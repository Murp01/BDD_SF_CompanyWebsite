using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.Extensions;
using CompanyWebsitePageFactory.PageObjects;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class AccountHomeStepDefinitions
    {
        [Given(@"I have logged into Trello with a valid account")]
        public void GivenIHaveLoggedIntoTrelloWithAValidAccount()
        {
            PageObjectFactory.LogInPage.LogIntoValidTrelloAccount();
        }
        
        [When(@"I click on the Create new board box")]
        public void WhenIClickOnTheCreateNewBoardBox()
        {
            PageObjectFactory.AccountHome.ClickHSCreateNewBoardButton();
        }

        [Then(@"a new Personal board will be displayed on the home screen")]
        public void ThenANewPersonalBoardWillBeDisplayedOnTheHomeScreen()
        {
            ScenarioContext.Current.Pending();
        }



        [When(@"I type the name of the board into the title field")]
        public void WhenITypeTheNameOfTheBoardIntoTheTitleField()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the Board Template Create Board Button")]
        public void WhenIClickTheBoardTemplateCreateBoardButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I create a new board from the account home page")]
        public void WhenICreateANewBoardFromTheAccountHomePage()
        {
            PageObjectFactory.AccountHome.CreateANewBoardFromAccountHome();
        }


    }
}
