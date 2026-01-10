using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Exceptions;
using Nps.Services;

namespace Nps;

/// <inheritdoc/>
public sealed class NpsClient : INpsClient
{
    readonly ClientOptions _options;

    /// <inheritdoc/>
    public HttpClient HttpClient
    {
        get { return this._options.HttpClient; }
        init { this._options.HttpClient = value; }
    }

    /// <inheritdoc/>
    public string BaseUrl
    {
        get { return this._options.BaseUrl; }
        init { this._options.BaseUrl = value; }
    }

    /// <inheritdoc/>
    public bool ResponseValidation
    {
        get { return this._options.ResponseValidation; }
        init { this._options.ResponseValidation = value; }
    }

    /// <inheritdoc/>
    public int? MaxRetries
    {
        get { return this._options.MaxRetries; }
        init { this._options.MaxRetries = value; }
    }

    /// <inheritdoc/>
    public TimeSpan? Timeout
    {
        get { return this._options.Timeout; }
        init { this._options.Timeout = value; }
    }

    /// <inheritdoc/>
    public string? ApiKey
    {
        get { return this._options.ApiKey; }
        init { this._options.ApiKey = value; }
    }

    readonly Lazy<INpsClientWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public INpsClientWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    /// <inheritdoc/>
    public INpsClient WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new NpsClient(modifier(this._options));
    }

    readonly Lazy<IActivityService> _activities;
    public IActivityService Activities
    {
        get { return _activities.Value; }
    }

    readonly Lazy<IAlertService> _alerts;
    public IAlertService Alerts
    {
        get { return _alerts.Value; }
    }

    readonly Lazy<IAmenityService> _amenities;
    public IAmenityService Amenities
    {
        get { return _amenities.Value; }
    }

    readonly Lazy<IArticleService> _articles;
    public IArticleService Articles
    {
        get { return _articles.Value; }
    }

    readonly Lazy<ICampgroundService> _campgrounds;
    public ICampgroundService Campgrounds
    {
        get { return _campgrounds.Value; }
    }

    readonly Lazy<IEventService> _events;
    public IEventService Events
    {
        get { return _events.Value; }
    }

    readonly Lazy<IFeespassService> _feespasses;
    public IFeespassService Feespasses
    {
        get { return _feespasses.Value; }
    }

    readonly Lazy<ILessonplanService> _lessonplans;
    public ILessonplanService Lessonplans
    {
        get { return _lessonplans.Value; }
    }

    readonly Lazy<IMapService> _maps;
    public IMapService Maps
    {
        get { return _maps.Value; }
    }

    readonly Lazy<IMultimediaService> _multimedia;
    public IMultimediaService Multimedia
    {
        get { return _multimedia.Value; }
    }

    readonly Lazy<INewsReleaseService> _newsReleases;
    public INewsReleaseService NewsReleases
    {
        get { return _newsReleases.Value; }
    }

    readonly Lazy<IParkingLotService> _parkingLots;
    public IParkingLotService ParkingLots
    {
        get { return _parkingLots.Value; }
    }

    readonly Lazy<IParkService> _parks;
    public IParkService Parks
    {
        get { return _parks.Value; }
    }

    readonly Lazy<IPassportStampLocationService> _passportStampLocations;
    public IPassportStampLocationService PassportStampLocations
    {
        get { return _passportStampLocations.Value; }
    }

    readonly Lazy<IPersonService> _people;
    public IPersonService People
    {
        get { return _people.Value; }
    }

    readonly Lazy<IPlaceService> _places;
    public IPlaceService Places
    {
        get { return _places.Value; }
    }

    readonly Lazy<IRoadEventService> _roadEvents;
    public IRoadEventService RoadEvents
    {
        get { return _roadEvents.Value; }
    }

    readonly Lazy<IThingsTodoService> _thingsTodo;
    public IThingsTodoService ThingsTodo
    {
        get { return _thingsTodo.Value; }
    }

    readonly Lazy<ITopicService> _topics;
    public ITopicService Topics
    {
        get { return _topics.Value; }
    }

    readonly Lazy<ITourService> _tours;
    public ITourService Tours
    {
        get { return _tours.Value; }
    }

    readonly Lazy<IVisitorCenterService> _visitorCenters;
    public IVisitorCenterService VisitorCenters
    {
        get { return _visitorCenters.Value; }
    }

    readonly Lazy<IWebcamService> _webcams;
    public IWebcamService Webcams
    {
        get { return _webcams.Value; }
    }

    public void Dispose() => this.HttpClient.Dispose();

    public NpsClient()
    {
        _options = new();

        _withRawResponse = new(() => new NpsClientWithRawResponse(this._options));
        _activities = new(() => new ActivityService(this));
        _alerts = new(() => new AlertService(this));
        _amenities = new(() => new AmenityService(this));
        _articles = new(() => new ArticleService(this));
        _campgrounds = new(() => new CampgroundService(this));
        _events = new(() => new EventService(this));
        _feespasses = new(() => new FeespassService(this));
        _lessonplans = new(() => new LessonplanService(this));
        _maps = new(() => new MapService(this));
        _multimedia = new(() => new MultimediaService(this));
        _newsReleases = new(() => new NewsReleaseService(this));
        _parkingLots = new(() => new ParkingLotService(this));
        _parks = new(() => new ParkService(this));
        _passportStampLocations = new(() => new PassportStampLocationService(this));
        _people = new(() => new PersonService(this));
        _places = new(() => new PlaceService(this));
        _roadEvents = new(() => new RoadEventService(this));
        _thingsTodo = new(() => new ThingsTodoService(this));
        _topics = new(() => new TopicService(this));
        _tours = new(() => new TourService(this));
        _visitorCenters = new(() => new VisitorCenterService(this));
        _webcams = new(() => new WebcamService(this));
    }

    public NpsClient(ClientOptions options)
        : this()
    {
        _options = options;
    }
}

/// <inheritdoc/>
public sealed class NpsClientWithRawResponse : INpsClientWithRawResponse
{
#if NET
    static readonly Random Random = Random.Shared;
#else
    static readonly ThreadLocal<Random> _threadLocalRandom = new(() => new Random());

    static Random Random
    {
        get { return _threadLocalRandom.Value!; }
    }
#endif

    readonly ClientOptions _options;

    /// <inheritdoc/>
    public HttpClient HttpClient
    {
        get { return this._options.HttpClient; }
        init { this._options.HttpClient = value; }
    }

    /// <inheritdoc/>
    public string BaseUrl
    {
        get { return this._options.BaseUrl; }
        init { this._options.BaseUrl = value; }
    }

    /// <inheritdoc/>
    public bool ResponseValidation
    {
        get { return this._options.ResponseValidation; }
        init { this._options.ResponseValidation = value; }
    }

    /// <inheritdoc/>
    public int? MaxRetries
    {
        get { return this._options.MaxRetries; }
        init { this._options.MaxRetries = value; }
    }

    /// <inheritdoc/>
    public TimeSpan? Timeout
    {
        get { return this._options.Timeout; }
        init { this._options.Timeout = value; }
    }

    /// <inheritdoc/>
    public string? ApiKey
    {
        get { return this._options.ApiKey; }
        init { this._options.ApiKey = value; }
    }

    /// <inheritdoc/>
    public INpsClientWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new NpsClientWithRawResponse(modifier(this._options));
    }

    readonly Lazy<IActivityServiceWithRawResponse> _activities;
    public IActivityServiceWithRawResponse Activities
    {
        get { return _activities.Value; }
    }

    readonly Lazy<IAlertServiceWithRawResponse> _alerts;
    public IAlertServiceWithRawResponse Alerts
    {
        get { return _alerts.Value; }
    }

    readonly Lazy<IAmenityServiceWithRawResponse> _amenities;
    public IAmenityServiceWithRawResponse Amenities
    {
        get { return _amenities.Value; }
    }

    readonly Lazy<IArticleServiceWithRawResponse> _articles;
    public IArticleServiceWithRawResponse Articles
    {
        get { return _articles.Value; }
    }

    readonly Lazy<ICampgroundServiceWithRawResponse> _campgrounds;
    public ICampgroundServiceWithRawResponse Campgrounds
    {
        get { return _campgrounds.Value; }
    }

    readonly Lazy<IEventServiceWithRawResponse> _events;
    public IEventServiceWithRawResponse Events
    {
        get { return _events.Value; }
    }

    readonly Lazy<IFeespassServiceWithRawResponse> _feespasses;
    public IFeespassServiceWithRawResponse Feespasses
    {
        get { return _feespasses.Value; }
    }

    readonly Lazy<ILessonplanServiceWithRawResponse> _lessonplans;
    public ILessonplanServiceWithRawResponse Lessonplans
    {
        get { return _lessonplans.Value; }
    }

    readonly Lazy<IMapServiceWithRawResponse> _maps;
    public IMapServiceWithRawResponse Maps
    {
        get { return _maps.Value; }
    }

    readonly Lazy<IMultimediaServiceWithRawResponse> _multimedia;
    public IMultimediaServiceWithRawResponse Multimedia
    {
        get { return _multimedia.Value; }
    }

    readonly Lazy<INewsReleaseServiceWithRawResponse> _newsReleases;
    public INewsReleaseServiceWithRawResponse NewsReleases
    {
        get { return _newsReleases.Value; }
    }

    readonly Lazy<IParkingLotServiceWithRawResponse> _parkingLots;
    public IParkingLotServiceWithRawResponse ParkingLots
    {
        get { return _parkingLots.Value; }
    }

    readonly Lazy<IParkServiceWithRawResponse> _parks;
    public IParkServiceWithRawResponse Parks
    {
        get { return _parks.Value; }
    }

    readonly Lazy<IPassportStampLocationServiceWithRawResponse> _passportStampLocations;
    public IPassportStampLocationServiceWithRawResponse PassportStampLocations
    {
        get { return _passportStampLocations.Value; }
    }

    readonly Lazy<IPersonServiceWithRawResponse> _people;
    public IPersonServiceWithRawResponse People
    {
        get { return _people.Value; }
    }

    readonly Lazy<IPlaceServiceWithRawResponse> _places;
    public IPlaceServiceWithRawResponse Places
    {
        get { return _places.Value; }
    }

    readonly Lazy<IRoadEventServiceWithRawResponse> _roadEvents;
    public IRoadEventServiceWithRawResponse RoadEvents
    {
        get { return _roadEvents.Value; }
    }

    readonly Lazy<IThingsTodoServiceWithRawResponse> _thingsTodo;
    public IThingsTodoServiceWithRawResponse ThingsTodo
    {
        get { return _thingsTodo.Value; }
    }

    readonly Lazy<ITopicServiceWithRawResponse> _topics;
    public ITopicServiceWithRawResponse Topics
    {
        get { return _topics.Value; }
    }

    readonly Lazy<ITourServiceWithRawResponse> _tours;
    public ITourServiceWithRawResponse Tours
    {
        get { return _tours.Value; }
    }

    readonly Lazy<IVisitorCenterServiceWithRawResponse> _visitorCenters;
    public IVisitorCenterServiceWithRawResponse VisitorCenters
    {
        get { return _visitorCenters.Value; }
    }

    readonly Lazy<IWebcamServiceWithRawResponse> _webcams;
    public IWebcamServiceWithRawResponse Webcams
    {
        get { return _webcams.Value; }
    }

    /// <inheritdoc/>
    public async Task<HttpResponse> Execute<T>(
        HttpRequest<T> request,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase
    {
        var maxRetries = this.MaxRetries ?? ClientOptions.DefaultMaxRetries;
        var retries = 0;
        while (true)
        {
            HttpResponse? response = null;
            try
            {
                response = await ExecuteOnce(request, retries, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                if (++retries > maxRetries || !ShouldRetry(e))
                {
                    throw;
                }
            }

            if (response != null && (++retries > maxRetries || !ShouldRetry(response)))
            {
                if (response.Message.IsSuccessStatusCode)
                {
                    return response;
                }

                try
                {
                    throw NpsExceptionFactory.CreateApiException(
                        response.Message.StatusCode,
                        await response.ReadAsString(cancellationToken).ConfigureAwait(false)
                    );
                }
                catch (HttpRequestException e)
                {
                    throw new NpsIOException("I/O Exception", e);
                }
                finally
                {
                    response.Dispose();
                }
            }

            var backoff = ComputeRetryBackoff(retries, response);
            response?.Dispose();
            await Task.Delay(backoff, cancellationToken).ConfigureAwait(false);
        }
    }

    async Task<HttpResponse> ExecuteOnce<T>(
        HttpRequest<T> request,
        int retryCount,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase
    {
        using HttpRequestMessage requestMessage = new(
            request.Method,
            request.Params.Url(this._options)
        )
        {
            Content = request.Params.BodyContent(),
        };
        request.Params.AddHeadersToRequest(requestMessage, this._options);
        if (!requestMessage.Headers.Contains("x-stainless-retry-count"))
        {
            requestMessage.Headers.Add("x-stainless-retry-count", retryCount.ToString());
        }
        using CancellationTokenSource timeoutCts = new(
            this.Timeout ?? ClientOptions.DefaultTimeout
        );
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(
            timeoutCts.Token,
            cancellationToken
        );
        HttpResponseMessage responseMessage;
        try
        {
            responseMessage = await this
                .HttpClient.SendAsync(
                    requestMessage,
                    HttpCompletionOption.ResponseHeadersRead,
                    cts.Token
                )
                .ConfigureAwait(false);
        }
        catch (HttpRequestException e)
        {
            throw new NpsIOException("I/O exception", e);
        }
        return new() { Message = responseMessage, CancellationToken = cts.Token };
    }

    static TimeSpan ComputeRetryBackoff(int retries, HttpResponse? response)
    {
        TimeSpan? apiBackoff = ParseRetryAfterMsHeader(response) ?? ParseRetryAfterHeader(response);
        if (apiBackoff != null && apiBackoff < TimeSpan.FromMinutes(1))
        {
            // If the API asks us to wait a certain amount of time (and it's a reasonable amount), then just
            // do what it says.
            return (TimeSpan)apiBackoff;
        }

        // Apply exponential backoff, but not more than the max.
        var backoffSeconds = Math.Min(0.5 * Math.Pow(2.0, retries - 1), 8.0);
        var jitter = 1.0 - 0.25 * Random.NextDouble();
        return TimeSpan.FromSeconds(backoffSeconds * jitter);
    }

    static TimeSpan? ParseRetryAfterMsHeader(HttpResponse? response)
    {
        IEnumerable<string>? headerValues = null;
        response?.Message.Headers.TryGetValues("Retry-After-Ms", out headerValues);
        var headerValue = headerValues == null ? null : Enumerable.FirstOrDefault(headerValues);
        if (headerValue == null)
        {
            return null;
        }

        if (float.TryParse(headerValue, out var retryAfterMs))
        {
            return TimeSpan.FromMilliseconds(retryAfterMs);
        }

        return null;
    }

    static TimeSpan? ParseRetryAfterHeader(HttpResponse? response)
    {
        IEnumerable<string>? headerValues = null;
        response?.Message.Headers.TryGetValues("Retry-After", out headerValues);
        var headerValue = headerValues == null ? null : Enumerable.FirstOrDefault(headerValues);
        if (headerValue == null)
        {
            return null;
        }

        if (float.TryParse(headerValue, out var retryAfterSeconds))
        {
            return TimeSpan.FromSeconds(retryAfterSeconds);
        }
        else if (DateTimeOffset.TryParse(headerValue, out var retryAfterDate))
        {
            return retryAfterDate - DateTimeOffset.Now;
        }

        return null;
    }

    static bool ShouldRetry(HttpResponse response)
    {
        if (
            response.Message.Headers.TryGetValues("X-Should-Retry", out var headerValues)
            && bool.TryParse(Enumerable.FirstOrDefault(headerValues), out var shouldRetry)
        )
        {
            // If the server explicitly says whether to retry, then we obey.
            return shouldRetry;
        }

        return (int)response.Message.StatusCode switch
        {
            // Retry on request timeouts
            408
            or
            // Retry on lock timeouts
            409
            or
            // Retry on rate limits
            429
            or
            // Retry internal errors
            >= 500 => true,
            _ => false,
        };
    }

    static bool ShouldRetry(Exception e)
    {
        return e is IOException || e is NpsIOException;
    }

    public void Dispose() => this.HttpClient.Dispose();

    public NpsClientWithRawResponse()
    {
        _options = new();

        _activities = new(() => new ActivityServiceWithRawResponse(this));
        _alerts = new(() => new AlertServiceWithRawResponse(this));
        _amenities = new(() => new AmenityServiceWithRawResponse(this));
        _articles = new(() => new ArticleServiceWithRawResponse(this));
        _campgrounds = new(() => new CampgroundServiceWithRawResponse(this));
        _events = new(() => new EventServiceWithRawResponse(this));
        _feespasses = new(() => new FeespassServiceWithRawResponse(this));
        _lessonplans = new(() => new LessonplanServiceWithRawResponse(this));
        _maps = new(() => new MapServiceWithRawResponse(this));
        _multimedia = new(() => new MultimediaServiceWithRawResponse(this));
        _newsReleases = new(() => new NewsReleaseServiceWithRawResponse(this));
        _parkingLots = new(() => new ParkingLotServiceWithRawResponse(this));
        _parks = new(() => new ParkServiceWithRawResponse(this));
        _passportStampLocations = new(() => new PassportStampLocationServiceWithRawResponse(this));
        _people = new(() => new PersonServiceWithRawResponse(this));
        _places = new(() => new PlaceServiceWithRawResponse(this));
        _roadEvents = new(() => new RoadEventServiceWithRawResponse(this));
        _thingsTodo = new(() => new ThingsTodoServiceWithRawResponse(this));
        _topics = new(() => new TopicServiceWithRawResponse(this));
        _tours = new(() => new TourServiceWithRawResponse(this));
        _visitorCenters = new(() => new VisitorCenterServiceWithRawResponse(this));
        _webcams = new(() => new WebcamServiceWithRawResponse(this));
    }

    public NpsClientWithRawResponse(ClientOptions options)
        : this()
    {
        _options = options;
    }
}
