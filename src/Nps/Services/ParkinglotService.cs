using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Parkinglots;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ParkinglotService : IParkinglotService
{
    /// <inheritdoc/>
    public IParkinglotService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ParkinglotService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public ParkinglotService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<ParkinglotListResponse>> List(
        ParkinglotListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ParkinglotListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var parkinglots = await response
            .Deserialize<List<ParkinglotListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in parkinglots)
            {
                item.Validate();
            }
        }
        return parkinglots;
    }
}
