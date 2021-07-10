# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) but using Sqlite as a database 

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1083 (20H2/October2020Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.301
  [Host]   : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  ShortRun : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                            Method |                  Type |        Mean |       StdDev |       Error |        Min |         Max |     Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |------------:|-------------:|------------:|-----------:|------------:|---------:|------:|------:|------:|----------:|
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |    433.7 μs |     55.62 μs |    30.01 μs |   371.2 μs |    684.8 μs | 2,305.59 |     - |     - |     - |      9 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |    443.6 μs |     55.40 μs |    30.72 μs |   371.9 μs |    674.4 μs | 2,254.25 |     - |     - |     - |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |    446.9 μs |     68.56 μs |    35.58 μs |   371.6 μs |    632.9 μs | 2,237.60 |     - |     - |     - |      9 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |    448.3 μs |     64.57 μs |    33.51 μs |   352.3 μs |    672.3 μs | 2,230.82 |     - |     - |     - |      9 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |    449.5 μs |     65.47 μs |    34.86 μs |   366.0 μs |    641.9 μs | 2,224.73 |     - |     - |     - |      9 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |    459.8 μs |     89.12 μs |    46.25 μs |   367.2 μs |    723.9 μs | 2,174.98 |     - |     - |     - |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |    461.5 μs |     87.15 μs |    45.81 μs |   378.6 μs |    860.9 μs | 2,166.85 |     - |     - |     - |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |    462.3 μs |     69.01 μs |    36.74 μs |   347.9 μs |    654.5 μs | 2,163.29 |     - |     - |     - |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |    463.3 μs |     82.95 μs |    42.02 μs |   380.4 μs |    735.0 μs | 2,158.37 |     - |     - |     - |     10 KB |
|                            Single |      InsightBenchmark |    464.3 μs |     79.61 μs |    40.82 μs |   367.2 μs |    703.5 μs | 2,153.71 |     - |     - |     - |      9 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |    466.3 μs |     84.82 μs |    44.02 μs |   370.5 μs |    687.8 μs | 2,144.52 |     - |     - |     - |      9 KB |
|                            Single | InsightBenchmarkWrite |    471.6 μs |    115.89 μs |    60.15 μs |   369.9 μs |    776.2 μs | 2,120.43 |     - |     - |     - |      9 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |    472.2 μs |     88.06 μs |    46.28 μs |   389.6 μs |    823.6 μs | 2,117.68 |     - |     - |     - |     10 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |    474.2 μs |     70.20 μs |    35.56 μs |   369.9 μs |    719.5 μs | 2,108.81 |     - |     - |     - |     10 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |    476.7 μs |    103.69 μs |    54.50 μs |   367.7 μs |    806.8 μs | 2,097.70 |     - |     - |     - |      9 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |    478.0 μs |     80.96 μs |    41.51 μs |   387.8 μs |    754.6 μs | 2,092.03 |     - |     - |     - |      9 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |    480.8 μs |     99.54 μs |    51.03 μs |   377.9 μs |    879.5 μs | 2,079.75 |     - |     - |     - |     10 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |    485.2 μs |     80.51 μs |    41.28 μs |   380.4 μs |    672.5 μs | 2,060.88 |     - |     - |     - |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |    486.0 μs |     98.88 μs |    51.32 μs |   359.6 μs |    800.8 μs | 2,057.66 |     - |     - |     - |     10 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |    487.0 μs |     94.80 μs |    47.47 μs |   380.9 μs |    731.0 μs | 2,053.46 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    487.2 μs |     84.32 μs |    44.89 μs |   406.3 μs |    806.7 μs | 2,052.64 |     - |     - |     - |     11 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |    488.0 μs |     90.54 μs |    48.21 μs |   403.9 μs |    804.8 μs | 2,049.08 |     - |     - |     - |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |    489.4 μs |     88.66 μs |    44.92 μs |   385.2 μs |    767.4 μs | 2,043.27 |     - |     - |     - |     10 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |    491.0 μs |     94.33 μs |    50.22 μs |   371.3 μs |    756.5 μs | 2,036.55 |     - |     - |     - |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |    493.5 μs |    102.71 μs |    52.03 μs |   372.6 μs |    821.3 μs | 2,026.49 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    496.0 μs |     68.44 μs |    36.93 μs |   421.8 μs |    735.2 μs | 2,016.31 |     - |     - |     - |     11 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |    500.0 μs |     91.83 μs |    46.52 μs |   375.5 μs |    708.3 μs | 1,999.99 |     - |     - |     - |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |    507.3 μs |     82.56 μs |    42.85 μs |   383.5 μs |    751.2 μs | 1,971.30 |     - |     - |     - |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |    509.6 μs |     97.61 μs |    48.87 μs |   386.4 μs |    814.8 μs | 1,962.35 |     - |     - |     - |      9 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |    511.0 μs |    106.67 μs |    55.37 μs |   367.1 μs |    784.6 μs | 1,956.86 |     - |     - |     - |     10 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |    519.1 μs |    113.37 μs |    59.59 μs |   367.9 μs |    847.6 μs | 1,926.57 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    532.0 μs |     68.69 μs |    35.65 μs |   433.2 μs |    702.9 μs | 1,879.74 |     - |     - |     - |     11 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |    534.5 μs |    114.77 μs |    58.84 μs |   365.9 μs |    779.0 μs | 1,870.81 |     - |     - |     - |      9 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |    550.1 μs |    125.88 μs |    64.54 μs |   390.8 μs |    814.6 μs | 1,817.87 |     - |     - |     - |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |    563.6 μs |    135.60 μs |    69.53 μs |   387.8 μs |    835.3 μs | 1,774.17 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    566.6 μs |    108.00 μs |    56.06 μs |   437.2 μs |    889.6 μs | 1,764.87 |     - |     - |     - |     11 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |    573.5 μs |    121.26 μs |    62.17 μs |   415.9 μs |    840.3 μs | 1,743.61 |     - |     - |     - |     10 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |    574.4 μs |    125.39 μs |    62.07 μs |   372.9 μs |    812.4 μs | 1,741.06 |     - |     - |     - |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |    611.6 μs |    109.98 μs |    55.72 μs |   394.4 μs |    887.6 μs | 1,635.06 |     - |     - |     - |      9 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |    672.7 μs |    115.39 μs |    57.78 μs |   439.4 μs |    923.2 μs | 1,486.53 |     - |     - |     - |     10 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark |  8,991.0 μs |    887.52 μs |   444.40 μs | 7,284.2 μs | 10,694.3 μs |   111.22 |     - |     - |     - |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark |  9,247.2 μs |    932.82 μs |   461.78 μs | 7,873.8 μs | 10,785.3 μs |   108.14 |     - |     - |     - |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite |  9,266.1 μs |  1,116.68 μs |   552.80 μs | 7,403.4 μs | 11,669.7 μs |   107.92 |     - |     - |     - |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite |  9,495.2 μs |  1,019.79 μs |   504.83 μs | 7,753.3 μs | 11,224.0 μs |   105.32 |     - |     - |     - |     24 KB |
|                                   |                       |             |              |             |            |             |          |       |       |       |           |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  8,822.8 μs |  4,072.39 μs | 2,039.14 μs | 4,593.4 μs | 19,330.4 μs |   113.34 |     - |     - |     - |      9 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite |  9,038.5 μs |  4,141.94 μs | 2,176.99 μs | 4,734.0 μs | 25,032.0 μs |   110.64 |     - |     - |     - |      8 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 12,241.7 μs | 11,815.01 μs | 5,916.06 μs | 5,269.0 μs | 44,621.4 μs |    81.69 |     - |     - |     - |      9 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 20,439.6 μs | 14,607.39 μs | 7,581.71 μs | 4,664.2 μs | 46,212.5 μs |    48.92 |     - |     - |     - |      8 KB |
