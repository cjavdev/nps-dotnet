using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Passportstamplocations;

namespace Nps.Tests.Models.Passportstamplocations;

public class PassportstamplocationListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PassportstamplocationListResponse
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
        };

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "70";

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
        var model = new PassportstamplocationListResponse
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PassportstamplocationListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PassportstamplocationListResponse
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PassportstamplocationListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "70";

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
        var model = new PassportstamplocationListResponse
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PassportstamplocationListResponse { };

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
        var model = new PassportstamplocationListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PassportstamplocationListResponse
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
        var model = new PassportstamplocationListResponse
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
        };

        string expectedID = "B13EC2AF-3E68-430D-8846-293320E2D018";
        string expectedLabel = "Anaktuvuk Pass Ranger Station";
        List<Park> expectedParks =
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
        ];
        string expectedType = "Visitor Center";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedLabel, model.Label);
        Assert.NotNull(model.Parks);
        Assert.Equal(expectedParks.Count, model.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], model.Parks[i]);
        }
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        string expectedID = "B13EC2AF-3E68-430D-8846-293320E2D018";
        string expectedLabel = "Anaktuvuk Pass Ranger Station";
        List<Park> expectedParks =
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
        ];
        string expectedType = "Visitor Center";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedLabel, deserialized.Label);
        Assert.NotNull(deserialized.Parks);
        Assert.Equal(expectedParks.Count, deserialized.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], deserialized.Parks[i]);
        }
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Label);
        Assert.False(model.RawData.ContainsKey("label"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
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
            ID = null,
            Label = null,
            Parks = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Label);
        Assert.False(model.RawData.ContainsKey("label"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Label = null,
            Parks = null,
            Type = null,
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
            Designation = "National Park & Preserve",
            FullName = "Gates Of The Arctic National Park & Preserve",
            Name = "Gates Of The Arctic",
            ParkCode = "gaar",
            States = "AK",
            Url = "https://www.nps.gov/gaar/index.htm",
        };

        string expectedDesignation = "National Park & Preserve";
        string expectedFullName = "Gates Of The Arctic National Park & Preserve";
        string expectedName = "Gates Of The Arctic";
        string expectedParkCode = "gaar";
        string expectedStates = "AK";
        string expectedUrl = "https://www.nps.gov/gaar/index.htm";

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
            Designation = "National Park & Preserve",
            FullName = "Gates Of The Arctic National Park & Preserve",
            Name = "Gates Of The Arctic",
            ParkCode = "gaar",
            States = "AK",
            Url = "https://www.nps.gov/gaar/index.htm",
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
            Designation = "National Park & Preserve",
            FullName = "Gates Of The Arctic National Park & Preserve",
            Name = "Gates Of The Arctic",
            ParkCode = "gaar",
            States = "AK",
            Url = "https://www.nps.gov/gaar/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Park>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park & Preserve";
        string expectedFullName = "Gates Of The Arctic National Park & Preserve";
        string expectedName = "Gates Of The Arctic";
        string expectedParkCode = "gaar";
        string expectedStates = "AK";
        string expectedUrl = "https://www.nps.gov/gaar/index.htm";

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
            Designation = "National Park & Preserve",
            FullName = "Gates Of The Arctic National Park & Preserve",
            Name = "Gates Of The Arctic",
            ParkCode = "gaar",
            States = "AK",
            Url = "https://www.nps.gov/gaar/index.htm",
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
