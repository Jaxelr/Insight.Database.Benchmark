# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]   : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  ShortRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT


```
|                            Method |                  Type |       Mean |      StdDev |       Error |     Median |        Min |         Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|--------:|----------:|
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   249.0 μs |    32.42 μs |    16.62 μs |   240.1 μs |   206.8 μs |    342.1 μs | 4,016.8 |     11 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   254.7 μs |    47.12 μs |    24.46 μs |   240.1 μs |   194.8 μs |    398.1 μs | 3,926.9 |     11 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   279.8 μs |    63.69 μs |    31.89 μs |   262.5 μs |   192.9 μs |    457.5 μs | 3,574.2 |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   289.4 μs |    84.74 μs |    41.95 μs |   273.8 μs |   182.2 μs |    469.4 μs | 3,455.7 |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   297.7 μs |    97.71 μs |    50.10 μs |   267.7 μs |   178.3 μs |    570.4 μs | 3,359.3 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   299.5 μs |    88.39 μs |    43.76 μs |   285.9 μs |   174.7 μs |    511.4 μs | 3,338.5 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   302.1 μs |    88.80 μs |    44.46 μs |   265.2 μs |   191.0 μs |    529.3 μs | 3,310.1 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   306.0 μs |    68.02 μs |    35.30 μs |   297.8 μs |   198.5 μs |    464.9 μs | 3,268.0 |     10 KB |
|                            Single |      InsightBenchmark |   307.6 μs |    79.82 μs |    41.95 μs |   311.4 μs |   189.1 μs |    457.1 μs | 3,250.9 |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   311.8 μs |    88.33 μs |    44.23 μs |   291.1 μs |   182.8 μs |    513.3 μs | 3,206.9 |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   318.5 μs |   108.42 μs |    56.98 μs |   274.1 μs |   209.2 μs |    598.9 μs | 3,140.0 |     11 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   318.6 μs |   101.72 μs |    52.15 μs |   291.7 μs |   177.8 μs |    659.7 μs | 3,139.2 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   328.9 μs |    92.94 μs |    47.08 μs |   292.2 μs |   217.1 μs |    521.1 μs | 3,040.5 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   329.1 μs |   103.65 μs |    53.14 μs |   312.2 μs |   202.2 μs |    642.0 μs | 3,038.7 |     10 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   335.0 μs |    94.23 μs |    47.18 μs |   323.4 μs |   193.7 μs |    540.4 μs | 2,985.2 |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   337.0 μs |    95.45 μs |    47.79 μs |   324.1 μs |   187.4 μs |    599.9 μs | 2,967.5 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   341.3 μs |   110.76 μs |    57.49 μs |   292.8 μs |   214.1 μs |    593.0 μs | 2,930.4 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   342.0 μs |   132.63 μs |    66.41 μs |   278.9 μs |   181.0 μs |    668.1 μs | 2,923.6 |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   355.5 μs |    81.38 μs |    41.23 μs |   338.1 μs |   229.3 μs |    621.8 μs | 2,812.9 |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   357.3 μs |   124.66 μs |    64.70 μs |   324.6 μs |   213.7 μs |    633.1 μs | 2,799.0 |     11 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   357.4 μs |   101.30 μs |    51.94 μs |   343.1 μs |   199.7 μs |    580.2 μs | 2,798.0 |     10 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   361.0 μs |   105.14 μs |    53.91 μs |   364.0 μs |   206.3 μs |    611.7 μs | 2,769.9 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   367.3 μs |   113.57 μs |    56.87 μs |   407.4 μs |   179.8 μs |    568.6 μs | 2,722.3 |     10 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   369.3 μs |   103.37 μs |    53.65 μs |   344.0 μs |   213.6 μs |    614.0 μs | 2,708.1 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   369.4 μs |   101.29 μs |    51.32 μs |   377.4 μs |   210.7 μs |    623.6 μs | 2,707.4 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   372.7 μs |    72.89 μs |    36.93 μs |   341.7 μs |   277.7 μs |    594.6 μs | 2,683.3 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   378.8 μs |   107.09 μs |    53.62 μs |   370.9 μs |   178.8 μs |    570.8 μs | 2,639.6 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   383.3 μs |   110.00 μs |    57.09 μs |   400.4 μs |   195.8 μs |    580.5 μs | 2,609.2 |     10 KB |
|                            Single | InsightBenchmarkWrite |   384.4 μs |   126.98 μs |    65.91 μs |   374.6 μs |   208.7 μs |    647.4 μs | 2,601.7 |     10 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   388.2 μs |   120.10 μs |    62.33 μs |   419.7 μs |   198.2 μs |    636.6 μs | 2,576.0 |     10 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   404.0 μs |   157.23 μs |    78.73 μs |   416.9 μs |   196.6 μs |    674.6 μs | 2,475.5 |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   404.7 μs |   124.61 μs |    63.89 μs |   419.4 μs |   232.6 μs |    667.5 μs | 2,471.0 |     11 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   405.6 μs |   164.43 μs |    84.30 μs |   354.3 μs |   190.1 μs |    789.7 μs | 2,465.5 |     10 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   409.8 μs |   111.84 μs |    57.34 μs |   401.3 μs |   247.4 μs |    606.5 μs | 2,440.4 |     11 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   413.9 μs |   130.10 μs |    65.15 μs |   441.8 μs |   192.0 μs |    625.5 μs | 2,415.8 |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   417.0 μs |    83.22 μs |    44.90 μs |   444.8 μs |   231.1 μs |    532.7 μs | 2,397.8 |     10 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   428.0 μs |   194.96 μs |    98.77 μs |   433.6 μs |   180.5 μs |  1,160.5 μs | 2,336.6 |     10 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   428.0 μs |   142.96 μs |    73.30 μs |   381.5 μs |   292.9 μs |    982.6 μs | 2,336.4 |     11 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   470.7 μs |   125.50 μs |    62.84 μs |   466.5 μs |   199.2 μs |    833.3 μs | 2,124.6 |     10 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   476.0 μs |   106.03 μs |    53.09 μs |   501.6 μs |   225.5 μs |    639.3 μs | 2,100.7 |     11 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 6,454.8 μs | 1,180.65 μs |   598.13 μs | 6,293.4 μs | 4,589.9 μs |  8,444.5 μs |   154.9 |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 8,059.1 μs | 2,141.27 μs | 1,097.85 μs | 8,813.0 μs | 4,670.9 μs | 11,653.6 μs |   124.1 |     25 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 8,605.7 μs | 1,185.35 μs |   593.53 μs | 8,931.0 μs | 4,753.7 μs | 10,035.4 μs |   116.2 |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 8,883.4 μs | 1,921.11 μs |   973.25 μs | 9,230.9 μs | 5,107.1 μs | 11,965.4 μs |   112.6 |     25 KB |
|                                   |                       |            |             |             |            |            |             |         |           |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 3,766.1 μs |   472.08 μs |   236.38 μs | 3,880.6 μs | 2,738.3 μs |  4,813.8 μs |   265.5 |      9 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,218.5 μs |   293.14 μs |   150.30 μs | 4,275.9 μs | 3,371.8 μs |  4,687.6 μs |   237.1 |     10 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 4,803.6 μs |   703.55 μs |   356.43 μs | 4,860.9 μs | 3,489.5 μs |  6,588.9 μs |   208.2 |      8 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,851.9 μs |   426.39 μs |   224.11 μs | 4,817.4 μs | 3,856.9 μs |  5,967.1 μs |   206.1 |      9 KB |
