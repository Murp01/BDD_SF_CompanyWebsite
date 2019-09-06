using CompanyWebsitePageFactory.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CompanyWebsitePageFactory.PageObjects
{
    class ContactUs
    {
        //private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='mapContact__controlContainer bg-brand-magenta-dark']")]
        [CacheLookup]
        private IWebElement Container_ContactUsBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='btn-group bootstrap-select dropup open']//select[@class='selectpicker']/option")]
        [CacheLookup]
        private IWebElement Option_LocationDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='btn-group bootstrap-select dropup']//button[@class='btn dropdown-toggle btn-default']")]
        [CacheLookup]
        private IWebElement Btn_LocationDropdown { get; set; }


        public void SelectLocationFromDropDown(string location)
        {
            Btn_LocationDropdown.ClickOnIt("Clicked on dropdown button");
            Option_LocationDropdown.SelectByText(location, location);
        }
    }
}
