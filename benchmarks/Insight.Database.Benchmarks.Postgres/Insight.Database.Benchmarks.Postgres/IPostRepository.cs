﻿using Insight.Database.Benchmarks.Postgres.Models;

namespace Insight.Database.Benchmarks.Postgres
{
    public interface IPostRepository
    {
        [Sql("SELECT * FROM Post WHERE Id = @param")]
        Post AutoIQueryPost(int param);

        [Sql("SELECT * FROM Post WHERE Id = @param")]
        Post AutoISinglePost(int param);

        [Sql("SELECT * FROM Post WHERE Id = @param")]
        dynamic AutoIQueryDynamic(int param);

        [Sql("SELECT * FROM Post WHERE Id = @param")]
        dynamic AutoISingleDynamic(int param);
    }
}
