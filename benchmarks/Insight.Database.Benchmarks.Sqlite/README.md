# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) but using Sqlite as a database 

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1083 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.301
  [Host]   : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  ShortRun : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                            Method |                  Type |        Mean |       StdDev |       Error |         Min |          Max |     Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |---------------------- |------------:|-------------:|------------:|------------:|-------------:|---------:|------:|------:|------:|----------:|
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |    425.2 μs |     37.12 μs |    19.76 μs |    381.1 μs |     560.7 μs | 2,351.88 |     - |     - |     - |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |    431.0 μs |     37.75 μs |    19.84 μs |    372.4 μs |     544.3 μs | 2,320.11 |     - |     - |     - |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |    432.4 μs |     47.76 μs |    25.10 μs |    363.4 μs |     564.9 μs | 2,312.69 |     - |     - |     - |      9 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |    439.1 μs |     34.34 μs |    18.78 μs |    387.8 μs |     536.3 μs | 2,277.22 |     - |     - |     - |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |    439.4 μs |     31.66 μs |    17.81 μs |    402.9 μs |     544.2 μs | 2,275.92 |     - |     - |     - |      9 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |    439.4 μs |     47.13 μs |    25.09 μs |    375.3 μs |     567.2 μs | 2,275.83 |     - |     - |     - |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |    441.1 μs |     57.75 μs |    31.15 μs |    388.4 μs |     650.0 μs | 2,267.11 |     - |     - |     - |      9 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |    442.4 μs |     50.51 μs |    27.25 μs |    379.1 μs |     591.1 μs | 2,260.42 |     - |     - |     - |      9 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |    442.6 μs |     34.89 μs |    18.57 μs |    389.4 μs |     539.1 μs | 2,259.17 |     - |     - |     - |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |    443.2 μs |     40.73 μs |    20.88 μs |    392.1 μs |     552.0 μs | 2,256.34 |     - |     - |     - |     10 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |    443.7 μs |     52.36 μs |    27.52 μs |    376.4 μs |     645.5 μs | 2,253.65 |     - |     - |     - |      9 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |    445.8 μs |     59.84 μs |    31.45 μs |    353.8 μs |     582.9 μs | 2,242.92 |     - |     - |     - |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |    446.3 μs |     60.36 μs |    31.73 μs |    359.6 μs |     632.1 μs | 2,240.51 |     - |     - |     - |      9 KB |
|                            Single |      InsightBenchmark |    447.1 μs |     55.40 μs |    29.50 μs |    389.4 μs |     678.3 μs | 2,236.59 |     - |     - |     - |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |    449.8 μs |     53.04 μs |    28.62 μs |    391.3 μs |     627.4 μs | 2,223.00 |     - |     - |     - |     10 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |    450.0 μs |     50.74 μs |    27.37 μs |    362.2 μs |     589.9 μs | 2,222.10 |     - |     - |     - |     10 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |    450.3 μs |     63.07 μs |    33.58 μs |    393.1 μs |     643.2 μs | 2,220.58 |     - |     - |     - |      9 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |    451.7 μs |     60.21 μs |    32.48 μs |    388.3 μs |     692.1 μs | 2,213.97 |     - |     - |     - |     10 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |    454.1 μs |     70.94 μs |    38.27 μs |    375.4 μs |     633.0 μs | 2,202.32 |     - |     - |     - |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |    454.3 μs |     70.57 μs |    37.09 μs |    393.4 μs |     675.0 μs | 2,201.09 |     - |     - |     - |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |    455.5 μs |     90.35 μs |    46.89 μs |    357.1 μs |     765.9 μs | 2,195.24 |     - |     - |     - |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |    455.9 μs |     79.52 μs |    42.33 μs |    354.2 μs |     803.7 μs | 2,193.44 |     - |     - |     - |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |    457.0 μs |     51.74 μs |    28.30 μs |    391.0 μs |     664.1 μs | 2,188.31 |     - |     - |     - |     10 KB |
|                            Single | InsightBenchmarkWrite |    466.8 μs |     85.24 μs |    45.38 μs |    380.6 μs |     760.2 μs | 2,142.10 |     - |     - |     - |      9 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |    468.0 μs |     81.36 μs |    42.23 μs |    363.8 μs |     763.9 μs | 2,136.93 |     - |     - |     - |     10 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |    469.1 μs |     54.88 μs |    29.61 μs |    409.3 μs |     642.0 μs | 2,131.82 |     - |     - |     - |     10 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |    469.3 μs |     66.62 μs |    35.47 μs |    399.9 μs |     632.0 μs | 2,130.77 |     - |     - |     - |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |    472.7 μs |     66.18 μs |    34.35 μs |    403.1 μs |     674.4 μs | 2,115.38 |     - |     - |     - |     10 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |    472.8 μs |     55.95 μs |    29.41 μs |    410.8 μs |     645.8 μs | 2,115.15 |     - |     - |     - |     10 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |    482.6 μs |     78.23 μs |    41.65 μs |    405.8 μs |     786.4 μs | 2,072.27 |     - |     - |     - |     10 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |    485.4 μs |     72.43 μs |    38.56 μs |    401.9 μs |     692.4 μs | 2,060.34 |     - |     - |     - |     10 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |    486.5 μs |     72.79 μs |    38.26 μs |    418.6 μs |     787.8 μs | 2,055.35 |     - |     - |     - |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |    488.2 μs |     90.71 μs |    47.08 μs |    392.5 μs |     763.0 μs | 2,048.13 |     - |     - |     - |     10 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |    489.0 μs |     71.67 μs |    36.75 μs |    384.7 μs |     660.1 μs | 2,044.90 |     - |     - |     - |      9 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    496.2 μs |     50.50 μs |    27.62 μs |    440.7 μs |     705.5 μs | 2,015.49 |     - |     - |     - |     11 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |    499.8 μs |    100.30 μs |    50.81 μs |    380.9 μs |     773.2 μs | 2,000.75 |     - |     - |     - |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    508.7 μs |     72.28 μs |    38.99 μs |    432.9 μs |     786.6 μs | 1,965.86 |     - |     - |     - |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    517.2 μs |     93.27 μs |    47.82 μs |    439.8 μs |     787.7 μs | 1,933.54 |     - |     - |     - |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    541.1 μs |    114.00 μs |    59.92 μs |    428.3 μs |     872.5 μs | 1,848.20 |     - |     - |     - |     11 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |    547.1 μs |     78.87 μs |    40.94 μs |    448.0 μs |     763.4 μs | 1,827.73 |     - |     - |     - |     10 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 68,107.7 μs |  2,020.85 μs | 1,036.11 μs | 64,946.7 μs |  74,470.9 μs |    14.68 |     - |     - |     - |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 68,133.6 μs |  3,160.39 μs | 1,682.63 μs | 63,861.3 μs |  80,014.8 μs |    14.68 |     - |     - |     - |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 80,674.6 μs |  7,455.20 μs | 3,733.00 μs | 67,229.1 μs |  95,552.6 μs |    12.40 |     - |     - |     - |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 82,237.1 μs |  7,296.78 μs | 3,696.63 μs | 71,705.8 μs | 100,249.3 μs |    12.16 |     - |     - |     - |     24 KB |
|                                   |                       |             |              |             |             |              |          |       |       |       |           |
|                         Update&lt;T&gt; | InsightBenchmarkWrite |  9,638.0 μs |  6,219.67 μs | 3,188.88 μs |  3,931.4 μs |  28,991.3 μs |   103.76 |     - |     - |     - |      8 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 10,179.2 μs |  5,989.23 μs | 2,964.90 μs |  4,016.2 μs |  29,207.7 μs |    98.24 |     - |     - |     - |      9 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 29,563.0 μs | 16,187.79 μs | 8,013.56 μs |  4,153.9 μs |  53,866.8 μs |    33.83 |     - |     - |     - |      8 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 31,331.5 μs | 19,762.82 μs | 9,895.72 μs |  4,994.4 μs |  69,811.6 μs |    31.92 |     - |     - |     - |      9 KB |
