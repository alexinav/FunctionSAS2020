using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using FunctionSAS2020;

namespace FunctionSAS2020XUnitTest
{
    public class ConnectionTest
    {
        [Fact]
        public void Create_connection_to_Storage_Account_Is_NOT_NULL()
        {
            var connection = new Connection();
            var response = connection.Create();
            Assert.NotNull(response);
        }
    }
}
