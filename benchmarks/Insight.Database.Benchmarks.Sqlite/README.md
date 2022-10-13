# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT


```
|                            Method |                  Type |       Mean |      StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   143.0 μs |    17.37 μs |   8.91 μs |   141.1 μs |   118.2 μs |   181.7 μs | 6,994.0 |     10 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   149.5 μs |    17.44 μs |   8.94 μs |   147.3 μs |   125.0 μs |   207.6 μs | 6,689.2 |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   150.7 μs |    26.26 μs |  14.36 μs |   143.8 μs |   119.1 μs |   244.5 μs | 6,634.1 |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   152.9 μs |    25.47 μs |  13.06 μs |   145.4 μs |   117.5 μs |   221.6 μs | 6,538.1 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   156.4 μs |    33.58 μs |  17.43 μs |   145.2 μs |   126.1 μs |   285.4 μs | 6,395.8 |     10 KB |
|                            Single | InsightBenchmarkWrite |   156.5 μs |    32.96 μs |  17.78 μs |   140.0 μs |   124.0 μs |   232.3 μs | 6,387.9 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   157.3 μs |    29.61 μs |  15.00 μs |   151.1 μs |   118.7 μs |   244.7 μs | 6,359.2 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   158.6 μs |    32.42 μs |  16.83 μs |   149.4 μs |   129.2 μs |   318.6 μs | 6,305.4 |     10 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   158.9 μs |    17.78 μs |   9.35 μs |   156.9 μs |   133.5 μs |   212.6 μs | 6,292.7 |     11 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   159.1 μs |    23.55 μs |  12.07 μs |   155.0 μs |   128.5 μs |   232.0 μs | 6,287.1 |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   161.0 μs |    31.44 μs |  16.12 μs |   145.5 μs |   126.7 μs |   255.2 μs | 6,211.0 |     10 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   161.5 μs |    33.52 μs |  16.98 μs |   150.1 μs |   126.8 μs |   286.8 μs | 6,191.8 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   165.0 μs |    18.86 μs |   9.67 μs |   165.1 μs |   134.0 μs |   213.3 μs | 6,059.6 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   165.3 μs |    24.07 μs |  12.34 μs |   159.1 μs |   129.1 μs |   235.3 μs | 6,049.7 |     10 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   165.3 μs |    51.52 μs |  26.74 μs |   138.6 μs |   119.3 μs |   319.9 μs | 6,048.1 |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   165.4 μs |    38.28 μs |  19.39 μs |   156.1 μs |   121.4 μs |   274.8 μs | 6,044.6 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   165.5 μs |    37.93 μs |  19.45 μs |   153.1 μs |   126.6 μs |   292.0 μs | 6,041.2 |     10 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   167.3 μs |    23.69 μs |  12.78 μs |   163.4 μs |   135.7 μs |   249.1 μs | 5,975.7 |     11 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   167.8 μs |    42.47 μs |  22.91 μs |   154.1 μs |   118.4 μs |   265.9 μs | 5,959.1 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   170.8 μs |    35.16 μs |  18.03 μs |   171.4 μs |   124.2 μs |   269.6 μs | 5,853.6 |     10 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   172.1 μs |    32.78 μs |  16.81 μs |   163.3 μs |   125.0 μs |   245.1 μs | 5,809.5 |     10 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   174.1 μs |    29.19 μs |  14.62 μs |   177.6 μs |   128.0 μs |   255.4 μs | 5,745.2 |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   176.6 μs |    41.44 μs |  21.51 μs |   165.9 μs |   136.3 μs |   319.1 μs | 5,662.4 |     11 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   177.2 μs |    36.94 μs |  18.50 μs |   169.3 μs |   134.1 μs |   277.6 μs | 5,643.7 |     11 KB |
|                            Single |      InsightBenchmark |   185.1 μs |    78.15 μs |  40.07 μs |   158.9 μs |   121.2 μs |   385.9 μs | 5,403.3 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   186.0 μs |    33.06 μs |  16.75 μs |   176.7 μs |   143.7 μs |   287.2 μs | 5,377.2 |     10 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   190.7 μs |    64.72 μs |  33.18 μs |   168.0 μs |   119.2 μs |   410.5 μs | 5,244.0 |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   196.2 μs |    89.52 μs |  46.46 μs |   169.2 μs |   136.8 μs |   605.3 μs | 5,096.6 |     11 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   196.9 μs |    41.76 μs |  21.16 μs |   188.3 μs |   139.8 μs |   295.0 μs | 5,077.4 |     11 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   197.4 μs |    50.23 μs |  25.45 μs |   179.4 μs |   134.4 μs |   322.5 μs | 5,066.1 |     10 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   198.0 μs |    67.40 μs |  34.15 μs |   176.7 μs |   126.8 μs |   356.9 μs | 5,049.7 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   201.6 μs |    67.58 μs |  34.65 μs |   181.6 μs |   120.8 μs |   362.6 μs | 4,961.5 |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   203.0 μs |    71.32 μs |  36.56 μs |   168.9 μs |   126.5 μs |   373.8 μs | 4,926.2 |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   204.4 μs |    44.85 μs |  23.28 μs |   193.6 μs |   152.3 μs |   364.0 μs | 4,891.3 |     11 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   204.8 μs |    79.23 μs |  40.14 μs |   168.8 μs |   124.6 μs |   399.1 μs | 4,883.7 |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   206.5 μs |    96.38 μs |  49.42 μs |   166.1 μs |   123.4 μs |   578.7 μs | 4,842.0 |     10 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   224.3 μs |    67.67 μs |  33.88 μs |   196.9 μs |   136.4 μs |   451.7 μs | 4,457.8 |     11 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   238.6 μs |    71.58 μs |  37.15 μs |   222.8 μs |   138.6 μs |   370.1 μs | 4,191.9 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   248.6 μs |   139.93 μs |  70.89 μs |   181.6 μs |   128.6 μs |   601.2 μs | 4,022.0 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   281.9 μs |   124.69 μs |  63.17 μs |   305.0 μs |   123.0 μs |   503.9 μs | 3,547.9 |     10 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3,637.0 μs |   552.59 μs | 290.44 μs | 3,459.4 μs | 3,036.0 μs | 5,644.5 μs |   275.0 |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 4,039.8 μs |   788.95 μs | 399.69 μs | 3,747.8 μs | 3,217.9 μs | 6,692.8 μs |   247.5 |     25 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 4,287.7 μs |   965.10 μs | 477.76 μs | 3,857.8 μs | 3,193.3 μs | 7,391.8 μs |   233.2 |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4,593.1 μs | 1,289.37 μs | 661.07 μs | 3,951.0 μs | 3,408.0 μs | 7,870.6 μs |   217.7 |     25 KB |
|                                   |                       |            |             |           |            |            |            |         |           |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 3,611.4 μs |   713.57 μs | 353.25 μs | 3,511.7 μs | 2,769.5 μs | 6,038.3 μs |   276.9 |      9 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,735.4 μs |   568.27 μs | 284.54 μs | 3,768.6 μs | 2,673.7 μs | 5,246.8 μs |   267.7 |     10 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,843.1 μs |   498.99 μs | 252.80 μs | 3,809.7 μs | 2,853.0 μs | 5,174.6 μs |   260.2 |      9 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 4,330.9 μs | 1,070.04 μs | 535.80 μs | 4,098.1 μs | 2,731.2 μs | 7,877.2 μs |   230.9 |      8 KB |
