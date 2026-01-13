using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.People;

[JsonConverter(typeof(JsonModelConverter<PersonListResponse, PersonListResponseFromRaw>))]
public sealed record class PersonListResponse : JsonModel
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

    public PersonListResponse() { }

    public PersonListResponse(PersonListResponse personListResponse)
        : base(personListResponse) { }

    public PersonListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PersonListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PersonListResponseFromRaw.FromRawUnchecked"/>
    public static PersonListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PersonListResponseFromRaw : IFromRawJson<PersonListResponse>
{
    /// <inheritdoc/>
    public PersonListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PersonListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Uniquely identifies person record
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

    public string? FirstName
    {
        get { return this._rawData.GetNullableClass<string>("firstName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("firstName", value);
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

    public IReadOnlyList<Image>? Images
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Image>>("images"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Image>?>(
                "images",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? LastName
    {
        get { return this._rawData.GetNullableClass<string>("lastName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("lastName", value);
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

    public string? MiddleName
    {
        get { return this._rawData.GetNullableClass<string>("middleName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("middleName", value);
        }
    }

    public IReadOnlyList<QuickFact>? QuickFacts
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<QuickFact>>("quickFacts"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<QuickFact>?>(
                "quickFacts",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<JsonElement>? RelatedOrganizations
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<JsonElement>>(
                "relatedOrganizations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<JsonElement>?>(
                "relatedOrganizations",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Parks which have a tie to this asset
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
        _ = this.BodyText;
        _ = this.FirstName;
        _ = this.GeometryPoiID;
        foreach (var item in this.Images ?? [])
        {
            item.Validate();
        }
        _ = this.LastName;
        _ = this.Latitude;
        _ = this.LatLong;
        _ = this.ListingDescription;
        _ = this.Longitude;
        _ = this.MiddleName;
        foreach (var item in this.QuickFacts ?? [])
        {
            item.Validate();
        }
        _ = this.RelatedOrganizations;
        foreach (var item in this.RelatedParks ?? [])
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

[JsonConverter(typeof(JsonModelConverter<Image, ImageFromRaw>))]
public sealed record class Image : JsonModel
{
    public string? AltText
    {
        get { return this._rawData.GetNullableClass<string>("altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("altText", value);
        }
    }

    public string? Caption
    {
        get { return this._rawData.GetNullableClass<string>("caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("caption", value);
        }
    }

    public string? Credit
    {
        get { return this._rawData.GetNullableClass<string>("credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("credit", value);
        }
    }

    public IReadOnlyList<string>? Crops
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("crops"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "crops",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

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
        _ = this.AltText;
        _ = this.Caption;
        _ = this.Credit;
        _ = this.Crops;
        _ = this.Title;
        _ = this.Url;
    }

    public Image() { }

    public Image(Image image)
        : base(image) { }

    public Image(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Image(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ImageFromRaw.FromRawUnchecked"/>
    public static Image FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ImageFromRaw : IFromRawJson<Image>
{
    /// <inheritdoc/>
    public Image FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Image.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<QuickFact, QuickFactFromRaw>))]
public sealed record class QuickFact : JsonModel
{
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

    public string? Value
    {
        get { return this._rawData.GetNullableClass<string>("value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("value", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Name;
        _ = this.Value;
    }

    public QuickFact() { }

    public QuickFact(QuickFact quickFact)
        : base(quickFact) { }

    public QuickFact(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    QuickFact(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="QuickFactFromRaw.FromRawUnchecked"/>
    public static QuickFact FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class QuickFactFromRaw : IFromRawJson<QuickFact>
{
    /// <inheritdoc/>
    public QuickFact FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        QuickFact.FromRawUnchecked(rawData);
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

    public IReadOnlyList<string>? States
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("states"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "states",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
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
