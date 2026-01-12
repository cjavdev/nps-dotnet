using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;
using Nps.Exceptions;
using System = System;

namespace Nps.Models.Campgrounds;

[JsonConverter(typeof(JsonModelConverter<CampgroundListResponse, CampgroundListResponseFromRaw>))]
public sealed record class CampgroundListResponse : JsonModel
{
    public IReadOnlyList<Data>? Data
    {
        get { return JsonModel.GetNullableClass<List<Data>>(this.RawData, "data"); }
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

    public CampgroundListResponse() { }

    public CampgroundListResponse(CampgroundListResponse campgroundListResponse)
        : base(campgroundListResponse) { }

    public CampgroundListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CampgroundListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CampgroundListResponseFromRaw.FromRawUnchecked"/>
    public static CampgroundListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CampgroundListResponseFromRaw : IFromRawJson<CampgroundListResponse>
{
    /// <inheritdoc/>
    public CampgroundListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CampgroundListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    public IReadOnlyList<DataData>? DataValue
    {
        get { return JsonModel.GetNullableClass<List<DataData>>(this.RawData, "data"); }
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
        foreach (var item in this.DataValue ?? [])
        {
            item.Validate();
        }
        _ = this.Limit;
        _ = this.Start;
        _ = this.Total;
    }

    public Data() { }

    public Data(Data data)
        : base(data) { }

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataFromRaw.FromRawUnchecked"/>
    public static Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<DataData, DataDataFromRaw>))]
public sealed record class DataData : JsonModel
{
    /// <summary>
    /// Campground identification string
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
    /// Detailed information about accessibility in the campground
    /// </summary>
    public Accessibility? Accessibility
    {
        get { return JsonModel.GetNullableClass<Accessibility>(this.RawData, "accessibility"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "accessibility", value);
        }
    }

    /// <summary>
    /// Campground addresses (physical and mailing)
    /// </summary>
    public IReadOnlyList<Address>? Addresses
    {
        get { return JsonModel.GetNullableClass<List<Address>>(this.RawData, "addresses"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "addresses", value);
        }
    }

    /// <summary>
    /// Detailed information about amenities available in the campground.
    /// </summary>
    public DataDataAmenities? Amenities
    {
        get { return JsonModel.GetNullableClass<DataDataAmenities>(this.RawData, "amenities"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "amenities", value);
        }
    }

    /// <summary>
    /// Detailed information about campsites
    /// </summary>
    public Campsites? Campsites
    {
        get { return JsonModel.GetNullableClass<Campsites>(this.RawData, "campsites"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "campsites", value);
        }
    }

    /// <summary>
    /// Information about contacting the park regarding this campground
    /// </summary>
    public Contacts? Contacts
    {
        get { return JsonModel.GetNullableClass<Contacts>(this.RawData, "contacts"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contacts", value);
        }
    }

    /// <summary>
    /// General description of the campground
    /// </summary>
    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "description", value);
        }
    }

    /// <summary>
    /// General overview of how to get to the campground
    /// </summary>
    public string? Directionsoverview
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "directionsoverview"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "directionsoverview", value);
        }
    }

    /// <summary>
    /// Link to page, if available, that provides additional detail on getting to
    /// the campground
    /// </summary>
    public string? DirectionsUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "directionsUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "directionsUrl", value);
        }
    }

    /// <summary>
    /// Information about the cost of camping
    /// </summary>
    public IReadOnlyList<string>? Fees
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "fees"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fees", value);
        }
    }

    /// <summary>
    /// Id for Geometry Point of Interest
    /// </summary>
    public string? GeometryPoiID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "geometryPoiId"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "geometryPoiId", value);
        }
    }

    /// <summary>
    /// Campground images
    /// </summary>
    public IReadOnlyList<string>? Images
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "images"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "images", value);
        }
    }

    /// <summary>
    /// When this match was last indexed
    /// </summary>
    public string? LastIndexedDate
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "lastIndexedDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "lastIndexedDate", value);
        }
    }

    public string? Latitude
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "latitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "latitude", value);
        }
    }

    /// <summary>
    /// Campground GPS cordinates
    /// </summary>
    public string? LatLong
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "latLong"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "latLong", value);
        }
    }

    public string? Longitude
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "longitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "longitude", value);
        }
    }

    public IReadOnlyList<DataDataMultimedia>? Multimedia
    {
        get
        {
            return JsonModel.GetNullableClass<List<DataDataMultimedia>>(this.RawData, "multimedia");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "multimedia", value);
        }
    }

    /// <summary>
    /// Campground name
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
    /// Hours and seasons when the campground is open or closed
    /// </summary>
    public IReadOnlyList<string>? OperatingHours
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "operatingHours"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "operatingHours", value);
        }
    }

    /// <summary>
    /// A variable width character code used to identify a specific park
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
    /// Information about campground regulations
    /// </summary>
    public string? Regulationsoverview
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "regulationsoverview"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "regulationsoverview", value);
        }
    }

    /// <summary>
    /// Link to additional information about campground regulations, if available
    /// </summary>
    public string? Regulationsurl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "regulationsurl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "regulationsurl", value);
        }
    }

    /// <summary>
    /// The relevance score is a numeric calculation of how much your item meets the
    /// criteria of your q (query text) search. This is normally coupled with a sort
    /// value of -relevanceScore. A higher value means that your item meets the criteria
    /// of the q search with a higher frequency and accuracy.
    /// </summary>
    public double? RelevanceScore
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "relevanceScore"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relevanceScore", value);
        }
    }

    /// <summary>
    /// General description of the reservation process, if applicable
    /// </summary>
    public string? Reservationsdescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "reservationsdescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "reservationsdescription", value);
        }
    }

    /// <summary>
    /// Number of sites that are first come, first served (cannot be booked in advance)
    /// </summary>
    public string? Reservationssitesfirstcome
    {
        get
        {
            return JsonModel.GetNullableClass<string>(this.RawData, "reservationssitesfirstcome");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "reservationssitesfirstcome", value);
        }
    }

    /// <summary>
    /// Number of sites that can be booked in advance
    /// </summary>
    public string? Reservationssitesreservable
    {
        get
        {
            return JsonModel.GetNullableClass<string>(this.RawData, "reservationssitesreservable");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "reservationssitesreservable", value);
        }
    }

    /// <summary>
    /// Link to website where reservations can be made
    /// </summary>
    public string? Reservationsurl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "reservationsurl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "reservationsurl", value);
        }
    }

    /// <summary>
    /// General description of the weather in the campground over the course of a year
    /// </summary>
    public string? Weatheroverview
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "weatheroverview"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "weatheroverview", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Accessibility?.Validate();
        foreach (var item in this.Addresses ?? [])
        {
            item.Validate();
        }
        this.Amenities?.Validate();
        this.Campsites?.Validate();
        this.Contacts?.Validate();
        _ = this.Description;
        _ = this.Directionsoverview;
        _ = this.DirectionsUrl;
        _ = this.Fees;
        _ = this.GeometryPoiID;
        _ = this.Images;
        _ = this.LastIndexedDate;
        _ = this.Latitude;
        _ = this.LatLong;
        _ = this.Longitude;
        foreach (var item in this.Multimedia ?? [])
        {
            item.Validate();
        }
        _ = this.Name;
        _ = this.OperatingHours;
        _ = this.ParkCode;
        _ = this.Regulationsoverview;
        _ = this.Regulationsurl;
        _ = this.RelevanceScore;
        _ = this.Reservationsdescription;
        _ = this.Reservationssitesfirstcome;
        _ = this.Reservationssitesreservable;
        _ = this.Reservationsurl;
        _ = this.Weatheroverview;
    }

    public DataData() { }

    public DataData(DataData dataData)
        : base(dataData) { }

    public DataData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataDataFromRaw.FromRawUnchecked"/>
    public static DataData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataDataFromRaw : IFromRawJson<DataData>
{
    /// <inheritdoc/>
    public DataData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataData.FromRawUnchecked(rawData);
}

/// <summary>
/// Detailed information about accessibility in the campground
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Accessibility, AccessibilityFromRaw>))]
public sealed record class Accessibility : JsonModel
{
    public IReadOnlyList<string>? Accessroads
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "accessroads"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "accessroads", value);
        }
    }

    public string? Adainfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "adainfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "adainfo", value);
        }
    }

    public string? Additionalinfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "additionalinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "additionalinfo", value);
        }
    }

    public string? Cellphoneinfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cellphoneinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cellphoneinfo", value);
        }
    }

    public IReadOnlyList<string>? Classifications
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "classifications"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "classifications", value);
        }
    }

    public string? Firestovepolicy
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "firestovepolicy"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "firestovepolicy", value);
        }
    }

    public string? Internetinfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "internetinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "internetinfo", value);
        }
    }

    public string? Rvallowed
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "rvallowed"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "rvallowed", value);
        }
    }

    public string? Rvinfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "rvinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "rvinfo", value);
        }
    }

    public string? Rvmaxlength
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "rvmaxlength"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "rvmaxlength", value);
        }
    }

    public string? Trailerallowed
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "trailerallowed"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "trailerallowed", value);
        }
    }

    public string? Trailermaxlength
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "trailermaxlength"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "trailermaxlength", value);
        }
    }

    public string? Wheelchairaccess
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "wheelchairaccess"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "wheelchairaccess", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Accessroads;
        _ = this.Adainfo;
        _ = this.Additionalinfo;
        _ = this.Cellphoneinfo;
        _ = this.Classifications;
        _ = this.Firestovepolicy;
        _ = this.Internetinfo;
        _ = this.Rvallowed;
        _ = this.Rvinfo;
        _ = this.Rvmaxlength;
        _ = this.Trailerallowed;
        _ = this.Trailermaxlength;
        _ = this.Wheelchairaccess;
    }

    public Accessibility() { }

    public Accessibility(Accessibility accessibility)
        : base(accessibility) { }

    public Accessibility(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Accessibility(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccessibilityFromRaw.FromRawUnchecked"/>
    public static Accessibility FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccessibilityFromRaw : IFromRawJson<Accessibility>
{
    /// <inheritdoc/>
    public Accessibility FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Accessibility.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Address, AddressFromRaw>))]
public sealed record class Address : JsonModel
{
    public string? City
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "city"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "city", value);
        }
    }

    public string? CountryCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "countryCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "countryCode", value);
        }
    }

    public string? Line1
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "line1"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "line1", value);
        }
    }

    public string? Line2
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "line2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "line2", value);
        }
    }

    public string? Line3
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "line3"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "line3", value);
        }
    }

    public string? PostalCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "postalCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "postalCode", value);
        }
    }

    public string? ProvinceTerritoryCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "provinceTerritoryCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "provinceTerritoryCode", value);
        }
    }

    public string? StateCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "stateCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "stateCode", value);
        }
    }

    public ApiEnum<string, global::Nps.Models.Campgrounds.Type>? Type
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, global::Nps.Models.Campgrounds.Type>>(
                this.RawData,
                "type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.City;
        _ = this.CountryCode;
        _ = this.Line1;
        _ = this.Line2;
        _ = this.Line3;
        _ = this.PostalCode;
        _ = this.ProvinceTerritoryCode;
        _ = this.StateCode;
        this.Type?.Validate();
    }

    public Address() { }

    public Address(Address address)
        : base(address) { }

    public Address(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Address(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AddressFromRaw.FromRawUnchecked"/>
    public static Address FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AddressFromRaw : IFromRawJson<Address>
{
    /// <inheritdoc/>
    public Address FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Address.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Physical,
    Mailing,
}

sealed class TypeConverter : JsonConverter<global::Nps.Models.Campgrounds.Type>
{
    public override global::Nps.Models.Campgrounds.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "Physical" => global::Nps.Models.Campgrounds.Type.Physical,
            "Mailing" => global::Nps.Models.Campgrounds.Type.Mailing,
            _ => (global::Nps.Models.Campgrounds.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Nps.Models.Campgrounds.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Nps.Models.Campgrounds.Type.Physical => "Physical",
                global::Nps.Models.Campgrounds.Type.Mailing => "Mailing",
                _ => throw new NpsInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Detailed information about amenities available in the campground.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<DataDataAmenities, DataDataAmenitiesFromRaw>))]
public sealed record class DataDataAmenities : JsonModel
{
    public string? Amphitheater
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "amphitheater"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "amphitheater", value);
        }
    }

    public string? Ampitheater
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "ampitheater"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "ampitheater", value);
        }
    }

    public string? Campstore
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "campstore"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "campstore", value);
        }
    }

    public string? Cellphonereception
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cellphonereception"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cellphonereception", value);
        }
    }

    public string? Dumpstation
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "dumpstation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "dumpstation", value);
        }
    }

    public string? Firewoodforsale
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "firewoodforsale"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "firewoodforsale", value);
        }
    }

    public string? FoodStorageLockers
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "foodStorageLockers"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "foodStorageLockers", value);
        }
    }

    public string? Iceavailableforsale
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "iceavailableforsale"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "iceavailableforsale", value);
        }
    }

    public string? Internetconnectivity
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "internetconnectivity"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "internetconnectivity", value);
        }
    }

    public string? Laundry
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "laundry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "laundry", value);
        }
    }

    public IReadOnlyList<string>? Potablewater
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "potablewater"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "potablewater", value);
        }
    }

    public IReadOnlyList<string>? Showers
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "showers"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "showers", value);
        }
    }

    public string? Stafforvolunteerhostonsite
    {
        get
        {
            return JsonModel.GetNullableClass<string>(this.RawData, "stafforvolunteerhostonsite");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "stafforvolunteerhostonsite", value);
        }
    }

    public IReadOnlyList<string>? Toilets
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "toilets"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "toilets", value);
        }
    }

    public string? Trashrecyclingcollection
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "trashrecyclingcollection"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "trashrecyclingcollection", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Amphitheater;
        _ = this.Ampitheater;
        _ = this.Campstore;
        _ = this.Cellphonereception;
        _ = this.Dumpstation;
        _ = this.Firewoodforsale;
        _ = this.FoodStorageLockers;
        _ = this.Iceavailableforsale;
        _ = this.Internetconnectivity;
        _ = this.Laundry;
        _ = this.Potablewater;
        _ = this.Showers;
        _ = this.Stafforvolunteerhostonsite;
        _ = this.Toilets;
        _ = this.Trashrecyclingcollection;
    }

    public DataDataAmenities() { }

    public DataDataAmenities(DataDataAmenities dataDataAmenities)
        : base(dataDataAmenities) { }

    public DataDataAmenities(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataDataAmenities(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataDataAmenitiesFromRaw.FromRawUnchecked"/>
    public static DataDataAmenities FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataDataAmenitiesFromRaw : IFromRawJson<DataDataAmenities>
{
    /// <inheritdoc/>
    public DataDataAmenities FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataDataAmenities.FromRawUnchecked(rawData);
}

/// <summary>
/// Detailed information about campsites
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Campsites, CampsitesFromRaw>))]
public sealed record class Campsites : JsonModel
{
    public string? Electricalhookups
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "electricalhookups"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "electricalhookups", value);
        }
    }

    public string? Group
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "group"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "group", value);
        }
    }

    public string? Horse
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "horse"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "horse", value);
        }
    }

    public string? Other
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "other"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "other", value);
        }
    }

    public string? Rvonly
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "rvonly"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "rvonly", value);
        }
    }

    public string? Tentonly
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "tentonly"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tentonly", value);
        }
    }

    public string? Totalsites
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "totalsites"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "totalsites", value);
        }
    }

    public string? Walkboatto
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "walkboatto"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "walkboatto", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Electricalhookups;
        _ = this.Group;
        _ = this.Horse;
        _ = this.Other;
        _ = this.Rvonly;
        _ = this.Tentonly;
        _ = this.Totalsites;
        _ = this.Walkboatto;
    }

    public Campsites() { }

    public Campsites(Campsites campsites)
        : base(campsites) { }

    public Campsites(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Campsites(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CampsitesFromRaw.FromRawUnchecked"/>
    public static Campsites FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CampsitesFromRaw : IFromRawJson<Campsites>
{
    /// <inheritdoc/>
    public Campsites FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Campsites.FromRawUnchecked(rawData);
}

/// <summary>
/// Information about contacting the park regarding this campground
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Contacts, ContactsFromRaw>))]
public sealed record class Contacts : JsonModel
{
    public IReadOnlyList<EmailAddress>? EmailAddresses
    {
        get
        {
            return JsonModel.GetNullableClass<List<EmailAddress>>(this.RawData, "emailAddresses");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "emailAddresses", value);
        }
    }

    public IReadOnlyList<PhoneNumber>? PhoneNumbers
    {
        get { return JsonModel.GetNullableClass<List<PhoneNumber>>(this.RawData, "phoneNumbers"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "phoneNumbers", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.EmailAddresses ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.PhoneNumbers ?? [])
        {
            item.Validate();
        }
    }

    public Contacts() { }

    public Contacts(Contacts contacts)
        : base(contacts) { }

    public Contacts(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Contacts(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ContactsFromRaw.FromRawUnchecked"/>
    public static Contacts FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ContactsFromRaw : IFromRawJson<Contacts>
{
    /// <inheritdoc/>
    public Contacts FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Contacts.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<EmailAddress, EmailAddressFromRaw>))]
public sealed record class EmailAddress : JsonModel
{
    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "description", value);
        }
    }

    public string? EmailAddressValue
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "emailAddress"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "emailAddress", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Description;
        _ = this.EmailAddressValue;
    }

    public EmailAddress() { }

    public EmailAddress(EmailAddress emailAddress)
        : base(emailAddress) { }

    public EmailAddress(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EmailAddress(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="EmailAddressFromRaw.FromRawUnchecked"/>
    public static EmailAddress FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class EmailAddressFromRaw : IFromRawJson<EmailAddress>
{
    /// <inheritdoc/>
    public EmailAddress FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        EmailAddress.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PhoneNumber, PhoneNumberFromRaw>))]
public sealed record class PhoneNumber : JsonModel
{
    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "description", value);
        }
    }

    public string? Extension
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "extension"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "extension", value);
        }
    }

    public string? PhoneNumberValue
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "phoneNumber"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "phoneNumber", value);
        }
    }

    public ApiEnum<string, PhoneNumberType>? Type
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, PhoneNumberType>>(
                this.RawData,
                "type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Description;
        _ = this.Extension;
        _ = this.PhoneNumberValue;
        this.Type?.Validate();
    }

    public PhoneNumber() { }

    public PhoneNumber(PhoneNumber phoneNumber)
        : base(phoneNumber) { }

    public PhoneNumber(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PhoneNumber(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PhoneNumberFromRaw.FromRawUnchecked"/>
    public static PhoneNumber FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PhoneNumberFromRaw : IFromRawJson<PhoneNumber>
{
    /// <inheritdoc/>
    public PhoneNumber FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PhoneNumber.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PhoneNumberTypeConverter))]
public enum PhoneNumberType
{
    Voice,
    Fax,
    Tty,
}

sealed class PhoneNumberTypeConverter : JsonConverter<PhoneNumberType>
{
    public override PhoneNumberType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "Voice" => PhoneNumberType.Voice,
            "Fax" => PhoneNumberType.Fax,
            "TTY" => PhoneNumberType.Tty,
            _ => (PhoneNumberType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PhoneNumberType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PhoneNumberType.Voice => "Voice",
                PhoneNumberType.Fax => "Fax",
                PhoneNumberType.Tty => "TTY",
                _ => throw new NpsInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<DataDataMultimedia, DataDataMultimediaFromRaw>))]
public sealed record class DataDataMultimedia : JsonModel
{
    /// <summary>
    /// UUID for multimedia asset
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
    /// title of multimedia asset
    /// </summary>
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

    /// <summary>
    /// the kind of asset
    /// </summary>
    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <summary>
    /// The URL of the multimedia asset
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
        _ = this.Title;
        _ = this.Type;
        _ = this.Url;
    }

    public DataDataMultimedia() { }

    public DataDataMultimedia(DataDataMultimedia dataDataMultimedia)
        : base(dataDataMultimedia) { }

    public DataDataMultimedia(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataDataMultimedia(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataDataMultimediaFromRaw.FromRawUnchecked"/>
    public static DataDataMultimedia FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataDataMultimediaFromRaw : IFromRawJson<DataDataMultimedia>
{
    /// <inheritdoc/>
    public DataDataMultimedia FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataDataMultimedia.FromRawUnchecked(rawData);
}
