using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    internal class SeleniumFirstTest
    {
        //Make this global to access in any classes
        IWebDriver driver; 

        [SetUp] 
        public void SetUp() 
        {

            //Methods -geturl, click
            //chromedriver.exe on chrome browser
            //edgedriver.exe
            //geckodriver
            //99 exe. (99)
            //WebDriverManager-(

            //Setup WebDriverManager

            //CHROME
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //FIREFOX
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //driver = new FirefoxDriver();

            //EDGE
            //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //driver = new EdgeDriver();

            //TO MAXIMIZE THE BROWSER
            //driver.Manage().Window.Maximize();
        
        }



        [Test] 
        public void Test() 
        {

            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            TestContext.WriteLine("-----------------------------------------");

            TestContext.WriteLine(driver.Title);
            TestContext.WriteLine(driver.Url);
            //TestContext.WriteLine(driver.PageSource);
            //TestContext.WriteLine(driver.WindowHandles);
            
            
            TestContext.WriteLine("-----------------------------------------");
            Thread.Sleep(3000);
            driver.Close();
            //driver.Quit();

        }



    }
}
