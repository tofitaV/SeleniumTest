using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Url = "http://automationpractice.com";
                driver.FindElement(By.XPath(".//*[@class='login']")).Click();

                Thread.Sleep(500);

                driver.FindElement(By.XPath(".//*[@name='email_create']")).SendKeys("test342424421@gmail.com");
                driver.FindElement(By.XPath(".//*[@id='SubmitCreate']")).Click();

                Thread.Sleep(2000);

                driver.FindElement(By.XPath(".//*[@id='customer_firstname']")).SendKeys("name");
                driver.FindElement(By.XPath(".//*[@id='customer_lastname']")).SendKeys("lastname");

                driver.FindElement(By.XPath(".//*[@id='passwd']")).SendKeys("123456789");

                driver.FindElement(By.XPath(".//*[@id='firstname']")).SendKeys("firstname");
                driver.FindElement(By.XPath(".//*[@id='lastname']")).SendKeys("lastname");
                driver.FindElement(By.XPath(".//*[@id='address1']")).SendKeys("street");
                driver.FindElement(By.XPath(".//*[@id='city']")).SendKeys("kherson");

                SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath(".//*[@id='id_state']")));
                oSelect.SelectByText("Texas");

                driver.FindElement(By.XPath(".//*[@id='postcode']")).SendKeys("73000");

                SelectElement oSelectC = new SelectElement(driver.FindElement(By.XPath(".//*[@id='id_state']")));
                oSelectC.SelectByValue("21");

                driver.FindElement(By.XPath(".//*[@id='phone_mobile']")).SendKeys("+3801234567");
                Thread.Sleep(3000);

                driver.FindElement(By.XPath(".//*[@id='submitAccount']")).Click();

                Thread.Sleep(2000);

                IWebElement element = driver.FindElement(By.XPath(".//*[@class='account']"));
                String attValue = element.Text;

                Assert.AreEqual("name lastname", attValue);
            }
                
        }
    }
}
