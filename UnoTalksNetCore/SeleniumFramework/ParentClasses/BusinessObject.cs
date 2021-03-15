using System;
namespace Framework.ParentClasses
{
    public abstract class BusinessObject
    {
        public Browser Browser { get; set; }

        protected BusinessObject(Browser browser)
        {
            this.Browser = browser;
        }
    }
}
