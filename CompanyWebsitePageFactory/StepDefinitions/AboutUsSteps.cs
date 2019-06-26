using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.PageObjects;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class AboutUsSteps
    {
        [Given(@"I am on the About Us homepage")]
        public void GivenIAmOnTheAboutUsHomepage()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["AboutUs"]);
            BrowserFactory.Driver.Manage().Window.Maximize();
        }

        [When(@"I click on each ""(.*)"" accordion segment")]
        public void WhenIClickOnEachAccordionSegment(string ClosedAccordion)
        {
            Page.AboutUs.AccordionCheckOpenCloseThenClick(ClosedAccordion);
        }


        [Then(@"the correct content will be displayed")]
        public void ThenTheCorrectContentWillBeDisplayed()
        {
            Page.AboutUs.assertAccordionTextField();
        }
    }
}
