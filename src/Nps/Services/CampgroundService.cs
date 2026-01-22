using System;
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

    readonly INationalParksClient _client;

    /// <inheritdoc/>
    public ICampgroundService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new CampgroundService(this._client.WithOptions(modifier));
    }

    public CampgroundService(INationalParksClient client)
    {
        _client = client;

        _withRawResponse = new(() => new CampgroundServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<CampgroundListPage> List(
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
    readonly INationalParksClientWithRawResponse _client;

    /// <inheritdoc/>
    public ICampgroundServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new CampgroundServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public CampgroundServiceWithRawResponse(INationalParksClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CampgroundListPage>> List(
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
                var page = await response
                    .Deserialize<CampgroundListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new CampgroundListPage(this, parameters, page);
            }
        );
    }
}
