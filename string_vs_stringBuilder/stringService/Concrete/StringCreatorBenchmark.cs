using BenchmarkDotNet.Attributes;

namespace string_vs_stringBuilder.stringService.Concrete;

[MemoryDiagnoser]
[MarkdownExporter]
public class StringCreatorBenchmark
{
    [Params(1000, 2500,250000)] public int N { get; set; }

    [Benchmark]
    public void StringConcatenation()
    {
        new StringCreator().CreateString(N);
    }

    [Benchmark]
    public void StringBuilderConcatenation()
    {
        new sBuilderCreator().CreateString(N);
    }

   /* [IterationSetup]
    public void IterationSetup()
    {
        // Unnecessary data uploads
    }

    [IterationCleanup]
    public void Cleanup()
    {
        //Any post-benchmark cleaning.
    }*/
}