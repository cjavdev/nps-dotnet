using System;
using System.Collections.Generic;
using Nps.Models.Feespasses;

namespace Nps.Tests.Models.Feespasses;

public class FeespassListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new FeespassListParams
        {
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Sort = ["string"],
            Start = 0,
            Statecode = ["string"],
        };

        long expectedLimit = 0;
        List<string> expectedParkCode = ["string"];
        string expectedQ = "q";
        List<string> expectedSort = ["string"];
        long expectedStart = 0;
        List<string> expectedStatecode = ["string"];

        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.NotNull(parameters.ParkCode);
        Assert.Equal(expectedParkCode.Count, parameters.ParkCode.Count);
        for (int i = 0; i < expectedParkCode.Count; i++)
        {
            Assert.Equal(expectedParkCode[i], parameters.ParkCode[i]);
        }
        Assert.Equal(expectedQ, parameters.Q);
        Assert.NotNull(parameters.Sort);
        Assert.Equal(expectedSort.Count, parameters.Sort.Count);
        for (int i = 0; i < expectedSort.Count; i++)
        {
            Assert.Equal(expectedSort[i], parameters.Sort[i]);
        }
        Assert.Equal(expectedStart, parameters.Start);
        Assert.NotNull(parameters.Statecode);
        Assert.Equal(expectedStatecode.Count, parameters.Statecode.Count);
        for (int i = 0; i < expectedStatecode.Count; i++)
        {
            Assert.Equal(expectedStatecode[i], parameters.Statecode[i]);
        }
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new FeespassListParams { };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Sort);
        Assert.False(parameters.RawQueryData.ContainsKey("sort"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.Statecode);
        Assert.False(parameters.RawQueryData.ContainsKey("statecode"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new FeespassListParams
        {
            // Null should be interpreted as omitted for these properties
            Limit = null,
            ParkCode = null,
            Q = null,
            Sort = null,
            Start = null,
            Statecode = null,
        };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Sort);
        Assert.False(parameters.RawQueryData.ContainsKey("sort"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.Statecode);
        Assert.False(parameters.RawQueryData.ContainsKey("statecode"));
    }

    [Fact]
    public void Url_Works()
    {
        FeespassListParams parameters = new()
        {
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Sort = ["string"],
            Start = 0,
            Statecode = ["string"],
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/feespasses?limit=0&parkCode=string&q=q&sort=string&start=0&statecode=string&api_key=My+API+Key"
            ),
            url
        );
    }
}
