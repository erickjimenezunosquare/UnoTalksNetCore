using System;
using Framework;
using Framework.Pages;

namespace TestCases.ParentClasses
{
    public abstract class ErickTest : BankTest
    {
        protected Pages Pages;        

        protected void InitializeFramework()
        {
            InitializeBrowser();
            InitializePages();
        }

        private void InitializePages()
        {
            Pages = new Pages(Browser);
        }
    }
}
