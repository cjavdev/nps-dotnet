using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Alerts;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class AlertService : IAlertService
{
    /// <inheritdoc/>
    public IAlertService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AlertService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public AlertService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<AlertListResponse>> List(
        AlertListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AlertListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var alerts = await response
            .Deserialize<List<AlertListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in alerts)
            {
                item.Validate();
            }
        }
        return alerts;
    }
}
