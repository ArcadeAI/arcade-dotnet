# Examples

This directory contains runnable examples demonstrating how to use the Arcade C# SDK.

## BasicExample

Demonstrates basic SDK usage including:
- Creating clients with different configuration methods
- Using environment variables
- Using `ArcadeClientOptions`
- Using `ArcadeClientFactory`
- Listing tools
- Health checks

### Running

```bash
cd BasicExample
export ARCADE_API_KEY="your-api-key"
dotnet run
```

## Requirements

- .NET 8 SDK
- Valid Arcade API key (set via `ARCADE_API_KEY` environment variable)

