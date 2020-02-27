using Insight.Database.Benchmark.Models;

namespace Insight.Database.Benchmark
{
    public interface IPostRepository
    {
        [Sql("SELECT * FROM Post WHERE Id = @param")]
        Post AutoIQueryPost(int param);

        [Sql("SELECT * FROM Post WHERE Id = @param")]
        Post AutoISinglePost(int param);


    }
}
