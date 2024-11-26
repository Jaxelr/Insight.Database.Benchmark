# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Type                  | Mean        | StdDev    | Error     | Median      | Min         | Max         | Op/s     | Allocated |
|------------------------------------------ |---------------------- |------------:|----------:|----------:|------------:|------------:|------------:|---------:|----------:|
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |    986.1 μs | 101.46 μs |  55.49 μs |    979.2 μs |    845.1 μs |  1,218.1 μs | 1,014.10 |  12.44 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1,002.7 μs | 122.50 μs |  65.22 μs |    987.9 μs |    828.0 μs |  1,307.2 μs |   997.32 |  12.45 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1,010.2 μs |  84.12 μs |  45.38 μs |  1,004.1 μs |    879.1 μs |  1,210.3 μs |   989.94 |  12.47 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1,019.9 μs | 160.98 μs |  85.71 μs |    977.1 μs |    846.3 μs |  1,715.6 μs |   980.47 |  12.45 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1,026.4 μs | 104.30 μs |  55.53 μs |  1,004.7 μs |    881.3 μs |  1,367.3 μs |   974.31 |  12.45 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1,028.0 μs | 130.57 μs |  70.44 μs |    998.6 μs |    841.8 μs |  1,469.7 μs |   972.81 |  12.44 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1,029.4 μs | 133.15 μs |  97.27 μs |    993.6 μs |    864.4 μs |  1,422.2 μs |   971.49 |        NA |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1,030.7 μs |  96.78 μs |  51.53 μs |  1,011.6 μs |    901.2 μs |  1,344.5 μs |   970.21 |  13.19 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1,032.3 μs | 129.93 μs |  66.62 μs |  1,006.9 μs |    855.3 μs |  1,410.3 μs |   968.71 |  12.19 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1,040.1 μs | 175.98 μs |  92.49 μs |    983.4 μs |    853.0 μs |  1,681.8 μs |   961.46 |  12.45 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1,042.8 μs | 188.34 μs | 101.61 μs |    989.7 μs |    847.6 μs |  1,950.3 μs |   958.96 |   13.1 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1,051.6 μs | 152.00 μs |  82.00 μs |  1,022.1 μs |    847.0 μs |  1,676.5 μs |   950.90 |  12.47 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1,059.4 μs | 149.10 μs |  78.37 μs |  1,027.1 μs |    867.9 μs |  1,683.7 μs |   943.96 |   13.2 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1,064.9 μs | 146.12 μs |  77.80 μs |  1,008.8 μs |    872.8 μs |  1,521.9 μs |   939.04 |  12.45 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1,070.9 μs | 163.97 μs |  85.10 μs |  1,015.0 μs |    877.9 μs |  1,669.2 μs |   933.77 |  12.17 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1,072.9 μs | 108.47 μs |  58.52 μs |  1,058.3 μs |    920.7 μs |  1,347.0 μs |   932.06 |  13.91 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1,075.7 μs | 125.20 μs |  63.43 μs |  1,054.8 μs |    876.5 μs |  1,374.8 μs |   929.59 |  13.53 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1,078.5 μs |  97.46 μs |  51.22 μs |  1,062.0 μs |    931.7 μs |  1,360.4 μs |   927.18 |  13.86 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1,085.9 μs | 109.50 μs |  58.30 μs |  1,065.1 μs |    901.0 μs |  1,386.2 μs |   920.87 |  14.74 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1,086.3 μs | 162.81 μs |  83.47 μs |  1,038.1 μs |    875.5 μs |  1,591.0 μs |   920.59 |  12.44 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1,087.0 μs | 152.45 μs |  81.16 μs |  1,046.0 μs |    866.9 μs |  1,469.4 μs |   920.00 |  13.57 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1,090.8 μs | 208.10 μs | 108.01 μs |  1,032.4 μs |    869.6 μs |  1,836.5 μs |   916.79 |  12.92 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1,097.3 μs |  90.13 μs |  47.37 μs |  1,070.0 μs |    973.7 μs |  1,366.3 μs |   911.36 |  15.48 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1,103.2 μs | 102.39 μs |  53.81 μs |  1,081.6 μs |    934.7 μs |  1,400.9 μs |   906.45 |  15.98 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1,104.8 μs | 123.02 μs |  64.66 μs |  1,064.0 μs |    954.5 μs |  1,517.1 μs |   905.13 |   36.7 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1,105.2 μs | 243.75 μs | 126.51 μs |  1,014.5 μs |    871.5 μs |  1,978.3 μs |   904.83 |  12.45 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1,107.9 μs | 107.60 μs |  58.84 μs |  1,103.5 μs |    964.4 μs |  1,426.0 μs |   902.62 |  15.57 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1,109.3 μs | 161.81 μs |  83.99 μs |  1,060.1 μs |    892.2 μs |  1,539.3 μs |   901.49 |  13.19 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1,110.4 μs | 121.54 μs |  63.88 μs |  1,097.2 μs |    929.5 μs |  1,487.5 μs |   900.59 |  14.84 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1,111.4 μs | 210.32 μs | 109.16 μs |  1,049.5 μs |    898.0 μs |  2,072.0 μs |   899.78 |  13.86 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1,114.2 μs | 147.93 μs |  76.78 μs |  1,068.2 μs |    947.6 μs |  1,514.8 μs |   897.49 |  14.73 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1,115.0 μs | 138.83 μs |  72.06 μs |  1,071.5 μs |    921.2 μs |  1,491.5 μs |   896.86 |  15.59 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1,115.6 μs | 243.54 μs | 124.87 μs |  1,034.8 μs |    854.5 μs |  1,822.0 μs |   896.40 |  12.47 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1,118.2 μs | 114.42 μs |  60.92 μs |  1,081.8 μs |    965.0 μs |  1,495.5 μs |   894.26 |  15.49 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1,125.4 μs | 151.45 μs |  80.63 μs |  1,078.1 μs |    896.4 μs |  1,627.7 μs |   888.58 |  14.82 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1,128.0 μs | 109.23 μs |  57.41 μs |  1,107.0 μs |    971.1 μs |  1,416.6 μs |   886.52 |  14.73 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1,128.4 μs | 282.28 μs | 152.29 μs |  1,026.9 μs |    865.8 μs |  2,094.4 μs |   886.19 |  12.45 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1,135.8 μs | 146.38 μs |  77.94 μs |  1,107.0 μs |    976.3 μs |  1,709.3 μs |   880.41 |  14.73 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1,140.3 μs | 117.20 μs |  63.23 μs |  1,113.7 μs |    972.4 μs |  1,439.3 μs |   876.97 |  14.74 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1,142.7 μs | 111.75 μs |  60.29 μs |  1,125.4 μs |    979.1 μs |  1,470.0 μs |   875.16 |   15.2 KB |
| Single                                    | InsightBenchmarkWrite |  1,147.0 μs | 234.38 μs | 124.79 μs |  1,052.0 μs |    899.2 μs |  1,877.3 μs |   871.87 |  13.22 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1,155.1 μs | 141.17 μs |  74.20 μs |  1,122.8 μs |    981.9 μs |  1,549.6 μs |   865.70 |   15.3 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1,157.2 μs | 355.82 μs | 187.02 μs |  1,027.2 μs |    855.3 μs |  2,640.8 μs |   864.18 |  13.85 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1,157.8 μs | 220.93 μs | 116.12 μs |  1,076.6 μs |    946.5 μs |  1,745.2 μs |   863.74 |  13.57 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1,164.5 μs | 257.85 μs | 135.53 μs |  1,087.7 μs |    916.4 μs |  2,242.2 μs |   858.73 |   13.2 KB |
| Single                                    | InsightBenchmark      |  1,175.7 μs | 271.96 μs | 139.44 μs |  1,061.5 μs |    850.9 μs |  1,831.3 μs |   850.58 |  13.22 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,181.8 μs | 160.53 μs |  87.79 μs |  1,140.6 μs |  1,017.0 μs |  1,794.0 μs |   846.20 |   16.3 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1,192.6 μs | 180.93 μs |  95.10 μs |  1,148.7 μs |    960.7 μs |  1,917.6 μs |   838.52 |  14.74 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1,195.9 μs | 176.12 μs |  88.19 μs |  1,138.4 μs |    986.8 μs |  1,650.2 μs |   836.20 |  14.74 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1,201.0 μs | 283.62 μs | 151.00 μs |  1,085.7 μs |    961.6 μs |  2,243.4 μs |   832.64 |  14.84 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1,204.4 μs | 233.20 μs | 122.57 μs |  1,123.5 μs |    915.2 μs |  1,702.4 μs |   830.31 |  14.82 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,205.8 μs | 141.58 μs |  73.48 μs |  1,177.2 μs |  1,007.0 μs |  1,628.5 μs |   829.32 |  15.97 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1,206.6 μs | 292.03 μs | 153.49 μs |  1,099.4 μs |    873.1 μs |  2,004.3 μs |   828.75 |   13.1 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1,207.2 μs | 251.60 μs | 129.00 μs |  1,151.4 μs |    928.6 μs |  2,165.1 μs |   828.35 |  14.73 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1,216.5 μs | 121.48 μs |  65.54 μs |  1,177.5 μs |  1,058.8 μs |  1,714.5 μs |   822.03 |  38.98 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,221.8 μs | 182.13 μs |  98.26 μs |  1,185.8 μs |    995.0 μs |  1,743.5 μs |   818.44 |  15.97 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1,223.4 μs | 189.63 μs |  94.95 μs |  1,192.2 μs |    976.3 μs |  1,929.3 μs |   817.38 |  16.91 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1,225.4 μs | 327.92 μs | 170.20 μs |  1,107.0 μs |    886.3 μs |  2,013.8 μs |   816.07 |  13.85 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1,225.6 μs | 224.32 μs | 115.01 μs |  1,171.3 μs |    961.1 μs |  2,064.8 μs |   815.91 |  15.57 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1,237.7 μs | 232.73 μs | 120.79 μs |  1,161.8 μs |    921.6 μs |  1,708.0 μs |   807.97 |  13.91 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1,244.7 μs | 219.73 μs | 116.99 μs |  1,174.2 μs |    964.0 μs |  1,864.1 μs |   803.41 |  13.23 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1,254.4 μs | 240.25 μs | 121.71 μs |  1,179.6 μs |    961.9 μs |  2,005.2 μs |   797.17 |  14.82 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1,262.3 μs |  94.73 μs |  50.43 μs |  1,246.8 μs |  1,087.2 μs |  1,495.5 μs |   792.22 |  66.26 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,312.2 μs | 368.47 μs | 188.92 μs |  1,133.9 μs |    979.4 μs |  2,286.1 μs |   762.10 |  15.31 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1,324.7 μs | 191.79 μs |  99.54 μs |  1,243.5 μs |  1,121.1 μs |  1,957.8 μs |   754.87 |  66.27 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1,359.1 μs | 278.77 μs | 144.69 μs |  1,417.4 μs |    881.0 μs |  1,819.4 μs |   735.77 |   13.1 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1,419.1 μs | 188.91 μs |  98.05 μs |  1,360.9 μs |  1,196.7 μs |  2,115.1 μs |   704.67 |  74.56 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1,426.4 μs | 372.86 μs | 195.97 μs |  1,314.7 μs |    979.2 μs |  2,330.0 μs |   701.09 |  36.69 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1,446.8 μs | 376.94 μs | 190.96 μs |  1,448.5 μs |    888.7 μs |  2,642.7 μs |   691.16 |   13.1 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1,496.1 μs | 450.84 μs | 225.75 μs |  1,358.2 μs |    956.4 μs |  2,392.5 μs |   668.41 |  14.84 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  1,544.5 μs | 235.38 μs | 122.17 μs |  1,515.5 μs |  1,230.4 μs |  2,288.9 μs |   647.44 |  68.55 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1,577.1 μs | 314.44 μs | 161.21 μs |  1,548.7 μs |  1,136.8 μs |  2,399.8 μs |   634.08 |  39.07 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2,601.3 μs | 307.56 μs | 161.65 μs |  2,519.6 μs |  2,290.4 μs |  3,793.2 μs |   384.43 |  33.85 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2,841.5 μs | 247.97 μs | 132.02 μs |  2,914.8 μs |  2,358.7 μs |  3,286.4 μs |   351.92 |  34.18 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2,864.6 μs | 137.69 μs |  76.36 μs |  2,836.8 μs |  2,639.5 μs |  3,240.3 μs |   349.09 |  32.59 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  3,140.8 μs | 571.84 μs | 300.56 μs |  2,875.9 μs |  2,652.2 μs |  5,276.9 μs |   318.39 |  32.31 KB |
|                                           |                       |             |           |           |             |             |             |          |           |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11,102.2 μs | 487.50 μs | 246.97 μs | 11,114.7 μs | 10,143.3 μs | 12,057.9 μs |    90.07 |   5.68 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,121.4 μs | 449.54 μs | 227.74 μs | 11,157.4 μs | 10,039.5 μs | 12,195.5 μs |    89.92 |   5.68 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11,128.4 μs | 388.75 μs | 194.66 μs | 11,050.4 μs | 10,330.6 μs | 11,913.0 μs |    89.86 |  14.12 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11,216.3 μs | 431.26 μs | 221.11 μs | 11,241.4 μs | 10,165.1 μs | 12,613.6 μs |    89.16 |   7.93 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,220.4 μs | 551.02 μs | 275.91 μs | 11,235.4 μs |  9,040.3 μs | 12,402.4 μs |    89.12 |   8.18 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11,304.7 μs | 717.42 μs | 355.15 μs | 11,089.2 μs | 10,014.1 μs | 13,425.2 μs |    88.46 |   5.68 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,435.3 μs | 697.29 μs | 353.25 μs | 11,337.4 μs |  9,861.6 μs | 13,787.7 μs |    87.45 |  16.52 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,481.7 μs | 560.72 μs | 291.03 μs | 11,511.9 μs | 10,548.0 μs | 12,569.6 μs |    87.10 |   8.21 KB |
