# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.104
  [Host]   : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.033 ms | 0.0844 ms | 0.0444 ms |  1.009 ms |  0.9144 ms |  1.303 ms | 967.97 |   20.6 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.041 ms | 0.0561 ms | 0.0295 ms |  1.038 ms |  0.9092 ms |  1.181 ms | 960.69 |  19.76 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.042 ms | 0.0929 ms | 0.0482 ms |  1.012 ms |  0.9167 ms |  1.266 ms | 960.08 |  20.92 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.055 ms | 0.0760 ms | 0.0381 ms |  1.026 ms |  0.9616 ms |  1.302 ms | 947.63 |  20.95 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.057 ms | 0.1015 ms | 0.0540 ms |  1.033 ms |  0.9117 ms |  1.385 ms | 945.92 |  20.92 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.069 ms | 0.0752 ms | 0.0386 ms |  1.055 ms |  0.9443 ms |  1.250 ms | 935.88 |  23.32 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.069 ms | 0.1378 ms | 0.0706 ms |  1.027 ms |  0.8917 ms |  1.562 ms | 935.77 |   20.6 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.083 ms | 0.0791 ms | 0.0406 ms |  1.065 ms |  0.9486 ms |  1.297 ms | 923.58 |  23.34 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.084 ms | 0.0793 ms | 0.0402 ms |  1.074 ms |  0.9845 ms |  1.274 ms | 922.72 |  22.88 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.088 ms | 0.1336 ms | 0.0677 ms |  1.052 ms |  0.8823 ms |  1.382 ms | 918.72 |   20.6 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.095 ms | 0.1442 ms | 0.0739 ms |  1.063 ms |  0.8951 ms |  1.315 ms | 913.12 |   20.6 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.103 ms | 0.0836 ms | 0.0429 ms |  1.093 ms |  0.9553 ms |  1.325 ms | 907.02 |  23.34 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.103 ms | 0.1239 ms | 0.0651 ms |  1.066 ms |  0.9168 ms |  1.489 ms | 906.61 |  20.95 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.103 ms | 0.1259 ms | 0.0645 ms |  1.071 ms |  0.9422 ms |  1.490 ms | 906.57 |  20.63 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.114 ms | 0.1312 ms | 0.0681 ms |  1.077 ms |  0.9363 ms |  1.490 ms | 897.40 |  20.62 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.115 ms | 0.0926 ms | 0.0480 ms |  1.086 ms |  0.9985 ms |  1.401 ms | 896.50 |  23.16 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.116 ms | 0.1091 ms | 0.0566 ms |  1.088 ms |  0.9834 ms |  1.599 ms | 896.21 |  23.19 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.126 ms | 0.1309 ms | 0.0688 ms |  1.077 ms |  0.9658 ms |  1.480 ms | 887.82 |  23.34 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.127 ms | 0.1438 ms | 0.0756 ms |  1.098 ms |  0.9427 ms |  1.621 ms | 887.07 |  23.34 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.131 ms | 0.2259 ms | 0.1144 ms |  1.069 ms |  0.9440 ms |  1.947 ms | 883.92 |  20.62 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.139 ms | 0.0938 ms | 0.0470 ms |  1.130 ms |  0.9745 ms |  1.386 ms | 878.28 |  23.36 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.141 ms | 0.2105 ms | 0.1107 ms |  1.073 ms |  0.8975 ms |  1.859 ms | 876.59 |  20.92 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.150 ms | 0.1998 ms | 0.1012 ms |  1.053 ms |  0.9717 ms |  1.743 ms | 869.81 |  23.32 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.152 ms | 0.0715 ms | 0.0362 ms |  1.135 ms |  1.0407 ms |  1.339 ms | 868.20 |  25.59 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.153 ms | 0.2043 ms | 0.1047 ms |  1.073 ms |  0.9534 ms |  1.665 ms | 867.00 |  22.88 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.155 ms | 0.1269 ms | 0.0636 ms |  1.115 ms |  0.9833 ms |  1.588 ms | 866.10 |  22.18 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.159 ms | 0.1230 ms | 0.0609 ms |  1.128 ms |  1.0031 ms |  1.476 ms | 862.97 |  23.34 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.161 ms | 0.0782 ms | 0.0406 ms |  1.141 ms |  1.0074 ms |  1.381 ms | 861.39 |  25.88 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.165 ms | 0.0633 ms | 0.0325 ms |  1.150 ms |  1.0517 ms |  1.353 ms | 858.09 |  25.88 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.167 ms | 0.1338 ms | 0.0670 ms |  1.133 ms |  1.0028 ms |  1.668 ms | 856.76 |  22.18 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.176 ms | 0.0601 ms | 0.0312 ms |  1.164 ms |  1.0211 ms |  1.308 ms | 850.69 |  25.62 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.184 ms | 0.2045 ms | 0.1075 ms |  1.104 ms |  0.9817 ms |  1.648 ms | 844.36 |  23.16 KB |
| Single                                    | InsightBenchmark      |  1.189 ms | 0.1900 ms | 0.1025 ms |  1.146 ms |  0.9221 ms |  1.700 ms | 840.88 |  52.81 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.190 ms | 0.0985 ms | 0.0499 ms |  1.162 ms |  1.0629 ms |  1.443 ms | 840.30 |  25.59 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.191 ms | 0.0793 ms | 0.0397 ms |  1.171 ms |  1.0683 ms |  1.360 ms | 839.53 |  25.91 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.193 ms | 0.2827 ms | 0.1486 ms |  1.045 ms |  0.8945 ms |  1.854 ms | 838.21 |  20.63 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.194 ms | 0.1933 ms | 0.0979 ms |  1.102 ms |  0.9757 ms |  1.688 ms | 837.71 |  23.16 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.196 ms | 0.1649 ms | 0.0826 ms |  1.138 ms |  0.9678 ms |  1.633 ms | 835.96 |  20.95 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.204 ms | 0.2112 ms | 0.1083 ms |  1.184 ms |  0.8815 ms |  1.698 ms | 830.70 |  20.92 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.207 ms | 0.2327 ms | 0.1179 ms |  1.114 ms |  0.9490 ms |  1.703 ms | 828.70 |  23.16 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.207 ms | 0.0893 ms | 0.0458 ms |  1.188 ms |  1.0602 ms |  1.418 ms | 828.66 |  25.88 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.246 ms | 0.2869 ms | 0.1471 ms |  1.067 ms |  0.9341 ms |  1.954 ms | 802.49 |  52.79 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.254 ms | 0.2019 ms | 0.1023 ms |  1.203 ms |  1.0001 ms |  1.742 ms | 797.36 |  23.34 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.256 ms | 0.1640 ms | 0.0821 ms |  1.202 ms |  1.0573 ms |  1.656 ms | 796.48 |  25.88 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.256 ms | 0.2321 ms | 0.1220 ms |  1.172 ms |  1.0011 ms |  2.069 ms | 796.37 |  23.19 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.259 ms | 0.1384 ms | 0.0701 ms |  1.222 ms |  1.0160 ms |  1.593 ms | 794.47 |  22.23 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.266 ms | 0.2475 ms | 0.1254 ms |  1.185 ms |  0.9663 ms |  1.860 ms | 789.75 |  20.95 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.267 ms | 0.1752 ms | 0.0877 ms |  1.185 ms |  1.0742 ms |  1.701 ms | 789.23 |  25.62 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.274 ms | 0.1526 ms | 0.0773 ms |  1.266 ms |  1.0740 ms |  1.565 ms | 784.69 |  23.19 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.276 ms | 0.2357 ms | 0.1167 ms |  1.203 ms |  0.9906 ms |  1.876 ms | 783.43 |  19.76 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.283 ms | 0.3698 ms | 0.1873 ms |  1.119 ms |  0.9193 ms |  2.133 ms | 779.20 |  20.62 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.297 ms | 0.1754 ms | 0.0922 ms |  1.252 ms |  1.0412 ms |  1.750 ms | 771.07 |  25.88 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.308 ms | 0.1453 ms | 0.0736 ms |  1.284 ms |  1.1050 ms |  1.609 ms | 764.55 |  25.91 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.309 ms | 0.3552 ms | 0.1844 ms |  1.160 ms |  0.9808 ms |  2.244 ms | 763.99 |  23.32 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.310 ms | 0.2516 ms | 0.1290 ms |  1.229 ms |  0.9711 ms |  2.102 ms | 763.27 |   19.7 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.332 ms | 0.5481 ms | 0.2881 ms |  1.097 ms |  0.9683 ms |  3.256 ms | 750.66 |  23.32 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.348 ms | 0.5861 ms | 0.3042 ms |  1.104 ms |  0.9756 ms |  3.564 ms | 741.84 |  23.36 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.368 ms | 0.4689 ms | 0.2434 ms |  1.122 ms |  0.9870 ms |  2.412 ms | 731.08 |  22.23 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.417 ms | 0.4834 ms | 0.2420 ms |  1.207 ms |  1.0066 ms |  2.913 ms | 705.50 |  25.88 KB |
| Single                                    | InsightBenchmarkWrite |  1.448 ms | 0.2517 ms | 0.1275 ms |  1.381 ms |  1.1173 ms |  2.087 ms | 690.75 |  20.64 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.451 ms | 0.4803 ms | 0.2405 ms |  1.187 ms |  0.9682 ms |  2.472 ms | 689.25 |  22.88 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.494 ms | 0.3212 ms | 0.1609 ms |  1.393 ms |  1.1189 ms |  2.205 ms | 669.14 |  23.16 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.636 ms | 0.3925 ms | 0.1943 ms |  1.587 ms |  1.0565 ms |  2.475 ms | 611.06 |  49.61 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.654 ms | 0.3219 ms | 0.1593 ms |  1.748 ms |  1.0214 ms |  2.075 ms | 604.75 |  47.06 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.654 ms | 0.3325 ms | 0.1665 ms |  1.672 ms |  1.0386 ms |  2.363 ms | 604.64 |  47.05 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.714 ms | 0.4667 ms | 0.2337 ms |  1.754 ms |  0.9367 ms |  2.449 ms | 583.60 |   19.7 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.769 ms | 0.4793 ms | 0.2519 ms |  1.868 ms |  1.1045 ms |  2.570 ms | 565.28 |  49.61 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.885 ms | 0.6121 ms | 0.3177 ms |  1.877 ms |  1.1176 ms |  3.344 ms | 530.47 |  55.36 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.993 ms | 0.2916 ms | 0.1532 ms |  2.896 ms |  2.6509 ms |  3.725 ms | 334.08 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  3.078 ms | 0.3133 ms | 0.1668 ms |  3.043 ms |  2.6112 ms |  3.828 ms | 324.90 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3.321 ms | 0.4834 ms | 0.2574 ms |  3.106 ms |  2.8529 ms |  4.630 ms | 301.12 |  45.65 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.638 ms | 0.6897 ms | 0.3536 ms |  3.621 ms |  2.7639 ms |  5.356 ms | 274.85 |  45.65 KB |
|                                           |                       |           |           |           |           |            |           |        |           |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.608 ms | 0.6217 ms | 0.3227 ms | 10.806 ms |  8.9154 ms | 12.192 ms |  94.27 |  34.38 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 10.900 ms | 0.4133 ms | 0.2119 ms | 10.999 ms | 10.1229 ms | 11.791 ms |  91.74 |  22.13 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11.080 ms | 0.5417 ms | 0.2812 ms | 11.083 ms |  9.9858 ms | 12.131 ms |  90.26 |  22.53 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.111 ms | 0.6312 ms | 0.3452 ms | 11.060 ms |  9.8798 ms | 13.034 ms |  90.00 |   24.5 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.135 ms | 0.7574 ms | 0.3931 ms | 10.959 ms |  9.8161 ms | 13.608 ms |  89.80 |  24.16 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.170 ms | 0.5764 ms | 0.3109 ms | 11.109 ms | 10.1566 ms | 12.962 ms |  89.52 |  35.02 KB |
