using System;
using System.Collections.Frozen;
using System.Collections.Generic;
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
        get { return JsonModel.GetNullableClass<List<Data>>(this.RawData, "data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data", value);
        }
    }

    public string? Limit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public string? Start
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public string? Total
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "total"); }
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

    public FeespassListResponse() { }

    public FeespassListResponse(FeespassListResponse feespassListResponse)
        : base(feespassListResponse) { }

    public FeespassListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FeespassListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cashless"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cashless", value);
        }
    }

    public ApiEnum<string, ContentOrderOrdinals>? ContentOrderOrdinals
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, ContentOrderOrdinals>>(
                this.RawData,
                "contentOrderOrdinals"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contentOrderOrdinals", value);
        }
    }

    public string? CustomFeeDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "customFeeDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "customFeeDescription", value);
        }
    }

    public string? CustomFeeHeading
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "customFeeHeading"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "customFeeHeading", value);
        }
    }

    public string? CustomFeeLinkText
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "customFeeLinkText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "customFeeLinkText", value);
        }
    }

    public string? CustomFeeLinkUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "customFeeLinkUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "customFeeLinkUrl", value);
        }
    }

    public string? EntranceFeeDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "entranceFeeDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "entranceFeeDescription", value);
        }
    }

    public string? EntrancePassesDescription
    {
        get
        {
            return JsonModel.GetNullableClass<string>(this.RawData, "entrancePassesDescription");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "entrancePassesDescription", value);
        }
    }

    public IReadOnlyList<Fee>? Fees
    {
        get { return JsonModel.GetNullableClass<List<Fee>>(this.RawData, "fees"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fees", value);
        }
    }

    public string? FeesAtWorkUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "feesAtWorkUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "feesAtWorkUrl", value);
        }
    }

    public bool? IsFeeFreePark
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "isFeeFreePark"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isFeeFreePark", value);
        }
    }

    public bool? IsInteragencyPassAccepted
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "isInteragencyPassAccepted"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isInteragencyPassAccepted", value);
        }
    }

    public bool? IsParkingFeePossible
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "isParkingFeePossible"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isParkingFeePossible", value);
        }
    }

    public bool? IsParkingOrTransportationFeePossible
    {
        get
        {
            return JsonModel.GetNullableStruct<bool>(
                this.RawData,
                "isParkingOrTransportationFeePossible"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "isParkingOrTransportationFeePossible", value);
        }
    }

    public string? PaidParkingDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "paidParkingDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "paidParkingDescription", value);
        }
    }

    public string? PaidParkingHeading
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "paidParkingHeading"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "paidParkingHeading", value);
        }
    }

    public string? ParkCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parkCode", value);
        }
    }

    public string? ParkingDetailsUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "parkingDetailsUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parkingDetailsUrl", value);
        }
    }

    public IReadOnlyList<Pass>? Passes
    {
        get { return JsonModel.GetNullableClass<List<Pass>>(this.RawData, "passes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "passes", value);
        }
    }

    public IReadOnlyList<RelatedMultiSitePass>? RelatedMultiSitePasses
    {
        get
        {
            return JsonModel.GetNullableClass<List<RelatedMultiSitePass>>(
                this.RawData,
                "relatedMultiSitePasses"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedMultiSitePasses", value);
        }
    }

    public string? TimedEntryDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "timedEntryDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timedEntryDescription", value);
        }
    }

    public string? TimedEntryHeading
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "timedEntryHeading"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timedEntryHeading", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public string? Cost
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cost", value);
        }
    }

    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "description", value);
        }
    }

    public EndDate? EndDate
    {
        get { return JsonModel.GetNullableClass<EndDate>(this.RawData, "endDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "endDate", value);
        }
    }

    public string? EntranceFeeType
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "entranceFeeType"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "entranceFeeType", value);
        }
    }

    public string? Exceptions
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "exceptions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "exceptions", value);
        }
    }

    public string? InformationUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "informationUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "informationUrl", value);
        }
    }

    public string? PayGovPurchaseUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "payGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "payGovPurchaseUrl", value);
        }
    }

    public string? PaymentDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "paymentDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "paymentDescription", value);
        }
    }

    public string? PurchaseUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "purchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "purchaseUrl", value);
        }
    }

    public string? RecGovPurchaseUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "recGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "recGovPurchaseUrl", value);
        }
    }

    public StartDate? StartDate
    {
        get { return JsonModel.GetNullableClass<StartDate>(this.RawData, "startDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "startDate", value);
        }
    }

    public string? TimedEntryLocation
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "timedEntryLocation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timedEntryLocation", value);
        }
    }

    public string? TimedEntryShortDescription
    {
        get
        {
            return JsonModel.GetNullableClass<string>(this.RawData, "timedEntryShortDescription");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timedEntryShortDescription", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Fee(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "day"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "day", value);
        }
    }

    public string? Holiday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "holiday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "holiday", value);
        }
    }

    public long? Month
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "month"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "month", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EndDate(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "day"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "day", value);
        }
    }

    public string? Holiday
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "holiday"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "holiday", value);
        }
    }

    public long? Month
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "month"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "month", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StartDate(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public string? Category
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "category"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "category", value);
        }
    }

    public string? Cost
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cost", value);
        }
    }

    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "description", value);
        }
    }

    public string? Exceptions
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "exceptions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "exceptions", value);
        }
    }

    public IReadOnlyList<Image>? Image
    {
        get { return JsonModel.GetNullableClass<List<Image>>(this.RawData, "image"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "image", value);
        }
    }

    public string? InformationUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "informationUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "informationUrl", value);
        }
    }

    public string? NpsGovPurchaseUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "npsGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "npsGovPurchaseUrl", value);
        }
    }

    public string? PayGovPurchaseUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "payGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "payGovPurchaseUrl", value);
        }
    }

    public string? PaymentDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "paymentDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "paymentDescription", value);
        }
    }

    public string? RecGovPurchaseUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "recGovPurchaseUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "recGovPurchaseUrl", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Pass(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "altText", value);
        }
    }

    public string? Caption
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "caption", value);
        }
    }

    public string? Credit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "credit", value);
        }
    }

    public string? Title
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "title", value);
        }
    }

    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Image(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "audience"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "audience", value);
        }
    }

    public string? Cost
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "cost"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "cost", value);
        }
    }

    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "description", value);
        }
    }

    public IReadOnlyList<RelatedMultiSitePassImage>? Images
    {
        get
        {
            return JsonModel.GetNullableClass<List<RelatedMultiSitePassImage>>(
                this.RawData,
                "images"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "images", value);
        }
    }

    public IReadOnlyList<PurchaseLocation>? PurchaseLocations
    {
        get
        {
            return JsonModel.GetNullableClass<List<PurchaseLocation>>(
                this.RawData,
                "purchaseLocations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "purchaseLocations", value);
        }
    }

    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get { return JsonModel.GetNullableClass<List<RelatedPark>>(this.RawData, "relatedParks"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedParks", value);
        }
    }

    public string? Title
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "title", value);
        }
    }

    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedMultiSitePass(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "altText", value);
        }
    }

    public string? Caption
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "caption", value);
        }
    }

    public string? Credit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "credit", value);
        }
    }

    public string? Title
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "title", value);
        }
    }

    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedMultiSitePassImage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public string? PaymentMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "paymentMethod"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "paymentMethod", value);
        }
    }

    public string? Title
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "title", value);
        }
    }

    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PurchaseLocation(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "designation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "designation", value);
        }
    }

    public string? FullName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "fullName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fullName", value);
        }
    }

    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "name", value);
        }
    }

    public string? ParkCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parkCode", value);
        }
    }

    public string? States
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "states"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "states", value);
        }
    }

    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
