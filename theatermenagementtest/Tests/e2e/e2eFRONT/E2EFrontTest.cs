using AcceptanceTest;
using AcceptanceTest.Pages;
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
        [Fact]
        public void FrontTest()
        {

            HomePage homepage = new HomePage();
            string url = "https://www.google.com";

            homepage.OpenHomePageInBrowser("chrome", url);

            homepage.ClickLoginBySelector();




        }

    }
}
