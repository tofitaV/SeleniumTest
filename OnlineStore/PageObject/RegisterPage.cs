using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineStore.PageObject
{
    class RegisterPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        [CacheLookup]
        public IWebElement CustomerFirstname { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        [CacheLookup]
        public IWebElement CustomerLastname { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "firstname")]
        [CacheLookup]
        public IWebElement Firstname { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        [CacheLookup]
        public IWebElement Lastname { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        [CacheLookup]
        public IWebElement Adress { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        [CacheLookup]
        public IWebElement City { get; set; }

        public static void SelectByText()
        {

        }
        [FindsBy(How = How.Id, Using = "id_state")]
        [CacheLookup]
        public IWebElement State { get; set; }


        //SelectElement oSelect = new SelectElement();
        //oSelect.SelectByText("Texas");






        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        public IWebElement Email { get; set; }

        

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void CreateAccount()
        {

        }
    }
}
