using CompanyWebsitePageFactory.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class AboutUs
    {
        [FindsBy(How = How.CssSelector, Using = "#container-special-offers")]
        [CacheLookup]
        public IWebElement button_SpecialOffers { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ui-id-2']")]
        [CacheLookup]
        public IWebElement Container_Accordion01 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ui-id-4']")]
        [CacheLookup]
        public IWebElement Container_Accordion02 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ui-id-6']")]
        [CacheLookup]
        public IWebElement Container_Accordion03 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'responsible business section')]")]
        [CacheLookup]
        public IWebElement href_ResponsibleBusinessSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@id='ui-id-1']")]
        [CacheLookup]
        public IWebElement tab_Accordion01 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@id='ui-id-3']")]
        [CacheLookup]
        public IWebElement tab_Accordion02 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@id='ui-id-5']")]
        [CacheLookup]
        public IWebElement tab_Accordion03 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-accordion ui-widget ui-helper-reset')]")]
        [CacheLookup]
        public IWebElement Widget_Accordion { get; set; }


        public void AccordionCheckOpenCloseThenClick(string TabState)
        {
            switch (TabState)
            {
                case "Closed":
                    if (Container_Accordion01.GetAttribute("style").Contains("none"))
                    {
                        tab_Accordion01.ClickOnIt("Accordion01");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }

                    if (Container_Accordion02.GetAttribute("style").Contains("none"))
                    {
                        tab_Accordion01.ClickOnIt("Accordion01");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }

                    if (Container_Accordion01.GetAttribute("style").Contains("none"))
                    {
                        tab_Accordion01.ClickOnIt("Accordion01");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }
                    break;

            }


        }
    }
}
