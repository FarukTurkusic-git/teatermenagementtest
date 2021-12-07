using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace AcceptanceTest.StepDefinitions
{
    [Binding]
    public class YouTubeSearchFeatureStepDefinitions : IDisposable
    {
        private String searchKeyword;
        private ChromeDriver chromeDriver;
        public YouTubeSearchFeatureStepDefinitions() => chromeDriver = new ChromeDriver();

        [Given(@"I have navigated to youtube website")]
        public void GivenIHaveNavigatedToYoutubeWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://www.youtube.com");
            chromeDriver.Title.ToLower().Should().Contain("youtube");
        }

        [Given(@"I have entered (.*) as search keyword")]
        public void GivenIHaveEnteredIndiaAsSearchKeyword(string searchKeyword)
        {
            this.searchKeyword = searchKeyword.ToLower();
            var searchInputBox = chromeDriver.FindElement(By.Id("search"));
            var wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(2));
            //System.Threading.Thread.Sleep(11000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("search")));
            searchInputBox.SendKeys(searchKeyword);
        }

        [When(@"I press the seearch button")]
        public void WhenIPressTheSeearchButton()
        {
            var searchButton = chromeDriver.FindElement(By.CssSelector("button#search-icon-legacy"));
            searchButton.Click();
        }

        [Then(@"I should be navigate to search result page")]
        public void ThenIShouldBeNavigateToSearchResultPage()
        {
            // After search is complete the keyword should be present in url as well as page title`  
            //Assert.IsTrue(chromeDriver.Url.ToLower().Contains(searchKeyword));
            //Assert.IsTrue(chromeDriver.Title.ToLower().Contains(searchKeyword));

            chromeDriver.Url.ToLower().Should().Contain(searchKeyword);
            chromeDriver.Title.ToLower().Should().Contain(searchKeyword);
        }
        public void Dispose()
        {
            if (chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }
        }
    }
}
