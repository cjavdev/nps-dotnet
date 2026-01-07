using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.ThingsTodo;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ThingsTodoService : IThingsTodoService
{
    /// <inheritdoc/>
    public IThingsTodoService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ThingsTodoService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public ThingsTodoService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<ThingsTodoListResponse>> List(
        ThingsTodoListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ThingsTodoListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var thingsTodos = await response
            .Deserialize<List<ThingsTodoListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in thingsTodos)
            {
                item.Validate();
            }
        }
        return thingsTodos;
    }
}
