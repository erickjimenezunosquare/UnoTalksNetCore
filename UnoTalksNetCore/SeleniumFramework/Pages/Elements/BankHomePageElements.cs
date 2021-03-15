using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Pages
{
    public class BankHomePageElements : BasePage
    {
        public BankHomePageElements(Browser browser):base (browser)
        {
        }

        #region Element locators

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'username') and contains(@class,'login')]")]
        private readonly IWebElement _inputUsername;

        [FindsBy(How = How.Id, Using = "password")]
        private readonly IWebElement _inputPassword;

        [FindsBy(How = How.Name, Using = "q")]
        private readonly IWebElement _inputSearchBar;

        #endregion Element locators

        #region Element accessors

        public IWebElement InputUsername => _inputUsername;

        public IWebElement InputPassword => _inputPassword;

        public IWebElement InputSearchBar => _inputSearchBar;

        #endregion Element accessors
    }
}
