using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Parks;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ParkService : IParkService
{
    readonly Lazy<IParkServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IParkServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IParkService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ParkService(this._client.WithOptions(modifier));
    }

    public ParkService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ParkServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<ParkListResponse> List(
        ParkListParams? parameters = null,
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
public sealed class ParkServiceWithRawResponse : IParkServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IParkServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ParkServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ParkServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ParkListResponse>> List(
        ParkListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ParkListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var parks = await response
                    .Deserialize<ParkListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    parks.Validate();
                }
                return parks;
            }
        );
    }
}
