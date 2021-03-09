# Insight.Database.Benchmark

[![Build status][build-svg]][build]

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Results for SQL Server Benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.200
  [Host]   : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  ShortRun : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


```
|                                    Method |                  Type |       Mean |      StdDev |       Error |        Min |         Max |    Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |-----------:|------------:|------------:|-----------:|------------:|--------:|------:|------:|------:|----------:|
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |   371.6 μs |    49.51 μs |    39.15 μs |   283.5 μs |    441.7 μs | 2,691.3 |     - |     - |     - |  11.79 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |   393.5 μs |    43.82 μs |    36.81 μs |   319.9 μs |    468.0 μs | 2,541.2 |     - |     - |     - |  13.52 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |   394.7 μs |    49.94 μs |    40.66 μs |   308.1 μs |    478.9 μs | 2,533.6 |     - |     - |     - |  12.51 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |   401.7 μs |    53.31 μs |    43.41 μs |   315.6 μs |    514.4 μs | 2,489.2 |     - |     - |     - |  13.82 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   402.2 μs |    36.68 μs |    29.87 μs |   333.9 μs |    478.6 μs | 2,486.2 |     - |     - |     - |  12.49 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |   402.2 μs |    49.18 μs |    40.05 μs |   311.3 μs |    497.9 μs | 2,486.1 |     - |     - |     - |   11.8 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   403.4 μs |    48.87 μs |    38.64 μs |   326.8 μs |    475.2 μs | 2,479.1 |     - |     - |     - |  12.81 KB |
|                                    Single |      InsightBenchmark |   403.7 μs |    44.12 μs |    38.31 μs |   312.8 μs |    491.7 μs | 2,477.2 |     - |     - |     - |  14.24 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |   405.7 μs |    50.73 μs |    41.31 μs |   320.9 μs |    489.7 μs | 2,464.9 |     - |     - |     - |   11.8 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |   407.1 μs |    46.24 μs |    37.65 μs |   324.2 μs |    486.6 μs | 2,456.4 |     - |     - |     - |  11.79 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |   407.7 μs |    36.04 μs |    29.35 μs |   338.9 μs |    486.1 μs | 2,452.9 |     - |     - |     - |  11.79 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   409.7 μs |    32.76 μs |    25.90 μs |   306.3 μs |    455.4 μs | 2,440.7 |     - |     - |     - |   11.8 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   411.0 μs |    52.61 μs |    44.19 μs |   339.7 μs |    527.6 μs | 2,433.3 |     - |     - |     - |  14.55 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   411.4 μs |    41.51 μs |    32.82 μs |   316.1 μs |    508.9 μs | 2,431.0 |     - |     - |     - |  12.51 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |   413.4 μs |    54.24 μs |    42.89 μs |   337.1 μs |    578.2 μs | 2,418.7 |     - |     - |     - |  14.23 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |   416.7 μs |    56.54 μs |    43.48 μs |   346.0 μs |    578.9 μs | 2,399.6 |     - |     - |     - |  14.23 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   417.7 μs |    40.34 μs |    31.90 μs |   343.3 μs |    502.6 μs | 2,394.2 |     - |     - |     - |  13.09 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   417.8 μs |    44.48 μs |    34.21 μs |   313.8 μs |    469.6 μs | 2,393.7 |     - |     - |     - |  12.51 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   421.0 μs |    45.23 μs |    37.99 μs |   315.2 μs |    477.1 μs | 2,375.3 |     - |     - |     - |  12.25 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |   421.7 μs |    42.07 μs |    34.25 μs |   356.6 μs |    519.9 μs | 2,371.3 |     - |     - |     - |  14.55 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |   423.0 μs |    47.10 μs |    39.57 μs |   338.1 μs |    492.6 μs | 2,364.3 |     - |     - |     - |  14.55 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |   424.3 μs |    42.15 μs |    33.33 μs |   332.7 μs |    503.0 μs | 2,356.7 |     - |     - |     - |   11.8 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   428.9 μs |    56.17 μs |    44.42 μs |   339.4 μs |    592.3 μs | 2,331.7 |     - |     - |     - |  12.49 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   431.3 μs |    36.83 μs |    29.12 μs |   344.4 μs |    506.6 μs | 2,318.4 |     - |     - |     - |  12.51 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   434.5 μs |    38.14 μs |    32.04 μs |   320.3 μs |    495.2 μs | 2,301.7 |     - |     - |     - |  12.49 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   439.6 μs |    48.01 μs |    36.93 μs |   355.0 μs |    573.2 μs | 2,275.0 |     - |     - |     - |  12.81 KB |
|                                    Single | InsightBenchmarkWrite |   439.8 μs |    42.87 μs |    37.23 μs |   322.9 μs |    486.4 μs | 2,273.6 |     - |     - |     - |  14.24 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   439.8 μs |   113.83 μs |    92.69 μs |   324.6 μs |    824.8 μs | 2,273.5 |     - |     - |     - |  11.79 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |   441.8 μs |    47.99 μs |    39.08 μs |   346.2 μs |    549.5 μs | 2,263.5 |     - |     - |     - |  13.52 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   445.9 μs |   134.78 μs |   109.74 μs |   295.1 μs |    825.2 μs | 2,242.4 |     - |     - |     - |  12.49 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   446.6 μs |    45.52 μs |    35.99 μs |   343.4 μs |    532.0 μs | 2,239.3 |     - |     - |     - |  14.55 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |   461.6 μs |    32.12 μs |    26.15 μs |   393.9 μs |    537.2 μs | 2,166.1 |     - |     - |     - |  14.58 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   468.8 μs |    45.55 μs |    35.03 μs |   388.8 μs |    576.2 μs | 2,133.2 |     - |     - |     - |  14.02 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |   481.6 μs |    56.11 μs |    44.36 μs |   374.1 μs |    613.0 μs | 2,076.3 |     - |     - |     - |  14.63 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |   482.1 μs |   229.19 μs |   181.22 μs |   316.1 μs |  1,277.7 μs | 2,074.4 |     - |     - |     - |  13.54 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   486.8 μs |    41.63 μs |    32.01 μs |   427.1 μs |    613.0 μs | 2,054.1 |     - |     - |     - |  14.63 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |   494.2 μs |    55.63 μs |    43.99 μs |   408.2 μs |    636.6 μs | 2,023.5 |     - |     - |     - |  41.61 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |   501.8 μs |    61.40 μs |    53.31 μs |   403.4 μs |    689.5 μs | 1,992.7 |     - |     - |     - |  41.63 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   512.8 μs |    80.81 μs |    65.80 μs |   438.9 μs |    761.4 μs | 1,950.3 |     - |     - |     - |  14.34 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   545.0 μs |    45.17 μs |    34.74 μs |   460.6 μs |    609.0 μs | 1,834.9 |     - |     - |     - |  14.96 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |   553.0 μs |    53.75 μs |    43.77 μs |   467.8 μs |    654.1 μs | 1,808.2 |     - |     - |     - |  14.34 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   567.9 μs |    44.99 μs |    35.58 μs |   465.9 μs |    643.2 μs | 1,761.0 |     - |     - |     - |  15.59 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   569.3 μs |    86.45 μs |    68.36 μs |   457.8 μs |    810.9 μs | 1,756.5 |     - |     - |     - |  14.34 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   571.6 μs |    44.94 μs |    36.59 μs |   488.9 μs |    667.5 μs | 1,749.4 |     - |     - |     - |  16.16 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   572.3 μs |    47.86 μs |    38.97 μs |   476.5 μs |    643.0 μs | 1,747.2 |     - |     - |     - |  15.33 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   580.5 μs |    44.68 μs |    37.54 μs |   500.6 μs |    670.9 μs | 1,722.7 |     - |     - |     - |  15.88 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   580.6 μs |   128.36 μs |    98.72 μs |   456.1 μs |    960.5 μs | 1,722.3 |     - |     - |     - |  14.89 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |   580.7 μs |    59.26 μs |    46.86 μs |   446.9 μs |    744.4 μs | 1,722.1 |     - |     - |     - |  14.89 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   581.3 μs |   148.03 μs |   113.84 μs |   461.2 μs |  1,054.5 μs | 1,720.2 |     - |     - |     - |  17.33 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |   592.0 μs |    51.89 μs |    43.59 μs |   494.5 μs |    722.4 μs | 1,689.2 |     - |     - |     - |  16.92 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   592.3 μs |   100.44 μs |    84.38 μs |   419.5 μs |    937.1 μs | 1,688.5 |     - |     - |     - |  15.05 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   596.6 μs |   171.65 μs |   144.19 μs |   394.3 μs |  1,114.0 μs | 1,676.3 |     - |     - |     - |  15.17 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   602.1 μs |    81.58 μs |    62.74 μs |   493.0 μs |    833.8 μs | 1,660.8 |     - |     - |     - |  67.41 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   605.4 μs |    57.27 μs |    46.64 μs |   483.9 μs |    710.5 μs | 1,651.7 |     - |     - |     - |   18.3 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml |   606.1 μs |    93.29 μs |    78.37 μs |   477.5 μs |    893.0 μs | 1,649.8 |     - |     - |     - |  67.42 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |   611.1 μs |   129.62 μs |    97.09 μs |   483.4 μs |  1,076.1 μs | 1,636.3 |     - |     - |     - |  16.92 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |   615.2 μs |   145.88 μs |   112.19 μs |   398.3 μs |  1,021.0 μs | 1,625.5 |     - |     - |     - |  16.63 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |   616.0 μs |    30.38 μs |    24.73 μs |   550.6 μs |    683.8 μs | 1,623.3 |     - |     - |     - |  16.78 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |   616.1 μs |    58.89 μs |    45.29 μs |   473.5 μs |    689.0 μs | 1,623.2 |     - |     - |     - |  16.78 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   618.3 μs |    77.22 μs |    62.88 μs |   531.2 μs |    849.7 μs | 1,617.4 |     - |     - |     - |  15.05 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |   618.6 μs |    78.73 μs |    58.98 μs |   492.4 μs |    777.2 μs | 1,616.5 |     - |     - |     - |  16.34 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   621.0 μs |    92.70 μs |    75.49 μs |   451.1 μs |    902.6 μs | 1,610.4 |     - |     - |     - |  15.59 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   623.5 μs |    92.80 μs |    75.57 μs |   496.5 μs |    799.7 μs | 1,604.0 |     - |     - |     - |   18.3 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   658.1 μs |   102.54 μs |    86.14 μs |   446.6 μs |    852.8 μs | 1,519.6 |     - |     - |     - |   17.8 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   664.1 μs |   206.37 μs |   168.04 μs |   535.4 μs |  1,385.2 μs | 1,505.8 |     - |     - |     - |  15.05 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   664.4 μs |   211.63 μs |   167.34 μs |   495.2 μs |  1,252.0 μs | 1,505.2 |     - |     - |     - |  14.89 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |   670.9 μs |    35.76 μs |    30.04 μs |   593.8 μs |    712.5 μs | 1,490.6 |     - |     - |     - |  44.71 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   685.2 μs |   266.63 μs |   210.82 μs |   498.4 μs |  1,652.3 μs | 1,459.4 |     - |     - |     - |  17.33 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |   685.8 μs |    40.64 μs |    32.13 μs |   609.2 μs |    777.0 μs | 1,458.1 |     - |     - |     - |  44.16 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml |   766.5 μs |    54.96 μs |    46.16 μs |   642.1 μs |    849.2 μs | 1,304.7 |     - |     - |     - |  70.51 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml |   798.8 μs |   111.56 μs |    85.80 μs |   663.4 μs |  1,095.4 μs | 1,251.8 |     - |     - |     - |  69.96 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,031.4 μs | 1,164.45 μs |   895.53 μs |   545.0 μs |  5,600.5 μs |   969.6 |     - |     - |     - |  17.23 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 8,575.6 μs | 1,186.18 μs |   912.25 μs | 7,252.8 μs | 11,650.2 μs |   116.6 |     - |     - |     - |  34.75 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 9,142.6 μs | 1,417.32 μs | 1,090.01 μs | 7,335.4 μs | 12,388.8 μs |   109.4 |     - |     - |     - |  36.59 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 9,233.0 μs | 2,016.29 μs | 1,693.75 μs | 7,029.7 μs | 13,684.7 μs |   108.3 |     - |     - |     - |  36.59 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 9,321.4 μs | 1,640.07 μs | 1,296.83 μs | 7,746.0 μs | 14,719.5 μs |   107.3 |     - |     - |     - |  34.47 KB |
|                                           |                       |            |             |             |            |             |         |       |       |       |           |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |   836.9 μs |    89.83 μs |    75.46 μs |   746.5 μs |  1,064.5 μs | 1,194.8 |     - |     - |     - |  11.32 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite |   837.0 μs |   104.78 μs |    85.32 μs |   618.3 μs |    969.5 μs | 1,194.7 |     - |     - |     - |  16.66 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson |   861.3 μs |    81.44 μs |    66.31 μs |   757.2 μs |  1,083.9 μs | 1,161.0 |     - |     - |     - |   7.02 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   918.7 μs |   107.58 μs |    87.60 μs |   764.2 μs |  1,147.4 μs | 1,088.5 |     - |     - |     - |   10.2 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   930.8 μs |    96.11 μs |    78.26 μs |   834.9 μs |  1,204.8 μs | 1,074.4 |     - |     - |     - |   7.02 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   936.9 μs |    73.65 μs |    58.24 μs |   816.2 μs |  1,119.0 μs | 1,067.4 |     - |     - |     - |   11.3 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   963.3 μs |   111.18 μs |    90.53 μs |   773.4 μs |  1,133.6 μs | 1,038.1 |     - |     - |     - |   19.9 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 2,707.3 μs | 4,847.15 μs | 3,832.71 μs |   684.2 μs | 17,215.4 μs |   369.4 |     - |     - |     - |   7.02 KB |


## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.

[build]: https://ci.appveyor.com/project/Jaxelr/insight-database-benchmark/branch/master?fullLog=true
[build-svg]: https://ci.appveyor.com/api/projects/status/u7f3dxi8aaw02l0y?svg=true
