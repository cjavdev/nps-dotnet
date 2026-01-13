using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.People;

[JsonConverter(typeof(JsonModelConverter<PersonListPageResponse, PersonListPageResponseFromRaw>))]
public sealed record class PersonListPageResponse : JsonModel
{
    public IReadOnlyList<PersonListResponse>? Data
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<PersonListResponse>>("data"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<PersonListResponse>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? Limit
    {
        get { return this._rawData.GetNullableStruct<double>("limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("limit", value);
        }
    }

    public double? Start
    {
        get { return this._rawData.GetNullableStruct<double>("start"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("start", value);
        }
    }

    public double? Total
    {
        get { return this._rawData.GetNullableStruct<double>("total"); }
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

    public PersonListPageResponse() { }

    public PersonListPageResponse(PersonListPageResponse personListPageResponse)
        : base(personListPageResponse) { }

    public PersonListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PersonListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PersonListPageResponseFromRaw.FromRawUnchecked"/>
    public static PersonListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PersonListPageResponseFromRaw : IFromRawJson<PersonListPageResponse>
{
    /// <inheritdoc/>
    public PersonListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PersonListPageResponse.FromRawUnchecked(rawData);
}
