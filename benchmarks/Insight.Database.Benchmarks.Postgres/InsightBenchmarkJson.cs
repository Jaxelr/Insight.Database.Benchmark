﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmarks.Postgres.Models;
using Insight.Database.Providers.PostgreSQL;
using Npgsql;

namespace Insight.Database.Benchmarks.Postgres
{
    public class InsightBenchmarkJson : BaseBenchmark
    {
        protected NpgsqlConnection connection;

        public static string Text { get; } = string.Concat("{\"Text\": \"", new string ('x', 2000), "\"}");

        public static IEnumerable<Post> PostsJson()
        {
            yield return new Post() { Text = Text, CreationDate = DateTime.Now, LastChangeDate = DateTime.Now };
        }

        [Benchmark(Description = "Insert<T> json")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsJson))]
        public Post InsertPostJson(Post post) => connection.InsertSql("INSERT INTO PostJson (Child, CreationDate, LastChangeDate) VALUES (to_json(@Text::json), @CreationDate, @LastChangeDate) ", post);

        [Benchmark(Description = "Update<T> json")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(PostsJson))]
        public Post UpdatePostJson(Post post)
        {
            post.Id = param;
            return connection.QueryOntoSql("UPDATE PostJson SET Child = to_json(@Text::json), CreationDate = @CreationDate, LastChangeDate = @LastChangeDate WHERE Id = @Id Returning *", post);
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
            connection = new NpgsqlConnection(connectionString);
            PostgreSQLInsightDbProvider.RegisterProvider();
            connection.Open();

            var cmd = connection.CreateCommand();

            cmd.CommandText = $@"
                DROP TABLE IF EXISTS PostJson;

                CREATE TABLE IF NOT EXISTS PostJson
                (
                    Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
                    Child JSON NOT NULL,
                    CreationDate DATE NOT NULL,
                    LastChangeDate DATE NOT NULL
                );

                DO $$
                DECLARE iter integer;
                        PostId integer;
                        ChildField json;
                BEGIN
                    iter := 0;
                    ChildField := '{Text}';
                WHILE iter< {iterations}
                LOOP

                    INSERT INTO PostJson(Child, CreationDate, LastChangeDate)
                    SELECT ChildField, NOW(), NOW();

                    iter:= iter + 1;
                END LOOP;
                END $$;
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
