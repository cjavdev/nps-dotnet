using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.ThingsTodo;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IThingsTodoService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IThingsTodoServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IThingsTodoService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /thingstodo<c/>.
    /// </summary>
    Task<ThingsTodoListPage> List(
        ThingsTodoListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IThingsTodoService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IThingsTodoServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IThingsTodoServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /thingstodo`, but is otherwise the
    /// same as <see cref="IThingsTodoService.List(ThingsTodoListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ThingsTodoListPage>> List(
        ThingsTodoListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
