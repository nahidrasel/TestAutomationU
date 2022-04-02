using NUnit.Framework;
using OpenQA.Selenium;
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
       
            driver.Url= "https://automationintesting.online/#/";
            driver.Manage().Window.Maximize();

        }
      
        [TearDown]
        public void CleanUpTest()
        {
            driver.Close();
        }

    }
}
   
