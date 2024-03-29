﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Microsoft.Extensions.Configuration;

namespace Insight.Database.Benchmarks;

[BenchmarkCategory("Insight.Database")]

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class BaseBenchmark
{
    protected int param;
    protected readonly string connectionString;
    protected readonly int iterations;

    public BaseBenchmark()
    {
        var builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

        IConfigurationRoot configuration = builder.Build();

        connectionString = configuration.GetConnectionString("Default");
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
