using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Formatted;

namespace ArcadeDotnet.Services.Tools;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IFormattedService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IFormattedService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a page of tools from the engine configuration, optionally filtered
    /// by toolkit, formatted for a specific provider
    /// </summary>
    Task<FormattedListPageResponse> List(
        FormattedListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the formatted tool specification for a specific tool, given a provider
    /// </summary>
    Task<JsonElement> Get(
        FormattedGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(FormattedGetParams, CancellationToken)"/>
    Task<JsonElement> Get(
        string name,
        FormattedGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
