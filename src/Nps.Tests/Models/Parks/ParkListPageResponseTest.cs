using System;
using System.Collections.Generic;
using System.Text.Json;
using Parks = Nps.Models.Parks;

namespace Nps.Tests.Models.Parks;

public class ParkListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parks::ParkListPageResponse
        {
            Data =
            [
                new()
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                new()
                                {
                                    ID = "B912363F-771C-4098-BA3A-938DF38A9D7E",
                                    Name = "Aviation",
                                },
                            ],
                            Url = "https://www.nps.gov/yell/index.htm",
                            WeatherInfo =
                                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "496",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<Parks::ParkListResponse> expectedData =
        [
            new()
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
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
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
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
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
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
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
                            new()
                            {
                                ID = "B912363F-771C-4098-BA3A-938DF38A9D7E",
                                Name = "Aviation",
                            },
                        ],
                        Url = "https://www.nps.gov/yell/index.htm",
                        WeatherInfo =
                            "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "496",
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
        var model = new Parks::ParkListPageResponse
        {
            Data =
            [
                new()
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                new()
                                {
                                    ID = "B912363F-771C-4098-BA3A-938DF38A9D7E",
                                    Name = "Aviation",
                                },
                            ],
                            Url = "https://www.nps.gov/yell/index.htm",
                            WeatherInfo =
                                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "496",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Parks::ParkListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parks::ParkListPageResponse
        {
            Data =
            [
                new()
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                new()
                                {
                                    ID = "B912363F-771C-4098-BA3A-938DF38A9D7E",
                                    Name = "Aviation",
                                },
                            ],
                            Url = "https://www.nps.gov/yell/index.htm",
                            WeatherInfo =
                                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "496",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Parks::ParkListPageResponse>(element);
        Assert.NotNull(deserialized);

        List<Parks::ParkListResponse> expectedData =
        [
            new()
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
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
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
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
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
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
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
                            new()
                            {
                                ID = "B912363F-771C-4098-BA3A-938DF38A9D7E",
                                Name = "Aviation",
                            },
                        ],
                        Url = "https://www.nps.gov/yell/index.htm",
                        WeatherInfo =
                            "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "496",
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
        var model = new Parks::ParkListPageResponse
        {
            Data =
            [
                new()
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
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
                                new()
                                {
                                    ID = "B912363F-771C-4098-BA3A-938DF38A9D7E",
                                    Name = "Aviation",
                                },
                            ],
                            Url = "https://www.nps.gov/yell/index.htm",
                            WeatherInfo =
                                "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70F (25C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below zero, especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "496",
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
        var model = new Parks::ParkListPageResponse { };

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
        var model = new Parks::ParkListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parks::ParkListPageResponse
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
        var model = new Parks::ParkListPageResponse
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
