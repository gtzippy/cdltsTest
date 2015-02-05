using System;
using System.Collections.Generic;
using System.IO;
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
        public void BuildOutputStringTestValidNumber()
        {
            string productString;
            string actual = FunctionRepository.BuildOutputString(28, out productString);
            string expected = "2,2,7";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BuildOutputStringTestPrimeNumber()
        {
            string productString;
            string actual = FunctionRepository.BuildOutputString(47, out productString);
            string expected = 47+ " is Prime";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BuildOutputStringTestNegativeNumber()
        {
            string productString;
            string actual = FunctionRepository.BuildOutputString(-1, out productString);
            string expected = -1+" negative numbers, by definition, cannot be prime";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BuildOutputStringTestZero()
        {
            string productString;
            string actual = FunctionRepository.BuildOutputString(0, out productString);
            string expected = 0 + " is a composite number with infinite divisors";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BuildOutputStringTestOne()
        {
            string productString;
            string actual = FunctionRepository.BuildOutputString(1, out productString);
            string expected = 1 + " is not prime but has no divisors";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BuildOutputStringTestSquareOfTwoPrimes()
        {
            string productString;
            string actual = FunctionRepository.BuildOutputString(9, out productString);
            string expected = "3,3";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildPrimeFactorListTest()
        {
            List<int> expected = new List<int>() {2, 2, 2, 2};
            List<int> actual = FunctionRepository.BuildPrimeFactorList(16);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ListProductTest()
        {
            string productString;
            FunctionRepository.BuildOutputString(28, out productString);
            string actual = productString;
            string expected = " Product: 28";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckStringValueTestValidInt()
        {
            Assert.IsTrue(FunctionRepository.CheckStringValue("1"));
        }
        [Test]
        public void CheckStringValueTestNegativeInt()
        {
            Assert.IsTrue(FunctionRepository.CheckStringValue("-1"));
        }
        [Test]
        public void CheckStringValueTestInvalidInt()
        {
            Assert.IsFalse(FunctionRepository.CheckStringValue("1.3"));
        }
        [Test]
        public void CheckStringValueTestWhiteSpace()
        {
            Assert.IsFalse(FunctionRepository.CheckStringValue("   "));
        }
        [Test]
        public void CheckStringValueTestNonNumericString()
        {
            Assert.IsFalse(FunctionRepository.CheckStringValue("meh"));
        }
        [Test]
        public void CheckStringValueTestNumberLargerThanInt32()
        {
            Assert.IsFalse(FunctionRepository.CheckStringValue("9000000000000000000000000"));
        }

        [Test]
        public void IsPrimeTestSucceed()
        {
            Assert.IsTrue(FunctionRepository.IsPrime(3));
        }
        [Test]
        public void IsPrimeTestFailureNotPrimeCompositePositiveInteger()
        {
            Assert.IsFalse(FunctionRepository.IsPrime(4));
        }
        [Test]
        public void IsPrimeTestFailureNegativeInteger()
        {
            Assert.IsFalse(FunctionRepository.IsPrime(-2));
        }
        [Test]
        public void IsPrimeTestFailureOne()
        {
            Assert.IsFalse(FunctionRepository.IsPrime(1));
        }
        [Test]
        public void IsPrimeTestFailureZero()
        {
            Assert.IsFalse(FunctionRepository.IsPrime(0));
        }
        /// <summary>
        /// Tests numbers 2-100
        /// </summary>
        [Test]
        public void CheckProductsVsInputsOfTestFile()
        {
            bool actual = false;
            string filePath = Environment.CurrentDirectory + "\\UnitTestFile.txt";
            IEnumerable<string> numbersString = File.ReadLines(filePath);
            IEnumerable<int> numbers = numbersString.Select(int.Parse).ToList();
            numbers = numbers.Where(entry => FunctionRepository.IsPrime(entry)==false);
            foreach (int number in numbers)
            {
                int primeFactorListProduct = FunctionRepository.ListProduct(FunctionRepository.BuildPrimeFactorList(number));
                if (primeFactorListProduct != number)
                {
                    break;
                }
                actual = true;
            }
            Assert.IsTrue(actual);
        }
    }
}
