# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

``` ini

BenchmarkDotNet=v0.13.3, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                                    Method |                  Type |     Mean |    StdDev |     Error |   Median |       Min |       Max |  Op/s | Allocated |
|------------------------------------------ |---------------------- |---------:|----------:|----------:|---------:|----------:|----------:|------:|----------:|
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.249 ms | 0.2445 ms | 0.1254 ms | 1.263 ms | 0.6370 ms |  1.621 ms | 800.3 |  18.77 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.277 ms | 0.2512 ms | 0.1258 ms | 1.347 ms | 0.6837 ms |  1.730 ms | 782.9 |   18.5 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.281 ms | 0.2872 ms | 0.1438 ms | 1.365 ms | 0.6471 ms |  1.798 ms | 780.7 |  18.34 KB |
|                                    Single | InsightBenchmarkWrite | 1.311 ms | 0.1955 ms | 0.0968 ms | 1.286 ms | 0.9558 ms |  1.778 ms | 762.9 |  18.38 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.313 ms | 0.2407 ms | 0.1220 ms | 1.357 ms | 0.7763 ms |  1.768 ms | 761.8 |  18.68 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.315 ms | 0.2118 ms | 0.1048 ms | 1.336 ms | 0.7907 ms |  1.748 ms | 760.3 |  45.04 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.344 ms | 0.2417 ms | 0.1210 ms | 1.358 ms | 0.9049 ms |  1.966 ms | 743.9 |  18.34 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.349 ms | 0.2122 ms | 0.1063 ms | 1.390 ms | 0.8067 ms |  1.817 ms | 741.5 |  18.33 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.351 ms | 0.2326 ms | 0.1165 ms | 1.347 ms | 0.7351 ms |  1.776 ms | 740.3 |  18.45 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1.361 ms | 0.2106 ms | 0.1054 ms | 1.359 ms | 0.9257 ms |  1.835 ms | 734.8 |  21.03 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.382 ms | 0.2474 ms | 0.1225 ms | 1.402 ms | 0.7476 ms |  1.764 ms | 723.7 |  18.77 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.382 ms | 0.3085 ms | 0.1563 ms | 1.412 ms | 0.7258 ms |  2.016 ms | 723.4 |  21.03 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.383 ms | 0.2287 ms | 0.1145 ms | 1.414 ms | 0.8362 ms |  1.670 ms | 723.2 |  18.01 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1.405 ms | 0.2433 ms | 0.1204 ms | 1.407 ms | 0.8418 ms |  1.907 ms | 711.8 |  21.03 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1.407 ms | 0.2128 ms | 0.1066 ms | 1.405 ms | 0.9463 ms |  1.829 ms | 710.8 |  18.36 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.426 ms | 0.1726 ms | 0.0864 ms | 1.395 ms | 1.0406 ms |  1.907 ms | 701.1 |  18.77 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.436 ms | 0.2107 ms | 0.1043 ms | 1.405 ms | 1.0731 ms |  1.941 ms | 696.2 |  17.95 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.445 ms | 0.2213 ms | 0.1108 ms | 1.475 ms | 0.8864 ms |  2.018 ms | 692.1 |  20.59 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1.454 ms | 0.2810 ms | 0.1407 ms | 1.479 ms | 0.9375 ms |  1.956 ms | 687.9 |  21.06 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.454 ms | 0.2232 ms | 0.1118 ms | 1.481 ms | 0.9332 ms |  1.838 ms | 687.8 |  18.65 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1.458 ms | 0.1542 ms | 0.0781 ms | 1.463 ms | 1.1392 ms |  1.878 ms | 685.9 |   18.8 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.458 ms | 0.2516 ms | 0.1260 ms | 1.492 ms | 0.7890 ms |  1.937 ms | 685.7 |   20.6 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.480 ms | 0.2023 ms | 0.1013 ms | 1.499 ms | 1.0387 ms |  1.883 ms | 675.8 |  18.33 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.482 ms | 0.1468 ms | 0.0735 ms | 1.503 ms | 1.1702 ms |  1.772 ms | 674.6 |  21.03 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.483 ms | 0.2296 ms | 0.1150 ms | 1.499 ms | 0.9764 ms |  2.085 ms | 674.3 |  18.65 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1.502 ms | 0.1419 ms | 0.0736 ms | 1.517 ms | 1.1944 ms |  1.827 ms | 665.9 |  44.61 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.504 ms | 0.2041 ms | 0.1022 ms | 1.537 ms | 1.0117 ms |  1.986 ms | 665.1 |  18.77 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1.520 ms | 0.1922 ms | 0.0962 ms | 1.499 ms | 1.1280 ms |  1.958 ms | 657.8 |  20.59 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.521 ms | 0.3841 ms | 0.1901 ms | 1.494 ms | 0.8586 ms |  2.393 ms | 657.5 |  18.77 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.521 ms | 0.1623 ms | 0.0803 ms | 1.551 ms | 1.1553 ms |  1.776 ms | 657.4 |  18.65 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1.525 ms | 0.1949 ms | 0.0976 ms | 1.534 ms | 1.1100 ms |  1.876 ms | 655.9 |  20.62 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.525 ms | 0.2082 ms | 0.1031 ms | 1.540 ms | 1.0023 ms |  1.885 ms | 655.6 |  21.03 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.532 ms | 0.2960 ms | 0.1465 ms | 1.526 ms | 0.9131 ms |  2.379 ms | 652.9 |  18.68 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.535 ms | 0.1854 ms | 0.0939 ms | 1.497 ms | 1.2071 ms |  1.924 ms | 651.6 |  18.77 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1.536 ms | 0.2060 ms | 0.1031 ms | 1.538 ms | 1.1142 ms |  1.996 ms | 651.1 |  21.03 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.536 ms | 0.1748 ms | 0.0886 ms | 1.559 ms | 1.1908 ms |  1.837 ms | 650.9 |  18.68 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.538 ms | 0.1861 ms | 0.0932 ms | 1.543 ms | 1.2358 ms |  1.935 ms | 650.3 |   18.8 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.542 ms | 0.1460 ms | 0.0731 ms | 1.555 ms | 1.2475 ms |  1.792 ms | 648.6 |  18.68 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.552 ms | 0.1890 ms | 0.0936 ms | 1.566 ms | 1.1554 ms |  1.876 ms | 644.3 |  20.59 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1.555 ms | 0.1554 ms | 0.0769 ms | 1.564 ms | 1.1586 ms |  1.927 ms | 643.2 |  20.62 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.570 ms | 0.1731 ms | 0.0867 ms | 1.573 ms | 1.2009 ms |  2.064 ms | 636.9 |  18.65 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 1.579 ms | 0.1827 ms | 0.0915 ms | 1.573 ms | 1.1707 ms |  1.883 ms | 633.3 |  21.06 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1.616 ms | 0.1843 ms | 0.0912 ms | 1.599 ms | 1.0951 ms |  1.936 ms | 618.7 |   20.6 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.629 ms | 0.2276 ms | 0.1153 ms | 1.662 ms | 1.1222 ms |  2.072 ms | 613.7 |  44.59 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.634 ms | 0.2378 ms | 0.1177 ms | 1.602 ms | 1.2242 ms |  2.272 ms | 612.0 |  18.01 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1.645 ms | 0.2944 ms | 0.1491 ms | 1.601 ms | 1.1446 ms |  2.582 ms | 607.8 |  21.06 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.687 ms | 0.3106 ms | 0.1555 ms | 1.674 ms | 1.1052 ms |  2.309 ms | 592.8 |  18.33 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.692 ms | 0.2931 ms | 0.1485 ms | 1.782 ms | 0.9342 ms |  2.133 ms | 591.0 |  18.33 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.692 ms | 0.1809 ms | 0.0906 ms | 1.749 ms | 1.2970 ms |  2.039 ms | 590.9 |  45.04 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1.697 ms | 0.2719 ms | 0.1346 ms | 1.690 ms | 1.2768 ms |  2.628 ms | 589.1 |  20.63 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.712 ms | 0.2549 ms | 0.1291 ms | 1.664 ms | 1.2068 ms |  2.272 ms | 584.3 |  17.95 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.746 ms | 0.1726 ms | 0.0854 ms | 1.779 ms | 1.3653 ms |  2.043 ms | 572.6 |  18.34 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.783 ms | 0.2374 ms | 0.1248 ms | 1.821 ms | 1.3253 ms |  2.211 ms | 560.9 |  51.23 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1.904 ms | 0.1915 ms | 0.0982 ms | 1.904 ms | 1.4722 ms |  2.325 ms | 525.1 |  52.77 KB |
|                                    Single |      InsightBenchmark | 1.933 ms | 0.1110 ms | 0.0562 ms | 1.931 ms | 1.6952 ms |  2.247 ms | 517.3 |  50.55 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1.962 ms | 0.2577 ms | 0.1290 ms | 1.915 ms | 1.5484 ms |  2.665 ms | 509.6 |  20.59 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1.969 ms | 0.1349 ms | 0.0668 ms | 1.953 ms | 1.7276 ms |  2.413 ms | 507.8 |  50.98 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.974 ms | 0.1263 ms | 0.0632 ms | 1.960 ms | 1.7252 ms |  2.296 ms | 506.7 |  50.52 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 2.071 ms | 0.1803 ms | 0.0903 ms | 2.084 ms | 1.7258 ms |  2.372 ms | 482.8 |   53.2 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.073 ms | 0.2209 ms | 0.1132 ms | 2.094 ms | 1.5492 ms |  2.538 ms | 482.5 |   50.8 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 2.097 ms | 0.1783 ms | 0.0937 ms | 2.113 ms | 1.7558 ms |  2.486 ms | 476.8 |  52.77 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 2.098 ms | 0.1901 ms | 0.0975 ms | 2.106 ms | 1.5206 ms |  2.445 ms | 476.6 |  51.54 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 2.134 ms | 0.1355 ms | 0.0687 ms | 2.131 ms | 1.8367 ms |  2.450 ms | 468.7 |   53.2 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 2.138 ms | 0.3752 ms | 0.1857 ms | 2.095 ms | 1.4928 ms |  3.550 ms | 467.8 |  50.66 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.142 ms | 0.1171 ms | 0.0624 ms | 2.149 ms | 1.8221 ms |  2.421 ms | 466.8 |  50.75 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 2.245 ms | 0.2223 ms | 0.1140 ms | 2.225 ms | 1.9295 ms |  2.894 ms | 445.5 |  49.59 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 2.907 ms | 1.2216 ms | 0.6340 ms | 2.519 ms | 1.8770 ms |  8.081 ms | 344.0 |  51.97 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 3.580 ms | 0.2949 ms | 0.1512 ms | 3.547 ms | 2.9497 ms |  4.193 ms | 279.3 |  39.68 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3.584 ms | 0.2143 ms | 0.1112 ms | 3.611 ms | 3.1611 ms |  4.143 ms | 279.0 |  39.68 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3.705 ms | 0.3555 ms | 0.1823 ms | 3.654 ms | 2.8748 ms |  4.424 ms | 269.9 |  40.14 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 4.013 ms | 4.2982 ms | 2.2309 ms | 2.307 ms | 1.4921 ms | 25.028 ms | 249.2 |   50.7 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4.157 ms | 0.4579 ms | 0.2407 ms | 4.027 ms | 3.4523 ms |  5.031 ms | 240.5 |  40.14 KB |
|                                           |                       |          |           |           |          |           |           |       |           |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.700 ms | 0.7387 ms | 0.3657 ms | 2.507 ms | 1.5458 ms |  4.452 ms | 370.4 |  31.41 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.867 ms | 0.7609 ms | 0.3767 ms | 2.783 ms | 1.7512 ms |  4.910 ms | 348.8 |  32.53 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.144 ms | 0.9443 ms | 0.4728 ms | 3.160 ms | 1.6050 ms |  5.236 ms | 318.1 |  21.34 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3.169 ms | 0.7888 ms | 0.3950 ms | 3.177 ms | 1.8581 ms |  4.640 ms | 315.6 |  22.44 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 3.190 ms | 0.8193 ms | 0.4103 ms | 3.181 ms | 1.9817 ms |  5.033 ms | 313.5 |  21.02 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 3.631 ms | 0.7973 ms | 0.3992 ms | 3.656 ms | 2.2682 ms |  5.012 ms | 275.4 |  21.88 KB |
