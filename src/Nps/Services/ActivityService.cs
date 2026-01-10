using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Activities;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ActivityService : IActivityService
{
    readonly Lazy<IActivityServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IActivityServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IActivityService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ActivityService(this._client.WithOptions(modifier));
    }

    public ActivityService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ActivityServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<ActivityListResponse>> List(
        ActivityListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<List<ActivityListParksResponse>> ListParks(
        ActivityListParksParams? parameters = null,
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
public sealed class ActivityServiceWithRawResponse : IActivityServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IActivityServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ActivityServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ActivityServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<ActivityListResponse>>> List(
        ActivityListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ActivityListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var activities = await response
                    .Deserialize<List<ActivityListResponse>>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    foreach (var item in activities)
                    {
                        item.Validate();
                    }
                }
                return activities;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<ActivityListParksResponse>>> ListParks(
        ActivityListParksParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ActivityListParksParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<List<ActivityListParksResponse>>(token)
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
        );
    }
}
