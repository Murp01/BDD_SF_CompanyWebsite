using CompanyWebsitePageFactory.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebsitePageFactory.PageObjects
{
    class HomePage
    {
        //private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='slide slick-slide slick-current slick-active']//span[@class='icon-link-arrow-left']")]
        [CacheLookup]
        private IWebElement Btn_CarouselNavLeft { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='slide slick-slide slick-current slick-active']//span[@class='icon-link-arrow-right']")]
        [CacheLookup]
        private IWebElement Btn_CarouselNavRight { get; set; }

        [FindsBy(How = How.ClassName, Using = "icon-search")]
        [CacheLookup]
        public IWebElement Btn_SiteSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header__navDesktop']//a[contains(text(),'Insights')]")]
        [CacheLookup]
        private IWebElement PNav_Insights { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#slide-3cd12c03-b989-49a1-994a-39244c7aa792")]
        [CacheLookup]
        private IWebElement Slide_Index01 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#slide-7caba8a6-9070-400f-b587-e810aeb49a15")]
        [CacheLookup]
        private IWebElement Slide_Index02 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#slide-b98b1d54-2569-43ee-b8b1-d3b9fe44b8ce")]
        [CacheLookup]
        private IWebElement Slide_Index03 { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Forward Thinking')]")]
        [CacheLookup]
        private IWebElement Tab_Carousel01 { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Global Issues')]")]
        [CacheLookup]
        private IWebElement Tab_Carousel02 { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ground-breaking Deals')]")]
        [CacheLookup]
        private IWebElement Tab_Carousel03 { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Responsible Business')]")]
        [CacheLookup]
        private IWebElement Tab_Carousel04 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='slide slick-slide slick-current slick-active']//li[1]")]
        [CacheLookup]
        private IWebElement Slide_tab01Slide01 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='slide slick-slide slick-current slick-active']//li[2]")]
        [CacheLookup]
        private IWebElement Slide_tab01Slide02 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='slide slick-slide slick-current slick-active']//li[3]")]
        [CacheLookup]
        private IWebElement Slide_tab01Slide03 { get; set; }

        //[FindsBy(How = How.XPath, Using = "//div[@id='slide-1f50fe22-8ba1-401d-ae6d-f7e2b60f3853']")]
        [FindsBy(How = How.XPath, Using = "//div[@class='slide slick-slide slick-current slick-active']//div[@aria-hidden='false']")]
        [CacheLookup]
        private IWebElement Slide_CurrentSlide { get; set; }


        public void ClickOnNavInsights()
        {
            PNav_Insights.ClickOnIt("PNav_Insights");          
        }

        //WIP
        public void AssertSlideHasChanged(string BorderArrow)
        {
            if (BorderArrow == "Right")
            {

                string CurrentSlideIdPre = Slide_CurrentSlide.GetAttribute("id");
                string CurrentSlideHiddenPre = Slide_CurrentSlide.GetAttribute("aria-hidden");
                Console.WriteLine("ID is " + CurrentSlideIdPre);
                Console.WriteLine("Slide is " + CurrentSlideHiddenPre);
                Btn_CarouselNavRight.ClickOnIt("Clicked on right carousel");
                //slide has changed

                //slide_CurrentSlide is still highlighting the same slide.Why ?
                string CurrentSlideIdPost = Slide_CurrentSlide.GetAttribute("id");
                string CurrentSlideHiddenPost = Slide_CurrentSlide.GetAttribute("aria-hidden");
                Console.WriteLine("ID is " + CurrentSlideIdPost);
                Console.WriteLine("Slide is " + CurrentSlideHiddenPost);
                Assert.That(CurrentSlideIdPre != CurrentSlideIdPost);

                //Assert.That(Slide_CurrentSlide.GetAttribute("aria-hidden")== "false");
                //Btn_CarouselNavRight.ClickOnIt("Clicked on right carousel");
                //Assert.That(Slide_CurrentSlide.GetAttribute("aria-hidden") == "true");
            }
            else
            {
                //I think I will need to get slide id first and ensure it changes
                Assert.That(Slide_CurrentSlide.GetAttribute("aria-hidden") == "false");
                Btn_CarouselNavLeft.ClickOnIt("Clicked on right carousel");
                Assert.That(Slide_CurrentSlide.GetAttribute("aria-hidden") == "true");
            }

        }

        public void selectCarouselTab(string Category)
        {

            switch (Category)
            {

                case "Category01":

                    Tab_Carousel01.ClickOnIt("Clicked on " + Tab_Carousel01);

                    break;

                case "Category02":

                    Tab_Carousel02.ClickOnIt("Clicked on " + Tab_Carousel02);

                    break;

                case "Category03":

                    Tab_Carousel03.ClickOnIt("Clicked on " + Tab_Carousel03);

                    break;

                case "Category04":

                    Tab_Carousel04.ClickOnIt("Clicked on " + Tab_Carousel04);

                    break;

            }

        }


        public void selectSlideFromCarouselTab(string Slide)
        {
            switch (Slide)
            {
                case "Slide01":
                    Slide_tab01Slide01.ClickOnIt("Clicked on " + Slide_tab01Slide01);
                    break;
                case "Slide02":
                    Slide_tab01Slide02.ClickOnIt("Clicked on " + Slide_tab01Slide02);
                    break;
                case "Slide03":
                    Slide_tab01Slide03.ClickOnIt("Clicked on " + Slide_tab01Slide03);
                    break;
            }
        }

    }
}
