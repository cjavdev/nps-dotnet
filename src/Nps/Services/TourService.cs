using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Tours;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class TourService : ITourService
{
    /// <inheritdoc/>
    public ITourService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TourService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public TourService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<TourListResponse>> List(
        TourListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TourListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var tours = await response
            .Deserialize<List<TourListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in tours)
            {
                item.Validate();
            }
        }
        return tours;
    }
}
