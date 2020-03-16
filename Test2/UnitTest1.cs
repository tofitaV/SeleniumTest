using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Url = "http://automationpractice.com";
                driver.FindElement(By.XPath(".//*[@class='login']")).Click();

                Thread.Sleep(2000);

                driver.FindElement(By.XPath(".//*[@id='email']")).SendKeys("test342424421@gmail.com");
                driver.FindElement(By.XPath(".//*[@id='passwd']")).SendKeys("123456789");

                driver.FindElement(By.XPath(".//*[@id='SubmitLogin']")).Click();

                Thread.Sleep(2000);

                IWebElement element = driver.FindElement(By.XPath(".//*[@class='account']"));
                String attValue = element.Text;

                Assert.AreEqual("name lastname", attValue);


            }
        }
    }
}
