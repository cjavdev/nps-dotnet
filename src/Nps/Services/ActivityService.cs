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
    /// <inheritdoc/>
    public IActivityService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ActivityService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public ActivityService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<ActivityListResponse>> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var activities = await response
            .Deserialize<List<ActivityListResponse>>(cancellationToken)
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

    /// <inheritdoc/>
    public async Task<List<ActivityListParksResponse>> ListParks(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var deserializedResponse = await response
            .Deserialize<List<ActivityListParksResponse>>(cancellationToken)
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
