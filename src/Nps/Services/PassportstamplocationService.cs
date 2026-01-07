using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Passportstamplocations;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class PassportstamplocationService : IPassportstamplocationService
{
    /// <inheritdoc/>
    public IPassportstamplocationService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PassportstamplocationService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public PassportstamplocationService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<PassportstamplocationListResponse>> List(
        PassportstamplocationListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<PassportstamplocationListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var passportstamplocations = await response
            .Deserialize<List<PassportstamplocationListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in passportstamplocations)
            {
                item.Validate();
            }
        }
        return passportstamplocations;
    }
}
