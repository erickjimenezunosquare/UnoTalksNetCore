using Framework;
using Framework.Logger;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestCases.ParentClasses;

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
            BusinessObjects.BankHomePage
                .LoginWithCredentials("ID_CreditCards");

            BusinessObjects.BankCreditCards
                .ReportCardOnly();
        }

        [Test()]
        public void ReportCard_Comb2_Rush_OriginalAddress()
        {
            BusinessObjects.BankHomePage
                .LoginWithCredentials("ID_CreditCards");

            BusinessObjects.BankCreditCards
                .ReportCardRushReplacementOriginalAddress();
        }

        [Test()]
        public void ReportCard_Comb3_Rush_NewAddress()
        {
            BusinessObjects.BankHomePage
                .LoginWithCredentials("ID_CreditCards");

            BusinessObjects.BankCreditCards
                .ReportCardRushReplacementNewAddress();
        }

        [Test()]
        public void ReportCard_Comb4_Free_OriginalAddress()
        {
            BusinessObjects.BankHomePage
                .LoginWithCredentials("ID_CreditCards");

            BusinessObjects.BankCreditCards
                .ReportCardFreeReplacementOriginalAddress();
        }

        [Test()]
        public void ReportCard_Comb5_Free_NewAddress()
        {
            BusinessObjects.BankHomePage
                .LoginWithCredentials("ID_CreditCards");

            BusinessObjects.BankCreditCards
                .ReportCardFreeReplacementNewAddress();
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
