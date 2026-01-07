using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Feespasses;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class FeespassService : IFeespassService
{
    /// <inheritdoc/>
    public IFeespassService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new FeespassService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public FeespassService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<FeespassListResponse>> List(
        FeespassListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<FeespassListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var feespasses = await response
            .Deserialize<List<FeespassListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in feespasses)
            {
                item.Validate();
            }
        }
        return feespasses;
    }
}
