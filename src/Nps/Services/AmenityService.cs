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
    readonly Lazy<IAmenityServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IAmenityServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IAmenityService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AmenityService(this._client.WithOptions(modifier));
    }

    public AmenityService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new AmenityServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<AmenityListResponse>> List(
        AmenityListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<List<AmenityRetrieveParksPlacesResponse>> RetrieveParksPlaces(
        AmenityRetrieveParksPlacesParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.RetrieveParksPlaces(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<List<AmenityRetrieveParksVisitorCentersResponse>> RetrieveParksVisitorCenters(
        AmenityRetrieveParksVisitorCentersParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.RetrieveParksVisitorCenters(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class AmenityServiceWithRawResponse : IAmenityServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IAmenityServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AmenityServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public AmenityServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<AmenityListResponse>>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var amenities = await response
                    .Deserialize<List<AmenityListResponse>>(token)
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
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<AmenityRetrieveParksPlacesResponse>>> RetrieveParksPlaces(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<List<AmenityRetrieveParksPlacesResponse>>(token)
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
    public async Task<
        HttpResponse<List<AmenityRetrieveParksVisitorCentersResponse>>
    > RetrieveParksVisitorCenters(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<List<AmenityRetrieveParksVisitorCentersResponse>>(token)
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
}
