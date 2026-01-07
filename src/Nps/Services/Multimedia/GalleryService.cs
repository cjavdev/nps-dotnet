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
    /// <inheritdoc/>
    public IGalleryService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new GalleryService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public GalleryService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<GalleryListResponse>> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var galleries = await response
            .Deserialize<List<GalleryListResponse>>(cancellationToken)
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

    /// <inheritdoc/>
    public async Task<List<GalleryListAssetsResponse>> ListAssets(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<GalleryListAssetsResponse>>(cancellationToken)
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
