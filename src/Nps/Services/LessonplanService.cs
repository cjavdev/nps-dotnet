using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Lessonplans;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class LessonplanService : ILessonplanService
{
    /// <inheritdoc/>
    public ILessonplanService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new LessonplanService(this._client.WithOptions(modifier));
    }

    readonly INpsClient _client;

    public LessonplanService(INpsClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<List<LessonplanListResponse>> List(
        LessonplanListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<LessonplanListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var lessonplans = await response
            .Deserialize<List<LessonplanListResponse>>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            foreach (var item in lessonplans)
            {
                item.Validate();
            }
        }
        return lessonplans;
    }
}
