using System;
using System.Collections.Generic;
using Nps.Models.Amenities;

namespace Nps.Tests.Models.Amenities;

public class AmenityListParksPlacesParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AmenityListParksPlacesParams
        {
            ID = ["string"],
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Sort = "sort",
            Start = 0,
        };

        List<string> expectedID = ["string"];
        long expectedLimit = 0;
        List<string> expectedParkCode = ["string"];
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
        Assert.NotNull(parameters.ParkCode);
        Assert.Equal(expectedParkCode.Count, parameters.ParkCode.Count);
        for (int i = 0; i < expectedParkCode.Count; i++)
        {
            Assert.Equal(expectedParkCode[i], parameters.ParkCode[i]);
        }
        Assert.Equal(expectedQ, parameters.Q);
        Assert.Equal(expectedSort, parameters.Sort);
        Assert.Equal(expectedStart, parameters.Start);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new AmenityListParksPlacesParams { };

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
        var parameters = new AmenityListParksPlacesParams
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
        AmenityListParksPlacesParams parameters = new()
        {
            ID = ["string"],
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Sort = "sort",
            Start = 0,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/amenities/parksplaces?id=string&limit=0&parkCode=string&q=q&sort=sort&start=0&api_key=My+API+Key"
            ),
            url
        );
    }
}
