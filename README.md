# Arcade C# API Library

> [!NOTE]
> The Arcade C# API Library is currently in **beta** and we're excited for you to experiment with it!
>
> This library has not yet been exhaustively tested in production environments and may be missing some features you'd expect in a stable release. As we continue development, there may be breaking changes that require updates to your code.
>
> **We'd love your feedback!** Please share any suggestions, bug reports, feature requests, or general thoughts by [filing an issue](https://www.github.com/ArcadeAI/arcade-dotnet/issues/new).

The Arcade C# SDK provides convenient access to the [Arcade REST API](https://docs.arcade.dev) from applications written in C#.

It is generated with [Stainless](https://www.stainless.com/).

The REST API documentation can be found on [docs.arcade.dev](https://docs.arcade.dev).

## Installation

```bash
dotnet add package ArcadeDotnet
```

## Requirements

This library requires .NET 8 or later.

> [!NOTE]
> The library is currently in **beta**. The requirements will be lowered in the future.

## Usage

See the [`examples`](examples) directory for complete and runnable examples.

### Execute a Tool

**Simple tool (no OAuth):**
```csharp
using ArcadeDotnet;
using ArcadeDotnet.Models.Tools;

var client = new ArcadeClient();

var executeParams = new ToolExecuteParams
{
    ToolName = "CheckArcadeEngineHealth" // Example: simple tool
};

var result = await client.Tools.Execute(executeParams);
result.Validate();
Console.WriteLine($"Execution ID: {result.ExecutionID}");
Console.WriteLine($"Status: {result.Status}");
```

**Tool requiring OAuth (e.g., GitHub):**
```csharp
// Step 1: Authorize the tool
var authResponse = await client.Tools.Authorize(new ToolAuthorizeParams
{
    ToolName = "GitHub.ListRepositories"
});

// Step 2: After OAuth completes, execute with UserID
var executeParams = new ToolExecuteParams
{
    ToolName = "GitHub.ListRepositories",
    UserID = authResponse.UserID // From authorization response
};

var result = await client.Tools.Execute(executeParams);
```

### List Available Tools

```csharp
using ArcadeDotnet;

var client = new ArcadeClient();
var tools = await client.Tools.List();
tools.Validate();
Console.WriteLine($"Found {tools.Items?.Count ?? 0} tools");
```

### With Options

```csharp
using ArcadeDotnet;
using System.Net.Http;

var client = new ArcadeClient(new ArcadeClientOptions
{
    ApiKey = "your-api-key",
    BaseUrl = new Uri("https://api.arcade.dev"),
    HttpClient = new HttpClient() // Optional: inject your own HttpClient
});
```

### Using Factory

```csharp
using ArcadeDotnet;

// Factory method with shared HttpClient
var client = ArcadeClientFactory.Create("your-api-key");

// Or using environment variables
var clientFromEnv = ArcadeClientFactory.Create();
```

## Client Configuration

Configure the client using environment variables:

```csharp
using ArcadeDotnet;

// Configured using the ARCADE_API_KEY and ARCADE_BASE_URL environment variables
var client = new ArcadeClient();
```

Or with explicit options:

```csharp
using ArcadeDotnet;
using System.Net.Http;

var client = new ArcadeClient(new ArcadeClientOptions
{
    ApiKey = "your-api-key",
    BaseUrl = new Uri("https://api.arcade.dev"),
    HttpClient = new HttpClient() // Optional
});
```

See this table for the available options:

| Property     | Environment variable | Required | Default value              |
| ------------ | ------------------- | -------- | ------------------------- |
| `ApiKey`     | `ARCADE_API_KEY`    | true     | -                         |
| `BaseUrl`    | `ARCADE_BASE_URL`   | false    | `"https://api.arcade.dev"` |
| `HttpClient` | -                   | false    | New instance created      |

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

We are keen for your feedback; please open an [issue](https://www.github.com/ArcadeAI/arcade-dotnet/issues) with questions, bugs, or suggestions.
