using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomation.Framework;
using SeleniumAutomation.PageObject;
using System.IO;
using TechTalk.SpecFlow;


namespace SeleniumAutomation.StepDefinition
{
    [Binding]
    public class SampleTestsSteps
    {
        public IWebDriver driver;
        CoreFunctions _coreFunctions;
        NewCollegePageObject _newCollegePageObject;
        
        public SampleTestsSteps()
        {
            _coreFunctions = new CoreFunctions();
            driver = _coreFunctions.LaunchBrowser();
            _newCollegePageObject = new NewCollegePageObject(driver);
        }

        [Given(@"I am a New College customer")]
        public void GivenIAmANewCollegeCustomer()
        {
            //No step defintion
        }

        [When(@"I navigate to Pre Uni website")]
        public void WhenINavigateToPreUniWebsite()
        {
            _coreFunctions.LaunchWebsite("https://nsw.newcollege.com.au/");            
        }

        [Then(@"I verify Pre Uni Home page is displayed")]
        public void ThenIVerifyPreUniHomePageIsDisplayed()
        {           
            Assert.IsTrue(_newCollegePageObject.TabEnrolmentDisplayed());
        }

        [When(@"I click Enrolment tab")]
        public void WhenIClickEnrolmentTab()
        {
            _newCollegePageObject.ClickEnrolmentTab();
        }

        [Then(@"I verify Enrolment page is displayed")]
        public void ThenIVerifyEnrolmentPageIsDisplayed()
        {            
            Assert.IsTrue(_newCollegePageObject.ButtonEnrolmentDisplayed());
        }

        [When(@"I click Enrolment button")]
        public void WhenIClickEnrolmentButton()
        {
            _newCollegePageObject.ClickEnrolmentButton();
        }

        [Then(@"I verify Email Verifcation page is displayed with appropriate message")]
        public void ThenIVerifyEmailVerifcationPageIsDisplayedWithAppropriateMessage()
        {
            Assert.IsTrue(_newCollegePageObject.EmailVerifcationDisplayed("* The email verification step is essential for confirming your booking."));
        }

        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            _newCollegePageObject.EnterEmailAddress("xyz@gmail.com");
        }

        [Then(@"I am able to click Continue button")]
        public void ThenIAmAbleToClickContinueButton()
        {
            _newCollegePageObject.ClickContinueButton();
        }

        ~SampleTestsSteps()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}
