using System;
using Microsoft.Extensions.Configuration;

namespace Insight.Database.Benchmark
{
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
