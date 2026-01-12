using System;
using System.Collections.Generic;
using Nps.Models.Events;

namespace Nps.Tests.Models.Events;

public class EventListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new EventListParams
        {
            ID = "id",
            DateEnd = "dateEnd",
            DateStart = "dateStart",
            EventType = ["string"],
            ExpandRecurring = true,
            Limit = 0,
            Organization = ["string"],
            PageNumber = 0,
            PageSize = 0,
            ParkCode = ["string"],
            Portal = ["string"],
            Q = "q",
            Start = 0,
            StateCode = ["string"],
            Subject = ["string"],
            TagsAll = ["string"],
            TagsNone = ["string"],
            TagsOne = ["string"],
        };

        string expectedID = "id";
        string expectedDateEnd = "dateEnd";
        string expectedDateStart = "dateStart";
        List<string> expectedEventType = ["string"];
        bool expectedExpandRecurring = true;
        long expectedLimit = 0;
        List<string> expectedOrganization = ["string"];
        long expectedPageNumber = 0;
        long expectedPageSize = 0;
        List<string> expectedParkCode = ["string"];
        List<string> expectedPortal = ["string"];
        string expectedQ = "q";
        long expectedStart = 0;
        List<string> expectedStateCode = ["string"];
        List<string> expectedSubject = ["string"];
        List<string> expectedTagsAll = ["string"];
        List<string> expectedTagsNone = ["string"];
        List<string> expectedTagsOne = ["string"];

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedDateEnd, parameters.DateEnd);
        Assert.Equal(expectedDateStart, parameters.DateStart);
        Assert.NotNull(parameters.EventType);
        Assert.Equal(expectedEventType.Count, parameters.EventType.Count);
        for (int i = 0; i < expectedEventType.Count; i++)
        {
            Assert.Equal(expectedEventType[i], parameters.EventType[i]);
        }
        Assert.Equal(expectedExpandRecurring, parameters.ExpandRecurring);
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.NotNull(parameters.Organization);
        Assert.Equal(expectedOrganization.Count, parameters.Organization.Count);
        for (int i = 0; i < expectedOrganization.Count; i++)
        {
            Assert.Equal(expectedOrganization[i], parameters.Organization[i]);
        }
        Assert.Equal(expectedPageNumber, parameters.PageNumber);
        Assert.Equal(expectedPageSize, parameters.PageSize);
        Assert.NotNull(parameters.ParkCode);
        Assert.Equal(expectedParkCode.Count, parameters.ParkCode.Count);
        for (int i = 0; i < expectedParkCode.Count; i++)
        {
            Assert.Equal(expectedParkCode[i], parameters.ParkCode[i]);
        }
        Assert.NotNull(parameters.Portal);
        Assert.Equal(expectedPortal.Count, parameters.Portal.Count);
        for (int i = 0; i < expectedPortal.Count; i++)
        {
            Assert.Equal(expectedPortal[i], parameters.Portal[i]);
        }
        Assert.Equal(expectedQ, parameters.Q);
        Assert.Equal(expectedStart, parameters.Start);
        Assert.NotNull(parameters.StateCode);
        Assert.Equal(expectedStateCode.Count, parameters.StateCode.Count);
        for (int i = 0; i < expectedStateCode.Count; i++)
        {
            Assert.Equal(expectedStateCode[i], parameters.StateCode[i]);
        }
        Assert.NotNull(parameters.Subject);
        Assert.Equal(expectedSubject.Count, parameters.Subject.Count);
        for (int i = 0; i < expectedSubject.Count; i++)
        {
            Assert.Equal(expectedSubject[i], parameters.Subject[i]);
        }
        Assert.NotNull(parameters.TagsAll);
        Assert.Equal(expectedTagsAll.Count, parameters.TagsAll.Count);
        for (int i = 0; i < expectedTagsAll.Count; i++)
        {
            Assert.Equal(expectedTagsAll[i], parameters.TagsAll[i]);
        }
        Assert.NotNull(parameters.TagsNone);
        Assert.Equal(expectedTagsNone.Count, parameters.TagsNone.Count);
        for (int i = 0; i < expectedTagsNone.Count; i++)
        {
            Assert.Equal(expectedTagsNone[i], parameters.TagsNone[i]);
        }
        Assert.NotNull(parameters.TagsOne);
        Assert.Equal(expectedTagsOne.Count, parameters.TagsOne.Count);
        for (int i = 0; i < expectedTagsOne.Count; i++)
        {
            Assert.Equal(expectedTagsOne[i], parameters.TagsOne[i]);
        }
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new EventListParams { };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
        Assert.Null(parameters.DateEnd);
        Assert.False(parameters.RawQueryData.ContainsKey("dateEnd"));
        Assert.Null(parameters.DateStart);
        Assert.False(parameters.RawQueryData.ContainsKey("dateStart"));
        Assert.Null(parameters.EventType);
        Assert.False(parameters.RawQueryData.ContainsKey("eventType"));
        Assert.Null(parameters.ExpandRecurring);
        Assert.False(parameters.RawQueryData.ContainsKey("expandRecurring"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Organization);
        Assert.False(parameters.RawQueryData.ContainsKey("organization"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("pageNumber"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("pageSize"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Portal);
        Assert.False(parameters.RawQueryData.ContainsKey("portal"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.StateCode);
        Assert.False(parameters.RawQueryData.ContainsKey("stateCode"));
        Assert.Null(parameters.Subject);
        Assert.False(parameters.RawQueryData.ContainsKey("subject"));
        Assert.Null(parameters.TagsAll);
        Assert.False(parameters.RawQueryData.ContainsKey("tagsAll"));
        Assert.Null(parameters.TagsNone);
        Assert.False(parameters.RawQueryData.ContainsKey("tagsNone"));
        Assert.Null(parameters.TagsOne);
        Assert.False(parameters.RawQueryData.ContainsKey("tagsOne"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new EventListParams
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            DateEnd = null,
            DateStart = null,
            EventType = null,
            ExpandRecurring = null,
            Limit = null,
            Organization = null,
            PageNumber = null,
            PageSize = null,
            ParkCode = null,
            Portal = null,
            Q = null,
            Start = null,
            StateCode = null,
            Subject = null,
            TagsAll = null,
            TagsNone = null,
            TagsOne = null,
        };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
        Assert.Null(parameters.DateEnd);
        Assert.False(parameters.RawQueryData.ContainsKey("dateEnd"));
        Assert.Null(parameters.DateStart);
        Assert.False(parameters.RawQueryData.ContainsKey("dateStart"));
        Assert.Null(parameters.EventType);
        Assert.False(parameters.RawQueryData.ContainsKey("eventType"));
        Assert.Null(parameters.ExpandRecurring);
        Assert.False(parameters.RawQueryData.ContainsKey("expandRecurring"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Organization);
        Assert.False(parameters.RawQueryData.ContainsKey("organization"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("pageNumber"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("pageSize"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Portal);
        Assert.False(parameters.RawQueryData.ContainsKey("portal"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.StateCode);
        Assert.False(parameters.RawQueryData.ContainsKey("stateCode"));
        Assert.Null(parameters.Subject);
        Assert.False(parameters.RawQueryData.ContainsKey("subject"));
        Assert.Null(parameters.TagsAll);
        Assert.False(parameters.RawQueryData.ContainsKey("tagsAll"));
        Assert.Null(parameters.TagsNone);
        Assert.False(parameters.RawQueryData.ContainsKey("tagsNone"));
        Assert.Null(parameters.TagsOne);
        Assert.False(parameters.RawQueryData.ContainsKey("tagsOne"));
    }

    [Fact]
    public void Url_Works()
    {
        EventListParams parameters = new()
        {
            ID = "id",
            DateEnd = "dateEnd",
            DateStart = "dateStart",
            EventType = ["string"],
            ExpandRecurring = true,
            Limit = 0,
            Organization = ["string"],
            PageNumber = 0,
            PageSize = 0,
            ParkCode = ["string"],
            Portal = ["string"],
            Q = "q",
            Start = 0,
            StateCode = ["string"],
            Subject = ["string"],
            TagsAll = ["string"],
            TagsNone = ["string"],
            TagsOne = ["string"],
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/events?id=id&dateEnd=dateEnd&dateStart=dateStart&eventType=string&expandRecurring=true&limit=0&organization=string&pageNumber=0&pageSize=0&parkCode=string&portal=string&q=q&start=0&stateCode=string&subject=string&tagsAll=string&tagsNone=string&tagsOne=string"
            ),
            url
        );
    }
}
