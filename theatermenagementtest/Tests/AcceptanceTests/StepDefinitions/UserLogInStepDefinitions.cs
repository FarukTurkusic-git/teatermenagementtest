using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTest.StepDefinitions
{
    [Binding]
    public class UserLogInStepDefinitions
    {
        ChromeDriver driver;

        [Given(@"User navigate to application")]
        public void GivenUserNavigateToApplication()
        {

            ChromeOptions options = new ChromeOptions();
            Console.WriteLine("User log in");

            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("http://localhost:8080/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"User click the Login link")]
        public void GivenUserClickTheLoginLink()
        {
            var btnLogIn = driver.FindElement(By.CssSelector("a[class='nav-link text-light bg-primary']"));
            btnLogIn.Click();
        }

        [When(@"User login as demo user")]
        public void WhenUserLoginAsDemoUser()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            //System.Threading.Thread.Sleep(11000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Login']")));

            var btnLogIn = driver.FindElement(By.XPath("//button[text()='Login']"));
            btnLogIn.Click();
        }

        [Then(@"User will be login as demo user")]
        public void ThenUserWillBeLoginAsDemoUser()
        {
            var lblLogInUserName = driver.FindElement(By.CssSelector("a[class='nav-user text-light bg-primary']"));
            lblLogInUserName.Text.Should().Contain("Signed in as");


        }
    }

    //usefull links
    //https://devqa.io/selenium-css-selectors/
    //https://www.lambdatest.com/blog/locators-in-selenium-webdriver-with-examples/
    //https://www.youtube.com/watch?v=O5oHiBD5Lvk
}
