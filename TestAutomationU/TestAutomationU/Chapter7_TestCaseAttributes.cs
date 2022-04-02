using System;
using NUnit.Framework;

namespace TestAutomationU
{
    public class Chapter7_TestCaseAttributes
    {
        //Test Case Attributes
        /* [TestCase("9", "999")]
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
            Assert.That(a, Is.Not.SameAs(b), "A is not same as B");

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

        [TestFixture(typeof(double), typeof(int), 100.0, 42)]
        [TestFixture(typeof(int), typeof(double), 42, 100.0)]
        public class SpecifyBothSetsOfArgs<T1, T2>
        {
            T1 t1;
            T2 t2;

            public SpecifyBothSetsOfArgs(T1 t1, T2 t2)
            {
                this.t1 = t1;
                this.t2 = t2;
            }

            [TestCase(5, 7)]
            public void TestMyArgTypes(T1 t1, T2 t2)
            {
                Assert.That(t1, Is.TypeOf<T1>());
                Assert.That(t2, Is.TypeOf<T2>());
            }
        }

    }
    }