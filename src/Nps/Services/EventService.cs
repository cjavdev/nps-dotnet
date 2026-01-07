using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Events;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class EventService : IEventService
{
    /// <inheritdoc/>
    public IEventService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new EventService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public EventService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<EventListResponse>> List(
        EventListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<EventListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var events = await response
            .Deserialize<List<EventListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in events)
            {
                item.Validate();
            }
        }
        return events;
    }
}
