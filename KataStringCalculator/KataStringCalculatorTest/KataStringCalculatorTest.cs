using KataStringCalculator;
using KataStringCalculator.Exceptions;
using NUnit.Framework;
using System;

namespace KataStringCalculatorTest
{
    public class Tests
    {
        private ICalculator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Calculator();
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("10,20,4,5,8", ExpectedResult = 47)]
        [TestCase("10,20,4", ExpectedResult = 34)]
        [TestCase("1,2\n3", ExpectedResult = 6)]
        [TestCase("1\n2,4", ExpectedResult = 7)]
        [TestCase("//;\n1;3", ExpectedResult = 4)]
        [TestCase("//|\n1|2|3", ExpectedResult = 6)]
        [TestCase("//sep\n2sep5", ExpectedResult = 7)]        
              
        public int Test(string input) => _sut.Add(input);

        [Test]
        public void TestReturnException()
        {
            var input = "1,2,";
            Assert.Throws<SeparatorAtTheEndOfStringException>(() => _sut.Add(input));
        }

        [Test]
        public void TestException()
        {
            var input = "1,2,b";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }
        
        [Test]
        public void TestFormatExceptionAtferChangeSeparator()
        {
            var input = "//|\n1|2,3";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }
        [Test]
        public void TestMIssingSeparator()
        {
            var input = "//\n1|2,3";
            Assert.Throws<SeparatorAtTheEndOfStringException>(() => _sut.Add(input));
        }
        [Test]
        public void TestNegativeNumber()
        {
            var input = "-1,2,3";
            Assert.Throws<NegativeNumberException>(() => _sut.Add(input));
        }
    }
}