# Insight.Database.Benchmark

[![Build status][build-svg]][build]

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Results for SQL Server Benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.301
  [Host]   : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  ShortRun : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Type=InsightBenchmark  

```
|                                    Method |       Mean |    StdDev |     Error |        Min |         Max |    Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |-----------:|----------:|----------:|-----------:|------------:|--------:|------:|------:|------:|----------:|
|                        &#39;Single (dynamic)&#39; |   401.2 μs |  43.27 μs |  23.04 μs |   323.8 μs |    483.4 μs | 2,492.8 |     - |     - |     - |  15.73 KB |
|       &#39;Query&lt;T&gt; Procedure (Fast Expando)&#39; |   403.7 μs |  53.82 μs |  27.60 μs |   324.9 μs |    507.9 μs | 2,476.8 |     - |     - |     - |  14.73 KB |
|            &#39;Query&lt;T&gt; Procedure (dynamic)&#39; |   419.2 μs |  45.69 μs |  24.98 μs |   343.5 μs |    560.9 μs | 2,385.2 |     - |     - |     - |  14.73 KB |
|                   &#39;Single (Fast Expando)&#39; |   423.0 μs |  52.79 μs |  27.75 μs |   332.0 μs |    559.4 μs | 2,364.3 |     - |     - |     - |  15.73 KB |
|                      &#39;Query&lt;T&gt; (dynamic)&#39; |   427.4 μs |  64.57 μs |  33.94 μs |   337.1 μs |    654.0 μs | 2,339.9 |     - |     - |     - |  15.71 KB |
|         &#39;Single Procedure (Fast Expando)&#39; |   431.6 μs | 117.65 μs |  62.64 μs |   330.3 μs |    839.1 μs | 2,317.0 |     - |     - |     - |  14.74 KB |
|         &#39;Auto Interface Single (dynamic)&#39; |   434.2 μs |  51.48 μs |  26.72 μs |   338.7 μs |    542.4 μs | 2,303.1 |     - |     - |     - |  16.03 KB |
|              &#39;Single Procedure (dynamic)&#39; |   440.3 μs | 175.22 μs |  93.29 μs |   333.6 μs |  1,124.4 μs | 2,271.2 |     - |     - |     - |  14.74 KB |
|                    &#39;Auto Interface Query&#39; |   445.9 μs |  32.92 μs |  16.88 μs |   389.6 μs |    514.8 μs | 2,242.5 |     - |     - |     - |  21.62 KB |
|                 &#39;Query&lt;T&gt; (Fast Expando)&#39; |   447.7 μs | 142.94 μs |  75.13 μs |   343.4 μs |  1,095.4 μs | 2,233.7 |     - |     - |     - |  15.71 KB |
|                   &#39;Auto Interface Single&#39; |   448.8 μs |  43.75 μs |  23.29 μs |   357.4 μs |    541.5 μs | 2,228.0 |     - |     - |     - |  21.62 KB |
|                      &#39;Query&lt;T&gt; Procedure&#39; |   462.1 μs |  95.16 μs |  52.04 μs |   371.1 μs |    876.7 μs | 2,163.8 |     - |     - |     - |  20.31 KB |
|          &#39;Auto Interface Query (dynamic)&#39; |   467.2 μs |  94.13 μs |  49.47 μs |   373.9 μs |    736.7 μs | 2,140.2 |     - |     - |     - |  16.03 KB |
|                        &#39;Single Procedure&#39; |   472.7 μs | 102.11 μs |  53.67 μs |   379.3 μs |    873.7 μs | 2,115.5 |     - |     - |     - |  20.33 KB |
|                                    Single |   483.7 μs | 131.63 μs |  70.08 μs |   365.8 μs |    946.7 μs | 2,067.6 |     - |     - |     - |  21.31 KB |
|                                  Query&lt;T&gt; |   485.7 μs |  93.50 μs |  50.44 μs |   369.3 μs |    778.7 μs | 2,059.0 |     - |     - |     - |   21.3 KB |
|      &#39;Query&lt;T&gt; Procedure Async (dynamic)&#39; |   541.1 μs |  53.40 μs |  28.43 μs |   459.1 μs |    644.9 μs | 1,848.0 |     - |     - |     - |  18.47 KB |
|             &#39;Single Async (Fast Expando)&#39; |   568.9 μs |  58.02 μs |  31.30 μs |   448.9 μs |    704.1 μs | 1,757.8 |     - |     - |     - |  18.85 KB |
|                  &#39;Single Procedure Async&#39; |   572.8 μs |  74.78 μs |  39.81 μs |   470.5 μs |    784.0 μs | 1,745.8 |     - |     - |     - |  23.45 KB |
| &#39;Query&lt;T&gt; Procedure Async (Fast Expando)&#39; |   579.2 μs |  62.43 μs |  33.24 μs |   467.8 μs |    731.9 μs | 1,726.6 |     - |     - |     - |  18.47 KB |
|   &#39;Single Procedure Async (Fast Expando)&#39; |   590.7 μs |  45.31 μs |  25.13 μs |   504.9 μs |    683.4 μs | 1,693.0 |     - |     - |     - |  17.87 KB |
|                          &#39;Query&lt;T&gt; Async&#39; |   592.3 μs | 194.47 μs | 102.21 μs |   466.9 μs |  1,418.5 μs | 1,688.4 |     - |     - |     - |  25.04 KB |
|                &#39;Query&lt;T&gt; Procedure Async&#39; |   599.5 μs |  81.69 μs |  43.49 μs |   490.5 μs |    858.0 μs | 1,668.0 |     - |     - |     - |  24.05 KB |
|        &#39;Single Procedure Async (dynamic)&#39; |   600.5 μs | 144.25 μs |  76.80 μs |   455.6 μs |  1,103.0 μs | 1,665.3 |     - |     - |     - |  17.87 KB |
|           &#39;Query&lt;T&gt; Async (Fast Expando)&#39; |   624.7 μs | 162.36 μs |  85.33 μs |   449.5 μs |  1,356.1 μs | 1,600.8 |     - |     - |     - |  19.45 KB |
|                &#39;Query&lt;T&gt; Async (dynamic)&#39; |   651.9 μs | 186.61 μs |  98.08 μs |   471.3 μs |  1,318.8 μs | 1,534.0 |     - |     - |     - |  19.45 KB |
|                  &#39;Single Async (dynamic)&#39; |   661.5 μs | 232.82 μs | 123.95 μs |   462.5 μs |  1,595.3 μs | 1,511.8 |     - |     - |     - |  18.85 KB |
|                            &#39;Single Async&#39; |   711.9 μs | 357.47 μs | 190.32 μs |   490.6 μs |  2,525.9 μs | 1,404.7 |     - |     - |     - |  24.44 KB |
|          &#39;Query&lt;T&gt; Parent/Child Together&#39; | 8,022.0 μs | 844.03 μs | 422.63 μs | 7,054.0 μs | 11,291.5 μs |   124.7 |     - |     - |     - |  43.72 KB |
|                   &#39;Query&lt;T&gt; Parent/Child&#39; | 8,493.1 μs | 584.73 μs | 296.23 μs | 7,713.1 μs | 11,176.0 μs |   117.7 |     - |     - |     - |  43.68 KB |
|                                           |            |           |           |            |             |         |       |       |       |           |
|                                 Insert&lt;T&gt; |   745.1 μs |  93.94 μs |  47.59 μs |   600.0 μs |  1,113.1 μs | 1,342.1 |     - |     - |     - |   6.46 KB |
|                                 Update&lt;T&gt; |   752.8 μs |  74.33 μs |  38.58 μs |   642.8 μs |    913.5 μs | 1,328.4 |     - |     - |     - |  24.23 KB |
|                         &#39;Insert&lt;T&gt; Async&#39; |   910.6 μs | 135.15 μs |  70.15 μs |   722.3 μs |  1,377.4 μs | 1,098.2 |     - |     - |     - |  10.09 KB |
|                         &#39;Update&lt;T&gt; Async&#39; |   929.4 μs | 107.01 μs |  54.87 μs |   755.4 μs |  1,288.7 μs | 1,076.0 |     - |     - |     - |  27.35 KB |

## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.

[build]: https://ci.appveyor.com/project/Jaxelr/insight-database-benchmark/branch/master?fullLog=true
[build-svg]: https://ci.appveyor.com/api/projects/status/u7f3dxi8aaw02l0y?svg=true
