using System;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmarks.Models;
using Insight.Database.Providers.MySql;
using Insight.Database.Structure;
using MySql.Data.MySqlClient;

namespace Insight.Database.Benchmarks.MySql
{
    public class InsightBenchmark : BaseBenchmark
    {
        protected MySqlConnection connection;

        [Benchmark(Description = "Single")]
        [BenchmarkCategory("Read")]
        public Post SinglePost() => connection.SingleSql<Post>("SELECT * FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async")]
        [BenchmarkCategory("Read")]
        public async Task<Post> SinglePostAsync() =>
            await connection.SingleSqlAsync<Post>("SELECT * FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single (dynamic)")]
        [BenchmarkCategory("Read")]
        public dynamic SinglePostDynamic() => connection.SingleSql<dynamic>("SELECT * FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async (dynamic)")]
        [BenchmarkCategory("Read")]
        public async Task<dynamic> SinglePostAsyncDynamic() =>
            await connection.SingleSqlAsync<dynamic>("SELECT * FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public dynamic SinglePostExpando() => connection.SingleSql<FastExpando>("SELECT * FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single (Tuple)")]
        [BenchmarkCategory("Read")]
        public object SinglePostTuple() => connection.SingleSql<(int, string, DateTime, DateTime)>
            ("SELECT Id `Item1`, `Text` `Item2`, CreationDate `Item3` FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async (Tuple)")]
        [BenchmarkCategory("Read")]
        public async Task<object> SinglePostTupleAsync() => await
            connection.SingleSqlAsync<(int, string, DateTime, DateTime)>
            ("SELECT Id `Item1`, `Text` `Item2`, CreationDate `Item3` FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public async Task<dynamic> SinglePostAsyncExpando() =>
           await connection.SingleSqlAsync<FastExpando>("SELECT * FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Procedure")]
        [BenchmarkCategory("Read")]
        public Post SinglePostProcedure() => connection.Single<Post>("Select_Post", new { param });

        [Benchmark(Description = "Single Procedure Async")]
        [BenchmarkCategory("Read")]
        public async Task<Post> SinglePostProcedureAsync() =>
            await connection.SingleAsync<Post>("Select_Post", new { param });

        [Benchmark(Description = "Single Procedure (dynamic)")]
        [BenchmarkCategory("Read")]
        public dynamic SinglePostProcedureDynamic() => connection.Single<dynamic>("Select_Post", new { param });

        [Benchmark(Description = "Single Procedure Async (dynamic)")]
        [BenchmarkCategory("Read")]
        public async Task<dynamic> SinglePostProcedureAsyncDynamic() =>
            await connection.SingleAsync<dynamic>("Select_Post", new { param });

        [Benchmark(Description = "Single Procedure (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public dynamic SinglePostProcedureExpando() => connection.Single<FastExpando>("Select_Post", new { param });

        [Benchmark(Description = "Single Procedure Async (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public async Task<dynamic> SinglePostProcedureAsyncExpando() =>
            await connection.SingleAsync<FastExpando>("Select_Post", new { param });

        [Benchmark(Description = "Single Async (Tuple)")]
        [BenchmarkCategory("Read")]
        public async Task<object> QueryPostTupleAsync()
        {
            var result = await connection.QuerySqlAsync<(int, string, DateTime, DateTime)>
                ("SELECT Id `Item1`, `Text` `Item2`, CreationDate `Item3` FROM Post WHERE Id = @param", new { param });

            return result.FirstOrDefault();
        }

        [Benchmark(Description = "Query<T>")]
        [BenchmarkCategory("Read")]
        public Post QueryPost() => connection.QuerySql<Post>("SELECT * FROM Post WHERE Id = @param", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Async")]
        [BenchmarkCategory("Read")]
        public async Task<Post> QueryPostAsync()
        {
            var result = await connection.QuerySqlAsync<Post>("SELECT * FROM Post WHERE Id = @param", new { param });

            return result.FirstOrDefault();
        }

        [Benchmark(Description = "Query<T> (dynamic)")]
        [BenchmarkCategory("Read")]
        public dynamic QueryPostDynamic() => connection.QuerySql("SELECT * FROM Post WHERE Id = @param", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Async (dynamic)")]
        [BenchmarkCategory("Read")]
        public async Task<dynamic> QueryPostAsyncDynamic()
        {
            var result = await connection.QuerySqlAsync("SELECT * FROM Post WHERE Id = @param", new { param });

            return result.FirstOrDefault();
        }

        [Benchmark(Description = "Query<T> (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public FastExpando QueryPostFastExpando() => connection.QuerySql("SELECT * FROM Post WHERE Id = @param", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Async (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public async Task<FastExpando> QueryPostAsyncFastExpando()
        {
            var result = await connection.QuerySqlAsync("SELECT * FROM Post WHERE Id = @param", new { param });

            return result.FirstOrDefault();
        }

        [Benchmark(Description = "Query<(Tuple)>")]
        [BenchmarkCategory("Read")]
        public object QueryPostTuple() =>
            connection.QuerySql<(int, string, DateTime, DateTime)>
            ("SELECT Id `Item1`, `Text` `Item2`, CreationDate `Item3` FROM Post WHERE Id = @param", new { param })
            .FirstOrDefault();

        [Benchmark(Description = "Query<T> Procedure")]
        [BenchmarkCategory("Read")]
        public Post QueryPostProcedure() => connection.Query<Post>("Select_Post", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Procedure Async")]
        [BenchmarkCategory("Read")]
        public async Task<Post> QueryPostProcedureAsync()
        {
            var result = await connection.QueryAsync<Post>("Select_Post", new { param });

            return result.FirstOrDefault();
        }

        [Benchmark(Description = "Query<T> Procedure (dynamic)")]
        [BenchmarkCategory("Read")]
        public dynamic QueryPostProcedureDynamic() => connection.Query("Select_Post", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Procedure Async (dynamic)")]
        [BenchmarkCategory("Read")]
        public async Task<dynamic> QueryPostProcedureAsyncDynamic()
        {
            var result = await connection.QueryAsync("Select_Post", new { param });

            return result.FirstOrDefault();
        }

        [Benchmark(Description = "Query<T> Procedure (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public FastExpando QueryPostProcedureFastExpando() => connection.Query("Select_Post", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Procedure Async (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public async Task<FastExpando> QueryPostProcedureAsyncFastExpando()
        {
            var result = await connection.QueryAsync("Select_Post", new { param });

            return result.FirstOrDefault();
        }

        [Benchmark(Description = "Auto Interface Single")]
        [BenchmarkCategory("Read")]
        public Post AutoInterfaceSinglePost() => connection.As<IPostRepository>().AutoISinglePost(param);

        [Benchmark(Description = "Auto Interface Query")]
        [BenchmarkCategory("Read")]
        public Post AutoInterfaceQueryPost() => connection.As<IPostRepository>().AutoIQueryPost(param);

        [Benchmark(Description = "Auto Interface Single (dynamic)")]
        [BenchmarkCategory("Read")]
        public dynamic AutoInterfaceSingleDynamic() => connection.As<IPostRepository>().AutoISingleDynamic(param);

        [Benchmark(Description = "Auto Interface Query (dynamic)")]
        [BenchmarkCategory("Read")]
        public dynamic AutoInterfaceQueryDynamic() => connection.As<IPostRepository>().AutoIQueryDynamic(param);

        [Benchmark(Description = "Query<T> Parent/Child Together")]
        [BenchmarkCategory("Read")]
        public Post PostCommentTogether() =>
                connection.QuerySql("SELECT  * FROM Post p INNER JOIN Comment c ON p.Id = c.PostId WHERE p.Id = @param",
                new { param },
                Query.Returns(Together<Post, Comment>.Records)).FirstOrDefault();

        [Benchmark(Description = "Query<T> Parent/Child")]
        [BenchmarkCategory("Read")]
        public Post PostComment() =>
                connection.QuerySql("SELECT  * FROM Post p WHERE Id = @param; SELECT * FROM Comment c WHERE PostId = @param;",
                new { param },
                Query.Returns<Post>()
                .ThenChildren(Some<Comment>.Records)).FirstOrDefault();

        [GlobalSetup]
        public void DbSetup()
        {
            connection = new MySqlConnection(connectionString);
            MySqlInsightDbProvider.RegisterProvider();
            connection.Open();

            var cmd = connection.CreateCommand();

            cmd.CommandText = $@"
                    DROP TABLE IF EXISTS `Comment`;
                    DROP TABLE IF EXISTS Post;
                    CREATE TABLE IF NOT EXISTS Post
                    (
	                    Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
	                    `Text` TEXT NOT NULL,
	                    CreationDate DATETIME NOT NULL,
	                    LastChangeDate DATETIME NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS `Comment`
                    (
	                    Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
	                    PostId INT NOT NULL,
	                    CommentText TEXT NOT NULL,
	                    CreationDate TEXT NOT NULL
                    );

                    DROP PROCEDURE IF EXISTS Populate_Post_Comment;
                    CREATE PROCEDURE Populate_Post_Comment()
                    BEGIN
	                    DECLARE iter INT DEFAULT 1;
	                    DECLARE postId INT DEFAULT 0;

	                    WHILE (iter <= {iterations}) DO
		                    INSERT INTO Post(`Text`, CreationDate, LastChangeDate)
		                    SELECT REPEAT('x', 2000), NOW(), NOW();

		                    SELECT LAST_INSERT_ID() INTO postId;

		                    INSERT INTO `Comment`(CommentText, CreationDate, PostId)
		                    SELECT REPEAT('x', 2000), NOW(), postId UNION ALL
		                    SELECT REPEAT('x', 2000), NOW(), postId;

		                    SET iter = iter + 1;
	                    END WHILE;
                    END;

                    CALL populate_post_comment();
                    DROP PROCEDURE IF EXISTS populate_post_comment;";

            cmd.CommandTimeout = 0;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            cmd = connection.CreateCommand();
            cmd.CommandText = @"DROP PROCEDURE IF EXISTS Select_Post;
                    CREATE PROCEDURE Select_Post (IN param INT)
                    BEGIN
	                    SELECT * FROM Post WHERE Id = param;
                    END;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
        }

        [GlobalCleanup]
        public void DbCleanup()
        {
            var cmd = connection.CreateCommand();

            cmd.CommandText = "DROP PROCEDURE IF EXISTS Select_Post;DROP TABLE IF EXISTS `Comment`;DROP TABLE IF EXISTS Post;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
        }
    }
}
