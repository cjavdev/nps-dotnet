using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.VisitorCenters;

[JsonConverter(
    typeof(JsonModelConverter<VisitorCenterListPageResponse, VisitorCenterListPageResponseFromRaw>)
)]
public sealed record class VisitorCenterListPageResponse : JsonModel
{
    public IReadOnlyList<VisitorCenterListResponse>? Data
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<VisitorCenterListResponse>>(
                "data"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<VisitorCenterListResponse>?>(
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

    public VisitorCenterListPageResponse() { }

    public VisitorCenterListPageResponse(
        VisitorCenterListPageResponse visitorCenterListPageResponse
    )
        : base(visitorCenterListPageResponse) { }

    public VisitorCenterListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    VisitorCenterListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="VisitorCenterListPageResponseFromRaw.FromRawUnchecked"/>
    public static VisitorCenterListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class VisitorCenterListPageResponseFromRaw : IFromRawJson<VisitorCenterListPageResponse>
{
    /// <inheritdoc/>
    public VisitorCenterListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => VisitorCenterListPageResponse.FromRawUnchecked(rawData);
}
