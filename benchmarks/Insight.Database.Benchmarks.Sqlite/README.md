# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   113.2 μs |   6.54 μs |   3.57 μs |   111.5 μs |   105.1 μs |   131.1 μs | 8,833.7 |   8.66 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   118.5 μs |  10.01 μs |   5.26 μs |   115.4 μs |   106.7 μs |   146.6 μs | 8,436.8 |   9.31 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   118.6 μs |   7.83 μs |   4.01 μs |   117.2 μs |   107.8 μs |   135.9 μs | 8,431.3 |   8.84 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   121.5 μs |  14.45 μs |   7.70 μs |   118.2 μs |   102.7 μs |   171.5 μs | 8,230.0 |   8.66 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   122.6 μs |  14.97 μs |   7.87 μs |   118.0 μs |   107.9 μs |   166.7 μs | 8,157.5 |   9.31 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   122.8 μs |  14.42 μs |   7.49 μs |   118.8 μs |   105.7 μs |   164.2 μs | 8,144.7 |   9.31 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   124.5 μs |  11.45 μs |   6.10 μs |   120.7 μs |   112.8 μs |   165.5 μs | 8,031.2 |   9.49 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   124.7 μs |  15.39 μs |   8.09 μs |   120.9 μs |   108.7 μs |   170.0 μs | 8,017.1 |   9.49 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   125.4 μs |  14.59 μs |   7.67 μs |   126.8 μs |   104.0 μs |   152.9 μs | 7,974.8 |   8.68 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   126.5 μs |  15.10 μs |   7.74 μs |   120.5 μs |   108.7 μs |   174.2 μs | 7,906.5 |   9.11 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   126.6 μs |  13.10 μs |   6.72 μs |   121.2 μs |   109.8 μs |   156.3 μs | 7,900.6 |   9.21 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   127.2 μs |  13.69 μs |   7.20 μs |   124.7 μs |   108.4 μs |   161.4 μs | 7,859.4 |   9.49 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   129.5 μs |  18.25 μs |   9.36 μs |   126.8 μs |   108.1 μs |   182.9 μs | 7,721.2 |   8.66 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   130.8 μs |  22.07 μs |  11.31 μs |   122.4 μs |   109.3 μs |   214.4 μs | 7,646.9 |   9.11 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   131.0 μs |  23.33 μs |  12.11 μs |   123.3 μs |   109.4 μs |   222.2 μs | 7,633.9 |   9.11 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   131.5 μs |  15.04 μs |   7.80 μs |   126.9 μs |   110.3 μs |   166.3 μs | 7,606.4 |   9.11 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   131.5 μs |  16.28 μs |   8.15 μs |   126.7 μs |   113.0 μs |   190.2 μs | 7,602.6 |   9.11 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   131.6 μs |  20.15 μs |  10.33 μs |   126.5 μs |   111.8 μs |   214.8 μs | 7,601.4 |   9.29 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   131.6 μs |  25.13 μs |  13.04 μs |   122.3 μs |   105.9 μs |   224.2 μs | 7,597.0 |   8.68 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   132.1 μs |  18.95 μs |   9.71 μs |   124.7 μs |   112.8 μs |   184.1 μs | 7,567.3 |   9.11 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   134.7 μs |  14.91 μs |   7.55 μs |   131.9 μs |   114.0 μs |   169.8 μs | 7,425.4 |   9.77 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   134.9 μs |  21.62 μs |  11.22 μs |   130.8 μs |   110.2 μs |   195.3 μs | 7,411.6 |   9.31 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   135.6 μs |  18.40 μs |   9.55 μs |   132.0 μs |   114.5 μs |   198.1 μs | 7,373.7 |   9.77 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   136.6 μs |  13.09 μs |   6.79 μs |   131.7 μs |   121.8 μs |   174.3 μs | 7,320.3 |  10.32 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   136.9 μs |  24.65 μs |  12.34 μs |   130.6 μs |   113.7 μs |   231.5 μs | 7,306.8 |   9.29 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   137.0 μs |  25.65 μs |  12.70 μs |   128.3 μs |   109.3 μs |   233.0 μs | 7,301.8 |   8.84 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   138.6 μs |  13.95 μs |   7.24 μs |   133.9 μs |   124.3 μs |   190.3 μs | 7,216.7 |  10.27 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   138.6 μs |  18.67 μs |   9.24 μs |   132.7 μs |   116.2 μs |   191.0 μs | 7,213.1 |   9.55 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   138.7 μs |  18.90 μs |   9.81 μs |   133.2 μs |   118.0 μs |   184.8 μs | 7,207.6 |   9.83 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   146.4 μs |  58.65 μs |  30.07 μs |   117.9 μs |   106.3 μs |   311.8 μs | 6,829.4 |   8.68 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   146.8 μs |  65.71 μs |  34.10 μs |   115.5 μs |   105.2 μs |   316.4 μs | 6,810.2 |   8.66 KB |
| Single                            | InsightBenchmarkWrite |   147.0 μs |  24.45 μs |  12.10 μs |   144.0 μs |   105.7 μs |   215.4 μs | 6,801.0 |   8.86 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   148.0 μs |  45.19 μs |  23.75 μs |   132.8 μs |   109.6 μs |   307.7 μs | 6,758.5 |   9.11 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   149.5 μs |  21.51 μs |  11.31 μs |   143.0 μs |   125.1 μs |   240.7 μs | 6,688.4 |  10.32 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   150.8 μs |  21.24 μs |  10.76 μs |   144.1 μs |   125.1 μs |   213.2 μs | 6,632.8 |  10.27 KB |
| Single                            | InsightBenchmark      |   151.9 μs |  51.63 μs |  26.16 μs |   126.8 μs |   106.9 μs |   313.1 μs | 6,585.3 |   8.86 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   152.8 μs |  57.94 μs |  30.85 μs |   131.0 μs |   113.0 μs |   338.6 μs | 6,545.9 |   9.11 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   163.3 μs |  62.80 μs |  32.60 μs |   134.1 μs |   113.7 μs |   369.8 μs | 6,125.0 |   9.29 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   173.8 μs |  69.63 μs |  36.14 μs |   146.6 μs |   113.9 μs |   401.8 μs | 5,752.2 |   9.29 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   193.6 μs |  83.35 μs |  44.38 μs |   161.2 μs |   107.3 μs |   355.4 μs | 5,165.3 |   8.68 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 3,008.0 μs | 150.38 μs |  78.05 μs | 2,988.4 μs | 2,787.7 μs | 3,535.8 μs |   332.4 |  22.99 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 3,017.2 μs | 209.69 μs | 108.84 μs | 2,974.1 μs | 2,709.9 μs | 3,536.6 μs |   331.4 |  22.99 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,221.5 μs | 213.47 μs | 110.80 μs | 3,212.8 μs | 2,924.2 μs | 3,725.7 μs |   310.4 |  23.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,333.2 μs | 198.55 μs | 103.05 μs | 3,308.8 μs | 2,947.7 μs | 3,808.0 μs |   300.0 |  23.95 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,116.0 μs | 182.34 μs |  93.49 μs | 4,093.2 μs | 3,768.2 μs | 4,528.3 μs |   243.0 |   7.73 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,217.4 μs | 182.01 μs |  90.10 μs | 4,212.9 μs | 3,910.7 μs | 4,920.9 μs |   237.1 |   7.95 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,329.0 μs | 365.12 μs | 184.97 μs | 4,223.2 μs | 3,854.1 μs | 5,450.7 μs |   231.0 |   7.41 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,367.5 μs | 429.51 μs | 212.62 μs | 4,220.2 μs | 3,928.3 μs | 5,600.4 μs |   229.0 |   7.15 KB |
