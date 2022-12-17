# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                                    Method |                  Type |       Mean |      StdDev |       Error |     Median |        Min |         Max |    Op/s | Allocated |
|------------------------------------------ |---------------------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|--------:|----------:|
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |   824.4 μs |   213.80 μs |   112.37 μs |   783.4 μs |   519.8 μs |  1,247.5 μs | 1,212.9 |  13.55 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |   833.5 μs |   226.59 μs |   112.17 μs |   801.9 μs |   500.1 μs |  1,577.2 μs | 1,199.7 |  12.88 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   840.0 μs |   134.17 μs |    67.97 μs |   844.9 μs |   626.3 μs |  1,224.6 μs | 1,190.4 |  16.64 KB |
|                                    Single |      InsightBenchmark |   857.5 μs |   188.18 μs |    96.48 μs |   816.2 μs |   558.7 μs |  1,369.1 μs | 1,166.2 |  15.05 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   862.2 μs |   184.34 μs |    96.89 μs |   839.3 μs |   557.6 μs |  1,426.3 μs | 1,159.9 |  16.53 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   888.5 μs |   267.86 μs |   137.33 μs |   875.9 μs |   470.9 μs |  1,302.5 μs | 1,125.5 |  13.55 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   903.1 μs |   206.89 μs |   106.07 μs |   834.7 μs |   711.3 μs |  1,550.9 μs | 1,107.3 |  12.89 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml |   939.0 μs |   217.41 μs |   112.84 μs |   886.9 μs |   687.3 μs |  1,547.2 μs | 1,064.9 |  68.24 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   956.6 μs |   202.21 μs |   101.25 μs |   921.2 μs |   694.6 μs |  1,600.0 μs | 1,045.4 |  13.55 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   958.5 μs |   192.27 μs |    97.41 μs |   872.9 μs |   733.3 μs |  1,382.4 μs | 1,043.3 |  68.23 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |   961.7 μs |   177.61 μs |    92.18 μs |   902.6 μs |   728.8 μs |  1,522.5 μs | 1,039.8 |  16.53 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |   964.8 μs |   240.39 μs |   123.25 μs |   905.4 μs |   639.6 μs |  1,568.1 μs | 1,036.5 |  12.88 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   964.9 μs |   219.82 μs |   108.82 μs |   928.1 μs |   680.5 μs |  1,588.3 μs | 1,036.3 |  13.53 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |   965.2 μs |   221.46 μs |   112.20 μs |   932.6 μs |   678.2 μs |  1,630.3 μs | 1,036.1 |  12.88 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   965.4 μs |   155.96 μs |    79.96 μs |   931.7 μs |   744.7 μs |  1,414.8 μs | 1,035.9 |  15.51 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   967.5 μs |   241.38 μs |   123.76 μs |   880.1 μs |   696.8 μs |  1,693.8 μs | 1,033.6 |  13.55 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   969.1 μs |   240.43 μs |   121.80 μs |   910.7 μs |   681.1 μs |  1,702.7 μs | 1,031.8 |  13.53 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   973.9 μs |   145.77 μs |    76.61 μs |   983.9 μs |   716.2 μs |  1,360.0 μs | 1,026.8 |  14.13 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark | 1,002.5 μs |   239.63 μs |   121.40 μs |   947.6 μs |   684.8 μs |  1,564.8 μs |   997.5 |  18.15 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 1,004.8 μs |   295.94 μs |   155.54 μs |   874.0 μs |   677.5 μs |  1,618.7 μs |   995.2 |  16.95 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite | 1,021.5 μs |   285.45 μs |   141.31 μs |   972.5 μs |   662.6 μs |  1,665.4 μs |   979.0 |  18.04 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite | 1,022.2 μs |   146.27 μs |    76.88 μs | 1,007.7 μs |   758.7 μs |  1,504.5 μs |   978.3 |   18.7 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1,025.0 μs |   148.48 μs |    76.13 μs | 1,020.8 μs |   800.0 μs |  1,362.2 μs |   975.6 |  13.85 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite | 1,033.2 μs |   252.30 μs |   127.82 μs |   939.0 μs |   729.7 μs |  1,686.7 μs |   967.9 |  12.88 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,047.9 μs |   223.81 μs |   112.07 μs |   986.6 μs |   751.7 μs |  1,552.7 μs |   954.3 |  16.53 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,050.6 μs |   207.43 μs |   107.66 μs | 1,039.5 μs |   785.4 μs |  1,721.3 μs |   951.8 |  15.98 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark | 1,054.2 μs |   194.15 μs |    97.22 μs | 1,022.3 μs |   790.3 μs |  1,585.4 μs |   948.5 |  15.36 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1,055.4 μs |   158.03 μs |    79.13 μs | 1,044.6 μs |   771.0 μs |  1,492.1 μs |   947.5 |  13.85 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1,059.6 μs |   140.96 μs |    72.27 μs | 1,051.0 μs |   804.8 μs |  1,393.7 μs |   943.7 |  17.19 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1,064.6 μs |   191.99 μs |    96.13 μs | 1,052.5 μs |   788.2 μs |  1,633.0 μs |   939.4 |  16.64 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1,064.6 μs |   172.08 μs |    86.16 μs | 1,027.8 μs |   790.5 μs |  1,537.3 μs |   939.3 |  13.53 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark | 1,065.8 μs |   157.32 μs |    79.70 μs | 1,045.9 μs |   816.5 μs |  1,447.5 μs |   938.3 |  15.36 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite | 1,066.2 μs |   223.29 μs |   113.12 μs | 1,055.7 μs |   686.1 μs |  1,673.5 μs |   937.9 |  12.89 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark | 1,067.1 μs |   149.70 μs |    75.84 μs | 1,076.3 μs |   732.1 μs |  1,336.7 μs |   937.1 |  14.38 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml | 1,067.5 μs |   277.93 μs |   142.50 μs |   965.6 μs |   772.6 μs |  2,019.1 μs |   936.8 |  71.34 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark | 1,070.5 μs |   240.82 μs |   122.00 μs | 1,089.5 μs |   538.8 μs |  1,574.0 μs |   934.1 |  15.45 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1,074.5 μs |   126.88 μs |    64.28 μs | 1,058.5 μs |   860.9 μs |  1,361.6 μs |   930.7 |  17.19 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1,075.4 μs |   187.04 μs |    95.90 μs | 1,031.1 μs |   773.0 μs |  1,534.9 μs |   929.9 |  17.19 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite | 1,084.4 μs |   222.06 μs |   111.19 μs | 1,123.5 μs |   728.1 μs |  1,581.0 μs |   922.2 |  15.04 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1,102.0 μs |   201.62 μs |   102.14 μs | 1,095.3 μs |   761.9 μs |  1,544.9 μs |   907.4 |  13.85 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1,104.7 μs |   194.78 μs |    98.68 μs | 1,083.7 μs |   798.0 μs |  1,547.8 μs |   905.2 |  13.53 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,127.4 μs |   242.90 μs |   123.06 μs | 1,051.8 μs |   823.1 μs |  1,826.6 μs |   887.0 |  17.19 KB |
|                                    Single | InsightBenchmarkWrite | 1,132.3 μs |   261.34 μs |   135.65 μs | 1,128.2 μs |   758.7 μs |  1,727.4 μs |   883.1 |  15.05 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1,136.1 μs |   203.34 μs |   104.25 μs | 1,128.1 μs |   822.6 μs |  1,646.9 μs |   880.2 |  15.45 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite | 1,153.0 μs |   242.89 μs |   123.05 μs | 1,095.1 μs |   803.7 μs |  1,725.2 μs |   867.3 |  15.98 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark | 1,153.1 μs |   204.74 μs |   101.35 μs | 1,131.8 μs |   814.5 μs |  1,703.6 μs |   867.2 |  15.51 KB |
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite | 1,154.7 μs |   254.36 μs |   128.86 μs | 1,157.3 μs |   775.2 μs |  1,561.2 μs |   866.0 |   14.4 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite | 1,156.9 μs |   262.93 μs |   131.66 μs | 1,096.7 μs |   865.4 μs |  2,004.0 μs |   864.4 |  17.49 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1,163.2 μs |   256.24 μs |   126.85 μs | 1,131.5 μs |   840.8 μs |  1,827.1 μs |   859.7 |   18.7 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1,169.0 μs |   270.23 μs |   138.55 μs | 1,160.0 μs |   766.6 μs |  1,588.7 μs |   855.4 |  15.36 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml | 1,193.7 μs |   254.49 μs |   132.09 μs | 1,112.0 μs |   885.5 μs |  1,809.0 μs |   837.7 |  71.88 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark | 1,217.5 μs |   212.21 μs |   106.26 μs | 1,177.0 μs |   861.4 μs |  1,752.2 μs |   821.4 |  18.04 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1,259.4 μs |   224.37 μs |   113.67 μs | 1,272.6 μs |   909.0 μs |  1,748.8 μs |   794.0 |   18.7 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1,266.4 μs |   266.45 μs |   133.42 μs | 1,353.3 μs |   751.9 μs |  1,682.8 μs |   789.7 |  15.36 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,289.4 μs |   285.49 μs |   144.63 μs | 1,247.5 μs |   866.7 μs |  2,136.6 μs |   775.6 |  19.16 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,306.7 μs |   313.24 μs |   158.69 μs | 1,265.9 μs |   832.0 μs |  1,866.3 μs |   765.3 |  16.64 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite | 1,332.7 μs |   190.57 μs |    95.42 μs | 1,330.2 μs |   878.4 μs |  1,752.7 μs |   750.4 |  14.38 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,337.8 μs |   236.88 μs |   120.01 μs | 1,375.3 μs |   839.2 μs |  1,962.4 μs |   747.5 |  46.45 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark | 1,375.5 μs |   559.74 μs |   298.01 μs | 1,148.7 μs |   827.8 μs |  3,786.1 μs |   727.0 |  15.04 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson | 1,422.0 μs |   307.18 μs |   152.06 μs | 1,411.9 μs |   912.7 μs |  2,127.5 μs |   703.2 |  49.88 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,491.1 μs |   324.46 μs |   166.36 μs | 1,536.7 μs |   969.9 μs |  2,056.4 μs |   670.7 |  18.66 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson | 1,492.8 μs |   184.79 μs |    91.48 μs | 1,519.7 μs | 1,095.1 μs |  1,985.3 μs |   669.9 |  46.46 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1,519.2 μs |   277.66 μs |   139.03 μs | 1,552.1 μs |   849.1 μs |  2,132.9 μs |   658.3 |   50.1 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark | 1,556.8 μs |   107.69 μs |    53.92 μs | 1,553.9 μs | 1,306.2 μs |  1,758.0 μs |   642.4 |   14.4 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1,676.7 μs |    85.11 μs |    44.18 μs | 1,694.9 μs | 1,435.9 μs |  1,876.5 μs |   596.4 |  16.64 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark | 1,679.2 μs |   159.72 μs |    79.07 μs | 1,662.3 μs | 1,427.6 μs |  2,162.1 μs |   595.5 |  12.61 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark | 1,683.8 μs |   108.26 μs |    54.21 μs | 1,666.3 μs | 1,470.2 μs |  1,950.3 μs |   593.9 |  12.89 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,805.3 μs |   109.84 μs |    58.48 μs | 1,823.1 μs | 1,584.5 μs |  2,013.2 μs |   553.9 |  18.95 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark | 1,855.9 μs |    97.13 μs |    49.80 μs | 1,845.2 μs | 1,644.8 μs |  2,134.5 μs |   538.8 |  17.49 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark | 1,982.9 μs |   276.79 μs |   143.66 μs | 1,859.0 μs | 1,590.4 μs |  2,867.8 μs |   504.3 |  16.53 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark | 2,107.1 μs |   723.13 μs |   370.75 μs | 1,932.0 μs | 1,593.0 μs |  5,797.1 μs |   474.6 |  15.98 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 2,824.7 μs |   245.42 μs |   122.89 μs | 2,832.9 μs | 2,252.2 μs |  3,514.2 μs |   354.0 |  37.12 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 2,914.5 μs |   314.48 μs |   165.29 μs | 2,801.9 μs | 2,530.5 μs |  3,687.1 μs |   343.1 |  37.12 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 3,246.0 μs |   249.58 μs |   126.44 μs | 3,205.3 μs | 2,781.9 μs |  4,100.6 μs |   308.1 |  35.34 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 3,355.3 μs |   217.03 μs |   111.27 μs | 3,350.4 μs | 2,975.6 μs |  3,820.8 μs |   298.0 |  35.34 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 3,637.1 μs | 3,106.45 μs | 1,632.74 μs | 2,443.5 μs | 1,845.5 μs | 19,133.1 μs |   274.9 |  18.23 KB |
|                                           |                       |            |             |             |            |            |             |         |           |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,297.6 μs |   400.77 μs |   216.21 μs | 3,241.2 μs | 2,691.5 μs |  5,306.0 μs |   303.3 |  21.33 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 3,466.8 μs |   590.70 μs |   295.78 μs | 3,504.2 μs | 2,470.4 μs |  5,018.2 μs |   288.5 |   8.02 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite | 3,861.1 μs |   426.38 μs |   213.50 μs | 3,660.1 μs | 3,271.8 μs |  4,864.1 μs |   259.0 |   8.02 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3,899.2 μs |   441.43 μs |   223.63 μs | 3,822.2 μs | 3,197.6 μs |  5,026.1 μs |   256.5 |   12.2 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,902.1 μs |   375.19 μs |   199.76 μs | 3,813.7 μs | 3,275.7 μs |  4,987.6 μs |   256.3 |  11.76 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 3,923.6 μs |   483.54 μs |   247.91 μs | 3,746.2 μs | 3,288.1 μs |  5,172.3 μs |   254.9 |   8.02 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite | 4,091.6 μs |   572.33 μs |   283.32 μs | 3,958.1 μs | 3,352.0 μs |  5,531.5 μs |   244.4 |   18.1 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml | 4,131.3 μs |   918.62 μs |   459.97 μs | 3,740.2 μs | 3,314.4 μs |  7,083.7 μs |   242.1 |  12.17 KB |
