using BenchmarkDotNet.Attributes;
using test_benchmark.Validators;

namespace test_benchmark.Benchmarks
{
    [MemoryDiagnoser]
    public class EmailValidatorsBenchmark
    {
        static int NumberOfValidators = 100;

        [Benchmark(Baseline = true)]
        public void Regex()
        {
            var validator = new EmailValidatorRegex();
            for (int i = 0; i < NumberOfValidators; i++)
                validator.IsValid("texte@luana.com");
        }

        [Benchmark]
        public void RegexCompiled()
        {
            var validator = new EmailValidatorRegexCompiled();
            for (int i = 0; i < NumberOfValidators; i++)
                validator.IsValid("texte@luana.com");
        }


        [Benchmark]
        public void Simple()
        {
            var validator = new EmailValidatorSimple();
            for (int i = 0; i < NumberOfValidators; i++)
                validator.IsValid("texte@luana.com");
        }
    }
}