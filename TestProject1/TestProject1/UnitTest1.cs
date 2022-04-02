

using NUnit.Framework;
using System;
namespace TestProject1
{
    public class ParameterizedTests
    {
        /*
            public void CheckAsserts(string value)
            {
                Assert.IsNotNull(value);
            }

            [TestCase("yes!")]
        public void MyTest(string value)
            {
                CheckAsserts(value);

            }
        }
        */

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 6)]
        [TestCase(0, 0, 0)] // The test run with this row fails
        public void AddTest(int x, int y, int expected)
        {
            Assert.AreEqual(expected, x + y);
        }
    }
}
