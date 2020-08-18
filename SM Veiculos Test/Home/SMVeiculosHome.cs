using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class SMVeiculosHome
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {

            driver.Close();
            driver.Dispose();

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
        public void TheSMVeiculosHomeTest()
        {
            driver.Navigate().GoToUrl("https://smveiculosjf.com.br/");
            driver.FindElement(By.LinkText("Início")).Click();
            driver.FindElement(By.LinkText("Nossos Veículos")).Click();
            driver.FindElement(By.LinkText("Entre em Contato")).Click();
            driver.FindElement(By.Name("cidade")).Click();
            driver.FindElement(By.Name("cidade")).Click();
            driver.FindElement(By.Name("marca")).Click();
            driver.FindElement(By.Name("marca")).Click();
            driver.FindElement(By.Name("anoModelo")).Click();
            driver.FindElement(By.Name("anoModelo")).Click();
            driver.FindElement(By.Name("combustivel")).Click();
            driver.FindElement(By.Name("combustivel")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//img[@alt='2008 ALLURE AT']")).Click();
            driver.FindElement(By.XPath("//img[@alt='ARRIZO5 RX']")).Click();
            driver.FindElement(By.XPath("//img[@alt='GM/ASTRA HB 4P ADVANTAGE']")).Click();
            driver.FindElement(By.XPath("//img[@alt='C3 XTR 16 FLEX']")).Click();
            driver.FindElement(By.XPath("//img[@alt='RENAULT/SANDERO STW 16HP']")).Click();
            driver.FindElement(By.XPath("//img[@alt='FIESTA 16SEL']")).Click();
            driver.FindElement(By.XPath("//img[@alt='HB20 1.0M COMFOR']")).Click();
            driver.FindElement(By.XPath("//img[@alt='I/NISSAN FRONTIER LEATX4']")).Click();
            driver.FindElement(By.XPath("//img[@alt=' FOCUS 2L FC FLEX']")).Click();
            driver.FindElement(By.XPath("//img[@alt='FIT LX CVT']")).Click();
            driver.FindElement(By.XPath("//img[@alt='TORO FREEDOM AT']")).Click();
            driver.FindElement(By.XPath("//img[@alt=' 307 16 PR PK']")).Click();
            driver.FindElement(By.XPath("//img[@alt='Duster 1.6 Dakar 4x2']")).Click();
            driver.FindElement(By.XPath("//img[@alt='KA SE PLUS 1.0 HA C']")).Click();
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.XPath("//footer/div")).Click();
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("email@outlook.com.br");
            driver.FindElement(By.XPath("(//button[@type='submit'])[2]")).Click();
            driver.Close();

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
