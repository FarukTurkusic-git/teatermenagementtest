using AcceptanceTest.Pages;
using FluentAssertions;
using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTest.StepDefinitions
{

    [Binding]
    public class LoginStepDefinitions
    {
        static ChromeDriver Driver = new ChromeDriver();
        
       
        HomePage homePage = new HomePage(Driver);
        LoginPage loginPage = new LoginPage();

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            #region oldCode
            //ChromeOptions options = new ChromeOptions();
            ////options.AddArgument("start-maximized");
            ////options.AddArgument("--disable-gpu");
            ////options.AddArgument("--headless");
            //Console.WriteLine("Setup");

            //driver = new ChromeDriver(options);

            //driver.Navigate().GoToUrl("http://google.com");
            //driver.Manage().Window.Maximize();
            #endregion

            Driver.Navigate().GoToUrl("http://localhost:8080/");

            //homePage.OpenHomePage();

        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            #region oldCode
            //var q = Driver.FindElement(By.CssSelector("input[name='q']"));
            //driver.findElement(By.id("user_email_login"));
            #endregion
         
            homePage.ClickLogin();

        }


        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            #region oldCode
            //var q = Driver.FindElement(By.CssSelector("input[name='q']"));
            //q.SendKeys("abc@gmail.com");
            #endregion

            Console.WriteLine("Login as user for testing");
            
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            loginPage.ClickLoginUser();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            //String expectedUrl = Driver.Url.ToLower();
            //Assert.assertEquals(String actual, String expected);

            homePage.IsLogOutExist.Should().BeTrue();
            //expectedUrl.Should().NotBeNull();
            
        }
    }
}
