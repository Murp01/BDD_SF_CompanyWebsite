using CompanyWebsitePageFactory.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CompanyWebsitePageFactory.TestDataAccess;


namespace CompanyWebsitePageFactory.PageObjects
{
    class FindPeople
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        [CacheLookup]
        public IWebElement Input_SearchPerson { get; set; }

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

        public void InputSearchPersonName(string PersonName)
        {
            //BrowserFactory.Driver.FindElement(By.XPath("//input[@placeholder='Name']")).SendKeys(PersonName);
            Input_SearchPerson.SendKeys(PersonName);
        }

        public void InputLawyerNameSearch(string nameSearch)
        {
            var userData = ExcelDataAccess.GetTestData(nameSearch); //variable string goes to ExcelDBAccess class and uses method to search for argument (nameSearch will be test case (1st cell))
            Input_SearchPerson.SendKeys(userData.SearchTerm);   //References userData to select the key, and then looks in the SearchTerm column for value
        }
    }
}
