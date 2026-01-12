using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Amenities;

namespace Nps.Tests.Models.Amenities;

public class AmenityRetrieveParksPlacesResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponse
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
                                    Designation = "Parkway",
                                    FullName = "Blue Ridge Parkway",
                                    Name = "Blue Ridge",
                                    ParkCode = "blri",
                                    Places =
                                    [
                                        new()
                                        {
                                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                            Title = "Mabry Mill",
                                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                                        },
                                    ],
                                    States = "NC,VA",
                                    Url = "https://www.nps.gov/blri/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
                },
            ],
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<AmenityRetrieveParksPlacesResponseData> expectedData =
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
                                Designation = "Parkway",
                                FullName = "Blue Ridge Parkway",
                                Name = "Blue Ridge",
                                ParkCode = "blri",
                                Places =
                                [
                                    new()
                                    {
                                        ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                        Title = "Mabry Mill",
                                        Url = "https://www.nps.gov/places/mabry-mill.htm",
                                    },
                                ],
                                States = "NC,VA",
                                Url = "https://www.nps.gov/blri/index.htm",
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "53",
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
        var model = new AmenityRetrieveParksPlacesResponse
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
                                    Designation = "Parkway",
                                    FullName = "Blue Ridge Parkway",
                                    Name = "Blue Ridge",
                                    ParkCode = "blri",
                                    Places =
                                    [
                                        new()
                                        {
                                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                            Title = "Mabry Mill",
                                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                                        },
                                    ],
                                    States = "NC,VA",
                                    Url = "https://www.nps.gov/blri/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
                },
            ],
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksPlacesResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponse
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
                                    Designation = "Parkway",
                                    FullName = "Blue Ridge Parkway",
                                    Name = "Blue Ridge",
                                    ParkCode = "blri",
                                    Places =
                                    [
                                        new()
                                        {
                                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                            Title = "Mabry Mill",
                                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                                        },
                                    ],
                                    States = "NC,VA",
                                    Url = "https://www.nps.gov/blri/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
                },
            ],
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksPlacesResponse>(element);
        Assert.NotNull(deserialized);

        List<AmenityRetrieveParksPlacesResponseData> expectedData =
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
                                Designation = "Parkway",
                                FullName = "Blue Ridge Parkway",
                                Name = "Blue Ridge",
                                ParkCode = "blri",
                                Places =
                                [
                                    new()
                                    {
                                        ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                        Title = "Mabry Mill",
                                        Url = "https://www.nps.gov/places/mabry-mill.htm",
                                    },
                                ],
                                States = "NC,VA",
                                Url = "https://www.nps.gov/blri/index.htm",
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "53",
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
        var model = new AmenityRetrieveParksPlacesResponse
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
                                    Designation = "Parkway",
                                    FullName = "Blue Ridge Parkway",
                                    Name = "Blue Ridge",
                                    ParkCode = "blri",
                                    Places =
                                    [
                                        new()
                                        {
                                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                            Title = "Mabry Mill",
                                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                                        },
                                    ],
                                    States = "NC,VA",
                                    Url = "https://www.nps.gov/blri/index.htm",
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "53",
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
        var model = new AmenityRetrieveParksPlacesResponse { };

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
        var model = new AmenityRetrieveParksPlacesResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponse
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
        var model = new AmenityRetrieveParksPlacesResponse
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

public class AmenityRetrieveParksPlacesResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponseData
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
                            Designation = "Parkway",
                            FullName = "Blue Ridge Parkway",
                            Name = "Blue Ridge",
                            ParkCode = "blri",
                            Places =
                            [
                                new()
                                {
                                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                    Title = "Mabry Mill",
                                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                                },
                            ],
                            States = "NC,VA",
                            Url = "https://www.nps.gov/blri/index.htm",
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "53",
        };

        List<AmenityRetrieveParksPlacesResponseDataData> expectedData =
        [
            new()
            {
                ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                Name = "Accessibility - Accessible Restroom",
                Parks =
                [
                    new()
                    {
                        Designation = "Parkway",
                        FullName = "Blue Ridge Parkway",
                        Name = "Blue Ridge",
                        ParkCode = "blri",
                        Places =
                        [
                            new()
                            {
                                ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                Title = "Mabry Mill",
                                Url = "https://www.nps.gov/places/mabry-mill.htm",
                            },
                        ],
                        States = "NC,VA",
                        Url = "https://www.nps.gov/blri/index.htm",
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
        var model = new AmenityRetrieveParksPlacesResponseData
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
                            Designation = "Parkway",
                            FullName = "Blue Ridge Parkway",
                            Name = "Blue Ridge",
                            ParkCode = "blri",
                            Places =
                            [
                                new()
                                {
                                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                    Title = "Mabry Mill",
                                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                                },
                            ],
                            States = "NC,VA",
                            Url = "https://www.nps.gov/blri/index.htm",
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "53",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksPlacesResponseData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponseData
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
                            Designation = "Parkway",
                            FullName = "Blue Ridge Parkway",
                            Name = "Blue Ridge",
                            ParkCode = "blri",
                            Places =
                            [
                                new()
                                {
                                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                    Title = "Mabry Mill",
                                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                                },
                            ],
                            States = "NC,VA",
                            Url = "https://www.nps.gov/blri/index.htm",
                        },
                    ],
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "53",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksPlacesResponseData>(
            element
        );
        Assert.NotNull(deserialized);

        List<AmenityRetrieveParksPlacesResponseDataData> expectedData =
        [
            new()
            {
                ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
                Name = "Accessibility - Accessible Restroom",
                Parks =
                [
                    new()
                    {
                        Designation = "Parkway",
                        FullName = "Blue Ridge Parkway",
                        Name = "Blue Ridge",
                        ParkCode = "blri",
                        Places =
                        [
                            new()
                            {
                                ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                Title = "Mabry Mill",
                                Url = "https://www.nps.gov/places/mabry-mill.htm",
                            },
                        ],
                        States = "NC,VA",
                        Url = "https://www.nps.gov/blri/index.htm",
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
        var model = new AmenityRetrieveParksPlacesResponseData
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
                            Designation = "Parkway",
                            FullName = "Blue Ridge Parkway",
                            Name = "Blue Ridge",
                            ParkCode = "blri",
                            Places =
                            [
                                new()
                                {
                                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                                    Title = "Mabry Mill",
                                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                                },
                            ],
                            States = "NC,VA",
                            Url = "https://www.nps.gov/blri/index.htm",
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
        var model = new AmenityRetrieveParksPlacesResponseData { };

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
        var model = new AmenityRetrieveParksPlacesResponseData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponseData
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
        var model = new AmenityRetrieveParksPlacesResponseData
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

public class AmenityRetrieveParksPlacesResponseDataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponseDataData
        {
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
            Parks =
            [
                new()
                {
                    Designation = "Parkway",
                    FullName = "Blue Ridge Parkway",
                    Name = "Blue Ridge",
                    ParkCode = "blri",
                    Places =
                    [
                        new()
                        {
                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                            Title = "Mabry Mill",
                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                        },
                    ],
                    States = "NC,VA",
                    Url = "https://www.nps.gov/blri/index.htm",
                },
            ],
        };

        string expectedID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F";
        string expectedName = "Accessibility - Accessible Restroom";
        List<Park> expectedParks =
        [
            new()
            {
                Designation = "Parkway",
                FullName = "Blue Ridge Parkway",
                Name = "Blue Ridge",
                ParkCode = "blri",
                Places =
                [
                    new()
                    {
                        ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                        Title = "Mabry Mill",
                        Url = "https://www.nps.gov/places/mabry-mill.htm",
                    },
                ],
                States = "NC,VA",
                Url = "https://www.nps.gov/blri/index.htm",
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
        var model = new AmenityRetrieveParksPlacesResponseDataData
        {
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
            Parks =
            [
                new()
                {
                    Designation = "Parkway",
                    FullName = "Blue Ridge Parkway",
                    Name = "Blue Ridge",
                    ParkCode = "blri",
                    Places =
                    [
                        new()
                        {
                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                            Title = "Mabry Mill",
                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                        },
                    ],
                    States = "NC,VA",
                    Url = "https://www.nps.gov/blri/index.htm",
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksPlacesResponseDataData>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponseDataData
        {
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
            Parks =
            [
                new()
                {
                    Designation = "Parkway",
                    FullName = "Blue Ridge Parkway",
                    Name = "Blue Ridge",
                    ParkCode = "blri",
                    Places =
                    [
                        new()
                        {
                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                            Title = "Mabry Mill",
                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                        },
                    ],
                    States = "NC,VA",
                    Url = "https://www.nps.gov/blri/index.htm",
                },
            ],
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AmenityRetrieveParksPlacesResponseDataData>(
            element
        );
        Assert.NotNull(deserialized);

        string expectedID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F";
        string expectedName = "Accessibility - Accessible Restroom";
        List<Park> expectedParks =
        [
            new()
            {
                Designation = "Parkway",
                FullName = "Blue Ridge Parkway",
                Name = "Blue Ridge",
                ParkCode = "blri",
                Places =
                [
                    new()
                    {
                        ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                        Title = "Mabry Mill",
                        Url = "https://www.nps.gov/places/mabry-mill.htm",
                    },
                ],
                States = "NC,VA",
                Url = "https://www.nps.gov/blri/index.htm",
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
        var model = new AmenityRetrieveParksPlacesResponseDataData
        {
            ID = "75F2DA2A-1741-445A-9FA7-B63A81E4BD7F",
            Name = "Accessibility - Accessible Restroom",
            Parks =
            [
                new()
                {
                    Designation = "Parkway",
                    FullName = "Blue Ridge Parkway",
                    Name = "Blue Ridge",
                    ParkCode = "blri",
                    Places =
                    [
                        new()
                        {
                            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                            Title = "Mabry Mill",
                            Url = "https://www.nps.gov/places/mabry-mill.htm",
                        },
                    ],
                    States = "NC,VA",
                    Url = "https://www.nps.gov/blri/index.htm",
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponseDataData { };

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
        var model = new AmenityRetrieveParksPlacesResponseDataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AmenityRetrieveParksPlacesResponseDataData
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
        var model = new AmenityRetrieveParksPlacesResponseDataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Parks = null,
        };

        model.Validate();
    }
}

public class ParkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Park
        {
            Designation = "Parkway",
            FullName = "Blue Ridge Parkway",
            Name = "Blue Ridge",
            ParkCode = "blri",
            Places =
            [
                new()
                {
                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                    Title = "Mabry Mill",
                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                },
            ],
            States = "NC,VA",
            Url = "https://www.nps.gov/blri/index.htm",
        };

        string expectedDesignation = "Parkway";
        string expectedFullName = "Blue Ridge Parkway";
        string expectedName = "Blue Ridge";
        string expectedParkCode = "blri";
        List<Place> expectedPlaces =
        [
            new()
            {
                ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                Title = "Mabry Mill",
                Url = "https://www.nps.gov/places/mabry-mill.htm",
            },
        ];
        string expectedStates = "NC,VA";
        string expectedUrl = "https://www.nps.gov/blri/index.htm";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.NotNull(model.Places);
        Assert.Equal(expectedPlaces.Count, model.Places.Count);
        for (int i = 0; i < expectedPlaces.Count; i++)
        {
            Assert.Equal(expectedPlaces[i], model.Places[i]);
        }
        Assert.Equal(expectedStates, model.States);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Park
        {
            Designation = "Parkway",
            FullName = "Blue Ridge Parkway",
            Name = "Blue Ridge",
            ParkCode = "blri",
            Places =
            [
                new()
                {
                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                    Title = "Mabry Mill",
                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                },
            ],
            States = "NC,VA",
            Url = "https://www.nps.gov/blri/index.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Park>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Park
        {
            Designation = "Parkway",
            FullName = "Blue Ridge Parkway",
            Name = "Blue Ridge",
            ParkCode = "blri",
            Places =
            [
                new()
                {
                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                    Title = "Mabry Mill",
                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                },
            ],
            States = "NC,VA",
            Url = "https://www.nps.gov/blri/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Park>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "Parkway";
        string expectedFullName = "Blue Ridge Parkway";
        string expectedName = "Blue Ridge";
        string expectedParkCode = "blri";
        List<Place> expectedPlaces =
        [
            new()
            {
                ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                Title = "Mabry Mill",
                Url = "https://www.nps.gov/places/mabry-mill.htm",
            },
        ];
        string expectedStates = "NC,VA";
        string expectedUrl = "https://www.nps.gov/blri/index.htm";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.NotNull(deserialized.Places);
        Assert.Equal(expectedPlaces.Count, deserialized.Places.Count);
        for (int i = 0; i < expectedPlaces.Count; i++)
        {
            Assert.Equal(expectedPlaces[i], deserialized.Places[i]);
        }
        Assert.Equal(expectedStates, deserialized.States);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Park
        {
            Designation = "Parkway",
            FullName = "Blue Ridge Parkway",
            Name = "Blue Ridge",
            ParkCode = "blri",
            Places =
            [
                new()
                {
                    ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
                    Title = "Mabry Mill",
                    Url = "https://www.nps.gov/places/mabry-mill.htm",
                },
            ],
            States = "NC,VA",
            Url = "https://www.nps.gov/blri/index.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Park { };

        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.Places);
        Assert.False(model.RawData.ContainsKey("places"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Park { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Park
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            Places = null,
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
        Assert.Null(model.Places);
        Assert.False(model.RawData.ContainsKey("places"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Park
        {
            // Null should be interpreted as omitted for these properties
            Designation = null,
            FullName = null,
            Name = null,
            ParkCode = null,
            Places = null,
            States = null,
            Url = null,
        };

        model.Validate();
    }
}

public class PlaceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Place
        {
            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
            Title = "Mabry Mill",
            Url = "https://www.nps.gov/places/mabry-mill.htm",
        };

        string expectedID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3";
        string expectedTitle = "Mabry Mill";
        string expectedUrl = "https://www.nps.gov/places/mabry-mill.htm";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Place
        {
            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
            Title = "Mabry Mill",
            Url = "https://www.nps.gov/places/mabry-mill.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Place>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Place
        {
            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
            Title = "Mabry Mill",
            Url = "https://www.nps.gov/places/mabry-mill.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Place>(element);
        Assert.NotNull(deserialized);

        string expectedID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3";
        string expectedTitle = "Mabry Mill";
        string expectedUrl = "https://www.nps.gov/places/mabry-mill.htm";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Place
        {
            ID = "E4267D0C-EE18-4020-88DC-40B5EBAC32E3",
            Title = "Mabry Mill",
            Url = "https://www.nps.gov/places/mabry-mill.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Place { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Place { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Place
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Place
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}
