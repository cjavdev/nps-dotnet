using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.RoadEvents;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IRoadEventService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IRoadEventServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IRoadEventService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /roadevents<c/>.
    /// </summary>
    Task<List<RoadEventListResponse>> List(
        RoadEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IRoadEventService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IRoadEventServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IRoadEventServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /roadevents`, but is otherwise the
    /// same as <see cref="IRoadEventService.List(RoadEventListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<RoadEventListResponse>>> List(
        RoadEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
