using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Newsreleases;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class NewsreleaseService : INewsreleaseService
{
    /// <inheritdoc/>
    public INewsreleaseService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new NewsreleaseService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public NewsreleaseService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<NewsreleaseListResponse>> List(
        NewsreleaseListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<NewsreleaseListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var newsreleases = await response
            .Deserialize<List<NewsreleaseListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in newsreleases)
            {
                item.Validate();
            }
        }
        return newsreleases;
    }
}
