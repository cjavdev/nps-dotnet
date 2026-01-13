using System;
using Nps.Models.RoadEvents;

namespace Nps.Tests.Models.RoadEvents;

public class RoadEventListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new RoadEventListParams
        {
            Limit = 0,
            ParkCode = "parkCode",
            Start = 0,
            Type = "type",
        };

        long expectedLimit = 0;
        string expectedParkCode = "parkCode";
        long expectedStart = 0;
        string expectedType = "type";

        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedParkCode, parameters.ParkCode);
        Assert.Equal(expectedStart, parameters.Start);
        Assert.Equal(expectedType, parameters.Type);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new RoadEventListParams { };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new RoadEventListParams
        {
            // Null should be interpreted as omitted for these properties
            Limit = null,
            ParkCode = null,
            Start = null,
            Type = null,
        };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void Url_Works()
    {
        RoadEventListParams parameters = new()
        {
            Limit = 0,
            ParkCode = "parkCode",
            Start = 0,
            Type = "type",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/roadevents?limit=0&parkCode=parkCode&start=0&type=type&api_key=My+API+Key"
            ),
            url
        );
    }
}
