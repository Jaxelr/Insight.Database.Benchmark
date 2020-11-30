# Insight.Database.Benchmark

[![Build status][build-svg]][build]

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Results for SQL Server Benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.100
  [Host]   : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  ShortRun : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

Type=InsightBenchmark  

```
|                                    Method |        Mean |      StdDev |       Error |        Min |         Max |     Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |------------:|------------:|------------:|-----------:|------------:|---------:|------:|------:|------:|----------:|
|              &#39;Single Procedure (dynamic)&#39; |    351.3 μs |    42.52 μs |    35.72 μs |   307.5 μs |    438.9 μs | 2,846.45 |     - |     - |     - |  11.52 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |    355.0 μs |    40.92 μs |    32.36 μs |   307.9 μs |    438.5 μs | 2,817.14 |     - |     - |     - |   11.8 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |    363.3 μs |    39.65 μs |    34.43 μs |   322.9 μs |    461.9 μs | 2,752.51 |     - |     - |     - |  12.81 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |    370.6 μs |    92.51 μs |    73.15 μs |   308.1 μs |    674.7 μs | 2,698.07 |     - |     - |     - |  12.49 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |    381.7 μs |   126.40 μs |   106.18 μs |   302.1 μs |    773.7 μs | 2,619.73 |     - |     - |     - |  11.79 KB |
|                    &#39;Auto Interface Query&#39; |    385.1 μs |    34.48 μs |    28.96 μs |   337.8 μs |    489.8 μs | 2,596.54 |     - |     - |     - |  14.55 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |    394.3 μs |    85.50 μs |    71.82 μs |   337.0 μs |    728.0 μs | 2,535.86 |     - |     - |     - |  13.09 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |    395.0 μs |   157.74 μs |   128.44 μs |   305.8 μs |    898.8 μs | 2,531.56 |     - |     - |     - |  11.79 KB |
|                                  Query&lt;T&gt; |    396.4 μs |    54.25 μs |    44.17 μs |   326.7 μs |    509.1 μs | 2,522.82 |     - |     - |     - |  14.23 KB |
|                   &#39;Single (Fast Expando)&#39; |    409.4 μs |   142.62 μs |   116.13 μs |   305.9 μs |    979.9 μs | 2,442.83 |     - |     - |     - |  12.51 KB |
|                                    Single |    412.8 μs |    64.06 μs |    55.63 μs |   335.6 μs |    582.4 μs | 2,422.28 |     - |     - |     - |  14.24 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |    416.8 μs |   153.74 μs |   129.14 μs |   329.8 μs |    928.4 μs | 2,399.31 |     - |     - |     - |  13.52 KB |
|                        &#39;Single Procedure&#39; |    457.8 μs |   173.57 μs |   133.48 μs |   327.8 μs |    992.7 μs | 2,184.58 |     - |     - |     - |  13.54 KB |
|                            Query&lt;(Tuple)&gt; |    458.6 μs |   130.41 μs |   106.19 μs |   369.0 μs |    882.6 μs | 2,180.73 |     - |     - |     - |  14.35 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |    479.3 μs |    50.40 μs |    43.77 μs |   424.8 μs |    597.8 μs | 2,086.22 |     - |     - |     - |  14.97 KB |
|                        &#39;Single (dynamic)&#39; |    480.9 μs |   246.22 μs |   206.84 μs |   321.9 μs |  1,383.4 μs | 2,079.37 |     - |     - |     - |  12.51 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |    493.4 μs |    66.01 μs |    55.45 μs |   415.4 μs |    676.4 μs | 2,026.70 |     - |     - |     - |  14.63 KB |
|                   &#39;Auto Interface Single&#39; |    493.8 μs |   287.71 μs |   241.69 μs |   333.3 μs |  1,619.5 μs | 2,024.99 |     - |     - |     - |  14.55 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |    513.9 μs |    85.75 μs |    69.82 μs |   421.9 μs |    750.2 μs | 1,946.09 |     - |     - |     - |  16.16 KB |
|                  &#39;Single Procedure Async&#39; |    515.7 μs |    71.05 μs |    59.69 μs |   437.2 μs |    664.9 μs | 1,939.24 |     - |     - |     - |  16.93 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |    516.6 μs |    67.50 μs |    56.70 μs |   441.8 μs |    685.2 μs | 1,935.81 |     - |     - |     - |  15.74 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |    521.1 μs |   136.13 μs |   114.35 μs |   437.4 μs |    964.5 μs | 1,918.89 |     - |     - |     - |  16.63 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |    545.1 μs |   199.52 μs |   162.46 μs |   422.1 μs |  1,297.9 μs | 1,834.65 |     - |     - |     - |  16.16 KB |
|             &#39;Single Async (Fast Expando)&#39; |    550.6 μs |   166.30 μs |   135.41 μs |   433.6 μs |  1,186.2 μs | 1,816.27 |     - |     - |     - |  15.62 KB |
|                          &#39;Single (Tuple)&#39; |    550.7 μs |   230.02 μs |   181.88 μs |   355.8 μs |  1,298.6 μs | 1,815.86 |     - |     - |     - |   14.3 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |    562.5 μs |   222.45 μs |   181.13 μs |   424.7 μs |  1,318.8 μs | 1,777.66 |     - |     - |     - |  15.18 KB |
|                    &#39;Single Async (Tuple)&#39; |    587.9 μs |   134.28 μs |   106.18 μs |   456.3 μs |  1,006.0 μs | 1,701.03 |     - |     - |     - |  17.74 KB |
|                  &#39;Single Async (dynamic)&#39; |    588.9 μs |   232.44 μs |   183.79 μs |   417.1 μs |  1,310.7 μs | 1,698.07 |     - |     - |     - |  15.05 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |    599.4 μs |   251.17 μs |   210.99 μs |   458.5 μs |  1,460.5 μs | 1,668.43 |     - |     - |     - |  17.34 KB |
|                            &#39;Single Async&#39; |    623.4 μs |   188.47 μs |   153.47 μs |   455.5 μs |  1,089.1 μs | 1,604.19 |     - |     - |     - |  16.79 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |    759.1 μs |   768.74 μs |   625.97 μs |   319.8 μs |  2,705.3 μs | 1,317.29 |     - |     - |     - |  12.49 KB |
|                    &#39;Single Async (Tuple)&#39; |    956.1 μs |   876.33 μs |   713.57 μs |   466.2 μs |  3,960.3 μs | 1,045.93 |     - |     - |     - |  17.52 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | 10,625.6 μs | 1,436.47 μs | 1,104.74 μs | 8,205.7 μs | 13,926.9 μs |    94.11 |     - |     - |     - |  34.75 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | 10,759.1 μs | 1,857.36 μs | 1,391.31 μs | 7,696.7 μs | 13,582.2 μs |    92.94 |     - |     - |     - |  36.59 KB |
|                                           |             |             |             |            |             |          |       |       |       |           |
|                                 Insert&lt;T&gt; |    757.4 μs |   417.76 μs |   330.33 μs |   559.4 μs |  2,451.6 μs | 1,320.36 |     - |     - |     - |   7.02 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; |    770.1 μs |    85.36 μs |    71.71 μs |   669.2 μs |    975.5 μs | 1,298.48 |     - |     - |     - |  10.49 KB |
|                                 Update&lt;T&gt; |    793.3 μs |   314.85 μs |   273.40 μs |   621.9 μs |  1,778.3 μs | 1,260.59 |     - |     - |     - |  17.23 KB |
|                         &#39;Update&lt;T&gt; Async&#39; |    913.5 μs |   216.82 μs |   176.55 μs |   741.2 μs |  1,577.7 μs | 1,094.73 |     - |     - |     - |  19.91 KB |


## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.

[build]: https://ci.appveyor.com/project/Jaxelr/insight-database-benchmark/branch/master?fullLog=true
[build-svg]: https://ci.appveyor.com/api/projects/status/u7f3dxi8aaw02l0y?svg=true
