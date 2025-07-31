using Xunit;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc.Testing;
namespace WebApp.IntegrationTest
{
public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
{
private readonly HttpClient _client;
public IntegrationTestPages(WebApplicationFactory<Program> factory)
{
_client = factory.CreateClient();
}
        [Theory]
        [InlineData("Index")]
        [InlineData("Privacy")]
        [InlineData("Centro")]
        [InlineData("caridad")]
        [InlineData("Logos")]
        [InlineData("A1")]
        [InlineData("A2")]
        [InlineData("A3")]
        [InlineData("A4")]
        [InlineData("A5")]
        [InlineData("B1")]
        [InlineData("B2")]
        [InlineData("Bid")]
        [InlineData("Star")]
        [InlineData("alpha1")]
        [InlineData("Beta")]
        [InlineData("Omega")]
        [InlineData("GEN")]
        [InlineData("WW")]
        [InlineData("PGR")]
        
,

        public async Task TestGetPages(string url)
        {
            // Arrange
            // Act
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
}
}