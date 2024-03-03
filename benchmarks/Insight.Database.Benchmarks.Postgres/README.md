# Insight.Database.Benchmarks.Postgres

These are benchmark scenarios for the Postgres Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) running over Postgresql version 12.4.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3155/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2


```
| Method                            | Type                  | Mean       | StdDev     | Error     | Median     | Min        | Max        | Op/s    | Allocated |
|---------------------------------- |---------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|--------:|----------:|
| Query&lt;T&gt;                          | InsightBenchmark      |   986.7 μs |   109.5 μs |  56.15 μs |   962.8 μs |   815.0 μs | 1,256.5 μs | 1,013.4 |  13.35 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      | 1,025.1 μs |   129.7 μs |  65.72 μs | 1,017.5 μs |   816.2 μs | 1,335.0 μs |   975.5 |   9.22 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      | 1,168.5 μs |   170.4 μs |  87.35 μs | 1,139.2 μs |   928.1 μs | 1,582.2 μs |   855.8 |  15.28 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      | 1,186.5 μs |   235.3 μs | 120.66 μs | 1,147.2 μs |   775.8 μs | 1,690.0 μs |   842.8 |    9.2 KB |
| Single                            | InsightBenchmark      | 1,195.6 μs |   158.0 μs |  79.09 μs | 1,187.3 μs |   901.0 μs | 1,633.2 μs |   836.4 |  13.34 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      | 1,203.4 μs |   248.2 μs | 128.81 μs | 1,161.5 μs |   854.1 μs | 1,737.6 μs |   831.0 |   9.51 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmark      | 1,203.8 μs |   406.5 μs | 205.94 μs |   976.8 μs |   748.3 μs | 2,457.4 μs |   830.7 |    9.2 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite | 1,222.0 μs |   225.4 μs | 116.98 μs | 1,250.0 μs |   849.3 μs | 2,027.4 μs |   818.3 |   9.51 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      | 1,294.2 μs |   248.7 μs | 124.55 μs | 1,281.7 μs |   938.1 μs | 1,835.0 μs |   772.7 |  10.88 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      | 1,310.8 μs |   282.7 μs | 143.23 μs | 1,278.5 μs |   777.1 μs | 1,888.0 μs |   762.9 |   9.22 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite | 1,311.5 μs |   267.4 μs | 133.87 μs | 1,341.5 μs |   909.9 μs | 1,862.9 μs |   762.5 |   9.22 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite | 1,316.0 μs |   241.0 μs | 123.59 μs | 1,349.7 μs |   852.5 μs | 1,814.9 μs |   759.9 |  13.35 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite | 1,336.7 μs |   250.1 μs | 128.22 μs | 1,361.9 μs |   945.0 μs | 1,847.5 μs |   748.1 |   9.51 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite | 1,352.0 μs |   215.2 μs | 109.02 μs | 1,363.5 μs |   885.2 μs | 1,770.5 μs |   739.7 |  10.88 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite | 1,370.4 μs |   208.2 μs | 106.74 μs | 1,412.6 μs |   965.0 μs | 1,732.3 μs |   729.7 |   13.5 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      | 1,383.5 μs |   234.4 μs | 121.65 μs | 1,329.5 μs | 1,027.7 μs | 1,956.1 μs |   722.8 |  10.84 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite | 1,386.2 μs |   264.5 μs | 132.45 μs | 1,425.0 μs |   840.1 μs | 1,894.1 μs |   721.4 |    9.2 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite | 1,387.8 μs |   235.6 μs | 120.78 μs | 1,378.0 μs |   939.1 μs | 2,031.5 μs |   720.6 |  10.88 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite | 1,389.9 μs |   179.9 μs |  92.24 μs | 1,323.7 μs | 1,088.2 μs | 1,894.5 μs |   719.5 |   9.22 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite | 1,395.6 μs |   179.2 μs |  89.75 μs | 1,364.8 μs |   999.0 μs | 2,019.1 μs |   716.5 |  10.84 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      | 1,431.0 μs |   274.7 μs | 139.15 μs | 1,386.0 μs |   924.5 μs | 2,123.0 μs |   698.8 |  14.98 KB |
| Single                            | InsightBenchmarkWrite | 1,434.0 μs |   232.1 μs | 122.01 μs | 1,377.4 μs | 1,163.2 μs | 2,050.8 μs |   697.3 |  13.34 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite | 1,435.0 μs |   287.6 μs | 149.27 μs | 1,473.0 μs |   856.9 μs | 2,144.2 μs |   696.8 |  13.59 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite | 1,437.9 μs |   185.3 μs |  92.77 μs | 1,400.0 μs | 1,143.5 μs | 1,927.0 μs |   695.4 |    9.2 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite | 1,453.6 μs |   297.7 μs | 147.38 μs | 1,472.7 μs |   946.7 μs | 2,059.5 μs |   687.9 |  15.26 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      | 1,459.7 μs |   242.2 μs | 122.72 μs | 1,414.4 μs |   955.5 μs | 1,968.6 μs |   685.1 |  13.64 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite | 1,474.2 μs |   193.0 μs |  97.75 μs | 1,485.4 μs |   933.0 μs | 1,797.2 μs |   678.3 |  15.25 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite | 1,488.7 μs |   275.0 μs | 139.32 μs | 1,545.8 μs |   862.3 μs | 1,968.5 μs |   671.7 |  10.84 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      | 1,492.8 μs |   264.7 μs | 135.71 μs | 1,526.2 μs |   925.1 μs | 2,014.7 μs |   669.9 |  13.59 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      | 1,492.9 μs |   273.7 μs | 135.49 μs | 1,538.0 μs |   872.3 μs | 1,913.3 μs |   669.8 |  13.64 KB |
| &#39;Single json&#39;                     | InsightBenchmarkJson  | 1,505.0 μs |   256.1 μs | 126.80 μs | 1,541.3 μs |   886.0 μs | 2,002.8 μs |   664.5 |     39 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite | 1,510.1 μs |   275.5 μs | 137.95 μs | 1,493.1 μs | 1,032.5 μs | 2,205.1 μs |   662.2 |  15.01 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite | 1,517.9 μs |   285.5 μs | 141.31 μs | 1,475.7 μs | 1,006.0 μs | 2,094.1 μs |   658.8 |  13.64 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite | 1,521.3 μs |   240.9 μs | 125.04 μs | 1,531.3 μs | 1,158.8 μs | 2,015.8 μs |   657.4 |  13.64 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      | 1,538.0 μs |   192.2 μs |  99.77 μs | 1,492.5 μs | 1,246.4 μs | 2,020.3 μs |   650.2 |  10.84 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      | 1,543.9 μs |   223.4 μs | 111.88 μs | 1,505.5 μs | 1,108.4 μs | 2,073.8 μs |   647.7 |   9.51 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      | 1,547.0 μs |   233.4 μs | 116.89 μs | 1,548.7 μs | 1,163.7 μs | 2,147.6 μs |   646.4 |  10.88 KB |
| &#39;Query&lt;T&gt; json&#39;                   | InsightBenchmarkJson  | 1,548.2 μs |   293.5 μs | 146.94 μs | 1,485.2 μs | 1,024.7 μs | 2,124.8 μs |   645.9 |  39.02 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      | 1,585.3 μs |   176.2 μs |  89.28 μs | 1,596.5 μs | 1,306.8 μs | 1,956.0 μs |   630.8 |  15.26 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite | 1,618.8 μs |   282.1 μs | 141.25 μs | 1,665.8 μs |   998.7 μs | 2,079.1 μs |   617.7 |  31.78 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      | 1,631.6 μs |   158.4 μs |  83.28 μs | 1,655.3 μs | 1,333.2 μs | 2,000.9 μs |   612.9 |   13.5 KB |
| &#39;Query&lt;T&gt; Async json&#39;             | InsightBenchmarkJson  | 1,646.8 μs |   382.1 μs | 193.56 μs | 1,599.4 μs | 1,087.3 μs | 2,523.8 μs |   607.2 |  40.67 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      | 1,664.1 μs |   230.5 μs | 114.13 μs | 1,711.1 μs | 1,161.5 μs | 2,121.2 μs |   600.9 |  31.78 KB |
| &#39;Single Async json&#39;               | InsightBenchmarkJson  | 1,739.2 μs |   267.7 μs | 134.02 μs | 1,786.0 μs | 1,074.5 μs | 2,198.8 μs |   575.0 |  40.64 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite | 2,101.2 μs |   298.7 μs | 153.13 μs | 2,106.9 μs | 1,537.7 μs | 2,664.5 μs |   475.9 |  33.35 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      | 2,186.9 μs |   280.7 μs | 142.21 μs | 2,255.7 μs | 1,514.3 μs | 2,675.9 μs |   457.3 |  33.35 KB |
|                                   |                       |            |            |           |            |            |            |         |           |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 2,546.5 μs |   238.1 μs | 123.61 μs | 2,518.3 μs | 2,244.6 μs | 3,336.2 μs |   392.7 |   4.66 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 3,117.3 μs |   511.5 μs | 259.15 μs | 3,041.9 μs | 2,046.1 μs | 4,256.9 μs |   320.8 |    6.7 KB |
| &#39;Insert&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 3,224.6 μs |   431.3 μs | 218.52 μs | 3,094.0 μs | 2,556.6 μs | 4,094.8 μs |   310.1 |   4.73 KB |
| &#39;Update&lt;T&gt; json&#39;                  | InsightBenchmarkJson  | 3,343.7 μs |   321.2 μs | 159.01 μs | 3,309.1 μs | 2,780.2 μs | 4,121.3 μs |   299.1 |  10.82 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 3,404.2 μs |   317.3 μs | 158.88 μs | 3,441.4 μs | 2,835.7 μs | 4,078.6 μs |   293.8 |   14.7 KB |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 3,968.2 μs | 1,084.2 μs | 536.73 μs | 3,843.1 μs | 2,789.2 μs | 8,723.1 μs |   252.0 |  16.47 KB |
