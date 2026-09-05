# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9278/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   689.0 μs | 118.19 μs |  59.88 μs |   661.7 μs |   529.1 μs |   976.7 μs | 1,451.3 |   7.31 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   704.6 μs | 126.16 μs |  67.17 μs |   669.0 μs |   567.2 μs | 1,104.7 μs | 1,419.3 |   7.62 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   709.3 μs | 112.99 μs |  57.93 μs |   691.9 μs |   553.5 μs | 1,013.4 μs | 1,409.9 |  10.41 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   715.0 μs | 120.36 μs |  64.94 μs |   675.1 μs |   535.7 μs |   941.9 μs | 1,398.6 |   7.62 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   719.6 μs | 146.22 μs |  73.22 μs |   704.4 μs |   531.4 μs | 1,063.5 μs | 1,389.7 |   7.34 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   733.3 μs | 110.08 μs |  56.44 μs |   716.7 μs |   546.2 μs | 1,093.6 μs | 1,363.7 |   7.31 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   734.4 μs |  98.88 μs |  51.97 μs |   706.0 μs |   588.1 μs | 1,033.5 μs | 1,361.7 |   8.88 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   736.9 μs | 167.29 μs |  85.77 μs |   718.6 μs |   516.0 μs | 1,209.1 μs | 1,357.1 |   7.31 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   744.4 μs | 151.36 μs |  79.55 μs |   726.1 μs |   567.4 μs | 1,276.4 μs | 1,343.3 |   7.34 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   749.0 μs | 110.48 μs |  58.07 μs |   720.2 μs |   597.9 μs | 1,089.0 μs | 1,335.2 |   8.88 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   756.8 μs |  87.99 μs |  45.11 μs |   741.6 μs |   627.7 μs |   995.1 μs | 1,321.4 |   8.88 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   762.8 μs | 111.21 μs |  57.02 μs |   740.3 μs |   597.8 μs |   995.0 μs | 1,310.9 |  11.02 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   768.8 μs | 132.51 μs |  67.94 μs |   804.9 μs |   541.9 μs | 1,027.3 μs | 1,300.8 |   7.31 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   770.8 μs | 136.82 μs |  71.01 μs |   770.3 μs |   545.1 μs | 1,122.2 μs | 1,297.3 |   7.62 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   771.1 μs | 114.51 μs |  58.71 μs |   752.7 μs |   569.7 μs | 1,063.1 μs | 1,296.9 |  11.02 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   773.5 μs | 123.91 μs |  64.31 μs |   744.0 μs |   587.5 μs | 1,073.4 μs | 1,292.8 |  10.91 KB |
| Single                            | InsightBenchmark      |   774.8 μs | 154.26 μs |  78.15 μs |   725.5 μs |   598.2 μs | 1,306.1 μs | 1,290.6 |  10.38 KB |
| Single                            | InsightBenchmarkWrite |   775.9 μs | 115.13 μs |  59.76 μs |   765.5 μs |   583.7 μs | 1,012.5 μs | 1,288.8 |  10.38 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   777.2 μs | 140.21 μs |  73.69 μs |   764.6 μs |   576.1 μs | 1,112.2 μs | 1,286.6 |  10.91 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   784.7 μs | 166.72 μs |  85.48 μs |   721.8 μs |   591.8 μs | 1,243.4 μs | 1,274.4 |   8.83 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   792.1 μs | 154.29 μs |  82.15 μs |   743.8 μs |   639.0 μs | 1,437.8 μs | 1,262.5 |  12.55 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   794.9 μs | 115.21 μs |  59.80 μs |   801.9 μs |   600.8 μs |   991.0 μs | 1,258.0 |  10.68 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   806.4 μs | 221.94 μs | 115.19 μs |   810.5 μs |   531.4 μs | 1,320.8 μs | 1,240.1 |   7.34 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   808.1 μs | 157.03 μs |  78.63 μs |   790.3 μs |   551.2 μs | 1,200.5 μs | 1,237.5 |  10.41 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  |   812.1 μs | 121.42 μs |  63.82 μs |   808.3 μs |   607.0 μs | 1,127.8 μs | 1,231.4 |  35.92 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   815.2 μs | 129.58 μs |  64.89 μs |   789.4 μs |   611.7 μs | 1,153.4 μs | 1,226.7 |   8.57 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   815.2 μs | 168.74 μs |  85.49 μs |   772.2 μs |   575.0 μs | 1,348.2 μs | 1,226.7 |   7.34 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   815.4 μs | 115.66 μs |  60.03 μs |   810.5 μs |   593.0 μs | 1,084.6 μs | 1,226.5 |   7.62 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  |   819.5 μs | 119.47 μs |  62.01 μs |   807.4 μs |   619.0 μs | 1,091.0 μs | 1,220.2 |  35.95 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   832.4 μs | 188.47 μs |  94.37 μs |   793.7 μs |   619.9 μs | 1,493.3 μs | 1,201.4 |   8.52 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   845.4 μs | 153.43 μs |  77.73 μs |   790.5 μs |   644.2 μs | 1,264.4 μs | 1,182.9 |   12.2 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   847.3 μs | 219.07 μs | 115.14 μs |   834.4 μs |   550.8 μs | 1,640.9 μs | 1,180.3 |  10.68 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   848.4 μs | 186.70 μs |  96.90 μs |   809.7 μs |   612.1 μs | 1,366.5 μs | 1,178.7 |   8.52 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   854.9 μs | 169.06 μs |  84.65 μs |   811.2 μs |   637.2 μs | 1,462.9 μs | 1,169.7 |  11.94 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   855.0 μs | 181.60 μs |  90.93 μs |   841.6 μs |   626.7 μs | 1,390.1 μs | 1,169.6 |   8.52 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   860.0 μs | 185.06 μs |  93.75 μs |   803.0 μs |   621.3 μs | 1,534.5 μs | 1,162.7 |  11.89 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   867.5 μs | 132.84 μs |  66.52 μs |   874.3 μs |   652.9 μs | 1,144.9 μs | 1,152.7 |  10.68 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   901.0 μs | 139.57 μs |  70.71 μs |   875.2 μs |   672.2 μs | 1,217.3 μs | 1,109.9 |  11.89 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   901.7 μs | 210.56 μs | 110.67 μs |   894.3 μs |   632.2 μs | 1,502.4 μs | 1,109.0 |  10.68 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  |   909.8 μs | 169.65 μs |  86.98 μs |   867.7 μs |   667.3 μs | 1,291.3 μs | 1,099.2 |  37.44 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   927.3 μs | 160.83 μs |  81.48 μs |   941.0 μs |   673.9 μs | 1,266.3 μs | 1,078.4 |  12.55 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      |   952.1 μs | 143.75 μs |  73.70 μs |   944.2 μs |   692.9 μs | 1,240.5 μs | 1,050.3 |  28.22 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  | 1,013.2 μs | 200.94 μs |  99.47 μs | 1,017.4 μs |   677.8 μs | 1,488.0 μs |   987.0 |  37.48 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 1,020.6 μs | 177.75 μs |  89.01 μs | 1,014.0 μs |   698.8 μs | 1,373.5 μs |   979.8 |  28.22 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,341.0 μs | 130.74 μs |  69.61 μs | 1,348.9 μs | 1,115.5 μs | 1,679.0 μs |   745.7 |  29.65 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,341.5 μs | 188.76 μs |  96.78 μs | 1,266.2 μs | 1,108.5 μs | 1,856.3 μs |   745.5 |  29.65 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,122.6 μs | 182.41 μs |  94.68 μs | 2,091.6 μs | 1,845.7 μs | 2,663.0 μs |   471.1 |   4.38 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,215.9 μs | 309.95 μs | 155.20 μs | 2,125.4 μs | 1,782.4 μs | 3,049.1 μs |   451.3 |   3.03 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,255.7 μs | 282.26 μs | 144.72 μs | 2,158.8 μs | 1,789.3 μs | 2,797.9 μs |   443.3 |  11.26 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,322.0 μs | 337.07 μs | 166.86 μs | 2,268.9 μs | 1,749.5 μs | 3,053.4 μs |   430.7 |   3.08 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,328.9 μs | 247.37 μs | 123.87 μs | 2,319.4 μs | 1,815.8 μs | 3,051.8 μs |   429.4 |   7.38 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,346.8 μs | 232.38 μs | 119.14 μs | 2,291.3 μs | 2,008.8 μs | 2,921.4 μs |   426.1 |  12.91 KB |
