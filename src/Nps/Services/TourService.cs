using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Tours;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class TourService : ITourService
{
    readonly Lazy<ITourServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ITourServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public ITourService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TourService(this._client.WithOptions(modifier));
    }

    public TourService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new TourServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<TourListResponse> List(
        TourListParams? parameters = null,
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
public sealed class TourServiceWithRawResponse : ITourServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public ITourServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TourServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public TourServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TourListResponse>> List(
        TourListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TourListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var tours = await response
                    .Deserialize<TourListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    tours.Validate();
                }
                return tours;
            }
        );
    }
}
