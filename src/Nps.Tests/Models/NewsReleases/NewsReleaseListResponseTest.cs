using System;
using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.NewsReleases;

namespace Nps.Tests.Models.NewsReleases;

public class NewsReleaseListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new NewsReleaseListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Abstract = "abstract",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Image = new()
                    {
                        AltText = "altText",
                        Caption = "caption",
                        Credit = "credit",
                        Description = "description",
                        Title = "title",
                        Url = "url",
                    },
                    Latitude = "latitude",
                    Longitude = "longitude",
                    ParkCode = "parkCode",
                    RelatedOrgs =
                    [
                        new()
                        {
                            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                            Name = "Investigative Services",
                            Url = "http://www.nps.gov/orgs/1563/",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "1889",
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "id",
                Abstract = "abstract",
                GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                Image = new()
                {
                    AltText = "altText",
                    Caption = "caption",
                    Credit = "credit",
                    Description = "description",
                    Title = "title",
                    Url = "url",
                },
                Latitude = "latitude",
                Longitude = "longitude",
                ParkCode = "parkCode",
                RelatedOrgs =
                [
                    new()
                    {
                        ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                        Name = "Investigative Services",
                        Url = "http://www.nps.gov/orgs/1563/",
                    },
                ],
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National River",
                        FullName = "Buffalo National River",
                        Name = "Buffalo",
                        ParkCode = "buff",
                        State = "AR",
                        Url = "https://www.nps.gov/buff/index.htm",
                    },
                ],
                Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Title = "title",
                Url = "url",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "1889";

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
        var model = new NewsReleaseListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Abstract = "abstract",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Image = new()
                    {
                        AltText = "altText",
                        Caption = "caption",
                        Credit = "credit",
                        Description = "description",
                        Title = "title",
                        Url = "url",
                    },
                    Latitude = "latitude",
                    Longitude = "longitude",
                    ParkCode = "parkCode",
                    RelatedOrgs =
                    [
                        new()
                        {
                            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                            Name = "Investigative Services",
                            Url = "http://www.nps.gov/orgs/1563/",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "1889",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<NewsReleaseListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new NewsReleaseListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Abstract = "abstract",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Image = new()
                    {
                        AltText = "altText",
                        Caption = "caption",
                        Credit = "credit",
                        Description = "description",
                        Title = "title",
                        Url = "url",
                    },
                    Latitude = "latitude",
                    Longitude = "longitude",
                    ParkCode = "parkCode",
                    RelatedOrgs =
                    [
                        new()
                        {
                            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                            Name = "Investigative Services",
                            Url = "http://www.nps.gov/orgs/1563/",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "1889",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<NewsReleaseListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "id",
                Abstract = "abstract",
                GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                Image = new()
                {
                    AltText = "altText",
                    Caption = "caption",
                    Credit = "credit",
                    Description = "description",
                    Title = "title",
                    Url = "url",
                },
                Latitude = "latitude",
                Longitude = "longitude",
                ParkCode = "parkCode",
                RelatedOrgs =
                [
                    new()
                    {
                        ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                        Name = "Investigative Services",
                        Url = "http://www.nps.gov/orgs/1563/",
                    },
                ],
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National River",
                        FullName = "Buffalo National River",
                        Name = "Buffalo",
                        ParkCode = "buff",
                        State = "AR",
                        Url = "https://www.nps.gov/buff/index.htm",
                    },
                ],
                Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Title = "title",
                Url = "url",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "1889";

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
        var model = new NewsReleaseListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Abstract = "abstract",
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Image = new()
                    {
                        AltText = "altText",
                        Caption = "caption",
                        Credit = "credit",
                        Description = "description",
                        Title = "title",
                        Url = "url",
                    },
                    Latitude = "latitude",
                    Longitude = "longitude",
                    ParkCode = "parkCode",
                    RelatedOrgs =
                    [
                        new()
                        {
                            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                            Name = "Investigative Services",
                            Url = "http://www.nps.gov/orgs/1563/",
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Title = "title",
                    Url = "url",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "1889",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new NewsReleaseListResponse { };

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
        var model = new NewsReleaseListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new NewsReleaseListResponse
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
        var model = new NewsReleaseListResponse
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
            Abstract = "abstract",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Image = new()
            {
                AltText = "altText",
                Caption = "caption",
                Credit = "credit",
                Description = "description",
                Title = "title",
                Url = "url",
            },
            Latitude = "latitude",
            Longitude = "longitude",
            ParkCode = "parkCode",
            RelatedOrgs =
            [
                new()
                {
                    ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                    Name = "Investigative Services",
                    Url = "http://www.nps.gov/orgs/1563/",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Title = "title",
            Url = "url",
        };

        string expectedID = "id";
        string expectedAbstract = "abstract";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        Image expectedImage = new()
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
        };
        string expectedLatitude = "latitude";
        string expectedLongitude = "longitude";
        string expectedParkCode = "parkCode";
        List<RelatedOrg> expectedRelatedOrgs =
        [
            new()
            {
                ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                Name = "Investigative Services",
                Url = "http://www.nps.gov/orgs/1563/",
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National River",
                FullName = "Buffalo National River",
                Name = "Buffalo",
                ParkCode = "buff",
                State = "AR",
                Url = "https://www.nps.gov/buff/index.htm",
            },
        ];
        DateTimeOffset expectedReleasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAbstract, model.Abstract);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.Equal(expectedImage, model.Image);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.NotNull(model.RelatedOrgs);
        Assert.Equal(expectedRelatedOrgs.Count, model.RelatedOrgs.Count);
        for (int i = 0; i < expectedRelatedOrgs.Count; i++)
        {
            Assert.Equal(expectedRelatedOrgs[i], model.RelatedOrgs[i]);
        }
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedReleasedate, model.Releasedate);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "id",
            Abstract = "abstract",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Image = new()
            {
                AltText = "altText",
                Caption = "caption",
                Credit = "credit",
                Description = "description",
                Title = "title",
                Url = "url",
            },
            Latitude = "latitude",
            Longitude = "longitude",
            ParkCode = "parkCode",
            RelatedOrgs =
            [
                new()
                {
                    ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                    Name = "Investigative Services",
                    Url = "http://www.nps.gov/orgs/1563/",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Title = "title",
            Url = "url",
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
            ID = "id",
            Abstract = "abstract",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Image = new()
            {
                AltText = "altText",
                Caption = "caption",
                Credit = "credit",
                Description = "description",
                Title = "title",
                Url = "url",
            },
            Latitude = "latitude",
            Longitude = "longitude",
            ParkCode = "parkCode",
            RelatedOrgs =
            [
                new()
                {
                    ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                    Name = "Investigative Services",
                    Url = "http://www.nps.gov/orgs/1563/",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedAbstract = "abstract";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        Image expectedImage = new()
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
        };
        string expectedLatitude = "latitude";
        string expectedLongitude = "longitude";
        string expectedParkCode = "parkCode";
        List<RelatedOrg> expectedRelatedOrgs =
        [
            new()
            {
                ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                Name = "Investigative Services",
                Url = "http://www.nps.gov/orgs/1563/",
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National River",
                FullName = "Buffalo National River",
                Name = "Buffalo",
                ParkCode = "buff",
                State = "AR",
                Url = "https://www.nps.gov/buff/index.htm",
            },
        ];
        DateTimeOffset expectedReleasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAbstract, deserialized.Abstract);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.Equal(expectedImage, deserialized.Image);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.NotNull(deserialized.RelatedOrgs);
        Assert.Equal(expectedRelatedOrgs.Count, deserialized.RelatedOrgs.Count);
        for (int i = 0; i < expectedRelatedOrgs.Count; i++)
        {
            Assert.Equal(expectedRelatedOrgs[i], deserialized.RelatedOrgs[i]);
        }
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedReleasedate, deserialized.Releasedate);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "id",
            Abstract = "abstract",
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Image = new()
            {
                AltText = "altText",
                Caption = "caption",
                Credit = "credit",
                Description = "description",
                Title = "title",
                Url = "url",
            },
            Latitude = "latitude",
            Longitude = "longitude",
            ParkCode = "parkCode",
            RelatedOrgs =
            [
                new()
                {
                    ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
                    Name = "Investigative Services",
                    Url = "http://www.nps.gov/orgs/1563/",
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            Releasedate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        Assert.Null(model.Abstract);
        Assert.False(model.RawData.ContainsKey("abstract"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Image);
        Assert.False(model.RawData.ContainsKey("image"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.RelatedOrgs);
        Assert.False(model.RawData.ContainsKey("relatedOrgs"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Releasedate);
        Assert.False(model.RawData.ContainsKey("releasedate"));
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
            Abstract = null,
            GeometryPoiID = null,
            Image = null,
            Latitude = null,
            Longitude = null,
            ParkCode = null,
            RelatedOrgs = null,
            RelatedParks = null,
            Releasedate = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Abstract);
        Assert.False(model.RawData.ContainsKey("abstract"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Image);
        Assert.False(model.RawData.ContainsKey("image"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.RelatedOrgs);
        Assert.False(model.RawData.ContainsKey("relatedOrgs"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Releasedate);
        Assert.False(model.RawData.ContainsKey("releasedate"));
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
            Abstract = null,
            GeometryPoiID = null,
            Image = null,
            Latitude = null,
            Longitude = null,
            ParkCode = null,
            RelatedOrgs = null,
            RelatedParks = null,
            Releasedate = null,
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
        var model = new Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
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
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Description = "description",
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(element);
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
        var model = new Image
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
        var model = new Image { };

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
        var model = new Image
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

public class RelatedOrgTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RelatedOrg
        {
            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
            Name = "Investigative Services",
            Url = "http://www.nps.gov/orgs/1563/",
        };

        string expectedID = "1ED09DFF-E65B-425F-8596-7087FAC00343";
        string expectedName = "Investigative Services";
        string expectedUrl = "http://www.nps.gov/orgs/1563/";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedOrg
        {
            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
            Name = "Investigative Services",
            Url = "http://www.nps.gov/orgs/1563/",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedOrg>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedOrg
        {
            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
            Name = "Investigative Services",
            Url = "http://www.nps.gov/orgs/1563/",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedOrg>(element);
        Assert.NotNull(deserialized);

        string expectedID = "1ED09DFF-E65B-425F-8596-7087FAC00343";
        string expectedName = "Investigative Services";
        string expectedUrl = "http://www.nps.gov/orgs/1563/";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedOrg
        {
            ID = "1ED09DFF-E65B-425F-8596-7087FAC00343",
            Name = "Investigative Services",
            Url = "http://www.nps.gov/orgs/1563/",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RelatedOrg { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new RelatedOrg { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RelatedOrg
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RelatedOrg
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
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
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
        };

        string expectedDesignation = "National River";
        string expectedFullName = "Buffalo National River";
        string expectedName = "Buffalo";
        string expectedParkCode = "buff";
        string expectedState = "AR";
        string expectedUrl = "https://www.nps.gov/buff/index.htm";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedState, model.State);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
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
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National River";
        string expectedFullName = "Buffalo National River";
        string expectedName = "Buffalo";
        string expectedParkCode = "buff";
        string expectedState = "AR";
        string expectedUrl = "https://www.nps.gov/buff/index.htm";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedState, deserialized.State);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
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
        Assert.Null(model.State);
        Assert.False(model.RawData.ContainsKey("state"));
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
            State = null,
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
        Assert.Null(model.State);
        Assert.False(model.RawData.ContainsKey("state"));
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
            State = null,
            Url = null,
        };

        model.Validate();
    }
}
