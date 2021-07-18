# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) but using Sqlite as a database 

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.302
  [Host]   : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  ShortRun : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|                            Method |                  Type |         Mean |       StdDev |       Error |          Min |          Max |      Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |-------------:|-------------:|------------:|-------------:|-------------:|----------:|------:|------:|------:|----------:|
|                          Query&lt;T&gt; | InsightBenchmarkWrite |     438.2 μs |     62.38 μs |    33.65 μs |     365.9 μs |     652.6 μs | 2,282.251 |     - |     - |     - |      9 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |     439.9 μs |     53.76 μs |    29.40 μs |     380.3 μs |     612.5 μs | 2,273.342 |     - |     - |     - |      9 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |     442.2 μs |     44.81 μs |    24.51 μs |     399.3 μs |     604.4 μs | 2,261.177 |     - |     - |     - |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |     443.9 μs |     69.55 μs |    36.55 μs |     375.0 μs |     686.0 μs | 2,252.855 |     - |     - |     - |      9 KB |
|                            Single | InsightBenchmarkWrite |     446.7 μs |     62.75 μs |    33.41 μs |     377.4 μs |     644.2 μs | 2,238.696 |     - |     - |     - |      9 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |     451.0 μs |     59.83 μs |    32.28 μs |     379.9 μs |     692.2 μs | 2,217.181 |     - |     - |     - |      9 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |     454.5 μs |     85.33 μs |    44.85 μs |     375.6 μs |     709.1 μs | 2,200.414 |     - |     - |     - |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |     457.1 μs |     65.64 μs |    34.50 μs |     386.5 μs |     671.4 μs | 2,187.530 |     - |     - |     - |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |     462.1 μs |     78.91 μs |    40.46 μs |     368.8 μs |     698.2 μs | 2,164.243 |     - |     - |     - |      9 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |     462.2 μs |     76.38 μs |    40.15 μs |     390.0 μs |     723.7 μs | 2,163.638 |     - |     - |     - |     10 KB |
|                            Single |      InsightBenchmark |     462.9 μs |     84.69 μs |    44.51 μs |     378.4 μs |     715.9 μs | 2,160.423 |     - |     - |     - |      9 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |     464.8 μs |     99.46 μs |    52.28 μs |     384.4 μs |     814.7 μs | 2,151.273 |     - |     - |     - |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |     465.3 μs |     83.77 μs |    43.48 μs |     391.9 μs |     783.9 μs | 2,149.046 |     - |     - |     - |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |     468.0 μs |     84.84 μs |    44.59 μs |     376.3 μs |     740.0 μs | 2,136.712 |     - |     - |     - |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |     469.9 μs |     76.39 μs |    40.67 μs |     392.5 μs |     720.1 μs | 2,128.329 |     - |     - |     - |     10 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |     471.7 μs |     95.95 μs |    50.43 μs |     382.2 μs |     910.8 μs | 2,120.116 |     - |     - |     - |     10 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |     472.1 μs |     64.89 μs |    34.11 μs |     404.9 μs |     667.5 μs | 2,118.190 |     - |     - |     - |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |     473.1 μs |     82.25 μs |    43.23 μs |     405.4 μs |     763.0 μs | 2,113.788 |     - |     - |     - |     10 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |     478.4 μs |     67.55 μs |    35.97 μs |     401.7 μs |     694.4 μs | 2,090.410 |     - |     - |     - |     10 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |     482.4 μs |     78.33 μs |    40.66 μs |     395.6 μs |     661.2 μs | 2,073.034 |     - |     - |     - |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |     483.9 μs |    110.71 μs |    60.54 μs |     382.5 μs |     895.6 μs | 2,066.390 |     - |     - |     - |      9 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |     485.4 μs |     80.25 μs |    43.89 μs |     402.4 μs |     809.4 μs | 2,060.258 |     - |     - |     - |     10 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |     486.4 μs |    114.57 μs |    61.00 μs |     388.5 μs |   1,012.1 μs | 2,055.844 |     - |     - |     - |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |     487.3 μs |     95.18 μs |    50.03 μs |     406.4 μs |     772.0 μs | 2,052.058 |     - |     - |     - |      9 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |     492.2 μs |     77.89 μs |    40.94 μs |     421.1 μs |     732.7 μs | 2,031.850 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |     493.2 μs |     81.75 μs |    42.97 μs |     420.1 μs |     812.7 μs | 2,027.689 |     - |     - |     - |     11 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |     499.0 μs |    103.09 μs |    51.62 μs |     378.4 μs |     763.8 μs | 2,004.049 |     - |     - |     - |      9 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |     500.1 μs |     84.31 μs |    42.71 μs |     402.7 μs |     779.0 μs | 1,999.758 |     - |     - |     - |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |     500.2 μs |     99.78 μs |    51.79 μs |     388.0 μs |     741.0 μs | 1,999.000 |     - |     - |     - |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |     500.5 μs |    123.33 μs |    64.82 μs |     389.2 μs |     936.5 μs | 1,997.820 |     - |     - |     - |      9 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |     507.2 μs |     95.01 μs |    50.58 μs |     420.1 μs |     934.6 μs | 1,971.724 |     - |     - |     - |     11 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |     507.2 μs |     97.77 μs |    50.75 μs |     385.6 μs |     726.0 μs | 1,971.562 |     - |     - |     - |     10 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |     507.3 μs |     91.84 μs |    47.67 μs |     407.0 μs |     737.9 μs | 1,971.258 |     - |     - |     - |     10 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |     507.3 μs |     74.41 μs |    39.61 μs |     427.5 μs |     857.5 μs | 1,971.136 |     - |     - |     - |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |     507.8 μs |    105.25 μs |    53.96 μs |     392.3 μs |     864.6 μs | 1,969.209 |     - |     - |     - |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |     517.3 μs |     89.20 μs |    45.73 μs |     400.0 μs |     693.1 μs | 1,933.194 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |     530.0 μs |     90.81 μs |    48.99 μs |     439.4 μs |     768.2 μs | 1,886.925 |     - |     - |     - |     11 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |     536.7 μs |    130.93 μs |    68.81 μs |     399.5 μs |     864.0 μs | 1,863.126 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |     583.3 μs |    127.95 μs |    65.60 μs |     452.2 μs |     948.2 μs | 1,714.290 |     - |     - |     - |     11 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |     628.1 μs |     68.83 μs |    35.29 μs |     529.2 μs |     833.0 μs | 1,592.011 |     - |     - |     - |     10 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  76,140.3 μs |  1,637.42 μs |   839.52 μs |  73,014.4 μs |  80,894.4 μs |    13.134 |     - |     - |     - |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  76,510.4 μs |  1,748.21 μs |   918.85 μs |  73,175.6 μs |  80,326.5 μs |    13.070 |     - |     - |     - |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  76,565.6 μs |  1,288.84 μs |   668.95 μs |  73,996.8 μs |  79,077.1 μs |    13.061 |     - |     - |     - |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 129,007.8 μs |  3,487.85 μs | 1,788.25 μs | 123,414.0 μs | 135,788.2 μs |     7.751 |     - |     - |     - |     24 KB |
|                                   |                       |              |              |             |              |              |           |       |       |       |           |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  12,091.4 μs |  3,988.83 μs | 2,045.11 μs |   4,952.8 μs |  22,230.3 μs |    82.703 |     - |     - |     - |      9 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite |  14,027.4 μs |  8,831.13 μs | 4,421.96 μs |   4,761.1 μs |  34,710.3 μs |    71.289 |     - |     - |     - |      8 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  24,413.9 μs | 15,152.21 μs | 7,676.27 μs |   5,461.9 μs |  55,083.7 μs |    40.960 |     - |     - |     - |      9 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite |  31,192.4 μs | 15,328.88 μs | 7,588.37 μs |   5,682.2 μs |  62,522.8 μs |    32.059 |     - |     - |     - |      8 KB |
