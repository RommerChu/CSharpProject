using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium.DevTools.V107.SystemInfo;

namespace SeleniumLearning
{
    internal class Locators
    {

        IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            //CHROME
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //Point to the webform
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

            //Set desired window size
            System.Drawing.Size windowSize = new System.Drawing.Size(1184, 1240);

            driver.Manage().Window.Size = windowSize;




        }



        [Test]
        public void LocatorIdentification()
        {

            //TestContext.WriteLine("-----------------------------------------");

            driver.FindElement(By.Id("username")).SendKeys("rommer");
            driver.FindElement(By.Id("password")).SendKeys("test123");
            driver.FindElement(By.CssSelector("input[value='admin']")).Click();
            driver.FindElement(By.CssSelector("option[value='teach']")).Click();
            driver.FindElement(By.Id("terms")).Click();

            //tagName[@attribute = 'value']

            //driver.FindElement(By.Id("signInBtn")).Click();
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();

            //DELAY: To allow the ALERT to pop-up
            Thread.Sleep(3000);

            //Capture the ALERT MESSAGE after clicking Sign In button
            String errorMessage = driver.FindElement(By.ClassName("alert-danger")).Text;

            //Get the CLASS of the alert
            TestContext.Progress.WriteLine("------------" + errorMessage);

            //Verify the link text in <a>
            IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));

            String hrefAttr = link.GetAttribute("href");
            String expectedUrl = "https://rahulshettyacademy.com/documents-request";

            //Click on the link
            link.Click();

            //To match the URL and the href value
            Assert.AreEqual(expectedUrl, hrefAttr);

            
            
            //TestContext.Progress.WriteLine(hrefAttribute);

            //driver.Close();
            //driver.Quit();

        }
    }
}
