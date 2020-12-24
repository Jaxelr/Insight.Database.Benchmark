using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Microsoft.Extensions.Configuration;

namespace Insight.Database.Benchmark
{
    [BenchmarkCategory("Insight.Database")]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BaseBenchmark
    {
        public static string ConnectionString;
        public static int Iterations;

        public BaseBenchmark()
        {
            string connEnv = Environment.GetEnvironmentVariable("Sql_Connection");

            var builder = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            ConnectionString = configuration.GetConnectionString("Default");

            //Overwrite with external configuration
            if (!string.IsNullOrEmpty(connEnv))
            {
                ConnectionString = connEnv;
            }

            Iterations = int.Parse(configuration.GetSection("Records").Value);
        }
    }
}
