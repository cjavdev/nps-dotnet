using System.Collections.Frozen;
using System.Collections.Generic;
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
            return JsonModel.GetNullableClass<List<AmenityListParksVisitorCentersResponseData>>(
                this.RawData,
                "data"
            );
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

    public string? Limit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public string? Start
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public string? Total
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "total"); }
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

    public AmenityListParksVisitorCentersResponse() { }

    public AmenityListParksVisitorCentersResponse(
        AmenityListParksVisitorCentersResponse amenityListParksVisitorCentersResponse
    )
        : base(amenityListParksVisitorCentersResponse) { }

    public AmenityListParksVisitorCentersResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksVisitorCentersResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    /// <summary>
    /// The name for this amenity
    /// </summary>
    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "name", value);
        }
    }

    public IReadOnlyList<AmenityListParksVisitorCentersResponseDataPark>? Parks
    {
        get
        {
            return JsonModel.GetNullableClass<List<AmenityListParksVisitorCentersResponseDataPark>>(
                this.RawData,
                "parks"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parks", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksVisitorCentersResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "designation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "designation", value);
        }
    }

    public string? FullName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "fullName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fullName", value);
        }
    }

    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "Name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "Name", value);
        }
    }

    /// <summary>
    /// four letter park code
    /// </summary>
    public string? ParkCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parkCode", value);
        }
    }

    /// <summary>
    /// two letter state code
    /// </summary>
    public string? States
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "states"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "states", value);
        }
    }

    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
        }
    }

    public IReadOnlyList<Visitorcenter>? Visitorcenters
    {
        get
        {
            return JsonModel.GetNullableClass<List<Visitorcenter>>(this.RawData, "visitorcenters");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "visitorcenters", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksVisitorCentersResponseDataPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    /// <summary>
    /// Name of the Visitor Center
    /// </summary>
    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "name", value);
        }
    }

    /// <summary>
    /// URL for the Visitor Center
    /// </summary>
    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Visitorcenter(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
