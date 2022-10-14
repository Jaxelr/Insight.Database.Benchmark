# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |     Error |   Median |       Min |       Max |   Op/s | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|----------:|---------:|----------:|----------:|-------:|----------:|
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  1.284 ms |  0.3066 ms | 0.1553 ms | 1.186 ms | 0.8637 ms |  2.107 ms | 778.82 |     18 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  1.297 ms |  0.1942 ms | 0.0996 ms | 1.257 ms | 0.9515 ms |  1.715 ms | 771.24 |     18 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  1.351 ms |  0.2847 ms | 0.1409 ms | 1.379 ms | 0.8964 ms |  2.011 ms | 740.23 |     18 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  1.365 ms |  0.2997 ms | 0.1518 ms | 1.326 ms | 0.8475 ms |  2.220 ms | 732.83 |     19 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  1.375 ms |  0.3486 ms | 0.1726 ms | 1.303 ms | 0.8740 ms |  2.683 ms | 727.16 |     18 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  1.403 ms |  0.2521 ms | 0.1263 ms | 1.384 ms | 1.0117 ms |  1.969 ms | 712.76 |     19 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  1.491 ms |  0.4013 ms | 0.2009 ms | 1.470 ms | 0.9082 ms |  2.384 ms | 670.59 |     19 KB |
|                                    Single |      InsightBenchmark |  1.511 ms |  0.2927 ms | 0.1519 ms | 1.448 ms | 1.0180 ms |  2.179 ms | 661.83 |     18 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  1.555 ms |  0.2498 ms | 0.1251 ms | 1.527 ms | 1.1494 ms |  2.126 ms | 643.22 |     21 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  1.719 ms |  0.2576 ms | 0.1290 ms | 1.738 ms | 1.2162 ms |  2.274 ms | 581.90 |     21 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  1.733 ms |  0.2607 ms | 0.1321 ms | 1.709 ms | 1.2646 ms |  2.393 ms | 576.94 |     21 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  1.787 ms |  0.3555 ms | 0.1801 ms | 1.724 ms | 1.2659 ms |  2.855 ms | 559.61 |     18 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  1.822 ms |  0.2783 ms | 0.1410 ms | 1.772 ms | 1.3457 ms |  2.527 ms | 548.92 |     19 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  1.832 ms |  0.2092 ms | 0.1072 ms | 1.813 ms | 1.4109 ms |  2.393 ms | 545.91 |     18 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  1.886 ms |  0.4285 ms | 0.2197 ms | 1.840 ms | 1.2487 ms |  3.254 ms | 530.22 |     20 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  1.887 ms |  0.2577 ms | 0.1291 ms | 1.829 ms | 1.4932 ms |  2.618 ms | 529.94 |     19 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  1.890 ms |  0.4073 ms | 0.2063 ms | 1.803 ms | 1.2436 ms |  2.957 ms | 529.19 |     20 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  1.900 ms |  0.2404 ms | 0.1204 ms | 1.877 ms | 1.4365 ms |  2.567 ms | 526.44 |     20 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.920 ms |  0.2837 ms | 0.1405 ms | 1.856 ms | 1.5133 ms |  2.689 ms | 520.85 |     19 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  1.937 ms |  0.2228 ms | 0.1129 ms | 1.923 ms | 1.3579 ms |  2.453 ms | 516.27 |     18 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  1.962 ms |  0.2613 ms | 0.1308 ms | 1.946 ms | 1.3610 ms |  2.575 ms | 509.65 |     21 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  1.962 ms |  0.4052 ms | 0.2053 ms | 1.875 ms | 1.3570 ms |  2.930 ms | 509.60 |     20 KB |
|                                    Single | InsightBenchmarkWrite |  1.988 ms |  0.2708 ms | 0.1341 ms | 2.009 ms | 1.3623 ms |  2.554 ms | 503.00 |     18 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  2.014 ms |  0.3643 ms | 0.1803 ms | 1.942 ms | 1.3687 ms |  2.874 ms | 496.62 |     18 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.027 ms |  0.2699 ms | 0.1336 ms | 2.043 ms | 1.5350 ms |  2.560 ms | 493.26 |     19 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.040 ms |  0.4427 ms | 0.2243 ms | 1.896 ms | 1.3793 ms |  3.277 ms | 490.26 |     18 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.040 ms |  0.2967 ms | 0.1469 ms | 2.012 ms | 1.4610 ms |  2.898 ms | 490.13 |     21 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |  2.058 ms |  0.2903 ms | 0.1454 ms | 1.988 ms | 1.5636 ms |  2.668 ms | 485.94 |     45 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.073 ms |  0.2981 ms | 0.1510 ms | 2.132 ms | 1.5346 ms |  2.614 ms | 482.34 |     21 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  2.132 ms |  0.4285 ms | 0.2197 ms | 2.115 ms | 1.3923 ms |  3.226 ms | 469.12 |     18 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  2.134 ms |  0.5166 ms | 0.2617 ms | 2.052 ms | 1.3530 ms |  4.270 ms | 468.64 |     21 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.149 ms |  0.2652 ms | 0.1313 ms | 2.086 ms | 1.7165 ms |  2.855 ms | 465.40 |     18 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.151 ms |  0.4223 ms | 0.2114 ms | 2.047 ms | 1.4147 ms |  3.576 ms | 464.83 |     21 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.161 ms |  0.3487 ms | 0.1726 ms | 2.155 ms | 1.4276 ms |  3.018 ms | 462.80 |     18 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2.174 ms |  0.3460 ms | 0.1733 ms | 2.194 ms | 1.3780 ms |  3.097 ms | 460.02 |     19 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.174 ms |  0.4172 ms | 0.2065 ms | 2.169 ms | 1.2985 ms |  3.654 ms | 459.92 |     20 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.191 ms |  0.2991 ms | 0.1497 ms | 2.233 ms | 1.3513 ms |  2.826 ms | 456.44 |     21 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.199 ms |  0.5637 ms | 0.2890 ms | 2.066 ms | 1.6886 ms |  5.103 ms | 454.67 |     18 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.256 ms |  0.5162 ms | 0.2555 ms | 2.148 ms | 1.3470 ms |  3.274 ms | 443.26 |     19 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |  2.286 ms |  0.4430 ms | 0.2244 ms | 2.199 ms | 1.4711 ms |  3.465 ms | 437.45 |     45 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.316 ms |  0.3800 ms | 0.1948 ms | 2.202 ms | 1.6011 ms |  3.463 ms | 431.84 |     21 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  2.347 ms |  0.3338 ms | 0.1691 ms | 2.369 ms | 1.4667 ms |  3.113 ms | 426.10 |     18 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.373 ms |  0.3332 ms | 0.1649 ms | 2.413 ms | 1.7899 ms |  3.236 ms | 421.44 |     18 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  2.393 ms |  0.4673 ms | 0.2367 ms | 2.348 ms | 1.4811 ms |  3.492 ms | 417.81 |     18 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |  2.407 ms |  0.5405 ms | 0.2738 ms | 2.525 ms | 1.5919 ms |  3.414 ms | 415.40 |     44 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |  2.416 ms |  0.4684 ms | 0.2319 ms | 2.327 ms | 1.6767 ms |  3.222 ms | 413.88 |     44 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  2.429 ms |  0.5762 ms | 0.2885 ms | 2.247 ms | 1.5881 ms |  3.783 ms | 411.68 |     20 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.499 ms |  0.9511 ms | 0.4936 ms | 2.674 ms | 1.1930 ms |  5.135 ms | 400.18 |     18 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.505 ms |  0.5169 ms | 0.2619 ms | 2.496 ms | 1.4814 ms |  3.983 ms | 399.28 |     18 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  2.521 ms |  0.8462 ms | 0.4339 ms | 2.352 ms | 1.2402 ms |  4.871 ms | 396.71 |     20 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  2.543 ms |  0.4113 ms | 0.2036 ms | 2.538 ms | 1.8293 ms |  3.596 ms | 393.26 |     21 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  2.590 ms |  0.3800 ms | 0.1972 ms | 2.589 ms | 1.8173 ms |  3.472 ms | 386.14 |     20 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.591 ms |  0.3300 ms | 0.1692 ms | 2.589 ms | 1.9640 ms |  3.633 ms | 385.94 |     18 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.701 ms |  0.4592 ms | 0.2273 ms | 2.751 ms | 1.8612 ms |  3.664 ms | 370.24 |     19 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  2.776 ms |  0.7853 ms | 0.3978 ms | 2.662 ms | 1.6703 ms |  4.861 ms | 360.20 |     18 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.801 ms |  0.6691 ms | 0.3430 ms | 2.642 ms | 1.9083 ms |  4.684 ms | 356.99 |     20 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.826 ms |  0.4653 ms | 0.2330 ms | 2.666 ms | 1.8970 ms |  3.772 ms | 353.80 |     18 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.888 ms |  0.6407 ms | 0.3246 ms | 2.693 ms | 1.6605 ms |  4.346 ms | 346.23 |     21 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  2.891 ms |  1.2052 ms | 0.6106 ms | 2.410 ms | 1.6739 ms |  6.770 ms | 345.91 |     21 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  3.024 ms |  0.3866 ms | 0.1959 ms | 2.950 ms | 2.4179 ms |  4.566 ms | 330.64 |     18 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.055 ms |  1.3690 ms | 0.7289 ms | 2.648 ms | 1.7698 ms |  8.207 ms | 327.35 |     18 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  3.125 ms |  1.2327 ms | 0.6479 ms | 2.733 ms | 2.0694 ms |  8.406 ms | 320.02 |     18 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  3.166 ms |  1.6085 ms | 0.7963 ms | 2.531 ms | 1.8424 ms |  8.326 ms | 315.83 |     21 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  3.185 ms |  0.7562 ms | 0.3786 ms | 2.945 ms | 2.1067 ms |  4.791 ms | 313.97 |     19 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  4.245 ms |  1.9548 ms | 1.0022 ms | 3.696 ms | 2.4487 ms | 11.776 ms | 235.56 |     19 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  5.012 ms |  7.7487 ms | 3.9256 ms | 2.843 ms | 1.7900 ms | 48.271 ms | 199.51 |     18 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  5.294 ms |  1.4374 ms | 0.7282 ms | 4.710 ms | 3.6827 ms |  9.501 ms | 188.90 |     40 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  6.093 ms |  8.7488 ms | 4.4323 ms | 2.865 ms | 1.9082 ms | 37.962 ms | 164.13 |     18 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  6.292 ms |  1.5174 ms | 0.7598 ms | 6.032 ms | 3.8722 ms |  9.025 ms | 158.93 |     39 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  6.618 ms |  1.9173 ms | 0.9951 ms | 5.967 ms | 4.2443 ms | 10.420 ms | 151.10 |     40 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  7.979 ms | 11.7745 ms | 6.1886 ms | 2.887 ms | 1.9987 ms | 49.968 ms | 125.32 |     18 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 10.514 ms |  6.0311 ms | 3.0554 ms | 8.821 ms | 4.5587 ms | 29.738 ms |  95.11 |     39 KB |
|                                           |                       |           |            |           |          |           |           |        |           |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |  3.808 ms |  0.7332 ms | 0.3629 ms | 3.978 ms | 2.2041 ms |  5.555 ms | 262.59 |     32 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson |  3.901 ms |  0.9857 ms | 0.4880 ms | 3.828 ms | 2.1009 ms |  5.666 ms | 256.36 |     31 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  4.226 ms |  0.8588 ms | 0.4300 ms | 4.336 ms | 2.5903 ms |  6.297 ms | 236.64 |     22 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite |  4.745 ms |  1.7031 ms | 0.8528 ms | 4.599 ms | 2.1949 ms | 10.875 ms | 210.73 |     22 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite |  5.774 ms |  3.0897 ms | 1.5653 ms | 4.915 ms | 2.7961 ms | 19.026 ms | 173.18 |     21 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  6.126 ms |  2.2949 ms | 1.1360 ms | 5.797 ms | 2.4073 ms | 12.338 ms | 163.25 |     21 KB |
