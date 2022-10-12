# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT


```
|                                    Method |                  Type |     Mean |    StdDev |     Error |    Median |       Min |      Max |  Op/s | Allocated |
|------------------------------------------ |---------------------- |---------:|----------:|----------:|----------:|----------:|---------:|------:|----------:|
|                                  Query&lt;T&gt; |      InsightBenchmark | 1.046 ms | 0.2082 ms | 0.1081 ms | 0.9767 ms | 0.7704 ms | 1.550 ms | 955.9 |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.059 ms | 0.1559 ms | 0.0781 ms | 1.0294 ms | 0.7941 ms | 1.413 ms | 944.1 |     13 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.099 ms | 0.2186 ms | 0.1095 ms | 1.0345 ms | 0.8277 ms | 1.832 ms | 910.3 |     16 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.117 ms | 0.2163 ms | 0.1096 ms | 1.0652 ms | 0.8062 ms | 1.626 ms | 895.0 |     13 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.129 ms | 0.2560 ms | 0.1282 ms | 1.0092 ms | 0.8329 ms | 1.777 ms | 885.9 |     13 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 1.135 ms | 0.1587 ms | 0.0856 ms | 1.0799 ms | 0.9176 ms | 1.533 ms | 880.9 |     17 KB |
|                                    Single |      InsightBenchmark | 1.139 ms | 0.2494 ms | 0.1279 ms | 1.0606 ms | 0.8070 ms | 1.909 ms | 878.3 |     15 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.163 ms | 0.2584 ms | 0.1309 ms | 1.0929 ms | 0.8485 ms | 1.892 ms | 859.7 |     13 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1.211 ms | 0.2073 ms | 0.1050 ms | 1.1854 ms | 0.9081 ms | 1.777 ms | 826.1 |     18 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 1.213 ms | 0.2904 ms | 0.1471 ms | 1.0850 ms | 0.8406 ms | 2.005 ms | 824.5 |     13 KB |
|                                    Single | InsightBenchmarkWrite | 1.214 ms | 0.1576 ms | 0.0818 ms | 1.1899 ms | 0.9085 ms | 1.591 ms | 823.6 |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.234 ms | 0.2727 ms | 0.1381 ms | 1.1141 ms | 0.8589 ms | 1.948 ms | 810.2 |     17 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.289 ms | 0.1828 ms | 0.0915 ms | 1.2918 ms | 0.9796 ms | 1.676 ms | 775.7 |     16 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.306 ms | 0.2618 ms | 0.1311 ms | 1.2565 ms | 0.8993 ms | 1.976 ms | 765.7 |     19 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.322 ms | 0.3549 ms | 0.1777 ms | 1.1597 ms | 0.8797 ms | 2.298 ms | 756.6 |     16 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.333 ms | 0.2759 ms | 0.1382 ms | 1.2989 ms | 0.9411 ms | 2.107 ms | 750.2 |     16 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.344 ms | 0.3077 ms | 0.1559 ms | 1.2418 ms | 0.9336 ms | 2.287 ms | 743.8 |     18 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1.375 ms | 0.2211 ms | 0.1120 ms | 1.3629 ms | 0.9469 ms | 1.904 ms | 727.4 |     14 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 1.387 ms | 0.4206 ms | 0.2106 ms | 1.2874 ms | 0.8698 ms | 2.510 ms | 721.2 |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.390 ms | 0.3161 ms | 0.1601 ms | 1.4108 ms | 0.8845 ms | 2.444 ms | 719.3 |     13 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.403 ms | 0.1685 ms | 0.0844 ms | 1.3877 ms | 1.0406 ms | 1.728 ms | 712.7 |     14 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.410 ms | 0.2097 ms | 0.1038 ms | 1.3830 ms | 1.0921 ms | 2.062 ms | 709.1 |     17 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.410 ms | 0.3023 ms | 0.1496 ms | 1.3466 ms | 0.9846 ms | 2.201 ms | 709.0 |     16 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.426 ms | 0.3473 ms | 0.1760 ms | 1.3229 ms | 0.9514 ms | 2.398 ms | 701.3 |     13 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.475 ms | 0.2441 ms | 0.1222 ms | 1.4622 ms | 1.1183 ms | 2.303 ms | 677.9 |     14 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.528 ms | 0.2160 ms | 0.1094 ms | 1.5112 ms | 1.0636 ms | 1.946 ms | 654.3 |     15 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.531 ms | 0.3864 ms | 0.1958 ms | 1.4583 ms | 1.0033 ms | 2.555 ms | 653.1 |     19 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1.538 ms | 0.2587 ms | 0.1295 ms | 1.5422 ms | 1.0917 ms | 2.260 ms | 650.3 |     13 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1.546 ms | 0.2100 ms | 0.1051 ms | 1.5256 ms | 1.1553 ms | 2.027 ms | 647.0 |     15 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.553 ms | 0.3170 ms | 0.1645 ms | 1.5962 ms | 0.9564 ms | 2.255 ms | 643.9 |     13 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml | 1.556 ms | 0.2120 ms | 0.1074 ms | 1.5187 ms | 1.2321 ms | 2.108 ms | 642.5 |     68 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.557 ms | 0.2661 ms | 0.1317 ms | 1.5038 ms | 1.1906 ms | 2.207 ms | 642.4 |     16 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1.571 ms | 0.3068 ms | 0.1536 ms | 1.5141 ms | 1.1440 ms | 2.409 ms | 636.6 |     18 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.579 ms | 0.2103 ms | 0.1053 ms | 1.5454 ms | 1.1592 ms | 2.022 ms | 633.4 |     15 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1.611 ms | 0.4030 ms | 0.2018 ms | 1.4918 ms | 1.1008 ms | 2.869 ms | 620.9 |     18 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.635 ms | 0.2736 ms | 0.1386 ms | 1.6286 ms | 1.1731 ms | 2.288 ms | 611.5 |     14 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.636 ms | 0.4406 ms | 0.2206 ms | 1.4789 ms | 1.1633 ms | 3.160 ms | 611.2 |     13 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.646 ms | 0.3746 ms | 0.1876 ms | 1.6084 ms | 1.0630 ms | 2.675 ms | 607.5 |     13 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1.649 ms | 0.2326 ms | 0.1192 ms | 1.5751 ms | 1.2633 ms | 2.151 ms | 606.5 |     47 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.656 ms | 0.3784 ms | 0.1895 ms | 1.6069 ms | 1.0909 ms | 2.574 ms | 603.8 |     47 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.671 ms | 0.4162 ms | 0.2084 ms | 1.5455 ms | 1.2138 ms | 3.272 ms | 598.5 |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.680 ms | 0.2534 ms | 0.1284 ms | 1.6673 ms | 1.2229 ms | 2.361 ms | 595.1 |     14 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.704 ms | 0.3408 ms | 0.1687 ms | 1.6475 ms | 1.2159 ms | 2.436 ms | 586.8 |     16 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 1.729 ms | 0.3559 ms | 0.1825 ms | 1.7043 ms | 1.1589 ms | 2.649 ms | 578.2 |     68 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.735 ms | 0.2333 ms | 0.1182 ms | 1.7118 ms | 1.3254 ms | 2.280 ms | 576.2 |     16 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.758 ms | 0.4195 ms | 0.2100 ms | 1.5937 ms | 1.2744 ms | 3.118 ms | 568.9 |     19 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.798 ms | 0.6400 ms | 0.3322 ms | 1.5741 ms | 1.1384 ms | 4.194 ms | 556.2 |     13 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1.806 ms | 0.2655 ms | 0.1314 ms | 1.8249 ms | 1.2887 ms | 2.510 ms | 553.6 |     14 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml | 1.808 ms | 0.2242 ms | 0.1149 ms | 1.7712 ms | 1.4020 ms | 2.440 ms | 553.0 |     72 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.818 ms | 0.3882 ms | 0.1967 ms | 1.7952 ms | 1.1772 ms | 2.982 ms | 550.0 |     13 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.868 ms | 0.3212 ms | 0.1590 ms | 1.8524 ms | 1.2660 ms | 2.734 ms | 535.4 |     49 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml | 1.871 ms | 0.3141 ms | 0.1555 ms | 1.8425 ms | 1.3401 ms | 2.719 ms | 534.5 |     71 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1.894 ms | 0.5303 ms | 0.2625 ms | 1.7680 ms | 1.1045 ms | 3.331 ms | 528.0 |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.897 ms | 0.3370 ms | 0.1749 ms | 1.8150 ms | 1.3167 ms | 2.955 ms | 527.2 |     13 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.911 ms | 0.4535 ms | 0.2325 ms | 1.7831 ms | 1.2273 ms | 2.678 ms | 523.3 |     16 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.918 ms | 0.3999 ms | 0.2051 ms | 1.9457 ms | 1.1432 ms | 2.621 ms | 521.4 |     15 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.918 ms | 0.4500 ms | 0.2307 ms | 1.8796 ms | 1.2425 ms | 2.853 ms | 521.3 |     16 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.988 ms | 1.1978 ms | 0.6068 ms | 1.5976 ms | 0.8934 ms | 6.694 ms | 503.1 |     16 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 2.061 ms | 0.3403 ms | 0.1704 ms | 1.9889 ms | 1.4888 ms | 2.731 ms | 485.3 |     50 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 2.144 ms | 0.2314 ms | 0.1146 ms | 2.1849 ms | 1.4939 ms | 2.604 ms | 466.4 |     16 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 2.148 ms | 0.4713 ms | 0.2388 ms | 2.1103 ms | 1.0996 ms | 2.966 ms | 465.6 |     16 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 2.162 ms | 0.7124 ms | 0.3652 ms | 2.0449 ms | 1.1543 ms | 3.828 ms | 462.6 |     17 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 2.166 ms | 0.4577 ms | 0.2292 ms | 2.1493 ms | 1.3550 ms | 3.281 ms | 461.8 |     18 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.196 ms | 0.2915 ms | 0.1513 ms | 2.1211 ms | 1.6364 ms | 2.894 ms | 455.3 |     16 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.238 ms | 0.8150 ms | 0.4081 ms | 1.9590 ms | 1.2774 ms | 5.441 ms | 446.7 |     19 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 2.239 ms | 0.4265 ms | 0.2136 ms | 2.0979 ms | 1.6041 ms | 3.286 ms | 446.7 |     17 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 2.340 ms | 0.3811 ms | 0.1908 ms | 2.3767 ms | 1.5308 ms | 3.100 ms | 427.3 |     13 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.617 ms | 0.6215 ms | 0.3226 ms | 2.8530 ms | 1.6706 ms | 3.558 ms | 382.2 |     18 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 2.663 ms | 0.3041 ms | 0.1522 ms | 2.5769 ms | 2.1124 ms | 3.624 ms | 375.5 |     16 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.844 ms | 0.8480 ms | 0.4348 ms | 2.9625 ms | 1.2717 ms | 5.188 ms | 351.6 |     17 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 2.862 ms | 1.1921 ms | 0.6112 ms | 2.3750 ms | 1.6364 ms | 7.274 ms | 349.4 |     13 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.962 ms | 0.7785 ms | 0.3898 ms | 2.9416 ms | 1.5557 ms | 5.310 ms | 337.6 |     16 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3.675 ms | 0.5925 ms | 0.3038 ms | 3.6526 ms | 2.6382 ms | 4.920 ms | 272.1 |     37 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 3.912 ms | 0.8199 ms | 0.4154 ms | 3.6831 ms | 2.8961 ms | 6.082 ms | 255.6 |     37 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4.227 ms | 0.8345 ms | 0.4279 ms | 4.0522 ms | 3.0351 ms | 6.294 ms | 236.6 |     36 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 4.478 ms | 0.7312 ms | 0.3843 ms | 4.2494 ms | 3.5624 ms | 6.294 ms | 223.3 |     36 KB |
|                                           |                       |          |           |           |           |           |          |       |           |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 3.462 ms | 0.6046 ms | 0.2993 ms | 3.5895 ms | 2.4746 ms | 4.768 ms | 288.9 |      8 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 3.557 ms | 0.6296 ms | 0.3117 ms | 3.6090 ms | 2.4008 ms | 4.667 ms | 281.1 |     18 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 3.596 ms | 0.6207 ms | 0.3072 ms | 3.5749 ms | 2.6400 ms | 4.844 ms | 278.1 |     12 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3.609 ms | 0.8065 ms | 0.3993 ms | 3.5595 ms | 2.2364 ms | 5.210 ms | 277.1 |     12 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3.643 ms | 0.6902 ms | 0.3417 ms | 3.6233 ms | 2.5226 ms | 5.198 ms | 274.5 |      8 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.786 ms | 0.7830 ms | 0.3876 ms | 3.7976 ms | 2.5216 ms | 5.736 ms | 264.1 |     11 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.867 ms | 0.6890 ms | 0.3411 ms | 3.8446 ms | 2.6504 ms | 5.222 ms | 258.6 |     21 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 4.057 ms | 0.8790 ms | 0.4402 ms | 3.9625 ms | 2.7085 ms | 6.180 ms | 246.5 |      8 KB |
