using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.ThingsTodo;

[JsonConverter(typeof(JsonModelConverter<ThingsTodoListResponse, ThingsTodoListResponseFromRaw>))]
public sealed record class ThingsTodoListResponse : JsonModel
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

    public ThingsTodoListResponse() { }

    public ThingsTodoListResponse(ThingsTodoListResponse thingsTodoListResponse)
        : base(thingsTodoListResponse) { }

    public ThingsTodoListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ThingsTodoListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ThingsTodoListResponseFromRaw.FromRawUnchecked"/>
    public static ThingsTodoListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ThingsTodoListResponseFromRaw : IFromRawJson<ThingsTodoListResponse>
{
    /// <inheritdoc/>
    public ThingsTodoListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ThingsTodoListResponse.FromRawUnchecked(rawData);
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
    /// UUID for this Thing To Do
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

    public string? AccessibilityInformation
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "accessibilityInformation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "accessibilityInformation", value);
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

    public string? ActivityDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "activityDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "activityDescription", value);
        }
    }

    public string? Age
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "age"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "age", value);
        }
    }

    public string? AgeDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "ageDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "ageDescription", value);
        }
    }

    public string? ArePetsPermitted
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "arePetsPermitted"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "arePetsPermitted", value);
        }
    }

    /// <summary>
    /// true or false
    /// </summary>
    public string? ArePetsPermittedwithRestrictions
    {
        get
        {
            return JsonModel.GetNullableClass<string>(
                this.RawData,
                "arePetsPermittedwithRestrictions"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "arePetsPermittedwithRestrictions", value);
        }
    }

    /// <summary>
    /// true or false
    /// </summary>
    public string? DoFeesApply
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "doFeesApply"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "doFeesApply", value);
        }
    }

    /// <summary>
    /// estimated duration of this Thing To Do
    /// </summary>
    public string? Duration
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "duration"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "duration", value);
        }
    }

    public string? DurationDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "durationDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "durationDescription", value);
        }
    }

    public string? FeeDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "feeDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "feeDescription", value);
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
    /// true or false
    /// </summary>
    public string? IsReservationRequired
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "isReservationRequired"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isReservationRequired", value);
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

    public string? LocationDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "locationDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "locationDescription", value);
        }
    }

    public string? LongDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "longDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "longDescription", value);
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

    /// <summary>
    /// pet-related information for this Thing To Do
    /// </summary>
    public string? PetsDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "petsDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "petsDescription", value);
        }
    }

    public IReadOnlyList<JsonElement>? RelatedOrganizations
    {
        get
        {
            return JsonModel.GetNullableClass<List<JsonElement>>(
                this.RawData,
                "relatedOrganizations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedOrganizations", value);
        }
    }

    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get { return JsonModel.GetNullableClass<List<RelatedPark>>(this.RawData, "relatedParks"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedParks", value);
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

    public string? ReservationDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "reservationDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "reservationDescription", value);
        }
    }

    public IReadOnlyList<string>? Season
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "season"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "season", value);
        }
    }

    public string? SeasonDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "seasonDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "seasonDescription", value);
        }
    }

    public string? ShortDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "shortDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "shortDescription", value);
        }
    }

    /// <summary>
    /// comma separated list of tags
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

    public IReadOnlyList<string>? TimeOfDay
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "timeOfDay"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timeOfDay", value);
        }
    }

    public string? TimeOfDayDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "timeOfDayDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timeOfDayDescription", value);
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
    /// URL for this Thing To Do
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
        _ = this.AccessibilityInformation;
        foreach (var item in this.Activities ?? [])
        {
            item.Validate();
        }
        _ = this.ActivityDescription;
        _ = this.Age;
        _ = this.AgeDescription;
        _ = this.ArePetsPermitted;
        _ = this.ArePetsPermittedwithRestrictions;
        _ = this.DoFeesApply;
        _ = this.Duration;
        _ = this.DurationDescription;
        _ = this.FeeDescription;
        _ = this.GeometryPoiID;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
        _ = this.IsReservationRequired;
        _ = this.Latitude;
        _ = this.Location;
        _ = this.LocationDescription;
        _ = this.LongDescription;
        _ = this.Longitude;
        _ = this.PetsDescription;
        _ = this.RelatedOrganizations;
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        _ = this.RelevanceScore;
        _ = this.ReservationDescription;
        _ = this.Season;
        _ = this.SeasonDescription;
        _ = this.ShortDescription;
        _ = this.Tags;
        _ = this.TimeOfDay;
        _ = this.TimeOfDayDescription;
        _ = this.Title;
        foreach (var item in this.Topics ?? [])
        {
            item.Validate();
        }
        _ = this.Url;
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
    /// <summary>
    /// UUID for this activity
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
    /// name for this activity
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

[JsonConverter(typeof(JsonModelConverter<Image, ImageFromRaw>))]
public sealed record class Image : JsonModel
{
    /// <summary>
    /// alternate text for this image
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
    /// caption for this image
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
    /// credit for this image
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

    /// <summary>
    /// title for this image
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
    /// URL to this image
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
        foreach (var item in this.Crops ?? [])
        {
            item.Validate();
        }
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

[JsonConverter(typeof(JsonModelConverter<Crop, CropFromRaw>))]
public sealed record class Crop : JsonModel
{
    /// <summary>
    /// the image ratio for this cropped image
    /// </summary>
    public long? Aspectratio
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "aspectratio"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "aspectratio", value);
        }
    }

    /// <summary>
    /// URL for this cropped image
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
        _ = this.Aspectratio;
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

[JsonConverter(typeof(JsonModelConverter<RelatedPark, RelatedParkFromRaw>))]
public sealed record class RelatedPark : JsonModel
{
    /// <summary>
    /// designation of related park
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
    /// full name of related park
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
    /// name of related park
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
    /// four letter park code
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
    /// comma separated list of state codes
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

    /// <summary>
    /// URL of related park website
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
        _ = this.Designation;
        _ = this.FullName;
        _ = this.Name;
        _ = this.ParkCode;
        _ = this.States;
        _ = this.Url;
    }

    public RelatedPark() { }

    public RelatedPark(RelatedPark relatedPark)
        : base(relatedPark) { }

    public RelatedPark(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

[JsonConverter(typeof(JsonModelConverter<Topic, TopicFromRaw>))]
public sealed record class Topic : JsonModel
{
    /// <summary>
    /// UUID for this topic
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
    /// name for this topic
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
