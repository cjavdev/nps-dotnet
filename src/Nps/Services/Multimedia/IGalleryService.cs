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
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IGalleryServiceWithRawResponse WithRawResponse { get; }

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

/// <summary>
/// A view of <see cref="IGalleryService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IGalleryServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IGalleryServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /multimedia/galleries`, but is otherwise the
    /// same as <see cref="IGalleryService.List(GalleryListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<GalleryListResponse>>> List(
        GalleryListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /multimedia/galleries/assets`, but is otherwise the
    /// same as <see cref="IGalleryService.ListAssets(GalleryListAssetsParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<List<GalleryListAssetsResponse>>> ListAssets(
        GalleryListAssetsParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
