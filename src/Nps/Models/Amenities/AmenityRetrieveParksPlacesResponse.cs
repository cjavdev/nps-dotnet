using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Amenities;

[JsonConverter(
    typeof(JsonModelConverter<
        AmenityRetrieveParksPlacesResponse,
        AmenityRetrieveParksPlacesResponseFromRaw
    >)
)]
public sealed record class AmenityRetrieveParksPlacesResponse : JsonModel
{
    public IReadOnlyList<AmenityRetrieveParksPlacesResponseData>? Data
    {
        get
        {
            return JsonModel.GetNullableClass<List<AmenityRetrieveParksPlacesResponseData>>(
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

    public AmenityRetrieveParksPlacesResponse() { }

    public AmenityRetrieveParksPlacesResponse(
        AmenityRetrieveParksPlacesResponse amenityRetrieveParksPlacesResponse
    )
        : base(amenityRetrieveParksPlacesResponse) { }

    public AmenityRetrieveParksPlacesResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityRetrieveParksPlacesResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AmenityRetrieveParksPlacesResponseFromRaw.FromRawUnchecked"/>
    public static AmenityRetrieveParksPlacesResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AmenityRetrieveParksPlacesResponseFromRaw : IFromRawJson<AmenityRetrieveParksPlacesResponse>
{
    /// <inheritdoc/>
    public AmenityRetrieveParksPlacesResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AmenityRetrieveParksPlacesResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AmenityRetrieveParksPlacesResponseData,
        AmenityRetrieveParksPlacesResponseDataFromRaw
    >)
)]
public sealed record class AmenityRetrieveParksPlacesResponseData : JsonModel
{
    public IReadOnlyList<AmenityRetrieveParksPlacesResponseDataData>? Data
    {
        get
        {
            return JsonModel.GetNullableClass<List<AmenityRetrieveParksPlacesResponseDataData>>(
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

    public AmenityRetrieveParksPlacesResponseData() { }

    public AmenityRetrieveParksPlacesResponseData(
        AmenityRetrieveParksPlacesResponseData amenityRetrieveParksPlacesResponseData
    )
        : base(amenityRetrieveParksPlacesResponseData) { }

    public AmenityRetrieveParksPlacesResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityRetrieveParksPlacesResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AmenityRetrieveParksPlacesResponseDataFromRaw.FromRawUnchecked"/>
    public static AmenityRetrieveParksPlacesResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AmenityRetrieveParksPlacesResponseDataFromRaw
    : IFromRawJson<AmenityRetrieveParksPlacesResponseData>
{
    /// <inheritdoc/>
    public AmenityRetrieveParksPlacesResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AmenityRetrieveParksPlacesResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AmenityRetrieveParksPlacesResponseDataData,
        AmenityRetrieveParksPlacesResponseDataDataFromRaw
    >)
)]
public sealed record class AmenityRetrieveParksPlacesResponseDataData : JsonModel
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
    /// Name of the amenity
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

    public IReadOnlyList<Park>? Parks
    {
        get { return JsonModel.GetNullableClass<List<Park>>(this.RawData, "parks"); }
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

    public AmenityRetrieveParksPlacesResponseDataData() { }

    public AmenityRetrieveParksPlacesResponseDataData(
        AmenityRetrieveParksPlacesResponseDataData amenityRetrieveParksPlacesResponseDataData
    )
        : base(amenityRetrieveParksPlacesResponseDataData) { }

    public AmenityRetrieveParksPlacesResponseDataData(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityRetrieveParksPlacesResponseDataData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AmenityRetrieveParksPlacesResponseDataDataFromRaw.FromRawUnchecked"/>
    public static AmenityRetrieveParksPlacesResponseDataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AmenityRetrieveParksPlacesResponseDataDataFromRaw
    : IFromRawJson<AmenityRetrieveParksPlacesResponseDataData>
{
    /// <inheritdoc/>
    public AmenityRetrieveParksPlacesResponseDataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AmenityRetrieveParksPlacesResponseDataData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Park, ParkFromRaw>))]
public sealed record class Park : JsonModel
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
    /// four letter parkCode
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

    public IReadOnlyList<Place>? Places
    {
        get { return JsonModel.GetNullableClass<List<Place>>(this.RawData, "places"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "places", value);
        }
    }

    /// <summary>
    /// one or more comma separated state codes
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Designation;
        _ = this.FullName;
        _ = this.Name;
        _ = this.ParkCode;
        foreach (var item in this.Places ?? [])
        {
            item.Validate();
        }
        _ = this.States;
        _ = this.Url;
    }

    public Park() { }

    public Park(Park park)
        : base(park) { }

    public Park(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Park(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ParkFromRaw.FromRawUnchecked"/>
    public static Park FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ParkFromRaw : IFromRawJson<Park>
{
    /// <inheritdoc/>
    public Park FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Park.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Place, PlaceFromRaw>))]
public sealed record class Place : JsonModel
{
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

    public string? Title
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "title", value);
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Title;
        _ = this.Url;
    }

    public Place() { }

    public Place(Place place)
        : base(place) { }

    public Place(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Place(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PlaceFromRaw.FromRawUnchecked"/>
    public static Place FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PlaceFromRaw : IFromRawJson<Place>
{
    /// <inheritdoc/>
    public Place FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Place.FromRawUnchecked(rawData);
}
