# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7705/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean        | StdDev      | Error     | Median      | Min         | Max         | Op/s     | Allocated |
|------------------------------------------ |---------------------- |------------:|------------:|----------:|------------:|------------:|------------:|---------:|----------:|
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |    991.8 μs |    66.14 μs |  35.21 μs |    982.0 μs |    875.8 μs |  1,167.2 μs | 1,008.32 |  11.73 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |    997.5 μs |    72.38 μs |  36.67 μs |    993.3 μs |    882.6 μs |  1,181.4 μs | 1,002.50 |  11.43 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1,016.7 μs |   128.84 μs |  67.72 μs |    980.7 μs |    880.9 μs |  1,586.6 μs |   983.55 |  11.09 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1,034.4 μs |   101.30 μs |  50.72 μs |  1,012.7 μs |    882.0 μs |  1,287.6 μs |   966.73 |  11.09 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1,039.5 μs |    68.06 μs |  36.23 μs |  1,036.8 μs |    929.5 μs |  1,262.1 μs |   962.01 |  12.48 KB |
| Single                                    | InsightBenchmarkWrite |  1,048.0 μs |   126.73 μs |  64.97 μs |  1,023.4 μs |    882.9 μs |  1,426.6 μs |   954.16 |  12.18 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1,052.6 μs |   124.55 μs |  63.86 μs |  1,022.9 μs |    906.5 μs |  1,439.5 μs |   950.01 |  11.73 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1,058.5 μs |   175.30 μs |  90.99 μs |    999.4 μs |    857.0 μs |  1,630.5 μs |   944.76 |  11.41 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1,076.2 μs |    85.02 μs |  42.57 μs |  1,057.0 μs |    919.1 μs |  1,298.9 μs |   929.18 |  11.73 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1,080.7 μs |   121.54 μs |  63.88 μs |  1,053.4 μs |    871.6 μs |  1,405.8 μs |   925.32 |  11.07 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1,080.8 μs |   168.94 μs |  85.59 μs |  1,030.5 μs |    896.0 μs |  1,632.3 μs |   925.23 |  11.73 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1,091.5 μs |   126.97 μs |  65.90 μs |  1,058.0 μs |    946.3 μs |  1,645.8 μs |   916.20 |  12.48 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1,101.3 μs |   204.23 μs | 106.00 μs |  1,025.2 μs |    872.8 μs |  1,778.5 μs |   908.04 |  11.84 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1,103.7 μs |   165.61 μs |  82.93 μs |  1,043.7 μs |    902.1 μs |  1,531.5 μs |   906.03 |  12.16 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1,106.2 μs |    79.71 μs |  41.37 μs |  1,077.7 μs |    979.3 μs |  1,289.8 μs |   903.96 |  13.42 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1,119.5 μs |    89.25 μs |  45.22 μs |  1,109.2 μs |    963.4 μs |  1,372.0 μs |   893.26 |  13.17 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1,122.1 μs |   234.45 μs | 118.77 μs |  1,011.3 μs |    879.3 μs |  1,646.2 μs |   891.15 |  11.43 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1,124.5 μs |    93.39 μs |  47.88 μs |  1,112.0 μs |  1,003.9 μs |  1,468.0 μs |   889.26 |  13.68 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1,127.2 μs |   155.07 μs |  79.51 μs |  1,074.9 μs |    936.4 μs |  1,519.8 μs |   887.16 |  12.83 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1,130.9 μs |   121.49 μs |  63.86 μs |  1,112.1 μs |    948.5 μs |  1,374.8 μs |   884.26 |  11.43 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1,131.4 μs |   154.65 μs |  79.29 μs |  1,082.7 μs |    947.5 μs |  1,734.2 μs |   883.86 |  35.66 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1,132.9 μs |   190.72 μs | 100.24 μs |  1,072.6 μs |    936.5 μs |  1,871.5 μs |   882.72 |  11.82 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1,133.1 μs |   123.91 μs |  65.12 μs |  1,090.1 μs |    987.6 μs |  1,541.4 μs |   882.53 |  13.42 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,152.6 μs |    72.89 μs |  37.37 μs |  1,128.2 μs |  1,038.7 μs |  1,353.0 μs |   867.57 |  14.94 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1,162.3 μs |   232.31 μs | 125.33 μs |  1,115.3 μs |    857.1 μs |  2,045.3 μs |   860.33 |  11.07 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1,164.7 μs |   129.14 μs |  64.66 μs |  1,142.5 μs |    994.4 μs |  1,651.8 μs |   858.58 |   14.3 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1,166.7 μs |   200.31 μs | 102.70 μs |  1,125.4 μs |    909.9 μs |  1,643.6 μs |   857.15 |  11.41 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1,167.0 μs |   125.43 μs |  64.31 μs |  1,125.7 μs |  1,007.3 μs |  1,514.8 μs |   856.92 |  13.08 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1,168.7 μs |   242.12 μs | 125.67 μs |  1,104.5 μs |    874.9 μs |  2,130.0 μs |   855.62 |  11.82 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1,169.6 μs |   150.43 μs |  79.07 μs |  1,118.5 μs |    994.4 μs |  1,698.2 μs |   854.97 |  13.83 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1,193.4 μs |   108.95 μs |  58.78 μs |  1,166.9 μs |  1,011.2 μs |  1,509.4 μs |   837.91 |  14.27 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1,197.6 μs |   187.28 μs |  92.71 μs |  1,134.5 μs |    971.1 μs |  1,767.8 μs |   834.99 |  13.08 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1,199.2 μs |   151.59 μs |  79.67 μs |  1,175.4 μs |  1,008.0 μs |  1,737.0 μs |   833.87 |  12.88 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1,200.4 μs |   198.14 μs | 102.84 μs |  1,143.0 μs |    921.7 μs |  1,716.2 μs |   833.07 |  11.43 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1,201.1 μs |   291.18 μs | 151.13 μs |  1,124.0 μs |    855.4 μs |  2,249.8 μs |   832.58 |  11.41 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1,202.7 μs |   216.75 μs | 111.13 μs |  1,112.9 μs |    959.0 μs |  1,708.7 μs |   831.45 |  14.27 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,211.3 μs |   119.16 μs |  59.67 μs |  1,191.0 μs |  1,023.3 μs |  1,650.0 μs |   825.53 |  14.98 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1,213.2 μs |   174.87 μs |  93.10 μs |  1,165.4 μs |  1,021.3 μs |  1,838.0 μs |   824.26 |  13.52 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1,220.1 μs |   158.03 μs |  78.23 μs |  1,180.0 μs |  1,011.2 μs |  1,570.5 μs |   819.61 |  35.65 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1,227.4 μs |   211.78 μs | 108.58 μs |  1,149.3 μs |    955.1 μs |  1,935.6 μs |   814.73 |  11.84 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1,229.0 μs |   208.46 μs | 110.98 μs |  1,188.8 μs |    986.8 μs |  1,867.6 μs |   813.70 |  12.83 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1,231.2 μs |   165.20 μs |  82.72 μs |  1,259.5 μs |    934.0 μs |  1,597.0 μs |   812.25 |  12.48 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1,235.0 μs |   180.57 μs |  93.72 μs |  1,185.9 μs |  1,042.1 μs |  1,913.1 μs |   809.71 |  13.92 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1,235.1 μs |   278.17 μs | 142.62 μs |  1,142.8 μs |    910.8 μs |  2,100.8 μs |   809.64 |  11.07 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1,236.3 μs |   129.19 μs |  67.05 μs |  1,191.9 μs |  1,044.1 μs |  1,706.3 μs |   808.86 |  37.66 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1,239.0 μs |   221.13 μs | 116.23 μs |  1,189.3 μs |    914.3 μs |  1,765.7 μs |   807.07 |  11.09 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1,251.5 μs |   167.86 μs |  87.13 μs |  1,218.0 μs |  1,035.1 μs |  1,736.0 μs |   799.06 |   13.3 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1,260.9 μs |   290.03 μs | 150.53 μs |  1,154.6 μs |    975.7 μs |  2,174.0 μs |   793.07 |  13.17 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1,271.5 μs |   150.60 μs |  77.22 μs |  1,234.3 μs |  1,110.8 μs |  1,887.8 μs |   786.46 |  37.75 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1,293.6 μs |   269.87 μs | 136.72 μs |  1,243.2 μs |    956.1 μs |  1,977.5 μs |   773.04 |  12.16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1,295.4 μs |   256.51 μs | 131.51 μs |  1,206.0 μs |  1,004.3 μs |  2,002.2 μs |   771.98 |  13.17 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1,319.5 μs |   322.68 μs | 165.44 μs |  1,186.2 μs |    980.7 μs |  2,274.0 μs |   757.87 |  12.48 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1,322.7 μs |   396.72 μs | 203.40 μs |  1,142.8 μs |    955.6 μs |  2,538.5 μs |   756.05 |  11.07 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1,336.0 μs |   204.31 μs | 198.95 μs |  1,406.0 μs |  1,027.2 μs |  1,564.4 μs |   748.51 |        NA |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1,357.3 μs |   277.65 μs | 140.66 μs |  1,290.3 μs |    924.0 μs |  1,914.8 μs |   736.75 |  11.41 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1,368.1 μs |   286.80 μs | 150.74 μs |  1,280.1 μs |  1,024.7 μs |  2,380.2 μs |   730.96 |  13.92 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1,370.2 μs |   227.11 μs | 115.06 μs |  1,342.5 μs |  1,065.7 μs |  1,925.3 μs |   729.84 |  13.08 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1,371.2 μs |   265.03 μs | 139.30 μs |  1,385.1 μs |    876.3 μs |  2,326.6 μs |   729.31 |  11.09 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1,381.1 μs |   187.35 μs |  94.91 μs |  1,332.4 μs |  1,081.8 μs |  1,837.3 μs |   724.07 |  65.32 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1,382.9 μs |   235.13 μs | 120.55 μs |  1,420.4 μs |  1,028.0 μs |  1,945.3 μs |   723.11 |  13.08 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1,383.8 μs |    68.61 μs |  36.06 μs |  1,377.7 μs |  1,259.7 μs |  1,523.0 μs |   722.67 |  67.42 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1,384.4 μs |   121.88 μs |  60.33 μs |  1,358.4 μs |  1,178.2 μs |  1,711.0 μs |   722.34 |  65.34 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,386.3 μs |   235.52 μs | 122.24 μs |  1,309.2 μs |  1,096.7 μs |  2,036.2 μs |   721.35 |  15.12 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  1,435.5 μs |   101.19 μs |  53.18 μs |  1,399.7 μs |  1,243.7 μs |  1,701.8 μs |   696.60 |  67.33 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,473.6 μs |   261.15 μs | 132.30 μs |  1,433.8 μs |  1,048.8 μs |  2,109.0 μs |   678.60 |  14.94 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1,495.5 μs |   243.74 μs | 126.51 μs |  1,554.7 μs |  1,069.0 μs |  2,078.8 μs |   668.66 |  13.83 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1,501.1 μs |   357.24 μs | 183.16 μs |  1,409.3 μs |  1,024.8 μs |  2,412.6 μs |   666.20 |  13.52 KB |
| Single                                    | InsightBenchmark      |  1,565.3 μs |   434.90 μs | 220.33 μs |  1,465.2 μs |  1,001.5 μs |  2,693.2 μs |   638.86 |  12.18 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1,577.6 μs |   449.36 μs | 227.65 μs |  1,553.5 μs |    964.8 μs |  2,571.6 μs |   633.87 |  12.88 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1,697.1 μs |   598.56 μs | 310.67 μs |  1,543.0 μs |  1,040.9 μs |  3,574.7 μs |   589.25 |  13.42 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1,802.2 μs |   603.25 μs | 302.06 μs |  1,627.3 μs |  1,074.4 μs |  3,989.1 μs |   554.88 |  13.42 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1,863.9 μs | 1,186.68 μs | 601.18 μs |  1,410.5 μs |  1,007.3 μs |  5,781.3 μs |   536.51 |  14.17 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2,374.7 μs |   120.31 μs |  59.56 μs |  2,343.2 μs |  2,214.7 μs |  2,666.7 μs |   421.11 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2,446.1 μs |   200.43 μs |  99.22 μs |  2,411.1 μs |  2,186.7 μs |  3,224.8 μs |   408.82 |  33.14 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2,958.2 μs |   277.03 μs | 138.72 μs |  2,871.7 μs |  2,603.5 μs |  3,637.6 μs |   338.04 |  31.58 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3,000.5 μs |   224.13 μs | 110.95 μs |  2,959.8 μs |  2,624.0 μs |  3,438.7 μs |   333.28 |  31.58 KB |
|                                           |                       |             |             |           |             |             |             |          |           |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,073.0 μs |   414.66 μs | 210.07 μs | 10,994.4 μs | 10,259.1 μs | 12,065.1 μs |    90.31 |   15.2 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11,202.4 μs |   537.08 μs | 275.37 μs | 11,073.6 μs |  9,990.6 μs | 12,667.4 μs |    89.27 |  13.08 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,272.8 μs |   311.85 μs | 161.86 μs | 11,321.9 μs | 10,651.9 μs | 11,820.5 μs |    88.71 |   6.99 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,303.6 μs |   494.25 μs | 244.67 μs | 11,234.9 μs | 10,015.4 μs | 12,479.3 μs |    88.47 |   4.64 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,383.4 μs |   595.13 μs | 308.89 μs | 11,472.3 μs |  9,262.4 μs | 12,497.9 μs |    87.85 |   7.17 KB |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11,635.9 μs |   623.98 μs | 312.44 μs | 11,513.8 μs | 10,608.0 μs | 13,030.5 μs |    85.94 |   4.64 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11,737.1 μs |   561.14 μs | 284.28 μs | 11,607.0 μs | 10,675.8 μs | 13,136.3 μs |    85.20 |   7.17 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11,845.9 μs | 1,940.74 μs | 960.74 μs | 11,343.9 μs |  9,277.4 μs | 18,368.0 μs |    84.42 |   4.64 KB |
