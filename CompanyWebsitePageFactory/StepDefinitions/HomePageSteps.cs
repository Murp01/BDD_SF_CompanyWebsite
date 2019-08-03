using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    class HomePageSteps
    {
        [Given(@"I am on the Linklaters homepage")]
        public void GivenIAmOnTheLinklatersHomepage()
        {
            //BrowserFactory.InitBrowser("Chrome");
            //BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            //BrowserFactory.Driver.Manage().Window.Maximize();
        }

        [Given(@"I click on Insights from the global navigation bar")]
        public void GivenIClickOnInsightsFromTheGlobalNavigationBar()
        {
            Page.Home.ClickOnNavInsights();           
        }

        [When(@"I scroll the carousel feature by clicking on the ""(.*)"" border arrow")]
        public void WhenIScrollTheCarouselFeatureByClickingOnTheBorderArrow(string BorderArrow)
        {
            Page.Home.AssertSlideHasChanged(BorderArrow);
        }

        [Then(@"the carousel slide will change")]
        public void ThenTheCarouselSlideWillChange()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"""(.*)"" tab is selected")]
        public void GivenTabIsSelected(string Category)
        {
            Page.Home.selectCarouselTab(Category);
        }

        [When(@"I click on ""(.*)"" tab")]
        public void WhenIClickOnTab(string Tab)
        {
            Page.Home.selectSlideFromCarouselTab(Tab);
        }

        [Then(@"""(.*)"" will be displayed")]
        public void ThenWillBeDisplayed(string Category)
        {
            Page.Home.AssertSlideFromCarouselChanged(Category);
        }

        [Then(@"""(.*)"" tab will be selected")]
        public void ThenTabWillBeSelected(string Category)
        {
            Page.Home.AssertCorrectTabIsDisplayed(Category);
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
