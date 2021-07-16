# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.302
  [Host]   : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  ShortRun : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|                            Method |                  Type |     Mean |    StdDev |     Error |      Min |       Max |  Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |---------:|----------:|----------:|---------:|----------:|------:|------:|------:|------:|----------:|
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 2.168 ms | 0.1771 ms | 0.0919 ms | 1.927 ms |  2.742 ms | 461.2 |     - |     - |     - |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 2.169 ms | 0.2387 ms | 0.1224 ms | 1.721 ms |  2.688 ms | 461.1 |     - |     - |     - |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 2.250 ms | 0.2761 ms | 0.1433 ms | 1.776 ms |  2.969 ms | 444.4 |     - |     - |     - |      9 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 2.254 ms | 0.3094 ms | 0.1606 ms | 1.854 ms |  3.458 ms | 443.7 |     - |     - |     - |     13 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 2.255 ms | 0.3254 ms | 0.1689 ms | 1.823 ms |  3.262 ms | 443.5 |     - |     - |     - |      9 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.265 ms | 0.2541 ms | 0.1287 ms | 1.930 ms |  2.840 ms | 441.5 |     - |     - |     - |     35 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 2.303 ms | 0.3199 ms | 0.1660 ms | 1.891 ms |  3.010 ms | 434.2 |     - |     - |     - |     14 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 2.315 ms | 0.3034 ms | 0.1556 ms | 1.803 ms |  3.007 ms | 431.9 |     - |     - |     - |     13 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 2.330 ms | 0.2576 ms | 0.1290 ms | 1.936 ms |  2.937 ms | 429.1 |     - |     - |     - |      9 KB |
|                            Single | InsightBenchmarkWrite | 2.332 ms | 0.2548 ms | 0.1291 ms | 1.948 ms |  3.078 ms | 428.7 |     - |     - |     - |     13 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 2.333 ms | 0.2440 ms | 0.1236 ms | 1.819 ms |  2.858 ms | 428.7 |     - |     - |     - |     14 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 2.337 ms | 0.4885 ms | 0.2475 ms | 1.738 ms |  3.956 ms | 428.0 |     - |     - |     - |      9 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 2.347 ms | 0.3913 ms | 0.1983 ms | 1.809 ms |  3.843 ms | 426.0 |     - |     - |     - |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.355 ms | 0.2957 ms | 0.1516 ms | 1.882 ms |  3.054 ms | 424.7 |     - |     - |     - |     10 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 2.356 ms | 0.2861 ms | 0.1450 ms | 1.876 ms |  3.097 ms | 424.4 |     - |     - |     - |     14 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 2.371 ms | 0.2492 ms | 0.1248 ms | 1.934 ms |  2.871 ms | 421.8 |     - |     - |     - |     11 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.381 ms | 0.3487 ms | 0.1746 ms | 1.918 ms |  3.404 ms | 420.0 |     - |     - |     - |     16 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 2.381 ms | 0.2312 ms | 0.1158 ms | 1.990 ms |  3.078 ms | 419.9 |     - |     - |     - |      9 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 2.385 ms | 0.2801 ms | 0.1436 ms | 1.915 ms |  3.073 ms | 419.3 |     - |     - |     - |     11 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 2.386 ms | 0.2777 ms | 0.1390 ms | 2.036 ms |  3.026 ms | 419.1 |     - |     - |     - |     14 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 2.417 ms | 0.3452 ms | 0.1792 ms | 1.868 ms |  2.948 ms | 413.8 |     - |     - |     - |     15 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.422 ms | 0.2800 ms | 0.1402 ms | 2.032 ms |  3.275 ms | 412.8 |     - |     - |     - |     16 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 2.428 ms | 0.3429 ms | 0.1802 ms | 1.966 ms |  3.339 ms | 411.8 |     - |     - |     - |     36 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 2.437 ms | 0.3043 ms | 0.1523 ms | 1.999 ms |  3.259 ms | 410.4 |     - |     - |     - |     15 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 2.439 ms | 0.2209 ms | 0.1146 ms | 2.051 ms |  3.114 ms | 410.1 |     - |     - |     - |      9 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 2.442 ms | 0.3211 ms | 0.1627 ms | 1.947 ms |  3.203 ms | 409.5 |     - |     - |     - |     36 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 2.449 ms | 0.2428 ms | 0.1245 ms | 2.058 ms |  2.914 ms | 408.4 |     - |     - |     - |     35 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 2.452 ms | 0.2337 ms | 0.1278 ms | 2.075 ms |  2.999 ms | 407.8 |     - |     - |     - |     13 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 2.506 ms | 0.4130 ms | 0.2092 ms | 1.902 ms |  4.261 ms | 399.0 |     - |     - |     - |     11 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 2.509 ms | 0.4225 ms | 0.2141 ms | 1.876 ms |  3.743 ms | 398.6 |     - |     - |     - |      9 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 2.516 ms | 0.1650 ms | 0.0857 ms | 2.103 ms |  2.949 ms | 397.5 |     - |     - |     - |      9 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 2.520 ms | 0.5082 ms | 0.2575 ms | 1.851 ms |  4.428 ms | 396.9 |     - |     - |     - |     14 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 2.558 ms | 0.6660 ms | 0.3415 ms | 2.069 ms |  5.711 ms | 391.0 |     - |     - |     - |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.560 ms | 0.2459 ms | 0.1231 ms | 2.079 ms |  3.060 ms | 390.6 |     - |     - |     - |     15 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 2.567 ms | 0.1852 ms | 0.0961 ms | 2.186 ms |  2.966 ms | 389.5 |     - |     - |     - |     10 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 2.573 ms | 0.6789 ms | 0.3481 ms | 1.981 ms |  5.656 ms | 388.7 |     - |     - |     - |     14 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.586 ms | 0.1960 ms | 0.1030 ms | 2.208 ms |  3.247 ms | 386.7 |     - |     - |     - |     11 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 2.609 ms | 0.1910 ms | 0.0979 ms | 2.180 ms |  2.990 ms | 383.2 |     - |     - |     - |      9 KB |
|                            Single |      InsightBenchmark | 2.644 ms | 0.3245 ms | 0.1644 ms | 2.067 ms |  3.249 ms | 378.2 |     - |     - |     - |     13 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 2.679 ms | 0.6069 ms | 0.3075 ms | 1.836 ms |  4.212 ms | 373.2 |     - |     - |     - |     15 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 2.733 ms | 0.4336 ms | 0.2223 ms | 2.198 ms |  4.022 ms | 365.9 |     - |     - |     - |     13 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 2.770 ms | 0.4421 ms | 0.2240 ms | 2.056 ms |  3.938 ms | 361.0 |     - |     - |     - |      9 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 4.974 ms | 0.5662 ms | 0.2835 ms | 4.160 ms |  6.201 ms | 201.0 |     - |     - |     - |     32 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 5.578 ms | 0.8920 ms | 0.4416 ms | 4.278 ms |  7.451 ms | 179.3 |     - |     - |     - |     34 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5.710 ms | 0.8298 ms | 0.4155 ms | 4.478 ms |  7.950 ms | 175.1 |     - |     - |     - |     32 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 5.866 ms | 0.8181 ms | 0.4050 ms | 4.438 ms |  7.068 ms | 170.5 |     - |     - |     - |     34 KB |
|                                   |                       |          |           |           |          |           |       |       |       |       |           |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 5.196 ms | 2.2623 ms | 1.1891 ms | 3.036 ms | 10.982 ms | 192.4 |     - |     - |     - |     15 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 7.116 ms | 4.2684 ms | 2.1373 ms | 2.816 ms | 17.986 ms | 140.5 |     - |     - |     - |      4 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 8.048 ms | 5.3126 ms | 2.6914 ms | 2.816 ms | 26.266 ms | 124.2 |     - |     - |     - |      6 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 8.925 ms | 6.2326 ms | 3.2349 ms | 2.955 ms | 27.077 ms | 112.0 |     - |     - |     - |     16 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 9.039 ms | 5.3336 ms | 2.6707 ms | 2.951 ms | 21.182 ms | 110.6 |     - |     - |     - |     10 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 9.716 ms | 9.8663 ms | 4.8842 ms | 2.739 ms | 48.750 ms | 102.9 |     - |     - |     - |      4 KB |
