# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   847.2 μs | 123.70 μs |  64.20 μs |   808.6 μs |   689.6 μs | 1,157.5 μs | 1,180.4 |   8.94 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   850.3 μs |  84.16 μs |  44.24 μs |   843.5 μs |   713.4 μs | 1,038.2 μs | 1,176.0 |   12.6 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   867.3 μs | 129.56 μs |  68.10 μs |   814.5 μs |   715.5 μs | 1,314.8 μs | 1,153.0 |   9.54 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   879.4 μs | 155.55 μs |  78.80 μs |   837.6 μs |   678.0 μs | 1,378.3 μs | 1,137.2 |   8.94 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   886.1 μs | 170.61 μs |  88.55 μs |   818.2 μs |   694.7 μs | 1,450.4 μs | 1,128.5 |   8.91 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   890.2 μs | 139.41 μs |  72.36 μs |   857.5 μs |   695.7 μs | 1,225.1 μs | 1,123.3 |   8.94 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   904.7 μs | 115.04 μs |  59.71 μs |   860.9 μs |   768.0 μs | 1,254.9 μs | 1,105.4 |   12.6 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   905.9 μs | 134.23 μs |  71.47 μs |   880.6 μs |   704.4 μs | 1,336.8 μs | 1,103.9 |   12.6 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   907.9 μs | 124.06 μs |  66.05 μs |   903.5 μs |   684.0 μs | 1,209.2 μs | 1,101.4 |   8.91 KB |
| Single                            | InsightBenchmarkWrite |   908.2 μs | 168.74 μs |  86.51 μs |   852.2 μs |   685.3 μs | 1,367.5 μs | 1,101.1 |  11.97 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   912.2 μs |  93.58 μs |  49.19 μs |   903.0 μs |   765.2 μs | 1,116.0 μs | 1,096.2 |  10.47 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   913.1 μs | 133.23 μs |  68.31 μs |   882.2 μs |   749.2 μs | 1,318.8 μs | 1,095.1 |   12.6 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  |   915.1 μs | 129.09 μs |  67.85 μs |   884.8 μs |   776.8 μs | 1,389.4 μs | 1,092.8 |  37.55 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   917.1 μs | 200.94 μs | 104.29 μs |   862.1 μs |   708.7 μs | 1,540.0 μs | 1,090.4 |     12 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   917.4 μs | 207.51 μs | 107.70 μs |   828.1 μs |   693.0 μs | 1,563.0 μs | 1,090.0 |   8.94 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   924.5 μs | 133.83 μs |  70.34 μs |   882.7 μs |   739.4 μs | 1,378.1 μs | 1,081.6 |  10.47 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   927.1 μs | 199.04 μs | 103.31 μs |   847.5 μs |   715.2 μs | 1,678.5 μs | 1,078.6 |  11.72 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   928.6 μs | 158.70 μs |  84.49 μs |   892.2 μs |   770.6 μs | 1,619.4 μs | 1,076.9 |   12.5 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   928.9 μs | 157.74 μs |  82.91 μs |   893.0 μs |   735.7 μs | 1,390.4 μs | 1,076.5 |   12.6 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   932.5 μs | 163.96 μs |  85.10 μs |   889.5 μs |   761.5 μs | 1,601.3 μs | 1,072.4 |  12.22 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   933.1 μs | 179.91 μs |  94.56 μs |   894.7 μs |   749.7 μs | 1,480.8 μs | 1,071.7 |   9.54 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   940.1 μs | 129.75 μs |  68.20 μs |   911.3 μs |   773.0 μs | 1,336.4 μs | 1,063.7 |  13.23 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   942.4 μs | 140.57 μs |  73.88 μs |   906.8 μs |   756.6 μs | 1,402.5 μs | 1,061.2 |  10.47 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   946.6 μs | 159.54 μs |  83.85 μs |   906.9 μs |   735.5 μs | 1,542.7 μs | 1,056.4 |   9.54 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   947.8 μs | 147.93 μs |  75.84 μs |   943.9 μs |   740.7 μs | 1,328.7 μs | 1,055.0 |   9.54 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   953.0 μs | 147.50 μs |  77.53 μs |   903.6 μs |   734.9 μs | 1,311.7 μs | 1,049.4 |  10.42 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   954.8 μs | 149.53 μs |  76.67 μs |   889.8 μs |   808.6 μs | 1,455.8 μs | 1,047.4 |  10.47 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   965.0 μs |  97.26 μs |  51.78 μs |   941.9 μs |   823.9 μs | 1,297.7 μs | 1,036.3 |  14.13 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   968.6 μs | 201.72 μs | 102.19 μs |   919.3 μs |   699.4 μs | 1,578.1 μs | 1,032.4 |   12.6 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   984.3 μs | 186.85 μs |  94.66 μs |   939.7 μs |   735.6 μs | 1,698.5 μs | 1,016.0 |  10.42 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  |   986.1 μs | 202.73 μs | 103.94 μs |   914.9 μs |   746.9 μs | 1,628.5 μs | 1,014.1 |  37.52 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   995.2 μs | 194.65 μs | 105.01 μs |   913.0 μs |   793.5 μs | 1,444.9 μs | 1,004.8 |  13.53 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  |   995.9 μs | 153.96 μs |  84.20 μs |   939.1 μs |   830.6 μs | 1,542.7 μs | 1,004.2 |  39.03 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   996.1 μs | 157.32 μs |  80.66 μs |   959.1 μs |   808.9 μs | 1,556.6 μs | 1,003.9 |  13.48 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      | 1,004.2 μs | 156.82 μs |  82.43 μs |   977.9 μs |   762.8 μs | 1,549.2 μs |   995.8 |  10.12 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite | 1,018.6 μs | 227.47 μs | 116.62 μs |   984.8 μs |   676.0 μs | 1,607.3 μs |   981.8 |   8.91 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  | 1,040.0 μs | 251.27 μs | 128.83 μs |   933.8 μs |   825.5 μs | 1,829.2 μs |   961.5 |  39.08 KB |
| Single                            | InsightBenchmark      | 1,046.4 μs | 210.87 μs | 108.12 μs | 1,016.1 μs |   738.9 μs | 1,724.5 μs |   955.7 |  11.97 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      | 1,060.1 μs | 201.30 μs | 101.98 μs | 1,021.9 μs |   793.7 μs | 1,698.2 μs |   943.3 |  13.55 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 1,109.9 μs | 159.58 μs |  84.96 μs | 1,075.6 μs |   942.9 μs | 1,628.4 μs |   901.0 |  27.79 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      | 1,119.4 μs | 248.86 μs | 126.07 μs | 1,078.8 μs |   789.5 μs | 1,635.6 μs |   893.3 |  13.48 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 1,148.0 μs | 176.45 μs |  88.35 μs | 1,083.0 μs |   922.0 μs | 1,586.9 μs |   871.1 |  27.79 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      | 1,178.7 μs | 268.64 μs | 136.09 μs | 1,166.2 μs |   701.3 μs | 1,894.5 μs |   848.4 |   8.63 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite | 1,186.2 μs | 335.23 μs | 167.86 μs | 1,129.6 μs |   775.2 μs | 2,289.2 μs |   843.0 |  10.42 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,577.0 μs | 253.00 μs | 131.32 μs | 1,505.7 μs | 1,269.0 μs | 2,445.1 μs |   634.1 |  29.42 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,631.6 μs | 347.61 μs | 178.22 μs | 1,486.2 μs | 1,283.2 μs | 2,542.0 μs |   612.9 |  29.14 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,335.7 μs | 173.22 μs |  89.91 μs | 2,317.6 μs | 2,004.3 μs | 2,877.2 μs |   428.1 |   6.59 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,393.1 μs | 359.67 μs | 191.49 μs | 2,267.1 μs | 1,978.5 μs | 3,292.9 μs |   417.9 |   4.66 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,427.5 μs | 223.27 μs | 114.47 μs | 2,373.2 μs | 2,003.4 μs | 2,990.1 μs |   411.9 |  12.85 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,504.1 μs | 309.44 μs | 164.75 μs | 2,459.4 μs | 2,083.2 μs | 3,469.2 μs |   399.3 |   4.99 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,504.5 μs | 204.14 μs | 104.66 μs | 2,469.4 μs | 2,231.1 μs | 3,137.3 μs |   399.3 |   14.5 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,513.7 μs | 265.17 μs | 132.78 μs | 2,450.7 μs | 2,111.1 μs | 3,212.0 μs |   397.8 |   8.97 KB |
