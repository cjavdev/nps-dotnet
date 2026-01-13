using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.RoadEvents;

[JsonConverter(typeof(JsonModelConverter<RoadEventListResponse, RoadEventListResponseFromRaw>))]
public sealed record class RoadEventListResponse : JsonModel
{
    public IReadOnlyList<Feature>? Features
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Feature>>("features");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Feature>?>(
                "features",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public RoadEventFeedInfo? RoadEventFeedInfo
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<RoadEventFeedInfo>("road_event_feed_info");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("road_event_feed_info", value);
        }
    }

    public string? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
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

    public RoadEventListResponse() { }

    public RoadEventListResponse(RoadEventListResponse roadEventListResponse)
        : base(roadEventListResponse) { }

    public RoadEventListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RoadEventListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

[JsonConverter(typeof(JsonModelConverter<Feature, FeatureFromRaw>))]
public sealed record class Feature : JsonModel
{
    /// <summary>
    /// UUID for this feature
    /// </summary>
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public Geometry? Geometry
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Geometry>("geometry");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("geometry", value);
        }
    }

    public Properties? Properties
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Properties>("properties");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("properties", value);
        }
    }

    public string? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Feature(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
    public IReadOnlyList<IReadOnlyList<double>>? Coordinates
    {
        get
        {
            this._rawData.Freeze();
            return ImmutableArray.ToImmutableArray(
                Enumerable.Select(
                    this._rawData.GetNullableStruct<ImmutableArray<ImmutableArray<double>>>(
                        "coordinates"
                    ),
                    (item) => (IReadOnlyList<double>)item
                )
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ImmutableArray<double>>?>(
                "coordinates",
                value == null
                    ? null
                    : ImmutableArray.ToImmutableArray(
                        Enumerable.Select(value, (item) => ImmutableArray.ToImmutableArray(item))
                    )
            );
        }
    }

    public string? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Geometry(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CoreDetails>("core_details");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("core_details", value);
        }
    }

    public string? EndDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("end_date");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("end_date", value);
        }
    }

    public bool? IsEndDateVerified
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("is_end_date_verified");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("is_end_date_verified", value);
        }
    }

    public bool? IsEndPositionVerified
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("is_end_position_verified");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("is_end_position_verified", value);
        }
    }

    public bool? IsStartDateVerified
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("is_start_date_verified");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("is_start_date_verified", value);
        }
    }

    public bool? IsStartPositionVerified
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("is_start_position_verified");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("is_start_position_verified", value);
        }
    }

    public string? LocationMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("location_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("location_method", value);
        }
    }

    public string? StartDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("start_date");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("start_date", value);
        }
    }

    public IReadOnlyList<TypesOfWork>? TypesOfWork
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<TypesOfWork>>("types_of_work");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<TypesOfWork>?>(
                "types_of_work",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? VehicleImpact
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("vehicle_impact");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("vehicle_impact", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Properties(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("data_source_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("data_source_id", value);
        }
    }

    public string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public string? Direction
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("direction");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("direction", value);
        }
    }

    public string? EventType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("event_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("event_type", value);
        }
    }

    public string? Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name", value);
        }
    }

    public IReadOnlyList<string>? RoadNames
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("road_names");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "road_names",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CoreDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("type_name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type_name", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TypesOfWork(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public string? ContactEmail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("contact_email");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contact_email", value);
        }
    }

    public string? ContactName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("contact_name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contact_name", value);
        }
    }

    public IReadOnlyList<DataSource>? DataSources
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<DataSource>>("data_sources");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<DataSource>?>(
                "data_sources",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? License
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("license");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("license", value);
        }
    }

    public string? Publisher
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("publisher");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("publisher", value);
        }
    }

    public string? UpdateDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("update_date");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("update_date", value);
        }
    }

    public double? UpdateFrequency
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("update_frequency");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("update_frequency", value);
        }
    }

    public string? Version
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("version");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("version", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RoadEventFeedInfo(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("contact_email");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contact_email", value);
        }
    }

    public string? ContactName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("contact_name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("contact_name", value);
        }
    }

    public string? DataSourceID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("data_source_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("data_source_id", value);
        }
    }

    public string? OrganizationName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("organization_name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("organization_name", value);
        }
    }

    public string? UpdateDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("update_date");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("update_date", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataSource(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
