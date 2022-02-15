using KataStringCalculator;
using KataStringCalculator.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KataStringCalculatorTest
{
    public class ValidatorTest
    {
        

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestNegativeNumber()
        {
            var input = -1;
            Assert.Throws<NegativeNumberException>(() => input.CheckNegativeNumber());
        }
        [Test]
        public void TestNegativeNumberList()
        {
           var input = new List<int> { -1, 5, 3 };
            Assert.Throws<NegativeNumberException>(() => input.CheckNegativeNumber());
        }

        [Test]
        public void TestCheckOutnumber()
        {
            var input = 5000;
            var actual = input.CheckOutnumber();
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void TestCheckOutnumberList()
        {
            var input = new List<int> { 1, 5000, 3 };
            var expected = new List<int> { 1, 0, 3 };
            var actual = input.CheckOutnumber();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestStringValidator()
        {
            var input = "1,2,";
            Assert.Throws<SeparatorAtTheEndOfStringException>(() => input.ValidateString());
        }
    }
}
