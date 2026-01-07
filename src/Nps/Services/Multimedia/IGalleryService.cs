using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Multimedia.Galleries;

namespace Nps.Services.Multimedia;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IGalleryService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IGalleryService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    Task<List<GalleryListResponse>> List(
        GalleryListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    Task<List<GalleryListAssetsResponse>> ListAssets(
        GalleryListAssetsParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
