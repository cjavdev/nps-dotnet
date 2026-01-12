using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Exceptions;
using Nps.Services;

namespace Nps.Models.Activities;

/// <summary>
/// A single page from the paginated endpoint that <see cref="IActivityService.List(ActivityListParams, CancellationToken)"/> queries.
/// </summary>
public sealed class ActivityListPage(
    IActivityServiceWithRawResponse service,
    ActivityListParams parameters,
    ActivityListPageResponse response
) : IPage<ActivityListResponse>
{
    /// <inheritdoc/>
    public IReadOnlyList<ActivityListResponse> Items
    {
        get { return response.Data ?? []; }
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
            var totalCount = response.Total;
            if (totalCount == null)
            {
                return true;
            }
            return this.Items.Count < totalCount;
        }
        catch (NpsInvalidDataException)
        {
            // If accessing the response data to determine if there's a next page failed, then just
            // assume there's no next page.
            return false;
        }
    }

    /// <inheritdoc/>
    async Task<IPage<ActivityListResponse>> IPage<ActivityListResponse>.Next(
        CancellationToken cancellationToken
    ) => await this.Next(cancellationToken).ConfigureAwait(false);

    /// <inheritdoc cref="IPage{T}.Next"/>
    public async Task<ActivityListPage> Next(CancellationToken cancellationToken = default)
    {
        var currentOffset = parameters.Start ?? 0;
        using var nextResponse = await service
            .List(parameters with { Start = currentOffset + this.Items.Count }, cancellationToken)
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
