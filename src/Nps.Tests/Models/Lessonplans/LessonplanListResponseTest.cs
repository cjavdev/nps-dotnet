using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Lessonplans;

namespace Nps.Tests.Models.Lessonplans;

public class LessonplanListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LessonplanListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        string expectedLimit = "limit";
        string expectedStart = "start";
        string expectedTotal = "total";

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
        var model = new LessonplanListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<LessonplanListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LessonplanListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<LessonplanListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        string expectedLimit = "limit";
        string expectedStart = "start";
        string expectedTotal = "total";

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
        var model = new LessonplanListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LessonplanListResponse { };

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
        var model = new LessonplanListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new LessonplanListResponse
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
        var model = new LessonplanListResponse
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

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Data
        {
            DataValue =
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
        };

        List<DataData> expectedDataValue =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "806";

        Assert.NotNull(model.DataValue);
        Assert.Equal(expectedDataValue.Count, model.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], model.DataValue[i]);
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedStart, model.Start);
        Assert.Equal(expectedTotal, model.Total);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            DataValue =
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
        {
            DataValue =
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        List<DataData> expectedDataValue =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "806";

        Assert.NotNull(deserialized.DataValue);
        Assert.Equal(expectedDataValue.Count, deserialized.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], deserialized.DataValue[i]);
        }
        Assert.Equal(expectedLimit, deserialized.Limit);
        Assert.Equal(expectedStart, deserialized.Start);
        Assert.Equal(expectedTotal, deserialized.Total);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            DataValue =
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.DataValue);
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
        var model = new Data { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            DataValue = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        Assert.Null(model.DataValue);
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
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            DataValue = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        model.Validate();
    }
}

public class DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataData
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
        };

        string expectedID = "4837917";
        Commoncore expectedCommoncore = new()
        {
            Additionalstandards = "additionalstandards",
            Elastandards = ["string"],
            Mathstandards = ["string"],
            Statestandards = "statestandards",
        };
        string expectedDuration = "duration";
        string expectedGradelevel = "gradelevel";
        List<string> expectedParks = ["string"];
        string expectedQuestionobjective = "questionobjective";
        string expectedSubject = "subject";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCommoncore, model.Commoncore);
        Assert.Equal(expectedDuration, model.Duration);
        Assert.Equal(expectedGradelevel, model.Gradelevel);
        Assert.NotNull(model.Parks);
        Assert.Equal(expectedParks.Count, model.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], model.Parks[i]);
        }
        Assert.Equal(expectedQuestionobjective, model.Questionobjective);
        Assert.Equal(expectedSubject, model.Subject);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataData
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataData
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "4837917";
        Commoncore expectedCommoncore = new()
        {
            Additionalstandards = "additionalstandards",
            Elastandards = ["string"],
            Mathstandards = ["string"],
            Statestandards = "statestandards",
        };
        string expectedDuration = "duration";
        string expectedGradelevel = "gradelevel";
        List<string> expectedParks = ["string"];
        string expectedQuestionobjective = "questionobjective";
        string expectedSubject = "subject";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCommoncore, deserialized.Commoncore);
        Assert.Equal(expectedDuration, deserialized.Duration);
        Assert.Equal(expectedGradelevel, deserialized.Gradelevel);
        Assert.NotNull(deserialized.Parks);
        Assert.Equal(expectedParks.Count, deserialized.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], deserialized.Parks[i]);
        }
        Assert.Equal(expectedQuestionobjective, deserialized.Questionobjective);
        Assert.Equal(expectedSubject, deserialized.Subject);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataData
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Commoncore);
        Assert.False(model.RawData.ContainsKey("commoncore"));
        Assert.Null(model.Duration);
        Assert.False(model.RawData.ContainsKey("duration"));
        Assert.Null(model.Gradelevel);
        Assert.False(model.RawData.ContainsKey("gradelevel"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
        Assert.Null(model.Questionobjective);
        Assert.False(model.RawData.ContainsKey("questionobjective"));
        Assert.Null(model.Subject);
        Assert.False(model.RawData.ContainsKey("subject"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Commoncore = null,
            Duration = null,
            Gradelevel = null,
            Parks = null,
            Questionobjective = null,
            Subject = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Commoncore);
        Assert.False(model.RawData.ContainsKey("commoncore"));
        Assert.Null(model.Duration);
        Assert.False(model.RawData.ContainsKey("duration"));
        Assert.Null(model.Gradelevel);
        Assert.False(model.RawData.ContainsKey("gradelevel"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
        Assert.Null(model.Questionobjective);
        Assert.False(model.RawData.ContainsKey("questionobjective"));
        Assert.Null(model.Subject);
        Assert.False(model.RawData.ContainsKey("subject"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Commoncore = null,
            Duration = null,
            Gradelevel = null,
            Parks = null,
            Questionobjective = null,
            Subject = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class CommoncoreTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Commoncore
        {
            Additionalstandards = "additionalstandards",
            Elastandards = ["string"],
            Mathstandards = ["string"],
            Statestandards = "statestandards",
        };

        string expectedAdditionalstandards = "additionalstandards";
        List<string> expectedElastandards = ["string"];
        List<string> expectedMathstandards = ["string"];
        string expectedStatestandards = "statestandards";

        Assert.Equal(expectedAdditionalstandards, model.Additionalstandards);
        Assert.NotNull(model.Elastandards);
        Assert.Equal(expectedElastandards.Count, model.Elastandards.Count);
        for (int i = 0; i < expectedElastandards.Count; i++)
        {
            Assert.Equal(expectedElastandards[i], model.Elastandards[i]);
        }
        Assert.NotNull(model.Mathstandards);
        Assert.Equal(expectedMathstandards.Count, model.Mathstandards.Count);
        for (int i = 0; i < expectedMathstandards.Count; i++)
        {
            Assert.Equal(expectedMathstandards[i], model.Mathstandards[i]);
        }
        Assert.Equal(expectedStatestandards, model.Statestandards);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Commoncore
        {
            Additionalstandards = "additionalstandards",
            Elastandards = ["string"],
            Mathstandards = ["string"],
            Statestandards = "statestandards",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Commoncore>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Commoncore
        {
            Additionalstandards = "additionalstandards",
            Elastandards = ["string"],
            Mathstandards = ["string"],
            Statestandards = "statestandards",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Commoncore>(element);
        Assert.NotNull(deserialized);

        string expectedAdditionalstandards = "additionalstandards";
        List<string> expectedElastandards = ["string"];
        List<string> expectedMathstandards = ["string"];
        string expectedStatestandards = "statestandards";

        Assert.Equal(expectedAdditionalstandards, deserialized.Additionalstandards);
        Assert.NotNull(deserialized.Elastandards);
        Assert.Equal(expectedElastandards.Count, deserialized.Elastandards.Count);
        for (int i = 0; i < expectedElastandards.Count; i++)
        {
            Assert.Equal(expectedElastandards[i], deserialized.Elastandards[i]);
        }
        Assert.NotNull(deserialized.Mathstandards);
        Assert.Equal(expectedMathstandards.Count, deserialized.Mathstandards.Count);
        for (int i = 0; i < expectedMathstandards.Count; i++)
        {
            Assert.Equal(expectedMathstandards[i], deserialized.Mathstandards[i]);
        }
        Assert.Equal(expectedStatestandards, deserialized.Statestandards);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Commoncore
        {
            Additionalstandards = "additionalstandards",
            Elastandards = ["string"],
            Mathstandards = ["string"],
            Statestandards = "statestandards",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Commoncore { };

        Assert.Null(model.Additionalstandards);
        Assert.False(model.RawData.ContainsKey("additionalstandards"));
        Assert.Null(model.Elastandards);
        Assert.False(model.RawData.ContainsKey("elastandards"));
        Assert.Null(model.Mathstandards);
        Assert.False(model.RawData.ContainsKey("mathstandards"));
        Assert.Null(model.Statestandards);
        Assert.False(model.RawData.ContainsKey("statestandards"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Commoncore { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Commoncore
        {
            // Null should be interpreted as omitted for these properties
            Additionalstandards = null,
            Elastandards = null,
            Mathstandards = null,
            Statestandards = null,
        };

        Assert.Null(model.Additionalstandards);
        Assert.False(model.RawData.ContainsKey("additionalstandards"));
        Assert.Null(model.Elastandards);
        Assert.False(model.RawData.ContainsKey("elastandards"));
        Assert.Null(model.Mathstandards);
        Assert.False(model.RawData.ContainsKey("mathstandards"));
        Assert.Null(model.Statestandards);
        Assert.False(model.RawData.ContainsKey("statestandards"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Commoncore
        {
            // Null should be interpreted as omitted for these properties
            Additionalstandards = null,
            Elastandards = null,
            Mathstandards = null,
            Statestandards = null,
        };

        model.Validate();
    }
}
