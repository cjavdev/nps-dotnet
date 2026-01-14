using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Exceptions;
using Nps.Models.ParkingLots;

namespace Nps.Tests.Models.ParkingLots;

public class ParkingLotListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ParkingLotListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Accessibility = new()
                    {
                        AdaFacilitiesDescription = "",
                        IsLotAccessibleToDisabled = true,
                        NumberofAdaSpaces = 6,
                        NumberofAdaStepFreeSpaces = 6,
                        NumberofAdaVanAccessbileSpaces = 6,
                        NumberOfOversizeVehicleSpaces = 0,
                        TotalSpaces = 145,
                    },
                    AltName = "altName",
                    Contacts = new()
                    {
                        EmailAddresses =
                        [
                            new()
                            {
                                Description = "description",
                                EmailAddressValue = "emailAddress",
                            },
                        ],
                        PhoneNumbers =
                        [
                            new()
                            {
                                Description = "description",
                                Extension = "extension",
                                PhoneNumberValue = "phoneNumber",
                                Type = Type.Voice,
                            },
                        ],
                    },
                    Description = "description",
                    Fees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                            Title = "Acadia Entrance Fee - Per person or vehicle",
                        },
                    ],
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Latitude = "latitude",
                    LiveStatus = new()
                    {
                        Description = "description",
                        EstimatedWaitTimeInMinutes = 0,
                        ExpirationDate = "expirationDate",
                        IsActive = true,
                        Occupancy = "Light",
                    },
                    Longitude = "longitude",
                    ManagedByOrganization = "NPS",
                    Name = "name",
                    OperatingHours =
                    [
                        new()
                        {
                            Description = "description",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = "endDate",
                                    Name = "name",
                                    StartDate = "startDate",
                                },
                            ],
                            Name = "Cadillac Mountain",
                            StandardHours = new()
                            {
                                Friday = "All Day",
                                Monday = "All Day",
                                Saturday = "All Day",
                                Sunday = "All Day",
                                Thursday = "All Day",
                                Tuesday = "All Day",
                                Wednesday = "All Day",
                            },
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    TimeZone = "ET",
                    WebcamUrl = "webcamUrl",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "4",
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "id",
                Accessibility = new()
                {
                    AdaFacilitiesDescription = "",
                    IsLotAccessibleToDisabled = true,
                    NumberofAdaSpaces = 6,
                    NumberofAdaStepFreeSpaces = 6,
                    NumberofAdaVanAccessbileSpaces = 6,
                    NumberOfOversizeVehicleSpaces = 0,
                    TotalSpaces = 145,
                },
                AltName = "altName",
                Contacts = new()
                {
                    EmailAddresses =
                    [
                        new() { Description = "description", EmailAddressValue = "emailAddress" },
                    ],
                    PhoneNumbers =
                    [
                        new()
                        {
                            Description = "description",
                            Extension = "extension",
                            PhoneNumberValue = "phoneNumber",
                            Type = Type.Voice,
                        },
                    ],
                },
                Description = "description",
                Fees =
                [
                    new()
                    {
                        Cost = "cost",
                        Description =
                            "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                        Title = "Acadia Entrance Fee - Per person or vehicle",
                    },
                ],
                GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
                Latitude = "latitude",
                LiveStatus = new()
                {
                    Description = "description",
                    EstimatedWaitTimeInMinutes = 0,
                    ExpirationDate = "expirationDate",
                    IsActive = true,
                    Occupancy = "Light",
                },
                Longitude = "longitude",
                ManagedByOrganization = "NPS",
                Name = "name",
                OperatingHours =
                [
                    new()
                    {
                        Description = "description",
                        Exceptions =
                        [
                            new()
                            {
                                EndDate = "endDate",
                                Name = "name",
                                StartDate = "startDate",
                            },
                        ],
                        Name = "Cadillac Mountain",
                        StandardHours = new()
                        {
                            Friday = "All Day",
                            Monday = "All Day",
                            Saturday = "All Day",
                            Sunday = "All Day",
                            Thursday = "All Day",
                            Tuesday = "All Day",
                            Wednesday = "All Day",
                        },
                    },
                ],
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National River",
                        FullName = "Buffalo National River",
                        Name = "Buffalo",
                        ParkCode = "buff",
                        State = "AR",
                        Url = "https://www.nps.gov/buff/index.htm",
                    },
                ],
                TimeZone = "ET",
                WebcamUrl = "webcamUrl",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "4";

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
        var model = new ParkingLotListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Accessibility = new()
                    {
                        AdaFacilitiesDescription = "",
                        IsLotAccessibleToDisabled = true,
                        NumberofAdaSpaces = 6,
                        NumberofAdaStepFreeSpaces = 6,
                        NumberofAdaVanAccessbileSpaces = 6,
                        NumberOfOversizeVehicleSpaces = 0,
                        TotalSpaces = 145,
                    },
                    AltName = "altName",
                    Contacts = new()
                    {
                        EmailAddresses =
                        [
                            new()
                            {
                                Description = "description",
                                EmailAddressValue = "emailAddress",
                            },
                        ],
                        PhoneNumbers =
                        [
                            new()
                            {
                                Description = "description",
                                Extension = "extension",
                                PhoneNumberValue = "phoneNumber",
                                Type = Type.Voice,
                            },
                        ],
                    },
                    Description = "description",
                    Fees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                            Title = "Acadia Entrance Fee - Per person or vehicle",
                        },
                    ],
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Latitude = "latitude",
                    LiveStatus = new()
                    {
                        Description = "description",
                        EstimatedWaitTimeInMinutes = 0,
                        ExpirationDate = "expirationDate",
                        IsActive = true,
                        Occupancy = "Light",
                    },
                    Longitude = "longitude",
                    ManagedByOrganization = "NPS",
                    Name = "name",
                    OperatingHours =
                    [
                        new()
                        {
                            Description = "description",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = "endDate",
                                    Name = "name",
                                    StartDate = "startDate",
                                },
                            ],
                            Name = "Cadillac Mountain",
                            StandardHours = new()
                            {
                                Friday = "All Day",
                                Monday = "All Day",
                                Saturday = "All Day",
                                Sunday = "All Day",
                                Thursday = "All Day",
                                Tuesday = "All Day",
                                Wednesday = "All Day",
                            },
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    TimeZone = "ET",
                    WebcamUrl = "webcamUrl",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "4",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ParkingLotListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ParkingLotListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Accessibility = new()
                    {
                        AdaFacilitiesDescription = "",
                        IsLotAccessibleToDisabled = true,
                        NumberofAdaSpaces = 6,
                        NumberofAdaStepFreeSpaces = 6,
                        NumberofAdaVanAccessbileSpaces = 6,
                        NumberOfOversizeVehicleSpaces = 0,
                        TotalSpaces = 145,
                    },
                    AltName = "altName",
                    Contacts = new()
                    {
                        EmailAddresses =
                        [
                            new()
                            {
                                Description = "description",
                                EmailAddressValue = "emailAddress",
                            },
                        ],
                        PhoneNumbers =
                        [
                            new()
                            {
                                Description = "description",
                                Extension = "extension",
                                PhoneNumberValue = "phoneNumber",
                                Type = Type.Voice,
                            },
                        ],
                    },
                    Description = "description",
                    Fees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                            Title = "Acadia Entrance Fee - Per person or vehicle",
                        },
                    ],
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Latitude = "latitude",
                    LiveStatus = new()
                    {
                        Description = "description",
                        EstimatedWaitTimeInMinutes = 0,
                        ExpirationDate = "expirationDate",
                        IsActive = true,
                        Occupancy = "Light",
                    },
                    Longitude = "longitude",
                    ManagedByOrganization = "NPS",
                    Name = "name",
                    OperatingHours =
                    [
                        new()
                        {
                            Description = "description",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = "endDate",
                                    Name = "name",
                                    StartDate = "startDate",
                                },
                            ],
                            Name = "Cadillac Mountain",
                            StandardHours = new()
                            {
                                Friday = "All Day",
                                Monday = "All Day",
                                Saturday = "All Day",
                                Sunday = "All Day",
                                Thursday = "All Day",
                                Tuesday = "All Day",
                                Wednesday = "All Day",
                            },
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    TimeZone = "ET",
                    WebcamUrl = "webcamUrl",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "4",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ParkingLotListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "id",
                Accessibility = new()
                {
                    AdaFacilitiesDescription = "",
                    IsLotAccessibleToDisabled = true,
                    NumberofAdaSpaces = 6,
                    NumberofAdaStepFreeSpaces = 6,
                    NumberofAdaVanAccessbileSpaces = 6,
                    NumberOfOversizeVehicleSpaces = 0,
                    TotalSpaces = 145,
                },
                AltName = "altName",
                Contacts = new()
                {
                    EmailAddresses =
                    [
                        new() { Description = "description", EmailAddressValue = "emailAddress" },
                    ],
                    PhoneNumbers =
                    [
                        new()
                        {
                            Description = "description",
                            Extension = "extension",
                            PhoneNumberValue = "phoneNumber",
                            Type = Type.Voice,
                        },
                    ],
                },
                Description = "description",
                Fees =
                [
                    new()
                    {
                        Cost = "cost",
                        Description =
                            "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                        Title = "Acadia Entrance Fee - Per person or vehicle",
                    },
                ],
                GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
                Latitude = "latitude",
                LiveStatus = new()
                {
                    Description = "description",
                    EstimatedWaitTimeInMinutes = 0,
                    ExpirationDate = "expirationDate",
                    IsActive = true,
                    Occupancy = "Light",
                },
                Longitude = "longitude",
                ManagedByOrganization = "NPS",
                Name = "name",
                OperatingHours =
                [
                    new()
                    {
                        Description = "description",
                        Exceptions =
                        [
                            new()
                            {
                                EndDate = "endDate",
                                Name = "name",
                                StartDate = "startDate",
                            },
                        ],
                        Name = "Cadillac Mountain",
                        StandardHours = new()
                        {
                            Friday = "All Day",
                            Monday = "All Day",
                            Saturday = "All Day",
                            Sunday = "All Day",
                            Thursday = "All Day",
                            Tuesday = "All Day",
                            Wednesday = "All Day",
                        },
                    },
                ],
                RelatedParks =
                [
                    new()
                    {
                        Designation = "National River",
                        FullName = "Buffalo National River",
                        Name = "Buffalo",
                        ParkCode = "buff",
                        State = "AR",
                        Url = "https://www.nps.gov/buff/index.htm",
                    },
                ],
                TimeZone = "ET",
                WebcamUrl = "webcamUrl",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "4";

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
        var model = new ParkingLotListResponse
        {
            Data =
            [
                new()
                {
                    ID = "id",
                    Accessibility = new()
                    {
                        AdaFacilitiesDescription = "",
                        IsLotAccessibleToDisabled = true,
                        NumberofAdaSpaces = 6,
                        NumberofAdaStepFreeSpaces = 6,
                        NumberofAdaVanAccessbileSpaces = 6,
                        NumberOfOversizeVehicleSpaces = 0,
                        TotalSpaces = 145,
                    },
                    AltName = "altName",
                    Contacts = new()
                    {
                        EmailAddresses =
                        [
                            new()
                            {
                                Description = "description",
                                EmailAddressValue = "emailAddress",
                            },
                        ],
                        PhoneNumbers =
                        [
                            new()
                            {
                                Description = "description",
                                Extension = "extension",
                                PhoneNumberValue = "phoneNumber",
                                Type = Type.Voice,
                            },
                        ],
                    },
                    Description = "description",
                    Fees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                            Title = "Acadia Entrance Fee - Per person or vehicle",
                        },
                    ],
                    GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                    Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
                    Latitude = "latitude",
                    LiveStatus = new()
                    {
                        Description = "description",
                        EstimatedWaitTimeInMinutes = 0,
                        ExpirationDate = "expirationDate",
                        IsActive = true,
                        Occupancy = "Light",
                    },
                    Longitude = "longitude",
                    ManagedByOrganization = "NPS",
                    Name = "name",
                    OperatingHours =
                    [
                        new()
                        {
                            Description = "description",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = "endDate",
                                    Name = "name",
                                    StartDate = "startDate",
                                },
                            ],
                            Name = "Cadillac Mountain",
                            StandardHours = new()
                            {
                                Friday = "All Day",
                                Monday = "All Day",
                                Saturday = "All Day",
                                Sunday = "All Day",
                                Thursday = "All Day",
                                Tuesday = "All Day",
                                Wednesday = "All Day",
                            },
                        },
                    ],
                    RelatedParks =
                    [
                        new()
                        {
                            Designation = "National River",
                            FullName = "Buffalo National River",
                            Name = "Buffalo",
                            ParkCode = "buff",
                            State = "AR",
                            Url = "https://www.nps.gov/buff/index.htm",
                        },
                    ],
                    TimeZone = "ET",
                    WebcamUrl = "webcamUrl",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "4",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ParkingLotListResponse { };

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
        var model = new ParkingLotListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ParkingLotListResponse
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
        var model = new ParkingLotListResponse
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
            ID = "id",
            Accessibility = new()
            {
                AdaFacilitiesDescription = "",
                IsLotAccessibleToDisabled = true,
                NumberofAdaSpaces = 6,
                NumberofAdaStepFreeSpaces = 6,
                NumberofAdaVanAccessbileSpaces = 6,
                NumberOfOversizeVehicleSpaces = 0,
                TotalSpaces = 145,
            },
            AltName = "altName",
            Contacts = new()
            {
                EmailAddresses =
                [
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
                ],
                PhoneNumbers =
                [
                    new()
                    {
                        Description = "description",
                        Extension = "extension",
                        PhoneNumberValue = "phoneNumber",
                        Type = Type.Voice,
                    },
                ],
            },
            Description = "description",
            Fees =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                    Title = "Acadia Entrance Fee - Per person or vehicle",
                },
            ],
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Latitude = "latitude",
            LiveStatus = new()
            {
                Description = "description",
                EstimatedWaitTimeInMinutes = 0,
                ExpirationDate = "expirationDate",
                IsActive = true,
                Occupancy = "Light",
            },
            Longitude = "longitude",
            ManagedByOrganization = "NPS",
            Name = "name",
            OperatingHours =
            [
                new()
                {
                    Description = "description",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = "endDate",
                            Name = "name",
                            StartDate = "startDate",
                        },
                    ],
                    Name = "Cadillac Mountain",
                    StandardHours = new()
                    {
                        Friday = "All Day",
                        Monday = "All Day",
                        Saturday = "All Day",
                        Sunday = "All Day",
                        Thursday = "All Day",
                        Tuesday = "All Day",
                        Wednesday = "All Day",
                    },
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            TimeZone = "ET",
            WebcamUrl = "webcamUrl",
        };

        string expectedID = "id";
        Accessibility expectedAccessibility = new()
        {
            AdaFacilitiesDescription = "",
            IsLotAccessibleToDisabled = true,
            NumberofAdaSpaces = 6,
            NumberofAdaStepFreeSpaces = 6,
            NumberofAdaVanAccessbileSpaces = 6,
            NumberOfOversizeVehicleSpaces = 0,
            TotalSpaces = 145,
        };
        string expectedAltName = "altName";
        Contacts expectedContacts = new()
        {
            EmailAddresses =
            [
                new() { Description = "description", EmailAddressValue = "emailAddress" },
            ],
            PhoneNumbers =
            [
                new()
                {
                    Description = "description",
                    Extension = "extension",
                    PhoneNumberValue = "phoneNumber",
                    Type = Type.Voice,
                },
            ],
        };
        string expectedDescription = "description";
        List<Fee> expectedFees =
        [
            new()
            {
                Cost = "cost",
                Description =
                    "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                Title = "Acadia Entrance Fee - Per person or vehicle",
            },
        ];
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<JsonElement> expectedImages = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedLatitude = "latitude";
        LiveStatus expectedLiveStatus = new()
        {
            Description = "description",
            EstimatedWaitTimeInMinutes = 0,
            ExpirationDate = "expirationDate",
            IsActive = true,
            Occupancy = "Light",
        };
        string expectedLongitude = "longitude";
        string expectedManagedByOrganization = "NPS";
        string expectedName = "name";
        List<OperatingHour> expectedOperatingHours =
        [
            new()
            {
                Description = "description",
                Exceptions =
                [
                    new()
                    {
                        EndDate = "endDate",
                        Name = "name",
                        StartDate = "startDate",
                    },
                ],
                Name = "Cadillac Mountain",
                StandardHours = new()
                {
                    Friday = "All Day",
                    Monday = "All Day",
                    Saturday = "All Day",
                    Sunday = "All Day",
                    Thursday = "All Day",
                    Tuesday = "All Day",
                    Wednesday = "All Day",
                },
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National River",
                FullName = "Buffalo National River",
                Name = "Buffalo",
                ParkCode = "buff",
                State = "AR",
                Url = "https://www.nps.gov/buff/index.htm",
            },
        ];
        string expectedTimeZone = "ET";
        string expectedWebcamUrl = "webcamUrl";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccessibility, model.Accessibility);
        Assert.Equal(expectedAltName, model.AltName);
        Assert.Equal(expectedContacts, model.Contacts);
        Assert.Equal(expectedDescription, model.Description);
        Assert.NotNull(model.Fees);
        Assert.Equal(expectedFees.Count, model.Fees.Count);
        for (int i = 0; i < expectedFees.Count; i++)
        {
            Assert.Equal(expectedFees[i], model.Fees[i]);
        }
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedImages[i], model.Images[i]));
        }
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLiveStatus, model.LiveStatus);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedManagedByOrganization, model.ManagedByOrganization);
        Assert.Equal(expectedName, model.Name);
        Assert.NotNull(model.OperatingHours);
        Assert.Equal(expectedOperatingHours.Count, model.OperatingHours.Count);
        for (int i = 0; i < expectedOperatingHours.Count; i++)
        {
            Assert.Equal(expectedOperatingHours[i], model.OperatingHours[i]);
        }
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedTimeZone, model.TimeZone);
        Assert.Equal(expectedWebcamUrl, model.WebcamUrl);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "id",
            Accessibility = new()
            {
                AdaFacilitiesDescription = "",
                IsLotAccessibleToDisabled = true,
                NumberofAdaSpaces = 6,
                NumberofAdaStepFreeSpaces = 6,
                NumberofAdaVanAccessbileSpaces = 6,
                NumberOfOversizeVehicleSpaces = 0,
                TotalSpaces = 145,
            },
            AltName = "altName",
            Contacts = new()
            {
                EmailAddresses =
                [
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
                ],
                PhoneNumbers =
                [
                    new()
                    {
                        Description = "description",
                        Extension = "extension",
                        PhoneNumberValue = "phoneNumber",
                        Type = Type.Voice,
                    },
                ],
            },
            Description = "description",
            Fees =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                    Title = "Acadia Entrance Fee - Per person or vehicle",
                },
            ],
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Latitude = "latitude",
            LiveStatus = new()
            {
                Description = "description",
                EstimatedWaitTimeInMinutes = 0,
                ExpirationDate = "expirationDate",
                IsActive = true,
                Occupancy = "Light",
            },
            Longitude = "longitude",
            ManagedByOrganization = "NPS",
            Name = "name",
            OperatingHours =
            [
                new()
                {
                    Description = "description",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = "endDate",
                            Name = "name",
                            StartDate = "startDate",
                        },
                    ],
                    Name = "Cadillac Mountain",
                    StandardHours = new()
                    {
                        Friday = "All Day",
                        Monday = "All Day",
                        Saturday = "All Day",
                        Sunday = "All Day",
                        Thursday = "All Day",
                        Tuesday = "All Day",
                        Wednesday = "All Day",
                    },
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            TimeZone = "ET",
            WebcamUrl = "webcamUrl",
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
            ID = "id",
            Accessibility = new()
            {
                AdaFacilitiesDescription = "",
                IsLotAccessibleToDisabled = true,
                NumberofAdaSpaces = 6,
                NumberofAdaStepFreeSpaces = 6,
                NumberofAdaVanAccessbileSpaces = 6,
                NumberOfOversizeVehicleSpaces = 0,
                TotalSpaces = 145,
            },
            AltName = "altName",
            Contacts = new()
            {
                EmailAddresses =
                [
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
                ],
                PhoneNumbers =
                [
                    new()
                    {
                        Description = "description",
                        Extension = "extension",
                        PhoneNumberValue = "phoneNumber",
                        Type = Type.Voice,
                    },
                ],
            },
            Description = "description",
            Fees =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                    Title = "Acadia Entrance Fee - Per person or vehicle",
                },
            ],
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Latitude = "latitude",
            LiveStatus = new()
            {
                Description = "description",
                EstimatedWaitTimeInMinutes = 0,
                ExpirationDate = "expirationDate",
                IsActive = true,
                Occupancy = "Light",
            },
            Longitude = "longitude",
            ManagedByOrganization = "NPS",
            Name = "name",
            OperatingHours =
            [
                new()
                {
                    Description = "description",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = "endDate",
                            Name = "name",
                            StartDate = "startDate",
                        },
                    ],
                    Name = "Cadillac Mountain",
                    StandardHours = new()
                    {
                        Friday = "All Day",
                        Monday = "All Day",
                        Saturday = "All Day",
                        Sunday = "All Day",
                        Thursday = "All Day",
                        Tuesday = "All Day",
                        Wednesday = "All Day",
                    },
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            TimeZone = "ET",
            WebcamUrl = "webcamUrl",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        Accessibility expectedAccessibility = new()
        {
            AdaFacilitiesDescription = "",
            IsLotAccessibleToDisabled = true,
            NumberofAdaSpaces = 6,
            NumberofAdaStepFreeSpaces = 6,
            NumberofAdaVanAccessbileSpaces = 6,
            NumberOfOversizeVehicleSpaces = 0,
            TotalSpaces = 145,
        };
        string expectedAltName = "altName";
        Contacts expectedContacts = new()
        {
            EmailAddresses =
            [
                new() { Description = "description", EmailAddressValue = "emailAddress" },
            ],
            PhoneNumbers =
            [
                new()
                {
                    Description = "description",
                    Extension = "extension",
                    PhoneNumberValue = "phoneNumber",
                    Type = Type.Voice,
                },
            ],
        };
        string expectedDescription = "description";
        List<Fee> expectedFees =
        [
            new()
            {
                Cost = "cost",
                Description =
                    "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                Title = "Acadia Entrance Fee - Per person or vehicle",
            },
        ];
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<JsonElement> expectedImages = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedLatitude = "latitude";
        LiveStatus expectedLiveStatus = new()
        {
            Description = "description",
            EstimatedWaitTimeInMinutes = 0,
            ExpirationDate = "expirationDate",
            IsActive = true,
            Occupancy = "Light",
        };
        string expectedLongitude = "longitude";
        string expectedManagedByOrganization = "NPS";
        string expectedName = "name";
        List<OperatingHour> expectedOperatingHours =
        [
            new()
            {
                Description = "description",
                Exceptions =
                [
                    new()
                    {
                        EndDate = "endDate",
                        Name = "name",
                        StartDate = "startDate",
                    },
                ],
                Name = "Cadillac Mountain",
                StandardHours = new()
                {
                    Friday = "All Day",
                    Monday = "All Day",
                    Saturday = "All Day",
                    Sunday = "All Day",
                    Thursday = "All Day",
                    Tuesday = "All Day",
                    Wednesday = "All Day",
                },
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National River",
                FullName = "Buffalo National River",
                Name = "Buffalo",
                ParkCode = "buff",
                State = "AR",
                Url = "https://www.nps.gov/buff/index.htm",
            },
        ];
        string expectedTimeZone = "ET";
        string expectedWebcamUrl = "webcamUrl";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccessibility, deserialized.Accessibility);
        Assert.Equal(expectedAltName, deserialized.AltName);
        Assert.Equal(expectedContacts, deserialized.Contacts);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.NotNull(deserialized.Fees);
        Assert.Equal(expectedFees.Count, deserialized.Fees.Count);
        for (int i = 0; i < expectedFees.Count; i++)
        {
            Assert.Equal(expectedFees[i], deserialized.Fees[i]);
        }
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedImages[i], deserialized.Images[i]));
        }
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLiveStatus, deserialized.LiveStatus);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedManagedByOrganization, deserialized.ManagedByOrganization);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.NotNull(deserialized.OperatingHours);
        Assert.Equal(expectedOperatingHours.Count, deserialized.OperatingHours.Count);
        for (int i = 0; i < expectedOperatingHours.Count; i++)
        {
            Assert.Equal(expectedOperatingHours[i], deserialized.OperatingHours[i]);
        }
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedTimeZone, deserialized.TimeZone);
        Assert.Equal(expectedWebcamUrl, deserialized.WebcamUrl);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "id",
            Accessibility = new()
            {
                AdaFacilitiesDescription = "",
                IsLotAccessibleToDisabled = true,
                NumberofAdaSpaces = 6,
                NumberofAdaStepFreeSpaces = 6,
                NumberofAdaVanAccessbileSpaces = 6,
                NumberOfOversizeVehicleSpaces = 0,
                TotalSpaces = 145,
            },
            AltName = "altName",
            Contacts = new()
            {
                EmailAddresses =
                [
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
                ],
                PhoneNumbers =
                [
                    new()
                    {
                        Description = "description",
                        Extension = "extension",
                        PhoneNumberValue = "phoneNumber",
                        Type = Type.Voice,
                    },
                ],
            },
            Description = "description",
            Fees =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
                    Title = "Acadia Entrance Fee - Per person or vehicle",
                },
            ],
            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
            Images = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Latitude = "latitude",
            LiveStatus = new()
            {
                Description = "description",
                EstimatedWaitTimeInMinutes = 0,
                ExpirationDate = "expirationDate",
                IsActive = true,
                Occupancy = "Light",
            },
            Longitude = "longitude",
            ManagedByOrganization = "NPS",
            Name = "name",
            OperatingHours =
            [
                new()
                {
                    Description = "description",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = "endDate",
                            Name = "name",
                            StartDate = "startDate",
                        },
                    ],
                    Name = "Cadillac Mountain",
                    StandardHours = new()
                    {
                        Friday = "All Day",
                        Monday = "All Day",
                        Saturday = "All Day",
                        Sunday = "All Day",
                        Thursday = "All Day",
                        Tuesday = "All Day",
                        Wednesday = "All Day",
                    },
                },
            ],
            RelatedParks =
            [
                new()
                {
                    Designation = "National River",
                    FullName = "Buffalo National River",
                    Name = "Buffalo",
                    ParkCode = "buff",
                    State = "AR",
                    Url = "https://www.nps.gov/buff/index.htm",
                },
            ],
            TimeZone = "ET",
            WebcamUrl = "webcamUrl",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Accessibility);
        Assert.False(model.RawData.ContainsKey("accessibility"));
        Assert.Null(model.AltName);
        Assert.False(model.RawData.ContainsKey("altName"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Fees);
        Assert.False(model.RawData.ContainsKey("fees"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LiveStatus);
        Assert.False(model.RawData.ContainsKey("liveStatus"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.ManagedByOrganization);
        Assert.False(model.RawData.ContainsKey("managedByOrganization"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.OperatingHours);
        Assert.False(model.RawData.ContainsKey("operatingHours"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.TimeZone);
        Assert.False(model.RawData.ContainsKey("timeZone"));
        Assert.Null(model.WebcamUrl);
        Assert.False(model.RawData.ContainsKey("webcamUrl"));
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
            Accessibility = null,
            AltName = null,
            Contacts = null,
            Description = null,
            Fees = null,
            GeometryPoiID = null,
            Images = null,
            Latitude = null,
            LiveStatus = null,
            Longitude = null,
            ManagedByOrganization = null,
            Name = null,
            OperatingHours = null,
            RelatedParks = null,
            TimeZone = null,
            WebcamUrl = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Accessibility);
        Assert.False(model.RawData.ContainsKey("accessibility"));
        Assert.Null(model.AltName);
        Assert.False(model.RawData.ContainsKey("altName"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Fees);
        Assert.False(model.RawData.ContainsKey("fees"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LiveStatus);
        Assert.False(model.RawData.ContainsKey("liveStatus"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.ManagedByOrganization);
        Assert.False(model.RawData.ContainsKey("managedByOrganization"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.OperatingHours);
        Assert.False(model.RawData.ContainsKey("operatingHours"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.TimeZone);
        Assert.False(model.RawData.ContainsKey("timeZone"));
        Assert.Null(model.WebcamUrl);
        Assert.False(model.RawData.ContainsKey("webcamUrl"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Accessibility = null,
            AltName = null,
            Contacts = null,
            Description = null,
            Fees = null,
            GeometryPoiID = null,
            Images = null,
            Latitude = null,
            LiveStatus = null,
            Longitude = null,
            ManagedByOrganization = null,
            Name = null,
            OperatingHours = null,
            RelatedParks = null,
            TimeZone = null,
            WebcamUrl = null,
        };

        model.Validate();
    }
}

public class AccessibilityTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accessibility
        {
            AdaFacilitiesDescription = "",
            IsLotAccessibleToDisabled = true,
            NumberofAdaSpaces = 6,
            NumberofAdaStepFreeSpaces = 6,
            NumberofAdaVanAccessbileSpaces = 6,
            NumberOfOversizeVehicleSpaces = 0,
            TotalSpaces = 145,
        };

        string expectedAdaFacilitiesDescription = "";
        bool expectedIsLotAccessibleToDisabled = true;
        long expectedNumberofAdaSpaces = 6;
        long expectedNumberofAdaStepFreeSpaces = 6;
        long expectedNumberofAdaVanAccessbileSpaces = 6;
        long expectedNumberOfOversizeVehicleSpaces = 0;
        long expectedTotalSpaces = 145;

        Assert.Equal(expectedAdaFacilitiesDescription, model.AdaFacilitiesDescription);
        Assert.Equal(expectedIsLotAccessibleToDisabled, model.IsLotAccessibleToDisabled);
        Assert.Equal(expectedNumberofAdaSpaces, model.NumberofAdaSpaces);
        Assert.Equal(expectedNumberofAdaStepFreeSpaces, model.NumberofAdaStepFreeSpaces);
        Assert.Equal(expectedNumberofAdaVanAccessbileSpaces, model.NumberofAdaVanAccessbileSpaces);
        Assert.Equal(expectedNumberOfOversizeVehicleSpaces, model.NumberOfOversizeVehicleSpaces);
        Assert.Equal(expectedTotalSpaces, model.TotalSpaces);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Accessibility
        {
            AdaFacilitiesDescription = "",
            IsLotAccessibleToDisabled = true,
            NumberofAdaSpaces = 6,
            NumberofAdaStepFreeSpaces = 6,
            NumberofAdaVanAccessbileSpaces = 6,
            NumberOfOversizeVehicleSpaces = 0,
            TotalSpaces = 145,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accessibility>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accessibility
        {
            AdaFacilitiesDescription = "",
            IsLotAccessibleToDisabled = true,
            NumberofAdaSpaces = 6,
            NumberofAdaStepFreeSpaces = 6,
            NumberofAdaVanAccessbileSpaces = 6,
            NumberOfOversizeVehicleSpaces = 0,
            TotalSpaces = 145,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accessibility>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAdaFacilitiesDescription = "";
        bool expectedIsLotAccessibleToDisabled = true;
        long expectedNumberofAdaSpaces = 6;
        long expectedNumberofAdaStepFreeSpaces = 6;
        long expectedNumberofAdaVanAccessbileSpaces = 6;
        long expectedNumberOfOversizeVehicleSpaces = 0;
        long expectedTotalSpaces = 145;

        Assert.Equal(expectedAdaFacilitiesDescription, deserialized.AdaFacilitiesDescription);
        Assert.Equal(expectedIsLotAccessibleToDisabled, deserialized.IsLotAccessibleToDisabled);
        Assert.Equal(expectedNumberofAdaSpaces, deserialized.NumberofAdaSpaces);
        Assert.Equal(expectedNumberofAdaStepFreeSpaces, deserialized.NumberofAdaStepFreeSpaces);
        Assert.Equal(
            expectedNumberofAdaVanAccessbileSpaces,
            deserialized.NumberofAdaVanAccessbileSpaces
        );
        Assert.Equal(
            expectedNumberOfOversizeVehicleSpaces,
            deserialized.NumberOfOversizeVehicleSpaces
        );
        Assert.Equal(expectedTotalSpaces, deserialized.TotalSpaces);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Accessibility
        {
            AdaFacilitiesDescription = "",
            IsLotAccessibleToDisabled = true,
            NumberofAdaSpaces = 6,
            NumberofAdaStepFreeSpaces = 6,
            NumberofAdaVanAccessbileSpaces = 6,
            NumberOfOversizeVehicleSpaces = 0,
            TotalSpaces = 145,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Accessibility { };

        Assert.Null(model.AdaFacilitiesDescription);
        Assert.False(model.RawData.ContainsKey("adaFacilitiesDescription"));
        Assert.Null(model.IsLotAccessibleToDisabled);
        Assert.False(model.RawData.ContainsKey("isLotAccessibleToDisabled"));
        Assert.Null(model.NumberofAdaSpaces);
        Assert.False(model.RawData.ContainsKey("numberofAdaSpaces"));
        Assert.Null(model.NumberofAdaStepFreeSpaces);
        Assert.False(model.RawData.ContainsKey("numberofAdaStepFreeSpaces"));
        Assert.Null(model.NumberofAdaVanAccessbileSpaces);
        Assert.False(model.RawData.ContainsKey("numberofAdaVanAccessbileSpaces"));
        Assert.Null(model.NumberOfOversizeVehicleSpaces);
        Assert.False(model.RawData.ContainsKey("numberOfOversizeVehicleSpaces"));
        Assert.Null(model.TotalSpaces);
        Assert.False(model.RawData.ContainsKey("totalSpaces"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Accessibility { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Accessibility
        {
            // Null should be interpreted as omitted for these properties
            AdaFacilitiesDescription = null,
            IsLotAccessibleToDisabled = null,
            NumberofAdaSpaces = null,
            NumberofAdaStepFreeSpaces = null,
            NumberofAdaVanAccessbileSpaces = null,
            NumberOfOversizeVehicleSpaces = null,
            TotalSpaces = null,
        };

        Assert.Null(model.AdaFacilitiesDescription);
        Assert.False(model.RawData.ContainsKey("adaFacilitiesDescription"));
        Assert.Null(model.IsLotAccessibleToDisabled);
        Assert.False(model.RawData.ContainsKey("isLotAccessibleToDisabled"));
        Assert.Null(model.NumberofAdaSpaces);
        Assert.False(model.RawData.ContainsKey("numberofAdaSpaces"));
        Assert.Null(model.NumberofAdaStepFreeSpaces);
        Assert.False(model.RawData.ContainsKey("numberofAdaStepFreeSpaces"));
        Assert.Null(model.NumberofAdaVanAccessbileSpaces);
        Assert.False(model.RawData.ContainsKey("numberofAdaVanAccessbileSpaces"));
        Assert.Null(model.NumberOfOversizeVehicleSpaces);
        Assert.False(model.RawData.ContainsKey("numberOfOversizeVehicleSpaces"));
        Assert.Null(model.TotalSpaces);
        Assert.False(model.RawData.ContainsKey("totalSpaces"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Accessibility
        {
            // Null should be interpreted as omitted for these properties
            AdaFacilitiesDescription = null,
            IsLotAccessibleToDisabled = null,
            NumberofAdaSpaces = null,
            NumberofAdaStepFreeSpaces = null,
            NumberofAdaVanAccessbileSpaces = null,
            NumberOfOversizeVehicleSpaces = null,
            TotalSpaces = null,
        };

        model.Validate();
    }
}

public class ContactsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Contacts
        {
            EmailAddresses =
            [
                new() { Description = "description", EmailAddressValue = "emailAddress" },
            ],
            PhoneNumbers =
            [
                new()
                {
                    Description = "description",
                    Extension = "extension",
                    PhoneNumberValue = "phoneNumber",
                    Type = Type.Voice,
                },
            ],
        };

        List<EmailAddress> expectedEmailAddresses =
        [
            new() { Description = "description", EmailAddressValue = "emailAddress" },
        ];
        List<PhoneNumber> expectedPhoneNumbers =
        [
            new()
            {
                Description = "description",
                Extension = "extension",
                PhoneNumberValue = "phoneNumber",
                Type = Type.Voice,
            },
        ];

        Assert.NotNull(model.EmailAddresses);
        Assert.Equal(expectedEmailAddresses.Count, model.EmailAddresses.Count);
        for (int i = 0; i < expectedEmailAddresses.Count; i++)
        {
            Assert.Equal(expectedEmailAddresses[i], model.EmailAddresses[i]);
        }
        Assert.NotNull(model.PhoneNumbers);
        Assert.Equal(expectedPhoneNumbers.Count, model.PhoneNumbers.Count);
        for (int i = 0; i < expectedPhoneNumbers.Count; i++)
        {
            Assert.Equal(expectedPhoneNumbers[i], model.PhoneNumbers[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Contacts
        {
            EmailAddresses =
            [
                new() { Description = "description", EmailAddressValue = "emailAddress" },
            ],
            PhoneNumbers =
            [
                new()
                {
                    Description = "description",
                    Extension = "extension",
                    PhoneNumberValue = "phoneNumber",
                    Type = Type.Voice,
                },
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Contacts>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Contacts
        {
            EmailAddresses =
            [
                new() { Description = "description", EmailAddressValue = "emailAddress" },
            ],
            PhoneNumbers =
            [
                new()
                {
                    Description = "description",
                    Extension = "extension",
                    PhoneNumberValue = "phoneNumber",
                    Type = Type.Voice,
                },
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Contacts>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<EmailAddress> expectedEmailAddresses =
        [
            new() { Description = "description", EmailAddressValue = "emailAddress" },
        ];
        List<PhoneNumber> expectedPhoneNumbers =
        [
            new()
            {
                Description = "description",
                Extension = "extension",
                PhoneNumberValue = "phoneNumber",
                Type = Type.Voice,
            },
        ];

        Assert.NotNull(deserialized.EmailAddresses);
        Assert.Equal(expectedEmailAddresses.Count, deserialized.EmailAddresses.Count);
        for (int i = 0; i < expectedEmailAddresses.Count; i++)
        {
            Assert.Equal(expectedEmailAddresses[i], deserialized.EmailAddresses[i]);
        }
        Assert.NotNull(deserialized.PhoneNumbers);
        Assert.Equal(expectedPhoneNumbers.Count, deserialized.PhoneNumbers.Count);
        for (int i = 0; i < expectedPhoneNumbers.Count; i++)
        {
            Assert.Equal(expectedPhoneNumbers[i], deserialized.PhoneNumbers[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Contacts
        {
            EmailAddresses =
            [
                new() { Description = "description", EmailAddressValue = "emailAddress" },
            ],
            PhoneNumbers =
            [
                new()
                {
                    Description = "description",
                    Extension = "extension",
                    PhoneNumberValue = "phoneNumber",
                    Type = Type.Voice,
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Contacts { };

        Assert.Null(model.EmailAddresses);
        Assert.False(model.RawData.ContainsKey("emailAddresses"));
        Assert.Null(model.PhoneNumbers);
        Assert.False(model.RawData.ContainsKey("phoneNumbers"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Contacts { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Contacts
        {
            // Null should be interpreted as omitted for these properties
            EmailAddresses = null,
            PhoneNumbers = null,
        };

        Assert.Null(model.EmailAddresses);
        Assert.False(model.RawData.ContainsKey("emailAddresses"));
        Assert.Null(model.PhoneNumbers);
        Assert.False(model.RawData.ContainsKey("phoneNumbers"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Contacts
        {
            // Null should be interpreted as omitted for these properties
            EmailAddresses = null,
            PhoneNumbers = null,
        };

        model.Validate();
    }
}

public class EmailAddressTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new EmailAddress
        {
            Description = "description",
            EmailAddressValue = "emailAddress",
        };

        string expectedDescription = "description";
        string expectedEmailAddressValue = "emailAddress";

        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedEmailAddressValue, model.EmailAddressValue);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new EmailAddress
        {
            Description = "description",
            EmailAddressValue = "emailAddress",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<EmailAddress>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new EmailAddress
        {
            Description = "description",
            EmailAddressValue = "emailAddress",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<EmailAddress>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        string expectedEmailAddressValue = "emailAddress";

        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedEmailAddressValue, deserialized.EmailAddressValue);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new EmailAddress
        {
            Description = "description",
            EmailAddressValue = "emailAddress",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new EmailAddress { };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.EmailAddressValue);
        Assert.False(model.RawData.ContainsKey("emailAddress"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new EmailAddress { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new EmailAddress
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            EmailAddressValue = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.EmailAddressValue);
        Assert.False(model.RawData.ContainsKey("emailAddress"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new EmailAddress
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            EmailAddressValue = null,
        };

        model.Validate();
    }
}

public class PhoneNumberTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Type.Voice,
        };

        string expectedDescription = "description";
        string expectedExtension = "extension";
        string expectedPhoneNumberValue = "phoneNumber";
        ApiEnum<string, Type> expectedType = Type.Voice;

        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedExtension, model.Extension);
        Assert.Equal(expectedPhoneNumberValue, model.PhoneNumberValue);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Type.Voice,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PhoneNumber>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Type.Voice,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PhoneNumber>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        string expectedExtension = "extension";
        string expectedPhoneNumberValue = "phoneNumber";
        ApiEnum<string, Type> expectedType = Type.Voice;

        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedExtension, deserialized.Extension);
        Assert.Equal(expectedPhoneNumberValue, deserialized.PhoneNumberValue);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Type.Voice,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PhoneNumber { };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Extension);
        Assert.False(model.RawData.ContainsKey("extension"));
        Assert.Null(model.PhoneNumberValue);
        Assert.False(model.RawData.ContainsKey("phoneNumber"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PhoneNumber { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PhoneNumber
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            Extension = null,
            PhoneNumberValue = null,
            Type = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Extension);
        Assert.False(model.RawData.ContainsKey("extension"));
        Assert.Null(model.PhoneNumberValue);
        Assert.False(model.RawData.ContainsKey("phoneNumber"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PhoneNumber
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            Extension = null,
            PhoneNumberValue = null,
            Type = null,
        };

        model.Validate();
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Type.Voice)]
    [InlineData(Type.Fax)]
    [InlineData(Type.Tty)]
    public void Validation_Works(Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Type.Voice)]
    [InlineData(Type.Fax)]
    [InlineData(Type.Tty)]
    public void SerializationRoundtrip_Works(Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class FeeTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Fee
        {
            Cost = "cost",
            Description =
                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
            Title = "Acadia Entrance Fee - Per person or vehicle",
        };

        string expectedCost = "cost";
        string expectedDescription =
            "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.";
        string expectedTitle = "Acadia Entrance Fee - Per person or vehicle";

        Assert.Equal(expectedCost, model.Cost);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedTitle, model.Title);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Fee
        {
            Cost = "cost",
            Description =
                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
            Title = "Acadia Entrance Fee - Per person or vehicle",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Fee>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Fee
        {
            Cost = "cost",
            Description =
                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
            Title = "Acadia Entrance Fee - Per person or vehicle",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Fee>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedCost = "cost";
        string expectedDescription =
            "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.";
        string expectedTitle = "Acadia Entrance Fee - Per person or vehicle";

        Assert.Equal(expectedCost, deserialized.Cost);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedTitle, deserialized.Title);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Fee
        {
            Cost = "cost",
            Description =
                "From May to October, entrance into the park including Cadillac Mountain and Blue Hill Overlook require paying a park entrance fee.  Always display your pass in your vehicle when parking in the park. Please visit our Fees & Passes page for more information.",
            Title = "Acadia Entrance Fee - Per person or vehicle",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Fee { };

        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Fee { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Fee
        {
            // Null should be interpreted as omitted for these properties
            Cost = null,
            Description = null,
            Title = null,
        };

        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Fee
        {
            // Null should be interpreted as omitted for these properties
            Cost = null,
            Description = null,
            Title = null,
        };

        model.Validate();
    }
}

public class LiveStatusTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LiveStatus
        {
            Description = "description",
            EstimatedWaitTimeInMinutes = 0,
            ExpirationDate = "expirationDate",
            IsActive = true,
            Occupancy = "Light",
        };

        string expectedDescription = "description";
        long expectedEstimatedWaitTimeInMinutes = 0;
        string expectedExpirationDate = "expirationDate";
        bool expectedIsActive = true;
        string expectedOccupancy = "Light";

        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedEstimatedWaitTimeInMinutes, model.EstimatedWaitTimeInMinutes);
        Assert.Equal(expectedExpirationDate, model.ExpirationDate);
        Assert.Equal(expectedIsActive, model.IsActive);
        Assert.Equal(expectedOccupancy, model.Occupancy);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LiveStatus
        {
            Description = "description",
            EstimatedWaitTimeInMinutes = 0,
            ExpirationDate = "expirationDate",
            IsActive = true,
            Occupancy = "Light",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LiveStatus>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LiveStatus
        {
            Description = "description",
            EstimatedWaitTimeInMinutes = 0,
            ExpirationDate = "expirationDate",
            IsActive = true,
            Occupancy = "Light",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LiveStatus>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        long expectedEstimatedWaitTimeInMinutes = 0;
        string expectedExpirationDate = "expirationDate";
        bool expectedIsActive = true;
        string expectedOccupancy = "Light";

        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedEstimatedWaitTimeInMinutes, deserialized.EstimatedWaitTimeInMinutes);
        Assert.Equal(expectedExpirationDate, deserialized.ExpirationDate);
        Assert.Equal(expectedIsActive, deserialized.IsActive);
        Assert.Equal(expectedOccupancy, deserialized.Occupancy);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LiveStatus
        {
            Description = "description",
            EstimatedWaitTimeInMinutes = 0,
            ExpirationDate = "expirationDate",
            IsActive = true,
            Occupancy = "Light",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LiveStatus { };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.EstimatedWaitTimeInMinutes);
        Assert.False(model.RawData.ContainsKey("estimatedWaitTimeInMinutes"));
        Assert.Null(model.ExpirationDate);
        Assert.False(model.RawData.ContainsKey("expirationDate"));
        Assert.Null(model.IsActive);
        Assert.False(model.RawData.ContainsKey("isActive"));
        Assert.Null(model.Occupancy);
        Assert.False(model.RawData.ContainsKey("occupancy"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new LiveStatus { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new LiveStatus
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            EstimatedWaitTimeInMinutes = null,
            ExpirationDate = null,
            IsActive = null,
            Occupancy = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.EstimatedWaitTimeInMinutes);
        Assert.False(model.RawData.ContainsKey("estimatedWaitTimeInMinutes"));
        Assert.Null(model.ExpirationDate);
        Assert.False(model.RawData.ContainsKey("expirationDate"));
        Assert.Null(model.IsActive);
        Assert.False(model.RawData.ContainsKey("isActive"));
        Assert.Null(model.Occupancy);
        Assert.False(model.RawData.ContainsKey("occupancy"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LiveStatus
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            EstimatedWaitTimeInMinutes = null,
            ExpirationDate = null,
            IsActive = null,
            Occupancy = null,
        };

        model.Validate();
    }
}

public class OperatingHourTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = "endDate",
                    Name = "name",
                    StartDate = "startDate",
                },
            ],
            Name = "Cadillac Mountain",
            StandardHours = new()
            {
                Friday = "All Day",
                Monday = "All Day",
                Saturday = "All Day",
                Sunday = "All Day",
                Thursday = "All Day",
                Tuesday = "All Day",
                Wednesday = "All Day",
            },
        };

        string expectedDescription = "description";
        List<Exception> expectedExceptions =
        [
            new()
            {
                EndDate = "endDate",
                Name = "name",
                StartDate = "startDate",
            },
        ];
        string expectedName = "Cadillac Mountain";
        StandardHours expectedStandardHours = new()
        {
            Friday = "All Day",
            Monday = "All Day",
            Saturday = "All Day",
            Sunday = "All Day",
            Thursday = "All Day",
            Tuesday = "All Day",
            Wednesday = "All Day",
        };

        Assert.Equal(expectedDescription, model.Description);
        Assert.NotNull(model.Exceptions);
        Assert.Equal(expectedExceptions.Count, model.Exceptions.Count);
        for (int i = 0; i < expectedExceptions.Count; i++)
        {
            Assert.Equal(expectedExceptions[i], model.Exceptions[i]);
        }
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedStandardHours, model.StandardHours);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = "endDate",
                    Name = "name",
                    StartDate = "startDate",
                },
            ],
            Name = "Cadillac Mountain",
            StandardHours = new()
            {
                Friday = "All Day",
                Monday = "All Day",
                Saturday = "All Day",
                Sunday = "All Day",
                Thursday = "All Day",
                Tuesday = "All Day",
                Wednesday = "All Day",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<OperatingHour>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = "endDate",
                    Name = "name",
                    StartDate = "startDate",
                },
            ],
            Name = "Cadillac Mountain",
            StandardHours = new()
            {
                Friday = "All Day",
                Monday = "All Day",
                Saturday = "All Day",
                Sunday = "All Day",
                Thursday = "All Day",
                Tuesday = "All Day",
                Wednesday = "All Day",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<OperatingHour>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        List<Exception> expectedExceptions =
        [
            new()
            {
                EndDate = "endDate",
                Name = "name",
                StartDate = "startDate",
            },
        ];
        string expectedName = "Cadillac Mountain";
        StandardHours expectedStandardHours = new()
        {
            Friday = "All Day",
            Monday = "All Day",
            Saturday = "All Day",
            Sunday = "All Day",
            Thursday = "All Day",
            Tuesday = "All Day",
            Wednesday = "All Day",
        };

        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.NotNull(deserialized.Exceptions);
        Assert.Equal(expectedExceptions.Count, deserialized.Exceptions.Count);
        for (int i = 0; i < expectedExceptions.Count; i++)
        {
            Assert.Equal(expectedExceptions[i], deserialized.Exceptions[i]);
        }
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedStandardHours, deserialized.StandardHours);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = "endDate",
                    Name = "name",
                    StartDate = "startDate",
                },
            ],
            Name = "Cadillac Mountain",
            StandardHours = new()
            {
                Friday = "All Day",
                Monday = "All Day",
                Saturday = "All Day",
                Sunday = "All Day",
                Thursday = "All Day",
                Tuesday = "All Day",
                Wednesday = "All Day",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new OperatingHour { };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Exceptions);
        Assert.False(model.RawData.ContainsKey("exceptions"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.StandardHours);
        Assert.False(model.RawData.ContainsKey("standardHours"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new OperatingHour { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new OperatingHour
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            Exceptions = null,
            Name = null,
            StandardHours = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Exceptions);
        Assert.False(model.RawData.ContainsKey("exceptions"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.StandardHours);
        Assert.False(model.RawData.ContainsKey("standardHours"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new OperatingHour
        {
            // Null should be interpreted as omitted for these properties
            Description = null,
            Exceptions = null,
            Name = null,
            StandardHours = null,
        };

        model.Validate();
    }
}

public class ExceptionTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Exception
        {
            EndDate = "endDate",
            Name = "name",
            StartDate = "startDate",
        };

        string expectedEndDate = "endDate";
        string expectedName = "name";
        string expectedStartDate = "startDate";

        Assert.Equal(expectedEndDate, model.EndDate);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedStartDate, model.StartDate);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Exception
        {
            EndDate = "endDate",
            Name = "name",
            StartDate = "startDate",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Exception>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Exception
        {
            EndDate = "endDate",
            Name = "name",
            StartDate = "startDate",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Exception>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedEndDate = "endDate";
        string expectedName = "name";
        string expectedStartDate = "startDate";

        Assert.Equal(expectedEndDate, deserialized.EndDate);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedStartDate, deserialized.StartDate);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Exception
        {
            EndDate = "endDate",
            Name = "name",
            StartDate = "startDate",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Exception { };

        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("endDate"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("startDate"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Exception { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Exception
        {
            // Null should be interpreted as omitted for these properties
            EndDate = null,
            Name = null,
            StartDate = null,
        };

        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("endDate"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("startDate"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Exception
        {
            // Null should be interpreted as omitted for these properties
            EndDate = null,
            Name = null,
            StartDate = null,
        };

        model.Validate();
    }
}

public class StandardHoursTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StandardHours
        {
            Friday = "All Day",
            Monday = "All Day",
            Saturday = "All Day",
            Sunday = "All Day",
            Thursday = "All Day",
            Tuesday = "All Day",
            Wednesday = "All Day",
        };

        string expectedFriday = "All Day";
        string expectedMonday = "All Day";
        string expectedSaturday = "All Day";
        string expectedSunday = "All Day";
        string expectedThursday = "All Day";
        string expectedTuesday = "All Day";
        string expectedWednesday = "All Day";

        Assert.Equal(expectedFriday, model.Friday);
        Assert.Equal(expectedMonday, model.Monday);
        Assert.Equal(expectedSaturday, model.Saturday);
        Assert.Equal(expectedSunday, model.Sunday);
        Assert.Equal(expectedThursday, model.Thursday);
        Assert.Equal(expectedTuesday, model.Tuesday);
        Assert.Equal(expectedWednesday, model.Wednesday);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StandardHours
        {
            Friday = "All Day",
            Monday = "All Day",
            Saturday = "All Day",
            Sunday = "All Day",
            Thursday = "All Day",
            Tuesday = "All Day",
            Wednesday = "All Day",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StandardHours>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StandardHours
        {
            Friday = "All Day",
            Monday = "All Day",
            Saturday = "All Day",
            Sunday = "All Day",
            Thursday = "All Day",
            Tuesday = "All Day",
            Wednesday = "All Day",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StandardHours>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedFriday = "All Day";
        string expectedMonday = "All Day";
        string expectedSaturday = "All Day";
        string expectedSunday = "All Day";
        string expectedThursday = "All Day";
        string expectedTuesday = "All Day";
        string expectedWednesday = "All Day";

        Assert.Equal(expectedFriday, deserialized.Friday);
        Assert.Equal(expectedMonday, deserialized.Monday);
        Assert.Equal(expectedSaturday, deserialized.Saturday);
        Assert.Equal(expectedSunday, deserialized.Sunday);
        Assert.Equal(expectedThursday, deserialized.Thursday);
        Assert.Equal(expectedTuesday, deserialized.Tuesday);
        Assert.Equal(expectedWednesday, deserialized.Wednesday);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StandardHours
        {
            Friday = "All Day",
            Monday = "All Day",
            Saturday = "All Day",
            Sunday = "All Day",
            Thursday = "All Day",
            Tuesday = "All Day",
            Wednesday = "All Day",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new StandardHours { };

        Assert.Null(model.Friday);
        Assert.False(model.RawData.ContainsKey("friday"));
        Assert.Null(model.Monday);
        Assert.False(model.RawData.ContainsKey("monday"));
        Assert.Null(model.Saturday);
        Assert.False(model.RawData.ContainsKey("saturday"));
        Assert.Null(model.Sunday);
        Assert.False(model.RawData.ContainsKey("sunday"));
        Assert.Null(model.Thursday);
        Assert.False(model.RawData.ContainsKey("thursday"));
        Assert.Null(model.Tuesday);
        Assert.False(model.RawData.ContainsKey("tuesday"));
        Assert.Null(model.Wednesday);
        Assert.False(model.RawData.ContainsKey("wednesday"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new StandardHours { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new StandardHours
        {
            // Null should be interpreted as omitted for these properties
            Friday = null,
            Monday = null,
            Saturday = null,
            Sunday = null,
            Thursday = null,
            Tuesday = null,
            Wednesday = null,
        };

        Assert.Null(model.Friday);
        Assert.False(model.RawData.ContainsKey("friday"));
        Assert.Null(model.Monday);
        Assert.False(model.RawData.ContainsKey("monday"));
        Assert.Null(model.Saturday);
        Assert.False(model.RawData.ContainsKey("saturday"));
        Assert.Null(model.Sunday);
        Assert.False(model.RawData.ContainsKey("sunday"));
        Assert.Null(model.Thursday);
        Assert.False(model.RawData.ContainsKey("thursday"));
        Assert.Null(model.Tuesday);
        Assert.False(model.RawData.ContainsKey("tuesday"));
        Assert.Null(model.Wednesday);
        Assert.False(model.RawData.ContainsKey("wednesday"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new StandardHours
        {
            // Null should be interpreted as omitted for these properties
            Friday = null,
            Monday = null,
            Saturday = null,
            Sunday = null,
            Thursday = null,
            Tuesday = null,
            Wednesday = null,
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
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
        };

        string expectedDesignation = "National River";
        string expectedFullName = "Buffalo National River";
        string expectedName = "Buffalo";
        string expectedParkCode = "buff";
        string expectedState = "AR";
        string expectedUrl = "https://www.nps.gov/buff/index.htm";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedState, model.State);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
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
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDesignation = "National River";
        string expectedFullName = "Buffalo National River";
        string expectedName = "Buffalo";
        string expectedParkCode = "buff";
        string expectedState = "AR";
        string expectedUrl = "https://www.nps.gov/buff/index.htm";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedState, deserialized.State);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National River",
            FullName = "Buffalo National River",
            Name = "Buffalo",
            ParkCode = "buff",
            State = "AR",
            Url = "https://www.nps.gov/buff/index.htm",
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
        Assert.Null(model.State);
        Assert.False(model.RawData.ContainsKey("state"));
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
            State = null,
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
        Assert.Null(model.State);
        Assert.False(model.RawData.ContainsKey("state"));
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
            State = null,
            Url = null,
        };

        model.Validate();
    }
}
