# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) but using Sqlite as a database 

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100
  [Host]   : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  ShortRun : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |                  Type |        Mean |      StdDev |       Error |         Min |          Max |     Op/s | Allocated |
|---------------------------------- |---------------------- |------------:|------------:|------------:|------------:|-------------:|---------:|----------:|
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite |    474.2 μs |    37.21 μs |    20.08 μs |    405.6 μs |     573.2 μs | 2,108.68 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite |    477.5 μs |    36.04 μs |    19.98 μs |    412.9 μs |     568.8 μs | 2,094.33 |     10 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |    478.1 μs |    44.87 μs |    24.20 μs |    415.3 μs |     642.0 μs | 2,091.81 |     10 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite |    479.0 μs |    65.08 μs |    34.65 μs |    424.5 μs |     762.5 μs | 2,087.88 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |    485.2 μs |    54.02 μs |    29.14 μs |    419.6 μs |     682.5 μs | 2,060.99 |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |    490.0 μs |    69.97 μs |    37.25 μs |    412.2 μs |     767.5 μs | 2,040.78 |     10 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark |    493.9 μs |    61.93 μs |    32.97 μs |    420.2 μs |     742.4 μs | 2,024.52 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |    497.8 μs |    79.49 μs |    41.78 μs |    408.1 μs |     767.1 μs | 2,008.99 |     10 KB |
|                            Single | InsightBenchmarkWrite |    501.4 μs |    57.76 μs |    30.36 μs |    427.1 μs |     673.3 μs | 1,994.37 |     10 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite |    502.2 μs |    70.10 μs |    37.32 μs |    431.9 μs |     763.4 μs | 1,991.23 |     10 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark |    503.5 μs |    61.24 μs |    32.19 μs |    430.3 μs |     745.1 μs | 1,986.05 |     10 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |    506.1 μs |   116.38 μs |    61.17 μs |    423.1 μs |     861.9 μs | 1,976.02 |     10 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |    508.7 μs |   116.28 μs |    59.62 μs |    398.9 μs |     821.4 μs | 1,965.86 |     10 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite |    508.9 μs |    60.95 μs |    33.33 μs |    433.4 μs |     764.2 μs | 1,964.94 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite |    509.9 μs |    70.70 μs |    38.14 μs |    435.3 μs |     755.0 μs | 1,961.08 |     10 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark |    511.4 μs |    72.49 μs |    38.60 μs |    408.7 μs |     661.8 μs | 1,955.40 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark |    511.7 μs |    66.70 μs |    36.48 μs |    440.9 μs |     715.0 μs | 1,954.14 |     10 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite |    519.6 μs |    97.72 μs |    50.72 μs |    406.4 μs |     777.4 μs | 1,924.68 |     10 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark |    520.8 μs |   113.47 μs |    59.64 μs |    428.0 μs |   1,052.2 μs | 1,920.07 |     10 KB |
|                          Query&lt;T&gt; |      InsightBenchmark |    521.0 μs |    94.06 μs |    49.44 μs |    405.8 μs |     771.8 μs | 1,919.30 |     10 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |    524.5 μs |   119.52 μs |    62.82 μs |    409.1 μs |   1,037.2 μs | 1,906.73 |     10 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite |    525.7 μs |    80.95 μs |    43.10 μs |    432.1 μs |     774.9 μs | 1,902.21 |      9 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark |    527.1 μs |   106.62 μs |    55.34 μs |    436.2 μs |     903.8 μs | 1,897.30 |     10 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite |    527.9 μs |   106.76 μs |    56.12 μs |    433.4 μs |     908.7 μs | 1,894.13 |     10 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |    533.7 μs |    78.85 μs |    41.98 μs |    448.4 μs |     752.2 μs | 1,873.82 |     10 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark |    533.9 μs |    71.54 μs |    37.13 μs |    451.5 μs |     725.2 μs | 1,872.93 |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    542.1 μs |    62.67 μs |    33.81 μs |    477.3 μs |     818.6 μs | 1,844.58 |     11 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark |    562.0 μs |   108.78 μs |    55.77 μs |    422.1 μs |     735.9 μs | 1,779.25 |     10 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark |    564.8 μs |   144.99 μs |    78.22 μs |    439.5 μs |   1,021.0 μs | 1,770.55 |     10 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark |    565.2 μs |   129.47 μs |    67.20 μs |    432.2 μs |   1,064.5 μs | 1,769.23 |     11 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite |    565.8 μs |    74.10 μs |    39.45 μs |    457.9 μs |     749.5 μs | 1,767.47 |     11 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite |    566.5 μs |    95.22 μs |    48.24 μs |    442.4 μs |     852.1 μs | 1,765.36 |     11 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite |    569.4 μs |    78.50 μs |    41.80 μs |    474.4 μs |     758.3 μs | 1,756.24 |     11 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    573.9 μs |   112.87 μs |    59.32 μs |    476.0 μs |     984.0 μs | 1,742.34 |     11 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark |    577.7 μs |   126.14 μs |    65.47 μs |    428.1 μs |     850.4 μs | 1,731.00 |     10 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark |    584.2 μs |   110.43 μs |    58.79 μs |    438.5 μs |     789.4 μs | 1,711.60 |     10 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark |    617.0 μs |   104.83 μs |    53.75 μs |    503.1 μs |     899.8 μs | 1,620.73 |     11 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark |    618.9 μs |   144.99 μs |    74.34 μs |    430.9 μs |     924.6 μs | 1,615.80 |     10 KB |
|                            Single |      InsightBenchmark |    624.9 μs |   114.76 μs |    58.84 μs |    425.1 μs |     837.5 μs | 1,600.24 |     10 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |    658.2 μs |   150.66 μs |    75.44 μs |    409.6 μs |   1,035.3 μs | 1,519.30 |     10 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 78,024.6 μs | 2,707.79 μs | 1,423.20 μs | 73,864.3 μs |  89,493.9 μs |    12.82 |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 79,469.6 μs | 5,063.33 μs | 2,628.03 μs | 74,153.6 μs |  95,412.9 μs |    12.58 |     24 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 82,776.6 μs | 2,811.68 μs | 1,477.81 μs | 78,606.5 μs |  89,619.3 μs |    12.08 |     24 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 83,238.0 μs | 5,313.82 μs | 2,692.04 μs | 74,306.7 μs | 101,572.3 μs |    12.01 |     24 KB |
|                                   |                       |             |             |             |             |              |          |           |
|                         Update&lt;T&gt; | InsightBenchmarkWrite |  5,292.9 μs |   535.21 μs |   271.14 μs |  4,235.5 μs |   6,367.1 μs |   188.93 |      9 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  5,294.0 μs |   595.76 μs |   309.22 μs |  4,319.1 μs |   7,148.9 μs |   188.89 |     10 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite |  6,534.8 μs |   868.10 μs |   468.34 μs |  5,246.3 μs |   8,809.9 μs |   153.03 |      9 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite |  6,813.2 μs | 2,200.64 μs | 1,142.21 μs |  4,689.1 μs |  16,994.5 μs |   146.77 |      8 KB |
