# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)


``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1202 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.400
  [Host]   : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  ShortRun : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |      Error |      Min |       Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|-----------:|---------:|----------:|-------:|------:|------:|------:|----------:|
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.643 ms |  0.2952 ms |  0.1513 ms | 2.257 ms |  3.435 ms | 378.35 |     - |     - |     - |     47 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  2.646 ms |  0.3198 ms |  0.1583 ms | 2.203 ms |  3.394 ms | 377.94 |     - |     - |     - |     47 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  2.649 ms |  0.3220 ms |  0.1692 ms | 2.085 ms |  3.409 ms | 377.55 |     - |     - |     - |     47 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  2.699 ms |  0.3145 ms |  0.1612 ms | 2.179 ms |  3.650 ms | 370.57 |     - |     - |     - |     47 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  2.701 ms |  0.2907 ms |  0.1509 ms | 2.327 ms |  3.496 ms | 370.19 |     - |     - |     - |     47 KB |
|                                    Single | InsightBenchmarkWrite |  2.702 ms |  0.3225 ms |  0.1654 ms | 2.209 ms |  3.531 ms | 370.16 |     - |     - |     - |     47 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.703 ms |  0.3425 ms |  0.1778 ms | 2.203 ms |  3.839 ms | 369.94 |     - |     - |     - |     47 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  2.704 ms |  0.3472 ms |  0.1873 ms | 2.146 ms |  3.754 ms | 369.84 |     - |     - |     - |     49 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.725 ms |  0.3676 ms |  0.1841 ms | 2.118 ms |  3.908 ms | 366.92 |     - |     - |     - |     47 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.729 ms |  0.3012 ms |  0.1545 ms | 2.188 ms |  3.422 ms | 366.47 |     - |     - |     - |     47 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  2.732 ms |  0.2992 ms |  0.1498 ms | 2.214 ms |  3.584 ms | 366.07 |     - |     - |     - |     49 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  2.735 ms |  0.3256 ms |  0.1669 ms | 2.216 ms |  3.522 ms | 365.64 |     - |     - |     - |     47 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  2.737 ms |  0.3222 ms |  0.1652 ms | 2.297 ms |  3.634 ms | 365.40 |     - |     - |     - |     49 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2.751 ms |  0.4226 ms |  0.2116 ms | 2.179 ms |  3.846 ms | 363.53 |     - |     - |     - |     47 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  2.752 ms |  0.3140 ms |  0.1591 ms | 2.180 ms |  3.277 ms | 363.40 |     - |     - |     - |     47 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.753 ms |  0.2985 ms |  0.1530 ms | 2.272 ms |  3.780 ms | 363.24 |     - |     - |     - |     47 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.770 ms |  0.2845 ms |  0.1441 ms | 2.305 ms |  3.511 ms | 361.02 |     - |     - |     - |     49 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.782 ms |  0.3173 ms |  0.1608 ms | 2.193 ms |  3.684 ms | 359.42 |     - |     - |     - |     47 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.789 ms |  0.2828 ms |  0.1506 ms | 2.351 ms |  3.467 ms | 358.59 |     - |     - |     - |     47 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.795 ms |  0.3914 ms |  0.1960 ms | 2.232 ms |  3.691 ms | 357.80 |     - |     - |     - |     49 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.798 ms |  0.3555 ms |  0.1780 ms | 2.310 ms |  3.587 ms | 357.41 |     - |     - |     - |     48 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |  2.799 ms |  0.3252 ms |  0.1667 ms | 2.341 ms |  3.686 ms | 357.29 |     - |     - |     - |     69 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.802 ms |  0.3478 ms |  0.1762 ms | 2.239 ms |  3.676 ms | 356.94 |     - |     - |     - |     47 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |  2.803 ms |  0.3028 ms |  0.1534 ms | 2.340 ms |  3.557 ms | 356.80 |     - |     - |     - |     69 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  2.815 ms |  0.3816 ms |  0.1933 ms | 2.200 ms |  3.930 ms | 355.23 |     - |     - |     - |     47 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  2.826 ms |  0.2883 ms |  0.1535 ms | 2.291 ms |  3.774 ms | 353.88 |     - |     - |     - |     49 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.827 ms |  0.4062 ms |  0.2108 ms | 2.314 ms |  4.200 ms | 353.71 |     - |     - |     - |     49 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.831 ms |  0.2442 ms |  0.1300 ms | 2.433 ms |  3.492 ms | 353.28 |     - |     - |     - |     48 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  2.841 ms |  0.4219 ms |  0.2138 ms | 2.198 ms |  4.140 ms | 352.01 |     - |     - |     - |     49 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  2.850 ms |  0.3911 ms |  0.2005 ms | 2.225 ms |  3.817 ms | 350.91 |     - |     - |     - |     47 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  2.850 ms |  0.3395 ms |  0.1762 ms | 2.316 ms |  3.991 ms | 350.83 |     - |     - |     - |     47 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.851 ms |  0.4260 ms |  0.2184 ms | 2.179 ms |  3.851 ms | 350.78 |     - |     - |     - |     47 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  2.853 ms |  0.3044 ms |  0.1642 ms | 2.271 ms |  3.653 ms | 350.53 |     - |     - |     - |     49 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  2.853 ms |  0.3492 ms |  0.1835 ms | 2.275 ms |  3.706 ms | 350.47 |     - |     - |     - |     47 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.856 ms |  0.3992 ms |  0.2072 ms | 2.261 ms |  3.846 ms | 350.20 |     - |     - |     - |     47 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  2.857 ms |  0.3107 ms |  0.1593 ms | 2.358 ms |  3.550 ms | 349.96 |     - |     - |     - |     47 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.862 ms |  0.3757 ms |  0.1926 ms | 2.198 ms |  3.913 ms | 349.45 |     - |     - |     - |     47 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  2.863 ms |  0.3359 ms |  0.1722 ms | 2.325 ms |  3.732 ms | 349.30 |     - |     - |     - |     49 KB |
|                                    Single |      InsightBenchmark |  2.863 ms |  0.3153 ms |  0.1701 ms | 2.409 ms |  4.090 ms | 349.27 |     - |     - |     - |     14 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.882 ms |  0.5208 ms |  0.2578 ms | 2.236 ms |  4.142 ms | 346.93 |     - |     - |     - |     47 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.893 ms |  0.3195 ms |  0.1638 ms | 2.290 ms |  4.039 ms | 345.69 |     - |     - |     - |     49 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.895 ms |  0.2954 ms |  0.1479 ms | 2.480 ms |  3.634 ms | 345.41 |     - |     - |     - |     49 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.899 ms |  0.3366 ms |  0.1747 ms | 2.276 ms |  3.769 ms | 344.96 |     - |     - |     - |     49 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  2.915 ms |  0.4115 ms |  0.2136 ms | 2.302 ms |  4.217 ms | 343.03 |     - |     - |     - |     47 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.919 ms |  0.3519 ms |  0.1826 ms | 2.337 ms |  3.752 ms | 342.55 |     - |     - |     - |     49 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.928 ms |  0.3699 ms |  0.1874 ms | 2.229 ms |  3.634 ms | 341.58 |     - |     - |     - |     47 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |  2.928 ms |  0.2835 ms |  0.1472 ms | 2.436 ms |  3.501 ms | 341.52 |     - |     - |     - |     69 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  2.956 ms |  0.3870 ms |  0.1984 ms | 2.331 ms |  4.049 ms | 338.33 |     - |     - |     - |     49 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  2.960 ms |  0.4275 ms |  0.2166 ms | 2.357 ms |  4.156 ms | 337.85 |     - |     - |     - |     47 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.966 ms |  0.4332 ms |  0.2277 ms | 2.422 ms |  4.107 ms | 337.15 |     - |     - |     - |     49 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.982 ms |  0.3464 ms |  0.1776 ms | 2.335 ms |  3.882 ms | 335.39 |     - |     - |     - |     49 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  2.983 ms |  0.4332 ms |  0.2145 ms | 2.337 ms |  3.971 ms | 335.18 |     - |     - |     - |     47 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  2.989 ms |  1.1487 ms |  0.5889 ms | 2.191 ms |  8.377 ms | 334.60 |     - |     - |     - |     47 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.993 ms |  0.3066 ms |  0.1611 ms | 2.357 ms |  3.952 ms | 334.10 |     - |     - |     - |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  3.005 ms |  0.4553 ms |  0.2280 ms | 2.326 ms |  4.172 ms | 332.75 |     - |     - |     - |     47 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  3.007 ms |  0.4064 ms |  0.2059 ms | 2.373 ms |  3.918 ms | 332.51 |     - |     - |     - |     47 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.015 ms |  0.4633 ms |  0.2347 ms | 2.355 ms |  4.110 ms | 331.64 |     - |     - |     - |     48 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  3.021 ms |  0.4546 ms |  0.2303 ms | 2.334 ms |  4.198 ms | 331.01 |     - |     - |     - |     49 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  3.023 ms |  0.6056 ms |  0.3068 ms | 2.244 ms |  5.426 ms | 330.84 |     - |     - |     - |     47 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |  3.031 ms |  0.4853 ms |  0.2488 ms | 2.267 ms |  4.200 ms | 329.91 |     - |     - |     - |     69 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.062 ms |  0.4499 ms |  0.2253 ms | 2.315 ms |  4.189 ms | 326.58 |     - |     - |     - |     49 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  3.067 ms |  0.5422 ms |  0.2850 ms | 2.265 ms |  4.692 ms | 326.05 |     - |     - |     - |     49 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  3.083 ms |  0.4894 ms |  0.2451 ms | 2.373 ms |  4.595 ms | 324.40 |     - |     - |     - |     49 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  3.125 ms |  1.1484 ms |  0.5960 ms | 2.154 ms |  7.962 ms | 319.97 |     - |     - |     - |     47 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  3.143 ms |  0.4314 ms |  0.2160 ms | 2.573 ms |  4.189 ms | 318.21 |     - |     - |     - |     47 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  3.169 ms |  0.7863 ms |  0.3983 ms | 2.446 ms |  6.349 ms | 315.56 |     - |     - |     - |     49 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.180 ms |  0.6367 ms |  0.3264 ms | 2.387 ms |  5.405 ms | 314.50 |     - |     - |     - |     48 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.243 ms |  0.5808 ms |  0.3014 ms | 2.297 ms |  4.857 ms | 308.32 |     - |     - |     - |     49 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5.881 ms |  0.9787 ms |  0.4901 ms | 4.762 ms |  9.079 ms | 170.03 |     - |     - |     - |     64 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  6.002 ms |  1.0076 ms |  0.5046 ms | 4.816 ms |  8.412 ms | 166.60 |     - |     - |     - |     64 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  6.470 ms |  0.7212 ms |  0.3570 ms | 5.132 ms |  8.218 ms | 154.57 |     - |     - |     - |     65 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  6.881 ms |  0.9763 ms |  0.4888 ms | 5.307 ms |  9.260 ms | 145.32 |     - |     - |     - |     65 KB |
|                                           |                       |           |            |            |          |           |        |       |       |       |           |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |  9.292 ms |  2.0041 ms |  1.0960 ms | 6.244 ms | 15.248 ms | 107.62 |     - |     - |     - |     68 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 13.181 ms |  9.0343 ms |  4.6891 ms | 6.291 ms | 48.520 ms |  75.87 |     - |     - |     - |     57 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 22.456 ms | 17.9779 ms |  9.4491 ms | 7.315 ms | 91.693 ms |  44.53 |     - |     - |     - |     68 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 23.482 ms | 19.2261 ms |  9.7402 ms | 7.127 ms | 74.306 ms |  42.58 |     - |     - |     - |     58 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 24.070 ms | 21.9243 ms | 11.3794 ms | 5.941 ms | 78.916 ms |  41.54 |     - |     - |     - |     58 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 26.479 ms | 23.5943 ms | 12.0970 ms | 6.443 ms | 94.206 ms |  37.77 |     - |     - |     - |     57 KB |
