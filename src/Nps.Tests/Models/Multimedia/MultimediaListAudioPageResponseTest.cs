using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Multimedia;

namespace Nps.Tests.Models.Multimedia;

public class MultimediaListAudioPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListAudioPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<MultimediaListAudioResponse> expectedData =
        [
            new()
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
        var model = new MultimediaListAudioPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListAudioPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListAudioPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListAudioPageResponse>(element);
        Assert.NotNull(deserialized);

        List<MultimediaListAudioResponse> expectedData =
        [
            new()
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
        var model = new MultimediaListAudioPageResponse
        {
            Data =
            [
                new()
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
        var model = new MultimediaListAudioPageResponse { };

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
        var model = new MultimediaListAudioPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListAudioPageResponse
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
        var model = new MultimediaListAudioPageResponse
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
