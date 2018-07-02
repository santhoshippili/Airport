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
    public class BookACarParkPage
    {
        #region
        private By ChooseInternationalTerminalByXpath = By.XPath("//*[@id='booking-details']/div/div/div[1]/section/form/div[1]/div/div/div/button[1]");
        private By StartDateTimePickerByXPath = By.XPath("//*[@id='booking-details']/div/div/div[1]/section/form/div[2]/div/div/div/span/i");        
        private By DateTimePickerByXpath = By.XPath("//*[@id='booking-details']/div/div/div[1]/section/form/div[3]/div[1]/div/div/span/i");
        private By SelectMonthByXPath = By.XPath("/html/body/div[3]/div[3]/table/tbody/tr[5]/td[4]");
        private By SelectHourByXpath = By.XPath("/html/body/div[3]/div[2]/table/tbody/tr/td/fieldset[2]/span[9]");
        private By SelectMinuteByXpath = By.XPath("/html/body/div[3]/div[1]/table/tbody/tr/td/fieldset/span[1]");

        private By EndSelectDateByXPath = By.XPath("/html/body/div[7]/div[3]/table/tbody/tr[5]/td[6]");
        private By EndSelectHourByXpath = By.XPath("/html/body/div[7]/div[2]/table/tbody/tr/td/fieldset[2]/span[9]");
        private By EndSelectMinuteByXpath = By.XPath("/html/body/div[7]/div[1]/table/tbody/tr/td/fieldset/span[1]");

        private By FindACarParkBtnByName = By.Name("btnContinue");
        private By ValetServiceSelectById = By.Id("selectCarPark_0");
        private By LoungeArrivalTimeById = By.Id("LoungeArrivaltime");
        private By AddStrataLongueByXpath = By.XPath("//*[@id='container-parking-addons']/div/div/div/div/div/div/div[2]/a[1]");
        private By ContinueButtonByName = By.Name("btnContinue");

        #endregion
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public BookACarParkPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public IWebElement ChooseInternationalTerminal
        {
            get
            {
                return _wait.Until(d => d.FindElement(ChooseInternationalTerminalByXpath));
            }
        }
        public void ChooseInternationalTerminalClick()
        {
            var chooseInternationalTerminal = ChooseInternationalTerminal;
            chooseInternationalTerminal.Click();
        }
        public IWebElement StartDateTimePicker
        {
            get
            {
                return _wait.Until(d => d.FindElement(StartDateTimePickerByXPath));
            }
        }
        public void StartDateTimePickerClick()
        {
            var startDateTimePicker = StartDateTimePicker;
            startDateTimePicker.Click();
        }
        public IWebElement DateTimePicker
        {
            get
            {
                return _wait.Until(d => d.FindElement(DateTimePickerByXpath));
            }
        }
        public void DateTimePickerClick()
        {
            var dateTimePicker = DateTimePicker;
            dateTimePicker.Click();
        }
        public IWebElement SelectMonth
        {
            get
            {
                return _wait.Until(d => d.FindElement(SelectMonthByXPath));
            }
        }
        public void SelectMonthClick()
        {
            var selectMonth = SelectMonth;
            selectMonth.Click();
        }
        public IWebElement SelectHour
        {
            get
            {
                return _wait.Until(d => d.FindElement(SelectHourByXpath));
            }
        }
        public void SelectHourClick()
        {
            var selectHour = SelectHour;
            selectHour.Click();
        }
        public IWebElement SelectMinute
        {
            get
            {
                return _wait.Until(d => d.FindElement(SelectMinuteByXpath));
            }
        }
        public void SelectMinuteClick()
        {
            var selectMinute = SelectMinute;
            selectMinute.Click();
        }



        public IWebElement EndSelectMonth
        {
            get
            {
                return _wait.Until(d => d.FindElement(EndSelectDateByXPath));
            }
        }
        public void EndSelectMonthClick()
        {
            var endSelectMonth = EndSelectMonth;
            endSelectMonth.Click();
        }
        public IWebElement EndSelectHour
        {
            get
            {
                return _wait.Until(d => d.FindElement(EndSelectHourByXpath));
            }
        }
        public void EndSelectHourClick()
        {
            var endSelectHour = EndSelectHour;
            endSelectHour.Click();
        }
        public IWebElement EndSelectMinute
        {
            get
            {
                return _wait.Until(d => d.FindElement(EndSelectMinuteByXpath));
            }
        }
        public void EndSelectMinuteClick()
        {
            var endSelectMinute = EndSelectMinute;
            endSelectMinute.Click();
        }

        public IWebElement FindACarParkBtn
        {
            get
            {
                return _wait.Until(d => d.FindElement(FindACarParkBtnByName));
            }
        }
        public void FindACarParkBtnByClassClick()
        {
            var findACarParkBtn = FindACarParkBtn;
            findACarParkBtn.Click();
        }
        public IWebElement ValetServiceSelect
        {
            get
            {
                return _wait.Until(d => d.FindElement(ValetServiceSelectById));
            }
        }
        public void ValetServiceSelectByIdClick()
        {
            var valetServiceSelect = ValetServiceSelect;
            valetServiceSelect.Click();
        }
        public IWebElement AddStrataLongue
        {
            get
            {
                return _wait.Until(d => d.FindElement(AddStrataLongueByXpath));
            }
        }
        public void AddStrataLongueClick()
        {
            IWebElement webelement = _driver.FindElement(By.XPath("//*[@id='container-parking-addons']/div/div/div/div/div/div/div[2]/a[1]"));
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id='container-parking-addons']/div/div/div/div/div/div/div[2]/a[1]")));
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", webelement);
        }
        public IWebElement LoungeArrivalTime
        {
            get
            {
                return _wait.Until(d => d.FindElement(LoungeArrivalTimeById));
            }
        }
        public void LoungeArrivalTimeSelect()
        {
            var loungeArrivalTime = new SelectElement(LoungeArrivalTime);
            loungeArrivalTime.SelectByValue("05:00");            
        }
        public IWebElement ContinueButton
        {
            get
            {
                return _wait.Until(d => d.FindElement(ContinueButtonByName));
            }
        }
        public void ContinueButtonClick()
        {
            IWebElement webelement = _driver.FindElement(By.XPath("//*[@id='btnContinue']"));
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id='btnContinue']")));
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", webelement);
        }
        public void HoverClick()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("#btnContinue")));
            Actions builder = new Actions(_driver);
            builder.MoveToElement(_driver.FindElement(By.CssSelector("#btnContinue"))).Click().Perform();
        }
        //public void SelectDate()
        //{
        //    IWebElement DateTimePicker = _driver.FindElement(By.XPath("//*[@id='booking-details']/div/div/div[1]/section/form/div[3]/div[1]/div/div/span/i"));
        //    List<IWebElement> columns = DateTimePicker.FindElements(By.TagName("td")).ToList();

        //}
    }
}
