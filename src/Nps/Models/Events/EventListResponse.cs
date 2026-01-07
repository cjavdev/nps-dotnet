using System;
using System.Collections.Frozen;
using System.Collections.Generic;
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

    public string? Dates
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "dates"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "dates", value);
        }
    }

    public IReadOnlyList<JsonElement>? Errors
    {
        get { return JsonModel.GetNullableClass<List<JsonElement>>(this.RawData, "errors"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "errors", value);
        }
    }

    public string? Pagenumber
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "pagenumber"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "pagenumber", value);
        }
    }

    public string? Pagesize
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "pagesize"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "pagesize", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EventListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
    /// Category for event
    /// </summary>
    public string? Category
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "category"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "category", value);
        }
    }

    public string? Categoryid
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "categoryid"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "categoryid", value);
        }
    }

    /// <summary>
    /// Email address for event contact
    /// </summary>
    public string? Contactemailaddress
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "contactemailaddress"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contactemailaddress", value);
        }
    }

    /// <summary>
    /// Name of event contact
    /// </summary>
    public string? Contactname
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "contactname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contactname", value);
        }
    }

    /// <summary>
    /// Phone number for event contact
    /// </summary>
    public string? ContacttelephoneNumber
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "contacttelephoneNumber"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contacttelephoneNumber", value);
        }
    }

    public string? Createuser
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "createuser"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "createuser", value);
        }
    }

    /// <summary>
    /// Date of next upcoming event
    /// </summary>
    public DateTimeOffset? Date
    {
        get { return JsonModel.GetNullableStruct<DateTimeOffset>(this.RawData, "date"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "date", value);
        }
    }

    /// <summary>
    /// End date for event
    /// </summary>
    public DateTimeOffset? Dateend
    {
        get { return JsonModel.GetNullableStruct<DateTimeOffset>(this.RawData, "dateend"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "dateend", value);
        }
    }

    /// <summary>
    /// Array of event dates
    /// </summary>
    public IReadOnlyList<DateTimeOffset>? Dates
    {
        get { return JsonModel.GetNullableClass<List<DateTimeOffset>>(this.RawData, "dates"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "dates", value);
        }
    }

    /// <summary>
    /// Start date for event
    /// </summary>
    public DateTimeOffset? Datestart
    {
        get { return JsonModel.GetNullableStruct<DateTimeOffset>(this.RawData, "datestart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "datestart", value);
        }
    }

    public string? Datetimecreated
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "datetimecreated"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "datetimecreated", value);
        }
    }

    public string? Datetimeupdated
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "datetimeupdated"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "datetimeupdated", value);
        }
    }

    /// <summary>
    /// Event description
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

    public string? Eventid
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "eventid"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "eventid", value);
        }
    }

    /// <summary>
    /// Fee information for event
    /// </summary>
    public string? Feeinfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "feeinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "feeinfo", value);
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

    public string? Imageidlist
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "imageidlist"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "imageidlist", value);
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
    /// URL for more information about the event
    /// </summary>
    public string? Infourl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "infourl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "infourl", value);
        }
    }

    /// <summary>
    /// The event takes place all day
    /// </summary>
    public string? Isallday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "isallday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isallday", value);
        }
    }

    /// <summary>
    /// The event is free
    /// </summary>
    public string? Isfree
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "isfree"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isfree", value);
        }
    }

    /// <summary>
    /// The event has recurrence
    /// </summary>
    public string? Isrecurring
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "isrecurring"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isrecurring", value);
        }
    }

    /// <summary>
    /// The event requires registration or reservation
    /// </summary>
    public string? Isregresrequired
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "isregresrequired"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isregresrequired", value);
        }
    }

    /// <summary>
    /// The latitude of the event location
    /// </summary>
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
    /// The location the event takes place
    /// </summary>
    public string? Location
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "location"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "location", value);
        }
    }

    /// <summary>
    /// The longitude of the event location
    /// </summary>
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

    /// <summary>
    /// Name of the organization associated with event
    /// </summary>
    public string? Organizationname
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "organizationname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "organizationname", value);
        }
    }

    /// <summary>
    /// Name and designation of the park associated with event
    /// </summary>
    public string? Parkfullname
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "parkfullname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parkfullname", value);
        }
    }

    /// <summary>
    /// Name of the portal site associated with event
    /// </summary>
    public string? Portalname
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "portalname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "portalname", value);
        }
    }

    /// <summary>
    /// Date the event recurrence ends
    /// </summary>
    public DateTimeOffset? Recurrencedateend
    {
        get
        {
            return JsonModel.GetNullableStruct<DateTimeOffset>(this.RawData, "recurrencedateend");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "recurrencedateend", value);
        }
    }

    /// <summary>
    /// Date the event recurrence starts
    /// </summary>
    public DateTimeOffset? Recurrencedatestart
    {
        get
        {
            return JsonModel.GetNullableStruct<DateTimeOffset>(this.RawData, "recurrencedatestart");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "recurrencedatestart", value);
        }
    }

    /// <summary>
    /// Recurrence rule for event
    /// </summary>
    public string? Recurrencerule
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "recurrencerule"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "recurrencerule", value);
        }
    }

    /// <summary>
    /// Additional information on required reservation or registration for event
    /// </summary>
    public string? Regresinfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "regresinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "regresinfo", value);
        }
    }

    /// <summary>
    /// URL for required reservation or registration for event
    /// </summary>
    public string? Regresurl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "regresurl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "regresurl", value);
        }
    }

    /// <summary>
    /// Site code of the associated site for event
    /// </summary>
    public string? Sitecode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "sitecode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "sitecode", value);
        }
    }

    /// <summary>
    /// Site type of the associated site for event
    /// </summary>
    public string? Sitetype
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "sitetype"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "sitetype", value);
        }
    }

    /// <summary>
    /// Name of associated subject site for event
    /// </summary>
    public string? Subjectname
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "subjectname"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "subjectname", value);
        }
    }

    /// <summary>
    /// Tags associated with event
    /// </summary>
    public IReadOnlyList<string>? Tags
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "tags"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tags", value);
        }
    }

    /// <summary>
    /// Additional information about times for event
    /// </summary>
    public string? Timeinfo
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "timeinfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timeinfo", value);
        }
    }

    /// <summary>
    /// Time information for event
    /// </summary>
    public IReadOnlyList<Time>? Times
    {
        get { return JsonModel.GetNullableClass<List<Time>>(this.RawData, "times"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "times", value);
        }
    }

    /// <summary>
    /// Event title
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
    /// Type(s) of event
    /// </summary>
    public IReadOnlyList<string>? Types
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "types"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "types", value);
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

    /// <summary>
    /// Image caption
    /// </summary>
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

    /// <summary>
    /// Image credit
    /// </summary>
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

    public string? ImageID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "imageId"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "imageId", value);
        }
    }

    public string? Ordinal
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "ordinal"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "ordinal", value);
        }
    }

    public string? Path
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "path"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "path", value);
        }
    }

    /// <summary>
    /// Image title
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
    /// Image URL
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

[JsonConverter(typeof(JsonModelConverter<Time, TimeFromRaw>))]
public sealed record class Time : JsonModel
{
    /// <summary>
    /// Event begins at sunrise
    /// </summary>
    public string? Sunrisestart
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "sunrisestart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "sunrisestart", value);
        }
    }

    /// <summary>
    /// Event ends at sunset
    /// </summary>
    public string? Sunsetend
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "sunsetend"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "sunsetend", value);
        }
    }

    /// <summary>
    /// Time event ends
    /// </summary>
    public DateTimeOffset? Timeend
    {
        get { return JsonModel.GetNullableStruct<DateTimeOffset>(this.RawData, "timeend"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timeend", value);
        }
    }

    /// <summary>
    /// Time event begins
    /// </summary>
    public DateTimeOffset? Timestart
    {
        get { return JsonModel.GetNullableStruct<DateTimeOffset>(this.RawData, "timestart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timestart", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Time(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
