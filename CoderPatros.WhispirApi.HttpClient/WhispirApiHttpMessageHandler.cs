using System.Net.Http;
using CoderPatros.AuthenticatedHttpClient;

namespace CoderPatros.WhispirApi
{
    public class WhispirApiHttpMessageHandler : DelegatingHandler
    {
        public WhispirApiHttpMessageHandler(WhispirApiHttpClientOptions options) : this(options, null)
        {
        }

        public WhispirApiHttpMessageHandler(WhispirApiHttpClientOptions options, HttpMessageHandler innerHandler)
        {
            BasicAuthenticatedHttpMessageHandler basicAuthHandler;
            
            if (innerHandler == null)
            {
                basicAuthHandler = new BasicAuthenticatedHttpMessageHandler(
                    new BasicAuthenticatedHttpClientOptions
                    {
                        UserId = options.Username,
                        Password = options.Password
                    }
                );
            }
            else
            {
                basicAuthHandler = new BasicAuthenticatedHttpMessageHandler(
                    new BasicAuthenticatedHttpClientOptions
                    {
                        UserId = options.Username,
                        Password = options.Password
                    },
                    innerHandler
                );
            }

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
}
