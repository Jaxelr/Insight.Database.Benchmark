# Insight.Database.Benchmark

[![Build status][build-svg]][build]

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Results for SQL Server Benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.301
  [Host]   : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  ShortRun : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Type=InsightBenchmark  

```
|                            Method |        Mean |      StdDev |     Error |        Min |         Max |     Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|------------:|----------:|-----------:|------------:|---------:|------:|------:|------:|----------:|
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |    389.9 μs |    33.81 μs |  18.24 μs |   339.9 μs |    455.3 μs | 2,565.05 |     - |     - |     - |  15.71 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |    393.1 μs |    45.20 μs |  23.76 μs |   342.0 μs |    542.9 μs | 2,543.58 |     - |     - |     - |  15.71 KB |
|                            Single |    416.3 μs |    51.25 μs |  25.96 μs |   353.4 μs |    555.1 μs | 2,402.19 |     - |     - |     - |  21.31 KB |
|           &#39;Single (Fast Expando)&#39; |    423.2 μs |    38.25 μs |  19.61 μs |   339.9 μs |    505.3 μs | 2,362.69 |     - |     - |     - |  15.73 KB |
| &#39;Auto Interface Single (dynamic)&#39; |    427.3 μs |    51.88 μs |  27.27 μs |   362.6 μs |    570.0 μs | 2,340.30 |     - |     - |     - |  16.03 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |    441.6 μs |   104.01 μs |  54.67 μs |   354.1 μs |    878.6 μs | 2,264.37 |     - |     - |     - |  16.03 KB |
|                          Query&lt;T&gt; |    450.6 μs |    62.20 μs |  32.28 μs |   373.8 μs |    643.6 μs | 2,219.45 |     - |     - |     - |   21.3 KB |
|           &#39;Auto Interface Single&#39; |    450.6 μs |    60.33 μs |  31.31 μs |   365.2 μs |    617.1 μs | 2,219.08 |     - |     - |     - |  21.62 KB |
|                &#39;Single (dynamic)&#39; |    455.4 μs |    54.01 μs |  28.39 μs |   362.7 μs |    599.4 μs | 2,195.76 |     - |     - |     - |  15.73 KB |
|            &#39;Auto Interface Query&#39; |    472.5 μs |   103.89 μs |  53.92 μs |   378.9 μs |    906.7 μs | 2,116.52 |     - |     - |     - |  21.62 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |    542.4 μs |    46.20 μs |  24.60 μs |   470.3 μs |    661.2 μs | 1,843.70 |     - |     - |     - |  19.45 KB |
|     &#39;Single Async (Fast Expando)&#39; |    558.1 μs |    54.27 μs |  29.28 μs |   462.5 μs |    689.1 μs | 1,791.79 |     - |     - |     - |  18.85 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |    562.8 μs |    48.54 μs |  26.54 μs |   488.0 μs |    686.7 μs | 1,776.72 |     - |     - |     - |  19.45 KB |
|          &#39;Single Async (dynamic)&#39; |    569.4 μs |    47.04 μs |  25.04 μs |   511.5 μs |    768.6 μs | 1,756.16 |     - |     - |     - |  18.85 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |    650.9 μs |   119.51 μs |  64.48 μs |   492.6 μs |  1,118.4 μs | 1,536.23 |     - |     - |     - |  25.04 KB |
|                    &#39;Single Async&#39; |  1,372.0 μs | 1,712.64 μs | 878.08 μs |   492.9 μs |  7,610.4 μs |   728.85 |     - |     - |     - |  24.44 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | 10,380.8 μs | 1,113.88 μs | 564.30 μs | 7,859.8 μs | 12,369.1 μs |    96.33 |     - |     - |     - |  43.68 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | 10,423.3 μs | 1,317.85 μs | 667.64 μs | 7,371.2 μs | 13,555.0 μs |    95.94 |     - |     - |     - |  43.72 KB |
|                                   |             |             |           |            |             |          |       |       |       |           |
|                         Insert&lt;T&gt; |    770.5 μs |   147.74 μs |  74.85 μs |   613.6 μs |  1,194.5 μs | 1,297.89 |     - |     - |     - |   6.46 KB |
|                         Update&lt;T&gt; |    847.1 μs |   154.73 μs |  83.48 μs |   695.1 μs |  1,625.7 μs | 1,180.53 |     - |     - |     - |  24.23 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; |    860.2 μs |    88.39 μs |  47.06 μs |   730.4 μs |  1,182.9 μs | 1,162.47 |     - |     - |     - |  10.09 KB |
|                 &#39;Update&lt;T&gt; Async&#39; |  1,081.4 μs |   330.04 μs | 171.30 μs |   851.4 μs |  2,689.5 μs |   924.72 |     - |     - |     - |  27.35 KB |

## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.

[build]: https://ci.appveyor.com/project/Jaxelr/insight-database-benchmark/branch/master?fullLog=true
[build-svg]: https://ci.appveyor.com/api/projects/status/u7f3dxi8aaw02l0y?svg=true
