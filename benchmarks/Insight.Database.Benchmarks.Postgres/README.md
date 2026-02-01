# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7705/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   794.9 μs | 145.80 μs |  75.67 μs |   760.8 μs |   610.2 μs | 1,128.5 μs | 1,258.1 |  10.63 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   810.4 μs | 169.11 μs |  83.71 μs |   763.0 μs |   535.6 μs | 1,180.5 μs | 1,233.9 |   8.77 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  |   815.1 μs | 205.89 μs | 103.09 μs |   799.4 μs |   557.2 μs | 1,343.8 μs | 1,226.9 |   35.9 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  |   835.7 μs | 140.40 μs |  70.30 μs |   831.2 μs |   592.4 μs | 1,227.8 μs | 1,196.6 |  37.13 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   861.8 μs |  99.63 μs |  51.71 μs |   874.0 μs |   610.1 μs | 1,109.8 μs | 1,160.4 |  10.63 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   947.4 μs | 164.32 μs |  83.25 μs |   938.4 μs |   628.8 μs | 1,399.2 μs | 1,055.5 |  12.49 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   970.6 μs | 262.98 μs | 136.49 μs |   971.3 μs |   540.1 μs | 1,659.2 μs | 1,030.3 |  10.96 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      | 1,008.8 μs | 107.97 μs |  56.04 μs |   997.6 μs |   818.0 μs | 1,327.5 μs |   991.3 |   7.56 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite | 1,015.4 μs | 124.59 μs |  63.88 μs | 1,013.0 μs |   818.8 μs | 1,251.7 μs |   984.9 |   7.26 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite | 1,056.8 μs | 151.60 μs |  76.80 μs | 1,031.5 μs |   808.9 μs | 1,465.2 μs |   946.3 |   7.26 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite | 1,064.8 μs | 168.84 μs |  85.54 μs | 1,029.2 μs |   823.9 μs | 1,488.3 μs |   939.2 |   7.29 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite | 1,065.2 μs | 160.96 μs |  81.54 μs | 1,029.0 μs |   848.1 μs | 1,481.3 μs |   938.8 |   7.56 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      | 1,065.9 μs | 114.72 μs |  60.30 μs | 1,069.5 μs |   851.0 μs | 1,258.3 μs |   938.1 |   7.26 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite | 1,079.0 μs | 124.24 μs |  61.50 μs | 1,079.6 μs |   853.8 μs | 1,344.5 μs |   926.8 |  10.86 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite | 1,079.5 μs | 148.72 μs |  75.34 μs | 1,067.8 μs |   853.4 μs | 1,524.3 μs |   926.3 |   7.29 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite | 1,084.2 μs | 114.84 μs |  59.61 μs | 1,061.8 μs |   899.4 μs | 1,388.4 μs |   922.4 |  10.63 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      | 1,091.4 μs | 155.95 μs |  77.20 μs | 1,111.8 μs |   835.1 μs | 1,439.3 μs |   916.2 |   7.26 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,096.4 μs | 151.54 μs |  75.88 μs | 1,061.8 μs |   888.6 μs | 1,448.8 μs |   912.0 |   7.56 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      | 1,097.1 μs | 196.09 μs | 103.06 μs | 1,062.0 μs |   722.7 μs | 1,642.6 μs |   911.5 |   7.29 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      | 1,097.1 μs | 109.31 μs |  54.73 μs | 1,087.0 μs |   805.3 μs | 1,293.5 μs |   911.5 |   7.29 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      | 1,106.2 μs | 192.99 μs |  98.95 μs | 1,112.3 μs |   739.1 μs | 1,524.8 μs |   904.0 |   7.56 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite | 1,107.9 μs | 142.93 μs |  74.19 μs | 1,084.7 μs |   893.0 μs | 1,459.7 μs |   902.6 |   8.77 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite | 1,113.6 μs | 147.56 μs |  74.75 μs | 1,121.1 μs |   828.3 μs | 1,405.3 μs |   898.0 |  10.35 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  | 1,115.5 μs | 129.31 μs |  67.11 μs | 1,095.8 μs |   910.4 μs | 1,518.6 μs |   896.5 |  35.87 KB |
| Query&lt;T&gt;                          | InsightBenchmark      | 1,118.6 μs | 257.32 μs | 128.85 μs | 1,161.8 μs |   526.2 μs | 1,523.0 μs |   893.9 |  10.35 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite | 1,127.3 μs | 139.74 μs |  70.79 μs | 1,126.2 μs |   872.6 μs | 1,461.3 μs |   887.0 |   8.82 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      | 1,137.8 μs | 165.38 μs |  85.84 μs | 1,108.4 μs |   872.4 μs | 1,448.7 μs |   878.9 |   8.77 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite | 1,149.1 μs | 193.99 μs |  98.28 μs | 1,129.3 μs |   804.6 μs | 1,812.7 μs |   870.3 |  10.63 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite | 1,155.4 μs | 148.60 μs |  75.28 μs | 1,131.4 μs |   922.9 μs | 1,535.8 μs |   865.5 |  11.58 KB |
| Single                            | InsightBenchmarkWrite | 1,159.2 μs | 180.41 μs |  89.31 μs | 1,163.8 μs |   838.5 μs | 1,638.1 μs |   862.6 |  10.32 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      | 1,182.8 μs | 195.30 μs | 100.13 μs | 1,150.0 μs |   844.8 μs | 1,582.2 μs |   845.5 |  10.86 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite | 1,190.6 μs | 152.13 μs |  78.00 μs | 1,154.2 μs |   945.3 μs | 1,624.2 μs |   839.9 |  12.49 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite | 1,191.3 μs | 220.30 μs | 110.31 μs | 1,200.1 μs |   821.9 μs | 1,773.6 μs |   839.4 |   8.82 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      | 1,220.8 μs | 166.22 μs |  84.21 μs | 1,190.7 μs |   925.2 μs | 1,589.4 μs |   819.2 |   8.82 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      | 1,225.2 μs | 154.07 μs |  78.05 μs | 1,227.2 μs |   874.4 μs | 1,636.4 μs |   816.2 |   8.52 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      | 1,244.0 μs | 199.10 μs | 100.87 μs | 1,244.8 μs |   732.9 μs | 1,733.3 μs |   803.9 |  10.96 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  | 1,246.7 μs | 184.82 μs |  93.63 μs | 1,245.0 μs |   863.1 μs | 1,609.8 μs |   802.1 |  37.38 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite | 1,267.4 μs | 207.23 μs | 103.76 μs | 1,268.3 μs |   969.4 μs | 1,689.7 μs |   789.0 |  11.84 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      | 1,273.6 μs | 183.75 μs |  93.09 μs | 1,264.2 μs |   986.2 μs | 1,754.2 μs |   785.2 |  11.84 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite | 1,278.1 μs | 181.07 μs |  89.64 μs | 1,285.6 μs |   930.1 μs | 1,735.4 μs |   782.4 |   8.77 KB |
| Single                            | InsightBenchmark      | 1,284.1 μs | 253.50 μs | 125.49 μs | 1,268.0 μs |   878.0 μs | 1,805.5 μs |   778.7 |  10.32 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 1,308.5 μs | 159.57 μs |  81.82 μs | 1,298.5 μs |   868.5 μs | 1,688.2 μs |   764.2 |  26.14 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      | 1,342.2 μs | 222.10 μs | 109.95 μs | 1,373.4 μs |   929.7 μs | 1,763.5 μs |   745.0 |  11.58 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 1,344.8 μs | 160.01 μs |  79.21 μs | 1,338.4 μs | 1,068.1 μs | 1,868.5 μs |   743.6 |  26.14 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,797.5 μs | 197.99 μs | 102.77 μs | 1,792.0 μs | 1,474.8 μs | 2,285.0 μs |   556.3 |   27.8 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,827.9 μs | 231.39 μs | 115.86 μs | 1,796.3 μs | 1,457.9 μs | 2,392.8 μs |   547.1 |   27.8 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,550.1 μs | 306.16 μs | 156.97 μs | 2,578.3 μs | 1,840.7 μs | 3,248.2 μs |   392.1 |   3.67 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,583.4 μs | 470.84 μs | 235.76 μs | 2,682.9 μs | 1,811.9 μs | 3,492.6 μs |   387.1 |   11.2 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,690.3 μs | 244.96 μs | 122.66 μs | 2,666.1 μs | 2,287.5 μs | 3,410.0 μs |   371.7 |   3.63 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,787.3 μs | 288.84 μs | 142.99 μs | 2,796.8 μs | 2,131.8 μs | 3,534.3 μs |   358.8 |   7.32 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,862.6 μs | 309.51 μs | 153.22 μs | 2,852.9 μs | 2,178.5 μs | 3,490.8 μs |   349.3 |   5.27 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,949.3 μs | 394.94 μs | 197.76 μs | 2,867.8 μs | 2,453.2 μs | 4,071.2 μs |   339.1 |  12.55 KB |
