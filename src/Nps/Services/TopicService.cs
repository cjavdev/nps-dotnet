using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Topics;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class TopicService : ITopicService
{
    /// <inheritdoc/>
    public ITopicService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TopicService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public TopicService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<TopicListResponse>> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var topics = await response
            .Deserialize<List<TopicListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in topics)
            {
                item.Validate();
            }
        }
        return topics;
    }

    /// <inheritdoc/>
    public async Task<List<TopicRetrieveParksResponse>> RetrieveParks(
        TopicRetrieveParksParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TopicRetrieveParksParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<TopicRetrieveParksResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in deserializedResponse)
            {
                item.Validate();
            }
        }
        return deserializedResponse;
    }
}
