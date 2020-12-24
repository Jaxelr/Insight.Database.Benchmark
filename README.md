# Insight.Database.Benchmark

[![Build status][build-svg]][build]

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Results for SQL Server Benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.101
  [Host]   : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  ShortRun : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                                    Method |                 Type |       Mean |      StdDev |     Error |        Min |         Max |    Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |--------------------- |-----------:|------------:|----------:|-----------:|------------:|--------:|------:|------:|------:|----------:|
|                      &#39;Query&lt;T&gt; Procedure&#39; |     InsightBenchmark |   382.5 μs |    42.01 μs |  35.29 μs |   324.7 μs |    461.8 μs | 2,614.7 |     - |     - |     - |  13.52 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |     InsightBenchmark |   383.0 μs |    47.68 μs |  37.70 μs |   317.1 μs |    507.2 μs | 2,611.1 |     - |     - |     - |  11.79 KB |
|                        &#39;Single Procedure&#39; |     InsightBenchmark |   388.9 μs |    47.16 μs |  38.40 μs |   322.5 μs |    481.3 μs | 2,571.6 |     - |     - |     - |  13.54 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |     InsightBenchmark |   390.2 μs |    54.12 μs |  41.62 μs |   309.9 μs |    485.9 μs | 2,563.0 |     - |     - |     - |   11.8 KB |
|                   &#39;Single (Fast Expando)&#39; |     InsightBenchmark |   391.4 μs |    37.05 μs |  32.17 μs |   309.0 μs |    469.9 μs | 2,554.7 |     - |     - |     - |  11.95 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |     InsightBenchmark |   397.3 μs |    51.55 μs |  44.76 μs |   314.0 μs |    525.3 μs | 2,517.1 |     - |     - |     - |  11.79 KB |
|              &#39;Single Procedure (dynamic)&#39; |     InsightBenchmark |   402.1 μs |    57.65 μs |  48.43 μs |   325.0 μs |    574.6 μs | 2,487.1 |     - |     - |     - |   11.8 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |     InsightBenchmark |   412.4 μs |    50.97 μs |  40.30 μs |   329.0 μs |    517.2 μs | 2,424.7 |     - |     - |     - |  12.81 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |     InsightBenchmark |   416.7 μs |    42.34 μs |  34.47 μs |   338.6 μs |    516.4 μs | 2,399.7 |     - |     - |     - |  12.49 KB |
|                   &#39;Auto Interface Single&#39; |     InsightBenchmark |   417.7 μs |    48.73 μs |  38.53 μs |   336.9 μs |    542.1 μs | 2,394.3 |     - |     - |     - |  14.55 KB |
|                        &#39;Single (dynamic)&#39; |     InsightBenchmark |   421.5 μs |    63.80 μs |  49.06 μs |   318.9 μs |    542.3 μs | 2,372.3 |     - |     - |     - |  12.51 KB |
|                    &#39;Auto Interface Query&#39; |     InsightBenchmark |   424.7 μs |    50.46 μs |  39.90 μs |   336.8 μs |    512.7 μs | 2,354.8 |     - |     - |     - |  14.55 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |     InsightBenchmark |   426.2 μs |    48.93 μs |  38.69 μs |   349.9 μs |    539.6 μs | 2,346.6 |     - |     - |     - |  12.49 KB |
|                                  Query&lt;T&gt; |     InsightBenchmark |   430.2 μs |    47.53 μs |  38.70 μs |   333.1 μs |    500.5 μs | 2,324.4 |     - |     - |     - |  14.23 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |     InsightBenchmark |   435.1 μs |    67.85 μs |  52.18 μs |   340.0 μs |    579.8 μs | 2,298.6 |     - |     - |     - |  13.09 KB |
|                            Query&lt;(Tuple)&gt; |     InsightBenchmark |   454.8 μs |    40.94 μs |  35.55 μs |   369.6 μs |    514.1 μs | 2,198.6 |     - |     - |     - |  14.63 KB |
|                           &#39;Query&lt;T&gt; json&#39; | InsightBenchmarkJson |   465.5 μs |    48.57 μs |  38.41 μs |   388.8 μs |    557.8 μs | 2,148.3 |     - |     - |     - |  41.61 KB |
|                          &#39;Single (Tuple)&#39; |     InsightBenchmark |   489.6 μs |    93.59 μs |  74.00 μs |   356.2 μs |    704.5 μs | 2,042.6 |     - |     - |     - |  14.58 KB |
|                             &#39;Single json&#39; | InsightBenchmarkJson |   497.8 μs |    68.03 μs |  55.40 μs |   409.8 μs |    714.8 μs | 2,008.8 |     - |     - |     - |  41.63 KB |
|                                    Single |     InsightBenchmark |   518.7 μs |   339.70 μs | 268.60 μs |   343.1 μs |  1,944.8 μs | 1,928.0 |     - |     - |     - |  14.24 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |     InsightBenchmark |   552.5 μs |    62.69 μs |  52.67 μs |   424.4 μs |    650.4 μs | 1,809.9 |     - |     - |     - |  14.33 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |     InsightBenchmark |   552.8 μs |    67.29 μs |  56.53 μs |   448.0 μs |    664.4 μs | 1,809.0 |     - |     - |     - |  16.21 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |     InsightBenchmark |   555.6 μs |    58.65 μs |  45.11 μs |   447.9 μs |    655.3 μs | 1,799.9 |     - |     - |     - |  14.89 KB |
|             &#39;Single Async (Fast Expando)&#39; |     InsightBenchmark |   557.7 μs |    53.31 μs |  44.78 μs |   480.5 μs |    661.2 μs | 1,793.1 |     - |     - |     - |  15.05 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |     InsightBenchmark |   576.6 μs |    82.24 μs |  66.96 μs |   450.3 μs |    806.1 μs | 1,734.2 |     - |     - |     - |  17.19 KB |
|                            &#39;Single Async&#39; |     InsightBenchmark |   577.3 μs |    54.08 μs |  44.03 μs |   456.0 μs |    694.3 μs | 1,732.1 |     - |     - |     - |  16.78 KB |
|                  &#39;Single Async (dynamic)&#39; |     InsightBenchmark |   579.6 μs |    53.29 μs |  46.28 μs |   483.1 μs |    697.4 μs | 1,725.2 |     - |     - |     - |  15.61 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |     InsightBenchmark |   587.5 μs |    89.48 μs |  72.86 μs |   484.1 μs |    856.0 μs | 1,702.1 |     - |     - |     - |  14.63 KB |
|                  &#39;Single Procedure Async&#39; |     InsightBenchmark |   590.0 μs |    92.83 μs |  77.98 μs |   497.4 μs |    910.5 μs | 1,695.0 |     - |     - |     - |  16.08 KB |
|                    &#39;Single Async (Tuple)&#39; |     InsightBenchmark |   607.0 μs |    65.82 μs |  52.04 μs |   495.6 μs |    705.5 μs | 1,647.5 |     - |     - |     - |  18.02 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |     InsightBenchmark |   630.2 μs |    85.27 μs |  74.04 μs |   510.3 μs |    912.4 μs | 1,586.8 |     - |     - |     - |  14.63 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |     InsightBenchmark |   638.5 μs |   159.43 μs | 126.06 μs |   476.4 μs |  1,270.3 μs | 1,566.3 |     - |     - |     - |  15.59 KB |
|                    &#39;Single Async (Tuple)&#39; |     InsightBenchmark |   666.7 μs |   108.59 μs |  88.42 μs |   500.9 μs |    996.4 μs | 1,499.9 |     - |     - |     - |   17.8 KB |
|                       &#39;Single Async json&#39; | InsightBenchmarkJson |   672.7 μs |    97.25 μs |  81.69 μs |   545.9 μs |    977.0 μs | 1,486.6 |     - |     - |     - |  44.45 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |     InsightBenchmark |   678.2 μs |   142.32 μs | 115.88 μs |   590.1 μs |  1,205.5 μs | 1,474.5 |     - |     - |     - |  16.77 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; | InsightBenchmarkJson |   689.4 μs |   136.81 μs | 114.92 μs |   555.5 μs |  1,222.8 μs | 1,450.6 |     - |     - |     - |  44.71 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |     InsightBenchmark | 9,157.7 μs |   996.63 μs | 788.05 μs | 7,541.3 μs | 10,655.6 μs |   109.2 |     - |     - |     - |  36.59 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |     InsightBenchmark | 9,488.2 μs | 1,273.74 μs | 954.13 μs | 7,605.1 μs | 11,944.6 μs |   105.4 |     - |     - |     - |  34.75 KB |
|                                           |                      |            |             |           |            |             |         |       |       |       |           |
|                                 Insert&lt;T&gt; |     InsightBenchmark |   778.6 μs |    73.30 μs |  61.57 μs |   700.1 μs |    963.6 μs | 1,284.3 |     - |     - |     - |   7.59 KB |
|                          &#39;Insert&lt;T&gt; json&#39; | InsightBenchmarkJson |   802.5 μs |    65.05 μs |  54.64 μs |   691.1 μs |    904.0 μs | 1,246.2 |     - |     - |     - |   6.46 KB |
|                                 Update&lt;T&gt; |     InsightBenchmark |   835.0 μs |   229.29 μs | 192.61 μs |   711.5 μs |  1,641.3 μs | 1,197.6 |     - |     - |     - |  17.79 KB |
|                         &#39;Update&lt;T&gt; Async&#39; |     InsightBenchmark |   968.1 μs |   127.10 μs | 106.77 μs |   754.3 μs |  1,245.7 μs | 1,033.0 |     - |     - |     - |  20.46 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; |     InsightBenchmark |   979.1 μs |   163.31 μs | 129.13 μs |   782.9 μs |  1,292.3 μs | 1,021.3 |     - |     - |     - |  10.77 KB |
|                          &#39;Update&lt;T&gt; json&#39; | InsightBenchmarkJson |   993.1 μs |   356.32 μs | 274.03 μs |   674.3 μs |  1,978.3 μs | 1,006.9 |     - |     - |     - |  11.32 KB |

## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.

[build]: https://ci.appveyor.com/project/Jaxelr/insight-database-benchmark/branch/master?fullLog=true
[build-svg]: https://ci.appveyor.com/api/projects/status/u7f3dxi8aaw02l0y?svg=true
