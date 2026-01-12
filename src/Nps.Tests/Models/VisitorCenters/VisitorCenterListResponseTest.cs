using System;
using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Exceptions;
using VisitorCenters = Nps.Models.VisitorCenters;

namespace Nps.Tests.Models.VisitorCenters;

public class VisitorCenterListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::VisitorCenterListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<VisitorCenters::Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new VisitorCenters::VisitorCenterListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::VisitorCenterListResponse>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::VisitorCenterListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::VisitorCenterListResponse>(
            element
        );
        Assert.NotNull(deserialized);

        List<VisitorCenters::Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new VisitorCenters::VisitorCenterListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::VisitorCenterListResponse { };

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
        var model = new VisitorCenters::VisitorCenterListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::VisitorCenterListResponse
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
        var model = new VisitorCenters::VisitorCenterListResponse
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
        var model = new VisitorCenters::Data
        {
            DataValue =
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
                            AltText = "A long rectangular building with large logs on the roof.",
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        List<VisitorCenters::DataData> expectedDataValue =
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
                        AltText = "A long rectangular building with large logs on the roof.",
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
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "584";

        Assert.NotNull(model.DataValue);
        Assert.Equal(expectedDataValue.Count, model.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], model.DataValue[i]);
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedStart, model.Start);
        Assert.Equal(expectedTotal, model.Total);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new VisitorCenters::Data
        {
            DataValue =
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
                            AltText = "A long rectangular building with large logs on the roof.",
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Data>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::Data
        {
            DataValue =
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
                            AltText = "A long rectangular building with large logs on the roof.",
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Data>(element);
        Assert.NotNull(deserialized);

        List<VisitorCenters::DataData> expectedDataValue =
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
                        AltText = "A long rectangular building with large logs on the roof.",
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
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                                StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "584";

        Assert.NotNull(deserialized.DataValue);
        Assert.Equal(expectedDataValue.Count, deserialized.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], deserialized.DataValue[i]);
        }
        Assert.Equal(expectedLimit, deserialized.Limit);
        Assert.Equal(expectedStart, deserialized.Start);
        Assert.Equal(expectedTotal, deserialized.Total);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new VisitorCenters::Data
        {
            DataValue =
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
                            AltText = "A long rectangular building with large logs on the roof.",
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                                    StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::Data { };

        Assert.Null(model.DataValue);
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
        var model = new VisitorCenters::Data { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::Data
        {
            // Null should be interpreted as omitted for these properties
            DataValue = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        Assert.Null(model.DataValue);
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
        var model = new VisitorCenters::Data
        {
            // Null should be interpreted as omitted for these properties
            DataValue = null,
            Limit = null,
            Start = null,
            Total = null,
        };

        model.Validate();
    }
}

public class DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::DataData
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
                    AltText = "A long rectangular building with large logs on the roof.",
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        string expectedID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0";
        List<VisitorCenters::Address> expectedAddresses =
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
        ];
        List<string> expectedAmenities =
        [
            "Food/Drink - Snacks",
            "Information - Maps Available",
            "Information - Park Newspaper Available",
            "Information - Ranger/Staff Member Present",
            "Toilet - Vault/Composting",
        ];
        string expectedAudioDescription = "";
        List<string> expectedContacts = ["string"];
        string expectedDescription =
            "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.";
        string expectedDirectionsInfo =
            "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.";
        string expectedDirectionsUrl = "";
        string expectedGeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622";
        List<VisitorCenters::Image> expectedImages =
        [
            new()
            {
                AltText = "A long rectangular building with large logs on the roof.",
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
        ];
        bool expectedIsPassportStampLocation = true;
        string expectedLastIndexedDate = "";
        string expectedLatitude = "40.44103093774664";
        string expectedLatLong = "{lat:40.44103093774664, lng:-105.75452021953589}";
        string expectedLongitude = "-105.75452021953589";
        List<VisitorCenters::DataDataMultimedia> expectedMultimedia =
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
        string expectedName = "Alpine Visitor Center";
        List<VisitorCenters::OperatingHour> expectedOperatingHours =
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
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        ];
        string expectedParkCode = "romo";
        List<VisitorCenters::PassportStampImage> expectedPassportStampImages =
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
        ];
        string expectedPassportStampLocationDescription = "";
        double expectedRelevanceScore = 1;
        string expectedUrl = "";

        Assert.Equal(expectedID, model.ID);
        Assert.NotNull(model.Addresses);
        Assert.Equal(expectedAddresses.Count, model.Addresses.Count);
        for (int i = 0; i < expectedAddresses.Count; i++)
        {
            Assert.Equal(expectedAddresses[i], model.Addresses[i]);
        }
        Assert.NotNull(model.Amenities);
        Assert.Equal(expectedAmenities.Count, model.Amenities.Count);
        for (int i = 0; i < expectedAmenities.Count; i++)
        {
            Assert.Equal(expectedAmenities[i], model.Amenities[i]);
        }
        Assert.Equal(expectedAudioDescription, model.AudioDescription);
        Assert.NotNull(model.Contacts);
        Assert.Equal(expectedContacts.Count, model.Contacts.Count);
        for (int i = 0; i < expectedContacts.Count; i++)
        {
            Assert.Equal(expectedContacts[i], model.Contacts[i]);
        }
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDirectionsInfo, model.DirectionsInfo);
        Assert.Equal(expectedDirectionsUrl, model.DirectionsUrl);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedIsPassportStampLocation, model.IsPassportStampLocation);
        Assert.Equal(expectedLastIndexedDate, model.LastIndexedDate);
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
        Assert.NotNull(model.PassportStampImages);
        Assert.Equal(expectedPassportStampImages.Count, model.PassportStampImages.Count);
        for (int i = 0; i < expectedPassportStampImages.Count; i++)
        {
            Assert.Equal(expectedPassportStampImages[i], model.PassportStampImages[i]);
        }
        Assert.Equal(
            expectedPassportStampLocationDescription,
            model.PassportStampLocationDescription
        );
        Assert.Equal(expectedRelevanceScore, model.RelevanceScore);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new VisitorCenters::DataData
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
                    AltText = "A long rectangular building with large logs on the roof.",
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::DataData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::DataData
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
                    AltText = "A long rectangular building with large logs on the roof.",
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::DataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "6024ADBB-9505-45FD-A9AE-FF50CDA658A0";
        List<VisitorCenters::Address> expectedAddresses =
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
        ];
        List<string> expectedAmenities =
        [
            "Food/Drink - Snacks",
            "Information - Maps Available",
            "Information - Park Newspaper Available",
            "Information - Ranger/Staff Member Present",
            "Toilet - Vault/Composting",
        ];
        string expectedAudioDescription = "";
        List<string> expectedContacts = ["string"];
        string expectedDescription =
            "Located along Trail Ridge Road, this is the highest elevation visitor center in the National Park System at 11,796'. Alpine Visitor Center is closed for the 2022 season.";
        string expectedDirectionsInfo =
            "Fall River Pass at the junction of Trail Ridge and Old Fall River roads. Check the status of Trail Ridge Road by calling 970-586-1222.";
        string expectedDirectionsUrl = "";
        string expectedGeometryPoiID = "2C48E54F-1F93-4E49-BCDA-5A5DAAFAD622";
        List<VisitorCenters::Image> expectedImages =
        [
            new()
            {
                AltText = "A long rectangular building with large logs on the roof.",
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
        ];
        bool expectedIsPassportStampLocation = true;
        string expectedLastIndexedDate = "";
        string expectedLatitude = "40.44103093774664";
        string expectedLatLong = "{lat:40.44103093774664, lng:-105.75452021953589}";
        string expectedLongitude = "-105.75452021953589";
        List<VisitorCenters::DataDataMultimedia> expectedMultimedia =
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
        string expectedName = "Alpine Visitor Center";
        List<VisitorCenters::OperatingHour> expectedOperatingHours =
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
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                        StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        ];
        string expectedParkCode = "romo";
        List<VisitorCenters::PassportStampImage> expectedPassportStampImages =
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
        ];
        string expectedPassportStampLocationDescription = "";
        double expectedRelevanceScore = 1;
        string expectedUrl = "";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.NotNull(deserialized.Addresses);
        Assert.Equal(expectedAddresses.Count, deserialized.Addresses.Count);
        for (int i = 0; i < expectedAddresses.Count; i++)
        {
            Assert.Equal(expectedAddresses[i], deserialized.Addresses[i]);
        }
        Assert.NotNull(deserialized.Amenities);
        Assert.Equal(expectedAmenities.Count, deserialized.Amenities.Count);
        for (int i = 0; i < expectedAmenities.Count; i++)
        {
            Assert.Equal(expectedAmenities[i], deserialized.Amenities[i]);
        }
        Assert.Equal(expectedAudioDescription, deserialized.AudioDescription);
        Assert.NotNull(deserialized.Contacts);
        Assert.Equal(expectedContacts.Count, deserialized.Contacts.Count);
        for (int i = 0; i < expectedContacts.Count; i++)
        {
            Assert.Equal(expectedContacts[i], deserialized.Contacts[i]);
        }
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDirectionsInfo, deserialized.DirectionsInfo);
        Assert.Equal(expectedDirectionsUrl, deserialized.DirectionsUrl);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedIsPassportStampLocation, deserialized.IsPassportStampLocation);
        Assert.Equal(expectedLastIndexedDate, deserialized.LastIndexedDate);
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
        Assert.NotNull(deserialized.PassportStampImages);
        Assert.Equal(expectedPassportStampImages.Count, deserialized.PassportStampImages.Count);
        for (int i = 0; i < expectedPassportStampImages.Count; i++)
        {
            Assert.Equal(expectedPassportStampImages[i], deserialized.PassportStampImages[i]);
        }
        Assert.Equal(
            expectedPassportStampLocationDescription,
            deserialized.PassportStampLocationDescription
        );
        Assert.Equal(expectedRelevanceScore, deserialized.RelevanceScore);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new VisitorCenters::DataData
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
                    AltText = "A long rectangular building with large logs on the roof.",
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                            StartDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::DataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Addresses);
        Assert.False(model.RawData.ContainsKey("addresses"));
        Assert.Null(model.Amenities);
        Assert.False(model.RawData.ContainsKey("amenities"));
        Assert.Null(model.AudioDescription);
        Assert.False(model.RawData.ContainsKey("audioDescription"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DirectionsInfo);
        Assert.False(model.RawData.ContainsKey("directionsInfo"));
        Assert.Null(model.DirectionsUrl);
        Assert.False(model.RawData.ContainsKey("directionsUrl"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsPassportStampLocation);
        Assert.False(model.RawData.ContainsKey("isPassportStampLocation"));
        Assert.Null(model.LastIndexedDate);
        Assert.False(model.RawData.ContainsKey("lastIndexedDate"));
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
        Assert.Null(model.PassportStampImages);
        Assert.False(model.RawData.ContainsKey("passportStampImages"));
        Assert.Null(model.PassportStampLocationDescription);
        Assert.False(model.RawData.ContainsKey("passportStampLocationDescription"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new VisitorCenters::DataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Addresses = null,
            Amenities = null,
            AudioDescription = null,
            Contacts = null,
            Description = null,
            DirectionsInfo = null,
            DirectionsUrl = null,
            GeometryPoiID = null,
            Images = null,
            IsPassportStampLocation = null,
            LastIndexedDate = null,
            Latitude = null,
            LatLong = null,
            Longitude = null,
            Multimedia = null,
            Name = null,
            OperatingHours = null,
            ParkCode = null,
            PassportStampImages = null,
            PassportStampLocationDescription = null,
            RelevanceScore = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Addresses);
        Assert.False(model.RawData.ContainsKey("addresses"));
        Assert.Null(model.Amenities);
        Assert.False(model.RawData.ContainsKey("amenities"));
        Assert.Null(model.AudioDescription);
        Assert.False(model.RawData.ContainsKey("audioDescription"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DirectionsInfo);
        Assert.False(model.RawData.ContainsKey("directionsInfo"));
        Assert.Null(model.DirectionsUrl);
        Assert.False(model.RawData.ContainsKey("directionsUrl"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsPassportStampLocation);
        Assert.False(model.RawData.ContainsKey("isPassportStampLocation"));
        Assert.Null(model.LastIndexedDate);
        Assert.False(model.RawData.ContainsKey("lastIndexedDate"));
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
        Assert.Null(model.PassportStampImages);
        Assert.False(model.RawData.ContainsKey("passportStampImages"));
        Assert.Null(model.PassportStampLocationDescription);
        Assert.False(model.RawData.ContainsKey("passportStampLocationDescription"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new VisitorCenters::DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Addresses = null,
            Amenities = null,
            AudioDescription = null,
            Contacts = null,
            Description = null,
            DirectionsInfo = null,
            DirectionsUrl = null,
            GeometryPoiID = null,
            Images = null,
            IsPassportStampLocation = null,
            LastIndexedDate = null,
            Latitude = null,
            LatLong = null,
            Longitude = null,
            Multimedia = null,
            Name = null,
            OperatingHours = null,
            ParkCode = null,
            PassportStampImages = null,
            PassportStampLocationDescription = null,
            RelevanceScore = null,
            Url = null,
        };

        model.Validate();
    }
}

public class AddressTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = VisitorCenters::Type.Physical,
        };

        string expectedCity = "city";
        string expectedCountryCode = "US";
        string expectedLine1 = "line1";
        string expectedLine2 = "line2";
        string expectedLine3 = "line3";
        string expectedPostalCode = "postalCode";
        string expectedProvinceTerritoryCode = "";
        string expectedStateCode = "stateCode";
        ApiEnum<string, VisitorCenters::Type> expectedType = VisitorCenters::Type.Physical;

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
        var model = new VisitorCenters::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = VisitorCenters::Type.Physical,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Address>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = VisitorCenters::Type.Physical,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Address>(element);
        Assert.NotNull(deserialized);

        string expectedCity = "city";
        string expectedCountryCode = "US";
        string expectedLine1 = "line1";
        string expectedLine2 = "line2";
        string expectedLine3 = "line3";
        string expectedPostalCode = "postalCode";
        string expectedProvinceTerritoryCode = "";
        string expectedStateCode = "stateCode";
        ApiEnum<string, VisitorCenters::Type> expectedType = VisitorCenters::Type.Physical;

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
        var model = new VisitorCenters::Address
        {
            City = "city",
            CountryCode = "US",
            Line1 = "line1",
            Line2 = "line2",
            Line3 = "line3",
            PostalCode = "postalCode",
            ProvinceTerritoryCode = "",
            StateCode = "stateCode",
            Type = VisitorCenters::Type.Physical,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::Address { };

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
        var model = new VisitorCenters::Address { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::Address
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
        var model = new VisitorCenters::Address
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
    [InlineData(VisitorCenters::Type.Physical)]
    [InlineData(VisitorCenters::Type.Mailing)]
    public void Validation_Works(VisitorCenters::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, VisitorCenters::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, VisitorCenters::Type>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(VisitorCenters::Type.Physical)]
    [InlineData(VisitorCenters::Type.Mailing)]
    public void SerializationRoundtrip_Works(VisitorCenters::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, VisitorCenters::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, VisitorCenters::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, VisitorCenters::Type>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, VisitorCenters::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Title = "title",
            Url = "url",
        };

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        List<JsonElement> expectedCrops = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.NotNull(model.Crops);
        Assert.Equal(expectedCrops.Count, model.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedCrops[i], model.Crops[i]));
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new VisitorCenters::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Title = "title",
            Url = "url",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Image>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Image>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        List<JsonElement> expectedCrops = [JsonSerializer.Deserialize<JsonElement>("{}")];
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.NotNull(deserialized.Crops);
        Assert.Equal(expectedCrops.Count, deserialized.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedCrops[i], deserialized.Crops[i]));
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new VisitorCenters::Image
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Title = "title",
            Url = "url",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::Image { };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Crops);
        Assert.False(model.RawData.ContainsKey("crops"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new VisitorCenters::Image { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::Image
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
            Crops = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Crops);
        Assert.False(model.RawData.ContainsKey("crops"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new VisitorCenters::Image
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
            Crops = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class DataDataMultimediaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::DataDataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        string expectedID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883";
        string expectedTitle = "The Worthington Farm";
        string expectedType = "multimedia/videos";
        string expectedUrl =
            "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new VisitorCenters::DataDataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::DataDataMultimedia>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::DataDataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::DataDataMultimedia>(element);
        Assert.NotNull(deserialized);

        string expectedID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883";
        string expectedTitle = "The Worthington Farm";
        string expectedType = "multimedia/videos";
        string expectedUrl =
            "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new VisitorCenters::DataDataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::DataDataMultimedia { };

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
        var model = new VisitorCenters::DataDataMultimedia { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::DataDataMultimedia
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
        var model = new VisitorCenters::DataDataMultimedia
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
        var model = new VisitorCenters::OperatingHour
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
        List<VisitorCenters::Exception> expectedExceptions =
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
        VisitorCenters::StandardHours expectedStandardHours = new()
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
        var model = new VisitorCenters::OperatingHour
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::OperatingHour>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::OperatingHour
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

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::OperatingHour>(element);
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        List<VisitorCenters::Exception> expectedExceptions =
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
        VisitorCenters::StandardHours expectedStandardHours = new()
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
        var model = new VisitorCenters::OperatingHour
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
        var model = new VisitorCenters::OperatingHour { };

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
        var model = new VisitorCenters::OperatingHour { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::OperatingHour
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
        var model = new VisitorCenters::OperatingHour
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
        var model = new VisitorCenters::Exception
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
        VisitorCenters::ExceptionHours expectedExceptionHours = new()
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
        var model = new VisitorCenters::Exception
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Exception>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::Exception
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

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Exception>(element);
        Assert.NotNull(deserialized);

        DateTimeOffset expectedEndDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        VisitorCenters::ExceptionHours expectedExceptionHours = new()
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
        var model = new VisitorCenters::Exception
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
        var model = new VisitorCenters::Exception { };

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
        var model = new VisitorCenters::Exception { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::Exception
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
        var model = new VisitorCenters::Exception
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
        var model = new VisitorCenters::ExceptionHours
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
        var model = new VisitorCenters::ExceptionHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::ExceptionHours>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::ExceptionHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::ExceptionHours>(element);
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
        var model = new VisitorCenters::ExceptionHours
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
        var model = new VisitorCenters::ExceptionHours { };

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
        var model = new VisitorCenters::ExceptionHours { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::ExceptionHours
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
        var model = new VisitorCenters::ExceptionHours
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
        var model = new VisitorCenters::StandardHours
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
        var model = new VisitorCenters::StandardHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::StandardHours>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::StandardHours
        {
            Friday = "friday",
            Monday = "monday",
            Saturday = "saturday",
            Sunday = "sunday",
            Thursday = "thursday",
            Tuesday = "tuesday",
            Wednesday = "wednesday",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::StandardHours>(element);
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
        var model = new VisitorCenters::StandardHours
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
        var model = new VisitorCenters::StandardHours { };

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
        var model = new VisitorCenters::StandardHours { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::StandardHours
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
        var model = new VisitorCenters::StandardHours
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

public class PassportStampImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::PassportStampImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [new() { AspectRatio = 0, Url = "url" }],
            Description = "description",
            Title = "title",
            Url = "url",
        };

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        List<VisitorCenters::Crop> expectedCrops = [new() { AspectRatio = 0, Url = "url" }];
        string expectedDescription = "description";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.NotNull(model.Crops);
        Assert.Equal(expectedCrops.Count, model.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], model.Crops[i]);
        }
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new VisitorCenters::PassportStampImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [new() { AspectRatio = 0, Url = "url" }],
            Description = "description",
            Title = "title",
            Url = "url",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::PassportStampImage>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::PassportStampImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [new() { AspectRatio = 0, Url = "url" }],
            Description = "description",
            Title = "title",
            Url = "url",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::PassportStampImage>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "altText";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        List<VisitorCenters::Crop> expectedCrops = [new() { AspectRatio = 0, Url = "url" }];
        string expectedDescription = "description";
        string expectedTitle = "title";
        string expectedUrl = "url";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.NotNull(deserialized.Crops);
        Assert.Equal(expectedCrops.Count, deserialized.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], deserialized.Crops[i]);
        }
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new VisitorCenters::PassportStampImage
        {
            AltText = "altText",
            Caption = "caption",
            Credit = "credit",
            Crops = [new() { AspectRatio = 0, Url = "url" }],
            Description = "description",
            Title = "title",
            Url = "url",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::PassportStampImage { };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Crops);
        Assert.False(model.RawData.ContainsKey("crops"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new VisitorCenters::PassportStampImage { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::PassportStampImage
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
            Crops = null,
            Description = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.AltText);
        Assert.False(model.RawData.ContainsKey("altText"));
        Assert.Null(model.Caption);
        Assert.False(model.RawData.ContainsKey("caption"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Crops);
        Assert.False(model.RawData.ContainsKey("crops"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new VisitorCenters::PassportStampImage
        {
            // Null should be interpreted as omitted for these properties
            AltText = null,
            Caption = null,
            Credit = null,
            Crops = null,
            Description = null,
            Title = null,
            Url = null,
        };

        model.Validate();
    }
}

public class CropTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VisitorCenters::Crop { AspectRatio = 0, Url = "url" };

        double expectedAspectRatio = 0;
        string expectedUrl = "url";

        Assert.Equal(expectedAspectRatio, model.AspectRatio);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new VisitorCenters::Crop { AspectRatio = 0, Url = "url" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Crop>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VisitorCenters::Crop { AspectRatio = 0, Url = "url" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<VisitorCenters::Crop>(element);
        Assert.NotNull(deserialized);

        double expectedAspectRatio = 0;
        string expectedUrl = "url";

        Assert.Equal(expectedAspectRatio, deserialized.AspectRatio);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new VisitorCenters::Crop { AspectRatio = 0, Url = "url" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new VisitorCenters::Crop { };

        Assert.Null(model.AspectRatio);
        Assert.False(model.RawData.ContainsKey("aspectRatio"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new VisitorCenters::Crop { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new VisitorCenters::Crop
        {
            // Null should be interpreted as omitted for these properties
            AspectRatio = null,
            Url = null,
        };

        Assert.Null(model.AspectRatio);
        Assert.False(model.RawData.ContainsKey("aspectRatio"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new VisitorCenters::Crop
        {
            // Null should be interpreted as omitted for these properties
            AspectRatio = null,
            Url = null,
        };

        model.Validate();
    }
}
