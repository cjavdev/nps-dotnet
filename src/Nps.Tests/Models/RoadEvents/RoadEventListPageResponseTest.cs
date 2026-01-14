using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.RoadEvents;

namespace Nps.Tests.Models.RoadEvents;

public class RoadEventListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RoadEventListPageResponse
        {
            Data =
            [
                new()
                {
                    Features =
                    [
                        new()
                        {
                            ID = "13a5ed88-e452-440f-8daf-98707ed728b5",
                            Geometry = new()
                            {
                                Coordinates =
                                [
                                    [0],
                                ],
                                Type = "LineString",
                            },
                            Properties = new()
                            {
                                CoreDetails = new()
                                {
                                    DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                    Description =
                                        "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
                                    Direction = "unknown",
                                    EventType = "work-zone",
                                    Name = "Glacier Point Road Construction Closure",
                                    RoadNames = ["Glacier Point Road"],
                                },
                                EndDate = "2023-07-15T01:00:00Z",
                                IsEndDateVerified = false,
                                IsEndPositionVerified = false,
                                IsStartDateVerified = false,
                                IsStartPositionVerified = false,
                                LocationMethod = "unknown",
                                StartDate = "2023-06-30T23:04:00Z",
                                TypesOfWork = [new() { TypeName = "painting" }],
                                VehicleImpact = "all-lanes-closed",
                            },
                            Type = "Feature",
                        },
                    ],
                    RoadEventFeedInfo = new()
                    {
                        ID = "6ba84a20-3be7-4df0-81eb-711eccf84f18",
                        ContactEmail = "asknps@nps.gov",
                        ContactName = "National Park Service",
                        DataSources =
                        [
                            new()
                            {
                                ContactEmail = "YOSE_Superintendent@nps.gov",
                                ContactName = "Yosemite National Park",
                                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                OrganizationName = "Yosemite National Park",
                                UpdateDate = "2023-07-09T11:07:22.389219Z",
                            },
                        ],
                        License = "https://creativecommons.org/publicdomain/zero/1.0/",
                        Publisher = "National Park Service",
                        UpdateDate = "2023-04-28T06:37:22.497618Z",
                        UpdateFrequency = 60,
                        Version = "4.1",
                    },
                    Type = "FeatureCollection",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<RoadEventListResponse> expectedData =
        [
            new()
            {
                Features =
                [
                    new()
                    {
                        ID = "13a5ed88-e452-440f-8daf-98707ed728b5",
                        Geometry = new()
                        {
                            Coordinates =
                            [
                                [0],
                            ],
                            Type = "LineString",
                        },
                        Properties = new()
                        {
                            CoreDetails = new()
                            {
                                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                Description =
                                    "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
                                Direction = "unknown",
                                EventType = "work-zone",
                                Name = "Glacier Point Road Construction Closure",
                                RoadNames = ["Glacier Point Road"],
                            },
                            EndDate = "2023-07-15T01:00:00Z",
                            IsEndDateVerified = false,
                            IsEndPositionVerified = false,
                            IsStartDateVerified = false,
                            IsStartPositionVerified = false,
                            LocationMethod = "unknown",
                            StartDate = "2023-06-30T23:04:00Z",
                            TypesOfWork = [new() { TypeName = "painting" }],
                            VehicleImpact = "all-lanes-closed",
                        },
                        Type = "Feature",
                    },
                ],
                RoadEventFeedInfo = new()
                {
                    ID = "6ba84a20-3be7-4df0-81eb-711eccf84f18",
                    ContactEmail = "asknps@nps.gov",
                    ContactName = "National Park Service",
                    DataSources =
                    [
                        new()
                        {
                            ContactEmail = "YOSE_Superintendent@nps.gov",
                            ContactName = "Yosemite National Park",
                            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                            OrganizationName = "Yosemite National Park",
                            UpdateDate = "2023-07-09T11:07:22.389219Z",
                        },
                    ],
                    License = "https://creativecommons.org/publicdomain/zero/1.0/",
                    Publisher = "National Park Service",
                    UpdateDate = "2023-04-28T06:37:22.497618Z",
                    UpdateFrequency = 60,
                    Version = "4.1",
                },
                Type = "FeatureCollection",
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
        var model = new RoadEventListPageResponse
        {
            Data =
            [
                new()
                {
                    Features =
                    [
                        new()
                        {
                            ID = "13a5ed88-e452-440f-8daf-98707ed728b5",
                            Geometry = new()
                            {
                                Coordinates =
                                [
                                    [0],
                                ],
                                Type = "LineString",
                            },
                            Properties = new()
                            {
                                CoreDetails = new()
                                {
                                    DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                    Description =
                                        "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
                                    Direction = "unknown",
                                    EventType = "work-zone",
                                    Name = "Glacier Point Road Construction Closure",
                                    RoadNames = ["Glacier Point Road"],
                                },
                                EndDate = "2023-07-15T01:00:00Z",
                                IsEndDateVerified = false,
                                IsEndPositionVerified = false,
                                IsStartDateVerified = false,
                                IsStartPositionVerified = false,
                                LocationMethod = "unknown",
                                StartDate = "2023-06-30T23:04:00Z",
                                TypesOfWork = [new() { TypeName = "painting" }],
                                VehicleImpact = "all-lanes-closed",
                            },
                            Type = "Feature",
                        },
                    ],
                    RoadEventFeedInfo = new()
                    {
                        ID = "6ba84a20-3be7-4df0-81eb-711eccf84f18",
                        ContactEmail = "asknps@nps.gov",
                        ContactName = "National Park Service",
                        DataSources =
                        [
                            new()
                            {
                                ContactEmail = "YOSE_Superintendent@nps.gov",
                                ContactName = "Yosemite National Park",
                                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                OrganizationName = "Yosemite National Park",
                                UpdateDate = "2023-07-09T11:07:22.389219Z",
                            },
                        ],
                        License = "https://creativecommons.org/publicdomain/zero/1.0/",
                        Publisher = "National Park Service",
                        UpdateDate = "2023-04-28T06:37:22.497618Z",
                        UpdateFrequency = 60,
                        Version = "4.1",
                    },
                    Type = "FeatureCollection",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RoadEventListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RoadEventListPageResponse
        {
            Data =
            [
                new()
                {
                    Features =
                    [
                        new()
                        {
                            ID = "13a5ed88-e452-440f-8daf-98707ed728b5",
                            Geometry = new()
                            {
                                Coordinates =
                                [
                                    [0],
                                ],
                                Type = "LineString",
                            },
                            Properties = new()
                            {
                                CoreDetails = new()
                                {
                                    DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                    Description =
                                        "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
                                    Direction = "unknown",
                                    EventType = "work-zone",
                                    Name = "Glacier Point Road Construction Closure",
                                    RoadNames = ["Glacier Point Road"],
                                },
                                EndDate = "2023-07-15T01:00:00Z",
                                IsEndDateVerified = false,
                                IsEndPositionVerified = false,
                                IsStartDateVerified = false,
                                IsStartPositionVerified = false,
                                LocationMethod = "unknown",
                                StartDate = "2023-06-30T23:04:00Z",
                                TypesOfWork = [new() { TypeName = "painting" }],
                                VehicleImpact = "all-lanes-closed",
                            },
                            Type = "Feature",
                        },
                    ],
                    RoadEventFeedInfo = new()
                    {
                        ID = "6ba84a20-3be7-4df0-81eb-711eccf84f18",
                        ContactEmail = "asknps@nps.gov",
                        ContactName = "National Park Service",
                        DataSources =
                        [
                            new()
                            {
                                ContactEmail = "YOSE_Superintendent@nps.gov",
                                ContactName = "Yosemite National Park",
                                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                OrganizationName = "Yosemite National Park",
                                UpdateDate = "2023-07-09T11:07:22.389219Z",
                            },
                        ],
                        License = "https://creativecommons.org/publicdomain/zero/1.0/",
                        Publisher = "National Park Service",
                        UpdateDate = "2023-04-28T06:37:22.497618Z",
                        UpdateFrequency = 60,
                        Version = "4.1",
                    },
                    Type = "FeatureCollection",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RoadEventListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<RoadEventListResponse> expectedData =
        [
            new()
            {
                Features =
                [
                    new()
                    {
                        ID = "13a5ed88-e452-440f-8daf-98707ed728b5",
                        Geometry = new()
                        {
                            Coordinates =
                            [
                                [0],
                            ],
                            Type = "LineString",
                        },
                        Properties = new()
                        {
                            CoreDetails = new()
                            {
                                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                Description =
                                    "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
                                Direction = "unknown",
                                EventType = "work-zone",
                                Name = "Glacier Point Road Construction Closure",
                                RoadNames = ["Glacier Point Road"],
                            },
                            EndDate = "2023-07-15T01:00:00Z",
                            IsEndDateVerified = false,
                            IsEndPositionVerified = false,
                            IsStartDateVerified = false,
                            IsStartPositionVerified = false,
                            LocationMethod = "unknown",
                            StartDate = "2023-06-30T23:04:00Z",
                            TypesOfWork = [new() { TypeName = "painting" }],
                            VehicleImpact = "all-lanes-closed",
                        },
                        Type = "Feature",
                    },
                ],
                RoadEventFeedInfo = new()
                {
                    ID = "6ba84a20-3be7-4df0-81eb-711eccf84f18",
                    ContactEmail = "asknps@nps.gov",
                    ContactName = "National Park Service",
                    DataSources =
                    [
                        new()
                        {
                            ContactEmail = "YOSE_Superintendent@nps.gov",
                            ContactName = "Yosemite National Park",
                            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                            OrganizationName = "Yosemite National Park",
                            UpdateDate = "2023-07-09T11:07:22.389219Z",
                        },
                    ],
                    License = "https://creativecommons.org/publicdomain/zero/1.0/",
                    Publisher = "National Park Service",
                    UpdateDate = "2023-04-28T06:37:22.497618Z",
                    UpdateFrequency = 60,
                    Version = "4.1",
                },
                Type = "FeatureCollection",
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
        var model = new RoadEventListPageResponse
        {
            Data =
            [
                new()
                {
                    Features =
                    [
                        new()
                        {
                            ID = "13a5ed88-e452-440f-8daf-98707ed728b5",
                            Geometry = new()
                            {
                                Coordinates =
                                [
                                    [0],
                                ],
                                Type = "LineString",
                            },
                            Properties = new()
                            {
                                CoreDetails = new()
                                {
                                    DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                    Description =
                                        "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
                                    Direction = "unknown",
                                    EventType = "work-zone",
                                    Name = "Glacier Point Road Construction Closure",
                                    RoadNames = ["Glacier Point Road"],
                                },
                                EndDate = "2023-07-15T01:00:00Z",
                                IsEndDateVerified = false,
                                IsEndPositionVerified = false,
                                IsStartDateVerified = false,
                                IsStartPositionVerified = false,
                                LocationMethod = "unknown",
                                StartDate = "2023-06-30T23:04:00Z",
                                TypesOfWork = [new() { TypeName = "painting" }],
                                VehicleImpact = "all-lanes-closed",
                            },
                            Type = "Feature",
                        },
                    ],
                    RoadEventFeedInfo = new()
                    {
                        ID = "6ba84a20-3be7-4df0-81eb-711eccf84f18",
                        ContactEmail = "asknps@nps.gov",
                        ContactName = "National Park Service",
                        DataSources =
                        [
                            new()
                            {
                                ContactEmail = "YOSE_Superintendent@nps.gov",
                                ContactName = "Yosemite National Park",
                                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                                OrganizationName = "Yosemite National Park",
                                UpdateDate = "2023-07-09T11:07:22.389219Z",
                            },
                        ],
                        License = "https://creativecommons.org/publicdomain/zero/1.0/",
                        Publisher = "National Park Service",
                        UpdateDate = "2023-04-28T06:37:22.497618Z",
                        UpdateFrequency = 60,
                        Version = "4.1",
                    },
                    Type = "FeatureCollection",
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
        var model = new RoadEventListPageResponse { };

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
        var model = new RoadEventListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RoadEventListPageResponse
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
        var model = new RoadEventListPageResponse
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
