using CompanyWebsitePageFactory.BrowserWrapper;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static Insights Insight
        {
            get { return GetPage<Insights>(); }
        }
    }
}

