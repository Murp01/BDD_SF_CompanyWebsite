﻿using CompanyWebsitePageFactory.BrowserWrapper;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.Runner
{
    [Binding]
    public class CucumberTestRunner
    {
        [Before]
        public void ScenarioSetup()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.Driver.Manage().Window.Maximize();
            BrowserFactory.GoToURL(ConfigurationManager.AppSettings["URL"]);
        }

        [After]
        public void ScenarioTeardown()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}
