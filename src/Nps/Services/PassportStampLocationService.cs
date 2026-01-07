using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.PassportStampLocations;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class PassportStampLocationService : IPassportStampLocationService
{
    /// <inheritdoc/>
    public IPassportStampLocationService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PassportStampLocationService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public PassportStampLocationService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<PassportStampLocationListResponse>> List(
        PassportStampLocationListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<PassportStampLocationListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var passportStampLocations = await response
            .Deserialize<List<PassportStampLocationListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in passportStampLocations)
            {
                item.Validate();
            }
        }
        return passportStampLocations;
    }
}
