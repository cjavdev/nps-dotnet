using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Webcams;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class WebcamService : IWebcamService
{
    readonly Lazy<IWebcamServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IWebcamServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IWebcamService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WebcamService(this._client.WithOptions(modifier));
    }

    public WebcamService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new WebcamServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<WebcamListPage> List(
        WebcamListParams? parameters = null,
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
public sealed class WebcamServiceWithRawResponse : IWebcamServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IWebcamServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WebcamServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public WebcamServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WebcamListPage>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<WebcamListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new WebcamListPage(this, parameters, page);
            }
        );
    }
}
