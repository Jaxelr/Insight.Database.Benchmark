using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Microsoft.Extensions.Configuration;

namespace Insight.Database.Benchmarks.Postgres
{
    [BenchmarkCategory("Insight.Database")]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BaseBenchmark
    {
        protected int param;
        protected readonly string connectionString;
        protected readonly int iterations;

        public BaseBenchmark()
        {
            string connEnv = Environment.GetEnvironmentVariable("Postgres_Connection");

            var builder = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            connectionString = configuration.GetConnectionString("Default");

            //Overwrite with external configuration
            if (!string.IsNullOrEmpty(connEnv))
            {
                connectionString = connEnv;
            }

            iterations = int.Parse(configuration.GetSection("Records").Value);
        }

        [IterationSetup]
        public void Increment()
        {
            if (param > iterations)
                param = 0;
            param++;
        }
    }
}
