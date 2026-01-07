using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Mapdata;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IMapdataService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IMapdataService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    Task<List<MapdataRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        MapdataRetrieveParkBoundariesParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RetrieveParkBoundaries(MapdataRetrieveParkBoundariesParams, CancellationToken)"/>
    Task<List<MapdataRetrieveParkBoundariesResponse>> RetrieveParkBoundaries(
        string sitecode,
        MapdataRetrieveParkBoundariesParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
