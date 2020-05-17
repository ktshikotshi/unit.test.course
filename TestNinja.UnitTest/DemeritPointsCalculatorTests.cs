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

        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(69, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCaller_ReturnsPoints(int speed, int points)
        {
            var result = _calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(points));
        }
    }
}