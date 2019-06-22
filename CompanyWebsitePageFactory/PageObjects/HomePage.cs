using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='header__navDesktop']//a[contains(text(),'Insights')]")]
        [CacheLookup]
        private IWebElement PNav_Insights { get; set; }

        [FindsBy(How = How.ClassName, Using = "icon-search")]
        [CacheLookup]
        public IWebElement Btn_SiteSearch { get; set; }


            public void ClickOnNavInsights()
        {
            PNav_Insights.Click();
        }


    }
}
