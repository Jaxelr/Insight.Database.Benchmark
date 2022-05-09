# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]   : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  ShortRun : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT


```
|                            Method |                  Type |       Mean |    StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   140.8 μs |  26.25 μs |  13.62 μs |   136.9 μs |   110.5 μs |   234.8 μs | 7,102.4 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   142.0 μs |  18.05 μs |   9.61 μs |   137.8 μs |   120.6 μs |   184.7 μs | 7,041.7 |     10 KB |
|                            Single | InsightBenchmarkWrite |   143.8 μs |  21.74 μs |  11.02 μs |   139.7 μs |   117.0 μs |   199.0 μs | 6,955.5 |     10 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   144.5 μs |  17.47 μs |   9.18 μs |   141.8 μs |   116.3 μs |   199.8 μs | 6,921.3 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   147.3 μs |  22.35 μs |  11.75 μs |   145.2 μs |   118.8 μs |   197.9 μs | 6,790.4 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   147.4 μs |  27.55 μs |  15.07 μs |   134.1 μs |   119.1 μs |   212.9 μs | 6,786.1 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   148.0 μs |  17.12 μs |   8.88 μs |   144.8 μs |   120.9 μs |   200.4 μs | 6,757.8 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   148.9 μs |  17.39 μs |   9.26 μs |   150.9 μs |   121.8 μs |   186.7 μs | 6,717.8 |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   151.1 μs |  21.72 μs |  11.27 μs |   143.4 μs |   123.6 μs |   215.0 μs | 6,618.0 |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   151.5 μs |  23.54 μs |  11.93 μs |   148.6 μs |   118.7 μs |   248.8 μs | 6,600.6 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   152.3 μs |  20.98 μs |  10.39 μs |   150.9 μs |   124.8 μs |   211.2 μs | 6,567.6 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   152.3 μs |  24.43 μs |  12.68 μs |   143.8 μs |   124.7 μs |   233.6 μs | 6,565.5 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   153.1 μs |  24.52 μs |  12.89 μs |   151.9 μs |   115.6 μs |   227.7 μs | 6,529.9 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   153.5 μs |  25.85 μs |  13.26 μs |   143.9 μs |   118.8 μs |   203.8 μs | 6,516.4 |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   153.5 μs |  33.02 μs |  16.93 μs |   147.7 μs |   115.1 μs |   268.3 μs | 6,513.6 |     10 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   153.6 μs |  21.68 μs |  10.98 μs |   148.2 μs |   120.6 μs |   205.1 μs | 6,508.8 |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   154.3 μs |  28.97 μs |  14.50 μs |   144.8 μs |   121.7 μs |   256.5 μs | 6,482.3 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   154.6 μs |  29.98 μs |  15.01 μs |   139.4 μs |   120.8 μs |   237.4 μs | 6,468.0 |     10 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   154.9 μs |  30.77 μs |  15.97 μs |   145.9 μs |   118.7 μs |   269.5 μs | 6,456.5 |     10 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   155.3 μs |  22.51 μs |  11.54 μs |   150.7 μs |   125.0 μs |   239.3 μs | 6,437.2 |     11 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   156.2 μs |  32.69 μs |  16.76 μs |   142.2 μs |   124.0 μs |   266.8 μs | 6,403.2 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   156.4 μs |  20.70 μs |  11.02 μs |   154.3 μs |   121.2 μs |   211.5 μs | 6,394.5 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   157.0 μs |  25.40 μs |  13.18 μs |   150.1 μs |   121.2 μs |   233.9 μs | 6,370.7 |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   157.7 μs |  22.84 μs |  11.44 μs |   156.5 μs |   125.1 μs |   233.7 μs | 6,342.1 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   157.7 μs |  26.21 μs |  13.44 μs |   145.4 μs |   123.5 μs |   219.7 μs | 6,339.3 |     10 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   157.8 μs |  28.58 μs |  14.48 μs |   145.2 μs |   124.8 μs |   228.7 μs | 6,335.2 |     10 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   158.4 μs |  25.30 μs |  12.97 μs |   149.3 μs |   126.7 μs |   233.1 μs | 6,311.7 |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   159.7 μs |  19.07 μs |  10.02 μs |   153.1 μs |   136.6 μs |   218.0 μs | 6,263.0 |     11 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   159.7 μs |  34.13 μs |  17.71 μs |   152.2 μs |   126.0 μs |   299.4 μs | 6,261.2 |     10 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   161.0 μs |  38.05 μs |  20.26 μs |   153.8 μs |   119.6 μs |   318.1 μs | 6,210.0 |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   161.1 μs |  17.24 μs |   9.18 μs |   157.7 μs |   135.4 μs |   201.1 μs | 6,206.8 |     11 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   161.6 μs |  19.09 μs |   9.91 μs |   156.8 μs |   128.9 μs |   203.4 μs | 6,187.2 |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   162.5 μs |  23.48 μs |  12.04 μs |   157.9 μs |   134.1 μs |   221.4 μs | 6,153.2 |     11 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   163.7 μs |  25.50 μs |  13.23 μs |   158.2 μs |   134.0 μs |   254.4 μs | 6,107.4 |     11 KB |
|                            Single |      InsightBenchmark |   166.8 μs |  39.29 μs |  20.65 μs |   159.8 μs |   124.0 μs |   310.3 μs | 5,994.6 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   168.9 μs |  61.85 μs |  31.71 μs |   146.1 μs |   115.5 μs |   388.1 μs | 5,920.5 |     10 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   169.4 μs |  19.79 μs |   9.91 μs |   167.6 μs |   127.3 μs |   224.3 μs | 5,904.5 |     11 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   173.3 μs |  36.01 μs |  18.46 μs |   165.1 μs |   129.2 μs |   291.3 μs | 5,769.7 |     10 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   175.0 μs |  29.65 μs |  14.84 μs |   165.3 μs |   131.3 μs |   257.8 μs | 5,713.4 |     11 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   180.7 μs |  39.99 μs |  20.02 μs |   165.7 μs |   122.3 μs |   283.1 μs | 5,533.3 |     10 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 3,285.8 μs | 169.67 μs |  84.96 μs | 3,299.9 μs | 3,000.2 μs | 3,698.8 μs |   304.3 |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3,315.8 μs | 264.24 μs | 132.31 μs | 3,284.0 μs | 2,932.7 μs | 4,289.0 μs |   301.6 |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 3,536.2 μs | 230.92 μs | 116.99 μs | 3,509.6 μs | 3,138.8 μs | 4,148.9 μs |   282.8 |     25 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3,654.4 μs | 238.42 μs | 119.38 μs | 3,660.8 μs | 3,177.5 μs | 4,167.6 μs |   273.6 |     25 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,598.4 μs | 296.90 μs | 150.41 μs | 4,520.6 μs | 4,208.6 μs | 5,648.6 μs |   217.5 |     10 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 4,619.5 μs | 312.02 μs | 156.24 μs | 4,530.1 μs | 4,144.4 μs | 5,645.1 μs |   216.5 |      9 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,801.2 μs | 205.54 μs | 106.68 μs | 4,786.6 μs | 4,453.4 μs | 5,260.5 μs |   208.3 |      9 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 4,820.1 μs | 315.11 μs | 157.78 μs | 4,802.2 μs | 4,297.1 μs | 5,579.9 μs |   207.5 |      8 KB |
