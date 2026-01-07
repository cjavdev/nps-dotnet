using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Campgrounds;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class CampgroundService : ICampgroundService
{
    /// <inheritdoc/>
    public ICampgroundService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new CampgroundService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public CampgroundService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<CampgroundListResponse>> List(
        CampgroundListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<CampgroundListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var campgrounds = await response
            .Deserialize<List<CampgroundListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in campgrounds)
            {
                item.Validate();
            }
        }
        return campgrounds;
    }
}
