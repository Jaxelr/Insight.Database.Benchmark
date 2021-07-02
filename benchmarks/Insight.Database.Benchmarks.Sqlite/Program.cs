﻿using BenchmarkDotNet.Running;

namespace Insight.Database.Benchmarks.Sqlite
{
    public static class Program
    {
        private static void Main(string[] args) =>
            _ = BenchmarkSwitcher
                .FromAssembly(typeof(BaseBenchmark).Assembly)
                .Run(args, new Config());
    }
}
