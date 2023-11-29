using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Framework
{
    public class CoreFunctions
    {
        public IWebDriver driver;
        public IWebDriver LaunchBrowser()
        {            
            string driverPath = Path.Combine(Directory.GetCurrentDirectory(), "Drivers");
            driver = new ChromeDriver(driverPath);            
            return driver;
        }
        public void LaunchWebsite(string url)
        {            
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();           
        }
    }
}
