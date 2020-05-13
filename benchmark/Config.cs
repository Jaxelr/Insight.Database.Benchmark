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
            AddLogger(ConsoleLogger.Default);
            AddExporter(MarkdownExporter.GitHub);

            var md = MemoryDiagnoser.Default;
            AddDiagnoser(md);

            AddColumn(TargetMethodColumn.Method);
            AddColumn(TargetMethodColumn.Type);
            AddColumn(StatisticColumn.Mean);
            AddColumn(StatisticColumn.StdDev);
            AddColumn(StatisticColumn.Error);
            AddColumn(StatisticColumn.Min);
            AddColumn(StatisticColumn.Max);
            AddColumn(StatisticColumn.OperationsPerSecond);
            AddColumnProvider(DefaultColumnProviders.Metrics);

            AddJob(Job.ShortRun
             .WithLaunchCount(5)
             .WithWarmupCount(10)
             .WithMaxIterationCount(100)
             .WithIterationCount(10));

            Orderer = new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest);
            Options |= ConfigOptions.JoinSummary;
        }
    }
}
