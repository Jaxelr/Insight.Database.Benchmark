# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7705/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.016 ms | 0.0694 ms | 0.0365 ms |  1.005 ms |  0.8911 ms |  1.229 ms | 984.59 |  20.95 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.026 ms | 0.0831 ms | 0.0442 ms |  1.008 ms |  0.9287 ms |  1.254 ms | 974.89 |  20.92 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.054 ms | 0.0960 ms | 0.0498 ms |  1.033 ms |  0.8916 ms |  1.287 ms | 949.18 |  20.92 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.068 ms | 0.1077 ms | 0.0539 ms |  1.042 ms |  0.9239 ms |  1.350 ms | 936.68 |  20.95 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.070 ms | 0.1002 ms | 0.0527 ms |  1.035 ms |  0.9465 ms |  1.384 ms | 934.28 |  52.77 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.079 ms | 0.1394 ms | 0.0698 ms |  1.054 ms |  0.8784 ms |  1.355 ms | 926.95 |  20.92 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.082 ms | 0.1373 ms | 0.0722 ms |  1.053 ms |  0.8845 ms |  1.435 ms | 923.97 |   20.6 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.095 ms | 0.1106 ms | 0.0589 ms |  1.070 ms |  0.9064 ms |  1.379 ms | 913.41 |  20.95 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.095 ms | 0.1308 ms | 0.0687 ms |  1.046 ms |  0.9361 ms |  1.555 ms | 912.95 |   20.6 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.109 ms | 0.1927 ms | 0.0976 ms |  1.020 ms |  0.9089 ms |  1.726 ms | 901.91 |  20.92 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.120 ms | 0.1403 ms | 0.0719 ms |  1.077 ms |  0.9559 ms |  1.512 ms | 893.04 |  23.32 KB |
| Single                                    | InsightBenchmarkWrite |  1.136 ms | 0.1344 ms | 0.0716 ms |  1.101 ms |  0.9424 ms |  1.517 ms | 880.65 |  20.64 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.139 ms | 0.1522 ms | 0.0790 ms |  1.092 ms |  0.9001 ms |  1.600 ms | 878.10 |  20.63 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.150 ms | 0.2051 ms | 0.1052 ms |  1.052 ms |  0.8385 ms |  1.789 ms | 869.83 |   20.6 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.155 ms | 0.1093 ms | 0.0575 ms |  1.138 ms |  0.9927 ms |  1.494 ms | 865.89 |  22.88 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.160 ms | 0.1658 ms | 0.0850 ms |  1.139 ms |  0.8932 ms |  1.443 ms | 862.27 |  20.95 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.161 ms | 0.1730 ms | 0.0910 ms |  1.136 ms |  0.9317 ms |  1.788 ms | 861.50 |  51.93 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.163 ms | 0.1758 ms | 0.0924 ms |  1.101 ms |  0.9492 ms |  1.617 ms | 859.67 |  19.76 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.168 ms | 0.0849 ms | 0.0458 ms |  1.153 ms |  1.0281 ms |  1.404 ms | 856.40 |  25.88 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.174 ms | 0.1692 ms | 0.0878 ms |  1.111 ms |  1.0155 ms |  1.886 ms | 851.87 |  23.34 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.176 ms | 0.1524 ms | 0.0812 ms |  1.142 ms |  0.9718 ms |  1.564 ms | 850.58 |  23.34 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.179 ms | 0.1565 ms | 0.0803 ms |  1.159 ms |  0.9578 ms |  1.568 ms | 848.11 |  23.34 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.183 ms | 0.1507 ms | 0.0773 ms |  1.139 ms |  1.0386 ms |  1.737 ms | 845.12 |  55.51 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.183 ms | 0.1779 ms | 0.0935 ms |  1.133 ms |  0.9767 ms |  1.766 ms | 845.06 |  22.88 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.192 ms | 0.1734 ms | 0.0911 ms |  1.146 ms |  0.9129 ms |  1.544 ms | 838.65 |   19.7 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.197 ms | 0.0927 ms | 0.0481 ms |  1.174 ms |  1.0432 ms |  1.477 ms | 835.20 |  25.88 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.198 ms | 0.1932 ms | 0.1003 ms |  1.147 ms |  0.9496 ms |  1.926 ms | 834.84 |  23.32 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.205 ms | 0.1646 ms | 0.0865 ms |  1.157 ms |  0.9949 ms |  1.742 ms | 829.80 |  23.16 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.206 ms | 0.1766 ms | 0.0916 ms |  1.153 ms |  0.9588 ms |  1.832 ms | 829.31 |  23.16 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.209 ms | 0.1242 ms | 0.0629 ms |  1.186 ms |  1.0542 ms |  1.594 ms | 827.08 |  47.05 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.210 ms | 0.2376 ms | 0.1204 ms |  1.113 ms |  0.9682 ms |  1.932 ms | 826.52 |  20.62 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.217 ms | 0.2053 ms | 0.1079 ms |  1.135 ms |  0.9762 ms |  1.883 ms | 821.96 |  23.32 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.218 ms | 0.1685 ms | 0.0874 ms |  1.163 ms |  1.0059 ms |  1.758 ms | 820.84 |  23.19 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.220 ms | 0.2104 ms | 0.1079 ms |  1.164 ms |  0.9305 ms |  1.942 ms | 819.74 |  20.62 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.222 ms | 0.1637 ms | 0.0839 ms |  1.233 ms |  0.9703 ms |  1.630 ms | 818.62 |   52.8 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.222 ms | 0.1960 ms | 0.1005 ms |  1.155 ms |  1.0022 ms |  1.993 ms | 818.32 |  23.36 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.224 ms | 0.2660 ms | 0.1364 ms |  1.105 ms |  0.9395 ms |  1.908 ms | 816.88 |  20.62 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.225 ms | 0.1394 ms | 0.0715 ms |  1.220 ms |  0.9914 ms |  1.579 ms | 816.52 |  23.32 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.227 ms | 0.2486 ms | 0.1323 ms |  1.160 ms |  1.0073 ms |  2.095 ms | 815.04 |  55.36 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.235 ms | 0.1844 ms | 0.0969 ms |  1.201 ms |  0.9736 ms |  1.802 ms | 809.88 |  23.16 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.237 ms | 0.1425 ms | 0.0730 ms |  1.212 ms |  0.9607 ms |  1.524 ms | 808.27 |  20.62 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.240 ms | 0.1744 ms | 0.0894 ms |  1.194 ms |  1.0119 ms |  1.801 ms | 806.46 |  22.23 KB |
| Single                                    | InsightBenchmark      |  1.241 ms | 0.2856 ms | 0.1430 ms |  1.122 ms |  0.9329 ms |  1.979 ms | 805.50 |  20.64 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.251 ms | 0.2002 ms | 0.1052 ms |  1.194 ms |  0.9662 ms |  1.869 ms | 799.61 |  54.35 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.271 ms | 0.2387 ms | 0.1224 ms |  1.180 ms |  0.9694 ms |  1.871 ms | 786.72 |  47.06 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.281 ms | 0.1883 ms | 0.0989 ms |  1.256 ms |  1.0357 ms |  1.848 ms | 780.58 |  23.34 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.285 ms | 0.2651 ms | 0.1359 ms |  1.169 ms |  1.0209 ms |  2.088 ms | 777.99 |  23.19 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.294 ms | 0.1333 ms | 0.0675 ms |  1.288 ms |  1.1085 ms |  1.572 ms | 772.57 |  25.91 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.294 ms | 0.1234 ms | 0.0648 ms |  1.274 ms |  1.1189 ms |  1.716 ms | 772.52 |  25.91 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.302 ms | 0.1404 ms | 0.0747 ms |  1.277 ms |  1.0920 ms |  1.603 ms | 768.28 |  25.88 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.306 ms | 0.1718 ms | 0.0860 ms |  1.267 ms |  1.0699 ms |  1.641 ms | 765.79 |  58.07 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.323 ms | 0.2911 ms | 0.1493 ms |  1.231 ms |  1.0066 ms |  2.130 ms | 755.84 |  55.34 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.330 ms | 0.2404 ms | 0.1232 ms |  1.294 ms |  0.9974 ms |  1.885 ms | 751.63 |  23.34 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.332 ms | 0.2518 ms | 0.1307 ms |  1.240 ms |  1.0630 ms |  1.998 ms | 750.96 |   19.7 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.333 ms | 0.2207 ms | 0.1145 ms |  1.255 ms |  1.1229 ms |  2.100 ms | 749.91 |  25.88 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.339 ms | 0.2469 ms | 0.1266 ms |  1.297 ms |  1.0083 ms |  2.205 ms | 747.10 |  23.16 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.341 ms | 0.3425 ms | 0.1756 ms |  1.181 ms |  1.0366 ms |  2.350 ms | 745.99 |  22.18 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.350 ms | 0.2682 ms | 0.1375 ms |  1.276 ms |  0.9587 ms |  2.248 ms | 740.47 |  23.16 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.355 ms | 0.2155 ms | 0.1132 ms |  1.281 ms |  1.1163 ms |  1.863 ms | 738.16 |  58.05 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.359 ms | 0.2044 ms | 0.1061 ms |  1.344 ms |  1.0356 ms |  2.100 ms | 735.81 |  25.88 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.359 ms | 0.1656 ms | 0.0860 ms |  1.356 ms |  1.0858 ms |  1.714 ms | 735.60 |  49.61 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.373 ms | 0.2060 ms | 0.1069 ms |  1.350 ms |  1.0803 ms |  1.954 ms | 728.48 |  25.88 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.383 ms | 0.2866 ms | 0.1435 ms |  1.291 ms |  1.0568 ms |  2.502 ms | 723.16 |  49.61 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.409 ms | 0.2405 ms | 0.1233 ms |  1.358 ms |  1.0458 ms |  2.153 ms | 709.90 |  23.36 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.419 ms | 0.3097 ms | 0.1569 ms |  1.365 ms |  1.0134 ms |  2.452 ms | 704.76 |  21.94 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.433 ms | 0.3159 ms | 0.1682 ms |  1.303 ms |  1.0976 ms |  2.192 ms | 697.74 |  25.59 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.512 ms | 0.3791 ms | 0.1921 ms |  1.434 ms |  1.0001 ms |  2.464 ms | 661.31 |  23.19 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.712 ms | 0.5534 ms | 0.2771 ms |  1.569 ms |  1.0006 ms |  3.152 ms | 584.19 |  58.07 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.646 ms | 0.1640 ms | 0.0821 ms |  2.660 ms |  2.3510 ms |  2.992 ms | 377.90 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2.870 ms | 0.2048 ms | 0.1037 ms |  2.831 ms |  2.5828 ms |  3.423 ms | 348.45 |  45.65 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  3.005 ms | 0.5333 ms | 0.2768 ms |  2.820 ms |  2.4686 ms |  4.552 ms | 332.73 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.140 ms | 0.3866 ms | 0.1982 ms |  3.001 ms |  2.6860 ms |  4.335 ms | 318.48 |  45.65 KB |
|                                           |                       |           |           |           |           |            |           |        |           |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.715 ms | 0.5521 ms | 0.2902 ms | 10.729 ms |  9.2964 ms | 11.719 ms |  93.33 |  34.38 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 10.726 ms | 0.5483 ms | 0.2846 ms | 10.706 ms |  9.6815 ms | 12.116 ms |  93.23 |  22.13 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10.865 ms | 0.6727 ms | 0.3408 ms | 10.755 ms |  9.4712 ms | 12.608 ms |  92.04 |  22.53 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.011 ms | 0.6231 ms | 0.3362 ms | 11.048 ms |  9.1099 ms | 12.588 ms |  90.82 |  24.16 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.108 ms | 0.4194 ms | 0.2125 ms | 11.115 ms | 10.2379 ms | 12.062 ms |  90.02 |  35.02 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.249 ms | 0.6960 ms | 0.3706 ms | 11.210 ms |  9.9129 ms | 13.010 ms |  88.90 |  24.79 KB |
