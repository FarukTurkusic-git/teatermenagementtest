using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTest.Pages
{
    internal class LoginPage : DriverHelper
    {
        //bussines logic on page
        ChromeDriver Driver = new ChromeDriver();

        //private proporties
        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.Name("Login"));
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));


        IWebElement lnkLoginUser => Driver.FindElement(By.XPath("//button[text()='Login']"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }



        public void ClickLogin() => btnLogin.Click();

        public void ClickLoginUser() => lnkLoginUser.Click();
    }
}
