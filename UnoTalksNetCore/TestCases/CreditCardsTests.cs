using Framework.Logger;
using NUnit.Framework;
using System.Collections.Generic;
using TestCases.ParentClasses;

//Author: Erick Jiménez (erick9025@hotmail.com)

namespace TestCases
{
    [TestFixture()]
    public class CreditCardsTests : ErickTest
    {
        #region Initialization

        [OneTimeSetUp]
        public void BeforeEachSuite()
        {
            //Actions that happen (before) ONLY once per run
            Log.PrintSystemInfo();
        }

        [SetUp]
        public void BeforeEachTest()
        {
            //Actions that happen before each script/test
            InitializeFramework();
        }
        #endregion Initialization

        [Test()]
        public void ReportCard_Comb1_NoReplacement()
        {
            Pages.BankHomePage
                .LoginWithCredentials("14809876", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(false);
        }

        [Test()]
        public void ReportCard_Comb2_Rush_OriginalAddress()
        {
            Pages.BankHomePage
                .LoginWithCredentials("14809876", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(true, Framework.Pages.DeliveryTypes.Rush);
        }

        [Test()]
        public void ReportCard_Comb3_Rush_NewAddress()
        {
            List<string> newAddressLines = new List<string>
            {
                "123 Main St",
                "Apt. 3",
                "90210",
                "Beverly Hills",
                "CA"
            };

            Pages.BankHomePage
                .LoginWithCredentials("14809876", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(true, Framework.Pages.DeliveryTypes.Rush, newAddressLines);
        }

        [Test()]
        public void ReportCard_Comb4_Free_OriginalAddress()
        {
            Pages.BankHomePage
                .LoginWithCredentials("14809876", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(true, Framework.Pages.DeliveryTypes.Free);
        }

        [Test()]
        public void ReportCard_Comb5_Free_NewAddress()
        {
            List<string> newAddressLines = new List<string>
            {
                "123 Main St",
                "Apt. 3",
                "90210",
                "Beverly Hills",
                "CA"
            };

            Pages.BankHomePage
                .LoginWithCredentials("14809876", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(true, Framework.Pages.DeliveryTypes.Free, newAddressLines);
        }

        #region Tear Down

        [TearDown]
        public void AfterEachTest()
        {
            //Actions that happen after each script/test
            WaitFewSeconds();
            CleanupTest();
        }

        [OneTimeTearDown]
        public void AfterEachSuite()
        {
            //Actions that happen (after) ONLY once per run
            Log.Info("All scripts ran succesfully");
        }
        #endregion Tear Down
    }
}
