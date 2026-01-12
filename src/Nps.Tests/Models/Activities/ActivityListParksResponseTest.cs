using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Activities;

namespace Nps.Tests.Models.Activities;

public class ActivityListParksResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ActivityListParksResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Historical Park",
                                    FullName =
                                        "Abraham Lincoln Birthplace National Historical Park",
                                    Name = "Abraham Lincoln Birthplace",
                                    ParkCode = "abli",
                                    States = "KY",
                                    Url = "https://www.nps.gov/abli/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "2",
                },
            ],
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<ActivityListParksResponseData> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                        Name = "Arts and Culture",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Historical Park",
                                FullName = "Abraham Lincoln Birthplace National Historical Park",
                                Name = "Abraham Lincoln Birthplace",
                                ParkCode = "abli",
                                States = "KY",
                                Url = "https://www.nps.gov/abli/index.htm",
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "2",
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
        var model = new ActivityListParksResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Historical Park",
                                    FullName =
                                        "Abraham Lincoln Birthplace National Historical Park",
                                    Name = "Abraham Lincoln Birthplace",
                                    ParkCode = "abli",
                                    States = "KY",
                                    Url = "https://www.nps.gov/abli/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "2",
                },
            ],
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ActivityListParksResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Historical Park",
                                    FullName =
                                        "Abraham Lincoln Birthplace National Historical Park",
                                    Name = "Abraham Lincoln Birthplace",
                                    ParkCode = "abli",
                                    States = "KY",
                                    Url = "https://www.nps.gov/abli/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "2",
                },
            ],
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksResponse>(element);
        Assert.NotNull(deserialized);

        List<ActivityListParksResponseData> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                        Name = "Arts and Culture",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Historical Park",
                                FullName = "Abraham Lincoln Birthplace National Historical Park",
                                Name = "Abraham Lincoln Birthplace",
                                ParkCode = "abli",
                                States = "KY",
                                Url = "https://www.nps.gov/abli/index.htm",
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "2",
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
        var model = new ActivityListParksResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Historical Park",
                                    FullName =
                                        "Abraham Lincoln Birthplace National Historical Park",
                                    Name = "Abraham Lincoln Birthplace",
                                    ParkCode = "abli",
                                    States = "KY",
                                    Url = "https://www.nps.gov/abli/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "2",
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
        var model = new ActivityListParksResponse { };

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
        var model = new ActivityListParksResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ActivityListParksResponse
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
        var model = new ActivityListParksResponse
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

public class ActivityListParksResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ActivityListParksResponseData
        {
            Data =
            [
                new()
                {
                    ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                    Name = "Arts and Culture",
                    Parks =
                    [
                        new()
                        {
                            Designation = "National Historical Park",
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
                            Name = "Abraham Lincoln Birthplace",
                            ParkCode = "abli",
                            States = "KY",
                            Url = "https://www.nps.gov/abli/index.htm",
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "2",
        };

        List<ActivityListParksResponseDataData> expectedData =
        [
            new()
            {
                ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                Name = "Arts and Culture",
                Parks =
                [
                    new()
                    {
                        Designation = "National Historical Park",
                        FullName = "Abraham Lincoln Birthplace National Historical Park",
                        Name = "Abraham Lincoln Birthplace",
                        ParkCode = "abli",
                        States = "KY",
                        Url = "https://www.nps.gov/abli/index.htm",
                    },
                ],
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "2";

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
        var model = new ActivityListParksResponseData
        {
            Data =
            [
                new()
                {
                    ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                    Name = "Arts and Culture",
                    Parks =
                    [
                        new()
                        {
                            Designation = "National Historical Park",
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
                            Name = "Abraham Lincoln Birthplace",
                            ParkCode = "abli",
                            States = "KY",
                            Url = "https://www.nps.gov/abli/index.htm",
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "2",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksResponseData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ActivityListParksResponseData
        {
            Data =
            [
                new()
                {
                    ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                    Name = "Arts and Culture",
                    Parks =
                    [
                        new()
                        {
                            Designation = "National Historical Park",
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
                            Name = "Abraham Lincoln Birthplace",
                            ParkCode = "abli",
                            States = "KY",
                            Url = "https://www.nps.gov/abli/index.htm",
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "2",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksResponseData>(element);
        Assert.NotNull(deserialized);

        List<ActivityListParksResponseDataData> expectedData =
        [
            new()
            {
                ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                Name = "Arts and Culture",
                Parks =
                [
                    new()
                    {
                        Designation = "National Historical Park",
                        FullName = "Abraham Lincoln Birthplace National Historical Park",
                        Name = "Abraham Lincoln Birthplace",
                        ParkCode = "abli",
                        States = "KY",
                        Url = "https://www.nps.gov/abli/index.htm",
                    },
                ],
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "2";

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
        var model = new ActivityListParksResponseData
        {
            Data =
            [
                new()
                {
                    ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                    Name = "Arts and Culture",
                    Parks =
                    [
                        new()
                        {
                            Designation = "National Historical Park",
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
                            Name = "Abraham Lincoln Birthplace",
                            ParkCode = "abli",
                            States = "KY",
                            Url = "https://www.nps.gov/abli/index.htm",
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "2",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ActivityListParksResponseData { };

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
        var model = new ActivityListParksResponseData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ActivityListParksResponseData
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
        var model = new ActivityListParksResponseData
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

public class ActivityListParksResponseDataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ActivityListParksResponseDataData
        {
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
            Parks =
            [
                new()
                {
                    Designation = "National Historical Park",
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
        };

        string expectedID = "FEDA3DF8-B871-4C1A-BB96-32823860B174";
        string expectedName = "Arts and Culture";
        List<Park> expectedParks =
        [
            new()
            {
                Designation = "National Historical Park",
                FullName = "Abraham Lincoln Birthplace National Historical Park",
                Name = "Abraham Lincoln Birthplace",
                ParkCode = "abli",
                States = "KY",
                Url = "https://www.nps.gov/abli/index.htm",
            },
        ];

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
        Assert.NotNull(model.Parks);
        Assert.Equal(expectedParks.Count, model.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], model.Parks[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ActivityListParksResponseDataData
        {
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
            Parks =
            [
                new()
                {
                    Designation = "National Historical Park",
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksResponseDataData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ActivityListParksResponseDataData
        {
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
            Parks =
            [
                new()
                {
                    Designation = "National Historical Park",
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksResponseDataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "FEDA3DF8-B871-4C1A-BB96-32823860B174";
        string expectedName = "Arts and Culture";
        List<Park> expectedParks =
        [
            new()
            {
                Designation = "National Historical Park",
                FullName = "Abraham Lincoln Birthplace National Historical Park",
                Name = "Abraham Lincoln Birthplace",
                ParkCode = "abli",
                States = "KY",
                Url = "https://www.nps.gov/abli/index.htm",
            },
        ];

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.NotNull(deserialized.Parks);
        Assert.Equal(expectedParks.Count, deserialized.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], deserialized.Parks[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ActivityListParksResponseDataData
        {
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
            Parks =
            [
                new()
                {
                    Designation = "National Historical Park",
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ActivityListParksResponseDataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ActivityListParksResponseDataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ActivityListParksResponseDataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Parks = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ActivityListParksResponseDataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Parks = null,
        };

        model.Validate();
    }
}

public class ParkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Park
        {
            Designation = "National Historical Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
        };

        string expectedDesignation = "National Historical Park";
        string expectedFullName = "Abraham Lincoln Birthplace National Historical Park";
        string expectedName = "Abraham Lincoln Birthplace";
        string expectedParkCode = "abli";
        string expectedStates = "KY";
        string expectedUrl = "https://www.nps.gov/abli/index.htm";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedStates, model.States);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Park
        {
            Designation = "National Historical Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Park>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Park
        {
            Designation = "National Historical Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Park>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Historical Park";
        string expectedFullName = "Abraham Lincoln Birthplace National Historical Park";
        string expectedName = "Abraham Lincoln Birthplace";
        string expectedParkCode = "abli";
        string expectedStates = "KY";
        string expectedUrl = "https://www.nps.gov/abli/index.htm";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedStates, deserialized.States);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Park
        {
            Designation = "National Historical Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Park { };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Park { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Park
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            States = null,
            Url = null,
        };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Park
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            States = null,
            Url = null,
        };

        model.Validate();
    }
}
