using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Alerts;

namespace Nps.Tests.Models.Alerts;

public class AlertListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AlertListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<AlertListResponse> expectedData =
        [
            new()
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
        var model = new AlertListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AlertListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AlertListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AlertListPageResponse>(element);
        Assert.NotNull(deserialized);

        List<AlertListResponse> expectedData =
        [
            new()
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
        var model = new AlertListPageResponse
        {
            Data =
            [
                new()
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
        var model = new AlertListPageResponse { };

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
        var model = new AlertListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AlertListPageResponse
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
        var model = new AlertListPageResponse
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
