# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8117/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| Query&lt;T&gt;                          | InsightBenchmark      |   156.9 μs |  27.27 μs |  14.33 μs |   147.7 μs |   122.5 μs |   235.7 μs | 6,375.2 |   7.82 KB |
| Single                            | InsightBenchmarkWrite |   160.9 μs |  32.96 μs |  16.90 μs |   159.6 μs |   114.6 μs |   262.0 μs | 6,213.4 |   7.84 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   161.1 μs |  35.86 μs |  18.39 μs |   153.1 μs |   114.5 μs |   262.7 μs | 6,205.5 |   7.64 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   163.9 μs |  30.14 μs |  16.05 μs |   154.5 μs |   126.5 μs |   267.4 μs | 6,101.6 |   8.27 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   165.6 μs |  31.24 μs |  16.21 μs |   156.1 μs |   126.8 μs |   263.6 μs | 6,037.9 |   8.09 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   165.8 μs |  24.90 μs |  12.92 μs |   163.7 μs |   123.2 μs |   225.1 μs | 6,031.3 |   7.66 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   166.6 μs |  31.74 μs |  16.68 μs |   163.0 μs |   118.2 μs |   263.0 μs | 6,000.9 |   8.14 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   166.9 μs |  27.29 μs |  14.16 μs |   163.9 μs |   124.1 μs |   233.3 μs | 5,991.8 |   7.82 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   169.0 μs |  31.58 μs |  15.63 μs |   159.8 μs |   129.0 μs |   254.0 μs | 5,916.2 |   7.64 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   169.9 μs |  22.49 μs |  11.67 μs |   169.3 μs |   128.7 μs |   229.9 μs | 5,886.5 |   8.09 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   170.1 μs |  41.45 μs |  21.79 μs |   156.6 μs |   125.2 μs |   304.7 μs | 5,878.1 |   8.27 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   171.9 μs |  37.70 μs |  19.57 μs |   165.6 μs |   121.5 μs |   261.9 μs | 5,816.1 |   7.64 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   172.7 μs |  39.38 μs |  20.19 μs |   162.6 μs |   113.7 μs |   263.6 μs | 5,791.9 |   7.66 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   172.9 μs |  47.62 μs |  24.71 μs |   159.0 μs |   118.4 μs |   320.5 μs | 5,782.2 |   7.66 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   174.5 μs |  27.67 μs |  14.02 μs |   169.8 μs |   134.4 μs |   251.2 μs | 5,730.8 |   8.09 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   175.1 μs |  35.79 μs |  17.92 μs |   168.9 μs |   127.0 μs |   278.4 μs | 5,711.9 |   7.64 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   176.6 μs |  34.71 μs |  18.24 μs |   173.3 μs |   128.0 μs |   269.4 μs | 5,662.7 |   7.66 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   177.9 μs |  31.40 μs |  16.30 μs |   174.2 μs |   131.2 μs |   280.8 μs | 5,622.6 |   8.09 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   179.6 μs |  40.85 μs |  20.70 μs |   173.4 μs |   121.8 μs |   275.1 μs | 5,566.6 |   7.96 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   179.7 μs |  29.09 μs |  15.69 μs |   177.4 μs |   138.2 μs |   290.9 μs | 5,565.7 |   8.76 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   181.9 μs |  38.23 μs |  19.84 μs |   172.9 μs |   134.7 μs |   349.2 μs | 5,497.4 |   8.09 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   182.0 μs |  46.83 μs |  24.31 μs |   178.3 μs |   119.5 μs |   339.7 μs | 5,495.3 |   8.81 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   182.3 μs |  45.16 μs |  22.61 μs |   168.1 μs |   121.0 μs |   331.6 μs | 5,485.6 |   8.09 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   182.4 μs |  30.44 μs |  15.80 μs |   173.8 μs |   142.2 μs |   257.2 μs | 5,483.4 |   8.09 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   183.6 μs |  39.29 μs |  19.91 μs |   177.3 μs |   118.9 μs |   289.8 μs | 5,447.4 |   8.09 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   184.3 μs |  35.45 μs |  18.18 μs |   184.6 μs |   118.9 μs |   306.3 μs | 5,426.4 |   8.14 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   192.5 μs |  48.02 μs |  24.62 μs |   176.7 μs |   129.1 μs |   352.9 μs | 5,194.8 |   7.96 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   194.1 μs |  41.13 μs |  21.35 μs |   190.8 μs |   133.2 μs |   336.2 μs | 5,152.4 |   8.27 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   194.2 μs |  47.97 μs |  24.59 μs |   185.4 μs |   127.6 μs |   308.3 μs | 5,150.5 |   7.96 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   196.6 μs |  39.42 μs |  19.74 μs |   193.3 μs |   129.8 μs |   303.2 μs | 5,085.7 |   8.14 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   198.0 μs |  52.30 μs |  26.19 μs |   191.1 μs |   130.7 μs |   410.2 μs | 5,051.5 |   8.14 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   198.5 μs |  42.15 μs |  21.61 μs |   191.9 μs |   126.3 μs |   303.7 μs | 5,038.0 |   8.81 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   199.1 μs |  36.43 μs |  19.15 μs |   192.8 μs |   144.6 μs |   277.4 μs | 5,021.5 |    9.3 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   200.6 μs |  44.27 μs |  22.70 μs |   185.6 μs |   133.6 μs |   314.9 μs | 4,984.9 |   8.76 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   201.9 μs |  43.18 μs |  21.87 μs |   189.6 μs |   142.2 μs |   330.5 μs | 4,951.7 |    9.3 KB |
| Single                            | InsightBenchmark      |   206.0 μs |  60.10 μs |  31.19 μs |   201.5 μs |   126.9 μs |   342.2 μs | 4,854.6 |   7.84 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   207.3 μs |  66.34 μs |  34.02 μs |   196.8 μs |   131.1 μs |   434.8 μs | 4,822.8 |   7.96 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   208.1 μs |  46.53 μs |  23.85 μs |   189.0 μs |   158.7 μs |   330.3 μs | 4,806.5 |   9.26 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   216.0 μs |  61.51 μs |  31.54 μs |   204.8 μs |   135.3 μs |   384.6 μs | 4,630.4 |   8.27 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   220.0 μs |  52.05 μs |  27.36 μs |   204.2 μs |   148.1 μs |   370.4 μs | 4,546.3 |   9.26 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 3,391.4 μs | 170.68 μs |  87.51 μs | 3,403.8 μs | 3,000.6 μs | 3,758.4 μs |   294.9 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 3,444.9 μs | 226.64 μs | 116.20 μs | 3,400.8 μs | 3,118.1 μs | 4,098.8 μs |   290.3 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,818.4 μs | 210.33 μs | 107.84 μs | 3,826.8 μs | 3,472.1 μs | 4,352.9 μs |   261.9 |  22.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,830.4 μs | 225.10 μs | 115.41 μs | 3,770.8 μs | 3,533.0 μs | 4,426.8 μs |   261.1 |  22.95 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 5,450.9 μs | 357.81 μs | 183.45 μs | 5,463.1 μs | 4,801.0 μs | 6,250.1 μs |   183.5 |   6.92 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 5,564.5 μs | 443.01 μs | 219.31 μs | 5,564.9 μs | 4,687.9 μs | 6,551.9 μs |   179.7 |   6.37 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 5,830.9 μs | 565.06 μs | 282.94 μs | 5,917.3 μs | 4,924.4 μs | 7,214.6 μs |   171.5 |   6.11 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 5,927.7 μs | 651.37 μs | 329.99 μs | 6,028.4 μs | 4,443.6 μs | 7,295.9 μs |   168.7 |   6.69 KB |
