using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Places;

[JsonConverter(typeof(JsonModelConverter<PlaceListResponse, PlaceListResponseFromRaw>))]
public sealed record class PlaceListResponse : JsonModel
{
    public IReadOnlyList<Data>? Data
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Data>>("data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Data>?>(
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

    public PlaceListResponse() { }

    public PlaceListResponse(PlaceListResponse placeListResponse)
        : base(placeListResponse) { }

    public PlaceListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PlaceListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PlaceListResponseFromRaw.FromRawUnchecked"/>
    public static PlaceListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PlaceListResponseFromRaw : IFromRawJson<PlaceListResponse>
{
    /// <inheritdoc/>
    public PlaceListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PlaceListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Uniquely identifies place record
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

    public IReadOnlyList<string>? Amenities
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("amenities"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "amenities",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? AudioDescription
    {
        get { return this._rawData.GetNullableClass<string>("audioDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("audioDescription", value);
        }
    }

    /// <summary>
    /// HTML and text
    /// </summary>
    public string? BodyText
    {
        get { return this._rawData.GetNullableClass<string>("bodyText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("bodyText", value);
        }
    }

    /// <summary>
    /// Id for Geometry Point of Interest
    /// </summary>
    public string? GeometryPoiID
    {
        get { return this._rawData.GetNullableClass<string>("geometryPoiId"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("geometryPoiId", value);
        }
    }

    public IReadOnlyList<string>? Images
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("images"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "images",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? IsManagedByNps
    {
        get { return this._rawData.GetNullableClass<string>("isManagedByNps"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isManagedByNps", value);
        }
    }

    public string? IsOpenToPublic
    {
        get { return this._rawData.GetNullableClass<string>("isOpenToPublic"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("isOpenToPublic", value);
        }
    }

    public string? Latitude
    {
        get { return this._rawData.GetNullableClass<string>("latitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("latitude", value);
        }
    }

    /// <summary>
    /// geospatial coordinates
    /// </summary>
    public string? LatLong
    {
        get { return this._rawData.GetNullableClass<string>("latLong"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("latLong", value);
        }
    }

    /// <summary>
    /// Short description of the content
    /// </summary>
    public string? ListingDescription
    {
        get { return this._rawData.GetNullableClass<string>("listingDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("listingDescription", value);
        }
    }

    public string? Longitude
    {
        get { return this._rawData.GetNullableClass<string>("longitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("longitude", value);
        }
    }

    public string? ManagedByOrg
    {
        get { return this._rawData.GetNullableClass<string>("managedByOrg"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("managedByOrg", value);
        }
    }

    public string? ManagedByUrl
    {
        get { return this._rawData.GetNullableClass<string>("managedByUrl"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("managedByUrl", value);
        }
    }

    public IReadOnlyList<DataMultimedia>? Multimedia
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<DataMultimedia>>("multimedia");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<DataMultimedia>?>(
                "multimedia",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? NpmapID
    {
        get { return this._rawData.GetNullableClass<string>("npmapId"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("npmapId", value);
        }
    }

    public string? QuickFacts
    {
        get { return this._rawData.GetNullableClass<string>("quickFacts"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("quickFacts", value);
        }
    }

    public IReadOnlyList<string>? RelatedOrganizations
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("relatedOrganizations");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "relatedOrganizations",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Parks that have a tie to this asset in a comma-delimited list
    /// </summary>
    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<RelatedPark>>("relatedParks"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<RelatedPark>?>(
                "relatedParks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<string>? Tags
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("tags"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "tags",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Asset title
    /// </summary>
    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    /// <summary>
    /// Link to more information about the asset, if available
    /// </summary>
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
        _ = this.ID;
        _ = this.Amenities;
        _ = this.AudioDescription;
        _ = this.BodyText;
        _ = this.GeometryPoiID;
        _ = this.Images;
        _ = this.IsManagedByNps;
        _ = this.IsOpenToPublic;
        _ = this.Latitude;
        _ = this.LatLong;
        _ = this.ListingDescription;
        _ = this.Longitude;
        _ = this.ManagedByOrg;
        _ = this.ManagedByUrl;
        foreach (var item in this.Multimedia ?? [])
        {
            item.Validate();
        }
        _ = this.NpmapID;
        _ = this.QuickFacts;
        _ = this.RelatedOrganizations;
        foreach (var item in this.RelatedParks ?? [])
        {
            item.Validate();
        }
        _ = this.Tags;
        _ = this.Title;
        _ = this.Url;
    }

    public Data() { }

    public Data(Data data)
        : base(data) { }

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

[JsonConverter(typeof(JsonModelConverter<DataMultimedia, DataMultimediaFromRaw>))]
public sealed record class DataMultimedia : JsonModel
{
    /// <summary>
    /// UUID for multimedia asset
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
    /// title of multimedia asset
    /// </summary>
    public string? Title
    {
        get { return this._rawData.GetNullableClass<string>("title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("title", value);
        }
    }

    /// <summary>
    /// the kind of asset
    /// </summary>
    public string? Type
    {
        get { return this._rawData.GetNullableClass<string>("type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
        }
    }

    /// <summary>
    /// The URL of the multimedia asset
    /// </summary>
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
        _ = this.ID;
        _ = this.Title;
        _ = this.Type;
        _ = this.Url;
    }

    public DataMultimedia() { }

    public DataMultimedia(DataMultimedia dataMultimedia)
        : base(dataMultimedia) { }

    public DataMultimedia(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataMultimedia(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataMultimediaFromRaw.FromRawUnchecked"/>
    public static DataMultimedia FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataMultimediaFromRaw : IFromRawJson<DataMultimedia>
{
    /// <inheritdoc/>
    public DataMultimedia FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataMultimedia.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<RelatedPark, RelatedParkFromRaw>))]
public sealed record class RelatedPark : JsonModel
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
    /// full name of related park
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
    /// four letter code for related park
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
    /// comma separated list of state codes
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

    /// <summary>
    /// URL to park home page
    /// </summary>
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

    public RelatedPark() { }

    public RelatedPark(RelatedPark relatedPark)
        : base(relatedPark) { }

    public RelatedPark(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
