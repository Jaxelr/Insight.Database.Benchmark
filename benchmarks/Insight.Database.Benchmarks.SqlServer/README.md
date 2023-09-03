# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                                    Method |                  Type |        Mean |     StdDev |       Error |      Median |        Min |         Max |     Op/s | Allocated |
|------------------------------------------ |---------------------- |------------:|-----------:|------------:|------------:|-----------:|------------:|---------:|----------:|
|                                    Single | InsightBenchmarkWrite |    753.3 μs |   240.6 μs |   121.90 μs |    706.5 μs |   485.8 μs |  1,451.4 μs | 1,327.54 |  15.17 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |    838.6 μs |   228.9 μs |   115.96 μs |    753.2 μs |   571.5 μs |  1,368.5 μs | 1,192.41 |  13.66 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |    918.3 μs |   249.6 μs |   125.00 μs |    868.9 μs |   631.7 μs |  1,820.2 μs | 1,089.00 |     50 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |    918.4 μs |   228.5 μs |   115.74 μs |    863.7 μs |   625.4 μs |  1,556.4 μs | 1,088.80 |  50.55 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |    956.5 μs |   252.6 μs |   126.46 μs |    994.5 μs |   524.3 μs |  1,433.9 μs | 1,045.51 |  46.56 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |    957.0 μs |   258.3 μs |   130.85 μs |    865.5 μs |   677.6 μs |  1,710.5 μs | 1,044.95 |  13.66 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |    959.9 μs |   176.6 μs |    88.42 μs |    913.1 μs |   691.9 μs |  1,521.8 μs | 1,041.75 |  17.03 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |    997.8 μs |   300.8 μs |   152.37 μs |    888.5 μs |   623.5 μs |  1,679.2 μs | 1,002.24 |  46.58 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |  1,115.3 μs |   202.5 μs |   101.42 μs |  1,154.0 μs |   736.2 μs |  1,481.2 μs |   896.60 |  15.57 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |  1,141.0 μs |   346.6 μs |   175.59 μs |  1,171.5 μs |   543.4 μs |  1,756.4 μs |   876.40 |  18.27 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |  1,144.0 μs |   223.7 μs |   110.73 μs |  1,143.6 μs |   810.0 μs |  1,707.2 μs |   874.15 |  13.66 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  1,146.4 μs |   220.3 μs |   114.37 μs |  1,072.5 μs |   893.4 μs |  1,869.6 μs |   872.33 |  18.78 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |  1,172.2 μs |   243.6 μs |   123.40 μs |  1,090.9 μs |   864.9 μs |  1,849.1 μs |   853.11 |  16.76 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |  1,182.2 μs |   333.7 μs |   171.11 μs |  1,172.3 μs |   634.0 μs |  1,903.8 μs |   845.90 |  13.97 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |  1,193.2 μs |   258.9 μs |   129.65 μs |  1,140.7 μs |   882.4 μs |  1,877.6 μs |   838.09 |   16.1 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |  1,266.7 μs |   320.8 μs |   162.51 μs |  1,294.0 μs |   703.6 μs |  1,740.0 μs |   789.46 |  13.66 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  1,300.1 μs |   246.4 μs |   123.39 μs |  1,294.0 μs |   893.1 μs |  1,858.8 μs |   769.15 |  18.78 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |  1,308.4 μs |   252.5 μs |   125.00 μs |  1,312.7 μs |   812.1 μs |  1,890.0 μs |   764.29 |  15.57 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |  1,321.9 μs |   241.6 μs |   120.95 μs |  1,300.0 μs |   867.9 μs |  1,758.4 μs |   756.51 |  14.52 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |  1,322.2 μs |   337.4 μs |   175.11 μs |  1,243.0 μs |   854.7 μs |  1,917.8 μs |   756.34 |  18.54 KB |
|                                    Single |      InsightBenchmark |  1,422.0 μs |   224.6 μs |   111.17 μs |  1,400.6 μs |   966.5 μs |  1,938.6 μs |   703.22 |  15.17 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |  1,522.3 μs |   648.9 μs |   328.73 μs |  1,289.5 μs |   894.8 μs |  3,065.3 μs |   656.90 |  13.01 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |  1,569.3 μs |   330.1 μs |   165.30 μs |  1,605.1 μs |   972.6 μs |  2,259.4 μs |   637.24 |  13.01 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  1,689.9 μs |   352.6 μs |   176.57 μs |  1,677.4 μs |   988.0 μs |  2,445.6 μs |   591.74 |  16.38 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |  1,707.6 μs |   450.3 μs |   225.47 μs |  1,832.2 μs |   878.2 μs |  2,439.6 μs |   585.61 |   18.2 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1,709.2 μs |   502.3 μs |   251.50 μs |  1,573.4 μs | 1,012.0 μs |  2,843.8 μs |   585.08 |  17.03 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |  1,771.9 μs |   525.7 μs |   269.52 μs |  1,543.0 μs | 1,259.8 μs |  3,188.2 μs |   564.35 |  15.16 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |  1,775.3 μs |   465.6 μs |   238.72 μs |  1,643.4 μs |   997.0 μs |  2,706.7 μs |   563.27 |  16.76 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |  1,864.5 μs |   260.9 μs |   132.16 μs |  1,906.5 μs | 1,426.1 μs |  2,309.9 μs |   536.34 |  19.55 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |  1,881.6 μs |   452.0 μs |   226.32 μs |  1,731.8 μs | 1,151.7 μs |  2,657.0 μs |   531.46 |  13.65 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |  1,916.2 μs |   691.6 μs |   342.37 μs |  1,663.2 μs | 1,064.2 μs |  3,837.0 μs |   521.88 |  13.65 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |  1,982.4 μs |   334.5 μs |   171.52 μs |  1,991.2 μs | 1,407.8 μs |  2,621.1 μs |   504.45 |  12.99 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2,100.1 μs |   283.4 μs |   140.31 μs |  2,079.4 μs | 1,619.9 μs |  2,957.2 μs |   476.17 |  12.99 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |  2,161.5 μs |   311.2 μs |   155.82 μs |  2,128.5 μs | 1,699.9 μs |  3,015.5 μs |   462.65 |  17.88 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |  2,163.3 μs |   675.5 μs |   338.23 μs |  1,964.8 μs | 1,427.2 μs |  3,714.8 μs |   462.26 |  15.48 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |  2,163.9 μs |   499.3 μs |   247.16 μs |  1,987.7 μs | 1,599.5 μs |  3,551.7 μs |   462.14 |  13.65 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |  2,274.1 μs |   832.8 μs |   417.01 μs |  1,965.0 μs | 1,378.0 μs |  4,466.6 μs |   439.73 |  15.63 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |  2,279.0 μs |   753.3 μs |   395.93 μs |  1,990.8 μs | 1,536.1 μs |  4,498.2 μs |   438.78 |  15.16 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |  2,296.9 μs |   602.9 μs |   301.90 μs |  2,096.9 μs | 1,624.0 μs |  3,782.3 μs |   435.36 |  14.52 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |  2,355.2 μs |   688.4 μs |   344.70 μs |  2,117.8 μs | 1,606.0 μs |  4,078.6 μs |   424.60 |  15.48 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |  2,413.7 μs |   806.1 μs |   418.39 μs |  2,033.0 μs | 1,487.1 μs |  4,222.2 μs |   414.31 |  13.01 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |  2,417.8 μs |   651.9 μs |   330.25 μs |  2,185.5 μs | 1,489.0 μs |  3,643.0 μs |   413.60 |  15.63 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |  2,450.8 μs |   387.7 μs |   194.11 μs |  2,413.4 μs | 1,816.4 μs |  3,582.2 μs |   408.03 |   17.3 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |  2,471.2 μs |   578.1 μs |   300.03 μs |  2,301.3 μs | 1,728.0 μs |  3,857.3 μs |   404.66 |  19.36 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |  2,474.1 μs |   472.2 μs |   239.23 μs |  2,427.6 μs | 1,772.4 μs |  3,559.0 μs |   404.19 |   14.5 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2,490.1 μs |   473.0 μs |   239.64 μs |  2,412.4 μs | 1,730.4 μs |  3,440.9 μs |   401.59 |  13.01 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |  2,494.0 μs |   840.9 μs |   426.02 μs |  2,552.1 μs | 1,304.8 μs |  3,954.2 μs |   400.97 |  13.97 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2,520.7 μs |   502.7 μs |   251.72 μs |  2,380.1 μs | 1,869.5 μs |  3,821.3 μs |   396.72 |   17.3 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |  2,555.9 μs |   543.5 μs |   272.16 μs |  2,408.2 μs | 1,836.0 μs |  3,803.3 μs |   391.26 |  18.16 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  2,569.1 μs |   717.7 μs |   359.37 μs |  2,249.2 μs | 1,711.1 μs |  4,244.9 μs |   389.24 |  37.23 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |  2,592.8 μs |   717.3 μs |   355.11 μs |  2,352.8 μs | 1,854.6 μs |  5,348.6 μs |   385.68 |  68.34 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |  2,598.7 μs |   578.6 μs |   293.14 μs |  2,435.1 μs | 1,977.0 μs |  4,226.5 μs |   384.81 |  19.55 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |  2,600.1 μs |   865.4 μs |   443.69 μs |  2,509.2 μs | 1,564.5 μs |  4,317.4 μs |   384.61 |  14.78 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |  2,601.3 μs |   755.1 μs |   378.07 μs |  2,315.0 μs | 1,539.5 μs |  4,467.6 μs |   384.43 |  16.65 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |  2,664.9 μs |   550.7 μs |   272.60 μs |  2,496.7 μs | 1,828.2 μs |  3,762.8 μs |   375.25 |  17.88 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |  2,674.1 μs |   837.9 μs |   419.54 μs |  2,177.5 μs | 1,666.6 μs |  4,052.8 μs |   373.96 |  15.48 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |  2,747.9 μs |   689.4 μs |   345.21 μs |  2,468.7 μs | 1,831.2 μs |  3,951.6 μs |   363.92 |  13.65 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |  2,748.1 μs |   617.1 μs |   305.48 μs |  2,858.7 μs | 1,796.7 μs |  3,849.7 μs |   363.89 |  13.97 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |  2,751.7 μs |   648.9 μs |   321.25 μs |  2,752.0 μs | 1,752.9 μs |  4,163.8 μs |   363.41 |  12.99 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |  2,754.5 μs |   827.5 μs |   424.29 μs |  3,091.4 μs | 1,420.5 μs |  4,023.9 μs |   363.04 |  12.99 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |  2,787.0 μs |   591.5 μs |   296.19 μs |  2,781.2 μs | 1,666.0 μs |  4,258.3 μs |   358.81 |  13.97 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |  2,859.2 μs |   640.7 μs |   317.16 μs |  3,082.9 μs | 1,813.8 μs |  4,029.3 μs |   349.75 |  15.48 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  2,918.1 μs |   703.4 μs |   360.66 μs |  2,761.0 μs | 1,638.8 μs |  4,439.1 μs |   342.69 |   16.1 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  2,948.0 μs |   569.2 μs |   285.01 μs |  2,872.6 μs | 2,082.3 μs |  4,157.3 μs |   339.21 |  16.92 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml |  2,999.5 μs |   558.4 μs |   279.61 μs |  2,920.4 μs | 2,116.9 μs |  4,124.9 μs |   333.39 |  72.34 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml |  3,034.7 μs |   522.4 μs |   258.62 μs |  2,893.1 μs | 2,385.1 μs |  4,794.7 μs |   329.52 |  77.45 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |  3,081.0 μs |   876.8 μs |   439.01 μs |  3,306.7 μs | 1,695.7 μs |  5,539.1 μs |   324.57 |  16.65 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  3,162.0 μs |   835.5 μs |   413.59 μs |  3,358.8 μs | 1,797.1 μs |  4,819.3 μs |   316.26 |  18.81 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |  3,200.4 μs |   555.5 μs |   278.16 μs |  3,277.4 μs | 1,883.3 μs |  4,232.3 μs |   312.46 |   17.3 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  3,221.3 μs |   760.9 μs |   376.66 μs |  3,468.1 μs | 1,775.5 μs |  4,346.1 μs |   310.44 |  16.38 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  3,281.6 μs |   475.2 μs |   235.23 μs |  3,310.6 μs | 2,340.1 μs |  4,651.5 μs |   304.73 |  35.46 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |  3,320.4 μs |   641.3 μs |   328.78 μs |  3,458.9 μs | 2,212.8 μs |  4,517.6 μs |   301.17 |  16.65 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml |  3,388.5 μs |   573.2 μs |   283.75 μs |  3,406.0 μs | 2,280.1 μs |  4,694.0 μs |   295.11 |  68.36 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |  3,559.8 μs |   535.1 μs |   267.95 μs |  3,722.8 μs | 2,300.4 μs |  4,572.8 μs |   280.91 |   18.7 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  5,908.0 μs |   857.3 μs |   434.31 μs |  5,963.0 μs | 4,491.8 μs |  7,891.8 μs |   169.26 |  37.23 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  6,290.3 μs | 2,158.2 μs | 1,106.55 μs |  4,905.9 μs | 4,107.3 μs | 11,840.5 μs |   158.98 |  35.46 KB |
|                                           |                       |             |            |             |             |            |             |          |           |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |  2,721.4 μs |   175.0 μs |    89.75 μs |  2,701.8 μs | 2,406.7 μs |  3,083.1 μs |   367.46 |  12.31 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson |  2,835.0 μs |   302.6 μs |   155.15 μs |  2,724.0 μs | 2,360.2 μs |  3,710.3 μs |   352.74 |   8.14 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml |  8,135.7 μs | 1,492.2 μs |   784.32 μs |  8,326.3 μs | 4,795.5 μs | 11,315.2 μs |   122.91 |   8.14 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  8,853.1 μs | 2,251.9 μs | 1,127.59 μs |  9,001.6 μs | 5,082.9 μs | 14,081.1 μs |   112.95 |  12.42 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite |  8,890.5 μs | 1,121.9 μs |   568.36 μs |  9,052.5 μs | 6,107.1 μs | 10,917.9 μs |   112.48 |  18.22 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml |  9,198.5 μs | 1,444.1 μs |   731.61 μs |  9,084.8 μs | 6,875.1 μs | 12,511.4 μs |   108.71 |  12.29 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 11,574.5 μs | 2,108.5 μs | 1,055.79 μs | 11,615.3 μs | 8,242.0 μs | 16,480.2 μs |    86.40 |   8.14 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 11,717.0 μs | 2,594.2 μs | 1,284.24 μs | 10,894.4 μs | 7,708.7 μs | 16,072.1 μs |    85.35 |  21.72 KB |
