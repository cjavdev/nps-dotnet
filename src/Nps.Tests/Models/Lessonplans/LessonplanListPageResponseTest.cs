using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Lessonplans;

namespace Nps.Tests.Models.Lessonplans;

public class LessonplanListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LessonplanListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "4837917",
                            Commoncore = new()
                            {
                                Additionalstandards = "additionalstandards",
                                Elastandards = ["string"],
                                Mathstandards = ["string"],
                                Statestandards = "statestandards",
                            },
                            Duration = "duration",
                            Gradelevel = "gradelevel",
                            Parks = ["string"],
                            Questionobjective = "questionobjective",
                            Subject = "subject",
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "806",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<LessonplanListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "4837917",
                        Commoncore = new()
                        {
                            Additionalstandards = "additionalstandards",
                            Elastandards = ["string"],
                            Mathstandards = ["string"],
                            Statestandards = "statestandards",
                        },
                        Duration = "duration",
                        Gradelevel = "gradelevel",
                        Parks = ["string"],
                        Questionobjective = "questionobjective",
                        Subject = "subject",
                        Title = "title",
                        Url = "url",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "806",
            },
        ];
        double expectedLimit = 0;
        double expectedStart = 0;
        double expectedTotal = 0;

        Assert.NotNull(model.Data);
        Assert.Equal(expectedData.Count, model.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], model.Data[i]);
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedStart, model.Start);
        Assert.Equal(expectedTotal, model.Total);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LessonplanListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "4837917",
                            Commoncore = new()
                            {
                                Additionalstandards = "additionalstandards",
                                Elastandards = ["string"],
                                Mathstandards = ["string"],
                                Statestandards = "statestandards",
                            },
                            Duration = "duration",
                            Gradelevel = "gradelevel",
                            Parks = ["string"],
                            Questionobjective = "questionobjective",
                            Subject = "subject",
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "806",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<LessonplanListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LessonplanListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "4837917",
                            Commoncore = new()
                            {
                                Additionalstandards = "additionalstandards",
                                Elastandards = ["string"],
                                Mathstandards = ["string"],
                                Statestandards = "statestandards",
                            },
                            Duration = "duration",
                            Gradelevel = "gradelevel",
                            Parks = ["string"],
                            Questionobjective = "questionobjective",
                            Subject = "subject",
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "806",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<LessonplanListPageResponse>(element);
        Assert.NotNull(deserialized);

        List<LessonplanListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "4837917",
                        Commoncore = new()
                        {
                            Additionalstandards = "additionalstandards",
                            Elastandards = ["string"],
                            Mathstandards = ["string"],
                            Statestandards = "statestandards",
                        },
                        Duration = "duration",
                        Gradelevel = "gradelevel",
                        Parks = ["string"],
                        Questionobjective = "questionobjective",
                        Subject = "subject",
                        Title = "title",
                        Url = "url",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "806",
            },
        ];
        double expectedLimit = 0;
        double expectedStart = 0;
        double expectedTotal = 0;

        Assert.NotNull(deserialized.Data);
        Assert.Equal(expectedData.Count, deserialized.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], deserialized.Data[i]);
        }
        Assert.Equal(expectedLimit, deserialized.Limit);
        Assert.Equal(expectedStart, deserialized.Start);
        Assert.Equal(expectedTotal, deserialized.Total);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LessonplanListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "4837917",
                            Commoncore = new()
                            {
                                Additionalstandards = "additionalstandards",
                                Elastandards = ["string"],
                                Mathstandards = ["string"],
                                Statestandards = "statestandards",
                            },
                            Duration = "duration",
                            Gradelevel = "gradelevel",
                            Parks = ["string"],
                            Questionobjective = "questionobjective",
                            Subject = "subject",
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "806",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LessonplanListPageResponse { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Start);
        Assert.False(model.RawData.ContainsKey("start"));
        Assert.Null(model.Total);
        Assert.False(model.RawData.ContainsKey("total"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new LessonplanListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new LessonplanListPageResponse
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Start);
        Assert.False(model.RawData.ContainsKey("start"));
        Assert.Null(model.Total);
        Assert.False(model.RawData.ContainsKey("total"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LessonplanListPageResponse
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        model.Validate();
    }
}
