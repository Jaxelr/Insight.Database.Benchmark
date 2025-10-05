# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26100.6725/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev      | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   130.4 μs |    13.12 μs |   6.90 μs |   130.4 μs |   108.7 μs |   167.6 μs | 7,668.3 |   7.62 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   131.9 μs |    13.05 μs |   6.69 μs |   132.3 μs |   113.9 μs |   167.2 μs | 7,583.9 |   8.12 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   132.9 μs |    14.05 μs |   7.39 μs |   130.3 μs |   111.4 μs |   170.1 μs | 7,527.1 |   7.62 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   133.1 μs |    24.63 μs |  12.78 μs |   127.7 μs |   110.3 μs |   227.4 μs | 7,514.9 |   7.63 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   135.6 μs |    23.61 μs |  12.25 μs |   131.5 μs |   109.8 μs |   218.7 μs | 7,373.1 |   7.94 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   135.9 μs |    15.59 μs |   8.09 μs |   133.3 μs |   114.4 μs |   175.1 μs | 7,356.9 |   7.94 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   140.1 μs |    20.06 μs |  10.41 μs |   134.9 μs |   112.8 μs |   190.7 μs | 7,140.2 |   7.62 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   141.4 μs |    15.55 μs |   8.17 μs |   135.7 μs |   119.8 μs |   194.6 μs | 7,074.0 |   8.12 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   141.5 μs |    15.39 μs |   7.99 μs |   139.2 μs |   116.4 μs |   187.3 μs | 7,067.1 |   8.06 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   142.2 μs |    21.57 μs |  11.20 μs |   137.1 μs |   114.6 μs |   206.9 μs | 7,034.6 |   8.06 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   144.7 μs |    14.95 μs |   7.66 μs |   142.4 μs |   119.5 μs |   180.3 μs | 6,913.0 |   8.06 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   144.8 μs |    26.61 μs |  14.55 μs |   137.1 μs |   119.8 μs |   226.6 μs | 6,907.4 |   8.24 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   145.0 μs |    20.06 μs |  10.82 μs |   140.7 μs |   120.6 μs |   216.2 μs | 6,897.7 |   8.24 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   145.3 μs |    28.24 μs |  14.48 μs |   137.5 μs |   116.4 μs |   240.2 μs | 6,883.8 |   8.06 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   146.0 μs |    20.16 μs |  10.47 μs |   139.1 μs |   126.0 μs |   207.7 μs | 6,849.2 |   9.23 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   148.3 μs |    32.00 μs |  17.04 μs |   136.2 μs |   109.2 μs |   276.3 μs | 6,743.7 |   7.62 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   149.3 μs |    25.78 μs |  13.38 μs |   142.4 μs |   118.0 μs |   243.6 μs | 6,698.5 |   8.24 KB |
| Single                            | InsightBenchmark      |   150.1 μs |    35.68 μs |  18.75 μs |   141.9 μs |   109.5 μs |   283.6 μs | 6,663.7 |   7.81 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   150.4 μs |    39.10 μs |  20.05 μs |   138.3 μs |   111.2 μs |   266.9 μs | 6,650.0 |    7.8 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   156.6 μs |    18.56 μs |   9.52 μs |   152.1 μs |   129.8 μs |   206.5 μs | 6,384.6 |   9.27 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   159.4 μs |    55.07 μs |  28.95 μs |   134.6 μs |   111.4 μs |   340.9 μs | 6,275.1 |   7.63 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   159.6 μs |    50.87 μs |  26.40 μs |   141.9 μs |   117.1 μs |   366.9 μs | 6,266.9 |   8.06 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   160.4 μs |    32.01 μs |  16.83 μs |   154.4 μs |   120.1 μs |   279.4 μs | 6,234.3 |   8.06 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   160.9 μs |    28.24 μs |  15.03 μs |   154.3 μs |   114.8 μs |   240.7 μs | 6,216.2 |   7.94 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   169.2 μs |    31.00 μs |  16.29 μs |   165.0 μs |   121.5 μs |   271.2 μs | 5,910.3 |   8.12 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   169.3 μs |    34.43 μs |  18.10 μs |   161.7 μs |   127.9 μs |   286.4 μs | 5,905.4 |   9.23 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   173.2 μs |    29.61 μs |  15.56 μs |   163.7 μs |   137.2 μs |   262.1 μs | 5,773.7 |   8.78 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   174.9 μs |    70.66 μs |  36.67 μs |   141.5 μs |   109.5 μs |   346.6 μs | 5,716.0 |   7.63 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   175.7 μs |   102.15 μs |  54.39 μs |   128.8 μs |   110.0 μs |   434.1 μs | 5,692.3 |   7.63 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   176.9 μs |    42.58 μs |  21.83 μs |   169.8 μs |   116.3 μs |   326.6 μs | 5,653.0 |   8.06 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   178.4 μs |    44.17 μs |  23.51 μs |   162.0 μs |   122.7 μs |   291.1 μs | 5,605.3 |   8.73 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   184.4 μs |    34.82 μs |  18.54 μs |   178.8 μs |   129.6 μs |   305.7 μs | 5,424.3 |   8.24 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   184.9 μs |    53.09 μs |  27.55 μs |   169.7 μs |   121.1 μs |   320.8 μs | 5,409.8 |   8.12 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   190.7 μs |    60.75 μs |  32.77 μs |   179.6 μs |   113.2 μs |   325.0 μs | 5,244.0 |    7.8 KB |
| Single                            | InsightBenchmarkWrite |   193.4 μs |    81.46 μs |  42.28 μs |   164.8 μs |   114.0 μs |   445.1 μs | 5,170.1 |   7.81 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   202.5 μs |    81.41 μs |  41.74 μs |   176.2 μs |   117.7 μs |   406.7 μs | 4,937.8 |   7.94 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   214.9 μs |    88.06 μs |  46.28 μs |   177.5 μs |   129.2 μs |   443.2 μs | 4,653.5 |   8.06 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   245.6 μs |    98.50 μs |  50.50 μs |   212.7 μs |   137.5 μs |   500.3 μs | 4,071.6 |   8.73 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   248.0 μs |    59.81 μs |  31.85 μs |   250.2 μs |   133.1 μs |   357.9 μs | 4,031.8 |   9.27 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   263.0 μs |   108.68 μs |  55.72 μs |   229.0 μs |   128.0 μs |   520.0 μs | 3,802.1 |   8.78 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 3,258.0 μs |   197.67 μs | 103.89 μs | 3,258.3 μs | 2,842.9 μs | 3,606.6 μs |   306.9 |  21.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,620.5 μs |   207.29 μs | 106.28 μs | 3,571.1 μs | 3,239.0 μs | 4,084.1 μs |   276.2 |   22.9 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 3,660.4 μs |   520.70 μs | 270.26 μs | 3,491.4 μs | 2,912.2 μs | 4,892.5 μs |   273.2 |  21.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 4,067.6 μs | 1,071.87 μs | 536.71 μs | 3,765.8 μs | 3,121.8 μs | 7,508.8 μs |   245.8 |   22.9 KB |
|                                   |                       |            |             |           |            |            |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,440.1 μs |   235.35 μs | 117.85 μs | 4,356.7 μs | 4,001.6 μs | 4,941.9 μs |   225.2 |    6.1 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,495.1 μs |   224.68 μs | 112.50 μs | 4,477.1 μs | 4,060.6 μs | 5,141.8 μs |   222.5 |   6.91 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,562.6 μs |   383.49 μs | 194.28 μs | 4,516.6 μs | 3,923.7 μs | 5,604.0 μs |   219.2 |   6.67 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,636.4 μs |   540.94 μs | 277.34 μs | 4,453.6 μs | 4,049.9 μs | 5,911.2 μs |   215.7 |   6.36 KB |
