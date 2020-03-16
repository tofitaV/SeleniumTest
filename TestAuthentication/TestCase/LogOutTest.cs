using NUnit.Framework;
using OnlineStore.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestAuthentication.TestCase
{
    [TestFixture]
    class LogOutTest
    {
        #region test data
        string email = "test342424421@gmail.com";
        string password = "123456789";
        string fullName = "name lastname";
        string submitText = @"Sign in";
        #endregion

        static IWebDriver driver = new ChromeDriver();
        HomePage homePage = new HomePage(driver);
        LoginPage loginPage = new LoginPage(driver);
        MyAccountPage accountPage = new MyAccountPage(driver);

        [SetUp]
        public void SetUp()
        {
            driver.Url = "http://automationpractice.com/";
            homePage.ClickOnMyAccount();
            Thread.Sleep(2000);
        }

        [Test]
        public void PossitiveTest()
        {
            loginPage.LoginToApplication(email, password);
            Thread.Sleep(2000);
            Assert.AreEqual(fullName, accountPage.LogedUser());
            accountPage.LogOut();
            Thread.Sleep(2000);
            Assert.IsTrue(loginPage.SubmitButtonText().Contains(submitText));
        }

        [TestFixtureTearDown]
        public void AfterTest()
        {
            driver.Close();
        }
    }
}
