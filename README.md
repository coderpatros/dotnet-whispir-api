[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-whispir-api.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-whispir-api?ref=badge_shield)

Whispir Api Http Client
=======================

A .net standard library with a little helper for those who have to interact
with the Whispir API.

Example Usage
-------------

```
dotnet add package Patros.WhispirApi.HttpClient
```

```csharp
using Patros.WhispirApi;

...

var options = new WhispirApiHttpClientOptions
{
    Username = "<YOUR USERNAME>",
    Password = "<YOUR PASSWORD>",
    ApiKey = "<YOUR API KEY>"
};

var client = WhispirApiHttpClient.GetClient(options);

```

That's it for now. There's a .net SDK in the works. So I'll hold off to see
where that gets to before doing anything further.


## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-whispir-api.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-whispir-api?ref=badge_large)