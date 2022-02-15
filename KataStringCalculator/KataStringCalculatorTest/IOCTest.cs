using KataStringCalculator;
using KataStringCalculator.IOC;
using NUnit.Framework;

namespace KataStringCalculatorTest
{
    public class IOCTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestGetCalculator()
        {
            var calculator = Container.GetService<ICalculator>();
            Assert.IsNotNull(calculator);
        }

        [Test]
        public void TestGetValidator()
        {
            var validator = Container.GetService<IValidator>();
            Assert.IsNotNull(validator);
        }

        [Test]
        public void TestGetValidCalculator()
        {
            var calculator = Container.GetService<ICalculator>();
            var expected = typeof(Calculator);
            Assert.AreEqual(expected, calculator.GetType());
        }
    }
}
