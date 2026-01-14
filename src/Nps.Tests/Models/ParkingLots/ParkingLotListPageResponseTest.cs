using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.ParkingLots;

namespace Nps.Tests.Models.ParkingLots;

public class ParkingLotListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ParkingLotListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<ParkingLotListResponse> expectedData =
        [
            new()
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
        var model = new ParkingLotListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ParkingLotListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ParkingLotListPageResponse
        {
            Data =
            [
                new()
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
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ParkingLotListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<ParkingLotListResponse> expectedData =
        [
            new()
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
        var model = new ParkingLotListPageResponse
        {
            Data =
            [
                new()
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
        var model = new ParkingLotListPageResponse { };

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
        var model = new ParkingLotListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ParkingLotListPageResponse
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
        var model = new ParkingLotListPageResponse
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
