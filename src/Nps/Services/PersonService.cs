using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.People;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class PersonService : IPersonService
{
    readonly Lazy<IPersonServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IPersonServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public IPersonService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PersonService(this._client.WithOptions(modifier));
    }

    public PersonService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new PersonServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<PersonListPage> List(
        PersonListParams? parameters = null,
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
public sealed class PersonServiceWithRawResponse : IPersonServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public IPersonServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PersonServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public PersonServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PersonListPage>> List(
        PersonListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<PersonListParams> request = new()
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
                    .Deserialize<PersonListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new PersonListPage(this, parameters, page);
            }
        );
    }
}
