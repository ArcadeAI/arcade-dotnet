using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Core;

public sealed class HttpResponse : IDisposable
{
    public required HttpResponseMessage Message { get; init; }

    public CancellationToken CancellationToken { get; init; } = default;

    public async Task<T> Deserialize<T>(CancellationToken cancellationToken = default)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(
            this.CancellationToken,
            cancellationToken
        );
        try
        {
            return JsonSerializer.Deserialize<T>(
                    await Message.Content.ReadAsStreamAsync(cts.Token).ConfigureAwait(false),
                    ModelBase.SerializerOptions
                ) ?? throw new ArcadeInvalidDataException("Response cannot be null");
        }
        catch (HttpRequestException e)
        {
            throw new ArcadeIOException("I/O Exception", e);
        }
    }

    public void Dispose()
    {
        this.Message.Dispose();
    }
}
