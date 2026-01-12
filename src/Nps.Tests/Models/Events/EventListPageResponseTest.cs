using System;
using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Events;

namespace Nps.Tests.Models.Events;

public class EventListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new EventListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F0092036-921D-2344-8498FB0012847F3C",
                            Category = "category",
                            Categoryid = "1",
                            Contactemailaddress = "contactemailaddress",
                            Contactname = "contactname",
                            ContacttelephoneNumber = "contacttelephoneNumber",
                            Createuser = "createuser",
                            Date = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")],
                            Datestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Datetimecreated = "datetimecreated",
                            Datetimeupdated = "datetimeupdated",
                            Description = "description",
                            Eventid = "eventid",
                            Feeinfo = "feeinfo",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Imageidlist = "imageidlist",
                            Images =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    ImageID = "21803",
                                    Ordinal = "0",
                                    Path =
                                        "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            Infourl = "infourl",
                            Isallday = "isallday",
                            Isfree = "isfree",
                            Isrecurring = "isrecurring",
                            Isregresrequired = "isregresrequired",
                            Latitude = "latitude",
                            Location = "location",
                            Longitude = "longitude",
                            Organizationname = "organizationname",
                            Parkfullname = "parkfullname",
                            Portalname = "portalname",
                            Recurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencedatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencerule = "recurrencerule",
                            Regresinfo = "regresinfo",
                            Regresurl = "regresurl",
                            Sitecode = "sitecode",
                            Sitetype = "sitetype",
                            Subjectname = "subjectname",
                            Tags = ["string"],
                            Timeinfo = "timeinfo",
                            Times =
                            [
                                new()
                                {
                                    Sunrisestart = "true",
                                    Sunsetend = "false",
                                    Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Title = "title",
                            Types = ["string"],
                        },
                    ],
                    Dates = "2020-01-01,2019-12-04,2019-12-11",
                    Errors = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Pagenumber = "1",
                    Pagesize = "50",
                    Total = "745",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<EventListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "F0092036-921D-2344-8498FB0012847F3C",
                        Category = "category",
                        Categoryid = "1",
                        Contactemailaddress = "contactemailaddress",
                        Contactname = "contactname",
                        ContacttelephoneNumber = "contacttelephoneNumber",
                        Createuser = "createuser",
                        Date = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Dateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Dates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")],
                        Datestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Datetimecreated = "datetimecreated",
                        Datetimeupdated = "datetimeupdated",
                        Description = "description",
                        Eventid = "eventid",
                        Feeinfo = "feeinfo",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Imageidlist = "imageidlist",
                        Images =
                        [
                            new()
                            {
                                AltText = "altText",
                                Caption = "caption",
                                Credit = "credit",
                                ImageID = "21803",
                                Ordinal = "0",
                                Path =
                                    "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                                Title = "title",
                                Url = "url",
                            },
                        ],
                        Infourl = "infourl",
                        Isallday = "isallday",
                        Isfree = "isfree",
                        Isrecurring = "isrecurring",
                        Isregresrequired = "isregresrequired",
                        Latitude = "latitude",
                        Location = "location",
                        Longitude = "longitude",
                        Organizationname = "organizationname",
                        Parkfullname = "parkfullname",
                        Portalname = "portalname",
                        Recurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Recurrencedatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Recurrencerule = "recurrencerule",
                        Regresinfo = "regresinfo",
                        Regresurl = "regresurl",
                        Sitecode = "sitecode",
                        Sitetype = "sitetype",
                        Subjectname = "subjectname",
                        Tags = ["string"],
                        Timeinfo = "timeinfo",
                        Times =
                        [
                            new()
                            {
                                Sunrisestart = "true",
                                Sunsetend = "false",
                                Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                        ],
                        Title = "title",
                        Types = ["string"],
                    },
                ],
                Dates = "2020-01-01,2019-12-04,2019-12-11",
                Errors = [JsonSerializer.Deserialize<JsonElement>("{}")],
                Pagenumber = "1",
                Pagesize = "50",
                Total = "745",
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
        var model = new EventListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F0092036-921D-2344-8498FB0012847F3C",
                            Category = "category",
                            Categoryid = "1",
                            Contactemailaddress = "contactemailaddress",
                            Contactname = "contactname",
                            ContacttelephoneNumber = "contacttelephoneNumber",
                            Createuser = "createuser",
                            Date = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")],
                            Datestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Datetimecreated = "datetimecreated",
                            Datetimeupdated = "datetimeupdated",
                            Description = "description",
                            Eventid = "eventid",
                            Feeinfo = "feeinfo",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Imageidlist = "imageidlist",
                            Images =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    ImageID = "21803",
                                    Ordinal = "0",
                                    Path =
                                        "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            Infourl = "infourl",
                            Isallday = "isallday",
                            Isfree = "isfree",
                            Isrecurring = "isrecurring",
                            Isregresrequired = "isregresrequired",
                            Latitude = "latitude",
                            Location = "location",
                            Longitude = "longitude",
                            Organizationname = "organizationname",
                            Parkfullname = "parkfullname",
                            Portalname = "portalname",
                            Recurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencedatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencerule = "recurrencerule",
                            Regresinfo = "regresinfo",
                            Regresurl = "regresurl",
                            Sitecode = "sitecode",
                            Sitetype = "sitetype",
                            Subjectname = "subjectname",
                            Tags = ["string"],
                            Timeinfo = "timeinfo",
                            Times =
                            [
                                new()
                                {
                                    Sunrisestart = "true",
                                    Sunsetend = "false",
                                    Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Title = "title",
                            Types = ["string"],
                        },
                    ],
                    Dates = "2020-01-01,2019-12-04,2019-12-11",
                    Errors = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Pagenumber = "1",
                    Pagesize = "50",
                    Total = "745",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<EventListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new EventListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F0092036-921D-2344-8498FB0012847F3C",
                            Category = "category",
                            Categoryid = "1",
                            Contactemailaddress = "contactemailaddress",
                            Contactname = "contactname",
                            ContacttelephoneNumber = "contacttelephoneNumber",
                            Createuser = "createuser",
                            Date = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")],
                            Datestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Datetimecreated = "datetimecreated",
                            Datetimeupdated = "datetimeupdated",
                            Description = "description",
                            Eventid = "eventid",
                            Feeinfo = "feeinfo",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Imageidlist = "imageidlist",
                            Images =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    ImageID = "21803",
                                    Ordinal = "0",
                                    Path =
                                        "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            Infourl = "infourl",
                            Isallday = "isallday",
                            Isfree = "isfree",
                            Isrecurring = "isrecurring",
                            Isregresrequired = "isregresrequired",
                            Latitude = "latitude",
                            Location = "location",
                            Longitude = "longitude",
                            Organizationname = "organizationname",
                            Parkfullname = "parkfullname",
                            Portalname = "portalname",
                            Recurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencedatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencerule = "recurrencerule",
                            Regresinfo = "regresinfo",
                            Regresurl = "regresurl",
                            Sitecode = "sitecode",
                            Sitetype = "sitetype",
                            Subjectname = "subjectname",
                            Tags = ["string"],
                            Timeinfo = "timeinfo",
                            Times =
                            [
                                new()
                                {
                                    Sunrisestart = "true",
                                    Sunsetend = "false",
                                    Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Title = "title",
                            Types = ["string"],
                        },
                    ],
                    Dates = "2020-01-01,2019-12-04,2019-12-11",
                    Errors = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Pagenumber = "1",
                    Pagesize = "50",
                    Total = "745",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<EventListPageResponse>(element);
        Assert.NotNull(deserialized);

        List<EventListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "F0092036-921D-2344-8498FB0012847F3C",
                        Category = "category",
                        Categoryid = "1",
                        Contactemailaddress = "contactemailaddress",
                        Contactname = "contactname",
                        ContacttelephoneNumber = "contacttelephoneNumber",
                        Createuser = "createuser",
                        Date = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Dateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Dates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")],
                        Datestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Datetimecreated = "datetimecreated",
                        Datetimeupdated = "datetimeupdated",
                        Description = "description",
                        Eventid = "eventid",
                        Feeinfo = "feeinfo",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Imageidlist = "imageidlist",
                        Images =
                        [
                            new()
                            {
                                AltText = "altText",
                                Caption = "caption",
                                Credit = "credit",
                                ImageID = "21803",
                                Ordinal = "0",
                                Path =
                                    "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                                Title = "title",
                                Url = "url",
                            },
                        ],
                        Infourl = "infourl",
                        Isallday = "isallday",
                        Isfree = "isfree",
                        Isrecurring = "isrecurring",
                        Isregresrequired = "isregresrequired",
                        Latitude = "latitude",
                        Location = "location",
                        Longitude = "longitude",
                        Organizationname = "organizationname",
                        Parkfullname = "parkfullname",
                        Portalname = "portalname",
                        Recurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Recurrencedatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Recurrencerule = "recurrencerule",
                        Regresinfo = "regresinfo",
                        Regresurl = "regresurl",
                        Sitecode = "sitecode",
                        Sitetype = "sitetype",
                        Subjectname = "subjectname",
                        Tags = ["string"],
                        Timeinfo = "timeinfo",
                        Times =
                        [
                            new()
                            {
                                Sunrisestart = "true",
                                Sunsetend = "false",
                                Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                        ],
                        Title = "title",
                        Types = ["string"],
                    },
                ],
                Dates = "2020-01-01,2019-12-04,2019-12-11",
                Errors = [JsonSerializer.Deserialize<JsonElement>("{}")],
                Pagenumber = "1",
                Pagesize = "50",
                Total = "745",
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
        var model = new EventListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "F0092036-921D-2344-8498FB0012847F3C",
                            Category = "category",
                            Categoryid = "1",
                            Contactemailaddress = "contactemailaddress",
                            Contactname = "contactname",
                            ContacttelephoneNumber = "contacttelephoneNumber",
                            Createuser = "createuser",
                            Date = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Dates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")],
                            Datestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Datetimecreated = "datetimecreated",
                            Datetimeupdated = "datetimeupdated",
                            Description = "description",
                            Eventid = "eventid",
                            Feeinfo = "feeinfo",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Imageidlist = "imageidlist",
                            Images =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    ImageID = "21803",
                                    Ordinal = "0",
                                    Path =
                                        "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            Infourl = "infourl",
                            Isallday = "isallday",
                            Isfree = "isfree",
                            Isrecurring = "isrecurring",
                            Isregresrequired = "isregresrequired",
                            Latitude = "latitude",
                            Location = "location",
                            Longitude = "longitude",
                            Organizationname = "organizationname",
                            Parkfullname = "parkfullname",
                            Portalname = "portalname",
                            Recurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencedatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            Recurrencerule = "recurrencerule",
                            Regresinfo = "regresinfo",
                            Regresurl = "regresurl",
                            Sitecode = "sitecode",
                            Sitetype = "sitetype",
                            Subjectname = "subjectname",
                            Tags = ["string"],
                            Timeinfo = "timeinfo",
                            Times =
                            [
                                new()
                                {
                                    Sunrisestart = "true",
                                    Sunsetend = "false",
                                    Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Title = "title",
                            Types = ["string"],
                        },
                    ],
                    Dates = "2020-01-01,2019-12-04,2019-12-11",
                    Errors = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Pagenumber = "1",
                    Pagesize = "50",
                    Total = "745",
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
        var model = new EventListPageResponse { };

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
        var model = new EventListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new EventListPageResponse
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
        var model = new EventListPageResponse
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
