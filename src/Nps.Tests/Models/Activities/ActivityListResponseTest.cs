using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Activities;

namespace Nps.Tests.Models.Activities;

public class ActivityListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ActivityListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
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

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
                [
                    new()
                    {
                        ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                        Name = "Arts and Culture",
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
        var model = new ActivityListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
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
        var deserialized = JsonSerializer.Deserialize<ActivityListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ActivityListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
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
        var deserialized = JsonSerializer.Deserialize<ActivityListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
                [
                    new()
                    {
                        ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                        Name = "Arts and Culture",
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
        var model = new ActivityListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
                    [
                        new()
                        {
                            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
                            Name = "Arts and Culture",
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
        var model = new ActivityListResponse { };

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
        var model = new ActivityListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ActivityListResponse
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
        var model = new ActivityListResponse
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
                new() { ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174", Name = "Arts and Culture" },
            ],
            Limit = "50",
            Start = "0",
            Total = "2",
        };

        List<DataData> expectedDataValue =
        [
            new() { ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174", Name = "Arts and Culture" },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "2";

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
                new() { ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174", Name = "Arts and Culture" },
            ],
            Limit = "50",
            Start = "0",
            Total = "2",
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
                new() { ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174", Name = "Arts and Culture" },
            ],
            Limit = "50",
            Start = "0",
            Total = "2",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        List<DataData> expectedDataValue =
        [
            new() { ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174", Name = "Arts and Culture" },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "2";

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
                new() { ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174", Name = "Arts and Culture" },
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
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
        };

        string expectedID = "FEDA3DF8-B871-4C1A-BB96-32823860B174";
        string expectedName = "Arts and Culture";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataData
        {
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
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
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "FEDA3DF8-B871-4C1A-BB96-32823860B174";
        string expectedName = "Arts and Culture";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataData
        {
            ID = "FEDA3DF8-B871-4C1A-BB96-32823860B174",
            Name = "Arts and Culture",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
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
            Name = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        model.Validate();
    }
}
