using NUnit.Framework;

namespace TestAutomationU
{
    public class Chapter6_Skip_Ignore
    {
        [SetUp]
        public void SetUpTest() {...}

        [TearDown]
        public void CleanUpTest() {...}


        [Test]
        [Explicit(reason:"reason")]
        public void AddRoom() {...}

        [Test]
        [Ignore(reason:"ours is not to question why")]
        public void AddSuite() {...}

    }
}
