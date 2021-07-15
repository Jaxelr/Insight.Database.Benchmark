# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Sql Server

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.302
  [Host]   : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  ShortRun : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|                                    Method |                  Type |       Mean |      StdDev |     Error |        Min |         Max |    Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |-----------:|------------:|----------:|-----------:|------------:|--------:|------:|------:|------:|----------:|
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   365.2 μs |    36.34 μs |  19.60 μs |   291.1 μs |    443.1 μs | 2,738.4 |     - |     - |     - |     12 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |   369.0 μs |    48.93 μs |  25.39 μs |   284.9 μs |    458.6 μs | 2,710.0 |     - |     - |     - |     12 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   371.4 μs |    50.59 μs |  26.26 μs |   307.6 μs |    522.9 μs | 2,692.6 |     - |     - |     - |     13 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |   372.1 μs |    62.06 μs |  33.04 μs |   301.1 μs |    546.6 μs | 2,687.4 |     - |     - |     - |     12 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   372.1 μs |    50.57 μs |  26.25 μs |   306.8 μs |    476.1 μs | 2,687.1 |     - |     - |     - |     13 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   375.2 μs |    46.35 μs |  25.01 μs |   285.4 μs |    455.0 μs | 2,665.0 |     - |     - |     - |     12 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   376.3 μs |    46.91 μs |  24.05 μs |   301.6 μs |    454.6 μs | 2,657.3 |     - |     - |     - |     13 KB |
|                                    Single | InsightBenchmarkWrite |   378.8 μs |    47.18 μs |  24.49 μs |   297.6 μs |    461.9 μs | 2,640.2 |     - |     - |     - |     14 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |   381.2 μs |    38.72 μs |  20.61 μs |   311.5 μs |    510.7 μs | 2,623.2 |     - |     - |     - |     12 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   384.5 μs |    42.25 μs |  22.49 μs |   299.5 μs |    456.8 μs | 2,600.7 |     - |     - |     - |     12 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |   386.1 μs |    43.33 μs |  22.77 μs |   311.9 μs |    484.1 μs | 2,590.0 |     - |     - |     - |     14 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |   388.2 μs |    49.83 μs |  25.86 μs |   320.0 μs |    492.7 μs | 2,576.3 |     - |     - |     - |     15 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |   389.9 μs |    52.58 μs |  27.99 μs |   306.4 μs |    480.5 μs | 2,564.7 |     - |     - |     - |     15 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |   391.8 μs |    37.57 μs |  20.27 μs |   307.2 μs |    454.4 μs | 2,552.5 |     - |     - |     - |     12 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   394.5 μs |    40.11 μs |  20.82 μs |   293.4 μs |    481.0 μs | 2,534.8 |     - |     - |     - |     13 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   397.5 μs |    35.34 μs |  19.60 μs |   317.6 μs |    468.2 μs | 2,515.4 |     - |     - |     - |     12 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |   398.5 μs |    35.36 μs |  19.07 μs |   302.7 μs |    474.5 μs | 2,509.1 |     - |     - |     - |     14 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |   399.2 μs |    55.62 μs |  30.42 μs |   280.5 μs |    580.8 μs | 2,505.0 |     - |     - |     - |     13 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |   403.9 μs |    36.89 μs |  19.90 μs |   320.8 μs |    477.9 μs | 2,476.2 |     - |     - |     - |     14 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   406.7 μs |    46.36 μs |  25.01 μs |   324.2 μs |    508.5 μs | 2,458.8 |     - |     - |     - |     13 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |   408.2 μs |    35.71 μs |  18.54 μs |   333.5 μs |    511.1 μs | 2,449.5 |     - |     - |     - |     12 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   408.6 μs |    42.90 μs |  22.55 μs |   309.7 μs |    496.5 μs | 2,447.2 |     - |     - |     - |     12 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   414.4 μs |    61.27 μs |  32.62 μs |   319.5 μs |    619.5 μs | 2,413.3 |     - |     - |     - |     13 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |   422.1 μs |    45.93 μs |  24.14 μs |   312.5 μs |    518.8 μs | 2,369.2 |     - |     - |     - |     14 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   423.0 μs |    47.81 μs |  25.13 μs |   332.9 μs |    511.9 μs | 2,363.9 |     - |     - |     - |     15 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   424.6 μs |    52.80 μs |  27.41 μs |   336.9 μs |    603.0 μs | 2,355.3 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   426.5 μs |    36.25 μs |  19.30 μs |   358.6 μs |    551.2 μs | 2,344.6 |     - |     - |     - |     12 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   426.7 μs |    69.75 μs |  37.63 μs |   304.3 μs |    682.6 μs | 2,343.8 |     - |     - |     - |     13 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |   430.8 μs |    72.83 μs |  38.28 μs |   332.2 μs |    646.2 μs | 2,321.2 |     - |     - |     - |     14 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |   435.3 μs |    48.70 μs |  25.93 μs |   333.1 μs |    608.2 μs | 2,297.1 |     - |     - |     - |     14 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   437.6 μs |    41.60 μs |  21.59 μs |   335.1 μs |    522.5 μs | 2,285.1 |     - |     - |     - |     15 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |   446.9 μs |    45.41 μs |  24.50 μs |   352.2 μs |    534.0 μs | 2,237.5 |     - |     - |     - |     15 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |   448.3 μs |    50.66 μs |  27.33 μs |   359.4 μs |    566.9 μs | 2,230.6 |     - |     - |     - |     42 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |   458.3 μs |    50.88 μs |  27.09 μs |   369.6 μs |    551.5 μs | 2,181.9 |     - |     - |     - |     42 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |   462.0 μs |    39.78 μs |  21.76 μs |   384.4 μs |    566.1 μs | 2,164.7 |     - |     - |     - |     15 KB |
|                                    Single |      InsightBenchmark |   472.1 μs |   296.88 μs | 160.17 μs |   331.2 μs |  1,848.4 μs | 2,118.4 |     - |     - |     - |     14 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   476.5 μs |   134.00 μs |  72.29 μs |   346.2 μs |  1,024.8 μs | 2,098.6 |     - |     - |     - |     15 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   480.1 μs |    72.12 μs |  37.91 μs |   369.5 μs |    624.1 μs | 2,082.7 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   496.5 μs |    73.56 μs |  38.66 μs |   360.1 μs |    626.3 μs | 2,014.0 |     - |     - |     - |     16 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   500.6 μs |    59.63 μs |  31.34 μs |   406.5 μs |    651.3 μs | 1,997.8 |     - |     - |     - |     16 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   522.5 μs |    54.22 μs |  28.87 μs |   438.5 μs |    651.3 μs | 1,913.9 |     - |     - |     - |     15 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |   527.4 μs |    50.60 μs |  27.30 μs |   436.8 μs |    643.8 μs | 1,896.0 |     - |     - |     - |     15 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   528.0 μs |    78.02 μs |  42.67 μs |   399.9 μs |    770.5 μs | 1,893.9 |     - |     - |     - |     16 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |   529.5 μs |    61.22 μs |  33.95 μs |   414.2 μs |    630.7 μs | 1,888.7 |     - |     - |     - |     17 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   536.7 μs |    61.83 μs |  31.70 μs |   399.9 μs |    639.5 μs | 1,863.3 |     - |     - |     - |     14 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |   543.2 μs |   355.34 μs | 184.43 μs |   295.7 μs |  1,972.5 μs | 1,840.8 |     - |     - |     - |     12 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |   543.3 μs |    52.07 μs |  27.37 μs |   441.1 μs |    656.7 μs | 1,840.7 |     - |     - |     - |     14 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |   547.6 μs |    53.31 μs |  28.02 μs |   459.9 μs |    644.6 μs | 1,826.3 |     - |     - |     - |     17 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   549.3 μs |    70.81 μs |  37.22 μs |   447.8 μs |    749.3 μs | 1,820.6 |     - |     - |     - |     14 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   550.0 μs |    58.67 μs |  31.65 μs |   421.2 μs |    642.6 μs | 1,818.1 |     - |     - |     - |     14 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   550.6 μs |    55.96 μs |  29.80 μs |   451.4 μs |    676.9 μs | 1,816.3 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   550.8 μs |    73.74 μs |  38.76 μs |   402.1 μs |    689.1 μs | 1,815.4 |     - |     - |     - |     16 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   556.0 μs |    64.53 μs |  33.49 μs |   421.6 μs |    700.9 μs | 1,798.6 |     - |     - |     - |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   568.1 μs |    47.73 μs |  26.47 μs |   480.4 μs |    661.0 μs | 1,760.2 |     - |     - |     - |     17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   572.4 μs |    60.28 μs |  32.52 μs |   468.8 μs |    749.2 μs | 1,746.9 |     - |     - |     - |     15 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   575.3 μs |   103.29 μs |  54.99 μs |   467.5 μs |    953.7 μs | 1,738.1 |     - |     - |     - |     68 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml |   577.5 μs |    60.28 μs |  31.68 μs |   483.4 μs |    764.8 μs | 1,731.8 |     - |     - |     - |     67 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   578.3 μs |    92.87 μs |  50.79 μs |   465.2 μs |    951.5 μs | 1,729.2 |     - |     - |     - |     15 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   578.5 μs |    63.73 μs |  34.38 μs |   447.9 μs |    717.4 μs | 1,728.5 |     - |     - |     - |     15 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |   588.2 μs |    35.11 μs |  18.69 μs |   495.0 μs |    664.3 μs | 1,700.0 |     - |     - |     - |     16 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |   591.0 μs |   142.33 μs |  72.10 μs |   427.9 μs |  1,078.0 μs | 1,692.1 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   592.0 μs |    61.78 μs |  32.47 μs |   491.6 μs |    738.0 μs | 1,689.0 |     - |     - |     - |     18 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |   593.4 μs |    73.01 μs |  38.37 μs |   468.2 μs |    786.5 μs | 1,685.3 |     - |     - |     - |     16 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   593.4 μs |    61.50 μs |  32.75 μs |   476.5 μs |    751.1 μs | 1,685.3 |     - |     - |     - |     16 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |   595.6 μs |    46.00 μs |  25.16 μs |   498.2 μs |    695.2 μs | 1,679.1 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   601.4 μs |    56.13 μs |  29.88 μs |   481.8 μs |    727.3 μs | 1,662.8 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   606.2 μs |   146.71 μs |  78.11 μs |   481.9 μs |  1,407.1 μs | 1,649.7 |     - |     - |     - |     18 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |   615.9 μs |    81.63 μs |  42.37 μs |   483.6 μs |    793.9 μs | 1,623.5 |     - |     - |     - |     45 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |   618.2 μs |    49.72 μs |  25.49 μs |   497.4 μs |    712.6 μs | 1,617.5 |     - |     - |     - |     44 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   633.5 μs |    57.14 μs |  30.42 μs |   508.1 μs |    787.2 μs | 1,578.4 |     - |     - |     - |     18 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml |   775.0 μs |    49.38 μs |  26.64 μs |   700.2 μs |    979.0 μs | 1,290.3 |     - |     - |     - |     70 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml |   783.7 μs |    96.96 μs |  50.96 μs |   682.9 μs |  1,156.3 μs | 1,276.0 |     - |     - |     - |     71 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 8,185.5 μs | 1,073.76 μs | 531.55 μs | 6,743.4 μs | 10,207.4 μs |   122.2 |     - |     - |     - |     37 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 8,431.6 μs | 1,011.30 μs | 512.34 μs | 7,000.9 μs | 10,449.6 μs |   118.6 |     - |     - |     - |     37 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 8,557.2 μs | 1,191.21 μs | 596.47 μs | 7,083.8 μs | 10,999.5 μs |   116.9 |     - |     - |     - |     35 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 8,736.5 μs | 1,007.57 μs | 498.79 μs | 7,202.3 μs | 10,841.6 μs |   114.5 |     - |     - |     - |     34 KB |
|                                           |                       |            |             |           |            |             |         |       |       |       |           |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite |   730.4 μs |    71.27 μs |  37.46 μs |   585.6 μs |    922.4 μs | 1,369.2 |     - |     - |     - |      7 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |   803.7 μs |    75.83 μs |  39.86 μs |   679.5 μs |    953.5 μs | 1,244.2 |     - |     - |     - |     11 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite |   819.4 μs |    90.83 μs |  47.15 μs |   711.0 μs |  1,027.8 μs | 1,220.4 |     - |     - |     - |     17 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson |   843.5 μs |    85.89 μs |  45.73 μs |   621.0 μs |    972.6 μs | 1,185.5 |     - |     - |     - |      7 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   912.7 μs |    68.99 μs |  37.73 μs |   815.2 μs |  1,061.2 μs | 1,095.6 |     - |     - |     - |     11 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   917.1 μs |   118.79 μs |  61.65 μs |   746.7 μs |  1,283.1 μs | 1,090.4 |     - |     - |     - |     10 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   921.5 μs |   115.19 μs |  57.68 μs |   722.5 μs |  1,212.1 μs | 1,085.2 |     - |     - |     - |     20 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   959.4 μs |   177.67 μs |  93.38 μs |   726.5 μs |  1,535.2 μs | 1,042.3 |     - |     - |     - |      7 KB |
