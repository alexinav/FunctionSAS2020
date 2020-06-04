using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using FunctionSAS2020XUnitTest;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FunctionSAS2020
{
    public class GetSasTest
    {
        private readonly ILogger logger = TestFactory.CreateLogger();
        [Fact]
        public void GetSasDoNotEmpty()
        {
            var theresas = new GetSas().Do();

            Assert.NotEmpty(theresas);
        }
        [Fact]
        public void GetSasReturnInNotEmpty()
        {
            var getsas = new GetSas();
            var result = getsas.Do();

            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetSasDoIsASAS()
        {
            var sas = new GetSas().Do();

            Assert.Contains("?sv=", sas);

        }

        [Fact]
        public void DoIsReadAndWritePermission()
        {
            var sas = new GetSas().Do();

            Assert.Contains("&sp=rl", sas);
        }

        [Fact]
        public async void GetSasReturnASasWithPermitionOfRW()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await HelloWd.Run(request, logger);

            var result = response as OkObjectResult;

            Assert.Contains("?sv=", result.Value.ToString()); ;
            Assert.Contains("&sp=rl", result.Value.ToString()); ;
        }
    }
}
