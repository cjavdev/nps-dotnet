using System;
using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Exceptions;
using Parks = Nps.Models.Parks;

namespace Nps.Tests.Models.Parks;

public class ParkListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::ParkListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
                    Activities =
                    [
                        new()
                        {
                            ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3",
                            Name = "Guided Tours",
                        },
                    ],
                    Addresses =
                    [
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "2 Officers Row",
                            Line2 = "Yellowstone National Park Headquarters",
                            Line3 = "",
                            PostalCode = "82190",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Physical,
                        },
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "P.O. Box 168",
                            Line2 = "",
                            Line3 = "",
                            PostalCode = "82190-0168",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Mailing,
                        },
                    ],
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
                                Type = Parks::PhoneNumberType.Voice,
                            },
                        ],
                    },
                    Description =
                        "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
                    Designation = "National Park",
                    DirectionsInfo =
                        "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
                    DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
                    EntranceFees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description = "7-day pass for Yellowstone National Park",
                            Title = "Yellowstone (private, non-commercial vehicle)",
                        },
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                            Title = "Yellowstone (motorcycle or snowmobile)",
                        },
                    ],
                    EntrancePasses =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                            Title = "Yellowstone National Park Annual Pass",
                        },
                    ],
                    FullName = "Yellowstone National Park",
                    Images =
                    [
                        new()
                        {
                            AltText = "Crowd watching Aurum Geyser erupt",
                            Caption = "Aurum Geyser Erupting",
                            Credit = "NPS/Jim Peaco",
                            Title = "Aurum Geyser",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                        },
                        new()
                        {
                            AltText = "Photo of bison in Lamar Valley",
                            Caption = "Bison in Lamar Valley",
                            Credit = "NPS/Neal Herbert",
                            Title = "Bison in Lamar Valley",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                        },
                    ],
                    Latitude = "39.9818229675293",
                    LatLong = "lat:44.59824417, long:-110.5471695",
                    Longitude = "-84.0711364746094",
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
                    Name = "Yellowstone",
                    OperatingHours =
                    [
                        new()
                        {
                            Description =
                                "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Thanksgiving Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Christmas Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "All Park Hours",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                        new()
                        {
                            Description =
                                "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "name",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "West Entrance",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                    ],
                    ParkCode = "yell",
                    RelevanceScore = 1,
                    States = "ID,MT,WY",
                    Topics =
                    [
                        new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" },
                    ],
                    Url = "https://www.nps.gov/yell/index.htm",
                    WeatherInfo =
                        "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "496",
        };

        List<Parks::Data> expectedData =
        [
            new()
            {
                ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
                Activities =
                [
                    new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
                ],
                Addresses =
                [
                    new()
                    {
                        City = "Yellowstone National Park",
                        CountryCode = "US",
                        Line1 = "2 Officers Row",
                        Line2 = "Yellowstone National Park Headquarters",
                        Line3 = "",
                        PostalCode = "82190",
                        ProvinceTerritoryCode = "",
                        StateCode = "WY",
                        Type = Parks::Type.Physical,
                    },
                    new()
                    {
                        City = "Yellowstone National Park",
                        CountryCode = "US",
                        Line1 = "P.O. Box 168",
                        Line2 = "",
                        Line3 = "",
                        PostalCode = "82190-0168",
                        ProvinceTerritoryCode = "",
                        StateCode = "WY",
                        Type = Parks::Type.Mailing,
                    },
                ],
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
                            Type = Parks::PhoneNumberType.Voice,
                        },
                    ],
                },
                Description =
                    "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
                Designation = "National Park",
                DirectionsInfo =
                    "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
                DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
                EntranceFees =
                [
                    new()
                    {
                        Cost = "cost",
                        Description = "7-day pass for Yellowstone National Park",
                        Title = "Yellowstone (private, non-commercial vehicle)",
                    },
                    new()
                    {
                        Cost = "cost",
                        Description =
                            "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                        Title = "Yellowstone (motorcycle or snowmobile)",
                    },
                ],
                EntrancePasses =
                [
                    new()
                    {
                        Cost = "cost",
                        Description =
                            "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                        Title = "Yellowstone National Park Annual Pass",
                    },
                ],
                FullName = "Yellowstone National Park",
                Images =
                [
                    new()
                    {
                        AltText = "Crowd watching Aurum Geyser erupt",
                        Caption = "Aurum Geyser Erupting",
                        Credit = "NPS/Jim Peaco",
                        Title = "Aurum Geyser",
                        Url =
                            "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                    },
                    new()
                    {
                        AltText = "Photo of bison in Lamar Valley",
                        Caption = "Bison in Lamar Valley",
                        Credit = "NPS/Neal Herbert",
                        Title = "Bison in Lamar Valley",
                        Url =
                            "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                    },
                ],
                Latitude = "39.9818229675293",
                LatLong = "lat:44.59824417, long:-110.5471695",
                Longitude = "-84.0711364746094",
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
                Name = "Yellowstone",
                OperatingHours =
                [
                    new()
                    {
                        Description =
                            "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                        Exceptions =
                        [
                            new()
                            {
                                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                ExceptionHours = new()
                                {
                                    Friday = "friday",
                                    Monday = "monday",
                                    Saturday = "saturday",
                                    Sunday = "sunday",
                                    Thursday = "thursday",
                                    Tuesday = "tuesday",
                                    Wednesday = "wednesday",
                                },
                                Name = "Thanksgiving Day",
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                            new()
                            {
                                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                ExceptionHours = new()
                                {
                                    Friday = "friday",
                                    Monday = "monday",
                                    Saturday = "saturday",
                                    Sunday = "sunday",
                                    Thursday = "thursday",
                                    Tuesday = "tuesday",
                                    Wednesday = "wednesday",
                                },
                                Name = "Christmas Day",
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                        ],
                        Name = "All Park Hours",
                        StandardHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                    },
                    new()
                    {
                        Description =
                            "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                        Exceptions =
                        [
                            new()
                            {
                                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                ExceptionHours = new()
                                {
                                    Friday = "friday",
                                    Monday = "monday",
                                    Saturday = "saturday",
                                    Sunday = "sunday",
                                    Thursday = "thursday",
                                    Tuesday = "tuesday",
                                    Wednesday = "wednesday",
                                },
                                Name = "name",
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                        ],
                        Name = "West Entrance",
                        StandardHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                    },
                ],
                ParkCode = "yell",
                RelevanceScore = 1,
                States = "ID,MT,WY",
                Topics = [new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" }],
                Url = "https://www.nps.gov/yell/index.htm",
                WeatherInfo =
                    "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "496";

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
        var model = new Parks::ParkListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
                    Activities =
                    [
                        new()
                        {
                            ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3",
                            Name = "Guided Tours",
                        },
                    ],
                    Addresses =
                    [
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "2 Officers Row",
                            Line2 = "Yellowstone National Park Headquarters",
                            Line3 = "",
                            PostalCode = "82190",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Physical,
                        },
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "P.O. Box 168",
                            Line2 = "",
                            Line3 = "",
                            PostalCode = "82190-0168",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Mailing,
                        },
                    ],
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
                                Type = Parks::PhoneNumberType.Voice,
                            },
                        ],
                    },
                    Description =
                        "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
                    Designation = "National Park",
                    DirectionsInfo =
                        "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
                    DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
                    EntranceFees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description = "7-day pass for Yellowstone National Park",
                            Title = "Yellowstone (private, non-commercial vehicle)",
                        },
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                            Title = "Yellowstone (motorcycle or snowmobile)",
                        },
                    ],
                    EntrancePasses =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                            Title = "Yellowstone National Park Annual Pass",
                        },
                    ],
                    FullName = "Yellowstone National Park",
                    Images =
                    [
                        new()
                        {
                            AltText = "Crowd watching Aurum Geyser erupt",
                            Caption = "Aurum Geyser Erupting",
                            Credit = "NPS/Jim Peaco",
                            Title = "Aurum Geyser",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                        },
                        new()
                        {
                            AltText = "Photo of bison in Lamar Valley",
                            Caption = "Bison in Lamar Valley",
                            Credit = "NPS/Neal Herbert",
                            Title = "Bison in Lamar Valley",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                        },
                    ],
                    Latitude = "39.9818229675293",
                    LatLong = "lat:44.59824417, long:-110.5471695",
                    Longitude = "-84.0711364746094",
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
                    Name = "Yellowstone",
                    OperatingHours =
                    [
                        new()
                        {
                            Description =
                                "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Thanksgiving Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Christmas Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "All Park Hours",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                        new()
                        {
                            Description =
                                "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "name",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "West Entrance",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                    ],
                    ParkCode = "yell",
                    RelevanceScore = 1,
                    States = "ID,MT,WY",
                    Topics =
                    [
                        new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" },
                    ],
                    Url = "https://www.nps.gov/yell/index.htm",
                    WeatherInfo =
                        "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "496",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::ParkListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::ParkListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
                    Activities =
                    [
                        new()
                        {
                            ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3",
                            Name = "Guided Tours",
                        },
                    ],
                    Addresses =
                    [
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "2 Officers Row",
                            Line2 = "Yellowstone National Park Headquarters",
                            Line3 = "",
                            PostalCode = "82190",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Physical,
                        },
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "P.O. Box 168",
                            Line2 = "",
                            Line3 = "",
                            PostalCode = "82190-0168",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Mailing,
                        },
                    ],
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
                                Type = Parks::PhoneNumberType.Voice,
                            },
                        ],
                    },
                    Description =
                        "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
                    Designation = "National Park",
                    DirectionsInfo =
                        "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
                    DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
                    EntranceFees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description = "7-day pass for Yellowstone National Park",
                            Title = "Yellowstone (private, non-commercial vehicle)",
                        },
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                            Title = "Yellowstone (motorcycle or snowmobile)",
                        },
                    ],
                    EntrancePasses =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                            Title = "Yellowstone National Park Annual Pass",
                        },
                    ],
                    FullName = "Yellowstone National Park",
                    Images =
                    [
                        new()
                        {
                            AltText = "Crowd watching Aurum Geyser erupt",
                            Caption = "Aurum Geyser Erupting",
                            Credit = "NPS/Jim Peaco",
                            Title = "Aurum Geyser",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                        },
                        new()
                        {
                            AltText = "Photo of bison in Lamar Valley",
                            Caption = "Bison in Lamar Valley",
                            Credit = "NPS/Neal Herbert",
                            Title = "Bison in Lamar Valley",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                        },
                    ],
                    Latitude = "39.9818229675293",
                    LatLong = "lat:44.59824417, long:-110.5471695",
                    Longitude = "-84.0711364746094",
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
                    Name = "Yellowstone",
                    OperatingHours =
                    [
                        new()
                        {
                            Description =
                                "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Thanksgiving Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Christmas Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "All Park Hours",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                        new()
                        {
                            Description =
                                "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "name",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "West Entrance",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                    ],
                    ParkCode = "yell",
                    RelevanceScore = 1,
                    States = "ID,MT,WY",
                    Topics =
                    [
                        new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" },
                    ],
                    Url = "https://www.nps.gov/yell/index.htm",
                    WeatherInfo =
                        "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "496",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::ParkListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Parks::Data> expectedData =
        [
            new()
            {
                ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
                Activities =
                [
                    new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
                ],
                Addresses =
                [
                    new()
                    {
                        City = "Yellowstone National Park",
                        CountryCode = "US",
                        Line1 = "2 Officers Row",
                        Line2 = "Yellowstone National Park Headquarters",
                        Line3 = "",
                        PostalCode = "82190",
                        ProvinceTerritoryCode = "",
                        StateCode = "WY",
                        Type = Parks::Type.Physical,
                    },
                    new()
                    {
                        City = "Yellowstone National Park",
                        CountryCode = "US",
                        Line1 = "P.O. Box 168",
                        Line2 = "",
                        Line3 = "",
                        PostalCode = "82190-0168",
                        ProvinceTerritoryCode = "",
                        StateCode = "WY",
                        Type = Parks::Type.Mailing,
                    },
                ],
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
                            Type = Parks::PhoneNumberType.Voice,
                        },
                    ],
                },
                Description =
                    "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
                Designation = "National Park",
                DirectionsInfo =
                    "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
                DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
                EntranceFees =
                [
                    new()
                    {
                        Cost = "cost",
                        Description = "7-day pass for Yellowstone National Park",
                        Title = "Yellowstone (private, non-commercial vehicle)",
                    },
                    new()
                    {
                        Cost = "cost",
                        Description =
                            "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                        Title = "Yellowstone (motorcycle or snowmobile)",
                    },
                ],
                EntrancePasses =
                [
                    new()
                    {
                        Cost = "cost",
                        Description =
                            "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                        Title = "Yellowstone National Park Annual Pass",
                    },
                ],
                FullName = "Yellowstone National Park",
                Images =
                [
                    new()
                    {
                        AltText = "Crowd watching Aurum Geyser erupt",
                        Caption = "Aurum Geyser Erupting",
                        Credit = "NPS/Jim Peaco",
                        Title = "Aurum Geyser",
                        Url =
                            "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                    },
                    new()
                    {
                        AltText = "Photo of bison in Lamar Valley",
                        Caption = "Bison in Lamar Valley",
                        Credit = "NPS/Neal Herbert",
                        Title = "Bison in Lamar Valley",
                        Url =
                            "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                    },
                ],
                Latitude = "39.9818229675293",
                LatLong = "lat:44.59824417, long:-110.5471695",
                Longitude = "-84.0711364746094",
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
                Name = "Yellowstone",
                OperatingHours =
                [
                    new()
                    {
                        Description =
                            "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                        Exceptions =
                        [
                            new()
                            {
                                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                ExceptionHours = new()
                                {
                                    Friday = "friday",
                                    Monday = "monday",
                                    Saturday = "saturday",
                                    Sunday = "sunday",
                                    Thursday = "thursday",
                                    Tuesday = "tuesday",
                                    Wednesday = "wednesday",
                                },
                                Name = "Thanksgiving Day",
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                            new()
                            {
                                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                ExceptionHours = new()
                                {
                                    Friday = "friday",
                                    Monday = "monday",
                                    Saturday = "saturday",
                                    Sunday = "sunday",
                                    Thursday = "thursday",
                                    Tuesday = "tuesday",
                                    Wednesday = "wednesday",
                                },
                                Name = "Christmas Day",
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                        ],
                        Name = "All Park Hours",
                        StandardHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                    },
                    new()
                    {
                        Description =
                            "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                        Exceptions =
                        [
                            new()
                            {
                                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                ExceptionHours = new()
                                {
                                    Friday = "friday",
                                    Monday = "monday",
                                    Saturday = "saturday",
                                    Sunday = "sunday",
                                    Thursday = "thursday",
                                    Tuesday = "tuesday",
                                    Wednesday = "wednesday",
                                },
                                Name = "name",
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            },
                        ],
                        Name = "West Entrance",
                        StandardHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                    },
                ],
                ParkCode = "yell",
                RelevanceScore = 1,
                States = "ID,MT,WY",
                Topics = [new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" }],
                Url = "https://www.nps.gov/yell/index.htm",
                WeatherInfo =
                    "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "496";

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
        var model = new Parks::ParkListResponse
        {
            Data =
            [
                new()
                {
                    ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
                    Activities =
                    [
                        new()
                        {
                            ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3",
                            Name = "Guided Tours",
                        },
                    ],
                    Addresses =
                    [
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "2 Officers Row",
                            Line2 = "Yellowstone National Park Headquarters",
                            Line3 = "",
                            PostalCode = "82190",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Physical,
                        },
                        new()
                        {
                            City = "Yellowstone National Park",
                            CountryCode = "US",
                            Line1 = "P.O. Box 168",
                            Line2 = "",
                            Line3 = "",
                            PostalCode = "82190-0168",
                            ProvinceTerritoryCode = "",
                            StateCode = "WY",
                            Type = Parks::Type.Mailing,
                        },
                    ],
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
                                Type = Parks::PhoneNumberType.Voice,
                            },
                        ],
                    },
                    Description =
                        "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
                    Designation = "National Park",
                    DirectionsInfo =
                        "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
                    DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
                    EntranceFees =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description = "7-day pass for Yellowstone National Park",
                            Title = "Yellowstone (private, non-commercial vehicle)",
                        },
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                            Title = "Yellowstone (motorcycle or snowmobile)",
                        },
                    ],
                    EntrancePasses =
                    [
                        new()
                        {
                            Cost = "cost",
                            Description =
                                "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                            Title = "Yellowstone National Park Annual Pass",
                        },
                    ],
                    FullName = "Yellowstone National Park",
                    Images =
                    [
                        new()
                        {
                            AltText = "Crowd watching Aurum Geyser erupt",
                            Caption = "Aurum Geyser Erupting",
                            Credit = "NPS/Jim Peaco",
                            Title = "Aurum Geyser",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                        },
                        new()
                        {
                            AltText = "Photo of bison in Lamar Valley",
                            Caption = "Bison in Lamar Valley",
                            Credit = "NPS/Neal Herbert",
                            Title = "Bison in Lamar Valley",
                            Url =
                                "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                        },
                    ],
                    Latitude = "39.9818229675293",
                    LatLong = "lat:44.59824417, long:-110.5471695",
                    Longitude = "-84.0711364746094",
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
                    Name = "Yellowstone",
                    OperatingHours =
                    [
                        new()
                        {
                            Description =
                                "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Thanksgiving Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "Christmas Day",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "All Park Hours",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                        new()
                        {
                            Description =
                                "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                            Exceptions =
                            [
                                new()
                                {
                                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                    ExceptionHours = new()
                                    {
                                        Friday = "friday",
                                        Monday = "monday",
                                        Saturday = "saturday",
                                        Sunday = "sunday",
                                        Thursday = "thursday",
                                        Tuesday = "tuesday",
                                        Wednesday = "wednesday",
                                    },
                                    Name = "name",
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                },
                            ],
                            Name = "West Entrance",
                            StandardHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                        },
                    ],
                    ParkCode = "yell",
                    RelevanceScore = 1,
                    States = "ID,MT,WY",
                    Topics =
                    [
                        new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" },
                    ],
                    Url = "https://www.nps.gov/yell/index.htm",
                    WeatherInfo =
                        "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                },
            ],
            Limit = "50",
            Start = "0",
            Total = "496",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::ParkListResponse { };

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
        var model = new Parks::ParkListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::ParkListResponse
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
        var model = new Parks::ParkListResponse
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
        var model = new Parks::Data
        {
            ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
            Activities =
            [
                new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
            ],
            Addresses =
            [
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "2 Officers Row",
                    Line2 = "Yellowstone National Park Headquarters",
                    Line3 = "",
                    PostalCode = "82190",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Physical,
                },
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "P.O. Box 168",
                    Line2 = "",
                    Line3 = "",
                    PostalCode = "82190-0168",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Mailing,
                },
            ],
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
                        Type = Parks::PhoneNumberType.Voice,
                    },
                ],
            },
            Description =
                "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
            Designation = "National Park",
            DirectionsInfo =
                "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
            DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
            EntranceFees =
            [
                new()
                {
                    Cost = "cost",
                    Description = "7-day pass for Yellowstone National Park",
                    Title = "Yellowstone (private, non-commercial vehicle)",
                },
                new()
                {
                    Cost = "cost",
                    Description =
                        "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                    Title = "Yellowstone (motorcycle or snowmobile)",
                },
            ],
            EntrancePasses =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                    Title = "Yellowstone National Park Annual Pass",
                },
            ],
            FullName = "Yellowstone National Park",
            Images =
            [
                new()
                {
                    AltText = "Crowd watching Aurum Geyser erupt",
                    Caption = "Aurum Geyser Erupting",
                    Credit = "NPS/Jim Peaco",
                    Title = "Aurum Geyser",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                },
                new()
                {
                    AltText = "Photo of bison in Lamar Valley",
                    Caption = "Bison in Lamar Valley",
                    Credit = "NPS/Neal Herbert",
                    Title = "Bison in Lamar Valley",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                },
            ],
            Latitude = "39.9818229675293",
            LatLong = "lat:44.59824417, long:-110.5471695",
            Longitude = "-84.0711364746094",
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
            Name = "Yellowstone",
            OperatingHours =
            [
                new()
                {
                    Description =
                        "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Thanksgiving Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Christmas Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "All Park Hours",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
                new()
                {
                    Description =
                        "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "name",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "West Entrance",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
            ],
            ParkCode = "yell",
            RelevanceScore = 1,
            States = "ID,MT,WY",
            Topics = [new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" }],
            Url = "https://www.nps.gov/yell/index.htm",
            WeatherInfo =
                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
        };

        string expectedID = "F58C6D24-8D10-4573-9826-65D42B8B83AD";
        List<Parks::Activity> expectedActivities =
        [
            new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
        ];
        List<Parks::Address> expectedAddresses =
        [
            new()
            {
                City = "Yellowstone National Park",
                CountryCode = "US",
                Line1 = "2 Officers Row",
                Line2 = "Yellowstone National Park Headquarters",
                Line3 = "",
                PostalCode = "82190",
                ProvinceTerritoryCode = "",
                StateCode = "WY",
                Type = Parks::Type.Physical,
            },
            new()
            {
                City = "Yellowstone National Park",
                CountryCode = "US",
                Line1 = "P.O. Box 168",
                Line2 = "",
                Line3 = "",
                PostalCode = "82190-0168",
                ProvinceTerritoryCode = "",
                StateCode = "WY",
                Type = Parks::Type.Mailing,
            },
        ];
        Parks::Contacts expectedContacts = new()
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
                    Type = Parks::PhoneNumberType.Voice,
                },
            ],
        };
        string expectedDescription =
            "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'";
        string expectedDesignation = "National Park";
        string expectedDirectionsInfo =
            "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.";
        string expectedDirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm";
        List<Parks::EntranceFee> expectedEntranceFees =
        [
            new()
            {
                Cost = "cost",
                Description = "7-day pass for Yellowstone National Park",
                Title = "Yellowstone (private, non-commercial vehicle)",
            },
            new()
            {
                Cost = "cost",
                Description =
                    "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                Title = "Yellowstone (motorcycle or snowmobile)",
            },
        ];
        List<Parks::EntrancePass> expectedEntrancePasses =
        [
            new()
            {
                Cost = "cost",
                Description =
                    "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                Title = "Yellowstone National Park Annual Pass",
            },
        ];
        string expectedFullName = "Yellowstone National Park";
        List<Parks::Image> expectedImages =
        [
            new()
            {
                AltText = "Crowd watching Aurum Geyser erupt",
                Caption = "Aurum Geyser Erupting",
                Credit = "NPS/Jim Peaco",
                Title = "Aurum Geyser",
                Url =
                    "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
            },
            new()
            {
                AltText = "Photo of bison in Lamar Valley",
                Caption = "Bison in Lamar Valley",
                Credit = "NPS/Neal Herbert",
                Title = "Bison in Lamar Valley",
                Url =
                    "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
            },
        ];
        string expectedLatitude = "39.9818229675293";
        string expectedLatLong = "lat:44.59824417, long:-110.5471695";
        string expectedLongitude = "-84.0711364746094";
        List<Parks::DataMultimedia> expectedMultimedia =
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
        string expectedName = "Yellowstone";
        List<Parks::OperatingHour> expectedOperatingHours =
        [
            new()
            {
                Description =
                    "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                Exceptions =
                [
                    new()
                    {
                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        ExceptionHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                        Name = "Thanksgiving Day",
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                    new()
                    {
                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        ExceptionHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                        Name = "Christmas Day",
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                ],
                Name = "All Park Hours",
                StandardHours = new()
                {
                    Friday = "friday",
                    Monday = "monday",
                    Saturday = "saturday",
                    Sunday = "sunday",
                    Thursday = "thursday",
                    Tuesday = "tuesday",
                    Wednesday = "wednesday",
                },
            },
            new()
            {
                Description =
                    "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                Exceptions =
                [
                    new()
                    {
                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        ExceptionHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                        Name = "name",
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                ],
                Name = "West Entrance",
                StandardHours = new()
                {
                    Friday = "friday",
                    Monday = "monday",
                    Saturday = "saturday",
                    Sunday = "sunday",
                    Thursday = "thursday",
                    Tuesday = "tuesday",
                    Wednesday = "wednesday",
                },
            },
        ];
        string expectedParkCode = "yell";
        double expectedRelevanceScore = 1;
        string expectedStates = "ID,MT,WY";
        List<Parks::Topic> expectedTopics =
        [
            new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" },
        ];
        string expectedUrl = "https://www.nps.gov/yell/index.htm";
        string expectedWeatherInfo =
            "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.";

        Assert.Equal(expectedID, model.ID);
        Assert.NotNull(model.Activities);
        Assert.Equal(expectedActivities.Count, model.Activities.Count);
        for (int i = 0; i < expectedActivities.Count; i++)
        {
            Assert.Equal(expectedActivities[i], model.Activities[i]);
        }
        Assert.NotNull(model.Addresses);
        Assert.Equal(expectedAddresses.Count, model.Addresses.Count);
        for (int i = 0; i < expectedAddresses.Count; i++)
        {
            Assert.Equal(expectedAddresses[i], model.Addresses[i]);
        }
        Assert.Equal(expectedContacts, model.Contacts);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedDirectionsInfo, model.DirectionsInfo);
        Assert.Equal(expectedDirectionsUrl, model.DirectionsUrl);
        Assert.NotNull(model.EntranceFees);
        Assert.Equal(expectedEntranceFees.Count, model.EntranceFees.Count);
        for (int i = 0; i < expectedEntranceFees.Count; i++)
        {
            Assert.Equal(expectedEntranceFees[i], model.EntranceFees[i]);
        }
        Assert.NotNull(model.EntrancePasses);
        Assert.Equal(expectedEntrancePasses.Count, model.EntrancePasses.Count);
        for (int i = 0; i < expectedEntrancePasses.Count; i++)
        {
            Assert.Equal(expectedEntrancePasses[i], model.EntrancePasses[i]);
        }
        Assert.Equal(expectedFullName, model.FullName);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLatLong, model.LatLong);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.NotNull(model.Multimedia);
        Assert.Equal(expectedMultimedia.Count, model.Multimedia.Count);
        for (int i = 0; i < expectedMultimedia.Count; i++)
        {
            Assert.Equal(expectedMultimedia[i], model.Multimedia[i]);
        }
        Assert.Equal(expectedName, model.Name);
        Assert.NotNull(model.OperatingHours);
        Assert.Equal(expectedOperatingHours.Count, model.OperatingHours.Count);
        for (int i = 0; i < expectedOperatingHours.Count; i++)
        {
            Assert.Equal(expectedOperatingHours[i], model.OperatingHours[i]);
        }
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedRelevanceScore, model.RelevanceScore);
        Assert.Equal(expectedStates, model.States);
        Assert.NotNull(model.Topics);
        Assert.Equal(expectedTopics.Count, model.Topics.Count);
        for (int i = 0; i < expectedTopics.Count; i++)
        {
            Assert.Equal(expectedTopics[i], model.Topics[i]);
        }
        Assert.Equal(expectedUrl, model.Url);
        Assert.Equal(expectedWeatherInfo, model.WeatherInfo);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::Data
        {
            ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
            Activities =
            [
                new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
            ],
            Addresses =
            [
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "2 Officers Row",
                    Line2 = "Yellowstone National Park Headquarters",
                    Line3 = "",
                    PostalCode = "82190",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Physical,
                },
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "P.O. Box 168",
                    Line2 = "",
                    Line3 = "",
                    PostalCode = "82190-0168",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Mailing,
                },
            ],
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
                        Type = Parks::PhoneNumberType.Voice,
                    },
                ],
            },
            Description =
                "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
            Designation = "National Park",
            DirectionsInfo =
                "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
            DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
            EntranceFees =
            [
                new()
                {
                    Cost = "cost",
                    Description = "7-day pass for Yellowstone National Park",
                    Title = "Yellowstone (private, non-commercial vehicle)",
                },
                new()
                {
                    Cost = "cost",
                    Description =
                        "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                    Title = "Yellowstone (motorcycle or snowmobile)",
                },
            ],
            EntrancePasses =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                    Title = "Yellowstone National Park Annual Pass",
                },
            ],
            FullName = "Yellowstone National Park",
            Images =
            [
                new()
                {
                    AltText = "Crowd watching Aurum Geyser erupt",
                    Caption = "Aurum Geyser Erupting",
                    Credit = "NPS/Jim Peaco",
                    Title = "Aurum Geyser",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                },
                new()
                {
                    AltText = "Photo of bison in Lamar Valley",
                    Caption = "Bison in Lamar Valley",
                    Credit = "NPS/Neal Herbert",
                    Title = "Bison in Lamar Valley",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                },
            ],
            Latitude = "39.9818229675293",
            LatLong = "lat:44.59824417, long:-110.5471695",
            Longitude = "-84.0711364746094",
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
            Name = "Yellowstone",
            OperatingHours =
            [
                new()
                {
                    Description =
                        "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Thanksgiving Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Christmas Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "All Park Hours",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
                new()
                {
                    Description =
                        "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "name",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "West Entrance",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
            ],
            ParkCode = "yell",
            RelevanceScore = 1,
            States = "ID,MT,WY",
            Topics = [new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" }],
            Url = "https://www.nps.gov/yell/index.htm",
            WeatherInfo =
                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::Data
        {
            ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
            Activities =
            [
                new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
            ],
            Addresses =
            [
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "2 Officers Row",
                    Line2 = "Yellowstone National Park Headquarters",
                    Line3 = "",
                    PostalCode = "82190",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Physical,
                },
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "P.O. Box 168",
                    Line2 = "",
                    Line3 = "",
                    PostalCode = "82190-0168",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Mailing,
                },
            ],
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
                        Type = Parks::PhoneNumberType.Voice,
                    },
                ],
            },
            Description =
                "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
            Designation = "National Park",
            DirectionsInfo =
                "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
            DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
            EntranceFees =
            [
                new()
                {
                    Cost = "cost",
                    Description = "7-day pass for Yellowstone National Park",
                    Title = "Yellowstone (private, non-commercial vehicle)",
                },
                new()
                {
                    Cost = "cost",
                    Description =
                        "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                    Title = "Yellowstone (motorcycle or snowmobile)",
                },
            ],
            EntrancePasses =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                    Title = "Yellowstone National Park Annual Pass",
                },
            ],
            FullName = "Yellowstone National Park",
            Images =
            [
                new()
                {
                    AltText = "Crowd watching Aurum Geyser erupt",
                    Caption = "Aurum Geyser Erupting",
                    Credit = "NPS/Jim Peaco",
                    Title = "Aurum Geyser",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                },
                new()
                {
                    AltText = "Photo of bison in Lamar Valley",
                    Caption = "Bison in Lamar Valley",
                    Credit = "NPS/Neal Herbert",
                    Title = "Bison in Lamar Valley",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                },
            ],
            Latitude = "39.9818229675293",
            LatLong = "lat:44.59824417, long:-110.5471695",
            Longitude = "-84.0711364746094",
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
            Name = "Yellowstone",
            OperatingHours =
            [
                new()
                {
                    Description =
                        "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Thanksgiving Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Christmas Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "All Park Hours",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
                new()
                {
                    Description =
                        "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "name",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "West Entrance",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
            ],
            ParkCode = "yell",
            RelevanceScore = 1,
            States = "ID,MT,WY",
            Topics = [new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" }],
            Url = "https://www.nps.gov/yell/index.htm",
            WeatherInfo =
                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "F58C6D24-8D10-4573-9826-65D42B8B83AD";
        List<Parks::Activity> expectedActivities =
        [
            new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
        ];
        List<Parks::Address> expectedAddresses =
        [
            new()
            {
                City = "Yellowstone National Park",
                CountryCode = "US",
                Line1 = "2 Officers Row",
                Line2 = "Yellowstone National Park Headquarters",
                Line3 = "",
                PostalCode = "82190",
                ProvinceTerritoryCode = "",
                StateCode = "WY",
                Type = Parks::Type.Physical,
            },
            new()
            {
                City = "Yellowstone National Park",
                CountryCode = "US",
                Line1 = "P.O. Box 168",
                Line2 = "",
                Line3 = "",
                PostalCode = "82190-0168",
                ProvinceTerritoryCode = "",
                StateCode = "WY",
                Type = Parks::Type.Mailing,
            },
        ];
        Parks::Contacts expectedContacts = new()
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
                    Type = Parks::PhoneNumberType.Voice,
                },
            ],
        };
        string expectedDescription =
            "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'";
        string expectedDesignation = "National Park";
        string expectedDirectionsInfo =
            "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.";
        string expectedDirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm";
        List<Parks::EntranceFee> expectedEntranceFees =
        [
            new()
            {
                Cost = "cost",
                Description = "7-day pass for Yellowstone National Park",
                Title = "Yellowstone (private, non-commercial vehicle)",
            },
            new()
            {
                Cost = "cost",
                Description =
                    "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                Title = "Yellowstone (motorcycle or snowmobile)",
            },
        ];
        List<Parks::EntrancePass> expectedEntrancePasses =
        [
            new()
            {
                Cost = "cost",
                Description =
                    "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                Title = "Yellowstone National Park Annual Pass",
            },
        ];
        string expectedFullName = "Yellowstone National Park";
        List<Parks::Image> expectedImages =
        [
            new()
            {
                AltText = "Crowd watching Aurum Geyser erupt",
                Caption = "Aurum Geyser Erupting",
                Credit = "NPS/Jim Peaco",
                Title = "Aurum Geyser",
                Url =
                    "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
            },
            new()
            {
                AltText = "Photo of bison in Lamar Valley",
                Caption = "Bison in Lamar Valley",
                Credit = "NPS/Neal Herbert",
                Title = "Bison in Lamar Valley",
                Url =
                    "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
            },
        ];
        string expectedLatitude = "39.9818229675293";
        string expectedLatLong = "lat:44.59824417, long:-110.5471695";
        string expectedLongitude = "-84.0711364746094";
        List<Parks::DataMultimedia> expectedMultimedia =
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
        string expectedName = "Yellowstone";
        List<Parks::OperatingHour> expectedOperatingHours =
        [
            new()
            {
                Description =
                    "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                Exceptions =
                [
                    new()
                    {
                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        ExceptionHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                        Name = "Thanksgiving Day",
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                    new()
                    {
                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        ExceptionHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                        Name = "Christmas Day",
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                ],
                Name = "All Park Hours",
                StandardHours = new()
                {
                    Friday = "friday",
                    Monday = "monday",
                    Saturday = "saturday",
                    Sunday = "sunday",
                    Thursday = "thursday",
                    Tuesday = "tuesday",
                    Wednesday = "wednesday",
                },
            },
            new()
            {
                Description =
                    "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                Exceptions =
                [
                    new()
                    {
                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        ExceptionHours = new()
                        {
                            Friday = "friday",
                            Monday = "monday",
                            Saturday = "saturday",
                            Sunday = "sunday",
                            Thursday = "thursday",
                            Tuesday = "tuesday",
                            Wednesday = "wednesday",
                        },
                        Name = "name",
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                ],
                Name = "West Entrance",
                StandardHours = new()
                {
                    Friday = "friday",
                    Monday = "monday",
                    Saturday = "saturday",
                    Sunday = "sunday",
                    Thursday = "thursday",
                    Tuesday = "tuesday",
                    Wednesday = "wednesday",
                },
            },
        ];
        string expectedParkCode = "yell";
        double expectedRelevanceScore = 1;
        string expectedStates = "ID,MT,WY";
        List<Parks::Topic> expectedTopics =
        [
            new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" },
        ];
        string expectedUrl = "https://www.nps.gov/yell/index.htm";
        string expectedWeatherInfo =
            "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.NotNull(deserialized.Activities);
        Assert.Equal(expectedActivities.Count, deserialized.Activities.Count);
        for (int i = 0; i < expectedActivities.Count; i++)
        {
            Assert.Equal(expectedActivities[i], deserialized.Activities[i]);
        }
        Assert.NotNull(deserialized.Addresses);
        Assert.Equal(expectedAddresses.Count, deserialized.Addresses.Count);
        for (int i = 0; i < expectedAddresses.Count; i++)
        {
            Assert.Equal(expectedAddresses[i], deserialized.Addresses[i]);
        }
        Assert.Equal(expectedContacts, deserialized.Contacts);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedDirectionsInfo, deserialized.DirectionsInfo);
        Assert.Equal(expectedDirectionsUrl, deserialized.DirectionsUrl);
        Assert.NotNull(deserialized.EntranceFees);
        Assert.Equal(expectedEntranceFees.Count, deserialized.EntranceFees.Count);
        for (int i = 0; i < expectedEntranceFees.Count; i++)
        {
            Assert.Equal(expectedEntranceFees[i], deserialized.EntranceFees[i]);
        }
        Assert.NotNull(deserialized.EntrancePasses);
        Assert.Equal(expectedEntrancePasses.Count, deserialized.EntrancePasses.Count);
        for (int i = 0; i < expectedEntrancePasses.Count; i++)
        {
            Assert.Equal(expectedEntrancePasses[i], deserialized.EntrancePasses[i]);
        }
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLatLong, deserialized.LatLong);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.NotNull(deserialized.Multimedia);
        Assert.Equal(expectedMultimedia.Count, deserialized.Multimedia.Count);
        for (int i = 0; i < expectedMultimedia.Count; i++)
        {
            Assert.Equal(expectedMultimedia[i], deserialized.Multimedia[i]);
        }
        Assert.Equal(expectedName, deserialized.Name);
        Assert.NotNull(deserialized.OperatingHours);
        Assert.Equal(expectedOperatingHours.Count, deserialized.OperatingHours.Count);
        for (int i = 0; i < expectedOperatingHours.Count; i++)
        {
            Assert.Equal(expectedOperatingHours[i], deserialized.OperatingHours[i]);
        }
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedRelevanceScore, deserialized.RelevanceScore);
        Assert.Equal(expectedStates, deserialized.States);
        Assert.NotNull(deserialized.Topics);
        Assert.Equal(expectedTopics.Count, deserialized.Topics.Count);
        for (int i = 0; i < expectedTopics.Count; i++)
        {
            Assert.Equal(expectedTopics[i], deserialized.Topics[i]);
        }
        Assert.Equal(expectedUrl, deserialized.Url);
        Assert.Equal(expectedWeatherInfo, deserialized.WeatherInfo);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::Data
        {
            ID = "F58C6D24-8D10-4573-9826-65D42B8B83AD",
            Activities =
            [
                new() { ID = "B33DC9B6-0B7D-4322-BAD7-A13A34C584A3", Name = "Guided Tours" },
            ],
            Addresses =
            [
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "2 Officers Row",
                    Line2 = "Yellowstone National Park Headquarters",
                    Line3 = "",
                    PostalCode = "82190",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Physical,
                },
                new()
                {
                    City = "Yellowstone National Park",
                    CountryCode = "US",
                    Line1 = "P.O. Box 168",
                    Line2 = "",
                    Line3 = "",
                    PostalCode = "82190-0168",
                    ProvinceTerritoryCode = "",
                    StateCode = "WY",
                    Type = Parks::Type.Mailing,
                },
            ],
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
                        Type = Parks::PhoneNumberType.Voice,
                    },
                ],
            },
            Description =
                "Visit Yellowstone and experience the world's first national park. Marvel at a volcano's hidden power rising up in colorful hot springs, mudpots, and geysers. Explore mountains, forests, and lakes to watch wildlife and witness the drama of the natural world unfold. Discover the history that led to the conservation of our national treasures 'for the benefit and enjoyment of the people.'",
            Designation = "National Park",
            DirectionsInfo =
                "Yellowstone National Park covers nearly 3,500 square miles in the northwest corner of Wyoming (3% of the park is in Montana and 1% is in Idaho). Yellowstone has five entrance stations, and several are closed to regular vehicles during winter. It takes many hours to drive between these entrances, so be sure to check the status of roads at the entrance you intend to use while planning your trip and before you arrive.",
            DirectionsUrl = "https://www.nps.gov/yell/planyourvisit/directions.htm",
            EntranceFees =
            [
                new()
                {
                    Cost = "cost",
                    Description = "7-day pass for Yellowstone National Park",
                    Title = "Yellowstone (private, non-commercial vehicle)",
                },
                new()
                {
                    Cost = "cost",
                    Description =
                        "7-day pass for Yellowstone National Park. Snowmobile entry limited to guided tours or permit holders.",
                    Title = "Yellowstone (motorcycle or snowmobile)",
                },
            ],
            EntrancePasses =
            [
                new()
                {
                    Cost = "cost",
                    Description =
                        "Annual pass providing free entrance to Yellowstone National Park for one year; valid through the month of purchase. Winter use: On a snowmobile, admits the signers and children (residing in the same household under the age of 21). In a snowcoach or shuttle, it admits the signers and up to three additional persons (16 and older) for a total of four people.",
                    Title = "Yellowstone National Park Annual Pass",
                },
            ],
            FullName = "Yellowstone National Park",
            Images =
            [
                new()
                {
                    AltText = "Crowd watching Aurum Geyser erupt",
                    Caption = "Aurum Geyser Erupting",
                    Credit = "NPS/Jim Peaco",
                    Title = "Aurum Geyser",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D2FBB-1DD8-B71B-0BED99731011CFCE.jpg",
                },
                new()
                {
                    AltText = "Photo of bison in Lamar Valley",
                    Caption = "Bison in Lamar Valley",
                    Credit = "NPS/Neal Herbert",
                    Title = "Bison in Lamar Valley",
                    Url =
                        "https://www.nps.gov/common/uploads/structured_data/3C7D34E6-1DD8-B71B-0BBB1C0F478318E2.jpg",
                },
            ],
            Latitude = "39.9818229675293",
            LatLong = "lat:44.59824417, long:-110.5471695",
            Longitude = "-84.0711364746094",
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
            Name = "Yellowstone",
            OperatingHours =
            [
                new()
                {
                    Description =
                        "Yellowstone is open daily, year-round, although activities and services are limited at night and certain times of year. The park has five entrance stations, but not all entrance stations are open year-round. Make sure to carefully read about access at each station at different times of year. And remember, all dates are weather dependent!\n\nPlease note that camping is possible only in designated campgrounds.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Thanksgiving Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "Christmas Day",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "All Park Hours",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
                new()
                {
                    Description =
                        "Adjacent to the town of West Yellowstone, MT, the West Entrance is usually open (weather dependent) to wheeled vehicles from the third Friday in April through early November, and to tracked-oversnow (snowmobiles and snowcoaches) vehicles from December 15 to March 15.",
                    Exceptions =
                    [
                        new()
                        {
                            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                            ExceptionHours = new()
                            {
                                Friday = "friday",
                                Monday = "monday",
                                Saturday = "saturday",
                                Sunday = "sunday",
                                Thursday = "thursday",
                                Tuesday = "tuesday",
                                Wednesday = "wednesday",
                            },
                            Name = "name",
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        },
                    ],
                    Name = "West Entrance",
                    StandardHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                },
            ],
            ParkCode = "yell",
            RelevanceScore = 1,
            States = "ID,MT,WY",
            Topics = [new() { ID = "B912363F-771C-4098-BA3A-938DF38A9D7E", Name = "Aviation" }],
            Url = "https://www.nps.gov/yell/index.htm",
            WeatherInfo =
                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Activities);
        Assert.False(model.RawData.ContainsKey("activities"));
        Assert.Null(model.Addresses);
        Assert.False(model.RawData.ContainsKey("addresses"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.DirectionsInfo);
        Assert.False(model.RawData.ContainsKey("directionsInfo"));
        Assert.Null(model.DirectionsUrl);
        Assert.False(model.RawData.ContainsKey("directionsUrl"));
        Assert.Null(model.EntranceFees);
        Assert.False(model.RawData.ContainsKey("entranceFees"));
        Assert.Null(model.EntrancePasses);
        Assert.False(model.RawData.ContainsKey("entrancePasses"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.Multimedia);
        Assert.False(model.RawData.ContainsKey("multimedia"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.OperatingHours);
        Assert.False(model.RawData.ContainsKey("operatingHours"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Topics);
        Assert.False(model.RawData.ContainsKey("topics"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.WeatherInfo);
        Assert.False(model.RawData.ContainsKey("weatherInfo"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::Data { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Activities = null,
            Addresses = null,
            Contacts = null,
            Description = null,
            Designation = null,
            DirectionsInfo = null,
            DirectionsUrl = null,
            EntranceFees = null,
            EntrancePasses = null,
            FullName = null,
            Images = null,
            Latitude = null,
            LatLong = null,
            Longitude = null,
            Multimedia = null,
            Name = null,
            OperatingHours = null,
            ParkCode = null,
            RelevanceScore = null,
            States = null,
            Topics = null,
            Url = null,
            WeatherInfo = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Activities);
        Assert.False(model.RawData.ContainsKey("activities"));
        Assert.Null(model.Addresses);
        Assert.False(model.RawData.ContainsKey("addresses"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Designation);
        Assert.False(model.RawData.ContainsKey("designation"));
        Assert.Null(model.DirectionsInfo);
        Assert.False(model.RawData.ContainsKey("directionsInfo"));
        Assert.Null(model.DirectionsUrl);
        Assert.False(model.RawData.ContainsKey("directionsUrl"));
        Assert.Null(model.EntranceFees);
        Assert.False(model.RawData.ContainsKey("entranceFees"));
        Assert.Null(model.EntrancePasses);
        Assert.False(model.RawData.ContainsKey("entrancePasses"));
        Assert.Null(model.FullName);
        Assert.False(model.RawData.ContainsKey("fullName"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.Multimedia);
        Assert.False(model.RawData.ContainsKey("multimedia"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.OperatingHours);
        Assert.False(model.RawData.ContainsKey("operatingHours"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
        Assert.Null(model.Topics);
        Assert.False(model.RawData.ContainsKey("topics"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.WeatherInfo);
        Assert.False(model.RawData.ContainsKey("weatherInfo"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Parks::Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Activities = null,
            Addresses = null,
            Contacts = null,
            Description = null,
            Designation = null,
            DirectionsInfo = null,
            DirectionsUrl = null,
            EntranceFees = null,
            EntrancePasses = null,
            FullName = null,
            Images = null,
            Latitude = null,
            LatLong = null,
            Longitude = null,
            Multimedia = null,
            Name = null,
            OperatingHours = null,
            ParkCode = null,
            RelevanceScore = null,
            States = null,
            Topics = null,
            Url = null,
            WeatherInfo = null,
        };

        model.Validate();
    }
}

public class ActivityTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::Activity { ID = "id", Name = "name" };

        string expectedID = "id";
        string expectedName = "name";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::Activity { ID = "id", Name = "name" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Activity>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::Activity { ID = "id", Name = "name" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Activity>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedName = "name";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::Activity { ID = "id", Name = "name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::Activity { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::Activity { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::Activity
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Parks::Activity
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        model.Validate();
    }
}

public class AddressTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = Parks::Type.Physical,
        };

        string expectedCity = "city";
        string expectedCountryCode = "US";
        string expectedLine1 = "line1";
        string expectedLine2 = "line2";
        string expectedLine3 = "line3";
        string expectedPostalCode = "postalCode";
        string expectedProvinceTerritoryCode = "";
        string expectedStateCode = "stateCode";
        ApiEnum<string, Parks::Type> expectedType = Parks::Type.Physical;

        Assert.Equal(expectedCity, model.City);
        Assert.Equal(expectedCountryCode, model.CountryCode);
        Assert.Equal(expectedLine1, model.Line1);
        Assert.Equal(expectedLine2, model.Line2);
        Assert.Equal(expectedLine3, model.Line3);
        Assert.Equal(expectedPostalCode, model.PostalCode);
        Assert.Equal(expectedProvinceTerritoryCode, model.ProvinceTerritoryCode);
        Assert.Equal(expectedStateCode, model.StateCode);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = Parks::Type.Physical,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Address>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = Parks::Type.Physical,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Address>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCity = "city";
        string expectedCountryCode = "US";
        string expectedLine1 = "line1";
        string expectedLine2 = "line2";
        string expectedLine3 = "line3";
        string expectedPostalCode = "postalCode";
        string expectedProvinceTerritoryCode = "";
        string expectedStateCode = "stateCode";
        ApiEnum<string, Parks::Type> expectedType = Parks::Type.Physical;

        Assert.Equal(expectedCity, deserialized.City);
        Assert.Equal(expectedCountryCode, deserialized.CountryCode);
        Assert.Equal(expectedLine1, deserialized.Line1);
        Assert.Equal(expectedLine2, deserialized.Line2);
        Assert.Equal(expectedLine3, deserialized.Line3);
        Assert.Equal(expectedPostalCode, deserialized.PostalCode);
        Assert.Equal(expectedProvinceTerritoryCode, deserialized.ProvinceTerritoryCode);
        Assert.Equal(expectedStateCode, deserialized.StateCode);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = Parks::Type.Physical,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::Address { };

        Assert.Null(model.City);
        Assert.False(model.RawData.ContainsKey("city"));
        Assert.Null(model.CountryCode);
        Assert.False(model.RawData.ContainsKey("countryCode"));
        Assert.Null(model.Line1);
        Assert.False(model.RawData.ContainsKey("line1"));
        Assert.Null(model.Line2);
        Assert.False(model.RawData.ContainsKey("line2"));
        Assert.Null(model.Line3);
        Assert.False(model.RawData.ContainsKey("line3"));
        Assert.Null(model.PostalCode);
        Assert.False(model.RawData.ContainsKey("postalCode"));
        Assert.Null(model.ProvinceTerritoryCode);
        Assert.False(model.RawData.ContainsKey("provinceTerritoryCode"));
        Assert.Null(model.StateCode);
        Assert.False(model.RawData.ContainsKey("stateCode"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::Address { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::Address
        {
            // Null should be interpreted as omitted for these properties
            City = null,
            CountryCode = null,
            Line1 = null,
            Line2 = null,
            Line3 = null,
            PostalCode = null,
            ProvinceTerritoryCode = null,
            StateCode = null,
            Type = null,
        };

        Assert.Null(model.City);
        Assert.False(model.RawData.ContainsKey("city"));
        Assert.Null(model.CountryCode);
        Assert.False(model.RawData.ContainsKey("countryCode"));
        Assert.Null(model.Line1);
        Assert.False(model.RawData.ContainsKey("line1"));
        Assert.Null(model.Line2);
        Assert.False(model.RawData.ContainsKey("line2"));
        Assert.Null(model.Line3);
        Assert.False(model.RawData.ContainsKey("line3"));
        Assert.Null(model.PostalCode);
        Assert.False(model.RawData.ContainsKey("postalCode"));
        Assert.Null(model.ProvinceTerritoryCode);
        Assert.False(model.RawData.ContainsKey("provinceTerritoryCode"));
        Assert.Null(model.StateCode);
        Assert.False(model.RawData.ContainsKey("stateCode"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Parks::Address
        {
            // Null should be interpreted as omitted for these properties
            City = null,
            CountryCode = null,
            Line1 = null,
            Line2 = null,
            Line3 = null,
            PostalCode = null,
            ProvinceTerritoryCode = null,
            StateCode = null,
            Type = null,
        };

        model.Validate();
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Parks::Type.Physical)]
    [InlineData(Parks::Type.Mailing)]
    public void Validation_Works(Parks::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Parks::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Parks::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Parks::Type.Physical)]
    [InlineData(Parks::Type.Mailing)]
    public void SerializationRoundtrip_Works(Parks::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Parks::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Parks::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Parks::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Parks::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ContactsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::Contacts
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
                    Type = Parks::PhoneNumberType.Voice,
                },
            ],
        };

        List<Parks::EmailAddress> expectedEmailAddresses =
        [
            new() { Description = "description", EmailAddressValue = "emailAddress" },
        ];
        List<Parks::PhoneNumber> expectedPhoneNumbers =
        [
            new()
            {
                Description = "description",
                Extension = "extension",
                PhoneNumberValue = "phoneNumber",
                Type = Parks::PhoneNumberType.Voice,
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
        var model = new Parks::Contacts
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
                    Type = Parks::PhoneNumberType.Voice,
                },
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Contacts>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::Contacts
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
                    Type = Parks::PhoneNumberType.Voice,
                },
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Contacts>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Parks::EmailAddress> expectedEmailAddresses =
        [
            new() { Description = "description", EmailAddressValue = "emailAddress" },
        ];
        List<Parks::PhoneNumber> expectedPhoneNumbers =
        [
            new()
            {
                Description = "description",
                Extension = "extension",
                PhoneNumberValue = "phoneNumber",
                Type = Parks::PhoneNumberType.Voice,
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
        var model = new Parks::Contacts
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
                    Type = Parks::PhoneNumberType.Voice,
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::Contacts { };

        Assert.Null(model.EmailAddresses);
        Assert.False(model.RawData.ContainsKey("emailAddresses"));
        Assert.Null(model.PhoneNumbers);
        Assert.False(model.RawData.ContainsKey("phoneNumbers"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::Contacts { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::Contacts
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
        var model = new Parks::Contacts
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
        var model = new Parks::EmailAddress
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
        var model = new Parks::EmailAddress
        {
            Description = "description",
            EmailAddressValue = "emailAddress",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::EmailAddress>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::EmailAddress
        {
            Description = "description",
            EmailAddressValue = "emailAddress",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::EmailAddress>(
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
        var model = new Parks::EmailAddress
        {
            Description = "description",
            EmailAddressValue = "emailAddress",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::EmailAddress { };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.EmailAddressValue);
        Assert.False(model.RawData.ContainsKey("emailAddress"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::EmailAddress { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::EmailAddress
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
        var model = new Parks::EmailAddress
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
        var model = new Parks::PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Parks::PhoneNumberType.Voice,
        };

        string expectedDescription = "description";
        string expectedExtension = "extension";
        string expectedPhoneNumberValue = "phoneNumber";
        ApiEnum<string, Parks::PhoneNumberType> expectedType = Parks::PhoneNumberType.Voice;

        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedExtension, model.Extension);
        Assert.Equal(expectedPhoneNumberValue, model.PhoneNumberValue);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Parks::PhoneNumberType.Voice,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::PhoneNumber>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Parks::PhoneNumberType.Voice,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::PhoneNumber>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        string expectedExtension = "extension";
        string expectedPhoneNumberValue = "phoneNumber";
        ApiEnum<string, Parks::PhoneNumberType> expectedType = Parks::PhoneNumberType.Voice;

        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedExtension, deserialized.Extension);
        Assert.Equal(expectedPhoneNumberValue, deserialized.PhoneNumberValue);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::PhoneNumber
        {
            Description = "description",
            Extension = "extension",
            PhoneNumberValue = "phoneNumber",
            Type = Parks::PhoneNumberType.Voice,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::PhoneNumber { };

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
        var model = new Parks::PhoneNumber { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::PhoneNumber
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
        var model = new Parks::PhoneNumber
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

public class PhoneNumberTypeTest : TestBase
{
    [Theory]
    [InlineData(Parks::PhoneNumberType.Voice)]
    [InlineData(Parks::PhoneNumberType.Fax)]
    [InlineData(Parks::PhoneNumberType.Tty)]
    public void Validation_Works(Parks::PhoneNumberType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Parks::PhoneNumberType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Parks::PhoneNumberType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Parks::PhoneNumberType.Voice)]
    [InlineData(Parks::PhoneNumberType.Fax)]
    [InlineData(Parks::PhoneNumberType.Tty)]
    public void SerializationRoundtrip_Works(Parks::PhoneNumberType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Parks::PhoneNumberType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Parks::PhoneNumberType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Parks::PhoneNumberType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Parks::PhoneNumberType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class EntranceFeeTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::EntranceFee
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        string expectedCost = "cost";
        string expectedDescription = "description";
        string expectedTitle = "title";

        Assert.Equal(expectedCost, model.Cost);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedTitle, model.Title);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::EntranceFee
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::EntranceFee>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::EntranceFee
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::EntranceFee>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCost = "cost";
        string expectedDescription = "description";
        string expectedTitle = "title";

        Assert.Equal(expectedCost, deserialized.Cost);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedTitle, deserialized.Title);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::EntranceFee
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::EntranceFee { };

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
        var model = new Parks::EntranceFee { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::EntranceFee
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
        var model = new Parks::EntranceFee
        {
            // Null should be interpreted as omitted for these properties
            Cost = null,
            Description = null,
            Title = null,
        };

        model.Validate();
    }
}

public class EntrancePassTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::EntrancePass
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        string expectedCost = "cost";
        string expectedDescription = "description";
        string expectedTitle = "title";

        Assert.Equal(expectedCost, model.Cost);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedTitle, model.Title);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::EntrancePass
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::EntrancePass>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::EntrancePass
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::EntrancePass>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCost = "cost";
        string expectedDescription = "description";
        string expectedTitle = "title";

        Assert.Equal(expectedCost, deserialized.Cost);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedTitle, deserialized.Title);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::EntrancePass
        {
            Cost = "cost",
            Description = "description",
            Title = "title",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::EntrancePass { };

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
        var model = new Parks::EntrancePass { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::EntrancePass
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
        var model = new Parks::EntrancePass
        {
            // Null should be interpreted as omitted for these properties
            Cost = null,
            Description = null,
            Title = null,
        };

        model.Validate();
    }
}

public class ImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Title = "title",
            Url = "url",
        };

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Title = "title",
            Url = "url",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Image>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Image>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Title = "title",
            Url = "url",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::Image { };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::Image { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::Image
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Parks::Image
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
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
        var model = new Parks::DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
        };

        string expectedID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883";
        string expectedTitle = "The Worthington Farm";
        string expectedType = "multimedia/videos";
        string expectedUrl =
            "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::DataMultimedia>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::DataMultimedia>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883";
        string expectedTitle = "The Worthington Farm";
        string expectedType = "multimedia/videos";
        string expectedUrl =
            "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::DataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::DataMultimedia { };

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
        var model = new Parks::DataMultimedia { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::DataMultimedia
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
        var model = new Parks::DataMultimedia
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

public class OperatingHourTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExceptionHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                    Name = "name",
                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
            ],
            Name = "name",
            StandardHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
        };

        string expectedDescription = "description";
        List<Parks::Exception> expectedExceptions =
        [
            new()
            {
                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExceptionHours = new()
                {
                    Friday = "friday",
                    Monday = "monday",
                    Saturday = "saturday",
                    Sunday = "sunday",
                    Thursday = "thursday",
                    Tuesday = "tuesday",
                    Wednesday = "wednesday",
                },
                Name = "name",
                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        ];
        string expectedName = "name";
        Parks::StandardHours expectedStandardHours = new()
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
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
        var model = new Parks::OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExceptionHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                    Name = "name",
                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
            ],
            Name = "name",
            StandardHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::OperatingHour>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExceptionHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                    Name = "name",
                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
            ],
            Name = "name",
            StandardHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::OperatingHour>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        List<Parks::Exception> expectedExceptions =
        [
            new()
            {
                EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExceptionHours = new()
                {
                    Friday = "friday",
                    Monday = "monday",
                    Saturday = "saturday",
                    Sunday = "sunday",
                    Thursday = "thursday",
                    Tuesday = "tuesday",
                    Wednesday = "wednesday",
                },
                Name = "name",
                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        ];
        string expectedName = "name";
        Parks::StandardHours expectedStandardHours = new()
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
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
        var model = new Parks::OperatingHour
        {
            Description = "description",
            Exceptions =
            [
                new()
                {
                    EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExceptionHours = new()
                    {
                        Friday = "friday",
                        Monday = "monday",
                        Saturday = "saturday",
                        Sunday = "sunday",
                        Thursday = "thursday",
                        Tuesday = "tuesday",
                        Wednesday = "wednesday",
                    },
                    Name = "name",
                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
            ],
            Name = "name",
            StandardHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::OperatingHour { };

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
        var model = new Parks::OperatingHour { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::OperatingHour
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
        var model = new Parks::OperatingHour
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
        var model = new Parks::Exception
        {
            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExceptionHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
            Name = "name",
            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        DateTimeOffset expectedEndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Parks::ExceptionHours expectedExceptionHours = new()
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };
        string expectedName = "name";
        DateTimeOffset expectedStartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedEndDate, model.EndDate);
        Assert.Equal(expectedExceptionHours, model.ExceptionHours);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedStartDate, model.StartDate);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::Exception
        {
            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExceptionHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
            Name = "name",
            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Exception>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::Exception
        {
            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExceptionHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
            Name = "name",
            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Exception>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedEndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Parks::ExceptionHours expectedExceptionHours = new()
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };
        string expectedName = "name";
        DateTimeOffset expectedStartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedEndDate, deserialized.EndDate);
        Assert.Equal(expectedExceptionHours, deserialized.ExceptionHours);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedStartDate, deserialized.StartDate);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::Exception
        {
            EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExceptionHours = new()
            {
                Friday = "friday",
                Monday = "monday",
                Saturday = "saturday",
                Sunday = "sunday",
                Thursday = "thursday",
                Tuesday = "tuesday",
                Wednesday = "wednesday",
            },
            Name = "name",
            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::Exception { };

        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("endDate"));
        Assert.Null(model.ExceptionHours);
        Assert.False(model.RawData.ContainsKey("exceptionHours"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("startDate"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::Exception { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::Exception
        {
            // Null should be interpreted as omitted for these properties
            EndDate = null,
            ExceptionHours = null,
            Name = null,
            StartDate = null,
        };

        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("endDate"));
        Assert.Null(model.ExceptionHours);
        Assert.False(model.RawData.ContainsKey("exceptionHours"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("startDate"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Parks::Exception
        {
            // Null should be interpreted as omitted for these properties
            EndDate = null,
            ExceptionHours = null,
            Name = null,
            StartDate = null,
        };

        model.Validate();
    }
}

public class ExceptionHoursTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::ExceptionHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string expectedFriday = "friday";
        string expectedMonday = "monday";
        string expectedSaturday = "saturday";
        string expectedSunday = "sunday";
        string expectedThursday = "thursday";
        string expectedTuesday = "tuesday";
        string expectedWednesday = "wednesday";

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
        var model = new Parks::ExceptionHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::ExceptionHours>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::ExceptionHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::ExceptionHours>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedFriday = "friday";
        string expectedMonday = "monday";
        string expectedSaturday = "saturday";
        string expectedSunday = "sunday";
        string expectedThursday = "thursday";
        string expectedTuesday = "tuesday";
        string expectedWednesday = "wednesday";

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
        var model = new Parks::ExceptionHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::ExceptionHours { };

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
        var model = new Parks::ExceptionHours { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::ExceptionHours
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
        var model = new Parks::ExceptionHours
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

public class StandardHoursTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::StandardHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string expectedFriday = "friday";
        string expectedMonday = "monday";
        string expectedSaturday = "saturday";
        string expectedSunday = "sunday";
        string expectedThursday = "thursday";
        string expectedTuesday = "tuesday";
        string expectedWednesday = "wednesday";

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
        var model = new Parks::StandardHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::StandardHours>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::StandardHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::StandardHours>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedFriday = "friday";
        string expectedMonday = "monday";
        string expectedSaturday = "saturday";
        string expectedSunday = "sunday";
        string expectedThursday = "thursday";
        string expectedTuesday = "tuesday";
        string expectedWednesday = "wednesday";

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
        var model = new Parks::StandardHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::StandardHours { };

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
        var model = new Parks::StandardHours { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::StandardHours
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
        var model = new Parks::StandardHours
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

public class TopicTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::Topic { ID = "id", Name = "name" };

        string expectedID = "id";
        string expectedName = "name";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parks::Topic { ID = "id", Name = "name" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Topic>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::Topic { ID = "id", Name = "name" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Parks::Topic>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedName = "name";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parks::Topic { ID = "id", Name = "name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parks::Topic { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parks::Topic { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::Topic
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Parks::Topic
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        model.Validate();
    }
}
