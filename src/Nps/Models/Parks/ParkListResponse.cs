using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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

    public ParkListResponse() { }

    public ParkListResponse(ParkListResponse parkListResponse)
        : base(parkListResponse) { }

    public ParkListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ParkListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
    /// <summary>
    /// Park identification string
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

    public IReadOnlyList<Activity>? Activities
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Activity>>("activities");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Activity>?>(
                "activities",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Park addresses (physical and mailing)
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
    /// Information about contacting the park
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
    /// Introductory paragraph from the park homepage
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
    /// Type of designation (eg, national park, national monument, national recreation
    /// area, etc)
    /// </summary>
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

    /// <summary>
    /// General overview of how to get to the park
    /// </summary>
    public string? DirectionsInfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("directionsInfo");
        }
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
    /// the park
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
    /// Fee for entering the park
    /// </summary>
    public IReadOnlyList<EntranceFee>? EntranceFees
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<EntranceFee>>("entranceFees");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<EntranceFee>?>(
                "entranceFees",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Passes available to provide entry into the park
    /// </summary>
    public IReadOnlyList<EntrancePass>? EntrancePasses
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<EntrancePass>>("entrancePasses");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<EntrancePass>?>(
                "entrancePasses",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Full park name (with designation)
    /// </summary>
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

    /// <summary>
    /// Park images
    /// </summary>
    public IReadOnlyList<Image>? Images
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Image>>("images");
        }
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
    /// Park GPS cordinates
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
    /// Short park name (no designation)
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
    /// Hours and seasons when the park is open or closed
    /// </summary>
    public IReadOnlyList<OperatingHour>? OperatingHours
    {
        get
        {
            this._rawData.Freeze();
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
    /// State(s) the park is located in (comma-delimited list)
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

    public IReadOnlyList<Topic>? Topics
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Topic>>("topics");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Topic>?>(
                "topics",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Park Website
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

    /// <summary>
    /// General description of the weather in the park over the course of a year
    /// </summary>
    public string? WeatherInfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("weatherInfo");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("weatherInfo", value);
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

[JsonConverter(typeof(JsonModelConverter<Activity, ActivityFromRaw>))]
public sealed record class Activity : JsonModel
{
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Activity(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

    public ApiEnum<string, global::Nps.Models.Parks.Type>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, global::Nps.Models.Parks.Type>>(
                "type"
            );
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

[JsonConverter(typeof(JsonModelConverter<EntranceFee, EntranceFeeFromRaw>))]
public sealed record class EntranceFee : JsonModel
{
    public string? Cost
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("cost");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cost", value);
        }
    }

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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EntranceFee(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("cost");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cost", value);
        }
    }

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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EntrancePass(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("altText");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("caption");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("credit");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("credit", value);
        }
    }

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

[JsonConverter(typeof(JsonModelConverter<OperatingHour, OperatingHourFromRaw>))]
public sealed record class OperatingHour : JsonModel
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

    public IReadOnlyList<Exception>? Exceptions
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Exception>>("exceptions");
        }
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

    public StandardHours? StandardHours
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<StandardHours>("standardHours");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<System::DateTimeOffset>("endDate");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ExceptionHours>("exceptionHours");
        }
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

    public System::DateTimeOffset? StartDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<System::DateTimeOffset>("startDate");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("friday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("monday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("saturday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("sunday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("thursday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("tuesday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("wednesday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("friday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("monday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("saturday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("sunday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("thursday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("tuesday");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("wednesday");
        }
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

[JsonConverter(typeof(JsonModelConverter<Topic, TopicFromRaw>))]
public sealed record class Topic : JsonModel
{
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Topic(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
