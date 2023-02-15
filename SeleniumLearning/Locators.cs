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
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V107.Input;

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

            //Implicit wait 5 sec can be declared globally
            // Better than Thread.Sleep(3000)
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

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
            //tagName[@attribute = 'value']
            driver.FindElement(By.CssSelector("input[value='admin']")).Click();
            driver.FindElement(By.CssSelector("option[value='teach']")).Click();

            //driver.FindElement(By.Id("terms")).Click();  //Scenerio 1  ID
            //driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click(); // Scenerio 2  Xpath
            //driver.FindElement(By.XPath("//label[@class='text-info']/span/input")).Click(); // Scenerio 3 Xpath
            driver.FindElement(By.CssSelector(".text-info span:nth-child(1) input")).Click(); // Scenerio 3  CssSelector

            //driver.FindElement(By.Id("signInBtn")).Click();
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();

            //DELAY: To allow the ALERT to pop-up but unecessary
            //Thread.Sleep(3000);


            //Explicit wait implementation for specific element to trigger
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .TextToBePresentInElement(driver.FindElement(By.Id("signInBtn")), "Sign In"));

            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
            //    .ElementIsVisible(By.CssSelector("input[id=signInBtn]")));



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

            //Assert.AreEqual(expectedUrl, hrefAttr);  //Scenerio 1
            //Assert.That(hrefAttr, Is.EqualTo(expectedUrl)); //Scenerio 2
            Assert.That(hrefAttr.Equals(expectedUrl)); //Scenerio 3


            //driver.Close();
            //driver.Quit();

        }
    }
}
