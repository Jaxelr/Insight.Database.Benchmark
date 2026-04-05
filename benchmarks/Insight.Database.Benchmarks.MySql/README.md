# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8117/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.006 ms | 0.0615 ms | 0.0328 ms |  1.000 ms |  0.8919 ms |  1.173 ms | 994.09 |  20.62 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.018 ms | 0.0677 ms | 0.0361 ms |  1.023 ms |  0.8732 ms |  1.209 ms | 982.31 |   20.6 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.024 ms | 0.0991 ms | 0.0502 ms |  1.003 ms |  0.8656 ms |  1.295 ms | 976.84 |   20.6 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.026 ms | 0.0730 ms | 0.0379 ms |  1.015 ms |  0.9215 ms |  1.225 ms | 975.00 |  20.92 KB |
| Single                                    | InsightBenchmarkWrite |  1.042 ms | 0.0972 ms | 0.0504 ms |  1.022 ms |  0.8944 ms |  1.337 ms | 959.30 |  20.64 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.055 ms | 0.1057 ms | 0.0535 ms |  1.032 ms |  0.8812 ms |  1.375 ms | 948.29 |  20.62 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.058 ms | 0.1262 ms | 0.0647 ms |  1.033 ms |  0.8874 ms |  1.508 ms | 945.20 |  20.92 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.064 ms | 0.0746 ms | 0.0392 ms |  1.043 ms |  0.9629 ms |  1.243 ms | 939.63 |  23.32 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.083 ms | 0.1340 ms | 0.0695 ms |  1.022 ms |  0.9230 ms |  1.503 ms | 923.40 |  20.92 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.090 ms | 0.0892 ms | 0.0447 ms |  1.058 ms |  0.9203 ms |  1.276 ms | 917.45 |  23.34 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.093 ms | 0.1319 ms | 0.0676 ms |  1.067 ms |  0.9145 ms |  1.446 ms | 915.00 |  20.95 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.095 ms | 0.1679 ms | 0.0883 ms |  1.037 ms |  0.9054 ms |  1.623 ms | 913.10 |   20.6 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.095 ms | 0.1931 ms | 0.1015 ms |  1.022 ms |  0.9105 ms |  1.674 ms | 912.91 |  20.92 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.096 ms | 0.0790 ms | 0.0415 ms |  1.081 ms |  0.9641 ms |  1.339 ms | 912.32 |  19.76 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.105 ms | 0.1122 ms | 0.0582 ms |  1.096 ms |  0.9296 ms |  1.339 ms | 905.05 |  20.95 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.113 ms | 0.1945 ms | 0.0997 ms |  1.043 ms |  0.9196 ms |  1.752 ms | 898.73 |  20.63 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.115 ms | 0.1325 ms | 0.0671 ms |  1.079 ms |  0.9353 ms |  1.442 ms | 897.01 |  20.95 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.125 ms | 0.0991 ms | 0.0514 ms |  1.109 ms |  0.9605 ms |  1.457 ms | 889.13 |  23.16 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.125 ms | 0.1148 ms | 0.0568 ms |  1.102 ms |  0.9312 ms |  1.443 ms | 888.91 |  23.16 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.143 ms | 0.1792 ms | 0.0919 ms |  1.072 ms |  0.9310 ms |  1.695 ms | 874.62 |  20.62 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.144 ms | 0.0951 ms | 0.0487 ms |  1.119 ms |  1.0148 ms |  1.368 ms | 874.09 |  23.19 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.147 ms | 0.1106 ms | 0.0581 ms |  1.110 ms |  1.0022 ms |  1.587 ms | 872.11 |  23.16 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.149 ms | 0.1564 ms | 0.0812 ms |  1.106 ms |  0.8937 ms |  1.507 ms | 870.19 |  23.32 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.155 ms | 0.1699 ms | 0.0861 ms |  1.090 ms |  0.9361 ms |  1.568 ms | 866.12 |  20.95 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.158 ms | 0.1587 ms | 0.0845 ms |  1.116 ms |  0.9640 ms |  1.685 ms | 863.78 |  23.32 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.160 ms | 0.1211 ms | 0.0628 ms |  1.122 ms |  1.0145 ms |  1.507 ms | 862.30 |   22.9 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.170 ms | 0.1316 ms | 0.0652 ms |  1.134 ms |  0.9887 ms |  1.574 ms | 854.62 |  23.34 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.171 ms | 0.1215 ms | 0.0616 ms |  1.132 ms |  1.0335 ms |  1.529 ms | 853.70 |  47.06 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.174 ms | 0.2039 ms | 0.1058 ms |  1.093 ms |  1.0150 ms |  1.948 ms | 852.04 |  19.76 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.175 ms | 0.2092 ms | 0.1086 ms |  1.083 ms |  0.9366 ms |  1.702 ms | 850.80 |  23.34 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.176 ms | 0.2142 ms | 0.1112 ms |  1.088 ms |  0.9619 ms |  1.709 ms | 850.03 |  23.34 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.181 ms | 0.1743 ms | 0.0894 ms |  1.097 ms |  0.9666 ms |  1.556 ms | 846.40 |  23.34 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.187 ms | 0.1115 ms | 0.0572 ms |  1.157 ms |  1.0111 ms |  1.541 ms | 842.73 |  25.88 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.189 ms | 0.2511 ms | 0.1303 ms |  1.112 ms |  0.8744 ms |  1.926 ms | 841.07 |  20.62 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.189 ms | 0.0827 ms | 0.0424 ms |  1.170 ms |  1.0545 ms |  1.386 ms | 841.07 |  25.88 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.192 ms | 0.0775 ms | 0.0393 ms |  1.169 ms |  1.0705 ms |  1.378 ms | 838.78 |  49.61 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.200 ms | 0.1363 ms | 0.0726 ms |  1.172 ms |  1.0004 ms |  1.559 ms | 833.02 |  23.34 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.210 ms | 0.1574 ms | 0.0807 ms |  1.187 ms |  0.9676 ms |  1.683 ms | 826.75 |   19.7 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.214 ms | 0.1692 ms | 0.0878 ms |  1.150 ms |  0.9905 ms |  1.587 ms | 823.51 |  23.32 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.215 ms | 0.1213 ms | 0.0607 ms |  1.188 ms |  1.0233 ms |  1.547 ms | 822.94 |  25.62 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.215 ms | 0.1509 ms | 0.0756 ms |  1.159 ms |  1.0547 ms |  1.538 ms | 822.76 |  22.18 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.230 ms | 0.1864 ms | 0.0967 ms |  1.169 ms |  1.0222 ms |  1.823 ms | 813.12 |  23.16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.235 ms | 0.1439 ms | 0.0738 ms |  1.180 ms |  1.0613 ms |  1.604 ms | 809.41 |  25.59 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.247 ms | 0.1050 ms | 0.0532 ms |  1.234 ms |  1.0762 ms |  1.548 ms | 802.21 |  25.88 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.250 ms | 0.1328 ms | 0.0689 ms |  1.223 ms |  1.0672 ms |  1.638 ms | 800.03 |  25.88 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.253 ms | 0.2821 ms | 0.1464 ms |  1.151 ms |  0.9236 ms |  1.818 ms | 798.31 |  20.63 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.259 ms | 0.1101 ms | 0.0579 ms |  1.236 ms |  1.0862 ms |  1.571 ms | 794.06 |  25.59 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.268 ms | 0.1899 ms | 0.0951 ms |  1.233 ms |  0.9851 ms |  1.788 ms | 788.50 |   19.7 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.269 ms | 0.2365 ms | 0.1227 ms |  1.187 ms |  1.0059 ms |  1.954 ms | 788.16 |  23.19 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.283 ms | 0.2519 ms | 0.1324 ms |  1.257 ms |  0.9519 ms |  1.976 ms | 779.54 |   20.6 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.283 ms | 0.2369 ms | 0.1229 ms |  1.215 ms |  0.9964 ms |  1.841 ms | 779.53 |  23.16 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.296 ms | 0.1587 ms | 0.0814 ms |  1.259 ms |  1.0458 ms |  1.673 ms | 771.44 |  25.62 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.298 ms | 0.1971 ms | 0.0987 ms |  1.222 ms |  1.0675 ms |  1.806 ms | 770.56 |  49.61 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.301 ms | 0.2124 ms | 0.1102 ms |  1.250 ms |  1.0304 ms |  1.849 ms | 768.41 |  23.16 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.308 ms | 0.2233 ms | 0.1174 ms |  1.223 ms |  1.0862 ms |  1.871 ms | 764.38 |  25.91 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.319 ms | 0.1333 ms | 0.0675 ms |  1.300 ms |  1.0959 ms |  1.610 ms | 757.95 |  25.88 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.319 ms | 0.3157 ms | 0.1659 ms |  1.210 ms |  0.9929 ms |  2.281 ms | 757.90 |  22.88 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.353 ms | 0.3308 ms | 0.1656 ms |  1.238 ms |  0.9847 ms |  2.305 ms | 739.04 |  23.36 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.359 ms | 0.2524 ms | 0.1327 ms |  1.259 ms |  1.0819 ms |  1.922 ms | 735.59 |  22.18 KB |
| Single                                    | InsightBenchmark      |  1.363 ms | 0.2986 ms | 0.1550 ms |  1.325 ms |  0.9566 ms |  2.182 ms | 733.59 |  20.64 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.367 ms | 0.4951 ms | 0.2570 ms |  1.114 ms |  0.9688 ms |  2.505 ms | 731.29 |  23.36 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.372 ms | 0.2465 ms | 0.1312 ms |  1.288 ms |  1.0843 ms |  1.996 ms | 728.96 |  25.88 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.387 ms | 0.3395 ms | 0.1700 ms |  1.292 ms |  1.0050 ms |  2.480 ms | 720.92 |  22.88 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.388 ms | 0.2645 ms | 0.1427 ms |  1.356 ms |  1.0695 ms |  2.277 ms | 720.39 |  22.23 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.396 ms | 0.3297 ms | 0.1651 ms |  1.283 ms |  1.0106 ms |  2.174 ms | 716.36 |  47.05 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.466 ms | 0.4268 ms | 0.2162 ms |  1.281 ms |  1.0587 ms |  2.645 ms | 682.12 |  25.91 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.520 ms | 0.4860 ms | 0.2554 ms |  1.334 ms |  1.0466 ms |  2.668 ms | 658.08 |  23.19 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.825 ms | 0.5374 ms | 0.2691 ms |  1.870 ms |  0.9961 ms |  2.664 ms | 547.99 |  22.23 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2.804 ms | 0.1968 ms | 0.0985 ms |  2.806 ms |  2.4403 ms |  3.170 ms | 356.66 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2.942 ms | 0.1408 ms | 0.0697 ms |  2.918 ms |  2.7144 ms |  3.315 ms | 339.96 |  45.65 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.999 ms | 0.4744 ms | 0.2376 ms |  2.811 ms |  2.4885 ms |  4.250 ms | 333.47 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.021 ms | 0.2221 ms | 0.1139 ms |  2.959 ms |  2.6785 ms |  3.658 ms | 331.01 |  45.65 KB |
|                                           |                       |           |           |           |           |            |           |        |           |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10.821 ms | 0.4473 ms | 0.2322 ms | 10.808 ms |  9.8926 ms | 11.715 ms |  92.41 |  24.16 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.933 ms | 0.5933 ms | 0.2937 ms | 10.904 ms |  9.8247 ms | 12.378 ms |  91.47 |  34.38 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.025 ms | 0.5705 ms | 0.2890 ms | 11.006 ms |  9.7605 ms | 12.881 ms |  90.70 |  24.79 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11.032 ms | 0.5409 ms | 0.2773 ms | 10.959 ms |  9.7424 ms | 12.367 ms |  90.65 |  22.53 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.340 ms | 0.8074 ms | 0.4140 ms | 11.285 ms | 10.2061 ms | 15.142 ms |  88.19 |  35.02 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11.448 ms | 1.5278 ms | 0.7833 ms | 11.105 ms |  9.8442 ms | 17.340 ms |  87.35 |  22.13 KB |
