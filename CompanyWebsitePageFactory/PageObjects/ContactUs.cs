using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class ContactUs
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='mapContact__controlContainer bg-brand-magenta-dark']")]
        [CacheLookup]
        private IWebElement Container_ContactUsBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='btn-group bootstrap-select dropup open']//select[@class='selectpicker']/option")]
        [CacheLookup]
        private IWebElement Option_LocationDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='btn-group bootstrap-select dropup']//button[@class='btn dropdown-toggle btn-default']")]
        [CacheLookup]
        private IWebElement Btn_LocationDropdown { get; set; }


        public void selectLocationFromDropDown(string location)
        {
            Btn_LocationDropdown.ClickOnIt("Clicked on dropdown button");
            Option_LocationDropdown.SelectByText(location, location);
        }
    }
}
