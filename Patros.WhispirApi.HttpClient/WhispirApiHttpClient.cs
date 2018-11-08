using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Patros.AuthenticatedHttpClient;

namespace Patros.WhispirApi
{
    public class WhispirApiHttpClientOptions
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
    }

    public class WhispirApiHttpMessageHandler : DelegatingHandler
    {
        public WhispirApiHttpMessageHandler(WhispirApiHttpClientOptions options, HttpMessageHandler innerHandler = null)
        {
            var basicAuthHandler = new BasicAuthenticatedHttpMessageHandler(
                new BasicAuthenticatedHttpClientOptions
                {
                    UserId = options.Username,
                    Password = options.Password
                },
                innerHandler
            );

            var customHeaderAuthHandler = new CustomHeaderAuthenticatedHttpMessageHandler(
                new CustomHeaderAuthenticatedHttpClientOptions
                {
                    Name = "x-api-key",
                    Value = options.ApiKey
                },
                basicAuthHandler
            );

            var queryStringAuthHandler = new QueryStringParameterAuthenticatedHttpMessageHandler(
                new QueryStringParameterAuthenticatedHttpClientOptions
                {
                    Name = "apikey",
                    Value = options.ApiKey
                },
                customHeaderAuthHandler
            );

            InnerHandler = queryStringAuthHandler;
        }
    }

    public static class WhispirApiHttpClient
    {
        public static HttpClient GetClient(WhispirApiHttpClientOptions options, HttpMessageHandler innerHandler = null)
        {
            var msgHandler = new WhispirApiHttpMessageHandler(options, innerHandler);
            return new HttpClient(msgHandler);
        }
    }
}
