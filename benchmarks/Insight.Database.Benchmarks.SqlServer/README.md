# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.3915/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Type                  | Mean        | StdDev      | Error     | Median      | Min         | Max         | Op/s     | Allocated |
|------------------------------------------ |---------------------- |------------:|------------:|----------:|------------:|------------:|------------:|---------:|----------:|
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |    963.3 μs |    46.92 μs |  24.98 μs |    957.8 μs |    883.5 μs |  1,096.0 μs | 1,038.09 |  12.44 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1,025.6 μs |    70.84 μs |  35.89 μs |  1,012.9 μs |    923.1 μs |  1,186.8 μs |   975.06 |   13.1 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |  1,056.6 μs |   104.19 μs |  54.08 μs |  1,041.3 μs |    902.5 μs |  1,372.1 μs |   946.40 |  12.17 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1,058.2 μs |   109.26 μs |  56.71 μs |  1,021.6 μs |    920.2 μs |  1,315.9 μs |   945.00 |  13.57 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1,058.2 μs |    94.92 μs |  50.53 μs |  1,036.3 μs |    919.9 μs |  1,259.2 μs |   944.97 |  12.45 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1,060.2 μs |   113.47 μs |  58.89 μs |  1,035.5 μs |    926.4 μs |  1,474.4 μs |   943.23 |  13.85 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1,066.3 μs |   128.91 μs |  67.75 μs |  1,021.5 μs |    935.5 μs |  1,571.0 μs |   937.78 |   13.2 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1,070.5 μs |    78.34 μs |  40.16 μs |  1,060.8 μs |    927.3 μs |  1,256.3 μs |   934.18 |  14.82 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1,071.7 μs |   120.06 μs |  62.31 μs |  1,051.5 μs |    885.5 μs |  1,482.7 μs |   933.09 |  12.44 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1,087.6 μs |   129.15 μs |  63.94 μs |  1,052.0 μs |    904.1 μs |  1,374.7 μs |   919.47 |   13.1 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1,101.7 μs |   119.49 μs |  62.81 μs |  1,087.4 μs |    889.9 μs |  1,458.2 μs |   907.65 |   13.2 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1,103.7 μs |   109.63 μs |  56.90 μs |  1,078.2 μs |    903.8 μs |  1,375.6 μs |   906.01 |  13.86 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1,112.4 μs |   144.49 μs |  75.94 μs |  1,100.8 μs |    884.3 μs |  1,434.0 μs |   898.99 |  12.47 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1,112.4 μs |   196.96 μs |  99.78 μs |  1,047.9 μs |    907.2 μs |  1,876.0 μs |   898.93 |  13.19 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1,116.3 μs |   152.95 μs |  79.39 μs |  1,086.0 μs |    917.2 μs |  1,527.0 μs |   895.78 |  12.45 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1,117.7 μs |   133.42 μs |  68.40 μs |  1,082.3 μs |    934.3 μs |  1,493.0 μs |   894.73 |   13.1 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1,118.9 μs |   168.46 μs |  86.37 μs |  1,081.5 μs |    914.1 μs |  1,487.7 μs |   893.77 |  12.44 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1,121.5 μs |   133.33 μs |  70.99 μs |  1,090.2 μs |    924.2 μs |  1,482.3 μs |   891.68 |  13.85 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1,131.8 μs |   121.24 μs |  63.73 μs |  1,093.2 μs |    975.9 μs |  1,558.1 μs |   883.51 |  14.73 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1,138.2 μs |   183.44 μs |  96.42 μs |  1,102.2 μs |    901.3 μs |  1,751.1 μs |   878.61 |  12.45 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1,140.4 μs |   111.74 μs |  58.73 μs |  1,111.6 μs |    961.8 μs |  1,457.1 μs |   876.91 |  14.84 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1,142.2 μs |    95.06 μs |  69.45 μs |  1,122.0 μs |  1,006.3 μs |  1,431.6 μs |   875.53 |        NA |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1,143.5 μs |   182.28 μs |  90.24 μs |  1,070.3 μs |    994.7 μs |  1,816.3 μs |   874.49 |  14.54 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1,146.6 μs |   117.12 μs |  60.79 μs |  1,121.2 μs |  1,002.1 μs |  1,550.8 μs |   872.17 |  14.74 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1,157.8 μs |   202.97 μs | 102.83 μs |  1,083.8 μs |    925.4 μs |  1,903.5 μs |   863.74 |  13.85 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1,184.5 μs |   188.30 μs |  98.97 μs |  1,124.2 μs |    970.3 μs |  1,687.4 μs |   844.26 |  13.13 KB |
| Single                                    | InsightBenchmarkWrite |  1,187.0 μs |   204.57 μs | 104.89 μs |  1,120.9 μs |    943.4 μs |  1,657.8 μs |   842.48 |  12.94 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1,187.0 μs |   118.53 μs |  60.77 μs |  1,156.8 μs |  1,036.7 μs |  1,477.2 μs |   842.43 |  15.59 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1,200.2 μs |   119.11 μs |  61.07 μs |  1,167.8 μs |    996.1 μs |  1,481.4 μs |   833.18 |  15.57 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,201.0 μs |   100.09 μs |  53.29 μs |  1,191.5 μs |  1,051.0 μs |  1,500.1 μs |   832.63 |   16.3 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1,205.1 μs |   151.87 μs |  77.86 μs |  1,167.5 μs |    978.4 μs |  1,638.7 μs |   829.79 |  14.74 KB |
| Single                                    | InsightBenchmark      |  1,207.4 μs |   200.60 μs | 105.43 μs |  1,140.2 μs |    952.3 μs |  1,688.3 μs |   828.20 |  13.22 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1,207.6 μs |   147.40 μs |  77.47 μs |  1,161.0 μs |    991.3 μs |  1,546.3 μs |   828.10 |  14.84 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1,223.4 μs |   222.19 μs | 113.92 μs |  1,144.2 μs |  1,017.9 μs |  1,932.0 μs |   817.40 |  14.82 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1,232.5 μs |   231.04 μs | 118.46 μs |  1,192.5 μs |    914.7 μs |  1,795.5 μs |   811.35 |  12.47 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1,235.9 μs |   291.39 μs | 153.15 μs |  1,135.7 μs |    889.2 μs |  1,834.8 μs |   809.13 |  12.82 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1,237.6 μs |   258.00 μs | 133.91 μs |  1,149.5 μs |  1,025.6 μs |  2,166.3 μs |   808.00 |  36.69 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1,239.4 μs |   209.42 μs | 108.69 μs |  1,173.0 μs |    995.4 μs |  1,877.3 μs |   806.86 |   36.7 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1,246.1 μs |   253.33 μs | 136.67 μs |  1,159.5 μs |    896.5 μs |  1,659.2 μs |   802.50 |   13.2 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |  1,250.6 μs |    76.57 μs |  39.26 μs |  1,243.5 μs |  1,128.5 μs |  1,440.4 μs |   799.61 |  65.98 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1,287.5 μs |   248.75 μs | 129.11 μs |  1,221.5 μs |    965.5 μs |  1,892.5 μs |   776.69 |  13.91 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1,294.9 μs |   476.46 μs | 250.43 μs |  1,102.2 μs |    927.9 μs |  3,186.1 μs |   772.26 |  12.45 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1,302.2 μs |   181.43 μs |  95.36 μs |  1,261.5 μs |  1,062.6 μs |  1,928.4 μs |   767.93 |  38.79 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1,310.0 μs |   238.07 μs | 123.57 μs |  1,253.8 μs |  1,027.0 μs |  1,937.7 μs |   763.35 |  14.82 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1,313.2 μs |   227.84 μs | 116.82 μs |  1,271.9 μs |  1,006.3 μs |  1,717.1 μs |   761.52 |  14.73 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1,324.0 μs |   331.22 μs | 178.69 μs |  1,166.8 μs |    993.9 μs |  2,135.1 μs |   755.27 |  15.49 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1,349.6 μs |   313.40 μs | 160.68 μs |  1,349.5 μs |    914.9 μs |  2,098.2 μs |   740.94 |  12.44 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |  1,351.8 μs |   103.49 μs |  52.43 μs |  1,335.4 μs |  1,163.8 μs |  1,572.6 μs |   739.77 |  66.27 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1,353.9 μs |   289.00 μs | 151.90 μs |  1,202.5 μs |  1,005.2 μs |  1,859.9 μs |   738.59 |  15.49 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |  1,371.2 μs |    72.33 μs |  37.54 μs |  1,362.6 μs |  1,216.7 μs |  1,558.7 μs |   729.28 |  68.27 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1,421.7 μs |   382.43 μs | 193.74 μs |  1,273.8 μs |  1,132.7 μs |  2,634.7 μs |   703.41 |  38.98 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,434.5 μs |   400.18 μs | 207.71 μs |  1,228.2 μs |  1,029.4 μs |  2,485.4 μs |   697.09 |  16.25 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,442.5 μs |   442.08 μs | 226.66 μs |  1,242.6 μs |  1,056.0 μs |  2,503.2 μs |   693.26 |   16.3 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1,463.8 μs |   424.95 μs | 223.35 μs |  1,209.7 μs |  1,022.0 μs |  2,182.0 μs |   683.15 |  15.01 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1,475.5 μs |   226.09 μs | 117.35 μs |  1,544.0 μs |    983.0 μs |  1,870.6 μs |   677.71 |   13.2 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1,489.3 μs |   250.94 μs | 130.24 μs |  1,440.9 μs |  1,040.9 μs |  1,888.0 μs |   671.45 |  12.45 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1,494.2 μs |   449.53 μs | 239.33 μs |  1,234.1 μs |  1,028.3 μs |  2,328.4 μs |   669.27 |  14.55 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1,504.8 μs |   222.57 μs | 115.52 μs |  1,532.3 μs |  1,044.9 μs |  1,868.6 μs |   664.52 |  15.59 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1,543.6 μs |   150.27 μs |  78.98 μs |  1,506.0 μs |  1,370.6 μs |  2,081.8 μs |   647.84 |  12.47 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1,551.4 μs |   216.95 μs | 111.23 μs |  1,500.6 μs |  1,190.4 μs |  2,208.9 μs |   644.57 |  14.55 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |  1,581.8 μs |   396.33 μs | 205.71 μs |  1,413.6 μs |  1,231.6 μs |  2,908.6 μs |   632.18 |  68.64 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1,614.8 μs |    93.58 μs |  49.18 μs |  1,600.8 μs |  1,423.6 μs |  1,859.2 μs |   619.26 |  15.48 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1,634.1 μs |   219.20 μs | 115.21 μs |  1,568.2 μs |  1,252.6 μs |  2,235.2 μs |   611.98 |  13.86 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1,652.6 μs |   356.09 μs | 182.57 μs |  1,549.2 μs |  1,159.2 μs |  2,660.2 μs |   605.11 |  12.45 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1,653.3 μs |   135.33 μs |  71.13 μs |  1,622.4 μs |  1,456.1 μs |  2,129.0 μs |   604.87 |  14.46 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1,657.9 μs |   192.11 μs | 102.28 μs |  1,627.2 μs |  1,230.0 μs |  2,154.6 μs |   603.16 |  14.74 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1,682.3 μs |   274.28 μs | 140.63 μs |  1,643.3 μs |  1,295.7 μs |  2,404.9 μs |   594.41 |  12.47 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1,742.5 μs |   208.92 μs | 109.81 μs |  1,772.5 μs |  1,191.2 μs |  2,030.8 μs |   573.89 |  12.45 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1,783.7 μs |   425.93 μs | 223.87 μs |  1,762.8 μs |  1,020.3 μs |  2,556.3 μs |   560.62 |  13.91 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,873.4 μs |   256.24 μs | 134.68 μs |  1,786.2 μs |  1,506.8 μs |  2,348.2 μs |   533.78 |  15.92 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  2,110.0 μs |   369.16 μs | 187.02 μs |  2,095.7 μs |  1,368.8 μs |  2,855.1 μs |   473.93 |  15.57 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  2,249.8 μs |   775.64 μs | 407.67 μs |  1,915.0 μs |  1,524.5 μs |  4,775.1 μs |   444.48 |  13.19 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2,416.2 μs |   114.87 μs |  58.89 μs |  2,421.0 μs |  2,208.8 μs |  2,767.6 μs |   413.88 |  34.18 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2,598.8 μs |   254.19 μs | 130.33 μs |  2,524.2 μs |  2,328.9 μs |  3,373.6 μs |   384.79 |  34.18 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2,856.5 μs |   119.39 μs |  60.49 μs |  2,836.1 μs |  2,666.7 μs |  3,123.6 μs |   350.07 |  32.59 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2,939.4 μs |   209.23 μs | 108.60 μs |  2,860.5 μs |  2,702.0 μs |  3,565.0 μs |   340.21 |  32.59 KB |
|                                           |                       |             |             |           |             |             |             |          |           |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,331.6 μs |   438.24 μs | 222.01 μs | 11,428.9 μs | 10,371.2 μs | 12,112.4 μs |    88.25 |   8.21 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 11,378.7 μs |   528.37 μs | 264.57 μs | 11,291.8 μs | 10,342.7 μs | 12,856.3 μs |    87.88 |    5.4 KB |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11,387.3 μs |   745.59 μs | 377.72 μs | 11,141.9 μs | 10,198.9 μs | 12,995.6 μs |    87.82 |    5.4 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   | 11,457.6 μs |   580.48 μs | 290.66 μs | 11,277.7 μs | 10,490.9 μs | 12,935.0 μs |    87.28 |   8.21 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,508.2 μs |   492.05 μs | 249.28 μs | 11,514.1 μs |  9,989.6 μs | 12,499.1 μs |    86.89 |  17.84 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,658.6 μs |   629.43 μs | 318.87 μs | 11,667.6 μs | 10,473.8 μs | 13,119.5 μs |    85.77 |   9.49 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 11,667.5 μs |   627.31 μs | 321.63 μs | 11,678.0 μs | 10,415.1 μs | 13,214.0 μs |    85.71 |  13.84 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 11,815.3 μs | 1,897.80 μs | 939.48 μs | 11,390.7 μs |  9,822.2 μs | 20,163.0 μs |    84.64 |   5.68 KB |
