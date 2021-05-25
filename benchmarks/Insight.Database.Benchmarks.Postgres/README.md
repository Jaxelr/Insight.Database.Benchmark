# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.203
  [Host]   : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  ShortRun : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT


```
|                            Method |                  Type |      Mean |    StdDev |     Error |      Min |       Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |----------:|----------:|----------:|---------:|----------:|-------:|------:|------:|------:|----------:|
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  2.160 ms | 0.1967 ms | 0.1034 ms | 1.794 ms |  2.582 ms | 463.00 |     - |     - |     - |      9 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  2.165 ms | 0.1427 ms | 0.0732 ms | 1.870 ms |  2.537 ms | 461.91 |     - |     - |     - |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.169 ms | 0.1950 ms | 0.1012 ms | 1.864 ms |  2.634 ms | 461.08 |     - |     - |     - |      9 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  2.169 ms | 0.1382 ms | 0.0736 ms | 1.948 ms |  2.519 ms | 460.96 |     - |     - |     - |      9 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  2.172 ms | 0.1933 ms | 0.1016 ms | 1.888 ms |  2.862 ms | 460.41 |     - |     - |     - |     11 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |  2.174 ms | 0.1924 ms | 0.0987 ms | 1.862 ms |  2.614 ms | 459.91 |     - |     - |     - |     13 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.189 ms | 0.1564 ms | 0.0833 ms | 1.944 ms |  2.693 ms | 456.92 |     - |     - |     - |      9 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.195 ms | 0.1672 ms | 0.0868 ms | 1.847 ms |  2.654 ms | 455.67 |     - |     - |     - |     11 KB |
|                            Single |      InsightBenchmark |  2.195 ms | 0.2153 ms | 0.1131 ms | 1.867 ms |  3.050 ms | 455.57 |     - |     - |     - |     14 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  2.197 ms | 0.3739 ms | 0.1917 ms | 1.780 ms |  3.463 ms | 455.24 |     - |     - |     - |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.203 ms | 0.3022 ms | 0.1630 ms | 1.822 ms |  3.243 ms | 453.92 |     - |     - |     - |      9 KB |
|                            Single | InsightBenchmarkWrite |  2.214 ms | 0.2921 ms | 0.1498 ms | 1.892 ms |  3.213 ms | 451.74 |     - |     - |     - |     13 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |  2.217 ms | 0.3193 ms | 0.1678 ms | 1.815 ms |  3.617 ms | 451.06 |     - |     - |     - |     14 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  2.227 ms | 0.1536 ms | 0.0829 ms | 1.973 ms |  2.593 ms | 449.10 |     - |     - |     - |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |  2.228 ms | 0.1822 ms | 0.0983 ms | 1.896 ms |  2.628 ms | 448.77 |     - |     - |     - |     13 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |  2.229 ms | 0.2356 ms | 0.1194 ms | 1.787 ms |  2.894 ms | 448.70 |     - |     - |     - |      9 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.229 ms | 0.1516 ms | 0.0807 ms | 1.959 ms |  2.656 ms | 448.58 |     - |     - |     - |     14 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.240 ms | 0.2233 ms | 0.1159 ms | 1.864 ms |  2.764 ms | 446.38 |     - |     - |     - |     14 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.248 ms | 0.1791 ms | 0.0929 ms | 1.973 ms |  2.845 ms | 444.91 |     - |     - |     - |     16 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  2.251 ms | 0.3256 ms | 0.1669 ms | 1.832 ms |  3.339 ms | 444.29 |     - |     - |     - |      9 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |  2.252 ms | 0.3117 ms | 0.1598 ms | 1.839 ms |  3.279 ms | 443.95 |     - |     - |     - |     14 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  2.255 ms | 0.2781 ms | 0.1393 ms | 1.834 ms |  3.336 ms | 443.45 |     - |     - |     - |      9 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.258 ms | 0.2902 ms | 0.1506 ms | 1.910 ms |  3.275 ms | 442.86 |     - |     - |     - |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.266 ms | 0.2382 ms | 0.1236 ms | 1.911 ms |  3.179 ms | 441.30 |     - |     - |     - |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  2.281 ms | 0.3766 ms | 0.1908 ms | 1.889 ms |  3.320 ms | 438.44 |     - |     - |     - |     11 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.303 ms | 0.2067 ms | 0.1100 ms | 2.044 ms |  3.019 ms | 434.26 |     - |     - |     - |     14 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.308 ms | 0.3037 ms | 0.1596 ms | 1.990 ms |  3.410 ms | 433.25 |     - |     - |     - |      9 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.325 ms | 0.2924 ms | 0.1481 ms | 1.953 ms |  3.171 ms | 430.08 |     - |     - |     - |     11 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2.340 ms | 0.2665 ms | 0.1366 ms | 1.978 ms |  2.988 ms | 427.39 |     - |     - |     - |     15 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |  2.341 ms | 0.2543 ms | 0.1337 ms | 2.021 ms |  3.250 ms | 427.09 |     - |     - |     - |     14 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.347 ms | 0.2188 ms | 0.1122 ms | 2.032 ms |  2.926 ms | 426.14 |     - |     - |     - |     15 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson |  2.353 ms | 0.2947 ms | 0.1530 ms | 1.973 ms |  3.217 ms | 424.97 |     - |     - |     - |     35 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |  2.356 ms | 0.3888 ms | 0.2070 ms | 1.942 ms |  3.751 ms | 424.43 |     - |     - |     - |     14 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |  2.369 ms | 0.3943 ms | 0.2127 ms | 1.846 ms |  4.255 ms | 422.11 |     - |     - |     - |     15 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |  2.370 ms | 0.2520 ms | 0.1342 ms | 2.058 ms |  3.247 ms | 421.93 |     - |     - |     - |     36 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |  2.372 ms | 0.2812 ms | 0.1460 ms | 2.083 ms |  3.217 ms | 421.56 |     - |     - |     - |     35 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.372 ms | 0.3559 ms | 0.1847 ms | 1.938 ms |  3.641 ms | 421.54 |     - |     - |     - |     11 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2.394 ms | 0.3414 ms | 0.1794 ms | 2.054 ms |  3.469 ms | 417.75 |     - |     - |     - |     14 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |  2.395 ms | 0.3049 ms | 0.1623 ms | 2.014 ms |  3.408 ms | 417.57 |     - |     - |     - |     15 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.399 ms | 0.2897 ms | 0.1504 ms | 2.028 ms |  3.465 ms | 416.88 |     - |     - |     - |     15 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  2.437 ms | 0.3913 ms | 0.2031 ms | 1.941 ms |  3.909 ms | 410.34 |     - |     - |     - |     10 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson |  2.499 ms | 0.3004 ms | 0.1559 ms | 2.153 ms |  3.474 ms | 400.11 |     - |     - |     - |     37 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  4.991 ms | 0.6397 ms | 0.3241 ms | 4.197 ms |  6.852 ms | 200.35 |     - |     - |     - |     32 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5.222 ms | 0.6744 ms | 0.3339 ms | 4.278 ms |  7.155 ms | 191.49 |     - |     - |     - |     32 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  5.303 ms | 0.6489 ms | 0.3327 ms | 4.498 ms |  6.525 ms | 188.58 |     - |     - |     - |     34 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  5.321 ms | 0.6436 ms | 0.3223 ms | 4.455 ms |  6.827 ms | 187.94 |     - |     - |     - |     34 KB |
|                                   |                       |           |           |           |          |           |        |       |       |       |           |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  7.876 ms | 3.3471 ms | 1.6760 ms | 2.886 ms | 15.465 ms | 126.97 |     - |     - |     - |      5 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  9.513 ms | 5.3412 ms | 2.6745 ms | 3.155 ms | 22.434 ms | 105.12 |     - |     - |     - |     16 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |  9.797 ms | 6.4011 ms | 3.2052 ms | 3.155 ms | 27.556 ms | 102.07 |     - |     - |     - |     11 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 10.107 ms | 5.7749 ms | 2.9256 ms | 3.409 ms | 24.506 ms |  98.94 |     - |     - |     - |      4 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 10.795 ms | 6.2263 ms | 3.1543 ms | 3.035 ms | 22.614 ms |  92.63 |     - |     - |     - |      4 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 13.426 ms | 6.5262 ms | 3.2678 ms | 3.672 ms | 33.039 ms |  74.48 |     - |     - |     - |     14 KB |
