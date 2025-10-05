# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26100.6725/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.027 ms | 0.0609 ms | 0.0328 ms |  1.030 ms |  0.9058 ms |  1.177 ms | 973.57 |  11.06 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.034 ms | 0.0781 ms | 0.0400 ms |  1.024 ms |  0.8883 ms |  1.240 ms | 967.31 |  11.06 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.040 ms | 0.0917 ms | 0.0465 ms |  1.022 ms |  0.8982 ms |  1.382 ms | 961.49 |  11.08 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.060 ms | 0.0852 ms | 0.0432 ms |  1.041 ms |  0.9119 ms |  1.258 ms | 943.79 |  11.08 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.084 ms | 0.1041 ms | 0.0554 ms |  1.055 ms |  0.9707 ms |  1.391 ms | 922.86 |  11.81 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.085 ms | 0.0956 ms | 0.0503 ms |  1.085 ms |  0.9416 ms |  1.395 ms | 921.42 |  12.48 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.096 ms | 0.1245 ms | 0.0646 ms |  1.052 ms |  0.9231 ms |  1.521 ms | 912.76 |  11.41 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.100 ms | 0.1251 ms | 0.0649 ms |  1.057 ms |  0.9034 ms |  1.359 ms | 909.09 |  11.41 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.101 ms | 0.1161 ms | 0.0602 ms |  1.065 ms |  0.9592 ms |  1.446 ms | 907.94 |  11.41 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.109 ms | 0.1441 ms | 0.0758 ms |  1.087 ms |  0.9373 ms |  1.698 ms | 901.46 |  12.48 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.114 ms | 0.1265 ms | 0.0656 ms |  1.092 ms |  0.9805 ms |  1.609 ms | 897.79 |  12.87 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.116 ms | 0.1333 ms | 0.0692 ms |  1.093 ms |  0.9449 ms |  1.615 ms | 895.80 |  11.73 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.117 ms | 0.1211 ms | 0.0637 ms |  1.084 ms |  0.9249 ms |  1.492 ms | 895.63 |  11.08 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.129 ms | 0.1679 ms | 0.0871 ms |  1.076 ms |  0.8594 ms |  1.702 ms | 885.62 |  11.08 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1.132 ms | 0.1804 ms | 0.0914 ms |  1.060 ms |  0.9003 ms |  1.605 ms | 883.64 |  11.06 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.143 ms | 0.0946 ms | 0.0485 ms |  1.125 ms |  0.9695 ms |  1.356 ms | 875.16 |  13.16 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.144 ms | 0.0888 ms | 0.0461 ms |  1.126 ms |  1.0299 ms |  1.379 ms | 873.89 |  35.64 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.152 ms | 0.1036 ms | 0.0551 ms |  1.129 ms |  1.0307 ms |  1.431 ms | 868.39 |  13.91 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.152 ms | 0.1527 ms | 0.0803 ms |  1.097 ms |  0.9605 ms |  1.604 ms | 868.09 |  11.81 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.153 ms | 0.1046 ms | 0.0530 ms |  1.128 ms |  0.9919 ms |  1.404 ms | 867.64 |  13.41 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.160 ms | 0.1344 ms | 0.0689 ms |  1.125 ms |  0.9793 ms |  1.714 ms | 861.97 |  13.16 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.167 ms | 0.0744 ms | 0.0382 ms |  1.146 ms |  1.0476 ms |  1.321 ms | 857.24 |  13.51 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.174 ms | 0.1276 ms | 0.0662 ms |  1.144 ms |  1.0087 ms |  1.584 ms | 851.77 |  13.82 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.177 ms | 0.1106 ms | 0.0581 ms |  1.149 ms |  1.0016 ms |  1.462 ms | 849.97 |   14.6 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.181 ms | 0.2018 ms | 0.1022 ms |  1.100 ms |  0.9627 ms |  1.652 ms | 846.77 |  12.48 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.185 ms | 0.2011 ms | 0.1031 ms |  1.090 ms |  0.9773 ms |  1.778 ms | 844.10 |  12.87 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.202 ms | 0.1875 ms | 0.0950 ms |  1.153 ms |  0.9580 ms |  1.767 ms | 831.89 |  11.42 KB |
| Single                                    | InsightBenchmarkWrite |  1.208 ms | 0.2661 ms | 0.1381 ms |  1.122 ms |  0.9579 ms |  2.246 ms | 827.81 |  12.17 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.220 ms | 0.1760 ms | 0.0902 ms |  1.161 ms |  1.0164 ms |  1.724 ms | 819.96 |  13.51 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.226 ms | 0.1492 ms | 0.0774 ms |  1.178 ms |  1.0504 ms |  1.753 ms | 815.64 |  13.51 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.228 ms | 0.2246 ms | 0.1196 ms |  1.143 ms |  1.0021 ms |  1.812 ms | 814.64 |  12.48 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.243 ms | 0.1790 ms | 0.0941 ms |  1.182 ms |  1.0077 ms |  1.641 ms | 804.23 |  13.51 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.251 ms | 0.2628 ms | 0.1381 ms |  1.177 ms |  0.9104 ms |  1.796 ms | 799.55 |  11.73 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.255 ms | 0.2099 ms | 0.1090 ms |  1.177 ms |  1.0355 ms |  2.020 ms | 796.67 |  12.81 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.258 ms | 0.2688 ms | 0.1413 ms |  1.163 ms |  1.0004 ms |  2.045 ms | 794.90 |  12.16 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.264 ms | 0.2138 ms | 0.1124 ms |  1.199 ms |  1.0327 ms |  1.963 ms | 790.90 |  14.97 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.266 ms | 0.2012 ms | 0.1007 ms |  1.202 ms |  1.0290 ms |  1.881 ms | 789.86 |  13.91 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.271 ms | 0.1589 ms | 0.0825 ms |  1.222 ms |  1.0642 ms |  1.704 ms | 786.80 |  16.23 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.303 ms | 0.2478 ms | 0.1270 ms |  1.234 ms |  1.0044 ms |  2.193 ms | 767.19 |  35.66 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.311 ms | 0.2245 ms | 0.1137 ms |  1.216 ms |  1.0196 ms |  1.925 ms | 762.50 |  13.16 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.312 ms | 0.2094 ms | 0.1061 ms |  1.231 ms |  1.0521 ms |  1.978 ms | 761.91 |  14.92 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.331 ms | 0.1757 ms | 0.0912 ms |  1.256 ms |  1.1225 ms |  1.827 ms | 751.26 |  39.05 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.337 ms | 0.1989 ms | 0.1020 ms |  1.292 ms |  1.0848 ms |  1.902 ms | 747.69 |  14.97 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.341 ms | 0.4184 ms | 0.2095 ms |  1.216 ms |  0.9435 ms |  2.436 ms | 745.64 |  11.83 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.343 ms | 0.1279 ms | 0.0672 ms |  1.309 ms |  1.1074 ms |  1.686 ms | 744.82 |  38.96 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.352 ms | 0.2186 ms | 0.1121 ms |  1.345 ms |  1.0096 ms |  1.966 ms | 739.54 |  13.82 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1.357 ms | 0.3049 ms | 0.1563 ms |  1.282 ms |  1.1261 ms |  2.904 ms | 736.85 |  65.23 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.363 ms | 0.2280 ms | 0.1169 ms |  1.330 ms |  1.0332 ms |  1.811 ms | 733.92 |  13.07 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.363 ms | 0.2274 ms | 0.1195 ms |  1.271 ms |  1.0676 ms |  2.014 ms | 733.70 |  13.41 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.370 ms | 0.4699 ms | 0.2439 ms |  1.186 ms |  1.0025 ms |  3.087 ms | 729.76 |  12.81 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.382 ms | 0.2140 ms | 0.1139 ms |  1.354 ms |  1.0862 ms |  1.800 ms | 723.44 |  13.41 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.386 ms | 0.4745 ms | 0.2560 ms |  1.136 ms |  0.9810 ms |  2.610 ms | 721.44 |  11.42 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1.402 ms | 0.5057 ms | 0.2692 ms |  1.194 ms |  1.0349 ms |  3.363 ms | 713.07 |  13.16 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.406 ms | 0.4220 ms | 0.2218 ms |  1.232 ms |  1.0071 ms |  2.358 ms | 711.38 |  11.83 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1.414 ms | 0.0996 ms | 0.0493 ms |  1.388 ms |  1.2663 ms |  1.646 ms | 707.22 |  68.63 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.419 ms | 0.5065 ms | 0.2629 ms |  1.255 ms |  0.9055 ms |  2.947 ms | 704.76 |  11.42 KB |
| Single                                    | InsightBenchmark      |  1.525 ms | 0.3381 ms | 0.1713 ms |  1.446 ms |  1.0101 ms |  2.205 ms | 655.65 |  12.17 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.534 ms | 0.5214 ms | 0.2641 ms |  1.440 ms |  0.9460 ms |  2.963 ms | 651.80 |  11.06 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1.543 ms | 0.4262 ms | 0.2159 ms |  1.375 ms |  1.1628 ms |  2.581 ms | 648.06 |  65.21 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.562 ms | 0.9006 ms | 0.4674 ms |  1.259 ms |  0.9432 ms |  5.033 ms | 640.13 |  11.41 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.635 ms | 0.4465 ms | 0.2236 ms |  1.568 ms |  1.0049 ms |  2.979 ms | 611.72 |  11.73 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.673 ms | 1.2693 ms | 0.6430 ms |  1.097 ms |  0.9540 ms |  6.365 ms | 597.83 |  12.16 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.777 ms | 0.7346 ms | 0.3766 ms |  1.415 ms |  1.0782 ms |  3.794 ms | 562.75 |  14.16 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.834 ms | 0.8082 ms | 0.4248 ms |  1.315 ms |  1.1563 ms |  3.804 ms | 545.22 |  14.16 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.911 ms | 1.5243 ms | 0.7722 ms |  1.188 ms |  1.0059 ms |  6.240 ms | 523.23 |  13.07 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  2.038 ms | 0.7513 ms | 0.3949 ms |  2.069 ms |  1.1265 ms |  3.931 ms | 490.61 |  13.41 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  2.081 ms | 2.4028 ms | 1.2629 ms |  1.075 ms |  0.9225 ms | 12.752 ms | 480.60 |  11.73 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  2.223 ms | 2.2944 ms | 1.1763 ms |  1.246 ms |  0.9811 ms | 10.815 ms | 449.90 |  14.26 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  2.241 ms | 2.2714 ms | 1.1789 ms |  1.217 ms |  1.0528 ms |  9.594 ms | 446.18 |  15.57 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  2.353 ms | 2.0621 ms | 1.0838 ms |  1.398 ms |  1.0776 ms |  9.520 ms | 424.90 |   14.6 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  2.480 ms | 2.2466 ms | 1.2121 ms |  1.415 ms |  1.2914 ms |  9.592 ms | 403.20 |  67.22 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2.561 ms | 0.2258 ms | 0.1118 ms |  2.514 ms |  2.2337 ms |  3.095 ms | 390.53 |  33.13 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2.568 ms | 0.2503 ms | 0.1268 ms |  2.486 ms |  2.1970 ms |  3.204 ms | 389.43 |  33.13 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3.319 ms | 1.0946 ms | 0.5481 ms |  2.925 ms |  2.5526 ms |  8.171 ms | 301.33 |  31.55 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  3.328 ms | 4.2415 ms | 2.1747 ms |  2.002 ms |  1.0304 ms | 24.521 ms | 300.51 |  11.42 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.930 ms | 1.8824 ms | 0.9894 ms |  3.119 ms |  2.6475 ms |  8.941 ms | 254.48 |  31.55 KB |
|                                           |                       |           |           |           |           |            |           |        |           |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11.330 ms | 0.6836 ms | 0.3463 ms | 11.124 ms | 10.1333 ms | 12.849 ms |  88.26 |  13.07 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.357 ms | 0.6569 ms | 0.3289 ms | 11.271 ms | 10.2820 ms | 13.146 ms |  88.05 |   4.63 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.553 ms | 0.6015 ms | 0.2978 ms | 11.625 ms |  9.0382 ms | 12.634 ms |  86.56 |   8.16 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11.729 ms | 2.2988 ms | 1.1646 ms | 11.185 ms |  9.2427 ms | 22.155 ms |  85.26 |   4.63 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11.844 ms | 0.7396 ms | 0.3747 ms | 11.861 ms | 10.1517 ms | 13.447 ms |  84.43 |   7.16 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.984 ms | 1.9333 ms | 0.9912 ms | 11.408 ms | 10.4441 ms | 18.879 ms |  83.44 |  16.51 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 12.100 ms | 2.0130 ms | 0.9965 ms | 11.403 ms |  9.5450 ms | 19.024 ms |  82.65 |   7.16 KB |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 12.335 ms | 2.3158 ms | 1.1732 ms | 11.356 ms | 10.3809 ms | 18.487 ms |  81.07 |   4.63 KB |
