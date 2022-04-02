using NUnit.Framework;

namespace TestAutomationU
{
    [TestFixture]
    public class MyNewTestFixture
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
