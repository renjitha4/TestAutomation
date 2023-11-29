using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace SeleniumAutomation
{
    public class Tests
    {
        public IWebDriver? driver = null;

        [SetUp]
        public void Setup()
        {
            string driverPath = Path.Combine(Directory.GetCurrentDirectory(), "Drivers");
            driver = new ChromeDriver(driverPath);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void NewCollegeEnrollment()
        {
            driver.Navigate().GoToUrl("https://nsw.newcollege.com.au/");
            
            IWebElement tabEnrollment = driver.FindElement(By.Id("menu-item-2876"));
            Assert.IsTrue(tabEnrollment.Displayed);

            tabEnrollment.Click();
            IWebElement btnEnrollment = driver.FindElement(By.XPath("//button[contains(text(), 'Apply for Enrolment')]"));
            Assert.IsTrue(btnEnrollment.Displayed);

            btnEnrollment.Click();

            IWebElement lblEmailError = driver.FindElement(By.XPath("//div[@class='mb-5 text-danger']"));
            Assert.IsTrue(lblEmailError.Text.Contains("* The email verification step is essential for confirming your booking."));

            IWebElement txtEmail = driver.FindElement(By.Name("email"));
            txtEmail.SendKeys("xyz@gmail.com");

            IWebElement btnContinue = driver.FindElement(By.XPath("//button[contains(text(), 'Continue')]"));
            btnContinue.Click();
        }
        [Test]
        public void SwagLabLogin()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            IWebElement txtUsername = driver.FindElement(By.Id("user-name"));
            txtUsername.SendKeys("standard_user");

            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("secret_sauce");

            IWebElement btnLogin = driver.FindElement(By.Id("login-button"));
            btnLogin.Click();

            IWebElement productLink = driver.FindElement(By.CssSelector("#item_4_title_link > div"));
            productLink.Click();

            IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addToCartButton.Click();

        }



        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Close();
        //    driver.Quit();
        //    driver.Dispose();
        //}
    }
}