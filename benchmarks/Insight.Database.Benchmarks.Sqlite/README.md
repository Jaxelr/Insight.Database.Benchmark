# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3155/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   170.4 μs |  39.36 μs |  20.43 μs |   157.6 μs |   124.0 μs |   275.1 μs | 5,868.5 |   9.98 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   174.1 μs |  45.84 μs |  24.73 μs |   169.8 μs |   117.8 μs |   299.5 μs | 5,744.7 |   9.54 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   174.4 μs |  37.35 μs |  19.39 μs |   164.4 μs |   122.5 μs |   287.6 μs | 5,732.9 |   9.98 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   178.2 μs |  38.94 μs |  20.21 μs |   175.4 μs |   124.4 μs |   295.9 μs | 5,613.2 |  10.73 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   178.7 μs |  30.31 μs |  15.73 μs |   179.7 μs |   129.2 μs |   238.6 μs | 5,594.8 |   9.73 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   179.7 μs |  58.07 μs |  29.77 μs |   155.7 μs |   107.3 μs |   374.2 μs | 5,566.0 |   9.55 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   182.5 μs |  30.51 μs |  16.03 μs |   181.8 μs |   133.4 μs |   252.1 μs | 5,479.3 |  10.05 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   184.7 μs |  39.53 μs |  21.05 μs |   175.0 μs |   129.7 μs |   332.0 μs | 5,413.6 |   9.86 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   187.7 μs |  46.53 μs |  23.57 μs |   167.7 μs |   134.4 μs |   357.0 μs | 5,327.2 |   9.54 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   189.8 μs |  59.04 μs |  30.64 μs |   173.3 μs |   125.5 μs |   373.7 μs | 5,268.5 |   9.54 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   190.2 μs |  46.48 μs |  23.27 μs |   180.9 μs |   128.7 μs |   318.3 μs | 5,258.8 |   9.98 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   192.1 μs |  57.97 μs |  29.72 μs |   177.9 μs |   123.8 μs |   421.6 μs | 5,206.2 |  10.73 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   192.3 μs |  65.72 μs |  32.91 μs |   176.0 μs |   115.8 μs |   407.2 μs | 5,200.0 |   8.88 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   192.7 μs |  41.00 μs |  21.28 μs |   192.5 μs |   123.2 μs |   287.1 μs | 5,189.6 |  10.17 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   192.7 μs |  66.63 μs |  34.16 μs |   179.4 μs |   123.5 μs |   395.4 μs | 5,189.3 |  10.17 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   192.7 μs |  47.75 μs |  25.10 μs |   182.6 μs |   128.6 μs |   311.9 μs | 5,188.7 |   9.98 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   194.3 μs |  45.47 μs |  23.60 μs |   191.6 μs |   132.2 μs |   370.0 μs | 5,147.6 |  10.05 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   195.3 μs |  41.66 μs |  21.62 μs |   199.6 μs |   130.6 μs |   291.2 μs | 5,120.8 |   9.86 KB |
| Single                            | InsightBenchmarkWrite |   196.1 μs |  64.13 μs |  32.88 μs |   177.6 μs |   119.6 μs |   372.6 μs | 5,100.5 |   9.74 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   196.2 μs |  46.03 μs |  24.51 μs |   183.4 μs |   134.8 μs |   345.2 μs | 5,096.9 |   9.58 KB |
| Single                            | InsightBenchmark      |   198.8 μs |  71.41 μs |  36.61 μs |   175.8 μs |   119.3 μs |   390.9 μs | 5,028.9 |   9.74 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   205.9 μs |  50.61 μs |  26.60 μs |   195.6 μs |   137.5 μs |   411.4 μs | 4,856.5 |  10.17 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   207.6 μs |  64.87 μs |  33.67 μs |   184.8 μs |   133.8 μs |   388.9 μs | 4,816.8 |   9.98 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   208.8 μs |  63.36 μs |  32.49 μs |   195.4 μs |   130.5 μs |   435.3 μs | 4,790.1 |    9.7 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   209.2 μs |  48.46 μs |  25.47 μs |   198.9 μs |   136.7 μs |   338.2 μs | 4,779.9 |  10.05 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   209.7 μs |  40.28 μs |  20.65 μs |   200.8 μs |   138.2 μs |   330.0 μs | 4,769.3 |   9.98 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   213.4 μs |  74.85 μs |  37.92 μs |   190.5 μs |   129.4 μs |   437.8 μs | 4,685.1 |  10.17 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   214.3 μs |  35.23 μs |  18.52 μs |   219.5 μs |   147.2 μs |   296.3 μs | 4,666.3 |   9.73 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   216.5 μs |  82.88 μs |  41.99 μs |   178.6 μs |   124.1 μs |   427.9 μs | 4,619.3 |   9.86 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   216.6 μs |  30.13 μs |  15.84 μs |   215.6 μs |   161.9 μs |   308.2 μs | 4,617.0 |  10.05 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   223.7 μs |  66.77 μs |  33.83 μs |   221.4 μs |   128.2 μs |   383.8 μs | 4,469.5 |   9.55 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   225.0 μs |  56.30 μs |  29.22 μs |   216.4 μs |   139.3 μs |   380.4 μs | 4,444.7 |  11.18 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   231.0 μs |  61.09 μs |  31.71 μs |   218.2 μs |   140.6 μs |   358.4 μs | 4,329.8 |   9.55 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   232.1 μs |  65.81 μs |  33.74 μs |   229.6 μs |   145.6 μs |   385.8 μs | 4,308.5 |   9.98 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   235.4 μs |  69.66 μs |  35.29 μs |   215.6 μs |   153.9 μs |   452.1 μs | 4,248.5 |  11.23 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   248.2 μs |  74.77 μs |  39.30 μs |   267.9 μs |   126.6 μs |   394.4 μs | 4,029.2 |  10.68 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   257.7 μs |  80.23 μs |  40.65 μs |   238.1 μs |   148.1 μs |   497.9 μs | 3,880.6 |  11.18 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   279.9 μs |  82.15 μs |  42.12 μs |   273.4 μs |   160.2 μs |   556.2 μs | 3,572.3 |   9.73 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   298.7 μs |  65.58 μs |  34.04 μs |   286.7 μs |   195.8 μs |   414.4 μs | 3,347.4 |   10.4 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   334.0 μs |  77.55 μs |  38.83 μs |   326.9 μs |   211.8 μs |   532.1 μs | 2,994.2 |   10.9 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 3,462.6 μs | 451.88 μs | 231.68 μs | 3,394.0 μs | 2,796.3 μs | 4,758.2 μs |   288.8 |  23.88 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 3,467.0 μs | 499.11 μs | 252.85 μs | 3,378.8 μs | 2,865.4 μs | 4,907.3 μs |   288.4 |  23.88 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 3,638.8 μs | 262.71 μs | 139.87 μs | 3,591.0 μs | 3,322.8 μs | 4,433.1 μs |   274.8 |  24.79 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 3,734.1 μs | 362.73 μs | 188.27 μs | 3,626.9 μs | 3,160.4 μs | 4,637.2 μs |   267.8 |  24.79 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 4,223.8 μs | 308.70 μs | 154.58 μs | 4,230.9 μs | 3,687.2 μs | 4,875.7 μs |   236.8 |   8.47 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 4,410.5 μs | 450.40 μs | 242.99 μs | 4,329.7 μs | 3,588.8 μs | 5,739.3 μs |   226.7 |   8.21 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,435.4 μs | 492.18 μs | 249.34 μs | 4,383.7 μs | 3,305.6 μs | 5,901.4 μs |   225.5 |   9.74 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 4,504.2 μs | 542.01 μs | 281.32 μs | 4,313.1 μs | 3,768.9 μs | 6,015.8 μs |   222.0 |   9.23 KB |
