using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Activities;

namespace Nps.Tests.Models.Activities;

public class ActivityListParksPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ActivityListParksPageResponse
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
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<ActivityListParksResponse> expectedData =
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
        var model = new ActivityListParksPageResponse
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
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ActivityListParksPageResponse
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
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ActivityListParksPageResponse>(element);
        Assert.NotNull(deserialized);

        List<ActivityListParksResponse> expectedData =
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
        var model = new ActivityListParksPageResponse
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
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ActivityListParksPageResponse { };

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
        var model = new ActivityListParksPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ActivityListParksPageResponse
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
        var model = new ActivityListParksPageResponse
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
