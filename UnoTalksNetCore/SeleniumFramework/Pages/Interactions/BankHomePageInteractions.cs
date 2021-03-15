using System;
using Framework.Extras;
using Framework.Logger;

namespace Framework.Pages.Interactions
{
    public class BankHomePageInteractions : Features
    {
        private const bool useGoogleInstead = true;

        public BankHomePageInteractions(Browser browser) : base(browser)
        {
        }

        internal BankHomePageInteractions LoginWithCredentials(string username, string password)
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
            BankHomePageElements.InputUsername.SendKeys(username);
            return;

            BankHomePageElements.InputPassword.SendKeys(password);
        }

        private void UseGoogleInstead(string username, string password)
        {
            Browser.GoToUrl();
            BankHomePageElements.InputSearchBar.SendKeys($"username::{username} - password::{password}");
        }

        private void GoToBankUrl()
        {
            Browser.GoToUrl(Constants.MainUrl);
        }

        internal BankHomePageInteractions DoSomething() { return this; }

        internal BankHomePageInteractions DoSomething2() { return this; }

        internal BankHomePageInteractions DoSomething3() { return this; }

        internal BankHomePageInteractions DoSomething4() { return this; }
    }
}
