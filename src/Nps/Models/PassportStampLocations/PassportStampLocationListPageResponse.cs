using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.PassportStampLocations;

[JsonConverter(
    typeof(JsonModelConverter<
        PassportStampLocationListPageResponse,
        PassportStampLocationListPageResponseFromRaw
    >)
)]
public sealed record class PassportStampLocationListPageResponse : JsonModel
{
    public IReadOnlyList<PassportStampLocationListResponse>? Data
    {
        get
        {
            return this._rawData.GetNullableStruct<
                ImmutableArray<PassportStampLocationListResponse>
            >("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<PassportStampLocationListResponse>?>(
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

    public PassportStampLocationListPageResponse() { }

    public PassportStampLocationListPageResponse(
        PassportStampLocationListPageResponse passportStampLocationListPageResponse
    )
        : base(passportStampLocationListPageResponse) { }

    public PassportStampLocationListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PassportStampLocationListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PassportStampLocationListPageResponseFromRaw.FromRawUnchecked"/>
    public static PassportStampLocationListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PassportStampLocationListPageResponseFromRaw
    : IFromRawJson<PassportStampLocationListPageResponse>
{
    /// <inheritdoc/>
    public PassportStampLocationListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PassportStampLocationListPageResponse.FromRawUnchecked(rawData);
}
