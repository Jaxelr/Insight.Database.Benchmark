# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)


``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.302
  [Host]   : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  ShortRun : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |      Error |      Min |       Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|-----------:|---------:|----------:|-------:|------:|------:|------:|----------:|
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.715 ms |  0.2834 ms |  0.1471 ms | 2.191 ms |  3.644 ms | 368.28 |     - |     - |     - |     15 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  2.732 ms |  0.3033 ms |  0.1574 ms | 2.093 ms |  3.419 ms | 366.01 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.742 ms |  0.2463 ms |  0.1311 ms | 2.283 ms |  3.316 ms | 364.71 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  2.776 ms |  0.2095 ms |  0.1101 ms | 2.303 ms |  3.286 ms | 360.29 |     - |     - |     - |     14 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.776 ms |  0.2460 ms |  0.1232 ms | 2.315 ms |  3.558 ms | 360.19 |     - |     - |     - |     16 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.796 ms |  0.3681 ms |  0.1910 ms | 2.195 ms |  3.732 ms | 357.68 |     - |     - |     - |     15 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2.844 ms |  0.4268 ms |  0.2215 ms | 2.195 ms |  4.442 ms | 351.66 |     - |     - |     - |     15 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |  2.853 ms |  0.3711 ms |  0.1903 ms | 2.251 ms |  3.805 ms | 350.51 |     - |     - |     - |     37 KB |
|                                    Single | InsightBenchmarkWrite |  2.860 ms |  0.2280 ms |  0.1183 ms | 2.421 ms |  3.372 ms | 349.64 |     - |     - |     - |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.864 ms |  0.2691 ms |  0.1379 ms | 2.460 ms |  3.653 ms | 349.16 |     - |     - |     - |     15 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.866 ms |  0.3337 ms |  0.1652 ms | 2.357 ms |  3.587 ms | 348.88 |     - |     - |     - |     16 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  2.870 ms |  0.2790 ms |  0.1431 ms | 2.356 ms |  3.573 ms | 348.43 |     - |     - |     - |     17 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.871 ms |  0.3816 ms |  0.1911 ms | 2.288 ms |  3.780 ms | 348.31 |     - |     - |     - |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.872 ms |  0.4085 ms |  0.2120 ms | 2.221 ms |  4.169 ms | 348.17 |     - |     - |     - |     15 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  2.877 ms |  0.3680 ms |  0.1887 ms | 2.335 ms |  3.904 ms | 347.53 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  2.897 ms |  0.2500 ms |  0.1297 ms | 2.388 ms |  3.414 ms | 345.17 |     - |     - |     - |     17 KB |
|                                    Single |      InsightBenchmark |  2.897 ms |  0.3090 ms |  0.1604 ms | 2.387 ms |  3.807 ms | 345.15 |     - |     - |     - |     14 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.899 ms |  0.3097 ms |  0.1607 ms | 2.331 ms |  4.042 ms | 344.96 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.899 ms |  0.5138 ms |  0.2573 ms | 2.267 ms |  4.386 ms | 344.94 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.900 ms |  0.4063 ms |  0.2109 ms | 2.271 ms |  3.947 ms | 344.82 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  2.902 ms |  0.3662 ms |  0.1901 ms | 2.377 ms |  3.699 ms | 344.61 |     - |     - |     - |     14 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.905 ms |  0.3846 ms |  0.1949 ms | 2.351 ms |  3.787 ms | 344.28 |     - |     - |     - |     14 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |  2.906 ms |  0.2766 ms |  0.1385 ms | 2.458 ms |  3.725 ms | 344.14 |     - |     - |     - |     37 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  2.912 ms |  0.3366 ms |  0.1747 ms | 2.414 ms |  4.191 ms | 343.38 |     - |     - |     - |     17 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.915 ms |  0.3369 ms |  0.1727 ms | 2.329 ms |  4.029 ms | 343.04 |     - |     - |     - |     15 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  2.918 ms |  0.4472 ms |  0.2350 ms | 2.345 ms |  4.280 ms | 342.68 |     - |     - |     - |     14 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.927 ms |  0.3336 ms |  0.1690 ms | 2.347 ms |  3.892 ms | 341.61 |     - |     - |     - |     17 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  2.932 ms |  0.3360 ms |  0.1682 ms | 2.342 ms |  3.866 ms | 341.12 |     - |     - |     - |     14 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.936 ms |  0.3273 ms |  0.1699 ms | 2.383 ms |  3.678 ms | 340.55 |     - |     - |     - |     17 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.953 ms |  0.3479 ms |  0.1829 ms | 2.411 ms |  3.834 ms | 338.62 |     - |     - |     - |     17 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  2.961 ms |  0.3245 ms |  0.1625 ms | 2.402 ms |  3.682 ms | 337.70 |     - |     - |     - |     17 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  2.961 ms |  0.3757 ms |  0.1903 ms | 2.242 ms |  3.989 ms | 337.67 |     - |     - |     - |     15 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  2.963 ms |  0.2596 ms |  0.1364 ms | 2.606 ms |  3.962 ms | 337.46 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  2.972 ms |  0.2839 ms |  0.1438 ms | 2.459 ms |  3.526 ms | 336.45 |     - |     - |     - |     14 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  2.976 ms |  0.2904 ms |  0.1438 ms | 2.468 ms |  3.805 ms | 335.97 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.977 ms |  0.3973 ms |  0.2037 ms | 2.262 ms |  4.242 ms | 335.93 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.983 ms |  0.4179 ms |  0.2169 ms | 2.364 ms |  4.049 ms | 335.25 |     - |     - |     - |     14 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.983 ms |  0.3868 ms |  0.1960 ms | 2.380 ms |  3.870 ms | 335.21 |     - |     - |     - |     15 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  2.992 ms |  0.2517 ms |  0.1306 ms | 2.582 ms |  3.621 ms | 334.27 |     - |     - |     - |     14 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  3.015 ms |  0.4297 ms |  0.2203 ms | 2.415 ms |  4.127 ms | 331.65 |     - |     - |     - |     16 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.016 ms |  0.3384 ms |  0.1714 ms | 2.393 ms |  3.752 ms | 331.58 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  3.018 ms |  0.2841 ms |  0.1457 ms | 2.548 ms |  3.881 ms | 331.39 |     - |     - |     - |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  3.020 ms |  0.3782 ms |  0.1963 ms | 2.438 ms |  4.114 ms | 331.12 |     - |     - |     - |     16 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.021 ms |  0.3289 ms |  0.1728 ms | 2.413 ms |  3.615 ms | 330.99 |     - |     - |     - |     17 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  3.022 ms |  0.3642 ms |  0.1891 ms | 2.393 ms |  4.297 ms | 330.94 |     - |     - |     - |     15 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.028 ms |  0.4438 ms |  0.2248 ms | 2.351 ms |  4.221 ms | 330.30 |     - |     - |     - |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  3.030 ms |  0.4666 ms |  0.2422 ms | 2.184 ms |  4.580 ms | 330.06 |     - |     - |     - |     16 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  3.042 ms |  0.6054 ms |  0.3104 ms | 2.269 ms |  4.852 ms | 328.78 |     - |     - |     - |     15 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  3.045 ms |  0.4133 ms |  0.2119 ms | 2.402 ms |  4.029 ms | 328.37 |     - |     - |     - |     15 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  3.057 ms |  0.3960 ms |  0.1983 ms | 2.380 ms |  4.115 ms | 327.12 |     - |     - |     - |     15 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  3.057 ms |  0.5605 ms |  0.2909 ms | 2.337 ms |  4.620 ms | 327.07 |     - |     - |     - |     16 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  3.059 ms |  0.3614 ms |  0.1831 ms | 2.497 ms |  4.358 ms | 326.88 |     - |     - |     - |     14 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  3.067 ms |  0.5601 ms |  0.2805 ms | 2.216 ms |  4.484 ms | 326.06 |     - |     - |     - |     14 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.068 ms |  0.3287 ms |  0.1685 ms | 2.570 ms |  3.978 ms | 325.99 |     - |     - |     - |     17 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |  3.069 ms |  0.3291 ms |  0.1687 ms | 2.327 ms |  3.634 ms | 325.81 |     - |     - |     - |     37 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.070 ms |  0.4537 ms |  0.2326 ms | 2.414 ms |  4.622 ms | 325.71 |     - |     - |     - |     17 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  3.074 ms |  0.2574 ms |  0.1336 ms | 2.687 ms |  3.553 ms | 325.32 |     - |     - |     - |     17 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  3.076 ms |  0.5304 ms |  0.2720 ms | 2.409 ms |  4.877 ms | 325.08 |     - |     - |     - |     15 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  3.098 ms |  0.4275 ms |  0.2192 ms | 2.437 ms |  4.220 ms | 322.81 |     - |     - |     - |     16 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |  3.100 ms |  0.3423 ms |  0.1714 ms | 2.504 ms |  3.881 ms | 322.62 |     - |     - |     - |     37 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  3.128 ms |  0.3786 ms |  0.1965 ms | 2.627 ms |  4.174 ms | 319.65 |     - |     - |     - |     15 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  3.129 ms |  0.5088 ms |  0.2578 ms | 2.306 ms |  4.315 ms | 319.61 |     - |     - |     - |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  3.138 ms |  0.5141 ms |  0.2604 ms | 2.389 ms |  4.318 ms | 318.65 |     - |     - |     - |     15 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  3.142 ms |  0.3545 ms |  0.1775 ms | 2.676 ms |  4.183 ms | 318.28 |     - |     - |     - |     17 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.182 ms |  0.5498 ms |  0.2854 ms | 2.274 ms |  4.609 ms | 314.26 |     - |     - |     - |     17 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  3.231 ms |  0.5449 ms |  0.2728 ms | 2.484 ms |  4.474 ms | 309.46 |     - |     - |     - |     17 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  3.263 ms |  0.7616 ms |  0.3858 ms | 2.485 ms |  6.372 ms | 306.50 |     - |     - |     - |     17 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  3.281 ms |  0.4499 ms |  0.2279 ms | 2.614 ms |  4.257 ms | 304.77 |     - |     - |     - |     16 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5.747 ms |  0.5945 ms |  0.3012 ms | 4.822 ms |  7.188 ms | 173.99 |     - |     - |     - |     32 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  6.277 ms |  0.6695 ms |  0.3392 ms | 5.242 ms |  8.097 ms | 159.31 |     - |     - |     - |     33 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  6.616 ms |  1.7713 ms |  0.8769 ms | 4.772 ms | 12.563 ms | 151.15 |     - |     - |     - |     32 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  6.925 ms |  0.8062 ms |  0.3991 ms | 5.274 ms |  8.750 ms | 144.41 |     - |     - |     - |     33 KB |
|                                           |                       |           |            |            |          |           |        |       |       |       |           |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite |  9.913 ms |  1.6610 ms |  0.8961 ms | 6.221 ms | 13.939 ms | 100.88 |     - |     - |     - |     21 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 11.283 ms |  4.1089 ms |  2.1876 ms | 6.441 ms | 20.944 ms |  88.63 |     - |     - |     - |     21 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 17.704 ms | 12.4139 ms |  6.4432 ms | 6.438 ms | 58.894 ms |  56.49 |     - |     - |     - |     58 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 21.017 ms | 17.2366 ms |  8.7322 ms | 6.367 ms | 72.988 ms |  47.58 |     - |     - |     - |     31 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 21.825 ms | 16.0135 ms |  8.1126 ms | 5.880 ms | 60.419 ms |  45.82 |     - |     - |     - |     21 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 26.752 ms | 21.2481 ms | 10.7645 ms | 8.080 ms | 92.641 ms |  37.38 |     - |     - |     - |     32 KB |
