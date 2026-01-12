using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Topics;

namespace Nps.Tests.Models.Topics;

public class TopicListParksPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TopicListParksPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F40AC1EE-420B-457B-B519-EC6EE5280F0C",
                            Name = "animals",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Heritage Area",
                                    FullName = "Arabia Mountain National Heritage Area",
                                    Name = "Arabia Mountain",
                                    ParkCode = "armo",
                                    States = "GA",
                                    Url = "https://www.nps.gov/armo/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "3",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<TopicListParksResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "F40AC1EE-420B-457B-B519-EC6EE5280F0C",
                        Name = "animals",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Heritage Area",
                                FullName = "Arabia Mountain National Heritage Area",
                                Name = "Arabia Mountain",
                                ParkCode = "armo",
                                States = "GA",
                                Url = "https://www.nps.gov/armo/index.htm",
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "3",
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
        var model = new TopicListParksPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F40AC1EE-420B-457B-B519-EC6EE5280F0C",
                            Name = "animals",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Heritage Area",
                                    FullName = "Arabia Mountain National Heritage Area",
                                    Name = "Arabia Mountain",
                                    ParkCode = "armo",
                                    States = "GA",
                                    Url = "https://www.nps.gov/armo/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "3",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TopicListParksPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TopicListParksPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F40AC1EE-420B-457B-B519-EC6EE5280F0C",
                            Name = "animals",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Heritage Area",
                                    FullName = "Arabia Mountain National Heritage Area",
                                    Name = "Arabia Mountain",
                                    ParkCode = "armo",
                                    States = "GA",
                                    Url = "https://www.nps.gov/armo/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "3",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TopicListParksPageResponse>(element);
        Assert.NotNull(deserialized);

        List<TopicListParksResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "F40AC1EE-420B-457B-B519-EC6EE5280F0C",
                        Name = "animals",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Heritage Area",
                                FullName = "Arabia Mountain National Heritage Area",
                                Name = "Arabia Mountain",
                                ParkCode = "armo",
                                States = "GA",
                                Url = "https://www.nps.gov/armo/index.htm",
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "3",
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
        var model = new TopicListParksPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F40AC1EE-420B-457B-B519-EC6EE5280F0C",
                            Name = "animals",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Heritage Area",
                                    FullName = "Arabia Mountain National Heritage Area",
                                    Name = "Arabia Mountain",
                                    ParkCode = "armo",
                                    States = "GA",
                                    Url = "https://www.nps.gov/armo/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "3",
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
        var model = new TopicListParksPageResponse { };

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
        var model = new TopicListParksPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TopicListParksPageResponse
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
        var model = new TopicListParksPageResponse
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
