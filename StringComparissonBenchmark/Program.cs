using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace StringComparissonBenchmark
{
    [MemoryDiagnoser]
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benchmark dotnet");
            BenchmarkRunner.Run<StringComparisson_ToUpperVsEquals>();
        }
    }
}
