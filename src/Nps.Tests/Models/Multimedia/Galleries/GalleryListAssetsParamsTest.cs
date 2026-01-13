using System;
using System.Collections.Generic;
using Nps.Models.Multimedia.Galleries;

namespace Nps.Tests.Models.Multimedia.Galleries;

public class GalleryListAssetsParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new GalleryListAssetsParams
        {
            ID = "id",
            GalleryID = "galleryId",
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Start = 0,
            StateCode = ["string"],
        };

        string expectedID = "id";
        string expectedGalleryID = "galleryId";
        long expectedLimit = 0;
        List<string> expectedParkCode = ["string"];
        string expectedQ = "q";
        long expectedStart = 0;
        List<string> expectedStateCode = ["string"];

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedGalleryID, parameters.GalleryID);
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.NotNull(parameters.ParkCode);
        Assert.Equal(expectedParkCode.Count, parameters.ParkCode.Count);
        for (int i = 0; i < expectedParkCode.Count; i++)
        {
            Assert.Equal(expectedParkCode[i], parameters.ParkCode[i]);
        }
        Assert.Equal(expectedQ, parameters.Q);
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
        var parameters = new GalleryListAssetsParams { };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
        Assert.Null(parameters.GalleryID);
        Assert.False(parameters.RawQueryData.ContainsKey("galleryId"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.StateCode);
        Assert.False(parameters.RawQueryData.ContainsKey("stateCode"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new GalleryListAssetsParams
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            GalleryID = null,
            Limit = null,
            ParkCode = null,
            Q = null,
            Start = null,
            StateCode = null,
        };

        Assert.Null(parameters.ID);
        Assert.False(parameters.RawQueryData.ContainsKey("id"));
        Assert.Null(parameters.GalleryID);
        Assert.False(parameters.RawQueryData.ContainsKey("galleryId"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.ParkCode);
        Assert.False(parameters.RawQueryData.ContainsKey("parkCode"));
        Assert.Null(parameters.Q);
        Assert.False(parameters.RawQueryData.ContainsKey("q"));
        Assert.Null(parameters.Start);
        Assert.False(parameters.RawQueryData.ContainsKey("start"));
        Assert.Null(parameters.StateCode);
        Assert.False(parameters.RawQueryData.ContainsKey("stateCode"));
    }

    [Fact]
    public void Url_Works()
    {
        GalleryListAssetsParams parameters = new()
        {
            ID = "id",
            GalleryID = "galleryId",
            Limit = 0,
            ParkCode = ["string"],
            Q = "q",
            Start = 0,
            StateCode = ["string"],
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://developer.nps.gov/api/v1/multimedia/galleries/assets?id=id&galleryId=galleryId&limit=0&parkCode=string&q=q&start=0&stateCode=string&api_key=My+API+Key"
            ),
            url
        );
    }
}
