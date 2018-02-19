using AutomationFramework;
using NUnit.Framework;
using System.Text;
using System.Threading.Tasks;
using TestProject.POMs;

namespace TestProject.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TestHomepage:TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "GetBrowsers")]
        public void VerifyStarzLogo(string browserName)
        {
            SetUp(browserName);
            HomePageObject  homepageObj = HomePageObject.NavigateAndInitilize(driver, baseUrl);
            Assert.AreEqual("Quality Consulting", homepageObj.lnkHome.Text);
        }
    }
}
