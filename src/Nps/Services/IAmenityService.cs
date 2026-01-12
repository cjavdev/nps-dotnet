using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Amenities;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IAmenityService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IAmenityServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAmenityService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /amenities<c/>.
    /// </summary>
    Task<AmenityListResponse> List(
        AmenityListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a request to <c>get /amenities/parksplaces<c/>.
    /// </summary>
    Task<AmenityRetrieveParksPlacesResponse> RetrieveParksPlaces(
        AmenityRetrieveParksPlacesParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a request to <c>get /amenities/parksvisitorcenters<c/>.
    /// </summary>
    Task<AmenityRetrieveParksVisitorCentersResponse> RetrieveParksVisitorCenters(
        AmenityRetrieveParksVisitorCentersParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IAmenityService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IAmenityServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAmenityServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /amenities`, but is otherwise the
    /// same as <see cref="IAmenityService.List(AmenityListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AmenityListResponse>> List(
        AmenityListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /amenities/parksplaces`, but is otherwise the
    /// same as <see cref="IAmenityService.RetrieveParksPlaces(AmenityRetrieveParksPlacesParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AmenityRetrieveParksPlacesResponse>> RetrieveParksPlaces(
        AmenityRetrieveParksPlacesParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /amenities/parksvisitorcenters`, but is otherwise the
    /// same as <see cref="IAmenityService.RetrieveParksVisitorCenters(AmenityRetrieveParksVisitorCentersParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AmenityRetrieveParksVisitorCentersResponse>> RetrieveParksVisitorCenters(
        AmenityRetrieveParksVisitorCentersParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
