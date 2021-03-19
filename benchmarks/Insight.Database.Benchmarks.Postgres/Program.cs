﻿using System;
using BenchmarkDotNet.Running;

namespace Insight.Database.Benchmarks.Postgres
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            _ = BenchmarkSwitcher
                .FromAssembly(typeof(InsightBenchmark).Assembly)
                .Run(args, new Config());

            Console.Read();
        }
    }
}