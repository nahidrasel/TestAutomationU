using NUnit.Framework;
using System;


namespace TestWithNunit
{
    public class AdminTests : BaseClass
    {

        [Test]
        public void Login()
        {
            driver.Url = "https://automationintesting.online/#/admin";
            
            driver.Manage().Window.Maximize();
            Console.WriteLine("Passed");
        }

    }
}
   
