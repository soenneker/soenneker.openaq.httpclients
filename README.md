[![](https://img.shields.io/nuget/v/soenneker.openaq.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openaq.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openaq.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openaq.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openaq.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openaq.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openaq.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.openaq.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.OpenAq.HttpClients

Provides a cached `HttpClient` configured for OpenAQ's API, including `X-API-Key` authentication.

## Installation

```bash
dotnet add package Soenneker.OpenAq.HttpClients
```

## Configuration

```json
{
  "OpenAq": {
    "ApiKey": "your-api-key"
  }
}
```

`OpenAq:ClientBaseUrl`, `OpenAq:AuthHeaderName`, and `OpenAq:AuthHeaderValueTemplate` can override the defaults.

## Usage

```csharp
using Soenneker.OpenAq.HttpClients.Abstract;
using Soenneker.OpenAq.HttpClients.Registrars;

services.AddOpenAqOpenApiHttpClientAsSingleton();

IOpenAqOpenApiHttpClient provider = serviceProvider
    .GetRequiredService<IOpenAqOpenApiHttpClient>();

HttpClient client = await provider.Get(cancellationToken);
HttpResponseMessage response = await client.GetAsync("v3/locations?limit=10", cancellationToken);
response.EnsureSuccessStatusCode();
```

The provider owns its cached client. Disposing the provider removes and disposes that client. Scoped registration gives each provider instance its own cached client.
