using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Campgrounds;

[JsonConverter(
    typeof(JsonModelConverter<CampgroundListPageResponse, CampgroundListPageResponseFromRaw>)
)]
public sealed record class CampgroundListPageResponse : JsonModel
{
    public IReadOnlyList<CampgroundListResponse>? Data
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<CampgroundListResponse>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<CampgroundListResponse>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? Limit
    {
        get { return this._rawData.GetNullableStruct<double>("limit"); }
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
        get { return this._rawData.GetNullableStruct<double>("start"); }
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
        get { return this._rawData.GetNullableStruct<double>("total"); }
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

    public CampgroundListPageResponse() { }

    public CampgroundListPageResponse(CampgroundListPageResponse campgroundListPageResponse)
        : base(campgroundListPageResponse) { }

    public CampgroundListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CampgroundListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CampgroundListPageResponseFromRaw.FromRawUnchecked"/>
    public static CampgroundListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CampgroundListPageResponseFromRaw : IFromRawJson<CampgroundListPageResponse>
{
    /// <inheritdoc/>
    public CampgroundListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CampgroundListPageResponse.FromRawUnchecked(rawData);
}
