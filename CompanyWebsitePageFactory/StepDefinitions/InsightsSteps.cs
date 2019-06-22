using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.PageObjects;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{

    [Binding]
    public class InsightsSteps
    {

        [Given(@"I am on the Linklaters homepage")]
        public void GivenIAmOnTheLinklatersHomepage()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
        }
        
        [Given(@"I click on Insights from the global navigation bar")]
        public void GivenIClickOnInsightsFromTheGlobalNavigationBar()
        {
            Page.Home.ClickOnNavInsights();
        }
        
        [When(@"I enter a search term into Insights name search box")]
        public void WhenIEnterASearchTermIntoInsightsNameSearchBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all results containing the search box will appear")]
        public void ThenAllResultsContainingTheSearchBoxWillAppear()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
