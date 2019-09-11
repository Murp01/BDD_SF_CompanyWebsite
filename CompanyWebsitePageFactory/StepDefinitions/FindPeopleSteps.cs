using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.Extensions;
using CompanyWebsitePageFactory.PageObjects;
using CompanyWebsitePageFactory.BrowserWrapper;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class FindLawyerPagePeopleSearchSteps
    {
        [Given(@"I am on the Lawyer Search Page")]
        public void GivenIAmOnTheLawyerSearchPage()
        {
            //BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["FindPeople"]);
            //BrowserFactory.Driver.Manage().Window.Maximize();
        }

        [Given(@"the ""(.*)"" selector is selected")]
        public void GivenTheSelectorIsSelected(string Selector)
        {
            DotCom.FindPeople.ClickOnDirectorySelector(Selector);
        }

        
        [Given(@"the business team directory tab is selected")]
        public void GivenTheBusinessTeamDirectoryTabIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have entered '(.*)' into the name input field")]
        public void WhenIHaveEnteredIntoTheNameInputField(string PersonName)
        {
            DotCom.FindPeople.InputSearchPersonName(PersonName);
        }


        [Given(@"the lawyer directory tab is selected")]
        public void GivenTheLawyerDirectoryTabIsSelected()
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
