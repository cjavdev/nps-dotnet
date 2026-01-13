using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Amenities;

[JsonConverter(
    typeof(JsonModelConverter<
        AmenityListParksPlacesPageResponse,
        AmenityListParksPlacesPageResponseFromRaw
    >)
)]
public sealed record class AmenityListParksPlacesPageResponse : JsonModel
{
    public IReadOnlyList<AmenityListParksPlacesResponse>? Data
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<AmenityListParksPlacesResponse>>(
                "data"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<AmenityListParksPlacesResponse>?>(
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

    public AmenityListParksPlacesPageResponse() { }

    public AmenityListParksPlacesPageResponse(
        AmenityListParksPlacesPageResponse amenityListParksPlacesPageResponse
    )
        : base(amenityListParksPlacesPageResponse) { }

    public AmenityListParksPlacesPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksPlacesPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AmenityListParksPlacesPageResponseFromRaw.FromRawUnchecked"/>
    public static AmenityListParksPlacesPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AmenityListParksPlacesPageResponseFromRaw : IFromRawJson<AmenityListParksPlacesPageResponse>
{
    /// <inheritdoc/>
    public AmenityListParksPlacesPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AmenityListParksPlacesPageResponse.FromRawUnchecked(rawData);
}
