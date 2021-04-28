# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]   : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  ShortRun : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

Type=InsightBenchmark  

```
|                                    Method |     Mean |    StdDev |     Error |      Min |       Max |  Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------:|----------:|----------:|---------:|----------:|------:|------:|------:|------:|----------:|
|         &#39;Single Procedure (Fast Expando)&#39; | 2.810 ms | 0.3039 ms | 0.1504 ms | 2.290 ms |  3.699 ms | 355.9 |     - |     - |     - |  16.49 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | 2.838 ms | 0.2811 ms | 0.1408 ms | 2.381 ms |  3.441 ms | 352.4 |     - |     - |     - |  16.52 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | 2.845 ms | 0.3994 ms | 0.2048 ms | 2.106 ms |  3.757 ms | 351.5 |     - |     - |     - |   14.1 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | 2.878 ms | 0.3092 ms | 0.1531 ms | 2.335 ms |  3.655 ms | 347.5 |     - |     - |     - |  14.02 KB |
|                            Query&lt;(Tuple)&gt; | 2.882 ms | 0.2752 ms | 0.1394 ms | 2.323 ms |  3.470 ms | 347.0 |     - |     - |     - |  14.84 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | 2.906 ms | 0.3094 ms | 0.1567 ms | 2.467 ms |  3.831 ms | 344.1 |     - |     - |     - |  16.48 KB |
|                                  Query&lt;T&gt; | 2.931 ms | 0.3619 ms | 0.1902 ms | 2.419 ms |  4.130 ms | 341.2 |     - |     - |     - |   14.3 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | 2.971 ms | 0.3425 ms | 0.1778 ms | 2.393 ms |  3.974 ms | 336.6 |     - |     - |     - |  16.63 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | 2.986 ms | 0.4277 ms | 0.2220 ms | 2.392 ms |  4.823 ms | 334.9 |     - |     - |     - |  14.27 KB |
|                  &#39;Single Procedure Async&#39; | 2.989 ms | 0.4374 ms | 0.2242 ms | 2.416 ms |  4.008 ms | 334.6 |     - |     - |     - |  16.91 KB |
|                  &#39;Single Async (dynamic)&#39; | 2.992 ms | 0.3531 ms | 0.1811 ms | 2.362 ms |  3.986 ms | 334.2 |     - |     - |     - |  14.66 KB |
|                        &#39;Single Procedure&#39; | 3.016 ms | 0.3616 ms | 0.1877 ms | 2.273 ms |  4.025 ms | 331.5 |     - |     - |     - |  16.53 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | 3.031 ms | 0.3278 ms | 0.1641 ms | 2.434 ms |  4.068 ms | 329.9 |     - |     - |     - |  16.88 KB |
|                   &#39;Auto Interface Single&#39; | 3.038 ms | 0.4484 ms | 0.2299 ms | 2.445 ms |  4.226 ms | 329.1 |     - |     - |     - |  14.63 KB |
|              &#39;Single Procedure (dynamic)&#39; | 3.041 ms | 0.3286 ms | 0.1705 ms | 2.463 ms |  3.991 ms | 328.9 |     - |     - |     - |  16.49 KB |
|                    &#39;Single Async (Tuple)&#39; | 3.047 ms | 0.3460 ms | 0.1842 ms | 2.441 ms |  3.987 ms | 328.2 |     - |     - |     - |     15 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | 3.052 ms | 0.3220 ms | 0.1594 ms | 2.393 ms |  3.717 ms | 327.7 |     - |     - |     - |  16.88 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | 3.053 ms | 0.4574 ms | 0.2264 ms | 2.346 ms |  4.624 ms | 327.5 |     - |     - |     - |  16.48 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | 3.055 ms | 0.4305 ms | 0.2181 ms | 2.366 ms |  4.185 ms | 327.3 |     - |     - |     - |  14.66 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | 3.068 ms | 0.7099 ms | 0.3685 ms | 2.320 ms |  5.708 ms | 325.9 |     - |     - |     - |  14.27 KB |
|                        &#39;Single (dynamic)&#39; | 3.079 ms | 0.3946 ms | 0.2048 ms | 2.386 ms |  4.268 ms | 324.8 |     - |     - |     - |  14.28 KB |
|             &#39;Single Async (Fast Expando)&#39; | 3.083 ms | 0.4064 ms | 0.2084 ms | 2.371 ms |  4.274 ms | 324.4 |     - |     - |     - |  14.66 KB |
|                            &#39;Single Async&#39; | 3.106 ms | 0.5088 ms | 0.2519 ms | 2.441 ms |  4.837 ms | 322.0 |     - |     - |     - |   14.7 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | 3.121 ms | 0.5376 ms | 0.2790 ms | 2.565 ms |  5.030 ms | 320.4 |     - |     - |     - |  16.88 KB |
|                                    Single | 3.147 ms | 0.5229 ms | 0.2681 ms | 2.462 ms |  4.696 ms | 317.7 |     - |     - |     - |  14.32 KB |
|                   &#39;Single (Fast Expando)&#39; | 3.151 ms | 0.5339 ms | 0.2737 ms | 2.414 ms |  4.322 ms | 317.4 |     - |     - |     - |  14.28 KB |
|                    &#39;Single Async (Tuple)&#39; | 3.162 ms | 0.5029 ms | 0.2578 ms | 2.426 ms |  4.514 ms | 316.2 |     - |     - |     - |  15.23 KB |
|                    &#39;Auto Interface Query&#39; | 3.164 ms | 0.6970 ms | 0.3490 ms | 2.315 ms |  5.704 ms | 316.0 |     - |     - |     - |  14.63 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | 3.166 ms | 0.5510 ms | 0.2825 ms | 2.416 ms |  4.625 ms | 315.9 |     - |     - |     - |   14.7 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | 3.187 ms | 0.5563 ms | 0.2852 ms | 2.442 ms |  5.261 ms | 313.8 |     - |     - |     - |   14.3 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | 3.294 ms | 0.6163 ms | 0.3086 ms | 2.526 ms |  4.665 ms | 303.6 |     - |     - |     - |  16.88 KB |
|                          &#39;Single (Tuple)&#39; | 3.366 ms | 0.6806 ms | 0.3489 ms | 2.616 ms |  5.428 ms | 297.1 |     - |     - |     - |  14.78 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | 6.181 ms | 0.8647 ms | 0.4488 ms | 4.960 ms |  8.234 ms | 161.8 |     - |     - |     - |  32.13 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | 7.581 ms | 1.1940 ms | 0.6049 ms | 5.695 ms | 12.186 ms | 131.9 |     - |     - |     - |  32.54 KB |
