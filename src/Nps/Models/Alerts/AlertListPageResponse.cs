using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Alerts;

[JsonConverter(typeof(JsonModelConverter<AlertListPageResponse, AlertListPageResponseFromRaw>))]
public sealed record class AlertListPageResponse : JsonModel
{
    public IReadOnlyList<AlertListResponse>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<AlertListResponse>>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<AlertListResponse>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public long? Limit
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("limit");
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

    public long? Start
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("start");
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

    public long? Total
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("total");
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

    public AlertListPageResponse() { }

    public AlertListPageResponse(AlertListPageResponse alertListPageResponse)
        : base(alertListPageResponse) { }

    public AlertListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AlertListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AlertListPageResponseFromRaw.FromRawUnchecked"/>
    public static AlertListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AlertListPageResponseFromRaw : IFromRawJson<AlertListPageResponse>
{
    /// <inheritdoc/>
    public AlertListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AlertListPageResponse.FromRawUnchecked(rawData);
}
