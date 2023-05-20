``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.3.1 (a) (22E772610a) [Darwin 22.4.0]
Intel Core i5-8279U CPU 2.40GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|        Method |       Mean |     Error |    StdDev | Ratio |     Gen0 |   Gen1 | Allocated | Alloc Ratio |
|-------------- |-----------:|----------:|----------:|------:|---------:|-------:|----------:|------------:|
|         Regex | 797.857 μs | 2.4777 μs | 2.0690 μs | 1.000 | 211.9141 | 0.9766 | 650.78 KB |       1.000 |
| RegexCompiled |  38.667 μs | 0.4017 μs | 0.3757 μs | 0.048 |  15.2588 | 0.0610 |  46.88 KB |       0.072 |
|        Simple |   5.201 μs | 0.0133 μs | 0.0118 μs | 0.007 |   1.7929 | 0.0076 |   5.49 KB |       0.008 |
