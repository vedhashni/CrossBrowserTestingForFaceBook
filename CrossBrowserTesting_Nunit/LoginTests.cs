using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;

namespace CrossBrowserTesting_Nunit
{
    [TestFixture]
    [Parallelizable]
    public class LoginTests:BaseClass
    {
        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "chrome", "firefox", };
            foreach(string b in browsers)
            {
                yield return b;
            }
        }

        [Test]
        [TestCaseSource("BrowserToRunWith")]
        public void LoginIntoFacebook(string browsername)
        {
            BrowserTestMethod(browsername);
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.Name("email")).SendKeys("9843801062");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Id("pass")).SendKeys("Vedha@1");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(10000);
        }

    }
}