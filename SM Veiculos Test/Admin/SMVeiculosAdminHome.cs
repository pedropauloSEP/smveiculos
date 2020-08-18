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
    public class SMVeiculosAdminHome
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
            driver.Navigate().GoToUrl("https://smveiculosjf.com.br/sistema");
            driver.FindElement(By.XPath("//div/div/div/div/div[2]/div")).Click();
            driver.FindElement(By.XPath("//div[2]/a/i")).Click();
            driver.FindElement(By.XPath("//nav[@id='sidebar']/ul/li[6]/a/span")).Click();
            driver.FindElement(By.LinkText("Todos os Usuários")).Click();
            driver.FindElement(By.LinkText("Alterar Perfil")).Click();
            driver.FindElement(By.XPath("//img[@alt='logo']")).Click();
            driver.FindElement(By.XPath("//div[3]")).Click();
            driver.FindElement(By.XPath("//div[3]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Novo Usuário')]")).Click();
            driver.FindElement(By.XPath("//img[@alt='logo']")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Todos os Usuários')]")).Click();
            driver.FindElement(By.XPath("//img[@alt='logo']")).Click();
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
