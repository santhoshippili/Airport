using ÀirportTest.Pages;
using ÀirportTest.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace ÀirportTest.Definition
{
    [Binding]
    public class BookACarParkDefn
    {
        private readonly SetUp _setUp;
        private readonly AucklandAirportHomePage _homePage;
        private readonly BookACarParkPage _bookingPage;
        private readonly PersonalDetails _personalDetails;
        private readonly PaymentConfirmationPage _paymentPage;
        private readonly ConfirmationPage _confirmationPage;
        string SelfUrl = ConfigurationManager.AppSettings["SelfUrl"];
        //private readonly IWebDriver _driver;
        public BookACarParkDefn(SetUp setUp, AucklandAirportHomePage homePage, BookACarParkPage bookingPage, PersonalDetails personalDetails, PaymentConfirmationPage paymentPage, ConfirmationPage confirmationPage)
        {
            _setUp = setUp;
            _homePage = homePage;
            _bookingPage = bookingPage;
            _personalDetails = personalDetails;
            _paymentPage = paymentPage;
            _confirmationPage = confirmationPage;
        }
        [Given(@"I navigate to the Auckland Airport URL '(.*)'")]
        public void GivenINavigateToTheAucklandAirportURL(string url)
        {
            if (url == "SelfUrl")
            {
                _setUp.Navigate(SelfUrl);
            }
            else { _setUp.Navigate(url); }

        }

        [Given(@"I navigate to the Car Park Managment")]
        public void GivenINavigateToTheCarParkManagment()
        {
            _homePage.HoverToParkingHeader();
            _homePage.BookACarParkClick();
        }

        [Given(@"I select CarPark, Terminal, Date, Time and Valet Services")]
        public void GivenISelectCarParkTerminalDateTimeAndValetServices()
        {
            _bookingPage.ChooseInternationalTerminalClick();
            _bookingPage.StartDateTimePickerClick();
            _bookingPage.SelectMonthClick();
            _bookingPage.SelectHourClick();
            _bookingPage.SelectMinuteClick();

            _bookingPage.DateTimePickerClick();
            _bookingPage.EndSelectMonthClick();
            _bookingPage.EndSelectHourClick();
            _bookingPage.EndSelectMinuteClick();
            _bookingPage.FindACarParkBtnByClassClick();
            _bookingPage.ValetServiceSelectByIdClick();
            Thread.Sleep(20000);
            
        }

        [Given(@"I select AddOns Strata Lounge for One Adult")]
        public void GivenISelectAddOnsStrataLoungeForOneAdult()
        {
            _bookingPage.LoungeArrivalTimeSelect();
            _bookingPage.AddStrataLongueClick();
            _bookingPage.ContinueButtonClick();

        }

        [When(@"I enter my personal details for New Users")]
        public void WhenIEnterMyPersonalDetailsForNewUsers(Table _table)
        {
            var personalDetails = _table.CreateInstance<PersonalDetail>();
            _personalDetails.PersonTitleSelect(personalDetails.title);
            _personalDetails.FirstNameEnter(personalDetails.FirstName);
            _personalDetails.LastNameEnter(personalDetails.LastName);
            _personalDetails.AddressEnter(personalDetails.Address);
            _personalDetails.PhoneNumberEnter(personalDetails.Phone);
            _personalDetails.EmailAddressByIdEnter(personalDetails.Email);
            _personalDetails.ExistingEmailAddressByIdEnter(personalDetails.Email);
            _personalDetails.TncCheck();
            _personalDetails.ContinueButtonClick();
        }
        public class PersonalDetail
        {
            public string title { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

        }
        
        [When(@"I enter the payment\tdetails")]
        public void WhenIEnterThePaymentDetails(Table _table)
        {
            _paymentPage.MakePaymentButtonClick();
            var paymentDetails = _table.CreateInstance<PaymentDetails>();
            _paymentPage.CardNumberEnter(paymentDetails.CardNumber);
            _paymentPage.NameOnCardEnter(paymentDetails.Name);
            _paymentPage.SecurityCodeEnter(paymentDetails.SecurityCode);
            _paymentPage.CCDExpiryMonthSelect(paymentDetails.ExpiryMonth);
            _paymentPage.CCDExpiryYearSelect(paymentDetails.ExpiryYear);
            _paymentPage.LicenceplateEnter(paymentDetails.LicensePlateNo);
            _paymentPage.CarMakeEnter(paymentDetails.CarMAke);
            _paymentPage.VehiclecolourEnter(paymentDetails.CarColor);
            _paymentPage.InboundflightEnter(paymentDetails.FlightNo);
            _paymentPage.TncCheck();
            _paymentPage.SumbitButtonClick();
        }

        public class PaymentDetails
        {
            public string CardNumber { get; set; }
            public string Name { get; set; }
            public string SecurityCode { get; set; }
            public string ExpiryMonth { get; set; }
            public string ExpiryYear { get; set; }
            public string LicensePlateNo { get; set; }
            public string CarMAke { get; set; }
            public string CarColor { get; set; }
            public string FlightNo { get; set; }            
        }

        [Then(@"the confirmation page appears")]
        public void ThenTheConfirmationPageAppears()
        {
            string text = _confirmationPage.ConfirmationText.Text;
            Assert.AreEqual("text123", text, "Text validated");
            _setUp.TearDown();

        }

    }
}
