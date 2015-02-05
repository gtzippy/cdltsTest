using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using FunctionRepository;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public static void CountFifthFromEndSuccessTest()
        {
            List<int> testList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            string actual = ArrayProblemFunctions.GetNthFromEndEntry(testList);
            Assert.AreEqual(actual, "5 is 5 entries from the end of the array");
        }
        [Test]
        public static void CountFourthFromEndSuccessTest()
        {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string actual = ArrayProblemFunctions.GetNthFromEndEntry(testList, 4);
            Assert.AreEqual(actual, "6 is 4 entries from the end of the array");
        }
        [Test]
        public static void AskForZerothFromEndFailure()
        {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string actual = ArrayProblemFunctions.GetNthFromEndEntry(testList, 0);
            Assert.AreEqual(actual, "Invalid Input: Please enter an integer greater than '0'");
        }
        [Test]
        public static void AskForNegativeIndexFromEndFailure()
        {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string actual = ArrayProblemFunctions.GetNthFromEndEntry(testList, -3);
            Assert.AreEqual(actual, "Invalid Input: Please enter an integer greater than '0'");
        }
        [Test]
        public static void ArrayToShortFailureTest()
        {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string actual = ArrayProblemFunctions.GetNthFromEndEntry(testList, 11);
            Assert.AreEqual(actual, "List not long enough, must contain at least 11 entires");
        }

    }
}
