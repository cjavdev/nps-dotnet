using System;
using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.NewsReleases;

namespace Nps.Tests.Models.NewsReleases;

public class NewsReleaseListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new NewsReleaseListPageResponse
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<NewsReleaseListResponse> expectedData =
        [
            new()
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
        var model = new NewsReleaseListPageResponse
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<NewsReleaseListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new NewsReleaseListPageResponse
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<NewsReleaseListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<NewsReleaseListResponse> expectedData =
        [
            new()
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
        var model = new NewsReleaseListPageResponse
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
        var model = new NewsReleaseListPageResponse { };

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
        var model = new NewsReleaseListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new NewsReleaseListPageResponse
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
        var model = new NewsReleaseListPageResponse
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
