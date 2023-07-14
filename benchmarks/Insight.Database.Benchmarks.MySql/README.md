# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                    Method |                  Type |     Mean |    StdDev |     Error |   Median |       Min |      Max |  Op/s | Allocated |
|------------------------------------------ |---------------------- |---------:|----------:|----------:|---------:|----------:|---------:|------:|----------:|
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.024 ms | 0.1797 ms | 0.0910 ms | 1.037 ms | 0.7094 ms | 1.409 ms | 976.2 |  18.34 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.135 ms | 0.2692 ms | 0.1397 ms | 1.054 ms | 0.7702 ms | 1.723 ms | 881.4 |  18.77 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.163 ms | 0.2368 ms | 0.1172 ms | 1.148 ms | 0.7237 ms | 1.726 ms | 860.1 |  17.95 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.185 ms | 0.2235 ms | 0.1119 ms | 1.179 ms | 0.6840 ms | 1.626 ms | 843.9 |   18.5 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.276 ms | 0.3336 ms | 0.1651 ms | 1.299 ms | 0.6867 ms | 1.795 ms | 783.8 |  18.77 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.334 ms | 0.2303 ms | 0.1140 ms | 1.383 ms | 0.7358 ms | 1.765 ms | 749.5 |  18.34 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 1.382 ms | 0.1621 ms | 0.0803 ms | 1.351 ms | 1.1470 ms | 1.705 ms | 723.6 |  21.06 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.386 ms | 0.1721 ms | 0.0872 ms | 1.398 ms | 1.0131 ms | 1.735 ms | 721.6 |  18.01 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 1.395 ms | 0.1798 ms | 0.0922 ms | 1.379 ms | 0.9719 ms | 1.828 ms | 717.1 |   20.6 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1.407 ms | 0.1913 ms | 0.0947 ms | 1.404 ms | 0.9646 ms | 1.772 ms | 710.8 |   18.8 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.431 ms | 0.1912 ms | 0.0969 ms | 1.455 ms | 1.0312 ms | 1.834 ms | 698.7 |  18.77 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 1.431 ms | 0.1806 ms | 0.0926 ms | 1.432 ms | 1.0314 ms | 1.724 ms | 698.7 |  20.63 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.433 ms | 0.1820 ms | 0.0922 ms | 1.406 ms | 1.0163 ms | 1.855 ms | 697.8 |  18.45 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.457 ms | 0.2216 ms | 0.1110 ms | 1.449 ms | 0.9504 ms | 1.916 ms | 686.4 |   18.8 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.469 ms | 0.1677 ms | 0.0860 ms | 1.456 ms | 1.0972 ms | 1.815 ms | 680.7 |  18.77 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1.469 ms | 0.2048 ms | 0.1014 ms | 1.491 ms | 0.9661 ms | 1.999 ms | 680.7 |  20.59 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.469 ms | 0.2145 ms | 0.1074 ms | 1.512 ms | 0.9993 ms | 1.789 ms | 680.6 |  21.03 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.470 ms | 0.1651 ms | 0.0836 ms | 1.472 ms | 1.1154 ms | 1.900 ms | 680.1 |  18.33 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.484 ms | 0.1993 ms | 0.1022 ms | 1.481 ms | 0.9478 ms | 1.840 ms | 674.0 |  18.77 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.494 ms | 0.1616 ms | 0.0828 ms | 1.487 ms | 1.1567 ms | 1.798 ms | 669.4 |  18.77 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.500 ms | 0.2190 ms | 0.1109 ms | 1.491 ms | 1.0744 ms | 1.995 ms | 666.8 |  20.59 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.506 ms | 0.2249 ms | 0.1153 ms | 1.479 ms | 1.0924 ms | 2.082 ms | 663.9 |   18.5 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1.506 ms | 0.2142 ms | 0.1060 ms | 1.503 ms | 1.1326 ms | 2.175 ms | 663.8 |  20.63 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 1.507 ms | 0.1994 ms | 0.0999 ms | 1.518 ms | 1.0578 ms | 1.972 ms | 663.8 |  18.36 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.508 ms | 0.2598 ms | 0.1286 ms | 1.490 ms | 0.9445 ms | 2.082 ms | 663.2 |  18.77 KB |
|                                    Single | InsightBenchmarkWrite | 1.509 ms | 0.2166 ms | 0.1072 ms | 1.515 ms | 1.1089 ms | 2.118 ms | 662.6 |  18.38 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.510 ms | 0.1640 ms | 0.0831 ms | 1.514 ms | 1.1730 ms | 1.797 ms | 662.3 |  18.01 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.515 ms | 0.1862 ms | 0.0955 ms | 1.522 ms | 1.1845 ms | 1.948 ms | 660.0 |  18.33 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.519 ms | 0.1560 ms | 0.0772 ms | 1.517 ms | 1.1759 ms | 1.858 ms | 658.5 |  21.03 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1.526 ms | 0.2061 ms | 0.1032 ms | 1.473 ms | 1.1739 ms | 1.958 ms | 655.5 |   18.8 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1.527 ms | 0.1825 ms | 0.0947 ms | 1.542 ms | 1.1562 ms | 2.014 ms | 654.7 |  21.06 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.532 ms | 0.1465 ms | 0.0770 ms | 1.514 ms | 1.2316 ms | 1.850 ms | 652.6 |  18.33 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.571 ms | 0.1510 ms | 0.0748 ms | 1.615 ms | 1.2823 ms | 1.857 ms | 636.3 |  18.68 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.572 ms | 0.1682 ms | 0.0842 ms | 1.557 ms | 1.1655 ms | 1.946 ms | 636.1 |  18.65 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.574 ms | 0.2039 ms | 0.1021 ms | 1.593 ms | 1.0991 ms | 1.990 ms | 635.2 |   20.6 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.578 ms | 0.1842 ms | 0.0923 ms | 1.575 ms | 1.0978 ms | 1.972 ms | 633.9 |  18.33 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.578 ms | 0.2187 ms | 0.1108 ms | 1.644 ms | 1.1797 ms | 1.989 ms | 633.7 |   18.8 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.582 ms | 0.1874 ms | 0.0938 ms | 1.589 ms | 1.1534 ms | 2.011 ms | 632.3 |  18.68 KB |
|                                    Single |      InsightBenchmark | 1.584 ms | 0.1743 ms | 0.0873 ms | 1.609 ms | 1.1703 ms | 1.918 ms | 631.2 |  18.38 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.586 ms | 0.2096 ms | 0.1062 ms | 1.583 ms | 1.0774 ms | 2.070 ms | 630.4 |  20.59 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.592 ms | 0.1831 ms | 0.0917 ms | 1.592 ms | 1.2475 ms | 2.002 ms | 628.2 |  21.03 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.592 ms | 0.1639 ms | 0.0821 ms | 1.608 ms | 1.2144 ms | 1.945 ms | 628.2 |  21.03 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.593 ms | 0.1686 ms | 0.0844 ms | 1.582 ms | 1.2173 ms | 1.919 ms | 627.9 |  18.65 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1.608 ms | 0.1930 ms | 0.0966 ms | 1.550 ms | 1.1554 ms | 2.028 ms | 621.7 |  20.62 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.610 ms | 0.1693 ms | 0.0838 ms | 1.583 ms | 1.0882 ms | 1.967 ms | 621.2 |  18.68 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.614 ms | 0.2031 ms | 0.1005 ms | 1.593 ms | 1.1845 ms | 1.995 ms | 619.6 |  18.45 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.620 ms | 0.2207 ms | 0.1160 ms | 1.609 ms | 1.2330 ms | 2.073 ms | 617.2 |  18.65 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.621 ms | 0.3579 ms | 0.1813 ms | 1.529 ms | 1.0777 ms | 2.506 ms | 616.8 |  18.65 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.631 ms | 0.3689 ms | 0.1847 ms | 1.534 ms | 1.1341 ms | 2.447 ms | 613.2 |  18.34 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1.633 ms | 0.1383 ms | 0.0685 ms | 1.628 ms | 1.3075 ms | 1.904 ms | 612.2 |  20.62 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.638 ms | 0.2593 ms | 0.1298 ms | 1.647 ms | 1.1325 ms | 2.198 ms | 610.6 |  18.34 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1.640 ms | 0.2301 ms | 0.1152 ms | 1.606 ms | 1.0857 ms | 2.353 ms | 609.7 |  44.61 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.643 ms | 0.1594 ms | 0.0789 ms | 1.655 ms | 1.3512 ms | 1.993 ms | 608.5 |  20.59 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.654 ms | 0.1903 ms | 0.0942 ms | 1.629 ms | 1.3078 ms | 2.198 ms | 604.5 |  21.03 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 1.666 ms | 0.1728 ms | 0.0865 ms | 1.680 ms | 1.3288 ms | 1.962 ms | 600.1 |  21.06 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.672 ms | 0.1539 ms | 0.0789 ms | 1.679 ms | 1.3583 ms | 2.161 ms | 598.1 |  18.68 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.678 ms | 0.2042 ms | 0.1011 ms | 1.677 ms | 1.2611 ms | 2.051 ms | 596.0 |  21.03 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.700 ms | 0.1733 ms | 0.0858 ms | 1.707 ms | 1.2571 ms | 1.994 ms | 588.3 |  45.04 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.701 ms | 0.1625 ms | 0.0804 ms | 1.708 ms | 1.3334 ms | 2.087 ms | 587.8 |  21.03 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1.702 ms | 0.2664 ms | 0.1349 ms | 1.706 ms | 1.1734 ms | 2.414 ms | 587.6 |  21.06 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.702 ms | 0.2008 ms | 0.1005 ms | 1.727 ms | 1.2166 ms | 2.126 ms | 587.5 |  45.04 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1.724 ms | 0.3478 ms | 0.1762 ms | 1.702 ms | 1.2526 ms | 2.541 ms | 580.1 |  18.36 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.744 ms | 0.2321 ms | 0.1190 ms | 1.717 ms | 1.3750 ms | 2.414 ms | 573.4 |  21.03 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.786 ms | 0.2203 ms | 0.1129 ms | 1.730 ms | 1.3979 ms | 2.358 ms | 559.9 |  44.59 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.793 ms | 0.2546 ms | 0.1290 ms | 1.791 ms | 1.2501 ms | 2.487 ms | 557.8 |   20.6 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.843 ms | 0.3450 ms | 0.1748 ms | 1.811 ms | 1.3127 ms | 2.801 ms | 542.6 |   20.6 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.860 ms | 0.4595 ms | 0.2415 ms | 1.671 ms | 1.2858 ms | 2.864 ms | 537.7 |  18.77 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 2.030 ms | 0.7519 ms | 0.3765 ms | 1.825 ms | 1.2545 ms | 4.067 ms | 492.5 |  17.95 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3.792 ms | 0.2527 ms | 0.1311 ms | 3.745 ms | 3.3223 ms | 4.511 ms | 263.7 |  39.68 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3.843 ms | 0.3904 ms | 0.2002 ms | 3.788 ms | 3.3034 ms | 5.425 ms | 260.2 |  40.14 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 3.979 ms | 0.4578 ms | 0.2347 ms | 3.835 ms | 3.2999 ms | 5.068 ms | 251.3 |  39.68 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4.118 ms | 0.4654 ms | 0.2386 ms | 3.977 ms | 3.4652 ms | 5.468 ms | 242.8 |  40.14 KB |
|                                           |                       |          |           |           |          |           |          |       |           |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 2.938 ms | 0.6613 ms | 0.3350 ms | 2.963 ms | 1.6028 ms | 4.263 ms | 340.4 |  21.02 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.298 ms | 1.1330 ms | 0.5740 ms | 3.052 ms | 1.5916 ms | 6.273 ms | 303.2 |  22.44 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.713 ms | 1.0106 ms | 0.5003 ms | 3.785 ms | 1.7516 ms | 5.662 ms | 269.3 |  21.34 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3.911 ms | 0.9193 ms | 0.4657 ms | 4.048 ms | 1.9295 ms | 5.348 ms | 255.7 |  32.53 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4.106 ms | 0.9362 ms | 0.4634 ms | 4.381 ms | 2.2337 ms | 5.424 ms | 243.5 |  31.41 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 4.680 ms | 0.6505 ms | 0.3220 ms | 4.672 ms | 2.8591 ms | 6.466 ms | 213.7 |  21.88 KB |
