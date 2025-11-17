# Changelog

## 0.2.0 (2025-01-XX)

### Breaking Changes

* **Client Configuration**: Constructor now requires `ArcadeClientOptions` instead of object initializer syntax
* **HttpClient**: Removed from public API. Inject via `ArcadeClientOptions.HttpClient` for dependency injection support
* **Type Names**: Renamed `HttpRequest`/`HttpResponse` → `ArcadeRequest`/`ArcadeResponse` to avoid ASP.NET naming conflicts

### Features

* **ArcadeClientOptions**: New strongly-typed configuration class with environment variable support
* **ArcadeClientFactory**: Convenient factory methods with shared HttpClient instance
* **Parameterless Constructor**: Creates client using `ARCADE_API_KEY` and `ARCADE_BASE_URL` environment variables
* **XML Documentation**: Comprehensive documentation added to all public APIs

### Improvements

* Applied modern C# 12 patterns (primary constructors, expression-bodied members, string interpolation)
* Added 69 behavior-focused unit tests covering edge cases and architectural validation
* Proper dependency injection support for `HttpClient`
* All exception types now sealed with XML documentation
* Improved separation of concerns and architectural patterns

## 0.1.0 (2025-10-29)

Full Changelog: [v0.0.1...v0.1.0](https://github.com/ArcadeAI/arcade-dotnet/compare/v0.0.1...v0.1.0)

### Features

* **api:** api update ([e731ecf](https://github.com/ArcadeAI/arcade-dotnet/commit/e731ecf0945af45989f03aa3cb73a557562974b8))


### Chores

* configure new SDK language ([a3f7f88](https://github.com/ArcadeAI/arcade-dotnet/commit/a3f7f8840bf0a4f27a93ca34ffb6d41d012f1b22))
* update SDK settings ([e48eeed](https://github.com/ArcadeAI/arcade-dotnet/commit/e48eeede2c39ba869c37e5bb47ade19fba268a62))
