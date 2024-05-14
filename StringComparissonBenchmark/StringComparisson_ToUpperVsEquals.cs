using BenchmarkDotNet.Attributes;
using System;

namespace StringComparissonBenchmark
{
    public class StringComparisson_ToUpperVsEquals
    {
        [Benchmark]
        public bool CompasissonWithUpper()
        {
            string parameter1 = "BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER";
            string parameter2 = "BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPEr";
            return parameter1.ToUpper() == parameter2.ToUpper();
        }
        [Benchmark]
        public bool CompasissonWithEquals()
        {
            string parameter1 = "BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER";
            string parameter2 = "BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPER BRAVE DEVELOPEr";
            return string.Equals(parameter1, parameter2, StringComparison.OrdinalIgnoreCase);
        }
    }
}
