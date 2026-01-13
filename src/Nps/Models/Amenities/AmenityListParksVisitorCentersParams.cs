using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using Nps.Core;

namespace Nps.Models.Amenities;

public sealed record class AmenityListParksVisitorCentersParams : ParamsBase
{
    /// <summary>
    /// A comma delimited list of amenity IDs.
    /// </summary>
    public string? ID
    {
        get { return this._rawQueryData.GetNullableClass<string>("id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("id", value);
        }
    }

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
    /// A comma delimited list of 4 character park codes.
    /// </summary>
    public string? ParkCode
    {
        get { return this._rawQueryData.GetNullableClass<string>("parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("parkCode", value);
        }
    }

    /// <summary>
    /// A string to search for.
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
    /// A comma delimited list of fields to sort the results by. Ascending order is
    /// assumed for each field unless the field name is prefixed with the unary negative
    /// which implies descending order.
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

    public AmenityListParksVisitorCentersParams() { }

    public AmenityListParksVisitorCentersParams(
        AmenityListParksVisitorCentersParams amenityListParksVisitorCentersParams
    )
        : base(amenityListParksVisitorCentersParams) { }

    public AmenityListParksVisitorCentersParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AmenityListParksVisitorCentersParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static AmenityListParksVisitorCentersParams FromRawUnchecked(
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
        return new UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/') + "/amenities/parksvisitorcenters"
        )
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
