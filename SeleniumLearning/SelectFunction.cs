using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace SeleniumLearning
{
    internal class SelectFunction
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            

        }

        [Test]
        public void SelectDropDown() 
        {
            IWebElement selOpt = driver.FindElement(By.CssSelector("select.form-control"));

            //Selectement from Selenium Support UI
            SelectElement opt = new SelectElement(selOpt);

            opt.SelectByText("Consultant");
           
        }


    }
}
