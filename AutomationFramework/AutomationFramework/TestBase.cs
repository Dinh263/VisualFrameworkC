using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
namespace AutomationFramework
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected string baseUrl = ConfigurationManager.AppSettings["url"];
        public void SetUp(string browserName)
        {
            if (browserName.ToLower().Equals("ie"))
            {
                driver = new InternetExplorerDriver();
            }
            else if (browserName.ToLower().Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else
            {
                driver = new FirefoxDriver();
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
 
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

        public static IEnumerable<string> GetBrowsers()
        {
            string configBrowser = ConfigurationManager.AppSettings["browsers"] ?? "chrome";
            string[] browsers = configBrowser.Split(',');
            foreach(string browser in browsers)
            {
                yield return browser;
            }
        }
    }
}
