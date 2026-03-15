# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.104
  [Host]   : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev   | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|---------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| Single                            | InsightBenchmarkWrite |   663.8 μs | 124.7 μs |  63.94 μs |   612.0 μs |   531.0 μs | 1,076.7 μs | 1,506.5 |  10.32 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   668.3 μs | 124.9 μs |  65.65 μs |   631.7 μs |   478.8 μs |   949.0 μs | 1,496.3 |   7.91 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   680.4 μs | 148.3 μs |  78.95 μs |   644.0 μs |   471.1 μs | 1,077.4 μs | 1,469.8 |   7.26 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   692.2 μs | 152.3 μs |  78.07 μs |   624.0 μs |   520.2 μs | 1,069.3 μs | 1,444.6 |   7.56 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   706.5 μs | 115.4 μs |  60.63 μs |   690.6 μs |   559.0 μs | 1,063.2 μs | 1,415.4 |   7.56 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   717.3 μs | 135.3 μs |  68.55 μs |   693.8 μs |   508.6 μs | 1,095.4 μs | 1,394.1 |   7.94 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   729.4 μs | 138.4 μs |  70.11 μs |   689.4 μs |   529.5 μs | 1,091.3 μs | 1,371.0 |   7.91 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   731.7 μs | 126.2 μs |  64.71 μs |   698.0 μs |   581.3 μs | 1,061.8 μs | 1,366.7 |  10.96 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   733.9 μs | 151.8 μs |  78.78 μs |   714.5 μs |   550.6 μs | 1,228.9 μs | 1,362.6 |  11.27 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   734.0 μs | 140.6 μs |  73.90 μs |   733.5 μs |   511.3 μs | 1,206.2 μs | 1,362.4 |   7.29 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   739.7 μs | 183.3 μs |  95.12 μs |   687.4 μs |   500.4 μs | 1,269.0 μs | 1,352.0 |   7.26 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   742.9 μs | 159.7 μs |  81.89 μs |   722.5 μs |   540.3 μs | 1,288.0 μs | 1,346.0 |  10.35 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   779.4 μs | 129.0 μs |  66.95 μs |   773.7 μs |   564.0 μs | 1,067.0 μs | 1,283.0 |   8.77 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   805.0 μs | 214.6 μs | 110.01 μs |   751.7 μs |   521.8 μs | 1,259.2 μs | 1,242.3 |   7.29 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   813.9 μs | 157.9 μs |  79.05 μs |   763.4 μs |   613.3 μs | 1,412.1 μs | 1,228.6 |  11.84 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   814.1 μs | 229.3 μs | 113.53 μs |   754.8 μs |   568.5 μs | 1,496.2 μs | 1,228.4 |   8.52 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   817.8 μs | 254.8 μs | 132.26 μs |   734.8 μs |   542.7 μs | 1,348.8 μs | 1,222.8 |     11 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   820.3 μs | 136.3 μs |  68.22 μs |   800.6 μs |   583.2 μs | 1,068.8 μs | 1,219.0 |  11.51 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   824.1 μs | 170.9 μs |  86.56 μs |   809.6 μs |   600.0 μs | 1,393.8 μs | 1,213.5 |  11.88 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  |   830.6 μs | 193.5 μs | 101.73 μs |   801.9 μs |   590.6 μs | 1,519.3 μs | 1,204.0 |  38.08 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   832.1 μs | 271.5 μs | 135.93 μs |   719.5 μs |   541.5 μs | 1,688.2 μs | 1,201.7 |   8.21 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   842.1 μs | 188.9 μs |  96.83 μs |   821.9 μs |   566.5 μs | 1,490.5 μs | 1,187.5 |   8.77 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   849.0 μs | 166.0 μs |  85.09 μs |   845.6 μs |   574.0 μs | 1,331.5 μs | 1,177.8 |  12.48 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   866.3 μs | 173.4 μs |  87.85 μs |   820.4 μs |   616.8 μs | 1,234.3 μs | 1,154.3 |  12.84 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   878.5 μs | 223.7 μs | 116.11 μs |   826.8 μs |   605.6 μs | 1,462.8 μs | 1,138.4 |  12.53 KB |
| Single                            | InsightBenchmark      |   890.5 μs | 205.7 μs | 110.97 μs |   837.6 μs |   555.3 μs | 1,230.0 μs | 1,123.0 |  10.97 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   907.3 μs | 207.1 μs | 107.48 μs |   869.5 μs |   616.7 μs | 1,434.1 μs | 1,102.1 |   8.82 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   912.8 μs | 226.2 μs | 115.99 μs |   837.3 μs |   625.0 μs | 1,385.5 μs | 1,095.5 |   9.42 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   944.3 μs | 220.4 μs | 117.34 μs |   858.5 μs |   673.6 μs | 1,441.6 μs | 1,059.0 |  12.19 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite |   952.0 μs | 179.6 μs |  92.09 μs |   939.8 μs |   687.8 μs | 1,483.8 μs | 1,050.4 |  26.14 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   984.9 μs | 314.3 μs | 159.24 μs |   930.6 μs |   586.4 μs | 1,815.0 μs | 1,015.3 |  10.86 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite | 1,006.9 μs | 273.8 μs | 138.72 μs |   948.5 μs |   664.9 μs | 1,952.7 μs |   993.2 |  11.27 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  | 1,041.5 μs | 224.7 μs | 115.20 μs | 1,061.1 μs |   606.9 μs | 1,567.0 μs |   960.2 |  36.55 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      | 1,057.1 μs | 228.0 μs | 114.14 μs | 1,026.5 μs |   598.6 μs | 1,527.2 μs |   945.9 |  11.27 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      | 1,067.0 μs | 313.7 μs | 160.83 μs | 1,058.7 μs |   611.6 μs | 2,188.1 μs |   937.2 |   7.94 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      | 1,099.1 μs | 276.2 μs | 143.37 μs | 1,040.0 μs |   696.8 μs | 1,675.4 μs |   909.8 |  11.61 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      | 1,146.4 μs | 385.6 μs | 197.68 μs | 1,203.0 μs |   517.1 μs | 2,021.3 μs |   872.3 |   8.21 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      | 1,156.5 μs | 295.0 μs | 149.44 μs | 1,169.5 μs |   685.1 μs | 1,832.4 μs |   864.7 |   9.16 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 1,190.3 μs | 270.1 μs | 136.82 μs | 1,197.9 μs |   701.9 μs | 1,699.7 μs |   840.1 |  28.81 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      | 1,209.2 μs | 430.2 μs | 217.93 μs | 1,390.5 μs |   567.7 μs | 1,946.0 μs |   827.0 |   9.42 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      | 1,265.2 μs | 234.2 μs | 121.56 μs | 1,302.0 μs |   842.2 μs | 1,741.2 μs |   790.4 |  11.27 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  | 1,293.6 μs | 359.9 μs | 184.53 μs | 1,401.8 μs |   572.1 μs | 1,717.3 μs |   773.1 |  36.52 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      | 1,337.5 μs | 327.5 μs | 163.97 μs | 1,294.1 μs |   815.1 μs | 2,177.1 μs |   747.7 |   9.47 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,355.7 μs | 247.5 μs | 128.48 μs | 1,298.5 μs | 1,037.1 μs | 2,029.7 μs |   737.6 |   27.8 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,406.0 μs | 198.2 μs | 101.64 μs | 1,363.7 μs | 1,056.6 μs | 1,842.1 μs |   711.3 |  30.47 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  | 1,426.2 μs | 254.3 μs | 135.41 μs | 1,400.9 μs |   743.8 μs | 2,093.0 μs |   701.1 |  37.73 KB |
|                                   |                       |            |          |           |            |            |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,144.8 μs | 207.6 μs | 103.93 μs | 2,125.2 μs | 1,723.9 μs | 2,603.0 μs |   466.2 |   3.63 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,221.6 μs | 208.5 μs | 106.91 μs | 2,178.0 μs | 1,802.8 μs | 2,711.4 μs |   450.1 |   4.97 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,240.8 μs | 214.1 μs | 107.23 μs | 2,229.5 μs | 1,894.3 μs | 2,824.4 μs |   446.3 |   7.97 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,290.3 μs | 216.6 μs | 109.71 μs | 2,299.4 μs | 1,896.5 μs | 2,828.2 μs |   436.6 |   11.2 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,486.3 μs | 368.8 μs | 186.85 μs | 2,362.7 μs | 2,000.9 μs | 3,360.3 μs |   402.2 |   3.67 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,535.8 μs | 357.3 μs | 181.01 μs | 2,574.4 μs | 1,884.0 μs | 3,199.7 μs |   394.4 |  12.55 KB |
