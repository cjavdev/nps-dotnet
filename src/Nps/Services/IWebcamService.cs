using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Webcams;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IWebcamService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IWebcamServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IWebcamService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /webcams<c/>.
    /// </summary>
    Task<WebcamListResponse> List(
        WebcamListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IWebcamService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IWebcamServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IWebcamServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /webcams`, but is otherwise the
    /// same as <see cref="IWebcamService.List(WebcamListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<WebcamListResponse>> List(
        WebcamListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
