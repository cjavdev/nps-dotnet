using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Exceptions;
using Nps.Models.Maps;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class MapService : IMapService
{
    /// <inheritdoc/>
    public IMapService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new MapService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public MapService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<MapRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        MapRetrieveParkBoundariesParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.Sitecode == null)
        {
            throw new NpsInvalidDataException("'parameters.Sitecode' cannot be null");
        }

        HttpRequest<MapRetrieveParkBoundariesParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<MapRetrieveParkBoundariesResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in deserializedResponse)
            {
                item.Validate();
            }
        }
        return deserializedResponse;
    }

    /// <inheritdoc/>
    public async Task<List<MapRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        string sitecode,
        MapRetrieveParkBoundariesParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return await this.RetrieveParkBoundaries(
            parameters with
            {
                Sitecode = sitecode,
            },
            cancellationToken
        );
    }
}
