using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Lessonplans;

[JsonConverter(
    typeof(JsonModelConverter<LessonplanListPageResponse, LessonplanListPageResponseFromRaw>)
)]
public sealed record class LessonplanListPageResponse : JsonModel
{
    public IReadOnlyList<LessonplanListResponse>? Data
    {
        get
        {
            return JsonModel.GetNullableClass<List<LessonplanListResponse>>(this.RawData, "data");
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

    public LessonplanListPageResponse() { }

    public LessonplanListPageResponse(LessonplanListPageResponse lessonplanListPageResponse)
        : base(lessonplanListPageResponse) { }

    public LessonplanListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LessonplanListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LessonplanListPageResponseFromRaw.FromRawUnchecked"/>
    public static LessonplanListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LessonplanListPageResponseFromRaw : IFromRawJson<LessonplanListPageResponse>
{
    /// <inheritdoc/>
    public LessonplanListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LessonplanListPageResponse.FromRawUnchecked(rawData);
}
