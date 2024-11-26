using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmarks.Models;

namespace Insight.Database.Benchmarks.Postgres;

public class InsightBenchmarkWrite : InsightBenchmark
{
    public static IEnumerable<Post> Posts()
    {
        yield return new Post() { Text = new string('x', 2000), CreationDate = DateTime.UtcNow, LastChangeDate = DateTime.UtcNow };
    }

    [Benchmark(Description = "Insert<T>")]
    [BenchmarkCategory("Write")]
    [ArgumentsSource(nameof(Posts))]
    public Post InsertPost(Post post) => connection.InsertSql("INSERT INTO Post (\"Text\", CreationDate, LastChangeDate) VALUES (@Text, @CreationDate, @LastChangeDate) ", post);

    [Benchmark(Description = "Insert<T> Async")]
    [BenchmarkCategory("Write")]
    [ArgumentsSource(nameof(Posts))]
    public async Task<Post> InsertPostAsync(Post post) =>
        await connection.InsertSqlAsync("INSERT INTO Post (\"Text\", CreationDate, LastChangeDate) VALUES (@Text, @CreationDate, @LastChangeDate)", post);

    [Benchmark(Description = "Update<T>")]
    [BenchmarkCategory("Write")]
    [ArgumentsSource(nameof(Posts))]
    public Post UpdatePost(Post post)
    {
        post.Id = param;
        return connection.QueryOntoSql("UPDATE Post SET \"Text\" = @Text, CreationDate = @CreationDate, LastChangeDate = @LastChangeDate WHERE Id = @Id Returning *", post);
    }

    [Benchmark(Description = "Update<T> Async")]
    [BenchmarkCategory("Write")]
    [ArgumentsSource(nameof(Posts))]
    public async Task<Post> UpdatePostAsync(Post post)
    {
        post.Id = param;
        return await connection.QueryOntoSqlAsync("UPDATE Post SET \"Text\" = @Text, CreationDate = @CreationDate, LastChangeDate = @LastChangeDate WHERE Id = @Id Returning *", post);
    }
}
