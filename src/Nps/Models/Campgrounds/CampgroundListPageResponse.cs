using System.Collections.Frozen;
using System.Collections.Generic;
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
            return JsonModel.GetNullableClass<List<CampgroundListResponse>>(this.RawData, "data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data", value);
        }
    }

    public double? Limit
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public double? Start
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public double? Total
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "total"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "total", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CampgroundListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
