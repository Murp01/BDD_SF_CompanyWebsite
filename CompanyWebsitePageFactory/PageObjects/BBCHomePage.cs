using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyWebsitePageFactory.Extensions;
using CompanyWebsitePageFactory.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CompanyWebsitePageFactory.PageObjects
{
    class BBCHomePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='istats-notrack']")]
        [CacheLookup]
        public IWebElement Button_More { get; set; }



        public void ClickOnMoreBtn()
        {
            Button_More.ClickOnIt("Clicked on More button");
        }

    }
}
