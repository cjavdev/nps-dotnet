using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Events;

[JsonConverter(typeof(JsonModelConverter<EventListPageResponse, EventListPageResponseFromRaw>))]
public sealed record class EventListPageResponse : JsonModel
{
    public IReadOnlyList<EventListResponse>? Data
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<EventListResponse>>("data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<EventListResponse>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? Limit
    {
        get { return this._rawData.GetNullableStruct<double>("limit"); }
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
        get { return this._rawData.GetNullableStruct<double>("start"); }
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
        get { return this._rawData.GetNullableStruct<double>("total"); }
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

    public EventListPageResponse() { }

    public EventListPageResponse(EventListPageResponse eventListPageResponse)
        : base(eventListPageResponse) { }

    public EventListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EventListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="EventListPageResponseFromRaw.FromRawUnchecked"/>
    public static EventListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class EventListPageResponseFromRaw : IFromRawJson<EventListPageResponse>
{
    /// <inheritdoc/>
    public EventListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => EventListPageResponse.FromRawUnchecked(rawData);
}
