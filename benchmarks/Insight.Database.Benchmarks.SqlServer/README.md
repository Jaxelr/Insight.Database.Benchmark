# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9278/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.021 ms | 0.0653 ms | 0.0339 ms |  1.023 ms |  0.8889 ms |  1.157 ms | 979.76 |  11.09 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.040 ms | 0.0536 ms | 0.0282 ms |  1.030 ms |  0.9043 ms |  1.176 ms | 961.56 |  11.09 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.042 ms | 0.0827 ms | 0.0424 ms |  1.026 ms |  0.8969 ms |  1.278 ms | 959.41 |  11.41 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.060 ms | 0.0992 ms | 0.0521 ms |  1.024 ms |  0.9098 ms |  1.392 ms | 943.75 |  11.43 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.060 ms | 0.0973 ms | 0.0505 ms |  1.040 ms |  0.9481 ms |  1.379 ms | 943.01 |  11.43 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.063 ms | 0.0680 ms | 0.0349 ms |  1.050 ms |  0.9298 ms |  1.271 ms | 941.15 |  11.84 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.077 ms | 0.0833 ms | 0.0427 ms |  1.055 ms |  0.9765 ms |  1.394 ms | 928.83 |  11.73 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.080 ms | 0.0991 ms | 0.0514 ms |  1.043 ms |  0.9449 ms |  1.351 ms | 926.27 |  11.07 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.081 ms | 0.0947 ms | 0.0474 ms |  1.041 ms |  0.9438 ms |  1.303 ms | 924.80 |  12.48 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.091 ms | 0.1218 ms | 0.0648 ms |  1.054 ms |  0.9156 ms |  1.400 ms | 916.20 |  11.43 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.095 ms | 0.0826 ms | 0.0429 ms |  1.075 ms |  0.9738 ms |  1.353 ms | 913.53 |  11.73 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.095 ms | 0.0809 ms | 0.0431 ms |  1.095 ms |  0.9357 ms |  1.343 ms | 913.41 |  12.16 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.095 ms | 0.0750 ms | 0.0399 ms |  1.086 ms |  0.9670 ms |  1.307 ms | 912.83 |  12.16 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.099 ms | 0.1267 ms | 0.0658 ms |  1.049 ms |  0.9330 ms |  1.603 ms | 909.64 |  11.07 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.100 ms | 0.1353 ms | 0.0702 ms |  1.065 ms |  0.9369 ms |  1.619 ms | 909.11 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.102 ms | 0.1106 ms | 0.0582 ms |  1.061 ms |  0.9058 ms |  1.417 ms | 907.68 |  11.07 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.102 ms | 0.1358 ms | 0.0688 ms |  1.071 ms |  0.9092 ms |  1.431 ms | 907.49 |  11.41 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.106 ms | 0.0912 ms | 0.0462 ms |  1.078 ms |  0.9548 ms |  1.331 ms | 904.20 |  12.48 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.108 ms | 0.1012 ms | 0.0546 ms |  1.106 ms |  0.9688 ms |  1.364 ms | 902.85 |  11.82 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.108 ms | 0.1283 ms | 0.0666 ms |  1.057 ms |  0.9547 ms |  1.441 ms | 902.79 |  12.83 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.114 ms | 0.1210 ms | 0.0628 ms |  1.098 ms |  0.9085 ms |  1.508 ms | 897.90 |  11.07 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.117 ms | 0.0923 ms | 0.0485 ms |  1.088 ms |  0.9595 ms |  1.389 ms | 895.43 |  11.09 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.125 ms | 0.1260 ms | 0.0662 ms |  1.102 ms |  0.8839 ms |  1.417 ms | 888.54 |  11.43 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.128 ms | 0.0430 ms | 0.0226 ms |  1.127 ms |  1.0431 ms |  1.226 ms | 886.39 |  13.52 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.129 ms | 0.0969 ms | 0.0516 ms |  1.111 ms |  0.9591 ms |  1.404 ms | 886.08 |  11.84 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.135 ms | 0.1347 ms | 0.0691 ms |  1.092 ms |  0.9771 ms |  1.504 ms | 880.77 |  11.73 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.159 ms | 0.0572 ms | 0.0297 ms |  1.147 ms |  1.0494 ms |  1.360 ms | 862.68 |  13.08 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.165 ms | 0.1849 ms | 0.0936 ms |  1.107 ms |  0.9316 ms |  1.951 ms | 858.42 |  11.41 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.168 ms | 0.0683 ms | 0.0350 ms |  1.156 ms |  1.0544 ms |  1.355 ms | 856.31 |  13.59 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.169 ms | 0.0677 ms | 0.0347 ms |  1.156 ms |  1.0490 ms |  1.330 ms | 855.07 |  13.21 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.174 ms | 0.0883 ms | 0.0453 ms |  1.159 ms |  1.0108 ms |  1.436 ms | 851.56 |  13.17 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.178 ms | 0.0792 ms | 0.0427 ms |  1.173 ms |  0.9971 ms |  1.356 ms | 848.72 |  13.55 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.183 ms | 0.1311 ms | 0.0698 ms |  1.153 ms |  0.9721 ms |  1.515 ms | 845.49 |  12.88 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.185 ms | 0.0753 ms | 0.0406 ms |  1.178 ms |  1.0802 ms |  1.393 ms | 843.92 |  14.27 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.186 ms | 0.1366 ms | 0.0701 ms |  1.165 ms |  0.9900 ms |  1.589 ms | 843.35 |  11.82 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.186 ms | 0.0558 ms | 0.0293 ms |  1.191 ms |  1.0452 ms |  1.311 ms | 843.25 |  14.98 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.202 ms | 0.0611 ms | 0.0317 ms |  1.196 ms |  1.0891 ms |  1.343 ms | 832.07 |  13.83 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.205 ms | 0.1700 ms | 0.0872 ms |  1.139 ms |  1.0196 ms |  1.646 ms | 829.90 |  12.48 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.205 ms | 0.1854 ms | 0.0987 ms |  1.159 ms |  0.9865 ms |  1.889 ms | 829.76 |  11.09 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.208 ms | 0.1071 ms | 0.0556 ms |  1.181 ms |  1.0695 ms |  1.535 ms | 827.65 |  13.17 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.209 ms | 0.1357 ms | 0.0704 ms |  1.161 ms |  1.0424 ms |  1.590 ms | 827.16 |  35.65 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.218 ms | 0.0814 ms | 0.0439 ms |  1.208 ms |  1.0497 ms |  1.405 ms | 821.27 |  13.52 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.226 ms | 0.1028 ms | 0.0541 ms |  1.191 ms |  1.0589 ms |  1.519 ms | 815.59 |  13.52 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.235 ms | 0.1127 ms | 0.0616 ms |  1.207 ms |  1.0813 ms |  1.532 ms | 809.63 |  13.92 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.238 ms | 0.1435 ms | 0.0745 ms |  1.202 ms |  1.0619 ms |  1.720 ms | 808.04 |  13.42 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.239 ms | 0.0975 ms | 0.0526 ms |  1.232 ms |  1.0141 ms |  1.484 ms | 806.79 |  13.24 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.242 ms | 0.1068 ms | 0.0554 ms |  1.218 ms |  1.0713 ms |  1.502 ms | 804.83 |  14.94 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.251 ms | 0.1266 ms | 0.0657 ms |  1.229 ms |  1.0632 ms |  1.691 ms | 799.49 |  14.17 KB |
| Single                                    | InsightBenchmark      |  1.259 ms | 0.2604 ms | 0.1369 ms |  1.192 ms |  0.9504 ms |  2.007 ms | 794.30 |  12.18 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.260 ms | 0.2158 ms | 0.1120 ms |  1.200 ms |  0.9701 ms |  1.709 ms | 793.45 |  12.88 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.264 ms | 0.2044 ms | 0.1061 ms |  1.174 ms |  0.9632 ms |  1.719 ms | 791.44 |  12.83 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.266 ms | 0.1928 ms | 0.1026 ms |  1.193 ms |  1.0937 ms |  1.985 ms | 789.86 |  13.52 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.274 ms | 0.1525 ms | 0.0763 ms |  1.220 ms |  1.0937 ms |  1.778 ms | 785.08 |  13.55 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1.282 ms | 0.0715 ms | 0.0371 ms |  1.277 ms |  1.1329 ms |  1.506 ms | 779.95 |  65.32 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1.287 ms | 0.0850 ms | 0.0441 ms |  1.263 ms |  1.1327 ms |  1.483 ms | 777.22 |  65.34 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.292 ms | 0.1385 ms | 0.0728 ms |  1.272 ms |  1.0320 ms |  1.756 ms | 774.14 |  13.83 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.293 ms | 0.1491 ms | 0.0774 ms |  1.275 ms |  1.0269 ms |  1.737 ms | 773.59 |  14.17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.298 ms | 0.1689 ms | 0.0877 ms |  1.257 ms |  1.1064 ms |  1.683 ms | 770.48 |  13.17 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.314 ms | 0.1502 ms | 0.0761 ms |  1.264 ms |  1.0763 ms |  1.653 ms | 761.05 |  13.21 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.315 ms | 0.1315 ms | 0.0682 ms |  1.277 ms |  1.1312 ms |  1.767 ms | 760.62 |  14.94 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.323 ms | 0.5022 ms | 0.2640 ms |  1.133 ms |  1.0005 ms |  3.476 ms | 755.71 |  11.73 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.330 ms | 0.2565 ms | 0.1300 ms |  1.241 ms |  1.1015 ms |  2.429 ms | 751.95 |  14.53 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.337 ms | 0.1639 ms | 0.0861 ms |  1.283 ms |  1.1174 ms |  1.878 ms | 748.22 |  14.98 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.341 ms | 0.2557 ms | 0.1344 ms |  1.249 ms |  1.0723 ms |  2.055 ms | 745.98 |  13.92 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.380 ms | 0.2021 ms | 0.1012 ms |  1.379 ms |  1.0544 ms |  1.804 ms | 724.86 |  12.48 KB |
| Single                                    | InsightBenchmarkWrite |  1.380 ms | 0.4440 ms | 0.2277 ms |  1.202 ms |  0.9565 ms |  2.539 ms | 724.61 |  12.18 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.387 ms | 0.1241 ms | 0.0652 ms |  1.373 ms |  1.2109 ms |  1.727 ms | 720.74 |  35.66 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.401 ms | 0.1603 ms | 0.0832 ms |  1.361 ms |  1.2044 ms |  1.927 ms | 714.00 |  37.75 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.425 ms | 0.1609 ms | 0.0846 ms |  1.363 ms |  1.1573 ms |  1.740 ms | 701.60 |  37.66 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1.428 ms | 0.0590 ms | 0.0310 ms |  1.428 ms |  1.3125 ms |  1.615 ms | 700.50 |  67.55 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  1.440 ms | 0.0782 ms | 0.0428 ms |  1.417 ms |  1.3348 ms |  1.701 ms | 694.39 |  67.33 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.449 ms | 0.4154 ms | 0.2211 ms |  1.271 ms |  1.0812 ms |  2.781 ms | 690.34 |  13.17 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.379 ms | 0.1056 ms | 0.0548 ms |  2.350 ms |  2.2042 ms |  2.699 ms | 420.28 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2.537 ms | 0.2083 ms | 0.1095 ms |  2.479 ms |  2.3020 ms |  3.152 ms | 394.23 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2.875 ms | 0.0799 ms | 0.0409 ms |  2.872 ms |  2.7263 ms |  3.041 ms | 347.83 |  31.58 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2.985 ms | 0.1765 ms | 0.0940 ms |  2.939 ms |  2.6963 ms |  3.588 ms | 335.00 |  31.58 KB |
|                                           |                       |           |           |           |           |            |           |        |           |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10.731 ms | 0.3329 ms | 0.1686 ms | 10.730 ms | 10.0369 ms | 11.603 ms |  93.19 |  13.08 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10.936 ms | 0.4424 ms | 0.2268 ms | 10.861 ms |  9.7285 ms | 11.716 ms |  91.44 |   6.99 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10.958 ms | 0.3640 ms | 0.1844 ms | 10.966 ms | 10.0016 ms | 11.645 ms |  91.25 |  15.34 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.035 ms | 0.3885 ms | 0.1945 ms | 10.968 ms | 10.3486 ms | 12.416 ms |  90.62 |   7.17 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11.103 ms | 0.3454 ms | 0.1815 ms | 11.060 ms | 10.5454 ms | 11.993 ms |  90.07 |   7.17 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11.228 ms | 0.3827 ms | 0.1916 ms | 11.275 ms | 10.4643 ms | 12.046 ms |  89.06 |   4.64 KB |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11.307 ms | 1.7845 ms | 0.9149 ms | 10.813 ms |  8.9559 ms | 16.833 ms |  88.44 |   4.64 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.361 ms | 1.5079 ms | 0.7550 ms | 10.924 ms | 10.1677 ms | 18.544 ms |  88.02 |   4.64 KB |
