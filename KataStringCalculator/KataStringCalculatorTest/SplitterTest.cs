using KataStringCalculator;
using KataStringCalculator.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KataStringCalculatorTest
{
    public class SplitterTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestSplitter()
        {
            var input = "10,20,4,5,8";
            var expected = new List<int> { 10, 20, 4, 5, 8 };
            Assert.AreEqual(expected, input.Splitter());
        }
        [Test]
        public void TestSplitterException()
        {
            var input = "10,20,4,5,8,";
            Assert.Throws<SeparatorAtTheEndOfStringException>(() => input.Splitter());
        }
        [Test]
        public void TestCheckNewSeparator()
        {
            var input1 = "1\n2,4";
            var input2 = "//;\n1;3";
            var input3 = "//|\n1|2|3";
            var input4 = "//sep\n2sep5";
            var expected1 = ("1\n2,4", new string[] { ",", "\n" });
            var expected2 = ("1;3", new string[] { ";"});
            var expected3 = ("1|2|3", new string[] { "|"});
            var expected4 = ("2sep5", new string[] { "sep" });
            Assert.AreEqual (expected1, input1.CheckPersonalizedSeparator());
            Assert.AreEqual (expected2, input2.CheckPersonalizedSeparator());
            Assert.AreEqual (expected3, input3.CheckPersonalizedSeparator());
            Assert.AreEqual (expected4, input4.CheckPersonalizedSeparator());
        }
    }
}
