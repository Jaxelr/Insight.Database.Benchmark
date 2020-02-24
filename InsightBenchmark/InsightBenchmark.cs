using BenchmarkDotNet.Attributes;
using Insight.Database;
using Insight.Database.Structure;
using InsightBenchmark.Models;
using System.Data.SqlClient;
using System.Linq;

namespace InsightBenchmark
{
    [BenchmarkCategory("Insight.Database")]
    public class InsightBenchmark : BaseBenchmark
    {
        protected SqlConnection _connection;
        private int param = 0;

        [Benchmark(Description = "Single")]
        public Post GetSinglePost()
        {
            return _connection.SingleSql<Post>("SELECT * FROM Post WHERE Id = @param", new { param });
        }

        [Benchmark(Description = "Query<T>")]
        public Post GetQueryPost()
        {
            return _connection.QuerySql<Post>("SELECT * FROM Post WHERE Id = @param", new { param }).First();
        }

        [Benchmark(Description = "Auto Interface Single")]
        public Post AutoInterfaceSinglePost()
        {
            return _connection.As<IPostRepository>().AutoISinglePost(param);
        }

        [Benchmark(Description = "Auto Interface Query")]
        public Post AutoInterfaceQueryPost()
        {
            return _connection.As<IPostRepository>().AutoIQueryPost(param);
        }

        [Benchmark(Description = "Query<T> Parent/Child Together")]
        public Post PostCommentTogether()
        {
            return _connection.QuerySql("SELECT  * FROM Post p INNER JOIN Comment c ON p.Id = c.PostId", 
                new { param },
                Query.Returns(Together<Post, Comment>.Records)).First();
        }

        [Benchmark(Description = "Query<T> Parent/Child")]
        public Post PostComment()
        {
            return _connection.QuerySql("SELECT  * FROM Post p; SELECT * FROM Comment c;",
                new { param },
                Query.Returns<Post>()
                .ThenChildren(Some<Comment>.Records)).First();
        }


        [IterationSetup]
        public void Increment()
        {
            if (param > Iterations)
                param = 0;
            param++;
        }

        [GlobalSetup]
        public void DbSetup()
        {
            System.Console.Write($"Connection string: {ConnectionString}");

            _connection = new SqlConnection(ConnectionString);
            SqlInsightDbProvider.RegisterProvider();
            _connection.Open();

            var cmd = _connection.CreateCommand();

            cmd.CommandText = $@"
					SET NOCOUNT ON;
					IF (OBJECT_ID('Post') IS NULL)
					BEGIN
						CREATE TABLE Post
						(
							Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
							[Text] VARCHAR(MAX) NOT NULL,
							CreationDate DATETIME NOT NULL,
							LastChangeDate DATETIME NOT NULL,
							Counter1 INT,
							Counter2 INT,
							Counter3 INT,
							Counter4 INT,
							Counter5 INT,
							Counter6 INT,
							Counter7 INT,
							Counter8 INT,
							Counter9 INT
						);
					END;
					IF (OBJECT_ID('Comment') IS NULL)
					BEGIN
						CREATE TABLE Comment
						(
							Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
							PostId INT NOT NULL,
							[CommentText] VARCHAR(MAX) NOT NULL,
							CreationDate DATETIME NOT NULL
						);
					END;

					DELETE FROM dbo.Post;
					DELETE FROM dbo.Comment;

					DECLARE @i INT = 0;
					WHILE (@i <= {Iterations})
					BEGIN
						DECLARE @PostId INT;

						INSERT INTO	Post([Text], CreationDate, LastChangeDate)
						VALUES (REPLICATE('x', 2000), SYSDATETIME(), SYSDATETIME());
						SET @i = @i + 1;

						SELECT @PostId = SCOPE_IDENTITY();

						INSERT INTO	Comment([CommentText], CreationDate, PostId)
						SELECT REPLICATE('x', 2000), SYSDATETIME(), @PostId UNION ALL
						SELECT REPLICATE('x', 2000), SYSDATETIME(), @PostId
					END;
                ";

            cmd.Connection = _connection;
            cmd.ExecuteNonQuery();
        }

        [GlobalCleanup]
        public void DbCleanup()
        {
            var cmd = _connection.CreateCommand();

            cmd.CommandText = @"DROP TABLE Post; DROP TABLE Comment;";

            cmd.Connection = _connection;
            cmd.ExecuteNonQuery();

            _connection.Close();
            _connection.Dispose();
        }
    }
}