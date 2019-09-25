using System;
using TechTalk.SpecFlow;

namespace API_Tests.Step_Definitions
{
    [Binding]
    public class LoginPageSteps
    {
        [Given(@"I am on the Trello log in screen")]
        public void GivenIAmOnTheTrelloLogInScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter my username and password into the password field")]
        public void GivenIEnterMyUsernameAndPasswordIntoThePasswordField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the login")]
        public void WhenIClickOnTheLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be logged into my account")]
        public void ThenIWillBeLoggedIntoMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
