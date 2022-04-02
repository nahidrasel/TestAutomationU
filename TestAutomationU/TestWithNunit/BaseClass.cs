

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestWithNunit
{
    public class BaseClass
    {
        public IWebDriver driver { get; set; }

        [OneTimeSetUp]
        public void StartDriver()
        {
            driver = new ChromeDriver();
        }
         

        [OneTimeTearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
