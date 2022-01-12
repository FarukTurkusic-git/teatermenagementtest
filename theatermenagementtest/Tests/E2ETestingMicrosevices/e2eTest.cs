using Microsoft.Graph;
using OpenQA.Selenium;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RestSharp;

namespace AcceptanceTest.Tests.E2ETestingMicrosevices
{
    //RestSharp
    //https://github.com/godlzr/RestSharp
    //https://csharp.hotexamples.com/examples/-/RestClient/Execute/php-restclient-execute-method-examples.html
    //https://csharp.hotexamples.com/examples/-/YouScribeClient/-/php-youscribeclient-class-examples.html
    
    public class e2eTest
    {
        //Uri baseUrl = new Uri("http://localhost:59461/");
        Uri baseUrl = new Uri("https://www.google.com/");
        [Trait("Category", "e2eAPI")]
        [Fact]
        public void e2eClientTest()
        {


            RestClient client = new RestClient(baseUrl);

            RestRequest request = new RestRequest("search?q=faruk+turkusic", Method.GET);


            IRestResponse<Response> response = client.Execute<Response>(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            //Assert.Equal("Works!", response.Data.Message);

        }
        [Trait("Category", "e2eAPI")]
        [Fact]
        public void Handles_GET_Request_404_Error()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("StatusCode/404");
            var response = client.Execute(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
