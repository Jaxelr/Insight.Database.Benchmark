# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                            Method |                  Type |     Mean |    StdDev |     Error |   Median |      Min |      Max |  Op/s | Allocated |
|---------------------------------- |---------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------:|----------:|
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1.362 ms | 0.1840 ms | 0.0932 ms | 1.331 ms | 1.004 ms | 1.880 ms | 734.0 |   9.51 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1.423 ms | 0.1849 ms | 0.0937 ms | 1.392 ms | 1.100 ms | 1.938 ms | 702.5 |   9.51 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1.427 ms | 0.1676 ms | 0.0830 ms | 1.431 ms | 1.105 ms | 1.801 ms | 700.7 |   9.51 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1.434 ms | 0.1682 ms | 0.0842 ms | 1.417 ms | 1.170 ms | 2.011 ms | 697.2 |    9.2 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1.443 ms | 0.2047 ms | 0.1014 ms | 1.422 ms | 1.130 ms | 2.016 ms | 692.9 |    9.2 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1.508 ms | 0.1926 ms | 0.0964 ms | 1.567 ms | 1.026 ms | 1.783 ms | 663.1 |  13.64 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1.521 ms | 0.2789 ms | 0.1413 ms | 1.475 ms | 1.121 ms | 2.228 ms | 657.3 |    9.2 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1.540 ms | 0.1850 ms | 0.0926 ms | 1.523 ms | 1.157 ms | 1.980 ms | 649.2 |    9.2 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1.557 ms | 0.2867 ms | 0.1470 ms | 1.457 ms | 1.193 ms | 2.133 ms | 642.3 |  13.64 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1.570 ms | 0.2159 ms | 0.1081 ms | 1.553 ms | 1.091 ms | 1.991 ms | 637.0 |   13.5 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1.580 ms | 0.1831 ms | 0.0917 ms | 1.532 ms | 1.256 ms | 1.969 ms | 633.0 |  10.84 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1.583 ms | 0.2430 ms | 0.1203 ms | 1.576 ms | 1.123 ms | 2.028 ms | 631.9 |   9.22 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1.588 ms | 0.2338 ms | 0.1171 ms | 1.585 ms | 1.152 ms | 2.102 ms | 629.8 |   9.22 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1.623 ms | 0.2715 ms | 0.1375 ms | 1.580 ms | 1.239 ms | 2.436 ms | 616.3 |  39.02 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1.650 ms | 0.1594 ms | 0.0807 ms | 1.636 ms | 1.352 ms | 2.041 ms | 606.0 |     39 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1.656 ms | 0.2500 ms | 0.1282 ms | 1.669 ms | 1.248 ms | 2.231 ms | 603.8 |  11.49 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 1.657 ms | 0.1970 ms | 0.0975 ms | 1.662 ms | 1.167 ms | 2.118 ms | 603.4 |  31.78 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 1.664 ms | 0.2586 ms | 0.1295 ms | 1.615 ms | 1.238 ms | 2.316 ms | 601.0 |  13.59 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 1.670 ms | 0.2022 ms | 0.1001 ms | 1.642 ms | 1.336 ms | 2.128 ms | 598.8 |  14.98 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1.696 ms | 0.3239 ms | 0.1661 ms | 1.610 ms | 1.267 ms | 2.501 ms | 589.8 |   13.5 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1.701 ms | 0.2348 ms | 0.1162 ms | 1.690 ms | 1.188 ms | 2.514 ms | 588.0 |  11.15 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1.706 ms | 0.1535 ms | 0.0769 ms | 1.713 ms | 1.420 ms | 2.022 ms | 586.3 |  10.84 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1.726 ms | 0.1914 ms | 0.0959 ms | 1.738 ms | 1.336 ms | 2.124 ms | 579.3 |   9.22 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.727 ms | 0.2331 ms | 0.1154 ms | 1.723 ms | 1.241 ms | 2.257 ms | 578.9 |  40.67 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1.758 ms | 0.1820 ms | 0.0945 ms | 1.729 ms | 1.474 ms | 2.165 ms | 568.8 |  15.01 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1.794 ms | 0.3627 ms | 0.1795 ms | 1.697 ms | 1.244 ms | 2.709 ms | 557.5 |  13.64 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 1.794 ms | 0.2526 ms | 0.1250 ms | 1.786 ms | 1.223 ms | 2.288 ms | 557.3 |  40.91 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1.797 ms | 0.2890 ms | 0.1500 ms | 1.720 ms | 1.304 ms | 2.461 ms | 556.4 |   9.22 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1.798 ms | 0.3625 ms | 0.1815 ms | 1.695 ms | 1.342 ms | 2.788 ms | 556.3 |  11.49 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1.799 ms | 0.3806 ms | 0.1928 ms | 1.640 ms | 1.332 ms | 2.597 ms | 555.8 |   9.79 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 1.831 ms | 0.5822 ms | 0.2882 ms | 1.577 ms | 1.200 ms | 3.302 ms | 546.1 |  13.35 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1.837 ms | 0.6914 ms | 0.3503 ms | 1.579 ms | 1.112 ms | 3.772 ms | 544.3 |  13.64 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1.847 ms | 0.2221 ms | 0.1125 ms | 1.834 ms | 1.458 ms | 2.381 ms | 541.4 |  11.49 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 1.857 ms | 0.1849 ms | 0.0948 ms | 1.835 ms | 1.510 ms | 2.201 ms | 538.6 |  31.78 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1.861 ms | 0.3341 ms | 0.1693 ms | 1.799 ms | 1.389 ms | 2.560 ms | 537.5 |  13.59 KB |
|                            Single |      InsightBenchmark | 1.890 ms | 0.2323 ms | 0.1163 ms | 1.880 ms | 1.368 ms | 2.406 ms | 529.0 |  13.34 KB |
|                            Single | InsightBenchmarkWrite | 2.018 ms | 0.3555 ms | 0.1845 ms | 1.942 ms | 1.509 ms | 3.003 ms | 495.6 |  13.34 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.052 ms | 0.7820 ms | 0.3962 ms | 1.762 ms | 1.278 ms | 4.130 ms | 487.2 |  10.84 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 2.059 ms | 0.5171 ms | 0.2620 ms | 1.895 ms | 1.394 ms | 3.330 ms | 485.7 |  10.84 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 2.188 ms | 0.2713 ms | 0.1391 ms | 2.213 ms | 1.643 ms | 2.707 ms | 456.9 |  33.35 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 2.192 ms | 0.1672 ms | 0.0837 ms | 2.171 ms | 1.910 ms | 2.658 ms | 456.2 |  33.35 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 2.205 ms | 0.6206 ms | 0.3108 ms | 1.946 ms | 1.383 ms | 3.805 ms | 453.4 |  15.53 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.324 ms | 0.6794 ms | 0.3402 ms | 2.077 ms | 1.543 ms | 3.899 ms | 430.3 |  15.26 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 2.421 ms | 0.7311 ms | 0.3704 ms | 2.001 ms | 1.515 ms | 3.621 ms | 413.0 |  15.25 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 2.484 ms | 0.8939 ms | 0.4425 ms | 2.195 ms | 1.497 ms | 5.013 ms | 402.5 |  13.35 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.511 ms | 0.9027 ms | 0.4520 ms | 2.095 ms | 1.446 ms | 5.138 ms | 398.2 |  15.01 KB |
|                                   |                       |          |           |           |          |          |          |       |           |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 2.743 ms | 0.3242 ms | 0.1662 ms | 2.734 ms | 2.227 ms | 3.576 ms | 364.6 |   4.66 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 2.814 ms | 0.2423 ms | 0.1258 ms | 2.801 ms | 2.449 ms | 3.511 ms | 355.3 |   14.7 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.891 ms | 0.2756 ms | 0.1380 ms | 2.917 ms | 2.291 ms | 3.525 ms | 345.9 |   6.42 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.987 ms | 0.2186 ms | 0.1107 ms | 2.986 ms | 2.516 ms | 3.544 ms | 334.8 |  16.47 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3.440 ms | 0.6403 ms | 0.3206 ms | 3.240 ms | 2.434 ms | 4.949 ms | 290.7 |   4.73 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4.076 ms | 1.4315 ms | 0.7252 ms | 3.577 ms | 2.630 ms | 8.312 ms | 245.3 |  10.82 KB |
