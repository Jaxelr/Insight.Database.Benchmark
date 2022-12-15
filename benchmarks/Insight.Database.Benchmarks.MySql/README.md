# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                                    Method |                  Type |     Mean |     StdDev |     Error |    Median |       Min |       Max |  Op/s | Allocated |
|------------------------------------------ |---------------------- |---------:|-----------:|----------:|----------:|----------:|----------:|------:|----------:|
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.035 ms |  0.2220 ms | 0.1112 ms | 0.9988 ms | 0.6808 ms |  1.732 ms | 965.9 |  20.38 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1.058 ms |  0.2078 ms | 0.1041 ms | 1.0344 ms | 0.6713 ms |  1.503 ms | 945.3 |  20.41 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 1.105 ms |  0.2360 ms | 0.1169 ms | 1.0528 ms | 0.7687 ms |  1.760 ms | 904.8 |  20.85 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.124 ms |  0.3550 ms | 0.1777 ms | 1.0484 ms | 0.6560 ms |  1.872 ms | 889.4 |  20.38 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.149 ms |  0.2983 ms | 0.1477 ms | 1.2093 ms | 0.6513 ms |  1.717 ms | 870.1 |  17.82 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.153 ms |  0.1765 ms | 0.0894 ms | 1.1761 ms | 0.7026 ms |  1.610 ms | 867.3 |  18.47 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.218 ms |  0.2544 ms | 0.1274 ms | 1.1639 ms | 0.7425 ms |  1.996 ms | 820.9 |  18.44 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.233 ms |  0.2810 ms | 0.1391 ms | 1.1821 ms | 0.7792 ms |  1.958 ms | 811.2 |  18.44 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.269 ms |  0.3563 ms | 0.1784 ms | 1.1913 ms | 0.7986 ms |  2.013 ms | 788.1 |  18.47 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.289 ms |  0.2761 ms | 0.1367 ms | 1.3440 ms | 0.6724 ms |  1.818 ms | 775.8 |  20.82 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.347 ms |  0.2122 ms | 0.1051 ms | 1.3599 ms | 0.9609 ms |  1.748 ms | 742.6 |  18.56 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.358 ms |  0.1746 ms | 0.0864 ms | 1.3740 ms | 1.0638 ms |  1.798 ms | 736.2 |  18.56 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.362 ms |  0.1685 ms | 0.0854 ms | 1.3938 ms | 0.9349 ms |  1.688 ms | 734.3 |  18.47 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1.367 ms |  0.2085 ms | 0.1032 ms | 1.2963 ms | 0.9966 ms |  1.867 ms | 731.4 |  20.41 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.380 ms |  0.1677 ms | 0.0850 ms | 1.3715 ms | 1.1005 ms |  1.777 ms | 724.7 |  18.47 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.389 ms |  0.1725 ms | 0.0874 ms | 1.3761 ms | 1.1280 ms |  2.026 ms | 719.8 |  18.13 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.393 ms |  0.1660 ms | 0.0831 ms | 1.3611 ms | 1.0938 ms |  1.888 ms | 718.0 |  18.13 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.395 ms |  0.2272 ms | 0.1138 ms | 1.3855 ms | 0.9359 ms |  1.915 ms | 717.0 |  20.38 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.398 ms |  0.1843 ms | 0.0923 ms | 1.3719 ms | 1.0469 ms |  1.734 ms | 715.3 |  18.44 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.398 ms |  0.1853 ms | 0.0917 ms | 1.3842 ms | 1.1155 ms |  1.786 ms | 715.1 |  18.56 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.404 ms |  0.1966 ms | 0.0973 ms | 1.4120 ms | 1.0606 ms |  1.738 ms | 712.4 |  18.12 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.405 ms |  0.1581 ms | 0.0811 ms | 1.3962 ms | 1.0353 ms |  1.758 ms | 711.9 |  20.82 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1.430 ms |  0.2070 ms | 0.1036 ms | 1.4587 ms | 0.9983 ms |  1.768 ms | 699.3 |  20.85 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1.432 ms |  0.1462 ms | 0.0741 ms | 1.4263 ms | 1.1261 ms |  1.709 ms | 698.1 |  20.85 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.433 ms |  0.1609 ms | 0.0796 ms | 1.4083 ms | 1.1342 ms |  1.818 ms | 697.9 |  18.56 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.436 ms |  0.1832 ms | 0.0917 ms | 1.4330 ms | 1.0563 ms |  1.844 ms | 696.3 |  18.12 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.449 ms |  0.3748 ms | 0.1970 ms | 1.3822 ms | 0.8839 ms |  2.175 ms | 690.1 |  20.82 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1.450 ms |  0.2217 ms | 0.1123 ms | 1.4652 ms | 0.9977 ms |  1.892 ms | 689.7 |  18.15 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.450 ms |  0.2395 ms | 0.1199 ms | 1.4331 ms | 0.8061 ms |  1.913 ms | 689.5 |  18.12 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.451 ms |  0.2071 ms | 0.1025 ms | 1.4227 ms | 1.0768 ms |  2.022 ms | 689.3 |  20.82 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1.452 ms |  0.1820 ms | 0.0901 ms | 1.4376 ms | 1.1164 ms |  1.967 ms | 688.6 |  20.38 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.473 ms |  0.1638 ms | 0.0820 ms | 1.4757 ms | 1.1121 ms |  1.807 ms | 678.9 |  17.82 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.474 ms |  0.2265 ms | 0.1161 ms | 1.4970 ms | 1.0426 ms |  1.964 ms | 678.5 |  18.27 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.474 ms |  0.2342 ms | 0.1159 ms | 1.4770 ms | 1.0092 ms |  1.920 ms | 678.3 |  18.56 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.476 ms |  0.1723 ms | 0.0853 ms | 1.4680 ms | 1.1040 ms |  1.760 ms | 677.4 |  18.56 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 1.482 ms |  0.2351 ms | 0.1177 ms | 1.4774 ms | 1.0308 ms |  1.954 ms | 674.9 |  18.15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.494 ms |  0.2349 ms | 0.1163 ms | 1.4865 ms | 1.1115 ms |  2.054 ms | 669.5 |  18.44 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.494 ms |  0.1668 ms | 0.0835 ms | 1.4928 ms | 1.1381 ms |  1.864 ms | 669.3 |  20.82 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1.497 ms |  0.1864 ms | 0.0933 ms | 1.4778 ms | 1.0791 ms |  1.875 ms | 668.1 |   44.4 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.499 ms |  0.1812 ms | 0.0907 ms | 1.5286 ms | 0.9701 ms |  1.817 ms | 667.0 |  18.12 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1.504 ms |  0.1558 ms | 0.0780 ms | 1.4944 ms | 1.2537 ms |  1.823 ms | 665.1 |  20.42 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.527 ms |  0.2094 ms | 0.1048 ms | 1.5636 ms | 1.1098 ms |  1.846 ms | 654.8 |  20.39 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.560 ms |  0.1705 ms | 0.0844 ms | 1.5412 ms | 1.1668 ms |  1.934 ms | 641.2 |  18.31 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.568 ms |  0.1703 ms | 0.0843 ms | 1.5615 ms | 1.2348 ms |  2.078 ms | 637.7 |  20.39 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.569 ms |  0.2120 ms | 0.1049 ms | 1.5754 ms | 1.1373 ms |  2.006 ms | 637.3 |  44.38 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.575 ms |  0.2319 ms | 0.1161 ms | 1.5247 ms | 1.0607 ms |  2.174 ms | 635.1 |  17.77 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.583 ms |  0.1961 ms | 0.0982 ms | 1.6104 ms | 1.0905 ms |  1.937 ms | 631.6 |  20.82 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.600 ms |  0.1995 ms | 0.0988 ms | 1.6074 ms | 1.2112 ms |  2.156 ms | 624.9 |  44.83 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.602 ms |  0.3089 ms | 0.1529 ms | 1.5360 ms | 1.1356 ms |  2.315 ms | 624.2 |  18.59 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1.635 ms |  0.2017 ms | 0.1010 ms | 1.6385 ms | 1.2611 ms |  2.128 ms | 611.6 |  18.59 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.647 ms |  0.2473 ms | 0.1224 ms | 1.5895 ms | 1.2315 ms |  2.331 ms | 607.1 |  18.27 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.649 ms |  0.3287 ms | 0.1627 ms | 1.5776 ms | 1.1577 ms |  2.439 ms | 606.4 |  18.59 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.679 ms |  0.2121 ms | 0.1087 ms | 1.6688 ms | 1.2754 ms |  2.183 ms | 595.4 |  44.83 KB |
|                                    Single | InsightBenchmarkWrite | 1.702 ms |  0.3369 ms | 0.1687 ms | 1.6986 ms | 1.1030 ms |  2.549 ms | 587.7 |  18.16 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.823 ms |  0.3281 ms | 0.1662 ms | 1.7414 ms | 1.3545 ms |  2.463 ms | 548.5 |  20.39 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 1.837 ms |  0.4624 ms | 0.2315 ms | 1.7654 ms | 1.1178 ms |  2.663 ms | 544.5 |  20.39 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.936 ms |  0.3664 ms | 0.1879 ms | 1.9561 ms | 1.1758 ms |  2.523 ms | 516.5 |  20.82 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 2.022 ms |  0.3596 ms | 0.1780 ms | 1.9712 ms | 1.4378 ms |  2.665 ms | 494.5 |  20.82 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 2.163 ms |  0.2381 ms | 0.1192 ms | 2.2207 ms | 1.6830 ms |  2.592 ms | 462.3 |   50.3 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 2.236 ms |  0.3355 ms | 0.1720 ms | 2.3014 ms | 1.5693 ms |  2.776 ms | 447.2 |  50.77 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 2.386 ms |  0.2894 ms | 0.1466 ms | 2.4316 ms | 1.6867 ms |  2.828 ms | 419.1 |  50.73 KB |
|                                    Single |      InsightBenchmark | 2.502 ms |  0.1238 ms | 0.0635 ms | 2.5002 ms | 2.2727 ms |  2.744 ms | 399.6 |  50.34 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 2.554 ms |  0.1202 ms | 0.0616 ms | 2.5423 ms | 2.3310 ms |  2.863 ms | 391.6 |  50.73 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 2.574 ms |  1.0588 ms | 0.5302 ms | 2.4619 ms | 1.5733 ms |  7.310 ms | 388.5 |  20.85 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 2.578 ms |  0.1873 ms | 0.0938 ms | 2.5447 ms | 2.2193 ms |  2.937 ms | 388.0 |  50.02 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.802 ms |  1.2758 ms | 0.6622 ms | 2.5941 ms | 2.0742 ms |  9.202 ms | 356.9 |  50.61 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3.390 ms |  0.6884 ms | 0.3487 ms | 3.0756 ms | 2.6294 ms |  5.206 ms | 294.9 |  39.38 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3.434 ms |  0.3177 ms | 0.1714 ms | 3.5238 ms | 2.7563 ms |  4.086 ms | 291.2 |  39.84 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 3.464 ms |  0.1824 ms | 0.0947 ms | 3.4133 ms | 3.1181 ms |  3.987 ms | 288.7 |  39.38 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 3.760 ms |  0.4113 ms | 0.2109 ms | 3.7093 ms | 3.2243 ms |  5.203 ms | 266.0 |  39.84 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 4.468 ms |  2.6091 ms | 1.3891 ms | 3.2608 ms | 2.5715 ms | 12.944 ms | 223.8 |  51.33 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 7.770 ms | 12.4249 ms | 6.3704 ms | 3.7883 ms | 1.9952 ms | 70.495 ms | 128.7 |  49.78 KB |
|                                           |                       |          |            |           |           |           |           |       |           |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.331 ms |  0.9788 ms | 0.4901 ms | 3.0486 ms | 1.7644 ms |  5.014 ms | 300.2 |  21.23 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 3.332 ms |  0.8567 ms | 0.4290 ms | 3.1847 ms | 1.8187 ms |  5.299 ms | 300.1 |   20.9 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.957 ms |  0.9013 ms | 0.4462 ms | 4.2271 ms | 2.3081 ms |  5.375 ms | 252.7 |  22.32 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 4.302 ms |  0.9286 ms | 0.4597 ms | 4.5216 ms | 2.2755 ms |  5.762 ms | 232.4 |  21.77 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4.388 ms |  0.9199 ms | 0.4554 ms | 4.5908 ms | 2.3976 ms |  6.160 ms | 227.9 |   31.3 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 5.144 ms |  0.6763 ms | 0.3348 ms | 5.3418 ms | 2.6913 ms |  6.029 ms | 194.4 |  32.41 KB |
