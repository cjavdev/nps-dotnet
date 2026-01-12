using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Campgrounds;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ICampgroundService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ICampgroundServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICampgroundService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /campgrounds<c/>.
    /// </summary>
    Task<CampgroundListResponse> List(
        CampgroundListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ICampgroundService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ICampgroundServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICampgroundServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /campgrounds`, but is otherwise the
    /// same as <see cref="ICampgroundService.List(CampgroundListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CampgroundListResponse>> List(
        CampgroundListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
