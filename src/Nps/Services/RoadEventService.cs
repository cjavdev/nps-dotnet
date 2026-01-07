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
    /// <inheritdoc/>
    public IRoadEventService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new RoadEventService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public RoadEventService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<RoadEventListResponse>> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var roadEvents = await response
            .Deserialize<List<RoadEventListResponse>>(cancellationToken)
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
}
