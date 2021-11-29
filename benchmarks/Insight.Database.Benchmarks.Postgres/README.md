# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100
  [Host]   : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  ShortRun : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |                  Type |     Mean |    StdDev |     Error |      Min |       Max |  Op/s | Allocated |
|---------------------------------- |---------------------- |---------:|----------:|----------:|---------:|----------:|------:|----------:|
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.789 ms | 0.1251 ms | 0.0658 ms | 1.606 ms |  2.167 ms | 559.1 |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.810 ms | 0.1360 ms | 0.0724 ms | 1.539 ms |  2.233 ms | 552.6 |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.832 ms | 0.1504 ms | 0.0801 ms | 1.576 ms |  2.434 ms | 545.8 |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.846 ms | 0.1382 ms | 0.0708 ms | 1.533 ms |  2.300 ms | 541.7 |     11 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.848 ms | 0.1714 ms | 0.0901 ms | 1.513 ms |  2.267 ms | 541.2 |      9 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.849 ms | 0.1460 ms | 0.0787 ms | 1.582 ms |  2.209 ms | 540.7 |     11 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.851 ms | 0.1295 ms | 0.0672 ms | 1.684 ms |  2.195 ms | 540.3 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.855 ms | 0.1826 ms | 0.0948 ms | 1.638 ms |  2.505 ms | 539.2 |      9 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.856 ms | 0.1421 ms | 0.0777 ms | 1.605 ms |  2.213 ms | 538.7 |     14 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.869 ms | 0.1338 ms | 0.0722 ms | 1.641 ms |  2.218 ms | 535.0 |      9 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.875 ms | 0.2155 ms | 0.1105 ms | 1.632 ms |  2.701 ms | 533.3 |      9 KB |
|                            Single | InsightBenchmarkWrite | 1.877 ms | 0.1884 ms | 0.0954 ms | 1.574 ms |  2.578 ms | 532.9 |     14 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1.877 ms | 0.0869 ms | 0.0463 ms | 1.744 ms |  2.128 ms | 532.8 |     11 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.877 ms | 0.1571 ms | 0.0837 ms | 1.645 ms |  2.370 ms | 532.8 |     10 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 1.884 ms | 0.1299 ms | 0.0691 ms | 1.662 ms |  2.235 ms | 530.8 |     14 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.887 ms | 0.1310 ms | 0.0697 ms | 1.663 ms |  2.172 ms | 530.0 |     11 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.888 ms | 0.2366 ms | 0.1213 ms | 1.485 ms |  2.820 ms | 529.7 |     10 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.893 ms | 0.1343 ms | 0.0725 ms | 1.684 ms |  2.257 ms | 528.2 |     14 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.905 ms | 0.1565 ms | 0.0802 ms | 1.566 ms |  2.300 ms | 524.9 |     14 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.911 ms | 0.1951 ms | 0.1052 ms | 1.602 ms |  2.396 ms | 523.4 |     14 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.911 ms | 0.1891 ms | 0.0958 ms | 1.607 ms |  2.530 ms | 523.2 |     40 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.912 ms | 0.1970 ms | 0.0986 ms | 1.632 ms |  2.496 ms | 523.0 |     11 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.918 ms | 0.2789 ms | 0.1447 ms | 1.545 ms |  3.176 ms | 521.3 |     14 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 1.930 ms | 0.2834 ms | 0.1471 ms | 1.585 ms |  2.963 ms | 518.3 |     14 KB |
|                            Single |      InsightBenchmark | 1.934 ms | 0.3247 ms | 0.1729 ms | 1.554 ms |  2.857 ms | 517.1 |     14 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.936 ms | 0.3047 ms | 0.1544 ms | 1.666 ms |  2.994 ms | 516.5 |      9 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 1.938 ms | 0.1239 ms | 0.0651 ms | 1.640 ms |  2.392 ms | 516.0 |     15 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.939 ms | 0.3036 ms | 0.1556 ms | 1.571 ms |  2.881 ms | 515.8 |      9 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1.941 ms | 0.1430 ms | 0.0761 ms | 1.751 ms |  2.406 ms | 515.2 |     15 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.941 ms | 0.2013 ms | 0.1072 ms | 1.570 ms |  2.381 ms | 515.1 |     14 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.957 ms | 0.1724 ms | 0.0930 ms | 1.650 ms |  2.465 ms | 510.9 |     14 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 1.958 ms | 0.2107 ms | 0.1080 ms | 1.618 ms |  2.513 ms | 510.7 |     15 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.962 ms | 0.2571 ms | 0.1334 ms | 1.679 ms |  2.874 ms | 509.7 |     11 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.963 ms | 0.1318 ms | 0.0702 ms | 1.774 ms |  2.286 ms | 509.4 |     41 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.964 ms | 0.3085 ms | 0.1601 ms | 1.590 ms |  3.126 ms | 509.1 |     11 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.970 ms | 0.2476 ms | 0.1301 ms | 1.615 ms |  2.867 ms | 507.5 |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1.983 ms | 0.1302 ms | 0.0722 ms | 1.771 ms |  2.359 ms | 504.2 |     15 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1.993 ms | 0.1721 ms | 0.0917 ms | 1.678 ms |  2.434 ms | 501.7 |     15 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1.999 ms | 0.2889 ms | 0.1447 ms | 1.591 ms |  3.109 ms | 500.3 |     40 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 2.001 ms | 0.1705 ms | 0.0896 ms | 1.710 ms |  2.707 ms | 499.8 |     15 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 2.028 ms | 0.2170 ms | 0.1113 ms | 1.663 ms |  2.827 ms | 493.1 |     14 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 2.076 ms | 0.2156 ms | 0.1133 ms | 1.816 ms |  2.616 ms | 481.8 |     41 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 4.472 ms | 0.5366 ms | 0.2687 ms | 3.813 ms |  5.454 ms | 223.6 |     34 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 4.504 ms | 0.4287 ms | 0.2198 ms | 4.074 ms |  5.837 ms | 222.0 |     34 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 4.603 ms | 0.7760 ms | 0.3979 ms | 3.849 ms |  6.844 ms | 217.3 |     34 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4.880 ms | 0.8179 ms | 0.4144 ms | 4.112 ms |  7.016 ms | 204.9 |     34 KB |
|                                   |                       |          |           |           |          |           |       |           |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 7.502 ms | 3.5091 ms | 1.8214 ms | 2.895 ms | 17.266 ms | 133.3 |      5 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 7.588 ms | 3.0798 ms | 1.6397 ms | 2.874 ms | 13.825 ms | 131.8 |     15 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 8.152 ms | 4.7359 ms | 2.4892 ms | 3.223 ms | 20.362 ms | 122.7 |     17 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 8.186 ms | 5.0276 ms | 2.5777 ms | 3.017 ms | 23.011 ms | 122.2 |     11 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 8.365 ms | 4.6139 ms | 2.3374 ms | 2.601 ms | 19.203 ms | 119.6 |      6 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 8.583 ms | 6.2736 ms | 3.1414 ms | 2.521 ms | 27.331 ms | 116.5 |      5 KB |
