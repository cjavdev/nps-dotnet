using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<GalleryListAssetsResponseData>>(
                "data"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<GalleryListAssetsResponseData>?>(
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

    public GalleryListAssetsResponse() { }

    public GalleryListAssetsResponse(GalleryListAssetsResponse galleryListAssetsResponse)
        : base(galleryListAssetsResponse) { }

    public GalleryListAssetsResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

    public GalleryListAssetsResponseDataConstraintsInfo? ConstraintsInfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<GalleryListAssetsResponseDataConstraintsInfo>(
                "constraintsInfo"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("constraintsInfo", value);
        }
    }

    public string? Copyright
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("copyright");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("copyright", value);
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

    public FileInfo? FileInfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FileInfo>("fileInfo");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("fileInfo", value);
        }
    }

    public string? Ordinal
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("ordinal");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("ordinal", value);
        }
    }

    public string? PermalinkUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("permalinkUrl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("permalinkUrl", value);
        }
    }

    public IReadOnlyList<GalleryListAssetsResponseDataRelatedPark>? RelatedParks
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<GalleryListAssetsResponseDataRelatedPark>
            >("relatedParks");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<GalleryListAssetsResponseDataRelatedPark>?>(
                "relatedParks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<string>? Tags
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("tags");
        }
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("constraint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("constraint", value);
        }
    }

    public string? GrantingRights
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("grantingRights");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("grantingRights", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponseDataConstraintsInfo(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("fileSizeKb");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("fileSizeKb", value);
        }
    }

    public string? FileType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("fileType");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("fileType", value);
        }
    }

    public string? HeightPixels
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("heightPixels");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("heightPixels", value);
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

    public string? WidthPixels
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("widthPixels");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("widthPixels", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FileInfo(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsResponseDataRelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
