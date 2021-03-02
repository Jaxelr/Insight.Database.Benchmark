using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmark.Models;

namespace Insight.Database.Benchmark
{
    public class InsightBenchmarkXml : BaseBenchmark
    {
        protected SqlConnection connection;


        public static IEnumerable<Post> PostsXml()
        {
            yield return new Post() { Text = string.Concat("<text>", new string('x', 2000), "</text>"), CreationDate = DateTime.Now, LastChangeDate = DateTime.Now };
        }

        [Benchmark(Description = "Insert<T> xml")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsXml))]
        public Post InsertPostXml(Post post) => connection.InsertSql("INSERT INTO PostXml (Child, CreationDate, LastChangeDate) VALUES (@Text, @CreationDate, @LastChangeDate) ", post);

        [Benchmark(Description = "Update<T> xml")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsXml))]
        public Post UpdatePostXml(Post post)
        {
            post.Id = param;
            return connection.QueryOntoSql("UPDATE PostXml SET Child = @Text, CreationDate = @CreationDate, LastChangeDate = @LastChangeDate output inserted.* WHERE Id = @Id", post);
        }

        [Benchmark(Description = "Single xml")]
        [BenchmarkCategory("Read")]
        public PostXml SinglePostXml() => connection.SingleSql<PostXml, ChildXml>("SELECT * FROM PostXml WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async xml")]
        [BenchmarkCategory("Read")]
        public async Task<PostXml> SingleAsyncPostXml() => await connection.SingleSqlAsync<PostXml, ChildXml>("SELECT * FROM PostXml WHERE Id = @param", new { param });

        [Benchmark(Description = "Query<T> xml")]
        [BenchmarkCategory("Read")]
        public PostXml QueryPostXml() => connection.QuerySql<PostXml, ChildXml>("SELECT * FROM PostXml WHERE Id = @param", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Async xml")]
        [BenchmarkCategory("Read")]
        public async Task<PostXml> QueryAsyncPostXml()
        {
            var result = await connection.QuerySqlAsync<PostXml, ChildXml>("SELECT * FROM PostXml WHERE Id = @param", new { param });

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
                    IF (OBJECT_ID('PostXml') IS NULL)
                    BEGIN
                        CREATE TABLE PostXml
                        (
                            Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
                            [Child] XML NOT NULL,
                            CreationDate DATETIME NOT NULL,
                            LastChangeDate DATETIME NOT NULL
                        );

                    END;

                    DELETE FROM dbo.PostXml;

                    DECLARE @i INT = 0;
                    WHILE (@i <= {iterations})
                    BEGIN
                        INSERT INTO	PostXml([Child], CreationDate, LastChangeDate)
                        SELECT CONCAT('<text>',REPLICATE('x', 2000),'</text>'), SYSDATETIME(), SYSDATETIME();
                        SET @i = @i + 1;
                    END;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
        }

        [GlobalCleanup]
        public void DbCleanup()
        {
            var cmd = connection.CreateCommand();

            cmd.CommandText = "DROP TABLE PostXml;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
        }
    }
}
