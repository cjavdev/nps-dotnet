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
    readonly Lazy<IMapServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IMapServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IMapService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new MapService(this._client.WithOptions(modifier));
    }

    public MapService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new MapServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<MapRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        MapRetrieveParkBoundariesParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.RetrieveParkBoundaries(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<List<MapRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        string sitecode,
        MapRetrieveParkBoundariesParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.RetrieveParkBoundaries(
            parameters with
            {
                Sitecode = sitecode,
            },
            cancellationToken
        );
    }
}

/// <inheritdoc/>
public sealed class MapServiceWithRawResponse : IMapServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IMapServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new MapServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public MapServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<MapRetrieveParkBoundariesResponse>>> RetrieveParkBoundaries(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<List<MapRetrieveParkBoundariesResponse>>(token)
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
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<List<MapRetrieveParkBoundariesResponse>>> RetrieveParkBoundaries(
        string sitecode,
        MapRetrieveParkBoundariesParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.RetrieveParkBoundaries(
            parameters with
            {
                Sitecode = sitecode,
            },
            cancellationToken
        );
    }
}
