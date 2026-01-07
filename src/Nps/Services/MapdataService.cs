using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Exceptions;
using Nps.Models.Mapdata;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class MapdataService : IMapdataService
{
    /// <inheritdoc/>
    public IMapdataService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new MapdataService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public MapdataService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<MapdataRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        MapdataRetrieveParkBoundariesParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.Sitecode == null)
        {
            throw new NpsInvalidDataException("'parameters.Sitecode' cannot be null");
        }

        HttpRequest<MapdataRetrieveParkBoundariesParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<MapdataRetrieveParkBoundariesResponse>>(cancellationToken)
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
    public async Task<List<MapdataRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        string sitecode,
        MapdataRetrieveParkBoundariesParams? parameters = null,
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
