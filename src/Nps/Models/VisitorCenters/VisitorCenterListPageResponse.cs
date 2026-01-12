using System.Collections.Frozen;
using System.Collections.Generic;
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
            return JsonModel.GetNullableClass<List<VisitorCenterListResponse>>(
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

    public VisitorCenterListPageResponse() { }

    public VisitorCenterListPageResponse(
        VisitorCenterListPageResponse visitorCenterListPageResponse
    )
        : base(visitorCenterListPageResponse) { }

    public VisitorCenterListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    VisitorCenterListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
