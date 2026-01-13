using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using Nps.Core;

namespace Nps.Models.VisitorCenters;

public sealed record class VisitorCenterListParams : ParamsBase
{
    /// <summary>
    /// Number of results to return per request. Default is 50.
    /// </summary>
    public long? Limit
    {
        get { return this._rawQueryData.GetNullableStruct<long>("limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("limit", value);
        }
    }

    /// <summary>
    /// A comma delimited list of park codes (each 4 characters in length).
    /// </summary>
    public IReadOnlyList<string>? ParkCode
    {
        get { return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "parkCode",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Term to search on
    /// </summary>
    public string? Q
    {
        get { return this._rawQueryData.GetNullableClass<string>("q"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("q", value);
        }
    }

    /// <summary>
    /// A comma delimited list of resource properties to sort the results by. Ascending
    /// order is assumed for each property. If descending order is desired, the unary
    /// negative should prefix the property name. Invalid property values will be
    /// ignored. If no sort parameter is passed in a request, the default sort is
    /// by name. If sorting by relevanceScore, you 1) will likely use -relevanceScore
    /// as a higher score indicates a more relevant result and 2) cannot use it in
    /// conjunction with other sort properties. Possible fields to sort by are name,
    /// parkCode, and relevanceScore.
    /// </summary>
    public IReadOnlyList<string>? Sort
    {
        get { return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("sort"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "sort",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Get the next [limit] results starting with this number. Default is 0.
    /// </summary>
    public long? Start
    {
        get { return this._rawQueryData.GetNullableStruct<long>("start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("start", value);
        }
    }

    /// <summary>
    /// A comma delimited list of 2 character state codes.
    /// </summary>
    public IReadOnlyList<string>? StateCode
    {
        get { return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("stateCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "stateCode",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public VisitorCenterListParams() { }

    public VisitorCenterListParams(VisitorCenterListParams visitorCenterListParams)
        : base(visitorCenterListParams) { }

    public VisitorCenterListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    VisitorCenterListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static VisitorCenterListParams FromRawUnchecked(
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/visitorcenters")
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
