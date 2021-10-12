﻿using IC_API_Testing.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace IC_API_Testing.Utilities
{
    public class CommonDriver
    {
        public IWebDriver testDriver;

        [OneTimeSetUp]
        public void GoToLoginPage()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
   
            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.GoToLoginPage(testDriver);
        }
   
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            testDriver.Quit();
        }
    }
}
