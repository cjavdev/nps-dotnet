using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;
using Nps.Exceptions;

namespace Nps.Models.Feespasses;

[JsonConverter(typeof(JsonModelConverter<FeespassListResponse, FeespassListResponseFromRaw>))]
public sealed record class FeespassListResponse : JsonModel
{
    public IReadOnlyList<Data>? Data
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Data>>("data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Data>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Limit
    {
        get { return this._rawData.GetNullableClass<string>("limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("limit", value);
        }
    }

    public string? Start
    {
        get { return this._rawData.GetNullableClass<string>("start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("start", value);
        }
    }

    public string? Total
    {
        get { return this._rawData.GetNullableClass<string>("total"); }
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

    public FeespassListResponse() { }

    public FeespassListResponse(FeespassListResponse feespassListResponse)
        : base(feespassListResponse) { }

    public FeespassListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FeespassListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FeespassListResponseFromRaw.FromRawUnchecked"/>
    public static FeespassListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FeespassListResponseFromRaw : IFromRawJson<FeespassListResponse>
{
    /// <inheritdoc/>
    public FeespassListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => FeespassListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    public string? Cashless
    {
        get { return this._rawData.GetNullableClass<string>("cashless"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cashless", value);
        }
    }

    public ApiEnum<string, ContentOrderOrdinals>? ContentOrderOrdinals
    {
        get
        {
            return this._rawData.GetNullableClass<ApiEnum<string, ContentOrderOrdinals>>(
                "contentOrderOrdinals"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contentOrderOrdinals", value);
        }
    }

    public string? CustomFeeDescription
    {
        get { return this._rawData.GetNullableClass<string>("customFeeDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("customFeeDescription", value);
        }
    }

    public string? CustomFeeHeading
    {
        get { return this._rawData.GetNullableClass<string>("customFeeHeading"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("customFeeHeading", value);
        }
    }

    public string? CustomFeeLinkText
    {
        get { return this._rawData.GetNullableClass<string>("customFeeLinkText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("customFeeLinkText", value);
        }
    }

    public string? CustomFeeLinkUrl
    {
        get { return this._rawData.GetNullableClass<string>("customFeeLinkUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("customFeeLinkUrl", value);
        }
    }

    public string? EntranceFeeDescription
    {
        get { return this._rawData.GetNullableClass<string>("entranceFeeDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("entranceFeeDescription", value);
        }
    }

    public string? EntrancePassesDescription
    {
        get { return this._rawData.GetNullableClass<string>("entrancePassesDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("entrancePassesDescription", value);
        }
    }

    public IReadOnlyList<Fee>? Fees
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Fee>>("fees"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Fee>?>(
                "fees",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? FeesAtWorkUrl
    {
        get { return this._rawData.GetNullableClass<string>("feesAtWorkUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("feesAtWorkUrl", value);
        }
    }

    public bool? IsFeeFreePark
    {
        get { return this._rawData.GetNullableStruct<bool>("isFeeFreePark"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isFeeFreePark", value);
        }
    }

    public bool? IsInteragencyPassAccepted
    {
        get { return this._rawData.GetNullableStruct<bool>("isInteragencyPassAccepted"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isInteragencyPassAccepted", value);
        }
    }

    public bool? IsParkingFeePossible
    {
        get { return this._rawData.GetNullableStruct<bool>("isParkingFeePossible"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isParkingFeePossible", value);
        }
    }

    public bool? IsParkingOrTransportationFeePossible
    {
        get
        {
            return this._rawData.GetNullableStruct<bool>("isParkingOrTransportationFeePossible");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isParkingOrTransportationFeePossible", value);
        }
    }

    public string? PaidParkingDescription
    {
        get { return this._rawData.GetNullableClass<string>("paidParkingDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("paidParkingDescription", value);
        }
    }

    public string? PaidParkingHeading
    {
        get { return this._rawData.GetNullableClass<string>("paidParkingHeading"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("paidParkingHeading", value);
        }
    }

    public string? ParkCode
    {
        get { return this._rawData.GetNullableClass<string>("parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("parkCode", value);
        }
    }

    public string? ParkingDetailsUrl
    {
        get { return this._rawData.GetNullableClass<string>("parkingDetailsUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("parkingDetailsUrl", value);
        }
    }

    public IReadOnlyList<Pass>? Passes
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Pass>>("passes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Pass>?>(
                "passes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<RelatedMultiSitePass>? RelatedMultiSitePasses
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<RelatedMultiSitePass>>(
                "relatedMultiSitePasses"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<RelatedMultiSitePass>?>(
                "relatedMultiSitePasses",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? TimedEntryDescription
    {
        get { return this._rawData.GetNullableClass<string>("timedEntryDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timedEntryDescription", value);
        }
    }

    public string? TimedEntryHeading
    {
        get { return this._rawData.GetNullableClass<string>("timedEntryHeading"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timedEntryHeading", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Cashless;
        this.ContentOrderOrdinals?.Validate();
        _ = this.CustomFeeDescription;
        _ = this.CustomFeeHeading;
        _ = this.CustomFeeLinkText;
        _ = this.CustomFeeLinkUrl;
        _ = this.EntranceFeeDescription;
        _ = this.EntrancePassesDescription;
        foreach (var item in this.Fees ?? [])
        {
            item.Validate();
        }
        _ = this.FeesAtWorkUrl;
        _ = this.IsFeeFreePark;
        _ = this.IsInteragencyPassAccepted;
        _ = this.IsParkingFeePossible;
        _ = this.IsParkingOrTransportationFeePossible;
        _ = this.PaidParkingDescription;
        _ = this.PaidParkingHeading;
        _ = this.ParkCode;
        _ = this.ParkingDetailsUrl;
        foreach (var item in this.Passes ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.RelatedMultiSitePasses ?? [])
        {
            item.Validate();
        }
        _ = this.TimedEntryDescription;
        _ = this.TimedEntryHeading;
    }

    public Data() { }

    public Data(Data data)
        : base(data) { }

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataFromRaw.FromRawUnchecked"/>
    public static Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ContentOrderOrdinalsConverter))]
public enum ContentOrderOrdinals
{
    EntranceFee,
    TimedEntry,
    PaidParking,
    CustomFee,
}

sealed class ContentOrderOrdinalsConverter : JsonConverter<ContentOrderOrdinals>
{
    public override ContentOrderOrdinals Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "entranceFee" => ContentOrderOrdinals.EntranceFee,
            "timedEntry" => ContentOrderOrdinals.TimedEntry,
            "paidParking" => ContentOrderOrdinals.PaidParking,
            "customFee" => ContentOrderOrdinals.CustomFee,
            _ => (ContentOrderOrdinals)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ContentOrderOrdinals value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ContentOrderOrdinals.EntranceFee => "entranceFee",
                ContentOrderOrdinals.TimedEntry => "timedEntry",
                ContentOrderOrdinals.PaidParking => "paidParking",
                ContentOrderOrdinals.CustomFee => "customFee",
                _ => throw new NpsInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Fee, FeeFromRaw>))]
public sealed record class Fee : JsonModel
{
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public string? Cost
    {
        get { return this._rawData.GetNullableClass<string>("cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cost", value);
        }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public EndDate? EndDate
    {
        get { return this._rawData.GetNullableClass<EndDate>("endDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endDate", value);
        }
    }

    public string? EntranceFeeType
    {
        get { return this._rawData.GetNullableClass<string>("entranceFeeType"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("entranceFeeType", value);
        }
    }

    public string? Exceptions
    {
        get { return this._rawData.GetNullableClass<string>("exceptions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("exceptions", value);
        }
    }

    public string? InformationUrl
    {
        get { return this._rawData.GetNullableClass<string>("informationUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("informationUrl", value);
        }
    }

    public string? PayGovPurchaseUrl
    {
        get { return this._rawData.GetNullableClass<string>("payGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("payGovPurchaseUrl", value);
        }
    }

    public string? PaymentDescription
    {
        get { return this._rawData.GetNullableClass<string>("paymentDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("paymentDescription", value);
        }
    }

    public string? PurchaseUrl
    {
        get { return this._rawData.GetNullableClass<string>("purchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("purchaseUrl", value);
        }
    }

    public string? RecGovPurchaseUrl
    {
        get { return this._rawData.GetNullableClass<string>("recGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("recGovPurchaseUrl", value);
        }
    }

    public StartDate? StartDate
    {
        get { return this._rawData.GetNullableClass<StartDate>("startDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("startDate", value);
        }
    }

    public string? TimedEntryLocation
    {
        get { return this._rawData.GetNullableClass<string>("timedEntryLocation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timedEntryLocation", value);
        }
    }

    public string? TimedEntryShortDescription
    {
        get { return this._rawData.GetNullableClass<string>("timedEntryShortDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timedEntryShortDescription", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Cost;
        _ = this.Description;
        this.EndDate?.Validate();
        _ = this.EntranceFeeType;
        _ = this.Exceptions;
        _ = this.InformationUrl;
        _ = this.PayGovPurchaseUrl;
        _ = this.PaymentDescription;
        _ = this.PurchaseUrl;
        _ = this.RecGovPurchaseUrl;
        this.StartDate?.Validate();
        _ = this.TimedEntryLocation;
        _ = this.TimedEntryShortDescription;
    }

    public Fee() { }

    public Fee(Fee fee)
        : base(fee) { }

    public Fee(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Fee(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FeeFromRaw.FromRawUnchecked"/>
    public static Fee FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FeeFromRaw : IFromRawJson<Fee>
{
    /// <inheritdoc/>
    public Fee FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Fee.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<EndDate, EndDateFromRaw>))]
public sealed record class EndDate : JsonModel
{
    public long? Day
    {
        get { return this._rawData.GetNullableStruct<long>("day"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("day", value);
        }
    }

    public string? Holiday
    {
        get { return this._rawData.GetNullableClass<string>("holiday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("holiday", value);
        }
    }

    public long? Month
    {
        get { return this._rawData.GetNullableStruct<long>("month"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("month", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Day;
        _ = this.Holiday;
        _ = this.Month;
    }

    public EndDate() { }

    public EndDate(EndDate endDate)
        : base(endDate) { }

    public EndDate(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EndDate(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="EndDateFromRaw.FromRawUnchecked"/>
    public static EndDate FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class EndDateFromRaw : IFromRawJson<EndDate>
{
    /// <inheritdoc/>
    public EndDate FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        EndDate.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<StartDate, StartDateFromRaw>))]
public sealed record class StartDate : JsonModel
{
    public long? Day
    {
        get { return this._rawData.GetNullableStruct<long>("day"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("day", value);
        }
    }

    public string? Holiday
    {
        get { return this._rawData.GetNullableClass<string>("holiday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("holiday", value);
        }
    }

    public long? Month
    {
        get { return this._rawData.GetNullableStruct<long>("month"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("month", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Day;
        _ = this.Holiday;
        _ = this.Month;
    }

    public StartDate() { }

    public StartDate(StartDate startDate)
        : base(startDate) { }

    public StartDate(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StartDate(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StartDateFromRaw.FromRawUnchecked"/>
    public static StartDate FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StartDateFromRaw : IFromRawJson<StartDate>
{
    /// <inheritdoc/>
    public StartDate FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StartDate.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Pass, PassFromRaw>))]
public sealed record class Pass : JsonModel
{
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public string? Category
    {
        get { return this._rawData.GetNullableClass<string>("category"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("category", value);
        }
    }

    public string? Cost
    {
        get { return this._rawData.GetNullableClass<string>("cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cost", value);
        }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public string? Exceptions
    {
        get { return this._rawData.GetNullableClass<string>("exceptions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("exceptions", value);
        }
    }

    public IReadOnlyList<Image>? Image
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Image>>("image"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Image>?>(
                "image",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? InformationUrl
    {
        get { return this._rawData.GetNullableClass<string>("informationUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("informationUrl", value);
        }
    }

    public string? NpsGovPurchaseUrl
    {
        get { return this._rawData.GetNullableClass<string>("npsGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("npsGovPurchaseUrl", value);
        }
    }

    public string? PayGovPurchaseUrl
    {
        get { return this._rawData.GetNullableClass<string>("payGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("payGovPurchaseUrl", value);
        }
    }

    public string? PaymentDescription
    {
        get { return this._rawData.GetNullableClass<string>("paymentDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("paymentDescription", value);
        }
    }

    public string? RecGovPurchaseUrl
    {
        get { return this._rawData.GetNullableClass<string>("recGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("recGovPurchaseUrl", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Category;
        _ = this.Cost;
        _ = this.Description;
        _ = this.Exceptions;
        foreach (var item in this.Image ?? [])
        {
            item.Validate();
        }
        _ = this.InformationUrl;
        _ = this.NpsGovPurchaseUrl;
        _ = this.PayGovPurchaseUrl;
        _ = this.PaymentDescription;
        _ = this.RecGovPurchaseUrl;
    }

    public Pass() { }

    public Pass(Pass pass)
        : base(pass) { }

    public Pass(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Pass(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PassFromRaw.FromRawUnchecked"/>
    public static Pass FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PassFromRaw : IFromRawJson<Pass>
{
    /// <inheritdoc/>
    public Pass FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Pass.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Image, ImageFromRaw>))]
public sealed record class Image : JsonModel
{
    public string? AltText
    {
        get { return this._rawData.GetNullableClass<string>("altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("altText", value);
        }
    }

    public string? Caption
    {
        get { return this._rawData.GetNullableClass<string>("caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("caption", value);
        }
    }

    public string? Credit
    {
        get { return this._rawData.GetNullableClass<string>("credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("credit", value);
        }
    }

    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("url", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AltText;
        _ = this.Caption;
        _ = this.Credit;
        _ = this.Title;
        _ = this.Url;
    }

    public Image() { }

    public Image(Image image)
        : base(image) { }

    public Image(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Image(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ImageFromRaw.FromRawUnchecked"/>
    public static Image FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ImageFromRaw : IFromRawJson<Image>
{
    /// <inheritdoc/>
    public Image FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Image.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<RelatedMultiSitePass, RelatedMultiSitePassFromRaw>))]
public sealed record class RelatedMultiSitePass : JsonModel
{
    public string? Audience
    {
        get { return this._rawData.GetNullableClass<string>("audience"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("audience", value);
        }
    }

    public string? Cost
    {
        get { return this._rawData.GetNullableClass<string>("cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("cost", value);
        }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public IReadOnlyList<RelatedMultiSitePassImage>? Images
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<RelatedMultiSitePassImage>>(
                "images"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<RelatedMultiSitePassImage>?>(
                "images",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<PurchaseLocation>? PurchaseLocations
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<PurchaseLocation>>(
                "purchaseLocations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<PurchaseLocation>?>(
                "purchaseLocations",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<RelatedPark>>("relatedParks"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<RelatedPark>?>(
                "relatedParks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    public string? Type
    {
        get { return this._rawData.GetNullableClass<string>("type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Audience;
        _ = this.Cost;
        _ = this.Description;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.PurchaseLocations ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        _ = this.Title;
        _ = this.Type;
    }

    public RelatedMultiSitePass() { }

    public RelatedMultiSitePass(RelatedMultiSitePass relatedMultiSitePass)
        : base(relatedMultiSitePass) { }

    public RelatedMultiSitePass(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedMultiSitePass(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RelatedMultiSitePassFromRaw.FromRawUnchecked"/>
    public static RelatedMultiSitePass FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RelatedMultiSitePassFromRaw : IFromRawJson<RelatedMultiSitePass>
{
    /// <inheritdoc/>
    public RelatedMultiSitePass FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RelatedMultiSitePass.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<RelatedMultiSitePassImage, RelatedMultiSitePassImageFromRaw>)
)]
public sealed record class RelatedMultiSitePassImage : JsonModel
{
    public string? AltText
    {
        get { return this._rawData.GetNullableClass<string>("altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("altText", value);
        }
    }

    public string? Caption
    {
        get { return this._rawData.GetNullableClass<string>("caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("caption", value);
        }
    }

    public string? Credit
    {
        get { return this._rawData.GetNullableClass<string>("credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("credit", value);
        }
    }

    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("url", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AltText;
        _ = this.Caption;
        _ = this.Credit;
        _ = this.Title;
        _ = this.Url;
    }

    public RelatedMultiSitePassImage() { }

    public RelatedMultiSitePassImage(RelatedMultiSitePassImage relatedMultiSitePassImage)
        : base(relatedMultiSitePassImage) { }

    public RelatedMultiSitePassImage(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedMultiSitePassImage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RelatedMultiSitePassImageFromRaw.FromRawUnchecked"/>
    public static RelatedMultiSitePassImage FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RelatedMultiSitePassImageFromRaw : IFromRawJson<RelatedMultiSitePassImage>
{
    /// <inheritdoc/>
    public RelatedMultiSitePassImage FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RelatedMultiSitePassImage.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PurchaseLocation, PurchaseLocationFromRaw>))]
public sealed record class PurchaseLocation : JsonModel
{
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public string? PaymentMethod
    {
        get { return this._rawData.GetNullableClass<string>("paymentMethod"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("paymentMethod", value);
        }
    }

    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    public string? Type
    {
        get { return this._rawData.GetNullableClass<string>("type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.PaymentMethod;
        _ = this.Title;
        _ = this.Type;
    }

    public PurchaseLocation() { }

    public PurchaseLocation(PurchaseLocation purchaseLocation)
        : base(purchaseLocation) { }

    public PurchaseLocation(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PurchaseLocation(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PurchaseLocationFromRaw.FromRawUnchecked"/>
    public static PurchaseLocation FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PurchaseLocationFromRaw : IFromRawJson<PurchaseLocation>
{
    /// <inheritdoc/>
    public PurchaseLocation FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PurchaseLocation.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<RelatedPark, RelatedParkFromRaw>))]
public sealed record class RelatedPark : JsonModel
{
    public string? Designation
    {
        get { return this._rawData.GetNullableClass<string>("designation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("designation", value);
        }
    }

    public string? FullName
    {
        get { return this._rawData.GetNullableClass<string>("fullName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("fullName", value);
        }
    }

    public string? Name
    {
        get { return this._rawData.GetNullableClass<string>("name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name", value);
        }
    }

    public string? ParkCode
    {
        get { return this._rawData.GetNullableClass<string>("parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("parkCode", value);
        }
    }

    public string? States
    {
        get { return this._rawData.GetNullableClass<string>("states"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("states", value);
        }
    }

    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("url", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Designation;
        _ = this.FullName;
        _ = this.Name;
        _ = this.ParkCode;
        _ = this.States;
        _ = this.Url;
    }

    public RelatedPark() { }

    public RelatedPark(RelatedPark relatedPark)
        : base(relatedPark) { }

    public RelatedPark(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RelatedParkFromRaw.FromRawUnchecked"/>
    public static RelatedPark FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RelatedParkFromRaw : IFromRawJson<RelatedPark>
{
    /// <inheritdoc/>
    public RelatedPark FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        RelatedPark.FromRawUnchecked(rawData);
}
