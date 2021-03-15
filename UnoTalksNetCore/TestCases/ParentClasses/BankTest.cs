using Framework;

namespace TestCases
{
    public abstract class BankTest
    {
        protected Browser Browser { get; set; }

        protected BankTest()
        {
            Browser = new Browser();
        }

        protected void InitializeBrowser()
        {
            Browser.PickDriver();
        }

        protected void CleanupTest()
        {
            Browser.Quit();
        }

        protected void WaitFewSeconds()
        {
            Browser.WaitTime(4);
        }
    }
}