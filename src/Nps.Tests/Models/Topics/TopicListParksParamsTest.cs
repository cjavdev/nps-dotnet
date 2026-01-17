using System;
using System.Collections.Generic;
using Nps.Models.Topics;

namespace Nps.Tests.Models.Topics;

public class TopicListParksParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TopicListParksParams
        {
            ID = ["string"],
            Limit = 0,
            Q = "q",
            Sort = "sort",
            Start = 0,
        };

        List<string> expectedID = ["string"];
        long expectedLimit = 0;
        string expectedQ = "q";
        string expectedSort = "sort";
        long expectedStart = 0;

        Assert.NotNull(parameters.ID);
        Assert.Equal(expectedID.Count, parameters.ID.Count);
        for (int i = 0; i < expectedID.Count; i++)
        {
            Assert.Equal(expectedID[i], parameters.ID[i]);
        }
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedQ, parameters.Q);
        Assert.Equal(expectedSort, parameters.Sort);
        Assert.Equal(expectedStart, parameters.Start);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new TopicListParksParams { };

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
        var parameters = new TopicListParksParams
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
        TopicListParksParams parameters = new()
        {
            ID = ["string"],
            Limit = 0,
            Q = "q",
            Sort = "sort",
            Start = 0,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/topics/parks?id=string&limit=0&q=q&sort=sort&start=0&api_key=My+API+Key"
            ),
            url
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new TopicListParksParams
        {
            ID = ["string"],
            Limit = 0,
            Q = "q",
            Sort = "sort",
            Start = 0,
        };

        TopicListParksParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
