using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Multimedia.Galleries;

namespace Nps.Tests.Models.Multimedia.Galleries;

public class GalleryListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new GalleryListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<GalleryListResponse> expectedData =
        [
            new()
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
        var model = new GalleryListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<GalleryListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new GalleryListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<GalleryListPageResponse>(element);
        Assert.NotNull(deserialized);

        List<GalleryListResponse> expectedData =
        [
            new()
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
        var model = new GalleryListPageResponse
        {
            Data =
            [
                new()
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
        var model = new GalleryListPageResponse { };

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
        var model = new GalleryListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new GalleryListPageResponse
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
        var model = new GalleryListPageResponse
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
