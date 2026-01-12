using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Multimedia.Galleries;

namespace Nps.Tests.Models.Multimedia.Galleries;

public class GalleryListAssetsPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new GalleryListAssetsPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<GalleryListAssetsResponse> expectedData =
        [
            new()
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
        var model = new GalleryListAssetsPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new GalleryListAssetsPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<GalleryListAssetsPageResponse>(element);
        Assert.NotNull(deserialized);

        List<GalleryListAssetsResponse> expectedData =
        [
            new()
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
        var model = new GalleryListAssetsPageResponse
        {
            Data =
            [
                new()
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
        var model = new GalleryListAssetsPageResponse { };

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
        var model = new GalleryListAssetsPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new GalleryListAssetsPageResponse
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
        var model = new GalleryListAssetsPageResponse
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
