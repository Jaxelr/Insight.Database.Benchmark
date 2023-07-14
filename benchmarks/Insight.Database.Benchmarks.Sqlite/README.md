# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                            Method |                  Type |       Mean |      StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   239.2 μs |    32.24 μs |  16.33 μs |   231.0 μs |   189.0 μs |   333.2 μs | 4,180.3 |   9.55 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   248.8 μs |    30.40 μs |  15.22 μs |   241.2 μs |   203.2 μs |   307.7 μs | 4,019.8 |   9.55 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   265.1 μs |    56.41 μs |  28.58 μs |   247.4 μs |   202.2 μs |   452.6 μs | 3,772.3 |   9.55 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   279.5 μs |    41.33 μs |  21.45 μs |   270.2 μs |   222.4 μs |   418.4 μs | 3,577.7 |  10.68 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   288.3 μs |    57.55 μs |  28.49 μs |   270.4 μs |   214.1 μs |   473.9 μs | 3,469.1 |   9.55 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   289.6 μs |    51.36 μs |  26.33 μs |   290.6 μs |   208.8 μs |   482.5 μs | 3,452.5 |  10.17 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   291.4 μs |    42.34 μs |  21.71 μs |   290.8 μs |   223.3 μs |   396.3 μs | 3,431.3 |  10.05 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   291.8 μs |    52.23 μs |  27.11 μs |   285.8 μs |   202.3 μs |   441.1 μs | 3,426.8 |   9.86 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   292.1 μs |    51.25 μs |  25.96 μs |   277.5 μs |   234.4 μs |   439.5 μs | 3,424.0 |  10.05 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   292.7 μs |    48.76 μs |  26.31 μs |   277.6 μs |   220.8 μs |   402.1 μs | 3,416.5 |  10.17 KB |
|                            Single | InsightBenchmarkWrite |   295.8 μs |    75.60 μs |  37.86 μs |   280.9 μs |   199.9 μs |   509.6 μs | 3,380.7 |   9.74 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   305.9 μs |    70.36 μs |  35.64 μs |   286.2 μs |   225.9 μs |   528.2 μs | 3,269.1 |   9.98 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   306.8 μs |    42.01 μs |  21.81 μs |   302.9 μs |   238.7 μs |   404.1 μs | 3,259.6 |  11.18 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   309.5 μs |   100.10 μs |  50.71 μs |   263.3 μs |   216.1 μs |   609.2 μs | 3,230.7 |  10.68 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   312.8 μs |    53.74 μs |  27.55 μs |   313.1 μs |   228.0 μs |   476.6 μs | 3,197.1 |   9.86 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   316.6 μs |    70.46 μs |  35.28 μs |   313.3 μs |   209.5 μs |   480.2 μs | 3,158.3 |    9.7 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   320.3 μs |   102.27 μs |  52.43 μs |   270.1 μs |   228.2 μs |   585.6 μs | 3,121.6 |   9.98 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   323.7 μs |   102.95 μs |  53.43 μs |   276.8 μs |   210.8 μs |   610.1 μs | 3,089.4 |   9.73 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   324.8 μs |    53.01 μs |  26.85 μs |   324.1 μs |   241.1 μs |   457.3 μs | 3,078.4 |  10.05 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   328.6 μs |    70.92 μs |  36.81 μs |   299.3 μs |   249.6 μs |   509.9 μs | 3,042.8 |  11.23 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   331.2 μs |    92.78 μs |  48.16 μs |   303.6 μs |   217.1 μs |   582.9 μs | 3,019.2 |   9.86 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   342.1 μs |   105.94 μs |  53.67 μs |   304.1 μs |   239.6 μs |   612.5 μs | 2,923.0 |  10.05 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   342.4 μs |   104.32 μs |  53.49 μs |   298.6 μs |   220.9 μs |   578.0 μs | 2,920.5 |   9.86 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   344.2 μs |    76.20 μs |  40.05 μs |   336.9 μs |   249.7 μs |   598.6 μs | 2,905.2 |  11.23 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   369.1 μs |    97.77 μs |  49.53 μs |   341.8 μs |   247.6 μs |   637.5 μs | 2,709.0 |   9.54 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   374.6 μs |   144.69 μs |  75.10 μs |   301.4 μs |   237.2 μs |   718.2 μs | 2,669.9 |  11.18 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   399.3 μs |    96.13 μs |  48.13 μs |   376.6 μs |   278.0 μs |   669.5 μs | 2,504.5 |   9.98 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   415.2 μs |   159.95 μs |  83.02 μs |   365.6 μs |   223.7 μs |   807.1 μs | 2,408.4 |   9.73 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   416.0 μs |   116.00 μs |  58.77 μs |   373.0 μs |   246.3 μs |   668.2 μs | 2,403.9 |   9.54 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   419.5 μs |   203.73 μs | 107.08 μs |   334.4 μs |   243.9 μs | 1,061.0 μs | 2,383.7 |   9.98 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   433.8 μs |   133.13 μs |  66.66 μs |   381.6 μs |   261.4 μs |   701.9 μs | 2,305.2 |   9.98 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   434.7 μs |   139.93 μs |  73.55 μs |   410.1 μs |   244.7 μs |   750.0 μs | 2,300.3 |  10.73 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   436.7 μs |    87.03 μs |  43.09 μs |   409.1 μs |   312.2 μs |   659.0 μs | 2,289.8 |   9.98 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   445.7 μs |   160.13 μs |  80.18 μs |   418.1 μs |   215.3 μs |   730.7 μs | 2,243.5 |   9.54 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   446.3 μs |   138.99 μs |  68.80 μs |   425.6 μs |   247.3 μs |   861.9 μs | 2,240.9 |   9.54 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   462.8 μs |   175.84 μs |  88.05 μs |   427.0 μs |   224.3 μs |   927.3 μs | 2,160.6 |   9.98 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   465.4 μs |   165.23 μs |  86.84 μs |   402.9 μs |   247.7 μs |   742.0 μs | 2,148.7 |  10.17 KB |
|                            Single |      InsightBenchmark |   474.2 μs |    91.80 μs |  46.51 μs |   469.4 μs |   329.3 μs |   754.8 μs | 2,108.6 |   9.74 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   556.8 μs |   112.73 μs |  57.11 μs |   532.5 μs |   370.8 μs |   798.9 μs | 1,795.9 |  10.73 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   601.1 μs |   143.62 μs |  72.76 μs |   561.8 μs |   426.2 μs |   948.6 μs | 1,663.6 |  10.17 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4,877.9 μs |   248.47 μs | 127.39 μs | 4,846.7 μs | 4,476.4 μs | 5,382.3 μs |   205.0 |  24.79 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5,046.7 μs |   522.65 μs | 267.96 μs | 5,030.9 μs | 4,170.1 μs | 6,076.5 μs |   198.1 |  23.88 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 5,486.1 μs | 1,268.27 μs | 666.60 μs | 4,873.7 μs | 4,462.4 μs | 8,858.1 μs |   182.3 |  24.79 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 5,756.5 μs | 1,027.17 μs | 514.33 μs | 5,431.6 μs | 4,469.7 μs | 9,131.9 μs |   173.7 |  23.88 KB |
|                                   |                       |            |             |           |            |            |            |         |           |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,039.2 μs |   427.64 μs | 219.26 μs | 3,977.4 μs | 3,313.1 μs | 5,052.1 μs |   247.6 |   9.74 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 4,476.9 μs |   376.03 μs | 192.80 μs | 4,525.6 μs | 3,398.8 μs | 5,360.5 μs |   223.4 |   8.47 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 4,678.8 μs |   390.39 μs | 193.26 μs | 4,665.6 μs | 4,000.8 μs | 5,683.3 μs |   213.7 |   8.21 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 5,161.6 μs | 1,076.15 μs | 551.75 μs | 4,712.9 μs | 3,701.8 μs | 7,267.7 μs |   193.7 |   9.51 KB |
