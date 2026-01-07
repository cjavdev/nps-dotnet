using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using Nps.Core;

namespace Nps.Models.Newsreleases;

public sealed record class NewsreleaseListParams : ParamsBase
{
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
    /// A comma delimited list of park codes (each 4 characters in length).
    /// </summary>
    public IReadOnlyList<string>? ParkCode
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "parkCode"); }
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
    /// Term to search on
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
    /// A comma delimited list of resource properties to sort the results by. Each
    /// resource identifies which properties are 'sortable'. Ascending order is assumed
    /// for each property. If descending order is desired, the unary negative should
    /// prefix the property name. The sortable properties are listed in the documentation
    /// for each resource. Invalid property values will be ignored. Default is -releaseDate.
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
    public IReadOnlyList<string>? StateCode
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "stateCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "stateCode", value);
        }
    }

    public NewsreleaseListParams() { }

    public NewsreleaseListParams(NewsreleaseListParams newsreleaseListParams)
        : base(newsreleaseListParams) { }

    public NewsreleaseListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    NewsreleaseListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static NewsreleaseListParams FromRawUnchecked(
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
