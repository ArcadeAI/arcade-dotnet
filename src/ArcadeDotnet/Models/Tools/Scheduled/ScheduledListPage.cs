using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Services.Tools;

namespace ArcadeDotnet.Models.Tools.Scheduled;

public sealed class ScheduledListPage(
    IScheduledServiceWithRawResponse service,
    ScheduledListParams parameters,
    ScheduledListPageResponse response
) : IPage<ToolExecution>
{
    /// <inheritdoc/>
    public IReadOnlyList<ToolExecution> Items
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
    async Task<IPage<ToolExecution>> IPage<ToolExecution>.Next(
        CancellationToken cancellationToken
    ) => await this.Next(cancellationToken).ConfigureAwait(false);

    /// <inheritdoc cref="IPage{T}.Next"/>
    public async Task<ScheduledListPage> Next(CancellationToken cancellationToken = default)
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
        JsonSerializer.Serialize(this.Items, ModelBase.ToStringSerializerOptions);
}
