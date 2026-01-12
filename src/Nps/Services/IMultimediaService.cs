using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Multimedia;
using Nps.Services.Multimedia;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IMultimediaService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IMultimediaServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IMultimediaService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IGalleryService Galleries { get; }

    /// <summary>
    /// Sends a request to <c>get /multimedia/audio<c/>.
    /// </summary>
    Task<MultimediaListAudioPage> ListAudio(
        MultimediaListAudioParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a request to <c>get /multimedia/videos<c/>.
    /// </summary>
    Task<MultimediaListVideosPage> ListVideos(
        MultimediaListVideosParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IMultimediaService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IMultimediaServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IMultimediaServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IGalleryServiceWithRawResponse Galleries { get; }

    /// <summary>
    /// Returns a raw HTTP response for `get /multimedia/audio`, but is otherwise the
    /// same as <see cref="IMultimediaService.ListAudio(MultimediaListAudioParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<MultimediaListAudioPage>> ListAudio(
        MultimediaListAudioParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /multimedia/videos`, but is otherwise the
    /// same as <see cref="IMultimediaService.ListVideos(MultimediaListVideosParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<MultimediaListVideosPage>> ListVideos(
        MultimediaListVideosParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
