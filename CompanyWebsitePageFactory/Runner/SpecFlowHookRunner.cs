using CompanyWebsitePageFactory.BrowserWrapper;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;



namespace CompanyWebsitePageFactory.Runner
{
    [Binding]
    public class SpecflowHookRunner //rename to hooks?
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        [BeforeTestRun]
        public static void InitializeReport()
        {
            //Create Html Report
            var htmlReporter = new ExtentHtmlReporter(@"C:\\ExtentReports");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            //Create Extent report instance variable
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);           
        }


        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }


        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }


        [AfterStep]
        public void InsertReportingSteps()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
        }

        [BeforeScenario]
        public void Initialize()
        {
            //SelectBrowser(BrowserType.Chrome);
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }


        [Before]
        public void ScenarioSetup()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.GetDriver.Manage().Window.Maximize();
            BrowserFactory.GoToURL(ConfigurationManager.AppSettings["URL"]);
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [After]
        public void ScenarioTeardown()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}
