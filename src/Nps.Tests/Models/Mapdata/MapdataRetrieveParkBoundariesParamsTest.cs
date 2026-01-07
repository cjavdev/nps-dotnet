using System;
using Nps.Models.Mapdata;

namespace Nps.Tests.Models.Mapdata;

public class MapdataRetrieveParkBoundariesParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new MapdataRetrieveParkBoundariesParams { Sitecode = "sitecode" };

        string expectedSitecode = "sitecode";

        Assert.Equal(expectedSitecode, parameters.Sitecode);
    }

    [Fact]
    public void Url_Works()
    {
        MapdataRetrieveParkBoundariesParams parameters = new() { Sitecode = "sitecode" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri("https://developer.nps.gov/api/v1/mapdata/parkboundaries/sitecode"),
            url
        );
    }
}
