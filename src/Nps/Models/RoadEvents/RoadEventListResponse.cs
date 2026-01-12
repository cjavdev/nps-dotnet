using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.RoadEvents;

[JsonConverter(typeof(JsonModelConverter<RoadEventListResponse, RoadEventListResponseFromRaw>))]
public sealed record class RoadEventListResponse : JsonModel
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

    public double? Limit
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public double? Start
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start", value);
        }
    }

    public double? Total
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "total"); }
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

    public RoadEventListResponse() { }

    public RoadEventListResponse(RoadEventListResponse roadEventListResponse)
        : base(roadEventListResponse) { }

    public RoadEventListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RoadEventListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RoadEventListResponseFromRaw.FromRawUnchecked"/>
    public static RoadEventListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RoadEventListResponseFromRaw : IFromRawJson<RoadEventListResponse>
{
    /// <inheritdoc/>
    public RoadEventListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RoadEventListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    public IReadOnlyList<Feature>? Features
    {
        get { return JsonModel.GetNullableClass<List<Feature>>(this.RawData, "features"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "features", value);
        }
    }

    public RoadEventFeedInfo? RoadEventFeedInfo
    {
        get
        {
            return JsonModel.GetNullableClass<RoadEventFeedInfo>(
                this.RawData,
                "road_event_feed_info"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "road_event_feed_info", value);
        }
    }

    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.Features ?? [])
        {
            item.Validate();
        }
        this.RoadEventFeedInfo?.Validate();
        _ = this.Type;
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

[JsonConverter(typeof(JsonModelConverter<Feature, FeatureFromRaw>))]
public sealed record class Feature : JsonModel
{
    /// <summary>
    /// UUID for this feature
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

    public Geometry? Geometry
    {
        get { return JsonModel.GetNullableClass<Geometry>(this.RawData, "geometry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "geometry", value);
        }
    }

    public Properties? Properties
    {
        get { return JsonModel.GetNullableClass<Properties>(this.RawData, "properties"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "properties", value);
        }
    }

    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Geometry?.Validate();
        this.Properties?.Validate();
        _ = this.Type;
    }

    public Feature() { }

    public Feature(Feature feature)
        : base(feature) { }

    public Feature(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Feature(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FeatureFromRaw.FromRawUnchecked"/>
    public static Feature FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FeatureFromRaw : IFromRawJson<Feature>
{
    /// <inheritdoc/>
    public Feature FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Feature.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Geometry, GeometryFromRaw>))]
public sealed record class Geometry : JsonModel
{
    public IReadOnlyList<List<double>>? Coordinates
    {
        get { return JsonModel.GetNullableClass<List<List<double>>>(this.RawData, "coordinates"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "coordinates", value);
        }
    }

    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Coordinates;
        _ = this.Type;
    }

    public Geometry() { }

    public Geometry(Geometry geometry)
        : base(geometry) { }

    public Geometry(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Geometry(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="GeometryFromRaw.FromRawUnchecked"/>
    public static Geometry FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class GeometryFromRaw : IFromRawJson<Geometry>
{
    /// <inheritdoc/>
    public Geometry FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Geometry.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Properties, PropertiesFromRaw>))]
public sealed record class Properties : JsonModel
{
    public CoreDetails? CoreDetails
    {
        get { return JsonModel.GetNullableClass<CoreDetails>(this.RawData, "core_details"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "core_details", value);
        }
    }

    public string? EndDate
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "end_date"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "end_date", value);
        }
    }

    public bool? IsEndDateVerified
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "is_end_date_verified"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "is_end_date_verified", value);
        }
    }

    public bool? IsEndPositionVerified
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "is_end_position_verified"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "is_end_position_verified", value);
        }
    }

    public bool? IsStartDateVerified
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "is_start_date_verified"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "is_start_date_verified", value);
        }
    }

    public bool? IsStartPositionVerified
    {
        get
        {
            return JsonModel.GetNullableStruct<bool>(this.RawData, "is_start_position_verified");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "is_start_position_verified", value);
        }
    }

    public string? LocationMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "location_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "location_method", value);
        }
    }

    public string? StartDate
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "start_date"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "start_date", value);
        }
    }

    public IReadOnlyList<TypesOfWork>? TypesOfWork
    {
        get { return JsonModel.GetNullableClass<List<TypesOfWork>>(this.RawData, "types_of_work"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "types_of_work", value);
        }
    }

    public string? VehicleImpact
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "vehicle_impact"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "vehicle_impact", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.CoreDetails?.Validate();
        _ = this.EndDate;
        _ = this.IsEndDateVerified;
        _ = this.IsEndPositionVerified;
        _ = this.IsStartDateVerified;
        _ = this.IsStartPositionVerified;
        _ = this.LocationMethod;
        _ = this.StartDate;
        foreach (var item in this.TypesOfWork ?? [])
        {
            item.Validate();
        }
        _ = this.VehicleImpact;
    }

    public Properties() { }

    public Properties(Properties properties)
        : base(properties) { }

    public Properties(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Properties(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PropertiesFromRaw.FromRawUnchecked"/>
    public static Properties FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PropertiesFromRaw : IFromRawJson<Properties>
{
    /// <inheritdoc/>
    public Properties FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Properties.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CoreDetails, CoreDetailsFromRaw>))]
public sealed record class CoreDetails : JsonModel
{
    public string? DataSourceID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "data_source_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data_source_id", value);
        }
    }

    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "description", value);
        }
    }

    public string? Direction
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "direction"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "direction", value);
        }
    }

    public string? EventType
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "event_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "event_type", value);
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

    public IReadOnlyList<string>? RoadNames
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "road_names"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "road_names", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.DataSourceID;
        _ = this.Description;
        _ = this.Direction;
        _ = this.EventType;
        _ = this.Name;
        _ = this.RoadNames;
    }

    public CoreDetails() { }

    public CoreDetails(CoreDetails coreDetails)
        : base(coreDetails) { }

    public CoreDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CoreDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CoreDetailsFromRaw.FromRawUnchecked"/>
    public static CoreDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CoreDetailsFromRaw : IFromRawJson<CoreDetails>
{
    /// <inheritdoc/>
    public CoreDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CoreDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<TypesOfWork, TypesOfWorkFromRaw>))]
public sealed record class TypesOfWork : JsonModel
{
    public string? TypeName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type_name", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.TypeName;
    }

    public TypesOfWork() { }

    public TypesOfWork(TypesOfWork typesOfWork)
        : base(typesOfWork) { }

    public TypesOfWork(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TypesOfWork(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TypesOfWorkFromRaw.FromRawUnchecked"/>
    public static TypesOfWork FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TypesOfWorkFromRaw : IFromRawJson<TypesOfWork>
{
    /// <inheritdoc/>
    public TypesOfWork FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        TypesOfWork.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<RoadEventFeedInfo, RoadEventFeedInfoFromRaw>))]
public sealed record class RoadEventFeedInfo : JsonModel
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

    public string? ContactEmail
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "contact_email"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contact_email", value);
        }
    }

    public string? ContactName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "contact_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contact_name", value);
        }
    }

    public IReadOnlyList<DataSource>? DataSources
    {
        get { return JsonModel.GetNullableClass<List<DataSource>>(this.RawData, "data_sources"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data_sources", value);
        }
    }

    public string? License
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "license"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "license", value);
        }
    }

    public string? Publisher
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "publisher"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "publisher", value);
        }
    }

    public string? UpdateDate
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "update_date"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "update_date", value);
        }
    }

    public double? UpdateFrequency
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "update_frequency"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "update_frequency", value);
        }
    }

    public string? Version
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "version", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.ContactEmail;
        _ = this.ContactName;
        foreach (var item in this.DataSources ?? [])
        {
            item.Validate();
        }
        _ = this.License;
        _ = this.Publisher;
        _ = this.UpdateDate;
        _ = this.UpdateFrequency;
        _ = this.Version;
    }

    public RoadEventFeedInfo() { }

    public RoadEventFeedInfo(RoadEventFeedInfo roadEventFeedInfo)
        : base(roadEventFeedInfo) { }

    public RoadEventFeedInfo(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RoadEventFeedInfo(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RoadEventFeedInfoFromRaw.FromRawUnchecked"/>
    public static RoadEventFeedInfo FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RoadEventFeedInfoFromRaw : IFromRawJson<RoadEventFeedInfo>
{
    /// <inheritdoc/>
    public RoadEventFeedInfo FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        RoadEventFeedInfo.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<DataSource, DataSourceFromRaw>))]
public sealed record class DataSource : JsonModel
{
    public string? ContactEmail
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "contact_email"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contact_email", value);
        }
    }

    public string? ContactName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "contact_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "contact_name", value);
        }
    }

    public string? DataSourceID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "data_source_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "data_source_id", value);
        }
    }

    public string? OrganizationName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "organization_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "organization_name", value);
        }
    }

    public string? UpdateDate
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "update_date"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "update_date", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ContactEmail;
        _ = this.ContactName;
        _ = this.DataSourceID;
        _ = this.OrganizationName;
        _ = this.UpdateDate;
    }

    public DataSource() { }

    public DataSource(DataSource dataSource)
        : base(dataSource) { }

    public DataSource(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataSource(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataSourceFromRaw.FromRawUnchecked"/>
    public static DataSource FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataSourceFromRaw : IFromRawJson<DataSource>
{
    /// <inheritdoc/>
    public DataSource FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataSource.FromRawUnchecked(rawData);
}
