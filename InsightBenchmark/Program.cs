using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace InsightBenchmark
{
    internal class Program
    {
        public static string ConnectionString;
        public static int Iterations;

        private static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            ConnectionString = configuration.GetConnectionString("Default");
            Iterations = int.Parse(configuration.GetSection("Records").Value);

            BenchmarkSwitcher.FromAssembly(typeof(InsightBenchmark).Assembly).Run(args, new DebugInProcessConfig());
        }
    }
}