using CompanyWebsitePageFactory.BrowserWrapper;
using CompanyWebsitePageFactory.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class FindPeople
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Business Team Directory')]")]
        [CacheLookup]
        public IWebElement Selector_BusinessTeamDirectory { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Lawyer Directory')]")]
        [CacheLookup]
        public IWebElement Selector_LawyerDirectory { get; set; }

        public void ClickOnDirectorySelector(string Selector)
        {
            switch(Selector)
            {
                case "LawyerDirectory":
                    if (!Selector_LawyerDirectory.Selected)
                    {
                        Selector_LawyerDirectory.ClickOnIt("Lawyer Directory was not selected.  Clicked on it");
                    }
                    break;
                case "BusinessTeamDirectory":
                    if (!Selector_BusinessTeamDirectory.Selected)
                    {
                        Selector_BusinessTeamDirectory.ClickOnIt("Business Team Directory was not selected.  Clicked on it");
                    }
                    break;
            }
        }
    }
}
