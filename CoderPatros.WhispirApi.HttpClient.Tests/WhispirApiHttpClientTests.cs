using System.Net;
using System.Threading.Tasks;
using Xunit;
using RichardSzalay.MockHttp;
using CoderPatros.WhispirApi;

namespace CoderPatros.WhispirApi.HttpClient.Tests
{
    public class WhispirApiHttpClientTests
    {
        [Fact]
        public async Task TestRequestAddsAuthentication()
        {
            var mockHttp = new MockHttpMessageHandler();
            mockHttp
                .Expect("http://www.example.com?apikey=test-api-key") // DevSkim: ignore DS137138
                .WithHeaders("Authorization", "Basic dGVzdC11c2VybmFtZTp0ZXN0LXBhc3N3b3Jk")
                .WithHeaders("x-api-key", "test-api-key")
                .Respond(HttpStatusCode.OK);
            var client = WhispirApiHttpClient.GetClient(new WhispirApiHttpClientOptions
            {
                Username = "test-username",
                Password = "test-password",
                ApiKey = "test-api-key"
            }, mockHttp);

            await client.GetStringAsync("http://www.example.com"); // DevSkim: ignore DS137138

            mockHttp.VerifyNoOutstandingExpectation();
        }
    }
}
