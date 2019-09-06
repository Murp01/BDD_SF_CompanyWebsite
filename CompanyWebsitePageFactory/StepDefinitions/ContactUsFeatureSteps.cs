using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.PageObjects;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{
    [Binding]
    public class ContactUsFeatureSteps
    {
        [Given(@"I am on the About Us page")]
        public void GivenIAmOnTheAboutUsPage()
        {
            //BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["ContactUs"]);
            //BrowserFactory.Driver.Manage().Window.Maximize();
        }

        [When(@"I select the ""(.*)"" location from the Contact Us drop down box")]
        public void WhenISelectTheLocationFromTheContactUsDropDownBox(string Location)
        {
            
            DotCom.ContactUs.SelectLocationFromDropDown(Location);
        }
        
        [Then(@"the details for the ""(.*)"" location will be displayed in the Contact Us box")]
        public void ThenTheDetailsForTheLocationWillBeDisplayedInTheContactUsBox(string Location)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
