using System;
using NUnit.Framework;
using System.Collections.Generic;
using FibonacciNumbers;

namespace FibonacciNumbersTest
{
    [TestFixture]
    public class FibonacciNumbersTest
    {
        public IEnumerable<TestCaseData> DatasCaseForSumFibonacciNumbers
        {
            get
            {
                yield return new TestCaseData(6).Returns(12);
                yield return new TestCaseData(11).Returns(143);
                yield return new TestCaseData(0).Returns(0);
            }
        }

        [Test, TestCaseSource("DatasCaseForSumFibonacciNumbers")]
        public int FibonacciNumbers_Test(int number)
        {
            return FibonacciNumbers.FibonacciNumbers.SumFibonacciNumbers(number);
        }
    }
}
