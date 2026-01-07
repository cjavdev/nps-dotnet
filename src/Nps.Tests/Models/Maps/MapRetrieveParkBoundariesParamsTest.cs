using System;
using Nps.Models.Maps;

namespace Nps.Tests.Models.Maps;

public class MapRetrieveParkBoundariesParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new MapRetrieveParkBoundariesParams { Sitecode = "sitecode" };

        string expectedSitecode = "sitecode";

        Assert.Equal(expectedSitecode, parameters.Sitecode);
    }

    [Fact]
    public void Url_Works()
    {
        MapRetrieveParkBoundariesParams parameters = new() { Sitecode = "sitecode" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri("https://developer.nps.gov/api/v1/mapdata/parkboundaries/sitecode"),
            url
        );
    }
}
