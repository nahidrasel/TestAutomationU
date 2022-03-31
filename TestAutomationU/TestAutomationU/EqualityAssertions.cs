using NUnit.Framework;


namespace TestAutomationU
{
    [TestFixture]
    public class EqualityAssertions
    {
        [Test]
        public void AreEqual()
        {
            Assert.AreEqual("expected", "Actual");
        }
        [Test]
        public void AreEqualWithDescription()
        {
            Assert.AreEqual("expected", "actual", "what does this even mean");

        }

        [Test]
        public void AreEqualWithDynamicDescription()
        {
            Assert.AreEqual("expected", "actual", "what does{0} mean to {1}", "testing", "you");

        }
        [Test]
        public void AreEqualNumbers()
        {
            Assert.AreEqual(1, 2);
        }
        [Test]
        public void AreEqualNumbersWithDifferentTypes()
        {
            Assert.AreEqual(2, 2d);
        }
        [Test]
        public void AreEqualNumbersWithInTolerance()
        {
            Assert.AreEqual(2, 23, .5);
        }
        [Test]
        public void AreEqualArrays()
        {
            var expected= new int[] { 1, 2, 3 };
            var actual= new int[] { 1, 3, 2 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreObjectsEqual()
        {
            var obj1 = new object();
            var obj2 = obj1;

            Assert.AreEqual(obj1, obj2);
        }
        [Test]
        public void AreNotEqual()
        {
            Assert.AreNotEqual("expected", "actual");
        }
        [Test]
        public void IsStringEmpty()
        {
            var myString = "";
            Assert.IsEmpty(myString);
        }

        [Test]
        public void ComaparingRelativeValues()
        {
            Assert.GreaterOrEqual(2, 3);
        }


    }
}
