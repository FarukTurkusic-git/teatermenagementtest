using AcceptanceTest.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcceptanceTest.Tests.UnitTests
{
   
    public class UnitTesPoc
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "http://localhost:8080/";
        IWebDriver driver;


        [Fact]
        public void Customer()
        {
            brow.Init_Browser();
        }


        [Fact]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@id='search_form_input_homepage']"));

            element.SendKeys("LambdaTest");

            /* Submit the Search */
            element.Submit();

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }

        [Fact]
        public void close_Browser()
        {
            brow.Close();
        }
    }


}


