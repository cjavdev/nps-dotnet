using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Multimedia;
using Nps.Services.Multimedia;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class MultimediaService : IMultimediaService
{
    /// <inheritdoc/>
    public IMultimediaService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new MultimediaService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public MultimediaService(INpsClient client)
    {
        _client = client;
        _galleries = new(() => new GalleryService(client));
    }

    readonly Lazy<IGalleryService> _galleries;
    public IGalleryService Galleries
    {
        get { return _galleries.Value; }
    }

    /// <inheritdoc/>
    public async Task<List<MultimediaListAudioResponse>> ListAudio(
        MultimediaListAudioParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<MultimediaListAudioParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<MultimediaListAudioResponse>>(cancellationToken)
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
    public async Task<List<MultimediaListVideosResponse>> ListVideos(
        MultimediaListVideosParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<MultimediaListVideosParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<MultimediaListVideosResponse>>(cancellationToken)
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
