# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                            Method |                  Type |       Mean |      StdDev |       Error |     Median |        Min |         Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|--------:|----------:|
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   262.2 μs |    26.91 μs |    13.79 μs |   264.0 μs |   206.1 μs |    336.5 μs | 3,814.1 |   9.33 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   276.0 μs |    22.12 μs |    11.48 μs |   274.3 μs |   235.0 μs |    330.4 μs | 3,623.4 |   9.52 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   282.1 μs |    28.01 μs |    14.03 μs |   281.8 μs |   228.3 μs |    338.1 μs | 3,545.2 |   9.84 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   288.1 μs |    30.66 μs |    15.92 μs |   284.6 μs |   222.3 μs |    361.2 μs | 3,471.3 |   9.65 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   289.5 μs |    42.60 μs |    21.58 μs |   281.2 μs |   219.0 μs |    397.5 μs | 3,453.6 |   9.96 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   294.0 μs |    38.99 μs |    19.75 μs |   286.7 μs |   237.0 μs |    400.7 μs | 3,401.4 |   9.65 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   304.2 μs |    24.03 μs |    12.03 μs |   299.3 μs |   269.1 μs |    361.5 μs | 3,287.1 |  10.47 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   305.1 μs |    43.96 μs |    22.54 μs |   289.4 μs |   248.5 μs |    437.0 μs | 3,278.1 |   9.77 KB |
|                            Single | InsightBenchmarkWrite |   307.2 μs |    50.10 μs |    25.38 μs |   296.2 μs |   225.4 μs |    441.2 μs | 3,255.1 |   9.53 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   308.8 μs |    58.14 μs |    30.18 μs |   287.1 μs |   241.4 μs |    494.4 μs | 3,238.0 |   9.34 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   312.1 μs |    41.38 μs |    21.48 μs |   304.2 μs |   247.0 μs |    419.9 μs | 3,203.8 |   9.96 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   315.0 μs |    51.50 μs |    26.09 μs |   304.9 μs |   252.2 μs |    447.6 μs | 3,174.9 |   9.96 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   318.1 μs |    58.76 μs |    30.13 μs |   315.7 μs |   240.8 μs |    478.9 μs | 3,143.6 |   9.34 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   319.0 μs |    44.03 μs |    23.14 μs |   310.2 μs |   241.8 μs |    421.1 μs | 3,134.9 |   9.52 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   321.4 μs |    67.37 μs |    34.13 μs |   297.6 μs |   243.6 μs |    489.2 μs | 3,111.3 |   9.84 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   323.9 μs |    36.64 μs |    18.56 μs |   319.6 μs |   273.8 μs |    448.5 μs | 3,087.5 |   9.77 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   324.4 μs |    93.95 μs |    47.04 μs |   290.0 μs |   237.4 μs |    620.8 μs | 3,082.5 |   9.34 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   325.3 μs |    48.12 μs |    24.38 μs |   320.1 μs |   243.1 μs |    444.3 μs | 3,073.9 |   9.84 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   328.9 μs |    72.56 μs |    36.33 μs |   301.7 μs |   246.6 μs |    541.2 μs | 3,040.7 |   9.34 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   333.9 μs |    93.56 μs |    46.85 μs |   300.7 μs |   250.7 μs |    608.0 μs | 2,994.5 |   9.65 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   337.3 μs |    78.66 μs |    40.33 μs |   300.2 μs |   270.7 μs |    565.7 μs | 2,964.7 |   9.33 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   341.1 μs |    89.91 μs |    45.55 μs |   311.1 μs |   243.0 μs |    622.7 μs | 2,931.4 |   9.77 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   341.2 μs |    76.35 μs |    39.63 μs |   324.3 μs |   256.7 μs |    534.6 μs | 2,930.8 |   9.33 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   341.4 μs |   104.00 μs |    51.49 μs |   323.7 μs |   222.8 μs |    626.9 μs | 2,928.7 |   9.84 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   342.6 μs |    99.39 μs |    50.96 μs |   326.8 μs |   216.4 μs |    594.5 μs | 2,919.0 |   9.33 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   343.4 μs |    80.20 μs |    41.63 μs |   309.4 μs |   274.5 μs |    583.2 μs | 2,911.7 |  10.47 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   345.8 μs |    60.75 μs |    30.78 μs |   330.2 μs |   266.2 μs |    516.5 μs | 2,891.7 |   9.77 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   347.2 μs |   105.84 μs |    52.39 μs |   307.7 μs |   243.6 μs |    641.9 μs | 2,880.0 |   9.77 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   351.0 μs |    72.21 μs |    36.16 μs |   334.8 μs |   242.3 μs |    531.5 μs | 2,849.4 |   9.77 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   357.6 μs |    69.36 μs |    35.14 μs |   333.0 μs |   281.8 μs |    520.8 μs | 2,796.1 |  11.02 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   358.5 μs |    95.64 μs |    47.89 μs |   324.9 μs |   228.9 μs |    608.8 μs | 2,789.7 |   9.77 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   360.0 μs |    89.23 μs |    46.90 μs |   317.4 μs |   250.4 μs |    607.5 μs | 2,777.5 |  10.52 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   365.0 μs |   105.39 μs |    54.03 μs |   319.1 μs |   269.0 μs |    651.3 μs | 2,739.6 |   9.65 KB |
|                            Single |      InsightBenchmark |   377.2 μs |    64.87 μs |    32.86 μs |   365.7 μs |   270.6 μs |    561.2 μs | 2,650.8 |   9.53 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   390.6 μs |    63.03 μs |    33.13 μs |   375.5 μs |   267.4 μs |    583.3 μs | 2,560.2 |   9.96 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   406.6 μs |   107.54 μs |    54.48 μs |   364.6 μs |   290.1 μs |    685.0 μs | 2,459.2 |  10.52 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   466.9 μs |   157.71 μs |    78.97 μs |   413.5 μs |   304.9 μs |    799.9 μs | 2,141.6 |  10.97 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   467.4 μs |   183.83 μs |    95.42 μs |   360.9 μs |   281.0 μs |    872.3 μs | 2,139.7 |  11.02 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   527.6 μs |   185.28 μs |    93.87 μs |   516.5 μs |   284.1 μs |    908.0 μs | 1,895.4 |  10.97 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   592.1 μs |   225.68 μs |   115.71 μs |   675.4 μs |   226.5 μs |    913.2 μs | 1,688.9 |   9.77 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5,506.1 μs |   855.40 μs |   438.57 μs | 5,284.2 μs | 4,450.5 μs |  7,395.1 μs |   181.6 |  23.66 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 5,819.0 μs |   966.98 μs |   484.19 μs | 5,392.8 μs | 4,719.9 μs |  9,227.4 μs |   171.8 |  24.55 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 5,827.0 μs | 1,395.40 μs |   715.44 μs | 5,231.6 μs | 4,589.6 μs |  9,512.7 μs |   171.6 |  24.55 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 6,427.3 μs | 2,086.50 μs | 1,057.05 μs | 5,278.2 μs | 4,008.8 μs | 10,701.0 μs |   155.6 |  23.66 KB |
|                                   |                       |            |             |             |            |            |             |         |           |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,024.3 μs |   340.15 μs |   168.38 μs | 3,973.8 μs | 3,359.3 μs |  4,813.2 μs |   248.5 |   9.49 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 4,215.0 μs |   508.51 μs |   257.62 μs | 4,182.5 μs | 3,320.1 μs |  5,720.0 μs |   237.3 |   8.23 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,896.2 μs |   469.40 μs |   237.80 μs | 4,865.5 μs | 4,022.5 μs |  5,731.8 μs |   204.2 |   9.26 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 5,156.2 μs |   492.78 μs |   243.94 μs | 5,163.9 μs | 4,089.0 μs |  6,162.4 μs |   193.9 |   7.98 KB |
