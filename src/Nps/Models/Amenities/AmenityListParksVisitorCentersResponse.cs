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
        AmenityListParksVisitorCentersResponse,
        AmenityListParksVisitorCentersResponseFromRaw
    >)
)]
public sealed record class AmenityListParksVisitorCentersResponse : JsonModel
{
    public IReadOnlyList<AmenityListParksVisitorCentersResponseData>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<AmenityListParksVisitorCentersResponseData>
            >("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<AmenityListParksVisitorCentersResponseData>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Limit
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("limit");
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

    public string? Start
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("start");
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

    public string? Total
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("total");
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

    public AmenityListParksVisitorCentersResponse() { }

    public AmenityListParksVisitorCentersResponse(
        AmenityListParksVisitorCentersResponse amenityListParksVisitorCentersResponse
    )
        : base(amenityListParksVisitorCentersResponse) { }

    public AmenityListParksVisitorCentersResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksVisitorCentersResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AmenityListParksVisitorCentersResponseFromRaw.FromRawUnchecked"/>
    public static AmenityListParksVisitorCentersResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AmenityListParksVisitorCentersResponseFromRaw
    : IFromRawJson<AmenityListParksVisitorCentersResponse>
{
    /// <inheritdoc/>
    public AmenityListParksVisitorCentersResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AmenityListParksVisitorCentersResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AmenityListParksVisitorCentersResponseData,
        AmenityListParksVisitorCentersResponseDataFromRaw
    >)
)]
public sealed record class AmenityListParksVisitorCentersResponseData : JsonModel
{
    /// <summary>
    /// Unique identifier for this amenity
    /// </summary>
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    /// <summary>
    /// The name for this amenity
    /// </summary>
    public string? Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name", value);
        }
    }

    public IReadOnlyList<AmenityListParksVisitorCentersResponseDataPark>? Parks
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<AmenityListParksVisitorCentersResponseDataPark>
            >("parks");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<AmenityListParksVisitorCentersResponseDataPark>?>(
                "parks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Name;
        foreach (var item in this.Parks ?? [])
        {
            item.Validate();
        }
    }

    public AmenityListParksVisitorCentersResponseData() { }

    public AmenityListParksVisitorCentersResponseData(
        AmenityListParksVisitorCentersResponseData amenityListParksVisitorCentersResponseData
    )
        : base(amenityListParksVisitorCentersResponseData) { }

    public AmenityListParksVisitorCentersResponseData(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksVisitorCentersResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AmenityListParksVisitorCentersResponseDataFromRaw.FromRawUnchecked"/>
    public static AmenityListParksVisitorCentersResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AmenityListParksVisitorCentersResponseDataFromRaw
    : IFromRawJson<AmenityListParksVisitorCentersResponseData>
{
    /// <inheritdoc/>
    public AmenityListParksVisitorCentersResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AmenityListParksVisitorCentersResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AmenityListParksVisitorCentersResponseDataPark,
        AmenityListParksVisitorCentersResponseDataParkFromRaw
    >)
)]
public sealed record class AmenityListParksVisitorCentersResponseDataPark : JsonModel
{
    public string? Designation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("designation");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("designation", value);
        }
    }

    public string? FullName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("fullName");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("fullName", value);
        }
    }

    public string? Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("Name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("Name", value);
        }
    }

    /// <summary>
    /// four letter park code
    /// </summary>
    public string? ParkCode
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("parkCode");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("parkCode", value);
        }
    }

    /// <summary>
    /// two letter state code
    /// </summary>
    public string? States
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("states");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("states", value);
        }
    }

    public string? Url
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("url");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("url", value);
        }
    }

    public IReadOnlyList<Visitorcenter>? Visitorcenters
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Visitorcenter>>("visitorcenters");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Visitorcenter>?>(
                "visitorcenters",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Designation;
        _ = this.FullName;
        _ = this.Name;
        _ = this.ParkCode;
        _ = this.States;
        _ = this.Url;
        foreach (var item in this.Visitorcenters ?? [])
        {
            item.Validate();
        }
    }

    public AmenityListParksVisitorCentersResponseDataPark() { }

    public AmenityListParksVisitorCentersResponseDataPark(
        AmenityListParksVisitorCentersResponseDataPark amenityListParksVisitorCentersResponseDataPark
    )
        : base(amenityListParksVisitorCentersResponseDataPark) { }

    public AmenityListParksVisitorCentersResponseDataPark(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksVisitorCentersResponseDataPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AmenityListParksVisitorCentersResponseDataParkFromRaw.FromRawUnchecked"/>
    public static AmenityListParksVisitorCentersResponseDataPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AmenityListParksVisitorCentersResponseDataParkFromRaw
    : IFromRawJson<AmenityListParksVisitorCentersResponseDataPark>
{
    /// <inheritdoc/>
    public AmenityListParksVisitorCentersResponseDataPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AmenityListParksVisitorCentersResponseDataPark.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Visitorcenter, VisitorcenterFromRaw>))]
public sealed record class Visitorcenter : JsonModel
{
    /// <summary>
    /// Unique identifier for the Visitor Center
    /// </summary>
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    /// <summary>
    /// Name of the Visitor Center
    /// </summary>
    public string? Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name", value);
        }
    }

    /// <summary>
    /// URL for the Visitor Center
    /// </summary>
    public string? Url
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("url");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("url", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Name;
        _ = this.Url;
    }

    public Visitorcenter() { }

    public Visitorcenter(Visitorcenter visitorcenter)
        : base(visitorcenter) { }

    public Visitorcenter(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Visitorcenter(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="VisitorcenterFromRaw.FromRawUnchecked"/>
    public static Visitorcenter FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class VisitorcenterFromRaw : IFromRawJson<Visitorcenter>
{
    /// <inheritdoc/>
    public Visitorcenter FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Visitorcenter.FromRawUnchecked(rawData);
}
