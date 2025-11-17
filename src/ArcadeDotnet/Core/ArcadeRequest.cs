using System.Net.Http;

namespace ArcadeDotnet.Core;

/// <summary>
/// Represents an API request with strongly-typed parameters.
/// </summary>
/// <typeparam name="TParams">The type of request parameters.</typeparam>
/// <param name="Method">The HTTP method for the request.</param>
/// <param name="Params">The request parameters.</param>
public sealed record ArcadeRequest<TParams>(HttpMethod Method, TParams Params)
    where TParams : ParamsBase;
