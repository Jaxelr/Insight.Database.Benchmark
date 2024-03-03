# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3155/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min       | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.183 ms | 0.1396 ms | 0.0716 ms |  1.171 ms | 0.9965 ms |  1.641 ms | 845.02 |  18.34 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.220 ms | 0.1721 ms | 0.0862 ms |  1.193 ms | 0.9532 ms |  1.613 ms | 819.45 |  18.34 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.230 ms | 0.1689 ms | 0.0846 ms |  1.216 ms | 0.9943 ms |  1.676 ms | 813.03 |  18.33 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.231 ms | 0.1376 ms | 0.0697 ms |  1.241 ms | 1.0197 ms |  1.501 ms | 812.52 |  18.32 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.231 ms | 0.1465 ms | 0.0761 ms |  1.202 ms | 1.0163 ms |  1.731 ms | 812.06 |   18.8 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.233 ms | 0.1401 ms | 0.0701 ms |  1.222 ms | 1.0009 ms |  1.555 ms | 810.77 |  18.77 KB |
| Single                                    | InsightBenchmarkWrite |  1.243 ms | 0.1697 ms | 0.0840 ms |  1.194 ms | 1.0333 ms |  1.816 ms | 804.44 |  18.38 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.257 ms | 0.1210 ms | 0.0613 ms |  1.247 ms | 1.0676 ms |  1.575 ms | 795.50 |  17.95 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.259 ms | 0.1475 ms | 0.0747 ms |  1.216 ms | 0.9850 ms |  1.556 ms | 794.33 |  18.45 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.262 ms | 0.1293 ms | 0.0648 ms |  1.258 ms | 1.0714 ms |  1.582 ms | 792.48 |  18.34 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.267 ms | 0.1737 ms | 0.0870 ms |  1.226 ms | 1.0162 ms |  1.663 ms | 789.56 |  18.77 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.274 ms | 0.1917 ms | 0.0960 ms |  1.246 ms | 1.0237 ms |  1.750 ms | 785.02 |  17.95 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.278 ms | 0.1612 ms | 0.0837 ms |  1.248 ms | 1.0367 ms |  1.750 ms | 782.45 |   20.6 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.283 ms | 0.1841 ms | 0.0911 ms |  1.248 ms | 0.9777 ms |  1.721 ms | 779.13 |  21.03 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.288 ms | 0.1331 ms | 0.0674 ms |  1.252 ms | 1.0643 ms |  1.648 ms | 776.20 |   20.6 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.290 ms | 0.1431 ms | 0.0708 ms |  1.255 ms | 1.1034 ms |  1.554 ms | 774.95 |  21.03 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.296 ms | 0.1722 ms | 0.0905 ms |  1.270 ms | 1.0503 ms |  1.762 ms | 771.83 |  20.75 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.297 ms | 0.1409 ms | 0.0714 ms |  1.269 ms | 1.0945 ms |  1.793 ms | 771.07 |   18.8 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.300 ms | 0.1372 ms | 0.0704 ms |  1.299 ms | 1.0446 ms |  1.668 ms | 769.23 |  44.59 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.304 ms | 0.1744 ms | 0.0873 ms |  1.251 ms | 1.0837 ms |  1.795 ms | 766.93 |   20.6 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.304 ms | 0.2002 ms | 0.1002 ms |  1.240 ms | 1.0361 ms |  2.025 ms | 766.60 |  18.49 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.308 ms | 0.1738 ms | 0.0881 ms |  1.266 ms | 1.0942 ms |  1.799 ms | 764.71 |  18.01 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.312 ms | 0.2050 ms | 0.1064 ms |  1.242 ms | 1.0566 ms |  1.891 ms | 762.12 |  18.35 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.313 ms | 0.1454 ms | 0.0728 ms |  1.293 ms | 1.0772 ms |  1.636 ms | 761.63 |  21.06 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.315 ms | 0.1578 ms | 0.0799 ms |  1.297 ms | 1.0265 ms |  1.699 ms | 760.21 |  18.65 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.316 ms | 0.1885 ms | 0.0944 ms |  1.258 ms | 1.0815 ms |  1.966 ms | 759.81 |  20.59 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.317 ms | 0.1416 ms | 0.0717 ms |  1.310 ms | 1.0769 ms |  1.654 ms | 759.44 |  21.03 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.318 ms | 0.1493 ms | 0.0748 ms |  1.296 ms | 1.0958 ms |  1.603 ms | 758.84 |  21.03 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.319 ms | 0.1745 ms | 0.0874 ms |  1.270 ms | 1.0903 ms |  1.788 ms | 757.88 |  21.06 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.321 ms | 0.1585 ms | 0.0785 ms |  1.277 ms | 1.0952 ms |  1.810 ms | 757.08 |  45.04 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.329 ms | 0.1807 ms | 0.0905 ms |  1.279 ms | 1.0689 ms |  1.994 ms | 752.66 |   18.8 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.330 ms | 0.1530 ms | 0.0766 ms |  1.306 ms | 1.1375 ms |  1.773 ms | 751.83 |  45.04 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.334 ms | 0.2497 ms | 0.1280 ms |  1.318 ms | 0.9649 ms |  1.942 ms | 749.72 |  18.33 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.339 ms | 0.1748 ms | 0.0865 ms |  1.312 ms | 1.0744 ms |  1.781 ms | 746.60 |   20.3 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.342 ms | 0.2332 ms | 0.1168 ms |  1.310 ms | 1.0821 ms |  2.259 ms | 745.06 |  21.06 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.345 ms | 0.1877 ms | 0.0962 ms |  1.326 ms | 1.0814 ms |  1.844 ms | 743.38 |   18.5 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.351 ms | 0.1429 ms | 0.0742 ms |  1.368 ms | 1.0163 ms |  1.679 ms | 740.16 |   18.5 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.363 ms | 0.1378 ms | 0.0698 ms |  1.361 ms | 1.0533 ms |  1.669 ms | 733.66 |  20.62 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.377 ms | 0.2001 ms | 0.0991 ms |  1.364 ms | 1.0688 ms |  1.841 ms | 726.34 |  18.08 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.383 ms | 0.2637 ms | 0.1336 ms |  1.312 ms | 1.0155 ms |  2.054 ms | 723.07 |  18.34 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.384 ms | 0.2289 ms | 0.1146 ms |  1.329 ms | 1.0211 ms |  1.844 ms | 722.56 |  18.45 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.395 ms | 0.2106 ms | 0.1042 ms |  1.337 ms | 1.0672 ms |  1.994 ms | 716.59 |  44.61 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.397 ms | 0.1831 ms | 0.0917 ms |  1.397 ms | 1.0977 ms |  1.960 ms | 715.66 |  20.63 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.400 ms | 0.2223 ms | 0.1140 ms |  1.359 ms | 1.1048 ms |  2.105 ms | 714.53 |  20.63 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.404 ms | 0.2215 ms | 0.1109 ms |  1.403 ms | 1.1052 ms |  2.061 ms | 712.24 |   20.6 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.424 ms | 0.1680 ms | 0.0851 ms |  1.427 ms | 1.0797 ms |  1.876 ms | 702.13 |  18.45 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.448 ms | 0.3962 ms | 0.2007 ms |  1.341 ms | 0.9999 ms |  2.414 ms | 690.70 |  18.77 KB |
| Single                                    | InsightBenchmark      |  1.461 ms | 0.2749 ms | 0.1361 ms |  1.399 ms | 1.0855 ms |  2.310 ms | 684.61 |  18.38 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.496 ms | 0.3099 ms | 0.1589 ms |  1.470 ms | 1.1313 ms |  2.501 ms | 668.55 |  21.03 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.744 ms | 0.4585 ms | 0.2380 ms |  1.771 ms | 1.0380 ms |  2.793 ms | 573.47 |  18.45 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.865 ms | 1.0589 ms | 0.5364 ms |  1.522 ms | 1.1201 ms |  6.880 ms | 536.19 |  18.68 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.871 ms | 0.2542 ms | 0.1273 ms |  1.881 ms | 1.4413 ms |  2.621 ms | 534.51 |  18.77 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.872 ms | 0.2352 ms | 0.1192 ms |  1.855 ms | 1.3962 ms |  2.495 ms | 534.17 |  18.33 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.901 ms | 0.2118 ms | 0.1086 ms |  1.854 ms | 1.5239 ms |  2.413 ms | 526.15 |  20.62 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.901 ms | 0.2193 ms | 0.1086 ms |  1.895 ms | 1.4771 ms |  2.381 ms | 526.10 |  17.73 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.908 ms | 0.2003 ms | 0.1015 ms |  1.904 ms | 1.5379 ms |  2.289 ms | 524.23 |  18.36 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.913 ms | 0.3285 ms | 0.1705 ms |  1.900 ms | 1.3959 ms |  2.716 ms | 522.77 |  18.77 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.932 ms | 0.2551 ms | 0.1277 ms |  1.899 ms | 1.5022 ms |  2.450 ms | 517.58 |  20.59 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.946 ms | 0.3605 ms | 0.1848 ms |  1.892 ms | 1.3560 ms |  3.114 ms | 513.97 |  18.33 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.955 ms | 0.3163 ms | 0.1603 ms |  1.907 ms | 1.4576 ms |  2.771 ms | 511.55 |  21.03 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.979 ms | 0.3223 ms | 0.1614 ms |  1.933 ms | 1.4690 ms |  2.825 ms | 505.34 |   18.8 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.995 ms | 0.3251 ms | 0.1647 ms |  1.922 ms | 1.4599 ms |  3.074 ms | 501.14 |  18.65 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  2.007 ms | 0.2696 ms | 0.1399 ms |  2.036 ms | 1.5190 ms |  2.575 ms | 498.14 |  18.37 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  2.016 ms | 0.3739 ms | 0.1851 ms |  2.001 ms | 1.4432 ms |  3.116 ms | 496.13 |  21.06 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  2.079 ms | 0.4041 ms | 0.2047 ms |  1.972 ms | 1.5548 ms |  3.129 ms | 480.96 |   20.3 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  2.082 ms | 0.5524 ms | 0.2904 ms |  1.988 ms | 1.5871 ms |  5.043 ms | 480.24 |   18.4 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  2.126 ms | 0.4574 ms | 0.2374 ms |  1.988 ms | 1.6366 ms |  3.801 ms | 470.33 |  18.68 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.220 ms | 0.4462 ms | 0.2345 ms |  2.160 ms | 1.5300 ms |  3.155 ms | 450.54 |  20.75 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2.939 ms | 0.1412 ms | 0.0715 ms |  2.926 ms | 2.6123 ms |  3.234 ms | 340.20 |  39.68 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2.956 ms | 0.1084 ms | 0.0577 ms |  2.963 ms | 2.6658 ms |  3.203 ms | 338.28 |  40.14 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  3.935 ms | 0.5357 ms | 0.2714 ms |  3.852 ms | 3.1048 ms |  5.149 ms | 254.15 |   39.4 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  4.293 ms | 0.7001 ms | 0.3547 ms |  4.281 ms | 3.3150 ms |  5.653 ms | 232.95 |  40.14 KB |
|                                           |                       |           |           |           |           |           |           |        |           |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite |  6.115 ms | 3.0979 ms | 1.5883 ms |  4.963 ms | 3.0987 ms | 12.477 ms | 163.53 |  21.02 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.317 ms | 1.4151 ms | 0.7255 ms | 10.781 ms | 5.8508 ms | 11.863 ms |  96.92 |  31.41 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10.645 ms | 0.4393 ms | 0.2252 ms | 10.644 ms | 9.8794 ms | 11.737 ms |  93.94 |  21.88 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10.666 ms | 0.3705 ms | 0.1947 ms | 10.716 ms | 9.6860 ms | 11.442 ms |  93.76 |  22.44 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.789 ms | 0.6628 ms | 0.3440 ms | 10.651 ms | 9.5051 ms | 13.688 ms |  92.69 |  32.53 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.332 ms | 0.9522 ms | 0.4942 ms | 11.369 ms | 7.0506 ms | 13.078 ms |  88.25 |  21.34 KB |
