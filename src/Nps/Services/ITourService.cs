using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Tours;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ITourService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ITourServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITourService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    Task<List<TourListResponse>> List(
        TourListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ITourService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ITourServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITourServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /tours`, but is otherwise the
    /// same as <see cref="ITourService.List(TourListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<TourListResponse>>> List(
        TourListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
