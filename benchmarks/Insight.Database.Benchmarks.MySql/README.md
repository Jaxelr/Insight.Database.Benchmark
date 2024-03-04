# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3235/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min       | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.089 ms | 0.0831 ms | 0.0442 ms |  1.087 ms | 0.9701 ms |  1.281 ms | 918.46 |  50.21 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.099 ms | 0.0824 ms | 0.0428 ms |  1.087 ms | 0.9724 ms |  1.289 ms | 910.26 |  18.28 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.099 ms | 0.0722 ms | 0.0380 ms |  1.096 ms | 0.9742 ms |  1.271 ms | 910.00 |  50.47 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.102 ms | 0.1280 ms | 0.0682 ms |  1.067 ms | 0.9294 ms |  1.472 ms | 907.28 |  18.93 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.118 ms | 0.0876 ms | 0.0467 ms |  1.118 ms | 0.9581 ms |  1.470 ms | 894.23 |  18.76 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.122 ms | 0.0697 ms | 0.0367 ms |  1.113 ms | 0.9874 ms |  1.339 ms | 891.31 |   50.9 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.126 ms | 0.1179 ms | 0.0620 ms |  1.101 ms | 0.9667 ms |  1.493 ms | 887.80 |  50.47 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.127 ms | 0.0782 ms | 0.0416 ms |  1.110 ms | 1.0001 ms |  1.316 ms | 887.45 |  18.76 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.127 ms | 0.1308 ms | 0.0679 ms |  1.089 ms | 0.9514 ms |  1.687 ms | 887.20 |  50.47 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.130 ms | 0.0782 ms | 0.0416 ms |  1.127 ms | 1.0048 ms |  1.316 ms | 884.73 |  20.55 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.133 ms | 0.1251 ms | 0.0658 ms |  1.096 ms | 0.9619 ms |  1.584 ms | 882.56 |  18.31 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.138 ms | 0.1024 ms | 0.0545 ms |  1.131 ms | 0.9629 ms |  1.527 ms | 879.00 |  50.93 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.138 ms | 0.0719 ms | 0.0388 ms |  1.133 ms | 1.0311 ms |  1.339 ms | 878.92 |  52.73 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.139 ms | 0.1288 ms | 0.0686 ms |  1.098 ms | 0.9499 ms |  1.397 ms | 878.35 |  18.28 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.139 ms | 0.1031 ms | 0.0535 ms |  1.126 ms | 0.9986 ms |  1.432 ms | 877.90 |  18.73 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.140 ms | 0.0965 ms | 0.0501 ms |  1.126 ms | 0.9960 ms |  1.454 ms | 877.56 |   50.9 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.141 ms | 0.0885 ms | 0.0471 ms |  1.119 ms | 1.0110 ms |  1.355 ms | 876.64 |  50.48 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.145 ms | 0.1791 ms | 0.0930 ms |  1.101 ms | 0.9618 ms |  1.770 ms | 873.72 |  50.47 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.145 ms | 0.1168 ms | 0.0614 ms |  1.116 ms | 1.0095 ms |  1.475 ms | 873.54 |  50.27 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.145 ms | 0.0853 ms | 0.0448 ms |  1.121 ms | 0.9942 ms |  1.439 ms | 873.10 |  52.73 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.146 ms | 0.1000 ms | 0.0532 ms |  1.121 ms | 0.9910 ms |  1.403 ms | 872.86 |  18.73 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.146 ms | 0.0774 ms | 0.0418 ms |  1.141 ms | 1.0358 ms |  1.409 ms | 872.28 |  20.54 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.151 ms | 0.1196 ms | 0.0628 ms |  1.130 ms | 0.9768 ms |  1.450 ms | 868.99 |   50.9 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.152 ms | 0.0976 ms | 0.0513 ms |  1.153 ms | 0.9881 ms |  1.478 ms | 868.15 |   50.9 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.154 ms | 0.1043 ms | 0.0548 ms |  1.144 ms | 1.0145 ms |  1.455 ms | 866.71 |  18.96 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.160 ms | 0.0859 ms | 0.0457 ms |  1.142 ms | 1.0352 ms |  1.412 ms | 861.81 |  20.98 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.166 ms | 0.1640 ms | 0.0851 ms |  1.120 ms | 0.9764 ms |  1.708 ms | 857.32 |  50.21 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.171 ms | 0.0915 ms | 0.0481 ms |  1.168 ms | 1.0099 ms |  1.405 ms | 853.84 |  53.16 KB |
| Single                                    | InsightBenchmarkWrite |  1.172 ms | 0.1055 ms | 0.0562 ms |  1.160 ms | 1.0105 ms |  1.445 ms | 853.45 |  18.33 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.172 ms | 0.0881 ms | 0.0457 ms |  1.160 ms | 0.9889 ms |  1.352 ms | 853.03 |  21.02 KB |
| Single                                    | InsightBenchmark      |  1.173 ms | 0.1255 ms | 0.0643 ms |  1.147 ms | 0.9758 ms |  1.416 ms | 852.75 |   50.5 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.174 ms | 0.1006 ms | 0.0516 ms |  1.155 ms | 1.0180 ms |  1.427 ms | 851.44 |  18.46 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.184 ms | 0.1327 ms | 0.0689 ms |  1.155 ms | 0.9415 ms |  1.667 ms | 844.80 |  20.54 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.187 ms | 0.0952 ms | 0.0501 ms |  1.186 ms | 1.0232 ms |  1.430 ms | 842.34 |  52.76 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.191 ms | 0.2086 ms | 0.1057 ms |  1.108 ms | 0.9730 ms |  2.045 ms | 839.69 |  18.93 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.192 ms | 0.1157 ms | 0.0601 ms |  1.152 ms | 1.0280 ms |  1.462 ms | 838.79 |  18.41 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.195 ms | 0.1420 ms | 0.0728 ms |  1.157 ms | 1.0010 ms |  1.570 ms | 836.51 |  20.98 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.197 ms | 0.1936 ms | 0.0981 ms |  1.121 ms | 1.0279 ms |  1.937 ms | 835.15 |  50.45 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.201 ms | 0.0937 ms | 0.0520 ms |  1.200 ms | 0.9839 ms |  1.458 ms | 832.32 |  44.52 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.207 ms | 0.1145 ms | 0.0618 ms |  1.179 ms | 1.0632 ms |  1.622 ms | 828.73 |  53.19 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.207 ms | 0.1324 ms | 0.0696 ms |  1.147 ms | 1.0100 ms |  1.525 ms | 828.39 |  53.16 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.209 ms | 0.1135 ms | 0.0612 ms |  1.186 ms | 1.0487 ms |  1.632 ms | 827.46 |  52.74 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.212 ms | 0.2302 ms | 0.1166 ms |  1.149 ms | 0.9742 ms |  2.060 ms | 824.76 |  18.73 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.216 ms | 0.2852 ms | 0.1499 ms |  1.105 ms | 1.0159 ms |  2.159 ms | 822.64 |  50.45 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.218 ms | 0.1255 ms | 0.0660 ms |  1.170 ms | 0.9865 ms |  1.495 ms | 820.75 |  20.59 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.244 ms | 0.1414 ms | 0.0716 ms |  1.202 ms | 0.9960 ms |  1.560 ms | 804.14 |  21.02 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.246 ms | 0.1756 ms | 0.0961 ms |  1.193 ms | 1.0444 ms |  1.686 ms | 802.79 |  20.98 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.256 ms | 0.2095 ms | 0.1101 ms |  1.198 ms | 1.0281 ms |  1.819 ms | 796.05 |  20.54 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.259 ms | 0.0857 ms | 0.0468 ms |  1.236 ms | 1.1251 ms |  1.485 ms | 794.55 |  44.95 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.265 ms | 0.1716 ms | 0.0902 ms |  1.209 ms | 1.0307 ms |  1.733 ms | 790.71 |  50.93 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.267 ms | 0.2820 ms | 0.1482 ms |  1.170 ms | 0.9946 ms |  2.037 ms | 789.29 |  20.55 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.268 ms | 0.1405 ms | 0.0720 ms |  1.227 ms | 1.0824 ms |  1.580 ms | 788.62 |  53.19 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.280 ms | 0.1884 ms | 0.0966 ms |  1.233 ms | 1.0227 ms |  1.901 ms | 781.39 |  44.51 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.282 ms | 0.3163 ms | 0.1684 ms |  1.136 ms | 0.9947 ms |  2.285 ms | 780.02 |  18.73 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.285 ms | 0.2142 ms | 0.1085 ms |  1.245 ms | 0.9500 ms |  1.838 ms | 778.02 |  20.98 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.294 ms | 0.1481 ms | 0.0759 ms |  1.237 ms | 1.1149 ms |  1.725 ms | 772.97 |  44.95 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.339 ms | 0.3424 ms | 0.1734 ms |  1.196 ms | 1.0019 ms |  2.381 ms | 746.65 |  50.71 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.351 ms | 0.4007 ms | 0.2106 ms |  1.174 ms | 1.0243 ms |  2.204 ms | 740.13 |  51.13 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.363 ms | 0.3473 ms | 0.1849 ms |  1.227 ms | 1.0005 ms |  2.289 ms | 733.54 |  20.98 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.372 ms | 0.3382 ms | 0.1756 ms |  1.226 ms | 1.0247 ms |  2.342 ms | 728.92 |  20.57 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.373 ms | 0.2606 ms | 0.1388 ms |  1.467 ms | 0.9902 ms |  1.826 ms | 728.43 |  18.93 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.379 ms | 0.3750 ms | 0.1971 ms |  1.209 ms | 0.9730 ms |  2.162 ms | 725.34 |  18.93 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.403 ms | 0.2163 ms | 0.1096 ms |  1.432 ms | 1.0731 ms |  1.884 ms | 713.00 |  50.76 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.470 ms | 0.3291 ms | 0.1752 ms |  1.493 ms | 1.0419 ms |  2.123 ms | 680.14 |  18.96 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.568 ms | 0.1636 ms | 0.0849 ms |  1.560 ms | 1.2526 ms |  2.168 ms | 637.73 |  18.96 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.579 ms | 0.3302 ms | 0.1781 ms |  1.572 ms | 1.0555 ms |  2.335 ms | 633.23 |  20.98 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.711 ms | 0.3696 ms | 0.1895 ms |  1.636 ms | 1.1287 ms |  2.473 ms | 584.57 |  20.54 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.870 ms | 0.4405 ms | 0.2231 ms |  2.019 ms | 1.0674 ms |  2.545 ms | 534.72 |  17.97 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2.820 ms | 0.1369 ms | 0.0729 ms |  2.793 ms | 2.6390 ms |  3.292 ms | 354.62 |  72.65 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  3.038 ms | 0.5392 ms | 0.2798 ms |  2.798 ms | 2.5348 ms |  5.023 ms | 329.11 |  39.63 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  3.113 ms | 0.3175 ms | 0.1628 ms |  3.103 ms | 2.6052 ms |  3.784 ms | 321.19 |   38.7 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3.262 ms | 0.3899 ms | 0.2049 ms |  3.351 ms | 2.7005 ms |  4.123 ms | 306.57 |  40.35 KB |
|                                           |                       |           |           |           |           |           |           |        |           |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite |  3.434 ms | 0.7728 ms | 0.3825 ms |  3.449 ms | 2.3553 ms |  4.816 ms | 291.17 |  21.84 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite |  3.462 ms | 0.7528 ms | 0.3727 ms |  3.721 ms | 2.3125 ms |  4.890 ms | 288.84 |  22.39 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite |  3.572 ms | 0.8383 ms | 0.4150 ms |  3.643 ms | 2.3529 ms |  5.027 ms | 279.97 |   21.3 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite |  3.812 ms | 0.8477 ms | 0.4196 ms |  3.836 ms | 2.3426 ms |  5.376 ms | 262.33 |  20.97 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.334 ms | 1.2036 ms | 0.6171 ms | 10.528 ms | 5.8813 ms | 11.569 ms |  96.77 |  32.48 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.395 ms | 0.4455 ms | 0.2284 ms | 10.421 ms | 8.9982 ms | 11.060 ms |  96.20 |  67.41 KB |
