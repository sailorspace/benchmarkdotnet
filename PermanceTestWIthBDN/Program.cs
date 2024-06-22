using BenchmarkDotNet.Running;

namespace PermanceTestWIthBDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var summary = BenchmarkRunner.Run<BenchmarkLINQPerformance>();
            //var summary = BenchmarkRunner.Run<BenchmarkLINQPerformance>();
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
