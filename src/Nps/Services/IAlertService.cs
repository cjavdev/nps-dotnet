using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Alerts;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IAlertService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IAlertServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAlertService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /alerts<c/>.
    /// </summary>
    Task<List<AlertListResponse>> List(
        AlertListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IAlertService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IAlertServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAlertServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /alerts`, but is otherwise the
    /// same as <see cref="IAlertService.List(AlertListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<AlertListResponse>>> List(
        AlertListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
