using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Articles;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ArticleService : IArticleService
{
    /// <inheritdoc/>
    public IArticleService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ArticleService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public ArticleService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<ArticleListResponse>> List(
        ArticleListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ArticleListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var articles = await response
            .Deserialize<List<ArticleListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in articles)
            {
                item.Validate();
            }
        }
        return articles;
    }
}
