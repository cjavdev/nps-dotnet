using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Visitorcenters;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class VisitorcenterService : IVisitorcenterService
{
    /// <inheritdoc/>
    public IVisitorcenterService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new VisitorcenterService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public VisitorcenterService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<VisitorcenterListResponse>> List(
        VisitorcenterListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<VisitorcenterListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var visitorcenters = await response
            .Deserialize<List<VisitorcenterListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in visitorcenters)
            {
                item.Validate();
            }
        }
        return visitorcenters;
    }
}
