using System;
using System.Collections.Generic;
using Framework.Pages.Interactions;
using Framework.ParentClasses;

namespace Framework.BusinessObjects
{
    public class BankCreditCards : BusinessObject, IBusinessObject
    {
        private BankCreditCardsInteractions bankCreditCardsInteractions;

        public BankCreditCards(Browser browser) : base(browser)
        {
            bankCreditCardsInteractions = new BankCreditCardsInteractions(Browser);
        }

        public void LoadDataFromFile(string dataSetID)
        {
            throw new NotImplementedException();
        }

        public BankCreditCards ReportCardOnly()
        {
            bankCreditCardsInteractions
                .ReportCardAsLostOrStolen(false);

            return this;
        }

        public BankCreditCards ReportCardRushReplacementOriginalAddress()
        {
            bankCreditCardsInteractions
                .ReportCardAsLostOrStolen(true, Pages.Abilities.DeliveryTypes.Rush);

            return this;
        }

        public BankCreditCards ReportCardRushReplacementNewAddress()
        {
            List<string> newAddressLines = new List<string>
            {
                "123 Main St",
                "Apt. 3",
                "90210",
                "Beverly Hills",
                "CA"
            };

            bankCreditCardsInteractions
                .ReportCardAsLostOrStolen(true, Pages.Abilities.DeliveryTypes.Rush, newAddressLines);

            return this;
        }

        public BankCreditCards ReportCardFreeReplacementOriginalAddress()
        {
            bankCreditCardsInteractions
                .ReportCardAsLostOrStolen(true, Pages.Abilities.DeliveryTypes.Free);

            return this;
        }

        public BankCreditCards ReportCardFreeReplacementNewAddress()
        {
            List<string> newAddressLines = new List<string>
            {
                "123 Main St",
                "Apt. 3",
                "90210",
                "Beverly Hills",
                "CA"
            };

            bankCreditCardsInteractions
                .ReportCardAsLostOrStolen(true, Pages.Abilities.DeliveryTypes.Free, newAddressLines);

            return this;
        }
    }
}
