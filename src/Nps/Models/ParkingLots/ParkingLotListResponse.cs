using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;
using Nps.Exceptions;
using System = System;

namespace Nps.Models.ParkingLots;

[JsonConverter(typeof(JsonModelConverter<ParkingLotListResponse, ParkingLotListResponseFromRaw>))]
public sealed record class ParkingLotListResponse : JsonModel
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

    public ParkingLotListResponse() { }

    public ParkingLotListResponse(ParkingLotListResponse parkingLotListResponse)
        : base(parkingLotListResponse) { }

    public ParkingLotListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ParkingLotListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ParkingLotListResponseFromRaw.FromRawUnchecked"/>
    public static ParkingLotListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ParkingLotListResponseFromRaw : IFromRawJson<ParkingLotListResponse>
{
    /// <inheritdoc/>
    public ParkingLotListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ParkingLotListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the parking lot
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
    /// alternative names for this parklinglot
    /// </summary>
    public string? AltName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("altName");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("altName", value);
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
    /// General description of the parkinglot
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

    public IReadOnlyList<Fee>? Fees
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Fee>>("fees");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Fee>?>(
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

    public IReadOnlyList<JsonElement>? Images
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<JsonElement>>("images");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<JsonElement>?>(
                "images",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// The latitude of the parkinglot location
    /// </summary>
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

    public LiveStatus? LiveStatus
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<LiveStatus>("liveStatus");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("liveStatus", value);
        }
    }

    /// <summary>
    /// The longitude of the parkinglot location
    /// </summary>
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

    /// <summary>
    /// which organization manages this parkinglot
    /// </summary>
    public string? ManagedByOrganization
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("managedByOrganization");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("managedByOrganization", value);
        }
    }

    /// <summary>
    /// Parkinglot name
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
    /// the operating hours for this parkinglot
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
    /// which parks are associated with this parkinglot
    /// </summary>
    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<RelatedPark>>("relatedParks");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<RelatedPark>?>(
                "relatedParks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// the time zone in which this parkinglot is found
    /// </summary>
    public string? TimeZone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("timeZone");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeZone", value);
        }
    }

    /// <summary>
    /// URL of parkinglot webcam
    /// </summary>
    public string? WebcamUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("webcamUrl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("webcamUrl", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Accessibility?.Validate();
        _ = this.AltName;
        this.Contacts?.Validate();
        _ = this.Description;
        foreach (var item in this.Fees ?? [])
        {
            item.Validate();
        }
        _ = this.GeometryPoiID;
        _ = this.Images;
        _ = this.Latitude;
        this.LiveStatus?.Validate();
        _ = this.Longitude;
        _ = this.ManagedByOrganization;
        _ = this.Name;
        foreach (var item in this.OperatingHours ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        _ = this.TimeZone;
        _ = this.WebcamUrl;
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

[JsonConverter(typeof(JsonModelConverter<Accessibility, AccessibilityFromRaw>))]
public sealed record class Accessibility : JsonModel
{
    public string? AdaFacilitiesDescription
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("adaFacilitiesDescription");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("adaFacilitiesDescription", value);
        }
    }

    public bool? IsLotAccessibleToDisabled
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("isLotAccessibleToDisabled");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isLotAccessibleToDisabled", value);
        }
    }

    public long? NumberofAdaSpaces
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("numberofAdaSpaces");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("numberofAdaSpaces", value);
        }
    }

    public long? NumberofAdaStepFreeSpaces
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("numberofAdaStepFreeSpaces");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("numberofAdaStepFreeSpaces", value);
        }
    }

    public long? NumberofAdaVanAccessbileSpaces
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("numberofAdaVanAccessbileSpaces");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("numberofAdaVanAccessbileSpaces", value);
        }
    }

    public long? NumberOfOversizeVehicleSpaces
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("numberOfOversizeVehicleSpaces");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("numberOfOversizeVehicleSpaces", value);
        }
    }

    public long? TotalSpaces
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("totalSpaces");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("totalSpaces", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AdaFacilitiesDescription;
        _ = this.IsLotAccessibleToDisabled;
        _ = this.NumberofAdaSpaces;
        _ = this.NumberofAdaStepFreeSpaces;
        _ = this.NumberofAdaVanAccessbileSpaces;
        _ = this.NumberOfOversizeVehicleSpaces;
        _ = this.TotalSpaces;
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

    public ApiEnum<string, global::Nps.Models.ParkingLots.Type>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::Nps.Models.ParkingLots.Type>
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

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Voice,
    Fax,
    Tty,
}

sealed class TypeConverter : JsonConverter<global::Nps.Models.ParkingLots.Type>
{
    public override global::Nps.Models.ParkingLots.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "Voice" => global::Nps.Models.ParkingLots.Type.Voice,
            "Fax" => global::Nps.Models.ParkingLots.Type.Fax,
            "TTY" => global::Nps.Models.ParkingLots.Type.Tty,
            _ => (global::Nps.Models.ParkingLots.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Nps.Models.ParkingLots.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Nps.Models.ParkingLots.Type.Voice => "Voice",
                global::Nps.Models.ParkingLots.Type.Fax => "Fax",
                global::Nps.Models.ParkingLots.Type.Tty => "TTY",
                _ => throw new NpsInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Fee, FeeFromRaw>))]
public sealed record class Fee : JsonModel
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

    public Fee() { }

    public Fee(Fee fee)
        : base(fee) { }

    public Fee(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Fee(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FeeFromRaw.FromRawUnchecked"/>
    public static Fee FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FeeFromRaw : IFromRawJson<Fee>
{
    /// <inheritdoc/>
    public Fee FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Fee.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<LiveStatus, LiveStatusFromRaw>))]
public sealed record class LiveStatus : JsonModel
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

    public long? EstimatedWaitTimeInMinutes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("estimatedWaitTimeInMinutes");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("estimatedWaitTimeInMinutes", value);
        }
    }

    public string? ExpirationDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("expirationDate");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("expirationDate", value);
        }
    }

    public bool? IsActive
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("isActive");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isActive", value);
        }
    }

    public string? Occupancy
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("occupancy");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("occupancy", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Description;
        _ = this.EstimatedWaitTimeInMinutes;
        _ = this.ExpirationDate;
        _ = this.IsActive;
        _ = this.Occupancy;
    }

    public LiveStatus() { }

    public LiveStatus(LiveStatus liveStatus)
        : base(liveStatus) { }

    public LiveStatus(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LiveStatus(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LiveStatusFromRaw.FromRawUnchecked"/>
    public static LiveStatus FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LiveStatusFromRaw : IFromRawJson<LiveStatus>
{
    /// <inheritdoc/>
    public LiveStatus FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        LiveStatus.FromRawUnchecked(rawData);
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
    public string? EndDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("endDate");
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

    public string? StartDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("startDate");
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

[JsonConverter(typeof(JsonModelConverter<RelatedPark, RelatedParkFromRaw>))]
public sealed record class RelatedPark : JsonModel
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

    public string? State
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("state");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("state", value);
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
        _ = this.Designation;
        _ = this.FullName;
        _ = this.Name;
        _ = this.ParkCode;
        _ = this.State;
        _ = this.Url;
    }

    public RelatedPark() { }

    public RelatedPark(RelatedPark relatedPark)
        : base(relatedPark) { }

    public RelatedPark(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RelatedParkFromRaw.FromRawUnchecked"/>
    public static RelatedPark FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RelatedParkFromRaw : IFromRawJson<RelatedPark>
{
    /// <inheritdoc/>
    public RelatedPark FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        RelatedPark.FromRawUnchecked(rawData);
}
