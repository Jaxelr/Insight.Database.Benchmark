# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Sql Server

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT


```
|                                    Method |                  Type |     Mean |    StdDev |     Error |   Median |       Min |      Max |  Op/s | Allocated |
|------------------------------------------ |---------------------- |---------:|----------:|----------:|---------:|----------:|---------:|------:|----------:|
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 1.238 ms | 0.3124 ms | 0.1546 ms | 1.146 ms | 0.7900 ms | 1.995 ms | 807.9 |     15 KB |
|                                    Single |      InsightBenchmark | 1.262 ms | 0.3063 ms | 0.1570 ms | 1.254 ms | 0.7785 ms | 1.950 ms | 792.6 |     15 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.288 ms | 0.3066 ms | 0.1535 ms | 1.217 ms | 0.8798 ms | 2.089 ms | 776.5 |     13 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.344 ms | 0.4418 ms | 0.2238 ms | 1.202 ms | 0.7988 ms | 2.367 ms | 744.3 |     13 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 1.346 ms | 0.4508 ms | 0.2340 ms | 1.105 ms | 0.8098 ms | 2.278 ms | 743.1 |     13 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.376 ms | 0.3895 ms | 0.2022 ms | 1.272 ms | 0.7950 ms | 2.198 ms | 726.5 |     16 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.437 ms | 0.4036 ms | 0.2021 ms | 1.274 ms | 0.9294 ms | 2.391 ms | 695.7 |     16 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.505 ms | 0.3805 ms | 0.1951 ms | 1.404 ms | 0.9540 ms | 2.560 ms | 664.4 |     13 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1.566 ms | 0.3047 ms | 0.1508 ms | 1.532 ms | 1.1692 ms | 2.554 ms | 638.7 |     15 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.576 ms | 0.3466 ms | 0.1716 ms | 1.491 ms | 1.1045 ms | 2.367 ms | 634.7 |     13 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.587 ms | 0.3040 ms | 0.1505 ms | 1.518 ms | 1.0723 ms | 2.292 ms | 629.9 |     15 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.597 ms | 0.6408 ms | 0.3209 ms | 1.462 ms | 0.8901 ms | 4.651 ms | 626.3 |     16 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.606 ms | 0.3678 ms | 0.1841 ms | 1.655 ms | 1.0538 ms | 2.583 ms | 622.5 |     13 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.607 ms | 0.3111 ms | 0.1540 ms | 1.512 ms | 1.1145 ms | 2.377 ms | 622.3 |     13 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.610 ms | 0.2362 ms | 0.1226 ms | 1.568 ms | 1.2043 ms | 2.223 ms | 621.2 |     14 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.614 ms | 0.2937 ms | 0.1454 ms | 1.575 ms | 1.1621 ms | 2.218 ms | 619.6 |     13 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.631 ms | 0.3680 ms | 0.1843 ms | 1.552 ms | 1.0955 ms | 2.464 ms | 613.2 |     15 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.678 ms | 0.4266 ms | 0.2112 ms | 1.650 ms | 1.0593 ms | 2.943 ms | 595.9 |     19 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.679 ms | 0.3539 ms | 0.1772 ms | 1.616 ms | 1.0744 ms | 2.535 ms | 595.5 |     16 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.689 ms | 0.5090 ms | 0.2610 ms | 1.768 ms | 0.8156 ms | 3.054 ms | 592.2 |     17 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.691 ms | 0.3998 ms | 0.1979 ms | 1.574 ms | 1.0311 ms | 2.422 ms | 591.5 |     15 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1.691 ms | 0.2828 ms | 0.1433 ms | 1.642 ms | 1.2185 ms | 2.484 ms | 591.4 |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.696 ms | 0.3169 ms | 0.1569 ms | 1.654 ms | 1.1791 ms | 2.406 ms | 589.7 |     14 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1.704 ms | 0.3588 ms | 0.1776 ms | 1.679 ms | 1.1587 ms | 2.652 ms | 586.8 |     47 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.734 ms | 0.3370 ms | 0.1687 ms | 1.624 ms | 1.2543 ms | 2.578 ms | 576.8 |     16 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.734 ms | 0.4910 ms | 0.2549 ms | 1.641 ms | 1.1425 ms | 3.238 ms | 576.7 |     13 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1.736 ms | 0.4494 ms | 0.2250 ms | 1.728 ms | 0.9849 ms | 2.548 ms | 575.9 |     14 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.738 ms | 0.3007 ms | 0.1542 ms | 1.692 ms | 1.2790 ms | 2.485 ms | 575.3 |     17 KB |
|                                    Single | InsightBenchmarkWrite | 1.745 ms | 0.3419 ms | 0.1712 ms | 1.715 ms | 1.2943 ms | 2.539 ms | 572.9 |     15 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.746 ms | 0.3824 ms | 0.1915 ms | 1.708 ms | 1.2009 ms | 2.575 ms | 572.8 |     47 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1.747 ms | 0.4101 ms | 0.2077 ms | 1.645 ms | 1.2119 ms | 2.783 ms | 572.5 |     13 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1.765 ms | 0.5233 ms | 0.2716 ms | 1.744 ms | 0.9900 ms | 2.901 ms | 566.7 |     19 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 1.768 ms | 0.4081 ms | 0.2092 ms | 1.870 ms | 0.9737 ms | 2.364 ms | 565.6 |     17 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1.776 ms | 0.3227 ms | 0.1635 ms | 1.708 ms | 1.2889 ms | 2.777 ms | 562.9 |     18 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.788 ms | 0.3641 ms | 0.1867 ms | 1.660 ms | 1.2563 ms | 2.703 ms | 559.2 |     19 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.799 ms | 0.3405 ms | 0.1725 ms | 1.693 ms | 1.3199 ms | 2.486 ms | 555.9 |     17 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.811 ms | 0.3290 ms | 0.1648 ms | 1.782 ms | 1.2822 ms | 2.676 ms | 552.2 |     14 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1.833 ms | 0.2995 ms | 0.1517 ms | 1.839 ms | 1.2536 ms | 2.640 ms | 545.5 |     17 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.838 ms | 0.3072 ms | 0.1575 ms | 1.822 ms | 1.1765 ms | 2.411 ms | 544.0 |     16 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.842 ms | 0.3902 ms | 0.1977 ms | 1.761 ms | 1.3679 ms | 2.614 ms | 543.0 |     16 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.877 ms | 0.2952 ms | 0.1496 ms | 1.907 ms | 1.3416 ms | 2.439 ms | 532.7 |     49 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.879 ms | 0.3418 ms | 0.1692 ms | 1.836 ms | 1.2183 ms | 2.838 ms | 532.1 |     16 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.889 ms | 0.3489 ms | 0.1727 ms | 1.882 ms | 1.2109 ms | 2.731 ms | 529.4 |     16 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 1.889 ms | 0.3064 ms | 0.1552 ms | 1.921 ms | 1.3550 ms | 2.519 ms | 529.3 |     68 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1.893 ms | 0.5194 ms | 0.2601 ms | 1.845 ms | 1.2437 ms | 3.688 ms | 528.2 |     18 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.894 ms | 0.3245 ms | 0.1606 ms | 1.808 ms | 1.4137 ms | 2.709 ms | 527.9 |     50 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.898 ms | 0.5050 ms | 0.2589 ms | 1.737 ms | 1.2261 ms | 3.138 ms | 527.0 |     13 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.917 ms | 0.6087 ms | 0.3200 ms | 1.722 ms | 1.1904 ms | 3.464 ms | 521.7 |     16 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.941 ms | 0.4606 ms | 0.2306 ms | 1.929 ms | 1.2222 ms | 3.154 ms | 515.3 |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.946 ms | 0.3852 ms | 0.1907 ms | 1.936 ms | 1.3399 ms | 3.118 ms | 513.9 |     14 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.946 ms | 0.4357 ms | 0.2157 ms | 1.891 ms | 1.2263 ms | 2.779 ms | 513.8 |     13 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml | 1.959 ms | 0.3900 ms | 0.1931 ms | 1.910 ms | 1.3279 ms | 2.860 ms | 510.4 |     68 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.980 ms | 0.3756 ms | 0.1859 ms | 1.955 ms | 1.3702 ms | 2.778 ms | 505.2 |     19 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.993 ms | 0.6013 ms | 0.3011 ms | 1.910 ms | 0.8607 ms | 3.887 ms | 501.8 |     13 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.995 ms | 0.4507 ms | 0.2257 ms | 1.897 ms | 1.1771 ms | 3.245 ms | 501.2 |     13 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.023 ms | 0.5181 ms | 0.2656 ms | 1.884 ms | 1.3048 ms | 3.266 ms | 494.3 |     16 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml | 2.047 ms | 0.4313 ms | 0.2211 ms | 1.906 ms | 1.5047 ms | 3.367 ms | 488.6 |     72 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 2.067 ms | 0.5395 ms | 0.2766 ms | 2.326 ms | 1.0465 ms | 2.825 ms | 483.8 |     16 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 2.072 ms | 0.2952 ms | 0.1478 ms | 2.079 ms | 1.4716 ms | 2.768 ms | 482.7 |     16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 2.073 ms | 0.5270 ms | 0.2639 ms | 1.968 ms | 1.2752 ms | 3.079 ms | 482.3 |     16 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml | 2.102 ms | 0.3471 ms | 0.1738 ms | 2.081 ms | 1.5070 ms | 2.859 ms | 475.7 |     71 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 2.128 ms | 0.4258 ms | 0.2132 ms | 2.062 ms | 1.5262 ms | 3.559 ms | 469.9 |     16 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 2.129 ms | 0.3505 ms | 0.1819 ms | 2.205 ms | 1.4033 ms | 2.663 ms | 469.7 |     13 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.190 ms | 0.5528 ms | 0.2768 ms | 2.063 ms | 1.3152 ms | 3.218 ms | 456.7 |     18 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 2.221 ms | 0.3849 ms | 0.1950 ms | 2.264 ms | 1.2236 ms | 2.875 ms | 450.3 |     17 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 2.228 ms | 0.3696 ms | 0.1830 ms | 2.209 ms | 1.5954 ms | 2.924 ms | 448.8 |     14 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 2.283 ms | 0.6223 ms | 0.3116 ms | 2.208 ms | 1.2118 ms | 3.602 ms | 438.1 |     17 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 2.376 ms | 0.9769 ms | 0.4836 ms | 2.140 ms | 1.4939 ms | 6.841 ms | 420.9 |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 2.427 ms | 1.4789 ms | 0.7583 ms | 2.016 ms | 1.2565 ms | 8.545 ms | 412.1 |     13 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 2.438 ms | 0.4569 ms | 0.2262 ms | 2.467 ms | 1.5896 ms | 3.473 ms | 410.2 |     18 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.455 ms | 0.5159 ms | 0.2678 ms | 2.377 ms | 1.5789 ms | 4.523 ms | 407.4 |     20 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 2.796 ms | 1.4548 ms | 0.7202 ms | 2.275 ms | 1.6561 ms | 8.665 ms | 357.6 |     19 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 3.204 ms | 0.3154 ms | 0.1702 ms | 3.172 ms | 2.6029 ms | 4.170 ms | 312.1 |     37 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3.465 ms | 0.4009 ms | 0.2081 ms | 3.428 ms | 2.7283 ms | 4.539 ms | 288.6 |     37 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4.028 ms | 0.5402 ms | 0.2769 ms | 3.918 ms | 3.0406 ms | 5.079 ms | 248.2 |     36 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 4.273 ms | 0.6724 ms | 0.3367 ms | 4.152 ms | 3.3242 ms | 6.013 ms | 234.0 |     36 KB |
|                                           |                       |          |           |           |          |           |          |       |           |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3.641 ms | 0.7906 ms | 0.3959 ms | 3.654 ms | 2.4121 ms | 5.591 ms | 274.6 |     12 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 3.860 ms | 0.6616 ms | 0.3275 ms | 3.905 ms | 2.8029 ms | 5.363 ms | 259.1 |     12 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.968 ms | 0.6603 ms | 0.3307 ms | 3.901 ms | 2.9168 ms | 5.346 ms | 252.0 |     21 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 3.984 ms | 1.1209 ms | 0.5549 ms | 3.800 ms | 2.5266 ms | 8.648 ms | 251.0 |      8 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4.049 ms | 0.9227 ms | 0.4674 ms | 3.971 ms | 2.6666 ms | 6.116 ms | 247.0 |     12 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4.238 ms | 1.2567 ms | 0.6221 ms | 4.003 ms | 2.5749 ms | 8.781 ms | 235.9 |      8 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 4.477 ms | 1.4829 ms | 0.7341 ms | 3.968 ms | 2.3885 ms | 7.538 ms | 223.4 |      8 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 4.712 ms | 1.0657 ms | 0.5276 ms | 4.693 ms | 2.6814 ms | 6.757 ms | 212.2 |     18 KB |
