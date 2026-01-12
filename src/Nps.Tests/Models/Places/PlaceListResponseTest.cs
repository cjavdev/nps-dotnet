using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Places;

namespace Nps.Tests.Models.Places;

public class PlaceListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PlaceListResponse
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
        };

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "950";

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
        var model = new PlaceListResponse
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PlaceListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PlaceListResponse
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PlaceListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "950";

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
        var model = new PlaceListResponse
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PlaceListResponse { };

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
        var model = new PlaceListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PlaceListResponse
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
        var model = new PlaceListResponse
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

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Data
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
        };

        string expectedID = "770F90DA-DE86-4C87-8F65-00369A398BC9";
        List<string> expectedAmenities =
        [
            "\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\"",
        ];
        string expectedAudioDescription = "audioDescription";
        string expectedBodyText = "bodyText";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<string> expectedImages = ["string"];
        string expectedIsManagedByNps = "1";
        string expectedIsOpenToPublic = "1";
        string expectedLatitude = "38.871843";
        string expectedLatLong = "38.871843,-78.203699";
        string expectedListingDescription = "listingDescription";
        string expectedLongitude = "-78.203699";
        string expectedManagedByOrg = "";
        string expectedManagedByUrl = "";
        List<DataMultimedia> expectedMultimedia =
        [
            new()
            {
                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                Title = "The Worthington Farm",
                Type = "multimedia/videos",
                Url =
                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            },
        ];
        string expectedNpmapID = "npmapId";
        string expectedQuickFacts = "";
        List<string> expectedRelatedOrganizations = ["string"];
        List<RelatedPark> expectedRelatedParks =
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
        ];
        List<string> expectedTags = ["string"];
        string expectedTitle = "title";
        string expectedUrl = "https://www.nps.gov/places/fox-hollow-trailhead.htm";

        Assert.Equal(expectedID, model.ID);
        Assert.NotNull(model.Amenities);
        Assert.Equal(expectedAmenities.Count, model.Amenities.Count);
        for (int i = 0; i < expectedAmenities.Count; i++)
        {
            Assert.Equal(expectedAmenities[i], model.Amenities[i]);
        }
        Assert.Equal(expectedAudioDescription, model.AudioDescription);
        Assert.Equal(expectedBodyText, model.BodyText);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedIsManagedByNps, model.IsManagedByNps);
        Assert.Equal(expectedIsOpenToPublic, model.IsOpenToPublic);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLatLong, model.LatLong);
        Assert.Equal(expectedListingDescription, model.ListingDescription);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedManagedByOrg, model.ManagedByOrg);
        Assert.Equal(expectedManagedByUrl, model.ManagedByUrl);
        Assert.NotNull(model.Multimedia);
        Assert.Equal(expectedMultimedia.Count, model.Multimedia.Count);
        for (int i = 0; i < expectedMultimedia.Count; i++)
        {
            Assert.Equal(expectedMultimedia[i], model.Multimedia[i]);
        }
        Assert.Equal(expectedNpmapID, model.NpmapID);
        Assert.Equal(expectedQuickFacts, model.QuickFacts);
        Assert.NotNull(model.RelatedOrganizations);
        Assert.Equal(expectedRelatedOrganizations.Count, model.RelatedOrganizations.Count);
        for (int i = 0; i < expectedRelatedOrganizations.Count; i++)
        {
            Assert.Equal(expectedRelatedOrganizations[i], model.RelatedOrganizations[i]);
        }
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.NotNull(model.Tags);
        Assert.Equal(expectedTags.Count, model.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], model.Tags[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        string expectedID = "770F90DA-DE86-4C87-8F65-00369A398BC9";
        List<string> expectedAmenities =
        [
            "\"Beach/Water Access\", \"ORV Access\", \"Parking - Auto\"",
        ];
        string expectedAudioDescription = "audioDescription";
        string expectedBodyText = "bodyText";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<string> expectedImages = ["string"];
        string expectedIsManagedByNps = "1";
        string expectedIsOpenToPublic = "1";
        string expectedLatitude = "38.871843";
        string expectedLatLong = "38.871843,-78.203699";
        string expectedListingDescription = "listingDescription";
        string expectedLongitude = "-78.203699";
        string expectedManagedByOrg = "";
        string expectedManagedByUrl = "";
        List<DataMultimedia> expectedMultimedia =
        [
            new()
            {
                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                Title = "The Worthington Farm",
                Type = "multimedia/videos",
                Url =
                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            },
        ];
        string expectedNpmapID = "npmapId";
        string expectedQuickFacts = "";
        List<string> expectedRelatedOrganizations = ["string"];
        List<RelatedPark> expectedRelatedParks =
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
        ];
        List<string> expectedTags = ["string"];
        string expectedTitle = "title";
        string expectedUrl = "https://www.nps.gov/places/fox-hollow-trailhead.htm";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.NotNull(deserialized.Amenities);
        Assert.Equal(expectedAmenities.Count, deserialized.Amenities.Count);
        for (int i = 0; i < expectedAmenities.Count; i++)
        {
            Assert.Equal(expectedAmenities[i], deserialized.Amenities[i]);
        }
        Assert.Equal(expectedAudioDescription, deserialized.AudioDescription);
        Assert.Equal(expectedBodyText, deserialized.BodyText);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedIsManagedByNps, deserialized.IsManagedByNps);
        Assert.Equal(expectedIsOpenToPublic, deserialized.IsOpenToPublic);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLatLong, deserialized.LatLong);
        Assert.Equal(expectedListingDescription, deserialized.ListingDescription);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedManagedByOrg, deserialized.ManagedByOrg);
        Assert.Equal(expectedManagedByUrl, deserialized.ManagedByUrl);
        Assert.NotNull(deserialized.Multimedia);
        Assert.Equal(expectedMultimedia.Count, deserialized.Multimedia.Count);
        for (int i = 0; i < expectedMultimedia.Count; i++)
        {
            Assert.Equal(expectedMultimedia[i], deserialized.Multimedia[i]);
        }
        Assert.Equal(expectedNpmapID, deserialized.NpmapID);
        Assert.Equal(expectedQuickFacts, deserialized.QuickFacts);
        Assert.NotNull(deserialized.RelatedOrganizations);
        Assert.Equal(expectedRelatedOrganizations.Count, deserialized.RelatedOrganizations.Count);
        for (int i = 0; i < expectedRelatedOrganizations.Count; i++)
        {
            Assert.Equal(expectedRelatedOrganizations[i], deserialized.RelatedOrganizations[i]);
        }
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.NotNull(deserialized.Tags);
        Assert.Equal(expectedTags.Count, deserialized.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], deserialized.Tags[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Amenities);
        Assert.False(model.RawData.ContainsKey("amenities"));
        Assert.Null(model.AudioDescription);
        Assert.False(model.RawData.ContainsKey("audioDescription"));
        Assert.Null(model.BodyText);
        Assert.False(model.RawData.ContainsKey("bodyText"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsManagedByNps);
        Assert.False(model.RawData.ContainsKey("isManagedByNps"));
        Assert.Null(model.IsOpenToPublic);
        Assert.False(model.RawData.ContainsKey("isOpenToPublic"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.ListingDescription);
        Assert.False(model.RawData.ContainsKey("listingDescription"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.ManagedByOrg);
        Assert.False(model.RawData.ContainsKey("managedByOrg"));
        Assert.Null(model.ManagedByUrl);
        Assert.False(model.RawData.ContainsKey("managedByUrl"));
        Assert.Null(model.Multimedia);
        Assert.False(model.RawData.ContainsKey("multimedia"));
        Assert.Null(model.NpmapID);
        Assert.False(model.RawData.ContainsKey("npmapId"));
        Assert.Null(model.QuickFacts);
        Assert.False(model.RawData.ContainsKey("quickFacts"));
        Assert.Null(model.RelatedOrganizations);
        Assert.False(model.RawData.ContainsKey("relatedOrganizations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Amenities = null,
            AudioDescription = null,
            BodyText = null,
            GeometryPoiID = null,
            Images = null,
            IsManagedByNps = null,
            IsOpenToPublic = null,
            Latitude = null,
            LatLong = null,
            ListingDescription = null,
            Longitude = null,
            ManagedByOrg = null,
            ManagedByUrl = null,
            Multimedia = null,
            NpmapID = null,
            QuickFacts = null,
            RelatedOrganizations = null,
            RelatedParks = null,
            Tags = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Amenities);
        Assert.False(model.RawData.ContainsKey("amenities"));
        Assert.Null(model.AudioDescription);
        Assert.False(model.RawData.ContainsKey("audioDescription"));
        Assert.Null(model.BodyText);
        Assert.False(model.RawData.ContainsKey("bodyText"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsManagedByNps);
        Assert.False(model.RawData.ContainsKey("isManagedByNps"));
        Assert.Null(model.IsOpenToPublic);
        Assert.False(model.RawData.ContainsKey("isOpenToPublic"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.ListingDescription);
        Assert.False(model.RawData.ContainsKey("listingDescription"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.ManagedByOrg);
        Assert.False(model.RawData.ContainsKey("managedByOrg"));
        Assert.Null(model.ManagedByUrl);
        Assert.False(model.RawData.ContainsKey("managedByUrl"));
        Assert.Null(model.Multimedia);
        Assert.False(model.RawData.ContainsKey("multimedia"));
        Assert.Null(model.NpmapID);
        Assert.False(model.RawData.ContainsKey("npmapId"));
        Assert.Null(model.QuickFacts);
        Assert.False(model.RawData.ContainsKey("quickFacts"));
        Assert.Null(model.RelatedOrganizations);
        Assert.False(model.RawData.ContainsKey("relatedOrganizations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Amenities = null,
            AudioDescription = null,
            BodyText = null,
            GeometryPoiID = null,
            Images = null,
            IsManagedByNps = null,
            IsOpenToPublic = null,
            Latitude = null,
            LatLong = null,
            ListingDescription = null,
            Longitude = null,
            ManagedByOrg = null,
            ManagedByUrl = null,
            Multimedia = null,
            NpmapID = null,
            QuickFacts = null,
            RelatedOrganizations = null,
            RelatedParks = null,
            Tags = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class DataMultimediaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        string expectedID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883";
        string expectedTitle = "The Worthington Farm";
        string expectedType = "multimedia/videos";
        string expectedUrl =
            "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataMultimedia>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataMultimedia>(element);
        Assert.NotNull(deserialized);

        string expectedID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883";
        string expectedTitle = "The Worthington Farm";
        string expectedType = "multimedia/videos";
        string expectedUrl =
            "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataMultimedia { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataMultimedia { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataMultimedia
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Title = null,
            Type = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataMultimedia
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Title = null,
            Type = null,
            Url = null,
        };

        model.Validate();
    }
}

public class RelatedParkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            FullName = "Shenandoah National Park",
            Name = "Shenandoah",
            ParkCode = "shen",
            States = "VA",
            Url = "https://www.nps.gov/shen/index.htm",
        };

        string expectedDesignation = "National Park";
        string expectedFullName = "Shenandoah National Park";
        string expectedName = "Shenandoah";
        string expectedParkCode = "shen";
        string expectedStates = "VA";
        string expectedUrl = "https://www.nps.gov/shen/index.htm";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedStates, model.States);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            FullName = "Shenandoah National Park",
            Name = "Shenandoah",
            ParkCode = "shen",
            States = "VA",
            Url = "https://www.nps.gov/shen/index.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            FullName = "Shenandoah National Park",
            Name = "Shenandoah",
            ParkCode = "shen",
            States = "VA",
            Url = "https://www.nps.gov/shen/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park";
        string expectedFullName = "Shenandoah National Park";
        string expectedName = "Shenandoah";
        string expectedParkCode = "shen";
        string expectedStates = "VA";
        string expectedUrl = "https://www.nps.gov/shen/index.htm";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedStates, deserialized.States);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            FullName = "Shenandoah National Park",
            Name = "Shenandoah",
            ParkCode = "shen",
            States = "VA",
            Url = "https://www.nps.gov/shen/index.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RelatedPark { };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new RelatedPark { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RelatedPark
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            States = null,
            Url = null,
        };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RelatedPark
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            States = null,
            Url = null,
        };

        model.Validate();
    }
}
