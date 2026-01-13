using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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

    public ThingsTodoListResponse() { }

    public ThingsTodoListResponse(ThingsTodoListResponse thingsTodoListResponse)
        : base(thingsTodoListResponse) { }

    public ThingsTodoListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ThingsTodoListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
    /// <summary>
    /// UUID for this Thing To Do
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

    public string? AccessibilityInformation
    {
        get { return this._rawData.GetNullableClass<string>("accessibilityInformation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("accessibilityInformation", value);
        }
    }

    public IReadOnlyList<Activity>? Activities
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Activity>>("activities"); }
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

    public string? ActivityDescription
    {
        get { return this._rawData.GetNullableClass<string>("activityDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("activityDescription", value);
        }
    }

    public string? Age
    {
        get { return this._rawData.GetNullableClass<string>("age"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("age", value);
        }
    }

    public string? AgeDescription
    {
        get { return this._rawData.GetNullableClass<string>("ageDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("ageDescription", value);
        }
    }

    public string? ArePetsPermitted
    {
        get { return this._rawData.GetNullableClass<string>("arePetsPermitted"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("arePetsPermitted", value);
        }
    }

    /// <summary>
    /// true or false
    /// </summary>
    public string? ArePetsPermittedwithRestrictions
    {
        get { return this._rawData.GetNullableClass<string>("arePetsPermittedwithRestrictions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("arePetsPermittedwithRestrictions", value);
        }
    }

    /// <summary>
    /// true or false
    /// </summary>
    public string? DoFeesApply
    {
        get { return this._rawData.GetNullableClass<string>("doFeesApply"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("doFeesApply", value);
        }
    }

    /// <summary>
    /// estimated duration of this Thing To Do
    /// </summary>
    public string? Duration
    {
        get { return this._rawData.GetNullableClass<string>("duration"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("duration", value);
        }
    }

    public string? DurationDescription
    {
        get { return this._rawData.GetNullableClass<string>("durationDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("durationDescription", value);
        }
    }

    public string? FeeDescription
    {
        get { return this._rawData.GetNullableClass<string>("feeDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("feeDescription", value);
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
    /// true or false
    /// </summary>
    public string? IsReservationRequired
    {
        get { return this._rawData.GetNullableClass<string>("isReservationRequired"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isReservationRequired", value);
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

    public string? LocationDescription
    {
        get { return this._rawData.GetNullableClass<string>("locationDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("locationDescription", value);
        }
    }

    public string? LongDescription
    {
        get { return this._rawData.GetNullableClass<string>("longDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("longDescription", value);
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

    /// <summary>
    /// pet-related information for this Thing To Do
    /// </summary>
    public string? PetsDescription
    {
        get { return this._rawData.GetNullableClass<string>("petsDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("petsDescription", value);
        }
    }

    public IReadOnlyList<JsonElement>? RelatedOrganizations
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<JsonElement>>(
                "relatedOrganizations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<JsonElement>?>(
                "relatedOrganizations",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<RelatedPark>>("relatedParks"); }
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

    public string? ReservationDescription
    {
        get { return this._rawData.GetNullableClass<string>("reservationDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("reservationDescription", value);
        }
    }

    public IReadOnlyList<string>? Season
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("season"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "season",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? SeasonDescription
    {
        get { return this._rawData.GetNullableClass<string>("seasonDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("seasonDescription", value);
        }
    }

    public string? ShortDescription
    {
        get { return this._rawData.GetNullableClass<string>("shortDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("shortDescription", value);
        }
    }

    /// <summary>
    /// comma separated list of tags
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

    public IReadOnlyList<string>? TimeOfDay
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("timeOfDay"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "timeOfDay",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? TimeOfDayDescription
    {
        get { return this._rawData.GetNullableClass<string>("timeOfDayDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeOfDayDescription", value);
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

    public IReadOnlyList<Topic>? Topics
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Topic>>("topics"); }
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
    /// URL for this Thing To Do
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
    /// <summary>
    /// UUID for this activity
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
    /// name for this activity
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

[JsonConverter(typeof(JsonModelConverter<Image, ImageFromRaw>))]
public sealed record class Image : JsonModel
{
    /// <summary>
    /// alternate text for this image
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
    /// caption for this image
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
    /// credit for this image
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

    /// <summary>
    /// title for this image
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
    /// URL to this image
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

[JsonConverter(typeof(JsonModelConverter<Crop, CropFromRaw>))]
public sealed record class Crop : JsonModel
{
    /// <summary>
    /// the image ratio for this cropped image
    /// </summary>
    public long? Aspectratio
    {
        get { return this._rawData.GetNullableStruct<long>("aspectratio"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("aspectratio", value);
        }
    }

    /// <summary>
    /// URL for this cropped image
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
        _ = this.Aspectratio;
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

[JsonConverter(typeof(JsonModelConverter<RelatedPark, RelatedParkFromRaw>))]
public sealed record class RelatedPark : JsonModel
{
    /// <summary>
    /// designation of related park
    /// </summary>
    public string? Designation
    {
        get { return this._rawData.GetNullableClass<string>("designation"); }
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
    /// full name of related park
    /// </summary>
    public string? FullName
    {
        get { return this._rawData.GetNullableClass<string>("fullName"); }
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
    /// name of related park
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
    /// four letter park code
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

    /// <summary>
    /// comma separated list of state codes
    /// </summary>
    public string? States
    {
        get { return this._rawData.GetNullableClass<string>("states"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("states", value);
        }
    }

    /// <summary>
    /// URL of related park website
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

[JsonConverter(typeof(JsonModelConverter<Topic, TopicFromRaw>))]
public sealed record class Topic : JsonModel
{
    /// <summary>
    /// UUID for this topic
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
    /// name for this topic
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
