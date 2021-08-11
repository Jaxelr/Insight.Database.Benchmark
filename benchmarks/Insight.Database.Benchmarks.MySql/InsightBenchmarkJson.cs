using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmarks.Models;
using Insight.Database.Providers.MySql;
using MySql.Data.MySqlClient;

namespace Insight.Database.Benchmarks.MySql
{
    public class InsightBenchmarkJson : BaseBenchmark
    {
        public static string Text { get; } = string.Concat("{\"Text\": \"", new string('x', 2000), "\"}");

        protected MySqlConnection connection;

        public static IEnumerable<Post> PostsJson()
        {
            yield return new Post() { Text = Text, CreationDate = DateTime.Now, LastChangeDate = DateTime.Now };
        }

        [Benchmark(Description = "Insert<T> json")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsJson))]
        public Post InsertPostJson(Post post) => connection.InsertSql("INSERT INTO PostJson (Child, CreationDate, LastChangeDate) VALUES (@Text, @CreationDate, @LastChangeDate); SELECT LAST_INSERT_ID() Id;", post);

        [Benchmark(Description = "Update<T> json")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsJson))]
        public Post UpdatePostJson(Post post)
        {
            post.Id = param;
            return connection.QueryOntoSql("UPDATE PostJson SET Child = @Text, CreationDate = @CreationDate, LastChangeDate = @LastChangeDate WHERE Id = @Id; SELECT LAST_INSERT_ID() Id;", post);
        }

        [Benchmark(Description = "Single json")]
        [BenchmarkCategory("Read")]
        public PostJson SinglePostJson() => connection.SingleSql<PostJson, ChildJson>("SELECT Id, CreationDate, LastChangeDate, Child FROM PostJson WHERE Id = @param", new { param });

        [Benchmark(Description = "Single Async json")]
        [BenchmarkCategory("Read")]
        public async Task<PostJson> SingleAsyncPostJson() => await connection.SingleSqlAsync<PostJson, ChildJson>("SELECT Id, CreationDate, LastChangeDate, Child FROM PostJson WHERE Id = @param", new { param });

        [Benchmark(Description = "Query<T> json")]
        [BenchmarkCategory("Read")]
        public PostJson QueryPostJson() => connection.QuerySql<PostJson, ChildJson>("SELECT Id, CreationDate, LastChangeDate, Child FROM PostJson WHERE Id = @param", new { param }).FirstOrDefault();

        [Benchmark(Description = "Query<T> Async json")]
        [BenchmarkCategory("Read")]
        public async Task<PostJson> QueryAsyncPostJson()
        {
            var result = await connection.QuerySqlAsync<PostJson, ChildJson>("SELECT Id, CreationDate, LastChangeDate, Child FROM PostJson WHERE Id = @param", new { param });

            return result.FirstOrDefault();
        }

        [GlobalSetup]
        public void DbSetup()
        {
            connection = new MySqlConnection(connectionString);
            MySqlInsightDbProvider.RegisterProvider();
            connection.Open();

            var cmd = connection.CreateCommand();

            cmd.CommandText = $@"
            DROP TABLE IF EXISTS PostJson;
            CREATE TABLE IF NOT EXISTS PostJson
            (
              Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
              Child JSON NOT NULL,
              CreationDate DATETIME NOT NULL,
              LastChangeDate DATETIME NOT NULL
            );

            DROP PROCEDURE IF EXISTS Populate_Post_Json;
            CREATE PROCEDURE Populate_Post_Json()
            BEGIN
                DECLARE iter INT DEFAULT 1;
                DECLARE postId INT DEFAULT 0;
                DECLARE ChildText JSON ;

                SET ChildText = '{Text}';

                WHILE(iter <= {iterations}) DO
                INSERT INTO PostJson(Child, CreationDate, LastChangeDate)
                SELECT ChildText, NOW(), NOW();

                SET iter = iter + 1;
                END WHILE;
            END;

            CALL Populate_Post_Json();
            DROP PROCEDURE IF EXISTS Populate_Post_Json;
            ";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
        }

        [GlobalCleanup]
        public void DbCleanup()
        {
            var cmd = connection.CreateCommand();

            cmd.CommandText = "DROP TABLE IF EXISTS PostJson;";

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
        }
    }
}
