using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÀirportTest.Pages
{
    public class AucklandAirportHomePage
    {
        #region
        private By ParkingHeaderByID = By.XPath("//*[@id='main-nav']/ul[1]/li[2]/a");
        private By BookACarParkByXPath = By.XPath("//*[contains( text(), 'Book a car park')]");
        #endregion

        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public AucklandAirportHomePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public IWebElement ParkingHeader
        {
            get
            {
                return _wait.Until(d => d.FindElement(ParkingHeaderByID));
            }
        }
        public IWebElement BookACarPark
        {
            get
            {
                return _wait.Until(d => d.FindElement(BookACarParkByXPath));
            }
        }
        public void HoverToParkingHeader()
        {
            //var element = ParkingHeader ;
            Actions builder = new Actions(_driver);
            builder.MoveToElement(_driver.FindElement(By.XPath("//*[@id='main-nav']/ul[1]/li[2]/a"))).Perform();
        }
        public void BookACarParkClick()
        {
            var bookACarPark = BookACarPark;
            bookACarPark.Click();
        }
    }
}
