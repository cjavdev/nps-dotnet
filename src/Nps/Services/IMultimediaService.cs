using System;
using System.Collections.Generic;
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
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IMultimediaService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IGalleryService Galleries { get; }

    Task<List<MultimediaListAudioResponse>> ListAudio(
        MultimediaListAudioParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    Task<List<MultimediaListVideosResponse>> ListVideos(
        MultimediaListVideosParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
