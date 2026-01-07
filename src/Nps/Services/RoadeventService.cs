using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Roadevents;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class RoadeventService : IRoadeventService
{
    /// <inheritdoc/>
    public IRoadeventService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new RoadeventService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public RoadeventService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<RoadeventListResponse>> List(
        RoadeventListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<RoadeventListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var roadevents = await response
            .Deserialize<List<RoadeventListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in roadevents)
            {
                item.Validate();
            }
        }
        return roadevents;
    }
}
