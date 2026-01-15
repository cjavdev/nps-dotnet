# Nps C# API Library

The Nps C# SDK provides convenient access to the Nps REST API from applications written in C#.

It is generated with [Stainless](https://www.stainless.com/).

## Installation

```bash
git clone git@github.com:cjavdev/nps-dotnet.git
dotnet add reference nps-dotnet/src/Nps
```

## Requirements

This library requires .NET Standard 2.0 or later.

## Usage

See the [`examples`](examples) directory for complete and runnable examples.

```csharp
using System;
using Nps;
using Nps.Models.Activities;

NpsClient client = new();

ActivityListParams parameters = new();

var activities = await client.Activities.List(parameters);

Console.WriteLine(activities);
```

## Client configuration

Configure the client using environment variables:

```csharp
using Nps;

// Configured using the NATIONAL_PARK_KEY and NPS_BASE_URL environment variables
NpsClient client = new();
```

Or manually:

```csharp
using Nps;

NpsClient client = new() { ApiKey = "My API Key" };
```

Or using a combination of the two approaches.

See this table for the available options:

| Property  | Environment variable | Required | Default value                        |
| --------- | -------------------- | -------- | ------------------------------------ |
| `ApiKey`  | `NATIONAL_PARK_KEY`  | false    | -                                    |
| `BaseUrl` | `NPS_BASE_URL`       | true     | `"https://developer.nps.gov/api/v1"` |

### Modifying configuration

To temporarily use a modified client configuration, while reusing the same connection and thread pools, call `WithOptions` on any client or service:

```csharp
using System;

var activities = await client
    .WithOptions(options =>
        options with
        {
            BaseUrl = "https://example.com",
            Timeout = TimeSpan.FromSeconds(42),
        }
    )
    .Activities.List(parameters);

Console.WriteLine(activities);
```

Using a [`with` expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/with-expression) makes it easy to construct the modified options.

The `WithOptions` method does not affect the original client or service.

## Requests and responses

To send a request to the Nps API, build an instance of some `Params` class and pass it to the corresponding client method. When the response is received, it will be deserialized into an instance of a C# class.

For example, `client.Activities.List` should be called with an instance of `ActivityListParams`, and it will return an instance of `Task<List<ActivityListResponse>>`.

## Raw responses

The SDK defines methods that deserialize responses into instances of C# classes. However, these methods don't provide access to the response headers, status code, or the raw response body.

To access this data, prefix any HTTP method call on a client or service with `WithRawResponse`:

```csharp
var response = await client.WithRawResponse.Activities.List();
var statusCode = response.StatusCode;
var headers = response.Headers;
```

The raw `HttpResponseMessage` can also be accessed through the `RawMessage` property.

For non-streaming responses, you can deserialize the response into an instance of a C# class if needed:

```csharp
using System;
using System.Collections.Generic;
using Nps.Models.Activities;

var response = await client.WithRawResponse.Activities.List();
List<ActivityListResponse> deserialized = await response.Deserialize();
Console.WriteLine(deserialized);
```

## Error handling

The SDK throws custom unchecked exception types:

- `NpsApiException`: Base class for API errors. See this table for which exception subclass is thrown for each HTTP status code:

| Status | Exception                          |
| ------ | ---------------------------------- |
| 400    | `NpsBadRequestException`           |
| 401    | `NpsUnauthorizedException`         |
| 403    | `NpsForbiddenException`            |
| 404    | `NpsNotFoundException`             |
| 422    | `NpsUnprocessableEntityException`  |
| 429    | `NpsRateLimitException`            |
| 5xx    | `Nps5xxException`                  |
| others | `NpsUnexpectedStatusCodeException` |

Additionally, all 4xx errors inherit from `Nps4xxException`.

false

- `NpsIOException`: I/O networking errors.

- `NpsInvalidDataException`: Failure to interpret successfully parsed data. For example, when accessing a property that's supposed to be required, but the API unexpectedly omitted it from the response.

- `NpsException`: Base class for all exceptions.

## Pagination

The SDK defines methods that return a paginated lists of results. It provides convenient ways to access the results either one page at a time or item-by-item across all pages.

### Auto-pagination

To iterate through all results across all pages, use the `Paginate` method, which automatically fetches more pages as needed. The method returns an [`IAsyncEnumerable`](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1):

```csharp
using System;

var page = await client.Activities.ListParks(parameters);
await foreach (var item in page.Paginate())
{
    Console.WriteLine(item);
}
```

### Manual pagination

To access individual page items and manually request the next page, use the `Items` property, and `HasNext` and `Next` methods:

```csharp
using System;

var page = await client.Activities.ListParks();
while (true)
{
    foreach (var item in page.Items)
    {
        Console.WriteLine(item);
    }
    if (!page.HasNext())
    {
        break;
    }
    page = await page.Next();
}
```

## Network options

### Retries

The SDK automatically retries 2 times by default, with a short exponential backoff between requests.

Only the following error types are retried:

- Connection errors (for example, due to a network connectivity problem)
- 408 Request Timeout
- 409 Conflict
- 429 Rate Limit
- 5xx Internal

The API may also explicitly instruct the SDK to retry or not retry a request.

To set a custom number of retries, configure the client using the `MaxRetries` method:

```csharp
using Nps;

NpsClient client = new() { MaxRetries = 3 };
```

Or configure a single method call using [`WithOptions`](#modifying-configuration):

```csharp
using System;

var activities = await client
    .WithOptions(options =>
        options with { MaxRetries = 3 }
    )
    .Activities.List(parameters);

Console.WriteLine(activities);
```

### Timeouts

Requests time out after 1 minute by default.

To set a custom timeout, configure the client using the `Timeout` option:

```csharp
using System;
using Nps;

NpsClient client = new() { Timeout = TimeSpan.FromSeconds(42) };
```

Or configure a single method call using [`WithOptions`](#modifying-configuration):

```csharp
using System;

var activities = await client
    .WithOptions(options =>
        options with { Timeout = TimeSpan.FromSeconds(42) }
    )
    .Activities.List(parameters);

Console.WriteLine(activities);
```

## Undocumented API functionality

The SDK is typed for convenient usage of the documented API. However, it also supports working with undocumented or not yet supported parts of the API.

### Response validation

In rare cases, the API may return a response that doesn't match the expected type. For example, the SDK may expect a property to contain a `string`, but the API could return something else.

By default, the SDK will not throw an exception in this case. It will throw `NpsInvalidDataException` only if you directly access the property.

If you would prefer to check that the response is completely well-typed upfront, then either call `Validate`:

```csharp
var response = client.Maps.RetrieveParkBoundaries(parameters);
response.Validate();
```

Or configure the client using the `ResponseValidation` option:

```csharp
using Nps;

NpsClient client = new() { ResponseValidation = true };
```

Or configure a single method call using [`WithOptions`](#modifying-configuration):

```csharp
using System;

var response = await client
    .WithOptions(options =>
        options with { ResponseValidation = true }
    )
    .Maps.RetrieveParkBoundaries(parameters);

Console.WriteLine(response);
```

## Semantic versioning

This package generally follows [SemVer](https://semver.org/spec/v2.0.0.html) conventions, though certain backwards-incompatible changes may be released as minor versions:

1. Changes to library internals which are technically public but not intended or documented for external use. _(Please open a GitHub issue to let us know if you are relying on such internals.)_
2. Changes that we do not expect to impact the vast majority of users in practice.

We take backwards-compatibility seriously and work hard to ensure you can rely on a smooth upgrade experience.

We are keen for your feedback; please open an [issue](https://www.github.com/cjavdev/nps-dotnet/issues) with questions, bugs, or suggestions.
