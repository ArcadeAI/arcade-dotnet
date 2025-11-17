using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Core;

/// <summary>
/// Represents an API response with deserialization capabilities.
/// </summary>
/// <remarks>
/// Implements <see cref="IDisposable"/>. Always use within a using statement to ensure proper resource disposal.
/// </remarks>
public sealed record ArcadeResponse : IDisposable
{
    /// <summary>
    /// Gets the underlying HTTP response message.
    /// </summary>
    public required HttpResponseMessage Message { get; init; }

    /// <summary>
    /// Deserializes the response content to the specified type.
    /// </summary>
    /// <typeparam name="TResult">The type to deserialize into.</typeparam>
    /// <returns>The deserialized object.</returns>
    /// <exception cref="ArcadeInvalidDataException">Thrown when deserialization fails.</exception>
    /// <exception cref="ArcadeIOException">Thrown when an I/O error occurs.</exception>
    public async Task<TResult> Deserialize<TResult>()
    {
        try
        {
            return JsonSerializer.Deserialize<TResult>(
                    await Message.Content.ReadAsStreamAsync().ConfigureAwait(false),
                    ModelBase.SerializerOptions
                ) ?? throw new ArcadeInvalidDataException("Response content cannot be null or deserialization failed");
        }
        catch (HttpRequestException ex)
        {
            throw new ArcadeIOException("I/O error occurred while reading response content", ex);
        }
    }

    /// <summary>
    /// Disposes the underlying HTTP response resources.
    /// </summary>
    public void Dispose()
    {
        Message.Dispose();
    }
}
