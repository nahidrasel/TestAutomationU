using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithNunit.Pages
{
    internal class AdminPage
    {
        public AdminPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        internal void Login()
        {
            throw new NotImplementedException();
        }
    }
}
