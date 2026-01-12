using System;
using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Events;

namespace Nps.Tests.Models.Events;

public class EventListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new EventListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new EventListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
        var deserialized = JsonSerializer.Deserialize<EventListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new EventListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
        var deserialized = JsonSerializer.Deserialize<EventListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new EventListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
        var model = new EventListResponse { };

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
        var model = new EventListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new EventListResponse
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
        var model = new EventListResponse
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
            DataValue =
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
        };

        List<DataData> expectedDataValue =
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
        ];
        string expectedDates = "2020-01-01,2019-12-04,2019-12-11";
        List<JsonElement> expectedErrors = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedPagenumber = "1";
        string expectedPagesize = "50";
        string expectedTotal = "745";

        Assert.NotNull(model.DataValue);
        Assert.Equal(expectedDataValue.Count, model.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], model.DataValue[i]);
        }
        Assert.Equal(expectedDates, model.Dates);
        Assert.NotNull(model.Errors);
        Assert.Equal(expectedErrors.Count, model.Errors.Count);
        for (int i = 0; i < expectedErrors.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedErrors[i], model.Errors[i]));
        }
        Assert.Equal(expectedPagenumber, model.Pagenumber);
        Assert.Equal(expectedPagesize, model.Pagesize);
        Assert.Equal(expectedTotal, model.Total);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            DataValue =
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
            DataValue =
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        List<DataData> expectedDataValue =
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
        ];
        string expectedDates = "2020-01-01,2019-12-04,2019-12-11";
        List<JsonElement> expectedErrors = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedPagenumber = "1";
        string expectedPagesize = "50";
        string expectedTotal = "745";

        Assert.NotNull(deserialized.DataValue);
        Assert.Equal(expectedDataValue.Count, deserialized.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], deserialized.DataValue[i]);
        }
        Assert.Equal(expectedDates, deserialized.Dates);
        Assert.NotNull(deserialized.Errors);
        Assert.Equal(expectedErrors.Count, deserialized.Errors.Count);
        for (int i = 0; i < expectedErrors.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedErrors[i], deserialized.Errors[i]));
        }
        Assert.Equal(expectedPagenumber, deserialized.Pagenumber);
        Assert.Equal(expectedPagesize, deserialized.Pagesize);
        Assert.Equal(expectedTotal, deserialized.Total);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            DataValue =
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.DataValue);
        Assert.False(model.RawData.ContainsKey("data"));
        Assert.Null(model.Dates);
        Assert.False(model.RawData.ContainsKey("dates"));
        Assert.Null(model.Errors);
        Assert.False(model.RawData.ContainsKey("errors"));
        Assert.Null(model.Pagenumber);
        Assert.False(model.RawData.ContainsKey("pagenumber"));
        Assert.Null(model.Pagesize);
        Assert.False(model.RawData.ContainsKey("pagesize"));
        Assert.Null(model.Total);
        Assert.False(model.RawData.ContainsKey("total"));
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
            DataValue = null,
            Dates = null,
            Errors = null,
            Pagenumber = null,
            Pagesize = null,
            Total = null,
        };

        Assert.Null(model.DataValue);
        Assert.False(model.RawData.ContainsKey("data"));
        Assert.Null(model.Dates);
        Assert.False(model.RawData.ContainsKey("dates"));
        Assert.Null(model.Errors);
        Assert.False(model.RawData.ContainsKey("errors"));
        Assert.Null(model.Pagenumber);
        Assert.False(model.RawData.ContainsKey("pagenumber"));
        Assert.Null(model.Pagesize);
        Assert.False(model.RawData.ContainsKey("pagesize"));
        Assert.Null(model.Total);
        Assert.False(model.RawData.ContainsKey("total"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            DataValue = null,
            Dates = null,
            Errors = null,
            Pagenumber = null,
            Pagesize = null,
            Total = null,
        };

        model.Validate();
    }
}

public class DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataData
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
                    Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
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
        };

        string expectedID = "F0092036-921D-2344-8498FB0012847F3C";
        string expectedCategory = "category";
        string expectedCategoryid = "1";
        string expectedContactemailaddress = "contactemailaddress";
        string expectedContactname = "contactname";
        string expectedContacttelephoneNumber = "contacttelephoneNumber";
        string expectedCreateuser = "createuser";
        DateTimeOffset expectedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedDateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        List<DateTimeOffset> expectedDates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")];
        DateTimeOffset expectedDatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedDatetimecreated = "datetimecreated";
        string expectedDatetimeupdated = "datetimeupdated";
        string expectedDescription = "description";
        string expectedEventid = "eventid";
        string expectedFeeinfo = "feeinfo";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        string expectedImageidlist = "imageidlist";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "altText",
                Caption = "caption",
                Credit = "credit",
                ImageID = "21803",
                Ordinal = "0",
                Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                Title = "title",
                Url = "url",
            },
        ];
        string expectedInfourl = "infourl";
        string expectedIsallday = "isallday";
        string expectedIsfree = "isfree";
        string expectedIsrecurring = "isrecurring";
        string expectedIsregresrequired = "isregresrequired";
        string expectedLatitude = "latitude";
        string expectedLocation = "location";
        string expectedLongitude = "longitude";
        string expectedOrganizationname = "organizationname";
        string expectedParkfullname = "parkfullname";
        string expectedPortalname = "portalname";
        DateTimeOffset expectedRecurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedRecurrencedatestart = DateTimeOffset.Parse(
            "2019-12-27T18:11:19.117Z"
        );
        string expectedRecurrencerule = "recurrencerule";
        string expectedRegresinfo = "regresinfo";
        string expectedRegresurl = "regresurl";
        string expectedSitecode = "sitecode";
        string expectedSitetype = "sitetype";
        string expectedSubjectname = "subjectname";
        List<string> expectedTags = ["string"];
        string expectedTimeinfo = "timeinfo";
        List<Time> expectedTimes =
        [
            new()
            {
                Sunrisestart = "true",
                Sunsetend = "false",
                Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        ];
        string expectedTitle = "title";
        List<string> expectedTypes = ["string"];

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCategory, model.Category);
        Assert.Equal(expectedCategoryid, model.Categoryid);
        Assert.Equal(expectedContactemailaddress, model.Contactemailaddress);
        Assert.Equal(expectedContactname, model.Contactname);
        Assert.Equal(expectedContacttelephoneNumber, model.ContacttelephoneNumber);
        Assert.Equal(expectedCreateuser, model.Createuser);
        Assert.Equal(expectedDate, model.Date);
        Assert.Equal(expectedDateend, model.Dateend);
        Assert.NotNull(model.Dates);
        Assert.Equal(expectedDates.Count, model.Dates.Count);
        for (int i = 0; i < expectedDates.Count; i++)
        {
            Assert.Equal(expectedDates[i], model.Dates[i]);
        }
        Assert.Equal(expectedDatestart, model.Datestart);
        Assert.Equal(expectedDatetimecreated, model.Datetimecreated);
        Assert.Equal(expectedDatetimeupdated, model.Datetimeupdated);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedEventid, model.Eventid);
        Assert.Equal(expectedFeeinfo, model.Feeinfo);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.Equal(expectedImageidlist, model.Imageidlist);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedInfourl, model.Infourl);
        Assert.Equal(expectedIsallday, model.Isallday);
        Assert.Equal(expectedIsfree, model.Isfree);
        Assert.Equal(expectedIsrecurring, model.Isrecurring);
        Assert.Equal(expectedIsregresrequired, model.Isregresrequired);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLocation, model.Location);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedOrganizationname, model.Organizationname);
        Assert.Equal(expectedParkfullname, model.Parkfullname);
        Assert.Equal(expectedPortalname, model.Portalname);
        Assert.Equal(expectedRecurrencedateend, model.Recurrencedateend);
        Assert.Equal(expectedRecurrencedatestart, model.Recurrencedatestart);
        Assert.Equal(expectedRecurrencerule, model.Recurrencerule);
        Assert.Equal(expectedRegresinfo, model.Regresinfo);
        Assert.Equal(expectedRegresurl, model.Regresurl);
        Assert.Equal(expectedSitecode, model.Sitecode);
        Assert.Equal(expectedSitetype, model.Sitetype);
        Assert.Equal(expectedSubjectname, model.Subjectname);
        Assert.NotNull(model.Tags);
        Assert.Equal(expectedTags.Count, model.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], model.Tags[i]);
        }
        Assert.Equal(expectedTimeinfo, model.Timeinfo);
        Assert.NotNull(model.Times);
        Assert.Equal(expectedTimes.Count, model.Times.Count);
        for (int i = 0; i < expectedTimes.Count; i++)
        {
            Assert.Equal(expectedTimes[i], model.Times[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.NotNull(model.Types);
        Assert.Equal(expectedTypes.Count, model.Types.Count);
        for (int i = 0; i < expectedTypes.Count; i++)
        {
            Assert.Equal(expectedTypes[i], model.Types[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataData
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
                    Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataData
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
                    Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "F0092036-921D-2344-8498FB0012847F3C";
        string expectedCategory = "category";
        string expectedCategoryid = "1";
        string expectedContactemailaddress = "contactemailaddress";
        string expectedContactname = "contactname";
        string expectedContacttelephoneNumber = "contacttelephoneNumber";
        string expectedCreateuser = "createuser";
        DateTimeOffset expectedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedDateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        List<DateTimeOffset> expectedDates = [DateTimeOffset.Parse("2019-12-27T18:11:19.117Z")];
        DateTimeOffset expectedDatestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedDatetimecreated = "datetimecreated";
        string expectedDatetimeupdated = "datetimeupdated";
        string expectedDescription = "description";
        string expectedEventid = "eventid";
        string expectedFeeinfo = "feeinfo";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        string expectedImageidlist = "imageidlist";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "altText",
                Caption = "caption",
                Credit = "credit",
                ImageID = "21803",
                Ordinal = "0",
                Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
                Title = "title",
                Url = "url",
            },
        ];
        string expectedInfourl = "infourl";
        string expectedIsallday = "isallday";
        string expectedIsfree = "isfree";
        string expectedIsrecurring = "isrecurring";
        string expectedIsregresrequired = "isregresrequired";
        string expectedLatitude = "latitude";
        string expectedLocation = "location";
        string expectedLongitude = "longitude";
        string expectedOrganizationname = "organizationname";
        string expectedParkfullname = "parkfullname";
        string expectedPortalname = "portalname";
        DateTimeOffset expectedRecurrencedateend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedRecurrencedatestart = DateTimeOffset.Parse(
            "2019-12-27T18:11:19.117Z"
        );
        string expectedRecurrencerule = "recurrencerule";
        string expectedRegresinfo = "regresinfo";
        string expectedRegresurl = "regresurl";
        string expectedSitecode = "sitecode";
        string expectedSitetype = "sitetype";
        string expectedSubjectname = "subjectname";
        List<string> expectedTags = ["string"];
        string expectedTimeinfo = "timeinfo";
        List<Time> expectedTimes =
        [
            new()
            {
                Sunrisestart = "true",
                Sunsetend = "false",
                Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        ];
        string expectedTitle = "title";
        List<string> expectedTypes = ["string"];

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCategory, deserialized.Category);
        Assert.Equal(expectedCategoryid, deserialized.Categoryid);
        Assert.Equal(expectedContactemailaddress, deserialized.Contactemailaddress);
        Assert.Equal(expectedContactname, deserialized.Contactname);
        Assert.Equal(expectedContacttelephoneNumber, deserialized.ContacttelephoneNumber);
        Assert.Equal(expectedCreateuser, deserialized.Createuser);
        Assert.Equal(expectedDate, deserialized.Date);
        Assert.Equal(expectedDateend, deserialized.Dateend);
        Assert.NotNull(deserialized.Dates);
        Assert.Equal(expectedDates.Count, deserialized.Dates.Count);
        for (int i = 0; i < expectedDates.Count; i++)
        {
            Assert.Equal(expectedDates[i], deserialized.Dates[i]);
        }
        Assert.Equal(expectedDatestart, deserialized.Datestart);
        Assert.Equal(expectedDatetimecreated, deserialized.Datetimecreated);
        Assert.Equal(expectedDatetimeupdated, deserialized.Datetimeupdated);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedEventid, deserialized.Eventid);
        Assert.Equal(expectedFeeinfo, deserialized.Feeinfo);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.Equal(expectedImageidlist, deserialized.Imageidlist);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedInfourl, deserialized.Infourl);
        Assert.Equal(expectedIsallday, deserialized.Isallday);
        Assert.Equal(expectedIsfree, deserialized.Isfree);
        Assert.Equal(expectedIsrecurring, deserialized.Isrecurring);
        Assert.Equal(expectedIsregresrequired, deserialized.Isregresrequired);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLocation, deserialized.Location);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedOrganizationname, deserialized.Organizationname);
        Assert.Equal(expectedParkfullname, deserialized.Parkfullname);
        Assert.Equal(expectedPortalname, deserialized.Portalname);
        Assert.Equal(expectedRecurrencedateend, deserialized.Recurrencedateend);
        Assert.Equal(expectedRecurrencedatestart, deserialized.Recurrencedatestart);
        Assert.Equal(expectedRecurrencerule, deserialized.Recurrencerule);
        Assert.Equal(expectedRegresinfo, deserialized.Regresinfo);
        Assert.Equal(expectedRegresurl, deserialized.Regresurl);
        Assert.Equal(expectedSitecode, deserialized.Sitecode);
        Assert.Equal(expectedSitetype, deserialized.Sitetype);
        Assert.Equal(expectedSubjectname, deserialized.Subjectname);
        Assert.NotNull(deserialized.Tags);
        Assert.Equal(expectedTags.Count, deserialized.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], deserialized.Tags[i]);
        }
        Assert.Equal(expectedTimeinfo, deserialized.Timeinfo);
        Assert.NotNull(deserialized.Times);
        Assert.Equal(expectedTimes.Count, deserialized.Times.Count);
        for (int i = 0; i < expectedTimes.Count; i++)
        {
            Assert.Equal(expectedTimes[i], deserialized.Times[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.NotNull(deserialized.Types);
        Assert.Equal(expectedTypes.Count, deserialized.Types.Count);
        for (int i = 0; i < expectedTypes.Count; i++)
        {
            Assert.Equal(expectedTypes[i], deserialized.Types[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataData
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
                    Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Category);
        Assert.False(model.RawData.ContainsKey("category"));
        Assert.Null(model.Categoryid);
        Assert.False(model.RawData.ContainsKey("categoryid"));
        Assert.Null(model.Contactemailaddress);
        Assert.False(model.RawData.ContainsKey("contactemailaddress"));
        Assert.Null(model.Contactname);
        Assert.False(model.RawData.ContainsKey("contactname"));
        Assert.Null(model.ContacttelephoneNumber);
        Assert.False(model.RawData.ContainsKey("contacttelephoneNumber"));
        Assert.Null(model.Createuser);
        Assert.False(model.RawData.ContainsKey("createuser"));
        Assert.Null(model.Date);
        Assert.False(model.RawData.ContainsKey("date"));
        Assert.Null(model.Dateend);
        Assert.False(model.RawData.ContainsKey("dateend"));
        Assert.Null(model.Dates);
        Assert.False(model.RawData.ContainsKey("dates"));
        Assert.Null(model.Datestart);
        Assert.False(model.RawData.ContainsKey("datestart"));
        Assert.Null(model.Datetimecreated);
        Assert.False(model.RawData.ContainsKey("datetimecreated"));
        Assert.Null(model.Datetimeupdated);
        Assert.False(model.RawData.ContainsKey("datetimeupdated"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Eventid);
        Assert.False(model.RawData.ContainsKey("eventid"));
        Assert.Null(model.Feeinfo);
        Assert.False(model.RawData.ContainsKey("feeinfo"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Imageidlist);
        Assert.False(model.RawData.ContainsKey("imageidlist"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Infourl);
        Assert.False(model.RawData.ContainsKey("infourl"));
        Assert.Null(model.Isallday);
        Assert.False(model.RawData.ContainsKey("isallday"));
        Assert.Null(model.Isfree);
        Assert.False(model.RawData.ContainsKey("isfree"));
        Assert.Null(model.Isrecurring);
        Assert.False(model.RawData.ContainsKey("isrecurring"));
        Assert.Null(model.Isregresrequired);
        Assert.False(model.RawData.ContainsKey("isregresrequired"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Location);
        Assert.False(model.RawData.ContainsKey("location"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.Organizationname);
        Assert.False(model.RawData.ContainsKey("organizationname"));
        Assert.Null(model.Parkfullname);
        Assert.False(model.RawData.ContainsKey("parkfullname"));
        Assert.Null(model.Portalname);
        Assert.False(model.RawData.ContainsKey("portalname"));
        Assert.Null(model.Recurrencedateend);
        Assert.False(model.RawData.ContainsKey("recurrencedateend"));
        Assert.Null(model.Recurrencedatestart);
        Assert.False(model.RawData.ContainsKey("recurrencedatestart"));
        Assert.Null(model.Recurrencerule);
        Assert.False(model.RawData.ContainsKey("recurrencerule"));
        Assert.Null(model.Regresinfo);
        Assert.False(model.RawData.ContainsKey("regresinfo"));
        Assert.Null(model.Regresurl);
        Assert.False(model.RawData.ContainsKey("regresurl"));
        Assert.Null(model.Sitecode);
        Assert.False(model.RawData.ContainsKey("sitecode"));
        Assert.Null(model.Sitetype);
        Assert.False(model.RawData.ContainsKey("sitetype"));
        Assert.Null(model.Subjectname);
        Assert.False(model.RawData.ContainsKey("subjectname"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Timeinfo);
        Assert.False(model.RawData.ContainsKey("timeinfo"));
        Assert.Null(model.Times);
        Assert.False(model.RawData.ContainsKey("times"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Types);
        Assert.False(model.RawData.ContainsKey("types"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Category = null,
            Categoryid = null,
            Contactemailaddress = null,
            Contactname = null,
            ContacttelephoneNumber = null,
            Createuser = null,
            Date = null,
            Dateend = null,
            Dates = null,
            Datestart = null,
            Datetimecreated = null,
            Datetimeupdated = null,
            Description = null,
            Eventid = null,
            Feeinfo = null,
            GeometryPoiID = null,
            Imageidlist = null,
            Images = null,
            Infourl = null,
            Isallday = null,
            Isfree = null,
            Isrecurring = null,
            Isregresrequired = null,
            Latitude = null,
            Location = null,
            Longitude = null,
            Organizationname = null,
            Parkfullname = null,
            Portalname = null,
            Recurrencedateend = null,
            Recurrencedatestart = null,
            Recurrencerule = null,
            Regresinfo = null,
            Regresurl = null,
            Sitecode = null,
            Sitetype = null,
            Subjectname = null,
            Tags = null,
            Timeinfo = null,
            Times = null,
            Title = null,
            Types = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Category);
        Assert.False(model.RawData.ContainsKey("category"));
        Assert.Null(model.Categoryid);
        Assert.False(model.RawData.ContainsKey("categoryid"));
        Assert.Null(model.Contactemailaddress);
        Assert.False(model.RawData.ContainsKey("contactemailaddress"));
        Assert.Null(model.Contactname);
        Assert.False(model.RawData.ContainsKey("contactname"));
        Assert.Null(model.ContacttelephoneNumber);
        Assert.False(model.RawData.ContainsKey("contacttelephoneNumber"));
        Assert.Null(model.Createuser);
        Assert.False(model.RawData.ContainsKey("createuser"));
        Assert.Null(model.Date);
        Assert.False(model.RawData.ContainsKey("date"));
        Assert.Null(model.Dateend);
        Assert.False(model.RawData.ContainsKey("dateend"));
        Assert.Null(model.Dates);
        Assert.False(model.RawData.ContainsKey("dates"));
        Assert.Null(model.Datestart);
        Assert.False(model.RawData.ContainsKey("datestart"));
        Assert.Null(model.Datetimecreated);
        Assert.False(model.RawData.ContainsKey("datetimecreated"));
        Assert.Null(model.Datetimeupdated);
        Assert.False(model.RawData.ContainsKey("datetimeupdated"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Eventid);
        Assert.False(model.RawData.ContainsKey("eventid"));
        Assert.Null(model.Feeinfo);
        Assert.False(model.RawData.ContainsKey("feeinfo"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Imageidlist);
        Assert.False(model.RawData.ContainsKey("imageidlist"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Infourl);
        Assert.False(model.RawData.ContainsKey("infourl"));
        Assert.Null(model.Isallday);
        Assert.False(model.RawData.ContainsKey("isallday"));
        Assert.Null(model.Isfree);
        Assert.False(model.RawData.ContainsKey("isfree"));
        Assert.Null(model.Isrecurring);
        Assert.False(model.RawData.ContainsKey("isrecurring"));
        Assert.Null(model.Isregresrequired);
        Assert.False(model.RawData.ContainsKey("isregresrequired"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Location);
        Assert.False(model.RawData.ContainsKey("location"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.Organizationname);
        Assert.False(model.RawData.ContainsKey("organizationname"));
        Assert.Null(model.Parkfullname);
        Assert.False(model.RawData.ContainsKey("parkfullname"));
        Assert.Null(model.Portalname);
        Assert.False(model.RawData.ContainsKey("portalname"));
        Assert.Null(model.Recurrencedateend);
        Assert.False(model.RawData.ContainsKey("recurrencedateend"));
        Assert.Null(model.Recurrencedatestart);
        Assert.False(model.RawData.ContainsKey("recurrencedatestart"));
        Assert.Null(model.Recurrencerule);
        Assert.False(model.RawData.ContainsKey("recurrencerule"));
        Assert.Null(model.Regresinfo);
        Assert.False(model.RawData.ContainsKey("regresinfo"));
        Assert.Null(model.Regresurl);
        Assert.False(model.RawData.ContainsKey("regresurl"));
        Assert.Null(model.Sitecode);
        Assert.False(model.RawData.ContainsKey("sitecode"));
        Assert.Null(model.Sitetype);
        Assert.False(model.RawData.ContainsKey("sitetype"));
        Assert.Null(model.Subjectname);
        Assert.False(model.RawData.ContainsKey("subjectname"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Timeinfo);
        Assert.False(model.RawData.ContainsKey("timeinfo"));
        Assert.Null(model.Times);
        Assert.False(model.RawData.ContainsKey("times"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Types);
        Assert.False(model.RawData.ContainsKey("types"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Category = null,
            Categoryid = null,
            Contactemailaddress = null,
            Contactname = null,
            ContacttelephoneNumber = null,
            Createuser = null,
            Date = null,
            Dateend = null,
            Dates = null,
            Datestart = null,
            Datetimecreated = null,
            Datetimeupdated = null,
            Description = null,
            Eventid = null,
            Feeinfo = null,
            GeometryPoiID = null,
            Imageidlist = null,
            Images = null,
            Infourl = null,
            Isallday = null,
            Isfree = null,
            Isrecurring = null,
            Isregresrequired = null,
            Latitude = null,
            Location = null,
            Longitude = null,
            Organizationname = null,
            Parkfullname = null,
            Portalname = null,
            Recurrencedateend = null,
            Recurrencedatestart = null,
            Recurrencerule = null,
            Regresinfo = null,
            Regresurl = null,
            Sitecode = null,
            Sitetype = null,
            Subjectname = null,
            Tags = null,
            Timeinfo = null,
            Times = null,
            Title = null,
            Types = null,
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
            ImageID = "21803",
            Ordinal = "0",
            Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
            Title = "title",
            Url = "url",
        };

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        string expectedImageID = "21803";
        string expectedOrdinal = "0";
        string expectedPath =
            "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedImageID, model.ImageID);
        Assert.Equal(expectedOrdinal, model.Ordinal);
        Assert.Equal(expectedPath, model.Path);
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
            ImageID = "21803",
            Ordinal = "0",
            Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
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
            ImageID = "21803",
            Ordinal = "0",
            Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        string expectedImageID = "21803";
        string expectedOrdinal = "0";
        string expectedPath =
            "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedImageID, deserialized.ImageID);
        Assert.Equal(expectedOrdinal, deserialized.Ordinal);
        Assert.Equal(expectedPath, deserialized.Path);
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
            ImageID = "21803",
            Ordinal = "0",
            Path = "/common/uploads/event_calendar/1B853925-E059-D529-0C87BCF597BE816B.jpg",
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
        Assert.Null(model.ImageID);
        Assert.False(model.RawData.ContainsKey("imageId"));
        Assert.Null(model.Ordinal);
        Assert.False(model.RawData.ContainsKey("ordinal"));
        Assert.Null(model.Path);
        Assert.False(model.RawData.ContainsKey("path"));
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
            ImageID = null,
            Ordinal = null,
            Path = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.ImageID);
        Assert.False(model.RawData.ContainsKey("imageId"));
        Assert.Null(model.Ordinal);
        Assert.False(model.RawData.ContainsKey("ordinal"));
        Assert.Null(model.Path);
        Assert.False(model.RawData.ContainsKey("path"));
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
            ImageID = null,
            Ordinal = null,
            Path = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class TimeTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Time
        {
            Sunrisestart = "true",
            Sunsetend = "false",
            Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string expectedSunrisestart = "true";
        string expectedSunsetend = "false";
        DateTimeOffset expectedTimeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedTimestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedSunrisestart, model.Sunrisestart);
        Assert.Equal(expectedSunsetend, model.Sunsetend);
        Assert.Equal(expectedTimeend, model.Timeend);
        Assert.Equal(expectedTimestart, model.Timestart);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Time
        {
            Sunrisestart = "true",
            Sunsetend = "false",
            Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Time>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Time
        {
            Sunrisestart = "true",
            Sunsetend = "false",
            Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Time>(element);
        Assert.NotNull(deserialized);

        string expectedSunrisestart = "true";
        string expectedSunsetend = "false";
        DateTimeOffset expectedTimeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedTimestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedSunrisestart, deserialized.Sunrisestart);
        Assert.Equal(expectedSunsetend, deserialized.Sunsetend);
        Assert.Equal(expectedTimeend, deserialized.Timeend);
        Assert.Equal(expectedTimestart, deserialized.Timestart);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Time
        {
            Sunrisestart = "true",
            Sunsetend = "false",
            Timeend = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Timestart = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Time { };

        Assert.Null(model.Sunrisestart);
        Assert.False(model.RawData.ContainsKey("sunrisestart"));
        Assert.Null(model.Sunsetend);
        Assert.False(model.RawData.ContainsKey("sunsetend"));
        Assert.Null(model.Timeend);
        Assert.False(model.RawData.ContainsKey("timeend"));
        Assert.Null(model.Timestart);
        Assert.False(model.RawData.ContainsKey("timestart"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Time { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Time
        {
            // Null should be interpreted as omitted for these properties
            Sunrisestart = null,
            Sunsetend = null,
            Timeend = null,
            Timestart = null,
        };

        Assert.Null(model.Sunrisestart);
        Assert.False(model.RawData.ContainsKey("sunrisestart"));
        Assert.Null(model.Sunsetend);
        Assert.False(model.RawData.ContainsKey("sunsetend"));
        Assert.Null(model.Timeend);
        Assert.False(model.RawData.ContainsKey("timeend"));
        Assert.Null(model.Timestart);
        Assert.False(model.RawData.ContainsKey("timestart"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Time
        {
            // Null should be interpreted as omitted for these properties
            Sunrisestart = null,
            Sunsetend = null,
            Timeend = null,
            Timestart = null,
        };

        model.Validate();
    }
}
