using System.Net.Http;

namespace Patros.WhispirApi
{
    public static class WhispirApiHttpClient
    {
        public static HttpClient GetClient(WhispirApiHttpClientOptions options, HttpMessageHandler innerHandler = null)
        {
            var msgHandler = new WhispirApiHttpMessageHandler(options, innerHandler);
            return new HttpClient(msgHandler);
        }
    }
}
