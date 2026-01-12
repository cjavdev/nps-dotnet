using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Articles;

namespace Nps.Tests.Models.Articles;

public class ArticleListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ArticleListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<ArticleListResponse> expectedData =
        [
            new()
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
        var model = new ArticleListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ArticleListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ArticleListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ArticleListPageResponse>(element);
        Assert.NotNull(deserialized);

        List<ArticleListResponse> expectedData =
        [
            new()
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
        var model = new ArticleListPageResponse
        {
            Data =
            [
                new()
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
        var model = new ArticleListPageResponse { };

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
        var model = new ArticleListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ArticleListPageResponse
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
        var model = new ArticleListPageResponse
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
