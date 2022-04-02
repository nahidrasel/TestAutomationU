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
        
    }
}
