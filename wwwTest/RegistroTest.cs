using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Text;

namespace wwwTest
{
    [TestClass]
    public class RegistroCorrecto
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new EdgeDriver();
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
        public void TheRegistroCorrectoTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44387/InicioSesion.aspx");
            driver.FindElement(By.Id("btnRegistro")).Click();
            driver.FindElement(By.Id("tbxEmail")).Clear();
            driver.FindElement(By.Id("tbxEmail")).SendKeys("gestor@ubusecret.es");
            driver.FindElement(By.Id("tbxPassword")).Clear();
            driver.FindElement(By.Id("tbxPassword")).SendKeys("P@ssword");
            driver.FindElement(By.Id("tbxNombre")).Click();
            driver.FindElement(By.Id("tbxNombre")).Clear();
            driver.FindElement(By.Id("tbxNombre")).SendKeys("Prueba");
            driver.FindElement(By.XPath("//form[@id='form1']/div[3]/table/tbody/tr[10]/td[2]")).Click();
            driver.FindElement(By.Id("tbxApellidos")).Click();
            driver.FindElement(By.Id("tbxApellidos")).Clear();
            driver.FindElement(By.Id("tbxApellidos")).SendKeys("Prueba 1");
            driver.FindElement(By.Id("tbxEmail")).Click();
            driver.FindElement(By.Id("tbxEmail")).Click();
            driver.FindElement(By.Id("tbxEmail")).Clear();
            driver.FindElement(By.Id("tbxEmail")).SendKeys("gestorPrueba@ubusecret.es");
            driver.FindElement(By.Id("btnAceptar")).Click();
            driver.FindElement(By.Id("tbxEmail")).Clear();
            driver.FindElement(By.Id("tbxEmail")).SendKeys("gestor@ubusecret.es");
            driver.FindElement(By.Id("tbxPassword")).Clear();
            driver.FindElement(By.Id("tbxPassword")).SendKeys("P@ssword");
            try
            {
                Assert.IsTrue(IsElementPresent(By.Id("lblTitulo")));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
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

    [TestClass]
    public class RegistroCamposIncorrectos
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new EdgeDriver();
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
        public void TheRegistroCamposIncorrectosTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44387/InicioSesion.aspx");
            driver.FindElement(By.Id("btnRegistro")).Click();
            driver.FindElement(By.Id("btnAceptar")).Click();
            try
            {
                Assert.IsTrue(IsElementPresent(By.Id("lblErrorNombre")));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.Id("lblErrorApellidos")));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.Id("lblErrorEmail")));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.Id("lblErrorPassword")));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
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

    [TestClass]
    public class RegistroEmailYaEnUso
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new EdgeDriver();
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
        public void TheRegistroEmailYaEnUsoTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44387/InicioSesion.aspx");
            driver.FindElement(By.Id("btnRegistro")).Click();
            driver.FindElement(By.Id("tbxNombre")).Click();
            driver.FindElement(By.Id("tbxNombre")).Clear();
            driver.FindElement(By.Id("tbxNombre")).SendKeys("Prueba");
            driver.FindElement(By.Id("tbxApellidos")).Click();
            driver.FindElement(By.Id("tbxApellidos")).Clear();
            driver.FindElement(By.Id("tbxApellidos")).SendKeys("Prueba 1");
            driver.FindElement(By.Id("tbxEmail")).Click();
            driver.FindElement(By.Id("tbxEmail")).Clear();
            driver.FindElement(By.Id("tbxEmail")).SendKeys("gestor@ubusecret.es");
            driver.FindElement(By.Id("tbxPassword")).Click();
            driver.FindElement(By.Id("tbxPassword")).Clear();
            driver.FindElement(By.Id("tbxPassword")).SendKeys("123456");
            driver.FindElement(By.Id("btnAceptar")).Click();
            try
            {
                Assert.IsTrue(IsElementPresent(By.Id("lblErrorVentana")));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
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
