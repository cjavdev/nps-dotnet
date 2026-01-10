using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.RoadEvents;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class RoadEventService : IRoadEventService
{
    readonly Lazy<IRoadEventServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IRoadEventServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IRoadEventService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new RoadEventService(this._client.WithOptions(modifier));
    }

    public RoadEventService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new RoadEventServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<RoadEventListResponse>> List(
        RoadEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class RoadEventServiceWithRawResponse : IRoadEventServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IRoadEventServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new RoadEventServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public RoadEventServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<RoadEventListResponse>>> List(
        RoadEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<RoadEventListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var roadEvents = await response
                    .Deserialize<List<RoadEventListResponse>>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    foreach (var item in roadEvents)
                    {
                        item.Validate();
                    }
                }
                return roadEvents;
            }
        );
    }
}
