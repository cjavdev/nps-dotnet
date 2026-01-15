using System;
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
    public async Task<ActivityListPage> List(
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
    public async Task<ActivityListParksPage> ListParks(
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
    public async Task<HttpResponse<ActivityListPage>> List(
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
                var page = await response
                    .Deserialize<ActivityListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new ActivityListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ActivityListParksPage>> ListParks(
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
                var page = await response
                    .Deserialize<ActivityListParksPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new ActivityListParksPage(this, parameters, page);
            }
        );
    }
}
