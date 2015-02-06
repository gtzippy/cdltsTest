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
        public static void EquilateralTest()
        {
            string actual = TriangleFunctions.TriType(1, 1, 1);
            Assert.AreEqual(actual, "Equilateral");
        }

        [Test]
        public static void IsoscelesTest()
        {
            string actual = TriangleFunctions.TriType(1, 2, 2);
            Assert.AreEqual(actual, "Isosceles");
        }

        [Test]
        public static void ScaleneTest()
        {
            string actual = TriangleFunctions.TriType(1, 2, 3);
            Assert.AreEqual(actual, "Scalene");
        }

        [Test]
        public static void InvalidTest()
        {
            string actual = TriangleFunctions.TriType(-1, 2, 3);
            Assert.AreEqual(actual, "Error: Invalid side lengths");
        }

        [Test]
        public static void LargeNumberFailure()
        {
            string [] args = {"1", "2", "300000000000000000000000000000000000000000000000000000000"};
            string actual = TriangleFunctions.ValidInputs(args);
            Assert.AreEqual(actual, "Please enter 3 valid positive integers: OverflowException");
        }
        [Test]
        public static void NonIntegerInputFailure()
        {
            string[] args = { "A", "2", "3" };
            string actual = TriangleFunctions.ValidInputs(args);
            Assert.AreEqual(actual, "Please enter 3 valid positive integers: FormatException");
        }

        [Test]
        public static void NotEnoughInputsFailure()
        {
            string[] args = { "A", "2" };
            string actual = TriangleFunctions.ValidInputs(args);
            Assert.AreEqual(actual, "Please enter 3 valid positive integers");
        }
        [Test]
        public static void NonIntegerInputFailureBeforeLargeNumberFailure()
        {
            string[] args = { "A", "2", "3000000000000000000000000000000000000000000000" };
            string actual = TriangleFunctions.ValidInputs(args);
            Assert.AreEqual(actual, "Please enter 3 valid positive integers: FormatException");
        }

        [Test]
        public static void ToManyInputsFailure()
        {
            string[] args = { "1", "2", "3", "4" };
            string actual = TriangleFunctions.ValidInputs(args);
            Assert.AreEqual(actual, "Please enter ONLY 3 valid positive integers");
        }
        [Test]
        public static void NoInputsFailure()
        {
            string[] args = {};
            string actual = TriangleFunctions.ValidInputs(args);
            Assert.AreEqual(actual, "Please enter 3 valid positive integers");
        }
    }
}
