using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Webcams;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class WebcamService : IWebcamService
{
    /// <inheritdoc/>
    public IWebcamService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WebcamService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public WebcamService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<WebcamListResponse>> List(
        WebcamListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<WebcamListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var webcams = await response
            .Deserialize<List<WebcamListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in webcams)
            {
                item.Validate();
            }
        }
        return webcams;
    }
}
