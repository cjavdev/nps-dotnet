using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Data>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Data>?>(
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

    public CampgroundListResponse() { }

    public CampgroundListResponse(CampgroundListResponse campgroundListResponse)
        : base(campgroundListResponse) { }

    public CampgroundListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CampgroundListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
    /// <summary>
    /// Campground identification string
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
    /// Detailed information about accessibility in the campground
    /// </summary>
    public Accessibility? Accessibility
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Accessibility>("accessibility");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("accessibility", value);
        }
    }

    /// <summary>
    /// Campground addresses (physical and mailing)
    /// </summary>
    public IReadOnlyList<Address>? Addresses
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Address>>("addresses");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Address>?>(
                "addresses",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Detailed information about amenities available in the campground.
    /// </summary>
    public DataAmenities? Amenities
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<DataAmenities>("amenities");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("amenities", value);
        }
    }

    /// <summary>
    /// Detailed information about campsites
    /// </summary>
    public Campsites? Campsites
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Campsites>("campsites");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("campsites", value);
        }
    }

    /// <summary>
    /// Information about contacting the park regarding this campground
    /// </summary>
    public Contacts? Contacts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Contacts>("contacts");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contacts", value);
        }
    }

    /// <summary>
    /// General description of the campground
    /// </summary>
    public string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    /// <summary>
    /// General overview of how to get to the campground
    /// </summary>
    public string? Directionsoverview
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("directionsoverview");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("directionsoverview", value);
        }
    }

    /// <summary>
    /// Link to page, if available, that provides additional detail on getting to
    /// the campground
    /// </summary>
    public string? DirectionsUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("directionsUrl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("directionsUrl", value);
        }
    }

    /// <summary>
    /// Information about the cost of camping
    /// </summary>
    public IReadOnlyList<string>? Fees
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("fees");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "fees",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Id for Geometry Point of Interest
    /// </summary>
    public string? GeometryPoiID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("geometryPoiId");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("geometryPoiId", value);
        }
    }

    /// <summary>
    /// Campground images
    /// </summary>
    public IReadOnlyList<string>? Images
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("images");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "images",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// When this match was last indexed
    /// </summary>
    public string? LastIndexedDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("lastIndexedDate");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("lastIndexedDate", value);
        }
    }

    public string? Latitude
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("latitude");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("latitude", value);
        }
    }

    /// <summary>
    /// Campground GPS cordinates
    /// </summary>
    public string? LatLong
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("latLong");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("latLong", value);
        }
    }

    public string? Longitude
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("longitude");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("longitude", value);
        }
    }

    public IReadOnlyList<DataMultimedia>? Multimedia
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<DataMultimedia>>("multimedia");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<DataMultimedia>?>(
                "multimedia",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Campground name
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
    /// Hours and seasons when the campground is open or closed
    /// </summary>
    public IReadOnlyList<string>? OperatingHours
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("operatingHours");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "operatingHours",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// A variable width character code used to identify a specific park
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
    /// Information about campground regulations
    /// </summary>
    public string? Regulationsoverview
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("regulationsoverview");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("regulationsoverview", value);
        }
    }

    /// <summary>
    /// Link to additional information about campground regulations, if available
    /// </summary>
    public string? Regulationsurl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("regulationsurl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("regulationsurl", value);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("relevanceScore");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("relevanceScore", value);
        }
    }

    /// <summary>
    /// General description of the reservation process, if applicable
    /// </summary>
    public string? Reservationsdescription
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("reservationsdescription");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("reservationsdescription", value);
        }
    }

    /// <summary>
    /// Number of sites that are first come, first served (cannot be booked in advance)
    /// </summary>
    public string? Reservationssitesfirstcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("reservationssitesfirstcome");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("reservationssitesfirstcome", value);
        }
    }

    /// <summary>
    /// Number of sites that can be booked in advance
    /// </summary>
    public string? Reservationssitesreservable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("reservationssitesreservable");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("reservationssitesreservable", value);
        }
    }

    /// <summary>
    /// Link to website where reservations can be made
    /// </summary>
    public string? Reservationsurl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("reservationsurl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("reservationsurl", value);
        }
    }

    /// <summary>
    /// General description of the weather in the campground over the course of a year
    /// </summary>
    public string? Weatheroverview
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("weatheroverview");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("weatheroverview", value);
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

    public Data() { }

    public Data(Data data)
        : base(data) { }

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

/// <summary>
/// Detailed information about accessibility in the campground
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Accessibility, AccessibilityFromRaw>))]
public sealed record class Accessibility : JsonModel
{
    public IReadOnlyList<string>? Accessroads
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("accessroads");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "accessroads",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Adainfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("adainfo");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("adainfo", value);
        }
    }

    public string? Additionalinfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("additionalinfo");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("additionalinfo", value);
        }
    }

    public string? Cellphoneinfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("cellphoneinfo");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cellphoneinfo", value);
        }
    }

    public IReadOnlyList<string>? Classifications
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("classifications");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "classifications",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Firestovepolicy
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("firestovepolicy");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("firestovepolicy", value);
        }
    }

    public string? Internetinfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("internetinfo");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("internetinfo", value);
        }
    }

    public string? Rvallowed
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("rvallowed");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("rvallowed", value);
        }
    }

    public string? Rvinfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("rvinfo");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("rvinfo", value);
        }
    }

    public string? Rvmaxlength
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("rvmaxlength");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("rvmaxlength", value);
        }
    }

    public string? Trailerallowed
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("trailerallowed");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("trailerallowed", value);
        }
    }

    public string? Trailermaxlength
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("trailermaxlength");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("trailermaxlength", value);
        }
    }

    public string? Wheelchairaccess
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("wheelchairaccess");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("wheelchairaccess", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Accessibility(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("city");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("city", value);
        }
    }

    public string? CountryCode
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("countryCode");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("countryCode", value);
        }
    }

    public string? Line1
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("line1");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("line1", value);
        }
    }

    public string? Line2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("line2");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("line2", value);
        }
    }

    public string? Line3
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("line3");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("line3", value);
        }
    }

    public string? PostalCode
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("postalCode");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("postalCode", value);
        }
    }

    public string? ProvinceTerritoryCode
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("provinceTerritoryCode");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provinceTerritoryCode", value);
        }
    }

    public string? StateCode
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("stateCode");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("stateCode", value);
        }
    }

    public ApiEnum<string, global::Nps.Models.Campgrounds.Type>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::Nps.Models.Campgrounds.Type>
            >("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Address(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
[JsonConverter(typeof(JsonModelConverter<DataAmenities, DataAmenitiesFromRaw>))]
public sealed record class DataAmenities : JsonModel
{
    public string? Amphitheater
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("amphitheater");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("amphitheater", value);
        }
    }

    public string? Ampitheater
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("ampitheater");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("ampitheater", value);
        }
    }

    public string? Campstore
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("campstore");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("campstore", value);
        }
    }

    public string? Cellphonereception
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("cellphonereception");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cellphonereception", value);
        }
    }

    public string? Dumpstation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("dumpstation");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("dumpstation", value);
        }
    }

    public string? Firewoodforsale
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("firewoodforsale");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("firewoodforsale", value);
        }
    }

    public string? FoodStorageLockers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("foodStorageLockers");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("foodStorageLockers", value);
        }
    }

    public string? Iceavailableforsale
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("iceavailableforsale");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("iceavailableforsale", value);
        }
    }

    public string? Internetconnectivity
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("internetconnectivity");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("internetconnectivity", value);
        }
    }

    public string? Laundry
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("laundry");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("laundry", value);
        }
    }

    public IReadOnlyList<string>? Potablewater
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("potablewater");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "potablewater",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<string>? Showers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("showers");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "showers",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Stafforvolunteerhostonsite
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("stafforvolunteerhostonsite");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("stafforvolunteerhostonsite", value);
        }
    }

    public IReadOnlyList<string>? Toilets
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("toilets");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "toilets",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Trashrecyclingcollection
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("trashrecyclingcollection");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("trashrecyclingcollection", value);
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

    public DataAmenities() { }

    public DataAmenities(DataAmenities dataAmenities)
        : base(dataAmenities) { }

    public DataAmenities(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataAmenities(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataAmenitiesFromRaw.FromRawUnchecked"/>
    public static DataAmenities FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataAmenitiesFromRaw : IFromRawJson<DataAmenities>
{
    /// <inheritdoc/>
    public DataAmenities FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataAmenities.FromRawUnchecked(rawData);
}

/// <summary>
/// Detailed information about campsites
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Campsites, CampsitesFromRaw>))]
public sealed record class Campsites : JsonModel
{
    public string? Electricalhookups
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("electricalhookups");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("electricalhookups", value);
        }
    }

    public string? Group
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("group");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("group", value);
        }
    }

    public string? Horse
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("horse");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("horse", value);
        }
    }

    public string? Other
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("other");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("other", value);
        }
    }

    public string? Rvonly
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("rvonly");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("rvonly", value);
        }
    }

    public string? Tentonly
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("tentonly");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tentonly", value);
        }
    }

    public string? Totalsites
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("totalsites");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("totalsites", value);
        }
    }

    public string? Walkboatto
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("walkboatto");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("walkboatto", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Campsites(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<EmailAddress>>("emailAddresses");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<EmailAddress>?>(
                "emailAddresses",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<PhoneNumber>? PhoneNumbers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<PhoneNumber>>("phoneNumbers");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<PhoneNumber>?>(
                "phoneNumbers",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Contacts(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public string? EmailAddressValue
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("emailAddress");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("emailAddress", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EmailAddress(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public string? Extension
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("extension");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("extension", value);
        }
    }

    public string? PhoneNumberValue
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("phoneNumber");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("phoneNumber", value);
        }
    }

    public ApiEnum<string, PhoneNumberType>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, PhoneNumberType>>("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PhoneNumber(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

[JsonConverter(typeof(JsonModelConverter<DataMultimedia, DataMultimediaFromRaw>))]
public sealed record class DataMultimedia : JsonModel
{
    /// <summary>
    /// UUID for multimedia asset
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
    /// title of multimedia asset
    /// </summary>
    public string? Title
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("title");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    /// <summary>
    /// the kind of asset
    /// </summary>
    public string? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
        }
    }

    /// <summary>
    /// The URL of the multimedia asset
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
        _ = this.Title;
        _ = this.Type;
        _ = this.Url;
    }

    public DataMultimedia() { }

    public DataMultimedia(DataMultimedia dataMultimedia)
        : base(dataMultimedia) { }

    public DataMultimedia(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataMultimedia(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataMultimediaFromRaw.FromRawUnchecked"/>
    public static DataMultimedia FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataMultimediaFromRaw : IFromRawJson<DataMultimedia>
{
    /// <inheritdoc/>
    public DataMultimedia FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataMultimedia.FromRawUnchecked(rawData);
}
