using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Thingstodo;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ThingstodoService : IThingstodoService
{
    /// <inheritdoc/>
    public IThingstodoService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ThingstodoService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public ThingstodoService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<ThingstodoListResponse>> List(
        ThingstodoListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ThingstodoListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var thingstodos = await response
            .Deserialize<List<ThingstodoListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in thingstodos)
            {
                item.Validate();
            }
        }
        return thingstodos;
    }
}
