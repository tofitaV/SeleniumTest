using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineStore.PageObject
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "login")]
        private IWebElement SignIn { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickOnMyAccount()
        {
            SignIn.Click();
        }

    }
}
