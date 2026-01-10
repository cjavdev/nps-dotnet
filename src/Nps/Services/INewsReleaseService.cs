using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.NewsReleases;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface INewsReleaseService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    INewsReleaseServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    INewsReleaseService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    Task<List<NewsReleaseListResponse>> List(
        NewsReleaseListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="INewsReleaseService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface INewsReleaseServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    INewsReleaseServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /newsreleases`, but is otherwise the
    /// same as <see cref="INewsReleaseService.List(NewsReleaseListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<NewsReleaseListResponse>>> List(
        NewsReleaseListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
