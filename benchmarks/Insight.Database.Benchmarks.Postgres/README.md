# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

``` ini

BenchmarkDotNet=v0.13.3, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                            Method |                  Type |     Mean |    StdDev |     Error |   Median |       Min |       Max |  Op/s | Allocated |
|---------------------------------- |---------------------- |---------:|----------:|----------:|---------:|----------:|----------:|------:|----------:|
|                          Query&lt;T&gt; |      InsightBenchmark | 1.243 ms | 0.1499 ms | 0.0742 ms | 1.229 ms | 0.9813 ms |  1.501 ms | 804.3 |  13.35 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.265 ms | 0.1351 ms | 0.0676 ms | 1.254 ms | 1.0024 ms |  1.541 ms | 790.6 |   9.51 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.268 ms | 0.1364 ms | 0.0683 ms | 1.273 ms | 0.9342 ms |  1.560 ms | 788.7 |    9.2 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.285 ms | 0.1267 ms | 0.0650 ms | 1.294 ms | 1.0207 ms |  1.566 ms | 778.1 |    9.2 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.289 ms | 0.1428 ms | 0.0707 ms | 1.284 ms | 0.9935 ms |  1.607 ms | 775.9 |    9.2 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.314 ms | 0.1887 ms | 0.0967 ms | 1.321 ms | 0.9598 ms |  1.622 ms | 761.0 |   9.22 KB |
|                            Single | InsightBenchmarkWrite | 1.373 ms | 0.1765 ms | 0.0894 ms | 1.345 ms | 1.0733 ms |  1.798 ms | 728.2 |  13.34 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.374 ms | 0.1208 ms | 0.0598 ms | 1.367 ms | 1.0396 ms |  1.586 ms | 727.9 |   13.5 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.382 ms | 0.1482 ms | 0.0751 ms | 1.354 ms | 1.1215 ms |  1.729 ms | 723.8 |   9.22 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.386 ms | 0.2233 ms | 0.1118 ms | 1.418 ms | 0.9376 ms |  1.763 ms | 721.4 |  13.64 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.403 ms | 0.1419 ms | 0.0728 ms | 1.391 ms | 0.9657 ms |  1.765 ms | 712.7 |  11.46 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.407 ms | 0.1719 ms | 0.0871 ms | 1.397 ms | 1.0519 ms |  1.732 ms | 710.8 |  13.64 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.411 ms | 0.1896 ms | 0.0950 ms | 1.382 ms | 0.9179 ms |  1.935 ms | 709.0 |   9.22 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 1.415 ms | 0.1759 ms | 0.0871 ms | 1.421 ms | 1.0633 ms |  1.680 ms | 706.6 |  14.98 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.415 ms | 0.1262 ms | 0.0655 ms | 1.424 ms | 1.0956 ms |  1.760 ms | 706.5 |    9.2 KB |
|                            Single |      InsightBenchmark | 1.432 ms | 0.1456 ms | 0.0721 ms | 1.445 ms | 1.0490 ms |  1.727 ms | 698.1 |  13.34 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.435 ms | 0.1776 ms | 0.0889 ms | 1.452 ms | 1.1478 ms |  1.824 ms | 696.8 |   9.51 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.451 ms | 0.1789 ms | 0.0917 ms | 1.444 ms | 1.1191 ms |  1.958 ms | 689.4 |  13.64 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.451 ms | 0.1942 ms | 0.0962 ms | 1.443 ms | 1.0850 ms |  1.860 ms | 689.2 |  13.59 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.463 ms | 0.2096 ms | 0.1049 ms | 1.475 ms | 0.8811 ms |  1.827 ms | 683.5 |   9.51 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.468 ms | 0.1499 ms | 0.0769 ms | 1.446 ms | 1.2007 ms |  1.856 ms | 681.3 |  11.12 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.483 ms | 0.1372 ms | 0.0712 ms | 1.482 ms | 1.2068 ms |  1.801 ms | 674.3 |   9.51 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.483 ms | 0.1857 ms | 0.0941 ms | 1.516 ms | 1.0478 ms |  2.026 ms | 674.1 |  10.88 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.498 ms | 0.1344 ms | 0.0681 ms | 1.500 ms | 1.1780 ms |  1.855 ms | 667.7 |  15.63 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.512 ms | 0.1569 ms | 0.0795 ms | 1.518 ms | 1.1785 ms |  1.809 ms | 661.3 |  15.53 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.517 ms | 0.1459 ms | 0.0730 ms | 1.490 ms | 1.2492 ms |  1.790 ms | 659.3 |  11.15 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.521 ms | 0.1501 ms | 0.0779 ms | 1.517 ms | 1.1280 ms |  1.808 ms | 657.3 |  13.59 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 1.523 ms | 0.2545 ms | 0.1289 ms | 1.556 ms | 0.8645 ms |  1.938 ms | 656.6 |  14.98 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.525 ms | 0.2582 ms | 0.1293 ms | 1.502 ms | 0.9822 ms |  1.988 ms | 655.8 |  10.88 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 1.526 ms | 0.1747 ms | 0.0895 ms | 1.514 ms | 1.0779 ms |  1.951 ms | 655.3 |  13.35 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.545 ms | 0.1797 ms | 0.0900 ms | 1.566 ms | 1.1259 ms |  1.974 ms | 647.4 |  10.84 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 1.549 ms | 0.1510 ms | 0.0747 ms | 1.540 ms | 1.2891 ms |  1.899 ms | 645.7 |  31.78 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.558 ms | 0.2061 ms | 0.1044 ms | 1.525 ms | 1.1051 ms |  2.092 ms | 641.8 |  13.64 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.560 ms | 0.1737 ms | 0.0890 ms | 1.547 ms | 1.2416 ms |  1.907 ms | 641.0 |  39.02 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1.565 ms | 0.1732 ms | 0.0857 ms | 1.563 ms | 1.2235 ms |  1.930 ms | 638.8 |     39 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.583 ms | 0.1716 ms | 0.0859 ms | 1.562 ms | 1.2485 ms |  2.075 ms | 631.8 |  40.67 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.598 ms | 0.2299 ms | 0.1165 ms | 1.543 ms | 1.1238 ms |  2.204 ms | 625.9 |  11.12 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.627 ms | 0.2624 ms | 0.1314 ms | 1.603 ms | 1.0615 ms |  2.461 ms | 614.8 |   13.5 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.655 ms | 0.2389 ms | 0.1196 ms | 1.671 ms | 1.1293 ms |  2.246 ms | 604.3 |  10.88 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 1.670 ms | 0.2124 ms | 0.1103 ms | 1.666 ms | 1.1523 ms |  2.031 ms | 598.8 |  31.78 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.674 ms | 0.2343 ms | 0.1173 ms | 1.635 ms | 1.2626 ms |  2.250 ms | 597.5 |  15.26 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.695 ms | 0.1523 ms | 0.0763 ms | 1.675 ms | 1.4044 ms |  2.109 ms | 589.9 |  40.64 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.708 ms | 0.2167 ms | 0.1085 ms | 1.700 ms | 1.1968 ms |  2.155 ms | 585.6 |     15 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.719 ms | 0.2929 ms | 0.1540 ms | 1.666 ms | 1.2866 ms |  2.279 ms | 581.6 |   9.22 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 1.974 ms | 0.2668 ms | 0.1336 ms | 1.998 ms | 1.3328 ms |  2.436 ms | 506.7 |  33.35 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 2.800 ms | 0.7012 ms | 0.3511 ms | 2.640 ms | 1.6957 ms |  4.270 ms | 357.1 |  33.35 KB |
|                                   |                       |          |           |           |          |           |           |       |           |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.544 ms | 0.2426 ms | 0.1275 ms | 2.503 ms | 2.1810 ms |  3.247 ms | 393.1 |   4.73 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 2.551 ms | 0.3166 ms | 0.1567 ms | 2.487 ms | 2.0759 ms |  3.447 ms | 391.9 |   4.66 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.579 ms | 0.3083 ms | 0.1544 ms | 2.605 ms | 1.9670 ms |  3.219 ms | 387.7 |    6.7 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.645 ms | 0.1867 ms | 0.0946 ms | 2.620 ms | 2.3062 ms |  3.059 ms | 378.0 |  16.47 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 2.690 ms | 0.2083 ms | 0.1031 ms | 2.669 ms | 2.2724 ms |  3.155 ms | 371.7 |   14.7 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3.242 ms | 1.8003 ms | 0.9230 ms | 2.844 ms | 2.1218 ms | 11.792 ms | 308.4 |  10.82 KB |
