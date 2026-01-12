using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Multimedia.Galleries;

[JsonConverter(typeof(JsonModelConverter<GalleryListResponse, GalleryListResponseFromRaw>))]
public sealed record class GalleryListResponse : JsonModel
{
    public IReadOnlyList<global::Nps.Models.Multimedia.Galleries.Data>? Data
    {
        get
        {
            return JsonModel.GetNullableClass<List<global::Nps.Models.Multimedia.Galleries.Data>>(
                this.RawData,
                "data"
            );
        }
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

    public GalleryListResponse() { }

    public GalleryListResponse(GalleryListResponse galleryListResponse)
        : base(galleryListResponse) { }

    public GalleryListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="GalleryListResponseFromRaw.FromRawUnchecked"/>
    public static GalleryListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class GalleryListResponseFromRaw : IFromRawJson<GalleryListResponse>
{
    /// <inheritdoc/>
    public GalleryListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        GalleryListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        global::Nps.Models.Multimedia.Galleries.Data,
        global::Nps.Models.Multimedia.Galleries.DataFromRaw
    >)
)]
public sealed record class Data : JsonModel
{
    public IReadOnlyList<global::Nps.Models.Multimedia.Galleries.DataData>? DataValue
    {
        get
        {
            return JsonModel.GetNullableClass<
                List<global::Nps.Models.Multimedia.Galleries.DataData>
            >(this.RawData, "data");
        }
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

    public Data(global::Nps.Models.Multimedia.Galleries.Data data)
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

    /// <inheritdoc cref="global::Nps.Models.Multimedia.Galleries.DataFromRaw.FromRawUnchecked"/>
    public static global::Nps.Models.Multimedia.Galleries.Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<global::Nps.Models.Multimedia.Galleries.Data>
{
    /// <inheritdoc/>
    public global::Nps.Models.Multimedia.Galleries.Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Nps.Models.Multimedia.Galleries.Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        global::Nps.Models.Multimedia.Galleries.DataData,
        global::Nps.Models.Multimedia.Galleries.DataDataFromRaw
    >)
)]
public sealed record class DataData : JsonModel
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

    public string? AssetCount
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "assetCount"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "assetCount", value);
        }
    }

    public ConstraintsInfo? ConstraintsInfo
    {
        get { return JsonModel.GetNullableClass<ConstraintsInfo>(this.RawData, "constraintsInfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "constraintsInfo", value);
        }
    }

    public string? Copyright
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "copyright"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "copyright", value);
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

    public IReadOnlyList<global::Nps.Models.Multimedia.Galleries.RelatedPark>? RelatedParks
    {
        get
        {
            return JsonModel.GetNullableClass<
                List<global::Nps.Models.Multimedia.Galleries.RelatedPark>
            >(this.RawData, "relatedParks");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedParks", value);
        }
    }

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
        _ = this.ID;
        _ = this.AssetCount;
        this.ConstraintsInfo?.Validate();
        _ = this.Copyright;
        _ = this.Description;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        _ = this.Tags;
        _ = this.Title;
        _ = this.Url;
    }

    public DataData() { }

    public DataData(global::Nps.Models.Multimedia.Galleries.DataData dataData)
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

    /// <inheritdoc cref="global::Nps.Models.Multimedia.Galleries.DataDataFromRaw.FromRawUnchecked"/>
    public static global::Nps.Models.Multimedia.Galleries.DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataDataFromRaw : IFromRawJson<global::Nps.Models.Multimedia.Galleries.DataData>
{
    /// <inheritdoc/>
    public global::Nps.Models.Multimedia.Galleries.DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Nps.Models.Multimedia.Galleries.DataData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ConstraintsInfo, ConstraintsInfoFromRaw>))]
public sealed record class ConstraintsInfo : JsonModel
{
    public string? Constraint
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "constraint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "constraint", value);
        }
    }

    public string? GrantingRights
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "grantingRights"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "grantingRights", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Constraint;
        _ = this.GrantingRights;
    }

    public ConstraintsInfo() { }

    public ConstraintsInfo(ConstraintsInfo constraintsInfo)
        : base(constraintsInfo) { }

    public ConstraintsInfo(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConstraintsInfo(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ConstraintsInfoFromRaw.FromRawUnchecked"/>
    public static ConstraintsInfo FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ConstraintsInfoFromRaw : IFromRawJson<ConstraintsInfo>
{
    /// <inheritdoc/>
    public ConstraintsInfo FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ConstraintsInfo.FromRawUnchecked(rawData);
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
        _ = this.Description;
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

[JsonConverter(
    typeof(JsonModelConverter<
        global::Nps.Models.Multimedia.Galleries.RelatedPark,
        global::Nps.Models.Multimedia.Galleries.RelatedParkFromRaw
    >)
)]
public sealed record class RelatedPark : JsonModel
{
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

    public RelatedPark(global::Nps.Models.Multimedia.Galleries.RelatedPark relatedPark)
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

    /// <inheritdoc cref="global::Nps.Models.Multimedia.Galleries.RelatedParkFromRaw.FromRawUnchecked"/>
    public static global::Nps.Models.Multimedia.Galleries.RelatedPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RelatedParkFromRaw : IFromRawJson<global::Nps.Models.Multimedia.Galleries.RelatedPark>
{
    /// <inheritdoc/>
    public global::Nps.Models.Multimedia.Galleries.RelatedPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Nps.Models.Multimedia.Galleries.RelatedPark.FromRawUnchecked(rawData);
}
