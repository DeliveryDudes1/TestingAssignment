using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Sdjh
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheSdjhTest()
        {
            driver.Navigate().GoToUrl("http://localhost:54184/");
            driver.FindElement(By.Id("MainContent_Age")).Click();
            driver.FindElement(By.Id("MainContent_Age")).Clear();
            driver.FindElement(By.Id("MainContent_Age")).SendKeys("12");
            driver.FindElement(By.Id("MainContent_Gender")).Click();
            driver.FindElement(By.Id("MainContent_Gender")).Clear();
            driver.FindElement(By.Id("MainContent_Gender")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_Label3")).Click();
            Assert.AreEqual("0", driver.FindElement(By.Id("MainContent_Label3")).Text);
        }
        [Test]
        public void TheSdjhTest2()
        {
            driver.Navigate().GoToUrl("http://localhost:54184/");
            driver.FindElement(By.Id("MainContent_Age")).Click();
            driver.FindElement(By.Id("MainContent_Age")).Clear();
            driver.FindElement(By.Id("MainContent_Age")).SendKeys("22");
            driver.FindElement(By.Id("MainContent_Gender")).Click();
            driver.FindElement(By.Id("MainContent_Gender")).Clear();
            driver.FindElement(By.Id("MainContent_Gender")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_Label3")).Click();
            Assert.AreEqual("6", driver.FindElement(By.Id("MainContent_Label3")).Text);
        }
        [Test]
        public void TheSdjhTest3()
        {
            driver.Navigate().GoToUrl("http://localhost:54184/");
            driver.FindElement(By.Id("MainContent_Age")).Click();
            driver.FindElement(By.Id("MainContent_Age")).Clear();
            driver.FindElement(By.Id("MainContent_Age")).SendKeys("32");
            driver.FindElement(By.Id("MainContent_Gender")).Click();
            driver.FindElement(By.Id("MainContent_Gender")).Clear();
            driver.FindElement(By.Id("MainContent_Gender")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_Label3")).Click();
            Assert.AreEqual("5", driver.FindElement(By.Id("MainContent_Label3")).Text);
        }
        [Test]
        public void TheSdjhTest4()
        {
            driver.Navigate().GoToUrl("http://localhost:54184/");
            driver.FindElement(By.Id("MainContent_Age")).Click();
            driver.FindElement(By.Id("MainContent_Age")).Clear();
            driver.FindElement(By.Id("MainContent_Age")).SendKeys("38");
            driver.FindElement(By.Id("MainContent_Gender")).Click();
            driver.FindElement(By.Id("MainContent_Gender")).Clear();
            driver.FindElement(By.Id("MainContent_Gender")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_Label3")).Click();
            Assert.AreEqual("5", driver.FindElement(By.Id("MainContent_Label3")).Text);
        }
        [Test]
        public void TheSdjhTest5()
        {
            driver.Navigate().GoToUrl("http://localhost:54184/");
            driver.FindElement(By.Id("MainContent_Age")).Click();
            driver.FindElement(By.Id("MainContent_Age")).Clear();
            driver.FindElement(By.Id("MainContent_Age")).SendKeys("52");
            driver.FindElement(By.Id("MainContent_Gender")).Click();
            driver.FindElement(By.Id("MainContent_Gender")).Clear();
            driver.FindElement(By.Id("MainContent_Gender")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_Label3")).Click();
            Assert.AreEqual("1.75", driver.FindElement(By.Id("MainContent_Label3")).Text);
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

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
