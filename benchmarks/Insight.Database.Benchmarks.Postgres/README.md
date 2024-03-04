# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3235/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   950.3 μs | 137.58 μs |  71.41 μs |   961.1 μs |   771.1 μs | 1,328.5 μs | 1,052.3 |    9.1 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   964.6 μs | 165.57 μs |  83.88 μs |   934.9 μs |   717.7 μs | 1,447.4 μs | 1,036.7 |   9.09 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   977.2 μs | 146.11 μs |  74.91 μs |   955.0 μs |   774.5 μs | 1,360.7 μs | 1,023.3 |   9.72 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,003.5 μs | 139.84 μs |  70.02 μs | 1,006.5 μs |   775.6 μs | 1,441.6 μs |   996.6 |   9.72 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      | 1,007.4 μs | 114.13 μs |  56.50 μs | 1,023.7 μs |   759.4 μs | 1,296.5 μs |   992.7 |    9.1 KB |
| Single                            | InsightBenchmarkWrite | 1,019.5 μs | 140.93 μs |  72.26 μs | 1,005.5 μs |   831.8 μs | 1,439.6 μs |   980.9 |  13.21 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite | 1,023.8 μs | 186.02 μs |  95.38 μs |   975.3 μs |   771.2 μs | 1,505.2 μs |   976.8 |  13.84 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite | 1,028.7 μs | 143.08 μs |  73.36 μs | 1,029.0 μs |   804.5 μs | 1,427.6 μs |   972.1 |   8.82 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite | 1,036.5 μs | 136.24 μs |  68.22 μs | 1,019.6 μs |   725.1 μs | 1,387.6 μs |   964.8 |    9.1 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite | 1,054.6 μs | 161.61 μs |  82.86 μs | 1,024.1 μs |   777.3 μs | 1,557.5 μs |   948.2 |   9.09 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      | 1,069.4 μs | 161.65 μs |  80.94 μs | 1,057.1 μs |   808.7 μs | 1,478.8 μs |   935.1 |   9.72 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite | 1,070.5 μs | 152.16 μs |  78.97 μs | 1,046.7 μs |   808.2 μs | 1,373.3 μs |   934.1 |  13.84 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      | 1,081.8 μs | 134.72 μs |  66.69 μs | 1,069.7 μs |   846.6 μs | 1,389.6 μs |   924.4 |   9.72 KB |
| Query&lt;T&gt;                          | InsightBenchmark      | 1,091.5 μs | 174.65 μs |  89.55 μs | 1,050.0 μs |   861.3 μs | 1,572.1 μs |   916.1 |  13.23 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      | 1,106.5 μs |  83.67 μs |  43.97 μs | 1,115.4 μs |   932.7 μs | 1,284.1 μs |   903.8 |  14.74 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite | 1,106.8 μs | 203.48 μs | 103.09 μs | 1,102.8 μs |   808.2 μs | 1,546.1 μs |   903.5 |  10.92 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      | 1,125.7 μs | 155.66 μs |  79.81 μs | 1,082.7 μs |   906.8 μs | 1,447.2 μs |   888.4 |  10.62 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      | 1,140.2 μs | 196.16 μs |  98.22 μs | 1,108.4 μs |   824.4 μs | 1,626.8 μs |   877.0 |  13.48 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      | 1,143.8 μs | 198.36 μs | 100.49 μs | 1,090.6 μs |   846.0 μs | 1,625.5 μs |   874.3 |  10.65 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      | 1,151.6 μs | 223.36 μs | 115.93 μs | 1,089.8 μs |   843.8 μs | 1,760.6 μs |   868.4 |  10.65 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite | 1,158.0 μs | 219.31 μs | 112.44 μs | 1,121.9 μs |   794.9 μs | 1,735.8 μs |   863.6 |  13.39 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite | 1,159.9 μs | 285.77 μs | 143.09 μs | 1,067.2 μs |   823.2 μs | 2,129.7 μs |   862.2 |  10.62 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite | 1,163.5 μs | 180.97 μs |  90.62 μs | 1,158.3 μs |   874.9 μs | 1,543.8 μs |   859.5 |  10.65 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite | 1,167.4 μs | 160.57 μs |  82.33 μs | 1,139.9 μs |   877.9 μs | 1,573.8 μs |   856.6 |  14.74 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      | 1,172.2 μs | 183.40 μs |  91.83 μs | 1,175.9 μs |   879.3 μs | 1,753.5 μs |   853.1 |  15.04 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite | 1,173.8 μs | 187.96 μs |  96.37 μs | 1,108.2 μs |   914.6 μs | 1,579.0 μs |   851.9 |  14.77 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite | 1,179.1 μs | 212.60 μs | 107.71 μs | 1,116.6 μs |   801.2 μs | 1,603.2 μs |   848.1 |  13.23 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      | 1,180.3 μs | 273.91 μs | 142.17 μs | 1,054.5 μs |   805.5 μs | 1,754.2 μs |   847.3 |   9.09 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      | 1,185.7 μs | 245.39 μs | 121.48 μs | 1,158.5 μs |   861.1 μs | 1,920.5 μs |   843.4 |    8.8 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  | 1,189.3 μs | 197.87 μs |  97.96 μs | 1,125.3 μs |   936.3 μs | 1,908.7 μs |   840.8 |  38.84 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  | 1,196.4 μs | 164.93 μs |  84.56 μs | 1,161.1 μs |   894.2 μs | 1,519.4 μs |   835.8 |  38.85 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite | 1,198.4 μs | 298.75 μs | 149.59 μs | 1,106.8 μs |   831.5 μs | 2,167.0 μs |   834.5 |  13.48 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      | 1,210.9 μs | 190.65 μs |  95.46 μs | 1,179.8 μs |   906.9 μs | 1,719.3 μs |   825.8 |  15.08 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 1,213.7 μs | 202.91 μs | 101.60 μs | 1,169.4 μs |   996.3 μs | 1,903.3 μs |   823.9 |  31.66 KB |
| Single                            | InsightBenchmark      | 1,219.7 μs | 223.59 μs | 114.64 μs | 1,151.2 μs |   913.2 μs | 1,764.5 μs |   819.9 |  13.21 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      | 1,230.9 μs | 173.68 μs |  86.97 μs | 1,220.6 μs |   821.2 μs | 1,593.5 μs |   812.4 |  13.84 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      | 1,232.3 μs | 260.45 μs | 133.54 μs | 1,164.1 μs |   880.0 μs | 1,977.7 μs |   811.5 |  13.39 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite | 1,238.9 μs | 207.86 μs | 105.30 μs | 1,203.8 μs |   905.6 μs | 1,739.1 μs |   807.1 |  15.04 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      | 1,242.4 μs | 150.19 μs |  76.09 μs | 1,245.7 μs |   902.5 μs | 1,583.0 μs |   804.9 |  13.84 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  | 1,275.5 μs | 212.91 μs | 106.61 μs | 1,225.5 μs |   954.7 μs | 1,815.2 μs |   784.0 |   40.4 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite | 1,297.7 μs | 268.75 μs | 134.57 μs | 1,228.9 μs |   915.8 μs | 1,920.7 μs |   770.6 |  10.65 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      | 1,300.9 μs | 324.94 μs | 166.60 μs | 1,192.8 μs |   896.2 μs | 2,150.6 μs |   768.7 |  10.62 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 1,346.0 μs | 262.04 μs | 129.72 μs | 1,274.5 μs |   958.1 μs | 1,840.6 μs |   743.0 |  31.66 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  | 1,381.1 μs | 240.98 μs | 120.66 μs | 1,323.3 μs |   942.5 μs | 1,911.0 μs |   724.0 |  40.67 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,684.7 μs | 217.97 μs | 107.90 μs | 1,654.7 μs | 1,327.9 μs | 2,313.4 μs |   593.6 |  33.49 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,687.6 μs | 261.73 μs | 132.59 μs | 1,649.2 μs | 1,301.5 μs | 2,273.8 μs |   592.6 |  33.49 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,530.3 μs | 202.87 μs | 105.30 μs | 2,506.4 μs | 2,232.6 μs | 3,116.3 μs |   395.2 |   6.09 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,532.0 μs | 289.36 μs | 148.36 μs | 2,462.0 μs | 2,031.9 μs | 3,260.3 μs |   394.9 |   4.43 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,546.6 μs | 348.71 μs | 178.79 μs | 2,443.4 μs | 2,081.0 μs | 3,351.2 μs |   392.7 |   4.51 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,658.5 μs | 239.65 μs | 121.41 μs | 2,622.8 μs | 2,268.8 μs | 3,412.1 μs |   376.2 |  10.65 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,866.4 μs | 309.17 μs | 158.51 μs | 2,801.9 μs | 2,339.3 μs | 3,895.6 μs |   348.9 |  16.19 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,937.7 μs | 224.81 μs | 113.89 μs | 2,912.6 μs | 2,415.9 μs | 3,631.2 μs |   340.4 |  14.52 KB |
