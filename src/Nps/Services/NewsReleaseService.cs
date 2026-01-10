using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.NewsReleases;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class NewsReleaseService : INewsReleaseService
{
    readonly Lazy<INewsReleaseServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public INewsReleaseServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public INewsReleaseService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new NewsReleaseService(this._client.WithOptions(modifier));
    }

    public NewsReleaseService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new NewsReleaseServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<NewsReleaseListResponse>> List(
        NewsReleaseListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class NewsReleaseServiceWithRawResponse : INewsReleaseServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public INewsReleaseServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new NewsReleaseServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public NewsReleaseServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<NewsReleaseListResponse>>> List(
        NewsReleaseListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<NewsReleaseListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var newsReleases = await response
                    .Deserialize<List<NewsReleaseListResponse>>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    foreach (var item in newsReleases)
                    {
                        item.Validate();
                    }
                }
                return newsReleases;
            }
        );
    }
}
