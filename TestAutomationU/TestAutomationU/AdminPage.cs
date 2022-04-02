using OpenQA.Selenium;

namespace TestAutomationU
{
    public class AdminPage
    {
        private readonly IWebDriver driver;
        public AdminPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}