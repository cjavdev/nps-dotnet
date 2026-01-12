using System;
using System.Collections.Generic;
using System.Text.Json;
using VisitorCenters = Nps.Models.VisitorCenters;

namespace Nps.Tests.Models.VisitorCenters;

public class VisitorCenterListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::VisitorCenterListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0",
                            Addresses =
                            [
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Physical,
                                },
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "1000 US Hwy 36",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Mailing,
                                },
                            ],
                            Amenities =
                            [
                                "Food/Drink - Snacks",
                                "Information - Maps Available",
                                "Information - Park Newspaper Available",
                                "Information - Ranger/Staff Member Present",
                                "Toilet - Vault/Composting",
                            ],
                            AudioDescription = "",
                            Contacts = ["string"],
                            Description =
                                "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.",
                            DirectionsInfo =
                                "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.",
                            DirectionsUrl = "",
                            GeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "A long rectangular building with large logs on the roof.",
                                    Caption = "The Alpine Visitor Center in the height of summer.",
                                    Credit = "NPS Photo / Ann Schonlau",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A040051-E81A-FA40-C7A5F1E24F6E78D0.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Visitors hike a trail above the Alpine Visitor Center.",
                                    Caption =
                                        "The Alpine Ridge Trail leads from the visitor center up many steps to a scenic overlook.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center from Alpine Ridge Trail",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A0C8153-E844-CFEC-D3AC2F043EBC0051.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Staff dig out Alpine Visitor Center from feet of snow.",
                                    Caption =
                                        "The Alpine Visitor Center is covered by snow all winter long and has to be dug out every May.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Digging Out the Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A15D77D-CD52-A8C6-CBA0E70A85617516.jpg",
                                },
                            ],
                            IsPassportStampLocation = true,
                            LastIndexedDate = "",
                            Latitude = "40.44103093774664",
                            LatLong = "{lat:40.44103093774664, lng:-105.75452021953589}",
                            Longitude = "-105.75452021953589",
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
                            Name = "Alpine Visitor Center",
                            OperatingHours =
                            [
                                new()
                                {
                                    Description =
                                        "Alpine Visitor Center is closed for the winter season. Check back for the 2023 Summer Schedule.",
                                    Exceptions =
                                    [
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                            ExceptionHours = new()
                                            {
                                                Friday = "10:30AM - 4:30PM",
                                                Monday = "10:30AM - 4:30PM",
                                                Saturday = "10:30AM - 4:30PM",
                                                Sunday = "10:30AM - 4:30PM",
                                                Thursday = "10:30AM - 4:30PM",
                                                Tuesday = "10:30AM - 4:30PM",
                                                Wednesday = "10:30AM - 4:30PM",
                                            },
                                            Name =
                                                "Reduced hours in late Spring (weather permitting)",
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
                                                Friday = "Closed",
                                                Monday = "Closed",
                                                Saturday = "Closed",
                                                Sunday = "Closed",
                                                Thursday = "Closed",
                                                Tuesday = "Closed",
                                                Wednesday = "Closed",
                                            },
                                            Name = "Mid-Fall through late Spring",
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                    ],
                                    Name = "Alpine Visitor Center",
                                    StandardHours = new()
                                    {
                                        Friday = "Closed",
                                        Monday = "Closed",
                                        Saturday = "Closed",
                                        Sunday = "Closed",
                                        Thursday = "Closed",
                                        Tuesday = "Closed",
                                        Wednesday = "Closed",
                                    },
                                },
                            ],
                            ParkCode = "romo",
                            PassportStampImages =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops = [new() { AspectRatio = 0, Url = "url" }],
                                    Description = "description",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            PassportStampLocationDescription = "",
                            RelevanceScore = 1,
                            Url = "",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "584",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<VisitorCenters::VisitorCenterListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0",
                        Addresses =
                        [
                            new()
                            {
                                City = "Estes Park",
                                CountryCode = "US",
                                Line1 = "",
                                Line2 = "",
                                Line3 = "",
                                PostalCode = "80517",
                                ProvinceTerritoryCode = "",
                                StateCode = "CO",
                                Type = VisitorCenters::Type.Physical,
                            },
                            new()
                            {
                                City = "Estes Park",
                                CountryCode = "US",
                                Line1 = "1000 US Hwy 36",
                                Line2 = "",
                                Line3 = "",
                                PostalCode = "80517",
                                ProvinceTerritoryCode = "",
                                StateCode = "CO",
                                Type = VisitorCenters::Type.Mailing,
                            },
                        ],
                        Amenities =
                        [
                            "Food/Drink - Snacks",
                            "Information - Maps Available",
                            "Information - Park Newspaper Available",
                            "Information - Ranger/Staff Member Present",
                            "Toilet - Vault/Composting",
                        ],
                        AudioDescription = "",
                        Contacts = ["string"],
                        Description =
                            "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.",
                        DirectionsInfo =
                            "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.",
                        DirectionsUrl = "",
                        GeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622",
                        Images =
                        [
                            new()
                            {
                                AltText =
                                    "A long rectangular building with large logs on the roof.",
                                Caption = "The Alpine Visitor Center in the height of summer.",
                                Credit = "NPS Photo / Ann Schonlau",
                                Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                Title = "Alpine Visitor Center",
                                Url =
                                    "https://www.nps.gov/common/uploads/structured_data/1A040051-E81A-FA40-C7A5F1E24F6E78D0.jpg",
                            },
                            new()
                            {
                                AltText = "Visitors hike a trail above the Alpine Visitor Center.",
                                Caption =
                                    "The Alpine Ridge Trail leads from the visitor center up many steps to a scenic overlook.",
                                Credit = "NPS Photo",
                                Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                Title = "Alpine Visitor Center from Alpine Ridge Trail",
                                Url =
                                    "https://www.nps.gov/common/uploads/structured_data/1A0C8153-E844-CFEC-D3AC2F043EBC0051.jpg",
                            },
                            new()
                            {
                                AltText = "Staff dig out Alpine Visitor Center from feet of snow.",
                                Caption =
                                    "The Alpine Visitor Center is covered by snow all winter long and has to be dug out every May.",
                                Credit = "NPS Photo",
                                Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                Title = "Digging Out the Alpine Visitor Center",
                                Url =
                                    "https://www.nps.gov/common/uploads/structured_data/1A15D77D-CD52-A8C6-CBA0E70A85617516.jpg",
                            },
                        ],
                        IsPassportStampLocation = true,
                        LastIndexedDate = "",
                        Latitude = "40.44103093774664",
                        LatLong = "{lat:40.44103093774664, lng:-105.75452021953589}",
                        Longitude = "-105.75452021953589",
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
                        Name = "Alpine Visitor Center",
                        OperatingHours =
                        [
                            new()
                            {
                                Description =
                                    "Alpine Visitor Center is closed for the winter season. Check back for the 2023 Summer Schedule.",
                                Exceptions =
                                [
                                    new()
                                    {
                                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                        ExceptionHours = new()
                                        {
                                            Friday = "10:30AM - 4:30PM",
                                            Monday = "10:30AM - 4:30PM",
                                            Saturday = "10:30AM - 4:30PM",
                                            Sunday = "10:30AM - 4:30PM",
                                            Thursday = "10:30AM - 4:30PM",
                                            Tuesday = "10:30AM - 4:30PM",
                                            Wednesday = "10:30AM - 4:30PM",
                                        },
                                        Name = "Reduced hours in late Spring (weather permitting)",
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
                                    },
                                    new()
                                    {
                                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                        ExceptionHours = new()
                                        {
                                            Friday = "Closed",
                                            Monday = "Closed",
                                            Saturday = "Closed",
                                            Sunday = "Closed",
                                            Thursday = "Closed",
                                            Tuesday = "Closed",
                                            Wednesday = "Closed",
                                        },
                                        Name = "Mid-Fall through late Spring",
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
                                    },
                                ],
                                Name = "Alpine Visitor Center",
                                StandardHours = new()
                                {
                                    Friday = "Closed",
                                    Monday = "Closed",
                                    Saturday = "Closed",
                                    Sunday = "Closed",
                                    Thursday = "Closed",
                                    Tuesday = "Closed",
                                    Wednesday = "Closed",
                                },
                            },
                        ],
                        ParkCode = "romo",
                        PassportStampImages =
                        [
                            new()
                            {
                                AltText = "altText",
                                Caption = "caption",
                                Credit = "credit",
                                Crops = [new() { AspectRatio = 0, Url = "url" }],
                                Description = "description",
                                Title = "title",
                                Url = "url",
                            },
                        ],
                        PassportStampLocationDescription = "",
                        RelevanceScore = 1,
                        Url = "",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "584",
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
        var model = new VisitorCenters::VisitorCenterListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0",
                            Addresses =
                            [
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Physical,
                                },
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "1000 US Hwy 36",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Mailing,
                                },
                            ],
                            Amenities =
                            [
                                "Food/Drink - Snacks",
                                "Information - Maps Available",
                                "Information - Park Newspaper Available",
                                "Information - Ranger/Staff Member Present",
                                "Toilet - Vault/Composting",
                            ],
                            AudioDescription = "",
                            Contacts = ["string"],
                            Description =
                                "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.",
                            DirectionsInfo =
                                "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.",
                            DirectionsUrl = "",
                            GeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "A long rectangular building with large logs on the roof.",
                                    Caption = "The Alpine Visitor Center in the height of summer.",
                                    Credit = "NPS Photo / Ann Schonlau",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A040051-E81A-FA40-C7A5F1E24F6E78D0.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Visitors hike a trail above the Alpine Visitor Center.",
                                    Caption =
                                        "The Alpine Ridge Trail leads from the visitor center up many steps to a scenic overlook.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center from Alpine Ridge Trail",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A0C8153-E844-CFEC-D3AC2F043EBC0051.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Staff dig out Alpine Visitor Center from feet of snow.",
                                    Caption =
                                        "The Alpine Visitor Center is covered by snow all winter long and has to be dug out every May.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Digging Out the Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A15D77D-CD52-A8C6-CBA0E70A85617516.jpg",
                                },
                            ],
                            IsPassportStampLocation = true,
                            LastIndexedDate = "",
                            Latitude = "40.44103093774664",
                            LatLong = "{lat:40.44103093774664, lng:-105.75452021953589}",
                            Longitude = "-105.75452021953589",
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
                            Name = "Alpine Visitor Center",
                            OperatingHours =
                            [
                                new()
                                {
                                    Description =
                                        "Alpine Visitor Center is closed for the winter season. Check back for the 2023 Summer Schedule.",
                                    Exceptions =
                                    [
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                            ExceptionHours = new()
                                            {
                                                Friday = "10:30AM - 4:30PM",
                                                Monday = "10:30AM - 4:30PM",
                                                Saturday = "10:30AM - 4:30PM",
                                                Sunday = "10:30AM - 4:30PM",
                                                Thursday = "10:30AM - 4:30PM",
                                                Tuesday = "10:30AM - 4:30PM",
                                                Wednesday = "10:30AM - 4:30PM",
                                            },
                                            Name =
                                                "Reduced hours in late Spring (weather permitting)",
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
                                                Friday = "Closed",
                                                Monday = "Closed",
                                                Saturday = "Closed",
                                                Sunday = "Closed",
                                                Thursday = "Closed",
                                                Tuesday = "Closed",
                                                Wednesday = "Closed",
                                            },
                                            Name = "Mid-Fall through late Spring",
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                    ],
                                    Name = "Alpine Visitor Center",
                                    StandardHours = new()
                                    {
                                        Friday = "Closed",
                                        Monday = "Closed",
                                        Saturday = "Closed",
                                        Sunday = "Closed",
                                        Thursday = "Closed",
                                        Tuesday = "Closed",
                                        Wednesday = "Closed",
                                    },
                                },
                            ],
                            ParkCode = "romo",
                            PassportStampImages =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops = [new() { AspectRatio = 0, Url = "url" }],
                                    Description = "description",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            PassportStampLocationDescription = "",
                            RelevanceScore = 1,
                            Url = "",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "584",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<VisitorCenters::VisitorCenterListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::VisitorCenterListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0",
                            Addresses =
                            [
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Physical,
                                },
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "1000 US Hwy 36",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Mailing,
                                },
                            ],
                            Amenities =
                            [
                                "Food/Drink - Snacks",
                                "Information - Maps Available",
                                "Information - Park Newspaper Available",
                                "Information - Ranger/Staff Member Present",
                                "Toilet - Vault/Composting",
                            ],
                            AudioDescription = "",
                            Contacts = ["string"],
                            Description =
                                "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.",
                            DirectionsInfo =
                                "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.",
                            DirectionsUrl = "",
                            GeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "A long rectangular building with large logs on the roof.",
                                    Caption = "The Alpine Visitor Center in the height of summer.",
                                    Credit = "NPS Photo / Ann Schonlau",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A040051-E81A-FA40-C7A5F1E24F6E78D0.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Visitors hike a trail above the Alpine Visitor Center.",
                                    Caption =
                                        "The Alpine Ridge Trail leads from the visitor center up many steps to a scenic overlook.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center from Alpine Ridge Trail",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A0C8153-E844-CFEC-D3AC2F043EBC0051.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Staff dig out Alpine Visitor Center from feet of snow.",
                                    Caption =
                                        "The Alpine Visitor Center is covered by snow all winter long and has to be dug out every May.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Digging Out the Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A15D77D-CD52-A8C6-CBA0E70A85617516.jpg",
                                },
                            ],
                            IsPassportStampLocation = true,
                            LastIndexedDate = "",
                            Latitude = "40.44103093774664",
                            LatLong = "{lat:40.44103093774664, lng:-105.75452021953589}",
                            Longitude = "-105.75452021953589",
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
                            Name = "Alpine Visitor Center",
                            OperatingHours =
                            [
                                new()
                                {
                                    Description =
                                        "Alpine Visitor Center is closed for the winter season. Check back for the 2023 Summer Schedule.",
                                    Exceptions =
                                    [
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                            ExceptionHours = new()
                                            {
                                                Friday = "10:30AM - 4:30PM",
                                                Monday = "10:30AM - 4:30PM",
                                                Saturday = "10:30AM - 4:30PM",
                                                Sunday = "10:30AM - 4:30PM",
                                                Thursday = "10:30AM - 4:30PM",
                                                Tuesday = "10:30AM - 4:30PM",
                                                Wednesday = "10:30AM - 4:30PM",
                                            },
                                            Name =
                                                "Reduced hours in late Spring (weather permitting)",
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
                                                Friday = "Closed",
                                                Monday = "Closed",
                                                Saturday = "Closed",
                                                Sunday = "Closed",
                                                Thursday = "Closed",
                                                Tuesday = "Closed",
                                                Wednesday = "Closed",
                                            },
                                            Name = "Mid-Fall through late Spring",
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                    ],
                                    Name = "Alpine Visitor Center",
                                    StandardHours = new()
                                    {
                                        Friday = "Closed",
                                        Monday = "Closed",
                                        Saturday = "Closed",
                                        Sunday = "Closed",
                                        Thursday = "Closed",
                                        Tuesday = "Closed",
                                        Wednesday = "Closed",
                                    },
                                },
                            ],
                            ParkCode = "romo",
                            PassportStampImages =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops = [new() { AspectRatio = 0, Url = "url" }],
                                    Description = "description",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            PassportStampLocationDescription = "",
                            RelevanceScore = 1,
                            Url = "",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "584",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<VisitorCenters::VisitorCenterListPageResponse>(element);
        Assert.NotNull(deserialized);

        List<VisitorCenters::VisitorCenterListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0",
                        Addresses =
                        [
                            new()
                            {
                                City = "Estes Park",
                                CountryCode = "US",
                                Line1 = "",
                                Line2 = "",
                                Line3 = "",
                                PostalCode = "80517",
                                ProvinceTerritoryCode = "",
                                StateCode = "CO",
                                Type = VisitorCenters::Type.Physical,
                            },
                            new()
                            {
                                City = "Estes Park",
                                CountryCode = "US",
                                Line1 = "1000 US Hwy 36",
                                Line2 = "",
                                Line3 = "",
                                PostalCode = "80517",
                                ProvinceTerritoryCode = "",
                                StateCode = "CO",
                                Type = VisitorCenters::Type.Mailing,
                            },
                        ],
                        Amenities =
                        [
                            "Food/Drink - Snacks",
                            "Information - Maps Available",
                            "Information - Park Newspaper Available",
                            "Information - Ranger/Staff Member Present",
                            "Toilet - Vault/Composting",
                        ],
                        AudioDescription = "",
                        Contacts = ["string"],
                        Description =
                            "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.",
                        DirectionsInfo =
                            "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.",
                        DirectionsUrl = "",
                        GeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622",
                        Images =
                        [
                            new()
                            {
                                AltText =
                                    "A long rectangular building with large logs on the roof.",
                                Caption = "The Alpine Visitor Center in the height of summer.",
                                Credit = "NPS Photo / Ann Schonlau",
                                Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                Title = "Alpine Visitor Center",
                                Url =
                                    "https://www.nps.gov/common/uploads/structured_data/1A040051-E81A-FA40-C7A5F1E24F6E78D0.jpg",
                            },
                            new()
                            {
                                AltText = "Visitors hike a trail above the Alpine Visitor Center.",
                                Caption =
                                    "The Alpine Ridge Trail leads from the visitor center up many steps to a scenic overlook.",
                                Credit = "NPS Photo",
                                Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                Title = "Alpine Visitor Center from Alpine Ridge Trail",
                                Url =
                                    "https://www.nps.gov/common/uploads/structured_data/1A0C8153-E844-CFEC-D3AC2F043EBC0051.jpg",
                            },
                            new()
                            {
                                AltText = "Staff dig out Alpine Visitor Center from feet of snow.",
                                Caption =
                                    "The Alpine Visitor Center is covered by snow all winter long and has to be dug out every May.",
                                Credit = "NPS Photo",
                                Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                Title = "Digging Out the Alpine Visitor Center",
                                Url =
                                    "https://www.nps.gov/common/uploads/structured_data/1A15D77D-CD52-A8C6-CBA0E70A85617516.jpg",
                            },
                        ],
                        IsPassportStampLocation = true,
                        LastIndexedDate = "",
                        Latitude = "40.44103093774664",
                        LatLong = "{lat:40.44103093774664, lng:-105.75452021953589}",
                        Longitude = "-105.75452021953589",
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
                        Name = "Alpine Visitor Center",
                        OperatingHours =
                        [
                            new()
                            {
                                Description =
                                    "Alpine Visitor Center is closed for the winter season. Check back for the 2023 Summer Schedule.",
                                Exceptions =
                                [
                                    new()
                                    {
                                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                        ExceptionHours = new()
                                        {
                                            Friday = "10:30AM - 4:30PM",
                                            Monday = "10:30AM - 4:30PM",
                                            Saturday = "10:30AM - 4:30PM",
                                            Sunday = "10:30AM - 4:30PM",
                                            Thursday = "10:30AM - 4:30PM",
                                            Tuesday = "10:30AM - 4:30PM",
                                            Wednesday = "10:30AM - 4:30PM",
                                        },
                                        Name = "Reduced hours in late Spring (weather permitting)",
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
                                    },
                                    new()
                                    {
                                        EndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                                        ExceptionHours = new()
                                        {
                                            Friday = "Closed",
                                            Monday = "Closed",
                                            Saturday = "Closed",
                                            Sunday = "Closed",
                                            Thursday = "Closed",
                                            Tuesday = "Closed",
                                            Wednesday = "Closed",
                                        },
                                        Name = "Mid-Fall through late Spring",
                                        StartDate = DateTimeOffset.Parse(
                                            "2019-12-27T18:11:19.117Z"
                                        ),
                                    },
                                ],
                                Name = "Alpine Visitor Center",
                                StandardHours = new()
                                {
                                    Friday = "Closed",
                                    Monday = "Closed",
                                    Saturday = "Closed",
                                    Sunday = "Closed",
                                    Thursday = "Closed",
                                    Tuesday = "Closed",
                                    Wednesday = "Closed",
                                },
                            },
                        ],
                        ParkCode = "romo",
                        PassportStampImages =
                        [
                            new()
                            {
                                AltText = "altText",
                                Caption = "caption",
                                Credit = "credit",
                                Crops = [new() { AspectRatio = 0, Url = "url" }],
                                Description = "description",
                                Title = "title",
                                Url = "url",
                            },
                        ],
                        PassportStampLocationDescription = "",
                        RelevanceScore = 1,
                        Url = "",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "584",
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
        var model = new VisitorCenters::VisitorCenterListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0",
                            Addresses =
                            [
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Physical,
                                },
                                new()
                                {
                                    City = "Estes Park",
                                    CountryCode = "US",
                                    Line1 = "1000 US Hwy 36",
                                    Line2 = "",
                                    Line3 = "",
                                    PostalCode = "80517",
                                    ProvinceTerritoryCode = "",
                                    StateCode = "CO",
                                    Type = VisitorCenters::Type.Mailing,
                                },
                            ],
                            Amenities =
                            [
                                "Food/Drink - Snacks",
                                "Information - Maps Available",
                                "Information - Park Newspaper Available",
                                "Information - Ranger/Staff Member Present",
                                "Toilet - Vault/Composting",
                            ],
                            AudioDescription = "",
                            Contacts = ["string"],
                            Description =
                                "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.",
                            DirectionsInfo =
                                "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.",
                            DirectionsUrl = "",
                            GeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "A long rectangular building with large logs on the roof.",
                                    Caption = "The Alpine Visitor Center in the height of summer.",
                                    Credit = "NPS Photo / Ann Schonlau",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A040051-E81A-FA40-C7A5F1E24F6E78D0.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Visitors hike a trail above the Alpine Visitor Center.",
                                    Caption =
                                        "The Alpine Ridge Trail leads from the visitor center up many steps to a scenic overlook.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Alpine Visitor Center from Alpine Ridge Trail",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A0C8153-E844-CFEC-D3AC2F043EBC0051.jpg",
                                },
                                new()
                                {
                                    AltText =
                                        "Staff dig out Alpine Visitor Center from feet of snow.",
                                    Caption =
                                        "The Alpine Visitor Center is covered by snow all winter long and has to be dug out every May.",
                                    Credit = "NPS Photo",
                                    Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
                                    Title = "Digging Out the Alpine Visitor Center",
                                    Url =
                                        "https://www.nps.gov/common/uploads/structured_data/1A15D77D-CD52-A8C6-CBA0E70A85617516.jpg",
                                },
                            ],
                            IsPassportStampLocation = true,
                            LastIndexedDate = "",
                            Latitude = "40.44103093774664",
                            LatLong = "{lat:40.44103093774664, lng:-105.75452021953589}",
                            Longitude = "-105.75452021953589",
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
                            Name = "Alpine Visitor Center",
                            OperatingHours =
                            [
                                new()
                                {
                                    Description =
                                        "Alpine Visitor Center is closed for the winter season. Check back for the 2023 Summer Schedule.",
                                    Exceptions =
                                    [
                                        new()
                                        {
                                            EndDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                            ExceptionHours = new()
                                            {
                                                Friday = "10:30AM - 4:30PM",
                                                Monday = "10:30AM - 4:30PM",
                                                Saturday = "10:30AM - 4:30PM",
                                                Sunday = "10:30AM - 4:30PM",
                                                Thursday = "10:30AM - 4:30PM",
                                                Tuesday = "10:30AM - 4:30PM",
                                                Wednesday = "10:30AM - 4:30PM",
                                            },
                                            Name =
                                                "Reduced hours in late Spring (weather permitting)",
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
                                                Friday = "Closed",
                                                Monday = "Closed",
                                                Saturday = "Closed",
                                                Sunday = "Closed",
                                                Thursday = "Closed",
                                                Tuesday = "Closed",
                                                Wednesday = "Closed",
                                            },
                                            Name = "Mid-Fall through late Spring",
                                            StartDate = DateTimeOffset.Parse(
                                                "2019-12-27T18:11:19.117Z"
                                            ),
                                        },
                                    ],
                                    Name = "Alpine Visitor Center",
                                    StandardHours = new()
                                    {
                                        Friday = "Closed",
                                        Monday = "Closed",
                                        Saturday = "Closed",
                                        Sunday = "Closed",
                                        Thursday = "Closed",
                                        Tuesday = "Closed",
                                        Wednesday = "Closed",
                                    },
                                },
                            ],
                            ParkCode = "romo",
                            PassportStampImages =
                            [
                                new()
                                {
                                    AltText = "altText",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops = [new() { AspectRatio = 0, Url = "url" }],
                                    Description = "description",
                                    Title = "title",
                                    Url = "url",
                                },
                            ],
                            PassportStampLocationDescription = "",
                            RelevanceScore = 1,
                            Url = "",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "584",
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
        var model = new VisitorCenters::VisitorCenterListPageResponse { };

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
        var model = new VisitorCenters::VisitorCenterListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::VisitorCenterListPageResponse
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
        var model = new VisitorCenters::VisitorCenterListPageResponse
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
