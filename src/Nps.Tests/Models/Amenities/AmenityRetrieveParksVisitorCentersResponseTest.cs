using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Amenities;

namespace Nps.Tests.Models.Amenities;

public class AmenityRetrieveParksVisitorCentersResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponse
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

        List<AmenityRetrieveParksVisitorCentersResponseData> expectedData =
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
        var model = new AmenityRetrieveParksVisitorCentersResponse
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponse>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponse
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

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponse>(
            element
        );
        Assert.NotNull(deserialized);

        List<AmenityRetrieveParksVisitorCentersResponseData> expectedData =
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
        var model = new AmenityRetrieveParksVisitorCentersResponse
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
        var model = new AmenityRetrieveParksVisitorCentersResponse { };

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
        var model = new AmenityRetrieveParksVisitorCentersResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponse
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
        var model = new AmenityRetrieveParksVisitorCentersResponse
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

public class AmenityRetrieveParksVisitorCentersResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseData
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
                                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                },
                            ],
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "53",
        };

        List<AmenityRetrieveParksVisitorCentersResponseDataData> expectedData =
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
                                Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                            },
                        ],
                    },
                ],
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "53";

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
        var model = new AmenityRetrieveParksVisitorCentersResponseData
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
                                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                },
                            ],
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "53",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponseData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseData
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
                                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                },
                            ],
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "53",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponseData>(element);
        Assert.NotNull(deserialized);

        List<AmenityRetrieveParksVisitorCentersResponseDataData> expectedData =
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
                                Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                            },
                        ],
                    },
                ],
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "53";

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
        var model = new AmenityRetrieveParksVisitorCentersResponseData
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
                                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                                },
                            ],
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "53",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseData { };

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
        var model = new AmenityRetrieveParksVisitorCentersResponseData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseData
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
        var model = new AmenityRetrieveParksVisitorCentersResponseData
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

public class AmenityRetrieveParksVisitorCentersResponseDataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData
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
                            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                        },
                    ],
                },
            ],
        };

        string expectedID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F";
        string expectedName = "Accessibility - Accessible Restroom";
        List<AmenityRetrieveParksVisitorCentersResponseDataDataPark> expectedParks =
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
                        Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                    },
                ],
            },
        ];

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
        Assert.NotNull(model.Parks);
        Assert.Equal(expectedParks.Count, model.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], model.Parks[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData
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
                            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                        },
                    ],
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponseDataData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData
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
                            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                        },
                    ],
                },
            ],
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponseDataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F";
        string expectedName = "Accessibility - Accessible Restroom";
        List<AmenityRetrieveParksVisitorCentersResponseDataDataPark> expectedParks =
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
                        Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                    },
                ],
            },
        ];

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.NotNull(deserialized.Parks);
        Assert.Equal(expectedParks.Count, deserialized.Parks.Count);
        for (int i = 0; i < expectedParks.Count; i++)
        {
            Assert.Equal(expectedParks[i], deserialized.Parks[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData
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
                            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                        },
                    ],
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Parks = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Parks);
        Assert.False(model.RawData.ContainsKey("parks"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Parks = null,
        };

        model.Validate();
    }
}

public class AmenityRetrieveParksVisitorCentersResponseDataDataParkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark
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
                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                },
            ],
        };

        string expectedDesignation = "National Memorial";
        string expectedFullName = "";
        string expectedName = "Mount Rushmore";
        string expectedParkCode = "moru";
        string expectedStates = "SD";
        string expectedUrl = "https://www.nps.gov/moru/index.htm";
        List<Visitorcenter> expectedVisitorcenters =
        [
            new()
            {
                ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                Name = "Lincoln Borglum Visitor Center",
                Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
            },
        ];

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedStates, model.States);
        Assert.Equal(expectedUrl, model.Url);
        Assert.NotNull(model.Visitorcenters);
        Assert.Equal(expectedVisitorcenters.Count, model.Visitorcenters.Count);
        for (int i = 0; i < expectedVisitorcenters.Count; i++)
        {
            Assert.Equal(expectedVisitorcenters[i], model.Visitorcenters[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark
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
                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponseDataDataPark>(
                json
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark
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
                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                },
            ],
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AmenityRetrieveParksVisitorCentersResponseDataDataPark>(
                element
            );
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Memorial";
        string expectedFullName = "";
        string expectedName = "Mount Rushmore";
        string expectedParkCode = "moru";
        string expectedStates = "SD";
        string expectedUrl = "https://www.nps.gov/moru/index.htm";
        List<Visitorcenter> expectedVisitorcenters =
        [
            new()
            {
                ID = "AB856735-B829-4053-8BB2-9A27BC193084",
                Name = "Lincoln Borglum Visitor Center",
                Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
            },
        ];

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedStates, deserialized.States);
        Assert.Equal(expectedUrl, deserialized.Url);
        Assert.NotNull(deserialized.Visitorcenters);
        Assert.Equal(expectedVisitorcenters.Count, deserialized.Visitorcenters.Count);
        for (int i = 0; i < expectedVisitorcenters.Count; i++)
        {
            Assert.Equal(expectedVisitorcenters[i], deserialized.Visitorcenters[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark
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
                    Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark { };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("Name"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.Visitorcenters);
        Assert.False(model.RawData.ContainsKey("visitorcenters"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            States = null,
            Url = null,
            Visitorcenters = null,
        };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("Name"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.Visitorcenters);
        Assert.False(model.RawData.ContainsKey("visitorcenters"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AmenityRetrieveParksVisitorCentersResponseDataDataPark
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            States = null,
            Url = null,
            Visitorcenters = null,
        };

        model.Validate();
    }
}

public class VisitorcenterTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Visitorcenter
        {
            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
            Name = "Lincoln Borglum Visitor Center",
            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
        };

        string expectedID = "AB856735-B829-4053-8BB2-9A27BC193084";
        string expectedName = "Lincoln Borglum Visitor Center";
        string expectedUrl = "https://www.nps.gov/moru/planyourvisit/placestogo.htm";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Visitorcenter
        {
            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
            Name = "Lincoln Borglum Visitor Center",
            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Visitorcenter>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Visitorcenter
        {
            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
            Name = "Lincoln Borglum Visitor Center",
            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Visitorcenter>(element);
        Assert.NotNull(deserialized);

        string expectedID = "AB856735-B829-4053-8BB2-9A27BC193084";
        string expectedName = "Lincoln Borglum Visitor Center";
        string expectedUrl = "https://www.nps.gov/moru/planyourvisit/placestogo.htm";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Visitorcenter
        {
            ID = "AB856735-B829-4053-8BB2-9A27BC193084",
            Name = "Lincoln Borglum Visitor Center",
            Url = "https://www.nps.gov/moru/planyourvisit/placestogo.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Visitorcenter { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Visitorcenter { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Visitorcenter
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Visitorcenter
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Url = null,
        };

        model.Validate();
    }
}
