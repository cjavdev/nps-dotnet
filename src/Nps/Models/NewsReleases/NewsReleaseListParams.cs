using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using Nps.Core;

namespace Nps.Models.NewsReleases;

public sealed record class NewsReleaseListParams : ParamsBase
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
    /// A comma delimited list of resource properties to sort the results by. Each
    /// resource identifies which properties are 'sortable'. Ascending order is assumed
    /// for each property. If descending order is desired, the unary negative should
    /// prefix the property name. The sortable properties are listed in the documentation
    /// for each resource. Invalid property values will be ignored. Default is -releaseDate.
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

    public NewsReleaseListParams() { }

    public NewsReleaseListParams(NewsReleaseListParams newsReleaseListParams)
        : base(newsReleaseListParams) { }

    public NewsReleaseListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    NewsReleaseListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static NewsReleaseListParams FromRawUnchecked(
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/newsreleases")
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
