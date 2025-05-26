# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.3915/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min       | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.048 ms | 0.1045 ms | 0.0549 ms |  1.030 ms | 0.9098 ms |  1.384 ms | 953.94 |  21.92 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.062 ms | 0.1258 ms | 0.0645 ms |  1.030 ms | 0.8928 ms |  1.399 ms | 941.80 |  22.57 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.069 ms | 0.1174 ms | 0.0609 ms |  1.027 ms | 0.8905 ms |  1.417 ms | 935.09 |  21.92 KB |
| Single                                    | InsightBenchmarkWrite |  1.072 ms | 0.0896 ms | 0.0465 ms |  1.052 ms | 0.9328 ms |  1.361 ms | 932.89 |  21.96 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.083 ms | 0.1282 ms | 0.0674 ms |  1.054 ms | 0.8993 ms |  1.569 ms | 922.94 |  22.57 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.092 ms | 0.1226 ms | 0.0636 ms |  1.060 ms | 0.8857 ms |  1.381 ms | 915.78 |  21.94 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.096 ms | 0.0949 ms | 0.0475 ms |  1.067 ms | 0.9712 ms |  1.464 ms | 912.66 |  25.01 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.098 ms | 0.1084 ms | 0.0577 ms |  1.079 ms | 0.9541 ms |  1.427 ms | 910.63 |  22.57 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.101 ms | 0.0733 ms | 0.0376 ms |  1.097 ms | 0.9600 ms |  1.287 ms | 907.93 |   24.7 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.107 ms | 0.1150 ms | 0.0604 ms |  1.078 ms | 0.9552 ms |  1.438 ms | 903.28 |  21.92 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.110 ms | 0.0948 ms | 0.0492 ms |  1.105 ms | 0.9382 ms |  1.328 ms | 900.79 |  21.02 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.116 ms | 0.0692 ms | 0.0355 ms |  1.103 ms | 0.9972 ms |  1.367 ms | 896.29 |  23.49 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.118 ms | 0.1241 ms | 0.0644 ms |  1.090 ms | 0.9691 ms |  1.659 ms | 894.36 |  20.73 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.129 ms | 0.1469 ms | 0.0753 ms |  1.099 ms | 0.9715 ms |  1.672 ms | 885.93 |  21.94 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.132 ms | 0.1141 ms | 0.0585 ms |  1.091 ms | 1.0096 ms |  1.571 ms | 883.38 |  24.97 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.134 ms | 0.1888 ms | 0.1018 ms |  1.058 ms | 0.9362 ms |  1.579 ms | 881.99 |  21.92 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.135 ms | 0.0749 ms | 0.0399 ms |  1.130 ms | 0.9959 ms |  1.324 ms | 881.04 |  24.48 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.151 ms | 0.1064 ms | 0.0546 ms |  1.131 ms | 0.9810 ms |  1.426 ms | 868.82 |  24.48 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.155 ms | 0.1403 ms | 0.0747 ms |  1.121 ms | 0.9950 ms |  1.720 ms | 865.76 |  21.07 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.160 ms | 0.1275 ms | 0.0670 ms |  1.121 ms | 0.9696 ms |  1.622 ms | 861.83 |  24.48 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.162 ms | 0.1420 ms | 0.0728 ms |  1.104 ms | 0.9809 ms |  1.584 ms | 860.24 |  24.97 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.164 ms | 0.1845 ms | 0.0970 ms |  1.099 ms | 0.9346 ms |  1.792 ms | 859.45 |  21.95 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.168 ms | 0.1727 ms | 0.0932 ms |  1.122 ms | 0.9784 ms |  1.795 ms | 856.20 |  57.15 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.171 ms | 0.1495 ms | 0.0757 ms |  1.122 ms | 0.9557 ms |  1.682 ms | 853.91 |  22.31 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.176 ms | 0.1247 ms | 0.0655 ms |  1.155 ms | 0.9811 ms |  1.524 ms | 850.16 |  24.48 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.178 ms | 0.0997 ms | 0.0538 ms |  1.182 ms | 0.9976 ms |  1.428 ms | 849.05 |  48.38 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.180 ms | 0.1332 ms | 0.0683 ms |  1.139 ms | 0.9928 ms |  1.604 ms | 847.61 |  21.07 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.181 ms | 0.1104 ms | 0.0566 ms |  1.178 ms | 1.0207 ms |  1.448 ms | 846.50 |  48.37 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.184 ms | 0.1666 ms | 0.0844 ms |  1.135 ms | 0.9523 ms |  1.668 ms | 844.35 |  21.94 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.189 ms | 0.1268 ms | 0.0658 ms |  1.158 ms | 0.9567 ms |  1.465 ms | 841.36 |   24.2 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.189 ms | 0.1725 ms | 0.0895 ms |  1.138 ms | 0.9875 ms |  1.633 ms | 841.29 |  24.48 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.190 ms | 0.1544 ms | 0.0811 ms |  1.153 ms | 1.0007 ms |  1.772 ms | 840.03 |  24.51 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.191 ms | 0.1689 ms | 0.0911 ms |  1.151 ms | 0.9493 ms |  1.582 ms | 839.81 |  57.15 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.192 ms | 0.1318 ms | 0.0676 ms |  1.141 ms | 1.0417 ms |  1.527 ms | 838.80 |  23.25 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.193 ms | 0.1424 ms | 0.0739 ms |  1.168 ms | 0.9716 ms |  1.666 ms | 838.30 |  24.97 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.196 ms | 0.0884 ms | 0.0453 ms |  1.171 ms | 1.0684 ms |  1.459 ms | 836.01 |  27.24 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.203 ms | 0.0583 ms | 0.0299 ms |  1.200 ms | 1.0682 ms |  1.322 ms | 831.57 |  27.24 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.207 ms | 0.1993 ms | 0.1034 ms |  1.117 ms | 0.9908 ms |  1.762 ms | 828.83 |  24.99 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.207 ms | 0.1673 ms | 0.0858 ms |  1.215 ms | 0.9696 ms |  1.607 ms | 828.31 |  22.59 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.212 ms | 0.3172 ms | 0.1627 ms |  1.094 ms | 0.9685 ms |  2.338 ms | 825.18 |  24.98 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.212 ms | 0.1188 ms | 0.0609 ms |  1.188 ms | 1.0022 ms |  1.599 ms | 824.79 |  22.92 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.214 ms | 0.1829 ms | 0.0987 ms |  1.168 ms | 1.0124 ms |  1.901 ms | 823.97 |  57.17 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.220 ms | 0.1321 ms | 0.0686 ms |  1.206 ms | 0.9819 ms |  1.591 ms | 819.98 |  24.48 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.231 ms | 0.2170 ms | 0.1126 ms |  1.182 ms | 0.9447 ms |  1.720 ms | 812.46 |  22.59 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.251 ms | 0.1605 ms | 0.0833 ms |  1.194 ms | 1.0617 ms |  1.813 ms | 799.33 |  26.96 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.252 ms | 0.0921 ms | 0.0490 ms |  1.235 ms | 1.0860 ms |  1.465 ms | 798.72 |  59.72 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.260 ms | 0.1842 ms | 0.0945 ms |  1.184 ms | 1.0219 ms |  1.761 ms | 793.71 |  24.51 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.270 ms | 0.2001 ms | 0.1014 ms |  1.241 ms | 0.9766 ms |  1.813 ms | 787.23 |  22.59 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.272 ms | 0.3324 ms | 0.1704 ms |  1.104 ms | 0.9340 ms |  2.213 ms | 786.16 |  21.95 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.278 ms | 0.1104 ms | 0.0588 ms |  1.257 ms | 1.0976 ms |  1.544 ms | 782.31 |  50.93 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.279 ms | 0.2210 ms | 0.1161 ms |  1.263 ms | 0.9421 ms |  1.922 ms | 781.67 |  22.57 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.283 ms | 0.1643 ms | 0.0875 ms |  1.233 ms | 1.0879 ms |  1.617 ms | 779.26 |   59.7 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.291 ms | 0.1533 ms | 0.0767 ms |  1.268 ms | 1.0765 ms |  1.602 ms | 774.55 |  27.55 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.300 ms | 0.2511 ms | 0.1287 ms |  1.222 ms | 1.0405 ms |  1.984 ms | 769.38 |  23.54 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.309 ms | 0.2032 ms | 0.1068 ms |  1.221 ms | 1.0291 ms |  1.790 ms | 764.21 |  24.97 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.312 ms | 0.1911 ms | 0.0968 ms |  1.266 ms | 1.0701 ms |  1.749 ms | 761.97 |  24.99 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.315 ms | 0.1958 ms | 0.1029 ms |  1.233 ms | 1.0441 ms |  1.882 ms | 760.20 |  24.51 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.320 ms | 0.1085 ms | 0.0550 ms |  1.336 ms | 1.1291 ms |  1.527 ms | 757.43 |  50.93 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.333 ms | 0.1805 ms | 0.0949 ms |  1.284 ms | 1.0700 ms |  1.765 ms | 749.99 |  27.24 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.340 ms | 0.1871 ms | 0.0948 ms |  1.261 ms | 1.0846 ms |  1.747 ms | 746.40 |  27.24 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.352 ms | 0.2482 ms | 0.1258 ms |  1.252 ms | 1.0952 ms |  2.017 ms | 739.59 |  27.53 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.371 ms | 0.2190 ms | 0.1097 ms |  1.272 ms | 1.0980 ms |  1.877 ms | 729.16 |  27.55 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.374 ms | 0.1798 ms | 0.0922 ms |  1.357 ms | 1.1359 ms |  1.938 ms | 727.68 |  27.27 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.392 ms | 0.2494 ms | 0.1279 ms |  1.360 ms | 1.0306 ms |  1.847 ms | 718.56 |  27.53 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.452 ms | 0.5068 ms | 0.2567 ms |  1.226 ms | 1.0193 ms |  2.893 ms | 688.66 |  24.48 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.468 ms | 0.3525 ms | 0.1807 ms |  1.443 ms | 0.8728 ms |  2.607 ms | 681.30 |  21.94 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.563 ms | 0.2515 ms | 0.1305 ms |  1.511 ms | 1.1073 ms |  2.244 ms | 639.90 |  56.68 KB |
| Single                                    | InsightBenchmark      |  1.661 ms | 0.2971 ms | 0.1505 ms |  1.665 ms | 1.0624 ms |  2.471 ms | 602.11 |  54.13 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.914 ms | 0.1373 ms | 0.0751 ms |  2.893 ms | 2.6983 ms |  3.239 ms | 343.13 |  47.49 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3.022 ms | 0.1762 ms | 0.0926 ms |  2.957 ms | 2.7698 ms |  3.549 ms | 330.92 |  46.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.137 ms | 0.3772 ms | 0.1958 ms |  2.965 ms | 2.7134 ms |  4.553 ms | 318.76 |  46.95 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  3.139 ms | 0.4348 ms | 0.2257 ms |  2.989 ms | 2.7298 ms |  4.598 ms | 318.57 |  47.49 KB |
|                                           |                       |           |           |           |           |           |           |        |           |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10.590 ms | 1.0435 ms | 0.5225 ms | 10.697 ms | 5.9014 ms | 12.232 ms |  94.43 |  25.48 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.877 ms | 0.9581 ms | 0.4912 ms | 10.800 ms | 6.3691 ms | 12.230 ms |  91.94 |   35.7 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10.949 ms | 0.5077 ms | 0.2572 ms | 10.949 ms | 9.8882 ms | 12.114 ms |  91.34 |  23.85 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.006 ms | 0.8860 ms | 0.4543 ms | 11.085 ms | 6.1722 ms | 12.915 ms |  90.86 |  36.34 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11.013 ms | 0.7384 ms | 0.3655 ms | 10.965 ms | 9.5998 ms | 13.251 ms |  90.80 |  23.45 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.224 ms | 0.7901 ms | 0.4153 ms | 11.135 ms | 9.7003 ms | 13.750 ms |  89.10 |  26.11 KB |
