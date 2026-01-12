using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.People;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IPersonService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IPersonServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPersonService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /people<c/>.
    /// </summary>
    Task<PersonListResponse> List(
        PersonListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IPersonService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IPersonServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPersonServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /people`, but is otherwise the
    /// same as <see cref="IPersonService.List(PersonListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PersonListResponse>> List(
        PersonListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
