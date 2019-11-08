Whispir Api Http Client
=======================

A .net standard library with a little helper for those who have to interact
with the Whispir API.

Example Usage
-------------

```shell
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
