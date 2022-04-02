using NUnit.Framework;

namespace ParameterizedTest
    {
        public class ParameterizedTest
        {
            [TestCase(4, 2, 2)]
            [TestCase(6,2,4)]
            public void AddTest(int x, int y, int z)
            {
                Assert.AreEqual(z, x - y);

        }

        }
    }