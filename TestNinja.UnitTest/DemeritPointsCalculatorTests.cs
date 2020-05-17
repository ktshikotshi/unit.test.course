using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{

    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;
        
        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [TestCase(Int32.MinValue, TestName = "CalculateDemeritPoints: Speed is too low (Throws argumentOutOfRangeException)")]
        [TestCase(Int32.MaxValue, TestName = "CalculateDemeritPoints: Speed is too high (Throws argumentOutOfRangeException)")]
        public void CalculateDemeritPoints_SpeedInvalid_ArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_WithinSpeedLimit_Returns0()
        {
            var result = _calculator.CalculateDemeritPoints(60);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_OverSpeedLimit_ReturnsIntGreaterThanZero()
        {
            var result = _calculator.CalculateDemeritPoints(220);

            Assert.That(result, Is.GreaterThan(0));
        }
    }
}