# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.3915/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   127.3 μs |  11.84 μs |   6.22 μs |   124.3 μs |   111.4 μs |   163.3 μs | 7,854.2 |   8.66 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   131.5 μs |  17.76 μs |   9.22 μs |   128.2 μs |   109.1 μs |   184.8 μs | 7,606.2 |   8.68 KB |
| Single                            | InsightBenchmark      |   132.2 μs |  21.11 μs |  11.24 μs |   123.5 μs |   112.3 μs |   190.8 μs | 7,564.7 |   8.86 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   133.8 μs |  10.77 μs |   5.66 μs |   133.2 μs |   111.6 μs |   159.2 μs | 7,472.7 |   8.68 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   134.8 μs |  15.53 μs |   8.16 μs |   133.3 μs |   109.4 μs |   176.2 μs | 7,417.7 |   8.68 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   134.8 μs |  10.98 μs |   5.70 μs |   132.2 μs |   120.3 μs |   166.3 μs | 7,416.5 |   9.11 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   135.2 μs |  11.00 μs |   5.93 μs |   132.4 μs |   120.7 μs |   158.1 μs | 7,397.0 |   9.11 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   135.3 μs |  15.74 μs |   8.17 μs |   129.7 μs |   114.7 μs |   186.8 μs | 7,393.0 |   9.31 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   135.5 μs |  11.94 μs |   6.35 μs |   138.3 μs |   112.3 μs |   166.8 μs | 7,379.1 |   9.31 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   137.8 μs |  13.04 μs |   6.77 μs |   136.7 μs |   118.5 μs |   172.2 μs | 7,256.0 |   9.11 KB |
| Single                            | InsightBenchmarkWrite |   138.0 μs |  11.97 μs |   6.14 μs |   136.9 μs |   118.1 μs |   172.3 μs | 7,244.0 |   8.86 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   139.7 μs |  18.42 μs |   9.56 μs |   135.7 μs |   113.7 μs |   213.4 μs | 7,159.5 |   8.68 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   139.7 μs |  10.41 μs |   5.47 μs |   138.9 μs |   118.2 μs |   173.5 μs | 7,159.1 |   9.31 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   140.4 μs |  12.36 μs |   6.42 μs |   139.6 μs |   114.7 μs |   166.0 μs | 7,123.8 |   8.84 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   140.5 μs |  15.53 μs |   8.06 μs |   137.3 μs |   117.0 μs |   186.5 μs | 7,119.9 |   9.31 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   141.5 μs |  16.28 μs |   8.45 μs |   140.9 μs |   117.6 μs |   187.6 μs | 7,068.2 |   9.11 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   142.0 μs |  18.54 μs |   9.28 μs |   138.9 μs |   113.4 μs |   193.7 μs | 7,040.5 |   8.66 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   142.1 μs |  15.97 μs |   8.29 μs |   140.9 μs |   113.5 μs |   177.0 μs | 7,036.0 |   8.66 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   142.5 μs |  15.29 μs |   7.94 μs |   141.3 μs |   120.5 μs |   174.0 μs | 7,019.7 |   9.29 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   142.8 μs |  15.66 μs |   8.23 μs |   140.3 μs |   120.1 μs |   182.1 μs | 7,005.2 |   9.77 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   142.9 μs |  15.35 μs |   8.07 μs |   139.0 μs |   120.3 μs |   194.4 μs | 6,996.8 |   9.49 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   144.3 μs |  24.49 μs |  13.04 μs |   134.6 μs |   120.3 μs |   231.4 μs | 6,930.9 |   8.66 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   144.4 μs |  24.93 μs |  12.63 μs |   138.9 μs |   116.7 μs |   243.3 μs | 6,924.3 |   9.49 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   144.5 μs |  13.17 μs |   6.84 μs |   145.7 μs |   123.1 μs |   182.1 μs | 6,921.8 |   9.83 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   144.8 μs |  16.02 μs |   8.22 μs |   142.5 μs |   119.8 μs |   187.7 μs | 6,907.7 |   9.11 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   145.4 μs |  10.79 μs |   5.74 μs |   144.9 μs |   121.1 μs |   171.3 μs | 6,878.5 |   9.11 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   147.0 μs |  24.00 μs |  12.78 μs |   142.1 μs |   118.6 μs |   263.1 μs | 6,801.7 |   9.49 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   147.7 μs |  11.97 μs |   6.46 μs |   146.4 μs |   125.0 μs |   184.9 μs | 6,769.4 |   9.29 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   148.7 μs |  12.75 μs |   6.79 μs |   144.8 μs |   130.4 μs |   182.1 μs | 6,724.2 |   9.11 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   148.9 μs |  30.19 μs |  14.95 μs |   139.8 μs |   119.4 μs |   259.8 μs | 6,714.9 |   9.11 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   149.9 μs |  17.21 μs |   8.93 μs |   144.9 μs |   120.9 μs |   202.6 μs | 6,671.4 |   9.49 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   150.8 μs |  12.02 μs |   6.24 μs |   147.5 μs |   136.8 μs |   191.5 μs | 6,632.2 |   9.29 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   150.9 μs |  15.38 μs |   7.98 μs |   149.1 μs |   125.0 μs |   193.9 μs | 6,627.0 |   9.29 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   152.8 μs |   5.72 μs |   3.00 μs |   152.1 μs |   134.7 μs |   167.7 μs | 6,544.5 |   9.83 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   155.8 μs |  10.90 μs |   5.80 μs |   155.1 μs |   137.1 μs |   187.6 μs | 6,417.3 |  10.32 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   157.3 μs |  12.98 μs |   6.82 μs |   156.4 μs |   135.4 μs |   185.1 μs | 6,359.3 |  10.27 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   159.8 μs |  28.34 μs |  14.90 μs |   155.9 μs |   129.6 μs |   264.4 μs | 6,256.3 |  10.32 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   162.4 μs |  31.58 μs |  16.39 μs |   161.3 μs |   116.3 μs |   261.3 μs | 6,156.2 |   8.84 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   162.5 μs |  18.11 μs |   9.18 μs |   159.3 μs |   131.5 μs |   210.5 μs | 6,153.0 |  10.27 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   177.0 μs |  25.44 μs |  13.37 μs |   172.2 μs |   140.5 μs |   264.1 μs | 5,648.9 |   9.77 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 3,057.3 μs | 160.85 μs |  84.54 μs | 3,026.8 μs | 2,822.6 μs | 3,484.2 μs |   327.1 |  22.99 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 3,130.7 μs | 195.21 μs |  97.75 μs | 3,078.0 μs | 2,789.3 μs | 3,674.4 μs |   319.4 |  22.99 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,339.3 μs | 218.59 μs | 113.46 μs | 3,272.8 μs | 3,067.5 μs | 4,028.1 μs |   299.5 |  23.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,351.6 μs | 165.89 μs |  86.10 μs | 3,333.1 μs | 3,058.2 μs | 3,764.4 μs |   298.4 |  23.95 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,221.6 μs | 170.37 μs |  88.43 μs | 4,228.2 μs | 3,888.2 μs | 4,645.7 μs |   236.9 |   7.15 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,249.2 μs | 181.16 μs |  90.71 μs | 4,276.0 μs | 3,889.8 μs | 4,610.2 μs |   235.3 |   7.73 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,314.8 μs | 158.16 μs |  80.13 μs | 4,310.8 μs | 3,990.2 μs | 4,628.8 μs |   231.8 |   7.41 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,344.5 μs | 152.40 μs |  77.21 μs | 4,328.7 μs | 4,047.2 μs | 4,667.3 μs |   230.2 |   7.96 KB |
