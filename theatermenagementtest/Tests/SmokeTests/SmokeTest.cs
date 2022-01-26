using AcceptanceTest.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcceptanceTest.Tests.SmokeTests
{
    public class SmokeTest
    {
        [Trait("Category", "UITests")]
        [Fact]
        public void BrowseToUrlPageTest()
        {
            //ChromeDriver Driver = new ChromeDriver();

            HomePage homePage = new HomePage();

            homePage.OpenHomePageInBrowser("chrome", "https://devblogs.microsoft.com/devops/integrating-smoke-tests-into-your-continuous-delivery-pipeline/");
            
        }



    }

}
