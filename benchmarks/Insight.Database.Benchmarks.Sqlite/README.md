# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) but using Sqlite as a database 

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1202 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.400
  [Host]   : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  ShortRun : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|                            Method |                  Type |        Mean |       StdDev |       Error |         Min |         Max |     Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |------------:|-------------:|------------:|------------:|------------:|---------:|------:|------:|------:|----------:|
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |    456.8 μs |     53.83 μs |    28.29 μs |    388.7 μs |    648.8 μs | 2,189.37 |     - |     - |     - |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |    457.6 μs |     35.97 μs |    19.95 μs |    405.1 μs |    562.8 μs | 2,185.28 |     - |     - |     - |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |    458.2 μs |     56.70 μs |    31.01 μs |    402.5 μs |    712.5 μs | 2,182.29 |     - |     - |     - |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |    464.6 μs |     53.20 μs |    28.32 μs |    398.4 μs |    650.6 μs | 2,152.21 |     - |     - |     - |     10 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |    468.6 μs |     67.38 μs |    35.41 μs |    385.2 μs |    655.8 μs | 2,134.23 |     - |     - |     - |      9 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |    469.1 μs |     64.46 μs |    34.32 μs |    402.1 μs |    650.4 μs | 2,131.87 |     - |     - |     - |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |    473.0 μs |     80.04 μs |    42.62 μs |    389.4 μs |    687.2 μs | 2,114.05 |     - |     - |     - |      9 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |    474.9 μs |     64.09 μs |    33.69 μs |    390.5 μs |    690.5 μs | 2,105.87 |     - |     - |     - |      9 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |    475.0 μs |     83.57 μs |    43.92 μs |    387.8 μs |    796.1 μs | 2,105.29 |     - |     - |     - |     10 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |    475.4 μs |     83.02 μs |    43.09 μs |    395.4 μs |    707.6 μs | 2,103.56 |     - |     - |     - |      9 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |    476.8 μs |     54.24 μs |    28.88 μs |    411.4 μs |    736.2 μs | 2,097.13 |     - |     - |     - |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |    477.8 μs |     64.14 μs |    32.89 μs |    375.4 μs |    624.3 μs | 2,092.80 |     - |     - |     - |      9 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |    478.5 μs |     84.70 μs |    46.32 μs |    383.7 μs |    764.5 μs | 2,089.75 |     - |     - |     - |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |    479.6 μs |     88.43 μs |    45.34 μs |    378.4 μs |    763.6 μs | 2,085.06 |     - |     - |     - |      9 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |    483.0 μs |     80.50 μs |    42.86 μs |    403.4 μs |    733.9 μs | 2,070.29 |     - |     - |     - |      9 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |    483.4 μs |     80.71 μs |    42.42 μs |    393.9 μs |    733.3 μs | 2,068.50 |     - |     - |     - |     10 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |    483.6 μs |     59.51 μs |    31.69 μs |    407.5 μs |    719.8 μs | 2,067.98 |     - |     - |     - |     10 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |    484.8 μs |    106.61 μs |    54.66 μs |    402.1 μs |    879.9 μs | 2,062.88 |     - |     - |     - |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |    485.9 μs |    100.55 μs |    52.19 μs |    382.5 μs |    774.6 μs | 2,057.97 |     - |     - |     - |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |    485.9 μs |     93.18 μs |    47.78 μs |    384.9 μs |    843.3 μs | 2,057.85 |     - |     - |     - |     10 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |    486.0 μs |     52.80 μs |    27.75 μs |    417.7 μs |    639.8 μs | 2,057.56 |     - |     - |     - |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |    486.0 μs |     78.69 μs |    41.36 μs |    404.2 μs |    769.0 μs | 2,057.49 |     - |     - |     - |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |    487.0 μs |     68.70 μs |    36.57 μs |    399.6 μs |    758.0 μs | 2,053.19 |     - |     - |     - |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |    488.2 μs |     86.44 μs |    46.02 μs |    381.2 μs |    765.5 μs | 2,048.35 |     - |     - |     - |      9 KB |
|                            Single | InsightBenchmarkWrite |    488.8 μs |    121.43 μs |    64.65 μs |    368.8 μs |    931.2 μs | 2,045.71 |     - |     - |     - |      9 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |    489.1 μs |     73.10 μs |    39.44 μs |    387.0 μs |    673.7 μs | 2,044.58 |     - |     - |     - |      9 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |    489.5 μs |    109.18 μs |    58.13 μs |    393.3 μs |    927.3 μs | 2,042.72 |     - |     - |     - |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |    494.1 μs |     86.79 μs |    45.61 μs |    387.2 μs |    777.1 μs | 2,024.07 |     - |     - |     - |     10 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |    500.7 μs |     90.11 μs |    47.98 μs |    395.9 μs |    773.8 μs | 1,997.01 |     - |     - |     - |     10 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |    501.8 μs |     69.36 μs |    36.93 μs |    422.2 μs |    742.2 μs | 1,993.01 |     - |     - |     - |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |    503.1 μs |     81.34 μs |    40.73 μs |    387.2 μs |    670.4 μs | 1,987.85 |     - |     - |     - |     10 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |    503.2 μs |     77.68 μs |    39.35 μs |    407.9 μs |    714.4 μs | 1,987.40 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    507.3 μs |     47.55 μs |    26.37 μs |    438.3 μs |    659.9 μs | 1,971.26 |     - |     - |     - |     11 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |    509.4 μs |    100.71 μs |    52.93 μs |    399.7 μs |    870.6 μs | 1,962.99 |     - |     - |     - |     10 KB |
|                            Single |      InsightBenchmark |    511.5 μs |    149.12 μs |    75.55 μs |    393.4 μs |  1,005.3 μs | 1,955.09 |     - |     - |     - |      9 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |    517.5 μs |     84.91 μs |    44.07 μs |    416.6 μs |    852.5 μs | 1,932.31 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    523.6 μs |     98.12 μs |    52.24 μs |    434.9 μs |    873.1 μs | 1,909.82 |     - |     - |     - |     11 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |    534.1 μs |    111.61 μs |    57.23 μs |    390.6 μs |    791.4 μs | 1,872.14 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    546.0 μs |     91.75 μs |    48.22 μs |    424.2 μs |    797.5 μs | 1,831.61 |     - |     - |     - |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    547.0 μs |     83.72 μs |    44.00 μs |    438.6 μs |    800.8 μs | 1,828.21 |     - |     - |     - |     11 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 82,481.4 μs |  1,466.04 μs |   742.71 μs | 80,041.4 μs | 86,592.7 μs |    12.12 |     - |     - |     - |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 82,532.5 μs |  2,678.25 μs | 1,390.10 μs | 78,815.9 μs | 92,010.6 μs |    12.12 |     - |     - |     - |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 83,140.5 μs |  1,441.75 μs |   757.78 μs | 80,569.2 μs | 86,894.7 μs |    12.03 |     - |     - |     - |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 84,378.5 μs |  2,224.57 μs | 1,126.99 μs | 80,815.1 μs | 90,278.2 μs |    11.85 |     - |     - |     - |     24 KB |
|                                   |                       |             |              |             |             |             |          |       |       |       |           |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  5,411.5 μs |    555.18 μs |   284.64 μs |  4,573.8 μs |  6,640.8 μs |   184.79 |     - |     - |     - |      9 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite |  5,691.0 μs |  1,282.57 μs |   674.11 μs |  4,738.6 μs | 12,184.8 μs |   175.72 |     - |     - |     - |      8 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite |  7,917.8 μs |  5,814.52 μs | 3,056.08 μs |  4,926.7 μs | 40,566.2 μs |   126.30 |     - |     - |     - |      8 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  9,411.4 μs | 10,343.52 μs | 5,368.63 μs |  5,529.9 μs | 52,856.1 μs |   106.25 |     - |     - |     - |      9 KB |
