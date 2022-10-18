using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Insight.Database.Benchmarks.Models;
using Insight.Database.Structure;

namespace Insight.Database.Benchmarks.SqlServer;

public class InsightBenchmark : BaseBenchmark
{
    protected SqlConnection connection;

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

    [Benchmark(Description = "Single Procedure")]
    [BenchmarkCategory("Read")]
    public Post SinglePostProcedure() => connection.Single<Post>("SelectPost", new { param });

    [Benchmark(Description = "Single Procedure Async")]
    [BenchmarkCategory("Read")]
    public async Task<Post> SinglePostProcedureAsync() =>
        await connection.SingleAsync<Post>("SelectPost", new { param });

    [Benchmark(Description = "Single Procedure (dynamic)")]
    [BenchmarkCategory("Read")]
    public dynamic SinglePostProcedureDynamic() => connection.Single<dynamic>("SelectPost", new { param });

    [Benchmark(Description = "Single Procedure Async (dynamic)")]
    [BenchmarkCategory("Read")]
    public async Task<dynamic> SinglePostProcedureAsyncDynamic() =>
        await connection.SingleAsync<dynamic>("SelectPost", new { param });

    [Benchmark(Description = "Single Procedure (Fast Expando)")]
    [BenchmarkCategory("Read")]
    public dynamic SinglePostProcedureExpando() => connection.Single<FastExpando>("SelectPost", new { param });

    [Benchmark(Description = "Single Procedure Async (Fast Expando)")]
    [BenchmarkCategory("Read")]
    public async Task<dynamic> SinglePostProcedureAsyncExpando() =>
        await connection.SingleAsync<FastExpando>("SelectPost", new { param });

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

    [Benchmark(Description = "Query<T> Procedure")]
    [BenchmarkCategory("Read")]
    public Post QueryPostProcedure() => connection.Query<Post>("SelectPost", new { param }).FirstOrDefault();

    [Benchmark(Description = "Query<T> Procedure Async")]
    [BenchmarkCategory("Read")]
    public async Task<Post> QueryPostProcedureAsync()
    {
        var result = await connection.QueryAsync<Post>("SelectPost", new { param });

        return result.FirstOrDefault();
    }

    [Benchmark(Description = "Query<T> Procedure (dynamic)")]
    [BenchmarkCategory("Read")]
    public dynamic QueryPostProcedureDynamic() => connection.Query("SelectPost", new { param }).FirstOrDefault();

    [Benchmark(Description = "Query<T> Procedure Async (dynamic)")]
    [BenchmarkCategory("Read")]
    public async Task<dynamic> QueryPostProcedureAsyncDynamic()
    {
        var result = await connection.QueryAsync("SelectPost", new { param });

        return result.FirstOrDefault();
    }

    [Benchmark(Description = "Query<T> Procedure (Fast Expando)")]
    [BenchmarkCategory("Read")]
    public FastExpando QueryPostProcedureFastExpando() => connection.Query("SelectPost", new { param }).FirstOrDefault();

    [Benchmark(Description = "Query<T> Procedure Async (Fast Expando)")]
    [BenchmarkCategory("Read")]
    public async Task<FastExpando> QueryPostProcedureAsyncFastExpando()
    {
        var result = await connection.QueryAsync("SelectPost", new { param });

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
            connection.QuerySql("DECLARE @Id int = @param; SELECT  * FROM Post p WHERE Id = @Id; SELECT * FROM Comment c WHERE PostId = @Id;",
            new { param },
            Query.Returns<Post>()
            .ThenChildren(Some<Comment>.Records)).FirstOrDefault();

    [GlobalSetup]
    public void DbSetup()
    {
        connection = new SqlConnection(connectionString);
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
                            LastChangeDate DATETIME NOT NULL
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
                    WHILE (@i <= {iterations})
                    BEGIN
                        DECLARE @PostId INT;

                        INSERT INTO	Post([Text], CreationDate, LastChangeDate)
                        SELECT REPLICATE('x', 2000), SYSDATETIME(), SYSDATETIME();
                        SET @i = @i + 1;

                        SELECT @PostId = SCOPE_IDENTITY();

                        INSERT INTO	Comment([CommentText], CreationDate, PostId)
                        SELECT REPLICATE('x', 2000), SYSDATETIME(), @PostId UNION ALL
                        SELECT REPLICATE('x', 2000), SYSDATETIME(), @PostId
                    END;";

        cmd.Connection = connection;
        cmd.ExecuteNonQuery();

        cmd = connection.CreateCommand();
        cmd.CommandText = @"CREATE OR ALTER PROCEDURE SelectPost (@param int)
                    AS
                    BEGIN
                        SELECT * FROM Post WHERE Id = @param;
                    END;";

        cmd.Connection = connection;
        cmd.ExecuteNonQuery();
    }

    [GlobalCleanup]
    public void DbCleanup()
    {
        var cmd = connection.CreateCommand();

        cmd.CommandText = "DROP PROCEDURE IF EXISTS SelectPost; DROP TABLE IF EXISTS Post ; DROP TABLE IF EXISTS Comment;";

        cmd.Connection = connection;
        cmd.ExecuteNonQuery();

        connection.Close();
        connection.Dispose();
    }
}
