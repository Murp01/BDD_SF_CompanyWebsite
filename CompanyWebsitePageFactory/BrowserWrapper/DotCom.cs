using Common_Paul.Webdriver;
using OpenQA.Selenium.Support.PageObjects;


namespace CompanyWebsitePageFactory.PageObjects
{
    class DotCom
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebdriverInit.GetDriver, page);
            return page;
        }

        public static AboutUs AboutUs
        {
            get { return GetPage<AboutUs>(); }
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static Insights Insight
        {
            get { return GetPage<Insights>(); }
        }

        public static ContactUs ContactUs
        {
            get { return GetPage<ContactUs>(); }
        }

        public static FindPeople FindPeople
        {
            get { return GetPage<FindPeople>(); }
        }

        public static PrimaryNavigation PrimaryNavigation
        {
            get { return GetPage<PrimaryNavigation>(); }
        }

    }
}

