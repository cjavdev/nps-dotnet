using System.Collections.Frozen;
using System.Collections.Generic;
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
            return JsonModel.GetNullableClass<List<MultimediaListAudioResponse>>(
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

    public double? Limit
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public double? Start
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public double? Total
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "total"); }
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

    public MultimediaListAudioPageResponse() { }

    public MultimediaListAudioPageResponse(
        MultimediaListAudioPageResponse multimediaListAudioPageResponse
    )
        : base(multimediaListAudioPageResponse) { }

    public MultimediaListAudioPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MultimediaListAudioPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
