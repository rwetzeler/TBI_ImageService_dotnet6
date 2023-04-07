using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Moq;
using TBI.Images;
using Microsoft.AspNetCore.Http.Internal;

namespace TBI.Tests
{
    public class ImageServiceTests
    {
        [Fact]
        public void WatermarkImage_ReturnsExpectedResult()
        {
            // Arrange
            var req = new DefaultHttpRequest(new DefaultHttpContext());
            var logger = new Mock<ILogger>();

            // Act
            req.QueryString.Add("name", "test");
            var result = WatermarkImage.Run(req, logger.Object);

            // Assert            
            Assert.IsType<OkObjectResult>(result);
          //  Assert.Equal("ExpectedResult", ((OkObjectResult)result).Value);

        }
    }
}