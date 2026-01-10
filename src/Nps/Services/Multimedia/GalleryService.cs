using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Multimedia.Galleries;

namespace Nps.Services.Multimedia;

/// <inheritdoc/>
public sealed class GalleryService : IGalleryService
{
    readonly Lazy<IGalleryServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IGalleryServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IGalleryService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new GalleryService(this._client.WithOptions(modifier));
    }

    public GalleryService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new GalleryServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<GalleryListResponse>> List(
        GalleryListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<List<GalleryListAssetsResponse>> ListAssets(
        GalleryListAssetsParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.ListAssets(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class GalleryServiceWithRawResponse : IGalleryServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IGalleryServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new GalleryServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public GalleryServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<GalleryListResponse>>> List(
        GalleryListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<GalleryListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var galleries = await response
                    .Deserialize<List<GalleryListResponse>>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    foreach (var item in galleries)
                    {
                        item.Validate();
                    }
                }
                return galleries;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<GalleryListAssetsResponse>>> ListAssets(
        GalleryListAssetsParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<GalleryListAssetsParams> request = new()
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
                    .Deserialize<List<GalleryListAssetsResponse>>(token)
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
