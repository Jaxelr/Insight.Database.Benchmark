# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.104
  [Host]   : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   115.4 μs |   9.14 μs |   4.74 μs |   112.1 μs |   105.5 μs |   139.1 μs | 8,663.6 |   7.66 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   120.0 μs |  10.71 μs |   5.86 μs |   115.3 μs |   108.4 μs |   148.2 μs | 8,329.9 |   7.66 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   123.7 μs |  16.11 μs |   8.26 μs |   118.4 μs |   107.2 μs |   179.0 μs | 8,085.7 |   7.64 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   124.1 μs |  14.36 μs |   7.45 μs |   118.7 μs |   111.0 μs |   189.8 μs | 8,061.1 |   7.96 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   124.2 μs |  13.62 μs |   6.98 μs |   118.8 μs |   110.2 μs |   168.7 μs | 8,052.1 |   7.96 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   124.3 μs |  11.06 μs |   5.89 μs |   120.5 μs |   112.0 μs |   156.9 μs | 8,046.8 |   8.09 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   125.1 μs |  11.48 μs |   6.03 μs |   123.2 μs |   108.6 μs |   156.5 μs | 7,996.7 |   7.64 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   125.2 μs |  13.14 μs |   6.73 μs |   120.2 μs |   112.8 μs |   170.6 μs | 7,986.1 |   8.14 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   126.8 μs |  17.93 μs |   9.42 μs |   118.7 μs |   107.0 μs |   180.7 μs | 7,886.8 |   7.64 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   130.6 μs |  11.00 μs |   5.78 μs |   127.3 μs |   118.0 μs |   165.6 μs | 7,654.8 |   8.27 KB |
| Single                            | InsightBenchmarkWrite |   130.8 μs |  14.69 μs |   7.63 μs |   129.7 μs |   110.4 μs |   166.7 μs | 7,645.0 |   7.84 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   131.2 μs |  13.54 μs |   6.70 μs |   127.3 μs |   113.3 μs |   169.8 μs | 7,619.3 |   8.09 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   131.8 μs |  18.43 μs |   9.57 μs |   126.7 μs |   112.5 μs |   191.1 μs | 7,590.1 |   7.96 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   132.5 μs |  13.23 μs |   7.14 μs |   130.1 μs |   115.6 μs |   164.2 μs | 7,549.5 |   8.09 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   132.6 μs |  14.74 μs |   7.74 μs |   127.6 μs |   115.6 μs |   180.4 μs | 7,539.3 |   8.14 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   133.8 μs |  16.81 μs |   8.72 μs |   127.2 μs |   112.2 μs |   177.1 μs | 7,476.4 |   8.09 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   134.1 μs |  15.50 μs |   8.04 μs |   127.5 μs |   119.4 μs |   193.3 μs | 7,455.6 |   8.27 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   134.2 μs |  19.27 μs |   9.88 μs |   129.4 μs |   113.4 μs |   202.7 μs | 7,450.3 |   8.09 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   134.4 μs |  15.39 μs |   7.99 μs |   128.0 μs |   117.4 μs |   184.8 μs | 7,441.2 |   8.27 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   135.5 μs |  15.67 μs |   7.94 μs |   135.4 μs |   114.1 μs |   177.3 μs | 7,378.4 |   8.14 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   137.3 μs |  21.41 μs |  10.60 μs |   132.3 μs |   113.3 μs |   216.8 μs | 7,284.3 |   7.82 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   138.6 μs |  19.91 μs |   9.97 μs |   135.2 μs |   108.6 μs |   192.6 μs | 7,215.8 |   7.66 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   139.3 μs |  16.37 μs |   8.29 μs |   131.7 μs |   122.1 μs |   182.4 μs | 7,177.9 |   8.81 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   140.3 μs |  15.57 μs |   8.08 μs |   134.9 μs |   121.3 μs |   183.4 μs | 7,126.0 |   8.76 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   142.4 μs |  20.43 μs |  10.47 μs |   137.9 μs |   117.3 μs |   209.3 μs | 7,024.4 |   8.27 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   143.0 μs |  18.19 μs |   9.33 μs |   142.9 μs |   120.5 μs |   198.3 μs | 6,991.4 |   8.76 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   143.9 μs |  25.96 μs |  13.31 μs |   133.8 μs |   119.1 μs |   226.9 μs | 6,947.4 |   8.09 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   144.1 μs |  16.36 μs |   8.60 μs |   138.6 μs |   126.1 μs |   195.9 μs | 6,939.4 |    9.3 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   145.6 μs |  42.66 μs |  22.14 μs |   127.6 μs |   112.3 μs |   274.9 μs | 6,869.0 |   8.09 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   146.3 μs |  43.09 μs |  22.65 μs |   132.2 μs |   108.1 μs |   303.9 μs | 6,835.4 |   7.66 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   146.5 μs |  26.40 μs |  13.53 μs |   142.4 μs |   113.8 μs |   208.2 μs | 6,824.8 |   8.09 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   148.4 μs |  22.46 μs |  11.38 μs |   146.3 μs |   115.9 μs |   191.5 μs | 6,737.5 |   8.14 KB |
| Single                            | InsightBenchmark      |   151.0 μs |  40.77 μs |  21.16 μs |   138.5 μs |   109.5 μs |   280.1 μs | 6,624.4 |   7.84 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   153.1 μs |  22.36 μs |  11.75 μs |   147.1 μs |   128.4 μs |   213.8 μs | 6,530.0 |    9.3 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   154.7 μs |  23.86 μs |  11.95 μs |   151.5 μs |   123.2 μs |   204.6 μs | 6,465.3 |   8.81 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   158.6 μs |  39.23 μs |  20.11 μs |   145.6 μs |   126.7 μs |   282.6 μs | 6,304.5 |   9.26 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   163.2 μs |  68.80 μs |  34.45 μs |   130.8 μs |   107.0 μs |   364.3 μs | 6,127.5 |   7.64 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   169.3 μs |  47.66 μs |  24.74 μs |   173.6 μs |   108.8 μs |   271.9 μs | 5,906.7 |   7.96 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   179.8 μs |  41.45 μs |  22.07 μs |   181.9 μs |   125.1 μs |   263.4 μs | 5,561.1 |   9.26 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   187.3 μs |  29.95 μs |  15.54 μs |   184.6 μs |   137.8 μs |   283.4 μs | 5,339.7 |   7.82 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 3,319.3 μs | 439.20 μs | 222.50 μs | 3,320.1 μs | 2,711.4 μs | 4,326.8 μs |   301.3 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,404.4 μs | 206.89 μs | 107.38 μs | 3,392.4 μs | 3,112.0 μs | 3,896.1 μs |   293.7 |  22.95 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 3,468.1 μs | 352.34 μs | 176.42 μs | 3,464.4 μs | 2,742.7 μs | 4,149.4 μs |   288.3 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,514.5 μs | 376.31 μs | 190.64 μs | 3,341.2 μs | 3,052.2 μs | 4,566.8 μs |   284.5 |  22.95 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,256.0 μs | 225.54 μs | 117.06 μs | 4,299.9 μs | 3,561.4 μs | 4,682.7 μs |   235.0 |   6.11 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,366.3 μs | 202.90 μs | 101.60 μs | 4,337.2 μs | 4,070.3 μs | 4,931.7 μs |   229.0 |   6.69 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,375.3 μs | 211.76 μs | 106.03 μs | 4,372.1 μs | 3,982.6 μs | 4,877.9 μs |   228.6 |   6.37 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,543.2 μs | 350.72 μs | 175.61 μs | 4,534.0 μs | 3,892.6 μs | 5,375.2 μs |   220.1 |   6.92 KB |
