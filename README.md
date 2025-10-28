# Arcade C# API Library

> [!NOTE]
> The Arcade C# API Library is currently in **beta** and we're excited for you to experiment with it!
>
> This library has not yet been exhaustively tested in production environments and may be missing some features you'd expect in a stable release. As we continue development, there may be breaking changes that require updates to your code.
>
> **We'd love your feedback!** Please share any suggestions, bug reports, feature requests, or general thoughts by [filing an issue](https://www.github.com/stainless-sdks/arcade-engine-csharp/issues/new).

The Arcade C# SDK provides convenient access to the [Arcade REST API](https://docs.arcade.dev) from applications written in C#.

It is generated with [Stainless](https://www.stainless.com/).

The REST API documentation can be found on [docs.arcade.dev](https://docs.arcade.dev).

## Installation

```bash
git clone git@github.com:stainless-sdks/arcade-engine-csharp.git
dotnet add reference arcade-engine-csharp/src/ArcadeEngine
```

## Requirements

This library requires .NET 8 or later.

> [!NOTE]
> The library is currently in **beta**. The requirements will be lowered in the future.

## Usage

See the [`examples`](examples) directory for complete and runnable examples.

```csharp
using System;
using ArcadeEngine;
using ArcadeEngine.Models.Tools;

// Configured using the ARCADE_API_KEY and ARCADE_BASE_URL environment variables
ArcadeClient client = new();

ToolExecuteParams parameters = new() { ToolName = "Google.ListEmails" };

var executeToolResponse = await client.Tools.Execute(parameters);

Console.WriteLine(executeToolResponse);
```

## Client Configuration

Configure the client using environment variables:

```csharp
using ArcadeEngine;

// Configured using the ARCADE_API_KEY and ARCADE_BASE_URL environment variables
ArcadeClient client = new();
```

Or manually:

```csharp
using ArcadeEngine;

ArcadeClient client = new() { APIKey = "My API Key" };
```

Or using a combination of the two approaches.

See this table for the available options:

| Property  | Environment variable | Required | Default value              |
| --------- | -------------------- | -------- | -------------------------- |
| `APIKey`  | `ARCADE_API_KEY`     | true     | -                          |
| `BaseUrl` | `ARCADE_BASE_URL`    | true     | `"https://api.arcade.dev"` |

## Requests and responses

To send a request to the Arcade API, build an instance of some `Params` class and pass it to the corresponding client method. When the response is received, it will be deserialized into an instance of a C# class.

For example, `client.Tools.Execute` should be called with an instance of `ToolExecuteParams`, and it will return an instance of `Task<ExecuteToolResponse>`.

## Error handling

The SDK throws custom unchecked exception types:

- `ArcadeApiException`: Base class for API errors. See this table for which exception subclass is thrown for each HTTP status code:

| Status | Exception                             |
| ------ | ------------------------------------- |
| 400    | `ArcadeBadRequestException`           |
| 401    | `ArcadeUnauthorizedException`         |
| 403    | `ArcadeForbiddenException`            |
| 404    | `ArcadeNotFoundException`             |
| 422    | `ArcadeUnprocessableEntityException`  |
| 429    | `ArcadeRateLimitException`            |
| 5xx    | `Arcade5xxException`                  |
| others | `ArcadeUnexpectedStatusCodeException` |

Additionally, all 4xx errors inherit from `Arcade4xxException`.

false

- `ArcadeIOException`: I/O networking errors.

- `ArcadeInvalidDataException`: Failure to interpret successfully parsed data. For example, when accessing a property that's supposed to be required, but the API unexpectedly omitted it from the response.

- `ArcadeException`: Base class for all exceptions.

## Semantic versioning

This package generally follows [SemVer](https://semver.org/spec/v2.0.0.html) conventions, though certain backwards-incompatible changes may be released as minor versions:

1. Changes to library internals which are technically public but not intended or documented for external use. _(Please open a GitHub issue to let us know if you are relying on such internals.)_
2. Changes that we do not expect to impact the vast majority of users in practice.

We take backwards-compatibility seriously and work hard to ensure you can rely on a smooth upgrade experience.

We are keen for your feedback; please open an [issue](https://www.github.com/stainless-sdks/arcade-engine-csharp/issues) with questions, bugs, or suggestions.
