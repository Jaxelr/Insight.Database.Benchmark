# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT


```
|                            Method |                  Type |       Mean |      StdDev |     Error |     Median |        Min |         Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|----------:|-----------:|-----------:|------------:|--------:|----------:|
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   173.2 μs |    32.19 μs |  16.51 μs |   166.9 μs |   133.0 μs |    272.8 μs | 5,775.3 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   175.1 μs |    36.55 μs |  18.97 μs |   163.2 μs |   127.7 μs |    282.2 μs | 5,712.1 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   177.2 μs |    43.55 μs |  22.60 μs |   166.8 μs |   129.1 μs |    340.3 μs | 5,643.3 |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   180.4 μs |    53.26 μs |  27.64 μs |   168.8 μs |   122.8 μs |    302.2 μs | 5,543.6 |     10 KB |
|                            Single |      InsightBenchmark |   183.8 μs |    55.02 μs |  27.55 μs |   165.3 μs |   124.2 μs |    338.4 μs | 5,439.7 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   199.0 μs |    63.44 μs |  32.93 μs |   178.5 μs |   127.0 μs |    439.6 μs | 5,025.6 |     10 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   205.7 μs |    65.81 μs |  34.16 μs |   178.8 μs |   135.4 μs |    380.3 μs | 4,861.3 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   210.2 μs |    53.78 μs |  27.25 μs |   202.8 μs |   132.3 μs |    338.2 μs | 4,756.9 |     10 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   212.7 μs |    54.44 μs |  28.61 μs |   190.9 μs |   153.8 μs |    339.8 μs | 4,700.4 |     11 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   215.0 μs |    32.29 μs |  16.97 μs |   210.1 μs |   150.2 μs |    286.4 μs | 4,651.9 |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   216.7 μs |    78.94 μs |  40.97 μs |   191.2 μs |   127.3 μs |    437.3 μs | 4,614.2 |     10 KB |
|                            Single | InsightBenchmarkWrite |   218.1 μs |    64.31 μs |  33.38 μs |   194.2 μs |   147.9 μs |    417.9 μs | 4,584.0 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   221.3 μs |   111.12 μs |  55.64 μs |   190.8 μs |   129.3 μs |    716.6 μs | 4,519.4 |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   222.1 μs |    73.93 μs |  38.86 μs |   204.7 μs |   132.4 μs |    405.5 μs | 4,501.8 |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   231.0 μs |    64.56 μs |  33.51 μs |   225.6 μs |   145.7 μs |    416.8 μs | 4,329.5 |     11 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   234.0 μs |    40.29 μs |  20.65 μs |   228.1 μs |   170.8 μs |    333.0 μs | 4,273.5 |     10 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   237.7 μs |    77.28 μs |  40.62 μs |   216.8 μs |   140.6 μs |    437.6 μs | 4,206.4 |     11 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   239.0 μs |    65.43 μs |  33.15 μs |   229.3 μs |   151.3 μs |    398.8 μs | 4,183.9 |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   239.5 μs |    90.78 μs |  47.71 μs |   205.3 μs |   159.4 μs |    562.6 μs | 4,174.7 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   241.3 μs |    63.84 μs |  31.60 μs |   223.2 μs |   170.1 μs |    403.8 μs | 4,143.6 |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   249.2 μs |    82.23 μs |  42.16 μs |   239.8 μs |   145.3 μs |    563.1 μs | 4,012.8 |     11 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   251.6 μs |    62.92 μs |  31.50 μs |   242.5 μs |   185.8 μs |    520.4 μs | 3,974.6 |     10 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   251.9 μs |    71.56 μs |  35.42 μs |   245.5 μs |   160.3 μs |    448.9 μs | 3,969.5 |     10 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   256.1 μs |    91.97 μs |  46.05 μs |   241.5 μs |   137.3 μs |    480.5 μs | 3,904.7 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   256.9 μs |    54.84 μs |  28.47 μs |   251.4 μs |   177.1 μs |    421.4 μs | 3,893.1 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   259.4 μs |    76.93 μs |  38.52 μs |   226.4 μs |   173.2 μs |    406.9 μs | 3,854.4 |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   262.0 μs |    58.95 μs |  30.22 μs |   247.6 μs |   173.4 μs |    416.1 μs | 3,817.4 |     10 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   264.3 μs |    99.01 μs |  50.76 μs |   235.7 μs |   158.2 μs |    638.2 μs | 3,783.3 |     10 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   266.8 μs |    67.61 μs |  34.25 μs |   247.6 μs |   175.3 μs |    459.9 μs | 3,748.1 |     11 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   267.5 μs |    82.94 μs |  43.59 μs |   252.8 μs |   160.9 μs |    452.2 μs | 3,738.3 |     10 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   278.0 μs |    65.47 μs |  33.98 μs |   274.1 μs |   168.6 μs |    431.7 μs | 3,597.2 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   285.9 μs |   102.55 μs |  51.95 μs |   243.6 μs |   168.2 μs |    538.1 μs | 3,497.6 |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   294.2 μs |    88.63 μs |  45.44 μs |   262.3 μs |   171.3 μs |    499.6 μs | 3,398.5 |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   301.8 μs |    60.71 μs |  31.13 μs |   282.3 μs |   211.2 μs |    457.3 μs | 3,313.7 |     11 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   304.0 μs |    96.29 μs |  50.61 μs |   266.4 μs |   198.6 μs |    572.5 μs | 3,289.1 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   312.6 μs |    93.46 μs |  47.35 μs |   309.5 μs |   193.6 μs |    680.0 μs | 3,199.2 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   322.3 μs |    85.36 μs |  43.77 μs |   306.6 μs |   186.3 μs |    501.1 μs | 3,103.1 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   323.6 μs |    77.21 μs |  39.12 μs |   332.5 μs |   200.8 μs |    531.5 μs | 3,090.7 |     10 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   323.7 μs |   116.20 μs |  59.58 μs |   287.9 μs |   206.4 μs |    740.3 μs | 3,089.3 |     11 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   324.1 μs |   100.13 μs |  51.97 μs |   341.2 μs |   169.7 μs |    550.9 μs | 3,085.1 |     10 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 4,447.5 μs |   755.64 μs | 392.20 μs | 4,142.1 μs | 3,679.2 μs |  6,690.8 μs |   224.8 |     25 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5,099.6 μs | 1,791.94 μs | 897.27 μs | 4,487.2 μs | 3,125.2 μs | 12,688.5 μs |   196.1 |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 5,362.9 μs | 1,707.39 μs | 854.93 μs | 5,139.4 μs | 3,581.9 μs | 10,896.4 μs |   186.5 |     25 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 5,654.8 μs | 1,216.30 μs | 616.19 μs | 5,738.1 μs | 3,550.7 μs |  7,915.6 μs |   176.8 |     24 KB |
|                                   |                       |            |             |           |            |            |             |         |           |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 3,908.8 μs |   327.29 μs | 163.88 μs | 3,926.8 μs | 3,064.1 μs |  4,606.7 μs |   255.8 |      9 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 4,123.2 μs |   616.45 μs | 312.30 μs | 4,205.9 μs | 3,075.4 μs |  5,387.9 μs |   242.5 |      8 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,398.5 μs |   530.87 μs | 268.94 μs | 4,290.6 μs | 3,467.5 μs |  5,545.0 μs |   227.3 |      9 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 4,599.6 μs |   503.60 μs | 258.20 μs | 4,574.7 μs | 3,663.9 μs |  5,997.4 μs |   217.4 |     10 KB |
