using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;
using Nps.Exceptions;

namespace Nps.Models.Alerts;

[JsonConverter(typeof(JsonModelConverter<AlertListResponse, AlertListResponseFromRaw>))]
public sealed record class AlertListResponse : JsonModel
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

    public AlertListResponse() { }

    public AlertListResponse(AlertListResponse alertListResponse)
        : base(alertListResponse) { }

    public AlertListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AlertListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AlertListResponseFromRaw.FromRawUnchecked"/>
    public static AlertListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AlertListResponseFromRaw : IFromRawJson<AlertListResponse>
{
    /// <inheritdoc/>
    public AlertListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AlertListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for an alert record
    /// </summary>
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

    /// <summary>
    /// Alert type: Danger, Caution, Information, or Park Closure
    /// </summary>
    public ApiEnum<string, Category>? Category
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, Category>>(this.RawData, "category");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "category", value);
        }
    }

    /// <summary>
    /// Alert description
    /// </summary>
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

    /// <summary>
    /// date/time stamp of when this alert was last indexed
    /// </summary>
    public string? LastIndexedDate
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "lastIndexedDate"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "lastIndexedDate", value);
        }
    }

    /// <summary>
    /// A variable width character code that uniquely identifies a specific park
    /// </summary>
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

    /// <summary>
    /// more information about a road event related to this alert (if any)
    /// </summary>
    public IReadOnlyList<RelatedRoadEvent>? RelatedRoadEvents
    {
        get
        {
            return JsonModel.GetNullableClass<List<RelatedRoadEvent>>(
                this.RawData,
                "relatedRoadEvents"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedRoadEvents", value);
        }
    }

    /// <summary>
    /// Alert title
    /// </summary>
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

    /// <summary>
    /// Link to more information about the alert, if available
    /// </summary>
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
        _ = this.ID;
        this.Category?.Validate();
        _ = this.Description;
        _ = this.LastIndexedDate;
        _ = this.ParkCode;
        foreach (var item in this.RelatedRoadEvents ?? [])
        {
            item.Validate();
        }
        _ = this.Title;
        _ = this.Url;
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

/// <summary>
/// Alert type: Danger, Caution, Information, or Park Closure
/// </summary>
[JsonConverter(typeof(CategoryConverter))]
public enum Category
{
    Danger,
    Caution,
    Information,
    ParkClosure,
}

sealed class CategoryConverter : JsonConverter<Category>
{
    public override Category Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "Danger" => Category.Danger,
            "Caution" => Category.Caution,
            "Information" => Category.Information,
            "Park Closure" => Category.ParkClosure,
            _ => (Category)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Category value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Category.Danger => "Danger",
                Category.Caution => "Caution",
                Category.Information => "Information",
                Category.ParkClosure => "Park Closure",
                _ => throw new NpsInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<RelatedRoadEvent, RelatedRoadEventFromRaw>))]
public sealed record class RelatedRoadEvent : JsonModel
{
    /// <summary>
    /// UUID for this related road event
    /// </summary>
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

    /// <summary>
    /// title of this related road event
    /// </summary>
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

    /// <summary>
    /// what type of related road event is this
    /// </summary>
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

    /// <summary>
    /// URL for more information about this related road event
    /// </summary>
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
        _ = this.ID;
        _ = this.Title;
        _ = this.Type;
        _ = this.Url;
    }

    public RelatedRoadEvent() { }

    public RelatedRoadEvent(RelatedRoadEvent relatedRoadEvent)
        : base(relatedRoadEvent) { }

    public RelatedRoadEvent(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedRoadEvent(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RelatedRoadEventFromRaw.FromRawUnchecked"/>
    public static RelatedRoadEvent FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RelatedRoadEventFromRaw : IFromRawJson<RelatedRoadEvent>
{
    /// <inheritdoc/>
    public RelatedRoadEvent FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        RelatedRoadEvent.FromRawUnchecked(rawData);
}
