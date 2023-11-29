using OpenQA.Selenium;
using SeleniumAutomation.StepDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.PageObject
{
    public class NewCollegePageObject
    {
        
        public IWebDriver _driver;

        public NewCollegePageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool TabEnrolmentDisplayed()
        {
            IWebElement tabEnrollment = _driver.FindElement(By.Id("menu-item-2876"));
            if (tabEnrollment.Displayed)
                return true;
            else
                return false;
        }

        public void ClickEnrolmentTab()
        {
            IWebElement tabEnrollment = _driver.FindElement(By.Id("menu-item-2876"));
            tabEnrollment.Click();
        }

        public bool ButtonEnrolmentDisplayed()
        {
            IWebElement btnEnrollment = _driver.FindElement(By.XPath("//button[contains(text(), 'Apply for Enrolment')]"));
            if (btnEnrollment.Displayed)
                return true;
            else
                return false;
        }

        public void ClickEnrolmentButton()
        {
            IWebElement btnEnrollment = _driver.FindElement(By.XPath("//button[contains(text(), 'Apply for Enrolment')]"));
            btnEnrollment.Click();
        }

        public bool EmailVerifcationDisplayed(string message)
        {
            IWebElement lblEmailError = _driver.FindElement(By.XPath("//div[@class='mb-5 text-danger']"));
            if (lblEmailError.Text.Contains(message))
                return true;
            else
                return false;
        }

        public void EnterEmailAddress(string email)
        {
            IWebElement txtEmail = _driver.FindElement(By.Name("email"));
            txtEmail.SendKeys(email);
        }

        public void ClickContinueButton()
        {
            IWebElement btnContinue = _driver.FindElement(By.XPath("//button[contains(text(), 'Continue')]"));
            btnContinue.Click();
        }
    }
}
