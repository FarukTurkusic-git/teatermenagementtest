using OpenQA.Selenium;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//To get started, we need to have a REST API up and running.
//We’ll be writing unit tests for each of the API endpoints.
//https://medium.com/@oyetoketoby80/how-to-write-unit-test-for-your-rest-api-f8f71376273f

namespace AcceptanceTest.Tests.UnitTests
{
    public class UnitTestsAPI
    {
        String baseUrl = "https://apim-om-cluster-westus2-preprod.azure-api.net/echo/resource";

        [Fact]
        public void e2eClientTest()
        {


            RestClient client = new RestClient(baseUrl);

            RestRequest request = new RestRequest("/", Method.GET);


            IRestResponse<Response> response = client.Execute<Response>(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            //Assert.Equal("Works!", response.Data.Message);

        }

    }
}
