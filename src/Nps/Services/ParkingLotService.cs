using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.ParkingLots;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ParkingLotService : IParkingLotService
{
    /// <inheritdoc/>
    public IParkingLotService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ParkingLotService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public ParkingLotService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<ParkingLotListResponse>> List(
        ParkingLotListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ParkingLotListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var parkingLots = await response
            .Deserialize<List<ParkingLotListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in parkingLots)
            {
                item.Validate();
            }
        }
        return parkingLots;
    }
}
