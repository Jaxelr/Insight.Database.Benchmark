# Insight.Database.Benchmarks.Sqlite

These are benchmark scenarios for the Default Provider of [Insight.Database](https://github.com/jonwagner/Insight.Database) using Sqlite as a database

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7705/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4


```
| Method                            | Type                  | Mean        | StdDev    | Error     | Median      | Min         | Max         | Op/s     | Allocated |
|---------------------------------- |---------------------- |------------:|----------:|----------:|------------:|------------:|------------:|---------:|----------:|
| &#39;Single (dynamic)&#39;                | InsightBenchmark      |    133.7 μs |  12.01 μs |   6.31 μs |    131.6 μs |    113.0 μs |    173.4 μs | 7,480.18 |   7.66 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmark      |    140.7 μs |  21.90 μs |  11.51 μs |    136.2 μs |    117.0 μs |    256.5 μs | 7,107.10 |   7.64 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmarkWrite |    140.9 μs |  11.61 μs |   6.26 μs |    137.8 μs |    117.3 μs |    167.6 μs | 7,096.30 |   8.09 KB |
| Query&lt;T&gt;                          | InsightBenchmark      |    141.5 μs |  12.59 μs |   6.70 μs |    137.2 μs |    123.3 μs |    178.0 μs | 7,066.80 |   7.82 KB |
| &#39;Query&lt;T&gt; (dynamic)&#39;              | InsightBenchmarkWrite |    141.7 μs |  19.71 μs |  10.36 μs |    135.9 μs |    111.4 μs |    202.2 μs | 7,057.66 |   7.64 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmark      |    142.2 μs |  18.35 μs |   9.64 μs |    136.7 μs |    117.9 μs |    212.4 μs | 7,031.30 |   7.64 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmark      |    142.5 μs |  19.12 μs |  10.05 μs |    139.4 μs |    112.0 μs |    190.7 μs | 7,019.84 |   7.96 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmarkWrite |    142.6 μs |  16.25 μs |   8.54 μs |    138.7 μs |    121.7 μs |    208.5 μs | 7,011.97 |   8.14 KB |
| &#39;Query&lt;T&gt; (Fast Expando)&#39;         | InsightBenchmarkWrite |    142.9 μs |  23.23 μs |  12.37 μs |    133.7 μs |    115.2 μs |    225.7 μs | 7,000.13 |   7.64 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmark      |    143.3 μs |  22.54 μs |  11.85 μs |    136.2 μs |    116.0 μs |    223.4 μs | 6,977.23 |   7.96 KB |
| Single                            | InsightBenchmarkWrite |    144.2 μs |  23.00 μs |  12.09 μs |    135.5 μs |    117.2 μs |    208.5 μs | 6,932.89 |   7.84 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmarkWrite |    144.3 μs |  15.46 μs |   8.03 μs |    139.0 μs |    126.1 μs |    189.9 μs | 6,930.63 |   8.09 KB |
| &#39;Single Async&#39;                    | InsightBenchmarkWrite |    144.3 μs |  18.53 μs |  10.00 μs |    138.7 μs |    118.5 μs |    194.5 μs | 6,927.94 |   8.27 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmarkWrite |    144.5 μs |  16.23 μs |   8.32 μs |    138.3 μs |    122.9 μs |    197.7 μs | 6,922.35 |   8.09 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmarkWrite |    145.6 μs |  17.62 μs |   9.38 μs |    144.1 μs |    118.7 μs |    206.9 μs | 6,868.24 |   8.76 KB |
| Query&lt;T&gt;                          | InsightBenchmarkWrite |    146.5 μs |  21.66 μs |  11.53 μs |    139.6 μs |    117.8 μs |    217.6 μs | 6,825.73 |   7.82 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmarkWrite |    147.6 μs |  20.68 μs |  10.73 μs |    139.2 μs |    126.1 μs |    208.7 μs | 6,775.07 |   8.09 KB |
| &#39;Auto Interface Single&#39;           | InsightBenchmark      |    147.8 μs |  18.02 μs |   9.59 μs |    141.1 μs |    128.1 μs |    204.6 μs | 6,763.77 |   8.14 KB |
| &#39;Auto Interface Query (dynamic)&#39;  | InsightBenchmarkWrite |    150.8 μs |  22.36 μs |  11.75 μs |    142.0 μs |    118.9 μs |    207.2 μs | 6,630.32 |   7.96 KB |
| &#39;Single Async (dynamic)&#39;          | InsightBenchmark      |    151.2 μs |  22.11 μs |  11.34 μs |    149.2 μs |    116.6 μs |    212.3 μs | 6,612.59 |   8.09 KB |
| Single                            | InsightBenchmark      |    151.7 μs |  29.04 μs |  15.26 μs |    140.6 μs |    126.4 μs |    245.7 μs | 6,589.83 |   7.84 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmarkWrite |    152.0 μs |  21.01 μs |  11.19 μs |    146.6 μs |    118.4 μs |    214.8 μs | 6,578.06 |   8.14 KB |
| &#39;Auto Interface Query&#39;            | InsightBenchmark      |    152.0 μs |  23.15 μs |  12.01 μs |    143.4 μs |    116.9 μs |    216.2 μs | 6,578.01 |   8.14 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmarkWrite |    152.1 μs |  33.09 μs |  17.62 μs |    135.1 μs |    112.8 μs |    226.6 μs | 6,575.06 |   7.66 KB |
| &#39;Single (Fast Expando)&#39;           | InsightBenchmark      |    152.3 μs |  32.05 μs |  16.43 μs |    143.7 μs |    113.0 μs |    258.4 μs | 6,564.38 |   7.66 KB |
| &#39;Single (dynamic)&#39;                | InsightBenchmarkWrite |    153.4 μs |  27.87 μs |  15.03 μs |    144.2 μs |    112.2 μs |    218.8 μs | 6,520.88 |   7.66 KB |
| &#39;Single Async (Fast Expando)&#39;     | InsightBenchmark      |    153.4 μs |  26.85 μs |  14.29 μs |    141.2 μs |    118.9 μs |    238.6 μs | 6,519.10 |   8.09 KB |
| &#39;Query&lt;T&gt; Async (Fast Expando)&#39;   | InsightBenchmark      |    153.8 μs |  21.63 μs |  11.09 μs |    144.6 μs |    125.1 μs |    203.4 μs | 6,500.51 |   8.09 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmark      |    154.3 μs |  19.52 μs |  10.13 μs |    148.2 μs |    126.0 μs |    214.8 μs | 6,481.06 |   8.81 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmark      |    156.0 μs |  19.57 μs |  10.16 μs |    148.4 μs |    127.8 μs |    202.0 μs | 6,411.28 |   8.27 KB |
| &#39;Single Async&#39;                    | InsightBenchmark      |    156.8 μs |  26.84 μs |  14.11 μs |    150.2 μs |    115.0 μs |    218.1 μs | 6,376.29 |   8.27 KB |
| &#39;Query&lt;T&gt; Async&#39;                  | InsightBenchmarkWrite |    158.3 μs |  31.68 μs |  16.65 μs |    147.8 μs |    116.2 μs |    255.1 μs | 6,316.90 |   8.27 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |    158.5 μs |  23.26 μs |  11.92 μs |    154.0 μs |    125.7 μs |    227.8 μs | 6,310.67 |    9.3 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |    158.8 μs |  21.28 μs |  11.33 μs |    152.4 μs |    133.1 μs |    250.0 μs | 6,297.32 |   9.26 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmarkWrite |    159.8 μs |  21.61 μs |  11.66 μs |    151.8 μs |    129.1 μs |    220.8 μs | 6,258.05 |   9.26 KB |
| &#39;Single Async (Tuple)&#39;            | InsightBenchmark      |    159.8 μs |  28.23 μs |  14.47 μs |    151.9 μs |    124.9 μs |    230.3 μs | 6,257.07 |    9.3 KB |
| &#39;Query&lt;T&gt; Async (dynamic)&#39;        | InsightBenchmark      |    162.1 μs |  62.50 μs |  32.85 μs |    141.1 μs |    117.4 μs |    395.6 μs | 6,170.47 |   8.09 KB |
| &#39;Single (Tuple)&#39;                  | InsightBenchmark      |    164.2 μs |  25.91 μs |  13.28 μs |    153.5 μs |    128.0 μs |    238.3 μs | 6,091.87 |   8.76 KB |
| Query&lt;(Tuple)&gt;                    | InsightBenchmarkWrite |    172.2 μs |  42.15 μs |  21.88 μs |    160.8 μs |    132.9 μs |    376.3 μs | 5,808.85 |   8.81 KB |
| &#39;Auto Interface Single (dynamic)&#39; | InsightBenchmarkWrite |    183.2 μs |  83.96 μs |  44.70 μs |    141.0 μs |    117.8 μs |    449.1 μs | 5,459.77 |   7.96 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmark      |  3,130.8 μs | 285.40 μs | 148.13 μs |  3,055.7 μs |  2,852.0 μs |  4,284.7 μs |   319.41 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39;  | InsightBenchmarkWrite |  3,192.6 μs | 322.08 μs | 167.17 μs |  3,071.2 μs |  2,809.7 μs |  4,025.0 μs |   313.22 |  21.97 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmark      |  3,419.2 μs | 204.12 μs | 107.29 μs |  3,368.2 μs |  3,170.3 μs |  4,039.7 μs |   292.46 |  22.95 KB |
| &#39;Query&lt;T&gt; Parent/Child&#39;           | InsightBenchmarkWrite |  3,518.8 μs | 294.27 μs | 147.35 μs |  3,402.7 μs |  3,164.8 μs |  4,190.7 μs |   284.19 |  22.95 KB |
|                                   |                       |             |           |           |             |             |             |          |           |
| &#39;Update&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 15,368.8 μs | 468.08 μs | 234.38 μs | 15,378.7 μs | 14,090.7 μs | 16,590.4 μs |    65.07 |   6.92 KB |
| &#39;Insert&lt;T&gt; Async&#39;                 | InsightBenchmarkWrite | 15,527.7 μs | 521.78 μs | 267.52 μs | 15,685.4 μs | 14,149.8 μs | 16,204.0 μs |    64.40 |   6.69 KB |
| Update&lt;T&gt;                         | InsightBenchmarkWrite | 15,628.0 μs | 403.43 μs | 204.38 μs | 15,604.3 μs | 14,780.9 μs | 16,502.0 μs |    63.99 |   6.37 KB |
| Insert&lt;T&gt;                         | InsightBenchmarkWrite | 15,664.9 μs | 488.64 μs | 253.62 μs | 15,765.9 μs | 14,231.1 μs | 16,428.3 μs |    63.84 |   6.11 KB |
