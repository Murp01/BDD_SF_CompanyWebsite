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
      
        [When(@"I enter a search term into Insights name search box")]
        public void WhenIEnterASearchTermIntoInsightsNameSearchBox()
        {
            DotCom.Insight.SearchAndReset();
        }
        
        [Then(@"all results containing the search box will appear")]
        public void ThenAllResultsContainingTheSearchBoxWillAppear()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select '(.*)' from the Year drop down box")]
        public void WhenISelectFromTheYearDropDownBox(string Year)
        {
            DotCom.Insight.FilterByYear(Year);
        }

    }
}
