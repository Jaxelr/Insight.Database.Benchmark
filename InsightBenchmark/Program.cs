using BenchmarkDotNet.Running;

namespace InsightBenchmark
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(InsightBenchmark).Assembly).Run(args, new Config());
        }
    }
}