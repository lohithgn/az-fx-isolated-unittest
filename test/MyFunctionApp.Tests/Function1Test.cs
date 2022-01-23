using Microsoft.Azure.Functions.Isolated.TestDoubles;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using Microsoft.Azure.Functions.Isolated.TestDoubles.Extensions;

namespace MyFunctionApp.Tests;
public class Function1Test
{
    [Fact]
    public void When_Invoked_Responds_Correct()
    {
        //Arrange
        var requestData = MockHelpers.CreateHttpRequestData();

        //Act
        var sut = new Function1(Mock.Of<ILogger<Function1>>());
        var response = sut.Run(requestData);
        var result = response.ReadHttpResponseData();

        //Assert
        Assert.Equal("Welcome to Azure Functions!", result);
    }

}
