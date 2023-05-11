using string_vs_stringBuilder.stringService.Concrete;
using System.Diagnostics;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace string_vs_stringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
             var summary = BenchmarkRunner.Run<StringCreatorBenchmark>();
            Stopwatch sw = Stopwatch.StartNew();
            new StringCreator().CreateString(2500);
            var elapsedString = sw.ElapsedMilliseconds / 1000.0;

            sw.Stop();
            sw.Restart();
            new sBuilderCreator().CreateString(2500);
            var elapsedSbuilder = sw.ElapsedMilliseconds / 1000.0;
            sw.Stop();
            Console.WriteLine($"Total Seconds for String: {elapsedString:F2}\n");
            Console.WriteLine($"Total Seconds for StringBuilder: {elapsedSbuilder:F2}");
        }

      

    }
}