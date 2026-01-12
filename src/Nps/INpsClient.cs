using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Services;

namespace Nps;

/// <summary>
/// A client for interacting with the Nps REST API.
///
/// <para>This client performs best when you create a single instance and reuse it
/// for all interactions with the REST API. This is because each client holds its
/// own connection pool and thread pools. Reusing connections and threads reduces
/// latency and saves memory.</para>
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface INpsClient : IDisposable
{
    /// <inheritdoc cref="ClientOptions.HttpClient" />
    HttpClient HttpClient { get; init; }

    /// <inheritdoc cref="ClientOptions.BaseUrl" />
    string BaseUrl { get; init; }

    /// <inheritdoc cref="ClientOptions.ResponseValidation" />
    bool ResponseValidation { get; init; }

    /// <inheritdoc cref="ClientOptions.MaxRetries" />
    int? MaxRetries { get; init; }

    /// <inheritdoc cref="ClientOptions.Timeout" />
    TimeSpan? Timeout { get; init; }

    string? ApiKey { get; init; }

    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    INpsClientWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    INpsClient WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IActivityService Activities { get; }

    IAlertService Alerts { get; }

    IAmenityService Amenities { get; }

    IArticleService Articles { get; }

    ICampgroundService Campgrounds { get; }

    IEventService Events { get; }

    IFeespassService Feespasses { get; }

    ILessonplanService Lessonplans { get; }

    IMapService Maps { get; }

    IMultimediaService Multimedia { get; }

    INewsReleaseService NewsReleases { get; }

    IParkingLotService ParkingLots { get; }

    IParkService Parks { get; }

    IPassportStampLocationService PassportStampLocations { get; }

    IPersonService People { get; }

    IPlaceService Places { get; }

    IRoadEventService RoadEvents { get; }

    IThingsTodoService ThingsTodo { get; }

    ITopicService Topics { get; }

    ITourService Tours { get; }

    IVisitorCenterService VisitorCenters { get; }

    IWebcamService Webcams { get; }
}

/// <summary>
/// A view of <see cref="INpsClient"/> that provides access to raw HTTP responses for each method.
/// </summary>
public interface INpsClientWithRawResponse : IDisposable
{
    /// <inheritdoc cref="ClientOptions.HttpClient" />
    HttpClient HttpClient { get; init; }

    /// <inheritdoc cref="ClientOptions.BaseUrl" />
    string BaseUrl { get; init; }

    /// <inheritdoc cref="ClientOptions.ResponseValidation" />
    bool ResponseValidation { get; init; }

    /// <inheritdoc cref="ClientOptions.MaxRetries" />
    int? MaxRetries { get; init; }

    /// <inheritdoc cref="ClientOptions.Timeout" />
    TimeSpan? Timeout { get; init; }

    string? ApiKey { get; init; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    INpsClientWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IActivityServiceWithRawResponse Activities { get; }

    IAlertServiceWithRawResponse Alerts { get; }

    IAmenityServiceWithRawResponse Amenities { get; }

    IArticleServiceWithRawResponse Articles { get; }

    ICampgroundServiceWithRawResponse Campgrounds { get; }

    IEventServiceWithRawResponse Events { get; }

    IFeespassServiceWithRawResponse Feespasses { get; }

    ILessonplanServiceWithRawResponse Lessonplans { get; }

    IMapServiceWithRawResponse Maps { get; }

    IMultimediaServiceWithRawResponse Multimedia { get; }

    INewsReleaseServiceWithRawResponse NewsReleases { get; }

    IParkingLotServiceWithRawResponse ParkingLots { get; }

    IParkServiceWithRawResponse Parks { get; }

    IPassportStampLocationServiceWithRawResponse PassportStampLocations { get; }

    IPersonServiceWithRawResponse People { get; }

    IPlaceServiceWithRawResponse Places { get; }

    IRoadEventServiceWithRawResponse RoadEvents { get; }

    IThingsTodoServiceWithRawResponse ThingsTodo { get; }

    ITopicServiceWithRawResponse Topics { get; }

    ITourServiceWithRawResponse Tours { get; }

    IVisitorCenterServiceWithRawResponse VisitorCenters { get; }

    IWebcamServiceWithRawResponse Webcams { get; }

    /// <summary>
    /// Sends a request to the Nps REST API.
    /// </summary>
    Task<HttpResponse> Execute<T>(
        HttpRequest<T> request,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase;
}
