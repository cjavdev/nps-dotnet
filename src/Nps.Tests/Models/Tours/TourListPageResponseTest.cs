using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Tours;

namespace Nps.Tests.Models.Tours;

public class TourListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TourListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
                            Activities =
                            [
                                new()
                                {
                                    ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA",
                                    Name = "Hiking",
                                },
                            ],
                            Description =
                                "A tour that exists purely to ensure tours show up in the API successfully.",
                            DurationMax = "120",
                            DurationMin = "60",
                            DurationUnit = "m",
                            Images =
                            [
                                new()
                                {
                                    AltText = "a brown bear",
                                    Caption =
                                        "Grizzlies can sometimes be seen in the Savage River area of Denali",
                                    Credit = "NPS Photo / Emily Mesner",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = "1.00",
                                            Url =
                                                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                        },
                                    ],
                                    Title = "Title!",
                                    Url =
                                        "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                },
                            ],
                            Park = new()
                            {
                                Designation = "National Park & Preserve",
                                FullName = "Denali National Park & Preserve",
                                Name = "Denali",
                                ParkCode = "dena",
                                States = "AK",
                                Url = "https://www.nps.gov/dena/index.htm",
                            },
                            RelevanceScore = 1,
                            Stops =
                            [
                                new()
                                {
                                    ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
                                    AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
                                    AssetName = "Savage River",
                                    AssetType = "Place",
                                    DirectionsToNextStop = "directionsToNextStop",
                                    Ordinal = "1",
                                    Significance = "significance",
                                },
                            ],
                            Tags = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            Title = "API Test",
                            Topics =
                            [
                                new()
                                {
                                    ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E",
                                    Name = "Arctic",
                                },
                            ],
                            Type = "Standard",
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

        List<TourListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
                        Activities =
                        [
                            new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" },
                        ],
                        Description =
                            "A tour that exists purely to ensure tours show up in the API successfully.",
                        DurationMax = "120",
                        DurationMin = "60",
                        DurationUnit = "m",
                        Images =
                        [
                            new()
                            {
                                AltText = "a brown bear",
                                Caption =
                                    "Grizzlies can sometimes be seen in the Savage River area of Denali",
                                Credit = "NPS Photo / Emily Mesner",
                                Crops =
                                [
                                    new()
                                    {
                                        Aspectratio = "1.00",
                                        Url =
                                            "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                    },
                                ],
                                Title = "Title!",
                                Url =
                                    "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg",
                            },
                        ],
                        Park = new()
                        {
                            Designation = "National Park & Preserve",
                            FullName = "Denali National Park & Preserve",
                            Name = "Denali",
                            ParkCode = "dena",
                            States = "AK",
                            Url = "https://www.nps.gov/dena/index.htm",
                        },
                        RelevanceScore = 1,
                        Stops =
                        [
                            new()
                            {
                                ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
                                AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
                                AssetName = "Savage River",
                                AssetType = "Place",
                                DirectionsToNextStop = "directionsToNextStop",
                                Ordinal = "1",
                                Significance = "significance",
                            },
                        ],
                        Tags = [JsonSerializer.Deserialize<JsonElement>("{}")],
                        Title = "API Test",
                        Topics =
                        [
                            new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" },
                        ],
                        Type = "Standard",
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
        var model = new TourListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
                            Activities =
                            [
                                new()
                                {
                                    ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA",
                                    Name = "Hiking",
                                },
                            ],
                            Description =
                                "A tour that exists purely to ensure tours show up in the API successfully.",
                            DurationMax = "120",
                            DurationMin = "60",
                            DurationUnit = "m",
                            Images =
                            [
                                new()
                                {
                                    AltText = "a brown bear",
                                    Caption =
                                        "Grizzlies can sometimes be seen in the Savage River area of Denali",
                                    Credit = "NPS Photo / Emily Mesner",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = "1.00",
                                            Url =
                                                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                        },
                                    ],
                                    Title = "Title!",
                                    Url =
                                        "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                },
                            ],
                            Park = new()
                            {
                                Designation = "National Park & Preserve",
                                FullName = "Denali National Park & Preserve",
                                Name = "Denali",
                                ParkCode = "dena",
                                States = "AK",
                                Url = "https://www.nps.gov/dena/index.htm",
                            },
                            RelevanceScore = 1,
                            Stops =
                            [
                                new()
                                {
                                    ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
                                    AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
                                    AssetName = "Savage River",
                                    AssetType = "Place",
                                    DirectionsToNextStop = "directionsToNextStop",
                                    Ordinal = "1",
                                    Significance = "significance",
                                },
                            ],
                            Tags = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            Title = "API Test",
                            Topics =
                            [
                                new()
                                {
                                    ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E",
                                    Name = "Arctic",
                                },
                            ],
                            Type = "Standard",
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

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TourListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TourListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
                            Activities =
                            [
                                new()
                                {
                                    ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA",
                                    Name = "Hiking",
                                },
                            ],
                            Description =
                                "A tour that exists purely to ensure tours show up in the API successfully.",
                            DurationMax = "120",
                            DurationMin = "60",
                            DurationUnit = "m",
                            Images =
                            [
                                new()
                                {
                                    AltText = "a brown bear",
                                    Caption =
                                        "Grizzlies can sometimes be seen in the Savage River area of Denali",
                                    Credit = "NPS Photo / Emily Mesner",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = "1.00",
                                            Url =
                                                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                        },
                                    ],
                                    Title = "Title!",
                                    Url =
                                        "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                },
                            ],
                            Park = new()
                            {
                                Designation = "National Park & Preserve",
                                FullName = "Denali National Park & Preserve",
                                Name = "Denali",
                                ParkCode = "dena",
                                States = "AK",
                                Url = "https://www.nps.gov/dena/index.htm",
                            },
                            RelevanceScore = 1,
                            Stops =
                            [
                                new()
                                {
                                    ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
                                    AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
                                    AssetName = "Savage River",
                                    AssetType = "Place",
                                    DirectionsToNextStop = "directionsToNextStop",
                                    Ordinal = "1",
                                    Significance = "significance",
                                },
                            ],
                            Tags = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            Title = "API Test",
                            Topics =
                            [
                                new()
                                {
                                    ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E",
                                    Name = "Arctic",
                                },
                            ],
                            Type = "Standard",
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

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TourListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<TourListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
                        Activities =
                        [
                            new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" },
                        ],
                        Description =
                            "A tour that exists purely to ensure tours show up in the API successfully.",
                        DurationMax = "120",
                        DurationMin = "60",
                        DurationUnit = "m",
                        Images =
                        [
                            new()
                            {
                                AltText = "a brown bear",
                                Caption =
                                    "Grizzlies can sometimes be seen in the Savage River area of Denali",
                                Credit = "NPS Photo / Emily Mesner",
                                Crops =
                                [
                                    new()
                                    {
                                        Aspectratio = "1.00",
                                        Url =
                                            "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                    },
                                ],
                                Title = "Title!",
                                Url =
                                    "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg",
                            },
                        ],
                        Park = new()
                        {
                            Designation = "National Park & Preserve",
                            FullName = "Denali National Park & Preserve",
                            Name = "Denali",
                            ParkCode = "dena",
                            States = "AK",
                            Url = "https://www.nps.gov/dena/index.htm",
                        },
                        RelevanceScore = 1,
                        Stops =
                        [
                            new()
                            {
                                ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
                                AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
                                AssetName = "Savage River",
                                AssetType = "Place",
                                DirectionsToNextStop = "directionsToNextStop",
                                Ordinal = "1",
                                Significance = "significance",
                            },
                        ],
                        Tags = [JsonSerializer.Deserialize<JsonElement>("{}")],
                        Title = "API Test",
                        Topics =
                        [
                            new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" },
                        ],
                        Type = "Standard",
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
        var model = new TourListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
                            Activities =
                            [
                                new()
                                {
                                    ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA",
                                    Name = "Hiking",
                                },
                            ],
                            Description =
                                "A tour that exists purely to ensure tours show up in the API successfully.",
                            DurationMax = "120",
                            DurationMin = "60",
                            DurationUnit = "m",
                            Images =
                            [
                                new()
                                {
                                    AltText = "a brown bear",
                                    Caption =
                                        "Grizzlies can sometimes be seen in the Savage River area of Denali",
                                    Credit = "NPS Photo / Emily Mesner",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = "1.00",
                                            Url =
                                                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                        },
                                    ],
                                    Title = "Title!",
                                    Url =
                                        "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg",
                                },
                            ],
                            Park = new()
                            {
                                Designation = "National Park & Preserve",
                                FullName = "Denali National Park & Preserve",
                                Name = "Denali",
                                ParkCode = "dena",
                                States = "AK",
                                Url = "https://www.nps.gov/dena/index.htm",
                            },
                            RelevanceScore = 1,
                            Stops =
                            [
                                new()
                                {
                                    ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
                                    AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
                                    AssetName = "Savage River",
                                    AssetType = "Place",
                                    DirectionsToNextStop = "directionsToNextStop",
                                    Ordinal = "1",
                                    Significance = "significance",
                                },
                            ],
                            Tags = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            Title = "API Test",
                            Topics =
                            [
                                new()
                                {
                                    ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E",
                                    Name = "Arctic",
                                },
                            ],
                            Type = "Standard",
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
        var model = new TourListPageResponse { };

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
        var model = new TourListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TourListPageResponse
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
        var model = new TourListPageResponse
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
