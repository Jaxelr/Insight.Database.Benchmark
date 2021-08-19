﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmarks.Models;

namespace Insight.Database.Benchmarks.Sqlite
{
    public class InsightBenchmarkWrite : InsightBenchmark
    {
        public static IEnumerable<Post> Posts()
        {
            yield return new Post() { Text = new string('x', 2000), CreationDate = DateTime.Now, LastChangeDate = DateTime.Now };
        }

        [Benchmark(Description = "Insert<T>")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(Posts))]
        public Post InsertPost(Post post) => connection.InsertSql("INSERT INTO Post (Text, CreationDate, LastChangeDate) VALUES (@Text, @CreationDate, @LastChangeDate); SELECT last_insert_rowid() as Id", post);

        [Benchmark(Description = "Insert<T> Async")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(Posts))]
        public async Task<Post> InsertPostAsync(Post post) =>
            await connection.InsertSqlAsync("INSERT INTO Post (Text, CreationDate, LastChangeDate) VALUES (@Text, @CreationDate, @LastChangeDate); ; SELECT last_insert_rowid() as Id", post);

        [Benchmark(Description = "Update<T>")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(Posts))]
        public Post UpdatePost(Post post)
        {
            post.Id = param;
            return connection.QueryOntoSql("UPDATE Post SET Text = @Text, CreationDate = @CreationDate, LastChangeDate = @LastChangeDate WHERE Id = @Id; SELECT last_insert_rowid() as Id", post);
        }

        [Benchmark(Description = "Update<T> Async")]
        [BenchmarkCategory("Write")]
        [ArgumentsSource(nameof(Posts))]
        public async Task<Post> UpdatePostAsync(Post post)
        {
            post.Id = param;
            return await connection.QueryOntoSqlAsync("UPDATE Post SET Text = @Text, CreationDate = @CreationDate, LastChangeDate = @LastChangeDate WHERE Id = @Id; SELECT last_insert_rowid() as Id", post);
        }
    }
}