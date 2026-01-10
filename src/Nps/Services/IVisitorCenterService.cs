using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.VisitorCenters;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IVisitorCenterService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IVisitorCenterServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IVisitorCenterService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    Task<List<VisitorCenterListResponse>> List(
        VisitorCenterListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IVisitorCenterService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IVisitorCenterServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IVisitorCenterServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /visitorcenters`, but is otherwise the
    /// same as <see cref="IVisitorCenterService.List(VisitorCenterListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<VisitorCenterListResponse>>> List(
        VisitorCenterListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
