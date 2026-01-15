using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Webcams;

namespace Nps.Tests.Models.Webcams;

public class WebcamListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebcamListResponse
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
        };

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "4";
        string expectedTotal = "4";

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
        var model = new WebcamListResponse
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
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebcamListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebcamListResponse
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
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebcamListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "4";
        string expectedTotal = "4";

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
        var model = new WebcamListResponse
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebcamListResponse { };

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
        var model = new WebcamListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebcamListResponse
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
        var model = new WebcamListResponse
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
        };

        string expectedID = "id";
        string expectedDescription = "description";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<Image> expectedImages =
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
        ];
        bool expectedIsStreaming = false;
        double expectedLatitude = 61.4871482849121;
        double expectedLongitude = -142.87907409668;
        List<RelatedPark> expectedRelatedParks =
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
        ];
        string expectedStatus = "Active";
        string expectedStatusMessage = "";
        List<string> expectedTags = ["string"];
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedIsStreaming, model.IsStreaming);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusMessage, model.StatusMessage);
        Assert.NotNull(model.Tags);
        Assert.Equal(expectedTags.Count, model.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], model.Tags[i]);
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
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
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
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedDescription = "description";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<Image> expectedImages =
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
        ];
        bool expectedIsStreaming = false;
        double expectedLatitude = 61.4871482849121;
        double expectedLongitude = -142.87907409668;
        List<RelatedPark> expectedRelatedParks =
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
        ];
        string expectedStatus = "Active";
        string expectedStatusMessage = "";
        List<string> expectedTags = ["string"];
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedIsStreaming, deserialized.IsStreaming);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusMessage, deserialized.StatusMessage);
        Assert.NotNull(deserialized.Tags);
        Assert.Equal(expectedTags.Count, deserialized.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], deserialized.Tags[i]);
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsStreaming);
        Assert.False(model.RawData.ContainsKey("isStreaming"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.StatusMessage);
        Assert.False(model.RawData.ContainsKey("statusMessage"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
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
            Description = null,
            GeometryPoiID = null,
            Images = null,
            IsStreaming = null,
            Latitude = null,
            Longitude = null,
            RelatedParks = null,
            Status = null,
            StatusMessage = null,
            Tags = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsStreaming);
        Assert.False(model.RawData.ContainsKey("isStreaming"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.StatusMessage);
        Assert.False(model.RawData.ContainsKey("statusMessage"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
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
            Description = null,
            GeometryPoiID = null,
            Images = null,
            IsStreaming = null,
            Latitude = null,
            Longitude = null,
            RelatedParks = null,
            Status = null,
            StatusMessage = null,
            Tags = null,
            Title = null,
            Url = null,
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
        };

        string expectedAltText = "NPS";
        string expectedCaption = "Kennecott Mill and Mt. Blackburn";
        string expectedCredit = "NPS";
        List<Crop> expectedCrops =
        [
            new()
            {
                AspectRatio = 1.78,
                Url =
                    "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
            },
        ];
        string expectedDescription = "";
        string expectedTitle = "Kennecott Mill and Mt. Blackburn";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.NotNull(model.Crops);
        Assert.Equal(expectedCrops.Count, model.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], model.Crops[i]);
        }
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Image
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
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Image>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Image
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
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Image>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedAltText = "NPS";
        string expectedCaption = "Kennecott Mill and Mt. Blackburn";
        string expectedCredit = "NPS";
        List<Crop> expectedCrops =
        [
            new()
            {
                AspectRatio = 1.78,
                Url =
                    "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
            },
        ];
        string expectedDescription = "";
        string expectedTitle = "Kennecott Mill and Mt. Blackburn";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.NotNull(deserialized.Crops);
        Assert.Equal(expectedCrops.Count, deserialized.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], deserialized.Crops[i]);
        }
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Image
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
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
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
            Description = null,
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
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
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
            Description = null,
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
            AspectRatio = 1.78,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
        };

        double expectedAspectRatio = 1.78;
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg";

        Assert.Equal(expectedAspectRatio, model.AspectRatio);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Crop
        {
            AspectRatio = 1.78,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Crop>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Crop
        {
            AspectRatio = 1.78,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Crop>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        double expectedAspectRatio = 1.78;
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg";

        Assert.Equal(expectedAspectRatio, deserialized.AspectRatio);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Crop
        {
            AspectRatio = 1.78,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/55B6E49B-C6F3-38B9-82A9F7F3D7BDC873.jpg",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Crop { };

        Assert.Null(model.AspectRatio);
        Assert.False(model.RawData.ContainsKey("aspectRatio"));
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
            AspectRatio = null,
            Url = null,
        };

        Assert.Null(model.AspectRatio);
        Assert.False(model.RawData.ContainsKey("aspectRatio"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Crop
        {
            // Null should be interpreted as omitted for these properties
            AspectRatio = null,
            Url = null,
        };

        model.Validate();
    }
}

public class RelatedParkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park &amp; Preserve",
            FullName = "Wrangell - St Elias National Park &amp; Preserve",
            Name = "Wrangell - St Elias",
            ParkCode = "wrst",
            States = "AK",
            Url = "https://www.nps.gov/wrst",
        };

        string expectedDesignation = "National Park &amp; Preserve";
        string expectedFullName = "Wrangell - St Elias National Park &amp; Preserve";
        string expectedName = "Wrangell - St Elias";
        string expectedParkCode = "wrst";
        string expectedStates = "AK";
        string expectedUrl = "https://www.nps.gov/wrst";

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
        var model = new RelatedPark
        {
            Designation = "National Park &amp; Preserve",
            FullName = "Wrangell - St Elias National Park &amp; Preserve",
            Name = "Wrangell - St Elias",
            ParkCode = "wrst",
            States = "AK",
            Url = "https://www.nps.gov/wrst",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park &amp; Preserve",
            FullName = "Wrangell - St Elias National Park &amp; Preserve",
            Name = "Wrangell - St Elias",
            ParkCode = "wrst",
            States = "AK",
            Url = "https://www.nps.gov/wrst",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park &amp; Preserve";
        string expectedFullName = "Wrangell - St Elias National Park &amp; Preserve";
        string expectedName = "Wrangell - St Elias";
        string expectedParkCode = "wrst";
        string expectedStates = "AK";
        string expectedUrl = "https://www.nps.gov/wrst";

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
        var model = new RelatedPark
        {
            Designation = "National Park &amp; Preserve",
            FullName = "Wrangell - St Elias National Park &amp; Preserve",
            Name = "Wrangell - St Elias",
            ParkCode = "wrst",
            States = "AK",
            Url = "https://www.nps.gov/wrst",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RelatedPark { };

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
        var model = new RelatedPark { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RelatedPark
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
        var model = new RelatedPark
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
