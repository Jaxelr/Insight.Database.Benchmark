# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.3915/24H2/2024Update/HudsonValley)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                            | Type                  | Mean       | StdDev   | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|---------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |   647.7 μs | 164.7 μs |  84.46 μs |   588.5 μs |   482.8 μs | 1,220.0 μs | 1,543.9 |   8.94 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |   695.3 μs | 101.3 μs |  51.93 μs |   685.9 μs |   550.2 μs |   939.2 μs | 1,438.2 |  10.42 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |   698.2 μs | 132.6 μs |  66.41 μs |   682.2 μs |   499.7 μs |   985.5 μs | 1,432.2 |     12 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |   717.6 μs | 109.0 μs |  55.89 μs |   691.7 μs |   582.2 μs | 1,117.8 μs | 1,393.5 |   8.91 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |   729.7 μs | 147.7 μs |  74.81 μs |   718.3 μs |   510.1 μs | 1,187.7 μs | 1,370.5 |   12.6 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |   753.3 μs | 111.2 μs |  57.00 μs |   765.5 μs |   525.9 μs |   922.5 μs | 1,327.6 |   9.54 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |   799.6 μs | 295.0 μs | 151.23 μs |   701.2 μs |   473.8 μs | 1,530.5 μs | 1,250.6 |  12.32 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |   803.1 μs | 147.4 μs |  73.80 μs |   772.0 μs |   536.8 μs | 1,179.0 μs | 1,245.2 |   12.5 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |   810.1 μs | 162.6 μs |  84.41 μs |   802.2 μs |   541.9 μs | 1,190.8 μs | 1,234.4 |  13.53 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |   823.4 μs | 145.3 μs |  75.42 μs |   850.5 μs |   460.6 μs | 1,068.2 μs | 1,214.4 |   8.91 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |   867.2 μs | 177.1 μs |  88.67 μs |   822.5 μs |   588.0 μs | 1,277.0 μs | 1,153.2 |  14.13 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |   879.0 μs | 243.2 μs | 124.70 μs |   803.3 μs |   548.1 μs | 1,531.0 μs | 1,137.6 |  10.47 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |   930.0 μs | 107.8 μs |  55.95 μs |   940.1 μs |   602.6 μs | 1,106.8 μs | 1,075.2 |   12.5 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |   977.8 μs | 151.6 μs |  76.82 μs |   988.4 μs |   563.8 μs | 1,317.8 μs | 1,022.7 |   12.6 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |   980.1 μs | 127.4 μs |  65.33 μs |   964.9 μs |   766.4 μs | 1,357.9 μs | 1,020.4 |   8.91 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |   980.2 μs | 141.1 μs |  71.48 μs |   985.3 μs |   747.1 μs | 1,266.2 μs | 1,020.2 |   8.94 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      | 1,020.8 μs | 144.8 μs |  73.34 μs |   965.5 μs |   804.5 μs | 1,494.8 μs |   979.6 |  10.47 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite | 1,034.3 μs | 107.2 μs |  54.97 μs | 1,005.3 μs |   830.8 μs | 1,263.2 μs |   966.8 |  12.27 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite | 1,034.3 μs | 118.0 μs |  59.09 μs | 1,034.5 μs |   846.9 μs | 1,277.7 μs |   966.8 |     12 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      | 1,041.9 μs | 163.3 μs |  81.77 μs | 1,002.2 μs |   827.1 μs | 1,536.5 μs |   959.8 |  10.47 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite | 1,048.8 μs | 200.8 μs | 104.22 μs | 1,060.3 μs |   677.2 μs | 1,544.0 μs |   953.5 |  10.42 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      | 1,050.0 μs | 198.5 μs | 100.57 μs | 1,034.6 μs |   773.2 μs | 1,654.2 μs |   952.3 |   8.91 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      | 1,052.9 μs | 294.2 μs | 147.30 μs | 1,050.8 μs |   583.0 μs | 1,496.0 μs |   949.7 |   9.26 KB |
| Single                            | InsightBenchmark      | 1,057.1 μs | 148.7 μs |  77.18 μs | 1,024.8 μs |   828.8 μs | 1,461.6 μs |   946.0 |  11.97 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite | 1,084.5 μs | 129.8 μs |  64.97 μs | 1,086.2 μs |   789.2 μs | 1,410.7 μs |   922.1 |   9.26 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite | 1,107.0 μs | 160.8 μs |  79.59 μs | 1,101.3 μs |   759.8 μs | 1,613.3 μs |   903.3 |  13.83 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite | 1,112.3 μs | 220.7 μs | 109.26 μs | 1,052.9 μs |   770.5 μs | 1,668.0 μs |   899.0 |   8.94 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      | 1,120.3 μs | 229.0 μs | 117.39 μs | 1,114.5 μs |   728.0 μs | 1,587.0 μs |   892.6 |   8.66 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite | 1,133.2 μs | 152.0 μs |  76.99 μs | 1,134.0 μs |   816.2 μs | 1,407.0 μs |   882.5 |  13.83 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      | 1,143.8 μs | 207.4 μs | 105.09 μs | 1,156.9 μs |   787.6 μs | 1,671.0 μs |   874.3 |  10.12 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite | 1,166.4 μs | 165.8 μs |  83.01 μs | 1,141.3 μs |   936.5 μs | 1,619.1 μs |   857.3 |  13.23 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite | 1,167.6 μs | 167.4 μs |  83.81 μs | 1,172.7 μs |   678.3 μs | 1,539.3 μs |   856.5 |   12.6 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 1,170.7 μs | 218.1 μs | 111.81 μs | 1,236.0 μs |   739.2 μs | 1,531.2 μs |   854.2 |  27.79 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      | 1,171.5 μs | 197.6 μs |  98.93 μs | 1,159.5 μs |   854.0 μs | 1,715.5 μs |   853.6 |   12.9 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,187.2 μs | 119.0 μs |  61.78 μs | 1,199.0 μs |   969.5 μs | 1,480.0 μs |   842.3 |   9.54 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite | 1,198.9 μs | 250.4 μs | 125.40 μs | 1,242.7 μs |   580.6 μs | 1,766.5 μs |   834.1 |  10.47 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite | 1,212.0 μs | 174.1 μs |  88.20 μs | 1,168.4 μs |   854.0 μs | 1,667.2 μs |   825.1 |  12.27 KB |
| Single                            | InsightBenchmarkWrite | 1,239.6 μs | 200.8 μs | 100.53 μs | 1,261.3 μs |   865.8 μs | 1,545.1 μs |   806.7 |  12.34 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite | 1,248.4 μs | 143.3 μs |  72.58 μs | 1,243.3 μs |   956.8 μs | 1,563.6 μs |   801.0 |  10.12 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  | 1,283.2 μs | 149.9 μs |  75.03 μs | 1,251.0 μs |   990.6 μs | 1,596.7 μs |   779.3 |   38.2 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 1,325.7 μs | 172.4 μs |  87.34 μs | 1,340.9 μs |   931.1 μs | 1,754.2 μs |   754.3 |  30.46 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  | 1,336.0 μs | 204.1 μs | 103.38 μs | 1,368.6 μs |   831.0 μs | 1,752.3 μs |   748.5 |  38.16 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 1,352.6 μs | 204.9 μs | 112.03 μs | 1,365.4 μs | 1,021.7 μs | 1,701.8 μs |   739.3 |  29.42 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  | 1,365.0 μs | 156.6 μs |  81.28 μs | 1,373.6 μs |   978.2 μs | 1,702.0 μs |   732.6 |  39.73 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  | 1,454.4 μs | 145.7 μs |  72.97 μs | 1,439.8 μs | 1,207.8 μs | 1,762.5 μs |   687.6 |   39.4 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 2,024.7 μs | 265.8 μs | 137.96 μs | 2,112.4 μs | 1,544.5 μs | 2,480.7 μs |   493.9 |  32.09 KB |
|                                   |                       |            |          |           |            |            |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,586.5 μs | 238.4 μs | 119.39 μs | 2,549.1 μs | 2,160.2 μs | 3,016.4 μs |   386.6 |   4.95 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 2,683.5 μs | 219.9 μs | 111.43 μs | 2,710.6 μs | 2,220.0 μs | 3,142.7 μs |   372.6 |   4.71 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 2,758.9 μs | 258.9 μs | 132.74 μs | 2,754.5 μs | 2,129.7 μs | 3,381.2 μs |   362.5 |  12.57 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 2,838.5 μs | 255.4 μs | 129.39 μs | 2,815.8 μs | 2,314.2 μs | 3,392.4 μs |   352.3 |   6.29 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 3,037.7 μs | 290.0 μs | 146.90 μs | 3,084.2 μs | 2,305.4 μs | 3,581.4 μs |   329.2 |   14.5 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 3,097.3 μs | 276.5 μs | 141.76 μs | 3,076.7 μs | 2,317.0 μs | 3,677.1 μs |   322.9 |   9.62 KB |
