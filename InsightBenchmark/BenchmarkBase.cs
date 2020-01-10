using BenchmarkDotNet.Attributes;
using System.Data.SqlClient;

namespace InsightBenchmark
{
    [BenchmarkCategory("ORM")]
    public abstract class BenchmarkBase
    {
        protected SqlConnection _connection;
        protected int _counter;
        public readonly string ConnectionString;

        public BenchmarkBase(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}