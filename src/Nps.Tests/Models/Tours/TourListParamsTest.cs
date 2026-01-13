using System;
using System.Collections.Generic;
using Nps.Models.Tours;

namespace Nps.Tests.Models.Tours;

public class TourListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TourListParams
        {
            ID = ["string"],
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Sort = ["string"],
            Start = 0,
            StateCode = ["string"],
        };

        List<string> expectedID = ["string"];
        long expectedLimit = 0;
        List<string> expectedParkCode = ["string"];
        string expectedQ = "q";
        List<string> expectedSort = ["string"];
        long expectedStart = 0;
        List<string> expectedStateCode = ["string"];

        Assert.NotNull(parameters.ID);
        Assert.Equal(expectedID.Count, parameters.ID.Count);
        for (int i = 0; i < expectedID.Count; i++)
        {
            Assert.Equal(expectedID[i], parameters.ID[i]);
        }
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
        Assert.NotNull(parameters.StateCode);
        Assert.Equal(expectedStateCode.Count, parameters.StateCode.Count);
        for (int i = 0; i < expectedStateCode.Count; i++)
        {
            Assert.Equal(expectedStateCode[i], parameters.StateCode[i]);
        }
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new TourListParams { };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
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
        Assert.Null(parameters.StateCode);
        Assert.False(parameters.RawQueryData.ContainsKey("stateCode"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new TourListParams
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Limit = null,
            ParkCode = null,
            Q = null,
            Sort = null,
            Start = null,
            StateCode = null,
        };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
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
        Assert.Null(parameters.StateCode);
        Assert.False(parameters.RawQueryData.ContainsKey("stateCode"));
    }

    [Fact]
    public void Url_Works()
    {
        TourListParams parameters = new()
        {
            ID = ["string"],
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Sort = ["string"],
            Start = 0,
            StateCode = ["string"],
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/tours?id=string&limit=0&parkCode=string&q=q&sort=string&start=0&stateCode=string&api_key=My+API+Key"
            ),
            url
        );
    }
}
