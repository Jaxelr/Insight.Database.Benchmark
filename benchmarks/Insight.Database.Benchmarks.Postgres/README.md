# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT


```
|                            Method |                  Type |       Mean |     StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark |   957.2 μs |   176.1 μs |  89.22 μs |   919.8 μs |   703.9 μs | 1,385.7 μs | 1,044.7 |      9 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite |   966.3 μs |   185.7 μs |  94.10 μs |   905.6 μs |   732.0 μs | 1,470.7 μs | 1,034.8 |     11 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   967.3 μs |   200.2 μs | 101.40 μs |   938.0 μs |   695.1 μs | 1,538.0 μs | 1,033.8 |      9 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite |   973.3 μs |   208.1 μs | 105.43 μs |   927.6 μs |   723.5 μs | 1,432.4 μs | 1,027.5 |      9 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark |   987.3 μs |   200.5 μs | 102.81 μs |   940.9 μs |   637.5 μs | 1,420.4 μs | 1,012.9 |      9 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite |   999.8 μs |   230.7 μs | 115.54 μs |   955.0 μs |   698.1 μs | 1,707.7 μs | 1,000.2 |     11 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1,000.2 μs |   313.9 μs | 160.93 μs |   894.9 μs |   661.5 μs | 1,848.0 μs |   999.8 |      9 KB |
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark | 1,001.3 μs |   183.5 μs |  91.90 μs |   975.9 μs |   697.1 μs | 1,491.1 μs |   998.7 |      9 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1,002.1 μs |   182.2 μs |  90.20 μs |   996.2 μs |   726.9 μs | 1,426.9 μs |   997.9 |     14 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1,013.6 μs |   215.2 μs | 109.00 μs |   944.2 μs |   718.8 μs | 1,523.4 μs |   986.6 |      9 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 1,020.7 μs |   167.3 μs |  83.76 μs | 1,033.0 μs |   749.1 μs | 1,375.8 μs |   979.7 |     15 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1,026.0 μs |   246.0 μs | 123.16 μs |   980.8 μs |   707.7 μs | 1,705.2 μs |   974.7 |      9 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1,037.7 μs |   211.8 μs | 106.06 μs |   951.8 μs |   749.0 μs | 1,511.5 μs |   963.7 |     14 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 1,038.0 μs |   236.7 μs | 124.39 μs |   948.6 μs |   723.5 μs | 1,713.2 μs |   963.4 |     14 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1,046.0 μs |   198.0 μs |  99.13 μs | 1,048.4 μs |   733.9 μs | 1,420.1 μs |   956.0 |     11 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1,063.3 μs |   209.1 μs | 107.22 μs | 1,047.6 μs |   771.8 μs | 1,604.7 μs |   940.5 |     15 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1,071.1 μs |   254.0 μs | 133.51 μs | 1,046.0 μs |   720.9 μs | 1,574.5 μs |   933.6 |     11 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1,074.5 μs |   292.3 μs | 148.08 μs |   972.3 μs |   706.0 μs | 1,610.0 μs |   930.6 |      9 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1,081.8 μs |   210.7 μs | 108.05 μs | 1,063.2 μs |   716.6 μs | 1,627.6 μs |   924.4 |     11 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1,092.5 μs |   288.7 μs | 146.28 μs | 1,073.5 μs |   692.3 μs | 1,608.5 μs |   915.3 |      9 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,098.8 μs |   437.4 μs | 219.03 μs |   954.9 μs |   667.1 μs | 2,643.8 μs |   910.1 |     11 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1,107.3 μs |   384.7 μs | 192.63 μs |   964.3 μs |   648.4 μs | 2,382.3 μs |   903.1 |     11 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1,114.9 μs |   241.5 μs | 120.95 μs | 1,052.5 μs |   760.5 μs | 1,694.8 μs |   897.0 |     14 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1,122.6 μs |   312.5 μs | 156.49 μs | 1,019.7 μs |   702.8 μs | 2,093.1 μs |   890.8 |     41 KB |
|                            Single |      InsightBenchmark | 1,122.9 μs |   245.0 μs | 122.70 μs | 1,060.3 μs |   730.3 μs | 1,790.8 μs |   890.6 |     14 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1,127.3 μs |   255.8 μs | 128.06 μs | 1,081.9 μs |   755.0 μs | 1,695.8 μs |   887.1 |     15 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 1,131.7 μs |   192.1 μs | 100.99 μs | 1,082.7 μs |   830.2 μs | 1,609.2 μs |   883.6 |     32 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1,145.1 μs |   290.2 μs | 148.77 μs | 1,114.1 μs |   790.5 μs | 1,818.0 μs |   873.3 |     14 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,153.4 μs |   218.9 μs | 108.38 μs | 1,125.1 μs |   744.9 μs | 1,647.7 μs |   867.0 |     39 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1,156.3 μs |   282.7 μs | 143.24 μs | 1,156.5 μs |   714.7 μs | 1,696.8 μs |   864.9 |     14 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1,156.9 μs |   255.7 μs | 126.58 μs | 1,160.9 μs |   734.0 μs | 1,781.2 μs |   864.4 |      9 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1,158.4 μs |   317.7 μs | 157.25 μs | 1,104.4 μs |   742.0 μs | 2,125.2 μs |   863.3 |     14 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1,162.3 μs |   300.4 μs | 148.71 μs | 1,107.3 μs |   723.6 μs | 2,076.9 μs |   860.4 |     14 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,172.9 μs |   349.7 μs | 175.08 μs | 1,101.3 μs |   773.2 μs | 2,259.8 μs |   852.6 |     15 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1,184.9 μs |   141.3 μs |  71.59 μs | 1,196.0 μs |   874.3 μs | 1,503.7 μs |   843.9 |     11 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 1,192.9 μs |   344.6 μs | 176.69 μs | 1,077.2 μs |   776.1 μs | 2,333.2 μs |   838.3 |     14 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 1,205.7 μs |   282.1 μs | 139.65 μs | 1,178.9 μs |   754.1 μs | 1,796.9 μs |   829.4 |     15 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 1,268.5 μs |   431.5 μs | 216.07 μs | 1,132.3 μs |   789.6 μs | 2,985.2 μs |   788.3 |     41 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1,291.2 μs |   467.3 μs | 236.75 μs | 1,156.5 μs |   785.2 μs | 2,560.2 μs |   774.5 |     39 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 1,296.8 μs |   381.8 μs | 189.00 μs | 1,260.4 μs |   777.8 μs | 2,462.7 μs |   771.1 |     14 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 1,314.2 μs |   258.7 μs | 129.52 μs | 1,292.5 μs |   965.9 μs | 1,977.9 μs |   760.9 |     32 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1,325.0 μs |   319.4 μs | 158.12 μs | 1,352.5 μs |   727.3 μs | 1,919.2 μs |   754.7 |      9 KB |
|                            Single | InsightBenchmarkWrite | 1,329.8 μs |   525.4 μs | 260.08 μs | 1,117.0 μs |   727.0 μs | 2,456.2 μs |   752.0 |     14 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,390.1 μs |   594.2 μs | 294.16 μs | 1,147.1 μs |   692.9 μs | 2,916.7 μs |   719.4 |     15 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 1,592.4 μs |   254.8 μs | 127.57 μs | 1,568.4 μs | 1,195.2 μs | 2,221.9 μs |   628.0 |     34 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 1,595.6 μs |   427.0 μs | 216.30 μs | 1,449.8 μs | 1,054.6 μs | 2,590.1 μs |   626.7 |     34 KB |
|                                   |                       |            |            |           |            |            |            |         |           |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 1,973.5 μs |   336.8 μs | 172.70 μs | 1,941.8 μs | 1,437.0 μs | 2,681.3 μs |   506.7 |      4 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,984.2 μs |   279.1 μs | 139.77 μs | 1,981.7 μs | 1,528.1 μs | 2,551.1 μs |   504.0 |     11 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2,006.8 μs |   496.2 μs | 245.63 μs | 1,833.0 μs | 1,444.3 μs | 3,373.9 μs |   498.3 |     17 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2,068.5 μs |   379.4 μs | 194.51 μs | 2,015.3 μs | 1,448.9 μs | 3,044.3 μs |   483.4 |      6 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 2,341.6 μs |   487.3 μs | 249.87 μs | 2,365.8 μs | 1,492.2 μs | 3,336.8 μs |   427.1 |     15 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2,838.6 μs | 1,312.6 μs | 681.27 μs | 2,222.8 μs | 1,298.2 μs | 5,641.2 μs |   352.3 |      4 KB |
