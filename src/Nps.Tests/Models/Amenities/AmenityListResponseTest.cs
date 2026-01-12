using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Amenities;

namespace Nps.Tests.Models.Amenities;

public class AmenityListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityListResponse
        {
            Data =
            [
                new()
                {
                    ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                    Name = "Accessibility - Accessible Restroom",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "121",
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                Name = "Accessibility - Accessible Restroom",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "121";

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
        var model = new AmenityListResponse
        {
            Data =
            [
                new()
                {
                    ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                    Name = "Accessibility - Accessible Restroom",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "121",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityListResponse
        {
            Data =
            [
                new()
                {
                    ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                    Name = "Accessibility - Accessible Restroom",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "121",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                Name = "Accessibility - Accessible Restroom",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "121";

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
        var model = new AmenityListResponse
        {
            Data =
            [
                new()
                {
                    ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                    Name = "Accessibility - Accessible Restroom",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "121",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AmenityListResponse { };

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
        var model = new AmenityListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityListResponse
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
        var model = new AmenityListResponse
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
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
        };

        string expectedID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F";
        string expectedName = "Accessibility - Accessible Restroom";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
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
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        string expectedID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F";
        string expectedName = "Accessibility - Accessible Restroom";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
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
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        model.Validate();
    }
}
