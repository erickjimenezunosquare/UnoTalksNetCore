using System;
using Framework.Extras;
using Framework.Logger;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Pages
{
    public class BankHomePage : BasePage
    {
        private const bool useGoogleInstead = true;

        //Constructor
        public BankHomePage(Browser browser):base (browser)
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

        #region Page Methods

        public BankHomePage LoginWithCredentials(string username, string password)
        {
            Log.Info($"Logging in with user: {username}");
            Log.Info($"Logging in with password: {password}");

            if (!useGoogleInstead)
                LoginFlow(username, password);
            else
                UseGoogleInstead(username, password);

            return this;
        }

        private void LoginFlow(string username, string password)
        { 
            GoToBankUrl();
            InputUsername.SendKeys(username);
            return;

            InputPassword.SendKeys(password);
        }

        private void UseGoogleInstead(string username, string password)
        {
            Browser.GoToUrl();
            SeleniumExtras.PageObjects.PageFactory.InitElements(Browser.Driver, this);
            InputSearchBar.SendKeys($"username::{username} - password::{password}");
        }

        private void GoToBankUrl()
        {
            Browser.GoToUrl(Constants.MainUrl);
        }

        public BankHomePage DoSomething() { return this;  }

        public BankHomePage DoSomething2() { return this; }

        public BankHomePage DoSomething3() { return this; }

        public BankHomePage DoSomething4() { return this; }

        #endregion Page Methods
    }
}
