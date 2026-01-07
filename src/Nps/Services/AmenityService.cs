using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Amenities;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class AmenityService : IAmenityService
{
    /// <inheritdoc/>
    public IAmenityService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AmenityService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public AmenityService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<AmenityListResponse>> List(
        AmenityListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AmenityListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var amenities = await response
            .Deserialize<List<AmenityListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in amenities)
            {
                item.Validate();
            }
        }
        return amenities;
    }

    /// <inheritdoc/>
    public async Task<List<AmenityRetrieveParksPlacesResponse>> RetrieveParksPlaces(
        AmenityRetrieveParksPlacesParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AmenityRetrieveParksPlacesParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<AmenityRetrieveParksPlacesResponse>>(cancellationToken)
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
    public async Task<List<AmenityRetrieveParksVisitorCentersResponse>> RetrieveParksVisitorCenters(
        AmenityRetrieveParksVisitorCentersParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AmenityRetrieveParksVisitorCentersParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<AmenityRetrieveParksVisitorCentersResponse>>(cancellationToken)
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
}
