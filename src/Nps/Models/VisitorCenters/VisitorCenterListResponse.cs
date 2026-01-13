using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;
using Nps.Exceptions;
using System = System;

namespace Nps.Models.VisitorCenters;

[JsonConverter(
    typeof(JsonModelConverter<VisitorCenterListResponse, VisitorCenterListResponseFromRaw>)
)]
public sealed record class VisitorCenterListResponse : JsonModel
{
    public IReadOnlyList<Data>? Data
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Data>>("data"); }
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
        get { return this._rawData.GetNullableClass<string>("limit"); }
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
        get { return this._rawData.GetNullableClass<string>("start"); }
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
        get { return this._rawData.GetNullableClass<string>("total"); }
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

    public VisitorCenterListResponse() { }

    public VisitorCenterListResponse(VisitorCenterListResponse visitorCenterListResponse)
        : base(visitorCenterListResponse) { }

    public VisitorCenterListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    VisitorCenterListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="VisitorCenterListResponseFromRaw.FromRawUnchecked"/>
    public static VisitorCenterListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class VisitorCenterListResponseFromRaw : IFromRawJson<VisitorCenterListResponse>
{
    /// <inheritdoc/>
    public VisitorCenterListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => VisitorCenterListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// ID
    /// </summary>
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
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
    /// Visitor Center addresses (physical and mailing)
    /// </summary>
    public IReadOnlyList<Address>? Addresses
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Address>>("addresses"); }
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

    public IReadOnlyList<string>? Amenities
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("amenities"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "amenities",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// audio description of the facility
    /// </summary>
    public string? AudioDescription
    {
        get { return this._rawData.GetNullableClass<string>("audioDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("audioDescription", value);
        }
    }

    /// <summary>
    /// Information about contacting staff at the facility
    /// </summary>
    public IReadOnlyList<string>? Contacts
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("contacts"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "contacts",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// General description of the facility
    /// </summary>
    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
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
    /// General overview of how to get to the facility
    /// </summary>
    public string? DirectionsInfo
    {
        get { return this._rawData.GetNullableClass<string>("directionsInfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("directionsInfo", value);
        }
    }

    /// <summary>
    /// Link to page, if available, that provides additional detail on getting to
    /// the facility
    /// </summary>
    public string? DirectionsUrl
    {
        get { return this._rawData.GetNullableClass<string>("directionsUrl"); }
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
    /// Id for Geometry Point of Interest
    /// </summary>
    public string? GeometryPoiID
    {
        get { return this._rawData.GetNullableClass<string>("geometryPoiId"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("geometryPoiId", value);
        }
    }

    public IReadOnlyList<Image>? Images
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Image>>("images"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Image>?>(
                "images",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// 0 or 1
    /// </summary>
    public bool? IsPassportStampLocation
    {
        get { return this._rawData.GetNullableStruct<bool>("isPassportStampLocation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isPassportStampLocation", value);
        }
    }

    public string? LastIndexedDate
    {
        get { return this._rawData.GetNullableClass<string>("lastIndexedDate"); }
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
        get { return this._rawData.GetNullableClass<string>("latitude"); }
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
    /// Facility latitude and longitude
    /// </summary>
    public string? LatLong
    {
        get { return this._rawData.GetNullableClass<string>("latLong"); }
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
        get { return this._rawData.GetNullableClass<string>("longitude"); }
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
    /// Facility name
    /// </summary>
    public string? Name
    {
        get { return this._rawData.GetNullableClass<string>("name"); }
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
    /// Hours and seasons when the facility is open or closed
    /// </summary>
    public IReadOnlyList<OperatingHour>? OperatingHours
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<OperatingHour>>("operatingHours");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<OperatingHour>?>(
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
        get { return this._rawData.GetNullableClass<string>("parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("parkCode", value);
        }
    }

    public IReadOnlyList<PassportStampImage>? PassportStampImages
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<PassportStampImage>>(
                "passportStampImages"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<PassportStampImage>?>(
                "passportStampImages",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? PassportStampLocationDescription
    {
        get { return this._rawData.GetNullableClass<string>("passportStampLocationDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("passportStampLocationDescription", value);
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
        get { return this._rawData.GetNullableStruct<double>("relevanceScore"); }
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
    /// The URL corresponding to the visitor center
    /// </summary>
    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
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
        foreach (var item in this.Addresses ?? [])
        {
            item.Validate();
        }
        _ = this.Amenities;
        _ = this.AudioDescription;
        _ = this.Contacts;
        _ = this.Description;
        _ = this.DirectionsInfo;
        _ = this.DirectionsUrl;
        _ = this.GeometryPoiID;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
        _ = this.IsPassportStampLocation;
        _ = this.LastIndexedDate;
        _ = this.Latitude;
        _ = this.LatLong;
        _ = this.Longitude;
        foreach (var item in this.Multimedia ?? [])
        {
            item.Validate();
        }
        _ = this.Name;
        foreach (var item in this.OperatingHours ?? [])
        {
            item.Validate();
        }
        _ = this.ParkCode;
        foreach (var item in this.PassportStampImages ?? [])
        {
            item.Validate();
        }
        _ = this.PassportStampLocationDescription;
        _ = this.RelevanceScore;
        _ = this.Url;
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

[JsonConverter(typeof(JsonModelConverter<Address, AddressFromRaw>))]
public sealed record class Address : JsonModel
{
    public string? City
    {
        get { return this._rawData.GetNullableClass<string>("city"); }
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
        get { return this._rawData.GetNullableClass<string>("countryCode"); }
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
        get { return this._rawData.GetNullableClass<string>("line1"); }
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
        get { return this._rawData.GetNullableClass<string>("line2"); }
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
        get { return this._rawData.GetNullableClass<string>("line3"); }
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
        get { return this._rawData.GetNullableClass<string>("postalCode"); }
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
        get { return this._rawData.GetNullableClass<string>("provinceTerritoryCode"); }
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
        get { return this._rawData.GetNullableClass<string>("stateCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("stateCode", value);
        }
    }

    public ApiEnum<string, global::Nps.Models.VisitorCenters.Type>? Type
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::Nps.Models.VisitorCenters.Type>
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

sealed class TypeConverter : JsonConverter<global::Nps.Models.VisitorCenters.Type>
{
    public override global::Nps.Models.VisitorCenters.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "Physical" => global::Nps.Models.VisitorCenters.Type.Physical,
            "Mailing" => global::Nps.Models.VisitorCenters.Type.Mailing,
            _ => (global::Nps.Models.VisitorCenters.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Nps.Models.VisitorCenters.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Nps.Models.VisitorCenters.Type.Physical => "Physical",
                global::Nps.Models.VisitorCenters.Type.Mailing => "Mailing",
                _ => throw new NpsInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Image, ImageFromRaw>))]
public sealed record class Image : JsonModel
{
    public string? AltText
    {
        get { return this._rawData.GetNullableClass<string>("altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("altText", value);
        }
    }

    public string? Caption
    {
        get { return this._rawData.GetNullableClass<string>("caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("caption", value);
        }
    }

    public string? Credit
    {
        get { return this._rawData.GetNullableClass<string>("credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("credit", value);
        }
    }

    public IReadOnlyList<JsonElement>? Crops
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<JsonElement>>("crops"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<JsonElement>?>(
                "crops",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
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
        _ = this.AltText;
        _ = this.Caption;
        _ = this.Credit;
        _ = this.Crops;
        _ = this.Title;
        _ = this.Url;
    }

    public Image() { }

    public Image(Image image)
        : base(image) { }

    public Image(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Image(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ImageFromRaw.FromRawUnchecked"/>
    public static Image FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ImageFromRaw : IFromRawJson<Image>
{
    /// <inheritdoc/>
    public Image FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Image.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<DataMultimedia, DataMultimediaFromRaw>))]
public sealed record class DataMultimedia : JsonModel
{
    /// <summary>
    /// UUID for multimedia asset
    /// </summary>
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
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
        get { return this._rawData.GetNullableClass<string>("title"); }
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
        get { return this._rawData.GetNullableClass<string>("type"); }
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
        get { return this._rawData.GetNullableClass<string>("url"); }
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

[JsonConverter(typeof(JsonModelConverter<OperatingHour, OperatingHourFromRaw>))]
public sealed record class OperatingHour : JsonModel
{
    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public IReadOnlyList<Exception>? Exceptions
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Exception>>("exceptions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Exception>?>(
                "exceptions",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Name
    {
        get { return this._rawData.GetNullableClass<string>("name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name", value);
        }
    }

    public StandardHours? StandardHours
    {
        get { return this._rawData.GetNullableClass<StandardHours>("standardHours"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("standardHours", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Description;
        foreach (var item in this.Exceptions ?? [])
        {
            item.Validate();
        }
        _ = this.Name;
        this.StandardHours?.Validate();
    }

    public OperatingHour() { }

    public OperatingHour(OperatingHour operatingHour)
        : base(operatingHour) { }

    public OperatingHour(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    OperatingHour(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="OperatingHourFromRaw.FromRawUnchecked"/>
    public static OperatingHour FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class OperatingHourFromRaw : IFromRawJson<OperatingHour>
{
    /// <inheritdoc/>
    public OperatingHour FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        OperatingHour.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Exception, ExceptionFromRaw>))]
public sealed record class Exception : JsonModel
{
    public System::DateTimeOffset? EndDate
    {
        get { return this._rawData.GetNullableStruct<System::DateTimeOffset>("endDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endDate", value);
        }
    }

    public ExceptionHours? ExceptionHours
    {
        get { return this._rawData.GetNullableClass<ExceptionHours>("exceptionHours"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("exceptionHours", value);
        }
    }

    public string? Name
    {
        get { return this._rawData.GetNullableClass<string>("name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name", value);
        }
    }

    public System::DateTimeOffset? StartDate
    {
        get { return this._rawData.GetNullableStruct<System::DateTimeOffset>("startDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("startDate", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.EndDate;
        this.ExceptionHours?.Validate();
        _ = this.Name;
        _ = this.StartDate;
    }

    public Exception() { }

    public Exception(Exception exception)
        : base(exception) { }

    public Exception(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Exception(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ExceptionFromRaw.FromRawUnchecked"/>
    public static Exception FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ExceptionFromRaw : IFromRawJson<Exception>
{
    /// <inheritdoc/>
    public Exception FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Exception.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ExceptionHours, ExceptionHoursFromRaw>))]
public sealed record class ExceptionHours : JsonModel
{
    public string? Friday
    {
        get { return this._rawData.GetNullableClass<string>("friday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("friday", value);
        }
    }

    public string? Monday
    {
        get { return this._rawData.GetNullableClass<string>("monday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("monday", value);
        }
    }

    public string? Saturday
    {
        get { return this._rawData.GetNullableClass<string>("saturday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("saturday", value);
        }
    }

    public string? Sunday
    {
        get { return this._rawData.GetNullableClass<string>("sunday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sunday", value);
        }
    }

    public string? Thursday
    {
        get { return this._rawData.GetNullableClass<string>("thursday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("thursday", value);
        }
    }

    public string? Tuesday
    {
        get { return this._rawData.GetNullableClass<string>("tuesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tuesday", value);
        }
    }

    public string? Wednesday
    {
        get { return this._rawData.GetNullableClass<string>("wednesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("wednesday", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Friday;
        _ = this.Monday;
        _ = this.Saturday;
        _ = this.Sunday;
        _ = this.Thursday;
        _ = this.Tuesday;
        _ = this.Wednesday;
    }

    public ExceptionHours() { }

    public ExceptionHours(ExceptionHours exceptionHours)
        : base(exceptionHours) { }

    public ExceptionHours(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExceptionHours(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ExceptionHoursFromRaw.FromRawUnchecked"/>
    public static ExceptionHours FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ExceptionHoursFromRaw : IFromRawJson<ExceptionHours>
{
    /// <inheritdoc/>
    public ExceptionHours FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ExceptionHours.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<StandardHours, StandardHoursFromRaw>))]
public sealed record class StandardHours : JsonModel
{
    public string? Friday
    {
        get { return this._rawData.GetNullableClass<string>("friday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("friday", value);
        }
    }

    public string? Monday
    {
        get { return this._rawData.GetNullableClass<string>("monday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("monday", value);
        }
    }

    public string? Saturday
    {
        get { return this._rawData.GetNullableClass<string>("saturday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("saturday", value);
        }
    }

    public string? Sunday
    {
        get { return this._rawData.GetNullableClass<string>("sunday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sunday", value);
        }
    }

    public string? Thursday
    {
        get { return this._rawData.GetNullableClass<string>("thursday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("thursday", value);
        }
    }

    public string? Tuesday
    {
        get { return this._rawData.GetNullableClass<string>("tuesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tuesday", value);
        }
    }

    public string? Wednesday
    {
        get { return this._rawData.GetNullableClass<string>("wednesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("wednesday", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Friday;
        _ = this.Monday;
        _ = this.Saturday;
        _ = this.Sunday;
        _ = this.Thursday;
        _ = this.Tuesday;
        _ = this.Wednesday;
    }

    public StandardHours() { }

    public StandardHours(StandardHours standardHours)
        : base(standardHours) { }

    public StandardHours(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StandardHours(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StandardHoursFromRaw.FromRawUnchecked"/>
    public static StandardHours FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StandardHoursFromRaw : IFromRawJson<StandardHours>
{
    /// <inheritdoc/>
    public StandardHours FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StandardHours.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PassportStampImage, PassportStampImageFromRaw>))]
public sealed record class PassportStampImage : JsonModel
{
    public string? AltText
    {
        get { return this._rawData.GetNullableClass<string>("altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("altText", value);
        }
    }

    public string? Caption
    {
        get { return this._rawData.GetNullableClass<string>("caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("caption", value);
        }
    }

    public string? Credit
    {
        get { return this._rawData.GetNullableClass<string>("credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("credit", value);
        }
    }

    public IReadOnlyList<Crop>? Crops
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Crop>>("crops"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Crop>?>(
                "crops",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
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
        _ = this.AltText;
        _ = this.Caption;
        _ = this.Credit;
        foreach (var item in this.Crops ?? [])
        {
            item.Validate();
        }
        _ = this.Description;
        _ = this.Title;
        _ = this.Url;
    }

    public PassportStampImage() { }

    public PassportStampImage(PassportStampImage passportStampImage)
        : base(passportStampImage) { }

    public PassportStampImage(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PassportStampImage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PassportStampImageFromRaw.FromRawUnchecked"/>
    public static PassportStampImage FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PassportStampImageFromRaw : IFromRawJson<PassportStampImage>
{
    /// <inheritdoc/>
    public PassportStampImage FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PassportStampImage.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Crop, CropFromRaw>))]
public sealed record class Crop : JsonModel
{
    public double? AspectRatio
    {
        get { return this._rawData.GetNullableStruct<double>("aspectRatio"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("aspectRatio", value);
        }
    }

    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
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
        _ = this.AspectRatio;
        _ = this.Url;
    }

    public Crop() { }

    public Crop(Crop crop)
        : base(crop) { }

    public Crop(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Crop(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CropFromRaw.FromRawUnchecked"/>
    public static Crop FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CropFromRaw : IFromRawJson<Crop>
{
    /// <inheritdoc/>
    public Crop FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Crop.FromRawUnchecked(rawData);
}
