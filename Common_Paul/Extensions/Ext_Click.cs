﻿using Common_Paul.Webdriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Paul.Extensions
{
    public static class Ext_Click
    {
        public static void EnterText(this IWebElement element, string text, string elementName)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine(text + " entered in the " + elementName + " field.");
        }

        public static bool IsDisplayed(this IWebElement element, string elementName)
        {
            bool result;
            try
            {
                result = element.Displayed;
                Console.WriteLine(elementName + " is Displayed.");
            }
            catch (Exception)
            {
                result = false;
                Console.WriteLine(elementName + " is not Displayed.");
            }

            return result;
        }

        public static void ClickOnIt(this IWebElement element, string elementName)
        {
            if (element.Displayed)
            {
                element.Click();
                Console.WriteLine("Clicked on " + elementName);
            }
            else
            {
                Console.WriteLine("Element not displayed");
            }

        }

        public static void JavaScriptClick(IWebElement GetWebElement)
        {
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)BrowserFactory.Driver;
            //executor.ExecuteScript("arguments[0].click()", GetWebElement(true, true));


            //IWebDriver driver; // assume assigned elsewhere - Look into this
            //IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserFactory.Driver;           
            //string title = (string)js.ExecuteScript("return document.title");

            //BrowserFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        public static void SelectByText(this IWebElement element, string text, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text);
            Console.WriteLine(text + " text selected on " + elementName);
        }

        public static void SelectByIndex(this IWebElement element, int index, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByIndex(index);
            Console.WriteLine(index + " index selected on " + elementName);
        }

        public static void SelectByValue(this IWebElement element, string text, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByValue(text);
            Console.WriteLine(text + " value selected on " + elementName);
        }



        public static void BrowserNavigate(string nav)
        {
            switch (nav)
            {
                case ("Forward"):
                    WebdriverInit.GetDriver.Navigate().Forward();

                    break;
                case ("Back"):
                    WebdriverInit.GetDriver.Navigate().Back();
                    break;
                case ("Refresh"):
                    WebdriverInit.GetDriver.Navigate().Refresh();
                    break;
            }
            Console.WriteLine("Browser Navigated " + nav);
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }
}
