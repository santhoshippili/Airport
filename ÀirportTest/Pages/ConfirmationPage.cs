using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÀirportTest.Pages
{
    public class ConfirmationPage
    {
        private By ConfirmationTextByXPath = By.XPath("/html/body/main/div/div[2]/div/div/div[1]/div/div/article");
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public ConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
        public IWebElement ConfirmationText
        {
            get
            {
                return _wait.Until(d => d.FindElement(ConfirmationTextByXPath));
            }
        }
        public string ConfirmationTextValidation()
        {
            var confirmationText = ConfirmationText;
            return confirmationText.Text;
        }
    }
}
