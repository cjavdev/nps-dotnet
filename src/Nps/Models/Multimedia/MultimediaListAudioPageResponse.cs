using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Multimedia;

[JsonConverter(
    typeof(JsonModelConverter<
        MultimediaListAudioPageResponse,
        MultimediaListAudioPageResponseFromRaw
    >)
)]
public sealed record class MultimediaListAudioPageResponse : JsonModel
{
    public IReadOnlyList<MultimediaListAudioResponse>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<MultimediaListAudioResponse>>(
                "data"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<MultimediaListAudioResponse>?>(
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

    public MultimediaListAudioPageResponse() { }

    public MultimediaListAudioPageResponse(
        MultimediaListAudioPageResponse multimediaListAudioPageResponse
    )
        : base(multimediaListAudioPageResponse) { }

    public MultimediaListAudioPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListAudioPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MultimediaListAudioPageResponseFromRaw.FromRawUnchecked"/>
    public static MultimediaListAudioPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MultimediaListAudioPageResponseFromRaw : IFromRawJson<MultimediaListAudioPageResponse>
{
    /// <inheritdoc/>
    public MultimediaListAudioPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => MultimediaListAudioPageResponse.FromRawUnchecked(rawData);
}
