using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Pages
{
    public class BankCreditCardsElements : BasePage
    {
        public BankCreditCardsElements(Browser browser):base (browser)
        {
        }

        #region Element locators

        [FindsBy(How = How.Id, Using = "btn-1")]
        private readonly IWebElement _button1;

        [FindsBy(How = How.Name, Using = "btn-2")]
        private readonly IWebElement _button2;

        #endregion Element locators

        #region Element accessors

        public IWebElement Button1 => _button1;

        public IWebElement Button2 => _button2;

        #endregion Element accessors
    }
}
