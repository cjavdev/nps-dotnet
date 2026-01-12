using System.Collections.Frozen;
using System.Collections.Generic;
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
            return JsonModel.GetNullableClass<List<ThingsTodoListResponse>>(this.RawData, "data");
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

    public ThingsTodoListPageResponse() { }

    public ThingsTodoListPageResponse(ThingsTodoListPageResponse thingsTodoListPageResponse)
        : base(thingsTodoListPageResponse) { }

    public ThingsTodoListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ThingsTodoListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
