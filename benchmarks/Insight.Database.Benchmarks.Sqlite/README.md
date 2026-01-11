# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   128.1 μs |  13.19 μs |   7.02 μs |   122.2 μs |   114.7 μs |   158.8 μs | 7,804.1 |   8.09 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   128.8 μs |  15.65 μs |   8.12 μs |   128.8 μs |   106.2 μs |   172.1 μs | 7,766.9 |   7.96 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   129.8 μs |  14.67 μs |   8.02 μs |   130.3 μs |   105.3 μs |   162.1 μs | 7,703.5 |   7.64 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   130.2 μs |  15.75 μs |   8.38 μs |   131.2 μs |   105.5 μs |   170.8 μs | 7,679.4 |   7.64 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   130.5 μs |  16.87 μs |   9.10 μs |   130.2 μs |   103.3 μs |   194.1 μs | 7,665.7 |   7.66 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   131.6 μs |  17.56 μs |   9.00 μs |   125.5 μs |   114.8 μs |   198.2 μs | 7,599.8 |   8.09 KB |
| Single                            | InsightBenchmarkWrite |   132.4 μs |  11.14 μs |   5.93 μs |   132.9 μs |   112.4 μs |   160.2 μs | 7,554.7 |   7.84 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   133.5 μs |  14.95 μs |   7.66 μs |   130.4 μs |   108.3 μs |   181.4 μs | 7,488.4 |   7.66 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   134.6 μs |  20.27 μs |  10.52 μs |   131.6 μs |   113.1 μs |   195.7 μs | 7,427.0 |   8.14 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   134.7 μs |  14.18 μs |   7.55 μs |   136.6 μs |   110.5 μs |   157.4 μs | 7,426.7 |   8.09 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   134.9 μs |  20.11 μs |  10.19 μs |   130.9 μs |   110.7 μs |   213.7 μs | 7,413.9 |   7.96 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   136.0 μs |  18.67 μs |   9.81 μs |   130.6 μs |   112.6 μs |   208.4 μs | 7,352.6 |   7.64 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   136.2 μs |  13.06 μs |   6.95 μs |   134.2 μs |   115.9 μs |   168.5 μs | 7,342.9 |   7.96 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   136.9 μs |   9.07 μs |   4.77 μs |   136.5 μs |   117.3 μs |   155.6 μs | 7,304.2 |   8.09 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   138.0 μs |  20.08 μs |  10.29 μs |   133.0 μs |   106.4 μs |   202.8 μs | 7,244.6 |   7.66 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   138.4 μs |  21.24 μs |  10.89 μs |   132.8 μs |   114.9 μs |   219.5 μs | 7,226.8 |   7.96 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   139.2 μs |  18.01 μs |   9.12 μs |   131.4 μs |   112.5 μs |   195.8 μs | 7,185.3 |   7.66 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   140.4 μs |  11.14 μs |   5.93 μs |   140.1 μs |   118.9 μs |   170.6 μs | 7,121.8 |   8.27 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   140.6 μs |  14.32 μs |   7.63 μs |   137.2 μs |   117.3 μs |   208.9 μs | 7,113.5 |   8.14 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   140.6 μs |  18.39 μs |   9.43 μs |   137.6 μs |   117.3 μs |   187.1 μs | 7,112.5 |   8.27 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   141.4 μs |  16.23 μs |   8.22 μs |   141.8 μs |   119.6 μs |   193.1 μs | 7,072.3 |   8.76 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   141.5 μs |  16.62 μs |   8.85 μs |   140.8 μs |   120.5 μs |   198.4 μs | 7,069.3 |   8.81 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   143.1 μs |  27.78 μs |  14.24 μs |   132.7 μs |   113.8 μs |   238.7 μs | 6,985.7 |   8.09 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   144.1 μs |  24.69 μs |  12.66 μs |   145.0 μs |   109.2 μs |   208.7 μs | 6,941.3 |   7.64 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   145.1 μs |  18.94 μs |   9.37 μs |   139.6 μs |   116.5 μs |   188.7 μs | 6,893.5 |   8.27 KB |
| Single                            | InsightBenchmark      |   146.1 μs |  31.36 μs |  16.92 μs |   133.9 μs |   110.5 μs |   261.2 μs | 6,843.1 |   7.84 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   146.2 μs |  16.04 μs |   8.13 μs |   146.7 μs |   118.2 μs |   185.1 μs | 6,840.2 |   8.09 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   148.0 μs |  14.56 μs |   7.65 μs |   149.8 μs |   127.2 μs |   184.4 μs | 6,757.2 |   9.26 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   149.4 μs |  23.05 μs |  11.82 μs |   144.1 μs |   119.2 μs |   238.1 μs | 6,693.9 |   8.09 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   150.0 μs |  25.90 μs |  13.28 μs |   146.9 μs |   114.7 μs |   228.3 μs | 6,668.0 |   8.09 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   150.5 μs |  24.71 μs |  12.52 μs |   142.8 μs |   111.1 μs |   217.8 μs | 6,644.1 |   8.14 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   150.8 μs |  30.76 μs |  15.77 μs |   137.5 μs |   120.8 μs |   269.7 μs | 6,629.9 |   8.14 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   154.4 μs |  20.48 μs |  10.77 μs |   151.4 μs |   124.1 μs |   209.1 μs | 6,477.6 |    9.3 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   156.4 μs |  36.04 μs |  18.71 μs |   145.9 μs |   116.7 μs |   289.7 μs | 6,393.6 |   8.76 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   156.5 μs |  39.05 μs |  20.02 μs |   141.3 μs |   108.5 μs |   279.4 μs | 6,390.6 |   7.82 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   156.5 μs |  25.91 μs |  13.45 μs |   149.3 μs |   127.5 μs |   266.5 μs | 6,390.0 |    9.3 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   157.3 μs |  14.70 μs |   7.54 μs |   157.3 μs |   127.0 μs |   187.3 μs | 6,356.0 |   9.26 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   166.7 μs |  30.72 μs |  16.14 μs |   164.2 μs |   114.7 μs |   235.8 μs | 6,000.2 |   8.27 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   167.6 μs |  27.72 μs |  14.57 μs |   162.6 μs |   134.2 μs |   238.1 μs | 5,967.5 |   8.81 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   168.8 μs |  84.95 μs |  44.09 μs |   136.1 μs |   110.9 μs |   473.7 μs | 5,925.4 |   7.82 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 2,984.1 μs | 148.68 μs |  80.22 μs | 2,962.2 μs | 2,749.3 μs | 3,545.0 μs |   335.1 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 3,047.3 μs | 245.11 μs | 127.22 μs | 2,978.6 μs | 2,735.1 μs | 3,709.5 μs |   328.2 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,314.3 μs | 168.31 μs |  90.80 μs | 3,308.5 μs | 3,027.2 μs | 3,884.2 μs |   301.7 |  22.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,439.9 μs | 313.13 μs | 162.53 μs | 3,370.2 μs | 3,032.8 μs | 4,496.3 μs |   290.7 |  22.95 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,266.1 μs | 189.79 μs |  95.03 μs | 4,276.5 μs | 3,888.0 μs | 4,824.1 μs |   234.4 |   6.69 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,341.1 μs | 183.13 μs |  92.78 μs | 4,301.7 μs | 4,054.5 μs | 4,773.5 μs |   230.4 |   6.11 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,378.8 μs | 246.79 μs | 125.03 μs | 4,358.6 μs | 3,893.9 μs | 5,320.1 μs |   228.4 |   6.37 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,395.0 μs | 205.97 μs | 103.13 μs | 4,377.8 μs | 3,993.9 μs | 4,849.8 μs |   227.5 |   6.92 KB |
