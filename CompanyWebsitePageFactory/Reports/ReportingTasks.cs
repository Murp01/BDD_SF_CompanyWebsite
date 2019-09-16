using NUnit.Framework;
using NUnit.Framework.Interfaces;
//using RelevantCodes.ExtentReports;

namespace CompanyWebsitePageFactory.Reports
{
    public class ReportingTasks
    {
        //private ExtentReports _extent;
        //private ExtentTest _test;

        ///// Initializes a new instance of the class.
        //public ReportingTasks(ExtentReports extentInstance)
        //{
        //    _extent = extentInstance;
        //}


        //Initializes the test for reporting.  Runs at the beginning of each test
        public void InitializeTest()
        {
            //_test = _extent.StartTest(TestContext.CurrentContext.Test.Name);
        }


        //Finalizes test.  Runs at the end of every test
        public void FinalizeTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)

                ? ""
                : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

            //LogStatus logstatus;

            //switch (status)
            //{
            //    case TestStatus.Failed:
            //        logstatus = LogStatus.Fail;
            //        break;

            //    case TestStatus.Inconclusive:
            //        logstatus = LogStatus.Warning;
            //        break;

            //    case TestStatus.Skipped:
            //        logstatus = LogStatus.Skip;
            //        break;

            //    default:
            //        logstatus = LogStatus.Pass;
            //        break;
            //}
            //_test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            //_extent.EndTest(_test);
            //_extent.Flush();
        }


        //Cleans up reporting.  Runs after all the test finishes
        public void CleanUpReporting()
        {
            //_extent.Close();
        }

    }


}
