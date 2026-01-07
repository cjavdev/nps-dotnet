using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Parks;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ParkService : IParkService
{
    /// <inheritdoc/>
    public IParkService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ParkService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public ParkService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<ParkListResponse>> List(
        ParkListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ParkListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var parks = await response
            .Deserialize<List<ParkListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in parks)
            {
                item.Validate();
            }
        }
        return parks;
    }
}
