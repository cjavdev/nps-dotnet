using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Topics;

[JsonConverter(typeof(JsonModelConverter<TopicListParksResponse, TopicListParksResponseFromRaw>))]
public sealed record class TopicListParksResponse : JsonModel
{
    public IReadOnlyList<TopicListParksResponseData>? Data
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<TopicListParksResponseData>>(
                "data"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<TopicListParksResponseData>?>(
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

    public TopicListParksResponse() { }

    public TopicListParksResponse(TopicListParksResponse topicListParksResponse)
        : base(topicListParksResponse) { }

    public TopicListParksResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TopicListParksResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TopicListParksResponseFromRaw.FromRawUnchecked"/>
    public static TopicListParksResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TopicListParksResponseFromRaw : IFromRawJson<TopicListParksResponse>
{
    /// <inheritdoc/>
    public TopicListParksResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TopicListParksResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<TopicListParksResponseData, TopicListParksResponseDataFromRaw>)
)]
public sealed record class TopicListParksResponseData : JsonModel
{
    /// <summary>
    /// Unique identifier for topic park record
    /// </summary>
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

    /// <summary>
    /// Name of topic park record
    /// </summary>
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

    public IReadOnlyList<Park>? Parks
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Park>>("parks"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Park>?>(
                "parks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Name;
        foreach (var item in this.Parks ?? [])
        {
            item.Validate();
        }
    }

    public TopicListParksResponseData() { }

    public TopicListParksResponseData(TopicListParksResponseData topicListParksResponseData)
        : base(topicListParksResponseData) { }

    public TopicListParksResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TopicListParksResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TopicListParksResponseDataFromRaw.FromRawUnchecked"/>
    public static TopicListParksResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TopicListParksResponseDataFromRaw : IFromRawJson<TopicListParksResponseData>
{
    /// <inheritdoc/>
    public TopicListParksResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TopicListParksResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Park, ParkFromRaw>))]
public sealed record class Park : JsonModel
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

    /// <summary>
    /// the full name of a park
    /// </summary>
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

    /// <summary>
    /// four letter alpha code for a park
    /// </summary>
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

    /// <summary>
    /// a comma delimeted list of two letter state codes
    /// </summary>
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

    public Park() { }

    public Park(Park park)
        : base(park) { }

    public Park(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Park(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ParkFromRaw.FromRawUnchecked"/>
    public static Park FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ParkFromRaw : IFromRawJson<Park>
{
    /// <inheritdoc/>
    public Park FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Park.FromRawUnchecked(rawData);
}
