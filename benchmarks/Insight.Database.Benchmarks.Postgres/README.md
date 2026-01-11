# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean       | StdDev    | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |   605.6 μs | 101.18 μs |  51.87 μs |   583.5 μs |   479.7 μs |   912.9 μs | 1,651.4 |   7.29 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   623.1 μs | 123.03 μs |  63.86 μs |   572.5 μs |   458.7 μs |   891.0 μs | 1,605.0 |   7.26 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   624.1 μs | 105.59 μs |  56.22 μs |   581.5 μs |   502.9 μs |   899.3 μs | 1,602.2 |   7.29 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   656.3 μs | 101.62 μs |  53.41 μs |   633.8 μs |   532.5 μs |   918.5 μs | 1,523.7 |   7.56 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   661.0 μs | 123.49 μs |  64.09 μs |   627.4 μs |   501.3 μs |   978.5 μs | 1,512.8 |   7.26 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |   661.8 μs | 113.95 μs |  58.42 μs |   659.6 μs |   493.3 μs |   920.8 μs | 1,511.1 |   7.56 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |   664.6 μs | 112.99 μs |  55.93 μs |   640.2 μs |   490.4 μs |   939.9 μs | 1,504.7 |   7.29 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   674.9 μs | 129.05 μs |  66.98 μs |   627.7 μs |   544.1 μs | 1,088.0 μs | 1,481.8 |  10.86 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |   675.9 μs |  87.90 μs |  47.42 μs |   679.4 μs |   522.2 μs |   893.1 μs | 1,479.4 |  11.88 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |   676.2 μs | 128.26 μs |  64.98 μs |   694.8 μs |   513.2 μs |   940.9 μs | 1,478.9 |   7.26 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  |   676.5 μs | 111.67 μs |  60.24 μs |   642.0 μs |   536.5 μs |   918.5 μs | 1,478.1 |  35.87 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   686.8 μs | 169.77 μs |  87.04 μs |   618.0 μs |   503.9 μs | 1,233.8 μs | 1,456.0 |   7.26 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   690.2 μs | 118.38 μs |  61.44 μs |   695.6 μs |   513.9 μs |   957.1 μs | 1,448.9 |   7.29 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |   694.5 μs | 103.96 μs |  52.67 μs |   683.1 μs |   540.6 μs | 1,010.8 μs | 1,439.8 |   8.77 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   697.7 μs | 113.61 μs |  58.97 μs |   687.5 μs |   537.8 μs |   979.6 μs | 1,433.4 |  10.63 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |   700.0 μs | 111.05 μs |  58.37 μs |   723.1 μs |   487.9 μs |   960.7 μs | 1,428.6 |  10.63 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |   700.4 μs | 110.15 μs |  56.47 μs |   670.8 μs |   551.5 μs |   981.9 μs | 1,427.7 |   8.77 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |   702.6 μs | 119.98 μs |  60.78 μs |   690.9 μs |   519.0 μs | 1,005.2 μs | 1,423.3 |   7.56 KB |
| Single                            | InsightBenchmarkWrite |   705.0 μs |  72.80 μs |  38.27 μs |   691.9 μs |   556.2 μs |   843.8 μs | 1,418.5 |  10.32 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   715.5 μs | 157.85 μs |  81.93 μs |   709.7 μs |   514.7 μs | 1,219.8 μs | 1,397.6 |  10.63 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |   715.6 μs | 129.49 μs |  66.39 μs |   676.3 μs |   546.5 μs | 1,161.2 μs | 1,397.5 |   8.82 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |   727.6 μs | 146.73 μs |  74.33 μs |   706.9 μs |   539.9 μs | 1,148.2 μs | 1,374.4 |   8.82 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |   732.6 μs | 224.55 μs | 112.44 μs |   685.8 μs |   488.1 μs | 1,424.3 μs | 1,365.1 |   7.56 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   749.9 μs | 114.76 μs |  58.84 μs |   722.3 μs |   577.6 μs | 1,040.5 μs | 1,333.5 |  10.86 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |   751.1 μs |  78.70 μs |  41.36 μs |   749.5 μs |   611.1 μs |   923.2 μs | 1,331.3 |  11.84 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  |   754.3 μs | 130.97 μs |  66.35 μs |   711.4 μs |   611.0 μs | 1,210.3 μs | 1,325.8 |  37.13 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   754.6 μs | 197.25 μs | 101.13 μs |   721.0 μs |   504.2 μs | 1,492.3 μs | 1,325.2 |  10.35 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   756.3 μs | 122.43 μs |  62.77 μs |   762.0 μs |   521.3 μs |   998.5 μs | 1,322.2 |   8.82 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   756.4 μs | 120.85 μs |  63.52 μs |   743.9 μs |   556.2 μs | 1,020.6 μs | 1,322.0 |  11.88 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |   757.1 μs | 104.49 μs |  54.24 μs |   759.8 μs |   589.3 μs |   979.2 μs | 1,320.8 |  10.35 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  |   757.4 μs | 146.46 μs |  74.20 μs |   737.1 μs |   556.2 μs | 1,195.6 μs | 1,320.3 |   35.9 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   760.0 μs | 129.53 μs |  67.23 μs |   729.7 μs |   566.8 μs | 1,115.4 μs | 1,315.7 |   8.77 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |   768.3 μs | 150.72 μs |  75.47 μs |   765.9 μs |   541.6 μs | 1,137.2 μs | 1,301.6 |  10.96 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   768.4 μs | 143.54 μs |  75.44 μs |   767.9 μs |   543.1 μs | 1,036.9 μs | 1,301.5 |  10.96 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |   768.6 μs | 145.96 μs |  72.26 μs |   763.8 μs |   556.3 μs | 1,104.4 μs | 1,301.0 |   8.77 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  |   773.5 μs | 143.01 μs |  75.16 μs |   745.9 μs |   581.3 μs | 1,139.9 μs | 1,292.9 |  37.38 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |   784.9 μs | 161.29 μs |  82.69 μs |   748.7 μs |   575.8 μs | 1,180.6 μs | 1,274.0 |   8.82 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |   785.4 μs |  98.82 μs |  51.29 μs |   763.4 μs |   617.4 μs | 1,017.3 μs | 1,273.2 |  12.49 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite |   800.1 μs |  97.13 μs |  50.41 μs |   781.6 μs |   683.2 μs | 1,094.6 μs | 1,249.9 |  26.14 KB |
| Single                            | InsightBenchmark      |   803.1 μs | 198.37 μs | 100.50 μs |   755.2 μs |   537.8 μs | 1,375.7 μs | 1,245.2 |  10.32 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |   805.1 μs | 175.55 μs |  91.11 μs |   786.8 μs |   543.1 μs | 1,206.2 μs | 1,242.1 |  10.63 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |   819.7 μs | 151.14 μs |  77.49 μs |   790.3 μs |   608.8 μs | 1,294.9 μs | 1,219.9 |  11.84 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   829.9 μs | 126.50 μs |  64.09 μs |   805.4 μs |   584.1 μs | 1,220.6 μs | 1,205.0 |  12.49 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      |   878.9 μs | 174.62 μs |  88.47 μs |   866.4 μs |   643.7 μs | 1,388.4 μs | 1,137.8 |  26.14 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 1,195.9 μs | 147.11 μs |  75.42 μs | 1,180.3 μs |   909.4 μs | 1,620.0 μs |   836.2 |   27.8 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,250.4 μs | 182.38 μs |  92.40 μs | 1,252.8 μs |   922.0 μs | 1,763.3 μs |   799.7 |   27.8 KB |
|                                   |                       |            |           |           |            |            |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,065.3 μs | 204.92 μs | 103.82 μs | 2,112.9 μs | 1,673.6 μs | 2,515.4 μs |   484.2 |   3.63 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,071.2 μs | 183.89 μs |  94.28 μs | 2,032.2 μs | 1,830.8 μs | 2,550.7 μs |   482.8 |   3.67 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,138.1 μs | 167.51 μs |  84.86 μs | 2,074.9 μs | 1,933.7 μs | 2,608.6 μs |   467.7 |   7.32 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,206.4 μs | 212.46 μs | 110.27 μs | 2,167.8 μs | 1,863.4 μs | 2,701.1 μs |   453.2 |   5.27 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,249.1 μs | 222.25 μs | 111.28 μs | 2,208.1 μs | 1,913.3 μs | 2,740.8 μs |   444.6 |   11.2 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,323.9 μs | 323.13 μs | 161.80 μs | 2,232.7 μs | 1,923.3 μs | 3,290.0 μs |   430.3 |  12.85 KB |
