using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Maps;

[JsonConverter(
    typeof(JsonModelConverter<
        MapRetrieveParkBoundariesResponse,
        MapRetrieveParkBoundariesResponseFromRaw
    >)
)]
public sealed record class MapRetrieveParkBoundariesResponse : JsonModel
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

    public MapRetrieveParkBoundariesResponse() { }

    public MapRetrieveParkBoundariesResponse(
        MapRetrieveParkBoundariesResponse mapRetrieveParkBoundariesResponse
    )
        : base(mapRetrieveParkBoundariesResponse) { }

    public MapRetrieveParkBoundariesResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    MapRetrieveParkBoundariesResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MapRetrieveParkBoundariesResponseFromRaw.FromRawUnchecked"/>
    public static MapRetrieveParkBoundariesResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MapRetrieveParkBoundariesResponseFromRaw : IFromRawJson<MapRetrieveParkBoundariesResponse>
{
    /// <inheritdoc/>
    public MapRetrieveParkBoundariesResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => MapRetrieveParkBoundariesResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Geometry, GeometryFromRaw>))]
public sealed record class Geometry : JsonModel
{
    public IReadOnlyList<List<List<UnnamedSchemaWithArrayParent0>>>? Coordinates
    {
        get
        {
            return JsonModel.GetNullableClass<List<List<List<UnnamedSchemaWithArrayParent0>>>>(
                this.RawData,
                "coordinates"
            );
        }
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
        foreach (var item in this.Coordinates ?? [])
        {
            foreach (var item1 in item)
            {
                foreach (var item2 in item1)
                {
                    item2.Validate();
                }
            }
        }
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

[JsonConverter(
    typeof(JsonModelConverter<UnnamedSchemaWithArrayParent0, UnnamedSchemaWithArrayParent0FromRaw>)
)]
public sealed record class UnnamedSchemaWithArrayParent0 : JsonModel
{
    public double? U0
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "0"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "0", value);
        }
    }

    public double? U1
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawData, "1"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "1", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.U0;
        _ = this.U1;
    }

    public UnnamedSchemaWithArrayParent0() { }

    public UnnamedSchemaWithArrayParent0(
        UnnamedSchemaWithArrayParent0 unnamedSchemaWithArrayParent0
    )
        : base(unnamedSchemaWithArrayParent0) { }

    public UnnamedSchemaWithArrayParent0(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UnnamedSchemaWithArrayParent0(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UnnamedSchemaWithArrayParent0FromRaw.FromRawUnchecked"/>
    public static UnnamedSchemaWithArrayParent0 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UnnamedSchemaWithArrayParent0FromRaw : IFromRawJson<UnnamedSchemaWithArrayParent0>
{
    /// <inheritdoc/>
    public UnnamedSchemaWithArrayParent0 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UnnamedSchemaWithArrayParent0.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Properties, PropertiesFromRaw>))]
public sealed record class Properties : JsonModel
{
    public string? ParkClass
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "parkClass"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "parkClass", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ParkClass;
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
