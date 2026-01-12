using System;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Topics;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ITopicService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ITopicServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITopicService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>get /topics<c/>.
    /// </summary>
    Task<TopicListResponse> List(
        TopicListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a request to <c>get /topics/parks<c/>.
    /// </summary>
    Task<TopicRetrieveParksResponse> RetrieveParks(
        TopicRetrieveParksParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ITopicService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ITopicServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITopicServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /topics`, but is otherwise the
    /// same as <see cref="ITopicService.List(TopicListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TopicListResponse>> List(
        TopicListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /topics/parks`, but is otherwise the
    /// same as <see cref="ITopicService.RetrieveParks(TopicRetrieveParksParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TopicRetrieveParksResponse>> RetrieveParks(
        TopicRetrieveParksParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
