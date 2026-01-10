using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.ThingsTodo;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class ThingsTodoService : IThingsTodoService
{
    readonly Lazy<IThingsTodoServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IThingsTodoServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IThingsTodoService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ThingsTodoService(this._client.WithOptions(modifier));
    }

    public ThingsTodoService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ThingsTodoServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<List<ThingsTodoListResponse>> List(
        ThingsTodoListParams? parameters = null,
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
public sealed class ThingsTodoServiceWithRawResponse : IThingsTodoServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IThingsTodoServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new ThingsTodoServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ThingsTodoServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<List<ThingsTodoListResponse>>> List(
        ThingsTodoListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ThingsTodoListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var thingsTodos = await response
                    .Deserialize<List<ThingsTodoListResponse>>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    foreach (var item in thingsTodos)
                    {
                        item.Validate();
                    }
                }
                return thingsTodos;
            }
        );
    }
}
