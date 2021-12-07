using AcceptanceTest.Pages;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTest
{
    [Binding]
    public class ViewHomePageStepDefinitions
    {

        private DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginPage;


        //public ViewHomePageStepDefinitions(DriverHelper driverHelper)
        //{
        //    _driverHelper = driverHelper;
        //    loginPage = new LoginPage(_driverHelper.Driver);
        //    homePage = new HomePage(_driverHelper.Driver);
        //}




        [Given(@"I navigate to home page of application")]
        public void GivenINavigateToHomePageOfApplication()
        {
            throw new PendingStepException();
        }

        [When(@"I am on home page")]
        public void WhenIAmOnHomePage()
        {
            throw new PendingStepException();
        }

        [Then(@"I see home page")]
        public void ThenISeeHomePage()
        {
            throw new PendingStepException();
        }
    }
}
