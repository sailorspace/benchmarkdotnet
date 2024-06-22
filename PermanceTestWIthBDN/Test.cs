using BenchmarkDotNet.Attributes;

namespace PermanceTestWIthBDN
{
    public class Test
    {
        [Benchmark]
        public void TestWithSpan()
        {
            var input = "SAN-123456";
            var inputSpan = input.AsSpan();
            var comparision = new Span<char>(new[] { 'S', 'A', 'N' });
            var result = false;
            if (inputSpan.Slice(0, 3) == comparision)
            {

                result = true;
            }
        }

        [Benchmark]
        public void RunWithoutSpan()
        {
            var input = "SAN-123456";
            var result = false;
            if (input.StartsWith("SAN"))
            {
                result = true;
            }
        }

    }
}

