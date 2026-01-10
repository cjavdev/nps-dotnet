using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.PassportStampLocations;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class PassportStampLocationService : IPassportStampLocationService
{
    readonly Lazy<IPassportStampLocationServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IPassportStampLocationServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IPassportStampLocationService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PassportStampLocationService(this._client.WithOptions(modifier));
    }

    public PassportStampLocationService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new PassportStampLocationServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<List<PassportStampLocationListResponse>> List(
        PassportStampLocationListParams? parameters = null,
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
public sealed class PassportStampLocationServiceWithRawResponse
    : IPassportStampLocationServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IPassportStampLocationServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new PassportStampLocationServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public PassportStampLocationServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<PassportStampLocationListResponse>>> List(
        PassportStampLocationListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<PassportStampLocationListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var passportStampLocations = await response
                    .Deserialize<List<PassportStampLocationListResponse>>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    foreach (var item in passportStampLocations)
                    {
                        item.Validate();
                    }
                }
                return passportStampLocations;
            }
        );
    }
}
