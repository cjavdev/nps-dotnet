using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nps.Core;

namespace Nps.Models.Lessonplans;

[JsonConverter(typeof(JsonModelConverter<LessonplanListResponse, LessonplanListResponseFromRaw>))]
public sealed record class LessonplanListResponse : JsonModel
{
    public IReadOnlyList<Data>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Data>>("data");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("limit");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("start");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("total");
        }
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

    public LessonplanListResponse() { }

    public LessonplanListResponse(LessonplanListResponse lessonplanListResponse)
        : base(lessonplanListResponse) { }

    public LessonplanListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LessonplanListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LessonplanListResponseFromRaw.FromRawUnchecked"/>
    public static LessonplanListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LessonplanListResponseFromRaw : IFromRawJson<LessonplanListResponse>
{
    /// <inheritdoc/>
    public LessonplanListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LessonplanListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for this lesson plan
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

    /// <summary>
    /// Educational standards that apply to this lesson
    /// </summary>
    public Commoncore? Commoncore
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Commoncore>("commoncore");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("commoncore", value);
        }
    }

    /// <summary>
    /// Time it takes to peform the lesson
    /// </summary>
    public string? Duration
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("duration");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("duration", value);
        }
    }

    /// <summary>
    /// Grade level of students at which this lesson is aimed
    /// </summary>
    public string? Gradelevel
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("gradelevel");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("gradelevel", value);
        }
    }

    /// <summary>
    /// Related parks for this lesson plan
    /// </summary>
    public IReadOnlyList<string>? Parks
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("parks");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "parks",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Objective of the lesson or the question student should be able to answer at
    /// the end of the lesson
    /// </summary>
    public string? Questionobjective
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("questionobjective");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("questionobjective", value);
        }
    }

    /// <summary>
    /// Broad subject the lesson falls under= literacy and language arts, math, science,
    /// or social studies
    /// </summary>
    public string? Subject
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("subject");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("subject", value);
        }
    }

    /// <summary>
    /// Lesson plan title
    /// </summary>
    public string? Title
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("title");
        }
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
    /// Lesson plan link
    /// </summary>
    public string? Url
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("url");
        }
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
        this.Commoncore?.Validate();
        _ = this.Duration;
        _ = this.Gradelevel;
        _ = this.Parks;
        _ = this.Questionobjective;
        _ = this.Subject;
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

/// <summary>
/// Educational standards that apply to this lesson
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Commoncore, CommoncoreFromRaw>))]
public sealed record class Commoncore : JsonModel
{
    public string? Additionalstandards
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("additionalstandards");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("additionalstandards", value);
        }
    }

    public IReadOnlyList<string>? Elastandards
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("elastandards");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "elastandards",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<string>? Mathstandards
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("mathstandards");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "mathstandards",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Statestandards
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("statestandards");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("statestandards", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Additionalstandards;
        _ = this.Elastandards;
        _ = this.Mathstandards;
        _ = this.Statestandards;
    }

    public Commoncore() { }

    public Commoncore(Commoncore commoncore)
        : base(commoncore) { }

    public Commoncore(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Commoncore(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CommoncoreFromRaw.FromRawUnchecked"/>
    public static Commoncore FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CommoncoreFromRaw : IFromRawJson<Commoncore>
{
    /// <inheritdoc/>
    public Commoncore FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Commoncore.FromRawUnchecked(rawData);
}
