using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Places;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class PlaceService : IPlaceService
{
    /// <inheritdoc/>
    public IPlaceService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PlaceService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public PlaceService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<PlaceListResponse>> List(
        PlaceListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<PlaceListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var places = await response
            .Deserialize<List<PlaceListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in places)
            {
                item.Validate();
            }
        }
        return places;
    }
}
