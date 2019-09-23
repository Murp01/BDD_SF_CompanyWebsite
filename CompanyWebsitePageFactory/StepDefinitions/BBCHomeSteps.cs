using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.Extensions;
using CompanyWebsitePageFactory.PageObjects;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class PrimaryNavigationMenuSteps
    {
        [Given(@"I am on the BBC homepage")]
        public void GivenIAmOnTheBBCHomepage()
        {
            BrowserFactory.GoToURL(ConfigurationManager.AppSettings["URL"]);
        }
        
        [When(@"I click on the More drop down button")]
        public void WhenIClickOnTheMoreDropDownButton()
        {
            PageObjectFactory.BBCHomePage.ClickOnMoreBtn();
        }
        
        [Then(@"further nav options are revealed below the primary nav bar")]
        public void ThenFurtherNavOptionsAreRevealedBelowThePrimaryNavBar()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
