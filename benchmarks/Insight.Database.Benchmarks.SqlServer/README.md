# Insight.Database.Benchmarks.SqlServer

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Sql Server

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]   : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  ShortRun : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                                    Method |                  Type |       Mean |    StdDev |     Error |        Min |        Max |    Op/s | Allocated |
|------------------------------------------ |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|--------:|----------:|
|                        &#39;Single Procedure&#39; | InsightBenchmarkWrite |   139.3 μs |  24.05 μs |  12.80 μs |   106.6 μs |   204.7 μs | 7,177.0 |     14 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |      InsightBenchmark |   139.5 μs |  15.11 μs |   7.94 μs |   112.1 μs |   170.6 μs | 7,168.7 |     12 KB |
|              &#39;Single Procedure (dynamic)&#39; | InsightBenchmarkWrite |   140.7 μs |  28.13 μs |  14.98 μs |   108.9 μs |   195.9 μs | 7,108.9 |     12 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |      InsightBenchmark |   144.6 μs |  23.82 μs |  12.68 μs |   108.3 μs |   189.6 μs | 6,916.9 |     12 KB |
|         &#39;Single Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   146.9 μs |  30.65 μs |  16.11 μs |   103.8 μs |   199.6 μs | 6,805.8 |     12 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   147.1 μs |  30.83 μs |  16.20 μs |   112.2 μs |   217.0 μs | 6,796.6 |     13 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   147.5 μs |  26.08 μs |  13.71 μs |   107.8 μs |   198.5 μs | 6,780.6 |     13 KB |
|         &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   148.3 μs |  31.62 μs |  16.21 μs |   102.5 μs |   206.3 μs | 6,741.6 |     13 KB |
|                        &#39;Single (dynamic)&#39; |      InsightBenchmark |   149.2 μs |  29.13 μs |  15.51 μs |   114.8 μs |   231.5 μs | 6,702.1 |     13 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   151.0 μs |  20.25 μs |  10.64 μs |   106.7 μs |   206.8 μs | 6,624.3 |     13 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |      InsightBenchmark |   151.3 μs |  31.39 μs |  16.09 μs |   111.5 μs |   242.1 μs | 6,607.5 |     12 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |   152.5 μs |  36.73 μs |  18.83 μs |   102.4 μs |   254.8 μs | 6,557.9 |     13 KB |
|                          &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |   155.8 μs |  19.47 μs |  10.11 μs |   122.5 μs |   208.4 μs | 6,416.8 |     15 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |   157.3 μs |  37.08 μs |  19.01 μs |   108.5 μs |   235.4 μs | 6,355.4 |     13 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; | InsightBenchmarkWrite |   158.2 μs |  20.28 μs |  10.40 μs |   126.2 μs |   205.7 μs | 6,320.5 |     14 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |      InsightBenchmark |   159.0 μs |  23.52 μs |  11.91 μs |   115.8 μs |   206.4 μs | 6,290.5 |     14 KB |
|                        &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   159.3 μs |  34.92 μs |  17.91 μs |   106.1 μs |   235.3 μs | 6,276.6 |     13 KB |
|          &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |   161.1 μs |  42.75 μs |  21.66 μs |   103.7 μs |   270.9 μs | 6,208.7 |     13 KB |
|                                  Query&lt;T&gt; | InsightBenchmarkWrite |   162.9 μs |  70.06 μs |  36.82 μs |   112.4 μs |   477.2 μs | 6,137.9 |     15 KB |
|                                    Single | InsightBenchmarkWrite |   163.3 μs |  38.45 μs |  20.21 μs |   108.5 μs |   279.3 μs | 6,124.4 |     15 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   163.3 μs |  39.76 μs |  20.63 μs |   113.1 μs |   249.1 μs | 6,124.0 |     13 KB |
|                        &#39;Single Procedure&#39; |      InsightBenchmark |   164.3 μs |  31.04 μs |  16.31 μs |   110.8 μs |   255.6 μs | 6,087.7 |     14 KB |
|                                    Single |      InsightBenchmark |   164.7 μs |  50.79 μs |  26.69 μs |   106.0 μs |   319.9 μs | 6,070.1 |     15 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; | InsightBenchmarkWrite |   164.8 μs |  26.31 μs |  13.49 μs |   113.3 μs |   203.4 μs | 6,069.5 |     12 KB |
|                            Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |   166.2 μs |  35.13 μs |  17.80 μs |   119.0 μs |   234.1 μs | 6,016.1 |     15 KB |
|                            Query&lt;(Tuple)&gt; |      InsightBenchmark |   167.4 μs |  35.01 μs |  18.17 μs |   120.8 μs |   233.6 μs | 5,973.0 |     15 KB |
|                   &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |   169.5 μs |  24.32 μs |  12.32 μs |   105.0 μs |   211.1 μs | 5,900.4 |     13 KB |
|                                  Query&lt;T&gt; |      InsightBenchmark |   170.7 μs |  58.32 μs |  29.90 μs |   108.0 μs |   349.8 μs | 5,859.0 |     15 KB |
|                   &#39;Auto Interface Single&#39; |      InsightBenchmark |   171.3 μs |  43.92 μs |  22.80 μs |   110.0 μs |   239.3 μs | 5,837.2 |     15 KB |
|                    &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |   171.4 μs |  60.63 μs |  31.87 μs |   109.2 μs |   372.9 μs | 5,835.9 |     15 KB |
|                   &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |   173.5 μs |  67.71 μs |  35.59 μs |   107.8 μs |   427.4 μs | 5,763.1 |     15 KB |
|                          &#39;Single (Tuple)&#39; |      InsightBenchmark |   175.2 μs |  27.69 μs |  14.37 μs |   127.8 μs |   227.6 μs | 5,708.3 |     15 KB |
|              &#39;Single Procedure (dynamic)&#39; |      InsightBenchmark |   177.6 μs |  49.40 μs |  25.64 μs |   112.6 μs |   361.7 μs | 5,629.9 |     12 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; | InsightBenchmarkWrite |   178.5 μs |  63.10 μs |  31.60 μs |   115.9 μs |   415.5 μs | 5,601.5 |     12 KB |
|                    &#39;Auto Interface Query&#39; |      InsightBenchmark |   179.6 μs |  41.70 μs |  20.88 μs |   113.7 μs |   257.9 μs | 5,568.3 |     15 KB |
|                   &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   187.9 μs |  48.19 μs |  25.66 μs |   103.3 μs |   284.1 μs | 5,322.6 |     13 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |   188.8 μs |  46.84 μs |  25.27 μs |   132.2 μs |   358.9 μs | 5,295.6 |     17 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |   189.1 μs |  41.92 μs |  21.76 μs |   128.1 μs |   293.7 μs | 5,289.0 |     16 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   191.2 μs |  38.56 μs |  19.77 μs |   134.9 μs |   324.1 μs | 5,231.4 |     15 KB |
|                             &#39;Single json&#39; |  InsightBenchmarkJson |   194.5 μs |  37.23 μs |  19.82 μs |   137.1 μs |   293.9 μs | 5,140.8 |     46 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   196.0 μs |  51.80 μs |  26.89 μs |   152.1 μs |   386.3 μs | 5,101.8 |     16 KB |
|             &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |   198.9 μs |  31.59 μs |  16.20 μs |   142.1 μs |   288.6 μs | 5,026.8 |     15 KB |
|        &#39;Single Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   200.4 μs |  41.79 μs |  21.96 μs |   141.9 μs |   326.2 μs | 4,989.4 |     15 KB |
|                  &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   203.1 μs |  45.38 μs |  23.85 μs |   133.5 μs |   298.4 μs | 4,924.8 |     15 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   203.1 μs |  73.52 μs |  38.64 μs |   131.6 μs |   531.9 μs | 4,923.0 |     16 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |      InsightBenchmark |   205.7 μs |  53.92 μs |  27.32 μs |   132.6 μs |   348.9 μs | 4,860.7 |     15 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; | InsightBenchmarkWrite |   206.7 μs |  53.02 μs |  27.86 μs |   142.2 μs |   464.6 μs | 4,838.0 |     15 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |   213.8 μs |  44.85 μs |  22.99 μs |   159.3 μs |   350.6 μs | 4,676.8 |     18 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   214.3 μs |  37.82 μs |  20.13 μs |   163.6 μs |   324.0 μs | 4,667.2 |     18 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |      InsightBenchmark |   217.0 μs |  63.56 μs |  32.99 μs |   142.4 μs |   458.9 μs | 4,608.5 |     15 KB |
|                  &#39;Single Procedure Async&#39; | InsightBenchmarkWrite |   218.0 μs |  49.48 μs |  25.37 μs |   140.6 μs |   400.9 μs | 4,587.2 |     17 KB |
|             &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |   219.6 μs |  64.96 μs |  33.31 μs |   130.3 μs |   437.3 μs | 4,554.7 |     15 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |   220.0 μs |  49.45 μs |  25.67 μs |   142.6 μs |   374.6 μs | 4,544.5 |     16 KB |
|                  &#39;Single Async (dynamic)&#39; |      InsightBenchmark |   220.8 μs |  36.01 μs |  18.69 μs |   165.5 μs |   314.8 μs | 4,528.3 |     15 KB |
|                    &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |   221.6 μs |  45.30 μs |  23.81 μs |   160.8 μs |   363.8 μs | 4,513.2 |     18 KB |
|                           &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson |   227.1 μs |  76.15 μs |  38.58 μs |   142.7 μs |   549.1 μs | 4,403.8 |     46 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; | InsightBenchmarkWrite |   231.9 μs |  56.11 μs |  29.87 μs |   156.1 μs |   437.6 μs | 4,312.8 |     15 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |      InsightBenchmark |   235.3 μs |  54.18 μs |  27.45 μs |   164.3 μs |   401.9 μs | 4,249.5 |     17 KB |
|                          &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   239.1 μs |  73.11 μs |  38.43 μs |   138.4 μs |   571.4 μs | 4,183.0 |     18 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |      InsightBenchmark |   241.4 μs | 132.65 μs |  68.85 μs |   127.2 μs |   808.1 μs | 4,143.1 |     15 KB |
|                       &#39;Single Async json&#39; |  InsightBenchmarkJson |   245.0 μs |  46.16 μs |  23.11 μs |   178.9 μs |   330.6 μs | 4,081.4 |     49 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; | InsightBenchmarkWrite |   245.7 μs | 101.75 μs |  51.55 μs |   152.2 μs |   619.5 μs | 4,069.7 |     17 KB |
|                            &#39;Single Async&#39; | InsightBenchmarkWrite |   252.6 μs | 100.22 μs |  52.02 μs |   146.0 μs |   642.7 μs | 3,958.6 |     17 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   254.4 μs |  73.29 μs |  38.52 μs |   143.2 μs |   476.6 μs | 3,930.6 |     18 KB |
|                    &#39;Single Async (Tuple)&#39; |      InsightBenchmark |   257.8 μs |  54.33 μs |  28.20 μs |   160.3 μs |   419.5 μs | 3,878.7 |     18 KB |
|                     &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson |   276.9 μs |  52.84 μs |  26.46 μs |   183.1 μs |   387.1 μs | 3,610.8 |     49 KB |
|                            &#39;Query&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   290.4 μs |  38.42 μs |  19.70 μs |   231.1 μs |   372.4 μs | 3,443.2 |     68 KB |
|                  &#39;Single Procedure Async&#39; |      InsightBenchmark |   295.3 μs | 120.81 μs |  62.71 μs |   196.2 μs |   814.5 μs | 3,386.5 |     17 KB |
|                            &#39;Single Async&#39; |      InsightBenchmark |   296.5 μs | 111.45 μs |  58.58 μs |   150.1 μs |   582.9 μs | 3,372.6 |     17 KB |
|                              &#39;Single xml&#39; |   InsightBenchmarkXml |   311.9 μs | 181.24 μs |  94.07 μs |   222.7 μs | 1,268.5 μs | 3,206.5 |     68 KB |
|                      &#39;Query&lt;T&gt; Async xml&#39; |   InsightBenchmarkXml |   350.7 μs |  47.12 μs |  25.08 μs |   273.4 μs |   458.9 μs | 2,851.7 |     71 KB |
|                        &#39;Single Async xml&#39; |   InsightBenchmarkXml |   359.7 μs |  45.20 μs |  23.17 μs |   287.6 μs |   450.4 μs | 2,780.1 |     70 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 5,333.4 μs | 139.33 μs |  71.44 μs | 5,086.4 μs | 5,681.9 μs |   187.5 |     37 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 5,458.0 μs | 169.79 μs |  86.01 μs | 5,101.7 μs | 5,807.8 μs |   183.2 |     37 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 5,545.7 μs | 201.88 μs | 102.28 μs | 5,289.6 μs | 6,166.1 μs |   180.3 |     35 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 5,668.6 μs | 189.46 μs |  97.14 μs | 5,428.2 μs | 6,125.5 μs |   176.4 |     35 KB |
|                                           |                       |            |           |           |            |            |         |           |
|                         &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   321.6 μs |  49.47 μs |  25.06 μs |   264.2 μs |   451.5 μs | 3,109.4 |     10 KB |
|                                 Update&lt;T&gt; | InsightBenchmarkWrite |   359.0 μs |  44.81 μs |  23.26 μs |   276.2 μs |   470.0 μs | 2,785.4 |     18 KB |
|                                 Insert&lt;T&gt; | InsightBenchmarkWrite |   371.2 μs |  81.05 μs |  41.56 μs |   243.4 μs |   534.9 μs | 2,693.8 |      7 KB |
|                          &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson |   386.5 μs |  59.17 μs |  29.98 μs |   275.7 μs |   555.8 μs | 2,587.5 |      7 KB |
|                          &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson |   391.8 μs |  74.67 μs |  37.83 μs |   301.7 μs |   549.0 μs | 2,552.1 |     12 KB |
|                           &#39;Insert&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   403.8 μs |  49.42 μs |  25.97 μs |   325.0 μs |   514.4 μs | 2,476.2 |      7 KB |
|                         &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |   422.6 μs |  96.20 μs |  49.93 μs |   292.2 μs |   782.7 μs | 2,366.3 |     20 KB |
|                           &#39;Update&lt;T&gt; xml&#39; |   InsightBenchmarkXml |   456.4 μs |  97.14 μs |  49.21 μs |   340.3 μs |   795.1 μs | 2,191.1 |     12 KB |
