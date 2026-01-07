using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.People;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class PersonService : IPersonService
{
    /// <inheritdoc/>
    public IPersonService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PersonService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public PersonService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<PersonListResponse>> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var people = await response
            .Deserialize<List<PersonListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in people)
            {
                item.Validate();
            }
        }
        return people;
    }
}
