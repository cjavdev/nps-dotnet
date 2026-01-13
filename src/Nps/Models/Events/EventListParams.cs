using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("id");
        }
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
    /// An ending date in the yyyy-mm-dd format to filter events by.
    /// </summary>
    public string? DateEnd
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("dateEnd");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("dateEnd", value);
        }
    }

    /// <summary>
    /// A stating date in the yyyy-mm-dd format to filter events by.
    /// </summary>
    public string? DateStart
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("dateStart");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("dateStart", value);
        }
    }

    /// <summary>
    /// A comma delimited list of event types.
    /// </summary>
    public IReadOnlyList<string>? EventType
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("eventType");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "eventType",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// A flag to denote whether or not to expand the recurring events out into multiple
    /// records (one per event date). Default is false.
    /// </summary>
    public bool? ExpandRecurring
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<bool>("expandRecurring");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("expandRecurring", value);
        }
    }

    /// <summary>
    /// Number of results to return per request. Default is 50.
    /// </summary>
    public long? Limit
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<long>("limit");
        }
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
    /// A comma delimited list of organization site codes.
    /// </summary>
    public IReadOnlyList<string>? Organization
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("organization");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "organization",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// The current page number for the results. Default is 1.
    /// </summary>
    public long? PageNumber
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<long>("pageNumber");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("pageNumber", value);
        }
    }

    /// <summary>
    /// The number of results per page. Default is 10.
    /// </summary>
    public long? PageSize
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<long>("pageSize");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("pageSize", value);
        }
    }

    /// <summary>
    /// A comma delimited list of park codes (each 4 characters in length).
    /// </summary>
    public IReadOnlyList<string>? ParkCode
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("parkCode");
        }
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
    /// A comma delimited list of portal site codes.
    /// </summary>
    public IReadOnlyList<string>? Portal
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("portal");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "portal",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Term to search on.
    /// </summary>
    public string? Q
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("q");
        }
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
    /// Number of results to return per request. Default is 50.
    /// </summary>
    public long? Start
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<long>("start");
        }
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
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("stateCode");
        }
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

    /// <summary>
    /// A comma delimited list of subject site codes.
    /// </summary>
    public IReadOnlyList<string>? Subject
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("subject");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "subject",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// A comma delimited list of tags that must be included.
    /// </summary>
    public IReadOnlyList<string>? TagsAll
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("tagsAll");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "tagsAll",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// A comma delimited list of tags that must not be included.
    /// </summary>
    public IReadOnlyList<string>? TagsNone
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("tagsNone");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "tagsNone",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// A comma delimited list of tags that may be included.
    /// </summary>
    public IReadOnlyList<string>? TagsOne
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<string>>("tagsOne");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<string>?>(
                "tagsOne",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
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
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    EventListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
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
