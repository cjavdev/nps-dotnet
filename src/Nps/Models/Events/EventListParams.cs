using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using Nps.Core;

namespace Nps.Models.Events;

public sealed record class EventListParams : ParamsBase
{
    /// <summary>
    /// A unique ID string for an event.
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
    /// An ending date in the yyyy-mm-dd format to filter events by.
    /// </summary>
    public string? DateEnd
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "dateEnd"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "dateEnd", value);
        }
    }

    /// <summary>
    /// A stating date in the yyyy-mm-dd format to filter events by.
    /// </summary>
    public string? DateStart
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "dateStart"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "dateStart", value);
        }
    }

    /// <summary>
    /// A comma delimited list of event types.
    /// </summary>
    public IReadOnlyList<string>? EventType
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "eventType"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "eventType", value);
        }
    }

    /// <summary>
    /// A flag to denote whether or not to expand the recurring events out into multiple
    /// records (one per event date). Default is false.
    /// </summary>
    public bool? ExpandRecurring
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawQueryData, "expandRecurring"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "expandRecurring", value);
        }
    }

    /// <summary>
    /// A comma delimited list of organization site codes.
    /// </summary>
    public IReadOnlyList<string>? Organization
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "organization"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "organization", value);
        }
    }

    /// <summary>
    /// The current page number for the results. Default is 1.
    /// </summary>
    public long? PageNumber
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawQueryData, "pageNumber"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "pageNumber", value);
        }
    }

    /// <summary>
    /// The number of results per page. Default is 10.
    /// </summary>
    public long? PageSize
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawQueryData, "pageSize"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "pageSize", value);
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
    /// A comma delimited list of portal site codes.
    /// </summary>
    public IReadOnlyList<string>? Portal
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "portal"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "portal", value);
        }
    }

    /// <summary>
    /// Term to search on.
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

    /// <summary>
    /// A comma delimited list of subject site codes.
    /// </summary>
    public IReadOnlyList<string>? Subject
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "subject"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "subject", value);
        }
    }

    /// <summary>
    /// A comma delimited list of tags that must be included.
    /// </summary>
    public IReadOnlyList<string>? TagsAll
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "tagsAll"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "tagsAll", value);
        }
    }

    /// <summary>
    /// A comma delimited list of tags that must not be included.
    /// </summary>
    public IReadOnlyList<string>? TagsNone
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "tagsNone"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "tagsNone", value);
        }
    }

    /// <summary>
    /// A comma delimited list of tags that may be included.
    /// </summary>
    public IReadOnlyList<string>? TagsOne
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawQueryData, "tagsOne"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "tagsOne", value);
        }
    }

    public EventListParams() { }

    public EventListParams(EventListParams eventListParams)
        : base(eventListParams) { }

    public EventListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EventListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static EventListParams FromRawUnchecked(
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/events")
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
