using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÀirportTest.Utilities
{
    public interface ISetUp
    {
        void Navigate(string url);
    }
    public class SetUp : ISetUp
    {
        protected static IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly IObjectContainer _objectContainer;

        public SetUp(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _objectContainer.RegisterInstanceAs(_driver);
            _objectContainer.RegisterInstanceAs(_wait);
        }

        public void Navigate(string url)
        {
            _driver.Url = url;
        }
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
