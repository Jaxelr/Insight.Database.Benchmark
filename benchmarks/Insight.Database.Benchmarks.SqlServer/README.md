# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.104
  [Host]   : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median     | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|-----------:|-----------:|----------:|-------:|----------:|
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.000 ms | 0.0744 ms | 0.0391 ms |  0.9864 ms |  0.9043 ms |  1.231 ms | 999.52 |  11.07 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.005 ms | 0.0892 ms | 0.0458 ms |  0.9911 ms |  0.8693 ms |  1.216 ms | 994.90 |  11.09 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.007 ms | 0.0777 ms | 0.0398 ms |  0.9936 ms |  0.8805 ms |  1.203 ms | 993.09 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.009 ms | 0.0807 ms | 0.0424 ms |  0.9912 ms |  0.8751 ms |  1.282 ms | 991.39 |  11.07 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.011 ms | 0.0983 ms | 0.0510 ms |  0.9821 ms |  0.8568 ms |  1.256 ms | 989.28 |  11.07 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.012 ms | 0.0720 ms | 0.0369 ms |  1.0062 ms |  0.8910 ms |  1.169 ms | 987.81 |  11.41 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.030 ms | 0.0929 ms | 0.0465 ms |  1.0119 ms |  0.9009 ms |  1.314 ms | 970.72 |  11.73 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.033 ms | 0.0584 ms | 0.0311 ms |  1.0288 ms |  0.9330 ms |  1.170 ms | 968.07 |  12.16 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.034 ms | 0.0953 ms | 0.0489 ms |  1.0166 ms |  0.8668 ms |  1.379 ms | 967.03 |  11.84 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.040 ms | 0.0809 ms | 0.0425 ms |  1.0230 ms |  0.9288 ms |  1.350 ms | 961.24 |  12.48 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.047 ms | 0.1011 ms | 0.0586 ms |  1.0217 ms |  0.9354 ms |  1.347 ms | 954.73 |        NA |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.053 ms | 0.1901 ms | 0.0987 ms |  0.9795 ms |  0.8626 ms |  1.690 ms | 949.98 |  11.09 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.061 ms | 0.0945 ms | 0.0503 ms |  1.0521 ms |  0.8963 ms |  1.309 ms | 942.12 |  11.43 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.065 ms | 0.0931 ms | 0.0477 ms |  1.0533 ms |  0.9044 ms |  1.317 ms | 939.12 |  11.82 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.069 ms | 0.1103 ms | 0.0595 ms |  1.0364 ms |  0.9137 ms |  1.465 ms | 935.08 |  11.09 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.074 ms | 0.1121 ms | 0.0575 ms |  1.0436 ms |  0.9228 ms |  1.300 ms | 931.26 |  11.82 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.084 ms | 0.1232 ms | 0.0632 ms |  1.0597 ms |  0.8752 ms |  1.373 ms | 922.30 |  11.41 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.090 ms | 0.1469 ms | 0.0744 ms |  1.0457 ms |  0.9279 ms |  1.582 ms | 917.10 |  11.73 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.091 ms | 0.0745 ms | 0.0387 ms |  1.0781 ms |  0.9490 ms |  1.256 ms | 916.98 |  12.88 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.098 ms | 0.0941 ms | 0.0477 ms |  1.0946 ms |  0.9290 ms |  1.308 ms | 910.92 |  12.48 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.100 ms | 0.1536 ms | 0.0797 ms |  1.0563 ms |  0.8889 ms |  1.542 ms | 909.10 |  11.43 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.107 ms | 0.1156 ms | 0.0600 ms |  1.0750 ms |  0.9385 ms |  1.399 ms | 903.53 |  11.73 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.114 ms | 0.1987 ms | 0.1019 ms |  1.0624 ms |  0.9026 ms |  1.858 ms | 897.51 |  12.48 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.116 ms | 0.0688 ms | 0.0362 ms |  1.1061 ms |  1.0052 ms |  1.283 ms | 896.35 |  13.83 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.124 ms | 0.0900 ms | 0.0445 ms |  1.1004 ms |  0.9741 ms |  1.327 ms | 890.05 |  13.52 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.126 ms | 0.0847 ms | 0.0445 ms |  1.1023 ms |  1.0253 ms |  1.354 ms | 887.74 |  13.17 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.127 ms | 0.2041 ms | 0.1047 ms |  1.0604 ms |  0.8891 ms |  1.942 ms | 887.37 |  11.43 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.129 ms | 0.1224 ms | 0.0643 ms |  1.0999 ms |  0.9909 ms |  1.410 ms | 885.69 |  13.17 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.135 ms | 0.2105 ms | 0.1121 ms |  1.0425 ms |  0.9365 ms |  1.736 ms | 881.16 |  12.16 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.142 ms | 0.0717 ms | 0.0368 ms |  1.1274 ms |  1.0386 ms |  1.321 ms | 875.78 |  14.27 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.143 ms | 0.1194 ms | 0.0620 ms |  1.1207 ms |  0.9939 ms |  1.618 ms | 875.06 |  13.92 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.150 ms | 0.1257 ms | 0.0678 ms |  1.1220 ms |  0.9539 ms |  1.480 ms | 869.90 |  13.08 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.153 ms | 0.1001 ms | 0.0526 ms |  1.1285 ms |  1.0035 ms |  1.422 ms | 867.34 |  35.65 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.154 ms | 0.2250 ms | 0.1114 ms |  1.0562 ms |  0.9111 ms |  1.695 ms | 866.20 |  11.73 KB |
| Single                                    | InsightBenchmarkWrite |  1.157 ms | 0.1954 ms | 0.0990 ms |  1.1072 ms |  0.9418 ms |  1.824 ms | 864.53 |  12.18 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.157 ms | 0.1111 ms | 0.0576 ms |  1.1297 ms |  1.0047 ms |  1.596 ms | 864.51 |  13.92 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.157 ms | 0.0979 ms | 0.0508 ms |  1.1388 ms |  1.0404 ms |  1.444 ms | 864.43 |  13.68 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.158 ms | 0.0867 ms | 0.0439 ms |  1.1497 ms |  0.9760 ms |  1.358 ms | 863.57 |  14.98 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.162 ms | 0.1100 ms | 0.0557 ms |  1.1718 ms |  0.9763 ms |  1.395 ms | 860.80 |  13.52 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.168 ms | 0.1330 ms | 0.0666 ms |  1.1466 ms |  0.9683 ms |  1.652 ms | 856.10 |  35.66 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.169 ms | 0.1317 ms | 0.0684 ms |  1.1355 ms |  0.9699 ms |  1.517 ms | 855.25 |  13.08 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.179 ms | 0.1276 ms | 0.0680 ms |  1.1371 ms |  1.0151 ms |  1.486 ms | 848.45 |  13.42 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.182 ms | 0.1035 ms | 0.0551 ms |  1.1674 ms |  1.0424 ms |  1.481 ms | 846.12 |  13.83 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.184 ms | 0.1918 ms | 0.1008 ms |  1.1032 ms |  0.9845 ms |  1.749 ms | 844.69 |  13.08 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.184 ms | 0.1572 ms | 0.0848 ms |  1.1310 ms |  0.9673 ms |  1.761 ms | 844.60 |  12.88 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.184 ms | 0.2977 ms | 0.1628 ms |  1.0538 ms |  0.9290 ms |  1.950 ms | 844.41 |  11.43 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.188 ms | 0.1217 ms | 0.0632 ms |  1.1602 ms |  0.9986 ms |  1.606 ms | 841.90 |  14.27 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.197 ms | 0.2313 ms | 0.1201 ms |  1.1240 ms |  0.9634 ms |  2.006 ms | 835.27 |  11.84 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.203 ms | 0.1271 ms | 0.0677 ms |  1.1843 ms |  1.0592 ms |  1.719 ms | 831.03 |  13.42 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.211 ms | 0.1446 ms | 0.0741 ms |  1.1721 ms |  1.0034 ms |  1.663 ms | 825.54 |  14.98 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.215 ms | 0.1667 ms | 0.0855 ms |  1.1590 ms |  1.0018 ms |  1.885 ms | 822.91 |  13.42 KB |
| Single                                    | InsightBenchmark      |  1.226 ms | 0.1772 ms | 0.0920 ms |  1.2098 ms |  0.8925 ms |  1.642 ms | 815.98 |  12.18 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.229 ms | 0.3702 ms | 0.1946 ms |  1.0810 ms |  0.9259 ms |  2.589 ms | 813.53 |  11.09 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.232 ms | 0.2270 ms | 0.1164 ms |  1.1388 ms |  1.0325 ms |  1.761 ms | 811.68 |  13.08 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.233 ms | 0.2896 ms | 0.1467 ms |  1.1175 ms |  0.9738 ms |  2.086 ms | 810.91 |  12.48 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.237 ms | 0.2543 ms | 0.1304 ms |  1.1254 ms |  0.9763 ms |  1.885 ms | 808.36 |  13.17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.249 ms | 0.2287 ms | 0.1172 ms |  1.2193 ms |  0.9748 ms |  1.973 ms | 800.39 |  13.17 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.258 ms | 0.3229 ms | 0.1676 ms |  1.1148 ms |  0.9803 ms |  2.338 ms | 795.02 |  13.42 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.286 ms | 0.1294 ms | 0.0648 ms |  1.2601 ms |  1.0910 ms |  1.751 ms | 777.58 |  37.75 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.309 ms | 0.2860 ms | 0.1523 ms |  1.1814 ms |  1.0651 ms |  2.115 ms | 763.67 |  14.34 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.312 ms | 0.1873 ms | 0.0972 ms |  1.2391 ms |  1.0722 ms |  1.762 ms | 761.91 |  15.07 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.315 ms | 0.2656 ms | 0.1362 ms |  1.2317 ms |  0.9883 ms |  1.908 ms | 760.37 |  13.52 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.331 ms | 0.4901 ms | 0.2544 ms |  1.1016 ms |  0.9220 ms |  2.589 ms | 751.53 |  11.41 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.341 ms | 0.2360 ms | 0.1225 ms |  1.2631 ms |  1.0608 ms |  1.890 ms | 745.68 |  15.07 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.369 ms | 0.2053 ms | 0.1065 ms |  1.3124 ms |  1.0767 ms |  1.889 ms | 730.57 |  14.34 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.373 ms | 0.5189 ms | 0.2693 ms |  1.1482 ms |  0.9449 ms |  2.746 ms | 728.13 |  12.83 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1.416 ms | 0.2015 ms | 0.1073 ms |  1.3398 ms |  1.2016 ms |  2.071 ms | 706.22 |  65.34 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.457 ms | 0.1592 ms | 0.0797 ms |  1.4358 ms |  1.1777 ms |  1.810 ms | 686.47 |  37.66 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  1.468 ms | 0.1720 ms | 0.0893 ms |  1.4177 ms |  1.2525 ms |  2.037 ms | 681.32 |  67.33 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1.473 ms | 0.1600 ms | 0.0841 ms |  1.4145 ms |  1.2976 ms |  2.070 ms | 678.93 |  67.55 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.488 ms | 0.5055 ms | 0.2592 ms |  1.3561 ms |  0.9630 ms |  2.905 ms | 672.05 |  12.83 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1.505 ms | 0.2504 ms | 0.1316 ms |  1.4416 ms |  1.1825 ms |  2.314 ms | 664.59 |  65.32 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.385 ms | 0.1617 ms | 0.0839 ms |  2.3445 ms |  2.1706 ms |  2.821 ms | 419.37 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2.740 ms | 0.6863 ms | 0.3477 ms |  2.4383 ms |  2.1714 ms |  4.506 ms | 365.01 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2.839 ms | 0.1398 ms | 0.0726 ms |  2.8053 ms |  2.5959 ms |  3.237 ms | 352.25 |  31.58 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.060 ms | 0.2737 ms | 0.1355 ms |  2.9555 ms |  2.7046 ms |  3.849 ms | 326.75 |  31.58 KB |
|                                           |                       |           |           |           |            |            |           |        |           |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.014 ms | 0.5246 ms | 0.2690 ms | 11.0088 ms |  9.5941 ms | 12.449 ms |  90.79 |   7.17 KB |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11.154 ms | 0.5124 ms | 0.2537 ms | 11.0524 ms | 10.3849 ms | 12.264 ms |  89.65 |   4.64 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.219 ms | 0.5070 ms | 0.2539 ms | 11.1680 ms |  9.9350 ms | 12.409 ms |  89.13 |   6.86 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11.393 ms | 0.6631 ms | 0.3283 ms | 11.2167 ms | 10.4499 ms | 14.055 ms |  87.78 |  13.08 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11.419 ms | 0.4457 ms | 0.2207 ms | 11.4535 ms | 10.6635 ms | 12.698 ms |  87.57 |   7.17 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.736 ms | 2.0553 ms | 1.0538 ms | 11.1788 ms | 10.1650 ms | 18.513 ms |  85.21 |   4.64 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11.978 ms | 0.8642 ms | 0.4378 ms | 11.8379 ms | 10.0595 ms | 14.993 ms |  83.48 |   4.64 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.998 ms | 1.1110 ms | 0.5563 ms | 11.6894 ms | 10.0868 ms | 15.117 ms |  83.35 |  15.34 KB |
