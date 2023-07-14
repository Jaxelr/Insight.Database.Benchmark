# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                            Method |                  Type |     Mean |    StdDev |     Error |   Median |       Min |       Max |  Op/s | Allocated |
|---------------------------------- |---------------------- |---------:|----------:|----------:|---------:|----------:|----------:|------:|----------:|
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.290 ms | 0.1575 ms | 0.0789 ms | 1.292 ms | 0.9912 ms |  1.692 ms | 775.0 |   9.22 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.301 ms | 0.1391 ms | 0.0705 ms | 1.292 ms | 0.9850 ms |  1.551 ms | 768.4 |   9.22 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.311 ms | 0.1507 ms | 0.0746 ms | 1.299 ms | 0.9611 ms |  1.639 ms | 762.7 |    9.2 KB |
|                            Single | InsightBenchmarkWrite | 1.312 ms | 0.1703 ms | 0.0863 ms | 1.322 ms | 1.0098 ms |  1.699 ms | 762.0 |  13.34 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.314 ms | 0.1886 ms | 0.0944 ms | 1.324 ms | 0.9789 ms |  1.723 ms | 760.8 |   13.5 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.324 ms | 0.1277 ms | 0.0639 ms | 1.321 ms | 1.0383 ms |  1.643 ms | 755.2 |    9.2 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.326 ms | 0.1768 ms | 0.0885 ms | 1.312 ms | 1.0034 ms |  1.744 ms | 754.2 |   9.22 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.330 ms | 0.2204 ms | 0.1116 ms | 1.293 ms | 0.9480 ms |  2.032 ms | 752.0 |  13.64 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.336 ms | 0.1679 ms | 0.0831 ms | 1.357 ms | 0.9711 ms |  1.685 ms | 748.4 |   9.51 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.338 ms | 0.1630 ms | 0.0826 ms | 1.340 ms | 0.9752 ms |  1.641 ms | 747.5 |   9.51 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.353 ms | 0.1753 ms | 0.0868 ms | 1.332 ms | 1.0111 ms |  1.784 ms | 739.3 |   9.51 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.365 ms | 0.1155 ms | 0.0585 ms | 1.378 ms | 1.0816 ms |  1.624 ms | 732.6 |   9.22 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.375 ms | 0.1523 ms | 0.0781 ms | 1.363 ms | 1.0991 ms |  1.667 ms | 727.2 |    9.2 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 1.380 ms | 0.1609 ms | 0.0797 ms | 1.367 ms | 1.1212 ms |  1.728 ms | 724.4 |  13.35 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.387 ms | 0.1316 ms | 0.0675 ms | 1.390 ms | 0.9647 ms |  1.607 ms | 721.2 |  13.64 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.388 ms | 0.1216 ms | 0.0623 ms | 1.376 ms | 1.1269 ms |  1.733 ms | 720.5 |  13.59 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.390 ms | 0.2003 ms | 0.0992 ms | 1.398 ms | 0.9968 ms |  1.869 ms | 719.5 |  13.64 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.414 ms | 0.1461 ms | 0.0749 ms | 1.422 ms | 1.1449 ms |  1.820 ms | 707.1 |   9.51 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.418 ms | 0.1858 ms | 0.0953 ms | 1.431 ms | 1.0396 ms |  1.835 ms | 705.2 |  11.49 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 1.431 ms | 0.1878 ms | 0.0930 ms | 1.420 ms | 1.1224 ms |  1.902 ms | 699.0 |  13.35 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.431 ms | 0.1909 ms | 0.0967 ms | 1.417 ms | 1.0178 ms |  1.892 ms | 698.9 |   13.5 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.443 ms | 0.1621 ms | 0.0803 ms | 1.432 ms | 1.0841 ms |  1.752 ms | 693.0 |  10.88 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.455 ms | 0.1809 ms | 0.0906 ms | 1.481 ms | 0.9888 ms |  1.790 ms | 687.3 |  10.84 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.466 ms | 0.1527 ms | 0.0774 ms | 1.452 ms | 1.1879 ms |  1.735 ms | 682.3 |  13.64 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.473 ms | 0.1614 ms | 0.0817 ms | 1.458 ms | 1.1217 ms |  1.911 ms | 678.8 |  39.02 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 1.493 ms | 0.1278 ms | 0.0663 ms | 1.477 ms | 1.2538 ms |  1.774 ms | 669.7 |  31.78 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.511 ms | 0.1746 ms | 0.0874 ms | 1.498 ms | 1.1243 ms |  1.999 ms | 661.8 |  10.88 KB |
|                            Single |      InsightBenchmark | 1.512 ms | 0.2777 ms | 0.1442 ms | 1.422 ms | 1.1652 ms |  2.146 ms | 661.2 |  13.34 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.515 ms | 0.1630 ms | 0.0816 ms | 1.497 ms | 1.1664 ms |  1.875 ms | 660.1 |  15.63 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.516 ms | 0.1946 ms | 0.0963 ms | 1.475 ms | 1.1396 ms |  2.064 ms | 659.7 |  11.41 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1.539 ms | 0.2353 ms | 0.1165 ms | 1.532 ms | 0.9440 ms |  2.101 ms | 649.7 |     39 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.541 ms | 0.1667 ms | 0.0844 ms | 1.558 ms | 1.0857 ms |  1.855 ms | 648.9 |  15.01 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.548 ms | 0.1580 ms | 0.0791 ms | 1.526 ms | 1.2954 ms |  1.905 ms | 645.9 |  15.26 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.563 ms | 0.1908 ms | 0.0967 ms | 1.570 ms | 1.1370 ms |  1.933 ms | 639.7 |  10.84 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.566 ms | 0.1658 ms | 0.0850 ms | 1.588 ms | 1.1488 ms |  1.914 ms | 638.7 |  15.26 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 1.569 ms | 0.1768 ms | 0.0907 ms | 1.567 ms | 1.2197 ms |  1.948 ms | 637.2 |  14.98 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.583 ms | 0.2204 ms | 0.1103 ms | 1.588 ms | 1.1766 ms |  1.994 ms | 631.5 |  40.64 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.591 ms | 0.1459 ms | 0.0722 ms | 1.584 ms | 1.1544 ms |  1.968 ms | 628.6 |  10.84 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 1.602 ms | 0.1850 ms | 0.0916 ms | 1.601 ms | 1.2906 ms |  2.063 ms | 624.4 |  31.78 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 1.608 ms | 0.2158 ms | 0.1068 ms | 1.578 ms | 1.2487 ms |  2.241 ms | 621.8 |  14.98 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.609 ms | 0.1897 ms | 0.0961 ms | 1.607 ms | 1.2429 ms |  2.079 ms | 621.6 |  40.67 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.683 ms | 0.3307 ms | 0.1637 ms | 1.692 ms | 1.1032 ms |  2.554 ms | 594.2 |  11.44 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.762 ms | 0.2111 ms | 0.1045 ms | 1.793 ms | 1.2474 ms |  2.283 ms | 567.5 |  13.59 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 1.958 ms | 0.1625 ms | 0.0823 ms | 1.940 ms | 1.6746 ms |  2.404 ms | 510.8 |  33.35 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 2.099 ms | 0.2129 ms | 0.1054 ms | 2.124 ms | 1.5572 ms |  2.486 ms | 476.5 |  33.35 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 2.797 ms | 3.6183 ms | 1.8118 ms | 1.483 ms | 1.1061 ms | 17.708 ms | 357.6 |    9.2 KB |
|                                   |                       |          |           |           |          |           |           |       |           |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 2.338 ms | 0.1657 ms | 0.0850 ms | 2.312 ms | 2.0593 ms |  2.641 ms | 427.7 |   4.66 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.452 ms | 0.2086 ms | 0.1045 ms | 2.489 ms | 1.9384 ms |  2.857 ms | 407.8 |   7.26 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.543 ms | 0.2453 ms | 0.1242 ms | 2.537 ms | 1.8520 ms |  3.204 ms | 393.3 |   4.73 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 2.583 ms | 0.2123 ms | 0.1102 ms | 2.555 ms | 2.2060 ms |  3.178 ms | 387.2 |   14.7 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.728 ms | 0.3025 ms | 0.1515 ms | 2.778 ms | 2.1389 ms |  3.304 ms | 366.6 |  10.82 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.796 ms | 0.2379 ms | 0.1191 ms | 2.825 ms | 2.3053 ms |  3.247 ms | 357.6 |  16.74 KB |
