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
    readonly Lazy<ICampgroundServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ICampgroundServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public ICampgroundService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new CampgroundService(this._client.WithOptions(modifier));
    }

    public CampgroundService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new CampgroundServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<CampgroundListResponse>> List(
        CampgroundListParams? parameters = null,
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
public sealed class CampgroundServiceWithRawResponse : ICampgroundServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public ICampgroundServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new CampgroundServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public CampgroundServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<CampgroundListResponse>>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var campgrounds = await response
                    .Deserialize<List<CampgroundListResponse>>(token)
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
        );
    }
}
