# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3235/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min         | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|------------:|-----------:|--------:|----------:|
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   110.4 μs |  11.37 μs |   5.98 μs |   105.5 μs |    99.70 μs |   145.0 μs | 9,057.4 |   9.53 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   111.6 μs |   9.31 μs |   4.96 μs |   108.0 μs |   101.40 μs |   144.6 μs | 8,963.3 |  10.16 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   114.9 μs |  12.33 μs |   6.48 μs |   110.1 μs |   101.70 μs |   155.2 μs | 8,705.4 |   9.88 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   115.3 μs |  14.25 μs |   7.59 μs |   109.0 μs |   100.30 μs |   149.9 μs | 8,669.6 |   9.53 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   117.2 μs |  10.03 μs |   5.34 μs |   114.1 μs |   104.40 μs |   148.2 μs | 8,535.5 |    9.7 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   117.9 μs |  12.43 μs |   6.45 μs |   114.8 μs |   102.95 μs |   159.6 μs | 8,481.0 |    9.7 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   118.8 μs |  10.33 μs |   5.57 μs |   114.8 μs |   105.60 μs |   141.9 μs | 8,418.5 |   9.96 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   120.9 μs |  18.47 μs |   9.71 μs |   113.8 μs |   100.00 μs |   175.3 μs | 8,273.0 |   9.52 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   121.6 μs |  17.09 μs |   9.10 μs |   121.4 μs |    98.00 μs |   182.0 μs | 8,224.3 |  10.35 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   121.9 μs |  11.86 μs |   6.01 μs |   118.2 μs |   106.15 μs |   159.2 μs | 8,200.9 |   9.96 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   122.4 μs |   9.46 μs |   4.91 μs |   121.1 μs |   111.25 μs |   144.0 μs | 8,168.2 |  10.15 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   122.7 μs |  13.11 μs |   6.89 μs |   120.1 μs |   107.90 μs |   167.1 μs | 8,151.1 |  10.15 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   123.3 μs |  17.57 μs |   9.12 μs |   121.3 μs |   102.50 μs |   189.2 μs | 8,109.7 |  10.16 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   124.2 μs |  17.20 μs |   8.93 μs |   122.2 μs |    98.80 μs |   169.9 μs | 8,049.0 |   9.53 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   124.3 μs |  15.38 μs |   7.89 μs |   120.9 μs |   108.15 μs |   188.7 μs | 8,044.3 |   9.96 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   125.8 μs |  17.73 μs |   9.09 μs |   124.4 μs |   106.70 μs |   190.1 μs | 7,947.0 |  10.35 KB |
| Single                            | InsightBenchmarkWrite |   127.4 μs |  22.26 μs |  11.56 μs |   122.1 μs |   102.25 μs |   194.9 μs | 7,850.5 |   9.72 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   128.4 μs |  14.27 μs |   7.23 μs |   125.0 μs |   109.80 μs |   169.1 μs | 7,786.6 |  10.15 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   128.9 μs |  30.77 μs |  15.59 μs |   114.2 μs |   100.65 μs |   201.9 μs | 7,756.4 |   9.52 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   129.0 μs |  14.22 μs |   7.47 μs |   129.6 μs |   109.30 μs |   160.1 μs | 7,750.6 |   9.96 KB |
| Single                            | InsightBenchmark      |   129.9 μs |  24.53 μs |  12.73 μs |   125.1 μs |   104.30 μs |   215.7 μs | 7,700.3 |   9.72 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   130.3 μs |  24.53 μs |  12.73 μs |   126.7 μs |   108.65 μs |   223.1 μs | 7,673.8 |   9.96 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   131.9 μs |  16.82 μs |   8.62 μs |   130.8 μs |   111.50 μs |   182.4 μs | 7,580.3 |  10.72 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   132.6 μs |  30.90 μs |  15.65 μs |   123.0 μs |   102.80 μs |   263.2 μs | 7,543.8 |   9.53 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   132.9 μs |  24.82 μs |  12.73 μs |   124.6 μs |   110.90 μs |   241.2 μs | 7,522.2 |   9.96 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   134.5 μs |  16.62 μs |   8.42 μs |   134.0 μs |   110.90 μs |   174.4 μs | 7,435.1 |  10.66 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   135.7 μs |  20.10 μs |  10.31 μs |   132.8 μs |   111.65 μs |   201.8 μs | 7,367.2 |  10.66 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   135.8 μs |  23.89 μs |  12.25 μs |   132.0 μs |   105.25 μs |   219.4 μs | 7,361.8 |   9.52 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   143.0 μs |  26.07 μs |  13.53 μs |   141.8 μs |   106.90 μs |   217.4 μs | 6,993.3 |   9.52 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   143.0 μs |  18.95 μs |   9.96 μs |   140.1 μs |   119.80 μs |   183.5 μs | 6,990.9 |  11.21 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   147.9 μs |  31.29 μs |  16.24 μs |   133.8 μs |   121.50 μs |   243.7 μs | 6,762.9 |  11.21 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   149.6 μs |  33.49 μs |  17.38 μs |   137.2 μs |   114.50 μs |   238.4 μs | 6,683.8 |  10.15 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   156.6 μs |  62.76 μs |  32.18 μs |   128.7 μs |   101.10 μs |   394.5 μs | 6,384.1 |  10.16 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   161.4 μs |  36.10 μs |  19.22 μs |   147.5 μs |   123.70 μs |   279.9 μs | 6,196.6 |  11.16 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   162.4 μs |  56.85 μs |  29.88 μs |   130.8 μs |   120.00 μs |   314.6 μs | 6,158.6 |  11.16 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   164.0 μs |  31.96 μs |  16.80 μs |   153.1 μs |   121.05 μs |   244.2 μs | 6,096.7 |  10.35 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   170.9 μs |  41.97 μs |  22.06 μs |   167.3 μs |   108.70 μs |   284.0 μs | 5,851.0 |   9.96 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   176.2 μs |  38.50 μs |  19.28 μs |   176.7 μs |   121.65 μs |   269.1 μs | 5,677.0 |  10.35 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   183.5 μs |  85.30 μs |  43.22 μs |   137.4 μs |   106.65 μs |   395.4 μs | 5,450.3 |   9.96 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   188.6 μs |  46.62 μs |  23.90 μs |   173.8 μs |   136.15 μs |   315.4 μs | 5,302.1 |  10.72 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 2,733.0 μs | 237.96 μs | 128.38 μs | 2,663.3 μs | 2,448.40 μs | 3,559.2 μs |   365.9 |  23.85 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 2,822.5 μs | 218.24 μs | 113.27 μs | 2,758.4 μs | 2,526.10 μs | 3,583.9 μs |   354.3 |  23.85 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,007.2 μs | 195.84 μs | 104.27 μs | 2,942.4 μs | 2,704.20 μs | 3,568.2 μs |   332.5 |  25.05 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,042.2 μs | 244.23 μs | 122.29 μs | 2,954.3 μs | 2,686.10 μs | 3,716.6 μs |   328.7 |  25.05 KB |
|                                   |                       |            |           |           |            |             |            |         |           |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,471.1 μs | 120.09 μs |  63.94 μs | 4,475.4 μs | 4,224.30 μs | 4,714.7 μs |   223.7 |   8.43 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,670.7 μs | 409.94 μs | 205.27 μs | 4,563.1 μs | 4,220.80 μs | 6,222.6 μs |   214.1 |    9.7 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,730.9 μs | 410.86 μs | 210.65 μs | 4,719.4 μs | 4,134.70 μs | 5,648.6 μs |   211.4 |   8.17 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 5,246.5 μs | 468.35 μs | 240.13 μs | 5,214.5 μs | 4,354.00 μs | 6,246.5 μs |   190.6 |   9.47 KB |
