# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1083 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.301
  [Host]   : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  ShortRun : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                                    Method |                  Type |      Mean |     StdDev |      Error |      Min |        Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |----------:|-----------:|-----------:|---------:|-----------:|-------:|------:|------:|------:|----------:|
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.784 ms |  0.2764 ms |  0.1384 ms | 2.320 ms |   3.445 ms | 359.16 |     - |     - |     - |     15 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.817 ms |  0.2392 ms |  0.1226 ms | 2.345 ms |   3.256 ms | 354.95 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  2.841 ms |  0.2121 ms |  0.1160 ms | 2.507 ms |   3.399 ms | 352.02 |     - |     - |     - |     14 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.879 ms |  0.2903 ms |  0.1546 ms | 2.301 ms |   3.639 ms | 347.30 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.879 ms |  0.2769 ms |  0.1386 ms | 2.319 ms |   3.488 ms | 347.30 |     - |     - |     - |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  2.885 ms |  0.2697 ms |  0.1455 ms | 2.372 ms |   3.522 ms | 346.63 |     - |     - |     - |     15 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.892 ms |  0.3461 ms |  0.1819 ms | 2.330 ms |   3.773 ms | 345.82 |     - |     - |     - |     15 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  2.893 ms |  0.3916 ms |  0.2032 ms | 2.293 ms |   3.946 ms | 345.63 |     - |     - |     - |     14 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2.900 ms |  0.2228 ms |  0.1236 ms | 2.382 ms |   3.363 ms | 344.78 |     - |     - |     - |     15 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.902 ms |  0.4122 ms |  0.2113 ms | 2.351 ms |   4.393 ms | 344.61 |     - |     - |     - |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.914 ms |  0.2058 ms |  0.1055 ms | 2.512 ms |   3.382 ms | 343.20 |     - |     - |     - |     15 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  2.915 ms |  0.2455 ms |  0.1307 ms | 2.460 ms |   3.593 ms | 343.10 |     - |     - |     - |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  2.924 ms |  0.2899 ms |  0.1486 ms | 2.303 ms |   3.524 ms | 341.95 |     - |     - |     - |     16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  2.934 ms |  0.3077 ms |  0.1617 ms | 2.466 ms |   4.096 ms | 340.87 |     - |     - |     - |     17 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  2.936 ms |  0.3996 ms |  0.2074 ms | 2.296 ms |   3.983 ms | 340.63 |     - |     - |     - |     15 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  2.958 ms |  0.2935 ms |  0.1505 ms | 2.523 ms |   3.883 ms | 338.09 |     - |     - |     - |     15 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  2.961 ms |  0.3885 ms |  0.1992 ms | 2.433 ms |   4.201 ms | 337.77 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.961 ms |  0.4090 ms |  0.2097 ms | 2.343 ms |   4.240 ms | 337.72 |     - |     - |     - |     15 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  2.966 ms |  0.2983 ms |  0.1548 ms | 2.347 ms |   3.612 ms | 337.12 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  2.969 ms |  0.2980 ms |  0.1587 ms | 2.452 ms |   3.903 ms | 336.86 |     - |     - |     - |     14 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  2.979 ms |  0.3176 ms |  0.1628 ms | 2.327 ms |   3.786 ms | 335.70 |     - |     - |     - |     16 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.980 ms |  0.2441 ms |  0.1317 ms | 2.612 ms |   3.751 ms | 335.60 |     - |     - |     - |     15 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  2.981 ms |  0.4109 ms |  0.2133 ms | 2.307 ms |   4.457 ms | 335.50 |     - |     - |     - |     15 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2.981 ms |  0.2455 ms |  0.1343 ms | 2.440 ms |   3.474 ms | 335.47 |     - |     - |     - |     16 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  2.983 ms |  0.2615 ms |  0.1309 ms | 2.547 ms |   3.749 ms | 335.22 |     - |     - |     - |     17 KB |
|                                    Single | InsightBenchmarkWrite |  2.995 ms |  0.2757 ms |  0.1468 ms | 2.568 ms |   3.542 ms | 333.90 |     - |     - |     - |     14 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.995 ms |  0.2563 ms |  0.1330 ms | 2.408 ms |   3.594 ms | 333.90 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  3.002 ms |  0.2643 ms |  0.1426 ms | 2.521 ms |   3.598 ms | 333.12 |     - |     - |     - |     17 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.010 ms |  0.4616 ms |  0.2367 ms | 2.450 ms |   4.384 ms | 332.25 |     - |     - |     - |     15 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  3.012 ms |  0.3736 ms |  0.1939 ms | 2.450 ms |   3.711 ms | 332.02 |     - |     - |     - |     15 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  3.016 ms |  0.4057 ms |  0.2080 ms | 2.359 ms |   4.446 ms | 331.60 |     - |     - |     - |     17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.017 ms |  0.3635 ms |  0.1887 ms | 2.373 ms |   4.100 ms | 331.51 |     - |     - |     - |     17 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  3.031 ms |  0.3026 ms |  0.1611 ms | 2.532 ms |   3.923 ms | 329.93 |     - |     - |     - |     16 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  3.034 ms |  0.4563 ms |  0.2312 ms | 2.346 ms |   4.287 ms | 329.57 |     - |     - |     - |     16 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  3.040 ms |  0.3904 ms |  0.1978 ms | 2.411 ms |   4.040 ms | 328.92 |     - |     - |     - |     17 KB |
|                                    Single |      InsightBenchmark |  3.049 ms |  0.3421 ms |  0.1713 ms | 2.376 ms |   3.826 ms | 327.93 |     - |     - |     - |     14 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  3.055 ms |  0.3901 ms |  0.2000 ms | 2.350 ms |   4.011 ms | 327.35 |     - |     - |     - |     15 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  3.057 ms |  0.4904 ms |  0.2611 ms | 2.455 ms |   4.624 ms | 327.12 |     - |     - |     - |     16 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  3.074 ms |  0.4105 ms |  0.2104 ms | 2.298 ms |   4.167 ms | 325.34 |     - |     - |     - |     14 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  3.077 ms |  0.4595 ms |  0.2385 ms | 2.434 ms |   4.550 ms | 324.95 |     - |     - |     - |     14 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  3.078 ms |  0.4131 ms |  0.2144 ms | 2.411 ms |   4.401 ms | 324.94 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  3.081 ms |  0.4472 ms |  0.2293 ms | 2.507 ms |   4.785 ms | 324.54 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  3.084 ms |  0.4006 ms |  0.2054 ms | 2.447 ms |   4.363 ms | 324.23 |     - |     - |     - |     17 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  3.091 ms |  0.5845 ms |  0.2927 ms | 2.347 ms |   4.711 ms | 323.55 |     - |     - |     - |     15 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3.092 ms |  0.3182 ms |  0.1631 ms | 2.686 ms |   4.043 ms | 323.41 |     - |     - |     - |     17 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  3.093 ms |  0.3879 ms |  0.2065 ms | 2.510 ms |   4.384 ms | 323.34 |     - |     - |     - |     17 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  3.093 ms |  0.3390 ms |  0.1760 ms | 2.602 ms |   4.108 ms | 323.28 |     - |     - |     - |     17 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  3.100 ms |  0.4705 ms |  0.2473 ms | 2.461 ms |   4.705 ms | 322.61 |     - |     - |     - |     16 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  3.103 ms |  0.3507 ms |  0.1892 ms | 2.463 ms |   3.934 ms | 322.26 |     - |     - |     - |     15 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  3.124 ms |  0.3815 ms |  0.1956 ms | 2.626 ms |   4.216 ms | 320.14 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  3.132 ms |  0.5310 ms |  0.2756 ms | 2.518 ms |   4.807 ms | 319.27 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  3.135 ms |  0.4552 ms |  0.2334 ms | 2.288 ms |   4.376 ms | 318.93 |     - |     - |     - |     14 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  3.150 ms |  0.4449 ms |  0.2338 ms | 2.661 ms |   4.622 ms | 317.49 |     - |     - |     - |     17 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  3.156 ms |  0.5491 ms |  0.2963 ms | 2.399 ms |   5.047 ms | 316.84 |     - |     - |     - |     14 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  3.157 ms |  0.4843 ms |  0.2513 ms | 2.419 ms |   4.400 ms | 316.79 |     - |     - |     - |     15 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  3.195 ms |  0.4036 ms |  0.2069 ms | 2.543 ms |   4.437 ms | 312.95 |     - |     - |     - |     17 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  3.199 ms |  0.4956 ms |  0.2482 ms | 2.543 ms |   4.719 ms | 312.64 |     - |     - |     - |     14 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  3.226 ms |  0.4902 ms |  0.2544 ms | 2.603 ms |   4.691 ms | 310.01 |     - |     - |     - |     16 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  3.254 ms |  0.4515 ms |  0.2315 ms | 2.407 ms |   4.367 ms | 307.34 |     - |     - |     - |     17 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3.263 ms |  0.7830 ms |  0.4015 ms | 2.383 ms |   6.056 ms | 306.50 |     - |     - |     - |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  3.295 ms |  0.5176 ms |  0.2687 ms | 2.616 ms |   4.450 ms | 303.45 |     - |     - |     - |     15 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  3.300 ms |  0.6977 ms |  0.3815 ms | 2.580 ms |   6.471 ms | 302.99 |     - |     - |     - |     14 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  3.307 ms |  1.1313 ms |  0.5800 ms | 2.393 ms |   7.695 ms | 302.36 |     - |     - |     - |     14 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  3.745 ms |  1.5344 ms |  0.8065 ms | 2.674 ms |  10.301 ms | 267.01 |     - |     - |     - |     16 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5.671 ms |  0.5664 ms |  0.2836 ms | 4.906 ms |   7.209 ms | 176.32 |     - |     - |     - |     32 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  6.313 ms |  0.6784 ms |  0.3359 ms | 5.327 ms |   8.395 ms | 158.39 |     - |     - |     - |     33 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  6.624 ms |  0.7169 ms |  0.3676 ms | 5.538 ms |   8.862 ms | 150.96 |     - |     - |     - |     33 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  6.781 ms |  2.1423 ms |  1.0853 ms | 4.910 ms |  16.643 ms | 147.47 |     - |     - |     - |     32 KB |
|                                           |                       |           |            |            |          |            |        |       |       |       |           |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 10.999 ms |  3.8790 ms |  1.9888 ms | 6.686 ms |  26.258 ms |  90.92 |     - |     - |     - |     21 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 24.500 ms | 33.3033 ms | 16.6758 ms | 6.077 ms | 154.396 ms |  40.82 |     - |     - |     - |     21 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 32.227 ms | 18.4846 ms |  9.5941 ms | 7.620 ms |  79.577 ms |  31.03 |     - |     - |     - |     22 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 37.201 ms | 25.1244 ms | 12.7283 ms | 8.189 ms | 115.286 ms |  26.88 |     - |     - |     - |     21 KB |
