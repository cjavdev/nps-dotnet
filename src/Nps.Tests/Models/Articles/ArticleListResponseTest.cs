using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Articles;

namespace Nps.Tests.Models.Articles;

public class ArticleListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ArticleListResponse
        {
            Data =
            [
                new()
                {
                    ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Latitude = 38.8994750976563,
                    LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
                    ListingDescription =
                        "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
                    ListingImage = new()
                    {
                        AltText = "Historic town homes in front of modern brick building",
                        Caption = "",
                        Credit = "",
                        Description = "",
                        Title = "",
                        Url =
                            "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
                    },
                    Longitude = -77.0365524291992,
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "",
                            FullName = "President's Park (White House)",
                            Name = "President's Park (White House)",
                            ParkCode = "whho",
                            States = "DC",
                            Url = "https://www.nps.gov/whho",
                        },
                    ],
                    Title =
                        "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
                    Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
                },
            ],
            Limit = "1",
            Start = "0",
            Total = "total",
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
                GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                Latitude = 38.8994750976563,
                LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
                ListingDescription =
                    "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
                ListingImage = new()
                {
                    AltText = "Historic town homes in front of modern brick building",
                    Caption = "",
                    Credit = "",
                    Description = "",
                    Title = "",
                    Url =
                        "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
                },
                Longitude = -77.0365524291992,
                RelatedParks =
                [
                    new()
                    {
                        Designation = "",
                        FullName = "President's Park (White House)",
                        Name = "President's Park (White House)",
                        ParkCode = "whho",
                        States = "DC",
                        Url = "https://www.nps.gov/whho",
                    },
                ],
                Title = "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
                Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
            },
        ];
        string expectedLimit = "1";
        string expectedStart = "0";
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
        var model = new ArticleListResponse
        {
            Data =
            [
                new()
                {
                    ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Latitude = 38.8994750976563,
                    LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
                    ListingDescription =
                        "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
                    ListingImage = new()
                    {
                        AltText = "Historic town homes in front of modern brick building",
                        Caption = "",
                        Credit = "",
                        Description = "",
                        Title = "",
                        Url =
                            "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
                    },
                    Longitude = -77.0365524291992,
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "",
                            FullName = "President's Park (White House)",
                            Name = "President's Park (White House)",
                            ParkCode = "whho",
                            States = "DC",
                            Url = "https://www.nps.gov/whho",
                        },
                    ],
                    Title =
                        "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
                    Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
                },
            ],
            Limit = "1",
            Start = "0",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ArticleListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ArticleListResponse
        {
            Data =
            [
                new()
                {
                    ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Latitude = 38.8994750976563,
                    LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
                    ListingDescription =
                        "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
                    ListingImage = new()
                    {
                        AltText = "Historic town homes in front of modern brick building",
                        Caption = "",
                        Credit = "",
                        Description = "",
                        Title = "",
                        Url =
                            "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
                    },
                    Longitude = -77.0365524291992,
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "",
                            FullName = "President's Park (White House)",
                            Name = "President's Park (White House)",
                            ParkCode = "whho",
                            States = "DC",
                            Url = "https://www.nps.gov/whho",
                        },
                    ],
                    Title =
                        "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
                    Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
                },
            ],
            Limit = "1",
            Start = "0",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ArticleListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
                GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                Latitude = 38.8994750976563,
                LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
                ListingDescription =
                    "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
                ListingImage = new()
                {
                    AltText = "Historic town homes in front of modern brick building",
                    Caption = "",
                    Credit = "",
                    Description = "",
                    Title = "",
                    Url =
                        "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
                },
                Longitude = -77.0365524291992,
                RelatedParks =
                [
                    new()
                    {
                        Designation = "",
                        FullName = "President's Park (White House)",
                        Name = "President's Park (White House)",
                        ParkCode = "whho",
                        States = "DC",
                        Url = "https://www.nps.gov/whho",
                    },
                ],
                Title = "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
                Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
            },
        ];
        string expectedLimit = "1";
        string expectedStart = "0";
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
        var model = new ArticleListResponse
        {
            Data =
            [
                new()
                {
                    ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Latitude = 38.8994750976563,
                    LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
                    ListingDescription =
                        "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
                    ListingImage = new()
                    {
                        AltText = "Historic town homes in front of modern brick building",
                        Caption = "",
                        Credit = "",
                        Description = "",
                        Title = "",
                        Url =
                            "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
                    },
                    Longitude = -77.0365524291992,
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "",
                            FullName = "President's Park (White House)",
                            Name = "President's Park (White House)",
                            ParkCode = "whho",
                            States = "DC",
                            Url = "https://www.nps.gov/whho",
                        },
                    ],
                    Title =
                        "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
                    Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
                },
            ],
            Limit = "1",
            Start = "0",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ArticleListResponse { };

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
        var model = new ArticleListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ArticleListResponse
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
        var model = new ArticleListResponse
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
            ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Latitude = 38.8994750976563,
            LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
            ListingDescription =
                "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
            ListingImage = new()
            {
                AltText = "Historic town homes in front of modern brick building",
                Caption = "",
                Credit = "",
                Description = "",
                Title = "",
                Url =
                    "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
            },
            Longitude = -77.0365524291992,
            RelatedParks =
            [
                new()
                {
                    Designation = "",
                    FullName = "President's Park (White House)",
                    Name = "President's Park (White House)",
                    ParkCode = "whho",
                    States = "DC",
                    Url = "https://www.nps.gov/whho",
                },
            ],
            Title = "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
            Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
        };

        string expectedID = "FB939FC8-04B4-42F7-BC97-5557890D33F8";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        double expectedLatitude = 38.8994750976563;
        string expectedLatLong = "{lat:38.89947509765625, long:-77.03655242919922}";
        string expectedListingDescription =
            "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.";
        ListingImage expectedListingImage = new()
        {
            AltText = "Historic town homes in front of modern brick building",
            Caption = "",
            Credit = "",
            Description = "",
            Title = "",
            Url =
                "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
        };
        double expectedLongitude = -77.0365524291992;
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "",
                FullName = "President's Park (White House)",
                Name = "President's Park (White House)",
                ParkCode = "whho",
                States = "DC",
                Url = "https://www.nps.gov/whho",
            },
        ];
        string expectedTitle =
            "The “First Neighborhood”: Presidents and Preservation in Lafayette Park";
        string expectedUrl = "https://www.nps.gov/articles/lafayette-square-preservation.htm";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLatLong, model.LatLong);
        Assert.Equal(expectedListingDescription, model.ListingDescription);
        Assert.Equal(expectedListingImage, model.ListingImage);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Latitude = 38.8994750976563,
            LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
            ListingDescription =
                "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
            ListingImage = new()
            {
                AltText = "Historic town homes in front of modern brick building",
                Caption = "",
                Credit = "",
                Description = "",
                Title = "",
                Url =
                    "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
            },
            Longitude = -77.0365524291992,
            RelatedParks =
            [
                new()
                {
                    Designation = "",
                    FullName = "President's Park (White House)",
                    Name = "President's Park (White House)",
                    ParkCode = "whho",
                    States = "DC",
                    Url = "https://www.nps.gov/whho",
                },
            ],
            Title = "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
            Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
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
            ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Latitude = 38.8994750976563,
            LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
            ListingDescription =
                "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
            ListingImage = new()
            {
                AltText = "Historic town homes in front of modern brick building",
                Caption = "",
                Credit = "",
                Description = "",
                Title = "",
                Url =
                    "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
            },
            Longitude = -77.0365524291992,
            RelatedParks =
            [
                new()
                {
                    Designation = "",
                    FullName = "President's Park (White House)",
                    Name = "President's Park (White House)",
                    ParkCode = "whho",
                    States = "DC",
                    Url = "https://www.nps.gov/whho",
                },
            ],
            Title = "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
            Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "FB939FC8-04B4-42F7-BC97-5557890D33F8";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        double expectedLatitude = 38.8994750976563;
        string expectedLatLong = "{lat:38.89947509765625, long:-77.03655242919922}";
        string expectedListingDescription =
            "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.";
        ListingImage expectedListingImage = new()
        {
            AltText = "Historic town homes in front of modern brick building",
            Caption = "",
            Credit = "",
            Description = "",
            Title = "",
            Url =
                "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
        };
        double expectedLongitude = -77.0365524291992;
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "",
                FullName = "President's Park (White House)",
                Name = "President's Park (White House)",
                ParkCode = "whho",
                States = "DC",
                Url = "https://www.nps.gov/whho",
            },
        ];
        string expectedTitle =
            "The “First Neighborhood”: Presidents and Preservation in Lafayette Park";
        string expectedUrl = "https://www.nps.gov/articles/lafayette-square-preservation.htm";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLatLong, deserialized.LatLong);
        Assert.Equal(expectedListingDescription, deserialized.ListingDescription);
        Assert.Equal(expectedListingImage, deserialized.ListingImage);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "FB939FC8-04B4-42F7-BC97-5557890D33F8",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Latitude = 38.8994750976563,
            LatLong = "{lat:38.89947509765625, long:-77.03655242919922}",
            ListingDescription =
                "Presidents from Franklin D. Roosevelt to Lyndon B. Johnson, as well as two first ladies, were instrumental in preserving the 19th century historic character of Lafayette Square. Their advocacy influenced not only the White House's closest national historic district, but the development of national historic preservation law.",
            ListingImage = new()
            {
                AltText = "Historic town homes in front of modern brick building",
                Caption = "",
                Credit = "",
                Description = "",
                Title = "",
                Url =
                    "https://www.nps.gov/common/uploads/articles/images/nri/20170118/articles/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85/F6AD3834-1DD8-B71B-0BA8516D0F8C4D85.jpg",
            },
            Longitude = -77.0365524291992,
            RelatedParks =
            [
                new()
                {
                    Designation = "",
                    FullName = "President's Park (White House)",
                    Name = "President's Park (White House)",
                    ParkCode = "whho",
                    States = "DC",
                    Url = "https://www.nps.gov/whho",
                },
            ],
            Title = "The “First Neighborhood”: Presidents and Preservation in Lafayette Park",
            Url = "https://www.nps.gov/articles/lafayette-square-preservation.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.ListingDescription);
        Assert.False(model.RawData.ContainsKey("listingDescription"));
        Assert.Null(model.ListingImage);
        Assert.False(model.RawData.ContainsKey("listingImage"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
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
            GeometryPoiID = null,
            Latitude = null,
            LatLong = null,
            ListingDescription = null,
            ListingImage = null,
            Longitude = null,
            RelatedParks = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.ListingDescription);
        Assert.False(model.RawData.ContainsKey("listingDescription"));
        Assert.Null(model.ListingImage);
        Assert.False(model.RawData.ContainsKey("listingImage"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
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
            GeometryPoiID = null,
            Latitude = null,
            LatLong = null,
            ListingDescription = null,
            ListingImage = null,
            Longitude = null,
            RelatedParks = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class ListingImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ListingImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
        };

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        string expectedDescription = "description";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ListingImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ListingImage>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ListingImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ListingImage>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        string expectedDescription = "description";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ListingImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ListingImage { };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
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
        var model = new ListingImage { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ListingImage
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
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
        var model = new ListingImage
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
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
            Designation = "designation",
            FullName = "fullName",
            Name = "name",
            ParkCode = "parkCode",
            States = "states",
            Url = "url",
        };

        string expectedDesignation = "designation";
        string expectedFullName = "fullName";
        string expectedName = "name";
        string expectedParkCode = "parkCode";
        string expectedStates = "states";
        string expectedUrl = "url";

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
            Designation = "designation",
            FullName = "fullName",
            Name = "name",
            ParkCode = "parkCode",
            States = "states",
            Url = "url",
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
            Designation = "designation",
            FullName = "fullName",
            Name = "name",
            ParkCode = "parkCode",
            States = "states",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDesignation = "designation";
        string expectedFullName = "fullName";
        string expectedName = "name";
        string expectedParkCode = "parkCode";
        string expectedStates = "states";
        string expectedUrl = "url";

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
            Designation = "designation",
            FullName = "fullName",
            Name = "name",
            ParkCode = "parkCode",
            States = "states",
            Url = "url",
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
