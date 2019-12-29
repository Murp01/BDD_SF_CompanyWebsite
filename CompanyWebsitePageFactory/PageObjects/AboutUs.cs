using CompanyWebsitePageFactory.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace CompanyWebsitePageFactory.PageObjects
{
    class AboutUs
    {
        private IWebDriver chromeDriver;

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

        [FindsBy(How = How.CssSelector, Using = "#ui-id-1")]
        [CacheLookup]
        public IWebElement tab_Accordion01 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ui-id-3")]
        [CacheLookup]
        public IWebElement tab_Accordion02 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ui-id-5")]
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
                        TimeSpan ts = new TimeSpan(0, 0, 1);
                        Thread.Sleep(ts);
                        tab_Accordion02.ClickOnIt("Accordion02");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }

                    if (Container_Accordion03.GetAttribute("style").Contains("none"))
                    {
                        TimeSpan ts = new TimeSpan(0, 0, 1);
                        Thread.Sleep(ts);
                        tab_Accordion03.ClickOnIt("Accordion03");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }
                    break;

                case "Open":
                    if (Container_Accordion01.GetAttribute("style").Contains("block"))
                    {
                        TimeSpan ts = new TimeSpan(0, 0, 2);
                        Thread.Sleep(ts);
                        tab_Accordion01.ClickOnIt("Accordion01");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }

                    if (Container_Accordion02.GetAttribute("style").Contains("block"))
                    {
                        TimeSpan ts = new TimeSpan(0, 0, 2);
                        Thread.Sleep(ts);
                        tab_Accordion02.ClickOnIt("Accordion02");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }

                    if (Container_Accordion03.GetAttribute("style").Contains("block"))
                    {
                        TimeSpan ts = new TimeSpan(0, 0, 2);
                        Thread.Sleep(ts);
                        tab_Accordion03.ClickOnIt("Accordion03");
                    }
                    else
                    {
                        Console.WriteLine("Already Open");
                    }
                    break;
            }


        }

        public void assertAccordionTextField()
        {
            Assert.That(Container_Accordion01.GetAttribute("style").Contains("block"));
            Assert.That(Container_Accordion02.GetAttribute("style").Contains("block"));
            Assert.That(Container_Accordion03.GetAttribute("style").Contains("block"));
        }

        public void assertAccordionTabOpenElseClickToOpen(string OpenTab)
        {
            switch (OpenTab)
            {
                case "Segment01":
                    if (!Container_Accordion01.GetAttribute("style").Contains("block"))
                    {
                        tab_Accordion01.ClickOnIt("Accordion tab01 was closed.  Clicked to open");
                    }
                    break;
                case "Segment02":
                    if (!Container_Accordion02.GetAttribute("style").Contains("block"))
                    {
                        tab_Accordion02.ClickOnIt("Accordion tab02 was closed.  Clicked to open");
                    }
                    break;

                case "Segment03":
                    if (!Container_Accordion02.GetAttribute("style").Contains("block"))
                    {
                        tab_Accordion02.ClickOnIt("Accordion tab02 was closed.  Clicked to open");
                    }
                    break;
            }
        }

        public void assertAllAccordionTabsAreClosed()
        {
            Assert.That(Container_Accordion01.GetAttribute("style").Contains("none"));
            Assert.That(Container_Accordion02.GetAttribute("style").Contains("none"));
            Assert.That(Container_Accordion03.GetAttribute("style").Contains("none"));
        }

        public void clickOnLinkWithinAccordionTextbox(String link, String section) //throws InterruptedException
        {
            Console.WriteLine(section);
            Console.WriteLine(link);
		switch(section) {		
			case "Segment01":
                    switch (link)
                    {
                        case ("ResponsibleBusinessSection"):
                            System.Threading.Thread.Sleep(3000);
                            href_ResponsibleBusinessSection.ClickOnIt("Clicked on " + link + " from " + section + ".");
                            break;
                        case ("Add new"):
                            break;
                    }                                       
				break;
			case "Segment02":
                    //href_ResponsibleBusinessSection.ClickOnIt("Clicked on " + link + " from " + section + ".");
                break;

		}



}
    }
}
