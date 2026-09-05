# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9278/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min         | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|------------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   110.8 μs |  20.32 μs |  10.82 μs |   103.0 μs |    92.20 μs |   197.8 μs | 9,028.8 |   7.11 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   116.0 μs |  17.33 μs |   9.23 μs |   108.2 μs |    96.70 μs |   161.2 μs | 8,622.3 |   7.11 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   118.0 μs |  21.12 μs |  10.96 μs |   111.5 μs |    92.40 μs |   171.1 μs | 8,478.2 |   7.13 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   118.3 μs |  21.39 μs |  11.10 μs |   111.3 μs |    96.95 μs |   181.3 μs | 8,453.2 |   7.63 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   118.8 μs |  14.93 μs |   7.85 μs |   114.2 μs |   101.20 μs |   166.4 μs | 8,420.7 |   7.63 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   119.5 μs |  18.11 μs |   9.64 μs |   113.8 μs |   104.60 μs |   199.3 μs | 8,365.8 |   7.66 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   119.6 μs |  21.59 μs |  10.81 μs |   110.8 μs |    91.20 μs |   176.8 μs | 8,359.6 |   7.13 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   120.0 μs |  19.31 μs |  10.15 μs |   110.1 μs |    95.40 μs |   166.5 μs | 8,335.8 |   7.63 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   120.8 μs |  19.51 μs |  10.39 μs |   115.2 μs |    96.90 μs |   175.2 μs | 8,279.7 |   7.63 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   121.4 μs |  20.42 μs |  10.60 μs |   120.9 μs |    97.10 μs |   178.2 μs | 8,240.0 |   7.11 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   121.5 μs |  32.45 μs |  17.51 μs |   111.9 μs |    95.50 μs |   259.7 μs | 8,228.6 |   7.43 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   122.2 μs |  24.74 μs |  13.01 μs |   117.3 μs |    93.60 μs |   205.4 μs | 8,180.9 |   7.13 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   122.6 μs |  21.74 μs |  11.42 μs |   114.1 μs |   104.40 μs |   188.8 μs | 8,158.8 |   7.34 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   123.3 μs |  30.44 μs |  15.80 μs |   111.6 μs |    99.00 μs |   257.9 μs | 8,107.9 |   7.43 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   124.5 μs |  22.30 μs |  11.43 μs |   122.5 μs |    93.30 μs |   192.0 μs | 8,035.4 |   7.11 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   125.0 μs |  31.44 μs |  16.32 μs |   110.9 μs |   100.50 μs |   206.6 μs | 8,003.2 |   7.63 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   127.3 μs |  18.49 μs |   9.72 μs |   124.2 μs |   104.40 μs |   176.6 μs | 7,856.1 |   7.66 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   127.4 μs |  25.80 μs |  13.56 μs |   114.7 μs |   105.55 μs |   206.2 μs | 7,846.3 |   7.86 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   127.8 μs |  32.43 μs |  17.05 μs |   118.5 μs |    95.50 μs |   237.4 μs | 7,826.2 |   7.43 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   128.2 μs |  26.08 μs |  13.54 μs |   121.1 μs |    97.60 μs |   212.1 μs | 7,802.7 |   7.43 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   129.2 μs |  22.49 μs |  11.26 μs |   125.6 μs |   104.20 μs |   198.0 μs | 7,740.4 |   7.66 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   130.5 μs |  30.33 μs |  15.74 μs |   119.6 μs |   103.30 μs |   221.3 μs | 7,665.6 |   7.63 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   130.9 μs |  26.35 μs |  13.68 μs |   119.3 μs |   102.45 μs |   193.0 μs | 7,640.7 |   7.63 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   131.0 μs |  25.27 μs |  12.65 μs |   120.3 μs |   101.60 μs |   197.7 μs | 7,634.9 |   7.63 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   131.5 μs |  29.19 μs |  15.15 μs |   121.9 μs |   108.55 μs |   253.2 μs | 7,605.8 |   7.86 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   132.1 μs |  33.07 μs |  17.16 μs |   120.0 μs |   104.05 μs |   247.3 μs | 7,570.7 |   7.66 KB |
| Single                            | InsightBenchmarkWrite |   132.8 μs |  36.76 μs |  18.85 μs |   115.5 μs |    99.40 μs |   247.7 μs | 7,527.3 |   7.36 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   133.8 μs |  32.17 μs |  16.50 μs |   125.5 μs |    96.70 μs |   242.2 μs | 7,475.5 |   7.13 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   135.0 μs |  22.28 μs |  11.71 μs |   125.2 μs |   109.55 μs |   209.3 μs | 7,405.5 |   8.41 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   136.8 μs |  29.81 μs |  15.28 μs |   125.5 μs |   110.10 μs |   243.0 μs | 7,312.4 |   8.41 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   137.6 μs |  29.11 μs |  14.75 μs |   125.0 μs |   103.90 μs |   203.0 μs | 7,265.1 |   7.86 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   139.3 μs |  38.32 μs |  20.40 μs |   127.2 μs |   101.35 μs |   252.0 μs | 7,179.9 |   7.34 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   139.9 μs |  20.18 μs |  10.60 μs |   131.6 μs |   118.90 μs |   199.9 μs | 7,150.4 |   8.98 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   140.9 μs |  25.94 μs |  13.47 μs |   131.6 μs |   110.70 μs |   212.6 μs | 7,098.1 |   8.36 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   141.9 μs |  21.83 μs |  11.19 μs |   135.7 μs |   119.20 μs |   207.6 μs | 7,045.6 |   8.93 KB |
| Single                            | InsightBenchmark      |   146.0 μs |  33.85 μs |  18.26 μs |   136.5 μs |   102.85 μs |   260.7 μs | 6,850.0 |   7.36 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   147.6 μs |  25.88 μs |  13.60 μs |   144.7 μs |   111.00 μs |   213.7 μs | 6,776.1 |   8.36 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   149.1 μs |  27.29 μs |  14.17 μs |   139.7 μs |   123.90 μs |   239.4 μs | 6,704.7 |   8.98 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   152.8 μs |  43.78 μs |  21.92 μs |   140.0 μs |   106.60 μs |   268.1 μs | 6,544.5 |   7.86 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   189.5 μs |  51.01 μs |  27.16 μs |   179.8 μs |   121.75 μs |   315.2 μs | 5,278.2 |   8.93 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 2,852.4 μs | 240.68 μs | 124.92 μs | 2,805.0 μs | 2,575.25 μs | 3,572.9 μs |   350.6 |  21.23 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 2,905.6 μs | 231.05 μs | 121.44 μs | 2,840.3 μs | 2,649.60 μs | 3,456.7 μs |   344.2 |  21.23 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,184.9 μs | 184.44 μs |  95.73 μs | 3,159.7 μs | 2,873.50 μs | 3,658.4 μs |   314.0 |  21.96 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,304.6 μs | 244.21 μs | 131.75 μs | 3,261.7 μs | 2,932.60 μs | 3,723.4 μs |   302.6 |  21.96 KB |
|                                   |                       |            |           |           |            |             |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,277.2 μs | 247.59 μs | 123.98 μs | 4,247.2 μs | 3,951.50 μs | 4,938.3 μs |   233.8 |   6.61 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,397.8 μs | 279.95 μs | 145.30 μs | 4,319.6 μs | 3,965.20 μs | 5,091.7 μs |   227.4 |   7.24 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,583.7 μs | 334.80 μs | 169.61 μs | 4,598.5 μs | 3,911.10 μs | 5,406.9 μs |   218.2 |   7.21 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,835.8 μs | 512.94 μs | 259.86 μs | 4,699.2 μs | 4,030.70 μs | 5,928.3 μs |   206.8 |   7.84 KB |
