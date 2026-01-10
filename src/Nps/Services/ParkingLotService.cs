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
    readonly Lazy<IParkingLotServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IParkingLotServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IParkingLotService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ParkingLotService(this._client.WithOptions(modifier));
    }

    public ParkingLotService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ParkingLotServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<ParkingLotListResponse>> List(
        ParkingLotListParams? parameters = null,
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
public sealed class ParkingLotServiceWithRawResponse : IParkingLotServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IParkingLotServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new ParkingLotServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ParkingLotServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<ParkingLotListResponse>>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var parkingLots = await response
                    .Deserialize<List<ParkingLotListResponse>>(token)
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
        );
    }
}
