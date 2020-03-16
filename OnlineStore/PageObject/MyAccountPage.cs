using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineStore.PageObject
{
    public class MyAccountPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'header_user_info']/a/span")]
        private IWebElement UserInfo { get; set; }

        [FindsBy(How = How.ClassName, Using = "logout")]
        private IWebElement SignOut { get; set; }

        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string LogedUser()
        {
            return UserInfo.Text;
        }

        public void LogOut()
        {
            SignOut.Click();
        }
    }
}
