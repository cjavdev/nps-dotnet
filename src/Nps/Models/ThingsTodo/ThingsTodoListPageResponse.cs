using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.ThingsTodo;

[JsonConverter(
    typeof(JsonModelConverter<ThingsTodoListPageResponse, ThingsTodoListPageResponseFromRaw>)
)]
public sealed record class ThingsTodoListPageResponse : JsonModel
{
    public IReadOnlyList<ThingsTodoListResponse>? Data
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<ThingsTodoListResponse>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ThingsTodoListResponse>?>(
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

    public ThingsTodoListPageResponse() { }

    public ThingsTodoListPageResponse(ThingsTodoListPageResponse thingsTodoListPageResponse)
        : base(thingsTodoListPageResponse) { }

    public ThingsTodoListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ThingsTodoListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ThingsTodoListPageResponseFromRaw.FromRawUnchecked"/>
    public static ThingsTodoListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ThingsTodoListPageResponseFromRaw : IFromRawJson<ThingsTodoListPageResponse>
{
    /// <inheritdoc/>
    public ThingsTodoListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ThingsTodoListPageResponse.FromRawUnchecked(rawData);
}
