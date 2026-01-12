using System.Collections.Frozen;
using System.Collections.Generic;
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
        get { return JsonModel.GetNullableClass<List<Data>>(this.RawData, "data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data", value);
        }
    }

    public string? Limit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public string? Start
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public string? Total
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "total"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "total", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PersonListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
    public IReadOnlyList<DataData>? DataValue
    {
        get { return JsonModel.GetNullableClass<List<DataData>>(this.RawData, "data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data", value);
        }
    }

    public string? Limit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public string? Start
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public string? Total
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "total"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "total", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.DataValue ?? [])
        {
            item.Validate();
        }
        _ = this.Limit;
        _ = this.Start;
        _ = this.Total;
    }

    public Data() { }

    public Data(Data data)
        : base(data) { }

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

[JsonConverter(typeof(JsonModelConverter<DataData, DataDataFromRaw>))]
public sealed record class DataData : JsonModel
{
    /// <summary>
    /// Uniquely identifies person record
    /// </summary>
    public string? ID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public string? BodyText
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "bodyText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "bodyText", value);
        }
    }

    public string? FirstName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "firstName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "firstName", value);
        }
    }

    /// <summary>
    /// Id for Geometry Point of Interest
    /// </summary>
    public string? GeometryPoiID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "geometryPoiId"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "geometryPoiId", value);
        }
    }

    public IReadOnlyList<Image>? Images
    {
        get { return JsonModel.GetNullableClass<List<Image>>(this.RawData, "images"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "images", value);
        }
    }

    public string? LastName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "lastName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "lastName", value);
        }
    }

    public string? Latitude
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "latitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "latitude", value);
        }
    }

    /// <summary>
    /// geospatial coordinates
    /// </summary>
    public string? LatLong
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "latLong"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "latLong", value);
        }
    }

    /// <summary>
    /// Short description of the content
    /// </summary>
    public string? ListingDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "listingDescription"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "listingDescription", value);
        }
    }

    public string? Longitude
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "longitude"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "longitude", value);
        }
    }

    public string? MiddleName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "middleName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "middleName", value);
        }
    }

    public IReadOnlyList<QuickFact>? QuickFacts
    {
        get { return JsonModel.GetNullableClass<List<QuickFact>>(this.RawData, "quickFacts"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "quickFacts", value);
        }
    }

    public IReadOnlyList<JsonElement>? RelatedOrganizations
    {
        get
        {
            return JsonModel.GetNullableClass<List<JsonElement>>(
                this.RawData,
                "relatedOrganizations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedOrganizations", value);
        }
    }

    /// <summary>
    /// Parks which have a tie to this asset
    /// </summary>
    public IReadOnlyList<RelatedPark>? RelatedParks
    {
        get { return JsonModel.GetNullableClass<List<RelatedPark>>(this.RawData, "relatedParks"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "relatedParks", value);
        }
    }

    /// <summary>
    /// Asset title
    /// </summary>
    public string? Title
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "title", value);
        }
    }

    /// <summary>
    /// Link to more information about the asset, if available
    /// </summary>
    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
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

    public DataData() { }

    public DataData(DataData dataData)
        : base(dataData) { }

    public DataData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataDataFromRaw.FromRawUnchecked"/>
    public static DataData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataDataFromRaw : IFromRawJson<DataData>
{
    /// <inheritdoc/>
    public DataData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Image, ImageFromRaw>))]
public sealed record class Image : JsonModel
{
    public string? AltText
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "altText"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "altText", value);
        }
    }

    public string? Caption
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "caption"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "caption", value);
        }
    }

    public string? Credit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "credit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "credit", value);
        }
    }

    public IReadOnlyList<string>? Crops
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "crops"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "crops", value);
        }
    }

    public string? Title
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "title"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "title", value);
        }
    }

    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Image(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "name", value);
        }
    }

    public string? Value
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "value", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    QuickFact(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
        get { return JsonModel.GetNullableClass<string>(this.RawData, "designation"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "designation", value);
        }
    }

    public string? FullName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "fullName"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "fullName", value);
        }
    }

    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "name", value);
        }
    }

    public string? ParkCode
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "parkCode"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parkCode", value);
        }
    }

    public IReadOnlyList<string>? States
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "states"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "states", value);
        }
    }

    public string? Url
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "url", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RelatedPark(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
