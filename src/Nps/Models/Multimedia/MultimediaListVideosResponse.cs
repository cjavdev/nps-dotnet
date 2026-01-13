using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Multimedia;

[JsonConverter(
    typeof(JsonModelConverter<MultimediaListVideosResponse, MultimediaListVideosResponseFromRaw>)
)]
public sealed record class MultimediaListVideosResponse : JsonModel
{
    public IReadOnlyList<MultimediaListVideosResponseData>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<MultimediaListVideosResponseData>
            >("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<MultimediaListVideosResponseData>?>(
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

    public MultimediaListVideosResponse() { }

    public MultimediaListVideosResponse(MultimediaListVideosResponse multimediaListVideosResponse)
        : base(multimediaListVideosResponse) { }

    public MultimediaListVideosResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MultimediaListVideosResponseFromRaw.FromRawUnchecked"/>
    public static MultimediaListVideosResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MultimediaListVideosResponseFromRaw : IFromRawJson<MultimediaListVideosResponse>
{
    /// <inheritdoc/>
    public MultimediaListVideosResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => MultimediaListVideosResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        MultimediaListVideosResponseData,
        MultimediaListVideosResponseDataFromRaw
    >)
)]
public sealed record class MultimediaListVideosResponseData : JsonModel
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

    public string? AslVideoUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("aslVideoUrl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("aslVideoUrl", value);
        }
    }

    public bool? AudioDescribedBuiltIn
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("audioDescribedBuiltIn");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("audioDescribedBuiltIn", value);
        }
    }

    public string? Audiodescription
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("audiodescription");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("audiodescription", value);
        }
    }

    public string? AudioDescriptionUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("audioDescriptionUrl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("audioDescriptionUrl", value);
        }
    }

    public string? CallToAction
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("callToAction");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("callToAction", value);
        }
    }

    public string? CallToActionUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("callToActionURL");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("callToActionURL", value);
        }
    }

    public IReadOnlyList<CaptionFile>? CaptionFiles
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<CaptionFile>>("captionFiles");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<CaptionFile>?>(
                "captionFiles",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
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

    public string? DescriptiveTranscript
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("descriptiveTranscript");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("descriptiveTranscript", value);
        }
    }

    public double? DurationMs
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("durationMs");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("durationMs", value);
        }
    }

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

    public bool? HasOpenCaptions
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("hasOpenCaptions");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("hasOpenCaptions", value);
        }
    }

    public bool? IsBRoll
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("isBRoll");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isBRoll", value);
        }
    }

    public bool? IsVideoOnly
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("isVideoOnly");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isVideoOnly", value);
        }
    }

    public double? Latitude
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("latitude");
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

    public double? Longitude
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("longitude");
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

    public IReadOnlyList<MultimediaListVideosResponseDataRelatedPark>? RelatedParks
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<MultimediaListVideosResponseDataRelatedPark>
            >("relatedParks");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<MultimediaListVideosResponseDataRelatedPark>?>(
                "relatedParks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public MultimediaListVideosResponseDataSplashImage? SplashImage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<MultimediaListVideosResponseDataSplashImage>(
                "splashImage"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("splashImage", value);
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

    public string? Transcript
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("transcript");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("transcript", value);
        }
    }

    public IReadOnlyList<Version>? Versions
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Version>>("versions");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Version>?>(
                "versions",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.AslVideoUrl;
        _ = this.AudioDescribedBuiltIn;
        _ = this.Audiodescription;
        _ = this.AudioDescriptionUrl;
        _ = this.CallToAction;
        _ = this.CallToActionUrl;
        foreach (var item in this.CaptionFiles ?? [])
        {
            item.Validate();
        }
        _ = this.Credit;
        _ = this.Description;
        _ = this.DescriptiveTranscript;
        _ = this.DurationMs;
        _ = this.GeometryPoiID;
        _ = this.HasOpenCaptions;
        _ = this.IsBRoll;
        _ = this.IsVideoOnly;
        _ = this.Latitude;
        _ = this.Longitude;
        _ = this.PermalinkUrl;
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        this.SplashImage?.Validate();
        _ = this.Tags;
        _ = this.Title;
        _ = this.Transcript;
        foreach (var item in this.Versions ?? [])
        {
            item.Validate();
        }
    }

    public MultimediaListVideosResponseData() { }

    public MultimediaListVideosResponseData(
        MultimediaListVideosResponseData multimediaListVideosResponseData
    )
        : base(multimediaListVideosResponseData) { }

    public MultimediaListVideosResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MultimediaListVideosResponseDataFromRaw.FromRawUnchecked"/>
    public static MultimediaListVideosResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MultimediaListVideosResponseDataFromRaw : IFromRawJson<MultimediaListVideosResponseData>
{
    /// <inheritdoc/>
    public MultimediaListVideosResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => MultimediaListVideosResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CaptionFile, CaptionFileFromRaw>))]
public sealed record class CaptionFile : JsonModel
{
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

    public string? Language
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("language");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("language", value);
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
        _ = this.FileType;
        _ = this.Language;
        _ = this.Url;
    }

    public CaptionFile() { }

    public CaptionFile(CaptionFile captionFile)
        : base(captionFile) { }

    public CaptionFile(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CaptionFile(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CaptionFileFromRaw.FromRawUnchecked"/>
    public static CaptionFile FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CaptionFileFromRaw : IFromRawJson<CaptionFile>
{
    /// <inheritdoc/>
    public CaptionFile FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CaptionFile.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        MultimediaListVideosResponseDataRelatedPark,
        MultimediaListVideosResponseDataRelatedParkFromRaw
    >)
)]
public sealed record class MultimediaListVideosResponseDataRelatedPark : JsonModel
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

    public MultimediaListVideosResponseDataRelatedPark() { }

    public MultimediaListVideosResponseDataRelatedPark(
        MultimediaListVideosResponseDataRelatedPark multimediaListVideosResponseDataRelatedPark
    )
        : base(multimediaListVideosResponseDataRelatedPark) { }

    public MultimediaListVideosResponseDataRelatedPark(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponseDataRelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MultimediaListVideosResponseDataRelatedParkFromRaw.FromRawUnchecked"/>
    public static MultimediaListVideosResponseDataRelatedPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MultimediaListVideosResponseDataRelatedParkFromRaw
    : IFromRawJson<MultimediaListVideosResponseDataRelatedPark>
{
    /// <inheritdoc/>
    public MultimediaListVideosResponseDataRelatedPark FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => MultimediaListVideosResponseDataRelatedPark.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        MultimediaListVideosResponseDataSplashImage,
        MultimediaListVideosResponseDataSplashImageFromRaw
    >)
)]
public sealed record class MultimediaListVideosResponseDataSplashImage : JsonModel
{
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
        _ = this.Url;
    }

    public MultimediaListVideosResponseDataSplashImage() { }

    public MultimediaListVideosResponseDataSplashImage(
        MultimediaListVideosResponseDataSplashImage multimediaListVideosResponseDataSplashImage
    )
        : base(multimediaListVideosResponseDataSplashImage) { }

    public MultimediaListVideosResponseDataSplashImage(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponseDataSplashImage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MultimediaListVideosResponseDataSplashImageFromRaw.FromRawUnchecked"/>
    public static MultimediaListVideosResponseDataSplashImage FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MultimediaListVideosResponseDataSplashImageFromRaw
    : IFromRawJson<MultimediaListVideosResponseDataSplashImage>
{
    /// <inheritdoc/>
    public MultimediaListVideosResponseDataSplashImage FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => MultimediaListVideosResponseDataSplashImage.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Version, VersionFromRaw>))]
public sealed record class Version : JsonModel
{
    public double? AspectRatio
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("aspectRatio");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("aspectRatio", value);
        }
    }

    public double? FileSizeKB
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("fileSizeKb");
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

    public double? HeightPixels
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("heightPixels");
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

    public double? WidthPixels
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("widthPixels");
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
        _ = this.AspectRatio;
        _ = this.FileSizeKB;
        _ = this.FileType;
        _ = this.HeightPixels;
        _ = this.Url;
        _ = this.WidthPixels;
    }

    public Version() { }

    public Version(Version version)
        : base(version) { }

    public Version(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Version(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="VersionFromRaw.FromRawUnchecked"/>
    public static Version FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class VersionFromRaw : IFromRawJson<Version>
{
    /// <inheritdoc/>
    public Version FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Version.FromRawUnchecked(rawData);
}
