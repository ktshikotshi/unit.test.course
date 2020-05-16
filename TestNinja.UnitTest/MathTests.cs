using NUnit.Framework;

using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void Setup(){
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOfArgs(){
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [TestCase(2, 1, 2, TestName = "Max: Larger of the specified arguments (Returns: 65)")]
        [TestCase(1, 2, 2, TestName = "Max: Frist Argument Is larger than second Argument (Returns: 2)")]
        [TestCase(2, 2, 2, TestName = "Max: Arguments are equal (Returns: 2)")]
        public void Max_WhenCalled_ReturnFirstArg(int a, int b, int expectedResult){
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}