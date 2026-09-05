# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9278/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min       | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.084 ms | 0.0663 ms | 0.0332 ms |  1.086 ms | 0.9445 ms |  1.224 ms | 922.54 |  20.62 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.086 ms | 0.0658 ms | 0.0346 ms |  1.075 ms | 0.9711 ms |  1.283 ms | 920.95 |   20.6 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.086 ms | 0.0662 ms | 0.0335 ms |  1.072 ms | 0.9807 ms |  1.290 ms | 920.67 |   20.6 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.102 ms | 0.0829 ms | 0.0415 ms |  1.084 ms | 0.9693 ms |  1.321 ms | 907.42 |  20.63 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.112 ms | 0.0683 ms | 0.0342 ms |  1.107 ms | 1.0067 ms |  1.312 ms | 899.38 |  20.92 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.131 ms | 0.0738 ms | 0.0374 ms |  1.127 ms | 1.0024 ms |  1.329 ms | 884.19 |  20.92 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.137 ms | 0.0807 ms | 0.0404 ms |  1.144 ms | 1.0149 ms |  1.303 ms | 879.50 |  20.92 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.137 ms | 0.0776 ms | 0.0398 ms |  1.134 ms | 1.0008 ms |  1.330 ms | 879.28 |  20.95 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.140 ms | 0.0639 ms | 0.0332 ms |  1.136 ms | 1.0327 ms |  1.325 ms | 877.47 |  23.32 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.141 ms | 0.0858 ms | 0.0457 ms |  1.144 ms | 0.9644 ms |  1.289 ms | 876.41 |  23.34 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.149 ms | 0.0880 ms | 0.0446 ms |  1.136 ms | 1.0185 ms |  1.370 ms | 870.59 |   19.7 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.155 ms | 0.1495 ms | 0.0757 ms |  1.108 ms | 0.9553 ms |  1.710 ms | 866.01 |  20.62 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.155 ms | 0.0726 ms | 0.0382 ms |  1.147 ms | 1.0310 ms |  1.323 ms | 865.70 |  20.95 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.162 ms | 0.0759 ms | 0.0389 ms |  1.149 ms | 1.0331 ms |  1.308 ms | 860.90 |  23.34 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.163 ms | 0.0792 ms | 0.0416 ms |  1.155 ms | 1.0085 ms |  1.365 ms | 859.69 |  20.95 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.165 ms | 0.0844 ms | 0.0428 ms |  1.165 ms | 0.9941 ms |  1.405 ms | 858.13 |  23.32 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.171 ms | 0.1404 ms | 0.0720 ms |  1.134 ms | 0.9846 ms |  1.670 ms | 854.30 |  20.92 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.171 ms | 0.1115 ms | 0.0578 ms |  1.149 ms | 0.9913 ms |  1.474 ms | 853.71 |  20.62 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.179 ms | 0.1037 ms | 0.0519 ms |  1.140 ms | 1.0131 ms |  1.482 ms | 848.31 |  20.95 KB |
| Single                                    | InsightBenchmarkWrite |  1.188 ms | 0.1510 ms | 0.0794 ms |  1.147 ms | 1.0209 ms |  1.680 ms | 841.59 |  20.64 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.201 ms | 0.1343 ms | 0.0697 ms |  1.166 ms | 1.0381 ms |  1.706 ms | 832.92 |  23.32 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.201 ms | 0.1321 ms | 0.0703 ms |  1.164 ms | 1.0387 ms |  1.547 ms | 832.38 |  20.63 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.205 ms | 0.1115 ms | 0.0579 ms |  1.174 ms | 1.0015 ms |  1.481 ms | 829.67 |  23.36 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.205 ms | 0.0898 ms | 0.0472 ms |  1.188 ms | 1.0085 ms |  1.390 ms | 829.55 |  23.32 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.209 ms | 0.0780 ms | 0.0405 ms |  1.192 ms | 1.1073 ms |  1.436 ms | 827.00 |  22.88 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.210 ms | 0.1389 ms | 0.0740 ms |  1.191 ms | 1.0261 ms |  1.677 ms | 826.11 |   20.6 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.212 ms | 0.0917 ms | 0.0495 ms |  1.211 ms | 1.0565 ms |  1.430 ms | 824.81 |  23.34 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.216 ms | 0.1160 ms | 0.0634 ms |  1.196 ms | 1.0807 ms |  1.564 ms | 822.54 |  47.06 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.222 ms | 0.1171 ms | 0.0632 ms |  1.195 ms | 1.0405 ms |  1.489 ms | 818.36 |   19.7 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.225 ms | 0.1081 ms | 0.0548 ms |  1.210 ms | 1.0481 ms |  1.491 ms | 816.42 |  23.19 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.227 ms | 0.1682 ms | 0.0873 ms |  1.177 ms | 1.0037 ms |  1.847 ms | 814.85 |   20.6 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.228 ms | 0.1325 ms | 0.0705 ms |  1.192 ms | 1.0524 ms |  1.539 ms | 814.43 |  23.34 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.231 ms | 0.0924 ms | 0.0462 ms |  1.233 ms | 1.0795 ms |  1.453 ms | 812.48 |  23.16 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.233 ms | 0.1535 ms | 0.0787 ms |  1.190 ms | 0.9860 ms |  1.679 ms | 810.77 |  23.36 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.236 ms | 0.1466 ms | 0.0771 ms |  1.232 ms | 1.0093 ms |  1.646 ms | 809.12 |  20.62 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.254 ms | 0.0726 ms | 0.0372 ms |  1.240 ms | 1.1064 ms |  1.391 ms | 797.19 |  22.23 KB |
| Single                                    | InsightBenchmark      |  1.255 ms | 0.1723 ms | 0.0906 ms |  1.210 ms | 1.0305 ms |  1.818 ms | 796.71 |  20.64 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.256 ms | 0.0901 ms | 0.0473 ms |  1.234 ms | 1.1505 ms |  1.519 ms | 795.94 |  25.59 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.260 ms | 0.1535 ms | 0.0797 ms |  1.203 ms | 1.0607 ms |  1.778 ms | 793.36 |  19.76 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.265 ms | 0.0614 ms | 0.0319 ms |  1.268 ms | 1.1383 ms |  1.430 ms | 790.64 |  25.88 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.272 ms | 0.0752 ms | 0.0390 ms |  1.262 ms | 1.1356 ms |  1.433 ms | 786.21 |  21.89 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.274 ms | 0.1636 ms | 0.0829 ms |  1.230 ms | 1.0203 ms |  1.836 ms | 784.72 |  23.34 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.277 ms | 0.1002 ms | 0.0533 ms |  1.257 ms | 1.1049 ms |  1.479 ms | 782.98 |  23.16 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.278 ms | 0.1323 ms | 0.0670 ms |  1.254 ms | 1.0673 ms |  1.637 ms | 782.69 |  23.16 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.288 ms | 0.1474 ms | 0.0765 ms |  1.246 ms | 1.0910 ms |  1.579 ms | 776.67 |  47.05 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.295 ms | 0.1300 ms | 0.0701 ms |  1.256 ms | 1.1179 ms |  1.609 ms | 772.33 |  23.16 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.295 ms | 0.1036 ms | 0.0531 ms |  1.268 ms | 1.1305 ms |  1.665 ms | 772.23 |  25.91 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.300 ms | 0.1268 ms | 0.0694 ms |  1.255 ms | 1.1271 ms |  1.698 ms | 769.34 |  23.19 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.306 ms | 0.0897 ms | 0.0460 ms |  1.301 ms | 1.1980 ms |  1.652 ms | 765.76 |  25.59 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.313 ms | 0.1658 ms | 0.0850 ms |  1.249 ms | 1.0809 ms |  1.932 ms | 761.86 |  23.19 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.316 ms | 0.1398 ms | 0.0765 ms |  1.292 ms | 1.0547 ms |  1.776 ms | 759.75 |  23.16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.321 ms | 0.1435 ms | 0.0736 ms |  1.282 ms | 1.1265 ms |  1.702 ms | 757.16 |  25.59 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.331 ms | 0.1566 ms | 0.0784 ms |  1.282 ms | 1.0881 ms |  1.634 ms | 751.52 |  22.88 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.335 ms | 0.1504 ms | 0.0790 ms |  1.289 ms | 1.0810 ms |  1.814 ms | 749.24 |  23.16 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.337 ms | 0.0848 ms | 0.0452 ms |  1.322 ms | 1.2103 ms |  1.498 ms | 747.77 |  49.32 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.342 ms | 0.1271 ms | 0.0644 ms |  1.335 ms | 1.1448 ms |  1.591 ms | 745.35 |  25.88 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.349 ms | 0.1432 ms | 0.0743 ms |  1.316 ms | 1.1485 ms |  1.955 ms | 741.47 |  25.91 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.357 ms | 0.1844 ms | 0.0957 ms |  1.304 ms | 1.1273 ms |  2.131 ms | 737.11 |  25.88 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.364 ms | 0.1218 ms | 0.0649 ms |  1.338 ms | 1.2021 ms |  1.644 ms | 733.20 |  25.62 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.370 ms | 0.2005 ms | 0.1004 ms |  1.308 ms | 1.1019 ms |  1.874 ms | 729.98 |  23.34 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.379 ms | 0.1500 ms | 0.0789 ms |  1.324 ms | 1.1772 ms |  1.779 ms | 724.93 |  49.61 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.380 ms | 0.1403 ms | 0.0747 ms |  1.371 ms | 1.1580 ms |  1.689 ms | 724.39 |  22.23 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.414 ms | 0.1665 ms | 0.0854 ms |  1.395 ms | 1.1846 ms |  1.843 ms | 707.22 |  25.59 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.417 ms | 0.2405 ms | 0.1218 ms |  1.363 ms | 1.1215 ms |  2.087 ms | 705.72 |   22.9 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.419 ms | 0.2287 ms | 0.1187 ms |  1.361 ms | 1.1574 ms |  2.094 ms | 704.66 |  25.88 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.441 ms | 0.1908 ms | 0.0967 ms |  1.424 ms | 1.1401 ms |  1.961 ms | 694.06 |  22.18 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.457 ms | 0.2918 ms | 0.1496 ms |  1.361 ms | 1.0624 ms |  2.103 ms | 686.23 |  19.76 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.484 ms | 0.1838 ms | 0.0920 ms |  1.454 ms | 1.2003 ms |  1.944 ms | 673.85 |  25.62 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.739 ms | 0.1040 ms | 0.0533 ms |  2.733 ms | 2.5309 ms |  3.001 ms | 365.10 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2.875 ms | 0.3998 ms | 0.2050 ms |  2.754 ms | 2.4976 ms |  4.380 ms | 347.86 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2.878 ms | 0.1045 ms | 0.0517 ms |  2.871 ms | 2.6429 ms |  3.143 ms | 347.49 |  45.65 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.011 ms | 0.1957 ms | 0.1016 ms |  2.950 ms | 2.7901 ms |  3.678 ms | 332.06 |  45.65 KB |
|                                           |                       |           |           |           |           |           |           |        |           |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 10.406 ms | 0.3725 ms | 0.1887 ms | 10.341 ms | 9.8852 ms | 11.353 ms |  96.10 |  22.13 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10.521 ms | 0.3422 ms | 0.1734 ms | 10.570 ms | 9.5110 ms | 11.168 ms |  95.05 |  24.16 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10.645 ms | 0.5122 ms | 0.2565 ms | 10.718 ms | 8.4032 ms | 11.567 ms |  93.94 |  24.79 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10.717 ms | 0.5373 ms | 0.2789 ms | 10.840 ms | 9.0381 ms | 11.756 ms |  93.31 |  22.53 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.758 ms | 0.3847 ms | 0.1972 ms | 10.725 ms | 9.9137 ms | 11.607 ms |  92.95 |  35.02 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.885 ms | 1.6430 ms | 0.8227 ms | 10.478 ms | 9.5749 ms | 18.693 ms |  91.87 |  34.38 KB |
