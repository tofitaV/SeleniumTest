using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OnlineStore.PageObject;

namespace TestAuthentication
{
    [TestFixture]
    public class LogInTest
    {
        #region test data
        string email = "test342424421@gmail.com";
        string password = "123456789";
        string fullName = "name lastname";
        string authAlert = "Authentication failed.";
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
        public void NegativeLoggin()
        {
            var emailNegative = "eruguequge@gmail.com";
            loginPage.LoginToApplication(emailNegative, password);
            Thread.Sleep(2000);
            Assert.AreEqual(authAlert, loginPage.ErrorMessageAuth());
        }

        [Test]
        public void PossitiveTest()
        {
            Thread.Sleep(2000);
            loginPage.LoginToApplication(email, password);
            Thread.Sleep(2000);
            Assert.AreEqual(fullName, accountPage.LogedUser());
        }

        [Test]
        public void NegativePassword()
        {
            Thread.Sleep(2000);
            var passwordNegative = "eruguequge@gmail.com";
            loginPage.LoginToApplication(email, passwordNegative);
            Thread.Sleep(2000);
            Assert.AreEqual(authAlert, loginPage.ErrorMessageAuth());
        }

        [TestFixtureTearDown]
        public void AfterTest() 
        {
            driver.Close();
        }
    }
}

