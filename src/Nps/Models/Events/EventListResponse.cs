using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Events;

[JsonConverter(typeof(JsonModelConverter<EventListResponse, EventListResponseFromRaw>))]
public sealed record class EventListResponse : JsonModel
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

    public string? Dates
    {
        get { return this._rawData.GetNullableClass<string>("dates"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("dates", value);
        }
    }

    public IReadOnlyList<JsonElement>? Errors
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<JsonElement>>("errors"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<JsonElement>?>(
                "errors",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Pagenumber
    {
        get { return this._rawData.GetNullableClass<string>("pagenumber"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("pagenumber", value);
        }
    }

    public string? Pagesize
    {
        get { return this._rawData.GetNullableClass<string>("pagesize"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("pagesize", value);
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
        _ = this.Dates;
        _ = this.Errors;
        _ = this.Pagenumber;
        _ = this.Pagesize;
        _ = this.Total;
    }

    public EventListResponse() { }

    public EventListResponse(EventListResponse eventListResponse)
        : base(eventListResponse) { }

    public EventListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EventListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="EventListResponseFromRaw.FromRawUnchecked"/>
    public static EventListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class EventListResponseFromRaw : IFromRawJson<EventListResponse>
{
    /// <inheritdoc/>
    public EventListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        EventListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for this event
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
    /// Category for event
    /// </summary>
    public string? Category
    {
        get { return this._rawData.GetNullableClass<string>("category"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("category", value);
        }
    }

    public string? Categoryid
    {
        get { return this._rawData.GetNullableClass<string>("categoryid"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("categoryid", value);
        }
    }

    /// <summary>
    /// Email address for event contact
    /// </summary>
    public string? Contactemailaddress
    {
        get { return this._rawData.GetNullableClass<string>("contactemailaddress"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contactemailaddress", value);
        }
    }

    /// <summary>
    /// Name of event contact
    /// </summary>
    public string? Contactname
    {
        get { return this._rawData.GetNullableClass<string>("contactname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contactname", value);
        }
    }

    /// <summary>
    /// Phone number for event contact
    /// </summary>
    public string? ContacttelephoneNumber
    {
        get { return this._rawData.GetNullableClass<string>("contacttelephoneNumber"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contacttelephoneNumber", value);
        }
    }

    public string? Createuser
    {
        get { return this._rawData.GetNullableClass<string>("createuser"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("createuser", value);
        }
    }

    /// <summary>
    /// Date of next upcoming event
    /// </summary>
    public DateTimeOffset? Date
    {
        get { return this._rawData.GetNullableStruct<DateTimeOffset>("date"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("date", value);
        }
    }

    /// <summary>
    /// End date for event
    /// </summary>
    public DateTimeOffset? Dateend
    {
        get { return this._rawData.GetNullableStruct<DateTimeOffset>("dateend"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("dateend", value);
        }
    }

    /// <summary>
    /// Array of event dates
    /// </summary>
    public IReadOnlyList<DateTimeOffset>? Dates
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<DateTimeOffset>>("dates"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<DateTimeOffset>?>(
                "dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Start date for event
    /// </summary>
    public DateTimeOffset? Datestart
    {
        get { return this._rawData.GetNullableStruct<DateTimeOffset>("datestart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("datestart", value);
        }
    }

    public string? Datetimecreated
    {
        get { return this._rawData.GetNullableClass<string>("datetimecreated"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("datetimecreated", value);
        }
    }

    public string? Datetimeupdated
    {
        get { return this._rawData.GetNullableClass<string>("datetimeupdated"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("datetimeupdated", value);
        }
    }

    /// <summary>
    /// Event description
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

    public string? Eventid
    {
        get { return this._rawData.GetNullableClass<string>("eventid"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("eventid", value);
        }
    }

    /// <summary>
    /// Fee information for event
    /// </summary>
    public string? Feeinfo
    {
        get { return this._rawData.GetNullableClass<string>("feeinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("feeinfo", value);
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

    public string? Imageidlist
    {
        get { return this._rawData.GetNullableClass<string>("imageidlist"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("imageidlist", value);
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
    /// URL for more information about the event
    /// </summary>
    public string? Infourl
    {
        get { return this._rawData.GetNullableClass<string>("infourl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("infourl", value);
        }
    }

    /// <summary>
    /// The event takes place all day
    /// </summary>
    public string? Isallday
    {
        get { return this._rawData.GetNullableClass<string>("isallday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isallday", value);
        }
    }

    /// <summary>
    /// The event is free
    /// </summary>
    public string? Isfree
    {
        get { return this._rawData.GetNullableClass<string>("isfree"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isfree", value);
        }
    }

    /// <summary>
    /// The event has recurrence
    /// </summary>
    public string? Isrecurring
    {
        get { return this._rawData.GetNullableClass<string>("isrecurring"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isrecurring", value);
        }
    }

    /// <summary>
    /// The event requires registration or reservation
    /// </summary>
    public string? Isregresrequired
    {
        get { return this._rawData.GetNullableClass<string>("isregresrequired"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isregresrequired", value);
        }
    }

    /// <summary>
    /// The latitude of the event location
    /// </summary>
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
    /// The location the event takes place
    /// </summary>
    public string? Location
    {
        get { return this._rawData.GetNullableClass<string>("location"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("location", value);
        }
    }

    /// <summary>
    /// The longitude of the event location
    /// </summary>
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

    /// <summary>
    /// Name of the organization associated with event
    /// </summary>
    public string? Organizationname
    {
        get { return this._rawData.GetNullableClass<string>("organizationname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("organizationname", value);
        }
    }

    /// <summary>
    /// Name and designation of the park associated with event
    /// </summary>
    public string? Parkfullname
    {
        get { return this._rawData.GetNullableClass<string>("parkfullname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("parkfullname", value);
        }
    }

    /// <summary>
    /// Name of the portal site associated with event
    /// </summary>
    public string? Portalname
    {
        get { return this._rawData.GetNullableClass<string>("portalname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("portalname", value);
        }
    }

    /// <summary>
    /// Date the event recurrence ends
    /// </summary>
    public DateTimeOffset? Recurrencedateend
    {
        get { return this._rawData.GetNullableStruct<DateTimeOffset>("recurrencedateend"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("recurrencedateend", value);
        }
    }

    /// <summary>
    /// Date the event recurrence starts
    /// </summary>
    public DateTimeOffset? Recurrencedatestart
    {
        get { return this._rawData.GetNullableStruct<DateTimeOffset>("recurrencedatestart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("recurrencedatestart", value);
        }
    }

    /// <summary>
    /// Recurrence rule for event
    /// </summary>
    public string? Recurrencerule
    {
        get { return this._rawData.GetNullableClass<string>("recurrencerule"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("recurrencerule", value);
        }
    }

    /// <summary>
    /// Additional information on required reservation or registration for event
    /// </summary>
    public string? Regresinfo
    {
        get { return this._rawData.GetNullableClass<string>("regresinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("regresinfo", value);
        }
    }

    /// <summary>
    /// URL for required reservation or registration for event
    /// </summary>
    public string? Regresurl
    {
        get { return this._rawData.GetNullableClass<string>("regresurl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("regresurl", value);
        }
    }

    /// <summary>
    /// Site code of the associated site for event
    /// </summary>
    public string? Sitecode
    {
        get { return this._rawData.GetNullableClass<string>("sitecode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sitecode", value);
        }
    }

    /// <summary>
    /// Site type of the associated site for event
    /// </summary>
    public string? Sitetype
    {
        get { return this._rawData.GetNullableClass<string>("sitetype"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sitetype", value);
        }
    }

    /// <summary>
    /// Name of associated subject site for event
    /// </summary>
    public string? Subjectname
    {
        get { return this._rawData.GetNullableClass<string>("subjectname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("subjectname", value);
        }
    }

    /// <summary>
    /// Tags associated with event
    /// </summary>
    public IReadOnlyList<string>? Tags
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("tags"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "tags",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Additional information about times for event
    /// </summary>
    public string? Timeinfo
    {
        get { return this._rawData.GetNullableClass<string>("timeinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeinfo", value);
        }
    }

    /// <summary>
    /// Time information for event
    /// </summary>
    public IReadOnlyList<Time>? Times
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Time>>("times"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Time>?>(
                "times",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Event title
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
    /// Type(s) of event
    /// </summary>
    public IReadOnlyList<string>? Types
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("types"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "types",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Category;
        _ = this.Categoryid;
        _ = this.Contactemailaddress;
        _ = this.Contactname;
        _ = this.ContacttelephoneNumber;
        _ = this.Createuser;
        _ = this.Date;
        _ = this.Dateend;
        _ = this.Dates;
        _ = this.Datestart;
        _ = this.Datetimecreated;
        _ = this.Datetimeupdated;
        _ = this.Description;
        _ = this.Eventid;
        _ = this.Feeinfo;
        _ = this.GeometryPoiID;
        _ = this.Imageidlist;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
        _ = this.Infourl;
        _ = this.Isallday;
        _ = this.Isfree;
        _ = this.Isrecurring;
        _ = this.Isregresrequired;
        _ = this.Latitude;
        _ = this.Location;
        _ = this.Longitude;
        _ = this.Organizationname;
        _ = this.Parkfullname;
        _ = this.Portalname;
        _ = this.Recurrencedateend;
        _ = this.Recurrencedatestart;
        _ = this.Recurrencerule;
        _ = this.Regresinfo;
        _ = this.Regresurl;
        _ = this.Sitecode;
        _ = this.Sitetype;
        _ = this.Subjectname;
        _ = this.Tags;
        _ = this.Timeinfo;
        foreach (var item in this.Times ?? [])
        {
            item.Validate();
        }
        _ = this.Title;
        _ = this.Types;
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
/// Event image
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Image, ImageFromRaw>))]
public sealed record class Image : JsonModel
{
    /// <summary>
    /// Image alt text
    /// </summary>
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

    /// <summary>
    /// Image caption
    /// </summary>
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

    /// <summary>
    /// Image credit
    /// </summary>
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

    public string? ImageID
    {
        get { return this._rawData.GetNullableClass<string>("imageId"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("imageId", value);
        }
    }

    public string? Ordinal
    {
        get { return this._rawData.GetNullableClass<string>("ordinal"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("ordinal", value);
        }
    }

    public string? Path
    {
        get { return this._rawData.GetNullableClass<string>("path"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("path", value);
        }
    }

    /// <summary>
    /// Image title
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
    /// Image URL
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
        _ = this.AltText;
        _ = this.Caption;
        _ = this.Credit;
        _ = this.ImageID;
        _ = this.Ordinal;
        _ = this.Path;
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

[JsonConverter(typeof(JsonModelConverter<Time, TimeFromRaw>))]
public sealed record class Time : JsonModel
{
    /// <summary>
    /// Event begins at sunrise
    /// </summary>
    public string? Sunrisestart
    {
        get { return this._rawData.GetNullableClass<string>("sunrisestart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sunrisestart", value);
        }
    }

    /// <summary>
    /// Event ends at sunset
    /// </summary>
    public string? Sunsetend
    {
        get { return this._rawData.GetNullableClass<string>("sunsetend"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sunsetend", value);
        }
    }

    /// <summary>
    /// Time event ends
    /// </summary>
    public DateTimeOffset? Timeend
    {
        get { return this._rawData.GetNullableStruct<DateTimeOffset>("timeend"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeend", value);
        }
    }

    /// <summary>
    /// Time event begins
    /// </summary>
    public DateTimeOffset? Timestart
    {
        get { return this._rawData.GetNullableStruct<DateTimeOffset>("timestart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timestart", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Sunrisestart;
        _ = this.Sunsetend;
        _ = this.Timeend;
        _ = this.Timestart;
    }

    public Time() { }

    public Time(Time time)
        : base(time) { }

    public Time(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Time(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TimeFromRaw.FromRawUnchecked"/>
    public static Time FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TimeFromRaw : IFromRawJson<Time>
{
    /// <inheritdoc/>
    public Time FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Time.FromRawUnchecked(rawData);
}
