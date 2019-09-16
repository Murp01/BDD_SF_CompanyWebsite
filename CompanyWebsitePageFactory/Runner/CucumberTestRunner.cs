using CompanyWebsitePageFactory.BrowserWrapper;
using System.Configuration;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports; //reporting addition
using CompanyWebsitePageFactory.Reports; //reporting addition


namespace CompanyWebsitePageFactory.Runner
{
    [Binding]
    public class CucumberTestRunner
    {
        private static ReportingTasks _reportingTasks; //reporting addition

        [Before]
        public void ScenarioSetup()
        {

            ExtentReports extentReports = ReportingManager.Instance;

            //extentReports.LoadConfig(Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.FullName + "\\extent-config.xml");

            //Note we have hardcoded the browser, we will deal with this later

            extentReports.AddSystemInfo("Browser", "Chrome");



            _reportingTasks = new ReportingTasks(extentReports);


            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.Driver.Manage().Window.Maximize();
            BrowserFactory.GoToURL(ConfigurationManager.AppSettings["URL"]);
        }

        [After]
        public void ScenarioTeardown()
        {
            _reportingTasks.FinalizeTest(); //reporting addition
            BrowserFactory.CloseAllDrivers();
        }
    }
}
