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

        public void InputRegisteredEmailAddressPassword()
        {
            InputEmailAddress.SendKeys(ConfigurationManager.AppSettings["ValidLogInUser"]);
            InputPassword.SendKeys(ConfigurationManager.AppSettings["ValidLogInPass"]);
            System.Threading.Thread.Sleep(9000);
            ButtonLogIn.Click();
            System.Threading.Thread.Sleep(9000);
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
