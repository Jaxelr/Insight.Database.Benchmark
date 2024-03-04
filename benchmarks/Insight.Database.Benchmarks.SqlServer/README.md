# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over the latest Sql Server 2022.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3235/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|------------------------------------------ |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmarkWrite |   150.2 μs |  33.81 μs |  17.34 μs |   144.2 μs |   105.7 μs |   256.4 μs | 6,657.6 |  12.09 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmarkWrite |   164.7 μs |  16.44 μs |   8.87 μs |   165.0 μs |   108.8 μs |   200.0 μs | 6,071.1 |  12.09 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmark      |   168.4 μs |  31.62 μs |  16.83 μs |   172.8 μs |   113.5 μs |   233.5 μs | 5,938.9 |  12.76 KB |
| &#39;Query&lt;T&gt; Procedure (dynamic)&#39;            | InsightBenchmark      |   174.5 μs |  41.23 μs |  21.40 μs |   163.4 μs |   117.9 μs |   306.4 μs | 5,731.2 |  12.09 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmarkWrite |   178.4 μs |  39.52 μs |  20.26 μs |   176.3 μs |   111.0 μs |   303.2 μs | 5,604.5 |   12.1 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmark      |   179.8 μs |  32.76 μs |  17.00 μs |   181.4 μs |   117.7 μs |   245.7 μs | 5,563.1 |  12.74 KB |
| &#39;Single (Fast Expando)&#39;                   | InsightBenchmarkWrite |   180.0 μs |  51.69 μs |  27.52 μs |   164.2 μs |   109.5 μs |   323.6 μs | 5,554.6 |  12.76 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmarkWrite |   182.0 μs |  55.15 μs |  28.63 μs |   164.9 μs |   120.7 μs |   421.0 μs | 5,495.5 |  13.39 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmark      |   182.8 μs |  33.28 μs |  17.28 μs |   170.7 μs |   137.1 μs |   279.9 μs | 5,470.2 |   14.9 KB |
| &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39;       | InsightBenchmark      |   183.6 μs |  31.12 μs |  15.96 μs |   184.1 μs |   116.1 μs |   252.0 μs | 5,447.9 |  12.09 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmarkWrite |   183.7 μs |  37.78 μs |  19.61 μs |   181.1 μs |   111.0 μs |   274.4 μs | 5,443.3 |  12.76 KB |
| &#39;Single Procedure (Fast Expando)&#39;         | InsightBenchmark      |   189.7 μs |  38.03 μs |  19.99 μs |   187.5 μs |   132.6 μs |   303.6 μs | 5,271.2 |   12.1 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmark      |   190.0 μs |  39.56 μs |  20.79 μs |   181.9 μs |   117.3 μs |   297.7 μs | 5,263.0 |  13.39 KB |
| &#39;Single (dynamic)&#39;                        | InsightBenchmark      |   190.2 μs |  55.52 μs |  27.80 μs |   181.6 μs |   113.5 μs |   317.2 μs | 5,257.6 |  12.76 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmark      |   191.2 μs |  35.99 μs |  17.81 μs |   182.8 μs |   121.4 μs |   274.5 μs | 5,229.5 |  13.61 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmark      |   191.5 μs |  17.41 μs |   9.66 μs |   195.6 μs |   162.6 μs |   222.4 μs | 5,221.3 |   15.7 KB |
| &#39;Auto Interface Single (dynamic)&#39;         | InsightBenchmark      |   192.1 μs |  32.45 μs |  17.51 μs |   183.3 μs |   139.2 μs |   266.8 μs | 5,206.8 |  13.39 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmark      |   196.2 μs |  53.07 μs |  27.21 μs |   186.9 μs |   113.8 μs |   334.0 μs | 5,097.7 |   12.1 KB |
| Query&lt;T&gt;                                  | InsightBenchmark      |   199.5 μs |  40.25 μs |  21.16 μs |   193.2 μs |   138.1 μs |   349.1 μs | 5,012.3 |  14.25 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmark      |   200.4 μs |  35.76 μs |  18.79 μs |   197.7 μs |   138.3 μs |   285.1 μs | 4,989.0 |  12.74 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;                 | InsightBenchmarkWrite |   201.9 μs |  50.05 μs |  26.31 μs |   200.9 μs |   115.1 μs |   311.0 μs | 4,952.1 |  12.74 KB |
| &#39;Auto Interface Query (dynamic)&#39;          | InsightBenchmarkWrite |   203.2 μs |  33.98 μs |  17.42 μs |   210.5 μs |   140.4 μs |   267.6 μs | 4,921.1 |  13.39 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmarkWrite |   209.2 μs |  43.30 μs |  22.48 μs |   210.7 μs |   142.4 μs |   374.1 μs | 4,781.3 |  13.59 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmark      |   212.1 μs |  36.27 μs |  18.60 μs |   219.3 μs |   154.4 μs |   301.1 μs | 4,715.3 |   14.9 KB |
| &#39;Query&lt;T&gt; Procedure&#39;                      | InsightBenchmark      |   212.4 μs |  41.38 μs |  20.96 μs |   202.7 μs |   155.1 μs |   314.3 μs | 4,707.0 |  13.59 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmarkWrite |   214.5 μs |  44.41 μs |  23.34 μs |   215.2 μs |   134.5 μs |   345.1 μs | 4,661.1 |  14.67 KB |
| &#39;Single Procedure (dynamic)&#39;              | InsightBenchmarkWrite |   216.4 μs |  48.24 μs |  25.35 μs |   210.1 μs |   131.5 μs |   342.9 μs | 4,621.9 |   12.1 KB |
| &#39;Single Procedure&#39;                        | InsightBenchmarkWrite |   218.6 μs |  48.71 μs |  24.97 μs |   220.2 μs |   115.0 μs |   350.7 μs | 4,575.3 |  13.61 KB |
| Single                                    | InsightBenchmarkWrite |   218.9 μs |  41.30 μs |  21.71 μs |   213.9 μs |   151.7 μs |   310.1 μs | 4,568.1 |  14.27 KB |
| Single                                    | InsightBenchmark      |   219.1 μs |  75.47 μs |  39.67 μs |   209.6 μs |   132.4 μs |   453.9 μs | 4,563.8 |  13.98 KB |
| &#39;Auto Interface Single&#39;                   | InsightBenchmarkWrite |   220.6 μs |  42.34 μs |  22.54 μs |   223.2 μs |   127.5 μs |   320.0 μs | 4,533.9 |   14.9 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmarkWrite |   223.8 μs |  40.52 μs |  20.78 μs |   213.9 μs |   163.8 μs |   316.0 μs | 4,468.3 |   15.8 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmarkWrite |   224.4 μs |  44.19 μs |  22.66 μs |   214.7 μs |   155.2 μs |   353.7 μs | 4,456.1 |  14.73 KB |
| Query&lt;(Tuple)&gt;                            | InsightBenchmark      |   225.3 μs |  49.39 μs |  25.63 μs |   216.6 μs |   153.8 μs |   355.2 μs | 4,437.6 |  14.73 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmarkWrite |   225.4 μs |  53.18 μs |  27.95 μs |   203.3 μs |   163.4 μs |   376.0 μs | 4,436.9 |   15.7 KB |
| &#39;Single (Tuple)&#39;                          | InsightBenchmark      |   227.7 μs |  44.02 μs |  23.14 μs |   228.6 μs |   169.1 μs |   404.9 μs | 4,392.2 |  14.67 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmark      |   228.4 μs |  42.98 μs |  22.04 μs |   213.1 μs |   162.3 μs |   333.4 μs | 4,378.3 |   15.8 KB |
| &#39;Single json&#39;                             | InsightBenchmarkJson  |   230.4 μs |  43.09 μs |  22.37 μs |   227.6 μs |   166.9 μs |   316.2 μs | 4,339.5 |  45.63 KB |
| Query&lt;T&gt;                                  | InsightBenchmarkWrite |   232.7 μs |  47.83 μs |  24.83 μs |   229.6 μs |   124.8 μs |   354.4 μs | 4,297.8 |  14.25 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmarkWrite |   236.7 μs |  42.09 μs |  22.12 μs |   235.8 μs |   162.6 μs |   343.6 μs | 4,225.1 |  15.15 KB |
| &#39;Auto Interface Query&#39;                    | InsightBenchmarkWrite |   237.7 μs |  59.75 μs |  29.58 μs |   231.8 μs |   157.4 μs |   413.5 μs | 4,206.8 |   14.9 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmark      |   244.6 μs |  82.56 μs |  41.83 μs |   203.8 μs |   145.2 μs |   467.0 μs | 4,089.0 |  16.35 KB |
| &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39;      | InsightBenchmark      |   246.6 μs |  58.05 μs |  29.41 μs |   233.1 μs |   162.9 μs |   407.0 μs | 4,056.0 |   15.7 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmark      |   248.6 μs |  51.53 μs |  26.75 μs |   243.2 μs |   165.2 μs |   363.6 μs | 4,022.5 |  16.35 KB |
| &#39;Single Procedure Async (dynamic)&#39;        | InsightBenchmark      |   250.0 μs |  71.92 μs |  37.33 μs |   216.9 μs |   166.7 μs |   462.7 μs | 3,999.7 |  15.15 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;           | InsightBenchmarkWrite |   254.2 μs |  71.39 μs |  37.06 μs |   245.1 μs |   161.8 μs |   489.8 μs | 3,934.7 |  16.35 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   256.3 μs |  70.00 μs |  35.89 μs |   233.8 μs |   172.9 μs |   438.0 μs | 3,901.0 |  15.15 KB |
| &#39;Single Procedure Async (Fast Expando)&#39;   | InsightBenchmark      |   257.3 μs |  66.65 μs |  34.17 μs |   243.4 μs |   173.2 μs |   436.9 μs | 3,887.1 |  15.45 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmarkWrite |   259.3 μs |  52.11 μs |  27.39 μs |   244.4 μs |   170.4 μs |   397.9 μs | 3,856.9 |  17.86 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmarkWrite |   259.4 μs |  66.03 μs |  34.27 μs |   236.3 μs |   185.2 μs |   434.1 μs | 3,855.1 |  16.66 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmarkWrite |   262.7 μs |  64.82 μs |  33.65 μs |   240.4 μs |   179.7 μs |   413.5 μs | 3,807.2 |   17.2 KB |
| &#39;Single Procedure Async&#39;                  | InsightBenchmark      |   267.4 μs |  73.25 μs |  38.50 μs |   254.2 μs |   176.8 μs |   480.1 μs | 3,739.9 |  16.66 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   269.1 μs |  57.56 μs |  29.51 μs |   270.8 μs |   186.9 μs |   384.5 μs | 3,715.7 |   15.7 KB |
| &#39;Single Async (Fast Expando)&#39;             | InsightBenchmarkWrite |   274.0 μs |  75.81 μs |  38.41 μs |   266.1 μs |   169.0 μs |   525.1 μs | 3,650.2 |   15.8 KB |
| &#39;Query&lt;T&gt; Async&#39;                          | InsightBenchmark      |   275.4 μs |  80.96 μs |  41.51 μs |   247.0 μs |   177.4 μs |   531.5 μs | 3,631.4 |  17.86 KB |
| &#39;Single Async&#39;                            | InsightBenchmarkWrite |   277.3 μs |  72.04 μs |  36.50 μs |   245.1 μs |   179.3 μs |   445.7 μs | 3,605.9 |  17.31 KB |
| &#39;Single Async (dynamic)&#39;                  | InsightBenchmark      |   282.2 μs |  83.70 μs |  45.16 μs |   256.2 μs |   158.4 μs |   480.3 μs | 3,543.6 |   15.8 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |   285.7 μs |  76.40 μs |  39.17 μs |   261.6 μs |   192.0 μs |   514.5 μs | 3,500.3 |  17.84 KB |
| &#39;Query&lt;T&gt; Procedure Async&#39;                | InsightBenchmark      |   286.0 μs |  83.80 μs |  43.50 μs |   262.8 μs |   162.7 μs |   497.6 μs | 3,496.1 |   17.2 KB |
| &#39;Single Async&#39;                            | InsightBenchmark      |   301.6 μs |  99.46 μs |  51.62 μs |   260.3 μs |   193.7 μs |   601.1 μs | 3,315.8 |  17.31 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;                      | InsightBenchmarkWrite |   301.7 μs | 286.14 μs | 150.39 μs |   167.8 μs |   110.5 μs |   951.4 μs | 3,314.5 |  12.74 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |   311.9 μs |  95.18 μs |  48.22 μs |   295.2 μs |   189.9 μs |   552.4 μs | 3,205.7 |  17.84 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmarkWrite |   317.1 μs |  90.68 μs |  48.92 μs |   298.6 μs |   212.1 μs |   560.5 μs | 3,153.6 |  18.34 KB |
| &#39;Query&lt;T&gt; xml&#39;                            | InsightBenchmarkXml   |   324.3 μs |  48.33 μs |  25.08 μs |   321.8 μs |   243.7 μs |   445.4 μs | 3,083.3 |  67.28 KB |
| &#39;Single Async (Tuple)&#39;                    | InsightBenchmark      |   353.0 μs | 256.93 μs | 133.36 μs |   263.1 μs |   194.1 μs | 1,250.5 μs | 2,832.5 |  18.34 KB |
| &#39;Query&lt;T&gt; Async json&#39;                     | InsightBenchmarkJson  |   379.9 μs |  71.54 μs |  37.60 μs |   377.8 μs |   253.4 μs |   554.6 μs | 2,632.4 |  49.23 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;                | InsightBenchmarkWrite |   428.6 μs | 290.99 μs | 147.42 μs |   325.1 μs |   192.3 μs | 1,196.6 μs | 2,333.1 |  16.35 KB |
| &#39;Query&lt;T&gt; Async xml&#39;                      | InsightBenchmarkXml   |   440.6 μs |  73.51 μs |  38.15 μs |   452.2 μs |   310.7 μs |   598.2 μs | 2,269.7 |  70.89 KB |
| &#39;Query&lt;T&gt; json&#39;                           | InsightBenchmarkJson  |   447.2 μs | 369.96 μs | 189.68 μs |   271.3 μs |   160.2 μs | 1,607.6 μs | 2,236.1 |  45.62 KB |
| &#39;Single Async json&#39;                       | InsightBenchmarkJson  |   496.6 μs | 316.18 μs | 168.34 μs |   378.3 μs |   213.7 μs | 1,190.9 μs | 2,013.7 |  48.68 KB |
| &#39;Single Async xml&#39;                        | InsightBenchmarkXml   |   580.3 μs | 352.03 μs | 180.49 μs |   465.7 μs |   324.1 μs | 1,929.5 μs | 1,723.1 |  70.34 KB |
| &#39;Single xml&#39;                              | InsightBenchmarkXml   |   759.3 μs | 357.87 μs | 188.10 μs |   951.8 μs |   279.3 μs | 1,258.4 μs | 1,317.0 |   67.3 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmark      | 1,236.7 μs | 154.05 μs |  78.04 μs | 1,202.0 μs | 1,064.3 μs | 1,758.4 μs |   808.6 |  36.33 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;          | InsightBenchmarkWrite | 1,294.2 μs | 165.19 μs |  85.74 μs | 1,243.9 μs | 1,140.5 μs | 1,946.6 μs |   772.7 |  36.33 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmark      | 1,408.7 μs | 101.92 μs |  54.26 μs | 1,416.5 μs | 1,265.0 μs | 1,727.3 μs |   709.9 |  34.84 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;                   | InsightBenchmarkWrite | 1,461.3 μs | 107.89 μs |  56.71 μs | 1,440.2 μs | 1,292.2 μs | 1,705.0 μs |   684.3 |  34.84 KB |
|                                           |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   |   375.4 μs |  67.04 μs |  34.80 μs |   361.3 μs |   279.4 μs |   582.2 μs | 2,664.1 |   7.23 KB |
| Insert&lt;T&gt;                                 | InsightBenchmarkWrite |   392.3 μs |  92.51 μs |  48.01 μs |   370.8 μs |   261.0 μs |   629.8 μs | 2,549.3 |   7.23 KB |
| &#39;Insert&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite |   392.3 μs |  77.01 μs |  39.49 μs |   364.1 μs |   294.9 μs |   590.0 μs | 2,548.8 |  10.92 KB |
| Update&lt;T&gt;                                 | InsightBenchmarkWrite |   414.8 μs |  92.05 μs |  47.78 μs |   404.9 μs |   257.4 μs |   616.7 μs | 2,411.0 |  17.31 KB |
| &#39;Update&lt;T&gt; Async&#39;                         | InsightBenchmarkWrite |   433.4 μs | 113.43 μs |  56.80 μs |   391.8 μs |   315.5 μs |   858.9 μs | 2,307.5 |  20.49 KB |
| &#39;Insert&lt;T&gt; json&#39;                          | InsightBenchmarkJson  |   440.1 μs |  90.62 μs |  45.91 μs |   444.3 μs |   291.4 μs |   683.2 μs | 2,272.0 |   7.23 KB |
| &#39;Update&lt;T&gt; xml&#39;                           | InsightBenchmarkXml   |   489.5 μs |  84.46 μs |  42.79 μs |   460.1 μs |   353.9 μs |   696.8 μs | 2,042.9 |  11.38 KB |
| &#39;Update&lt;T&gt; json&#39;                          | InsightBenchmarkJson  |   518.6 μs | 200.76 μs | 102.93 μs |   480.3 μs |   269.4 μs | 1,078.2 μs | 1,928.4 |  11.41 KB |
