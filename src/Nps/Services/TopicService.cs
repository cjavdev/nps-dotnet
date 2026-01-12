using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Topics;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class TopicService : ITopicService
{
    readonly Lazy<ITopicServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ITopicServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public ITopicService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TopicService(this._client.WithOptions(modifier));
    }

    public TopicService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new TopicServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<TopicListPage> List(
        TopicListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<TopicListParksPage> ListParks(
        TopicListParksParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.ListParks(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class TopicServiceWithRawResponse : ITopicServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public ITopicServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TopicServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public TopicServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TopicListPage>> List(
        TopicListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TopicListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<TopicListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new TopicListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TopicListParksPage>> ListParks(
        TopicListParksParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TopicListParksParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<TopicListParksPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new TopicListParksPage(this, parameters, page);
            }
        );
    }
}
