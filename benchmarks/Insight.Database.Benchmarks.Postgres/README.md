# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.963)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                            Method |                  Type |       Mean |   StdDev |     Error |     Median |        Min |        Max |    Op/s | Allocated |
|---------------------------------- |---------------------- |-----------:|---------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
|           &#39;Single (Fast Expando)&#39; |      InsightBenchmark |   970.2 μs | 226.1 μs | 111.91 μs |   964.2 μs |   597.5 μs | 1,505.0 μs | 1,030.7 |   9.09 KB |
|          &#39;Single Async (dynamic)&#39; |      InsightBenchmark | 1,024.2 μs | 268.8 μs | 134.60 μs |   940.9 μs |   618.8 μs | 1,628.4 μs |   976.3 |  10.73 KB |
|                  &#39;Single (Tuple)&#39; |      InsightBenchmark | 1,035.0 μs | 223.7 μs | 113.31 μs |   953.4 μs |   691.8 μs | 1,475.5 μs |   966.2 |  13.38 KB |
|                &#39;Single (dynamic)&#39; |      InsightBenchmark | 1,038.8 μs | 189.6 μs |  96.05 μs | 1,069.5 μs |   644.8 μs | 1,379.2 μs |   962.6 |   9.09 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; | InsightBenchmarkWrite | 1,049.6 μs | 192.4 μs |  97.49 μs | 1,055.8 μs |   691.7 μs | 1,502.3 μs |   952.7 |    9.1 KB |
|           &#39;Single (Fast Expando)&#39; | InsightBenchmarkWrite | 1,057.3 μs | 184.2 μs |  93.31 μs | 1,074.5 μs |   625.2 μs | 1,483.2 μs |   945.8 |   9.09 KB |
|  &#39;Auto Interface Query (dynamic)&#39; |      InsightBenchmark | 1,070.6 μs | 233.7 μs | 117.04 μs | 1,071.9 μs |   575.9 μs | 1,604.2 μs |   934.1 |   9.39 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; | InsightBenchmarkWrite | 1,079.1 μs | 253.4 μs | 128.40 μs |   983.0 μs |   744.9 μs | 1,667.8 μs |   926.7 |  10.76 KB |
|                            Single |      InsightBenchmark | 1,085.0 μs | 199.7 μs |  99.97 μs | 1,090.7 μs |   679.8 μs | 1,533.5 μs |   921.7 |  13.22 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; | InsightBenchmarkWrite | 1,087.9 μs | 224.2 μs | 114.93 μs | 1,106.5 μs |   782.5 μs | 1,653.7 μs |   919.2 |    9.1 KB |
|                    &#39;Single Async&#39; |      InsightBenchmark | 1,095.9 μs | 240.9 μs | 119.27 μs | 1,105.9 μs |   675.5 μs | 1,523.3 μs |   912.5 |  14.86 KB |
|                &#39;Single (dynamic)&#39; | InsightBenchmarkWrite | 1,100.1 μs | 175.6 μs |  86.95 μs | 1,090.0 μs |   727.5 μs | 1,559.4 μs |   909.0 |   9.09 KB |
|                            Single | InsightBenchmarkWrite | 1,120.7 μs | 170.4 μs |  86.32 μs | 1,125.8 μs |   786.1 μs | 1,530.0 μs |   892.3 |  13.22 KB |
|                   &#39;Query&lt;T&gt; json&#39; |  InsightBenchmarkJson | 1,126.7 μs | 190.1 μs |  96.29 μs | 1,080.4 μs |   780.5 μs | 1,504.5 μs |   887.5 |   38.9 KB |
|                    Query&lt;(Tuple)&gt; | InsightBenchmarkWrite | 1,140.7 μs | 186.0 μs |  93.15 μs | 1,121.8 μs |   776.3 μs | 1,549.6 μs |   876.6 |  13.47 KB |
| &#39;Auto Interface Single (dynamic)&#39; |      InsightBenchmark | 1,142.0 μs | 201.1 μs | 105.71 μs | 1,150.8 μs |   684.0 μs | 1,615.1 μs |   875.7 |   9.39 KB |
|                          Query&lt;T&gt; | InsightBenchmarkWrite | 1,142.9 μs | 206.1 μs | 102.02 μs | 1,108.3 μs |   712.5 μs | 1,694.6 μs |   874.9 |  13.23 KB |
|                     &#39;Single json&#39; |  InsightBenchmarkJson | 1,187.6 μs | 146.1 μs |  73.16 μs | 1,190.9 μs |   791.5 μs | 1,458.5 μs |   842.0 |  38.88 KB |
|            &#39;Auto Interface Query&#39; |      InsightBenchmark | 1,188.5 μs | 137.8 μs |  70.64 μs | 1,160.0 μs |   989.3 μs | 1,498.3 μs |   841.4 |  13.52 KB |
|           &#39;Auto Interface Single&#39; |      InsightBenchmark | 1,192.3 μs | 147.7 μs |  74.83 μs | 1,169.7 μs |   886.1 μs | 1,598.0 μs |   838.7 |  13.52 KB |
|         &#39;Query&lt;T&gt; (Fast Expando)&#39; |      InsightBenchmark | 1,198.7 μs | 230.2 μs | 113.95 μs | 1,202.8 μs |   807.2 μs | 1,559.8 μs |   834.2 |    9.1 KB |
|              &#39;Query&lt;T&gt; (dynamic)&#39; |      InsightBenchmark | 1,203.2 μs | 263.7 μs | 130.56 μs | 1,236.3 μs |   697.0 μs | 1,689.3 μs |   831.1 |    9.1 KB |
|            &#39;Auto Interface Query&#39; | InsightBenchmarkWrite | 1,217.7 μs | 203.3 μs | 100.64 μs | 1,208.9 μs |   832.3 μs | 1,637.0 μs |   821.2 |  13.52 KB |
|          &#39;Single Async (dynamic)&#39; | InsightBenchmarkWrite | 1,223.4 μs | 245.9 μs | 121.71 μs | 1,248.2 μs |   673.3 μs | 1,723.5 μs |   817.4 |  10.73 KB |
|                    &#39;Single Async&#39; | InsightBenchmarkWrite | 1,227.6 μs | 213.3 μs | 108.08 μs | 1,186.9 μs |   874.5 μs | 1,747.8 μs |   814.6 |  14.86 KB |
|            &#39;Single Async (Tuple)&#39; |      InsightBenchmark | 1,234.3 μs | 256.8 μs | 128.57 μs | 1,253.8 μs |   818.1 μs | 1,838.7 μs |   810.1 |  15.14 KB |
|     &#39;Single Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,243.6 μs | 186.2 μs |  94.35 μs | 1,228.4 μs |   907.2 μs | 1,644.5 μs |   804.1 |  10.86 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; | InsightBenchmarkWrite | 1,245.2 μs | 251.9 μs | 124.72 μs | 1,224.4 μs |   811.8 μs | 1,914.3 μs |   803.1 |  10.76 KB |
|                  &#39;Query&lt;T&gt; Async&#39; |      InsightBenchmark | 1,252.5 μs | 266.5 μs | 133.42 μs | 1,230.0 μs |   758.3 μs | 1,697.9 μs |   798.4 |  15.02 KB |
|        &#39;Query&lt;T&gt; Async (dynamic)&#39; |      InsightBenchmark | 1,265.3 μs | 198.8 μs | 101.92 μs | 1,250.2 μs |   787.6 μs | 1,665.0 μs |   790.4 |  10.76 KB |
|  &#39;Auto Interface Query (dynamic)&#39; | InsightBenchmarkWrite | 1,268.5 μs | 132.3 μs |  66.23 μs | 1,256.2 μs |   912.2 μs | 1,540.1 μs |   788.4 |   9.39 KB |
|                  &#39;Single (Tuple)&#39; | InsightBenchmarkWrite | 1,275.6 μs | 156.2 μs |  80.07 μs | 1,277.5 μs |   806.7 μs | 1,551.0 μs |   783.9 |  13.38 KB |
|                  &#39;Query&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 1,280.8 μs | 202.6 μs | 102.65 μs | 1,256.0 μs |   903.1 μs | 1,726.6 μs |   780.7 |  14.89 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,292.9 μs | 135.9 μs |  68.86 μs | 1,295.9 μs |   902.2 μs | 1,574.0 μs |   773.5 |   9.39 KB |
|               &#39;Single Async json&#39; |  InsightBenchmarkJson | 1,296.0 μs | 234.5 μs | 116.10 μs | 1,361.2 μs |   875.8 μs | 1,737.6 μs |   771.6 |   41.2 KB |
|           &#39;Auto Interface Single&#39; | InsightBenchmarkWrite | 1,300.0 μs | 186.7 μs |  92.41 μs | 1,277.0 μs |   934.9 μs | 1,789.1 μs |   769.3 |  13.52 KB |
|     &#39;Single Async (Fast Expando)&#39; |      InsightBenchmark | 1,302.9 μs | 196.4 μs |  97.21 μs | 1,292.1 μs |   930.5 μs | 1,675.1 μs |   767.5 |  10.73 KB |
|                    Query&lt;(Tuple)&gt; |      InsightBenchmark | 1,312.7 μs | 221.9 μs | 109.86 μs | 1,305.5 μs |   820.7 μs | 1,771.3 μs |   761.8 |  13.47 KB |
|                          Query&lt;T&gt; |      InsightBenchmark | 1,313.8 μs | 183.2 μs |  92.79 μs | 1,324.4 μs |   977.1 μs | 1,662.8 μs |   761.2 |  13.23 KB |
|             &#39;Query&lt;T&gt; Async json&#39; |  InsightBenchmarkJson | 1,319.7 μs | 287.6 μs | 145.71 μs | 1,306.5 μs |   749.9 μs | 1,839.8 μs |   757.7 |  40.55 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; |      InsightBenchmark | 1,351.8 μs | 205.9 μs | 103.10 μs | 1,364.5 μs |   782.6 μs | 1,897.0 μs |   739.8 |  31.66 KB |
|            &#39;Single Async (Tuple)&#39; | InsightBenchmarkWrite | 1,365.8 μs | 154.6 μs |  81.27 μs | 1,380.2 μs |   985.3 μs | 1,662.5 μs |   732.2 |  15.14 KB |
|   &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |      InsightBenchmark | 1,405.6 μs | 190.8 μs |  95.53 μs | 1,390.9 μs |   996.6 μs | 1,832.6 μs |   711.5 |  10.76 KB |
|  &#39;Query&lt;T&gt; Parent/Child Together&#39; | InsightBenchmarkWrite | 1,446.0 μs | 156.0 μs |  79.02 μs | 1,430.5 μs | 1,162.9 μs | 1,791.1 μs |   691.6 |  31.66 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; |      InsightBenchmark | 1,638.5 μs | 180.4 μs |  90.33 μs | 1,669.9 μs | 1,198.9 μs | 1,934.2 μs |   610.3 |  33.23 KB |
|           &#39;Query&lt;T&gt; Parent/Child&#39; | InsightBenchmarkWrite | 1,683.0 μs | 145.7 μs |  73.80 μs | 1,668.1 μs | 1,311.4 μs | 2,051.2 μs |   594.2 |  33.23 KB |
|                                   |                       |            |          |           |            |            |            |         |           |
|                         Insert&lt;T&gt; | InsightBenchmarkWrite | 2,068.1 μs | 282.2 μs | 142.95 μs | 2,009.7 μs | 1,668.9 μs | 2,717.2 μs |   483.5 |   4.54 KB |
|                  &#39;Insert&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2,100.0 μs | 297.5 μs | 147.26 μs | 2,113.1 μs | 1,458.8 μs | 2,875.7 μs |   476.2 |   4.62 KB |
|                  &#39;Update&lt;T&gt; json&#39; |  InsightBenchmarkJson | 2,339.8 μs | 259.2 μs | 128.30 μs | 2,319.7 μs | 1,942.7 μs | 3,160.9 μs |   427.4 |   10.7 KB |
|                 &#39;Insert&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2,342.8 μs | 301.0 μs | 150.73 μs | 2,289.9 μs | 1,787.0 μs | 3,080.7 μs |   426.8 |    6.3 KB |
|                         Update&lt;T&gt; | InsightBenchmarkWrite | 2,403.8 μs | 168.1 μs |  84.16 μs | 2,446.7 μs | 2,046.7 μs | 2,681.1 μs |   416.0 |  14.58 KB |
|                 &#39;Update&lt;T&gt; Async&#39; | InsightBenchmarkWrite | 2,590.8 μs | 263.0 μs | 133.23 μs | 2,593.3 μs | 2,158.9 μs | 3,350.4 μs |   386.0 |  16.48 KB |
