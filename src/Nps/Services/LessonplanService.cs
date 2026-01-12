using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.Lessonplans;

namespace Nps.Services;

/// <inheritdoc/>
public sealed class LessonplanService : ILessonplanService
{
    readonly Lazy<ILessonplanServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ILessonplanServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly INpsClient _client;

    /// <inheritdoc/>
    public ILessonplanService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new LessonplanService(this._client.WithOptions(modifier));
    }

    public LessonplanService(INpsClient client)
    {
        _client = client;

        _withRawResponse = new(() => new LessonplanServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<LessonplanListPage> List(
        LessonplanListParams? parameters = null,
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
public sealed class LessonplanServiceWithRawResponse : ILessonplanServiceWithRawResponse
{
    readonly INpsClientWithRawResponse _client;

    /// <inheritdoc/>
    public ILessonplanServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new LessonplanServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public LessonplanServiceWithRawResponse(INpsClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LessonplanListPage>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<LessonplanListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new LessonplanListPage(this, parameters, page);
            }
        );
    }
}
