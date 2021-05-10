# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Sql Server

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]   : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  ShortRun : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                                    Method |                  Type |       Mean |      StdDev |       Error |        Min |         Max |    Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |-----------:|------------:|------------:|-----------:|------------:|--------:|------:|------:|------:|----------:|
|                        &#39;Single Procedure&#39; |      InsightBenchmark |   356.5 μs |    60.20 μs |    32.48 μs |   287.3 μs |    606.3 μs | 2,805.1 |     - |     - |     - |  14.38 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   380.6 μs |    51.40 μs |    28.50 μs |   299.2 μs |    505.5 μs | 2,627.6 |     - |     - |     - |  12.81 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   383.4 μs |    35.79 μs |    18.58 μs |   311.4 μs |    442.9 μs | 2,608.3 |     - |     - |     - |  12.51 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |   384.1 μs |    56.53 μs |    30.91 μs |   311.8 μs |    533.7 μs | 2,603.3 |     - |     - |     - |  14.55 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   384.7 μs |    86.49 μs |    47.30 μs |   300.6 μs |    833.5 μs | 2,599.5 |     - |     - |     - |  12.81 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   384.8 μs |    40.53 μs |    21.03 μs |   302.1 μs |    457.6 μs | 2,599.0 |     - |     - |     - |  12.49 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |   385.6 μs |    40.89 μs |    20.72 μs |   291.9 μs |    484.4 μs | 2,593.5 |     - |     - |     - |   11.8 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   387.9 μs |    34.31 μs |    18.27 μs |   303.1 μs |    471.6 μs | 2,577.8 |     - |     - |     - |   11.8 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   388.0 μs |    38.25 μs |    19.61 μs |   326.9 μs |    486.9 μs | 2,577.4 |     - |     - |     - |  11.79 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   388.1 μs |    40.39 μs |    22.09 μs |   305.6 μs |    518.0 μs | 2,576.9 |     - |     - |     - |  12.51 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   389.5 μs |    34.23 μs |    17.77 μs |   293.4 μs |    444.3 μs | 2,567.3 |     - |     - |     - |  12.49 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   392.2 μs |    44.31 μs |    22.72 μs |   309.2 μs |    452.3 μs | 2,549.8 |     - |     - |     - |  12.81 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   396.6 μs |    94.93 μs |    52.65 μs |   285.0 μs |    720.3 μs | 2,521.3 |     - |     - |     - |  12.51 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   397.0 μs |    28.20 μs |    14.64 μs |   318.4 μs |    458.0 μs | 2,519.2 |     - |     - |     - |  12.81 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   397.8 μs |    46.97 μs |    23.25 μs |   311.4 μs |    476.6 μs | 2,513.6 |     - |     - |     - |  14.55 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |   399.3 μs |    37.98 μs |    19.71 μs |   326.6 μs |    475.0 μs | 2,504.1 |     - |     - |     - |  13.54 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |   400.3 μs |    46.62 μs |    23.90 μs |   313.1 μs |    499.4 μs | 2,498.4 |     - |     - |     - |  13.52 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |   400.9 μs |    29.93 μs |    15.54 μs |   330.7 μs |    462.2 μs | 2,494.4 |     - |     - |     - |  11.79 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   408.4 μs |    42.33 μs |    21.70 μs |   326.6 μs |    481.3 μs | 2,448.5 |     - |     - |     - |  14.55 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |   409.0 μs |   107.79 μs |    55.95 μs |   299.9 μs |    902.9 μs | 2,445.2 |     - |     - |     - |  12.51 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |   409.1 μs |   162.23 μs |    88.72 μs |   323.3 μs |  1,172.8 μs | 2,444.7 |     - |     - |     - |  14.55 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |   409.5 μs |   164.86 μs |    87.77 μs |   279.4 μs |  1,075.9 μs | 2,442.1 |     - |     - |     - |  11.79 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |   413.9 μs |    40.37 μs |    20.95 μs |   326.9 μs |    495.4 μs | 2,416.1 |     - |     - |     - |  14.23 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |   416.3 μs |   157.19 μs |    84.81 μs |   317.9 μs |  1,354.5 μs | 2,402.4 |     - |     - |     - |  11.79 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   421.5 μs |    40.41 μs |    20.47 μs |   335.1 μs |    527.6 μs | 2,372.6 |     - |     - |     - |  14.63 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |   431.8 μs |   122.82 μs |    66.26 μs |   324.9 μs |    844.7 μs | 2,315.9 |     - |     - |     - |  14.58 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |   442.6 μs |   161.81 μs |    91.03 μs |   303.7 μs |  1,075.5 μs | 2,259.3 |     - |     - |     - |   11.8 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   445.0 μs |    44.38 μs |    23.63 μs |   354.8 μs |    556.5 μs | 2,247.3 |     - |     - |     - |  14.58 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   484.2 μs |    81.02 μs |    44.31 μs |   392.3 μs |    819.1 μs | 2,065.4 |     - |     - |     - |  14.89 KB |
|                                    Single | InsightBenchmarkWrite |   484.8 μs |   184.48 μs |    98.22 μs |   348.4 μs |  1,331.4 μs | 2,062.7 |     - |     - |     - |  14.24 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   518.2 μs |    57.87 μs |    28.98 μs |   431.8 μs |    683.0 μs | 1,929.9 |     - |     - |     - |  15.19 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |   520.6 μs |   159.42 μs |    84.88 μs |   372.0 μs |  1,113.6 μs | 1,920.8 |     - |     - |     - |  17.47 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   522.0 μs |    47.55 μs |    24.09 μs |   447.3 μs |    627.3 μs | 1,915.6 |     - |     - |     - |  67.55 KB |
|                                    Single |      InsightBenchmark |   524.0 μs |   416.41 μs |   218.86 μs |   349.3 μs |  2,487.9 μs | 1,908.5 |     - |     - |     - |  14.24 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   531.9 μs |    53.34 μs |    27.68 μs |   433.6 μs |    618.6 μs | 1,880.0 |     - |     - |     - |  14.34 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   534.4 μs |    48.64 μs |    24.64 μs |   432.4 μs |    630.7 μs | 1,871.3 |     - |     - |     - |  14.89 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   536.9 μs |    77.88 μs |    40.93 μs |   380.1 μs |    785.0 μs | 1,862.4 |     - |     - |     - |  15.05 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   537.5 μs |    54.74 μs |    29.14 μs |   427.4 μs |    632.6 μs | 1,860.4 |     - |     - |     - |  15.59 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   538.1 μs |    71.68 μs |    37.20 μs |   395.9 μs |    709.8 μs | 1,858.5 |     - |     - |     - |  15.59 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   539.7 μs |    61.21 μs |    31.38 μs |   438.6 μs |    708.9 μs | 1,852.8 |     - |     - |     - |  15.05 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   545.4 μs |    74.28 μs |    38.56 μs |   431.6 μs |    766.7 μs | 1,833.6 |     - |     - |     - |  14.89 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml |   551.2 μs |    44.89 μs |    23.59 μs |   447.1 μs |    630.4 μs | 1,814.2 |     - |     - |     - |  67.57 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |   559.2 μs |   205.47 μs |   112.37 μs |   374.7 μs |  1,302.8 μs | 1,788.4 |     - |     - |     - |  14.34 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   564.2 μs |   325.36 μs |   177.94 μs |   372.5 μs |  2,007.0 μs | 1,772.3 |     - |     - |     - |  15.05 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   566.2 μs |    83.63 μs |    43.40 μs |   432.3 μs |    888.5 μs | 1,766.3 |     - |     - |     - |  15.05 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |   580.0 μs |    52.26 μs |    27.82 μs |   458.7 μs |    687.4 μs | 1,724.1 |     - |     - |     - |  17.47 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |   582.0 μs |   263.61 μs |   146.19 μs |   320.6 μs |  1,309.6 μs | 1,718.3 |     - |     - |     - |  13.52 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |   585.1 μs |   316.58 μs |   175.56 μs |   331.9 μs |  1,648.4 μs | 1,709.2 |     - |     - |     - |   15.2 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   585.3 μs |    49.19 μs |    25.85 μs |   465.9 μs |    716.5 μs | 1,708.5 |     - |     - |     - |  17.73 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   587.4 μs |    64.51 μs |    33.07 μs |   486.9 μs |    813.9 μs | 1,702.5 |     - |     - |     - |  17.23 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   594.3 μs |    47.46 μs |    24.34 μs |   477.3 μs |    703.5 μs | 1,682.6 |     - |     - |     - |  17.33 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |   595.7 μs |    99.78 μs |    53.12 μs |   479.9 μs |    950.5 μs | 1,678.8 |     - |     - |     - |  16.78 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |   601.9 μs |   282.69 μs |   150.51 μs |   374.9 μs |  1,331.9 μs | 1,661.3 |     - |     - |     - |  16.08 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |   604.6 μs |   337.90 μs |   179.90 μs |   384.9 μs |  1,844.4 μs | 1,654.0 |     - |     - |     - |  14.89 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |   606.2 μs |   148.74 μs |    76.26 μs |   447.8 μs |  1,238.0 μs | 1,649.6 |     - |     - |     - |  16.08 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |   635.1 μs |   731.91 μs |   389.68 μs |   294.3 μs |  4,298.2 μs | 1,574.5 |     - |     - |     - |   11.8 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   635.8 μs |   304.36 μs |   166.45 μs |   398.1 μs |  2,145.3 μs | 1,572.9 |     - |     - |     - |  17.33 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   654.6 μs |   585.26 μs |   311.60 μs |   315.6 μs |  3,419.3 μs | 1,527.6 |     - |     - |     - |  11.93 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |   666.3 μs |    60.46 μs |    31.38 μs |   547.0 μs |    810.6 μs | 1,500.8 |     - |     - |     - |  44.16 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   667.6 μs |   394.46 μs |   204.74 μs |   435.1 μs |  2,595.7 μs | 1,497.9 |     - |     - |     - |  17.23 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   718.7 μs |   439.01 μs |   243.46 μs |   391.2 μs |  2,383.7 μs | 1,391.5 |     - |     - |     - |  15.59 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml |   730.7 μs |    55.23 μs |    28.31 μs |   617.4 μs |    879.6 μs | 1,368.5 |     - |     - |     - |  70.09 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   734.4 μs |   946.57 μs |   510.68 μs |   310.5 μs |  4,465.8 μs | 1,361.7 |     - |     - |     - |  12.49 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml |   737.8 μs |    33.33 μs |    17.52 μs |   659.0 μs |    816.0 μs | 1,355.4 |     - |     - |     - |  70.11 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   761.7 μs |   661.14 μs |   352.00 μs |   405.0 μs |  2,847.8 μs | 1,312.9 |     - |     - |     - |  14.63 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |   789.3 μs |   388.67 μs |   201.73 μs |   482.7 μs |  2,118.7 μs | 1,266.9 |     - |     - |     - |  17.34 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   897.0 μs |   881.94 μs |   482.32 μs |   466.4 μs |  5,041.9 μs | 1,114.8 |     - |     - |     - |   18.3 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1,069.0 μs |   990.93 μs |   527.59 μs |   542.4 μs |  5,633.9 μs |   935.4 |     - |     - |     - |  44.71 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1,108.1 μs | 1,292.79 μs |   697.46 μs |   376.5 μs |  5,705.1 μs |   902.4 |     - |     - |     - |  15.59 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1,129.3 μs | 1,577.73 μs |   829.25 μs |   412.2 μs |  7,174.3 μs |   885.5 |     - |     - |     - |  41.63 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,172.7 μs | 2,014.72 μs | 1,045.70 μs |   372.9 μs | 11,859.0 μs |   852.7 |     - |     - |     - |  41.61 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 1,707.6 μs | 2,296.27 μs | 1,177.32 μs |   327.6 μs |  9,011.8 μs |   585.6 |     - |     - |     - |  14.23 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 7,607.8 μs |   726.91 μs |   359.85 μs | 6,700.6 μs |  9,248.9 μs |   131.4 |     - |     - |     - |  36.59 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 7,729.8 μs |   712.40 μs |   352.66 μs | 6,887.5 μs |  9,600.6 μs |   129.4 |     - |     - |     - |  34.77 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 8,393.5 μs | 1,418.70 μs |   710.38 μs | 6,872.9 μs | 14,115.8 μs |   119.1 |     - |     - |     - |  36.59 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 9,134.6 μs | 1,464.04 μs |   741.70 μs | 7,316.9 μs | 13,054.7 μs |   109.5 |     - |     - |     - |  34.77 KB |
|                                           |                       |            |             |             |            |             |         |       |       |       |           |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite |   707.9 μs |    84.81 μs |    42.96 μs |   589.6 μs |    924.2 μs | 1,412.7 |     - |     - |     - |   6.46 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |   819.5 μs |   101.17 μs |    55.33 μs |   678.8 μs |  1,117.7 μs | 1,220.3 |     - |     - |     - |  11.32 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite |   831.0 μs |    83.64 μs |    42.37 μs |   660.0 μs |  1,075.4 μs | 1,203.4 |     - |     - |     - |  17.23 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   846.0 μs |    71.23 μs |    37.92 μs |   745.7 μs |  1,040.6 μs | 1,182.0 |     - |     - |     - |   11.3 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   857.9 μs |    57.77 μs |    31.59 μs |   771.1 μs |    998.5 μs | 1,165.6 |     - |     - |     - |   7.02 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson |   860.3 μs |    88.31 μs |    47.02 μs |   729.3 μs |  1,148.1 μs | 1,162.4 |     - |     - |     - |   7.02 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   920.6 μs |    92.76 μs |    47.56 μs |   754.4 μs |  1,133.8 μs | 1,086.2 |     - |     - |     - |   10.2 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   947.0 μs |   110.31 μs |    55.88 μs |   720.9 μs |  1,238.5 μs | 1,055.9 |     - |     - |     - |   19.9 KB |
