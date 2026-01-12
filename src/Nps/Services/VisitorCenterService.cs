using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.VisitorCenters;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class VisitorCenterService : IVisitorCenterService
{
    readonly Lazy<IVisitorCenterServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IVisitorCenterServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IVisitorCenterService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new VisitorCenterService(this._client.WithOptions(modifier));
    }

    public VisitorCenterService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new VisitorCenterServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<VisitorCenterListResponse> List(
        VisitorCenterListParams? parameters = null,
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
public sealed class VisitorCenterServiceWithRawResponse : IVisitorCenterServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IVisitorCenterServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new VisitorCenterServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public VisitorCenterServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<VisitorCenterListResponse>> List(
        VisitorCenterListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<VisitorCenterListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var visitorCenters = await response
                    .Deserialize<VisitorCenterListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    visitorCenters.Validate();
                }
                return visitorCenters;
            }
        );
    }
}
