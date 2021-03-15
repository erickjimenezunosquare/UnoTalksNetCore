using SeleniumExtras.PageObjects;

namespace Framework
{
    public abstract class BasePage
    {
        public Browser Browser { get; set; }

        protected BasePage(Browser browser)
        {
            this.Browser = browser;
            InitElements();
        }

        private void InitElements()
        {
            PageFactory.InitElements(Browser.Driver, this);
        }       
    }
}
