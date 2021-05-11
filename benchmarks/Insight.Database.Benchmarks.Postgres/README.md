# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]   : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  ShortRun : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                            Method |                  Type |      Mean |    StdDev |     Error |      Min |       Max |   Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |----------:|----------:|----------:|---------:|----------:|-------:|------:|------:|------:|----------:|
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  2.050 ms | 0.1890 ms | 0.1006 ms | 1.789 ms |  2.520 ms | 487.77 |     - |     - |     - |   8.33 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |  2.120 ms | 0.3021 ms | 0.1513 ms | 1.732 ms |  3.180 ms | 471.67 |     - |     - |     - |   8.89 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |  2.123 ms | 0.3569 ms | 0.1808 ms | 1.756 ms |  3.391 ms | 470.96 |     - |     - |     - |   8.89 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.145 ms | 0.2028 ms | 0.1066 ms | 1.812 ms |  2.755 ms | 466.17 |     - |     - |     - |  10.23 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2.148 ms | 0.2626 ms | 0.1380 ms | 1.740 ms |  3.096 ms | 465.64 |     - |     - |     - |    9.2 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |  2.152 ms | 0.2022 ms | 0.1121 ms | 1.776 ms |  2.580 ms | 464.60 |     - |     - |     - |  13.48 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  2.167 ms | 0.2813 ms | 0.1425 ms | 1.826 ms |  3.069 ms | 461.56 |     - |     - |     - |  10.23 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2.174 ms | 0.2232 ms | 0.1173 ms | 1.792 ms |  2.888 ms | 459.99 |     - |     - |     - |  13.77 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  2.185 ms | 0.2404 ms | 0.1218 ms | 1.784 ms |  2.800 ms | 457.75 |     - |     - |     - |   8.91 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  2.191 ms | 0.3161 ms | 0.1620 ms | 1.804 ms |  3.165 ms | 456.32 |     - |     - |     - |  10.52 KB |
|                            Single |      InsightBenchmark |  2.192 ms | 0.3362 ms | 0.1684 ms | 1.806 ms |  3.340 ms | 456.29 |     - |     - |     - |  14.03 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |  2.192 ms | 0.3377 ms | 0.1731 ms | 1.821 ms |  3.300 ms | 456.12 |     - |     - |     - |  10.77 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2.209 ms | 0.2164 ms | 0.1123 ms | 1.897 ms |  2.690 ms | 452.63 |     - |     - |     - |   8.91 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  2.219 ms | 0.2347 ms | 0.1203 ms | 1.871 ms |  2.906 ms | 450.70 |     - |     - |     - |  14.81 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2.221 ms | 0.3353 ms | 0.1741 ms | 1.749 ms |  3.206 ms | 450.24 |     - |     - |     - |    9.2 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  2.226 ms | 0.2741 ms | 0.1440 ms | 1.840 ms |  3.034 ms | 449.19 |     - |     - |     - |   10.8 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |  2.229 ms | 0.2404 ms | 0.1233 ms | 1.881 ms |  3.017 ms | 448.70 |     - |     - |     - |  13.04 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  2.231 ms | 0.2862 ms | 0.1485 ms | 1.833 ms |  3.137 ms | 448.15 |     - |     - |     - |    9.2 KB |
|                            Single | InsightBenchmarkWrite |  2.240 ms | 0.2433 ms | 0.1263 ms | 1.827 ms |  2.863 ms | 446.39 |     - |     - |     - |  13.47 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2.245 ms | 0.3467 ms | 0.1822 ms | 1.820 ms |  3.275 ms | 445.52 |     - |     - |     - |  10.77 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |  2.253 ms | 0.2679 ms | 0.1408 ms | 1.871 ms |  3.125 ms | 443.79 |     - |     - |     - |  13.52 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2.255 ms | 0.3142 ms | 0.1611 ms | 1.778 ms |  3.286 ms | 443.38 |     - |     - |     - |    9.2 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  2.276 ms | 0.2331 ms | 0.1225 ms | 1.847 ms |  2.863 ms | 439.38 |     - |     - |     - |  10.77 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  2.284 ms | 0.2713 ms | 0.1374 ms | 1.909 ms |  3.266 ms | 437.85 |     - |     - |     - |  10.48 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |  2.290 ms | 0.4541 ms | 0.2387 ms | 1.813 ms |  3.588 ms | 436.63 |     - |     - |     - |  13.77 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2.298 ms | 0.2843 ms | 0.1476 ms | 1.860 ms |  3.208 ms | 435.15 |     - |     - |     - |  13.77 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2.299 ms | 0.2879 ms | 0.1494 ms | 1.932 ms |  3.288 ms | 434.92 |     - |     - |     - |  14.38 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |  2.304 ms | 0.3040 ms | 0.1522 ms | 1.902 ms |  3.262 ms | 433.98 |     - |     - |     - |  15.06 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |  2.308 ms | 0.3139 ms | 0.1609 ms | 1.868 ms |  2.968 ms | 433.29 |     - |     - |     - |  13.48 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  2.311 ms | 0.2789 ms | 0.1448 ms | 1.809 ms |  3.087 ms | 432.79 |     - |     - |     - |  13.52 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  2.322 ms | 0.3484 ms | 0.1765 ms | 1.756 ms |  3.216 ms | 430.66 |     - |     - |     - |   8.91 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |  2.354 ms | 0.4409 ms | 0.2234 ms | 1.859 ms |  3.576 ms | 424.77 |     - |     - |     - |   8.89 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |  2.356 ms | 0.3507 ms | 0.1777 ms | 1.894 ms |  3.511 ms | 424.49 |     - |     - |     - |  14.78 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  2.369 ms | 0.3211 ms | 0.1646 ms | 1.950 ms |  3.519 ms | 422.14 |     - |     - |     - |  15.51 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2.373 ms | 0.1735 ms | 0.0901 ms | 2.075 ms |  2.904 ms | 421.39 |     - |     - |     - |  14.81 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |  2.388 ms | 0.2974 ms | 0.1489 ms | 1.817 ms |  3.323 ms | 418.83 |     - |     - |     - |  14.05 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2.415 ms | 0.3391 ms | 0.1718 ms | 1.756 ms |  3.275 ms | 414.14 |     - |     - |     - |   8.91 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2.517 ms | 0.3404 ms | 0.1685 ms | 2.055 ms |  3.388 ms | 397.28 |     - |     - |     - |  13.88 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  4.943 ms | 0.7335 ms | 0.3673 ms | 4.075 ms |  7.061 ms | 202.29 |     - |     - |     - |  32.41 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  5.284 ms | 0.8576 ms | 0.4294 ms | 4.158 ms |  7.442 ms | 189.24 |     - |     - |     - |  32.41 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  5.321 ms | 0.8112 ms | 0.4159 ms | 4.379 ms |  7.600 ms | 187.93 |     - |     - |     - |  33.95 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  5.553 ms | 1.0328 ms | 0.5232 ms | 4.381 ms |  7.863 ms | 180.07 |     - |     - |     - |  33.95 KB |
|                                   |                       |           |           |           |          |           |        |       |       |       |           |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite |  8.666 ms | 4.5782 ms | 2.3473 ms | 2.923 ms | 18.261 ms | 115.39 |     - |     - |     - |   4.26 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite |  8.687 ms | 5.8133 ms | 3.0555 ms | 3.212 ms | 26.461 ms | 115.11 |     - |     - |     - |  14.69 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  8.700 ms | 5.3795 ms | 2.7253 ms | 2.824 ms | 27.528 ms | 114.94 |     - |     - |     - |   5.98 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 10.141 ms | 5.9326 ms | 3.1181 ms | 3.073 ms | 24.685 ms |  98.60 |     - |     - |     - |  16.13 KB |
