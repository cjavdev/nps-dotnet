using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Parks;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IParkService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IParkServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IParkService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /parks<c/>.
    /// </summary>
    Task<ParkListPage> List(
        ParkListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IParkService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IParkServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IParkServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /parks`, but is otherwise the
    /// same as <see cref="IParkService.List(ParkListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ParkListPage>> List(
        ParkListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
