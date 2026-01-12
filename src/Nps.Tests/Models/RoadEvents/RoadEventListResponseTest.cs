using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.RoadEvents;

namespace Nps.Tests.Models.RoadEvents;

public class RoadEventListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RoadEventListResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<Data> expectedData =
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
        string expectedLimit = "limit";
        string expectedStart = "start";
        string expectedTotal = "total";

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
        var model = new RoadEventListResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RoadEventListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RoadEventListResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RoadEventListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
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
        string expectedLimit = "limit";
        string expectedStart = "start";
        string expectedTotal = "total";

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
        var model = new RoadEventListResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RoadEventListResponse { };

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
        var model = new RoadEventListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RoadEventListResponse
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
        var model = new RoadEventListResponse
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
        };

        List<Feature> expectedFeatures =
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
        ];
        RoadEventFeedInfo expectedRoadEventFeedInfo = new()
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
        };
        string expectedType = "FeatureCollection";

        Assert.NotNull(model.Features);
        Assert.Equal(expectedFeatures.Count, model.Features.Count);
        for (int i = 0; i < expectedFeatures.Count; i++)
        {
            Assert.Equal(expectedFeatures[i], model.Features[i]);
        }
        Assert.Equal(expectedRoadEventFeedInfo, model.RoadEventFeedInfo);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        List<Feature> expectedFeatures =
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
        ];
        RoadEventFeedInfo expectedRoadEventFeedInfo = new()
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
        };
        string expectedType = "FeatureCollection";

        Assert.NotNull(deserialized.Features);
        Assert.Equal(expectedFeatures.Count, deserialized.Features.Count);
        for (int i = 0; i < expectedFeatures.Count; i++)
        {
            Assert.Equal(expectedFeatures[i], deserialized.Features[i]);
        }
        Assert.Equal(expectedRoadEventFeedInfo, deserialized.RoadEventFeedInfo);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.Features);
        Assert.False(model.RawData.ContainsKey("features"));
        Assert.Null(model.RoadEventFeedInfo);
        Assert.False(model.RawData.ContainsKey("road_event_feed_info"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
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
            Features = null,
            RoadEventFeedInfo = null,
            Type = null,
        };

        Assert.Null(model.Features);
        Assert.False(model.RawData.ContainsKey("features"));
        Assert.Null(model.RoadEventFeedInfo);
        Assert.False(model.RawData.ContainsKey("road_event_feed_info"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            Features = null,
            RoadEventFeedInfo = null,
            Type = null,
        };

        model.Validate();
    }
}

public class FeatureTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Feature
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
        };

        string expectedID = "13a5ed88-e452-440f-8daf-98707ed728b5";
        Geometry expectedGeometry = new()
        {
            Coordinates =
            [
                [0],
            ],
            Type = "LineString",
        };
        Properties expectedProperties = new()
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
        };
        string expectedType = "Feature";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedGeometry, model.Geometry);
        Assert.Equal(expectedProperties, model.Properties);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Feature
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Feature>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Feature
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Feature>(element);
        Assert.NotNull(deserialized);

        string expectedID = "13a5ed88-e452-440f-8daf-98707ed728b5";
        Geometry expectedGeometry = new()
        {
            Coordinates =
            [
                [0],
            ],
            Type = "LineString",
        };
        Properties expectedProperties = new()
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
        };
        string expectedType = "Feature";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedGeometry, deserialized.Geometry);
        Assert.Equal(expectedProperties, deserialized.Properties);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Feature
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Feature { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Geometry);
        Assert.False(model.RawData.ContainsKey("geometry"));
        Assert.Null(model.Properties);
        Assert.False(model.RawData.ContainsKey("properties"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Feature { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Feature
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Geometry = null,
            Properties = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Geometry);
        Assert.False(model.RawData.ContainsKey("geometry"));
        Assert.Null(model.Properties);
        Assert.False(model.RawData.ContainsKey("properties"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Feature
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Geometry = null,
            Properties = null,
            Type = null,
        };

        model.Validate();
    }
}

public class GeometryTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Geometry
        {
            Coordinates =
            [
                [0],
            ],
            Type = "LineString",
        };

        List<List<double>> expectedCoordinates =
        [
            [0],
        ];
        string expectedType = "LineString";

        Assert.NotNull(model.Coordinates);
        Assert.Equal(expectedCoordinates.Count, model.Coordinates.Count);
        for (int i = 0; i < expectedCoordinates.Count; i++)
        {
            Assert.Equal(expectedCoordinates[i].Count, model.Coordinates[i].Count);
            for (int i1 = 0; i1 < expectedCoordinates[i].Count; i1++)
            {
                Assert.Equal(expectedCoordinates[i][i1], model.Coordinates[i][i1]);
            }
        }
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Geometry
        {
            Coordinates =
            [
                [0],
            ],
            Type = "LineString",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Geometry>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Geometry
        {
            Coordinates =
            [
                [0],
            ],
            Type = "LineString",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Geometry>(element);
        Assert.NotNull(deserialized);

        List<List<double>> expectedCoordinates =
        [
            [0],
        ];
        string expectedType = "LineString";

        Assert.NotNull(deserialized.Coordinates);
        Assert.Equal(expectedCoordinates.Count, deserialized.Coordinates.Count);
        for (int i = 0; i < expectedCoordinates.Count; i++)
        {
            Assert.Equal(expectedCoordinates[i].Count, deserialized.Coordinates[i].Count);
            for (int i1 = 0; i1 < expectedCoordinates[i].Count; i1++)
            {
                Assert.Equal(expectedCoordinates[i][i1], deserialized.Coordinates[i][i1]);
            }
        }
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Geometry
        {
            Coordinates =
            [
                [0],
            ],
            Type = "LineString",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Geometry { };

        Assert.Null(model.Coordinates);
        Assert.False(model.RawData.ContainsKey("coordinates"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Geometry { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Geometry
        {
            // Null should be interpreted as omitted for these properties
            Coordinates = null,
            Type = null,
        };

        Assert.Null(model.Coordinates);
        Assert.False(model.RawData.ContainsKey("coordinates"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Geometry
        {
            // Null should be interpreted as omitted for these properties
            Coordinates = null,
            Type = null,
        };

        model.Validate();
    }
}

public class PropertiesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Properties
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
        };

        CoreDetails expectedCoreDetails = new()
        {
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            Description =
                "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
            Direction = "unknown",
            EventType = "work-zone",
            Name = "Glacier Point Road Construction Closure",
            RoadNames = ["Glacier Point Road"],
        };
        string expectedEndDate = "2023-07-15T01:00:00Z";
        bool expectedIsEndDateVerified = false;
        bool expectedIsEndPositionVerified = false;
        bool expectedIsStartDateVerified = false;
        bool expectedIsStartPositionVerified = false;
        string expectedLocationMethod = "unknown";
        string expectedStartDate = "2023-06-30T23:04:00Z";
        List<TypesOfWork> expectedTypesOfWork = [new() { TypeName = "painting" }];
        string expectedVehicleImpact = "all-lanes-closed";

        Assert.Equal(expectedCoreDetails, model.CoreDetails);
        Assert.Equal(expectedEndDate, model.EndDate);
        Assert.Equal(expectedIsEndDateVerified, model.IsEndDateVerified);
        Assert.Equal(expectedIsEndPositionVerified, model.IsEndPositionVerified);
        Assert.Equal(expectedIsStartDateVerified, model.IsStartDateVerified);
        Assert.Equal(expectedIsStartPositionVerified, model.IsStartPositionVerified);
        Assert.Equal(expectedLocationMethod, model.LocationMethod);
        Assert.Equal(expectedStartDate, model.StartDate);
        Assert.NotNull(model.TypesOfWork);
        Assert.Equal(expectedTypesOfWork.Count, model.TypesOfWork.Count);
        for (int i = 0; i < expectedTypesOfWork.Count; i++)
        {
            Assert.Equal(expectedTypesOfWork[i], model.TypesOfWork[i]);
        }
        Assert.Equal(expectedVehicleImpact, model.VehicleImpact);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Properties
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Properties>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Properties
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Properties>(element);
        Assert.NotNull(deserialized);

        CoreDetails expectedCoreDetails = new()
        {
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            Description =
                "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
            Direction = "unknown",
            EventType = "work-zone",
            Name = "Glacier Point Road Construction Closure",
            RoadNames = ["Glacier Point Road"],
        };
        string expectedEndDate = "2023-07-15T01:00:00Z";
        bool expectedIsEndDateVerified = false;
        bool expectedIsEndPositionVerified = false;
        bool expectedIsStartDateVerified = false;
        bool expectedIsStartPositionVerified = false;
        string expectedLocationMethod = "unknown";
        string expectedStartDate = "2023-06-30T23:04:00Z";
        List<TypesOfWork> expectedTypesOfWork = [new() { TypeName = "painting" }];
        string expectedVehicleImpact = "all-lanes-closed";

        Assert.Equal(expectedCoreDetails, deserialized.CoreDetails);
        Assert.Equal(expectedEndDate, deserialized.EndDate);
        Assert.Equal(expectedIsEndDateVerified, deserialized.IsEndDateVerified);
        Assert.Equal(expectedIsEndPositionVerified, deserialized.IsEndPositionVerified);
        Assert.Equal(expectedIsStartDateVerified, deserialized.IsStartDateVerified);
        Assert.Equal(expectedIsStartPositionVerified, deserialized.IsStartPositionVerified);
        Assert.Equal(expectedLocationMethod, deserialized.LocationMethod);
        Assert.Equal(expectedStartDate, deserialized.StartDate);
        Assert.NotNull(deserialized.TypesOfWork);
        Assert.Equal(expectedTypesOfWork.Count, deserialized.TypesOfWork.Count);
        for (int i = 0; i < expectedTypesOfWork.Count; i++)
        {
            Assert.Equal(expectedTypesOfWork[i], deserialized.TypesOfWork[i]);
        }
        Assert.Equal(expectedVehicleImpact, deserialized.VehicleImpact);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Properties
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Properties { };

        Assert.Null(model.CoreDetails);
        Assert.False(model.RawData.ContainsKey("core_details"));
        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("end_date"));
        Assert.Null(model.IsEndDateVerified);
        Assert.False(model.RawData.ContainsKey("is_end_date_verified"));
        Assert.Null(model.IsEndPositionVerified);
        Assert.False(model.RawData.ContainsKey("is_end_position_verified"));
        Assert.Null(model.IsStartDateVerified);
        Assert.False(model.RawData.ContainsKey("is_start_date_verified"));
        Assert.Null(model.IsStartPositionVerified);
        Assert.False(model.RawData.ContainsKey("is_start_position_verified"));
        Assert.Null(model.LocationMethod);
        Assert.False(model.RawData.ContainsKey("location_method"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("start_date"));
        Assert.Null(model.TypesOfWork);
        Assert.False(model.RawData.ContainsKey("types_of_work"));
        Assert.Null(model.VehicleImpact);
        Assert.False(model.RawData.ContainsKey("vehicle_impact"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Properties { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Properties
        {
            // Null should be interpreted as omitted for these properties
            CoreDetails = null,
            EndDate = null,
            IsEndDateVerified = null,
            IsEndPositionVerified = null,
            IsStartDateVerified = null,
            IsStartPositionVerified = null,
            LocationMethod = null,
            StartDate = null,
            TypesOfWork = null,
            VehicleImpact = null,
        };

        Assert.Null(model.CoreDetails);
        Assert.False(model.RawData.ContainsKey("core_details"));
        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("end_date"));
        Assert.Null(model.IsEndDateVerified);
        Assert.False(model.RawData.ContainsKey("is_end_date_verified"));
        Assert.Null(model.IsEndPositionVerified);
        Assert.False(model.RawData.ContainsKey("is_end_position_verified"));
        Assert.Null(model.IsStartDateVerified);
        Assert.False(model.RawData.ContainsKey("is_start_date_verified"));
        Assert.Null(model.IsStartPositionVerified);
        Assert.False(model.RawData.ContainsKey("is_start_position_verified"));
        Assert.Null(model.LocationMethod);
        Assert.False(model.RawData.ContainsKey("location_method"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("start_date"));
        Assert.Null(model.TypesOfWork);
        Assert.False(model.RawData.ContainsKey("types_of_work"));
        Assert.Null(model.VehicleImpact);
        Assert.False(model.RawData.ContainsKey("vehicle_impact"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Properties
        {
            // Null should be interpreted as omitted for these properties
            CoreDetails = null,
            EndDate = null,
            IsEndDateVerified = null,
            IsEndPositionVerified = null,
            IsStartDateVerified = null,
            IsStartPositionVerified = null,
            LocationMethod = null,
            StartDate = null,
            TypesOfWork = null,
            VehicleImpact = null,
        };

        model.Validate();
    }
}

public class CoreDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CoreDetails
        {
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            Description =
                "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
            Direction = "unknown",
            EventType = "work-zone",
            Name = "Glacier Point Road Construction Closure",
            RoadNames = ["Glacier Point Road"],
        };

        string expectedDataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2";
        string expectedDescription =
            "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.";
        string expectedDirection = "unknown";
        string expectedEventType = "work-zone";
        string expectedName = "Glacier Point Road Construction Closure";
        List<string> expectedRoadNames = ["Glacier Point Road"];

        Assert.Equal(expectedDataSourceID, model.DataSourceID);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDirection, model.Direction);
        Assert.Equal(expectedEventType, model.EventType);
        Assert.Equal(expectedName, model.Name);
        Assert.NotNull(model.RoadNames);
        Assert.Equal(expectedRoadNames.Count, model.RoadNames.Count);
        for (int i = 0; i < expectedRoadNames.Count; i++)
        {
            Assert.Equal(expectedRoadNames[i], model.RoadNames[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CoreDetails
        {
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            Description =
                "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
            Direction = "unknown",
            EventType = "work-zone",
            Name = "Glacier Point Road Construction Closure",
            RoadNames = ["Glacier Point Road"],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CoreDetails>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CoreDetails
        {
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            Description =
                "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
            Direction = "unknown",
            EventType = "work-zone",
            Name = "Glacier Point Road Construction Closure",
            RoadNames = ["Glacier Point Road"],
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CoreDetails>(element);
        Assert.NotNull(deserialized);

        string expectedDataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2";
        string expectedDescription =
            "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.";
        string expectedDirection = "unknown";
        string expectedEventType = "work-zone";
        string expectedName = "Glacier Point Road Construction Closure";
        List<string> expectedRoadNames = ["Glacier Point Road"];

        Assert.Equal(expectedDataSourceID, deserialized.DataSourceID);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDirection, deserialized.Direction);
        Assert.Equal(expectedEventType, deserialized.EventType);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.NotNull(deserialized.RoadNames);
        Assert.Equal(expectedRoadNames.Count, deserialized.RoadNames.Count);
        for (int i = 0; i < expectedRoadNames.Count; i++)
        {
            Assert.Equal(expectedRoadNames[i], deserialized.RoadNames[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CoreDetails
        {
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            Description =
                "Glacier Point Road is closed from July 9 at 10 pm through July 14. The road will be open starting July 15, with 30-minute delays.",
            Direction = "unknown",
            EventType = "work-zone",
            Name = "Glacier Point Road Construction Closure",
            RoadNames = ["Glacier Point Road"],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CoreDetails { };

        Assert.Null(model.DataSourceID);
        Assert.False(model.RawData.ContainsKey("data_source_id"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Direction);
        Assert.False(model.RawData.ContainsKey("direction"));
        Assert.Null(model.EventType);
        Assert.False(model.RawData.ContainsKey("event_type"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.RoadNames);
        Assert.False(model.RawData.ContainsKey("road_names"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CoreDetails { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CoreDetails
        {
            // Null should be interpreted as omitted for these properties
            DataSourceID = null,
            Description = null,
            Direction = null,
            EventType = null,
            Name = null,
            RoadNames = null,
        };

        Assert.Null(model.DataSourceID);
        Assert.False(model.RawData.ContainsKey("data_source_id"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Direction);
        Assert.False(model.RawData.ContainsKey("direction"));
        Assert.Null(model.EventType);
        Assert.False(model.RawData.ContainsKey("event_type"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.RoadNames);
        Assert.False(model.RawData.ContainsKey("road_names"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CoreDetails
        {
            // Null should be interpreted as omitted for these properties
            DataSourceID = null,
            Description = null,
            Direction = null,
            EventType = null,
            Name = null,
            RoadNames = null,
        };

        model.Validate();
    }
}

public class TypesOfWorkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TypesOfWork { TypeName = "painting" };

        string expectedTypeName = "painting";

        Assert.Equal(expectedTypeName, model.TypeName);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TypesOfWork { TypeName = "painting" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TypesOfWork>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TypesOfWork { TypeName = "painting" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TypesOfWork>(element);
        Assert.NotNull(deserialized);

        string expectedTypeName = "painting";

        Assert.Equal(expectedTypeName, deserialized.TypeName);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TypesOfWork { TypeName = "painting" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TypesOfWork { };

        Assert.Null(model.TypeName);
        Assert.False(model.RawData.ContainsKey("type_name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TypesOfWork { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TypesOfWork
        {
            // Null should be interpreted as omitted for these properties
            TypeName = null,
        };

        Assert.Null(model.TypeName);
        Assert.False(model.RawData.ContainsKey("type_name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TypesOfWork
        {
            // Null should be interpreted as omitted for these properties
            TypeName = null,
        };

        model.Validate();
    }
}

public class RoadEventFeedInfoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RoadEventFeedInfo
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
        };

        string expectedID = "6ba84a20-3be7-4df0-81eb-711eccf84f18";
        string expectedContactEmail = "asknps@nps.gov";
        string expectedContactName = "National Park Service";
        List<DataSource> expectedDataSources =
        [
            new()
            {
                ContactEmail = "YOSE_Superintendent@nps.gov",
                ContactName = "Yosemite National Park",
                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                OrganizationName = "Yosemite National Park",
                UpdateDate = "2023-07-09T11:07:22.389219Z",
            },
        ];
        string expectedLicense = "https://creativecommons.org/publicdomain/zero/1.0/";
        string expectedPublisher = "National Park Service";
        string expectedUpdateDate = "2023-04-28T06:37:22.497618Z";
        double expectedUpdateFrequency = 60;
        string expectedVersion = "4.1";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedContactEmail, model.ContactEmail);
        Assert.Equal(expectedContactName, model.ContactName);
        Assert.NotNull(model.DataSources);
        Assert.Equal(expectedDataSources.Count, model.DataSources.Count);
        for (int i = 0; i < expectedDataSources.Count; i++)
        {
            Assert.Equal(expectedDataSources[i], model.DataSources[i]);
        }
        Assert.Equal(expectedLicense, model.License);
        Assert.Equal(expectedPublisher, model.Publisher);
        Assert.Equal(expectedUpdateDate, model.UpdateDate);
        Assert.Equal(expectedUpdateFrequency, model.UpdateFrequency);
        Assert.Equal(expectedVersion, model.Version);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RoadEventFeedInfo
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RoadEventFeedInfo>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RoadEventFeedInfo
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RoadEventFeedInfo>(element);
        Assert.NotNull(deserialized);

        string expectedID = "6ba84a20-3be7-4df0-81eb-711eccf84f18";
        string expectedContactEmail = "asknps@nps.gov";
        string expectedContactName = "National Park Service";
        List<DataSource> expectedDataSources =
        [
            new()
            {
                ContactEmail = "YOSE_Superintendent@nps.gov",
                ContactName = "Yosemite National Park",
                DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
                OrganizationName = "Yosemite National Park",
                UpdateDate = "2023-07-09T11:07:22.389219Z",
            },
        ];
        string expectedLicense = "https://creativecommons.org/publicdomain/zero/1.0/";
        string expectedPublisher = "National Park Service";
        string expectedUpdateDate = "2023-04-28T06:37:22.497618Z";
        double expectedUpdateFrequency = 60;
        string expectedVersion = "4.1";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedContactEmail, deserialized.ContactEmail);
        Assert.Equal(expectedContactName, deserialized.ContactName);
        Assert.NotNull(deserialized.DataSources);
        Assert.Equal(expectedDataSources.Count, deserialized.DataSources.Count);
        for (int i = 0; i < expectedDataSources.Count; i++)
        {
            Assert.Equal(expectedDataSources[i], deserialized.DataSources[i]);
        }
        Assert.Equal(expectedLicense, deserialized.License);
        Assert.Equal(expectedPublisher, deserialized.Publisher);
        Assert.Equal(expectedUpdateDate, deserialized.UpdateDate);
        Assert.Equal(expectedUpdateFrequency, deserialized.UpdateFrequency);
        Assert.Equal(expectedVersion, deserialized.Version);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RoadEventFeedInfo
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RoadEventFeedInfo { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.ContactEmail);
        Assert.False(model.RawData.ContainsKey("contact_email"));
        Assert.Null(model.ContactName);
        Assert.False(model.RawData.ContainsKey("contact_name"));
        Assert.Null(model.DataSources);
        Assert.False(model.RawData.ContainsKey("data_sources"));
        Assert.Null(model.License);
        Assert.False(model.RawData.ContainsKey("license"));
        Assert.Null(model.Publisher);
        Assert.False(model.RawData.ContainsKey("publisher"));
        Assert.Null(model.UpdateDate);
        Assert.False(model.RawData.ContainsKey("update_date"));
        Assert.Null(model.UpdateFrequency);
        Assert.False(model.RawData.ContainsKey("update_frequency"));
        Assert.Null(model.Version);
        Assert.False(model.RawData.ContainsKey("version"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new RoadEventFeedInfo { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RoadEventFeedInfo
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            ContactEmail = null,
            ContactName = null,
            DataSources = null,
            License = null,
            Publisher = null,
            UpdateDate = null,
            UpdateFrequency = null,
            Version = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.ContactEmail);
        Assert.False(model.RawData.ContainsKey("contact_email"));
        Assert.Null(model.ContactName);
        Assert.False(model.RawData.ContainsKey("contact_name"));
        Assert.Null(model.DataSources);
        Assert.False(model.RawData.ContainsKey("data_sources"));
        Assert.Null(model.License);
        Assert.False(model.RawData.ContainsKey("license"));
        Assert.Null(model.Publisher);
        Assert.False(model.RawData.ContainsKey("publisher"));
        Assert.Null(model.UpdateDate);
        Assert.False(model.RawData.ContainsKey("update_date"));
        Assert.Null(model.UpdateFrequency);
        Assert.False(model.RawData.ContainsKey("update_frequency"));
        Assert.Null(model.Version);
        Assert.False(model.RawData.ContainsKey("version"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RoadEventFeedInfo
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            ContactEmail = null,
            ContactName = null,
            DataSources = null,
            License = null,
            Publisher = null,
            UpdateDate = null,
            UpdateFrequency = null,
            Version = null,
        };

        model.Validate();
    }
}

public class DataSourceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataSource
        {
            ContactEmail = "YOSE_Superintendent@nps.gov",
            ContactName = "Yosemite National Park",
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            OrganizationName = "Yosemite National Park",
            UpdateDate = "2023-07-09T11:07:22.389219Z",
        };

        string expectedContactEmail = "YOSE_Superintendent@nps.gov";
        string expectedContactName = "Yosemite National Park";
        string expectedDataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2";
        string expectedOrganizationName = "Yosemite National Park";
        string expectedUpdateDate = "2023-07-09T11:07:22.389219Z";

        Assert.Equal(expectedContactEmail, model.ContactEmail);
        Assert.Equal(expectedContactName, model.ContactName);
        Assert.Equal(expectedDataSourceID, model.DataSourceID);
        Assert.Equal(expectedOrganizationName, model.OrganizationName);
        Assert.Equal(expectedUpdateDate, model.UpdateDate);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataSource
        {
            ContactEmail = "YOSE_Superintendent@nps.gov",
            ContactName = "Yosemite National Park",
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            OrganizationName = "Yosemite National Park",
            UpdateDate = "2023-07-09T11:07:22.389219Z",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataSource>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataSource
        {
            ContactEmail = "YOSE_Superintendent@nps.gov",
            ContactName = "Yosemite National Park",
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            OrganizationName = "Yosemite National Park",
            UpdateDate = "2023-07-09T11:07:22.389219Z",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataSource>(element);
        Assert.NotNull(deserialized);

        string expectedContactEmail = "YOSE_Superintendent@nps.gov";
        string expectedContactName = "Yosemite National Park";
        string expectedDataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2";
        string expectedOrganizationName = "Yosemite National Park";
        string expectedUpdateDate = "2023-07-09T11:07:22.389219Z";

        Assert.Equal(expectedContactEmail, deserialized.ContactEmail);
        Assert.Equal(expectedContactName, deserialized.ContactName);
        Assert.Equal(expectedDataSourceID, deserialized.DataSourceID);
        Assert.Equal(expectedOrganizationName, deserialized.OrganizationName);
        Assert.Equal(expectedUpdateDate, deserialized.UpdateDate);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataSource
        {
            ContactEmail = "YOSE_Superintendent@nps.gov",
            ContactName = "Yosemite National Park",
            DataSourceID = "16e33ae7-e71f-45ce-2e37-08d4c7ad36e2",
            OrganizationName = "Yosemite National Park",
            UpdateDate = "2023-07-09T11:07:22.389219Z",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataSource { };

        Assert.Null(model.ContactEmail);
        Assert.False(model.RawData.ContainsKey("contact_email"));
        Assert.Null(model.ContactName);
        Assert.False(model.RawData.ContainsKey("contact_name"));
        Assert.Null(model.DataSourceID);
        Assert.False(model.RawData.ContainsKey("data_source_id"));
        Assert.Null(model.OrganizationName);
        Assert.False(model.RawData.ContainsKey("organization_name"));
        Assert.Null(model.UpdateDate);
        Assert.False(model.RawData.ContainsKey("update_date"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataSource { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataSource
        {
            // Null should be interpreted as omitted for these properties
            ContactEmail = null,
            ContactName = null,
            DataSourceID = null,
            OrganizationName = null,
            UpdateDate = null,
        };

        Assert.Null(model.ContactEmail);
        Assert.False(model.RawData.ContainsKey("contact_email"));
        Assert.Null(model.ContactName);
        Assert.False(model.RawData.ContainsKey("contact_name"));
        Assert.Null(model.DataSourceID);
        Assert.False(model.RawData.ContainsKey("data_source_id"));
        Assert.Null(model.OrganizationName);
        Assert.False(model.RawData.ContainsKey("organization_name"));
        Assert.Null(model.UpdateDate);
        Assert.False(model.RawData.ContainsKey("update_date"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataSource
        {
            // Null should be interpreted as omitted for these properties
            ContactEmail = null,
            ContactName = null,
            DataSourceID = null,
            OrganizationName = null,
            UpdateDate = null,
        };

        model.Validate();
    }
}
