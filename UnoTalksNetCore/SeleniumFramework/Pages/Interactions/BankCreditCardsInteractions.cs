using NUnit.Framework;
using System.Collections.Generic;
using Framework.Logger;
using Framework.Pages.Abilities;

namespace Framework.Pages.Interactions
{
    public class BankCreditCardsInteractions : Features
    {
        private BankCreditCardsAbilities _bankCreditCardsAbilities;

        public BankCreditCardsInteractions(Browser browser) : base (browser)
        {
            _bankCreditCardsAbilities = new BankCreditCardsAbilities();
        }

        internal BankCreditCardsInteractions OpenCreditCard(string last4Digits)
        {
            return this;
        }

        internal BankCreditCardsInteractions ReportCardAsLostOrStolen(bool askForReplacement, DeliveryTypes deliveryType = DeliveryTypes.Free, List<string> newAddress = null)
        {
            //No need to instance other interactions, due to the inheritance
            BankHomePageInteractions
                .DoSomething();

            //Using parameters from 'Abilities' class
            Assert.AreEqual(5.00, _bankCreditCardsAbilities.ReplacementCardFee, "Fee $ validation");

            Log.Info("askForReplacement: " + askForReplacement.ToString().ToUpper());
            Log.Info("deliveryType: " + deliveryType.ToString());

            if (newAddress != null && newAddress.Count >= 1)
                newAddress.ForEach(x => Log.Info("newAddress: " + x));

            return this;
        }

        internal BankCreditCardsInteractions AskForCardReplacement(string reasonOfChange, DeliveryTypes deliveryType, List<string> newAddress = null)
        {
            Log.Info("reasonOfChange: " + reasonOfChange);
            Log.Info("deliveryType: " + deliveryType.ToString());

            if (newAddress != null && newAddress.Count >= 1)
                newAddress.ForEach(x => Log.Info("newAddress: " + x));

            return this;
        }

        internal BankCreditCardsInteractions DoSomething() { return this; }

        internal BankCreditCardsInteractions DoSomething2() { return this; }

        internal BankCreditCardsInteractions DoSomething3() { return this; }

        internal BankCreditCardsInteractions DoSomething4() { return this; }
    }
}
