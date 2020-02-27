using BenchmarkDotNet.Attributes;
using Insight.Database;
using Insight.Database.Structure;
using InsightBenchmark.Models;
using System.Data.SqlClient;
using System.Linq;

namespace Insight.Database.Benchmark
{
    [BenchmarkCategory("Insight.Database")]
    public class InsightBenchmark : BaseBenchmark
    {
        protected SqlConnection connection;
        private int param = 0;

        [Benchmark(Description = "Single")]
        public Post GetSinglePost() => connection.SingleSql<Post>("SELECT * FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Query<T>")]
        public Post GetQueryPost() => connection.QuerySql<Post>("SELECT * FROM Post WHERE Id = @param", new { param }).First();

        [Benchmark(Description = "Auto Interface Single")]
        public Post AutoInterfaceSinglePost() => connection.As<IPostRepository>().AutoISinglePost(param);

        [Benchmark(Description = "Auto Interface Query")]
        public Post AutoInterfaceQueryPost() => connection.As<IPostRepository>().AutoIQueryPost(param);

        [Benchmark(Description = "Query<T> Parent/Child Together")]
        public Post PostCommentTogether() =>
                connection.QuerySql("SELECT  * FROM Post p INNER JOIN Comment c ON p.Id = c.PostId WHERE p.Id = @param",
                new { param },
                Query.Returns(Together<Post, Comment>.Records)).First();

        [Benchmark(Description = "Query<T> Parent/Child")]
        public Post PostComment() =>
                connection.QuerySql("DECLARE @Id int = @param; SELECT  * FROM Post p WHERE Id = @Id; SELECT * FROM Comment c WHERE PostId = @Id;",
                new { param },
                Query.Returns<Post>()
                .ThenChildren(Some<Comment>.Records)).First();


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
            connection = new SqlConnection(ConnectionString);
            SqlInsightDbProvider.RegisterProvider();
            connection.Open();

            var cmd = connection.CreateCommand();

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

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
        }

        [GlobalCleanup]
        public void DbCleanup()
        {
            var cmd = connection.CreateCommand();

            cmd.CommandText = @"DROP TABLE Post; DROP TABLE Comment;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
        }
    }
}
