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
    public class SMVeiculosVeiculo
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
        public void TheSMVeiculosVeiculoTest()
        {
            driver.Navigate().GoToUrl("https://smveiculosjf.com.br/veiculo/15");
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //section[@id='listing_img_slider']/div[2]/div | ]]
            driver.FindElement(By.XPath("//html")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //section[@id='listing_img_slider']/div[2]/div | ]]
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div/div[2]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //section[@id='listing_img_slider']/div[2]/div/div[2] | ]]
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//section[@id='listing_img_slider']/div[2]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//li/p")).Click();
            driver.FindElement(By.XPath("//li/p")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //li/p | ]]
            driver.FindElement(By.XPath("//li[2]/p")).Click();
            driver.FindElement(By.XPath("//li[2]/p")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //li[2]/p | ]]
            driver.FindElement(By.XPath("//li[2]/p")).Click();
            driver.FindElement(By.XPath("//li[2]/p")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //li[2]/p | ]]
            driver.FindElement(By.XPath("//div[2]/div/div/ul/li[3]")).Click();
            driver.FindElement(By.XPath("//div[2]/div/div/ul/li[3]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //div[2]/div/div/ul/li[3] | ]]
            driver.FindElement(By.XPath("//li[3]/p")).Click();
            driver.FindElement(By.XPath("//li[4]/p")).Click();
            driver.FindElement(By.XPath("//li[4]/p")).Click();
            driver.FindElement(By.XPath("//li[4]/p")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //li[4]/p | ]]
            driver.FindElement(By.XPath("//li[4]/p")).Click();
            driver.FindElement(By.XPath("//li[5]/p")).Click();
            driver.FindElement(By.XPath("//li[5]/p")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //li[5]/p | ]]
            driver.FindElement(By.XPath("//li[5]/p")).Click();
            driver.FindElement(By.XPath("//li[6]/p")).Click();
            driver.FindElement(By.XPath("//li[6]/p")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //li[6]/p | ]]
            driver.FindElement(By.XPath("//li[6]/p")).Click();
            driver.FindElement(By.LinkText("Descrição")).Click();
            driver.FindElement(By.LinkText("Acessórios")).Click();
            driver.FindElement(By.LinkText("Descrição")).Click();
            driver.FindElement(By.XPath("//div[2]/div/ul")).Click();
            driver.FindElement(By.LinkText("Acessórios")).Click();
            driver.FindElement(By.LinkText("Chamar no Whatsapp")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
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
