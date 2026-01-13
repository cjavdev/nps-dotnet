using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.ParkingLots;

[JsonConverter(
    typeof(JsonModelConverter<ParkingLotListPageResponse, ParkingLotListPageResponseFromRaw>)
)]
public sealed record class ParkingLotListPageResponse : JsonModel
{
    public IReadOnlyList<ParkingLotListResponse>? Data
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<ParkingLotListResponse>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ParkingLotListResponse>?>(
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

    public ParkingLotListPageResponse() { }

    public ParkingLotListPageResponse(ParkingLotListPageResponse parkingLotListPageResponse)
        : base(parkingLotListPageResponse) { }

    public ParkingLotListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ParkingLotListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ParkingLotListPageResponseFromRaw.FromRawUnchecked"/>
    public static ParkingLotListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ParkingLotListPageResponseFromRaw : IFromRawJson<ParkingLotListPageResponse>
{
    /// <inheritdoc/>
    public ParkingLotListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ParkingLotListPageResponse.FromRawUnchecked(rawData);
}
