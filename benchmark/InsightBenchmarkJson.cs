using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmark.Models;

namespace Insight.Database.Benchmark
{
    public class InsightBenchmarkJson : BaseBenchmark
    {
        protected SqlConnection connection;


        public static IEnumerable<Post> PostsJson()
        {
            yield return new Post() { Text = string.Concat("{\"Text\": \"", new string('x', 2000), "\"}"), CreationDate = DateTime.Now, LastChangeDate = DateTime.Now };
        }

        [Benchmark(Description = "Insert<T> json")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsJson))]
        public Post InsertPostJson(Post post) => connection.InsertSql("INSERT INTO PostJson (Child, CreationDate, LastChangeDate) VALUES (@Text, @CreationDate, @LastChangeDate) ", post);

        [Benchmark(Description = "Update<T> json")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsJson))]
        public Post UpdatePostJson(Post post)
        {
            post.Id = param;
            return connection.QueryOntoSql("UPDATE PostJson SET Child = @Text, CreationDate = @CreationDate, LastChangeDate = @LastChangeDate output inserted.* WHERE Id = @Id", post);
        }

        [Benchmark(Description = "Single json")]
        [BenchmarkCategory("Read")]
        public PostJson SinglePostJson() => connection.SingleSql<PostJson, ChildJson>("SELECT * FROM PostJson WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async json")]
        [BenchmarkCategory("Read")]
        public async Task<PostJson> SingleAsyncPostJson() => await connection.SingleSqlAsync<PostJson, ChildJson>("SELECT * FROM PostJson WHERE Id = @param", new { param });

        [Benchmark(Description = "Query<T> json")]
        [BenchmarkCategory("Read")]
        public PostJson QueryPostJson() => connection.QuerySql<PostJson, ChildJson>("SELECT * FROM PostJson WHERE Id = @param", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Async json")]
        [BenchmarkCategory("Read")]
        public async Task<PostJson> QueryAsyncPostJson()
        {
            var result = await connection.QuerySqlAsync<PostJson, ChildJson>("SELECT * FROM PostJson WHERE Id = @param", new { param });

            return result.FirstOrDefault();
        }

        [GlobalSetup]
        public void DbSetup()
        {
            connection = new SqlConnection(connectionString);
            SqlInsightDbProvider.RegisterProvider();
            connection.Open();

            var cmd = connection.CreateCommand();

            cmd.CommandText = $@"
                    SET NOCOUNT ON;
                    IF (OBJECT_ID('PostJson') IS NULL)
                    BEGIN
                        CREATE TABLE PostJson
                        (
                            Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
                            [Child] NVARCHAR(MAX) NOT NULL,
                            CreationDate DATETIME NOT NULL,
                            LastChangeDate DATETIME NOT NULL
                        );

                        ALTER TABLE [dbo].PostJson ADD CONSTRAINT [Text must be formatted as JSON object] CHECK  (IsJson([Child]) > 0)
                    END;

                    DELETE FROM dbo.PostJson;

                    DECLARE @i INT = 0;
                    WHILE (@i <= {iterations})
                    BEGIN
                        INSERT INTO	PostJson([Child], CreationDate, LastChangeDate)
                        SELECT (SELECT TOP 1 REPLICATE('x', 2000) [Text] FOR JSON PATH, WITHOUT_ARRAY_WRAPPER), SYSDATETIME(), SYSDATETIME();
                        SET @i = @i + 1;
                    END;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
        }

        [GlobalCleanup]
        public void DbCleanup()
        {
            var cmd = connection.CreateCommand();

            cmd.CommandText = "DROP TABLE PostJson;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
        }
    }
}
