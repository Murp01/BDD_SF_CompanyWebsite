using CompanyWebsitePageFactory.BrowserWrapper;
using OpenQA.Selenium.Support.PageObjects;


namespace CompanyWebsitePageFactory.PageObjects
{
    class PageObjectFactory
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.GetDriver, page);
            return page;
        }

        public static AboutUs AboutUs
        {
            get { return GetPage<AboutUs>(); }
        }



    }
}

