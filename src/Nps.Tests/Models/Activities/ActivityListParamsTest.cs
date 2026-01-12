using System;
using Nps.Models.Activities;

namespace Nps.Tests.Models.Activities;

public class ActivityListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ActivityListParams
        {
            ID = "id",
            Limit = 0,
            Q = "q",
            Sort = "sort",
            Start = 0,
        };

        string expectedID = "id";
        long expectedLimit = 0;
        string expectedQ = "q";
        string expectedSort = "sort";
        long expectedStart = 0;

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedQ, parameters.Q);
        Assert.Equal(expectedSort, parameters.Sort);
        Assert.Equal(expectedStart, parameters.Start);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ActivityListParams { };

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
        var parameters = new ActivityListParams
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
        ActivityListParams parameters = new()
        {
            ID = "id",
            Limit = 0,
            Q = "q",
            Sort = "sort",
            Start = 0,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/activities?id=id&limit=0&q=q&sort=sort&start=0"
            ),
            url
        );
    }
}
