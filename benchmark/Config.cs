using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;

namespace Insight.Database.Benchmark
{
    public class Config : ManualConfig
    {
        public Config()
        {
            Add(ConsoleLogger.Default);
            Add(MarkdownExporter.GitHub);

            var md = MemoryDiagnoser.Default;
            Add(md);

            Add(TargetMethodColumn.Method);
            Add(TargetMethodColumn.Type);
            Add(StatisticColumn.Mean);
            Add(StatisticColumn.StdDev);
            Add(StatisticColumn.Error);
            Add(StatisticColumn.Min);
            Add(StatisticColumn.Max);
            Add(StatisticColumn.OperationsPerSecond);
            Add(DefaultColumnProviders.Metrics);

            Add(Job.ShortRun
             .WithLaunchCount(5)
             .WithWarmupCount(10)
             .WithMaxIterationCount(100)
             .WithIterationCount(10));

            Orderer = new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest);
            Options |= ConfigOptions.JoinSummary;
        }
    }
}
