using System.Text.RegularExpressions;
using test_benchmark.interfaces;

namespace test_benchmark.Validators
{
    public class EmailValidatorRegex : IEmailValidator
    {
        public bool IsValid(string email)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\.\-]+)((\.(\w){2,3})+)$");

            return regex.Match(email).Success;
        }
    }
}