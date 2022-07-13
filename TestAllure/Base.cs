using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestAllure
{
    public class Base
    {
        private ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

      
        protected IWebDriver Driver => driver.Value;



        [SetUp]
        public void SetUp()
        {
           

            new DriverManager().SetUpDriver(new ChromeConfig());
            driver.Value = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
 

            Driver.Quit();
           
        }

    }
}
