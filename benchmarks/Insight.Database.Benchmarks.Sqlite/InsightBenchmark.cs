using System;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmarks.Sqlite.Models;
using Insight.Database.Structure;

namespace Insight.Database.Benchmarks.Sqlite
{
    public class InsightBenchmark : BaseBenchmark
    {
        protected SQLiteConnection connection;

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
        public object SinglePostTuple() => connection.SingleSql<(int, string, DateTime, DateTime)>("SELECT Id [Item1], [Text] [Item2], CreationDate [Item3] FROM Post WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async (Tuple)")]
        [BenchmarkCategory("Read")]
        public async Task<object> SinglePostTupleAsync() => await
            connection.SingleSqlAsync<(int, string, DateTime, DateTime)>
            ("SELECT Id [Item1], [Text] [Item2], CreationDate [Item3] FROM Post WHERE Id = @param"
            , new { param });

        [Benchmark(Description = "Single Async (Fast Expando)")]
        [BenchmarkCategory("Read")]
        public async Task<dynamic> SinglePostAsyncExpando() =>
            await connection.SingleSqlAsync<FastExpando>("SELECT * FROM Post WHERE Id = @param", new { param });


        [Benchmark(Description = "Single Async (Tuple)")]
        [BenchmarkCategory("Read")]
        public async Task<object> QueryPostTupleAsync()
        {
            var result = await connection.QuerySqlAsync<(int, string, DateTime, DateTime)>
                ("SELECT Id [Item1], [Text] [Item2], CreationDate [Item3] FROM Post WHERE Id = @param", new { param });

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
            ("SELECT Id [Item1], [Text] [Item2], CreationDate [Item3] FROM Post WHERE Id = @param", new { param })
            .FirstOrDefault();

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
            connection = new SQLiteConnection(connectionString);
            SqlInsightDbProvider.RegisterProvider();
            connection.Open();

            var cmd = connection.CreateCommand();

            cmd.CommandText = $@"
                    DROP TABLE IF EXISTS Post;
                    DROP TABLE IF EXISTS Comment;	
        
                    CREATE TABLE IF NOT EXISTS [Post] 
                    (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                        [Text] VARCHAR NOT NULL,
                        CreationDate DATETIME NOT NULL,
                        LastChangeDate DATETIME NOT NULL
                    );
        
                    CREATE TABLE IF NOT EXISTS [Comment]
                    (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                        PostId INTEGER NOT NULL,
                        [CommentText] VARCHAR NOT NULL,
                        CreationDate DATETIME NOT NULL
                    );
        
                    DELETE FROM Comment;
                    DELETE FROM Post;


                    WITH RECURSIVE temp ([Text], [CreationDate], [LastChangeDate])
                    AS 
                    (
                        SELECT 
                            PRINTF('%.' || 2000 ||'c', 'X') [Text],
                            DATETIME('now') [CreationDate], 
                            DATETIME('now') [LastChangeDate]
                        UNION ALL
                        SELECT 
                            [Text], 
                            [CreationDate],
                            [LastChangeDate]
                        FROM temp
                        LIMIT {iterations}
    
                    )

                    INSERT INTO Post([Text], [LastChangeDate], [CreationDate])
                    SELECT [Text], [LastChangeDate], [CreationDate] FROM temp;

                    INSERT INTO Comment([PostId], [CommentText], [CreationDate])
                    SELECT Id PostId, PRINTF('%.' || 2000 ||'c', 'X') [Text], DATETIME('now') [CreationDate]
                    FROM Post
                    UNION ALL 
                    SELECT Id PostId, PRINTF('%.' || 2000 ||'c', 'X') [Text], DATETIME('now') [CreationDate]
                    FROM Post";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
        }

        [GlobalCleanup]
        public void DbCleanup()
        {
            var cmd = connection.CreateCommand();

            cmd.CommandText = "DROP TABLE IF EXISTS Post; DROP TABLE IF EXISTS Comment;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
        }
    }
}
