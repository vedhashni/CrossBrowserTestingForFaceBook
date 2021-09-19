/*summary : CrossBrowser Testing Of FaceBook
  Author: Vedhashni V
  Date  : 18-09-21
*/


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace CrossBrowserTesting_Nunit
{
    public class BaseClass
    {
        public static IWebDriver driver;

       
        public void BrowserTestMethod(string browsername)
        {
            if (browsername.Equals("chrome"))
                driver = new ChromeDriver();
            else
                driver = new FirefoxDriver(); //Launches Browser

            driver.Manage().Window.Maximize();  //Maximize Browser
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(20));
        }

        [TearDown]
        public void Cleanup()// This method will fire at the end of the Test
        {
            driver.Quit();
        }
    }
}
