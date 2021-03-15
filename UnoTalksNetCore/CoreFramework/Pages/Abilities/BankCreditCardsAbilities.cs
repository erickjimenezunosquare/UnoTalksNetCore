using System;
using System.Collections.Generic;

namespace Framework.Pages.Abilities
{
    public class BankCreditCardsAbilities
    {
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
