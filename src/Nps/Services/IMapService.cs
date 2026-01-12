using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Maps;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IMapService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IMapServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IMapService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /mapdata/parkboundaries/{sitecode}<c/>.
    /// </summary>
    Task<List<MapRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        MapRetrieveParkBoundariesParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RetrieveParkBoundaries(MapRetrieveParkBoundariesParams, CancellationToken)"/>
    Task<List<MapRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        string sitecode,
        MapRetrieveParkBoundariesParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IMapService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IMapServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IMapServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /mapdata/parkboundaries/{sitecode}`, but is otherwise the
    /// same as <see cref="IMapService.RetrieveParkBoundaries(MapRetrieveParkBoundariesParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<MapRetrieveParkBoundariesResponse>>> RetrieveParkBoundaries(
        MapRetrieveParkBoundariesParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RetrieveParkBoundaries(MapRetrieveParkBoundariesParams, CancellationToken)"/>
    Task<HttpResponse<List<MapRetrieveParkBoundariesResponse>>> RetrieveParkBoundaries(
        string sitecode,
        MapRetrieveParkBoundariesParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
