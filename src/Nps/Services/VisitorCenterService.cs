using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.VisitorCenters;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class VisitorCenterService : IVisitorCenterService
{
    /// <inheritdoc/>
    public IVisitorCenterService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new VisitorCenterService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public VisitorCenterService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<VisitorCenterListResponse>> List(
        VisitorCenterListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<VisitorCenterListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var visitorCenters = await response
            .Deserialize<List<VisitorCenterListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in visitorCenters)
            {
                item.Validate();
            }
        }
        return visitorCenters;
    }
}
