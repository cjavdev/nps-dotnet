using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Amenities;

namespace Nps.Tests.Models.Amenities;

public class AmenityListParksVisitorCentersPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityListParksVisitorCentersPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                            Name = "Accessibility - Accessible Restroom",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Memorial",
                                    FullName = "",
                                    Name = "Mount Rushmore",
                                    ParkCode = "moru",
                                    States = "SD",
                                    Url = "https://www.nps.gov/moru/index.htm",
                                    Visitorcenters =
                                    [
                                        new()
                                        {
                                            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                                            Name = "Lincoln Borglum Visitor Center",
                                            Url =
                                                "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<AmenityListParksVisitorCentersResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                        Name = "Accessibility - Accessible Restroom",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Memorial",
                                FullName = "",
                                Name = "Mount Rushmore",
                                ParkCode = "moru",
                                States = "SD",
                                Url = "https://www.nps.gov/moru/index.htm",
                                Visitorcenters =
                                [
                                    new()
                                    {
                                        ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                                        Name = "Lincoln Borglum Visitor Center",
                                        Url =
                                            "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                    },
                                ],
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "53",
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
        var model = new AmenityListParksVisitorCentersPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                            Name = "Accessibility - Accessible Restroom",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Memorial",
                                    FullName = "",
                                    Name = "Mount Rushmore",
                                    ParkCode = "moru",
                                    States = "SD",
                                    Url = "https://www.nps.gov/moru/index.htm",
                                    Visitorcenters =
                                    [
                                        new()
                                        {
                                            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                                            Name = "Lincoln Borglum Visitor Center",
                                            Url =
                                                "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AmenityListParksVisitorCentersPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityListParksVisitorCentersPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                            Name = "Accessibility - Accessible Restroom",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Memorial",
                                    FullName = "",
                                    Name = "Mount Rushmore",
                                    ParkCode = "moru",
                                    States = "SD",
                                    Url = "https://www.nps.gov/moru/index.htm",
                                    Visitorcenters =
                                    [
                                        new()
                                        {
                                            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                                            Name = "Lincoln Borglum Visitor Center",
                                            Url =
                                                "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AmenityListParksVisitorCentersPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<AmenityListParksVisitorCentersResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                        Name = "Accessibility - Accessible Restroom",
                        Parks =
                        [
                            new()
                            {
                                Designation = "National Memorial",
                                FullName = "",
                                Name = "Mount Rushmore",
                                ParkCode = "moru",
                                States = "SD",
                                Url = "https://www.nps.gov/moru/index.htm",
                                Visitorcenters =
                                [
                                    new()
                                    {
                                        ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                                        Name = "Lincoln Borglum Visitor Center",
                                        Url =
                                            "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                    },
                                ],
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "53",
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
        var model = new AmenityListParksVisitorCentersPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                            Name = "Accessibility - Accessible Restroom",
                            Parks =
                            [
                                new()
                                {
                                    Designation = "National Memorial",
                                    FullName = "",
                                    Name = "Mount Rushmore",
                                    ParkCode = "moru",
                                    States = "SD",
                                    Url = "https://www.nps.gov/moru/index.htm",
                                    Visitorcenters =
                                    [
                                        new()
                                        {
                                            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                                            Name = "Lincoln Borglum Visitor Center",
                                            Url =
                                                "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
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
        var model = new AmenityListParksVisitorCentersPageResponse { };

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
        var model = new AmenityListParksVisitorCentersPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityListParksVisitorCentersPageResponse
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
        var model = new AmenityListParksVisitorCentersPageResponse
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
