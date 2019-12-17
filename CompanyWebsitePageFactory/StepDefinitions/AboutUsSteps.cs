using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.Extensions;
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
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["AboutUs"]);
        }

        [When(@"I click on each ""(.*)"" accordion segment")]
        public void WhenIClickOnEachAccordionSegment(string ClosedAccordion)
        {
            DotCom.AboutUs.AccordionCheckOpenCloseThenClick(ClosedAccordion);
        }

        [Then(@"the correct content will be displayed")]
        public void ThenTheCorrectContentWillBeDisplayed()
        {
            DotCom.AboutUs.assertAccordionTextField();
        }

        [Given(@"accordion ""(.*)"" is open")]
        public void GivenAccordionIsOpen(string segment)
        {
            DotCom.AboutUs.assertAccordionTabOpenElseClickToOpen(segment);
        }

        [When(@"I click on the browsers ""(.*)"" navigation button")]
        public void WhenIClickOnTheBrowsersNavigationButton(string nav)
        {
            Element_Extensions.BrowserNavigate(nav);
        }

        [Then(@"all accordion segments will be closed")]
        public void ThenAllAccordionSegmentsWillBeClosed()
        {
            DotCom.AboutUs.assertAllAccordionTabsAreClosed();
        }

        [Given(@"""(.*)"" is open")]
        public void GivenIsOpen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on the ""(.*)"" link from within ""(.*)""")]
        public void WhenIClickOnTheLinkFromWithin(string link, string section)
        {
            DotCom.AboutUs.clickOnLinkWithinAccordionTextbox(link, section);
        }

        [Then(@"the webpage will change to ""(.*)""")]
        public void ThenTheWebpageWillChangeTo(string p0)
        {
            
        }




    }
}
