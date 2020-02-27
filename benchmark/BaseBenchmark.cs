using Microsoft.Extensions.Configuration;
using System.IO;

namespace Insight.Database.Benchmark
{
    public class BaseBenchmark
    {
        public static string ConnectionString;
        public static int Iterations;

        public BaseBenchmark()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            ConnectionString = configuration.GetConnectionString("Default");
            Iterations = int.Parse(configuration.GetSection("Records").Value);
        }
    }
}
