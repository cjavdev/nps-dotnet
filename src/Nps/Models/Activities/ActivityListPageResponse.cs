using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Activities;

[JsonConverter(
    typeof(JsonModelConverter<ActivityListPageResponse, ActivityListPageResponseFromRaw>)
)]
public sealed record class ActivityListPageResponse : JsonModel
{
    public IReadOnlyList<ActivityListResponse>? Data
    {
        get { return JsonModel.GetNullableClass<List<ActivityListResponse>>(this.RawData, "data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data", value);
        }
    }

    public long? Limit
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public long? Start
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public long? Total
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "total"); }
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

    public ActivityListPageResponse() { }

    public ActivityListPageResponse(ActivityListPageResponse activityListPageResponse)
        : base(activityListPageResponse) { }

    public ActivityListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ActivityListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ActivityListPageResponseFromRaw.FromRawUnchecked"/>
    public static ActivityListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ActivityListPageResponseFromRaw : IFromRawJson<ActivityListPageResponse>
{
    /// <inheritdoc/>
    public ActivityListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ActivityListPageResponse.FromRawUnchecked(rawData);
}
