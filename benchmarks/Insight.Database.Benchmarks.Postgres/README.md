# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database)

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]   : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  ShortRun : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT


```
|                            Method |                  Type |       Mean |   StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|---------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite |   963.7 μs | 141.2 μs |  70.68 μs |   960.5 μs |   720.4 μs | 1,253.0 μs | 1,037.7 |      9 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite |   999.2 μs | 144.3 μs |  72.24 μs | 1,007.5 μs |   789.0 μs | 1,344.3 μs | 1,000.8 |      9 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 1,005.1 μs | 151.3 μs |  78.53 μs | 1,004.5 μs |   747.6 μs | 1,293.3 μs |   994.9 |     14 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1,008.9 μs | 145.6 μs |  75.57 μs |   992.3 μs |   784.6 μs | 1,260.5 μs |   991.2 |     14 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,011.6 μs | 154.7 μs |  78.38 μs |   987.2 μs |   724.6 μs | 1,371.8 μs |   988.5 |     11 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1,019.0 μs | 118.3 μs |  59.25 μs | 1,027.2 μs |   842.9 μs | 1,351.2 μs |   981.3 |      9 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1,026.2 μs | 120.2 μs |  60.20 μs | 1,034.0 μs |   810.0 μs | 1,311.9 μs |   974.5 |     11 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1,039.2 μs | 156.3 μs |  77.39 μs | 1,037.8 μs |   770.1 μs | 1,341.2 μs |   962.2 |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,053.9 μs | 148.1 μs |  74.16 μs | 1,052.1 μs |   777.5 μs | 1,410.2 μs |   948.9 |     11 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 1,082.7 μs | 164.5 μs |  81.46 μs | 1,084.2 μs |   784.3 μs | 1,462.4 μs |   923.6 |     14 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1,088.0 μs | 208.7 μs | 104.51 μs | 1,068.4 μs |   785.5 μs | 1,613.2 μs |   919.1 |      9 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1,095.5 μs | 146.3 μs |  72.41 μs | 1,065.9 μs |   831.0 μs | 1,426.5 μs |   912.8 |     14 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1,121.1 μs | 147.0 μs |  73.59 μs | 1,098.7 μs |   831.7 μs | 1,525.0 μs |   892.0 |     11 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1,121.5 μs | 203.1 μs | 100.54 μs | 1,105.5 μs |   789.6 μs | 1,497.6 μs |   891.6 |     11 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1,139.2 μs | 116.2 μs |  59.59 μs | 1,162.3 μs |   905.6 μs | 1,348.2 μs |   877.8 |     15 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 1,140.3 μs | 234.2 μs | 117.29 μs | 1,108.8 μs |   816.6 μs | 1,704.0 μs |   877.0 |     14 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1,164.3 μs | 193.9 μs |  97.08 μs | 1,170.0 μs |   804.3 μs | 1,601.8 μs |   858.9 |     14 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,168.6 μs | 163.8 μs |  83.00 μs | 1,188.8 μs |   854.2 μs | 1,549.8 μs |   855.8 |     15 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1,176.1 μs | 159.0 μs |  78.69 μs | 1,171.2 μs |   896.0 μs | 1,497.0 μs |   850.3 |     14 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,182.0 μs | 265.8 μs | 133.08 μs | 1,200.3 μs |   793.9 μs | 1,910.5 μs |   846.0 |      9 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1,184.0 μs | 180.9 μs |  90.60 μs | 1,218.6 μs |   818.0 μs | 1,560.2 μs |   844.6 |     15 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1,194.7 μs | 160.7 μs |  81.39 μs | 1,191.5 μs |   879.5 μs | 1,707.2 μs |   837.1 |     39 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1,201.2 μs | 192.4 μs |  96.34 μs | 1,199.8 μs |   799.0 μs | 1,501.8 μs |   832.5 |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1,201.5 μs | 194.7 μs |  97.49 μs | 1,210.2 μs |   817.5 μs | 1,654.4 μs |   832.3 |     11 KB |
|                            Single |      InsightBenchmark | 1,230.7 μs | 263.0 μs | 130.19 μs | 1,175.5 μs |   771.3 μs | 1,871.6 μs |   812.5 |     14 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1,234.7 μs | 190.1 μs |  95.19 μs | 1,230.3 μs |   897.0 μs | 1,643.5 μs |   809.9 |     11 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 1,236.5 μs | 182.8 μs |  90.48 μs | 1,210.8 μs |   927.1 μs | 1,661.8 μs |   808.8 |     41 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,261.7 μs | 166.3 μs |  83.25 μs | 1,255.0 μs |   966.0 μs | 1,643.2 μs |   792.6 |     39 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1,294.9 μs | 228.5 μs | 114.43 μs | 1,264.3 μs |   925.7 μs | 1,807.6 μs |   772.3 |     14 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1,301.9 μs | 285.2 μs | 146.21 μs | 1,234.8 μs |   827.2 μs | 1,945.0 μs |   768.1 |      9 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1,307.8 μs | 148.2 μs |  74.21 μs | 1,290.7 μs | 1,038.1 μs | 1,653.0 μs |   764.6 |      9 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1,325.3 μs | 156.7 μs |  78.47 μs | 1,313.2 μs | 1,068.0 μs | 1,609.6 μs |   754.6 |      9 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1,347.8 μs | 315.6 μs | 159.87 μs | 1,269.7 μs |   937.1 μs | 2,262.9 μs |   741.9 |     14 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,347.9 μs | 210.6 μs | 106.70 μs | 1,329.7 μs |   984.8 μs | 1,894.6 μs |   741.9 |     15 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1,348.4 μs | 423.0 μs | 211.83 μs | 1,301.0 μs |   840.0 μs | 2,265.8 μs |   741.6 |      9 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 1,380.8 μs | 217.2 μs | 110.05 μs | 1,411.0 μs |   944.0 μs | 1,841.3 μs |   724.2 |     15 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1,396.1 μs | 129.6 μs |  65.65 μs | 1,403.2 μs | 1,118.2 μs | 1,679.8 μs |   716.3 |     11 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1,398.2 μs | 299.1 μs | 151.52 μs | 1,415.9 μs |   897.2 μs | 2,122.4 μs |   715.2 |      9 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 1,412.0 μs | 136.5 μs |  70.85 μs | 1,407.7 μs | 1,083.8 μs | 1,801.0 μs |   708.2 |     32 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1,428.4 μs | 235.2 μs | 119.17 μs | 1,373.2 μs | 1,056.3 μs | 1,954.2 μs |   700.1 |     41 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1,434.8 μs | 225.4 μs | 111.58 μs | 1,427.6 μs |   963.7 μs | 1,889.5 μs |   696.9 |     14 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 1,438.7 μs | 186.5 μs |  94.50 μs | 1,391.6 μs | 1,150.1 μs | 2,023.6 μs |   695.1 |     15 KB |
|                            Single | InsightBenchmarkWrite | 1,477.1 μs | 234.9 μs | 118.99 μs | 1,558.2 μs |   933.4 μs | 1,835.4 μs |   677.0 |     14 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 1,850.7 μs | 219.7 μs | 110.01 μs | 1,827.3 μs | 1,443.0 μs | 2,462.0 μs |   540.3 |     34 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 1,970.3 μs | 201.5 μs | 100.90 μs | 1,948.8 μs | 1,615.3 μs | 2,495.2 μs |   507.5 |     32 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 2,980.1 μs | 897.6 μs | 454.74 μs | 2,721.3 μs | 2,093.3 μs | 7,060.5 μs |   335.6 |     34 KB |
|                                   |                       |            |          |           |            |            |            |         |           |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2,832.0 μs | 211.0 μs | 108.18 μs | 2,807.9 μs | 2,427.9 μs | 3,358.2 μs |   353.1 |      4 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2,944.9 μs | 185.3 μs |  93.86 μs | 2,919.7 μs | 2,609.7 μs | 3,591.2 μs |   339.6 |     11 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 3,151.9 μs | 239.7 μs | 121.41 μs | 3,142.3 μs | 2,624.2 μs | 3,647.7 μs |   317.3 |     15 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,194.1 μs | 429.5 μs | 217.61 μs | 3,064.2 μs | 2,611.9 μs | 4,077.7 μs |   313.1 |      7 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 3,421.5 μs | 361.8 μs | 181.17 μs | 3,386.2 μs | 2,811.6 μs | 4,297.9 μs |   292.3 |     17 KB |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 3,849.7 μs | 761.8 μs | 390.59 μs | 3,828.1 μs | 2,416.8 μs | 5,624.9 μs |   259.8 |      4 KB |
