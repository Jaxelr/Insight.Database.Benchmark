# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.201
  [Host]   : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT

```

|                            Method |                  Type |     Mean |    StdDev |     Error |      Min |       Max |  Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |---------:|----------:|----------:|---------:|----------:|------:|------:|------:|------:|----------:|
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 2.012 ms | 0.2263 ms | 0.1901 ms | 1.758 ms |  2.554 ms | 496.9 |     - |     - |     - |   8.89 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 2.101 ms | 0.2525 ms | 0.2056 ms | 1.799 ms |  2.662 ms | 476.1 |     - |     - |     - |    9.2 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 2.105 ms | 0.1382 ms | 0.1200 ms | 1.896 ms |  2.397 ms | 475.1 |     - |     - |     - |   10.8 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 2.110 ms | 0.2710 ms | 0.2030 ms | 1.821 ms |  2.907 ms | 473.9 |     - |     - |     - |    9.2 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.127 ms | 0.3494 ms | 0.2845 ms | 1.847 ms |  3.498 ms | 470.2 |     - |     - |     - |  10.48 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 2.169 ms | 0.1057 ms | 0.0888 ms | 2.003 ms |  2.419 ms | 461.1 |     - |     - |     - |  13.52 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 2.208 ms | 0.1729 ms | 0.1367 ms | 1.812 ms |  2.706 ms | 453.0 |     - |     - |     - |  13.49 KB |
|                            Single | InsightBenchmarkWrite | 2.212 ms | 0.3468 ms | 0.2824 ms | 1.841 ms |  3.105 ms | 452.1 |     - |     - |     - |  13.75 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 2.236 ms | 0.2645 ms | 0.2154 ms | 1.946 ms |  3.077 ms | 447.2 |     - |     - |     - |  13.77 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 2.244 ms | 0.3347 ms | 0.2725 ms | 1.856 ms |  3.170 ms | 445.6 |     - |     - |     - |    9.2 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 2.244 ms | 0.1968 ms | 0.1556 ms | 1.911 ms |  2.698 ms | 445.6 |     - |     - |     - |   13.6 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 2.250 ms | 0.3424 ms | 0.2788 ms | 1.889 ms |  3.096 ms | 444.5 |     - |     - |     - |   8.89 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 2.250 ms | 0.2157 ms | 0.1812 ms | 1.905 ms |  2.639 ms | 444.4 |     - |     - |     - |   9.92 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 2.265 ms | 0.2996 ms | 0.2517 ms | 1.922 ms |  3.036 ms | 441.5 |     - |     - |     - |   8.89 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 2.273 ms | 0.2357 ms | 0.1864 ms | 1.964 ms |  2.949 ms | 440.0 |     - |     - |     - |   9.47 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 2.281 ms | 0.3059 ms | 0.2419 ms | 1.964 ms |  3.197 ms | 438.4 |     - |     - |     - |  10.48 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.286 ms | 0.1936 ms | 0.1531 ms | 1.955 ms |  2.682 ms | 437.5 |     - |     - |     - |  10.23 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 2.286 ms | 0.3198 ms | 0.2604 ms | 1.947 ms |  2.921 ms | 437.5 |     - |     - |     - |   8.91 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 2.286 ms | 0.3645 ms | 0.2882 ms | 1.849 ms |  3.128 ms | 437.4 |     - |     - |     - |  13.77 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 2.294 ms | 0.2907 ms | 0.2367 ms | 1.842 ms |  2.831 ms | 436.0 |     - |     - |     - |    9.2 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 2.300 ms | 0.3872 ms | 0.3062 ms | 1.811 ms |  3.389 ms | 434.7 |     - |     - |     - |  14.05 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 2.316 ms | 0.3230 ms | 0.2484 ms | 1.921 ms |  3.208 ms | 431.8 |     - |     - |     - |   10.8 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 2.343 ms | 0.4231 ms | 0.3254 ms | 1.948 ms |  3.823 ms | 426.8 |     - |     - |     - |   8.89 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 2.353 ms | 0.3397 ms | 0.2766 ms | 1.890 ms |  3.107 ms | 425.0 |     - |     - |     - |  13.52 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 2.367 ms | 0.4244 ms | 0.3264 ms | 1.921 ms |  3.643 ms | 422.4 |     - |     - |     - |   8.91 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 2.378 ms | 0.2547 ms | 0.1959 ms | 2.033 ms |  2.919 ms | 420.5 |     - |     - |     - |  14.78 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 2.380 ms | 0.3483 ms | 0.2836 ms | 1.969 ms |  3.366 ms | 420.1 |     - |     - |     - |  13.48 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 2.388 ms | 0.3152 ms | 0.2361 ms | 2.024 ms |  3.292 ms | 418.7 |     - |     - |     - |  13.77 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 2.389 ms | 0.2188 ms | 0.1683 ms | 1.991 ms |  2.726 ms | 418.6 |     - |     - |     - |  10.52 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 2.396 ms | 0.3385 ms | 0.2603 ms | 1.871 ms |  3.314 ms | 417.3 |     - |     - |     - |  10.48 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.397 ms | 0.3766 ms | 0.3163 ms | 1.977 ms |  3.565 ms | 417.3 |     - |     - |     - |  15.51 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 2.436 ms | 0.3696 ms | 0.3010 ms | 2.046 ms |  3.414 ms | 410.5 |     - |     - |     - |   8.91 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 2.444 ms | 0.3003 ms | 0.2309 ms | 2.131 ms |  3.349 ms | 409.2 |     - |     - |     - |  15.06 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 2.446 ms | 0.3034 ms | 0.2334 ms | 2.077 ms |  3.211 ms | 408.8 |     - |     - |     - |  14.53 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.457 ms | 0.3420 ms | 0.2704 ms | 2.079 ms |  3.429 ms | 407.1 |     - |     - |     - |  14.25 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.490 ms | 0.3921 ms | 0.3101 ms | 2.099 ms |  3.501 ms | 401.7 |     - |     - |     - |  14.95 KB |
|                            Single |      InsightBenchmark | 2.499 ms | 0.4092 ms | 0.3332 ms | 2.020 ms |  3.638 ms | 400.2 |     - |     - |     - |  13.75 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 2.556 ms | 0.3277 ms | 0.2520 ms | 2.110 ms |  3.443 ms | 391.2 |     - |     - |     - |   13.6 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 4.940 ms | 0.4743 ms | 0.3750 ms | 4.298 ms |  5.845 ms | 202.4 |     - |     - |     - |  32.41 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 5.029 ms | 0.5318 ms | 0.4467 ms | 4.540 ms |  6.694 ms | 198.9 |     - |     - |     - |  33.95 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 5.223 ms | 0.6474 ms | 0.4979 ms | 4.339 ms |  6.698 ms | 191.5 |     - |     - |     - |  33.95 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5.305 ms | 0.8781 ms | 0.6753 ms | 4.138 ms |  7.136 ms | 188.5 |     - |     - |     - |  32.13 KB |
|                                   |                       |          |           |           |          |           |       |       |       |       |           |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 8.310 ms | 3.8086 ms | 3.0115 ms | 3.325 ms | 15.756 ms | 120.3 |     - |     - |     - |  16.13 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 8.711 ms | 5.1516 ms | 3.8590 ms | 2.817 ms | 20.522 ms | 114.8 |     - |     - |     - |   4.54 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 9.146 ms | 6.2484 ms | 4.9407 ms | 2.930 ms | 24.526 ms | 109.3 |     - |     - |     - |    5.7 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 9.620 ms | 6.2050 ms | 4.7721 ms | 3.548 ms | 28.562 ms | 103.9 |     - |     - |     - |  14.69 KB |
