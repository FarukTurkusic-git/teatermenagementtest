using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcceptanceTest.Tests.UnitTests
{
    public class UnitTestUseConfig
    {

        public UnitTestUseConfig()
        {
            try
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.test.json")
                    .Build();

                var clientId = config["Configutrations"];



            }
            catch (Exception ex)
            {
                var m = ex.Message;
            }
        }



        [Fact]
        public void Customer()
        {

            string client = "";
            IConfiguration config = InitConfiguration();

            var clientId = config["ClientId"];
            client = clientId.ToString();


            Console.WriteLine("success!" + client);
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("xunit.runner.json")
                .Build();
            return config;
        }
    }
}
