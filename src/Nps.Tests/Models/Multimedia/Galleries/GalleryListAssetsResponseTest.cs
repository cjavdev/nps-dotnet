using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Multimedia.Galleries;

namespace Nps.Tests.Models.Multimedia.Galleries;

public class GalleryListAssetsResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new GalleryListAssetsResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A915-155D-451F-67EA-767489860884",
                    AltText = "1st place: 6th – 8th grade category",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "Full",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Credit = "",
                    Description = "1st place: 6th – 8th grade category",
                    FileInfo = new()
                    {
                        FileSizeKB = "147265",
                        FileType = "image/jpeg",
                        HeightPixels = "768",
                        Url =
                            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        WidthPixels = "1024",
                    },
                    Ordinal = "1",
                    PermalinkUrl =
                        "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
                    Tags = ["postcard"],
                    Title = "1st place: 6th – 8th grade category",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "13",
        };

        List<GalleryListAssetsResponseData> expectedData =
        [
            new()
            {
                ID = "F2D0A915-155D-451F-67EA-767489860884",
                AltText = "1st place: 6th – 8th grade category",
                ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "Full" },
                Copyright =
                    "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                Credit = "",
                Description = "1st place: 6th – 8th grade category",
                FileInfo = new()
                {
                    FileSizeKB = "147265",
                    FileType = "image/jpeg",
                    HeightPixels = "768",
                    Url =
                        "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                    WidthPixels = "1024",
                },
                Ordinal = "1",
                PermalinkUrl =
                    "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
                Tags = ["postcard"],
                Title = "1st place: 6th – 8th grade category",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "13";

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
        var model = new GalleryListAssetsResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A915-155D-451F-67EA-767489860884",
                    AltText = "1st place: 6th – 8th grade category",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "Full",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Credit = "",
                    Description = "1st place: 6th – 8th grade category",
                    FileInfo = new()
                    {
                        FileSizeKB = "147265",
                        FileType = "image/jpeg",
                        HeightPixels = "768",
                        Url =
                            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        WidthPixels = "1024",
                    },
                    Ordinal = "1",
                    PermalinkUrl =
                        "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
                    Tags = ["postcard"],
                    Title = "1st place: 6th – 8th grade category",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "13",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new GalleryListAssetsResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A915-155D-451F-67EA-767489860884",
                    AltText = "1st place: 6th – 8th grade category",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "Full",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Credit = "",
                    Description = "1st place: 6th – 8th grade category",
                    FileInfo = new()
                    {
                        FileSizeKB = "147265",
                        FileType = "image/jpeg",
                        HeightPixels = "768",
                        Url =
                            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        WidthPixels = "1024",
                    },
                    Ordinal = "1",
                    PermalinkUrl =
                        "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
                    Tags = ["postcard"],
                    Title = "1st place: 6th – 8th grade category",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "13",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<GalleryListAssetsResponseData> expectedData =
        [
            new()
            {
                ID = "F2D0A915-155D-451F-67EA-767489860884",
                AltText = "1st place: 6th – 8th grade category",
                ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "Full" },
                Copyright =
                    "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                Credit = "",
                Description = "1st place: 6th – 8th grade category",
                FileInfo = new()
                {
                    FileSizeKB = "147265",
                    FileType = "image/jpeg",
                    HeightPixels = "768",
                    Url =
                        "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                    WidthPixels = "1024",
                },
                Ordinal = "1",
                PermalinkUrl =
                    "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
                Tags = ["postcard"],
                Title = "1st place: 6th – 8th grade category",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "13";

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
        var model = new GalleryListAssetsResponse
        {
            Data =
            [
                new()
                {
                    ID = "F2D0A915-155D-451F-67EA-767489860884",
                    AltText = "1st place: 6th – 8th grade category",
                    ConstraintsInfo = new()
                    {
                        Constraint = "Public domain",
                        GrantingRights = "Full",
                    },
                    Copyright =
                        "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
                    Credit = "",
                    Description = "1st place: 6th – 8th grade category",
                    FileInfo = new()
                    {
                        FileSizeKB = "147265",
                        FileType = "image/jpeg",
                        HeightPixels = "768",
                        Url =
                            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                        WidthPixels = "1024",
                    },
                    Ordinal = "1",
                    PermalinkUrl =
                        "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
                    Tags = ["postcard"],
                    Title = "1st place: 6th – 8th grade category",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "13",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new GalleryListAssetsResponse { };

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
        var model = new GalleryListAssetsResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new GalleryListAssetsResponse
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
        var model = new GalleryListAssetsResponse
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

public class GalleryListAssetsResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new GalleryListAssetsResponseData
        {
            ID = "F2D0A915-155D-451F-67EA-767489860884",
            AltText = "1st place: 6th – 8th grade category",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "Full" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Credit = "",
            Description = "1st place: 6th – 8th grade category",
            FileInfo = new()
            {
                FileSizeKB = "147265",
                FileType = "image/jpeg",
                HeightPixels = "768",
                Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                WidthPixels = "1024",
            },
            Ordinal = "1",
            PermalinkUrl =
                "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
            Tags = ["postcard"],
            Title = "1st place: 6th – 8th grade category",
        };

        string expectedID = "F2D0A915-155D-451F-67EA-767489860884";
        string expectedAltText = "1st place: 6th – 8th grade category";
        GalleryListAssetsResponseDataConstraintsInfo expectedConstraintsInfo = new()
        {
            Constraint = "Public domain",
            GrantingRights = "Full",
        };
        string expectedCopyright =
            "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.";
        string expectedCredit = "";
        string expectedDescription = "1st place: 6th – 8th grade category";
        FileInfo expectedFileInfo = new()
        {
            FileSizeKB = "147265",
            FileType = "image/jpeg",
            HeightPixels = "768",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            WidthPixels = "1024",
        };
        string expectedOrdinal = "1";
        string expectedPermalinkUrl =
            "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286";
        List<GalleryListAssetsResponseDataRelatedPark> expectedRelatedParks =
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
        List<string> expectedTags = ["postcard"];
        string expectedTitle = "1st place: 6th – 8th grade category";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedConstraintsInfo, model.ConstraintsInfo);
        Assert.Equal(expectedCopyright, model.Copyright);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedFileInfo, model.FileInfo);
        Assert.Equal(expectedOrdinal, model.Ordinal);
        Assert.Equal(expectedPermalinkUrl, model.PermalinkUrl);
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
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new GalleryListAssetsResponseData
        {
            ID = "F2D0A915-155D-451F-67EA-767489860884",
            AltText = "1st place: 6th – 8th grade category",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "Full" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Credit = "",
            Description = "1st place: 6th – 8th grade category",
            FileInfo = new()
            {
                FileSizeKB = "147265",
                FileType = "image/jpeg",
                HeightPixels = "768",
                Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                WidthPixels = "1024",
            },
            Ordinal = "1",
            PermalinkUrl =
                "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
            Tags = ["postcard"],
            Title = "1st place: 6th – 8th grade category",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponseData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new GalleryListAssetsResponseData
        {
            ID = "F2D0A915-155D-451F-67EA-767489860884",
            AltText = "1st place: 6th – 8th grade category",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "Full" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Credit = "",
            Description = "1st place: 6th – 8th grade category",
            FileInfo = new()
            {
                FileSizeKB = "147265",
                FileType = "image/jpeg",
                HeightPixels = "768",
                Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                WidthPixels = "1024",
            },
            Ordinal = "1",
            PermalinkUrl =
                "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
            Tags = ["postcard"],
            Title = "1st place: 6th – 8th grade category",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponseData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "F2D0A915-155D-451F-67EA-767489860884";
        string expectedAltText = "1st place: 6th – 8th grade category";
        GalleryListAssetsResponseDataConstraintsInfo expectedConstraintsInfo = new()
        {
            Constraint = "Public domain",
            GrantingRights = "Full",
        };
        string expectedCopyright =
            "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.";
        string expectedCredit = "";
        string expectedDescription = "1st place: 6th – 8th grade category";
        FileInfo expectedFileInfo = new()
        {
            FileSizeKB = "147265",
            FileType = "image/jpeg",
            HeightPixels = "768",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            WidthPixels = "1024",
        };
        string expectedOrdinal = "1";
        string expectedPermalinkUrl =
            "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286";
        List<GalleryListAssetsResponseDataRelatedPark> expectedRelatedParks =
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
        List<string> expectedTags = ["postcard"];
        string expectedTitle = "1st place: 6th – 8th grade category";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedConstraintsInfo, deserialized.ConstraintsInfo);
        Assert.Equal(expectedCopyright, deserialized.Copyright);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedFileInfo, deserialized.FileInfo);
        Assert.Equal(expectedOrdinal, deserialized.Ordinal);
        Assert.Equal(expectedPermalinkUrl, deserialized.PermalinkUrl);
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
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new GalleryListAssetsResponseData
        {
            ID = "F2D0A915-155D-451F-67EA-767489860884",
            AltText = "1st place: 6th – 8th grade category",
            ConstraintsInfo = new() { Constraint = "Public domain", GrantingRights = "Full" },
            Copyright =
                "Permission must be secured from the individual copyright owners to reproduce any copyrighted materials contained within this website. Digital assets without any copyright restrictions are public domain.",
            Credit = "",
            Description = "1st place: 6th – 8th grade category",
            FileInfo = new()
            {
                FileSizeKB = "147265",
                FileType = "image/jpeg",
                HeightPixels = "768",
                Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
                WidthPixels = "1024",
            },
            Ordinal = "1",
            PermalinkUrl =
                "https://www.nps.gov/media/photo/gallery-item.htm?pg=1&id=F2D0A915-155D-451F-67EA-767489860884&gid=F2D0A8A2-155D-451F-67A9-A67E74025286",
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
            Tags = ["postcard"],
            Title = "1st place: 6th – 8th grade category",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new GalleryListAssetsResponseData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.ConstraintsInfo);
        Assert.False(model.RawData.ContainsKey("constraintsInfo"));
        Assert.Null(model.Copyright);
        Assert.False(model.RawData.ContainsKey("copyright"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.FileInfo);
        Assert.False(model.RawData.ContainsKey("fileInfo"));
        Assert.Null(model.Ordinal);
        Assert.False(model.RawData.ContainsKey("ordinal"));
        Assert.Null(model.PermalinkUrl);
        Assert.False(model.RawData.ContainsKey("permalinkUrl"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new GalleryListAssetsResponseData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new GalleryListAssetsResponseData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            AltText = null,
            ConstraintsInfo = null,
            Copyright = null,
            Credit = null,
            Description = null,
            FileInfo = null,
            Ordinal = null,
            PermalinkUrl = null,
            RelatedParks = null,
            Tags = null,
            Title = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.ConstraintsInfo);
        Assert.False(model.RawData.ContainsKey("constraintsInfo"));
        Assert.Null(model.Copyright);
        Assert.False(model.RawData.ContainsKey("copyright"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.FileInfo);
        Assert.False(model.RawData.ContainsKey("fileInfo"));
        Assert.Null(model.Ordinal);
        Assert.False(model.RawData.ContainsKey("ordinal"));
        Assert.Null(model.PermalinkUrl);
        Assert.False(model.RawData.ContainsKey("permalinkUrl"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new GalleryListAssetsResponseData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            AltText = null,
            ConstraintsInfo = null,
            Copyright = null,
            Credit = null,
            Description = null,
            FileInfo = null,
            Ordinal = null,
            PermalinkUrl = null,
            RelatedParks = null,
            Tags = null,
            Title = null,
        };

        model.Validate();
    }
}

public class GalleryListAssetsResponseDataConstraintsInfoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new GalleryListAssetsResponseDataConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "Full",
        };

        string expectedConstraint = "Public domain";
        string expectedGrantingRights = "Full";

        Assert.Equal(expectedConstraint, model.Constraint);
        Assert.Equal(expectedGrantingRights, model.GrantingRights);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new GalleryListAssetsResponseDataConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "Full",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponseDataConstraintsInfo>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new GalleryListAssetsResponseDataConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "Full",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponseDataConstraintsInfo>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedConstraint = "Public domain";
        string expectedGrantingRights = "Full";

        Assert.Equal(expectedConstraint, deserialized.Constraint);
        Assert.Equal(expectedGrantingRights, deserialized.GrantingRights);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new GalleryListAssetsResponseDataConstraintsInfo
        {
            Constraint = "Public domain",
            GrantingRights = "Full",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new GalleryListAssetsResponseDataConstraintsInfo { };

        Assert.Null(model.Constraint);
        Assert.False(model.RawData.ContainsKey("constraint"));
        Assert.Null(model.GrantingRights);
        Assert.False(model.RawData.ContainsKey("grantingRights"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new GalleryListAssetsResponseDataConstraintsInfo { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new GalleryListAssetsResponseDataConstraintsInfo
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
        var model = new GalleryListAssetsResponseDataConstraintsInfo
        {
            // Null should be interpreted as omitted for these properties
            Constraint = null,
            GrantingRights = null,
        };

        model.Validate();
    }
}

public class FileInfoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FileInfo
        {
            FileSizeKB = "147265",
            FileType = "image/jpeg",
            HeightPixels = "768",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            WidthPixels = "1024",
        };

        string expectedFileSizeKB = "147265";
        string expectedFileType = "image/jpeg";
        string expectedHeightPixels = "768";
        string expectedUrl =
            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884";
        string expectedWidthPixels = "1024";

        Assert.Equal(expectedFileSizeKB, model.FileSizeKB);
        Assert.Equal(expectedFileType, model.FileType);
        Assert.Equal(expectedHeightPixels, model.HeightPixels);
        Assert.Equal(expectedUrl, model.Url);
        Assert.Equal(expectedWidthPixels, model.WidthPixels);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new FileInfo
        {
            FileSizeKB = "147265",
            FileType = "image/jpeg",
            HeightPixels = "768",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            WidthPixels = "1024",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FileInfo>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FileInfo
        {
            FileSizeKB = "147265",
            FileType = "image/jpeg",
            HeightPixels = "768",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            WidthPixels = "1024",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FileInfo>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedFileSizeKB = "147265";
        string expectedFileType = "image/jpeg";
        string expectedHeightPixels = "768";
        string expectedUrl =
            "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884";
        string expectedWidthPixels = "1024";

        Assert.Equal(expectedFileSizeKB, deserialized.FileSizeKB);
        Assert.Equal(expectedFileType, deserialized.FileType);
        Assert.Equal(expectedHeightPixels, deserialized.HeightPixels);
        Assert.Equal(expectedUrl, deserialized.Url);
        Assert.Equal(expectedWidthPixels, deserialized.WidthPixels);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new FileInfo
        {
            FileSizeKB = "147265",
            FileType = "image/jpeg",
            HeightPixels = "768",
            Url = "https://www.nps.gov/npgallery/GetAsset/F2D0A915-155D-451F-67EA-767489860884",
            WidthPixels = "1024",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new FileInfo { };

        Assert.Null(model.FileSizeKB);
        Assert.False(model.RawData.ContainsKey("fileSizeKb"));
        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.HeightPixels);
        Assert.False(model.RawData.ContainsKey("heightPixels"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.WidthPixels);
        Assert.False(model.RawData.ContainsKey("widthPixels"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new FileInfo { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new FileInfo
        {
            // Null should be interpreted as omitted for these properties
            FileSizeKB = null,
            FileType = null,
            HeightPixels = null,
            Url = null,
            WidthPixels = null,
        };

        Assert.Null(model.FileSizeKB);
        Assert.False(model.RawData.ContainsKey("fileSizeKb"));
        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.HeightPixels);
        Assert.False(model.RawData.ContainsKey("heightPixels"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.WidthPixels);
        Assert.False(model.RawData.ContainsKey("widthPixels"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new FileInfo
        {
            // Null should be interpreted as omitted for these properties
            FileSizeKB = null,
            FileType = null,
            HeightPixels = null,
            Url = null,
            WidthPixels = null,
        };

        model.Validate();
    }
}

public class GalleryListAssetsResponseDataRelatedParkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new GalleryListAssetsResponseDataRelatedPark
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
        var model = new GalleryListAssetsResponseDataRelatedPark
        {
            Designation = "National Park",
            FullName = "Glacier National Park",
            Name = "Glacier",
            ParkCode = "glac",
            States = "MT",
            Url = "https://www.nps.gov/glac/index.htm",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponseDataRelatedPark>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new GalleryListAssetsResponseDataRelatedPark
        {
            Designation = "National Park",
            FullName = "Glacier National Park",
            Name = "Glacier",
            ParkCode = "glac",
            States = "MT",
            Url = "https://www.nps.gov/glac/index.htm",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsResponseDataRelatedPark>(
            element,
            ModelBase.SerializerOptions
        );
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
        var model = new GalleryListAssetsResponseDataRelatedPark
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
        var model = new GalleryListAssetsResponseDataRelatedPark { };

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
        var model = new GalleryListAssetsResponseDataRelatedPark { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new GalleryListAssetsResponseDataRelatedPark
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
        var model = new GalleryListAssetsResponseDataRelatedPark
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
