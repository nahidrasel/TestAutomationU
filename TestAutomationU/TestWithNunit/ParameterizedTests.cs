using NUnit.Framework;
using System;


namespace TestWithNunit
{
    public class ParameterizedTests
    {
        public void CheckAsserts(string value)
        {
            Assert.IsNotNull(value);
        }

        [TestCase("yes!")]
        public void MyTest(string value)
        {
            CheckAsserts(value);

        }
    }
}
