using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Webcams;

namespace Nps.Tests.Models.Webcams;

public class WebcamListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebcamListPageResponse
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
                            Description = "description",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "NPS",
                                    Caption = "Kennecott Mill and Mt. Blackburn",
                                    Credit = "NPS",
                                    Crops =
                                    [
                                        new()
                                        {
                                            AspectRatio = 1.78,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                        },
                                    ],
                                    Description = "",
                                    Title = "Kennecott Mill and Mt. Blackburn",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                },
                            ],
                            IsStreaming = false,
                            Latitude = 61.4871482849121,
                            Longitude = -142.87907409668,
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park &amp; Preserve",
                                    FullName = "Wrangell - St Elias National Park &amp; Preserve",
                                    Name = "Wrangell - St Elias",
                                    ParkCode = "wrst",
                                    States = "AK",
                                    Url = "https://www.nps.gov/wrst",
                                },
                            ],
                            Status = "Active",
                            StatusMessage = "",
                            Tags = ["string"],
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "4",
                    Total = "4",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<WebcamListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "id",
                        Description = "description",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images =
                        [
                            new()
                            {
                                AltText = "NPS",
                                Caption = "Kennecott Mill and Mt. Blackburn",
                                Credit = "NPS",
                                Crops =
                                [
                                    new()
                                    {
                                        AspectRatio = 1.78,
                                        Url =
                                            "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                    },
                                ],
                                Description = "",
                                Title = "Kennecott Mill and Mt. Blackburn",
                                Url =
                                    "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                            },
                        ],
                        IsStreaming = false,
                        Latitude = 61.4871482849121,
                        Longitude = -142.87907409668,
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park &amp; Preserve",
                                FullName = "Wrangell - St Elias National Park &amp; Preserve",
                                Name = "Wrangell - St Elias",
                                ParkCode = "wrst",
                                States = "AK",
                                Url = "https://www.nps.gov/wrst",
                            },
                        ],
                        Status = "Active",
                        StatusMessage = "",
                        Tags = ["string"],
                        Title = "title",
                        Url = "url",
                    },
                ],
                Limit = "50",
                Start = "4",
                Total = "4",
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
        var model = new WebcamListPageResponse
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
                            Description = "description",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "NPS",
                                    Caption = "Kennecott Mill and Mt. Blackburn",
                                    Credit = "NPS",
                                    Crops =
                                    [
                                        new()
                                        {
                                            AspectRatio = 1.78,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                        },
                                    ],
                                    Description = "",
                                    Title = "Kennecott Mill and Mt. Blackburn",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                },
                            ],
                            IsStreaming = false,
                            Latitude = 61.4871482849121,
                            Longitude = -142.87907409668,
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park &amp; Preserve",
                                    FullName = "Wrangell - St Elias National Park &amp; Preserve",
                                    Name = "Wrangell - St Elias",
                                    ParkCode = "wrst",
                                    States = "AK",
                                    Url = "https://www.nps.gov/wrst",
                                },
                            ],
                            Status = "Active",
                            StatusMessage = "",
                            Tags = ["string"],
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "4",
                    Total = "4",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebcamListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebcamListPageResponse
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
                            Description = "description",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "NPS",
                                    Caption = "Kennecott Mill and Mt. Blackburn",
                                    Credit = "NPS",
                                    Crops =
                                    [
                                        new()
                                        {
                                            AspectRatio = 1.78,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                        },
                                    ],
                                    Description = "",
                                    Title = "Kennecott Mill and Mt. Blackburn",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                },
                            ],
                            IsStreaming = false,
                            Latitude = 61.4871482849121,
                            Longitude = -142.87907409668,
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park &amp; Preserve",
                                    FullName = "Wrangell - St Elias National Park &amp; Preserve",
                                    Name = "Wrangell - St Elias",
                                    ParkCode = "wrst",
                                    States = "AK",
                                    Url = "https://www.nps.gov/wrst",
                                },
                            ],
                            Status = "Active",
                            StatusMessage = "",
                            Tags = ["string"],
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "4",
                    Total = "4",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebcamListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<WebcamListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "id",
                        Description = "description",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images =
                        [
                            new()
                            {
                                AltText = "NPS",
                                Caption = "Kennecott Mill and Mt. Blackburn",
                                Credit = "NPS",
                                Crops =
                                [
                                    new()
                                    {
                                        AspectRatio = 1.78,
                                        Url =
                                            "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                    },
                                ],
                                Description = "",
                                Title = "Kennecott Mill and Mt. Blackburn",
                                Url =
                                    "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                            },
                        ],
                        IsStreaming = false,
                        Latitude = 61.4871482849121,
                        Longitude = -142.87907409668,
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park &amp; Preserve",
                                FullName = "Wrangell - St Elias National Park &amp; Preserve",
                                Name = "Wrangell - St Elias",
                                ParkCode = "wrst",
                                States = "AK",
                                Url = "https://www.nps.gov/wrst",
                            },
                        ],
                        Status = "Active",
                        StatusMessage = "",
                        Tags = ["string"],
                        Title = "title",
                        Url = "url",
                    },
                ],
                Limit = "50",
                Start = "4",
                Total = "4",
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
        var model = new WebcamListPageResponse
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
                            Description = "description",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "NPS",
                                    Caption = "Kennecott Mill and Mt. Blackburn",
                                    Credit = "NPS",
                                    Crops =
                                    [
                                        new()
                                        {
                                            AspectRatio = 1.78,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                        },
                                    ],
                                    Description = "",
                                    Title = "Kennecott Mill and Mt. Blackburn",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
                                },
                            ],
                            IsStreaming = false,
                            Latitude = 61.4871482849121,
                            Longitude = -142.87907409668,
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park &amp; Preserve",
                                    FullName = "Wrangell - St Elias National Park &amp; Preserve",
                                    Name = "Wrangell - St Elias",
                                    ParkCode = "wrst",
                                    States = "AK",
                                    Url = "https://www.nps.gov/wrst",
                                },
                            ],
                            Status = "Active",
                            StatusMessage = "",
                            Tags = ["string"],
                            Title = "title",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "4",
                    Total = "4",
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
        var model = new WebcamListPageResponse { };

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
        var model = new WebcamListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebcamListPageResponse
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
        var model = new WebcamListPageResponse
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
