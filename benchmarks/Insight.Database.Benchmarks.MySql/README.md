# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)


``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.302
  [Host]   : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  ShortRun : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |      Error |      Min |        Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|-----------:|---------:|-----------:|-------:|------:|------:|------:|----------:|
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.760 ms |  0.2338 ms |  0.1261 ms | 2.393 ms |   3.287 ms | 362.32 |     - |     - |     - |     15 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  2.818 ms |  0.3100 ms |  0.1570 ms | 2.391 ms |   3.667 ms | 354.84 |     - |     - |     - |     14 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  2.836 ms |  0.3768 ms |  0.1980 ms | 2.345 ms |   4.109 ms | 352.59 |     - |     - |     - |     14 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.854 ms |  0.4028 ms |  0.2065 ms | 2.200 ms |   3.775 ms | 350.34 |     - |     - |     - |     14 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  2.861 ms |  0.4213 ms |  0.2110 ms | 2.263 ms |   3.942 ms | 349.52 |     - |     - |     - |     14 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.868 ms |  0.2982 ms |  0.1568 ms | 2.493 ms |   3.805 ms | 348.72 |     - |     - |     - |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.873 ms |  0.3323 ms |  0.1683 ms | 2.325 ms |   3.757 ms | 348.08 |     - |     - |     - |     16 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.875 ms |  0.4094 ms |  0.2099 ms | 2.330 ms |   4.031 ms | 347.82 |     - |     - |     - |     16 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.878 ms |  0.3874 ms |  0.1986 ms | 2.312 ms |   4.090 ms | 347.47 |     - |     - |     - |     15 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2.883 ms |  0.3676 ms |  0.1862 ms | 2.254 ms |   3.861 ms | 346.88 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.895 ms |  0.4509 ms |  0.2284 ms | 2.323 ms |   4.245 ms | 345.37 |     - |     - |     - |     14 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  2.905 ms |  0.3251 ms |  0.1709 ms | 2.383 ms |   3.903 ms | 344.20 |     - |     - |     - |     16 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  2.910 ms |  0.4247 ms |  0.2204 ms | 2.342 ms |   4.064 ms | 343.59 |     - |     - |     - |     14 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.918 ms |  0.3566 ms |  0.1807 ms | 2.281 ms |   4.153 ms | 342.71 |     - |     - |     - |     15 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.926 ms |  0.3321 ms |  0.1746 ms | 2.326 ms |   3.682 ms | 341.71 |     - |     - |     - |     17 KB |
|                                    Single |      InsightBenchmark |  2.926 ms |  0.3462 ms |  0.1797 ms | 2.432 ms |   3.922 ms | 341.71 |     - |     - |     - |     14 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.936 ms |  0.3668 ms |  0.1928 ms | 2.280 ms |   4.388 ms | 340.65 |     - |     - |     - |     15 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  2.952 ms |  0.4121 ms |  0.2139 ms | 2.390 ms |   4.251 ms | 338.71 |     - |     - |     - |     15 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.958 ms |  0.3075 ms |  0.1637 ms | 2.288 ms |   3.934 ms | 338.09 |     - |     - |     - |     15 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  2.958 ms |  0.3687 ms |  0.1938 ms | 2.436 ms |   3.905 ms | 338.05 |     - |     - |     - |     17 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  2.963 ms |  0.3222 ms |  0.1694 ms | 2.471 ms |   4.042 ms | 337.45 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  2.968 ms |  0.3278 ms |  0.1681 ms | 2.424 ms |   3.685 ms | 336.96 |     - |     - |     - |     17 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  2.987 ms |  0.3882 ms |  0.1966 ms | 2.384 ms |   3.947 ms | 334.80 |     - |     - |     - |     17 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.989 ms |  0.4819 ms |  0.2413 ms | 2.389 ms |   4.238 ms | 334.53 |     - |     - |     - |     16 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.991 ms |  0.3595 ms |  0.1821 ms | 2.411 ms |   3.888 ms | 334.28 |     - |     - |     - |     16 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  2.999 ms |  0.5570 ms |  0.2856 ms | 2.309 ms |   5.207 ms | 333.50 |     - |     - |     - |     14 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  3.003 ms |  0.4226 ms |  0.2221 ms | 2.343 ms |   4.259 ms | 332.95 |     - |     - |     - |     15 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.007 ms |  0.2433 ms |  0.1232 ms | 2.508 ms |   3.608 ms | 332.58 |     - |     - |     - |     17 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  3.011 ms |  0.3574 ms |  0.1833 ms | 2.411 ms |   3.973 ms | 332.10 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.013 ms |  0.3984 ms |  0.2094 ms | 2.438 ms |   4.045 ms | 331.92 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  3.027 ms |  0.4179 ms |  0.2117 ms | 2.326 ms |   3.908 ms | 330.39 |     - |     - |     - |     14 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  3.028 ms |  0.4248 ms |  0.2178 ms | 2.352 ms |   4.023 ms | 330.27 |     - |     - |     - |     17 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  3.031 ms |  0.3451 ms |  0.1708 ms | 2.378 ms |   3.785 ms | 329.89 |     - |     - |     - |     15 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  3.035 ms |  0.5375 ms |  0.2723 ms | 2.245 ms |   4.605 ms | 329.47 |     - |     - |     - |     14 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  3.036 ms |  0.3761 ms |  0.2002 ms | 2.354 ms |   3.654 ms | 329.33 |     - |     - |     - |     14 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  3.038 ms |  0.3581 ms |  0.1793 ms | 2.430 ms |   3.736 ms | 329.20 |     - |     - |     - |     17 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.040 ms |  0.4825 ms |  0.2416 ms | 2.438 ms |   4.155 ms | 328.93 |     - |     - |     - |     15 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  3.043 ms |  0.3797 ms |  0.1947 ms | 2.479 ms |   4.026 ms | 328.64 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  3.045 ms |  0.3381 ms |  0.1800 ms | 2.436 ms |   4.075 ms | 328.44 |     - |     - |     - |     15 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.047 ms |  0.3875 ms |  0.2037 ms | 2.488 ms |   4.111 ms | 328.19 |     - |     - |     - |     17 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  3.048 ms |  0.5081 ms |  0.2605 ms | 2.343 ms |   4.686 ms | 328.07 |     - |     - |     - |     15 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.056 ms |  0.4049 ms |  0.2076 ms | 2.355 ms |   3.929 ms | 327.24 |     - |     - |     - |     17 KB |
|                                    Single | InsightBenchmarkWrite |  3.058 ms |  0.4150 ms |  0.2154 ms | 2.426 ms |   4.092 ms | 327.05 |     - |     - |     - |     14 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  3.058 ms |  0.3305 ms |  0.1759 ms | 2.575 ms |   4.199 ms | 327.04 |     - |     - |     - |     17 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  3.060 ms |  0.5019 ms |  0.2708 ms | 2.461 ms |   5.210 ms | 326.79 |     - |     - |     - |     17 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  3.086 ms |  0.5469 ms |  0.2951 ms | 2.462 ms |   5.032 ms | 323.99 |     - |     - |     - |     16 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  3.098 ms |  0.5132 ms |  0.2600 ms | 2.326 ms |   4.487 ms | 322.80 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  3.100 ms |  0.3700 ms |  0.1996 ms | 2.641 ms |   4.714 ms | 322.61 |     - |     - |     - |     15 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  3.120 ms |  0.4898 ms |  0.2542 ms | 2.483 ms |   4.583 ms | 320.52 |     - |     - |     - |     15 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  3.125 ms |  0.4579 ms |  0.2320 ms | 2.402 ms |   4.310 ms | 320.05 |     - |     - |     - |     17 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  3.127 ms |  0.4175 ms |  0.2167 ms | 2.526 ms |   4.083 ms | 319.78 |     - |     - |     - |     15 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  3.136 ms |  0.4079 ms |  0.2117 ms | 2.410 ms |   4.204 ms | 318.87 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  3.139 ms |  0.4866 ms |  0.2465 ms | 2.351 ms |   4.189 ms | 318.62 |     - |     - |     - |     15 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  3.142 ms |  0.5844 ms |  0.2961 ms | 2.384 ms |   4.731 ms | 318.29 |     - |     - |     - |     14 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  3.153 ms |  0.5897 ms |  0.2988 ms | 2.324 ms |   5.176 ms | 317.13 |     - |     - |     - |     14 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  3.161 ms |  0.5150 ms |  0.2640 ms | 2.348 ms |   4.481 ms | 316.37 |     - |     - |     - |     15 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  3.164 ms |  0.6211 ms |  0.3110 ms | 2.355 ms |   4.730 ms | 316.08 |     - |     - |     - |     15 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  3.190 ms |  0.4864 ms |  0.2408 ms | 2.512 ms |   4.605 ms | 313.52 |     - |     - |     - |     17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.191 ms |  0.4981 ms |  0.2523 ms | 2.437 ms |   4.914 ms | 313.37 |     - |     - |     - |     17 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.235 ms |  0.5677 ms |  0.2947 ms | 2.316 ms |   4.688 ms | 309.14 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.333 ms |  0.6963 ms |  0.3659 ms | 2.421 ms |   5.996 ms | 300.06 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  3.339 ms |  1.7898 ms |  0.9177 ms | 2.469 ms |  11.794 ms | 299.46 |     - |     - |     - |     15 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  3.401 ms |  0.8194 ms |  0.4253 ms | 2.422 ms |   5.462 ms | 294.02 |     - |     - |     - |     16 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5.940 ms |  1.1173 ms |  0.5729 ms | 4.776 ms |  10.277 ms | 168.35 |     - |     - |     - |     32 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  6.191 ms |  0.8751 ms |  0.4382 ms | 4.952 ms |   8.020 ms | 161.52 |     - |     - |     - |     32 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  6.205 ms |  0.6523 ms |  0.3266 ms | 5.170 ms |   7.765 ms | 161.15 |     - |     - |     - |     33 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  7.244 ms |  1.1808 ms |  0.6054 ms | 5.587 ms |  11.193 ms | 138.04 |     - |     - |     - |     33 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 10.602 ms | 16.1857 ms |  8.2985 ms | 2.288 ms |  77.501 ms |  94.33 |     - |     - |     - |     16 KB |
|                                           |                       |           |            |            |          |            |        |       |       |       |           |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 14.520 ms |  9.8833 ms |  5.1946 ms | 6.825 ms |  56.521 ms |  68.87 |     - |     - |     - |     22 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 24.026 ms | 14.9419 ms |  7.6608 ms | 7.448 ms |  61.858 ms |  41.62 |     - |     - |     - |     21 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 24.185 ms | 16.9495 ms |  8.6902 ms | 6.442 ms |  70.734 ms |  41.35 |     - |     - |     - |     21 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 34.587 ms | 47.5273 ms | 24.9801 ms | 7.577 ms | 205.463 ms |  28.91 |     - |     - |     - |     21 KB |
