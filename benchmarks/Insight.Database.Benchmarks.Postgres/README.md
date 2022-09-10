# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]   : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  ShortRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT


```
|                            Method |                  Type |     Mean |    StdDev |     Error |   Median |       Min |      Max |  Op/s | Allocated |
|---------------------------------- |---------------------- |---------:|----------:|----------:|---------:|----------:|---------:|------:|----------:|
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.215 ms | 0.1671 ms | 0.0846 ms | 1.257 ms | 0.9066 ms | 1.581 ms | 822.9 |     11 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.241 ms | 0.2459 ms | 0.1261 ms | 1.276 ms | 0.7514 ms | 1.708 ms | 805.5 |     14 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.245 ms | 0.2100 ms | 0.1064 ms | 1.260 ms | 0.7869 ms | 1.642 ms | 803.4 |     14 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.256 ms | 0.2050 ms | 0.1027 ms | 1.258 ms | 0.8788 ms | 1.682 ms | 796.2 |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.290 ms | 0.2168 ms | 0.1085 ms | 1.270 ms | 0.8532 ms | 1.847 ms | 775.4 |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.320 ms | 0.2285 ms | 0.1131 ms | 1.318 ms | 0.9766 ms | 2.000 ms | 757.8 |     11 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.326 ms | 0.3188 ms | 0.1635 ms | 1.256 ms | 0.8454 ms | 2.284 ms | 754.1 |     39 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.367 ms | 0.2340 ms | 0.1172 ms | 1.392 ms | 0.9164 ms | 1.877 ms | 731.6 |     11 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.376 ms | 0.2740 ms | 0.1388 ms | 1.348 ms | 0.9814 ms | 2.285 ms | 726.6 |      9 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 1.384 ms | 0.1981 ms | 0.0981 ms | 1.372 ms | 0.9982 ms | 1.759 ms | 722.3 |     32 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.392 ms | 0.3510 ms | 0.1738 ms | 1.294 ms | 0.9846 ms | 2.317 ms | 718.2 |     14 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.398 ms | 0.2562 ms | 0.1330 ms | 1.337 ms | 0.9660 ms | 2.232 ms | 715.4 |      9 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.408 ms | 0.2382 ms | 0.1193 ms | 1.355 ms | 0.8889 ms | 1.940 ms | 710.2 |     14 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.417 ms | 0.2763 ms | 0.1383 ms | 1.501 ms | 0.8625 ms | 2.013 ms | 705.6 |      9 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.436 ms | 0.4093 ms | 0.2124 ms | 1.387 ms | 0.9216 ms | 2.431 ms | 696.4 |     15 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 1.442 ms | 0.2515 ms | 0.1245 ms | 1.426 ms | 0.9487 ms | 2.017 ms | 693.3 |     14 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.478 ms | 0.2304 ms | 0.1181 ms | 1.457 ms | 1.0312 ms | 2.079 ms | 676.4 |     14 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 1.498 ms | 0.3395 ms | 0.1720 ms | 1.429 ms | 0.9479 ms | 2.260 ms | 667.5 |     15 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.500 ms | 0.1982 ms | 0.1004 ms | 1.513 ms | 1.0588 ms | 1.973 ms | 666.7 |      9 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.521 ms | 0.2438 ms | 0.1221 ms | 1.504 ms | 1.0524 ms | 1.948 ms | 657.4 |     11 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.539 ms | 0.2758 ms | 0.1381 ms | 1.595 ms | 1.0008 ms | 2.100 ms | 649.6 |     11 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.542 ms | 0.2953 ms | 0.1572 ms | 1.559 ms | 0.9941 ms | 2.272 ms | 648.4 |     15 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.573 ms | 0.4284 ms | 0.2121 ms | 1.487 ms | 1.0329 ms | 2.788 ms | 635.6 |     14 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.585 ms | 0.4057 ms | 0.2055 ms | 1.543 ms | 1.0364 ms | 2.556 ms | 630.8 |      9 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.598 ms | 0.2105 ms | 0.1066 ms | 1.616 ms | 1.1167 ms | 2.179 ms | 625.8 |     11 KB |
|                            Single | InsightBenchmarkWrite | 1.625 ms | 0.5014 ms | 0.2510 ms | 1.470 ms | 1.0287 ms | 2.864 ms | 615.4 |     14 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.628 ms | 0.2980 ms | 0.1510 ms | 1.543 ms | 1.2234 ms | 2.468 ms | 614.3 |      9 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 1.638 ms | 0.2636 ms | 0.1320 ms | 1.568 ms | 1.2198 ms | 2.312 ms | 610.3 |     14 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.671 ms | 0.3191 ms | 0.1598 ms | 1.682 ms | 1.1079 ms | 2.593 ms | 598.6 |     41 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.686 ms | 0.3980 ms | 0.2040 ms | 1.634 ms | 0.9050 ms | 2.692 ms | 593.2 |     14 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.697 ms | 0.4255 ms | 0.2106 ms | 1.664 ms | 1.0385 ms | 2.479 ms | 589.1 |      9 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 1.699 ms | 0.3013 ms | 0.1509 ms | 1.685 ms | 1.1261 ms | 2.534 ms | 588.4 |     32 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.801 ms | 0.3815 ms | 0.1956 ms | 1.784 ms | 1.2125 ms | 2.628 ms | 555.2 |      9 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.806 ms | 0.6330 ms | 0.3133 ms | 1.599 ms | 0.9756 ms | 3.299 ms | 553.8 |     41 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.810 ms | 0.2178 ms | 0.1091 ms | 1.797 ms | 1.3397 ms | 2.334 ms | 552.4 |      9 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1.850 ms | 0.5363 ms | 0.2717 ms | 1.722 ms | 0.9597 ms | 2.744 ms | 540.6 |     39 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.866 ms | 0.2820 ms | 0.1412 ms | 1.848 ms | 1.3390 ms | 2.585 ms | 535.8 |     11 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.875 ms | 0.3836 ms | 0.1921 ms | 1.775 ms | 1.3488 ms | 2.739 ms | 533.4 |     15 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.910 ms | 0.2578 ms | 0.1276 ms | 1.885 ms | 1.3324 ms | 2.605 ms | 523.7 |     11 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.910 ms | 0.3376 ms | 0.1671 ms | 1.825 ms | 1.3794 ms | 3.065 ms | 523.6 |     14 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 1.945 ms | 0.2552 ms | 0.1293 ms | 1.901 ms | 1.5266 ms | 2.782 ms | 514.2 |     34 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.993 ms | 0.3892 ms | 0.1972 ms | 1.896 ms | 1.3202 ms | 2.951 ms | 501.7 |      9 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 2.112 ms | 0.3284 ms | 0.1664 ms | 2.125 ms | 1.5616 ms | 2.909 ms | 473.4 |     34 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.248 ms | 0.3077 ms | 0.1523 ms | 2.222 ms | 1.3461 ms | 3.006 ms | 444.8 |     15 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 2.322 ms | 0.3009 ms | 0.1490 ms | 2.308 ms | 1.8187 ms | 3.106 ms | 430.6 |     15 KB |
|                            Single |      InsightBenchmark | 2.566 ms | 0.5206 ms | 0.2638 ms | 2.458 ms | 1.6989 ms | 4.533 ms | 389.7 |     14 KB |
|                                   |                       |          |           |           |          |           |          |       |           |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 2.086 ms | 0.3726 ms | 0.1866 ms | 1.967 ms | 1.5124 ms | 3.032 ms | 479.4 |      4 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.152 ms | 0.2200 ms | 0.1089 ms | 2.106 ms | 1.8148 ms | 2.736 ms | 464.7 |      4 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.389 ms | 0.4457 ms | 0.2206 ms | 2.314 ms | 1.6841 ms | 3.630 ms | 418.6 |      6 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.391 ms | 0.3905 ms | 0.1978 ms | 2.305 ms | 1.8836 ms | 3.746 ms | 418.3 |     11 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.630 ms | 0.3663 ms | 0.1813 ms | 2.618 ms | 2.0676 ms | 3.354 ms | 380.2 |     17 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 2.683 ms | 0.3791 ms | 0.1898 ms | 2.649 ms | 1.9953 ms | 3.526 ms | 372.8 |     15 KB |
