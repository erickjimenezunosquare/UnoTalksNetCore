using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Browser
    {
        internal IWebDriver Driver { get; set; }

        public void PickDriver()
        {
            ChromeOptions chromeOptions;
            chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-notifications");
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);

            Driver = new ChromeDriver(chromeOptions);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Driver.Manage().Window.Maximize();
        }

        public void GoToUrl(string url = "https://google.com")
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            Driver.Quit();
        }

        public void WaitTime(int timeSeconds)
        {
            Thread.Sleep(1000 * timeSeconds);
        }
    }
}

#region Commented Code
/*
public class Browser
    {
        internal IWebDriver Driver { get; private set; }

        public IWebDriver PickDriver()
        {
            ChromeOptions chromeOptions;
            chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-notifications");
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);

            Driver = new ChromeDriver(chromeOptions);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Driver.Manage().Window.Maximize();

            return Driver;
        }

        public void Quit()
        {
            this.Driver.Quit();
        }
    }
*/
#endregion