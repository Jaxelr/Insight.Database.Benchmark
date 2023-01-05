# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

``` ini

BenchmarkDotNet=v0.13.3, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                                    Method |                  Type |       Mean |     StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|------------------------------------------ |---------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |   920.5 μs |   203.0 μs | 102.82 μs |   926.4 μs |   599.1 μs | 1,387.8 μs | 1,086.3 |  12.99 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |   967.5 μs |   217.0 μs | 108.64 μs |   925.9 μs |   631.9 μs | 1,530.0 μs | 1,033.6 |  18.16 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1,020.6 μs |   185.8 μs |  93.04 μs |   989.6 μs |   601.2 μs | 1,433.8 μs |   979.8 |   14.5 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1,065.0 μs |   184.6 μs |  92.42 μs | 1,065.3 μs |   757.4 μs | 1,529.2 μs |   939.0 |  13.66 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1,075.3 μs |   219.6 μs | 111.24 μs | 1,038.8 μs |   744.4 μs | 1,437.1 μs |   930.0 |  15.63 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1,084.3 μs |   167.6 μs |  85.95 μs | 1,034.2 μs |   802.1 μs | 1,510.1 μs |   922.2 |  13.65 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1,097.2 μs |   321.7 μs | 162.96 μs | 1,100.3 μs |   541.9 μs | 1,709.3 μs |   911.4 |  16.65 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1,123.8 μs |   193.2 μs |  96.75 μs | 1,125.3 μs |   721.6 μs | 1,465.6 μs |   889.8 |  13.66 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1,141.9 μs |   242.5 μs | 120.07 μs | 1,134.2 μs |   732.3 μs | 1,637.5 μs |   875.8 |  14.52 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1,146.6 μs |   201.3 μs |  99.63 μs | 1,143.5 μs |   792.6 μs | 1,519.7 μs |   872.2 |  15.57 KB |
|                                    Single | InsightBenchmarkWrite | 1,168.2 μs |   201.1 μs | 100.72 μs | 1,174.8 μs |   806.9 μs | 1,590.2 μs |   856.0 |  15.17 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1,169.6 μs |   228.5 μs | 117.18 μs | 1,220.2 μs |   663.2 μs | 1,535.9 μs |   855.0 |  12.99 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1,184.0 μs |   177.5 μs |  90.99 μs | 1,167.6 μs |   883.2 μs | 1,587.3 μs |   844.6 |  13.65 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1,215.6 μs |   292.1 μs | 146.28 μs | 1,211.0 μs |   699.5 μs | 1,924.1 μs |   822.6 |  13.97 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 1,215.9 μs |   295.6 μs | 146.32 μs | 1,172.3 μs |   683.2 μs | 1,929.7 μs |   822.4 |  15.16 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1,243.6 μs |   260.6 μs | 132.00 μs | 1,183.4 μs |   828.0 μs | 1,762.5 μs |   804.1 |  50.22 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,265.1 μs |   202.5 μs | 101.38 μs | 1,256.4 μs |   924.9 μs | 1,729.2 μs |   790.5 |  17.92 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1,267.9 μs |   327.3 μs | 165.79 μs | 1,251.4 μs |   732.6 μs | 1,925.1 μs |   788.7 |  16.76 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1,274.9 μs |   236.0 μs | 120.99 μs | 1,258.8 μs |   875.0 μs | 1,791.9 μs |   784.4 |  13.01 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1,300.7 μs |   216.0 μs | 109.43 μs | 1,317.9 μs |   864.1 μs | 1,721.3 μs |   768.8 |   18.5 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 1,303.1 μs |   343.5 μs | 170.04 μs | 1,311.0 μs |   772.3 μs | 2,076.6 μs |   767.4 |  13.01 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 1,310.1 μs |   479.7 μs | 245.95 μs | 1,299.7 μs |   668.0 μs | 2,589.6 μs |   763.3 |  14.52 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,314.3 μs |   213.5 μs | 105.70 μs | 1,324.2 μs |   810.6 μs | 1,696.4 μs |   760.9 |  46.56 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1,323.0 μs |   154.9 μs |  76.69 μs | 1,334.6 μs | 1,035.8 μs | 1,625.8 μs |   755.9 |  13.97 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1,323.3 μs |   231.8 μs | 117.45 μs | 1,315.4 μs |   889.6 μs | 1,834.3 μs |   755.7 |  15.16 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1,331.4 μs |   279.4 μs | 138.32 μs | 1,344.7 μs |   811.0 μs | 1,930.4 μs |   751.1 |  18.81 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1,352.5 μs |   177.2 μs |  89.75 μs | 1,359.8 μs |   855.0 μs | 1,662.9 μs |   739.4 |  13.01 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1,360.9 μs |   291.7 μs | 147.77 μs | 1,367.5 μs |   791.5 μs | 1,998.9 μs |   734.8 |  16.38 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,371.7 μs |   238.2 μs | 119.28 μs | 1,406.1 μs |   894.8 μs | 1,757.3 μs |   729.0 |  16.65 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,372.0 μs |   257.2 μs | 130.28 μs | 1,461.2 μs |   803.8 μs | 1,815.6 μs |   728.9 |  13.97 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1,381.3 μs |   272.3 μs | 136.33 μs | 1,395.8 μs |   854.4 μs | 1,844.5 μs |   723.9 |  18.27 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1,390.2 μs |   229.0 μs | 116.01 μs | 1,404.7 μs |   877.5 μs | 1,821.2 μs |   719.3 |  15.48 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1,394.2 μs |   234.6 μs | 118.84 μs | 1,449.2 μs |   834.2 μs | 1,793.2 μs |   717.3 |  13.97 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 1,409.3 μs |   337.7 μs | 175.29 μs | 1,457.5 μs |   742.7 μs | 2,012.7 μs |   709.5 |  17.61 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,411.6 μs |   430.5 μs | 220.73 μs | 1,613.8 μs |   736.2 μs | 2,002.7 μs |   708.4 |  18.78 KB |
|                                    Single |      InsightBenchmark | 1,419.3 μs |   189.1 μs |  94.68 μs | 1,407.5 μs | 1,046.7 μs | 1,837.8 μs |   704.6 |  15.17 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,422.2 μs |   281.9 μs | 142.83 μs | 1,412.9 μs |   911.7 μs | 1,972.5 μs |   703.1 |  16.65 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1,435.5 μs |   481.6 μs | 238.39 μs | 1,327.9 μs |   737.0 μs | 2,428.9 μs |   696.6 |  13.01 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1,440.6 μs |   328.1 μs | 164.27 μs | 1,439.3 μs |   823.6 μs | 2,392.1 μs |   694.2 |   16.1 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1,447.7 μs |   192.7 μs |  98.79 μs | 1,464.4 μs |   993.0 μs | 1,899.2 μs |   690.8 |  15.48 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1,468.8 μs |   198.2 μs | 100.40 μs | 1,482.2 μs | 1,029.2 μs | 1,890.5 μs |   680.8 |  46.58 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1,478.3 μs |   507.7 μs | 254.23 μs | 1,327.0 μs |   786.8 μs | 2,578.0 μs |   676.5 |  15.48 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1,486.4 μs |   405.7 μs | 208.00 μs | 1,565.7 μs |   831.1 μs | 2,242.7 μs |   672.8 |   17.3 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark | 1,497.3 μs |   229.5 μs | 113.62 μs | 1,457.5 μs | 1,095.7 μs | 2,105.6 μs |   667.9 |  13.66 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,514.0 μs |   285.9 μs | 141.53 μs | 1,527.1 μs |   981.8 μs | 2,172.7 μs |   660.5 |  19.28 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1,536.0 μs |   272.4 μs | 134.83 μs | 1,563.5 μs | 1,021.5 μs | 2,093.5 μs |   651.0 |  49.67 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,537.9 μs |   219.3 μs | 108.54 μs | 1,528.5 μs | 1,095.7 μs | 1,933.4 μs |   650.3 |  19.55 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1,572.4 μs |   283.4 μs | 143.55 μs | 1,590.5 μs |   937.3 μs | 2,023.7 μs |   636.0 |  16.76 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1,575.6 μs |   157.0 μs |  78.62 μs | 1,596.5 μs | 1,170.9 μs | 1,844.8 μs |   634.7 |   14.5 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark | 1,604.3 μs |   274.6 μs | 137.50 μs | 1,581.2 μs | 1,099.5 μs | 2,165.1 μs |   623.3 |  12.99 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1,613.8 μs |   342.7 μs | 175.72 μs | 1,523.8 μs | 1,008.0 μs | 2,381.0 μs |   619.6 |  15.63 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1,614.5 μs |   295.8 μs | 146.41 μs | 1,635.8 μs | 1,033.1 μs | 2,261.5 μs |   619.4 |  15.48 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1,650.5 μs |   383.5 μs | 192.01 μs | 1,657.6 μs |   885.5 μs | 2,586.0 μs |   605.9 |  13.66 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,731.9 μs |   303.5 μs | 151.95 μs | 1,734.5 μs |   934.2 μs | 2,563.2 μs |   577.4 |  16.76 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml | 1,734.5 μs |   195.3 μs | 101.38 μs | 1,720.3 μs | 1,354.3 μs | 2,212.6 μs |   576.5 |  68.36 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1,767.8 μs |   241.0 μs | 123.54 μs | 1,743.3 μs | 1,288.3 μs | 2,210.7 μs |   565.7 |   17.2 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1,769.6 μs |   278.2 μs | 137.71 μs | 1,812.9 μs | 1,207.3 μs | 2,422.8 μs |   565.1 |  17.72 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1,807.3 μs |   387.6 μs | 201.18 μs | 1,820.3 μs |   874.0 μs | 2,624.8 μs |   553.3 |  18.27 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,823.6 μs |   402.6 μs | 201.59 μs | 1,770.7 μs | 1,236.4 μs | 2,836.5 μs |   548.4 |  19.33 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1,847.6 μs |   401.7 μs | 198.86 μs | 1,777.6 μs | 1,140.1 μs | 2,778.8 μs |   541.3 |  18.81 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark | 1,854.3 μs |   297.3 μs | 148.86 μs | 1,880.4 μs | 1,215.3 μs | 2,429.2 μs |   539.3 |  16.65 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1,885.5 μs |   707.4 μs | 354.23 μs | 1,738.5 μs |   757.2 μs | 3,216.6 μs |   530.4 |  16.76 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1,889.4 μs |   344.3 μs | 172.42 μs | 1,781.0 μs | 1,306.3 μs | 2,763.1 μs |   529.3 |  13.65 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark | 1,927.9 μs |   366.3 μs | 183.39 μs | 1,945.5 μs | 1,190.0 μs | 2,724.9 μs |   518.7 |  12.99 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1,945.5 μs |   304.0 μs | 152.23 μs | 1,894.2 μs | 1,338.4 μs | 2,579.7 μs |   514.0 |  18.16 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml | 2,023.1 μs |   221.4 μs | 110.88 μs | 2,002.2 μs | 1,368.5 μs | 2,577.0 μs |   494.3 |  71.45 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 2,043.9 μs |   502.0 μs | 251.34 μs | 1,836.3 μs | 1,390.6 μs | 3,479.2 μs |   489.3 |   17.3 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 2,097.6 μs |   360.5 μs | 182.66 μs | 2,016.8 μs | 1,284.2 μs | 2,878.0 μs |   476.7 |  15.57 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml | 2,120.4 μs |   276.9 μs | 141.97 μs | 2,177.4 μs | 1,531.2 μs | 2,658.8 μs |   471.6 |  76.83 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 2,126.8 μs |   561.2 μs | 277.81 μs | 2,079.3 μs | 1,291.7 μs | 3,407.5 μs |   470.2 |  13.65 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 2,173.0 μs |   364.3 μs | 180.32 μs | 2,129.4 μs | 1,575.8 μs | 3,356.2 μs |   460.2 |  68.34 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 2,291.7 μs |   286.1 μs | 150.36 μs | 2,314.7 μs | 1,653.1 μs | 2,769.8 μs |   436.4 |  16.38 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 3,173.3 μs |   308.5 μs | 164.25 μs | 3,145.7 μs | 2,589.4 μs | 3,820.1 μs |   315.1 |  37.23 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3,450.6 μs |   305.1 μs | 154.55 μs | 3,371.0 μs | 2,736.2 μs | 4,259.3 μs |   289.8 |  35.46 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 3,773.2 μs |   625.8 μs | 309.80 μs | 3,577.8 μs | 2,794.2 μs | 5,340.2 μs |   265.0 |  35.46 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 4,915.2 μs | 1,566.3 μs | 793.50 μs | 4,638.8 μs | 2,827.9 μs | 9,543.8 μs |   203.5 |  37.23 KB |
|                                           |                       |            |            |           |            |            |            |         |           |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 4,333.9 μs |   827.4 μs | 414.29 μs | 4,034.0 μs | 3,304.1 μs | 6,589.1 μs |   230.7 |   8.14 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 4,656.0 μs |   865.2 μs | 454.77 μs | 4,447.7 μs | 3,441.9 μs | 7,201.5 μs |   214.8 |  12.31 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,955.4 μs |   528.5 μs | 264.62 μs | 5,025.6 μs | 3,844.0 μs | 5,993.3 μs |   201.8 |  12.15 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 4,965.3 μs |   822.6 μs | 407.23 μs | 4,746.2 μs | 3,766.4 μs | 7,363.8 μs |   201.4 |  12.29 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 5,027.3 μs |   607.3 μs | 304.09 μs | 4,982.0 μs | 4,093.3 μs | 6,495.2 μs |   198.9 |   8.14 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 5,032.5 μs | 1,217.9 μs | 609.81 μs | 5,053.9 μs | 3,457.2 μs | 9,051.6 μs |   198.7 |  18.22 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 5,117.7 μs |   719.9 μs | 364.73 μs | 4,997.9 μs | 3,775.6 μs | 7,848.9 μs |   195.4 |   8.14 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 5,128.1 μs |   631.6 μs | 316.23 μs | 5,054.8 μs | 4,105.2 μs | 6,566.2 μs |   195.0 |  21.99 KB |
