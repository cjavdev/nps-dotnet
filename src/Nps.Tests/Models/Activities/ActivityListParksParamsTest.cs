using System;
using System.Collections.Generic;
using Nps.Models.Activities;

namespace Nps.Tests.Models.Activities;

public class ActivityListParksParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ActivityListParksParams
        {
            ID = ["string"],
            Limit = 0,
            Q = "q",
            Sort = ["string"],
            Start = 0,
        };

        List<string> expectedID = ["string"];
        long expectedLimit = 0;
        string expectedQ = "q";
        List<string> expectedSort = ["string"];
        long expectedStart = 0;

        Assert.NotNull(parameters.ID);
        Assert.Equal(expectedID.Count, parameters.ID.Count);
        for (int i = 0; i < expectedID.Count; i++)
        {
            Assert.Equal(expectedID[i], parameters.ID[i]);
        }
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedQ, parameters.Q);
        Assert.NotNull(parameters.Sort);
        Assert.Equal(expectedSort.Count, parameters.Sort.Count);
        for (int i = 0; i < expectedSort.Count; i++)
        {
            Assert.Equal(expectedSort[i], parameters.Sort[i]);
        }
        Assert.Equal(expectedStart, parameters.Start);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ActivityListParksParams { };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Sort);
        Assert.False(parameters.RawQueryData.ContainsKey("sort"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new ActivityListParksParams
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Limit = null,
            Q = null,
            Sort = null,
            Start = null,
        };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Sort);
        Assert.False(parameters.RawQueryData.ContainsKey("sort"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
    }

    [Fact]
    public void Url_Works()
    {
        ActivityListParksParams parameters = new()
        {
            ID = ["string"],
            Limit = 0,
            Q = "q",
            Sort = ["string"],
            Start = 0,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/activities/parks?id=string&limit=0&q=q&sort=string&start=0&api_key=My+API+Key"
            ),
            url
        );
    }
}
