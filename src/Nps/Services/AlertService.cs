using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Alerts;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class AlertService : IAlertService
{
    readonly Lazy<IAlertServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IAlertServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IAlertService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AlertService(this._client.WithOptions(modifier));
    }

    public AlertService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new AlertServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<AlertListPage> List(
        AlertListParams? parameters = null,
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
public sealed class AlertServiceWithRawResponse : IAlertServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IAlertServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AlertServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public AlertServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AlertListPage>> List(
        AlertListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AlertListParams> request = new()
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
                    .Deserialize<AlertListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new AlertListPage(this, parameters, page);
            }
        );
    }
}
