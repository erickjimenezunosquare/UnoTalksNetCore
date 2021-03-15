using System;
using Framework;
using Framework.Pages;

namespace TestCases.ParentClasses
{
    public abstract class ErickTest : BankTest
    {
        protected BusinessObjects BusinessObjects;        

        protected void InitializeFramework()
        {
            InitializeBrowser();
            InitializeBusinessObjects();
        }

        private void InitializeBusinessObjects()
        {
            BusinessObjects = new BusinessObjects(Browser);
        }
    }
}
