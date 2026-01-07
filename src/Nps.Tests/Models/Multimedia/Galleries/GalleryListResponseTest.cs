using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Multimedia.Galleries;

namespace Nps.Tests.Models.Multimedia.Galleries;

public class GalleryListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new GalleryListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
                    AssetCount = "assetCount",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "unknown",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Description = "",
                    Images =
                    [
                        new()
                        {
                            AltText = "1st place: 6th – 8th grade category",
                            Description = "1st place: 6th – 8th grade category",
                            Title = "1st place: 6th – 8th grade category",
                            Url =
                                "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            FullName = "Glacier National Park",
                            Name = "Glacier",
                            ParkCode = "glac",
                            States = "MT",
                            Url = "https://www.nps.gov/glac/index.htm",
                        },
                    ],
                    Tags = ["bark ranger"],
                    Title = "2008 Postcard Contest Winners",
                    Url =
                        "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "29",
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
                AssetCount = "assetCount",
                ConstraintsInfo = new()
                {
                    Constraint = "Public domain",
                    GrantingRights = "unknown",
                },
                Copyright =
                    "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                Description = "",
                Images =
                [
                    new()
                    {
                        AltText = "1st place: 6th – 8th grade category",
                        Description = "1st place: 6th – 8th grade category",
                        Title = "1st place: 6th – 8th grade category",
                        Url =
                            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                    },
                ],
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National Park",
                        FullName = "Glacier National Park",
                        Name = "Glacier",
                        ParkCode = "glac",
                        States = "MT",
                        Url = "https://www.nps.gov/glac/index.htm",
                    },
                ],
                Tags = ["bark ranger"],
                Title = "2008 Postcard Contest Winners",
                Url =
                    "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "29";

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
        var model = new GalleryListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
                    AssetCount = "assetCount",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "unknown",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Description = "",
                    Images =
                    [
                        new()
                        {
                            AltText = "1st place: 6th – 8th grade category",
                            Description = "1st place: 6th – 8th grade category",
                            Title = "1st place: 6th – 8th grade category",
                            Url =
                                "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            FullName = "Glacier National Park",
                            Name = "Glacier",
                            ParkCode = "glac",
                            States = "MT",
                            Url = "https://www.nps.gov/glac/index.htm",
                        },
                    ],
                    Tags = ["bark ranger"],
                    Title = "2008 Postcard Contest Winners",
                    Url =
                        "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "29",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<GalleryListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new GalleryListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
                    AssetCount = "assetCount",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "unknown",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Description = "",
                    Images =
                    [
                        new()
                        {
                            AltText = "1st place: 6th – 8th grade category",
                            Description = "1st place: 6th – 8th grade category",
                            Title = "1st place: 6th – 8th grade category",
                            Url =
                                "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            FullName = "Glacier National Park",
                            Name = "Glacier",
                            ParkCode = "glac",
                            States = "MT",
                            Url = "https://www.nps.gov/glac/index.htm",
                        },
                    ],
                    Tags = ["bark ranger"],
                    Title = "2008 Postcard Contest Winners",
                    Url =
                        "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "29",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<GalleryListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
                AssetCount = "assetCount",
                ConstraintsInfo = new()
                {
                    Constraint = "Public domain",
                    GrantingRights = "unknown",
                },
                Copyright =
                    "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                Description = "",
                Images =
                [
                    new()
                    {
                        AltText = "1st place: 6th – 8th grade category",
                        Description = "1st place: 6th – 8th grade category",
                        Title = "1st place: 6th – 8th grade category",
                        Url =
                            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                    },
                ],
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National Park",
                        FullName = "Glacier National Park",
                        Name = "Glacier",
                        ParkCode = "glac",
                        States = "MT",
                        Url = "https://www.nps.gov/glac/index.htm",
                    },
                ],
                Tags = ["bark ranger"],
                Title = "2008 Postcard Contest Winners",
                Url =
                    "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "29";

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
        var model = new GalleryListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
                    AssetCount = "assetCount",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "unknown",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Description = "",
                    Images =
                    [
                        new()
                        {
                            AltText = "1st place: 6th – 8th grade category",
                            Description = "1st place: 6th – 8th grade category",
                            Title = "1st place: 6th – 8th grade category",
                            Url =
                                "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            FullName = "Glacier National Park",
                            Name = "Glacier",
                            ParkCode = "glac",
                            States = "MT",
                            Url = "https://www.nps.gov/glac/index.htm",
                        },
                    ],
                    Tags = ["bark ranger"],
                    Title = "2008 Postcard Contest Winners",
                    Url =
                        "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "29",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new GalleryListResponse { };

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
        var model = new GalleryListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new GalleryListResponse
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
        var model = new GalleryListResponse
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
            ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
            AssetCount = "assetCount",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "unknown" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Description = "",
            Images =
            [
                new()
                {
                    AltText = "1st place: 6th – 8th grade category",
                    Description = "1st place: 6th – 8th grade category",
                    Title = "1st place: 6th – 8th grade category",
                    Url =
                        "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    FullName = "Glacier National Park",
                    Name = "Glacier",
                    ParkCode = "glac",
                    States = "MT",
                    Url = "https://www.nps.gov/glac/index.htm",
                },
            ],
            Tags = ["bark ranger"],
            Title = "2008 Postcard Contest Winners",
            Url =
                "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
        };

        string expectedID = "F2D0A8A2-155D-451F-67A9-A67E74025286";
        string expectedAssetCount = "assetCount";
        ConstraintsInfo expectedConstraintsInfo = new()
        {
            Constraint = "Public domain",
            GrantingRights = "unknown",
        };
        string expectedCopyright =
            "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.";
        string expectedDescription = "";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "1st place: 6th – 8th grade category",
                Description = "1st place: 6th – 8th grade category",
                Title = "1st place: 6th – 8th grade category",
                Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National Park",
                FullName = "Glacier National Park",
                Name = "Glacier",
                ParkCode = "glac",
                States = "MT",
                Url = "https://www.nps.gov/glac/index.htm",
            },
        ];
        List<string> expectedTags = ["bark ranger"];
        string expectedTitle = "2008 Postcard Contest Winners";
        string expectedUrl =
            "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAssetCount, model.AssetCount);
        Assert.Equal(expectedConstraintsInfo, model.ConstraintsInfo);
        Assert.Equal(expectedCopyright, model.Copyright);
        Assert.Equal(expectedDescription, model.Description);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
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
            ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
            AssetCount = "assetCount",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "unknown" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Description = "",
            Images =
            [
                new()
                {
                    AltText = "1st place: 6th – 8th grade category",
                    Description = "1st place: 6th – 8th grade category",
                    Title = "1st place: 6th – 8th grade category",
                    Url =
                        "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    FullName = "Glacier National Park",
                    Name = "Glacier",
                    ParkCode = "glac",
                    States = "MT",
                    Url = "https://www.nps.gov/glac/index.htm",
                },
            ],
            Tags = ["bark ranger"],
            Title = "2008 Postcard Contest Winners",
            Url =
                "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
            ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
            AssetCount = "assetCount",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "unknown" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Description = "",
            Images =
            [
                new()
                {
                    AltText = "1st place: 6th – 8th grade category",
                    Description = "1st place: 6th – 8th grade category",
                    Title = "1st place: 6th – 8th grade category",
                    Url =
                        "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    FullName = "Glacier National Park",
                    Name = "Glacier",
                    ParkCode = "glac",
                    States = "MT",
                    Url = "https://www.nps.gov/glac/index.htm",
                },
            ],
            Tags = ["bark ranger"],
            Title = "2008 Postcard Contest Winners",
            Url =
                "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        string expectedID = "F2D0A8A2-155D-451F-67A9-A67E74025286";
        string expectedAssetCount = "assetCount";
        ConstraintsInfo expectedConstraintsInfo = new()
        {
            Constraint = "Public domain",
            GrantingRights = "unknown",
        };
        string expectedCopyright =
            "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.";
        string expectedDescription = "";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "1st place: 6th – 8th grade category",
                Description = "1st place: 6th – 8th grade category",
                Title = "1st place: 6th – 8th grade category",
                Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National Park",
                FullName = "Glacier National Park",
                Name = "Glacier",
                ParkCode = "glac",
                States = "MT",
                Url = "https://www.nps.gov/glac/index.htm",
            },
        ];
        List<string> expectedTags = ["bark ranger"];
        string expectedTitle = "2008 Postcard Contest Winners";
        string expectedUrl =
            "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAssetCount, deserialized.AssetCount);
        Assert.Equal(expectedConstraintsInfo, deserialized.ConstraintsInfo);
        Assert.Equal(expectedCopyright, deserialized.Copyright);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
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
            ID = "F2D0A8A2-155D-451F-67A9-A67E74025286",
            AssetCount = "assetCount",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "unknown" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Description = "",
            Images =
            [
                new()
                {
                    AltText = "1st place: 6th – 8th grade category",
                    Description = "1st place: 6th – 8th grade category",
                    Title = "1st place: 6th – 8th grade category",
                    Url =
                        "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    FullName = "Glacier National Park",
                    Name = "Glacier",
                    ParkCode = "glac",
                    States = "MT",
                    Url = "https://www.nps.gov/glac/index.htm",
                },
            ],
            Tags = ["bark ranger"],
            Title = "2008 Postcard Contest Winners",
            Url =
                "https://www.nps.gov/media/photo/gallery.htm?id=F2D0A8A2-155D-451F-67A9-A67E74025286",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AssetCount);
        Assert.False(model.RawData.ContainsKey("assetCount"));
        Assert.Null(model.ConstraintsInfo);
        Assert.False(model.RawData.ContainsKey("constraintsInfo"));
        Assert.Null(model.Copyright);
        Assert.False(model.RawData.ContainsKey("copyright"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
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
            AssetCount = null,
            ConstraintsInfo = null,
            Copyright = null,
            Description = null,
            Images = null,
            RelatedParks = null,
            Tags = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AssetCount);
        Assert.False(model.RawData.ContainsKey("assetCount"));
        Assert.Null(model.ConstraintsInfo);
        Assert.False(model.RawData.ContainsKey("constraintsInfo"));
        Assert.Null(model.Copyright);
        Assert.False(model.RawData.ContainsKey("copyright"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
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
            AssetCount = null,
            ConstraintsInfo = null,
            Copyright = null,
            Description = null,
            Images = null,
            RelatedParks = null,
            Tags = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class ConstraintsInfoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "unknown",
        };

        string expectedConstraint = "Public domain";
        string expectedGrantingRights = "unknown";

        Assert.Equal(expectedConstraint, model.Constraint);
        Assert.Equal(expectedGrantingRights, model.GrantingRights);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "unknown",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ConstraintsInfo>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "unknown",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ConstraintsInfo>(element);
        Assert.NotNull(deserialized);

        string expectedConstraint = "Public domain";
        string expectedGrantingRights = "unknown";

        Assert.Equal(expectedConstraint, deserialized.Constraint);
        Assert.Equal(expectedGrantingRights, deserialized.GrantingRights);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "unknown",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ConstraintsInfo { };

        Assert.Null(model.Constraint);
        Assert.False(model.RawData.ContainsKey("constraint"));
        Assert.Null(model.GrantingRights);
        Assert.False(model.RawData.ContainsKey("grantingRights"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ConstraintsInfo { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ConstraintsInfo
        {
            // Null should be interpreted as omitted for these properties
            Constraint = null,
            GrantingRights = null,
        };

        Assert.Null(model.Constraint);
        Assert.False(model.RawData.ContainsKey("constraint"));
        Assert.Null(model.GrantingRights);
        Assert.False(model.RawData.ContainsKey("grantingRights"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ConstraintsInfo
        {
            // Null should be interpreted as omitted for these properties
            Constraint = null,
            GrantingRights = null,
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
            AltText = "1st place: 6th – 8th grade category",
            Description = "1st place: 6th – 8th grade category",
            Title = "1st place: 6th – 8th grade category",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
        };

        string expectedAltText = "1st place: 6th – 8th grade category";
        string expectedDescription = "1st place: 6th – 8th grade category";
        string expectedTitle = "1st place: 6th – 8th grade category";
        string expectedUrl =
            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Image
        {
            AltText = "1st place: 6th – 8th grade category",
            Description = "1st place: 6th – 8th grade category",
            Title = "1st place: 6th – 8th grade category",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
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
            AltText = "1st place: 6th – 8th grade category",
            Description = "1st place: 6th – 8th grade category",
            Title = "1st place: 6th – 8th grade category",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "1st place: 6th – 8th grade category";
        string expectedDescription = "1st place: 6th – 8th grade category";
        string expectedTitle = "1st place: 6th – 8th grade category";
        string expectedUrl =
            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Image
        {
            AltText = "1st place: 6th – 8th grade category",
            Description = "1st place: 6th – 8th grade category",
            Title = "1st place: 6th – 8th grade category",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Image { };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
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
            Description = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
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
            Description = null,
            Title = null,
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
            Designation = "National Park",
            FullName = "Glacier National Park",
            Name = "Glacier",
            ParkCode = "glac",
            States = "MT",
            Url = "https://www.nps.gov/glac/index.htm",
        };

        string expectedDesignation = "National Park";
        string expectedFullName = "Glacier National Park";
        string expectedName = "Glacier";
        string expectedParkCode = "glac";
        string expectedStates = "MT";
        string expectedUrl = "https://www.nps.gov/glac/index.htm";

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
            Designation = "National Park",
            FullName = "Glacier National Park",
            Name = "Glacier",
            ParkCode = "glac",
            States = "MT",
            Url = "https://www.nps.gov/glac/index.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            FullName = "Glacier National Park",
            Name = "Glacier",
            ParkCode = "glac",
            States = "MT",
            Url = "https://www.nps.gov/glac/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park";
        string expectedFullName = "Glacier National Park";
        string expectedName = "Glacier";
        string expectedParkCode = "glac";
        string expectedStates = "MT";
        string expectedUrl = "https://www.nps.gov/glac/index.htm";

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
            Designation = "National Park",
            FullName = "Glacier National Park",
            Name = "Glacier",
            ParkCode = "glac",
            States = "MT",
            Url = "https://www.nps.gov/glac/index.htm",
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
