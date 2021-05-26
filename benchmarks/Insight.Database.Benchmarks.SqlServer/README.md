# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Sql Server

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.300
  [Host]   : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  ShortRun : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT


```
|                                    Method |                  Type |        Mean |      StdDev |       Error |        Min |         Max |     Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------------------- |------------:|------------:|------------:|-----------:|------------:|---------:|------:|------:|------:|----------:|
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |    335.5 μs |    49.73 μs |    26.83 μs |   284.4 μs |    546.9 μs | 2,981.02 |     - |     - |     - |     12 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |    351.8 μs |    41.56 μs |    22.13 μs |   292.6 μs |    450.8 μs | 2,842.71 |     - |     - |     - |     12 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |    383.1 μs |    46.26 μs |    24.01 μs |   313.2 μs |    474.4 μs | 2,610.23 |     - |     - |     - |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |    383.5 μs |    30.62 μs |    15.51 μs |   314.9 μs |    456.2 μs | 2,607.36 |     - |     - |     - |     13 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |    387.3 μs |    30.50 μs |    15.83 μs |   301.9 μs |    442.7 μs | 2,581.85 |     - |     - |     - |     12 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |    387.4 μs |    43.95 μs |    22.81 μs |   300.9 μs |    498.5 μs | 2,581.39 |     - |     - |     - |     12 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |    387.7 μs |    29.69 μs |    15.61 μs |   304.7 μs |    452.9 μs | 2,579.18 |     - |     - |     - |     11 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |    388.9 μs |    42.38 μs |    21.73 μs |   312.1 μs |    476.7 μs | 2,571.43 |     - |     - |     - |     14 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |    390.4 μs |    45.11 μs |    23.71 μs |   307.2 μs |    488.4 μs | 2,561.37 |     - |     - |     - |     14 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |    390.7 μs |    55.41 μs |    28.76 μs |   315.1 μs |    588.5 μs | 2,559.34 |     - |     - |     - |     12 KB |
|                                    Single | InsightBenchmarkWrite |    391.6 μs |    35.49 μs |    18.20 μs |   310.2 μs |    473.2 μs | 2,553.95 |     - |     - |     - |     14 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |    392.0 μs |    28.98 μs |    15.04 μs |   306.5 μs |    464.1 μs | 2,551.24 |     - |     - |     - |     12 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |    398.1 μs |    33.50 μs |    16.97 μs |   315.7 μs |    488.5 μs | 2,512.22 |     - |     - |     - |     12 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |    398.1 μs |    40.02 μs |    20.04 μs |   318.0 μs |    476.0 μs | 2,511.76 |     - |     - |     - |     13 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |    398.6 μs |    25.02 μs |    12.83 μs |   349.6 μs |    448.1 μs | 2,508.51 |     - |     - |     - |     12 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |    399.6 μs |    36.94 μs |    18.94 μs |   326.6 μs |    465.6 μs | 2,502.68 |     - |     - |     - |     13 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |    400.2 μs |    30.84 μs |    15.81 μs |   346.2 μs |    455.4 μs | 2,498.48 |     - |     - |     - |     13 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |    403.6 μs |    42.72 μs |    22.18 μs |   323.5 μs |    476.5 μs | 2,477.79 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |    404.8 μs |    46.26 μs |    23.72 μs |   311.8 μs |    551.0 μs | 2,470.65 |     - |     - |     - |     13 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |    405.6 μs |    34.85 μs |    18.80 μs |   318.4 μs |    503.7 μs | 2,465.43 |     - |     - |     - |     14 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |    406.4 μs |    35.76 μs |    18.33 μs |   333.2 μs |    495.9 μs | 2,460.70 |     - |     - |     - |     12 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |    407.5 μs |    46.57 μs |    24.79 μs |   320.4 μs |    493.3 μs | 2,454.17 |     - |     - |     - |     14 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |    414.2 μs |   139.50 μs |    74.27 μs |   305.8 μs |  1,100.7 μs | 2,414.20 |     - |     - |     - |     14 KB |
|                                    Single |      InsightBenchmark |    416.1 μs |    47.71 μs |    25.08 μs |   331.9 μs |    546.6 μs | 2,403.17 |     - |     - |     - |     14 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |    416.2 μs |    43.14 μs |    22.67 μs |   329.3 μs |    529.3 μs | 2,402.53 |     - |     - |     - |     13 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |    416.4 μs |    47.57 μs |    24.69 μs |   313.9 μs |    561.8 μs | 2,401.49 |     - |     - |     - |     14 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |    420.7 μs |    34.72 μs |    18.49 μs |   330.8 μs |    512.3 μs | 2,377.03 |     - |     - |     - |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |    421.3 μs |    45.56 μs |    23.94 μs |   326.9 μs |    515.1 μs | 2,373.66 |     - |     - |     - |     13 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |    421.3 μs |    28.76 μs |    14.93 μs |   357.2 μs |    483.3 μs | 2,373.48 |     - |     - |     - |     15 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |    428.1 μs |   244.31 μs |   146.23 μs |   294.6 μs |  1,647.0 μs | 2,336.16 |     - |     - |     - |     12 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |    432.1 μs |    62.74 μs |    33.85 μs |   359.2 μs |    658.2 μs | 2,314.23 |     - |     - |     - |     12 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |    434.3 μs |    54.39 μs |    28.23 μs |   343.0 μs |    581.3 μs | 2,302.37 |     - |     - |     - |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |    435.9 μs |    92.52 μs |    49.26 μs |   320.2 μs |    715.5 μs | 2,294.29 |     - |     - |     - |     13 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |    440.2 μs |    53.28 μs |    26.68 μs |   378.5 μs |    569.5 μs | 2,271.44 |     - |     - |     - |     42 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |    441.8 μs |    71.87 μs |    36.85 μs |   341.7 μs |    657.3 μs | 2,263.46 |     - |     - |     - |     15 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |    449.6 μs |    35.06 μs |    18.43 μs |   355.4 μs |    522.4 μs | 2,224.24 |     - |     - |     - |     15 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |    474.9 μs |    40.21 μs |    20.87 μs |   382.5 μs |    536.5 μs | 2,105.59 |     - |     - |     - |     42 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |    488.3 μs |    71.15 μs |    36.48 μs |   360.7 μs |    717.5 μs | 2,048.10 |     - |     - |     - |     16 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |    489.6 μs |    61.66 μs |    32.00 μs |   405.8 μs |    682.9 μs | 2,042.53 |     - |     - |     - |     16 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |    507.5 μs |    59.66 μs |    30.96 μs |   400.0 μs |    610.0 μs | 1,970.48 |     - |     - |     - |     15 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |    511.8 μs |    71.07 μs |    36.44 μs |   419.0 μs |    657.6 μs | 1,953.79 |     - |     - |     - |     17 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |    516.9 μs |    52.70 μs |    27.35 μs |   428.9 μs |    614.3 μs | 1,934.59 |     - |     - |     - |     14 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |    525.2 μs |    73.21 μs |    38.98 μs |   424.2 μs |    840.7 μs | 1,904.18 |     - |     - |     - |     14 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |    526.2 μs |    46.12 μs |    23.94 μs |   444.8 μs |    591.3 μs | 1,900.28 |     - |     - |     - |     14 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |    526.3 μs |    46.90 μs |    24.65 μs |   441.9 μs |    632.0 μs | 1,900.21 |     - |     - |     - |     15 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml |    528.8 μs |    38.51 μs |    21.06 μs |   482.6 μs |    671.5 μs | 1,890.90 |     - |     - |     - |     68 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |    529.8 μs |    46.69 μs |    23.11 μs |   449.9 μs |    631.3 μs | 1,887.56 |     - |     - |     - |     15 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |    531.6 μs |    45.07 μs |    23.69 μs |   440.8 μs |    622.4 μs | 1,881.14 |     - |     - |     - |     15 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |    539.2 μs |    53.62 μs |    27.49 μs |   433.9 μs |    629.8 μs | 1,854.64 |     - |     - |     - |     16 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |    541.0 μs |    53.50 μs |    27.10 μs |   450.8 μs |    626.3 μs | 1,848.42 |     - |     - |     - |     17 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |    543.3 μs |    52.90 μs |    28.54 μs |   479.9 μs |    732.8 μs | 1,840.67 |     - |     - |     - |     68 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |    547.3 μs |    47.24 μs |    23.93 μs |   438.5 μs |    626.1 μs | 1,827.12 |     - |     - |     - |     16 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |    555.5 μs |    56.49 μs |    29.69 μs |   451.8 μs |    706.3 μs | 1,800.17 |     - |     - |     - |     15 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |    559.6 μs |    45.46 μs |    23.31 μs |   448.7 μs |    643.6 μs | 1,787.05 |     - |     - |     - |     17 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |    565.1 μs |    55.63 μs |    29.24 μs |   462.6 μs |    740.5 μs | 1,769.72 |     - |     - |     - |     14 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |    590.1 μs |    50.98 μs |    25.83 μs |   516.2 μs |    784.2 μs | 1,694.53 |     - |     - |     - |     16 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |    593.4 μs |    47.45 μs |    24.94 μs |   460.4 μs |    713.4 μs | 1,685.34 |     - |     - |     - |     16 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |    599.1 μs |    83.42 μs |    43.30 μs |   491.6 μs |    920.3 μs | 1,669.05 |     - |     - |     - |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |    600.9 μs |    44.00 μs |    22.29 μs |   484.9 μs |    715.4 μs | 1,664.14 |     - |     - |     - |     17 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |    601.0 μs |    67.04 μs |    34.37 μs |   469.2 μs |    773.7 μs | 1,663.97 |     - |     - |     - |     16 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    602.1 μs |    48.68 μs |    24.96 μs |   479.1 μs |    684.3 μs | 1,660.98 |     - |     - |     - |     18 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |    611.3 μs |    38.61 μs |    19.79 μs |   527.9 μs |    777.3 μs | 1,635.77 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    620.6 μs |    43.70 μs |    22.14 μs |   508.8 μs |    714.6 μs | 1,611.39 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    623.9 μs |    85.55 μs |    44.96 μs |   470.4 μs |    823.9 μs | 1,602.72 |     - |     - |     - |     17 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    639.9 μs |   143.17 μs |    73.40 μs |   455.1 μs |  1,276.5 μs | 1,562.72 |     - |     - |     - |     18 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |    644.5 μs |    54.60 μs |    28.70 μs |   520.1 μs |    833.3 μs | 1,551.70 |     - |     - |     - |     45 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |    644.6 μs |    37.19 μs |    19.55 μs |   556.5 μs |    758.2 μs | 1,551.43 |     - |     - |     - |     44 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml |    670.4 μs |    57.36 μs |    29.41 μs |   587.4 μs |    821.5 μs | 1,491.63 |     - |     - |     - |     71 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |    692.8 μs |   651.82 μs |   342.59 μs |   343.1 μs |  2,802.5 μs | 1,443.36 |     - |     - |     - |     15 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml |    781.2 μs |    85.07 μs |    44.71 μs |   625.9 μs |    990.6 μs | 1,280.00 |     - |     - |     - |     71 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |    787.8 μs | 1,000.99 μs |   526.12 μs |   425.2 μs |  6,545.2 μs | 1,269.43 |     - |     - |     - |     15 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  1,299.3 μs | 1,904.94 μs |   965.07 μs |   463.1 μs |  8,795.5 μs |   769.64 |     - |     - |     - |     15 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  7,313.8 μs |   724.24 μs |   358.53 μs | 6,638.5 μs |  9,685.0 μs |   136.73 |     - |     - |     - |     37 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  7,656.7 μs |   633.32 μs |   313.52 μs | 6,886.3 μs |  9,069.8 μs |   130.60 |     - |     - |     - |     35 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 10,173.6 μs | 2,604.36 μs | 1,319.40 μs | 7,163.7 μs | 18,077.3 μs |    98.29 |     - |     - |     - |     35 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 11,987.5 μs | 4,261.39 μs | 2,211.80 μs | 6,926.5 μs | 21,615.2 μs |    83.42 |     - |     - |     - |     37 KB |
|                                           |                       |             |             |             |            |             |          |       |       |       |           |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite |    698.4 μs |    78.24 μs |    43.39 μs |   631.5 μs |    994.0 μs | 1,431.78 |     - |     - |     - |     17 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite |    707.0 μs |   109.11 μs |    58.09 μs |   584.9 μs |  1,057.2 μs | 1,414.50 |     - |     - |     - |      7 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |    756.0 μs |    76.74 μs |    39.83 μs |   622.4 μs |    935.2 μs | 1,322.68 |     - |     - |     - |     11 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |    794.3 μs |    73.23 μs |    38.99 μs |   701.1 μs |    977.0 μs | 1,258.94 |     - |     - |     - |     10 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson |    807.2 μs |    86.24 μs |    43.18 μs |   701.5 μs |  1,097.1 μs | 1,238.86 |     - |     - |     - |      7 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |    890.8 μs |   144.96 μs |    77.18 μs |   747.5 μs |  1,550.1 μs | 1,122.65 |     - |     - |     - |     20 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml |    928.0 μs |    93.80 μs |    48.09 μs |   753.6 μs |  1,244.9 μs | 1,077.61 |     - |     - |     - |      7 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml |    977.4 μs |   261.07 μs |   139.00 μs |   761.0 μs |  2,271.8 μs | 1,023.13 |     - |     - |     - |     11 KB |
