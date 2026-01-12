using System;
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
    readonly Lazy<IMultimediaServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IMultimediaServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IMultimediaService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new MultimediaService(this._client.WithOptions(modifier));
    }

    public MultimediaService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new MultimediaServiceWithRawResponse(client.WithRawResponse));
        _galleries = new(() => new GalleryService(client));
    }

    readonly Lazy<IGalleryService> _galleries;
    public IGalleryService Galleries
    {
        get { return _galleries.Value; }
    }

    /// <inheritdoc/>
    public async Task<MultimediaListAudioPage> ListAudio(
        MultimediaListAudioParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.ListAudio(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<MultimediaListVideosPage> ListVideos(
        MultimediaListVideosParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.ListVideos(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class MultimediaServiceWithRawResponse : IMultimediaServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IMultimediaServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new MultimediaServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public MultimediaServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;

        _galleries = new(() => new GalleryServiceWithRawResponse(client));
    }

    readonly Lazy<IGalleryServiceWithRawResponse> _galleries;
    public IGalleryServiceWithRawResponse Galleries
    {
        get { return _galleries.Value; }
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<MultimediaListAudioPage>> ListAudio(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<MultimediaListAudioPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new MultimediaListAudioPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<MultimediaListVideosPage>> ListVideos(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<MultimediaListVideosPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new MultimediaListVideosPage(this, parameters, page);
            }
        );
    }
}
