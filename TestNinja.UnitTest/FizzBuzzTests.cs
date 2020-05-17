using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(15, "FizzBuzz")]
        [TestCase(10, "Buzz")]
        [TestCase(9, "Fizz")]
        [TestCase(4, "4")]
        public void GetOutput_ValidOutput(int input, string output){
            var result = FizzBuzz.GetOutput(input);

            Assert.That(result, Is.EqualTo(output).IgnoreCase);
        }
    }
}