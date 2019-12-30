using Automation_Common.Webdriver;
using CompanyWebsitePageFactory.PageObjects;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    class HomePageSteps
    {
        [Given(@"I am on the Linklaters homepage")]
        public void GivenIAmOnTheLinklatersHomepage()
        {
            WebdriverInit.GoToURL(ConfigurationManager.AppSettings["URL"]);
        }


        [When(@"I wait a moment seconds for test purposes")]
        public void WhenIWaitAMomentSecondsForTestPurposes()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"I click on Insights from the global navigation bar")]
        public void GivenIClickOnInsightsFromTheGlobalNavigationBar()
        {
            DotCom.Home.ClickOnNavInsights();           
        }


        [When(@"I scroll the carousel feature by clicking on the ""(.*)"" border arrow")]
        public void WhenIScrollTheCarouselFeatureByClickingOnTheBorderArrow(string BorderArrow)
        {
            DotCom.Home.AssertSlideHasChanged(BorderArrow);
        }

        [Then(@"the carousel slide will change")]
        public void ThenTheCarouselSlideWillChange()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"""(.*)"" tab is selected")]
        public void GivenTabIsSelected(string Category)
        {
            DotCom.Home.selectCarouselTab(Category);
        }

        [When(@"I click on ""(.*)"" tab")]
        public void WhenIClickOnTab(string Tab)
        {
            DotCom.Home.selectSlideFromCarouselTab(Tab);
        }

        [Then(@"""(.*)"" will be displayed")]
        public void ThenWillBeDisplayed(string Category)
        {
            DotCom.Home.AssertSlideFromCarouselChanged(Category);
        }

        [Then(@"""(.*)"" tab will be selected")]
        public void ThenTabWillBeSelected(string Category)
        {
            DotCom.Home.AssertCorrectTabIsDisplayed(Category);
        }


        [Given(@"""(.*)"" is selected with ""(.*)"" selected")]
        public void GivenIsSelectedWithSelected(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on the ""(.*)"" link from the slide")]
        public void WhenIClickOnTheLinkFromTheSlide(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the ""(.*)"" webpage will be opened")]
        public void ThenTheWebpageWillBeOpened(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
