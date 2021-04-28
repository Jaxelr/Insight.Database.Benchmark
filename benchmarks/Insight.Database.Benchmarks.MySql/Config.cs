using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;

namespace Insight.Database.Benchmarks.MySql
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

            if (System.Environment.GetEnvironmentVariable("LOCAL_BENCHMARK") is not null)
            {
                AddJob(Job.ShortRun
                 .WithLaunchCount(5)
                 .WithWarmupCount(5)
                 .WithMinIterationCount(5)
                 .WithMaxIterationCount(10)
                 .WithIterationCount(10));
            }
            else
            {
                AddJob(Job.ShortRun
                 .WithLaunchCount(1)
                 .WithWarmupCount(1)
                 .WithMinIterationCount(1)
                 .WithMaxIterationCount(5)
                 .WithIterationCount(1));
            }

            Orderer = new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest);
            Options |= ConfigOptions.JoinSummary;
        }
    }
}
