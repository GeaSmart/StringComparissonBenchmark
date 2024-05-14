using BenchmarkDotNet.Attributes;

namespace StringComparissonBenchmark
{
    public class BucleVsFx
    {
        [Benchmark]
        public long SumAccBucle()
        {
            long number = 8900000;
            long result = 0;
            for (long i = 1; i < number; i++)
            {
                result += i;
            }
            return result;
        }
        [Benchmark]
        public long SumAccFx()
        {
            long number = 8900000;
            long result = number * (number + 1) / 2;
            return result;
        }
    }
}
