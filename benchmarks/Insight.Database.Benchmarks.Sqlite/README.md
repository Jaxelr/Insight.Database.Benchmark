# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                            Method |                  Type |       Mean |      StdDev |     Error |     Median |        Min |         Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|----------:|-----------:|-----------:|------------:|--------:|----------:|
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   267.0 μs |    41.40 μs |  21.76 μs |   259.5 μs |   201.9 μs |    370.6 μs | 3,745.9 |   9.55 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   267.5 μs |    30.89 μs |  16.03 μs |   267.9 μs |   202.6 μs |    352.6 μs | 3,738.0 |   9.54 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   272.2 μs |    35.11 μs |  17.58 μs |   260.9 μs |   225.3 μs |    388.9 μs | 3,674.1 |  10.05 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   273.9 μs |    22.99 μs |  11.93 μs |   271.3 μs |   240.9 μs |    347.8 μs | 3,651.5 |   9.86 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   277.5 μs |    28.68 μs |  14.88 μs |   280.1 μs |   213.2 μs |    352.7 μs | 3,603.4 |   9.98 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   285.8 μs |    53.60 μs |  27.15 μs |   277.0 μs |   201.0 μs |    428.4 μs | 3,498.7 |   9.55 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   294.3 μs |    35.91 μs |  18.87 μs |   290.1 μs |   241.3 μs |    443.0 μs | 3,397.9 |   9.98 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   297.9 μs |    68.23 μs |  34.56 μs |   274.2 μs |   221.4 μs |    514.6 μs | 3,356.7 |   9.86 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   298.2 μs |    43.43 μs |  22.00 μs |   291.7 μs |   231.5 μs |    395.7 μs | 3,353.1 |  10.05 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   301.1 μs |    27.70 μs |  14.38 μs |   295.8 μs |   251.9 μs |    384.2 μs | 3,320.9 |  10.17 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   305.4 μs |    41.30 μs |  20.68 μs |   295.2 μs |   251.7 μs |    445.5 μs | 3,273.9 |   9.98 KB |
|                            Single | InsightBenchmarkWrite |   306.6 μs |    53.79 μs |  26.93 μs |   299.5 μs |   228.0 μs |    422.6 μs | 3,261.1 |   9.74 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   310.6 μs |    79.33 μs |  40.68 μs |   278.7 μs |   231.6 μs |    529.5 μs | 3,219.7 |  10.17 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   311.8 μs |    49.14 μs |  25.83 μs |   306.6 μs |   228.8 μs |    420.1 μs | 3,207.5 |   9.86 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   321.5 μs |    53.30 μs |  28.01 μs |   308.6 μs |   251.1 μs |    481.6 μs | 3,110.7 |  10.05 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   321.5 μs |    60.55 μs |  31.82 μs |   302.5 μs |   260.6 μs |    561.0 μs | 3,110.6 |   9.98 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   324.4 μs |    74.12 μs |  38.00 μs |   296.5 μs |   246.9 μs |    500.6 μs | 3,082.4 |   9.86 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   324.9 μs |    84.63 μs |  43.39 μs |   294.8 μs |   247.3 μs |    602.1 μs | 3,078.2 |   9.54 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   332.2 μs |    92.15 μs |  47.24 μs |   296.7 μs |   240.9 μs |    646.7 μs | 3,010.2 |  10.73 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   337.8 μs |   121.85 μs |  62.47 μs |   295.7 μs |   210.7 μs |    788.5 μs | 2,960.5 |  10.05 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   342.3 μs |    62.22 μs |  30.80 μs |   335.9 μs |   237.0 μs |    488.1 μs | 2,921.7 |  10.73 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   344.9 μs |   100.07 μs |  50.70 μs |   304.6 μs |   243.6 μs |    717.5 μs | 2,899.3 |   9.98 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   345.6 μs |    38.16 μs |  20.32 μs |   346.6 μs |   270.2 μs |    414.9 μs | 2,893.5 |  10.68 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   350.8 μs |    83.11 μs |  43.13 μs |   321.3 μs |   261.9 μs |    617.1 μs | 2,851.0 |   9.98 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   355.4 μs |    57.74 μs |  30.35 μs |   343.4 μs |   262.9 μs |    496.4 μs | 2,813.9 |  11.18 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   356.0 μs |   105.92 μs |  53.66 μs |   312.6 μs |   268.4 μs |    661.9 μs | 2,808.7 |  10.68 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   356.5 μs |    48.82 μs |  24.17 μs |   348.0 μs |   286.6 μs |    486.7 μs | 2,805.3 |  11.23 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   359.0 μs |    57.53 μs |  29.50 μs |   350.6 μs |   275.1 μs |    498.6 μs | 2,785.5 |   9.55 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   370.3 μs |   141.74 μs |  71.81 μs |   311.4 μs |   244.6 μs |    791.1 μs | 2,700.3 |   9.98 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   388.4 μs |   132.08 μs |  66.91 μs |   325.4 μs |   278.2 μs |    736.4 μs | 2,574.8 |   9.55 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   388.9 μs |   118.60 μs |  63.14 μs |   356.7 μs |   261.1 μs |    813.5 μs | 2,571.3 |   9.73 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   403.7 μs |   202.05 μs | 104.87 μs |   311.7 μs |   242.6 μs |    927.0 μs | 2,477.0 |   9.54 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   454.3 μs |   202.72 μs | 102.70 μs |   338.9 μs |   241.7 μs |    932.5 μs | 2,201.2 |   9.73 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   468.1 μs |   289.00 μs | 143.06 μs |   331.4 μs |   233.5 μs |  1,186.8 μs | 2,136.4 |   9.54 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   472.3 μs |   255.05 μs | 130.77 μs |   381.4 μs |   253.5 μs |  1,121.5 μs | 2,117.2 |   9.98 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   483.3 μs |   243.19 μs | 123.20 μs |   380.8 μs |   273.7 μs |  1,109.6 μs | 2,069.3 |  11.23 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   550.6 μs |   313.52 μs | 164.79 μs |   406.6 μs |   255.3 μs |  1,429.8 μs | 1,816.1 |  10.17 KB |
|                            Single |      InsightBenchmark |   564.6 μs |   186.75 μs |  92.45 μs |   508.6 μs |   375.0 μs |  1,023.4 μs | 1,771.1 |   9.74 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   670.6 μs |   259.81 μs | 133.21 μs |   647.3 μs |   277.8 μs |  1,160.0 μs | 1,491.2 |  10.17 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   704.8 μs |   344.20 μs | 176.47 μs |   702.3 μs |   285.4 μs |  1,325.8 μs | 1,418.8 |  11.18 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 4,922.6 μs |   329.18 μs | 168.77 μs | 4,923.4 μs | 4,364.6 μs |  6,095.5 μs |   203.1 |  23.88 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5,318.0 μs |   889.48 μs | 467.51 μs | 4,928.6 μs | 4,680.1 μs |  7,591.6 μs |   188.0 |  23.88 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 6,235.1 μs | 1,571.23 μs | 825.83 μs | 5,685.4 μs | 4,690.8 μs | 11,803.0 μs |   160.4 |  24.79 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 6,295.3 μs | 1,513.23 μs | 766.62 μs | 5,651.4 μs | 4,511.5 μs | 10,028.4 μs |   158.8 |  24.79 KB |
|                                   |                       |            |             |           |            |            |             |         |           |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 4,809.8 μs |   765.58 μs | 387.85 μs | 4,505.4 μs | 3,657.8 μs |  6,625.1 μs |   207.9 |   8.47 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 4,903.2 μs |   484.45 μs | 248.38 μs | 4,831.9 μs | 3,887.2 μs |  5,913.6 μs |   203.9 |   8.21 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,999.3 μs | 1,534.72 μs | 786.87 μs | 4,437.3 μs | 3,592.4 μs | 10,151.5 μs |   200.0 |   9.74 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 5,109.6 μs |   529.36 μs | 271.41 μs | 4,992.4 μs | 4,162.5 μs |  7,336.5 μs |   195.7 |   9.51 KB |
