using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PrimeFactorization;

namespace PrimeFactorizationTestClass
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void primeFactorTest1()
        {
            string actual = FunctionRepository.BuildOutputString(28);
            string expected = "2,2,7 Product: 28";
            Assert.AreEqual(actual, expected);
        }
    }
}
