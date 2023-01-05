# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

``` ini

BenchmarkDotNet=v0.13.3, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                            Method |                  Type |       Mean |    StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|                          Query&lt;T&gt; | InsightBenchmarkWrite |   208.7 μs |  24.16 μs |  12.86 μs |   210.5 μs |   161.2 μs |   279.3 μs | 4,791.5 |   9.59 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   217.1 μs |  33.81 μs |  17.13 μs |   209.4 μs |   168.7 μs |   299.6 μs | 4,605.4 |    9.4 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   224.9 μs |  33.80 μs |  17.33 μs |   217.6 μs |   170.0 μs |   298.6 μs | 4,446.6 |   9.41 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   225.2 μs |  41.32 μs |  20.93 μs |   227.3 μs |   156.6 μs |   329.0 μs | 4,439.6 |   9.72 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   229.1 μs |  44.15 μs |  22.11 μs |   222.1 μs |   165.6 μs |   316.3 μs | 4,364.8 |   9.72 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   235.3 μs |  44.84 μs |  22.99 μs |   229.2 μs |   168.6 μs |   374.9 μs | 4,250.1 |   9.84 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |   236.4 μs |  50.29 μs |  24.90 μs |   226.5 μs |   163.8 μs |   366.4 μs | 4,229.4 |   9.41 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |   237.6 μs |  49.61 μs |  24.84 μs |   227.1 μs |   168.5 μs |   407.1 μs | 4,209.4 |  10.59 KB |
|                            Single | InsightBenchmarkWrite |   237.9 μs |  34.03 μs |  17.24 μs |   231.5 μs |   179.4 μs |   339.3 μs | 4,204.0 |    9.6 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   238.3 μs |  37.55 μs |  19.25 μs |   239.5 μs |   173.7 μs |   323.6 μs | 4,197.2 |  10.54 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   239.3 μs |  41.91 μs |  20.98 μs |   245.0 μs |   165.8 μs |   332.6 μs | 4,178.6 |   9.91 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   241.0 μs |  36.22 μs |  18.13 μs |   242.6 μs |   176.4 μs |   333.2 μs | 4,149.3 |  10.03 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |   241.4 μs |  31.57 μs |  16.18 μs |   241.5 μs |   185.0 μs |   321.1 μs | 4,142.4 |   9.91 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |   242.5 μs |  47.10 μs |  24.45 μs |   237.1 μs |   173.5 μs |   338.2 μs | 4,123.0 |  10.03 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |   246.6 μs |  55.08 μs |  28.95 μs |   235.4 μs |   164.3 μs |   412.8 μs | 4,054.5 |  10.03 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   246.9 μs |  77.82 μs |  39.90 μs |   227.6 μs |   150.0 μs |   492.1 μs | 4,050.5 |    9.4 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   250.5 μs |  62.67 μs |  31.75 μs |   257.1 μs |   151.6 μs |   364.1 μs | 3,992.8 |   9.84 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   256.8 μs |  34.99 μs |  17.94 μs |   248.8 μs |   200.2 μs |   333.3 μs | 3,893.9 |   9.84 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   258.1 μs |  73.31 μs |  36.71 μs |   257.2 μs |   149.4 μs |   439.2 μs | 3,873.9 |   9.84 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   258.7 μs |  45.33 μs |  23.24 μs |   252.9 μs |   185.0 μs |   388.9 μs | 3,864.9 |  11.09 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   258.9 μs |  45.57 μs |  22.56 μs |   255.7 μs |   175.6 μs |   364.1 μs | 3,862.7 |   9.84 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   261.5 μs |  70.88 μs |  35.49 μs |   267.1 μs |   154.1 μs |   445.9 μs | 3,824.5 |   9.41 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   261.6 μs |  68.22 μs |  34.56 μs |   247.6 μs |   176.3 μs |   458.7 μs | 3,823.1 |    9.4 KB |
|                            Single |      InsightBenchmark |   262.8 μs |  62.23 μs |  30.81 μs |   254.9 μs |   158.6 μs |   398.8 μs | 3,804.5 |    9.6 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   262.9 μs |  56.54 μs |  28.99 μs |   259.2 μs |   176.3 μs |   429.9 μs | 3,804.3 |  10.59 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   264.2 μs |  44.60 μs |  24.06 μs |   271.3 μs |   176.6 μs |   325.0 μs | 3,784.4 |  11.04 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   266.6 μs |  66.26 μs |  34.39 μs |   260.0 μs |   165.3 μs |   441.9 μs | 3,751.2 |   9.84 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |   266.9 μs |  37.99 μs |  19.48 μs |   264.2 μs |   199.8 μs |   348.1 μs | 3,746.6 |  10.54 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   271.1 μs |  61.04 μs |  31.68 μs |   278.4 μs |   161.5 μs |   385.8 μs | 3,689.4 |   9.72 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |   272.9 μs |  61.35 μs |  30.72 μs |   266.4 μs |   168.7 μs |   464.2 μs | 3,664.0 |   9.91 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |   275.4 μs |  64.77 μs |  33.62 μs |   270.8 μs |   175.2 μs |   412.8 μs | 3,630.8 |   9.59 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   281.4 μs |  69.43 μs |  36.49 μs |   270.1 μs |   175.6 μs |   439.8 μs | 3,554.2 |   9.72 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   282.3 μs |  38.01 μs |  19.26 μs |   282.6 μs |   215.1 μs |   371.1 μs | 3,542.5 |   9.91 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   285.9 μs |  85.16 μs |  44.20 μs |   238.3 μs |   187.1 μs |   477.4 μs | 3,497.5 |  11.09 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   290.6 μs |  86.35 μs |  44.27 μs |   258.9 μs |   182.8 μs |   520.1 μs | 3,441.1 |   9.84 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   309.3 μs | 138.74 μs |  71.13 μs |   231.8 μs |   169.1 μs |   659.0 μs | 3,233.5 |   9.41 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   334.6 μs | 133.35 μs |  66.77 μs |   282.4 μs |   213.0 μs |   664.6 μs | 2,988.8 |  10.03 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   346.8 μs | 119.71 μs |  62.13 μs |   297.3 μs |   204.4 μs |   583.1 μs | 2,883.7 |    9.4 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   355.6 μs | 103.74 μs |  51.95 μs |   331.1 μs |   211.7 μs |   656.3 μs | 2,811.8 |  11.04 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   494.6 μs |  84.83 μs |  42.48 μs |   518.9 μs |   331.6 μs |   685.0 μs | 2,021.9 |   9.84 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 4,576.0 μs | 528.10 μs | 270.76 μs | 4,375.9 μs | 3,937.8 μs | 6,072.1 μs |   218.5 |  23.73 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 4,768.8 μs | 688.10 μs | 352.79 μs | 4,489.4 μs | 3,872.1 μs | 6,736.5 μs |   209.7 |  23.73 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 5,329.1 μs | 917.54 μs | 470.43 μs | 5,320.8 μs | 4,232.5 μs | 8,359.6 μs |   187.7 |  24.63 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 5,376.8 μs | 469.36 μs | 232.35 μs | 5,298.5 μs | 4,643.6 μs | 6,603.9 μs |   186.0 |  24.63 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,772.5 μs | 462.19 μs | 236.97 μs | 3,782.4 μs | 3,013.6 μs | 4,834.6 μs |   265.1 |   9.33 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,846.0 μs | 386.28 μs | 195.69 μs | 3,883.1 μs | 3,043.9 μs | 4,726.7 μs |   260.0 |   9.56 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 3,881.5 μs | 613.89 μs | 311.00 μs | 3,772.4 μs | 2,904.8 μs | 5,396.8 μs |   257.6 |    8.3 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 4,078.5 μs | 453.43 μs | 224.47 μs | 4,098.9 μs | 3,350.8 μs | 5,124.2 μs |   245.2 |   8.05 KB |
