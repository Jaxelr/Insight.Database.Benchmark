# Insight.Database Benchmark

These are benchmark scenarios for the ORM library [Insight.Database](https://github.com/jonwagner/Insight.Database)

## Performance Results

``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.102
  [Host]   : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

Type=InsightBenchmark  

```

|                           Method |        Mean |     StdDev |       Error |        Min |         Max |     Op/s | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------------- |------------:|-----------:|------------:|-----------:|------------:|---------:|------:|------:|------:|----------:|
|          &#39;Auto Interface Single&#39; |    491.9 us |   107.4 us |    56.46 us |   276.1 us |    697.2 us | 2,033.01 |     - |     - |     - |   18.2 KB |
|           &#39;Auto Interface Query&#39; |    578.5 us |   129.7 us |    69.06 us |   303.9 us |    895.5 us | 1,728.53 |     - |     - |     - |   18.2 KB |
|                         Query&lt;T&gt; |    621.5 us |   126.4 us |    67.27 us |   391.1 us |    901.4 us | 1,609.02 |     - |     - |     - |  17.88 KB |
|                           Single |    764.8 us |   235.9 us |   125.62 us |   427.5 us |  1,169.5 us | 1,307.57 |     - |     - |     - |   17.9 KB |
| &#39;Query&lt;T&gt; Parent/Child Together&#39; | 12,927.0 us | 2,514.4 us | 1,273.81 us | 9,489.2 us | 19,464.5 us |    77.36 |     - |     - |     - |  39.54 KB |
|          &#39;Query&lt;T&gt; Parent/Child&#39; | 17,244.7 us | 5,909.2 us | 2,958.89 us | 8,670.2 us | 33,866.5 us |    57.99 |     - |     - |     - |  39.52 KB |

## Contributing

Check the [guidelines](https://github.com/Jaxelr/InsightBenchmark/blob/master/.github/CONTRIBUTING.md) for details on how you could contribute.
