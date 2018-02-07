using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace ProjetoTcc.Configuration
{
    public abstract class BaseUITest
    {
        public static IWebDriver Driver { get; private set; }

        [SetUp]
        public void SetupTest()
        {
            if (BaseUITest.Driver == null)
            {
                Driver = new ChromeDriver();
            }
            #pragma warning disable
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));
            //Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                Driver.Quit();
                Driver = null;
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
