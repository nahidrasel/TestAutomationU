using NUnit.Framework;
using System;


namespace TestAutomationU
{
    public class MyFirstNUnitTests
    {
        [Test]
        public void IAmDoingGreat()
        {
            Console.WriteLine("See you in the test output!");
            Assert.True(true);
        }

        [Test]
        public static void ThisIsAStaticTest()
        {

        }


    }
}
