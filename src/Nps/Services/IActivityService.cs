using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Activities;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IActivityService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IActivityServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IActivityService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /activities<c/>.
    /// </summary>
    Task<ActivityListPage> List(
        ActivityListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns activites parks information.
    /// </summary>
    Task<ActivityListParksPage> ListParks(
        ActivityListParksParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IActivityService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IActivityServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IActivityServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /activities`, but is otherwise the
    /// same as <see cref="IActivityService.List(ActivityListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ActivityListPage>> List(
        ActivityListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /activities/parks`, but is otherwise the
    /// same as <see cref="IActivityService.ListParks(ActivityListParksParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ActivityListParksPage>> ListParks(
        ActivityListParksParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
