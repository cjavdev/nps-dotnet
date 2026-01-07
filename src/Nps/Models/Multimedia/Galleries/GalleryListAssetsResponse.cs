using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Multimedia.Galleries;

[JsonConverter(
    typeof(JsonModelConverter<GalleryListAssetsResponse, GalleryListAssetsResponseFromRaw>)
)]
public sealed record class GalleryListAssetsResponse : JsonModel
{
    public IReadOnlyList<GalleryListAssetsResponseData>? Data
    {
        get
        {
            return JsonModel.GetNullableClass<List<GalleryListAssetsResponseData>>(
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

    public GalleryListAssetsResponse() { }

    public GalleryListAssetsResponse(GalleryListAssetsResponse galleryListAssetsResponse)
        : base(galleryListAssetsResponse) { }

    public GalleryListAssetsResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="GalleryListAssetsResponseFromRaw.FromRawUnchecked"/>
    public static GalleryListAssetsResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class GalleryListAssetsResponseFromRaw : IFromRawJson<GalleryListAssetsResponse>
{
    /// <inheritdoc/>
    public GalleryListAssetsResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => GalleryListAssetsResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<GalleryListAssetsResponseData, GalleryListAssetsResponseDataFromRaw>)
)]
public sealed record class GalleryListAssetsResponseData : JsonModel
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

    public GalleryListAssetsResponseDataConstraintsInfo? ConstraintsInfo
    {
        get
        {
            return JsonModel.GetNullableClass<GalleryListAssetsResponseDataConstraintsInfo>(
                this.RawData,
                "constraintsInfo"
            );
        }
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

    public FileInfo? FileInfo
    {
        get { return JsonModel.GetNullableClass<FileInfo>(this.RawData, "fileInfo"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fileInfo", value);
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

    public string? PermalinkUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "permalinkUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "permalinkUrl", value);
        }
    }

    public IReadOnlyList<GalleryListAssetsResponseDataRelatedPark>? RelatedParks
    {
        get
        {
            return JsonModel.GetNullableClass<List<GalleryListAssetsResponseDataRelatedPark>>(
                this.RawData,
                "relatedParks"
            );
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.AltText;
        this.ConstraintsInfo?.Validate();
        _ = this.Copyright;
        _ = this.Credit;
        _ = this.Description;
        this.FileInfo?.Validate();
        _ = this.Ordinal;
        _ = this.PermalinkUrl;
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        _ = this.Tags;
        _ = this.Title;
    }

    public GalleryListAssetsResponseData() { }

    public GalleryListAssetsResponseData(
        GalleryListAssetsResponseData galleryListAssetsResponseData
    )
        : base(galleryListAssetsResponseData) { }

    public GalleryListAssetsResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="GalleryListAssetsResponseDataFromRaw.FromRawUnchecked"/>
    public static GalleryListAssetsResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class GalleryListAssetsResponseDataFromRaw : IFromRawJson<GalleryListAssetsResponseData>
{
    /// <inheritdoc/>
    public GalleryListAssetsResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => GalleryListAssetsResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        GalleryListAssetsResponseDataConstraintsInfo,
        GalleryListAssetsResponseDataConstraintsInfoFromRaw
    >)
)]
public sealed record class GalleryListAssetsResponseDataConstraintsInfo : JsonModel
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

    public GalleryListAssetsResponseDataConstraintsInfo() { }

    public GalleryListAssetsResponseDataConstraintsInfo(
        GalleryListAssetsResponseDataConstraintsInfo galleryListAssetsResponseDataConstraintsInfo
    )
        : base(galleryListAssetsResponseDataConstraintsInfo) { }

    public GalleryListAssetsResponseDataConstraintsInfo(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponseDataConstraintsInfo(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="GalleryListAssetsResponseDataConstraintsInfoFromRaw.FromRawUnchecked"/>
    public static GalleryListAssetsResponseDataConstraintsInfo FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class GalleryListAssetsResponseDataConstraintsInfoFromRaw
    : IFromRawJson<GalleryListAssetsResponseDataConstraintsInfo>
{
    /// <inheritdoc/>
    public GalleryListAssetsResponseDataConstraintsInfo FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => GalleryListAssetsResponseDataConstraintsInfo.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<FileInfo, FileInfoFromRaw>))]
public sealed record class FileInfo : JsonModel
{
    public string? FileSizeKB
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "fileSizeKb"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fileSizeKb", value);
        }
    }

    public string? FileType
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "fileType"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fileType", value);
        }
    }

    public string? HeightPixels
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "heightPixels"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "heightPixels", value);
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

    public string? WidthPixels
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "widthPixels"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "widthPixels", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.FileSizeKB;
        _ = this.FileType;
        _ = this.HeightPixels;
        _ = this.Url;
        _ = this.WidthPixels;
    }

    public FileInfo() { }

    public FileInfo(FileInfo fileInfo)
        : base(fileInfo) { }

    public FileInfo(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FileInfo(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FileInfoFromRaw.FromRawUnchecked"/>
    public static FileInfo FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FileInfoFromRaw : IFromRawJson<FileInfo>
{
    /// <inheritdoc/>
    public FileInfo FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        FileInfo.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        GalleryListAssetsResponseDataRelatedPark,
        GalleryListAssetsResponseDataRelatedParkFromRaw
    >)
)]
public sealed record class GalleryListAssetsResponseDataRelatedPark : JsonModel
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

    public GalleryListAssetsResponseDataRelatedPark() { }

    public GalleryListAssetsResponseDataRelatedPark(
        GalleryListAssetsResponseDataRelatedPark galleryListAssetsResponseDataRelatedPark
    )
        : base(galleryListAssetsResponseDataRelatedPark) { }

    public GalleryListAssetsResponseDataRelatedPark(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponseDataRelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="GalleryListAssetsResponseDataRelatedParkFromRaw.FromRawUnchecked"/>
    public static GalleryListAssetsResponseDataRelatedPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class GalleryListAssetsResponseDataRelatedParkFromRaw
    : IFromRawJson<GalleryListAssetsResponseDataRelatedPark>
{
    /// <inheritdoc/>
    public GalleryListAssetsResponseDataRelatedPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => GalleryListAssetsResponseDataRelatedPark.FromRawUnchecked(rawData);
}
