# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean        | StdDev      | Error       | Median      | Min         | Max         | Op/s     | Allocated |
|------------------------------------------ |---------------------- |------------:|------------:|------------:|------------:|------------:|------------:|---------:|----------:|
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |    952.9 μs |    62.43 μs |    32.40 μs |    945.7 μs |    839.2 μs |  1,122.6 μs | 1,049.43 |  11.43 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |    973.5 μs |    43.21 μs |    23.31 μs |    970.5 μs |    892.1 μs |  1,082.3 μs | 1,027.27 |  11.07 KB |
| Single                                    | InsightBenchmarkWrite |    979.1 μs |    73.18 μs |    37.52 μs |    979.1 μs |    861.2 μs |  1,198.0 μs | 1,021.32 |  12.18 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |    979.9 μs |    77.53 μs |    40.75 μs |    972.9 μs |    849.4 μs |  1,264.2 μs | 1,020.52 |  11.73 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |    980.4 μs |    66.48 μs |    34.50 μs |    979.9 μs |    862.5 μs |  1,219.1 μs | 1,019.95 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |    996.5 μs |    63.64 μs |    33.03 μs |    997.3 μs |    889.8 μs |  1,130.2 μs | 1,003.51 |  11.07 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |    998.3 μs |    75.24 μs |    38.57 μs |    979.9 μs |    886.8 μs |  1,190.3 μs | 1,001.72 |  11.43 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1,024.6 μs |   115.60 μs |    59.27 μs |    990.9 μs |    887.1 μs |  1,433.7 μs |   975.97 |  11.73 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1,028.0 μs |    80.68 μs |    41.88 μs |  1,020.8 μs |    877.5 μs |  1,250.0 μs |   972.73 |  12.48 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1,045.4 μs |   103.80 μs |    56.76 μs |  1,024.4 μs |    893.6 μs |  1,419.3 μs |   956.61 |  11.43 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1,046.3 μs |   119.84 μs |    62.99 μs |  1,024.7 μs |    862.9 μs |  1,470.7 μs |   955.75 |  11.09 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1,055.5 μs |   119.00 μs |    63.36 μs |  1,022.2 μs |    934.5 μs |  1,518.0 μs |   947.42 |  11.09 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1,056.4 μs |   174.64 μs |    87.45 μs |    999.4 μs |    856.4 μs |  1,631.5 μs |   946.59 |  11.41 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1,060.4 μs |   110.34 μs |    58.74 μs |  1,044.0 μs |    842.4 μs |  1,340.0 μs |   943.07 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1,060.7 μs |    72.98 μs |    38.36 μs |  1,052.1 μs |    920.3 μs |  1,269.3 μs |   942.80 |  14.38 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1,066.6 μs |   145.58 μs |    74.64 μs |  1,009.3 μs |    862.8 μs |  1,530.6 μs |   937.52 |  11.09 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1,067.7 μs |   107.15 μs |    56.32 μs |  1,048.6 μs |    898.2 μs |  1,364.9 μs |   936.63 |  12.48 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1,071.9 μs |   116.17 μs |    61.85 μs |  1,047.5 μs |    912.7 μs |  1,372.7 μs |   932.93 |  11.09 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1,073.7 μs |    89.83 μs |    44.98 μs |  1,059.4 μs |    907.7 μs |  1,378.4 μs |   931.37 |  12.83 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1,075.5 μs |   115.61 μs |    61.55 μs |  1,061.2 μs |    870.1 μs |  1,352.2 μs |   929.83 |  11.07 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1,078.5 μs |   125.58 μs |    68.68 μs |  1,047.7 μs |    884.5 μs |  1,458.2 μs |   927.24 |  11.84 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1,079.3 μs |   109.89 μs |    57.03 μs |  1,061.7 μs |    896.4 μs |  1,441.0 μs |   926.54 |  11.41 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1,094.3 μs |   103.91 μs |    55.32 μs |  1,072.7 μs |    947.8 μs |  1,355.1 μs |   913.78 |  12.48 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1,102.7 μs |   116.12 μs |    61.03 μs |  1,089.4 μs |    943.1 μs |  1,476.0 μs |   906.84 |  12.16 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1,104.3 μs |   156.45 μs |    84.41 μs |  1,039.6 μs |    920.5 μs |  1,468.2 μs |   905.52 |  35.66 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1,108.0 μs |    73.89 μs |    37.88 μs |  1,101.7 μs |  1,000.6 μs |  1,285.6 μs |   902.55 |  14.17 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1,108.1 μs |   151.58 μs |    79.67 μs |  1,074.3 μs |    930.9 μs |  1,571.0 μs |   902.48 |  11.73 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1,118.6 μs |    78.29 μs |    39.66 μs |  1,106.5 μs |    982.1 μs |  1,333.8 μs |   894.01 |  13.17 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1,124.6 μs |   214.73 μs |   108.78 μs |  1,062.5 μs |    902.1 μs |  1,841.4 μs |   889.24 |  11.07 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1,125.5 μs |    60.16 μs |    31.22 μs |  1,116.5 μs |  1,006.6 μs |  1,284.4 μs |   888.46 |  35.65 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1,131.7 μs |   107.81 μs |    58.16 μs |  1,107.5 μs |    965.9 μs |  1,468.0 μs |   883.63 |  13.17 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1,133.9 μs |    84.10 μs |    45.37 μs |  1,109.7 μs |  1,001.0 μs |  1,389.3 μs |   881.91 |  13.17 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,135.3 μs |    72.85 μs |    37.81 μs |  1,123.7 μs |  1,006.6 μs |  1,359.0 μs |   880.86 |  14.94 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1,138.8 μs |   221.01 μs |   109.41 μs |  1,072.2 μs |    944.0 μs |  2,000.0 μs |   878.10 |  13.52 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1,141.0 μs |   124.36 μs |    64.55 μs |  1,112.5 μs |    988.4 μs |  1,446.7 μs |   876.41 |  13.42 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1,143.0 μs |   181.38 μs |    95.33 μs |  1,077.4 μs |    907.4 μs |  1,519.3 μs |   874.91 |  11.43 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1,143.2 μs |   121.04 μs |    63.62 μs |  1,115.3 μs |    930.6 μs |  1,395.1 μs |   874.77 |  13.83 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1,146.4 μs |    87.18 μs |    43.65 μs |  1,129.1 μs |  1,009.1 μs |  1,387.1 μs |   872.33 |  13.92 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1,154.7 μs |   183.32 μs |    95.15 μs |  1,099.3 μs |    909.4 μs |  1,661.1 μs |   865.99 |  11.84 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1,158.6 μs |   216.20 μs |   112.22 μs |  1,077.3 μs |    909.0 μs |  1,799.1 μs |   863.12 |  12.48 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1,164.0 μs |   130.06 μs |    68.36 μs |  1,143.9 μs |    992.3 μs |  1,594.5 μs |   859.07 |  13.42 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,164.1 μs |    96.59 μs |    52.11 μs |  1,160.7 μs |    998.9 μs |  1,401.6 μs |   859.01 |  14.98 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1,168.8 μs |   123.40 μs |    64.86 μs |  1,133.0 μs |    974.7 μs |  1,482.4 μs |   855.60 |  13.42 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,176.5 μs |   107.94 μs |    56.73 μs |  1,156.6 μs |  1,002.2 μs |  1,437.1 μs |   850.00 |  14.94 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1,180.6 μs |   137.33 μs |    73.12 μs |  1,165.7 μs |    981.6 μs |  1,570.1 μs |   847.05 |  12.83 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1,183.7 μs |   159.58 μs |    86.09 μs |  1,119.7 μs |  1,007.4 μs |  1,533.7 μs |   844.81 |  14.28 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1,184.3 μs |   201.78 μs |   106.06 μs |  1,129.5 μs |    965.6 μs |  2,043.6 μs |   844.35 |  13.08 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1,186.1 μs |   201.21 μs |   101.94 μs |  1,137.4 μs |    911.2 μs |  1,807.2 μs |   843.07 |  12.16 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1,186.5 μs |   263.17 μs |   134.93 μs |  1,077.0 μs |    865.9 μs |  2,025.1 μs |   842.82 |  11.73 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1,187.3 μs |   159.37 μs |    82.72 μs |  1,137.3 μs |    982.4 μs |  1,628.5 μs |   842.26 |  14.71 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1,188.8 μs |    57.55 μs |    30.25 μs |  1,186.5 μs |  1,065.0 μs |  1,330.8 μs |   841.19 |  37.75 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1,192.2 μs |   140.60 μs |    74.86 μs |  1,164.0 μs |    966.9 μs |  1,524.9 μs |   838.78 |  12.88 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1,201.1 μs |   221.88 μs |   118.13 μs |  1,120.7 μs |    969.8 μs |  1,761.7 μs |   832.56 |  14.27 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1,201.2 μs |   174.59 μs |    92.95 μs |  1,189.9 μs |    887.3 μs |  1,592.3 μs |   832.47 |  13.08 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1,212.4 μs |   176.56 μs |    94.00 μs |  1,161.7 μs |    955.3 μs |  1,790.0 μs |   824.80 |  13.08 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1,213.8 μs |   244.26 μs |   125.24 μs |  1,194.1 μs |    877.8 μs |  1,788.1 μs |   823.89 |  11.82 KB |
| Single                                    | InsightBenchmark      |  1,216.7 μs |   182.14 μs |    99.61 μs |  1,180.4 μs |    953.3 μs |  1,716.5 μs |   821.92 |  12.18 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1,220.5 μs |   202.24 μs |   101.27 μs |  1,138.0 μs |    966.4 μs |  1,812.2 μs |   819.32 |  13.42 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1,226.8 μs |   109.73 μs |    56.95 μs |  1,212.1 μs |  1,028.9 μs |  1,540.2 μs |   815.13 |  43.35 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1,236.2 μs |   198.29 μs |   101.66 μs |  1,201.5 μs |    952.4 μs |  1,620.7 μs |   808.91 |  12.88 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1,242.6 μs |   205.49 μs |   108.01 μs |  1,181.9 μs |  1,014.8 μs |  2,031.4 μs |   804.78 |  14.27 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1,260.4 μs |   100.43 μs |    51.49 μs |  1,229.1 μs |  1,130.6 μs |  1,543.0 μs |   793.37 |  65.32 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1,260.8 μs |   151.64 μs |    79.70 μs |  1,210.2 μs |  1,044.3 μs |  1,690.4 μs |   793.17 |  14.17 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1,274.4 μs |    94.13 μs |    47.69 μs |  1,247.0 μs |  1,140.7 μs |  1,589.0 μs |   784.67 |  65.34 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1,274.7 μs |   260.62 μs |   136.98 μs |  1,175.9 μs |    979.1 μs |  1,968.9 μs |   784.52 |  13.52 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1,277.9 μs |   203.08 μs |   102.88 μs |  1,257.5 μs |  1,008.3 μs |  1,617.4 μs |   782.54 |  13.92 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1,280.6 μs |   404.22 μs |   207.25 μs |  1,102.4 μs |    987.3 μs |  2,277.4 μs |   780.91 |  11.82 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,315.6 μs |   206.34 μs |   108.45 μs |  1,241.9 μs |  1,064.1 μs |  1,807.8 μs |   760.09 |  14.98 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1,355.5 μs |   165.78 μs |    87.13 μs |  1,355.0 μs |  1,002.9 μs |  1,701.5 μs |   737.73 |  15.03 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1,364.7 μs |    89.45 μs |    45.86 μs |  1,349.2 μs |  1,220.7 μs |  1,660.3 μs |   732.74 |  67.42 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1,364.9 μs |   239.37 μs |   122.73 μs |  1,479.5 μs |  1,012.8 μs |  1,739.2 μs |   732.64 |  13.52 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  1,434.8 μs |   150.44 μs |    77.13 μs |  1,394.2 μs |  1,253.7 μs |  1,812.0 μs |   696.96 |  68.52 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2,322.3 μs |   101.38 μs |    51.36 μs |  2,298.0 μs |  2,108.5 μs |  2,596.6 μs |   430.60 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2,504.4 μs |   291.19 μs |   145.81 μs |  2,382.2 μs |  2,173.5 μs |  3,212.5 μs |   399.29 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2,790.6 μs |   138.42 μs |    70.13 μs |  2,745.4 μs |  2,577.4 μs |  3,212.2 μs |   358.35 |  31.58 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2,968.7 μs |   252.28 μs |   129.35 μs |  2,899.1 μs |  2,541.2 μs |  3,666.1 μs |   336.85 |  31.58 KB |
|                                           |                       |             |             |             |             |             |             |          |           |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,105.8 μs |   470.39 μs |   235.54 μs | 10,998.9 μs | 10,229.2 μs | 12,455.2 μs |    90.04 |   8.05 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,227.1 μs |   446.56 μs |   226.23 μs | 11,194.4 μs | 10,345.0 μs | 12,558.6 μs |    89.07 |   7.17 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11,337.2 μs |   567.43 μs |   284.13 μs | 11,318.3 μs | 10,343.5 μs | 12,880.5 μs |    88.21 |  13.08 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,385.7 μs |   507.23 μs |   260.06 μs | 11,344.8 μs | 10,250.1 μs | 12,766.5 μs |    87.83 |   4.64 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11,546.4 μs |   521.07 μs |   263.98 μs | 11,609.0 μs | 10,402.0 μs | 12,535.2 μs |    86.61 |   7.17 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,719.8 μs |   526.55 μs |   266.76 μs | 11,608.8 μs | 10,650.8 μs | 13,088.7 μs |    85.33 |   16.4 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11,829.0 μs | 2,137.23 μs | 1,095.78 μs | 11,391.1 μs |  9,820.0 μs | 20,463.4 μs |    84.54 |   4.64 KB |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 12,217.5 μs | 2,438.54 μs | 1,221.03 μs | 11,302.9 μs | 10,217.3 μs | 19,110.0 μs |    81.85 |   4.64 KB |
