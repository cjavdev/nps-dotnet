using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;
using Nps.Exceptions;
using System = System;

namespace Nps.Models.Visitorcenters;

[JsonConverter(
    typeof(JsonModelConverter<VisitorcenterListResponse, VisitorcenterListResponseFromRaw>)
)]
public sealed record class VisitorcenterListResponse : JsonModel
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

    public VisitorcenterListResponse() { }

    public VisitorcenterListResponse(VisitorcenterListResponse visitorcenterListResponse)
        : base(visitorcenterListResponse) { }

    public VisitorcenterListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    VisitorcenterListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="VisitorcenterListResponseFromRaw.FromRawUnchecked"/>
    public static VisitorcenterListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class VisitorcenterListResponseFromRaw : IFromRawJson<VisitorcenterListResponse>
{
    /// <inheritdoc/>
    public VisitorcenterListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => VisitorcenterListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// ID
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
    /// Visitor Center addresses (physical and mailing)
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

    public IReadOnlyList<string>? Amenities
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "amenities"); }
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
    /// audio description of the facility
    /// </summary>
    public string? AudioDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "audioDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "audioDescription", value);
        }
    }

    /// <summary>
    /// Information about contacting staff at the facility
    /// </summary>
    public IReadOnlyList<string>? Contacts
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "contacts"); }
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
    /// General description of the facility
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
    /// General overview of how to get to the facility
    /// </summary>
    public string? DirectionsInfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "directionsInfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "directionsInfo", value);
        }
    }

    /// <summary>
    /// Link to page, if available, that provides additional detail on getting to
    /// the facility
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

    public IReadOnlyList<Image>? Images
    {
        get { return JsonModel.GetNullableClass<List<Image>>(this.RawData, "images"); }
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
    /// 0 or 1
    /// </summary>
    public bool? IsPassportStampLocation
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "isPassportStampLocation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isPassportStampLocation", value);
        }
    }

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
    /// Facility latitude and longitude
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

    public IReadOnlyList<DataMultimedia>? Multimedia
    {
        get { return JsonModel.GetNullableClass<List<DataMultimedia>>(this.RawData, "multimedia"); }
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
    /// Facility name
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
    /// Hours and seasons when the facility is open or closed
    /// </summary>
    public IReadOnlyList<OperatingHour>? OperatingHours
    {
        get
        {
            return JsonModel.GetNullableClass<List<OperatingHour>>(this.RawData, "operatingHours");
        }
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

    public IReadOnlyList<PassportStampImage>? PassportStampImages
    {
        get
        {
            return JsonModel.GetNullableClass<List<PassportStampImage>>(
                this.RawData,
                "passportStampImages"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "passportStampImages", value);
        }
    }

    public string? PassportStampLocationDescription
    {
        get
        {
            return JsonModel.GetNullableClass<string>(
                this.RawData,
                "passportStampLocationDescription"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "passportStampLocationDescription", value);
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
    /// The URL corresponding to the visitor center
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

    public ApiEnum<string, global::Nps.Models.Visitorcenters.Type>? Type
    {
        get
        {
            return JsonModel.GetNullableClass<
                ApiEnum<string, global::Nps.Models.Visitorcenters.Type>
            >(this.RawData, "type");
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

sealed class TypeConverter : JsonConverter<global::Nps.Models.Visitorcenters.Type>
{
    public override global::Nps.Models.Visitorcenters.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "Physical" => global::Nps.Models.Visitorcenters.Type.Physical,
            "Mailing" => global::Nps.Models.Visitorcenters.Type.Mailing,
            _ => (global::Nps.Models.Visitorcenters.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Nps.Models.Visitorcenters.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Nps.Models.Visitorcenters.Type.Physical => "Physical",
                global::Nps.Models.Visitorcenters.Type.Mailing => "Mailing",
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "altText", value);
        }
    }

    public string? Caption
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "caption", value);
        }
    }

    public string? Credit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "credit", value);
        }
    }

    public IReadOnlyList<JsonElement>? Crops
    {
        get { return JsonModel.GetNullableClass<List<JsonElement>>(this.RawData, "crops"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "crops", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Image(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public DataMultimedia() { }

    public DataMultimedia(DataMultimedia dataMultimedia)
        : base(dataMultimedia) { }

    public DataMultimedia(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataMultimedia(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public IReadOnlyList<Exception>? Exceptions
    {
        get { return JsonModel.GetNullableClass<List<Exception>>(this.RawData, "exceptions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "exceptions", value);
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

    public StandardHours? StandardHours
    {
        get { return JsonModel.GetNullableClass<StandardHours>(this.RawData, "standardHours"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "standardHours", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    OperatingHour(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableStruct<System::DateTimeOffset>(this.RawData, "endDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "endDate", value);
        }
    }

    public ExceptionHours? ExceptionHours
    {
        get { return JsonModel.GetNullableClass<ExceptionHours>(this.RawData, "exceptionHours"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "exceptionHours", value);
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

    public System::DateTimeOffset? StartDate
    {
        get
        {
            return JsonModel.GetNullableStruct<System::DateTimeOffset>(this.RawData, "startDate");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "startDate", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Exception(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "friday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "friday", value);
        }
    }

    public string? Monday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "monday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "monday", value);
        }
    }

    public string? Saturday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "saturday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "saturday", value);
        }
    }

    public string? Sunday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "sunday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "sunday", value);
        }
    }

    public string? Thursday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "thursday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "thursday", value);
        }
    }

    public string? Tuesday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "tuesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tuesday", value);
        }
    }

    public string? Wednesday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "wednesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "wednesday", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExceptionHours(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "friday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "friday", value);
        }
    }

    public string? Monday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "monday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "monday", value);
        }
    }

    public string? Saturday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "saturday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "saturday", value);
        }
    }

    public string? Sunday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "sunday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "sunday", value);
        }
    }

    public string? Thursday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "thursday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "thursday", value);
        }
    }

    public string? Tuesday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "tuesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tuesday", value);
        }
    }

    public string? Wednesday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "wednesday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "wednesday", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StandardHours(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "altText", value);
        }
    }

    public string? Caption
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "caption", value);
        }
    }

    public string? Credit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "credit", value);
        }
    }

    public IReadOnlyList<Crop>? Crops
    {
        get { return JsonModel.GetNullableClass<List<Crop>>(this.RawData, "crops"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "crops", value);
        }
    }

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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PassportStampImage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "aspectRatio"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "aspectRatio", value);
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
        _ = this.AspectRatio;
        _ = this.Url;
    }

    public Crop() { }

    public Crop(Crop crop)
        : base(crop) { }

    public Crop(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Crop(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
