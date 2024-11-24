using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.ChromeDriver;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class UntitledTestCase
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;
        
        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new ChromeDriver(@"~/downloads/chromedriver_mac64_m1");
            baseURL = "https://www.google.com/";
        }
        
        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        
        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }
        
        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [TestMethod]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://www.onlineconversion.com/leapyear.htm");
            driver.FindElement(By.Name("year")).Click();
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("1582");
            driver.FindElement(By.XPath("//input[@value='Check Year']")).Click();
            Assert.AreEqual("not a leap year.", driver.FindElement(By.Name("result")).GetAttribute("value"));
            // ERROR: Caught exception [unknown command []]
        }

        [TestMethod]
        public void TheUntitledTestCaseTest1()
        {
            driver.Navigate().GoToUrl("https://www.onlineconversion.com/leapyear.htm");
            driver.FindElement(By.Name("year")).Click();
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("1582");
            driver.FindElement(By.XPath("//input[@value='Check Year']")).Click();
            Assert.AreEqual("not a leap year.", driver.FindElement(By.Name("result")).GetAttribute("value"));
            // ERROR: Caught exception [unknown command []]
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
