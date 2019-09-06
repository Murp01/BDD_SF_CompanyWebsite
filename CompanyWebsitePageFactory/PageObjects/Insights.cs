using CompanyWebsitePageFactory.Extensions;
using CompanyWebsitePageFactory.TestDataAccess;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class Insights
    {
        //private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Reset search')]")]
        [CacheLookup]
        public IWebElement Btn_Reset { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        [CacheLookup]
        public IWebElement DrpDwn_Location { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Year')]")]
        [CacheLookup]
        public IWebElement DrpDwn_Year { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        [CacheLookup]
        public IWebElement Input_Name { get; set; }

        public void SearchAndReset()
        {
            Input_Name.SendKeys("Linklaters");
            Btn_Reset.Click();
        }

        public void FilterByYear(string Year)
        {
            DrpDwn_Year.SelectByText(Year, "DrpDwn_Year");
        }
    }
}

