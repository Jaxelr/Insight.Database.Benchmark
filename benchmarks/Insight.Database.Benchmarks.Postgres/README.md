# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8117/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev      | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|------------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   829.7 μs |   141.41 μs |  71.64 μs |   816.8 μs |   645.7 μs | 1,250.4 μs | 1,205.2 |   7.94 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   834.3 μs |   160.83 μs |  84.53 μs |   856.4 μs |   559.4 μs | 1,156.8 μs | 1,198.7 |  11.27 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   851.8 μs |   211.92 μs | 107.36 μs |   829.2 μs |   520.6 μs | 1,514.5 μs | 1,173.9 |  11.27 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   867.5 μs |   204.37 μs | 107.42 μs |   790.4 μs |   572.5 μs | 1,392.5 μs | 1,152.7 |   7.91 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   894.3 μs |    75.84 μs |  39.86 μs |   876.1 μs |   771.8 μs | 1,067.7 μs | 1,118.2 |   7.91 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   912.3 μs |   186.03 μs |  95.38 μs |   891.0 μs |   607.8 μs | 1,453.0 μs | 1,096.1 |   9.47 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   941.1 μs |   185.16 μs |  94.94 μs |   914.5 μs |   718.4 μs | 1,463.4 μs | 1,062.6 |  11.51 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   946.0 μs |   365.21 μs | 185.02 μs |   818.4 μs |   565.0 μs | 2,222.4 μs | 1,057.1 |  11.27 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite |   960.3 μs |   194.20 μs | 102.07 μs |   933.4 μs |   715.1 μs | 1,668.5 μs | 1,041.4 |  28.81 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   964.0 μs |   307.68 μs | 159.70 μs |   988.1 μs |   493.4 μs | 1,724.0 μs | 1,037.4 |   7.94 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   980.6 μs |   252.82 μs | 132.88 μs |   891.5 μs |   640.4 μs | 1,698.6 μs | 1,019.8 |   7.94 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   981.6 μs |   222.72 μs | 114.19 μs |   977.6 μs |   673.8 μs | 1,568.7 μs | 1,018.8 |  11.61 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      | 1,019.5 μs |   130.03 μs |  70.15 μs | 1,006.7 μs |   742.6 μs | 1,444.5 μs |   980.9 |   7.91 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite | 1,023.5 μs |   360.71 μs | 194.61 μs |   948.8 μs |   666.5 μs | 1,932.0 μs |   977.1 |   7.91 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite | 1,025.8 μs |   349.75 μs | 181.53 μs |   902.8 μs |   591.3 μs | 1,822.5 μs |   974.8 |  11.51 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,037.9 μs |   207.16 μs | 108.88 μs | 1,026.7 μs |   678.0 μs | 1,663.2 μs |   963.5 |   8.21 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite | 1,045.3 μs |   238.02 μs | 123.54 μs | 1,012.1 μs |   675.8 μs | 1,642.6 μs |   956.7 |   7.94 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      | 1,045.3 μs |   298.44 μs | 153.01 μs |   982.3 μs |   741.3 μs | 2,139.5 μs |   956.6 |   9.16 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      | 1,047.9 μs |   231.42 μs | 120.12 μs | 1,035.4 μs |   661.8 μs | 1,487.7 μs |   954.2 |   8.21 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      | 1,052.1 μs |   174.13 μs |  92.71 μs | 1,011.2 μs |   738.4 μs | 1,400.1 μs |   950.5 |   8.21 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite | 1,055.5 μs |   252.99 μs | 131.31 μs | 1,059.9 μs |   618.1 μs | 1,714.1 μs |   947.5 |   9.47 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  | 1,063.7 μs |   225.68 μs | 113.00 μs | 1,036.1 μs |   609.8 μs | 1,599.4 μs |   940.1 |  36.52 KB |
| Query&lt;T&gt;                          | InsightBenchmark      | 1,077.1 μs |   271.52 μs | 140.93 μs | 1,165.1 μs |   519.5 μs | 1,499.2 μs |   928.5 |     11 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite | 1,139.4 μs |   231.98 μs | 125.15 μs | 1,101.6 μs |   772.3 μs | 1,736.6 μs |   877.7 |  12.18 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite | 1,140.5 μs |   434.83 μs | 228.54 μs |   989.6 μs |   582.3 μs | 2,756.4 μs |   876.8 |     11 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite | 1,165.6 μs |   324.54 μs | 170.57 μs | 1,108.8 μs |   702.3 μs | 2,259.3 μs |   857.9 |  11.61 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      | 1,176.3 μs |   315.16 μs | 161.58 μs | 1,232.2 μs |   582.8 μs | 1,612.0 μs |   850.1 |   9.16 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      | 1,187.1 μs |   143.96 μs |  72.93 μs | 1,153.4 μs | 1,002.1 μs | 1,491.4 μs |   842.4 |  12.48 KB |
| Single                            | InsightBenchmarkWrite | 1,188.2 μs |   322.41 μs | 165.30 μs | 1,229.7 μs |   676.7 μs | 2,126.1 μs |   841.6 |  10.97 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite | 1,188.5 μs |   486.36 μs | 249.36 μs | 1,077.2 μs |   571.5 μs | 2,776.8 μs |   841.4 |   8.21 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite | 1,193.6 μs |   347.49 μs | 180.36 μs | 1,144.7 μs |   655.1 μs | 1,873.8 μs |   837.8 |  12.23 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      | 1,209.6 μs |   233.28 μs | 119.61 μs | 1,251.5 μs |   718.9 μs | 1,543.5 μs |   826.7 |   9.42 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 1,211.8 μs |   256.19 μs | 128.28 μs | 1,217.3 μs |   745.0 μs | 1,747.9 μs |   825.2 |  28.81 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      | 1,214.7 μs |   231.12 μs | 121.48 μs | 1,226.8 μs |   795.5 μs | 1,868.2 μs |   823.2 |  11.27 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  | 1,271.4 μs |   250.96 μs | 131.90 μs | 1,283.1 μs |   848.3 μs | 2,005.1 μs |   786.6 |  38.08 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite | 1,274.5 μs |   448.46 μs | 235.71 μs | 1,135.4 μs |   636.0 μs | 2,528.7 μs |   784.6 |   9.42 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite | 1,278.9 μs |   315.50 μs | 165.83 μs | 1,309.0 μs |   663.8 μs | 1,776.8 μs |   781.9 |  13.14 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  | 1,283.3 μs |   311.36 μs | 161.61 μs | 1,307.3 μs |   799.9 μs | 1,925.0 μs |   779.2 |  38.03 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      | 1,290.6 μs |   209.74 μs | 105.02 μs | 1,260.7 μs |   888.7 μs | 1,826.7 μs |   774.8 |  12.53 KB |
| Single                            | InsightBenchmark      | 1,321.7 μs |   209.81 μs | 107.57 μs | 1,369.9 μs |   937.5 μs | 1,677.7 μs |   756.6 |  10.97 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  | 1,341.4 μs |   420.84 μs | 215.77 μs | 1,266.7 μs |   688.5 μs | 2,901.5 μs |   745.5 |  36.55 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      | 1,349.2 μs |   190.78 μs |  96.65 μs | 1,309.8 μs |   951.8 μs | 1,784.1 μs |   741.2 |   9.42 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      | 1,352.1 μs |   277.57 μs | 147.78 μs | 1,358.8 μs |   912.2 μs | 2,129.3 μs |   739.6 |  12.84 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite | 1,370.3 μs |   268.79 μs | 141.27 μs | 1,387.8 μs |   979.4 μs | 2,111.9 μs |   729.8 |   9.42 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,731.0 μs |   326.05 μs | 178.31 μs | 1,714.5 μs | 1,174.1 μs | 2,409.8 μs |   577.7 |  30.47 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,976.4 μs |   614.58 μs | 307.73 μs | 1,830.3 μs | 1,151.2 μs | 3,353.2 μs |   506.0 |  30.47 KB |
|                                   |                       |            |             |           |            |            |            |         |           |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,525.6 μs |   364.27 μs | 186.76 μs | 2,474.6 μs | 2,054.8 μs | 4,017.1 μs |   395.9 |  11.85 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,732.5 μs |   570.35 μs | 292.42 μs | 2,500.4 μs | 2,126.9 μs | 4,588.2 μs |   366.0 |   7.97 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,848.5 μs |   862.50 μs | 436.95 μs | 2,720.2 μs | 2,121.9 μs | 8,117.6 μs |   351.1 |   5.27 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,967.4 μs |   604.37 μs | 306.18 μs | 2,878.9 μs | 1,857.8 μs | 4,485.6 μs |   337.0 |   3.63 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 3,044.1 μs |   607.50 μs | 300.73 μs | 2,917.0 μs | 1,984.8 μs | 4,712.1 μs |   328.5 |   3.67 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 3,475.5 μs | 1,512.71 μs | 775.58 μs | 2,930.8 μs | 2,252.9 μs | 8,904.6 μs |   287.7 |   13.2 KB |
