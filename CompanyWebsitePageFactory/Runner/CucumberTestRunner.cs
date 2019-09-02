﻿using CompanyWebsitePageFactory.BrowserWrapper;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.Runner
{
    [Binding]
    public class CucumberTestRunner
    {
        //[Before]
        public void ScenarioSetup()
        {
            //start driver
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            BrowserFactory.Driver.Manage().Window.Maximize();
        }

        //[After]
        public void ScenarioTeardown()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}