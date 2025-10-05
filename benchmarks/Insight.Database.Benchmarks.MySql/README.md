# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26100.6725/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean      | StdDev    | Error     | Median    | Min        | Max       | Op/s   | Allocated |
|------------------------------------------ |---------------------- |----------:|----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1.106 ms | 0.1159 ms | 0.0617 ms |  1.085 ms |  0.9571 ms |  1.414 ms | 904.37 |  20.59 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1.124 ms | 0.0896 ms | 0.0465 ms |  1.106 ms |  0.9828 ms |  1.430 ms | 889.47 |  23.31 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1.136 ms | 0.1481 ms | 0.0742 ms |  1.121 ms |  0.8984 ms |  1.512 ms | 880.15 |  20.94 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1.138 ms | 0.1270 ms | 0.0668 ms |  1.117 ms |  0.9019 ms |  1.539 ms | 879.04 |  20.59 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1.152 ms | 0.1351 ms | 0.0701 ms |  1.130 ms |  0.9493 ms |  1.555 ms | 868.10 |  20.91 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1.162 ms | 0.1432 ms | 0.0763 ms |  1.133 ms |  0.9464 ms |  1.577 ms | 860.76 |  20.62 KB |
| Single                                    | InsightBenchmark      |  1.172 ms | 0.1529 ms | 0.0793 ms |  1.150 ms |  0.9396 ms |  1.678 ms | 853.14 |   52.8 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1.176 ms | 0.1407 ms | 0.0730 ms |  1.130 ms |  1.0204 ms |  1.614 ms | 850.68 |  23.31 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1.181 ms | 0.1949 ms | 0.0999 ms |  1.156 ms |  0.9051 ms |  1.937 ms | 847.02 |  52.78 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1.186 ms | 0.1136 ms | 0.0605 ms |  1.143 ms |  1.0299 ms |  1.450 ms | 843.09 |  23.33 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1.195 ms | 0.1472 ms | 0.0774 ms |  1.164 ms |  0.9833 ms |  1.577 ms | 836.55 |  20.94 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1.199 ms | 0.2463 ms | 0.1248 ms |  1.114 ms |  0.9450 ms |  1.890 ms | 834.33 |  20.91 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1.204 ms | 0.1413 ms | 0.0734 ms |  1.176 ms |  1.0051 ms |  1.603 ms | 830.52 |  23.34 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1.205 ms | 0.2474 ms | 0.1239 ms |  1.107 ms |  0.9716 ms |  2.145 ms | 829.88 |  20.94 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1.207 ms | 0.1684 ms | 0.0874 ms |  1.165 ms |  1.0034 ms |  1.770 ms | 828.74 |  19.74 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1.211 ms | 0.1691 ms | 0.0867 ms |  1.142 ms |  0.9482 ms |  1.656 ms | 825.91 |  55.49 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1.222 ms | 0.1852 ms | 0.0973 ms |  1.219 ms |  0.9518 ms |  1.568 ms | 818.05 |  52.77 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1.224 ms | 0.1086 ms | 0.0571 ms |  1.199 ms |  1.0648 ms |  1.507 ms | 817.09 |  23.16 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1.239 ms | 0.1696 ms | 0.0880 ms |  1.208 ms |  0.9856 ms |  1.700 ms | 806.80 |  55.33 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1.240 ms | 0.1994 ms | 0.0999 ms |  1.175 ms |  0.9768 ms |  1.769 ms | 806.36 |  23.34 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1.242 ms | 0.2155 ms | 0.1105 ms |  1.204 ms |  0.9644 ms |  1.815 ms | 805.31 |  20.62 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1.264 ms | 0.1555 ms | 0.0828 ms |  1.241 ms |  1.0536 ms |  1.702 ms | 790.99 |  55.49 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1.268 ms | 0.1636 ms | 0.0849 ms |  1.235 ms |  1.0124 ms |  1.646 ms | 788.95 |  23.16 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1.276 ms | 0.3077 ms | 0.1597 ms |  1.133 ms |  0.9376 ms |  1.881 ms | 783.56 |  20.61 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1.278 ms | 0.1709 ms | 0.0910 ms |  1.227 ms |  1.0215 ms |  1.657 ms | 782.62 |  23.16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1.287 ms | 0.1097 ms | 0.0577 ms |  1.268 ms |  1.0702 ms |  1.548 ms | 776.89 |  25.59 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1.289 ms | 0.2401 ms | 0.1246 ms |  1.241 ms |  0.9526 ms |  1.735 ms | 775.91 |  20.61 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1.289 ms | 0.2640 ms | 0.1322 ms |  1.200 ms |  0.9555 ms |  2.144 ms | 775.75 |  51.86 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1.295 ms | 0.1918 ms | 0.0996 ms |  1.238 ms |  1.0474 ms |  1.806 ms | 771.94 |  55.52 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1.305 ms | 0.3033 ms | 0.1574 ms |  1.177 ms |  0.9716 ms |  2.003 ms | 766.53 |  20.91 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1.305 ms | 0.1693 ms | 0.0868 ms |  1.246 ms |  1.0920 ms |  1.685 ms | 766.02 |  25.59 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1.316 ms | 0.2958 ms | 0.1516 ms |  1.216 ms |  0.9220 ms |  2.105 ms | 759.63 |  52.78 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1.319 ms | 0.1181 ms | 0.0621 ms |  1.329 ms |  1.0953 ms |  1.623 ms | 758.28 |  58.06 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1.334 ms | 0.1490 ms | 0.0764 ms |  1.291 ms |  1.1571 ms |  1.865 ms | 749.56 |   25.9 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1.342 ms | 0.2118 ms | 0.1086 ms |  1.292 ms |  1.1196 ms |  2.219 ms | 745.21 |  25.88 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1.347 ms | 0.1731 ms | 0.0899 ms |  1.318 ms |  1.0668 ms |  1.911 ms | 742.47 |  55.33 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1.348 ms | 0.2297 ms | 0.1192 ms |  1.288 ms |  1.1046 ms |  2.166 ms | 741.87 |  23.31 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1.375 ms | 0.3601 ms | 0.1869 ms |  1.238 ms |  0.9553 ms |  2.145 ms | 727.29 |  23.33 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.380 ms | 0.2373 ms | 0.1217 ms |  1.323 ms |  1.0447 ms |  2.082 ms | 724.79 |  22.16 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1.385 ms | 0.1567 ms | 0.0794 ms |  1.401 ms |  1.1134 ms |  1.668 ms | 722.06 |   25.9 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.394 ms | 0.2591 ms | 0.1298 ms |  1.328 ms |  1.0612 ms |  1.996 ms | 717.37 |  22.16 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1.395 ms | 0.3527 ms | 0.1787 ms |  1.239 ms |  0.9910 ms |  2.144 ms | 716.83 |  22.87 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1.404 ms | 0.1593 ms | 0.0827 ms |  1.357 ms |  1.1921 ms |  1.975 ms | 712.33 |  25.59 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1.424 ms | 0.2730 ms | 0.1400 ms |  1.349 ms |  0.9957 ms |  2.181 ms | 702.03 |  20.91 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1.459 ms | 0.3871 ms | 0.1938 ms |  1.335 ms |  1.0953 ms |  3.218 ms | 685.38 |  57.75 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1.460 ms | 0.3186 ms | 0.1634 ms |  1.407 ms |  1.0413 ms |  2.357 ms | 685.08 |  55.06 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1.478 ms | 0.3020 ms | 0.1549 ms |  1.546 ms |  1.0065 ms |  1.995 ms | 676.46 |  22.89 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1.483 ms | 0.3442 ms | 0.1723 ms |  1.576 ms |  1.0155 ms |  2.114 ms | 674.37 |  19.69 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1.491 ms | 0.2600 ms | 0.1302 ms |  1.601 ms |  1.0064 ms |  1.894 ms | 670.86 |  21.92 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1.505 ms | 0.2639 ms | 0.1322 ms |  1.409 ms |  1.1732 ms |  2.250 ms | 664.63 |  25.59 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1.527 ms | 0.2765 ms | 0.1384 ms |  1.504 ms |  1.0672 ms |  2.082 ms | 654.88 |  49.31 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1.528 ms | 0.2318 ms | 0.1188 ms |  1.577 ms |  1.1171 ms |  2.005 ms | 654.47 |  47.04 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1.543 ms | 0.3491 ms | 0.1790 ms |  1.470 ms |  1.0656 ms |  2.276 ms | 648.09 |  23.18 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1.551 ms | 0.2643 ms | 0.1355 ms |  1.621 ms |  1.0118 ms |  2.075 ms | 644.54 |  23.35 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1.554 ms | 0.6472 ms | 0.3359 ms |  1.284 ms |  1.0404 ms |  3.730 ms | 643.67 |  19.74 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1.557 ms | 0.4004 ms | 0.2028 ms |  1.643 ms |  0.9812 ms |  2.627 ms | 642.32 |  22.87 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1.579 ms | 0.9801 ms | 0.5287 ms |  1.131 ms |  0.9669 ms |  4.527 ms | 633.35 |  20.94 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1.589 ms | 0.9866 ms | 0.5323 ms |  1.108 ms |  0.9332 ms |  5.169 ms | 629.40 |  20.59 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1.605 ms | 0.4996 ms | 0.2562 ms |  1.425 ms |  1.1699 ms |  3.147 ms | 623.25 |  58.04 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1.627 ms | 0.4543 ms | 0.2301 ms |  1.522 ms |  1.1075 ms |  2.783 ms | 614.74 |  54.38 KB |
| Single                                    | InsightBenchmarkWrite |  1.637 ms | 0.5106 ms | 0.2557 ms |  1.672 ms |  1.0149 ms |  2.509 ms | 611.01 |  20.63 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1.640 ms | 0.4317 ms | 0.2269 ms |  1.608 ms |  1.0675 ms |  3.713 ms | 609.61 |  55.33 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1.643 ms | 0.2209 ms | 0.1094 ms |  1.687 ms |  1.2336 ms |  1.955 ms | 608.75 |   49.6 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1.699 ms | 0.9582 ms | 0.4798 ms |  1.328 ms |  1.0367 ms |  4.915 ms | 588.75 |  23.18 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1.825 ms | 0.4303 ms | 0.2206 ms |  1.941 ms |  1.0226 ms |  2.431 ms | 547.95 |  47.05 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1.971 ms | 0.2994 ms | 0.1535 ms |  1.975 ms |  1.4236 ms |  2.886 ms | 507.24 |   25.9 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  2.131 ms | 1.9182 ms | 0.9718 ms |  1.569 ms |  1.0127 ms | 10.742 ms | 469.22 |  23.31 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  2.156 ms | 2.1878 ms | 1.1803 ms |  1.204 ms |  1.0564 ms |  9.993 ms | 463.92 |  25.88 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  3.066 ms | 0.2342 ms | 0.1215 ms |  3.032 ms |  2.7325 ms |  3.657 ms | 326.13 |  46.16 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3.175 ms | 0.2386 ms | 0.1209 ms |  3.099 ms |  2.7707 ms |  3.882 ms | 314.99 |  45.62 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  3.925 ms | 0.5278 ms | 0.2613 ms |  3.885 ms |  2.9803 ms |  5.204 ms | 254.80 |  45.62 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  4.108 ms | 2.5113 ms | 1.3199 ms |  3.076 ms |  2.5742 ms | 12.465 ms | 243.45 |  46.16 KB |
|                                           |                       |           |           |           |           |            |           |        |           |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 10.637 ms | 0.5755 ms | 0.2916 ms | 10.698 ms |  8.7244 ms | 11.664 ms |  94.01 |  22.13 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10.947 ms | 0.6840 ms | 0.3386 ms | 10.793 ms |  9.8065 ms | 12.350 ms |  91.35 |  34.37 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10.999 ms | 0.5250 ms | 0.2660 ms | 10.867 ms |  9.9452 ms | 12.021 ms |  90.92 |  22.52 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11.340 ms | 0.4702 ms | 0.2440 ms | 11.319 ms | 10.2912 ms | 12.338 ms |  88.18 |  35.02 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11.793 ms | 1.7965 ms | 0.9442 ms | 11.132 ms | 10.1779 ms | 18.185 ms |  84.80 |  24.78 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 12.549 ms | 3.6147 ms | 1.8312 ms | 11.628 ms |  9.8302 ms | 30.474 ms |  79.69 |  23.87 KB |
