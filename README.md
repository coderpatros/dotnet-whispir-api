[![Build Status](https://dev.azure.com/coderpatros/OpenSource/_apis/build/status/CoderPatros.WhispirApi?branchName=master)](https://dev.azure.com/coderpatros/OpenSource/_build/latest?definitionId=17&branchName=master)
![Azure DevOps tests](https://img.shields.io/azure-devops/tests/coderpatros/OpenSource/17.svg)
![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/coderpatros/OpenSource/17.svg)
[![CodeFactor](https://www.codefactor.io/repository/github/coderpatros/dotnet-whispir-api/badge)](https://www.codefactor.io/repository/github/coderpatros/dotnet-whispir-api)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/152d264f1e2f490c898b7dde0a5c7956)](https://www.codacy.com/manual/coderpatros/dotnet-whispir-api?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=coderpatros/dotnet-whispir-api&amp;utm_campaign=Badge_Grade)
[![NuGet](https://img.shields.io/nuget/v/CoderPatros.WhispirApi.HttpClient.svg?style=flat-square)](https://www.nuget.org/packages/CoderPatros.WhispirApi.HttpClient/)
![Nuget](https://img.shields.io/nuget/dt/CoderPatros.WhispirApi.HttpClient.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-whispir-api.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Fcoderpatros%2Fdotnet-whispir-api?ref=badge_shield)
![Twitter Follow](https://img.shields.io/twitter/follow/coderpatros?style=social)

Whispir Api Http Client
=======================

A .net standard library with a little helper for those who have to interact
with the Whispir API.

Example Usage
-------------

```shell
dotnet add package CoderPatros.WhispirApi.HttpClient
```

```csharp
using CoderPatros.WhispirApi;

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
