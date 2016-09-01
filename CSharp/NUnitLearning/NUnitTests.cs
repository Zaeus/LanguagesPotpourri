using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace NUnitLearning
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void TestIntAddition()
        {
            int result = SomethingToTest.Add(50, 50);
            Assert.AreEqual("100", result.ToString());
        }

        [Test]
        public void TestIntSubstract()
        {
            int result = SomethingToTest.Subtract(50, 50);
            Assert.AreEqual("0", result.ToString());
        }

        [Test]
        public void TestIntMultiply([Random(int.MinValue, int.MaxValue, 100)] int x)
        {
            int result = SomethingToTest.Multiply(x, 0);
            Assert.AreEqual("0", result.ToString());
        }

        [TestCase(4, 4, "16")]
        [TestCase(5, 4, "20")]
        [TestCase(25, 5, "125")]
        [TestCase(25, -5, "-125")]
        public void TestIntMultiply2(int x, int y, string s)
        {
            int result = SomethingToTest.Multiply(x, y);
            Assert.AreEqual(s, result.ToString());
        }

        [TestCase(14, 4, "3.5")]
        [TestCase(16, 4, "4")]
        [TestCase(25, 5, "5")]
        public void TestIntDivide(int x, int y, string s)
        {
            int result = SomethingToTest.Divide(x, y);
            Assert.AreEqual(s, result.ToString());
        }

        [TestCase(14, 4, "2")]
        [TestCase(16, 4, "0")]
        [TestCase(25, 5, "0")]
        [TestCase(24, 5, "4")]
        public void TestIntModulo(int x, int y, string s)
        {
            int result = SomethingToTest.Modulo(x, y);
            Assert.AreEqual(s, result.ToString());
        }

        [Test]
        [MaxTime(1000)]
        public void TimeSensitive()
        {
            SomethingToTest.TimeConsumingMethod(10, 2, 30, 4);
            Assert.Pass("It's working");
        }
    }
}
