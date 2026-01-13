using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Webcams;

[JsonConverter(typeof(JsonModelConverter<WebcamListResponse, WebcamListResponseFromRaw>))]
public sealed record class WebcamListResponse : JsonModel
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

    public WebcamListResponse() { }

    public WebcamListResponse(WebcamListResponse webcamListResponse)
        : base(webcamListResponse) { }

    public WebcamListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebcamListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebcamListResponseFromRaw.FromRawUnchecked"/>
    public static WebcamListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebcamListResponseFromRaw : IFromRawJson<WebcamListResponse>
{
    /// <inheritdoc/>
    public WebcamListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WebcamListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
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

    public bool? IsStreaming
    {
        get { return this._rawData.GetNullableStruct<bool>("isStreaming"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isStreaming", value);
        }
    }

    public double? Latitude
    {
        get { return this._rawData.GetNullableStruct<double>("latitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("latitude", value);
        }
    }

    public double? Longitude
    {
        get { return this._rawData.GetNullableStruct<double>("longitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("longitude", value);
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

    public string? Status
    {
        get { return this._rawData.GetNullableClass<string>("status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status", value);
        }
    }

    public string? StatusMessage
    {
        get { return this._rawData.GetNullableClass<string>("statusMessage"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("statusMessage", value);
        }
    }

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
    /// URL corresponding to this webcam
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
        _ = this.Description;
        _ = this.GeometryPoiID;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
        _ = this.IsStreaming;
        _ = this.Latitude;
        _ = this.Longitude;
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        _ = this.Status;
        _ = this.StatusMessage;
        _ = this.Tags;
        _ = this.Title;
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

[JsonConverter(typeof(JsonModelConverter<RelatedPark, RelatedParkFromRaw>))]
public sealed record class RelatedPark : JsonModel
{
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
