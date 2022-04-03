using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;


namespace TestWithNunit
{
    public class StructuredTest
    {
        public IWebDriver driver { get; set; }

        [SetUp]
        public void SetUpTest()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Login()
        {
       
            String Url= driver.Url= "https://automationintesting.online/#/admin";
            driver.FindElement(By.XPath("//button[contains(text(),'Let me hack!')]")).Click();
            driver.FindElement(By.Id("username")).SendKeys("admin");
            driver.FindElement(By.Id("password")).SendKeys("password");
            driver.FindElement(By.Id("doLogin")).Submit();  

        }
      
        [TearDown]
        public void CleanUpTest()
        {
            driver.Close();
        }

    }
}
   
