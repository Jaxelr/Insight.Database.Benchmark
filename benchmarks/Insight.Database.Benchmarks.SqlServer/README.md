# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                    Method |                  Type |       Mean |   StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|------------------------------------------ |---------------------- |-----------:|---------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|                                    Single | InsightBenchmarkWrite |   788.9 μs | 265.0 μs | 132.71 μs |   700.9 μs |   507.9 μs | 1,551.2 μs | 1,267.6 |  15.17 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |   808.2 μs | 197.3 μs | 102.39 μs |   742.2 μs |   563.9 μs | 1,208.2 μs | 1,237.3 |  18.27 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   818.9 μs | 154.0 μs |  80.93 μs |   774.8 μs |   659.6 μs | 1,406.3 μs | 1,221.1 |  13.65 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   826.7 μs | 265.1 μs | 137.58 μs |   856.4 μs |   458.2 μs | 1,415.1 μs | 1,209.7 |  13.66 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |   909.3 μs | 164.6 μs |  82.42 μs |   859.1 μs |   640.7 μs | 1,338.2 μs | 1,099.7 |  13.01 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   912.1 μs | 218.1 μs | 110.51 μs |   861.3 μs |   669.0 μs | 1,560.2 μs | 1,096.4 |  68.34 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   929.9 μs | 211.6 μs | 109.84 μs |   869.1 μs |   659.0 μs | 1,524.1 μs | 1,075.3 |  13.65 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   934.9 μs | 199.7 μs | 103.62 μs |   923.4 μs |   604.7 μs | 1,714.4 μs | 1,069.7 |  13.66 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   938.1 μs | 148.2 μs |  76.94 μs |   916.8 μs |   700.8 μs | 1,315.1 μs | 1,066.0 |   16.1 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   948.8 μs | 218.0 μs | 110.46 μs |   844.4 μs |   708.8 μs | 1,394.0 μs | 1,054.0 |  13.65 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |   954.5 μs | 208.8 μs | 104.56 μs |   928.4 μs |   674.0 μs | 1,505.5 μs | 1,047.7 |  14.52 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |   959.0 μs | 181.0 μs |  96.37 μs |   908.5 μs |   721.5 μs | 1,580.5 μs | 1,042.8 |  14.52 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |   963.4 μs | 278.4 μs | 139.40 μs |   872.2 μs |   641.8 μs | 1,615.5 μs | 1,038.0 |  13.01 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |   972.2 μs | 227.9 μs | 114.09 μs |   885.0 μs |   660.8 μs | 1,545.5 μs | 1,028.6 |  12.99 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |   984.0 μs | 226.4 μs | 120.54 μs |   917.2 μs |   732.6 μs | 1,790.0 μs | 1,016.2 |  17.88 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   984.3 μs | 183.7 μs |  99.09 μs |   931.0 μs |   779.4 μs | 1,673.9 μs | 1,016.0 |   17.3 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   989.4 μs | 155.3 μs |  81.64 μs |   966.2 μs |   750.1 μs | 1,372.7 μs | 1,010.7 |  15.48 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1,010.8 μs | 273.8 μs | 140.39 μs |   962.1 μs |   679.3 μs | 1,934.3 μs |   989.3 |  15.16 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1,017.8 μs | 231.4 μs | 118.64 μs |   973.9 μs |   644.7 μs | 1,885.1 μs |   982.5 |  17.58 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1,018.0 μs | 246.0 μs | 127.69 μs |   959.6 μs |   717.8 μs | 1,629.4 μs |   982.3 |  13.66 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,020.0 μs | 267.1 μs | 133.74 μs |   958.0 μs |   674.4 μs | 1,899.9 μs |   980.4 |  46.56 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1,022.1 μs | 251.1 μs | 127.19 μs | 1,013.4 μs |   677.0 μs | 1,520.0 μs |   978.4 |  13.65 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1,025.2 μs | 208.1 μs | 104.18 μs |   952.6 μs |   730.0 μs | 1,514.2 μs |   975.4 |  12.99 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1,030.3 μs | 256.4 μs | 126.93 μs |   989.2 μs |   672.8 μs | 1,569.4 μs |   970.6 |  13.01 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1,030.8 μs | 208.6 μs | 104.46 μs |   988.6 μs |   736.3 μs | 1,575.0 μs |   970.1 |   16.1 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 1,054.0 μs | 202.2 μs | 102.46 μs |   992.3 μs |   805.5 μs | 1,543.6 μs |   948.8 |   16.1 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1,054.5 μs | 274.2 μs | 135.75 μs | 1,075.7 μs |   581.9 μs | 1,516.0 μs |   948.3 |  13.01 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 1,057.5 μs | 244.8 μs | 124.00 μs | 1,019.0 μs |   726.5 μs | 1,761.5 μs |   945.6 |  15.16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1,064.0 μs | 219.1 μs | 113.73 μs | 1,032.7 μs |   769.1 μs | 1,656.3 μs |   939.8 |  16.65 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,066.0 μs | 196.5 μs | 100.73 μs |   993.8 μs |   840.8 μs | 1,744.8 μs |   938.1 |   16.1 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1,066.5 μs | 206.1 μs | 104.43 μs | 1,028.2 μs |   757.9 μs | 1,605.2 μs |   937.6 |  15.48 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1,074.3 μs | 207.1 μs | 104.92 μs | 1,022.5 μs |   780.0 μs | 1,590.2 μs |   930.8 |  18.16 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1,077.7 μs | 230.5 μs | 118.16 μs | 1,094.8 μs |   743.7 μs | 1,601.0 μs |   927.9 |  16.76 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1,085.5 μs | 235.3 μs | 126.92 μs | 1,009.8 μs |   786.5 μs | 1,604.1 μs |   921.2 |  50.82 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1,087.5 μs | 271.4 μs | 140.84 μs |   974.1 μs |   761.5 μs | 1,728.8 μs |   919.5 |  16.92 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1,092.5 μs | 342.3 μs | 173.39 μs | 1,057.5 μs |   532.8 μs | 1,840.7 μs |   915.3 |  17.87 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1,097.4 μs | 335.2 μs | 173.97 μs |   960.5 μs |   742.9 μs | 2,091.1 μs |   911.3 |  16.76 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml | 1,102.1 μs | 296.9 μs | 148.68 μs | 1,059.6 μs |   709.2 μs | 1,800.9 μs |   907.4 |  68.36 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 1,108.8 μs | 262.0 μs | 134.35 μs | 1,062.7 μs |   765.4 μs | 1,665.8 μs |   901.9 |  15.57 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1,109.5 μs | 384.1 μs | 194.59 μs | 1,068.0 μs |   553.2 μs | 1,930.2 μs |   901.3 |  16.76 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,118.3 μs | 322.5 μs | 165.36 μs | 1,064.0 μs |   740.7 μs | 2,250.5 μs |   894.2 |  16.76 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1,119.9 μs | 240.9 μs | 120.63 μs | 1,112.8 μs |   741.8 μs | 1,613.3 μs |   892.9 |  12.99 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,121.0 μs | 271.1 μs | 137.36 μs | 1,080.8 μs |   753.3 μs | 1,834.1 μs |   892.1 |  19.28 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1,130.3 μs | 216.1 μs | 113.59 μs | 1,122.3 μs |   763.1 μs | 1,729.9 μs |   884.7 |  15.57 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1,134.5 μs | 265.4 μs | 136.07 μs | 1,115.8 μs |   680.7 μs | 1,711.5 μs |   881.4 |  15.48 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1,134.6 μs | 269.4 μs | 133.38 μs | 1,098.8 μs |   712.6 μs | 1,823.2 μs |   881.4 |  13.97 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1,134.6 μs | 251.9 μs | 124.68 μs | 1,114.9 μs |   703.1 μs | 1,749.2 μs |   881.4 |  13.97 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1,146.8 μs | 315.0 μs | 155.93 μs | 1,070.2 μs |   745.6 μs | 1,783.5 μs |   872.0 |  15.63 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1,157.1 μs | 264.1 μs | 132.24 μs | 1,141.9 μs |   731.6 μs | 1,689.8 μs |   864.2 |   14.5 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1,177.0 μs | 350.5 μs | 175.49 μs | 1,043.9 μs |   802.0 μs | 2,357.2 μs |   849.6 |  18.27 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 1,179.4 μs | 250.1 μs | 125.25 μs | 1,144.1 μs |   827.0 μs | 1,867.0 μs |   847.9 |  18.16 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1,208.6 μs | 267.1 μs | 133.75 μs | 1,183.6 μs |   735.9 μs | 1,837.3 μs |   827.4 |  12.99 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,216.0 μs | 212.4 μs | 108.92 μs | 1,278.0 μs |   792.5 μs | 1,568.9 μs |   822.3 |  13.97 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1,221.6 μs | 244.1 μs | 125.17 μs | 1,300.1 μs |   769.0 μs | 1,699.3 μs |   818.6 |  15.48 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1,227.5 μs | 247.8 μs | 124.06 μs | 1,226.3 μs |   756.1 μs | 1,749.8 μs |   814.6 |  15.63 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1,235.6 μs | 272.7 μs | 136.56 μs | 1,203.7 μs |   820.0 μs | 1,796.7 μs |   809.3 |  18.81 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,244.6 μs | 270.6 μs | 135.52 μs | 1,272.2 μs |   813.5 μs | 1,810.2 μs |   803.5 |  18.78 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 1,244.8 μs | 317.7 μs | 162.91 μs | 1,336.2 μs |   703.8 μs | 1,778.7 μs |   803.3 |  13.66 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1,250.7 μs | 328.9 μs | 164.68 μs | 1,237.4 μs |   777.7 μs | 2,118.3 μs |   799.6 |  16.65 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1,250.8 μs | 214.2 μs | 107.27 μs | 1,289.7 μs |   897.8 μs | 1,719.0 μs |   799.5 |   14.5 KB |
|                                    Single |      InsightBenchmark | 1,260.5 μs | 259.4 μs | 129.87 μs | 1,221.8 μs |   765.2 μs | 1,917.6 μs |   793.4 |  15.17 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1,268.3 μs | 310.6 μs | 153.76 μs | 1,188.4 μs |   831.7 μs | 2,022.5 μs |   788.4 |  17.61 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1,276.5 μs | 297.5 μs | 152.52 μs | 1,291.0 μs |   767.4 μs | 1,862.2 μs |   783.4 |  18.81 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,287.6 μs | 341.0 μs | 176.97 μs | 1,205.3 μs |   795.4 μs | 2,203.4 μs |   776.6 |  18.78 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,344.7 μs | 340.4 μs | 176.67 μs | 1,327.4 μs |   856.9 μs | 2,158.7 μs |   743.6 |  19.83 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml | 1,347.8 μs | 390.9 μs | 202.87 μs | 1,205.6 μs |   881.8 μs | 2,333.4 μs |   742.0 |     72 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,351.8 μs | 394.5 μs | 195.30 μs | 1,351.8 μs |   697.9 μs | 2,182.4 μs |   739.7 |  16.65 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1,364.0 μs | 260.7 μs | 130.52 μs | 1,366.4 μs |   810.2 μs | 2,039.7 μs |   733.1 |  13.97 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1,406.5 μs | 312.1 μs | 158.11 μs | 1,430.8 μs |   932.7 μs | 1,997.5 μs |   711.0 |  49.67 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1,409.5 μs | 316.9 μs | 158.68 μs | 1,456.5 μs |   820.2 μs | 2,173.9 μs |   709.5 |  46.58 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml | 1,423.1 μs | 302.2 μs | 151.31 μs | 1,338.8 μs |   853.9 μs | 2,035.9 μs |   702.7 |  71.45 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,447.9 μs | 262.4 μs | 131.38 μs | 1,437.3 μs |   926.4 μs | 1,935.2 μs |   690.7 |   17.3 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 2,856.1 μs | 301.4 μs | 154.51 μs | 2,823.1 μs | 2,339.6 μs | 3,627.7 μs |   350.1 |  37.23 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 2,936.5 μs | 208.1 μs | 109.36 μs | 2,986.3 μs | 2,476.1 μs | 3,401.0 μs |   340.5 |  37.23 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3,261.9 μs | 257.3 μs | 130.36 μs | 3,248.6 μs | 2,794.3 μs | 4,174.9 μs |   306.6 |  35.46 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 3,350.5 μs | 253.9 μs | 128.64 μs | 3,344.9 μs | 2,804.4 μs | 4,010.4 μs |   298.5 |  35.46 KB |
|                                           |                       |            |          |           |            |            |            |         |           |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,021.0 μs | 438.1 μs | 221.95 μs | 2,931.4 μs | 2,426.2 μs | 4,332.6 μs |   331.0 |  11.88 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3,339.3 μs | 725.7 μs | 363.36 μs | 3,155.4 μs | 2,452.9 μs | 5,313.9 μs |   299.5 |   8.14 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 3,341.4 μs | 658.5 μs | 325.96 μs | 3,117.2 μs | 2,566.3 μs | 5,508.7 μs |   299.3 |  18.22 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 3,384.8 μs | 522.6 μs | 261.67 μs | 3,372.9 μs | 2,425.4 μs | 4,486.9 μs |   295.4 |   8.14 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3,580.7 μs | 632.5 μs | 316.69 μs | 3,404.4 μs | 2,790.2 μs | 5,241.4 μs |   279.3 |  12.31 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 3,629.3 μs | 454.6 μs | 235.93 μs | 3,505.1 μs | 3,002.6 μs | 4,877.1 μs |   275.5 |   8.14 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,631.3 μs | 682.9 μs | 341.93 μs | 3,488.5 μs | 2,537.5 μs | 5,602.4 μs |   275.4 |  21.45 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 3,768.3 μs | 551.4 μs | 276.12 μs | 3,752.2 μs | 2,816.8 μs | 4,744.2 μs |   265.4 |  12.29 KB |
