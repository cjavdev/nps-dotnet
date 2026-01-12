using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Articles;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ArticleService : IArticleService
{
    readonly Lazy<IArticleServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IArticleServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IArticleService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ArticleService(this._client.WithOptions(modifier));
    }

    public ArticleService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ArticleServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<ArticleListResponse> List(
        ArticleListParams? parameters = null,
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
public sealed class ArticleServiceWithRawResponse : IArticleServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IArticleServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ArticleServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ArticleServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ArticleListResponse>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var articles = await response
                    .Deserialize<ArticleListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    articles.Validate();
                }
                return articles;
            }
        );
    }
}
