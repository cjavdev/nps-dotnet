using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<ActivityListResponse>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ActivityListResponse>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public long? Limit
    {
        get { return this._rawData.GetNullableStruct<long>("limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("limit", value);
        }
    }

    public long? Start
    {
        get { return this._rawData.GetNullableStruct<long>("start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("start", value);
        }
    }

    public long? Total
    {
        get { return this._rawData.GetNullableStruct<long>("total"); }
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

    public ActivityListPageResponse() { }

    public ActivityListPageResponse(ActivityListPageResponse activityListPageResponse)
        : base(activityListPageResponse) { }

    public ActivityListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ActivityListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
