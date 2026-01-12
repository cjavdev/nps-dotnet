using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Feespasses;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class FeespassService : IFeespassService
{
    readonly Lazy<IFeespassServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IFeespassServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IFeespassService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new FeespassService(this._client.WithOptions(modifier));
    }

    public FeespassService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new FeespassServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<FeespassListResponse> List(
        FeespassListParams? parameters = null,
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
public sealed class FeespassServiceWithRawResponse : IFeespassServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IFeespassServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new FeespassServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public FeespassServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<FeespassListResponse>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var feespasses = await response
                    .Deserialize<FeespassListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    feespasses.Validate();
                }
                return feespasses;
            }
        );
    }
}
