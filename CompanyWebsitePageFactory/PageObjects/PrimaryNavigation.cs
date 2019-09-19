using CompanyWebsitePageFactory.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace CompanyWebsitePageFactory.PageObjects
{
    class PrimaryNavigation
    {
        private IWebDriver chromeDriver;

        [FindsBy(How = How.XPath, Using = "//div[@class='header__navDesktop']//a[contains(text(),'About Us')]")]
        [CacheLookup]
        public IWebElement Title_AboutUs { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header__navDesktop']//a[contains(text(),'Client Services')]")]
        [CacheLookup]
        public IWebElement Title_ClientServices { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header__navDesktop']//a[contains(text(),'Sectors')]")]
        [CacheLookup]
        public IWebElement Title_Sectors { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header__navDesktop']//a[contains(text(),'Insights')]")]
        [CacheLookup]
        public IWebElement Title_Insights { get; set; }



        public void ClickOnPrimaryNavTitle(string PageTitle)
        {
            switch (PageTitle)
            {
                case "About Us":
                    Title_AboutUs.ClickOnIt("Clicked on " + PageTitle + "from " + "Primary Navigation bar");
                    break;
                case "Client Services":
                    Title_ClientServices.ClickOnIt("Clicked on " + PageTitle + "from " + "Primary Navigation bar");
                    break;
                case "Sectors":
                    Title_Sectors.ClickOnIt("Clicked on " + PageTitle + "from " + "Primary Navigation bar");
                    break;
                case "Insights":
                    Title_Sectors.ClickOnIt("Clicked on " + PageTitle + "from " + "Primary Navigation bar");
                    break;
            }

        }
    }
}
