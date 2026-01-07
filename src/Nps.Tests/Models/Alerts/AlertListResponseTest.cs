using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Exceptions;
using Nps.Models.Alerts;

namespace Nps.Tests.Models.Alerts;

public class AlertListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AlertListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Category = Category.Danger,
                    Description = "description",
                    LastIndexedDate = "lastIndexedDate",
                    ParkCode = "parkCode",
                    RelatedRoadEvents =
                    [
                        new()
                        {
                            ID = "id",
                            Title = "title",
                            Type = "type",
                            Url = "url",
                        },
                    ],
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "474",
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "id",
                Category = Category.Danger,
                Description = "description",
                LastIndexedDate = "lastIndexedDate",
                ParkCode = "parkCode",
                RelatedRoadEvents =
                [
                    new()
                    {
                        ID = "id",
                        Title = "title",
                        Type = "type",
                        Url = "url",
                    },
                ],
                Title = "title",
                Url = "url",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "474";

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
        var model = new AlertListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Category = Category.Danger,
                    Description = "description",
                    LastIndexedDate = "lastIndexedDate",
                    ParkCode = "parkCode",
                    RelatedRoadEvents =
                    [
                        new()
                        {
                            ID = "id",
                            Title = "title",
                            Type = "type",
                            Url = "url",
                        },
                    ],
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "474",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AlertListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AlertListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Category = Category.Danger,
                    Description = "description",
                    LastIndexedDate = "lastIndexedDate",
                    ParkCode = "parkCode",
                    RelatedRoadEvents =
                    [
                        new()
                        {
                            ID = "id",
                            Title = "title",
                            Type = "type",
                            Url = "url",
                        },
                    ],
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "474",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AlertListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "id",
                Category = Category.Danger,
                Description = "description",
                LastIndexedDate = "lastIndexedDate",
                ParkCode = "parkCode",
                RelatedRoadEvents =
                [
                    new()
                    {
                        ID = "id",
                        Title = "title",
                        Type = "type",
                        Url = "url",
                    },
                ],
                Title = "title",
                Url = "url",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "474";

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
        var model = new AlertListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Category = Category.Danger,
                    Description = "description",
                    LastIndexedDate = "lastIndexedDate",
                    ParkCode = "parkCode",
                    RelatedRoadEvents =
                    [
                        new()
                        {
                            ID = "id",
                            Title = "title",
                            Type = "type",
                            Url = "url",
                        },
                    ],
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "474",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AlertListResponse { };

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
        var model = new AlertListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AlertListResponse
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
        var model = new AlertListResponse
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
            ID = "id",
            Category = Category.Danger,
            Description = "description",
            LastIndexedDate = "lastIndexedDate",
            ParkCode = "parkCode",
            RelatedRoadEvents =
            [
                new()
                {
                    ID = "id",
                    Title = "title",
                    Type = "type",
                    Url = "url",
                },
            ],
            Title = "title",
            Url = "url",
        };

        string expectedID = "id";
        ApiEnum<string, Category> expectedCategory = Category.Danger;
        string expectedDescription = "description";
        string expectedLastIndexedDate = "lastIndexedDate";
        string expectedParkCode = "parkCode";
        List<RelatedRoadEvent> expectedRelatedRoadEvents =
        [
            new()
            {
                ID = "id",
                Title = "title",
                Type = "type",
                Url = "url",
            },
        ];
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCategory, model.Category);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedLastIndexedDate, model.LastIndexedDate);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.NotNull(model.RelatedRoadEvents);
        Assert.Equal(expectedRelatedRoadEvents.Count, model.RelatedRoadEvents.Count);
        for (int i = 0; i < expectedRelatedRoadEvents.Count; i++)
        {
            Assert.Equal(expectedRelatedRoadEvents[i], model.RelatedRoadEvents[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "id",
            Category = Category.Danger,
            Description = "description",
            LastIndexedDate = "lastIndexedDate",
            ParkCode = "parkCode",
            RelatedRoadEvents =
            [
                new()
                {
                    ID = "id",
                    Title = "title",
                    Type = "type",
                    Url = "url",
                },
            ],
            Title = "title",
            Url = "url",
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
            ID = "id",
            Category = Category.Danger,
            Description = "description",
            LastIndexedDate = "lastIndexedDate",
            ParkCode = "parkCode",
            RelatedRoadEvents =
            [
                new()
                {
                    ID = "id",
                    Title = "title",
                    Type = "type",
                    Url = "url",
                },
            ],
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        ApiEnum<string, Category> expectedCategory = Category.Danger;
        string expectedDescription = "description";
        string expectedLastIndexedDate = "lastIndexedDate";
        string expectedParkCode = "parkCode";
        List<RelatedRoadEvent> expectedRelatedRoadEvents =
        [
            new()
            {
                ID = "id",
                Title = "title",
                Type = "type",
                Url = "url",
            },
        ];
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCategory, deserialized.Category);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedLastIndexedDate, deserialized.LastIndexedDate);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.NotNull(deserialized.RelatedRoadEvents);
        Assert.Equal(expectedRelatedRoadEvents.Count, deserialized.RelatedRoadEvents.Count);
        for (int i = 0; i < expectedRelatedRoadEvents.Count; i++)
        {
            Assert.Equal(expectedRelatedRoadEvents[i], deserialized.RelatedRoadEvents[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "id",
            Category = Category.Danger,
            Description = "description",
            LastIndexedDate = "lastIndexedDate",
            ParkCode = "parkCode",
            RelatedRoadEvents =
            [
                new()
                {
                    ID = "id",
                    Title = "title",
                    Type = "type",
                    Url = "url",
                },
            ],
            Title = "title",
            Url = "url",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Category);
        Assert.False(model.RawData.ContainsKey("category"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.LastIndexedDate);
        Assert.False(model.RawData.ContainsKey("lastIndexedDate"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.RelatedRoadEvents);
        Assert.False(model.RawData.ContainsKey("relatedRoadEvents"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
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
            Category = null,
            Description = null,
            LastIndexedDate = null,
            ParkCode = null,
            RelatedRoadEvents = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Category);
        Assert.False(model.RawData.ContainsKey("category"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.LastIndexedDate);
        Assert.False(model.RawData.ContainsKey("lastIndexedDate"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.RelatedRoadEvents);
        Assert.False(model.RawData.ContainsKey("relatedRoadEvents"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Category = null,
            Description = null,
            LastIndexedDate = null,
            ParkCode = null,
            RelatedRoadEvents = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class CategoryTest : TestBase
{
    [Theory]
    [InlineData(Category.Danger)]
    [InlineData(Category.Caution)]
    [InlineData(Category.Information)]
    [InlineData(Category.ParkClosure)]
    public void Validation_Works(Category rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Category> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Category>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Category.Danger)]
    [InlineData(Category.Caution)]
    [InlineData(Category.Information)]
    [InlineData(Category.ParkClosure)]
    public void SerializationRoundtrip_Works(Category rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Category> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Category>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Category>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Category>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class RelatedRoadEventTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RelatedRoadEvent
        {
            ID = "id",
            Title = "title",
            Type = "type",
            Url = "url",
        };

        string expectedID = "id";
        string expectedTitle = "title";
        string expectedType = "type";
        string expectedUrl = "url";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedRoadEvent
        {
            ID = "id",
            Title = "title",
            Type = "type",
            Url = "url",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedRoadEvent>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedRoadEvent
        {
            ID = "id",
            Title = "title",
            Type = "type",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedRoadEvent>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedTitle = "title";
        string expectedType = "type";
        string expectedUrl = "url";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedRoadEvent
        {
            ID = "id",
            Title = "title",
            Type = "type",
            Url = "url",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RelatedRoadEvent { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new RelatedRoadEvent { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RelatedRoadEvent
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Title = null,
            Type = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RelatedRoadEvent
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Title = null,
            Type = null,
            Url = null,
        };

        model.Validate();
    }
}
