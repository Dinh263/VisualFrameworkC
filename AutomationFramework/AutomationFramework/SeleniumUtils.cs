using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    public class SeleniumUtils
    {
        public static string TakeScreenshot(IWebDriver driver)
        {
            // Get the current TimeStamp
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff");
            // Build a file name (*NOTE: The folder must already exist and allow writes to it)
            string fileName = @"C:\temp\Selenium\" + timeStamp + ".jpg";
            // Take a screenshot
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);
            // Return the filename of the screenshot
            return fileName;
        }

    }
}
