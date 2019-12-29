using CompanyWebsitePageFactory.BrowserWrapper;
using System;
using TechTalk.SpecFlow;
using System.Configuration;
using CompanyWebsitePageFactory.PageObjects;
using Common_Paul.Webdriver;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class PrimaryNavigationBarSteps
    {
        [Given(@"I access the websites homepage")]
        public void GivenIAccessTheWebsitesHomepage()
        {
            WebdriverInit.GoToURL(ConfigurationManager.AppSettings["AboutUs"]);
        }
        
        [Given(@"I am on the ""(.*)"" page")]
        public void GivenIAmOnThePage(string PageTitle)
        {
            //getDriver().findElement(By.xpath("//li/a[contains(text(),'" + title  + "')]")).click();
            
        }

        [When(@"I click on ""(.*)"" from the primary navigation header")]
        public void WhenIClickOnFromThePrimaryNavigationHeader(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the Linklaters log at the top right of the webpage")]
        public void WhenIClickOnTheLinklatersLogAtTheTopRightOfTheWebpage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the link will open the ""(.*)"" page")]
        public void ThenTheLinkWillOpenThePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be returned to the homepage")]
        public void ThenIWillBeReturnedToTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
