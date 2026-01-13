using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.RoadEvents;

[JsonConverter(
    typeof(JsonModelConverter<RoadEventListPageResponse, RoadEventListPageResponseFromRaw>)
)]
public sealed record class RoadEventListPageResponse : JsonModel
{
    public IReadOnlyList<RoadEventListResponse>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<RoadEventListResponse>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<RoadEventListResponse>?>(
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

    public RoadEventListPageResponse() { }

    public RoadEventListPageResponse(RoadEventListPageResponse roadEventListPageResponse)
        : base(roadEventListPageResponse) { }

    public RoadEventListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RoadEventListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RoadEventListPageResponseFromRaw.FromRawUnchecked"/>
    public static RoadEventListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RoadEventListPageResponseFromRaw : IFromRawJson<RoadEventListPageResponse>
{
    /// <inheritdoc/>
    public RoadEventListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RoadEventListPageResponse.FromRawUnchecked(rawData);
}
