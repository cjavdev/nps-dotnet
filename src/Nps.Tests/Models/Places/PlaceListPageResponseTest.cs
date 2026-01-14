using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Places;

namespace Nps.Tests.Models.Places;

public class PlaceListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PlaceListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "770F90DA-DE86-4C87-8F65-00369A398BC9",
                            Amenities =
                            [
                                "\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\"",
                            ],
                            AudioDescription = "audioDescription",
                            BodyText = "bodyText",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            IsManagedByNps = "1",
                            IsOpenToPublic = "1",
                            Latitude = "38.871843",
                            LatLong = "38.871843,-78.203699",
                            ListingDescription = "listingDescription",
                            Longitude = "-78.203699",
                            ManagedByOrg = "",
                            ManagedByUrl = "",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                },
                            ],
                            NpmapID = "npmapId",
                            QuickFacts = "",
                            RelatedOrganizations = ["string"],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Shenandoah National Park",
                                    Name = "Shenandoah",
                                    ParkCode = "shen",
                                    States = "VA",
                                    Url = "https://www.nps.gov/shen/index.htm",
                                },
                            ],
                            Tags = ["string"],
                            Title = "title",
                            Url = "https://www.nps.gov/places/fox-hollow-trailhead.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "950",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<PlaceListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "770F90DA-DE86-4C87-8F65-00369A398BC9",
                        Amenities = ["\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\""],
                        AudioDescription = "audioDescription",
                        BodyText = "bodyText",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images = ["string"],
                        IsManagedByNps = "1",
                        IsOpenToPublic = "1",
                        Latitude = "38.871843",
                        LatLong = "38.871843,-78.203699",
                        ListingDescription = "listingDescription",
                        Longitude = "-78.203699",
                        ManagedByOrg = "",
                        ManagedByUrl = "",
                        Multimedia =
                        [
                            new()
                            {
                                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                Title = "The Worthington Farm",
                                Type = "multimedia/videos",
                                Url =
                                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                            },
                        ],
                        NpmapID = "npmapId",
                        QuickFacts = "",
                        RelatedOrganizations = ["string"],
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park",
                                FullName = "Shenandoah National Park",
                                Name = "Shenandoah",
                                ParkCode = "shen",
                                States = "VA",
                                Url = "https://www.nps.gov/shen/index.htm",
                            },
                        ],
                        Tags = ["string"],
                        Title = "title",
                        Url = "https://www.nps.gov/places/fox-hollow-trailhead.htm",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "950",
            },
        ];
        double expectedLimit = 0;
        double expectedStart = 0;
        double expectedTotal = 0;

        Assert.NotNull(model.Data);
        Assert.Equal(expectedData.Count, model.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], model.Data[i]);
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedStart, model.Start);
        Assert.Equal(expectedTotal, model.Total);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PlaceListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "770F90DA-DE86-4C87-8F65-00369A398BC9",
                            Amenities =
                            [
                                "\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\"",
                            ],
                            AudioDescription = "audioDescription",
                            BodyText = "bodyText",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            IsManagedByNps = "1",
                            IsOpenToPublic = "1",
                            Latitude = "38.871843",
                            LatLong = "38.871843,-78.203699",
                            ListingDescription = "listingDescription",
                            Longitude = "-78.203699",
                            ManagedByOrg = "",
                            ManagedByUrl = "",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                },
                            ],
                            NpmapID = "npmapId",
                            QuickFacts = "",
                            RelatedOrganizations = ["string"],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Shenandoah National Park",
                                    Name = "Shenandoah",
                                    ParkCode = "shen",
                                    States = "VA",
                                    Url = "https://www.nps.gov/shen/index.htm",
                                },
                            ],
                            Tags = ["string"],
                            Title = "title",
                            Url = "https://www.nps.gov/places/fox-hollow-trailhead.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "950",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PlaceListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PlaceListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "770F90DA-DE86-4C87-8F65-00369A398BC9",
                            Amenities =
                            [
                                "\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\"",
                            ],
                            AudioDescription = "audioDescription",
                            BodyText = "bodyText",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            IsManagedByNps = "1",
                            IsOpenToPublic = "1",
                            Latitude = "38.871843",
                            LatLong = "38.871843,-78.203699",
                            ListingDescription = "listingDescription",
                            Longitude = "-78.203699",
                            ManagedByOrg = "",
                            ManagedByUrl = "",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                },
                            ],
                            NpmapID = "npmapId",
                            QuickFacts = "",
                            RelatedOrganizations = ["string"],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Shenandoah National Park",
                                    Name = "Shenandoah",
                                    ParkCode = "shen",
                                    States = "VA",
                                    Url = "https://www.nps.gov/shen/index.htm",
                                },
                            ],
                            Tags = ["string"],
                            Title = "title",
                            Url = "https://www.nps.gov/places/fox-hollow-trailhead.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "950",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PlaceListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<PlaceListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "770F90DA-DE86-4C87-8F65-00369A398BC9",
                        Amenities = ["\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\""],
                        AudioDescription = "audioDescription",
                        BodyText = "bodyText",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images = ["string"],
                        IsManagedByNps = "1",
                        IsOpenToPublic = "1",
                        Latitude = "38.871843",
                        LatLong = "38.871843,-78.203699",
                        ListingDescription = "listingDescription",
                        Longitude = "-78.203699",
                        ManagedByOrg = "",
                        ManagedByUrl = "",
                        Multimedia =
                        [
                            new()
                            {
                                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                Title = "The Worthington Farm",
                                Type = "multimedia/videos",
                                Url =
                                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                            },
                        ],
                        NpmapID = "npmapId",
                        QuickFacts = "",
                        RelatedOrganizations = ["string"],
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park",
                                FullName = "Shenandoah National Park",
                                Name = "Shenandoah",
                                ParkCode = "shen",
                                States = "VA",
                                Url = "https://www.nps.gov/shen/index.htm",
                            },
                        ],
                        Tags = ["string"],
                        Title = "title",
                        Url = "https://www.nps.gov/places/fox-hollow-trailhead.htm",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "950",
            },
        ];
        double expectedLimit = 0;
        double expectedStart = 0;
        double expectedTotal = 0;

        Assert.NotNull(deserialized.Data);
        Assert.Equal(expectedData.Count, deserialized.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], deserialized.Data[i]);
        }
        Assert.Equal(expectedLimit, deserialized.Limit);
        Assert.Equal(expectedStart, deserialized.Start);
        Assert.Equal(expectedTotal, deserialized.Total);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PlaceListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "770F90DA-DE86-4C87-8F65-00369A398BC9",
                            Amenities =
                            [
                                "\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\"",
                            ],
                            AudioDescription = "audioDescription",
                            BodyText = "bodyText",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            IsManagedByNps = "1",
                            IsOpenToPublic = "1",
                            Latitude = "38.871843",
                            LatLong = "38.871843,-78.203699",
                            ListingDescription = "listingDescription",
                            Longitude = "-78.203699",
                            ManagedByOrg = "",
                            ManagedByUrl = "",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                },
                            ],
                            NpmapID = "npmapId",
                            QuickFacts = "",
                            RelatedOrganizations = ["string"],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Shenandoah National Park",
                                    Name = "Shenandoah",
                                    ParkCode = "shen",
                                    States = "VA",
                                    Url = "https://www.nps.gov/shen/index.htm",
                                },
                            ],
                            Tags = ["string"],
                            Title = "title",
                            Url = "https://www.nps.gov/places/fox-hollow-trailhead.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "950",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PlaceListPageResponse { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Start);
        Assert.False(model.RawData.ContainsKey("start"));
        Assert.Null(model.Total);
        Assert.False(model.RawData.ContainsKey("total"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PlaceListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PlaceListPageResponse
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Start);
        Assert.False(model.RawData.ContainsKey("start"));
        Assert.Null(model.Total);
        Assert.False(model.RawData.ContainsKey("total"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PlaceListPageResponse
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        model.Validate();
    }
}
