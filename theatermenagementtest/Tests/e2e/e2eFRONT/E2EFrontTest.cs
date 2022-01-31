using AcceptanceTest;
using AcceptanceTest.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace testProject.Tests.e2e.e2eFRONT
{
    public class E2EFrontTest
    {
        [Trait("Category", " E2EFrontTests")]
        [Fact]
        public void FrontTest()
        {
            ChromeDriver chromedriver = new ChromeDriver(); 

            HomePage homepage = new HomePage(chromedriver);
            string url = "https://www.google.com";

            homepage.OpenHomePageInBrowser("chrome", url);

            homepage.ClickLoginBySelector();




        }

    }
}
