using NUnit.Framework;
using System;

namespace TestAutomationU
{
    [TestFixture]
    public class EqualityAssertions
    {
        [Test]
        public void AreEqual()
        {
            Assert.AreEqual("expected", "Actual");
            Assert.That("actual", Is.EqualTo("expected"));
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
            Assert.AreEqual(2, 2.1, .5);
        }

        [Test]
        public void AreEqualNumbersOutsideOfTolerance()
        {
            Assert.AreEqual(2, 23, .5);
        }
        [Test]
        public void AreEqualArraysWithoutSort()
        {
            var expected = new int[] { 1, 2, 3 };
            var actual = new int[] { 1, 3, 2 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreEqualArraysWithSorting()
        {
            var expected = new int[] { 1, 2, 3 };
            var actual = new int[] { 1, 3, 2 };
            Array.Sort(actual);
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
            Assert.That("actual", Is.Not.EqualTo("expected"));
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
        [Test]
        public void ContainsOneInstanceOfThree()
        {
            int[] arrayOfValues = new int[] { 1, 2, 3 };
            Assert.That(arrayOfValues, Has.Exactly(1).EqualTo(3));

            Assert.That(arrayOfValues, Has.One.EqualTo(3));

            Assert.GreaterOrEqual(2, 3);
        }
        [Test]
        public void IsMoreThanFiveAndLessThan100()
        {
            var testValue = 100;
            Assert.That(testValue, Is.GreaterThan(5).Or.LessThan(100));

        }
        [Test]
        public void BeCarefull()
        {

            var yourValue = true;
            Assert.That(yourValue, Is.True.Or.False);
            Assert.That(yourValue, Is.True.And.False);

        }
    }
}