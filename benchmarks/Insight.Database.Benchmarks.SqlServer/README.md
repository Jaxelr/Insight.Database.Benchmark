# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Sql Server

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]   : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  ShortRun : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT


```
|                                    Method |                  Type |     Mean |    StdDev |     Error |   Median |       Min |      Max |  Op/s | Allocated |
|------------------------------------------ |---------------------- |---------:|----------:|----------:|---------:|----------:|---------:|------:|----------:|
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.225 ms | 0.1575 ms | 0.0817 ms | 1.246 ms | 0.9395 ms | 1.581 ms | 816.1 |     13 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.232 ms | 0.1177 ms | 0.0603 ms | 1.242 ms | 1.0024 ms | 1.513 ms | 811.7 |     13 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 1.250 ms | 0.1686 ms | 0.0854 ms | 1.225 ms | 1.0125 ms | 1.702 ms | 799.8 |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.261 ms | 0.2181 ms | 0.1118 ms | 1.216 ms | 0.9388 ms | 1.833 ms | 792.8 |     13 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.269 ms | 0.1819 ms | 0.0911 ms | 1.229 ms | 0.9296 ms | 1.691 ms | 788.0 |     13 KB |
|                                    Single | InsightBenchmarkWrite | 1.281 ms | 0.1705 ms | 0.0854 ms | 1.252 ms | 0.9990 ms | 1.621 ms | 780.5 |     15 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1.291 ms | 0.1815 ms | 0.0931 ms | 1.241 ms | 1.0200 ms | 1.719 ms | 774.8 |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.293 ms | 0.2272 ms | 0.1138 ms | 1.233 ms | 0.9689 ms | 2.031 ms | 773.4 |     14 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1.296 ms | 0.1870 ms | 0.0926 ms | 1.239 ms | 0.9941 ms | 1.838 ms | 771.9 |     13 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.304 ms | 0.2042 ms | 0.1022 ms | 1.252 ms | 1.0030 ms | 1.852 ms | 766.9 |     13 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1.321 ms | 0.1852 ms | 0.0938 ms | 1.276 ms | 1.0566 ms | 1.708 ms | 757.0 |     14 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.324 ms | 0.1872 ms | 0.0937 ms | 1.330 ms | 0.9286 ms | 1.769 ms | 755.3 |     14 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.327 ms | 0.1931 ms | 0.0990 ms | 1.284 ms | 1.0041 ms | 1.894 ms | 753.6 |     16 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.339 ms | 0.2591 ms | 0.1313 ms | 1.269 ms | 1.0682 ms | 2.088 ms | 746.6 |     15 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.364 ms | 0.2403 ms | 0.1232 ms | 1.308 ms | 1.0332 ms | 1.970 ms | 733.0 |     15 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.375 ms | 0.2132 ms | 0.1068 ms | 1.361 ms | 1.0145 ms | 1.880 ms | 727.0 |     16 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.377 ms | 0.3342 ms | 0.1735 ms | 1.268 ms | 0.8971 ms | 2.255 ms | 726.0 |     13 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.379 ms | 0.2376 ms | 0.1190 ms | 1.378 ms | 1.0227 ms | 1.939 ms | 724.9 |     13 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.390 ms | 0.1721 ms | 0.0852 ms | 1.398 ms | 1.1085 ms | 1.884 ms | 719.5 |     14 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.400 ms | 0.1941 ms | 0.0972 ms | 1.387 ms | 1.0910 ms | 1.810 ms | 714.5 |     47 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.405 ms | 0.1834 ms | 0.0929 ms | 1.378 ms | 1.0879 ms | 1.757 ms | 711.5 |     13 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1.407 ms | 0.3080 ms | 0.1525 ms | 1.327 ms | 1.0291 ms | 2.073 ms | 710.9 |     15 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1.411 ms | 0.2269 ms | 0.1136 ms | 1.347 ms | 1.0540 ms | 1.975 ms | 708.9 |     47 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1.416 ms | 0.2632 ms | 0.1318 ms | 1.392 ms | 1.0025 ms | 2.058 ms | 706.0 |     18 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.418 ms | 0.1779 ms | 0.0912 ms | 1.400 ms | 1.1434 ms | 1.967 ms | 705.2 |     16 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.431 ms | 0.2392 ms | 0.1212 ms | 1.371 ms | 1.0943 ms | 2.075 ms | 699.0 |     13 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.441 ms | 0.2358 ms | 0.1181 ms | 1.392 ms | 1.0904 ms | 2.153 ms | 694.2 |     13 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.442 ms | 0.2083 ms | 0.1068 ms | 1.395 ms | 1.1580 ms | 2.066 ms | 693.6 |     16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.451 ms | 0.2272 ms | 0.1138 ms | 1.471 ms | 1.0294 ms | 2.026 ms | 689.0 |     16 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.453 ms | 0.1692 ms | 0.0878 ms | 1.437 ms | 1.0843 ms | 1.767 ms | 688.3 |     14 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.464 ms | 0.2055 ms | 0.1029 ms | 1.451 ms | 1.1300 ms | 1.986 ms | 683.0 |     17 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.471 ms | 0.2986 ms | 0.1478 ms | 1.399 ms | 1.0763 ms | 2.244 ms | 679.8 |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.478 ms | 0.2233 ms | 0.1131 ms | 1.392 ms | 1.1897 ms | 2.049 ms | 676.5 |     18 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.487 ms | 0.1947 ms | 0.1010 ms | 1.457 ms | 1.1861 ms | 1.882 ms | 672.4 |     16 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.513 ms | 0.2183 ms | 0.1106 ms | 1.494 ms | 1.1865 ms | 2.203 ms | 661.0 |     19 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1.513 ms | 0.2635 ms | 0.1320 ms | 1.520 ms | 1.0940 ms | 2.038 ms | 660.9 |     17 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.525 ms | 0.2232 ms | 0.1144 ms | 1.486 ms | 1.1568 ms | 2.064 ms | 655.9 |     15 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.531 ms | 0.2700 ms | 0.1384 ms | 1.495 ms | 1.1840 ms | 2.316 ms | 653.1 |     16 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.539 ms | 0.2321 ms | 0.1176 ms | 1.524 ms | 1.1406 ms | 2.002 ms | 649.7 |     19 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.544 ms | 0.2584 ms | 0.1279 ms | 1.525 ms | 1.1291 ms | 2.202 ms | 647.8 |     16 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.575 ms | 0.2797 ms | 0.1400 ms | 1.580 ms | 1.1462 ms | 2.138 ms | 634.9 |     17 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.577 ms | 0.2302 ms | 0.1195 ms | 1.593 ms | 1.1773 ms | 2.131 ms | 634.0 |     15 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.586 ms | 0.2958 ms | 0.1517 ms | 1.571 ms | 1.0979 ms | 2.349 ms | 630.4 |     16 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 1.624 ms | 0.2254 ms | 0.1129 ms | 1.596 ms | 1.2604 ms | 2.126 ms | 615.9 |     15 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.651 ms | 0.2710 ms | 0.1373 ms | 1.607 ms | 1.2750 ms | 2.406 ms | 605.6 |     49 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 1.667 ms | 0.2677 ms | 0.1407 ms | 1.677 ms | 1.2249 ms | 2.310 ms | 599.9 |     17 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.695 ms | 0.2646 ms | 0.1310 ms | 1.676 ms | 1.2487 ms | 2.276 ms | 590.1 |     50 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.710 ms | 0.2308 ms | 0.1183 ms | 1.716 ms | 1.2873 ms | 2.136 ms | 584.9 |     16 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.779 ms | 0.2888 ms | 0.1430 ms | 1.732 ms | 1.3063 ms | 2.400 ms | 562.0 |     13 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.791 ms | 0.2949 ms | 0.1494 ms | 1.726 ms | 1.2973 ms | 2.612 ms | 558.5 |     16 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.844 ms | 0.3780 ms | 0.1915 ms | 1.730 ms | 1.3402 ms | 2.920 ms | 542.3 |     13 KB |
|                                    Single |      InsightBenchmark | 1.850 ms | 0.2682 ms | 0.1328 ms | 1.881 ms | 1.3554 ms | 2.496 ms | 540.4 |     15 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.860 ms | 0.2246 ms | 0.1112 ms | 1.850 ms | 1.3250 ms | 2.432 ms | 537.6 |     16 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.866 ms | 0.4725 ms | 0.2394 ms | 1.778 ms | 1.2604 ms | 3.646 ms | 536.0 |     13 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.869 ms | 0.2100 ms | 0.1052 ms | 1.866 ms | 1.4867 ms | 2.384 ms | 535.1 |     19 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.882 ms | 0.2925 ms | 0.1465 ms | 1.867 ms | 1.2541 ms | 2.678 ms | 531.2 |     18 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 1.889 ms | 0.3611 ms | 0.1808 ms | 1.854 ms | 1.2400 ms | 2.858 ms | 529.3 |     18 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.897 ms | 0.2566 ms | 0.1316 ms | 1.957 ms | 1.4564 ms | 2.435 ms | 527.1 |     16 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1.922 ms | 0.3394 ms | 0.1699 ms | 1.880 ms | 1.4213 ms | 2.648 ms | 520.3 |     18 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1.930 ms | 0.6709 ms | 0.3359 ms | 1.677 ms | 1.2400 ms | 3.599 ms | 518.2 |     18 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.937 ms | 0.2565 ms | 0.1270 ms | 1.927 ms | 1.3911 ms | 2.746 ms | 516.2 |     16 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 1.960 ms | 0.1521 ms | 0.0771 ms | 1.971 ms | 1.6866 ms | 2.288 ms | 510.1 |     68 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.967 ms | 0.3818 ms | 0.1912 ms | 1.895 ms | 1.3666 ms | 2.887 ms | 508.5 |     17 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1.989 ms | 0.2591 ms | 0.1297 ms | 1.913 ms | 1.4011 ms | 2.576 ms | 502.7 |     14 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 2.037 ms | 0.5421 ms | 0.2683 ms | 1.924 ms | 1.1824 ms | 3.745 ms | 490.8 |     13 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml | 2.105 ms | 0.2904 ms | 0.1454 ms | 2.036 ms | 1.6753 ms | 3.038 ms | 475.0 |     68 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.159 ms | 0.3105 ms | 0.1573 ms | 2.169 ms | 1.6284 ms | 3.224 ms | 463.1 |     16 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml | 2.211 ms | 0.2850 ms | 0.1444 ms | 2.181 ms | 1.6505 ms | 3.145 ms | 452.3 |     71 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml | 2.248 ms | 0.3040 ms | 0.1619 ms | 2.177 ms | 1.7442 ms | 2.876 ms | 444.9 |     72 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 2.350 ms | 0.4099 ms | 0.2052 ms | 2.248 ms | 1.6690 ms | 3.258 ms | 425.6 |     13 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.463 ms | 0.5658 ms | 0.2901 ms | 2.275 ms | 1.7903 ms | 4.108 ms | 406.0 |     19 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 2.583 ms | 0.5342 ms | 0.2706 ms | 2.562 ms | 1.6725 ms | 3.876 ms | 387.1 |     17 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 3.022 ms | 0.3958 ms | 0.1982 ms | 2.933 ms | 2.2935 ms | 3.932 ms | 330.9 |     37 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3.093 ms | 0.3406 ms | 0.1686 ms | 3.083 ms | 2.5111 ms | 3.827 ms | 323.3 |     37 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 3.203 ms | 0.3019 ms | 0.1548 ms | 3.171 ms | 2.6750 ms | 4.005 ms | 312.2 |     36 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3.342 ms | 0.2353 ms | 0.1165 ms | 3.331 ms | 2.9172 ms | 4.045 ms | 299.2 |     36 KB |
|                                           |                       |          |           |           |          |           |          |       |           |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4.182 ms | 0.8481 ms | 0.4198 ms | 4.521 ms | 2.9552 ms | 5.639 ms | 239.1 |      8 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4.318 ms | 0.8391 ms | 0.4154 ms | 4.718 ms | 3.0755 ms | 5.603 ms | 231.6 |     12 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 5.362 ms | 1.2168 ms | 0.6024 ms | 5.288 ms | 3.1923 ms | 7.709 ms | 186.5 |     12 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 5.480 ms | 0.9658 ms | 0.4781 ms | 5.790 ms | 3.7149 ms | 6.951 ms | 182.5 |     18 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 5.550 ms | 0.8604 ms | 0.4308 ms | 5.795 ms | 3.7967 ms | 6.657 ms | 180.2 |      8 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 6.120 ms | 0.9229 ms | 0.4732 ms | 6.268 ms | 4.0334 ms | 7.237 ms | 163.4 |     12 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 6.327 ms | 1.0652 ms | 0.5334 ms | 6.508 ms | 3.4805 ms | 8.191 ms | 158.1 |      8 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 6.437 ms | 1.0476 ms | 0.5245 ms | 6.497 ms | 4.1104 ms | 8.954 ms | 155.4 |     21 KB |
