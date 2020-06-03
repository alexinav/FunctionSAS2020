using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using FunctionSAS2020XUnitTest;
using Xunit;

namespace FunctionSAS2020
{
    public class GetSasTest
    {
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

            Assert.Contains("&sp=rl", sas);    //d
        }
    }
}