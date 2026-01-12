using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.PassportStampLocations;

namespace Nps.Tests.Models.PassportStampLocations;

public class PassportStampLocationListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PassportStampLocationListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "B13EC2AF-3E68-430D-8846-293320E2D018",
                            Label = "Anaktuvuk Pass Ranger Station",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Park & Preserve",
                                    FullName = "Gates Of The Arctic National Park & Preserve",
                                    Name = "Gates Of The Arctic",
                                    ParkCode = "gaar",
                                    States = "AK",
                                    Url = "https://www.nps.gov/gaar/index.htm",
                                },
                            ],
                            Type = "Visitor Center",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "70",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<PassportStampLocationListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "B13EC2AF-3E68-430D-8846-293320E2D018",
                        Label = "Anaktuvuk Pass Ranger Station",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Park & Preserve",
                                FullName = "Gates Of The Arctic National Park & Preserve",
                                Name = "Gates Of The Arctic",
                                ParkCode = "gaar",
                                States = "AK",
                                Url = "https://www.nps.gov/gaar/index.htm",
                            },
                        ],
                        Type = "Visitor Center",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "70",
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
        var model = new PassportStampLocationListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "B13EC2AF-3E68-430D-8846-293320E2D018",
                            Label = "Anaktuvuk Pass Ranger Station",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Park & Preserve",
                                    FullName = "Gates Of The Arctic National Park & Preserve",
                                    Name = "Gates Of The Arctic",
                                    ParkCode = "gaar",
                                    States = "AK",
                                    Url = "https://www.nps.gov/gaar/index.htm",
                                },
                            ],
                            Type = "Visitor Center",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "70",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PassportStampLocationListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PassportStampLocationListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "B13EC2AF-3E68-430D-8846-293320E2D018",
                            Label = "Anaktuvuk Pass Ranger Station",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Park & Preserve",
                                    FullName = "Gates Of The Arctic National Park & Preserve",
                                    Name = "Gates Of The Arctic",
                                    ParkCode = "gaar",
                                    States = "AK",
                                    Url = "https://www.nps.gov/gaar/index.htm",
                                },
                            ],
                            Type = "Visitor Center",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "70",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PassportStampLocationListPageResponse>(
            element
        );
        Assert.NotNull(deserialized);

        List<PassportStampLocationListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "B13EC2AF-3E68-430D-8846-293320E2D018",
                        Label = "Anaktuvuk Pass Ranger Station",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Park & Preserve",
                                FullName = "Gates Of The Arctic National Park & Preserve",
                                Name = "Gates Of The Arctic",
                                ParkCode = "gaar",
                                States = "AK",
                                Url = "https://www.nps.gov/gaar/index.htm",
                            },
                        ],
                        Type = "Visitor Center",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "70",
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
        var model = new PassportStampLocationListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "B13EC2AF-3E68-430D-8846-293320E2D018",
                            Label = "Anaktuvuk Pass Ranger Station",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Park & Preserve",
                                    FullName = "Gates Of The Arctic National Park & Preserve",
                                    Name = "Gates Of The Arctic",
                                    ParkCode = "gaar",
                                    States = "AK",
                                    Url = "https://www.nps.gov/gaar/index.htm",
                                },
                            ],
                            Type = "Visitor Center",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "70",
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
        var model = new PassportStampLocationListPageResponse { };

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
        var model = new PassportStampLocationListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PassportStampLocationListPageResponse
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
        var model = new PassportStampLocationListPageResponse
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
