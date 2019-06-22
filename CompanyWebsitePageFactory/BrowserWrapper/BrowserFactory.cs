using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace CompanyWebsitePageFactory.BrowserWrapper
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }


        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (driver == null)
                    {
                        driver = new FirefoxDriver();
                        Drivers.Add("Firefox", Driver);
                    }
                    break;

                case "IE":
                    if (driver == null)
                    {
                        driver = new InternetExplorerDriver(@"C:\Webdriver");
                        Drivers.Add("IE", Driver);
                    }
                    break;

                case "Chrome":
                    if (driver == null)
                    {
                        driver = new ChromeDriver();
                        Drivers.Add("Chrome", Driver);
                    }
                    break;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
    }

}
