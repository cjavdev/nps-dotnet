using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Places;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class PlaceService : IPlaceService
{
    readonly Lazy<IPlaceServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IPlaceServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IPlaceService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PlaceService(this._client.WithOptions(modifier));
    }

    public PlaceService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new PlaceServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<PlaceListPage> List(
        PlaceListParams? parameters = null,
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
public sealed class PlaceServiceWithRawResponse : IPlaceServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IPlaceServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PlaceServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public PlaceServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PlaceListPage>> List(
        PlaceListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<PlaceListParams> request = new()
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
                    .Deserialize<PlaceListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new PlaceListPage(this, parameters, page);
            }
        );
    }
}
