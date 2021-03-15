using System;
using System.Collections.Generic;
using Framework.Logger;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Pages
{
    public class BankCreditCards : BasePage
    {
        BankHomePage _bankHomePage;

        public BankCreditCards(Browser browser):base (browser)
        {
            _bankHomePage = new BankHomePage(browser);            
        }    

        #region Element locators

        [FindsBy(How = How.Id, Using = "btn-1")]
        private readonly IWebElement _button1;

        [FindsBy(How = How.Name, Using = "btn2")]
        private readonly IWebElement _button2;

        #endregion Element locators

        #region Element accessors

        public IWebElement Button1 => _button1;

        public IWebElement Button2 => _button2;

        #endregion Element accessors

        #region Page Methods

        public BankCreditCards OpenCreditCard(string last4Digits)
        {            
            return this;
        }

        public BankCreditCards ReportCardAsLostOrStolen(bool askForReplacement, DeliveryTypes deliveryType = DeliveryTypes.Free, List<string> newAddress = null)
        {
            //THERE IS NEED to instance other pages in order to access their methods (see this class constructor)
            _bankHomePage
                .DoSomething();

            //Using parameters from THIS class
            Assert.AreEqual(5.00, ReplacementCardFee, "Fee $ validation");

            Log.Info("askForReplacement: " + askForReplacement.ToString().ToUpper());
            Log.Info("deliveryType: " + deliveryType.ToString());

            if(newAddress != null && newAddress.Count >= 1)
                newAddress.ForEach(x => Log.Info("newAddress: " + x));

            return this;
        }

        public BankCreditCards AskForCardReplacement(string reasonOfChange, DeliveryTypes deliveryType, List<string> newAddress = null)
        {
            Log.Info("reasonOfChange: " + reasonOfChange);
            Log.Info("deliveryType: " + deliveryType.ToString());

            if (newAddress != null && newAddress.Count >= 1)
                newAddress.ForEach(x => Log.Info("newAddress: " + x));

            return this;
        }

        public BankCreditCards DoSomething() { return this; }

        public BankCreditCards DoSomething2() { return this; }

        public BankCreditCards DoSomething3() { return this; }

        public BankCreditCards DoSomething4() { return this; }

        #endregion Page Methods

        #region Parameters

        private readonly Dictionary<int, string> _validStatuses = new Dictionary<int, string>
        {
            { 1, "Active" },
            { 2, "Frozen" },
            { 3, "Suspended" },
            { 4, "Closed" },
            { 5, "Expired" },
            { 6, "Deleted" },
            { 7, "PIN Retries Exceeded" }
        };

        public Dictionary<int, string> ValidStatuses { get { return _validStatuses; } }

        public string CustomerServicePhone { get { return "1-866-104-7461"; } }

        public string DisclaimerText { get { return "This text ideally should be placed on a JSON or XML file."; } }

        public double ReplacementCardFee { get { return 5.00; } }

        #endregion Parameters
    }

    public enum CardNetworks
    {
        Visa,
        Mastercard
    }

    public enum DeliveryTypes
    {
        Rush,
        Free
    }
}
