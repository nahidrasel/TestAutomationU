using System;
using NUnit.Framework;

namespace TestAutomationU
{
    public class Chapter7_TestCaseAttributes
    {
        //Test Case Attributes
        
        /*
         
         [TestCase("9", "999")]
         [TestCase("10", "1000")]
          
         // Test Case Attributes with TestName and Description
         [TestCase("9", "999", TestName = "")]
         [TestCase("10", "1000", Description = "")]

       */
        
        //Expected result Parameter
        
        [Test]
        [TestCase(2, 5)]
        public void AdditionTest(int a, int b)
        {
            Assert.That(a, Is.Not.SameAs(b),"A is not same as B");
            //Console.WriteLine("A is not Same as B");
        }
        [Test]
        [TestCase("nhdrasel@gmail.com")]
        [TestCase("namhmud@gmail.com")]
        [TestCase("rasel@gmail.com")]
        public void EmailValidation(string emailAddress)
        {
            var email= nameof(EmailValidation);
        }
    }
}