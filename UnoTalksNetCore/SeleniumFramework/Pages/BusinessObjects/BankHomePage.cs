using System;
using Framework.Pages.Interactions;
using Framework.ParentClasses;

namespace Framework.BusinessObjects
{
    public class BankHomePage : BusinessObject, IBusinessObject
    {
        private BankHomePageInteractions bankHomePageInteractions;
        private string _username;
        private string _password;

        public BankHomePage(Browser browser): base(browser)
        {
            bankHomePageInteractions = new BankHomePageInteractions(Browser);
        }

        public void LoadDataFromFile(string dataSetID)
        {
            switch(dataSetID)
            {
                case "ID_CreditCards":
                    _username = "14809876";
                    _password = "MyPa$$W0rd123";
                    break;
            }
        }

        public BankHomePage LoginWithCredentials(string dataSetID)
        {
            LoadDataFromFile(dataSetID);

            bankHomePageInteractions
                .LoginWithCredentials(_username, _password);

            return this;
        }
    }
}
