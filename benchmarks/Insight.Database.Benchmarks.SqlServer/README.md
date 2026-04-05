# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8117/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.045 ms | 0.0860 ms | 0.0464 ms |  1.040 ms |  0.8908 ms |  1.292 ms | 957.30 |  12.16 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.046 ms | 0.1032 ms | 0.0557 ms |  1.030 ms |  0.8841 ms |  1.296 ms | 956.04 |  11.09 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.051 ms | 0.1174 ms | 0.0617 ms |  1.050 ms |  0.8881 ms |  1.304 ms | 951.55 |  11.07 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.062 ms | 0.1349 ms | 0.0700 ms |  1.026 ms |  0.8641 ms |  1.476 ms | 941.31 |  11.41 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.071 ms | 0.1046 ms | 0.0557 ms |  1.037 ms |  0.9487 ms |  1.367 ms | 933.35 |  11.84 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.074 ms | 0.1344 ms | 0.0697 ms |  1.024 ms |  0.8948 ms |  1.500 ms | 931.28 |  11.43 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.075 ms | 0.1331 ms | 0.0728 ms |  1.029 ms |  0.9459 ms |  1.526 ms | 929.86 |  11.73 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.077 ms | 0.1143 ms | 0.0593 ms |  1.044 ms |  0.9035 ms |  1.477 ms | 928.59 |  11.09 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.096 ms | 0.0997 ms | 0.0531 ms |  1.079 ms |  0.9285 ms |  1.317 ms | 912.67 |  11.82 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.101 ms | 0.1171 ms | 0.0608 ms |  1.077 ms |  0.9412 ms |  1.529 ms | 908.50 |  12.16 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.103 ms | 0.1623 ms | 0.0822 ms |  1.056 ms |  0.8944 ms |  1.667 ms | 906.41 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.105 ms | 0.1577 ms | 0.0809 ms |  1.042 ms |  0.8895 ms |  1.613 ms | 904.81 |  11.07 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.106 ms | 0.1348 ms | 0.0699 ms |  1.073 ms |  0.9223 ms |  1.403 ms | 903.93 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.108 ms | 0.1503 ms | 0.0790 ms |  1.060 ms |  0.9243 ms |  1.520 ms | 902.88 |  11.07 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.111 ms | 0.1318 ms | 0.0684 ms |  1.072 ms |  0.9437 ms |  1.509 ms | 900.13 |  11.73 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.114 ms | 0.1237 ms | 0.0642 ms |  1.104 ms |  0.8880 ms |  1.434 ms | 897.77 |  12.48 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.125 ms | 0.0881 ms | 0.0463 ms |  1.121 ms |  0.9660 ms |  1.272 ms | 889.16 |  12.83 KB |
| Single                                    | InsightBenchmarkWrite |  1.130 ms | 0.1357 ms | 0.0713 ms |  1.104 ms |  0.9454 ms |  1.502 ms | 884.85 |  12.18 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.147 ms | 0.1354 ms | 0.0712 ms |  1.115 ms |  0.9808 ms |  1.563 ms | 871.88 |  11.43 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.148 ms | 0.1996 ms | 0.1049 ms |  1.091 ms |  0.9480 ms |  1.783 ms | 871.22 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.149 ms | 0.1018 ms | 0.0542 ms |  1.121 ms |  1.0042 ms |  1.519 ms | 870.42 |  13.17 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.161 ms | 0.1071 ms | 0.0563 ms |  1.150 ms |  1.0221 ms |  1.489 ms | 861.52 |  13.65 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.176 ms | 0.1825 ms | 0.0985 ms |  1.119 ms |  0.9797 ms |  1.590 ms | 850.15 |  12.88 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.181 ms | 0.1844 ms | 0.0945 ms |  1.117 ms |  0.9232 ms |  1.704 ms | 847.10 |  11.07 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.184 ms | 0.1142 ms | 0.0600 ms |  1.165 ms |  0.9770 ms |  1.467 ms | 844.75 |  14.27 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.188 ms | 0.2473 ms | 0.1300 ms |  1.106 ms |  0.9101 ms |  1.864 ms | 841.73 |  11.73 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.198 ms | 0.1229 ms | 0.0654 ms |  1.165 ms |  1.0178 ms |  1.543 ms | 834.76 |  13.52 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.201 ms | 0.0991 ms | 0.0521 ms |  1.197 ms |  1.0441 ms |  1.453 ms | 832.79 |  14.17 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.202 ms | 0.3356 ms | 0.1742 ms |  1.036 ms |  0.9238 ms |  2.177 ms | 831.85 |  11.82 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.203 ms | 0.1395 ms | 0.0724 ms |  1.161 ms |  1.0214 ms |  1.603 ms | 831.56 |  13.92 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.217 ms | 0.1644 ms | 0.0853 ms |  1.189 ms |  1.0091 ms |  1.657 ms | 821.95 |  13.17 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.218 ms | 0.2281 ms | 0.1184 ms |  1.119 ms |  0.9749 ms |  2.051 ms | 821.14 |  13.42 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.229 ms | 0.1943 ms | 0.1009 ms |  1.193 ms |  0.9777 ms |  1.961 ms | 813.77 |  13.42 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.239 ms | 0.1482 ms | 0.0779 ms |  1.193 ms |  1.0489 ms |  1.720 ms | 807.27 |  13.83 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.242 ms | 0.2114 ms | 0.1126 ms |  1.163 ms |  0.9685 ms |  1.895 ms | 805.19 |  13.17 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.244 ms | 0.2559 ms | 0.1345 ms |  1.162 ms |  0.9085 ms |  1.830 ms | 803.84 |  12.48 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.251 ms | 0.1412 ms | 0.0724 ms |  1.230 ms |  1.0215 ms |  1.628 ms | 799.50 |  15.12 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.255 ms | 0.1250 ms | 0.0665 ms |  1.238 ms |  1.0595 ms |  1.671 ms | 796.74 |  13.65 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.255 ms | 0.2027 ms | 0.1093 ms |  1.191 ms |  1.0224 ms |  1.862 ms | 796.73 |  13.08 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.255 ms | 0.1767 ms | 0.0895 ms |  1.195 ms |  1.0383 ms |  1.700 ms | 796.56 |  14.05 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.257 ms | 0.1586 ms | 0.0834 ms |  1.213 ms |  1.0428 ms |  1.607 ms | 795.55 |   14.4 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.270 ms | 0.1506 ms | 0.0782 ms |  1.250 ms |  1.0940 ms |  1.867 ms | 787.63 |  14.98 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.270 ms | 0.1942 ms | 0.1034 ms |  1.234 ms |  0.9540 ms |  1.759 ms | 787.62 |  12.48 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.271 ms | 0.2103 ms | 0.1092 ms |  1.244 ms |  1.0311 ms |  1.999 ms | 786.74 |  13.08 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.278 ms | 0.1954 ms | 0.1040 ms |  1.223 ms |  1.0174 ms |  1.939 ms | 782.29 |  35.65 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.282 ms | 0.2770 ms | 0.1475 ms |  1.185 ms |  0.9996 ms |  2.292 ms | 780.24 |  12.88 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.285 ms | 0.2285 ms | 0.1171 ms |  1.231 ms |  1.0185 ms |  1.960 ms | 778.46 |  11.84 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.289 ms | 0.4330 ms | 0.2247 ms |  1.118 ms |  0.9181 ms |  2.572 ms | 775.72 |  11.09 KB |
| Single                                    | InsightBenchmark      |  1.290 ms | 0.3586 ms | 0.1861 ms |  1.180 ms |  0.9254 ms |  2.564 ms | 774.96 |  12.18 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.296 ms | 0.1712 ms | 0.0900 ms |  1.273 ms |  1.1081 ms |  1.997 ms | 771.55 |  14.94 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.322 ms | 0.2666 ms | 0.1351 ms |  1.242 ms |  1.0259 ms |  2.199 ms | 756.47 |  13.08 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.337 ms | 0.1626 ms | 0.0834 ms |  1.300 ms |  1.0917 ms |  1.806 ms | 748.07 |  37.66 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.339 ms | 0.1921 ms | 0.1010 ms |  1.305 ms |  1.0965 ms |  1.919 ms | 747.03 |  35.66 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.340 ms | 0.3216 ms | 0.1669 ms |  1.303 ms |  0.9588 ms |  2.213 ms | 746.35 |  11.73 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.378 ms | 0.1788 ms | 0.0940 ms |  1.317 ms |  1.1424 ms |  1.819 ms | 725.51 |  37.75 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.396 ms | 0.2998 ms | 0.1501 ms |  1.308 ms |  1.0047 ms |  2.257 ms | 716.56 |  13.17 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.396 ms | 0.4134 ms | 0.2146 ms |  1.214 ms |  1.0054 ms |  2.629 ms | 716.49 |  13.08 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.436 ms | 0.5703 ms | 0.2960 ms |  1.236 ms |  0.9085 ms |  3.499 ms | 696.39 |  11.09 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1.487 ms | 0.2462 ms | 0.1294 ms |  1.428 ms |  1.1803 ms |  2.045 ms | 672.42 |  65.32 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.489 ms | 0.2247 ms | 0.1125 ms |  1.479 ms |  1.0380 ms |  2.168 ms | 671.40 |  11.43 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.492 ms | 0.3319 ms | 0.1767 ms |  1.423 ms |  1.0268 ms |  2.347 ms | 670.40 |  13.52 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.499 ms | 0.3737 ms | 0.1916 ms |  1.385 ms |  0.9845 ms |  2.673 ms | 667.19 |  12.48 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.508 ms | 0.3407 ms | 0.1791 ms |  1.416 ms |  1.0631 ms |  2.510 ms | 662.97 |  13.99 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.534 ms | 0.2888 ms | 0.1463 ms |  1.492 ms |  1.0093 ms |  2.539 ms | 651.70 |  11.43 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  1.559 ms | 0.2703 ms | 0.1439 ms |  1.475 ms |  1.2208 ms |  2.299 ms | 641.41 |  67.33 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1.576 ms | 0.3132 ms | 0.1668 ms |  1.482 ms |  1.2099 ms |  2.420 ms | 634.34 |  65.34 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.596 ms | 0.1572 ms | 0.0806 ms |  1.601 ms |  1.2519 ms |  1.907 ms | 626.69 |  12.83 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.630 ms | 0.2244 ms | 0.1137 ms |  1.591 ms |  1.1441 ms |  2.296 ms | 613.58 |  13.42 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.671 ms | 0.6558 ms | 0.3447 ms |  1.442 ms |  1.0657 ms |  3.760 ms | 598.31 |  13.42 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1.682 ms | 0.3424 ms | 0.1755 ms |  1.542 ms |  1.3285 ms |  2.757 ms | 594.53 |  67.42 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.713 ms | 0.3786 ms | 0.1918 ms |  1.760 ms |  1.0421 ms |  2.495 ms | 583.75 |  14.17 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.723 ms | 0.8657 ms | 0.4438 ms |  1.318 ms |  1.0842 ms |  4.420 ms | 580.23 |  14.94 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2.440 ms | 0.1645 ms | 0.0876 ms |  2.426 ms |  2.2148 ms |  2.886 ms | 409.81 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.687 ms | 0.3707 ms | 0.1924 ms |  2.571 ms |  2.2083 ms |  3.505 ms | 372.12 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.113 ms | 0.3770 ms | 0.2007 ms |  2.969 ms |  2.6772 ms |  4.072 ms | 321.19 |  31.58 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3.268 ms | 0.6481 ms | 0.3283 ms |  3.012 ms |  2.7197 ms |  5.588 ms | 305.98 |  31.58 KB |
|                                           |                       |           |           |           |           |            |           |        |           |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10.901 ms | 1.1538 ms | 0.5777 ms | 11.223 ms |  7.6067 ms | 12.574 ms |  91.74 |  13.08 KB |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11.349 ms | 0.4810 ms | 0.2408 ms | 11.324 ms | 10.4303 ms | 12.277 ms |  88.11 |   4.64 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11.364 ms | 0.5552 ms | 0.2780 ms | 11.236 ms | 10.4332 ms | 12.840 ms |  88.00 |   7.17 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.378 ms | 0.5392 ms | 0.2799 ms | 11.276 ms | 10.3525 ms | 12.635 ms |  87.89 |   7.17 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.490 ms | 0.4814 ms | 0.2411 ms | 11.452 ms | 10.6033 ms | 12.703 ms |  87.04 |   6.99 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.695 ms | 1.5236 ms | 0.7629 ms | 11.357 ms |  9.1488 ms | 17.068 ms |  85.51 |   4.64 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.728 ms | 0.6189 ms | 0.3099 ms | 11.769 ms | 10.4326 ms | 13.031 ms |  85.27 |  15.34 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 12.141 ms | 2.4053 ms | 1.2044 ms | 11.420 ms |  9.4290 ms | 22.541 ms |  82.36 |   4.64 KB |
