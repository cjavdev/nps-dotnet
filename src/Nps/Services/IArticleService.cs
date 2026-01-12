using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Articles;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IArticleService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IArticleServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IArticleService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /articles<c/>.
    /// </summary>
    Task<ArticleListResponse> List(
        ArticleListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IArticleService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IArticleServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IArticleServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /articles`, but is otherwise the
    /// same as <see cref="IArticleService.List(ArticleListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ArticleListResponse>> List(
        ArticleListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
