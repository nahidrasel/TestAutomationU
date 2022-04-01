using NUnit.Framework;

namespace TestAutomationU
{
    public class Chapter6_ExcludeOs
    {
       // public AdminPage adminPage{get; set;};

        [SetUp]
        public void SetUpTest()
        {

        }

        [TearDown]
        public void CleanUpTest()
        {

        }
        [Test]
        [Platform(Exclude = "Windows")]
        public void AddRoom()
        {

        }
        [Test]
        public void AddSuit()
        {

        }

    }
}
