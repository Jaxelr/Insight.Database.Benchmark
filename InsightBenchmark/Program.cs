using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace InsightBenchmark
{
    internal class Program
    {
        public static string ConnectionString;

        private static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            ConnectionString = configuration.GetConnectionString("Default");

            BenchmarkSwitcher.FromAssembly(typeof(InsightBenchmark).Assembly).Run(args, new DebugInProcessConfig());
        }
    }
}