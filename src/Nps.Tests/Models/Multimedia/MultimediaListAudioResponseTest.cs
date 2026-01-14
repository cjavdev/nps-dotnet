using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Multimedia;

namespace Nps.Tests.Models.Multimedia;

public class MultimediaListAudioResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListAudioResponse
        {
            Data =
            [
                new()
                {
                    ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
                    CallToAction = "callToAction",
                    CallToActionUrl = "callToActionUrl",
                    Credit = "Behind the Scenery Podcast",
                    Description =
                        "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
                    DurationMs = 1263020,
                    GeometryPoiID = "geometryPoiId",
                    Latitude = 36.0566279811578,
                    Longitude = -112.143759727478,
                    PermalinkUrl =
                        "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            ParkCode = "grca",
                            States = "AZ",
                        },
                    ],
                    SplashImage = new()
                    {
                        Url =
                            "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
                    },
                    Tags = ["string"],
                    Title = "Theodore Roosevelt A Complicated Legacy",
                    Transcript = "transcript",
                    Versions = new()
                    {
                        FileSize = 50539839,
                        FileType = "audio/mp3",
                        Url =
                            "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
                    },
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "3427",
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
                CallToAction = "callToAction",
                CallToActionUrl = "callToActionUrl",
                Credit = "Behind the Scenery Podcast",
                Description =
                    "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
                DurationMs = 1263020,
                GeometryPoiID = "geometryPoiId",
                Latitude = 36.0566279811578,
                Longitude = -112.143759727478,
                PermalinkUrl =
                    "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National Park",
                        ParkCode = "grca",
                        States = "AZ",
                    },
                ],
                SplashImage = new()
                {
                    Url =
                        "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
                },
                Tags = ["string"],
                Title = "Theodore Roosevelt A Complicated Legacy",
                Transcript = "transcript",
                Versions = new()
                {
                    FileSize = 50539839,
                    FileType = "audio/mp3",
                    Url =
                        "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
                },
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "3427";

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
        var model = new MultimediaListAudioResponse
        {
            Data =
            [
                new()
                {
                    ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
                    CallToAction = "callToAction",
                    CallToActionUrl = "callToActionUrl",
                    Credit = "Behind the Scenery Podcast",
                    Description =
                        "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
                    DurationMs = 1263020,
                    GeometryPoiID = "geometryPoiId",
                    Latitude = 36.0566279811578,
                    Longitude = -112.143759727478,
                    PermalinkUrl =
                        "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            ParkCode = "grca",
                            States = "AZ",
                        },
                    ],
                    SplashImage = new()
                    {
                        Url =
                            "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
                    },
                    Tags = ["string"],
                    Title = "Theodore Roosevelt A Complicated Legacy",
                    Transcript = "transcript",
                    Versions = new()
                    {
                        FileSize = 50539839,
                        FileType = "audio/mp3",
                        Url =
                            "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
                    },
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "3427",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<MultimediaListAudioResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListAudioResponse
        {
            Data =
            [
                new()
                {
                    ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
                    CallToAction = "callToAction",
                    CallToActionUrl = "callToActionUrl",
                    Credit = "Behind the Scenery Podcast",
                    Description =
                        "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
                    DurationMs = 1263020,
                    GeometryPoiID = "geometryPoiId",
                    Latitude = 36.0566279811578,
                    Longitude = -112.143759727478,
                    PermalinkUrl =
                        "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            ParkCode = "grca",
                            States = "AZ",
                        },
                    ],
                    SplashImage = new()
                    {
                        Url =
                            "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
                    },
                    Tags = ["string"],
                    Title = "Theodore Roosevelt A Complicated Legacy",
                    Transcript = "transcript",
                    Versions = new()
                    {
                        FileSize = 50539839,
                        FileType = "audio/mp3",
                        Url =
                            "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
                    },
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "3427",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<MultimediaListAudioResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
                CallToAction = "callToAction",
                CallToActionUrl = "callToActionUrl",
                Credit = "Behind the Scenery Podcast",
                Description =
                    "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
                DurationMs = 1263020,
                GeometryPoiID = "geometryPoiId",
                Latitude = 36.0566279811578,
                Longitude = -112.143759727478,
                PermalinkUrl =
                    "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National Park",
                        ParkCode = "grca",
                        States = "AZ",
                    },
                ],
                SplashImage = new()
                {
                    Url =
                        "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
                },
                Tags = ["string"],
                Title = "Theodore Roosevelt A Complicated Legacy",
                Transcript = "transcript",
                Versions = new()
                {
                    FileSize = 50539839,
                    FileType = "audio/mp3",
                    Url =
                        "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
                },
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "3427";

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
        var model = new MultimediaListAudioResponse
        {
            Data =
            [
                new()
                {
                    ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
                    CallToAction = "callToAction",
                    CallToActionUrl = "callToActionUrl",
                    Credit = "Behind the Scenery Podcast",
                    Description =
                        "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
                    DurationMs = 1263020,
                    GeometryPoiID = "geometryPoiId",
                    Latitude = 36.0566279811578,
                    Longitude = -112.143759727478,
                    PermalinkUrl =
                        "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National Park",
                            ParkCode = "grca",
                            States = "AZ",
                        },
                    ],
                    SplashImage = new()
                    {
                        Url =
                            "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
                    },
                    Tags = ["string"],
                    Title = "Theodore Roosevelt A Complicated Legacy",
                    Transcript = "transcript",
                    Versions = new()
                    {
                        FileSize = 50539839,
                        FileType = "audio/mp3",
                        Url =
                            "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
                    },
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "3427",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new MultimediaListAudioResponse { };

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
        var model = new MultimediaListAudioResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListAudioResponse
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
        var model = new MultimediaListAudioResponse
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
            ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
            CallToAction = "callToAction",
            CallToActionUrl = "callToActionUrl",
            Credit = "Behind the Scenery Podcast",
            Description =
                "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
            DurationMs = 1263020,
            GeometryPoiID = "geometryPoiId",
            Latitude = 36.0566279811578,
            Longitude = -112.143759727478,
            PermalinkUrl =
                "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    ParkCode = "grca",
                    States = "AZ",
                },
            ],
            SplashImage = new()
            {
                Url =
                    "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
            },
            Tags = ["string"],
            Title = "Theodore Roosevelt A Complicated Legacy",
            Transcript = "transcript",
            Versions = new()
            {
                FileSize = 50539839,
                FileType = "audio/mp3",
                Url =
                    "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
            },
        };

        string expectedID = "6A437071-C23A-4754-ABBD-47027A1464E0";
        string expectedCallToAction = "callToAction";
        string expectedCallToActionUrl = "callToActionUrl";
        string expectedCredit = "Behind the Scenery Podcast";
        string expectedDescription =
            "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.";
        double expectedDurationMs = 1263020;
        string expectedGeometryPoiID = "geometryPoiId";
        double expectedLatitude = 36.0566279811578;
        double expectedLongitude = -112.143759727478;
        string expectedPermalinkUrl =
            "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0";
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National Park",
                ParkCode = "grca",
                States = "AZ",
            },
        ];
        SplashImage expectedSplashImage = new()
        {
            Url =
                "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
        };
        List<string> expectedTags = ["string"];
        string expectedTitle = "Theodore Roosevelt A Complicated Legacy";
        string expectedTranscript = "transcript";
        Versions expectedVersions = new()
        {
            FileSize = 50539839,
            FileType = "audio/mp3",
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
        };

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCallToAction, model.CallToAction);
        Assert.Equal(expectedCallToActionUrl, model.CallToActionUrl);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDurationMs, model.DurationMs);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedPermalinkUrl, model.PermalinkUrl);
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedSplashImage, model.SplashImage);
        Assert.NotNull(model.Tags);
        Assert.Equal(expectedTags.Count, model.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], model.Tags[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedTranscript, model.Transcript);
        Assert.Equal(expectedVersions, model.Versions);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
            CallToAction = "callToAction",
            CallToActionUrl = "callToActionUrl",
            Credit = "Behind the Scenery Podcast",
            Description =
                "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
            DurationMs = 1263020,
            GeometryPoiID = "geometryPoiId",
            Latitude = 36.0566279811578,
            Longitude = -112.143759727478,
            PermalinkUrl =
                "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    ParkCode = "grca",
                    States = "AZ",
                },
            ],
            SplashImage = new()
            {
                Url =
                    "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
            },
            Tags = ["string"],
            Title = "Theodore Roosevelt A Complicated Legacy",
            Transcript = "transcript",
            Versions = new()
            {
                FileSize = 50539839,
                FileType = "audio/mp3",
                Url =
                    "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
        {
            ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
            CallToAction = "callToAction",
            CallToActionUrl = "callToActionUrl",
            Credit = "Behind the Scenery Podcast",
            Description =
                "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
            DurationMs = 1263020,
            GeometryPoiID = "geometryPoiId",
            Latitude = 36.0566279811578,
            Longitude = -112.143759727478,
            PermalinkUrl =
                "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    ParkCode = "grca",
                    States = "AZ",
                },
            ],
            SplashImage = new()
            {
                Url =
                    "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
            },
            Tags = ["string"],
            Title = "Theodore Roosevelt A Complicated Legacy",
            Transcript = "transcript",
            Versions = new()
            {
                FileSize = 50539839,
                FileType = "audio/mp3",
                Url =
                    "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "6A437071-C23A-4754-ABBD-47027A1464E0";
        string expectedCallToAction = "callToAction";
        string expectedCallToActionUrl = "callToActionUrl";
        string expectedCredit = "Behind the Scenery Podcast";
        string expectedDescription =
            "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.";
        double expectedDurationMs = 1263020;
        string expectedGeometryPoiID = "geometryPoiId";
        double expectedLatitude = 36.0566279811578;
        double expectedLongitude = -112.143759727478;
        string expectedPermalinkUrl =
            "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0";
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National Park",
                ParkCode = "grca",
                States = "AZ",
            },
        ];
        SplashImage expectedSplashImage = new()
        {
            Url =
                "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
        };
        List<string> expectedTags = ["string"];
        string expectedTitle = "Theodore Roosevelt A Complicated Legacy";
        string expectedTranscript = "transcript";
        Versions expectedVersions = new()
        {
            FileSize = 50539839,
            FileType = "audio/mp3",
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
        };

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCallToAction, deserialized.CallToAction);
        Assert.Equal(expectedCallToActionUrl, deserialized.CallToActionUrl);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDurationMs, deserialized.DurationMs);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedPermalinkUrl, deserialized.PermalinkUrl);
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedSplashImage, deserialized.SplashImage);
        Assert.NotNull(deserialized.Tags);
        Assert.Equal(expectedTags.Count, deserialized.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], deserialized.Tags[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedTranscript, deserialized.Transcript);
        Assert.Equal(expectedVersions, deserialized.Versions);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "6A437071-C23A-4754-ABBD-47027A1464E0",
            CallToAction = "callToAction",
            CallToActionUrl = "callToActionUrl",
            Credit = "Behind the Scenery Podcast",
            Description =
                "No one is infallible, not our heroes, not our leaders, not even those who pioneered for the preservation of the natural world. President Theodore Roosevelt left a complex legacy. While he helped to create the National Park Service and set out to protect and preserve public lands, he excluded Indigenous voices. What would it be like to sit down and talk with Teddy today? —What would you ask him? In this episode, park visitors share how they respond to this multifaceted human and the legacy he left behind.",
            DurationMs = 1263020,
            GeometryPoiID = "geometryPoiId",
            Latitude = 36.0566279811578,
            Longitude = -112.143759727478,
            PermalinkUrl =
                "https://www.nps.gov/media/video/view.htm?id=6A437071-C23A-4754-ABBD-47027A1464E0",
            RelatedParks =
            [
                new()
                {
                    Designation = "National Park",
                    ParkCode = "grca",
                    States = "AZ",
                },
            ],
            SplashImage = new()
            {
                Url =
                    "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
            },
            Tags = ["string"],
            Title = "Theodore Roosevelt A Complicated Legacy",
            Transcript = "transcript",
            Versions = new()
            {
                FileSize = 50539839,
                FileType = "audio/mp3",
                Url =
                    "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.CallToAction);
        Assert.False(model.RawData.ContainsKey("callToAction"));
        Assert.Null(model.CallToActionUrl);
        Assert.False(model.RawData.ContainsKey("callToActionUrl"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DurationMs);
        Assert.False(model.RawData.ContainsKey("durationMs"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.PermalinkUrl);
        Assert.False(model.RawData.ContainsKey("permalinkUrl"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.SplashImage);
        Assert.False(model.RawData.ContainsKey("splashImage"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Transcript);
        Assert.False(model.RawData.ContainsKey("transcript"));
        Assert.Null(model.Versions);
        Assert.False(model.RawData.ContainsKey("versions"));
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
            CallToAction = null,
            CallToActionUrl = null,
            Credit = null,
            Description = null,
            DurationMs = null,
            GeometryPoiID = null,
            Latitude = null,
            Longitude = null,
            PermalinkUrl = null,
            RelatedParks = null,
            SplashImage = null,
            Tags = null,
            Title = null,
            Transcript = null,
            Versions = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.CallToAction);
        Assert.False(model.RawData.ContainsKey("callToAction"));
        Assert.Null(model.CallToActionUrl);
        Assert.False(model.RawData.ContainsKey("callToActionUrl"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DurationMs);
        Assert.False(model.RawData.ContainsKey("durationMs"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.PermalinkUrl);
        Assert.False(model.RawData.ContainsKey("permalinkUrl"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.SplashImage);
        Assert.False(model.RawData.ContainsKey("splashImage"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Transcript);
        Assert.False(model.RawData.ContainsKey("transcript"));
        Assert.Null(model.Versions);
        Assert.False(model.RawData.ContainsKey("versions"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            CallToAction = null,
            CallToActionUrl = null,
            Credit = null,
            Description = null,
            DurationMs = null,
            GeometryPoiID = null,
            Latitude = null,
            Longitude = null,
            PermalinkUrl = null,
            RelatedParks = null,
            SplashImage = null,
            Tags = null,
            Title = null,
            Transcript = null,
            Versions = null,
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
            ParkCode = "grca",
            States = "AZ",
        };

        string expectedDesignation = "National Park";
        string expectedParkCode = "grca";
        string expectedStates = "AZ";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedStates, model.States);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            ParkCode = "grca",
            States = "AZ",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            ParkCode = "grca",
            States = "AZ",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park";
        string expectedParkCode = "grca";
        string expectedStates = "AZ";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedStates, deserialized.States);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Park",
            ParkCode = "grca",
            States = "AZ",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RelatedPark { };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
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
            ParkCode = null,
            States = null,
        };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RelatedPark
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            ParkCode = null,
            States = null,
        };

        model.Validate();
    }
}

public class SplashImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SplashImage
        {
            Url =
                "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
        };

        string expectedUrl =
            "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg";

        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new SplashImage
        {
            Url =
                "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SplashImage>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new SplashImage
        {
            Url =
                "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SplashImage>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedUrl =
            "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg";

        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new SplashImage
        {
            Url =
                "https://www.nps.gov/common/uploads/ser/park/carl//896018B2-B099-D284-F1497C6FEA15018B/896018B2-B099-D284-F1497C6FEA15018B-large.jpg",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new SplashImage { };

        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new SplashImage { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new SplashImage
        {
            // Null should be interpreted as omitted for these properties
            Url = null,
        };

        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new SplashImage
        {
            // Null should be interpreted as omitted for these properties
            Url = null,
        };

        model.Validate();
    }
}

public class VersionsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Versions
        {
            FileSize = 50539839,
            FileType = "audio/mp3",
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
        };

        double expectedFileSize = 50539839;
        string expectedFileType = "audio/mp3";
        string expectedUrl =
            "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3";

        Assert.Equal(expectedFileSize, model.FileSize);
        Assert.Equal(expectedFileType, model.FileType);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Versions
        {
            FileSize = 50539839,
            FileType = "audio/mp3",
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Versions>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Versions
        {
            FileSize = 50539839,
            FileType = "audio/mp3",
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Versions>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        double expectedFileSize = 50539839;
        string expectedFileType = "audio/mp3";
        string expectedUrl =
            "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3";

        Assert.Equal(expectedFileSize, deserialized.FileSize);
        Assert.Equal(expectedFileType, deserialized.FileType);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Versions
        {
            FileSize = 50539839,
            FileType = "audio/mp3",
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/754f468d-0777-4647-b64b-d59c2c7803bd.mp3",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Versions { };

        Assert.Null(model.FileSize);
        Assert.False(model.RawData.ContainsKey("fileSize"));
        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Versions { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Versions
        {
            // Null should be interpreted as omitted for these properties
            FileSize = null,
            FileType = null,
            Url = null,
        };

        Assert.Null(model.FileSize);
        Assert.False(model.RawData.ContainsKey("fileSize"));
        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Versions
        {
            // Null should be interpreted as omitted for these properties
            FileSize = null,
            FileType = null,
            Url = null,
        };

        model.Validate();
    }
}
