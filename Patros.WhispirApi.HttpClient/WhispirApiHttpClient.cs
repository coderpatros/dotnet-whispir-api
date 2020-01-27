using System.Net.Http;

namespace CoderPatros.WhispirApi
{
    public static class WhispirApiHttpClient
    {
        public static HttpClient GetClient(WhispirApiHttpClientOptions options)
        {
            var msgHandler = new WhispirApiHttpMessageHandler(options);
            return new HttpClient(msgHandler);
        }

        public static HttpClient GetClient(WhispirApiHttpClientOptions options, HttpMessageHandler innerHandler)
        {
            var msgHandler = new WhispirApiHttpMessageHandler(options, innerHandler);
            return new HttpClient(msgHandler);
        }
    }
}
