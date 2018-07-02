using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace ÀirportTest.Pages
{
   public class PaymentConfirmationPage
    {
        #region
        private By MakePaymentButtonByID = By.Id("btnmakePayment");
        private By CardNumberByID = By.Id("cardNumber1");
        private By NameOnCardByID = By.Id("txt_NameOnCard");
        private By SecurityCodeByID = By.Id("txt_SecurityCode");
        private By CCDExpiryMonthByID = By.Id("ddl_CCDExpiryMonth");
        private By CCDExpiryYearByID = By.Id("ddl_CCDExpiryYear");
        private By LicenceplateByID = By.Id("txt_licenceplate");
        private By CarMakeByID = By.Id("txt_vehiclemake");
        private By VehiclecolourByID = By.Id("txt_vehiclecolour");
        private By InboundflightByID = By.Id("txt_inboundflight");
        private By TnCByXpath = By.XPath("//*[@id='form_payment']/div[8]/label/i");
        private By SumbitByID = By.Id("btn_Submit");        

        #endregion
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public PaymentConfirmationPage( IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
        public IWebElement MakePaymentButton
        {
            get
            {
                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("btnmakePayment")));
                return _wait.Until(d => d.FindElement(MakePaymentButtonByID));
            }
        }
        public void MakePaymentButtonClick()
        {
            var makePaymentButton = MakePaymentButton;
            makePaymentButton.Click();
        }
        public IWebElement CardNumber
        {
            get
            {
                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("cardNumber1")));
                return _wait.Until(d => d.FindElement(CardNumberByID));
            }
        }

        public void CardNumberEnter(string CardNo)
        {
            var cardNumber = CardNumber;
            cardNumber.SendKeys(CardNo);
        }
        public IWebElement NameOnCard
        {
            get
            {
                return _wait.Until(d => d.FindElement(NameOnCardByID));
            }
        }

        public void NameOnCardEnter(string CardName)
        {
            var nameOnCard = NameOnCard;
            nameOnCard.SendKeys(CardName);
        }
        public IWebElement SecurityCode
        {
            get
            {
                return _wait.Until(d => d.FindElement(SecurityCodeByID));
            }
        }

        public void SecurityCodeEnter(string Security)
        {
            var securityCode = SecurityCode;
            securityCode.SendKeys(Security);
        }
        public IWebElement CCDExpiryMonth
        {
            get
            {
                return _wait.Until(d => d.FindElement(CCDExpiryMonthByID));
            }
        }

        public void CCDExpiryMonthSelect(string CcdMonth)
        {
            var cCDExpiryMonth = new SelectElement(CCDExpiryMonth);
            cCDExpiryMonth.SelectByValue(CcdMonth);
        }
        public IWebElement CCDExpiryYear
        {
            get
            {
                return _wait.Until(d => d.FindElement(CCDExpiryYearByID));
            }
        }

        public void CCDExpiryYearSelect(string CcdYear)
        {
            var cCDExpiryYear = new SelectElement(CCDExpiryYear);
            cCDExpiryYear.SelectByValue(CcdYear);
        }
        public IWebElement Licenceplate
        {
            get
            {
                return _wait.Until(d => d.FindElement(LicenceplateByID));
            }
        }

        public void LicenceplateEnter(string LPNo)
        {
            var licenceplate = Licenceplate;
            licenceplate.SendKeys(LPNo);
        }
        public IWebElement CarMake
        {
            get
            {
                return _wait.Until(d => d.FindElement(CarMakeByID));
            }
        }

        public void CarMakeEnter(string Car)
        {
            var carMake= CarMake;
            carMake.SendKeys(Car);
        }
        public IWebElement Vehiclecolour
        {
            get
            {
                return _wait.Until(d => d.FindElement(VehiclecolourByID));
            }
        }

        public void VehiclecolourEnter(string Color)
        {
            var vehiclecolour = Vehiclecolour;
            vehiclecolour.SendKeys(Color);
        }
        public IWebElement Inboundflight
        {
            get
            {
                return _wait.Until(d => d.FindElement(InboundflightByID));
            }
        }

        public void InboundflightEnter(string FlightNo)
        {
            var ìnboundflight = Inboundflight;
            ìnboundflight.SendKeys(FlightNo);
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
            var tNC = TnC;
            if(tNC.Selected !=true)
            { tNC.Click(); }

        }
        public IWebElement SumbitButton
        {
            get
            {
                return _wait.Until(d => d.FindElement(SumbitByID));
            }
        }
        public void SumbitButtonClick()
        {
            var sumbitButton = SumbitButton;
            sumbitButton.Click();
        }
    }
}
