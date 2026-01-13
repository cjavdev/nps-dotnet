using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Multimedia;

[JsonConverter(
    typeof(JsonModelConverter<MultimediaListAudioResponse, MultimediaListAudioResponseFromRaw>)
)]
public sealed record class MultimediaListAudioResponse : JsonModel
{
    public IReadOnlyList<Data>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Data>>("data");
        }
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

    public MultimediaListAudioResponse() { }

    public MultimediaListAudioResponse(MultimediaListAudioResponse multimediaListAudioResponse)
        : base(multimediaListAudioResponse) { }

    public MultimediaListAudioResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListAudioResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MultimediaListAudioResponseFromRaw.FromRawUnchecked"/>
    public static MultimediaListAudioResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MultimediaListAudioResponseFromRaw : IFromRawJson<MultimediaListAudioResponse>
{
    /// <inheritdoc/>
    public MultimediaListAudioResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => MultimediaListAudioResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// unique identifier for this audio asset
    /// </summary>
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
            return this._rawData.GetNullableClass<string>("callToActionUrl");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("callToActionUrl", value);
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

    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<RelatedPark>>("relatedParks");
        }
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

    public SplashImage? SplashImage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<SplashImage>("splashImage");
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

    public Versions? Versions
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Versions>("versions");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("versions", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.CallToAction;
        _ = this.CallToActionUrl;
        _ = this.Credit;
        _ = this.Description;
        _ = this.DurationMs;
        _ = this.GeometryPoiID;
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
        this.Versions?.Validate();
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

[JsonConverter(typeof(JsonModelConverter<RelatedPark, RelatedParkFromRaw>))]
public sealed record class RelatedPark : JsonModel
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Designation;
        _ = this.ParkCode;
        _ = this.States;
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

[JsonConverter(typeof(JsonModelConverter<SplashImage, SplashImageFromRaw>))]
public sealed record class SplashImage : JsonModel
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

    public SplashImage() { }

    public SplashImage(SplashImage splashImage)
        : base(splashImage) { }

    public SplashImage(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SplashImage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SplashImageFromRaw.FromRawUnchecked"/>
    public static SplashImage FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SplashImageFromRaw : IFromRawJson<SplashImage>
{
    /// <inheritdoc/>
    public SplashImage FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        SplashImage.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Versions, VersionsFromRaw>))]
public sealed record class Versions : JsonModel
{
    public double? FileSize
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("fileSize");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("fileSize", value);
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
        _ = this.FileSize;
        _ = this.FileType;
        _ = this.Url;
    }

    public Versions() { }

    public Versions(Versions versions)
        : base(versions) { }

    public Versions(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Versions(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="VersionsFromRaw.FromRawUnchecked"/>
    public static Versions FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class VersionsFromRaw : IFromRawJson<Versions>
{
    /// <inheritdoc/>
    public Versions FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Versions.FromRawUnchecked(rawData);
}
