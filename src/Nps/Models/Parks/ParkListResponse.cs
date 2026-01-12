using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;
using Nps.Exceptions;
using System = System;

namespace Nps.Models.Parks;

[JsonConverter(typeof(JsonModelConverter<ParkListResponse, ParkListResponseFromRaw>))]
public sealed record class ParkListResponse : JsonModel
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

    public ParkListResponse() { }

    public ParkListResponse(ParkListResponse parkListResponse)
        : base(parkListResponse) { }

    public ParkListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ParkListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ParkListResponseFromRaw.FromRawUnchecked"/>
    public static ParkListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ParkListResponseFromRaw : IFromRawJson<ParkListResponse>
{
    /// <inheritdoc/>
    public ParkListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ParkListResponse.FromRawUnchecked(rawData);
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
    /// Park identification string
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

    public IReadOnlyList<Activity>? Activities
    {
        get { return JsonModel.GetNullableClass<List<Activity>>(this.RawData, "activities"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "activities", value);
        }
    }

    /// <summary>
    /// Park addresses (physical and mailing)
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
    /// Information about contacting the park
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
    /// Introductory paragraph from the park homepage
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
    /// Type of designation (eg, national park, national monument, national recreation
    /// area, etc)
    /// </summary>
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

    /// <summary>
    /// General overview of how to get to the park
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
    /// the park
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
    /// Fee for entering the park
    /// </summary>
    public IReadOnlyList<EntranceFee>? EntranceFees
    {
        get { return JsonModel.GetNullableClass<List<EntranceFee>>(this.RawData, "entranceFees"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "entranceFees", value);
        }
    }

    /// <summary>
    /// Passes available to provide entry into the park
    /// </summary>
    public IReadOnlyList<EntrancePass>? EntrancePasses
    {
        get
        {
            return JsonModel.GetNullableClass<List<EntrancePass>>(this.RawData, "entrancePasses");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "entrancePasses", value);
        }
    }

    /// <summary>
    /// Full park name (with designation)
    /// </summary>
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

    /// <summary>
    /// Park images
    /// </summary>
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
    /// Park GPS cordinates
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
    /// Short park name (no designation)
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
    /// Hours and seasons when the park is open or closed
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
    /// State(s) the park is located in (comma-delimited list)
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

    public IReadOnlyList<Topic>? Topics
    {
        get { return JsonModel.GetNullableClass<List<Topic>>(this.RawData, "topics"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "topics", value);
        }
    }

    /// <summary>
    /// Park Website
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

    /// <summary>
    /// General description of the weather in the park over the course of a year
    /// </summary>
    public string? WeatherInfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "weatherInfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "weatherInfo", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        foreach (var item in this.Activities ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.Addresses ?? [])
        {
            item.Validate();
        }
        this.Contacts?.Validate();
        _ = this.Description;
        _ = this.Designation;
        _ = this.DirectionsInfo;
        _ = this.DirectionsUrl;
        foreach (var item in this.EntranceFees ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.EntrancePasses ?? [])
        {
            item.Validate();
        }
        _ = this.FullName;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
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
        _ = this.RelevanceScore;
        _ = this.States;
        foreach (var item in this.Topics ?? [])
        {
            item.Validate();
        }
        _ = this.Url;
        _ = this.WeatherInfo;
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

[JsonConverter(typeof(JsonModelConverter<Activity, ActivityFromRaw>))]
public sealed record class Activity : JsonModel
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Name;
    }

    public Activity() { }

    public Activity(Activity activity)
        : base(activity) { }

    public Activity(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Activity(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ActivityFromRaw.FromRawUnchecked"/>
    public static Activity FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ActivityFromRaw : IFromRawJson<Activity>
{
    /// <inheritdoc/>
    public Activity FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Activity.FromRawUnchecked(rawData);
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

    public ApiEnum<string, global::Nps.Models.Parks.Type>? Type
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, global::Nps.Models.Parks.Type>>(
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

sealed class TypeConverter : JsonConverter<global::Nps.Models.Parks.Type>
{
    public override global::Nps.Models.Parks.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "Physical" => global::Nps.Models.Parks.Type.Physical,
            "Mailing" => global::Nps.Models.Parks.Type.Mailing,
            _ => (global::Nps.Models.Parks.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Nps.Models.Parks.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Nps.Models.Parks.Type.Physical => "Physical",
                global::Nps.Models.Parks.Type.Mailing => "Mailing",
                _ => throw new NpsInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Information about contacting the park
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

[JsonConverter(typeof(JsonModelConverter<EntranceFee, EntranceFeeFromRaw>))]
public sealed record class EntranceFee : JsonModel
{
    public string? Cost
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cost", value);
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Cost;
        _ = this.Description;
        _ = this.Title;
    }

    public EntranceFee() { }

    public EntranceFee(EntranceFee entranceFee)
        : base(entranceFee) { }

    public EntranceFee(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EntranceFee(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="EntranceFeeFromRaw.FromRawUnchecked"/>
    public static EntranceFee FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class EntranceFeeFromRaw : IFromRawJson<EntranceFee>
{
    /// <inheritdoc/>
    public EntranceFee FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        EntranceFee.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<EntrancePass, EntrancePassFromRaw>))]
public sealed record class EntrancePass : JsonModel
{
    public string? Cost
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cost", value);
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Cost;
        _ = this.Description;
        _ = this.Title;
    }

    public EntrancePass() { }

    public EntrancePass(EntrancePass entrancePass)
        : base(entrancePass) { }

    public EntrancePass(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EntrancePass(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="EntrancePassFromRaw.FromRawUnchecked"/>
    public static EntrancePass FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class EntrancePassFromRaw : IFromRawJson<EntrancePass>
{
    /// <inheritdoc/>
    public EntrancePass FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        EntrancePass.FromRawUnchecked(rawData);
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

[JsonConverter(typeof(JsonModelConverter<Topic, TopicFromRaw>))]
public sealed record class Topic : JsonModel
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Name;
    }

    public Topic() { }

    public Topic(Topic topic)
        : base(topic) { }

    public Topic(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Topic(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TopicFromRaw.FromRawUnchecked"/>
    public static Topic FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TopicFromRaw : IFromRawJson<Topic>
{
    /// <inheritdoc/>
    public Topic FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Topic.FromRawUnchecked(rawData);
}
