using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace CompanyWebsitePageFactory.Reports
{
    /// Creates a single instance of Extent Report 
    public class ReportingManager
    {
        /// Create new instance of Extent report
        private static readonly ExtentReports _instance = new ExtentReports(TestContext.CurrentContext.TestDirectory + "C:\\Users\\paul.murphy\\Source\\Repos\\BDD_SF_CompanyWebsite2\\ReportTest\\TestResults.html");

        static ReportingManager()
        {

        }
        private ReportingManager()
        {

        }

        /// Property to return the instance of the report.
        public static ExtentReports Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
