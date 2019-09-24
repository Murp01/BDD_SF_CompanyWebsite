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
    class AccountHome
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='board-tile mod-add']")]
        [CacheLookup]
        public IWebElement Btn_CreateBoard { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add board title']")]
        [CacheLookup]
        public IWebElement Field_BoardTemplateTitle { get; set; }
      
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Create Board')]")]
        [CacheLookup]
        public IWebElement Btn_CreateBoardTemplate { get; set; }




        public void ClickHSCreateNewBoardButton()
        {
            System.Threading.Thread.Sleep(4000);
            Btn_CreateBoard.Click();
            System.Threading.Thread.Sleep(4000);
        }


        public void InputNewBoardTitle()
        {
            Field_BoardTemplateTitle.SendKeys("New Board 2");
        }

        public void ClickCreateBoardFromTemplate()
        {
            Btn_CreateBoardTemplate.Click();
            System.Threading.Thread.Sleep(4000);
        }

        public void AccessPersonalBoard()
        {

        }

        public void ClosePersonnalBoard()
        {

        }

        public void DeletePersonalBoard()
        {
            //div[@class='board-tile-details-name']//div[contains(text(),'New Board 1')]
        }



        public void CreateANewBoardFromAccountHome()
        {
            ClickHSCreateNewBoardButton();
            InputNewBoardTitle();
            ClickCreateBoardFromTemplate();
        }
    }
}
