using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using Nps.Core;

namespace Nps.Models.ThingsTodo;

public sealed record class ThingsTodoListParams : ParamsBase
{
    /// <summary>
    /// A comma delimited list of things to do IDs.
    /// </summary>
    public string? ID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "id", value);
        }
    }

    /// <summary>
    /// Number of results to return per request. Default is 50.
    /// </summary>
    public long? Limit
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawQueryData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "limit", value);
        }
    }

    /// <summary>
    /// A comma delimited list of 4 character park codes.
    /// </summary>
    public string? ParkCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "parkCode", value);
        }
    }

    /// <summary>
    /// A string to search for.
    /// </summary>
    public string? Q
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "q"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "q", value);
        }
    }

    /// <summary>
    /// A comma delimited list of resource properties to sort the results by. Ascending
    /// order is assumed for each property. If descending order is desired, the unary
    /// negative should prefix the property name. Invalid property values will be
    /// ignored. If no sort parameter is passed in a request, the default sort is
    /// by descending order of date last modified. (Note that the date last modified
    /// is an unexposed property.) If sorting by relevanceScore, you will likely use
    /// -relevanceScore as a higher score indicates a more accurate result. The only
    /// sort option, besides the default, is relevanceScore.
    /// </summary>
    public IReadOnlyList<string>? Sort
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "sort"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "sort", value);
        }
    }

    /// <summary>
    /// Get the next [limit] results starting with this number. Default is 0.
    /// </summary>
    public long? Start
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawQueryData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "start", value);
        }
    }

    /// <summary>
    /// A comma delimited list of 2 character state codes.
    /// </summary>
    public string? StateCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "stateCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "stateCode", value);
        }
    }

    public ThingsTodoListParams() { }

    public ThingsTodoListParams(ThingsTodoListParams thingsTodoListParams)
        : base(thingsTodoListParams) { }

    public ThingsTodoListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ThingsTodoListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static ThingsTodoListParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData)
        );
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/thingstodo")
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}
