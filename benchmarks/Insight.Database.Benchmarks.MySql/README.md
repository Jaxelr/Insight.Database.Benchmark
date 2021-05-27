# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.300
  [Host]   : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  ShortRun : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |      Error |      Min |       Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|-----------:|---------:|----------:|-------:|------:|------:|------:|----------:|
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  2.830 ms |  0.2612 ms |  0.1373 ms | 2.466 ms |  3.432 ms | 353.38 |     - |     - |     - |     15 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  2.853 ms |  0.2891 ms |  0.1520 ms | 2.420 ms |  3.912 ms | 350.57 |     - |     - |     - |     17 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  2.854 ms |  0.3252 ms |  0.1688 ms | 2.288 ms |  3.851 ms | 350.43 |     - |     - |     - |     14 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.856 ms |  0.1850 ms |  0.0960 ms | 2.441 ms |  3.179 ms | 350.18 |     - |     - |     - |     15 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.857 ms |  0.3265 ms |  0.1635 ms | 2.284 ms |  3.976 ms | 350.01 |     - |     - |     - |     14 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.864 ms |  0.2408 ms |  0.1317 ms | 2.420 ms |  3.544 ms | 349.13 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.864 ms |  0.2632 ms |  0.1303 ms | 2.298 ms |  3.410 ms | 349.13 |     - |     - |     - |     15 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.874 ms |  0.2370 ms |  0.1230 ms | 2.488 ms |  3.550 ms | 347.97 |     - |     - |     - |     16 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.882 ms |  0.2997 ms |  0.1596 ms | 2.355 ms |  3.663 ms | 346.93 |     - |     - |     - |     14 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  2.883 ms |  0.2616 ms |  0.1341 ms | 2.313 ms |  3.535 ms | 346.88 |     - |     - |     - |     15 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  2.884 ms |  0.2349 ms |  0.1176 ms | 2.524 ms |  3.513 ms | 346.69 |     - |     - |     - |     14 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.901 ms |  0.3037 ms |  0.1596 ms | 2.441 ms |  4.042 ms | 344.66 |     - |     - |     - |     15 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  2.907 ms |  0.2950 ms |  0.1531 ms | 2.472 ms |  3.855 ms | 343.96 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  2.908 ms |  0.3515 ms |  0.1760 ms | 2.337 ms |  3.944 ms | 343.84 |     - |     - |     - |     14 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.912 ms |  0.2921 ms |  0.1480 ms | 2.369 ms |  3.618 ms | 343.43 |     - |     - |     - |     15 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  2.921 ms |  0.2799 ms |  0.1386 ms | 2.429 ms |  3.516 ms | 342.30 |     - |     - |     - |     18 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.922 ms |  0.3047 ms |  0.1509 ms | 2.410 ms |  3.968 ms | 342.26 |     - |     - |     - |     16 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  2.923 ms |  0.2856 ms |  0.1447 ms | 2.338 ms |  3.641 ms | 342.16 |     - |     - |     - |     17 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.923 ms |  0.2303 ms |  0.1167 ms | 2.385 ms |  3.393 ms | 342.07 |     - |     - |     - |     18 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.927 ms |  0.3097 ms |  0.1588 ms | 2.353 ms |  3.918 ms | 341.67 |     - |     - |     - |     15 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.928 ms |  0.3016 ms |  0.1510 ms | 2.381 ms |  3.743 ms | 341.48 |     - |     - |     - |     17 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.930 ms |  0.3516 ms |  0.1741 ms | 2.271 ms |  4.130 ms | 341.28 |     - |     - |     - |     15 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2.931 ms |  0.3963 ms |  0.2008 ms | 2.456 ms |  4.139 ms | 341.16 |     - |     - |     - |     17 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2.933 ms |  0.2915 ms |  0.1552 ms | 2.429 ms |  3.716 ms | 340.95 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.945 ms |  0.5221 ms |  0.2677 ms | 2.179 ms |  5.318 ms | 339.51 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.950 ms |  0.3994 ms |  0.2099 ms | 2.442 ms |  4.059 ms | 338.95 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  2.951 ms |  0.2630 ms |  0.1332 ms | 2.588 ms |  3.846 ms | 338.89 |     - |     - |     - |     17 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  2.952 ms |  0.5139 ms |  0.2635 ms | 2.235 ms |  4.373 ms | 338.74 |     - |     - |     - |     14 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.957 ms |  0.2311 ms |  0.1185 ms | 2.592 ms |  3.535 ms | 338.18 |     - |     - |     - |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.957 ms |  0.3253 ms |  0.1629 ms | 2.322 ms |  3.690 ms | 338.15 |     - |     - |     - |     16 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  2.966 ms |  0.2993 ms |  0.1553 ms | 2.311 ms |  3.667 ms | 337.16 |     - |     - |     - |     17 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  2.969 ms |  0.2780 ms |  0.1426 ms | 2.400 ms |  3.642 ms | 336.79 |     - |     - |     - |     17 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2.970 ms |  0.3282 ms |  0.1747 ms | 2.297 ms |  3.900 ms | 336.70 |     - |     - |     - |     16 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  2.972 ms |  0.3539 ms |  0.1772 ms | 2.218 ms |  3.864 ms | 336.43 |     - |     - |     - |     16 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  2.974 ms |  0.2702 ms |  0.1402 ms | 2.422 ms |  3.726 ms | 336.26 |     - |     - |     - |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2.977 ms |  0.2754 ms |  0.1379 ms | 2.445 ms |  3.624 ms | 335.87 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  2.981 ms |  0.2555 ms |  0.1279 ms | 2.543 ms |  3.558 ms | 335.43 |     - |     - |     - |     17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.983 ms |  0.4165 ms |  0.2217 ms | 2.304 ms |  4.152 ms | 335.26 |     - |     - |     - |     17 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  2.984 ms |  0.3948 ms |  0.2049 ms | 2.344 ms |  3.991 ms | 335.13 |     - |     - |     - |     15 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  2.984 ms |  0.2306 ms |  0.1197 ms | 2.460 ms |  3.415 ms | 335.10 |     - |     - |     - |     17 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.987 ms |  0.2760 ms |  0.1450 ms | 2.591 ms |  3.993 ms | 334.76 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  2.995 ms |  0.3220 ms |  0.1715 ms | 2.416 ms |  4.068 ms | 333.94 |     - |     - |     - |     14 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  3.000 ms |  0.2999 ms |  0.1538 ms | 2.461 ms |  3.714 ms | 333.33 |     - |     - |     - |     15 KB |
|                                    Single |      InsightBenchmark |  3.005 ms |  0.2817 ms |  0.1481 ms | 2.489 ms |  3.785 ms | 332.80 |     - |     - |     - |     14 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.008 ms |  0.4688 ms |  0.2464 ms | 2.454 ms |  4.620 ms | 332.49 |     - |     - |     - |     17 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  3.008 ms |  0.5374 ms |  0.2756 ms | 2.346 ms |  4.757 ms | 332.48 |     - |     - |     - |     15 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  3.008 ms |  0.3039 ms |  0.1577 ms | 2.408 ms |  3.867 ms | 332.41 |     - |     - |     - |     15 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  3.019 ms |  0.4963 ms |  0.2576 ms | 2.415 ms |  4.440 ms | 331.23 |     - |     - |     - |     15 KB |
|                                    Single | InsightBenchmarkWrite |  3.025 ms |  0.4771 ms |  0.2508 ms | 2.432 ms |  4.599 ms | 330.63 |     - |     - |     - |     14 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  3.034 ms |  0.4085 ms |  0.2175 ms | 2.482 ms |  4.234 ms | 329.65 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.046 ms |  0.4750 ms |  0.2465 ms | 2.340 ms |  4.284 ms | 328.29 |     - |     - |     - |     15 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  3.049 ms |  0.4888 ms |  0.2602 ms | 2.407 ms |  4.933 ms | 328.03 |     - |     - |     - |     14 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  3.064 ms |  0.4568 ms |  0.2401 ms | 2.339 ms |  4.371 ms | 326.37 |     - |     - |     - |     17 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  3.078 ms |  0.5859 ms |  0.2934 ms | 2.298 ms |  4.573 ms | 324.89 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  3.079 ms |  0.4159 ms |  0.2107 ms | 2.470 ms |  4.428 ms | 324.81 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  3.084 ms |  0.4794 ms |  0.2428 ms | 2.360 ms |  4.235 ms | 324.21 |     - |     - |     - |     14 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  3.098 ms |  0.3417 ms |  0.1692 ms | 2.413 ms |  3.846 ms | 322.77 |     - |     - |     - |     16 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  3.101 ms |  0.4959 ms |  0.2574 ms | 2.386 ms |  4.476 ms | 322.48 |     - |     - |     - |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  3.132 ms |  0.3550 ms |  0.1843 ms | 2.401 ms |  3.887 ms | 319.26 |     - |     - |     - |     16 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  3.149 ms |  0.4794 ms |  0.2552 ms | 2.524 ms |  4.343 ms | 317.57 |     - |     - |     - |     17 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  3.195 ms |  0.7926 ms |  0.4015 ms | 2.273 ms |  5.348 ms | 313.00 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  3.208 ms |  0.4627 ms |  0.2372 ms | 2.549 ms |  4.810 ms | 311.70 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  3.252 ms |  0.4904 ms |  0.2515 ms | 2.627 ms |  4.638 ms | 307.49 |     - |     - |     - |     17 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  3.730 ms |  2.6265 ms |  1.3632 ms | 2.257 ms | 17.570 ms | 268.09 |     - |     - |     - |     14 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  6.375 ms |  1.3008 ms |  0.6514 ms | 4.770 ms | 11.043 ms | 156.86 |     - |     - |     - |     32 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  6.478 ms |  1.4061 ms |  0.7123 ms | 4.828 ms | 12.023 ms | 154.37 |     - |     - |     - |     32 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  6.933 ms |  0.9361 ms |  0.4743 ms | 5.559 ms |  9.717 ms | 144.24 |     - |     - |     - |     33 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  7.026 ms |  1.0278 ms |  0.5207 ms | 5.452 ms |  9.313 ms | 142.34 |     - |     - |     - |     33 KB |
|                                           |                       |           |            |            |          |           |        |       |       |       |           |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 15.732 ms | 16.7985 ms |  8.8292 ms | 6.331 ms | 70.459 ms |  63.56 |     - |     - |     - |     22 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 17.682 ms | 15.5727 ms |  7.9843 ms | 6.626 ms | 67.475 ms |  56.55 |     - |     - |     - |     21 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 22.090 ms | 20.3644 ms | 10.5698 ms | 7.571 ms | 84.045 ms |  45.27 |     - |     - |     - |     21 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 24.533 ms | 17.5743 ms |  9.1216 ms | 8.248 ms | 69.298 ms |  40.76 |     - |     - |     - |     21 KB |
