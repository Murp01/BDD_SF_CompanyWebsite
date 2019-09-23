using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.Extensions;
using CompanyWebsitePageFactory.PageObjects;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class LogInPageSteps
    {
        [Given(@"I am on the Trello Log in page")]
        public void GivenIAmOnTheTrelloLogInPage()
        {
            BrowserFactory.GoToURL(ConfigurationManager.AppSettings["LoginPageURL"]);
        }
        
        [Given(@"I enter an unregistered email address into Email field")]
        public void GivenIEnterAnUnregisteredEmailAddressIntoEmailField()
        {
            PageObjectFactory.LogInPage.InputUnregisteredEmailAddress();
        }
        
        [Given(@"I enter an unregistered password into the password field")]
        public void GivenIEnterAnUnregisteredPasswordIntoThePasswordField()
        {
            PageObjectFactory.LogInPage.InputUnregisteredPassword();
        }
        
        [When(@"I click on the Log in button")]
        public void WhenIClickOnTheLogInButton()
        {
            PageObjectFactory.LogInPage.ClickOnLogInButton();
        }
        
        [Then(@"a prompt will state ""(.*)""")]
        public void ThenAPromptWillState(string ErrorPrompt)
        {
            PageObjectFactory.LogInPage.AssertAccountErrorPrompt(ErrorPrompt);
        }
    }
}
