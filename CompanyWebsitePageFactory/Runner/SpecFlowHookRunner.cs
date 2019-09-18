using CompanyWebsitePageFactory.BrowserWrapper;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using System.Reflection;
using System.IO;
using System;




namespace CompanyWebsitePageFactory.Runner
{

    [Binding]
    public class SpecflowHookRunner
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;


        [BeforeTestRun]
        public static void InitializeReport()
        {
            string relativePath = Environment.CurrentDirectory;

            var htmlReporter = new ExtentHtmlReporter(@"C:\ExtentReports\ExtentReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            //Create Extent report instance variable
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);           
        }


        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }


        [BeforeScenario]
        public void Initialize()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.GetDriver.Manage().Window.Maximize();
            BrowserFactory.GoToURL(ConfigurationManager.AppSettings["URL"]);
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }


        [AfterStep]
        public void InsertReportingSteps()
        {
            //Creates a string variable which displays the test step type. i.e. Given
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            //the below code retrieves the TestStatus property of the test - this is used in pending if statement - adding below code will fail all tests?
            //PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            //MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            //object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)  //if there is no error in the test
            {
                //if statement finds name of step and then adds it correctly to code
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if(stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            //Pending status
            //if (TestResult.ToString() == "StepDefinitionPending")
            //if (ScenarioContext.Current.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")
            //{
            //    if (stepType == "Given")
            //        scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Defintion Pending");
            //    if (stepType == "When")
            //        scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Defintion Pending");
            //    if (stepType == "Then")
            //        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Defintion Pending");
            //    if (stepType == "And")
            //        scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Defintion Pending");
            //}


        }


        [AfterScenario]
        public void CloseScenario()
        {
            BrowserFactory.CloseAllDrivers();
        }


        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }

    }
}
