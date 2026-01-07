using System;
using Nps.Models.RoadEvents;

namespace Nps.Tests.Models.RoadEvents;

public class RoadEventListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new RoadEventListParams { ParkCode = "parkCode", Type = "type" };

        string expectedParkCode = "parkCode";
        string expectedType = "type";

        Assert.Equal(expectedParkCode, parameters.ParkCode);
        Assert.Equal(expectedType, parameters.Type);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new RoadEventListParams { };

        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new RoadEventListParams
        {
            // Null should be interpreted as omitted for these properties
            ParkCode = null,
            Type = null,
        };

        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void Url_Works()
    {
        RoadEventListParams parameters = new() { ParkCode = "parkCode", Type = "type" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri("https://developer.nps.gov/api/v1/roadevents?parkCode=parkCode&type=type"),
            url
        );
    }
}
