﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTest.Pages
{
    internal class HomePage : DriverHelper
    {
        //ChromeDriver Driver = new ChromeDriver();
        IWebElement lnkLogin => Driver.FindElement(By.CssSelector("a[class='nav-link text-light bg-primary']"));
        IWebElement lnkLogOut => Driver.FindElement(By.CssSelector("a[title='Logout']"));

        public void ClickLogin() => lnkLogin.Click();
        //public void ClickLogOut() => lnkLogOut.Click();

        public bool IsLogOutExist => lnkLogOut.Displayed;

        public void OpenHomePage()
        {
            Driver.Navigate().GoToUrl("http://localhost:8080/");
            Driver.Manage().Window.Maximize();
        }


        public void OpenHomePageInBrowser(string browser)
        {
            if (browser == "chrome")
            {
                Driver.Navigate().GoToUrl("http://localhost:8080/");
                Driver.Manage().Window.Maximize();
            }
            else if (browser == "firefox") { }
            else
            {
            }
        }
    }
}
