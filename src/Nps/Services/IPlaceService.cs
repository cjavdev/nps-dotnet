using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Places;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IPlaceService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IPlaceServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPlaceService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /places<c/>.
    /// </summary>
    Task<PlaceListPage> List(
        PlaceListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IPlaceService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IPlaceServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPlaceServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /places`, but is otherwise the
    /// same as <see cref="IPlaceService.List(PlaceListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PlaceListPage>> List(
        PlaceListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
