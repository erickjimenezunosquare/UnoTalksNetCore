using System;
namespace Framework.Pages
{
    public class Pages
    {
        private Browser Browser { get; set; }

        public Pages(Browser browser)
        {
            this.Browser = browser;
        }

        private BankHomePage _bankHomePage;

        private BankCreditCards _bankCreditCards;

        public BankHomePage BankHomePage
        {
            get
            {
                return _bankHomePage ?? (_bankHomePage = new BankHomePage(Browser));
            }
        }

        public BankCreditCards BankCreditCards
        {
            get
            {
                return _bankCreditCards ?? (_bankCreditCards = new BankCreditCards(Browser));
            }
        }
    }
}
