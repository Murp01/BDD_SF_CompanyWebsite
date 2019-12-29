using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace CompanyWebsitePageFactory.BrowserWrapper
{
    class BrowserFactory
    {
        //private static IWebDriver driver;
        
        //public static IWebDriver GetDriver 
        //{
        //    get
        //    {
        //        if (driver == null)
        //            throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
        //        return driver;
        //    }
        //    private set
        //    {
        //        driver = value;
        //    }
        //}

        //public static void InitBrowser(string browserName)
        //{
        //    switch (browserName)
        //    {
        //        case "Firefox":
        //            driver = new FirefoxDriver();
        //            break;

        //        case "IE":
        //            //driver = new InternetExplorerDriver(@"C:\Webdriver");
        //            driver = new InternetExplorerDriver();
        //            break;

        //        case "Chrome":
        //            driver = new ChromeDriver();
        //            break;
        //    }
        //}

        //public static void GoToURL(string url)
        //{
        //    GetDriver.Url = url;
        //}

        //public static void CloseAllDrivers()
        //{
        //    GetDriver.Close();
        //    GetDriver.Quit();
        //}
    }

}
