using System;
using System.Collections.Generic;
using Nps.Models.Amenities;

namespace Nps.Tests.Models.Amenities;

public class AmenityListParksVisitorCentersParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AmenityListParksVisitorCentersParams
        {
            ID = "id",
            Limit = 0,
            ParkCode = "parkCode",
            Q = "q",
            Sort = ["string"],
            Start = 0,
        };

        string expectedID = "id";
        long expectedLimit = 0;
        string expectedParkCode = "parkCode";
        string expectedQ = "q";
        List<string> expectedSort = ["string"];
        long expectedStart = 0;

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedParkCode, parameters.ParkCode);
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
        var parameters = new AmenityListParksVisitorCentersParams { };

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
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new AmenityListParksVisitorCentersParams
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Limit = null,
            ParkCode = null,
            Q = null,
            Sort = null,
            Start = null,
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
    }

    [Fact]
    public void Url_Works()
    {
        AmenityListParksVisitorCentersParams parameters = new()
        {
            ID = "id",
            Limit = 0,
            ParkCode = "parkCode",
            Q = "q",
            Sort = ["string"],
            Start = 0,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/amenities/parksvisitorcenters?id=id&limit=0&parkCode=parkCode&q=q&sort=string&start=0&api_key=My+API+Key"
            ),
            url
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new AmenityListParksVisitorCentersParams
        {
            ID = "id",
            Limit = 0,
            ParkCode = "parkCode",
            Q = "q",
            Sort = ["string"],
            Start = 0,
        };

        AmenityListParksVisitorCentersParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
