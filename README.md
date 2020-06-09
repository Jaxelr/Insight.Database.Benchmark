# Insight.Database.Benchmark

[![Build status][build-svg]][build]

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Results for SQL Server Benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]   : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

Type=InsightBenchmark  

```
|                            Method |       Mean |      StdDev |     Error |        Min |         Max |    Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|------------:|----------:|-----------:|------------:|--------:|------:|------:|------:|----------:|
|              &#39;Query&lt;T&gt; (dynamic)&#39; |   402.0 μs |    43.12 μs |  22.38 μs |   344.1 μs |    541.1 μs | 2,487.7 |     - |     - |     - |  15.71 KB |
|            &#39;Auto Interface Query&#39; |   409.3 μs |    40.18 μs |  21.39 μs |   364.7 μs |    515.9 μs | 2,443.0 |     - |     - |     - |  21.62 KB |
|                            Single |   409.9 μs |    83.47 μs |  43.87 μs |   324.8 μs |    711.7 μs | 2,439.7 |     - |     - |     - |  21.31 KB |
| &#39;Auto Interface Single (dynamic)&#39; |   411.4 μs |    71.71 μs |  37.69 μs |   336.0 μs |    725.9 μs | 2,430.9 |     - |     - |     - |  16.03 KB |
|                &#39;Single (dynamic)&#39; |   429.7 μs |   169.47 μs |  89.07 μs |   314.1 μs |  1,135.5 μs | 2,327.0 |     - |     - |     - |  15.73 KB |
|                          Query&lt;T&gt; |   431.9 μs |    52.93 μs |  28.95 μs |   359.6 μs |    640.7 μs | 2,315.2 |     - |     - |     - |   21.3 KB |
|           &#39;Auto Interface Single&#39; |   440.3 μs |    95.04 μs |  50.60 μs |   361.5 μs |    759.8 μs | 2,271.2 |     - |     - |     - |  21.62 KB |
|          &#39;Single Async (dynamic)&#39; |   539.5 μs |   137.45 μs |  72.24 μs |   429.4 μs |  1,029.0 μs | 1,853.6 |     - |     - |     - |  18.85 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |   575.3 μs |   414.05 μs | 217.62 μs |   332.6 μs |  2,003.9 μs | 1,738.3 |     - |     - |     - |  16.03 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |   576.4 μs |    81.90 μs |  44.79 μs |   449.0 μs |    817.1 μs | 1,735.0 |     - |     - |     - |  19.45 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |   577.8 μs |    83.92 μs |  43.56 μs |   466.3 μs |    859.0 μs | 1,730.7 |     - |     - |     - |  25.04 KB |
|                    &#39;Single Async&#39; |   597.3 μs |    66.70 μs |  36.99 μs |   460.3 μs |    794.2 μs | 1,674.1 |     - |     - |     - |  24.44 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | 8,253.5 μs |   737.15 μs | 373.45 μs | 7,288.9 μs | 10,302.1 μs |   121.2 |     - |     - |     - |  43.72 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | 8,879.5 μs | 1,168.22 μs | 584.96 μs | 7,544.4 μs | 13,160.1 μs |   112.6 |     - |     - |     - |  43.68 KB |
|                                   |            |             |           |            |             |         |       |       |       |           |
|                         Insert&lt;T&gt; |   774.5 μs |   124.14 μs |  63.65 μs |   617.0 μs |  1,187.6 μs | 1,291.2 |     - |     - |     - |   6.46 KB |
|                         Update&lt;T&gt; |   797.5 μs |    70.64 μs |  37.61 μs |   668.7 μs |    958.9 μs | 1,253.9 |     - |     - |     - |  24.23 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; |   972.1 μs |   499.49 μs | 259.25 μs |   682.0 μs |  3,526.8 μs | 1,028.7 |     - |     - |     - |  10.09 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | 1,003.8 μs |   180.36 μs |  94.79 μs |   839.0 μs |  1,743.0 μs |   996.2 |     - |     - |     - |  27.35 KB |


## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.

[build]: https://ci.appveyor.com/project/Jaxelr/insight-database-benchmark/branch/master?fullLog=true
[build-svg]: https://ci.appveyor.com/api/projects/status/5ljodk64tubam5i5?svg=true
