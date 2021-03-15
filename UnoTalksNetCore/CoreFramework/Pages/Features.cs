using System;
using Framework.Pages.Interactions;

namespace Framework.Pages
{
    public abstract class Features
    {
        internal Browser Browser;

        public Features(Browser browser)
        {
            this.Browser = browser;
        }

        /// ............................................................................................................................................
        ///                                                           WEB ELEMENTS
        /// ............................................................................................................................................

        private BankCreditCardsElements _bankCreditCardsElements;
        private BankHomePageElements _bankHomePageElements;

        protected BankCreditCardsElements BankCreditCardsElements
        {
            get => _bankCreditCardsElements ?? new BankCreditCardsElements(Browser);
            set => new BankCreditCardsElements(Browser);
        }

        protected BankHomePageElements BankHomePageElements
        {
            get => _bankHomePageElements ?? new BankHomePageElements(Browser);
            set => new BankHomePageElements(Browser);
        }

        /// ............................................................................................................................................
        ///                                                            INTERACTIONS
        /// ............................................................................................................................................

        private BankCreditCardsInteractions _bankCreditCardsInteractions;
        private BankHomePageInteractions _bankHomePageInteractions;

        protected BankCreditCardsInteractions BankCreditCardsInteractions
        {
            get => _bankCreditCardsInteractions ?? new BankCreditCardsInteractions(Browser);
            set => new BankCreditCardsInteractions(Browser);
        }

        protected BankHomePageInteractions BankHomePageInteractions
        {
            get => _bankHomePageInteractions ?? new BankHomePageInteractions(Browser);
            set => new BankHomePageInteractions(Browser);
        }
    }
}
