using FunctionSAS2020;
using Xunit;
using Microsoft.Extensions.Logging;

namespace FunctionSAS2020XUnitTest
{
    public class alexfunction1
    {

        private readonly ILogger logger = TestFactory.CreateLogger();

        [Fact]
        public async void Images_devuelve_no_devuelve_null()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await HelloWd.Run(request, logger);

            Assert.NotNull(response);

        }
    }
}