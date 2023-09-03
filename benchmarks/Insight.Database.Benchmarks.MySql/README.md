# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                                    Method |                  Type |     Mean |    StdDev |     Error |   Median |      Min |       Max |  Op/s | Allocated |
|------------------------------------------ |---------------------- |---------:|----------:|----------:|---------:|---------:|----------:|------:|----------:|
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1.706 ms | 0.2155 ms | 0.1079 ms | 1.668 ms | 1.128 ms |  2.164 ms | 586.1 |  44.61 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1.792 ms | 0.3099 ms | 0.1552 ms | 1.830 ms | 1.180 ms |  2.463 ms | 558.1 |   18.8 KB |
|                                    Single | InsightBenchmarkWrite | 1.819 ms | 0.3299 ms | 0.1633 ms | 1.793 ms | 1.179 ms |  2.652 ms | 549.7 |  18.38 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1.826 ms | 0.2318 ms | 0.1161 ms | 1.835 ms | 1.305 ms |  2.374 ms | 547.6 |  45.04 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 2.025 ms | 0.9269 ms | 0.4641 ms | 1.651 ms | 1.333 ms |  4.601 ms | 493.8 |  21.03 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2.086 ms | 0.9000 ms | 0.4456 ms | 1.704 ms | 1.210 ms |  4.164 ms | 479.3 |  44.59 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 2.236 ms | 0.8439 ms | 0.4226 ms | 1.859 ms | 1.516 ms |  4.734 ms | 447.2 |  45.04 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 2.352 ms | 0.4338 ms | 0.2147 ms | 2.250 ms | 1.548 ms |  3.542 ms | 425.1 |  18.68 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.379 ms | 0.2182 ms | 0.1093 ms | 2.362 ms | 1.950 ms |  2.984 ms | 420.4 |   18.5 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 2.416 ms | 0.2121 ms | 0.1075 ms | 2.458 ms | 1.908 ms |  2.811 ms | 413.8 |  20.63 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 2.469 ms | 0.2568 ms | 0.1271 ms | 2.483 ms | 1.970 ms |  3.140 ms | 405.1 |  18.45 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 2.597 ms | 0.8519 ms | 0.4266 ms | 2.358 ms | 1.666 ms |  4.744 ms | 385.1 |  18.65 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 2.642 ms | 0.9089 ms | 0.4604 ms | 3.027 ms | 1.278 ms |  4.083 ms | 378.5 |  18.34 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 2.677 ms | 0.8700 ms | 0.4307 ms | 2.307 ms | 1.614 ms |  4.298 ms | 373.6 |  20.62 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 2.694 ms | 0.7358 ms | 0.3684 ms | 2.391 ms | 1.811 ms |  4.819 ms | 371.2 |  18.65 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 2.724 ms | 0.4887 ms | 0.2447 ms | 2.763 ms | 1.886 ms |  3.604 ms | 367.1 |  18.36 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.751 ms | 0.3438 ms | 0.1785 ms | 2.662 ms | 2.183 ms |  3.581 ms | 363.5 |  21.03 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 2.767 ms | 0.6579 ms | 0.3294 ms | 2.495 ms | 1.870 ms |  4.473 ms | 361.4 |  21.03 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 2.776 ms | 0.7089 ms | 0.3550 ms | 2.509 ms | 2.204 ms |  5.001 ms | 360.2 |  18.77 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2.867 ms | 0.5700 ms | 0.2854 ms | 2.667 ms | 2.248 ms |  4.448 ms | 348.8 |   18.8 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 3.084 ms | 0.9816 ms | 0.4915 ms | 2.532 ms | 1.840 ms |  4.652 ms | 324.3 |  21.06 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 3.178 ms | 0.5069 ms | 0.2538 ms | 3.291 ms | 2.304 ms |  4.200 ms | 314.6 |  19.26 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 3.218 ms | 1.0161 ms | 0.5088 ms | 3.049 ms | 1.928 ms |  5.104 ms | 310.8 |  20.59 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 3.244 ms | 0.9896 ms | 0.4955 ms | 3.443 ms | 1.905 ms |  4.671 ms | 308.3 |  18.34 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 3.260 ms | 0.5662 ms | 0.2869 ms | 3.274 ms | 2.352 ms |  4.579 ms | 306.8 |  18.68 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 3.264 ms | 1.0772 ms | 0.5394 ms | 2.717 ms | 2.070 ms |  5.608 ms | 306.4 |  21.03 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 3.337 ms | 0.6842 ms | 0.3387 ms | 3.492 ms | 2.074 ms |  4.935 ms | 299.7 |  18.68 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 3.343 ms | 1.2832 ms | 0.6579 ms | 3.491 ms | 1.298 ms |  5.992 ms | 299.2 |  18.68 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 3.365 ms | 0.5712 ms | 0.2828 ms | 3.394 ms | 2.319 ms |  4.540 ms | 297.2 |  21.06 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 3.466 ms | 0.5899 ms | 0.2920 ms | 3.521 ms | 2.207 ms |  4.509 ms | 288.5 |  17.95 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 3.479 ms | 0.8633 ms | 0.4274 ms | 3.308 ms | 2.171 ms |  5.667 ms | 287.4 |  18.77 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 3.508 ms | 0.6985 ms | 0.3497 ms | 3.669 ms | 2.129 ms |  4.739 ms | 285.0 |   20.6 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 3.556 ms | 0.6653 ms | 0.3331 ms | 3.466 ms | 2.662 ms |  6.016 ms | 281.2 |  18.33 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 3.581 ms | 0.3490 ms | 0.1747 ms | 3.576 ms | 2.905 ms |  4.285 ms | 279.2 |  18.77 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite | 3.595 ms | 0.9612 ms | 0.4870 ms | 3.803 ms | 1.585 ms |  4.982 ms | 278.2 |  20.59 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 3.604 ms | 0.4275 ms | 0.2116 ms | 3.512 ms | 2.776 ms |  4.649 ms | 277.4 |  18.65 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 3.621 ms | 0.4147 ms | 0.2076 ms | 3.655 ms | 2.789 ms |  4.884 ms | 276.1 |  21.03 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 3.659 ms | 0.3368 ms | 0.1748 ms | 3.685 ms | 2.898 ms |  4.467 ms | 273.3 |  18.36 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 3.670 ms | 0.7030 ms | 0.3562 ms | 3.756 ms | 2.155 ms |  4.880 ms | 272.5 |  18.01 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 3.683 ms | 0.5479 ms | 0.2744 ms | 3.680 ms | 2.652 ms |  4.959 ms | 271.5 |   20.6 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 3.706 ms | 0.4236 ms | 0.2097 ms | 3.705 ms | 2.806 ms |  4.572 ms | 269.8 |  18.33 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 3.707 ms | 0.3651 ms | 0.1828 ms | 3.704 ms | 3.062 ms |  4.494 ms | 269.8 |  18.34 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 3.730 ms | 0.3631 ms | 0.1818 ms | 3.715 ms | 3.064 ms |  4.533 ms | 268.1 |  18.33 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 3.806 ms | 0.5775 ms | 0.2891 ms | 3.965 ms | 2.495 ms |  4.788 ms | 262.8 |  20.59 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 3.818 ms | 0.3972 ms | 0.1966 ms | 3.774 ms | 3.161 ms |  4.617 ms | 261.9 |   18.5 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 3.838 ms | 0.4918 ms | 0.2463 ms | 3.769 ms | 2.880 ms |  5.327 ms | 260.5 |  18.77 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 3.853 ms | 0.4092 ms | 0.2049 ms | 3.757 ms | 3.220 ms |  4.771 ms | 259.5 |   20.6 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 3.866 ms | 0.4398 ms | 0.2228 ms | 3.909 ms | 2.722 ms |  4.663 ms | 258.7 |  19.02 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 3.911 ms | 1.3445 ms | 0.6732 ms | 4.656 ms | 1.994 ms |  5.754 ms | 255.7 |  18.33 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 4.023 ms | 0.4987 ms | 0.2497 ms | 3.984 ms | 3.189 ms |  4.882 ms | 248.5 |  18.77 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 4.028 ms | 0.5090 ms | 0.2549 ms | 4.081 ms | 3.112 ms |  5.011 ms | 248.2 |  17.95 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 4.036 ms | 0.5365 ms | 0.2686 ms | 3.978 ms | 3.174 ms |  5.173 ms | 247.8 |  21.03 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 4.036 ms | 0.3943 ms | 0.1974 ms | 3.903 ms | 3.314 ms |  4.905 ms | 247.8 |  18.77 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 4.061 ms | 0.6924 ms | 0.3550 ms | 3.888 ms | 3.061 ms |  5.753 ms | 246.3 |  18.77 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 4.095 ms | 0.3906 ms | 0.2002 ms | 4.104 ms | 3.187 ms |  4.833 ms | 244.2 |  18.77 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 4.098 ms | 0.5696 ms | 0.2852 ms | 4.158 ms | 2.752 ms |  5.482 ms | 244.0 |   20.6 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 4.146 ms | 0.5001 ms | 0.2476 ms | 4.098 ms | 2.989 ms |  5.356 ms | 241.2 |  21.06 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 4.155 ms | 0.4586 ms | 0.2323 ms | 4.155 ms | 3.297 ms |  5.150 ms | 240.7 |  18.01 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 4.169 ms | 0.5737 ms | 0.2840 ms | 4.064 ms | 3.197 ms |  5.536 ms | 239.8 |  20.62 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 4.175 ms | 0.4656 ms | 0.2359 ms | 4.066 ms | 3.449 ms |  5.296 ms | 239.5 |   18.8 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 4.265 ms | 0.7939 ms | 0.4070 ms | 4.176 ms | 2.931 ms |  6.225 ms | 234.5 |  21.03 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 4.301 ms | 0.7309 ms | 0.3660 ms | 4.328 ms | 3.145 ms |  5.753 ms | 232.5 |  20.59 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 4.372 ms | 0.6600 ms | 0.3384 ms | 4.216 ms | 3.191 ms |  6.486 ms | 228.7 |   18.8 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 4.385 ms | 0.6061 ms | 0.3071 ms | 4.444 ms | 3.208 ms |  5.421 ms | 228.0 |  21.03 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 4.414 ms | 0.6436 ms | 0.3300 ms | 4.436 ms | 2.874 ms |  5.527 ms | 226.5 |  20.63 KB |
|                                    Single |      InsightBenchmark | 4.498 ms | 0.4897 ms | 0.2511 ms | 4.544 ms | 3.488 ms |  5.926 ms | 222.3 |  18.38 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 4.676 ms | 0.7028 ms | 0.3604 ms | 4.533 ms | 3.457 ms |  6.277 ms | 213.9 |  21.06 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 4.835 ms | 0.4184 ms | 0.2145 ms | 4.802 ms | 3.778 ms |  5.816 ms | 206.8 |  18.34 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 4.853 ms | 0.3842 ms | 0.2019 ms | 4.755 ms | 4.289 ms |  5.799 ms | 206.1 |  40.14 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5.795 ms | 1.8638 ms | 0.9556 ms | 4.956 ms | 4.468 ms | 11.995 ms | 172.6 |  39.68 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 8.045 ms | 0.8746 ms | 0.4597 ms | 7.848 ms | 6.851 ms | 10.135 ms | 124.3 |   39.4 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 8.078 ms | 3.0595 ms | 1.5686 ms | 7.590 ms | 4.202 ms | 14.600 ms | 123.8 |  40.14 KB |
|                                           |                       |          |           |           |          |          |           |       |           |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4.779 ms | 1.4182 ms | 0.7101 ms | 4.441 ms | 2.325 ms |  6.935 ms | 209.2 |  31.41 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 6.155 ms | 2.4437 ms | 1.2097 ms | 5.886 ms | 2.442 ms | 10.501 ms | 162.5 |  32.53 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 6.218 ms | 1.5561 ms | 0.7792 ms | 5.861 ms | 3.462 ms |  9.655 ms | 160.8 |  21.02 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 6.367 ms | 1.1270 ms | 0.5579 ms | 6.479 ms | 3.427 ms |  7.912 ms | 157.1 |  21.34 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 6.379 ms | 1.1819 ms | 0.5918 ms | 6.486 ms | 3.671 ms |  9.105 ms | 156.8 |  22.44 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 7.098 ms | 3.1259 ms | 1.5836 ms | 6.057 ms | 3.718 ms | 16.391 ms | 140.9 |  21.88 KB |
