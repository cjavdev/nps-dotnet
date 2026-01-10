using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.PassportStampLocations;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IPassportStampLocationService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IPassportStampLocationServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPassportStampLocationService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    Task<List<PassportStampLocationListResponse>> List(
        PassportStampLocationListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IPassportStampLocationService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IPassportStampLocationServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPassportStampLocationServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /passportstamplocations`, but is otherwise the
    /// same as <see cref="IPassportStampLocationService.List(PassportStampLocationListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<PassportStampLocationListResponse>>> List(
        PassportStampLocationListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
