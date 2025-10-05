# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26100.6725/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   692.7 μs | 133.01 μs |  68.19 μs |   670.8 μs |   509.5 μs | 1,067.6 μs | 1,443.7 |   7.25 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   706.9 μs | 115.61 μs |  58.57 μs |   684.6 μs |   562.8 μs | 1,047.1 μs | 1,414.5 |   8.81 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   713.0 μs |  86.90 μs |  44.55 μs |   700.2 μs |   565.4 μs |   917.3 μs | 1,402.5 |   7.28 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   727.6 μs | 133.01 μs |  68.20 μs |   689.2 μs |   544.8 μs | 1,131.6 μs | 1,374.4 |   8.77 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   731.4 μs | 149.82 μs |  76.81 μs |   726.9 μs |   537.8 μs | 1,131.7 μs | 1,367.2 |  10.62 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   738.0 μs | 125.45 μs |  65.11 μs |   731.3 μs |   499.1 μs | 1,094.4 μs | 1,355.1 |   7.25 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   741.2 μs | 142.75 μs |  72.32 μs |   722.9 μs |   517.0 μs | 1,052.9 μs | 1,349.1 |   7.28 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   749.5 μs | 112.59 μs |  57.04 μs |   740.0 μs |   575.5 μs |   981.5 μs | 1,334.3 |  10.62 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   751.4 μs | 191.07 μs | 100.42 μs |   704.1 μs |   508.7 μs | 1,215.0 μs | 1,330.9 |   7.25 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   760.2 μs | 155.11 μs |  80.51 μs |   734.4 μs |   563.4 μs | 1,104.3 μs | 1,315.4 |   7.55 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   769.4 μs | 149.42 μs |  77.55 μs |   756.5 μs |   550.6 μs | 1,101.5 μs | 1,299.7 |   7.55 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   771.4 μs | 176.49 μs |  91.60 μs |   724.9 μs |   560.5 μs | 1,208.1 μs | 1,296.3 |  10.84 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  |   772.1 μs | 148.51 μs |  76.14 μs |   753.3 μs |   568.6 μs | 1,211.7 μs | 1,295.1 |  35.89 KB |
| Single                            | InsightBenchmarkWrite |   776.2 μs | 164.56 μs |  83.37 μs |   743.9 μs |   531.1 μs | 1,171.4 μs | 1,288.4 |  10.31 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   777.2 μs | 170.87 μs |  86.56 μs |   733.3 μs |   549.6 μs | 1,113.3 μs | 1,286.7 |  10.62 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   780.4 μs | 119.18 μs |  61.86 μs |   769.1 μs |   551.7 μs | 1,090.0 μs | 1,281.5 |  11.88 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   781.8 μs | 108.35 μs |  56.24 μs |   790.4 μs |   609.9 μs | 1,075.5 μs | 1,279.0 |   8.81 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  |   788.5 μs | 171.16 μs |  86.71 μs |   738.0 μs |   568.1 μs | 1,178.3 μs | 1,268.2 |  35.86 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   789.0 μs | 137.00 μs |  68.60 μs |   781.5 μs |   564.0 μs | 1,249.8 μs | 1,267.5 |  11.83 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   789.4 μs | 123.64 μs |  61.21 μs |   778.0 μs |   568.9 μs | 1,089.5 μs | 1,266.9 |   8.75 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   794.1 μs | 161.37 μs |  81.75 μs |   747.0 μs |   551.0 μs | 1,128.0 μs | 1,259.3 |  10.34 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   803.5 μs | 137.16 μs |  70.32 μs |   779.7 μs |   610.9 μs | 1,250.0 μs | 1,244.6 |   7.25 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   806.8 μs | 139.79 μs |  71.67 μs |   798.4 μs |   561.4 μs | 1,104.4 μs | 1,239.4 |   8.77 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   807.3 μs | 140.55 μs |  72.06 μs |   786.4 μs |   574.2 μs | 1,253.2 μs | 1,238.7 |  10.95 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   814.2 μs | 119.15 μs |  60.36 μs |   817.3 μs |   518.1 μs | 1,046.3 μs | 1,228.2 |   7.28 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   824.9 μs | 162.72 μs |  84.45 μs |   798.1 μs |   544.8 μs | 1,314.3 μs | 1,212.3 |   7.28 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   837.8 μs | 167.78 μs |  85.00 μs |   817.1 μs |   566.1 μs | 1,280.0 μs | 1,193.6 |  12.17 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  |   838.9 μs | 105.28 μs |  55.34 μs |   821.3 μs |   686.0 μs | 1,145.9 μs | 1,192.1 |  37.42 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   840.9 μs | 126.83 μs |  65.03 μs |   832.6 μs |   600.7 μs | 1,131.0 μs | 1,189.2 |  12.17 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   843.7 μs | 231.27 μs | 118.58 μs |   781.6 μs |   515.4 μs | 1,594.3 μs | 1,185.3 |  10.62 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   846.7 μs | 211.67 μs | 108.52 μs |   791.2 μs |   525.9 μs | 1,254.0 μs | 1,181.0 |   7.55 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   849.7 μs | 217.66 μs | 107.75 μs |   785.8 μs |   590.2 μs | 1,488.3 μs | 1,176.9 |   8.77 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  |   850.7 μs | 200.14 μs | 101.39 μs |   779.6 μs |   612.2 μs | 1,370.9 μs | 1,175.5 |  37.07 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   856.3 μs | 303.14 μs | 153.57 μs |   756.3 μs |   500.9 μs | 1,589.5 μs | 1,167.8 |  10.34 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   859.1 μs | 183.63 μs |  94.15 μs |   853.5 μs |   571.6 μs | 1,293.8 μs | 1,164.0 |   8.77 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite |   869.1 μs | 111.68 μs |  55.92 μs |   872.3 μs |   693.1 μs | 1,115.1 μs | 1,150.6 |  26.13 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   876.1 μs | 215.71 μs | 110.60 μs |   888.0 μs |   568.3 μs | 1,300.7 μs | 1,141.4 |   7.55 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   883.5 μs | 151.65 μs |  76.83 μs |   856.8 μs |   604.4 μs | 1,223.2 μs | 1,131.9 |  11.52 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      |   887.1 μs | 132.91 μs |  67.33 μs |   870.8 μs |   697.1 μs | 1,191.8 μs | 1,127.2 |  26.13 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   917.7 μs | 306.14 μs | 155.09 μs |   820.2 μs |   547.9 μs | 1,566.4 μs | 1,089.7 |  10.95 KB |
| Single                            | InsightBenchmark      |   937.5 μs | 299.24 μs | 151.60 μs |   836.2 μs |   552.6 μs | 1,868.6 μs | 1,066.7 |  10.31 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   951.2 μs | 367.45 μs | 188.39 μs |   842.6 μs |   544.7 μs | 1,822.1 μs | 1,051.3 |  10.84 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   993.1 μs | 455.10 μs | 233.34 μs |   814.3 μs |   595.7 μs | 2,119.2 μs | 1,006.9 |  11.88 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,139.9 μs | 122.84 μs |  62.23 μs | 1,110.4 μs |   965.0 μs | 1,452.8 μs |   877.3 |  27.77 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      | 1,149.7 μs | 192.69 μs | 101.28 μs | 1,174.5 μs |   732.8 μs | 1,443.4 μs |   869.8 |   8.81 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,486.4 μs | 449.89 μs | 233.51 μs | 1,309.4 μs | 1,072.7 μs | 2,592.8 μs |   672.7 |  27.77 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 5,895.1 μs | 311.85 μs | 157.99 μs | 5,899.9 μs | 5,156.4 μs | 6,625.4 μs |   169.6 |   4.96 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 6,184.7 μs | 472.51 μs | 236.59 μs | 6,221.7 μs | 5,148.1 μs | 6,916.4 μs |   161.7 |   3.62 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 6,201.5 μs | 339.65 μs | 170.07 μs | 6,193.7 μs | 5,467.8 μs | 7,042.5 μs |   161.3 |  12.84 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 6,357.9 μs | 413.59 μs | 207.10 μs | 6,346.0 μs | 5,497.8 μs | 7,211.1 μs |   157.3 |   3.66 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 6,377.5 μs | 777.61 μs | 393.94 μs | 6,331.9 μs | 5,292.7 μs | 8,991.3 μs |   156.8 |   11.2 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 6,521.1 μs | 491.80 μs | 243.46 μs | 6,407.8 μs | 5,660.6 μs | 7,483.2 μs |   153.3 |   7.31 KB |
