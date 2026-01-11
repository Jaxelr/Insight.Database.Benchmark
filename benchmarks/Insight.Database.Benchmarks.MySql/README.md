# Insight.Database.Benchmarks.MySql

These are benchmark scenarios for the MySql Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the MySql version 5.7.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


```
| Method                                    | Type                  | Mean        | StdDev    | Error     | Median      | Min        | Max         | Op/s     | Allocated |
|------------------------------------------ |---------------------- |------------:|----------:|----------:|------------:|-----------:|------------:|---------:|----------:|
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |    949.3 μs |  44.14 μs |  23.50 μs |    951.7 μs |   879.3 μs |  1,089.7 μs | 1,053.36 |   20.6 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |    995.0 μs |  59.70 μs |  30.24 μs |    982.4 μs |   872.4 μs |  1,122.6 μs | 1,005.02 |   20.6 KB |
| Single                                    | InsightBenchmarkWrite |    998.8 μs |  65.97 μs |  34.24 μs |    990.8 μs |   867.5 μs |  1,165.5 μs | 1,001.19 |  20.64 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |  1,007.7 μs |  79.82 μs |  41.95 μs |    987.4 μs |   895.9 μs |  1,215.0 μs |   992.34 |  20.92 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |  1,009.1 μs |  69.84 μs |  35.38 μs |    997.8 μs |   891.8 μs |  1,204.1 μs |   990.97 |  20.62 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |  1,045.4 μs |  99.21 μs |  52.14 μs |  1,017.2 μs |   934.5 μs |  1,335.0 μs |   956.58 |  20.95 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |  1,057.9 μs |  58.71 μs |  31.26 μs |  1,058.1 μs |   970.0 μs |  1,250.1 μs |   945.31 |  23.32 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |  1,058.2 μs | 110.11 μs |  56.45 μs |  1,041.2 μs |   882.6 μs |  1,295.4 μs |   944.99 |  20.95 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |  1,058.6 μs |  60.01 μs |  31.95 μs |  1,062.3 μs |   919.8 μs |  1,265.4 μs |   944.65 |  23.32 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |  1,061.8 μs | 136.21 μs |  68.20 μs |  1,016.1 μs |   898.6 μs |  1,509.2 μs |   941.79 |  20.92 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |  1,061.9 μs |  74.41 μs |  38.15 μs |  1,044.8 μs |   941.2 μs |  1,253.5 μs |   941.72 |  19.76 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |  1,063.6 μs | 112.36 μs |  56.92 μs |  1,023.1 μs |   911.6 μs |  1,350.2 μs |   940.22 |  20.63 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |  1,074.1 μs | 137.65 μs |  71.44 μs |  1,036.8 μs |   866.0 μs |  1,567.9 μs |   931.00 |  20.92 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |  1,085.4 μs |  83.92 μs |  42.02 μs |  1,064.3 μs |   936.3 μs |  1,308.0 μs |   921.34 |  23.19 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |  1,087.1 μs | 117.10 μs |  60.04 μs |  1,068.0 μs |   901.6 μs |  1,446.9 μs |   919.84 |  23.16 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |  1,088.3 μs | 127.96 μs |  66.42 μs |  1,041.5 μs |   914.2 μs |  1,383.3 μs |   918.88 |  23.32 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |  1,090.7 μs | 116.97 μs |  59.26 μs |  1,056.5 μs |   939.0 μs |  1,463.8 μs |   916.87 |  23.16 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |  1,091.5 μs | 110.72 μs |  56.77 μs |  1,068.0 μs |   921.5 μs |  1,374.6 μs |   916.17 |  23.34 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |  1,092.3 μs | 128.17 μs |  65.71 μs |  1,044.5 μs |   909.5 μs |  1,399.4 μs |   915.50 |  23.34 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |  1,097.3 μs |  82.50 μs |  42.30 μs |  1,071.5 μs | 1,000.2 μs |  1,310.1 μs |   911.33 |  23.34 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |  1,098.9 μs | 109.36 μs |  55.40 μs |  1,058.3 μs |   952.9 μs |  1,384.4 μs |   910.00 |  20.95 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |  1,104.8 μs | 143.50 μs |  75.43 μs |  1,055.8 μs |   913.7 μs |  1,490.0 μs |   905.13 |  20.62 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |  1,109.3 μs | 111.21 μs |  58.45 μs |  1,074.5 μs |   923.5 μs |  1,470.4 μs |   901.44 |  20.92 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |  1,113.7 μs | 126.22 μs |  64.71 μs |  1,068.8 μs |   921.2 μs |  1,405.4 μs |   897.94 |  23.16 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |  1,116.1 μs | 145.32 μs |  74.50 μs |  1,077.1 μs |   912.8 μs |  1,542.2 μs |   896.00 |  20.95 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |  1,121.7 μs | 109.01 μs |  55.22 μs |  1,097.2 μs |   949.6 μs |  1,384.7 μs |   891.53 |  47.05 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |  1,128.6 μs | 169.50 μs |  89.09 μs |  1,081.6 μs |   932.6 μs |  1,701.0 μs |   886.06 |  20.62 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |  1,130.2 μs | 100.77 μs |  52.30 μs |  1,113.1 μs |   979.5 μs |  1,407.0 μs |   884.81 |  23.19 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |  1,135.9 μs | 164.03 μs |  84.10 μs |  1,083.9 μs |   886.9 μs |  1,544.4 μs |   880.38 |   20.6 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |  1,138.7 μs |  54.35 μs |  29.32 μs |  1,128.2 μs | 1,040.1 μs |  1,328.7 μs |   878.19 |  25.88 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |  1,149.3 μs | 150.00 μs |  76.91 μs |  1,091.7 μs |   973.9 μs |  1,528.7 μs |   870.07 |  47.06 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |  1,159.6 μs | 130.76 μs |  67.87 μs |  1,127.5 μs |   994.6 μs |  1,635.9 μs |   862.37 |  23.16 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,160.1 μs | 109.48 μs |  55.46 μs |  1,118.0 μs | 1,017.8 μs |  1,401.6 μs |   861.96 |  21.94 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |  1,162.8 μs | 246.10 μs | 129.35 μs |  1,082.0 μs |   876.7 μs |  1,890.2 μs |   859.97 |   52.8 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |  1,167.6 μs | 281.29 μs | 140.85 μs |  1,061.4 μs |   860.0 μs |  1,775.4 μs |   856.47 |  20.62 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |  1,168.1 μs | 177.72 μs |  90.03 μs |  1,114.9 μs |   900.1 μs |  1,552.2 μs |   856.12 |   19.7 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |  1,181.6 μs | 183.50 μs |  94.08 μs |  1,117.2 μs |   978.0 μs |  1,568.1 μs |   846.33 |  23.16 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |  1,182.0 μs |  77.23 μs |  39.60 μs |  1,170.5 μs | 1,051.0 μs |  1,425.1 μs |   845.99 |  25.59 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |  1,184.6 μs | 137.88 μs |  73.41 μs |  1,148.0 μs | 1,019.9 μs |  1,513.0 μs |   844.19 |  23.32 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |  1,186.1 μs | 163.66 μs |  84.94 μs |  1,146.6 μs |   914.2 μs |  1,601.6 μs |   843.09 |  19.76 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |  1,187.6 μs | 230.31 μs | 118.08 μs |  1,117.7 μs |   920.6 μs |  2,040.5 μs |   842.04 |   20.6 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |  1,190.0 μs | 168.04 μs |  87.22 μs |  1,140.6 μs |   979.9 μs |  1,752.2 μs |   840.36 |   19.7 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,198.7 μs | 113.19 μs |  59.49 μs |  1,202.6 μs |   965.0 μs |  1,519.4 μs |   834.24 |  54.35 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |  1,200.8 μs | 180.70 μs |  96.20 μs |  1,141.0 μs |   955.8 μs |  1,816.4 μs |   832.78 |   55.5 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |  1,201.3 μs | 102.24 μs |  51.20 μs |  1,173.0 μs | 1,054.3 μs |  1,521.7 μs |   832.43 |  25.88 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |  1,208.7 μs | 156.83 μs |  81.40 μs |  1,182.7 μs |   972.7 μs |  1,596.7 μs |   827.31 |  23.16 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |  1,216.5 μs | 282.86 μs | 143.30 μs |  1,134.1 μs |   967.9 μs |  2,221.1 μs |   822.05 |  23.36 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |  1,221.7 μs | 133.40 μs |  66.79 μs |  1,178.3 μs | 1,008.0 μs |  1,574.2 μs |   818.55 |  49.61 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |  1,228.0 μs | 135.62 μs |  68.70 μs |  1,170.0 μs | 1,048.6 μs |  1,573.6 μs |   814.34 |  49.32 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |  1,231.5 μs | 140.07 μs |  70.96 μs |  1,192.1 μs | 1,047.1 μs |  1,575.3 μs |   812.01 |  25.62 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |  1,245.1 μs |  95.98 μs |  49.21 μs |  1,240.0 μs | 1,090.1 μs |  1,515.1 μs |   803.12 |  25.62 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |  1,247.3 μs | 189.62 μs |  97.22 μs |  1,192.0 μs |   980.1 μs |  1,682.1 μs |   801.75 |  55.05 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |  1,249.1 μs | 157.48 μs |  78.85 μs |  1,204.5 μs | 1,044.9 μs |  1,666.6 μs |   800.56 |  25.59 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |  1,249.4 μs | 152.09 μs |  82.06 μs |  1,213.1 μs | 1,077.8 μs |  1,967.8 μs |   800.38 |  57.76 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |  1,250.4 μs | 148.86 μs |  73.69 μs |  1,249.5 μs | 1,011.2 μs |  1,664.1 μs |   799.76 |  21.89 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |  1,262.7 μs | 324.12 μs | 168.23 μs |  1,138.0 μs |   988.1 μs |  2,286.1 μs |   791.97 |  23.34 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |  1,277.0 μs | 131.26 μs |  68.13 μs |  1,281.1 μs | 1,050.0 μs |  1,688.5 μs |   783.06 |  25.62 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |  1,282.1 μs | 145.74 μs |  76.60 μs |  1,275.4 μs | 1,019.1 μs |  1,616.5 μs |   779.96 |  23.19 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |  1,294.5 μs | 215.76 μs | 106.81 μs |  1,233.5 μs | 1,050.3 μs |  1,923.3 μs |   772.49 |  25.59 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |  1,299.8 μs | 315.38 μs | 161.70 μs |  1,173.7 μs |   993.2 μs |  2,489.4 μs |   769.37 |  55.52 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |  1,307.1 μs | 276.65 μs | 141.84 μs |  1,219.3 μs | 1,004.1 μs |  2,306.3 μs |   765.08 |  23.16 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |  1,312.1 μs | 171.93 μs |  86.09 μs |  1,267.5 μs | 1,074.5 μs |  1,823.2 μs |   762.12 |  58.05 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |  1,318.1 μs | 207.58 μs | 110.52 μs |  1,291.3 μs | 1,021.2 μs |  1,869.5 μs |   758.68 |  23.19 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |  1,339.1 μs | 155.20 μs |  76.83 μs |  1,335.7 μs | 1,049.2 μs |  1,683.4 μs |   746.80 |  25.88 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |  1,341.5 μs | 209.54 μs | 108.76 μs |  1,281.2 μs | 1,107.2 μs |  2,038.1 μs |   745.45 |  58.07 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |  1,361.3 μs | 238.18 μs | 126.81 μs |  1,426.3 μs |   910.8 μs |  1,693.4 μs |   734.61 |   55.5 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |  1,411.7 μs | 308.54 μs | 162.17 μs |  1,295.4 μs | 1,003.5 μs |  2,277.1 μs |   708.36 |  54.11 KB |
| Single                                    | InsightBenchmark      |  1,444.2 μs | 274.93 μs | 139.28 μs |  1,413.7 μs |   968.3 μs |  2,252.8 μs |   692.45 |  52.81 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      |  2,750.1 μs | 138.21 μs |  70.86 μs |  2,771.7 μs | 2,449.3 μs |  2,963.4 μs |   363.63 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite |  2,763.4 μs | 143.73 μs |  76.53 μs |  2,736.8 μs | 2,490.8 μs |  3,350.0 μs |   361.88 |  46.17 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      |  2,873.1 μs | 115.61 μs |  59.27 μs |  2,850.8 μs | 2,682.5 μs |  3,225.2 μs |   348.06 |  45.65 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite |  2,934.7 μs | 161.68 μs |  82.89 μs |  2,932.9 μs | 2,654.4 μs |  3,378.0 μs |   340.76 |  45.65 KB |
|                                           |                       |             |           |           |             |            |             |          |           |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10,765.5 μs | 532.72 μs | 276.50 μs | 10,799.5 μs | 9,344.8 μs | 11,956.5 μs |    92.89 |  35.02 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite | 10,773.3 μs | 345.01 μs | 174.79 μs | 10,816.2 μs | 9,860.3 μs | 11,838.0 μs |    92.82 |  22.53 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 10,860.4 μs | 534.24 μs | 267.51 μs | 10,963.5 μs | 9,495.5 μs | 11,837.3 μs |    92.08 |  24.16 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  | 10,879.0 μs | 476.58 μs | 241.44 μs | 10,846.1 μs | 9,980.9 μs | 11,820.7 μs |    91.92 |  34.38 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite | 10,980.1 μs | 665.45 μs | 333.21 μs | 10,925.5 μs | 9,460.6 μs | 12,494.2 μs |    91.07 |  22.13 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite | 11,114.8 μs | 618.62 μs | 309.76 μs | 11,041.0 μs | 9,677.4 μs | 12,852.3 μs |    89.97 |   24.5 KB |
