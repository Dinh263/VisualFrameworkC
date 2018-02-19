using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.POMs
{
    public class HomePageObject
    {
        #region find element locator
        [FindsBy(How =How.CssSelector,Using = "#logo > p > a")]
        public IWebElement lnkHome { get; set; }
        
        #endregion
        public HomePageObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        #region phuong thuc cua page
        public static HomePageObject NavigateAndInitilize(IWebDriver  driver, string baseUrl)
        {
            driver.Url = baseUrl;
            return new HomePageObject(driver);
        }
        #endregion
    }
}
