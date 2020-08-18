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
    public class SMVeiculosAdminAdicionar
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
        public void TheSMVeiculosAdminAdicionarTest()
        {
            driver.Navigate().GoToUrl("https://smveiculosjf.com.br/sistema/veiculos/adicionar");
            driver.FindElement(By.XPath("//div/div[2]")).Click();
            driver.FindElement(By.Id("placa")).Click();
            driver.FindElement(By.Id("modelo")).Click();
            driver.FindElement(By.Id("placa")).Click();
            driver.FindElement(By.XPath("//form[@action='https://smveiculosjf.com.br/index.php/admin/cadastro/veiculo']")).Click();
            driver.FindElement(By.Id("placa")).Click();
            driver.FindElement(By.Id("placa")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=placa | ]]
            driver.FindElement(By.Id("placa")).Click();
            driver.FindElement(By.Id("ano")).Click();
            driver.FindElement(By.Id("anoModelo")).Click();
            driver.FindElement(By.Id("cor")).Click();
            driver.FindElement(By.Id("marca")).Click();
            driver.FindElement(By.Id("valor")).Click();
            driver.FindElement(By.Id("modelo")).Click();
            driver.FindElement(By.Id("ano")).Click();
            driver.FindElement(By.Id("ano")).Clear();
            driver.FindElement(By.Id("ano")).SendKeys("2018");
            driver.FindElement(By.Id("anoModelo")).Click();
            driver.FindElement(By.Id("cor")).Click();
            driver.FindElement(By.Id("cor")).Clear();
            driver.FindElement(By.Id("cor")).SendKeys("Cinza");
            driver.FindElement(By.Id("marca")).Click();
            driver.FindElement(By.Id("marca")).Clear();
            driver.FindElement(By.Id("marca")).SendKeys("MMC");
            driver.FindElement(By.XPath("//div[4]")).Click();
            driver.FindElement(By.Id("valor")).Click();
            driver.FindElement(By.Id("placa")).Click();
            driver.FindElement(By.Id("km")).Click();
            driver.FindElement(By.Id("km")).Clear();
            driver.FindElement(By.Id("km")).SendKeys("500");
            driver.FindElement(By.XPath("//div[5]")).Click();
            driver.FindElement(By.Id("combustivel")).Click();
            new SelectElement(driver.FindElement(By.Id("combustivel"))).SelectByText("Alcool");
            driver.FindElement(By.Id("combustivel")).Click();
            driver.FindElement(By.Id("motor")).Click();
            driver.FindElement(By.Id("motor")).Clear();
            driver.FindElement(By.Id("motor")).SendKeys("4141");
            driver.FindElement(By.XPath("//div[6]")).Click();
            driver.FindElement(By.Id("cambio")).Click();
            new SelectElement(driver.FindElement(By.Id("cambio"))).SelectByText("Manual");
            driver.FindElement(By.Id("cambio")).Click();
            driver.FindElement(By.Id("descricao")).Click();
            driver.FindElement(By.Id("descricao")).Clear();
            driver.FindElement(By.Id("descricao")).SendKeys("afafsafsa");
            driver.FindElement(By.XPath("//label/span")).Click();
            driver.FindElement(By.XPath("//div[2]/div/ul[3]/li/label/span")).Click();
            driver.FindElement(By.XPath("//div[3]/div/ul[4]/li/label/span")).Click();
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
