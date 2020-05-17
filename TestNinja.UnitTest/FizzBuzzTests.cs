using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(15, "FizzBuzz", TestName = "Number divisible by 3 and 5 (Returns FizzBuzz)")]
        [TestCase(10, "Buzz", TestName = "Number only divisible by 5 (Returns Buzz)")]
        [TestCase(9, "Fizz", TestName = "Number only divisible by 3 (Returns Fizz)")]
        [TestCase(4, "4", TestName = "Number not divisble by 3 or 5 (Returns input number as string)")]
        public void GetOutput_ValidOutput(int input, string output){
            var result = FizzBuzz.GetOutput(input);

            Assert.That(result, Is.EqualTo(output).IgnoreCase);
        }
    }
}