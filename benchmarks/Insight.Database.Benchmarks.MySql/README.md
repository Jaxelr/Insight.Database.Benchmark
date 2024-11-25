# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Type                  | Mean        | StdDev      | Error     | Median      | Min        | Max         | Op/s     | Allocated |
|------------------------------------------ |---------------------- |------------:|------------:|----------:|------------:|-----------:|------------:|---------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |    996.1 μs |    90.37 μs |  46.33 μs |    989.3 μs |   832.8 μs |  1,299.2 μs | 1,003.94 |  21.92 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1,000.8 μs |   113.48 μs |  58.90 μs |    960.7 μs |   863.2 μs |  1,404.1 μs |   999.18 |  22.57 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1,004.8 μs |    63.53 μs |  33.83 μs |    989.4 μs |   915.1 μs |  1,175.8 μs |   995.19 |  24.98 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1,019.1 μs |   141.65 μs |  73.52 μs |    992.4 μs |   852.8 μs |  1,495.8 μs |   981.25 |  22.57 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1,026.1 μs |   157.90 μs |  80.96 μs |    995.6 μs |   837.7 μs |  1,676.7 μs |   974.60 |  22.57 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1,033.1 μs |   104.18 μs |  52.16 μs |  1,015.5 μs |   867.8 μs |  1,246.8 μs |   967.94 |  22.59 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1,039.9 μs |   107.73 μs |  56.62 μs |  1,014.9 μs |   876.6 μs |  1,344.7 μs |   961.63 |  21.92 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1,042.6 μs |   101.94 μs |  52.91 μs |  1,021.8 μs |   879.6 μs |  1,355.6 μs |   959.18 |  24.99 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1,051.1 μs |   117.59 μs |  58.88 μs |  1,032.1 μs |   852.8 μs |  1,350.5 μs |   951.37 |  21.95 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1,052.4 μs |   148.42 μs |  77.03 μs |  1,023.0 μs |   884.2 μs |  1,511.0 μs |   950.24 |  21.94 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1,057.5 μs |   100.45 μs |  51.50 μs |  1,040.1 μs |   918.4 μs |  1,342.5 μs |   945.61 |  24.23 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1,058.3 μs |   141.92 μs |  73.66 μs |  1,028.8 μs |   910.8 μs |  1,552.8 μs |   944.93 |  21.95 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1,068.5 μs |   129.83 μs |  65.01 μs |  1,027.5 μs |   867.1 μs |  1,360.5 μs |   935.88 |  21.02 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1,068.8 μs |   112.75 μs |  58.52 μs |  1,046.0 μs |   920.7 μs |  1,496.5 μs |   935.60 |  24.97 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1,069.4 μs |   120.31 μs |  62.44 μs |  1,042.6 μs |   842.0 μs |  1,423.2 μs |   935.10 |  24.98 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1,079.2 μs |    90.81 μs |  47.73 μs |  1,049.1 μs |   942.6 μs |  1,354.1 μs |   926.64 |  25.01 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1,081.9 μs |   116.33 μs |  59.65 μs |  1,053.6 μs |   923.1 μs |  1,528.4 μs |   924.34 |  21.07 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1,098.6 μs |   131.01 μs |  69.75 μs |  1,084.7 μs |   937.4 μs |  1,470.8 μs |   910.21 |  24.97 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1,099.3 μs |   116.39 μs |  58.96 μs |  1,075.4 μs |   853.1 μs |  1,402.4 μs |   909.70 |  24.48 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1,111.9 μs |   165.86 μs |  85.04 μs |  1,053.0 μs |   919.0 μs |  1,701.7 μs |   899.34 |  24.98 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1,112.3 μs |   118.58 μs |  60.07 μs |  1,124.3 μs |   886.6 μs |  1,422.1 μs |   899.00 |  24.97 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,118.9 μs |   117.03 μs |  62.31 μs |  1,102.7 μs |   950.5 μs |  1,557.5 μs |   893.77 |  23.54 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1,119.9 μs |   120.50 μs |  62.54 μs |  1,088.5 μs |   939.6 μs |  1,472.0 μs |   892.95 |  24.62 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1,120.0 μs |   147.24 μs |  74.59 μs |  1,116.8 μs |   899.1 μs |  1,564.6 μs |   892.88 |  20.79 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |  1,121.1 μs |   246.60 μs | 127.99 μs |  1,020.6 μs |   875.7 μs |  2,110.9 μs |   891.99 |  21.92 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1,135.8 μs |   196.47 μs | 103.27 μs |  1,066.8 μs |   899.8 μs |  1,673.1 μs |   880.47 |  22.59 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,135.8 μs |   123.77 μs |  62.71 μs |  1,112.6 μs |   980.7 μs |  1,668.5 μs |   880.45 |  23.49 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1,148.0 μs |   166.37 μs |  85.30 μs |  1,095.8 μs |   938.5 μs |  1,589.8 μs |   871.10 |  24.73 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1,150.9 μs |   194.83 μs | 101.12 μs |  1,116.5 μs |   880.1 μs |  1,665.5 μs |   868.88 |  24.71 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1,155.7 μs |   175.92 μs |  91.31 μs |  1,123.2 μs |   931.6 μs |  1,717.7 μs |   865.27 |  24.48 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1,155.7 μs |   174.11 μs |  92.70 μs |  1,115.1 μs |   938.4 μs |  1,652.3 μs |   865.25 |  24.98 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1,156.8 μs |   176.48 μs |  91.60 μs |  1,101.3 μs |   981.1 μs |  1,726.0 μs |   864.44 |  24.51 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1,158.0 μs |    91.99 μs |  48.35 μs |  1,126.3 μs | 1,017.3 μs |  1,391.2 μs |   863.54 |  27.24 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1,165.3 μs |   176.57 μs |  92.80 μs |  1,116.2 μs |   919.3 μs |  1,619.5 μs |   858.16 |   24.2 KB |
| Single                                    | InsightBenchmarkWrite |  1,168.5 μs |   305.53 μs | 156.65 μs |  1,034.7 μs |   830.0 μs |  1,956.1 μs |   855.77 |  21.96 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1,178.7 μs |   102.66 μs |  53.96 μs |  1,149.4 μs |   988.5 μs |  1,430.8 μs |   848.39 |  27.24 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1,181.4 μs |    98.77 μs |  50.04 μs |  1,158.7 μs | 1,035.8 μs |  1,414.5 μs |   846.42 |  27.53 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1,181.6 μs |   354.24 μs | 179.46 μs |  1,087.7 μs |   847.5 μs |  2,472.1 μs |   846.29 |  21.92 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1,185.6 μs |   146.13 μs |  74.92 μs |  1,156.5 μs |   967.0 μs |  1,688.2 μs |   843.45 |  27.53 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1,185.8 μs |   280.18 μs | 140.29 μs |  1,084.0 μs |   835.3 μs |  1,912.2 μs |   843.30 |  22.59 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1,186.3 μs |   232.56 μs | 123.82 μs |  1,106.0 μs |   929.1 μs |  2,023.3 μs |   842.95 |  24.69 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1,189.0 μs |   156.61 μs |  84.49 μs |  1,164.7 μs |   947.8 μs |  1,608.5 μs |   841.02 |   48.1 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1,189.5 μs |   119.36 μs |  60.47 μs |  1,151.4 μs | 1,026.3 μs |  1,534.8 μs |   840.70 |  27.55 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1,197.8 μs |   109.84 μs |  57.73 μs |  1,187.9 μs | 1,054.2 μs |  1,489.9 μs |   834.89 |  27.24 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1,199.0 μs |   131.88 μs |  71.15 μs |  1,184.6 μs | 1,007.0 μs |  1,598.9 μs |   834.03 |  27.53 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1,200.8 μs |   215.70 μs | 110.59 μs |  1,125.6 μs |   951.2 μs |  1,763.6 μs |   832.79 |  48.37 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1,203.3 μs |   268.41 μs | 137.62 μs |  1,109.1 μs |   890.3 μs |  1,997.0 μs |   831.03 |  22.31 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1,205.2 μs |   121.99 μs |  64.95 μs |  1,174.8 μs | 1,030.6 μs |  1,622.8 μs |   829.75 |  50.65 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1,231.3 μs |   116.08 μs |  61.01 μs |  1,201.2 μs | 1,045.1 μs |  1,487.8 μs |   812.14 |  26.98 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1,234.7 μs |   140.48 μs |  72.02 μs |  1,206.9 μs | 1,025.2 μs |  1,640.8 μs |   809.88 |  27.55 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1,235.7 μs |   233.54 μs | 119.74 μs |  1,149.7 μs |   950.4 μs |  1,890.2 μs |   809.27 |  25.05 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1,241.4 μs |   362.86 μs | 190.72 μs |  1,089.7 μs |   861.7 μs |  2,150.6 μs |   805.54 |  21.66 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1,245.0 μs |   181.37 μs |  92.99 μs |  1,191.2 μs | 1,029.3 μs |  1,761.4 μs |   803.21 |  27.53 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1,253.3 μs |   156.34 μs |  84.35 μs |  1,181.5 μs | 1,026.9 μs |  1,652.6 μs |   797.91 |  27.53 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1,255.2 μs |   204.53 μs | 104.87 μs |  1,285.9 μs |   946.0 μs |  2,026.0 μs |   796.68 |  23.91 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1,272.4 μs |   235.93 μs | 120.96 μs |  1,188.4 μs |   996.0 μs |  1,862.3 μs |   785.94 |  27.55 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1,273.2 μs |   215.39 μs | 111.79 μs |  1,228.6 μs |   949.1 μs |  1,909.5 μs |   785.43 |   24.2 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1,275.0 μs |   418.44 μs | 214.54 μs |  1,092.2 μs |   913.4 μs |  2,432.9 μs |   784.32 |   24.9 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1,276.3 μs |   356.22 μs | 184.89 μs |  1,152.0 μs |   898.4 μs |  2,406.3 μs |   783.53 |  22.29 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,290.6 μs |   195.49 μs | 101.47 μs |  1,236.2 μs | 1,013.5 μs |  1,839.7 μs |   774.84 |  23.49 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1,316.5 μs |   249.17 μs | 130.96 μs |  1,203.8 μs |   997.1 μs |  1,793.7 μs |   759.61 |  24.22 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1,347.9 μs |   405.02 μs | 205.19 μs |  1,257.2 μs |   888.4 μs |  2,357.8 μs |   741.91 |  21.02 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1,356.9 μs |   285.11 μs | 142.76 μs |  1,291.4 μs |   958.3 μs |  2,011.6 μs |   736.99 |  24.48 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1,388.2 μs |   404.04 μs | 204.69 μs |  1,252.0 μs |   855.4 μs |  2,310.4 μs |   720.38 |  21.94 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,423.4 μs |   321.24 μs | 162.74 μs |  1,418.0 μs | 1,002.1 μs |  2,171.9 μs |   702.54 |  23.25 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1,460.5 μs |   289.84 μs | 145.13 μs |  1,455.9 μs |   912.3 μs |  2,195.2 μs |   684.68 |  21.94 KB |
| Single                                    | InsightBenchmark      |  1,733.1 μs |   309.04 μs | 164.54 μs |  1,655.0 μs | 1,204.7 μs |  2,474.2 μs |   577.01 |  21.68 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1,758.9 μs |   403.02 μs | 204.17 μs |  1,828.5 μs | 1,158.8 μs |  2,493.2 μs |   568.53 |  50.93 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2,635.8 μs |   181.63 μs |  96.70 μs |  2,589.1 μs | 2,402.3 μs |  3,234.0 μs |   379.39 |  47.49 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2,724.1 μs |   259.33 μs | 134.60 μs |  2,659.1 μs | 2,370.4 μs |  3,473.5 μs |   367.10 |  47.49 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2,750.1 μs |   148.50 μs |  79.07 μs |  2,713.2 μs | 2,530.2 μs |  3,186.9 μs |   363.62 |  46.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2,766.1 μs |   360.60 μs | 184.88 μs |  2,657.6 μs | 2,428.3 μs |  4,281.6 μs |   361.52 |  46.95 KB |
|                                           |                       |             |             |           |             |            |             |          |           |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10,267.7 μs | 1,344.73 μs | 689.45 μs | 10,442.9 μs | 5,307.7 μs | 11,938.3 μs |    97.39 |   35.7 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 10,280.9 μs |   800.54 μs | 396.30 μs | 10,364.9 μs | 5,709.9 μs | 11,403.9 μs |    97.27 |  23.45 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10,615.1 μs |   546.99 μs | 280.45 μs | 10,590.8 μs | 9,471.8 μs | 11,715.4 μs |    94.21 |  36.06 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10,649.2 μs |   581.77 μs | 294.73 μs | 10,632.1 μs | 8,989.6 μs | 12,039.8 μs |    93.90 |  25.48 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10,702.5 μs |   935.79 μs | 485.71 μs | 10,766.1 μs | 5,888.2 μs | 11,844.2 μs |    93.44 |  26.11 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10,882.0 μs |   631.52 μs | 331.93 μs | 10,925.7 μs | 8,772.0 μs | 12,091.0 μs |    91.89 |  23.52 KB |
