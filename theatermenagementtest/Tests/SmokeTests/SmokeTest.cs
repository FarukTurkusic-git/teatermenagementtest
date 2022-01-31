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
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("test-type");
            //options.AddArguments("start-maximized");
            //options.AddArguments("--window-size=1920,1080");
            //options.AddArguments("--enable-precise-memory-info");
            //options.AddArguments("--disable-popup-blocking");
            //options.AddArguments("--disable-default-apps");
            //options.AddArguments("test-type=browser");
            options.AddArguments("--disable - dev - shm - usage");
            options.AddArguments("--remote-debugging-port=9222");
            



            ChromeDriver Driver = new ChromeDriver(options);




            HomePage homePage = new HomePage(Driver);

            homePage.OpenHomePageInBrowser("chrome", "https://devblogs.microsoft.com/devops/integrating-smoke-tests-into-your-continuous-delivery-pipeline/");
            
        }



    }

}
