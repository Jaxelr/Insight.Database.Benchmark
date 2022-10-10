# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100
  [Host]   : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  ShortRun : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |      Error |      Min |       Max |   Op/s | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|-----------:|---------:|----------:|-------:|----------:|
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  2.415 ms |  0.1579 ms |  0.0810 ms | 2.051 ms |  2.832 ms | 414.03 |     15 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  2.444 ms |  0.2300 ms |  0.1152 ms | 2.060 ms |  3.056 ms | 409.20 |     17 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  2.448 ms |  0.1577 ms |  0.0789 ms | 2.100 ms |  2.757 ms | 408.45 |     15 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  2.449 ms |  0.2725 ms |  0.1397 ms | 1.980 ms |  3.019 ms | 408.31 |     15 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.450 ms |  0.1808 ms |  0.0927 ms | 1.984 ms |  2.810 ms | 408.08 |     15 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.462 ms |  0.1713 ms |  0.0889 ms | 2.113 ms |  2.829 ms | 406.19 |     17 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  2.471 ms |  0.2916 ms |  0.1495 ms | 1.905 ms |  3.125 ms | 404.62 |     17 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.474 ms |  0.2380 ms |  0.1235 ms | 2.035 ms |  3.061 ms | 404.22 |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.476 ms |  0.2333 ms |  0.1168 ms | 2.026 ms |  3.041 ms | 403.94 |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  2.477 ms |  0.2010 ms |  0.1007 ms | 1.961 ms |  2.868 ms | 403.75 |     15 KB |
|                                    Single | InsightBenchmarkWrite |  2.480 ms |  0.2661 ms |  0.1332 ms | 1.973 ms |  3.149 ms | 403.18 |     15 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  2.483 ms |  0.2443 ms |  0.1209 ms | 2.030 ms |  3.135 ms | 402.69 |     15 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  2.484 ms |  0.2022 ms |  0.1012 ms | 2.149 ms |  3.004 ms | 402.63 |     15 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  2.485 ms |  0.2429 ms |  0.1216 ms | 1.982 ms |  3.090 ms | 402.34 |     15 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.492 ms |  0.1829 ms |  0.0927 ms | 2.004 ms |  2.907 ms | 401.32 |     15 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  2.508 ms |  0.1653 ms |  0.0838 ms | 2.191 ms |  2.882 ms | 398.69 |     17 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.510 ms |  0.2585 ms |  0.1294 ms | 1.986 ms |  3.120 ms | 398.39 |     15 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.513 ms |  0.2866 ms |  0.1487 ms | 2.004 ms |  3.196 ms | 397.99 |     15 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.515 ms |  0.1882 ms |  0.0965 ms | 2.173 ms |  2.919 ms | 397.56 |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.516 ms |  0.1870 ms |  0.0959 ms | 2.045 ms |  2.919 ms | 397.39 |     16 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  2.521 ms |  0.2301 ms |  0.1166 ms | 2.062 ms |  3.027 ms | 396.63 |     17 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  2.522 ms |  0.2616 ms |  0.1310 ms | 1.990 ms |  3.332 ms | 396.46 |     15 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  2.530 ms |  0.2070 ms |  0.1061 ms | 2.218 ms |  3.103 ms | 395.33 |     15 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  2.540 ms |  0.2567 ms |  0.1285 ms | 2.046 ms |  2.988 ms | 393.74 |     17 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.541 ms |  0.2920 ms |  0.1479 ms | 1.982 ms |  3.229 ms | 393.61 |     15 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |  2.546 ms |  0.2144 ms |  0.1099 ms | 2.074 ms |  3.023 ms | 392.82 |     41 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.547 ms |  0.2918 ms |  0.1461 ms | 1.948 ms |  3.336 ms | 392.66 |     17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.547 ms |  0.2426 ms |  0.1229 ms | 2.134 ms |  3.207 ms | 392.62 |     17 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  2.552 ms |  0.1857 ms |  0.0930 ms | 2.240 ms |  2.940 ms | 391.91 |     17 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.553 ms |  0.2192 ms |  0.1085 ms | 2.240 ms |  3.089 ms | 391.76 |     17 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  2.553 ms |  0.2370 ms |  0.1246 ms | 2.111 ms |  3.115 ms | 391.68 |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2.553 ms |  0.1958 ms |  0.0969 ms | 2.280 ms |  3.041 ms | 391.67 |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.562 ms |  0.1828 ms |  0.0905 ms | 2.054 ms |  2.864 ms | 390.36 |     15 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |  2.565 ms |  0.2393 ms |  0.1212 ms | 2.130 ms |  3.067 ms | 389.79 |     41 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.566 ms |  0.2846 ms |  0.1535 ms | 2.031 ms |  3.375 ms | 389.75 |     17 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  2.566 ms |  0.1917 ms |  0.0983 ms | 2.094 ms |  2.953 ms | 389.74 |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  2.568 ms |  0.2137 ms |  0.1070 ms | 2.028 ms |  3.064 ms | 389.36 |     15 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  2.574 ms |  0.3037 ms |  0.1557 ms | 2.008 ms |  3.365 ms | 388.44 |     17 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  2.583 ms |  0.2301 ms |  0.1166 ms | 2.017 ms |  3.164 ms | 387.13 |     17 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  2.589 ms |  0.2650 ms |  0.1312 ms | 2.206 ms |  3.284 ms | 386.20 |     15 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |  2.599 ms |  0.2329 ms |  0.1180 ms | 2.186 ms |  3.420 ms | 384.71 |     41 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.600 ms |  0.1766 ms |  0.0874 ms | 2.293 ms |  3.029 ms | 384.60 |     17 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  2.602 ms |  0.2750 ms |  0.1445 ms | 2.119 ms |  3.223 ms | 384.38 |     17 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  2.604 ms |  0.2898 ms |  0.1543 ms | 2.216 ms |  3.803 ms | 384.02 |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.606 ms |  0.1839 ms |  0.0921 ms | 2.217 ms |  3.142 ms | 383.67 |     17 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.615 ms |  0.2712 ms |  0.1342 ms | 2.165 ms |  3.427 ms | 382.45 |     15 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  2.618 ms |  0.3568 ms |  0.1830 ms | 2.077 ms |  4.032 ms | 382.04 |     15 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.618 ms |  0.2415 ms |  0.1209 ms | 2.195 ms |  3.107 ms | 381.96 |     16 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.624 ms |  0.2090 ms |  0.1085 ms | 2.265 ms |  3.051 ms | 381.08 |     16 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.635 ms |  0.2323 ms |  0.1221 ms | 2.305 ms |  3.522 ms | 379.55 |     16 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  2.640 ms |  0.3746 ms |  0.1876 ms | 2.216 ms |  3.640 ms | 378.72 |     15 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.642 ms |  0.3788 ms |  0.1991 ms | 2.262 ms |  4.094 ms | 378.54 |     15 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  2.642 ms |  0.2833 ms |  0.1471 ms | 2.221 ms |  3.605 ms | 378.48 |     17 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  2.647 ms |  0.3052 ms |  0.1584 ms | 2.187 ms |  3.497 ms | 377.82 |     15 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.650 ms |  0.2345 ms |  0.1249 ms | 2.159 ms |  3.184 ms | 377.42 |     17 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.661 ms |  0.2268 ms |  0.1192 ms | 2.260 ms |  3.164 ms | 375.81 |     17 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |  2.664 ms |  0.2147 ms |  0.1088 ms | 2.297 ms |  3.181 ms | 375.36 |     41 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  2.675 ms |  0.3368 ms |  0.1793 ms | 2.277 ms |  3.989 ms | 373.88 |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.688 ms |  0.4056 ms |  0.2132 ms | 2.056 ms |  3.844 ms | 372.07 |     15 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.691 ms |  0.3454 ms |  0.1793 ms | 2.184 ms |  3.917 ms | 371.64 |     15 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2.705 ms |  0.3296 ms |  0.1732 ms | 2.247 ms |  3.889 ms | 369.74 |     15 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  2.705 ms |  0.3296 ms |  0.1690 ms | 2.253 ms |  3.767 ms | 369.65 |     15 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  2.770 ms |  0.4650 ms |  0.2384 ms | 2.155 ms |  4.913 ms | 360.97 |     17 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.786 ms |  0.5662 ms |  0.2835 ms | 2.014 ms |  4.449 ms | 358.91 |     15 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.798 ms |  0.4385 ms |  0.2171 ms | 2.034 ms |  4.021 ms | 357.46 |     15 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  2.826 ms |  0.4326 ms |  0.2245 ms | 2.353 ms |  4.101 ms | 353.84 |     15 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.827 ms |  0.5344 ms |  0.2809 ms | 2.213 ms |  4.600 ms | 353.76 |     17 KB |
|                                    Single |      InsightBenchmark |  2.865 ms |  0.4022 ms |  0.2088 ms | 2.272 ms |  4.042 ms | 349.00 |     15 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  5.192 ms |  0.5701 ms |  0.2959 ms | 4.447 ms |  7.025 ms | 192.59 |     32 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5.262 ms |  0.6552 ms |  0.3319 ms | 4.560 ms |  7.417 ms | 190.03 |     32 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  5.850 ms |  0.5358 ms |  0.2653 ms | 4.939 ms |  7.212 ms | 170.94 |     33 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  5.901 ms |  0.7179 ms |  0.3637 ms | 5.019 ms |  8.310 ms | 169.45 |     33 KB |
|                                           |                       |           |            |            |          |           |        |           |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 10.814 ms |  4.8214 ms |  2.5341 ms | 6.380 ms | 29.762 ms |  92.48 |     22 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 12.160 ms | 10.9102 ms |  5.8088 ms | 5.480 ms | 46.758 ms |  82.24 |     22 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 15.090 ms | 13.6540 ms |  7.0869 ms | 5.766 ms | 66.214 ms |  66.27 |     31 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 16.354 ms | 14.7443 ms |  7.3828 ms | 6.561 ms | 61.772 ms |  61.15 |     32 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 22.037 ms | 22.5930 ms | 11.8748 ms | 5.961 ms | 86.679 ms |  45.38 |     21 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 27.077 ms | 20.7072 ms | 10.6168 ms | 5.716 ms | 94.090 ms |  36.93 |     21 KB |
