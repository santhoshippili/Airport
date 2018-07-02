using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÀirportTest.Pages
{
    public class PersonalDetails
    {
        #region
        private By PersonTitleById = By.Id("Title");
        private By FirstNameById = By.Id("FirstName");
        private By LastNameById = By.Id("LastName");
        private By AddressById = By.Id("autocomplete");
        private By PhoneNumberById = By.Id("PhoneNumber");
        private By EmailAddressById = By.Id("ExisitingParkingUserEmail");
        private By ExisitingParkingUserEmailConfirmSignUpById = By.Id("ExisitingParkingUserEmailConfirmSignUp");
        private By TnCByXpath = By.XPath("/html/body/main/div/div[3]/div/div/div[5]/div/div/div[2]/div/div[3]/form/div[10]/label/i");
        private By ContinueButtonByXpath = By.XPath("(//*[@id='btnContinue'])[2]");
        #endregion


        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public PersonalDetails(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
        public IWebElement PersonTitle
        {
            get
            {
                return _wait.Until(d => d.FindElement(PersonTitleById));
            }
        }
        public void PersonTitleSelect(string title)
        {
            var personTitle = new SelectElement(PersonTitle);
            personTitle.SelectByValue(title);
        }
        public IWebElement FirstName
        {
            get
            {
                return _wait.Until(d => d.FindElement(FirstNameById));
            }
        }

        public void FirstNameEnter(string FName)
        {
            var firstName = FirstName;
            firstName.SendKeys(FName);
        }
        public IWebElement LastName
        {
            get
            {
                return _wait.Until(d => d.FindElement(LastNameById));
            }
        }

        public void LastNameEnter(string LName)
        {
            var lastName = LastName;
            lastName.SendKeys(LName);
        }
        public IWebElement Address
        {
            get
            {
                return _wait.Until(d => d.FindElement(AddressById));
            }
        }

        public void AddressEnter(string aDdress)
        {
            var address = Address;
            address.SendKeys(aDdress);
        }
        public IWebElement PhoneNumber
        {
            get
            {
                return _wait.Until(d => d.FindElement(PhoneNumberById));
            }
        }

        public void PhoneNumberEnter(string PhoneNo)
        {
            var phoneNumber = PhoneNumber;
            phoneNumber.SendKeys(PhoneNo);
        }

        public IWebElement EmailAddress
        {
            get
            {
                return _wait.Until(d => d.FindElement(EmailAddressById));
            }
        }

        public void EmailAddressByIdEnter(string Email)
        {
            var emailAddress = EmailAddress;
            emailAddress.SendKeys(Email);
        }
        public IWebElement ExistingEmailAddress
        {
            get
            {
                return _wait.Until(d => d.FindElement(ExisitingParkingUserEmailConfirmSignUpById));
            }
        }

        public void ExistingEmailAddressByIdEnter(string Email)
        {
            var existingEmailAddress = ExistingEmailAddress;
            existingEmailAddress.SendKeys(Email);
        }
        public IWebElement TnC
        {
            get
            {
                return _wait.Until(d => d.FindElement(TnCByXpath));
            }
        }

        public void TncCheck()
        {
            if(TnC.Selected != true)
            {
                TnC.Click();
            }
        }
        public void ContinueButtonJSClick()
        {
            IWebElement webelement = _driver.FindElement(By.XPath("//*[@id='btnContinue']"));
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("btnContinue")));
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", webelement);
        }
        public IWebElement ContinueButton
        {
            get
            {
                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("(//*[@id='btnContinue'])[2]")));
                return _wait.Until(d => d.FindElement(ContinueButtonByXpath));
            }
        }
        public void ContinueButtonClick()
        {
            var continueButton = ContinueButton;
            continueButton.Click();
        }
    }
}
