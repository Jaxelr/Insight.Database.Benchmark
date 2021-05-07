# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]   : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  ShortRun : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |      Error |      Min |        Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|-----------:|---------:|-----------:|-------:|------:|------:|------:|----------:|
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.743 ms |  0.2133 ms |  0.1107 ms | 2.327 ms |   3.301 ms | 364.61 |     - |     - |     - |  14.27 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  2.784 ms |  0.2751 ms |  0.1378 ms | 2.284 ms |   3.447 ms | 359.24 |     - |     - |     - |  13.74 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  2.786 ms |  0.2388 ms |  0.1272 ms | 2.380 ms |   3.368 ms | 359.00 |     - |     - |     - |  14.27 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.807 ms |  0.2361 ms |  0.1241 ms | 2.414 ms |   3.348 ms | 356.28 |     - |     - |     - |  16.48 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.810 ms |  0.1943 ms |  0.1009 ms | 2.444 ms |   3.192 ms | 355.84 |     - |     - |     - |  14.27 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.875 ms |  0.3872 ms |  0.1985 ms | 2.210 ms |   3.859 ms | 347.83 |     - |     - |     - |   14.1 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  2.877 ms |  0.3390 ms |  0.1805 ms | 2.352 ms |   3.643 ms | 347.61 |     - |     - |     - |  14.84 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.892 ms |  0.2426 ms |  0.1244 ms | 2.400 ms |   3.479 ms | 345.82 |     - |     - |     - |  16.48 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.892 ms |  0.2854 ms |  0.1429 ms | 2.363 ms |   3.549 ms | 345.76 |     - |     - |     - |  14.66 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.892 ms |  0.3592 ms |  0.1888 ms | 2.303 ms |   4.044 ms | 345.75 |     - |     - |     - |  16.88 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  2.894 ms |  0.3580 ms |  0.1814 ms | 2.398 ms |   3.904 ms | 345.51 |     - |     - |     - |  14.66 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.922 ms |  0.3039 ms |  0.1540 ms | 2.382 ms |   3.547 ms | 342.24 |     - |     - |     - |  16.88 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.922 ms |  0.2746 ms |  0.1391 ms | 2.571 ms |   3.700 ms | 342.20 |     - |     - |     - |  16.49 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.928 ms |  0.3027 ms |  0.1552 ms | 2.428 ms |   3.928 ms | 341.52 |     - |     - |     - |  14.59 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.928 ms |  0.3427 ms |  0.1736 ms | 2.378 ms |   4.149 ms | 341.51 |     - |     - |     - |  14.66 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.931 ms |  0.2346 ms |  0.1203 ms | 2.414 ms |   3.403 ms | 341.20 |     - |     - |     - |   14.7 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  2.934 ms |  0.4171 ms |  0.2165 ms | 2.382 ms |   4.135 ms | 340.83 |     - |     - |     - |  14.63 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  2.940 ms |  0.3722 ms |  0.1908 ms | 2.465 ms |   4.364 ms | 340.16 |     - |     - |     - |  14.28 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2.941 ms |  0.2526 ms |  0.1250 ms | 2.474 ms |   3.577 ms | 340.05 |     - |     - |     - |  14.84 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  2.945 ms |  0.3120 ms |  0.1600 ms | 2.466 ms |   3.715 ms | 339.52 |     - |     - |     - |  14.66 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  2.946 ms |  0.3389 ms |  0.1759 ms | 2.440 ms |   3.871 ms | 339.47 |     - |     - |     - |   15.4 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.967 ms |  0.4000 ms |  0.2103 ms | 2.335 ms |   4.118 ms | 337.10 |     - |     - |     - |  14.59 KB |
|                                    Single | InsightBenchmarkWrite |  2.969 ms |  0.4087 ms |  0.2046 ms | 2.212 ms |   3.983 ms | 336.83 |     - |     - |     - |  14.32 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.973 ms |  0.3732 ms |  0.1937 ms | 2.420 ms |   3.914 ms | 336.36 |     - |     - |     - |  14.59 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.983 ms |  0.4800 ms |  0.2491 ms | 2.339 ms |   4.782 ms | 335.18 |     - |     - |     - |  14.63 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  2.984 ms |  0.3930 ms |  0.2040 ms | 2.438 ms |   4.377 ms | 335.14 |     - |     - |     - |  15.15 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.984 ms |  0.3510 ms |  0.1845 ms | 2.434 ms |   3.846 ms | 335.13 |     - |     - |     - |  14.78 KB |
|                                    Single |      InsightBenchmark |  2.989 ms |  0.4512 ms |  0.2313 ms | 2.318 ms |   4.385 ms | 334.60 |     - |     - |     - |  14.32 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  3.005 ms |  0.5343 ms |  0.2675 ms | 2.393 ms |   4.601 ms | 332.73 |     - |     - |     - |   14.7 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  3.019 ms |  0.5098 ms |  0.2582 ms | 2.210 ms |   4.832 ms | 331.23 |     - |     - |     - |   14.3 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  3.020 ms |  0.3247 ms |  0.1608 ms | 2.459 ms |   3.775 ms | 331.14 |     - |     - |     - |  16.35 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  3.021 ms |  0.3061 ms |  0.1551 ms | 2.430 ms |   3.775 ms | 331.03 |     - |     - |     - |  16.52 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  3.026 ms |  0.4669 ms |  0.2338 ms | 2.369 ms |   4.235 ms | 330.46 |     - |     - |     - |  14.63 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  3.037 ms |  0.5212 ms |  0.2672 ms | 2.340 ms |   4.558 ms | 329.23 |     - |     - |     - |  14.28 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  3.041 ms |  0.4365 ms |  0.2266 ms | 2.472 ms |   4.052 ms | 328.87 |     - |     - |     - |  16.91 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.048 ms |  0.3260 ms |  0.1714 ms | 2.437 ms |   3.721 ms | 328.07 |     - |     - |     - |  16.88 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  3.073 ms |  0.4015 ms |  0.2010 ms | 2.463 ms |   4.259 ms | 325.42 |     - |     - |     - |  14.66 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  3.073 ms |  0.4217 ms |  0.2162 ms | 2.284 ms |   3.938 ms | 325.41 |     - |     - |     - |  16.48 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  3.073 ms |  0.4693 ms |  0.2467 ms | 2.426 ms |   4.200 ms | 325.41 |     - |     - |     - |  14.27 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.093 ms |  0.5268 ms |  0.2638 ms | 2.354 ms |   4.651 ms | 323.33 |     - |     - |     - |  15.23 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  3.102 ms |  0.5397 ms |  0.2767 ms | 2.437 ms |   4.601 ms | 322.33 |     - |     - |     - |  14.67 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  3.105 ms |  0.4568 ms |  0.2314 ms | 2.513 ms |   4.322 ms | 322.07 |     - |     - |     - |  16.49 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  3.108 ms |  0.4705 ms |  0.2442 ms | 2.379 ms |   4.493 ms | 321.73 |     - |     - |     - |  14.84 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  3.109 ms |  0.4145 ms |  0.2207 ms | 2.399 ms |   4.272 ms | 321.69 |     - |     - |     - |  14.66 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  3.122 ms |  0.3945 ms |  0.2022 ms | 2.408 ms |   4.177 ms | 320.35 |     - |     - |     - |  16.49 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.139 ms |  0.5135 ms |  0.2571 ms | 2.546 ms |   5.010 ms | 318.62 |     - |     - |     - |  17.16 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.139 ms |  0.4884 ms |  0.2418 ms | 2.514 ms |   4.267 ms | 318.60 |     - |     - |     - |  14.66 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  3.190 ms |  0.4688 ms |  0.2464 ms | 2.447 ms |   4.524 ms | 313.51 |     - |     - |     - |  16.48 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  3.199 ms |  0.5631 ms |  0.2853 ms | 2.454 ms |   4.841 ms | 312.57 |     - |     - |     - |   14.7 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.215 ms |  0.4218 ms |  0.2162 ms | 2.594 ms |   4.585 ms | 311.03 |     - |     - |     - |  15.28 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.225 ms |  0.5501 ms |  0.2755 ms | 2.565 ms |   5.470 ms | 310.10 |     - |     - |     - |  16.88 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  3.226 ms |  0.4886 ms |  0.2568 ms | 2.638 ms |   4.907 ms | 309.95 |     - |     - |     - |  16.91 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  3.267 ms |  0.5018 ms |  0.2542 ms | 2.548 ms |   4.675 ms | 306.05 |     - |     - |     - |  16.53 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  3.276 ms |  0.6102 ms |  0.3091 ms | 2.444 ms |   4.872 ms | 305.23 |     - |     - |     - |  16.52 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.307 ms |  0.4693 ms |  0.2377 ms | 2.516 ms |   4.351 ms | 302.35 |     - |     - |     - |  16.88 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  3.331 ms |  0.4834 ms |  0.2478 ms | 2.586 ms |   4.602 ms | 300.17 |     - |     - |     - |  16.53 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  3.332 ms |  0.9021 ms |  0.4466 ms | 2.418 ms |   6.597 ms | 300.08 |     - |     - |     - |  14.78 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  3.339 ms |  0.5404 ms |  0.2706 ms | 2.637 ms |   4.592 ms | 299.49 |     - |     - |     - |  16.91 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  3.348 ms |  0.5217 ms |  0.2708 ms | 2.353 ms |   4.721 ms | 298.72 |     - |     - |     - |  15.65 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  3.356 ms |  0.5722 ms |  0.2899 ms | 2.512 ms |   4.998 ms | 298.01 |     - |     - |     - |  16.88 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.394 ms |  1.0555 ms |  0.5619 ms | 2.556 ms |   7.853 ms | 294.68 |     - |     - |     - |  16.88 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  3.774 ms |  1.4045 ms |  0.7201 ms | 2.378 ms |   8.435 ms | 264.98 |     - |     - |     - |  15.28 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5.945 ms |  0.7691 ms |  0.3992 ms | 4.745 ms |   7.575 ms | 168.21 |     - |     - |     - |  32.13 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  6.060 ms |  0.8260 ms |  0.4136 ms | 4.915 ms |   8.452 ms | 165.01 |     - |     - |     - |  32.13 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  6.890 ms |  0.8546 ms |  0.4381 ms | 5.485 ms |   9.081 ms | 145.14 |     - |     - |     - |  32.54 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  6.981 ms |  0.8441 ms |  0.4328 ms | 5.689 ms |   9.147 ms | 143.25 |     - |     - |     - |  32.54 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  7.127 ms | 12.7333 ms |  6.6090 ms | 2.284 ms |  60.086 ms | 140.32 |     - |     - |     - |  14.63 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  7.674 ms | 10.4499 ms |  5.2940 ms | 2.482 ms |  40.920 ms | 130.32 |     - |     - |     - |  14.42 KB |
|                                           |                       |           |            |            |          |            |        |       |       |       |           |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 13.729 ms |  8.6031 ms |  4.4109 ms | 5.849 ms |  39.598 ms |  72.84 |     - |     - |     - |  20.52 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 17.931 ms | 12.5422 ms |  6.6776 ms | 6.527 ms |  49.308 ms |  55.77 |     - |     - |     - |   21.9 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 18.562 ms | 18.6564 ms |  9.4515 ms | 7.507 ms |  95.690 ms |  53.87 |     - |     - |     - |  21.37 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 22.564 ms | 22.3526 ms | 11.4604 ms | 7.381 ms | 113.605 ms |  44.32 |     - |     - |     - |  21.39 KB |
