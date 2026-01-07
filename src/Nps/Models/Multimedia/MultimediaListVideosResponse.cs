using System.Collections.Frozen;
using System.Collections.Generic;
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
            return JsonModel.GetNullableClass<List<MultimediaListVideosResponseData>>(
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

    public MultimediaListVideosResponse() { }

    public MultimediaListVideosResponse(MultimediaListVideosResponse multimediaListVideosResponse)
        : base(multimediaListVideosResponse) { }

    public MultimediaListVideosResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public string? AslVideoUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "aslVideoUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "aslVideoUrl", value);
        }
    }

    public bool? AudioDescribedBuiltIn
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "audioDescribedBuiltIn"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "audioDescribedBuiltIn", value);
        }
    }

    public string? Audiodescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "audiodescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "audiodescription", value);
        }
    }

    public string? AudioDescriptionUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "audioDescriptionUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "audioDescriptionUrl", value);
        }
    }

    public string? CallToAction
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "callToAction"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "callToAction", value);
        }
    }

    public string? CallToActionUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "callToActionURL"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "callToActionURL", value);
        }
    }

    public IReadOnlyList<CaptionFile>? CaptionFiles
    {
        get { return JsonModel.GetNullableClass<List<CaptionFile>>(this.RawData, "captionFiles"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "captionFiles", value);
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

    public string? DescriptiveTranscript
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "descriptiveTranscript"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "descriptiveTranscript", value);
        }
    }

    public double? DurationMs
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "durationMs"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "durationMs", value);
        }
    }

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

    public bool? HasOpenCaptions
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "hasOpenCaptions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "hasOpenCaptions", value);
        }
    }

    public bool? IsBRoll
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "isBRoll"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isBRoll", value);
        }
    }

    public bool? IsVideoOnly
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "isVideoOnly"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isVideoOnly", value);
        }
    }

    public double? Latitude
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "latitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "latitude", value);
        }
    }

    public double? Longitude
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "longitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "longitude", value);
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

    public IReadOnlyList<MultimediaListVideosResponseDataRelatedPark>? RelatedParks
    {
        get
        {
            return JsonModel.GetNullableClass<List<MultimediaListVideosResponseDataRelatedPark>>(
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

    public MultimediaListVideosResponseDataSplashImage? SplashImage
    {
        get
        {
            return JsonModel.GetNullableClass<MultimediaListVideosResponseDataSplashImage>(
                this.RawData,
                "splashImage"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "splashImage", value);
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

    public string? Transcript
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "transcript"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "transcript", value);
        }
    }

    public IReadOnlyList<Version>? Versions
    {
        get { return JsonModel.GetNullableClass<List<Version>>(this.RawData, "versions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "versions", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public string? Language
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "language"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "language", value);
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
        _ = this.FileType;
        _ = this.Language;
        _ = this.Url;
    }

    public CaptionFile() { }

    public CaptionFile(CaptionFile captionFile)
        : base(captionFile) { }

    public CaptionFile(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CaptionFile(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public MultimediaListVideosResponseDataRelatedPark() { }

    public MultimediaListVideosResponseDataRelatedPark(
        MultimediaListVideosResponseDataRelatedPark multimediaListVideosResponseDataRelatedPark
    )
        : base(multimediaListVideosResponseDataRelatedPark) { }

    public MultimediaListVideosResponseDataRelatedPark(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponseDataRelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListVideosResponseDataSplashImage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "aspectRatio"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "aspectRatio", value);
        }
    }

    public double? FileSizeKB
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "fileSizeKb"); }
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

    public double? HeightPixels
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "heightPixels"); }
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

    public double? WidthPixels
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "widthPixels"); }
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Version(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
