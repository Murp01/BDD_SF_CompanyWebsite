using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyWebsitePageFactory.Extensions;
using CompanyWebsitePageFactory.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using CompanyWebsitePageFactory.BrowserWrapper;
using System.Configuration;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace CompanyWebsitePageFactory.PageObjects
{
    class LogInPage
    {

        [FindsBy(How = How.XPath, Using = "//input[@id='user']")]
        [CacheLookup]
        public IWebElement InputEmailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        [CacheLookup]
        public IWebElement InputPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='login']")]
        [CacheLookup]
        public IWebElement ButtonLogIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='error-message']")]
        [CacheLookup]
        public IWebElement PromptErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='login-submit']//span[@class='css-t5emrf']")]
        [CacheLookup]
        public IWebElement ButtonAtlassionLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        [CacheLookup]
        public IWebElement InputAtlassionPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='login-submit']//span[@class='css-t5emrf']")]
        [CacheLookup]
        public IWebElement ButtonAtlassianContinue { get; set; }

        [FindsBy(How = How.Id, Using = "login-submit")]
        [CacheLookup]
        public IWebElement IDButtonAtlassianContinue { get; set; }







        public void AssertAccountErrorPrompt(string ErrorPrompt)
        {
            //Add wait
            System.Threading.Thread.Sleep(3000);
            Assert.That(PromptErrorMessage.Text.Contains(ErrorPrompt));               
        }

        public void ClickOnLogInButton()
        {
            System.Threading.Thread.Sleep(3000);
            ButtonLogIn.Click();
        }

        public void ClickOnAtlassionaContButton()
        {
            ButtonAtlassianContinue.Click();
        }

        public void InputRegisteredEmailAddressPassword()
        {
            InputEmailAddress.SendKeys(ConfigurationManager.AppSettings["ValidLogInUser"]);
            InputPassword.SendKeys(ConfigurationManager.AppSettings["ValidLogInPass"]);
            System.Threading.Thread.Sleep(3000);
            ButtonLogIn.Click();    //Trello Log in
            System.Threading.Thread.Sleep(3000);
            ButtonAtlassionLogin.Click();   //email automatically entered
            System.Threading.Thread.Sleep(3000);
            InputAtlassionPassword.SendKeys(ConfigurationManager.AppSettings["ValidLogInPass"]);
            System.Threading.Thread.Sleep(3000);
            ButtonAtlassionLogin.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void LogIntoValidTrelloAccount()
        {
            
            //BrowserFactory.GoToURL(ConfigurationManager.AppSettings["LoginPageURL"]);
            //InputEmailAddress.SendKeys(ConfigurationManager.AppSettings["ValidLogInUser"]);
            //InputPassword.SendKeys(ConfigurationManager.AppSettings["ValidLogInPass"]);
            //ButtonLogIn.Click();    //Trello Log in
            //System.Threading.Thread.Sleep(3000);    //replace this with wait for element
            //ButtonAtlassionLogin.Click();   //email automatically entered
            //System.Threading.Thread.Sleep(3000);
            //InputAtlassionPassword.SendKeys(ConfigurationManager.AppSettings["ValidLogInPass"]);
            //ButtonAtlassionLogin.Click();
            //System.Threading.Thread.Sleep(3000);

            BrowserFactory.GoToURL(ConfigurationManager.AppSettings["LoginPageURL"]);
            InputEmailAddress.SendKeys(ConfigurationManager.AppSettings["ValidLogInUser"]);
            InputPassword.SendKeys(ConfigurationManager.AppSettings["ValidLogInPass"]);
            ButtonLogIn.Click();    //Trello Log in
            //Extensions.Element_Extensions.WaitUntilElementDisplayClick(driver, IDButtonAtlassianContinue);
              
            //ButtonAtlassionLogin.Click();   //replace this with wait for element
            System.Threading.Thread.Sleep(3000);
            InputAtlassionPassword.SendKeys(ConfigurationManager.AppSettings["ValidLogInPass"]);
            ButtonAtlassionLogin.Click();
            System.Threading.Thread.Sleep(3000);
        }


        public void InputUnregisteredEmailAddress()
        {
            InputEmailAddress.SendKeys("PabsCurfew@jimbaloo.com");
        }

        public void InputUnregisteredPassword()
        {
            InputPassword.SendKeys("pabbsywrongPassword");
        }


        public void AttemptToLoginWrongCredentials()
        {
            InputEmailAddress.SendKeys("PabsCurfew@jimbaloo.com");
            InputPassword.SendKeys("pabbsywrongPassword");
            ButtonLogIn.Click();
            System.Threading.Thread.Sleep(9000);
        }

    }
}
