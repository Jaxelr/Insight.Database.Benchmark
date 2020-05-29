# Insight.Database.Benchmark

[![Build status][build-svg]][build]

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Results for SQL Server Benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]   : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

Type=InsightBenchmark  

```
|                           Method |       Mean |      StdDev |     Error |        Min |         Max |    Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------------- |-----------:|------------:|----------:|-----------:|------------:|--------:|------:|------:|------:|----------:|
|                           Single |   408.4 μs |    50.24 μs |  27.11 μs |   338.6 μs |    578.8 μs | 2,448.6 |     - |     - |     - |  21.31 KB |
|          &#39;Auto Interface Single&#39; |   423.3 μs |    59.01 μs |  31.01 μs |   345.2 μs |    613.8 μs | 2,362.5 |     - |     - |     - |  21.62 KB |
|           &#39;Auto Interface Query&#39; |   436.0 μs |   114.81 μs |  62.79 μs |   346.8 μs |    909.4 μs | 2,293.8 |     - |     - |     - |  21.62 KB |
|                         Query&lt;T&gt; |   485.1 μs |   159.52 μs |  82.79 μs |   343.8 μs |    993.1 μs | 2,061.5 |     - |     - |     - |   21.3 KB |
|                   &#39;Single Async&#39; |   548.7 μs |    51.77 μs |  28.31 μs |   460.2 μs |    675.8 μs | 1,822.4 |     - |     - |     - |  24.44 KB |
|                 &#39;Query&lt;T&gt; Async&#39; |   617.2 μs |   281.60 μs | 146.16 μs |   440.9 μs |  1,860.8 μs | 1,620.3 |     - |     - |     - |  25.04 KB |
|          &#39;Query&lt;T&gt; Parent/Child&#39; | 9,247.4 μs | 1,173.06 μs | 594.28 μs | 7,851.9 μs | 12,970.8 μs |   108.1 |     - |     - |     - |  43.68 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39; | 9,288.1 μs | 1,718.65 μs | 860.57 μs | 7,412.3 μs | 14,244.0 μs |   107.7 |     - |     - |     - |  43.72 KB |
|                                  |            |             |           |            |             |         |       |       |       |           |
|                        Insert&lt;T&gt; |   775.9 μs |   182.14 μs |  96.97 μs |   559.5 μs |  1,449.5 μs | 1,288.9 |     - |     - |     - |   6.46 KB |
|                        Update&lt;T&gt; |   811.2 μs |   179.71 μs |  96.95 μs |   643.8 μs |  1,699.0 μs | 1,232.7 |     - |     - |     - |  24.23 KB |
|                &#39;Update&lt;T&gt; Async&#39; |   906.2 μs |   110.67 μs |  58.17 μs |   758.6 μs |  1,205.8 μs | 1,103.5 |     - |     - |     - |  27.35 KB |
|                &#39;Insert&lt;T&gt; Async&#39; |   991.7 μs |   277.99 μs | 146.11 μs |   686.4 μs |  1,843.0 μs | 1,008.4 |     - |     - |     - |  10.09 KB |


## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.

[build]: https://ci.appveyor.com/project/Jaxelr/insight-database-benchmark/branch/master?fullLog=true
[build-svg]: https://ci.appveyor.com/api/projects/status/5ljodk64tubam5i5?svg=true
