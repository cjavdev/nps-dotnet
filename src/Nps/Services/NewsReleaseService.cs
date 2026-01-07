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
    /// <inheritdoc/>
    public INewsReleaseService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new NewsReleaseService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public NewsReleaseService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<NewsReleaseListResponse>> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var newsReleases = await response
            .Deserialize<List<NewsReleaseListResponse>>(cancellationToken)
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
}
