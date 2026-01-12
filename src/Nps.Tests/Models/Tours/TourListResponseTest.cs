using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Tours;

namespace Nps.Tests.Models.Tours;

public class TourListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TourListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new TourListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TourListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TourListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TourListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new TourListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TourListResponse { };

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
        var model = new TourListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TourListResponse
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
        var model = new TourListResponse
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
        };

        List<DataData> expectedDataValue =
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
                Topics = [new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" }],
                Type = "Standard",
            },
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        List<DataData> expectedDataValue =
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
                Topics = [new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" }],
                Type = "Standard",
            },
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
            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
            Activities = [new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" }],
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
                    Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
            Topics = [new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" }],
            Type = "Standard",
        };

        string expectedID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32";
        List<Activity> expectedActivities =
        [
            new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" },
        ];
        string expectedDescription =
            "A tour that exists purely to ensure tours show up in the API successfully.";
        string expectedDurationMax = "120";
        string expectedDurationMin = "60";
        string expectedDurationUnit = "m";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "a brown bear",
                Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
        ];
        Park expectedPark = new()
        {
            Designation = "National Park & Preserve",
            FullName = "Denali National Park & Preserve",
            Name = "Denali",
            ParkCode = "dena",
            States = "AK",
            Url = "https://www.nps.gov/dena/index.htm",
        };
        double expectedRelevanceScore = 1;
        List<Stop> expectedStops =
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
        ];
        List<JsonElement> expectedTags = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedTitle = "API Test";
        List<Topic> expectedTopics =
        [
            new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" },
        ];
        string expectedType = "Standard";

        Assert.Equal(expectedID, model.ID);
        Assert.NotNull(model.Activities);
        Assert.Equal(expectedActivities.Count, model.Activities.Count);
        for (int i = 0; i < expectedActivities.Count; i++)
        {
            Assert.Equal(expectedActivities[i], model.Activities[i]);
        }
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDurationMax, model.DurationMax);
        Assert.Equal(expectedDurationMin, model.DurationMin);
        Assert.Equal(expectedDurationUnit, model.DurationUnit);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedPark, model.Park);
        Assert.Equal(expectedRelevanceScore, model.RelevanceScore);
        Assert.NotNull(model.Stops);
        Assert.Equal(expectedStops.Count, model.Stops.Count);
        for (int i = 0; i < expectedStops.Count; i++)
        {
            Assert.Equal(expectedStops[i], model.Stops[i]);
        }
        Assert.NotNull(model.Tags);
        Assert.Equal(expectedTags.Count, model.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedTags[i], model.Tags[i]));
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.NotNull(model.Topics);
        Assert.Equal(expectedTopics.Count, model.Topics.Count);
        for (int i = 0; i < expectedTopics.Count; i++)
        {
            Assert.Equal(expectedTopics[i], model.Topics[i]);
        }
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataData
        {
            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
            Activities = [new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" }],
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
                    Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
            Topics = [new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" }],
            Type = "Standard",
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
            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
            Activities = [new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" }],
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
                    Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
            Topics = [new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" }],
            Type = "Standard",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32";
        List<Activity> expectedActivities =
        [
            new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" },
        ];
        string expectedDescription =
            "A tour that exists purely to ensure tours show up in the API successfully.";
        string expectedDurationMax = "120";
        string expectedDurationMin = "60";
        string expectedDurationUnit = "m";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "a brown bear",
                Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
        ];
        Park expectedPark = new()
        {
            Designation = "National Park & Preserve",
            FullName = "Denali National Park & Preserve",
            Name = "Denali",
            ParkCode = "dena",
            States = "AK",
            Url = "https://www.nps.gov/dena/index.htm",
        };
        double expectedRelevanceScore = 1;
        List<Stop> expectedStops =
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
        ];
        List<JsonElement> expectedTags = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedTitle = "API Test";
        List<Topic> expectedTopics =
        [
            new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" },
        ];
        string expectedType = "Standard";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.NotNull(deserialized.Activities);
        Assert.Equal(expectedActivities.Count, deserialized.Activities.Count);
        for (int i = 0; i < expectedActivities.Count; i++)
        {
            Assert.Equal(expectedActivities[i], deserialized.Activities[i]);
        }
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDurationMax, deserialized.DurationMax);
        Assert.Equal(expectedDurationMin, deserialized.DurationMin);
        Assert.Equal(expectedDurationUnit, deserialized.DurationUnit);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedPark, deserialized.Park);
        Assert.Equal(expectedRelevanceScore, deserialized.RelevanceScore);
        Assert.NotNull(deserialized.Stops);
        Assert.Equal(expectedStops.Count, deserialized.Stops.Count);
        for (int i = 0; i < expectedStops.Count; i++)
        {
            Assert.Equal(expectedStops[i], deserialized.Stops[i]);
        }
        Assert.NotNull(deserialized.Tags);
        Assert.Equal(expectedTags.Count, deserialized.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedTags[i], deserialized.Tags[i]));
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.NotNull(deserialized.Topics);
        Assert.Equal(expectedTopics.Count, deserialized.Topics.Count);
        for (int i = 0; i < expectedTopics.Count; i++)
        {
            Assert.Equal(expectedTopics[i], deserialized.Topics[i]);
        }
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataData
        {
            ID = "6880801D-EDC4-00AF-FBD5EAFFB3B7FD32",
            Activities = [new() { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" }],
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
                    Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
            Topics = [new() { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" }],
            Type = "Standard",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Activities);
        Assert.False(model.RawData.ContainsKey("activities"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DurationMax);
        Assert.False(model.RawData.ContainsKey("durationMax"));
        Assert.Null(model.DurationMin);
        Assert.False(model.RawData.ContainsKey("durationMin"));
        Assert.Null(model.DurationUnit);
        Assert.False(model.RawData.ContainsKey("durationUnit"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Park);
        Assert.False(model.RawData.ContainsKey("park"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.Stops);
        Assert.False(model.RawData.ContainsKey("stops"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Topics);
        Assert.False(model.RawData.ContainsKey("topics"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
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
            Activities = null,
            Description = null,
            DurationMax = null,
            DurationMin = null,
            DurationUnit = null,
            Images = null,
            Park = null,
            RelevanceScore = null,
            Stops = null,
            Tags = null,
            Title = null,
            Topics = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Activities);
        Assert.False(model.RawData.ContainsKey("activities"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DurationMax);
        Assert.False(model.RawData.ContainsKey("durationMax"));
        Assert.Null(model.DurationMin);
        Assert.False(model.RawData.ContainsKey("durationMin"));
        Assert.Null(model.DurationUnit);
        Assert.False(model.RawData.ContainsKey("durationUnit"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Park);
        Assert.False(model.RawData.ContainsKey("park"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.Stops);
        Assert.False(model.RawData.ContainsKey("stops"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Topics);
        Assert.False(model.RawData.ContainsKey("topics"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Activities = null,
            Description = null,
            DurationMax = null,
            DurationMin = null,
            DurationUnit = null,
            Images = null,
            Park = null,
            RelevanceScore = null,
            Stops = null,
            Tags = null,
            Title = null,
            Topics = null,
            Type = null,
        };

        model.Validate();
    }
}

public class ActivityTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Activity { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" };

        string expectedID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA";
        string expectedName = "Hiking";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Activity { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Activity>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Activity { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Activity>(element);
        Assert.NotNull(deserialized);

        string expectedID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA";
        string expectedName = "Hiking";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Activity { ID = "BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA", Name = "Hiking" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Activity { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Activity { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Activity
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
        var model = new Activity
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        model.Validate();
    }
}

public class ImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Image
        {
            AltText = "a brown bear",
            Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
        };

        string expectedAltText = "a brown bear";
        string expectedCaption =
            "Grizzlies can sometimes be seen in the Savage River area of Denali";
        string expectedCredit = "NPS Photo / Emily Mesner";
        List<Crop> expectedCrops =
        [
            new()
            {
                Aspectratio = "1.00",
                Url =
                    "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
            },
        ];
        string expectedTitle = "Title!";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.NotNull(model.Crops);
        Assert.Equal(expectedCrops.Count, model.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], model.Crops[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Image
        {
            AltText = "a brown bear",
            Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Image
        {
            AltText = "a brown bear",
            Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "a brown bear";
        string expectedCaption =
            "Grizzlies can sometimes be seen in the Savage River area of Denali";
        string expectedCredit = "NPS Photo / Emily Mesner";
        List<Crop> expectedCrops =
        [
            new()
            {
                Aspectratio = "1.00",
                Url =
                    "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
            },
        ];
        string expectedTitle = "Title!";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/tours/6B230275-0DCB-8052-19039607F9A25672.jpg";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.NotNull(deserialized.Crops);
        Assert.Equal(expectedCrops.Count, deserialized.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], deserialized.Crops[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Image
        {
            AltText = "a brown bear",
            Caption = "Grizzlies can sometimes be seen in the Savage River area of Denali",
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Image { };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Crops);
        Assert.False(model.RawData.ContainsKey("crops"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Image { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Image
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
            Crops = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Crops);
        Assert.False(model.RawData.ContainsKey("crops"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Image
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
            Crops = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class CropTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Crop
        {
            Aspectratio = "1.00",
            Url =
                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
        };

        string expectedAspectratio = "1.00";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg";

        Assert.Equal(expectedAspectratio, model.Aspectratio);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Crop
        {
            Aspectratio = "1.00",
            Url =
                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Crop>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Crop
        {
            Aspectratio = "1.00",
            Url =
                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Crop>(element);
        Assert.NotNull(deserialized);

        string expectedAspectratio = "1.00";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg";

        Assert.Equal(expectedAspectratio, deserialized.Aspectratio);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Crop
        {
            Aspectratio = "1.00",
            Url =
                "https://www.nps.gov/common/uploads/tours/primary/6B230275-0DCB-8052-19039607F9A25672.jpg",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Crop { };

        Assert.Null(model.Aspectratio);
        Assert.False(model.RawData.ContainsKey("aspectratio"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Crop { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Crop
        {
            // Null should be interpreted as omitted for these properties
            Aspectratio = null,
            Url = null,
        };

        Assert.Null(model.Aspectratio);
        Assert.False(model.RawData.ContainsKey("aspectratio"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Crop
        {
            // Null should be interpreted as omitted for these properties
            Aspectratio = null,
            Url = null,
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
            FullName = "Denali National Park & Preserve",
            Name = "Denali",
            ParkCode = "dena",
            States = "AK",
            Url = "https://www.nps.gov/dena/index.htm",
        };

        string expectedDesignation = "National Park & Preserve";
        string expectedFullName = "Denali National Park & Preserve";
        string expectedName = "Denali";
        string expectedParkCode = "dena";
        string expectedStates = "AK";
        string expectedUrl = "https://www.nps.gov/dena/index.htm";

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
            FullName = "Denali National Park & Preserve",
            Name = "Denali",
            ParkCode = "dena",
            States = "AK",
            Url = "https://www.nps.gov/dena/index.htm",
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
            FullName = "Denali National Park & Preserve",
            Name = "Denali",
            ParkCode = "dena",
            States = "AK",
            Url = "https://www.nps.gov/dena/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Park>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park & Preserve";
        string expectedFullName = "Denali National Park & Preserve";
        string expectedName = "Denali";
        string expectedParkCode = "dena";
        string expectedStates = "AK";
        string expectedUrl = "https://www.nps.gov/dena/index.htm";

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
            FullName = "Denali National Park & Preserve",
            Name = "Denali",
            ParkCode = "dena",
            States = "AK",
            Url = "https://www.nps.gov/dena/index.htm",
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

public class StopTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Stop
        {
            ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
            AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
            AssetName = "Savage River",
            AssetType = "Place",
            DirectionsToNextStop = "directionsToNextStop",
            Ordinal = "1",
            Significance = "significance",
        };

        string expectedID = "6886BB60-C11B-1A87-589FEABEE387E9E4";
        string expectedAssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76";
        string expectedAssetName = "Savage River";
        string expectedAssetType = "Place";
        string expectedDirectionsToNextStop = "directionsToNextStop";
        string expectedOrdinal = "1";
        string expectedSignificance = "significance";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAssetID, model.AssetID);
        Assert.Equal(expectedAssetName, model.AssetName);
        Assert.Equal(expectedAssetType, model.AssetType);
        Assert.Equal(expectedDirectionsToNextStop, model.DirectionsToNextStop);
        Assert.Equal(expectedOrdinal, model.Ordinal);
        Assert.Equal(expectedSignificance, model.Significance);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Stop
        {
            ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
            AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
            AssetName = "Savage River",
            AssetType = "Place",
            DirectionsToNextStop = "directionsToNextStop",
            Ordinal = "1",
            Significance = "significance",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Stop>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Stop
        {
            ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
            AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
            AssetName = "Savage River",
            AssetType = "Place",
            DirectionsToNextStop = "directionsToNextStop",
            Ordinal = "1",
            Significance = "significance",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Stop>(element);
        Assert.NotNull(deserialized);

        string expectedID = "6886BB60-C11B-1A87-589FEABEE387E9E4";
        string expectedAssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76";
        string expectedAssetName = "Savage River";
        string expectedAssetType = "Place";
        string expectedDirectionsToNextStop = "directionsToNextStop";
        string expectedOrdinal = "1";
        string expectedSignificance = "significance";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAssetID, deserialized.AssetID);
        Assert.Equal(expectedAssetName, deserialized.AssetName);
        Assert.Equal(expectedAssetType, deserialized.AssetType);
        Assert.Equal(expectedDirectionsToNextStop, deserialized.DirectionsToNextStop);
        Assert.Equal(expectedOrdinal, deserialized.Ordinal);
        Assert.Equal(expectedSignificance, deserialized.Significance);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Stop
        {
            ID = "6886BB60-C11B-1A87-589FEABEE387E9E4",
            AssetID = "CD74CF08-6C88-418B-A2C2-F7B957975C76",
            AssetName = "Savage River",
            AssetType = "Place",
            DirectionsToNextStop = "directionsToNextStop",
            Ordinal = "1",
            Significance = "significance",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Stop { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AssetID);
        Assert.False(model.RawData.ContainsKey("assetId"));
        Assert.Null(model.AssetName);
        Assert.False(model.RawData.ContainsKey("assetName"));
        Assert.Null(model.AssetType);
        Assert.False(model.RawData.ContainsKey("assetType"));
        Assert.Null(model.DirectionsToNextStop);
        Assert.False(model.RawData.ContainsKey("directionsToNextStop"));
        Assert.Null(model.Ordinal);
        Assert.False(model.RawData.ContainsKey("ordinal"));
        Assert.Null(model.Significance);
        Assert.False(model.RawData.ContainsKey("significance"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Stop { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Stop
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            AssetID = null,
            AssetName = null,
            AssetType = null,
            DirectionsToNextStop = null,
            Ordinal = null,
            Significance = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AssetID);
        Assert.False(model.RawData.ContainsKey("assetId"));
        Assert.Null(model.AssetName);
        Assert.False(model.RawData.ContainsKey("assetName"));
        Assert.Null(model.AssetType);
        Assert.False(model.RawData.ContainsKey("assetType"));
        Assert.Null(model.DirectionsToNextStop);
        Assert.False(model.RawData.ContainsKey("directionsToNextStop"));
        Assert.Null(model.Ordinal);
        Assert.False(model.RawData.ContainsKey("ordinal"));
        Assert.Null(model.Significance);
        Assert.False(model.RawData.ContainsKey("significance"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Stop
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            AssetID = null,
            AssetName = null,
            AssetType = null,
            DirectionsToNextStop = null,
            Ordinal = null,
            Significance = null,
        };

        model.Validate();
    }
}

public class TopicTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Topic { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" };

        string expectedID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E";
        string expectedName = "Arctic";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Topic { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Topic>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Topic { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Topic>(element);
        Assert.NotNull(deserialized);

        string expectedID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E";
        string expectedName = "Arctic";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Topic { ID = "77B7EFDF-1A74-409C-8BA2-324EC919DB0E", Name = "Arctic" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Topic { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Topic { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Topic
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
        var model = new Topic
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        model.Validate();
    }
}
