using NUnit.Framework;


namespace TestWithNunit
{
    public class ParameterizedTest
    {
        [TestCase(4,2,2)]
        public void AddTest(int x, int y, int z)
        {
            Assert.AreEqual(z,x-y);

        }

        [Test, TestCaseSource("DivideCases")]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        static object[] DivideCases =
        { new object[] { 12, 3, 4 },
            new object[] { 12, 2, 6 },
            new object[] { 12, 4, 3 }
        };

    }
}
