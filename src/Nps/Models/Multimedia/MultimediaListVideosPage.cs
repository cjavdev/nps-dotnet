using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Exceptions;
using Nps.Services;

namespace Nps.Models.Multimedia;

/// <summary>
/// A single page from the paginated endpoint that <see cref="IMultimediaService.ListVideos(MultimediaListVideosParams, CancellationToken)"/> queries.
/// </summary>
public sealed class MultimediaListVideosPage(
    IMultimediaServiceWithRawResponse service,
    MultimediaListVideosParams parameters,
    MultimediaListVideosPageResponse response
) : IPage<MultimediaListVideosResponse>
{
    /// <inheritdoc/>
    public IReadOnlyList<MultimediaListVideosResponse> Items
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
    async Task<IPage<MultimediaListVideosResponse>> IPage<MultimediaListVideosResponse>.Next(
        CancellationToken cancellationToken
    ) => await this.Next(cancellationToken).ConfigureAwait(false);

    /// <inheritdoc cref="IPage{T}.Next"/>
    public async Task<MultimediaListVideosPage> Next(CancellationToken cancellationToken = default)
    {
        var currentOffset = parameters.Start ?? 0;
        using var nextResponse = await service
            .ListVideos(
                parameters with
                {
                    Start = currentOffset + this.Items.Count,
                },
                cancellationToken
            )
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
