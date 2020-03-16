using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineStore.PageObject
{
    public class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "login")]
        private IWebElement Login { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']/ol/li")]
        private IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']/span")]
        private IWebElement SubmitText { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginToApplication(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            Submit.Submit();
        }

        public string ErrorMessageAuth()
        {
            return ErrorMessage.Text;
        }

        public string SubmitButtonText()
        {
            return SubmitText.Text;
        }



        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement EmailForCreateAccount { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement SubmitCreate { get; set; }
        public void CreateAccount()
        {
            EmailForCreateAccount.SendKeys("test342424421@gmail.com");
            SubmitCreate.Submit();

        }
    }
}
