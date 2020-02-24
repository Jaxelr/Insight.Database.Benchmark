using Insight.Database;
using InsightBenchmark.Models;

namespace InsightBenchmark
{
    public interface IPostRepository
    {
        [Sql("SELECT * FROM Post WHERE Id = @param")]
        Post AutoIQueryPost(int param);

        [Sql("SELECT * FROM Post WHERE Id = @param")]
        Post AutoISinglePost(int param);


    }
}