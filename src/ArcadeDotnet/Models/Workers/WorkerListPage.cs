using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Services;

namespace ArcadeDotnet.Models.Workers;

/// <summary>
/// A single page from the paginated endpoint that <see cref="IWorkerService.List(WorkerListParams, CancellationToken)"/> queries.
/// </summary>
public sealed class WorkerListPage(
    IWorkerServiceWithRawResponse service,
    WorkerListParams parameters,
    WorkerListPageResponse response
) : IPage<WorkerResponse>
{
    /// <inheritdoc/>
    public IReadOnlyList<WorkerResponse> Items
    {
        get { return response.Items ?? []; }
    }

    /// <inheritdoc/>
    public bool HasNext()
    {
        try
        {
            if (this.Items.Count == 0)
            {
                return false;
            }
            var totalCount = response.TotalCount;
            if (totalCount == null)
            {
                return true;
            }
            return this.Items.Count < totalCount;
        }
        catch (ArcadeInvalidDataException)
        {
            // If accessing the response data to determine if there's a next page failed, then just
            // assume there's no next page.
            return false;
        }
    }

    /// <inheritdoc/>
    async Task<IPage<WorkerResponse>> IPage<WorkerResponse>.Next(
        CancellationToken cancellationToken
    ) => await this.Next(cancellationToken).ConfigureAwait(false);

    /// <inheritdoc cref="IPage{T}.Next"/>
    public async Task<WorkerListPage> Next(CancellationToken cancellationToken = default)
    {
        var currentOffset = parameters.Offset ?? 0;
        using var nextResponse = await service
            .List(parameters with { Offset = currentOffset + this.Items.Count }, cancellationToken)
            .ConfigureAwait(false);
        return await nextResponse.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public void Validate()
    {
        response.Validate();
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            FriendlyJsonPrinter.PrintValue(JsonSerializer.SerializeToElement(this.Items)),
            ModelBase.ToStringSerializerOptions
        );

    public override bool Equals(object? obj)
    {
        if (obj is not WorkerListPage other)
        {
            return false;
        }

        return Enumerable.SequenceEqual(this.Items, other.Items);
    }

    public override int GetHashCode() => 0;
}
