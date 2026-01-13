using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Articles;

[JsonConverter(typeof(JsonModelConverter<ArticleListPageResponse, ArticleListPageResponseFromRaw>))]
public sealed record class ArticleListPageResponse : JsonModel
{
    public IReadOnlyList<ArticleListResponse>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<ArticleListResponse>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ArticleListResponse>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? Limit
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("limit");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("limit", value);
        }
    }

    public double? Start
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("start");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("start", value);
        }
    }

    public double? Total
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("total");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("total", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.Data ?? [])
        {
            item.Validate();
        }
        _ = this.Limit;
        _ = this.Start;
        _ = this.Total;
    }

    public ArticleListPageResponse() { }

    public ArticleListPageResponse(ArticleListPageResponse articleListPageResponse)
        : base(articleListPageResponse) { }

    public ArticleListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ArticleListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ArticleListPageResponseFromRaw.FromRawUnchecked"/>
    public static ArticleListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ArticleListPageResponseFromRaw : IFromRawJson<ArticleListPageResponse>
{
    /// <inheritdoc/>
    public ArticleListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ArticleListPageResponse.FromRawUnchecked(rawData);
}
