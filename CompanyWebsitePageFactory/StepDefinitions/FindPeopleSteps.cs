using CompanyWebsitePageFactory.BrowserWrapper;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class FindLawyerPagePeopleSearchSteps
    {
        [Given(@"I am on the Lawyer Search Page")]
        public void GivenIAmOnTheLawyerSearchPage()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
        }
        
        [Given(@"the lawyer directory tab is selected")]
        public void GivenTheLawyerDirectoryTabIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the business team directory tab is selected")]
        public void GivenTheBusinessTeamDirectoryTabIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have entered '(.*)' into the name input field")]
        public void WhenIHaveEnteredIntoTheNameInputField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have clicked on business team directory")]
        public void WhenIHaveClickedOnBusinessTeamDirectory()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all profiles displayed on the screen will contain '(.*)'")]
        public void ThenAllProfilesDisplayedOnTheScreenWillContain(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the business team contacts will be displayed")]
        public void ThenTheBusinessTeamContactsWillBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
