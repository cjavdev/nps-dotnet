using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Multimedia.Galleries;

[JsonConverter(
    typeof(JsonModelConverter<GalleryListAssetsPageResponse, GalleryListAssetsPageResponseFromRaw>)
)]
public sealed record class GalleryListAssetsPageResponse : JsonModel
{
    public IReadOnlyList<GalleryListAssetsResponse>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<GalleryListAssetsResponse>>(
                "data"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<GalleryListAssetsResponse>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? Limit
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("limit");
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

    public double? Start
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("start");
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

    public double? Total
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("total");
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

    public GalleryListAssetsPageResponse() { }

    public GalleryListAssetsPageResponse(
        GalleryListAssetsPageResponse galleryListAssetsPageResponse
    )
        : base(galleryListAssetsPageResponse) { }

    public GalleryListAssetsPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    GalleryListAssetsPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="GalleryListAssetsPageResponseFromRaw.FromRawUnchecked"/>
    public static GalleryListAssetsPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class GalleryListAssetsPageResponseFromRaw : IFromRawJson<GalleryListAssetsPageResponse>
{
    /// <inheritdoc/>
    public GalleryListAssetsPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => GalleryListAssetsPageResponse.FromRawUnchecked(rawData);
}
