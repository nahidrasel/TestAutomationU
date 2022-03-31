using NUnit.Framework;
using System;

namespace TestAutomationU
{
    [TestFixture]
    public class AdvancedOptions
    {
        [Test]
        public void UsingWarnings()
        {
            var isProcessd = false;
            Warn.Unless(isProcessd, Is.EqualTo(true)
                .After(1).Minutes.PollEvery(10).Seconds);
            Console.WriteLine("still going");

        }
        [Test]
        public void AssertPassThrowsExceptionn()
        {
            Assert.That(Assert.Pass, Throws.TypeOf<AssertionException>());

        }
        [Test]
        public void Assumptions()
        {
            Assume.That("actual", Is.EqualTo("expected"));
        }

        [Test]
        public void WillThisMakeItThroughCodeReview()

        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, 2);
                Assert.AreEqual(3, 4);

            });
        }




    }
}
