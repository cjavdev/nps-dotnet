using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Campgrounds;

namespace Nps.Tests.Models.Campgrounds;

public class CampgroundListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CampgroundListPageResponse
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
                                Accessroads = ["string"],
                                Adainfo = "adainfo",
                                Additionalinfo = "additionalinfo",
                                Cellphoneinfo = "cellphoneinfo",
                                Classifications = ["string"],
                                Firestovepolicy = "firestovepolicy",
                                Internetinfo = "internetinfo",
                                Rvallowed = "rvallowed",
                                Rvinfo = "rvinfo",
                                Rvmaxlength = "rvmaxlength",
                                Trailerallowed = "trailerallowed",
                                Trailermaxlength = "trailermaxlength",
                                Wheelchairaccess = "wheelchairaccess",
                            },
                            Addresses =
                            [
                                new()
                                {
                                    City = "city",
                                    CountryCode = "US",
                                    Line1 = "line1",
                                    Line2 = "line2",
                                    Line3 = "line3",
                                    PostalCode = "postalCode",
                                    ProvinceTerritoryCode = "NB",
                                    StateCode = "stateCode",
                                    Type = Type.Physical,
                                },
                            ],
                            Amenities = new()
                            {
                                Amphitheater = "amphitheater",
                                Ampitheater = "ampitheater",
                                Campstore = "campstore",
                                Cellphonereception = "cellphonereception",
                                Dumpstation = "dumpstation",
                                Firewoodforsale = "firewoodforsale",
                                FoodStorageLockers = "foodStorageLockers",
                                Iceavailableforsale = "iceavailableforsale",
                                Internetconnectivity = "internetconnectivity",
                                Laundry = "laundry",
                                Potablewater = ["string"],
                                Showers = ["string"],
                                Stafforvolunteerhostonsite = "stafforvolunteerhostonsite",
                                Toilets = ["string"],
                                Trashrecyclingcollection = "trashrecyclingcollection",
                            },
                            Campsites = new()
                            {
                                Electricalhookups = "electricalhookups",
                                Group = "group",
                                Horse = "horse",
                                Other = "other",
                                Rvonly = "rvonly",
                                Tentonly = "tentonly",
                                Totalsites = "totalsites",
                                Walkboatto = "walkboatto",
                            },
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
                                        Type = PhoneNumberType.Voice,
                                    },
                                ],
                            },
                            Description = "description",
                            Directionsoverview = "directionsoverview",
                            DirectionsUrl = "directionsUrl",
                            Fees = ["string"],
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            LastIndexedDate = "lastIndexedDate",
                            Latitude = "63.4574408",
                            LatLong = "{lat:63.4574408, lng:-150.8612003}",
                            Longitude = "-150.8612003",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
                                },
                            ],
                            Name = "name",
                            OperatingHours = ["string"],
                            ParkCode = "parkCode",
                            Regulationsoverview = "regulationsoverview",
                            Regulationsurl = "regulationsurl",
                            RelevanceScore = 0,
                            Reservationsdescription = "reservationsdescription",
                            Reservationssitesfirstcome = "reservationssitesfirstcome",
                            Reservationssitesreservable = "reservationssitesreservable",
                            Reservationsurl = "reservationsurl",
                            Weatheroverview = "weatheroverview",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "total",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<CampgroundListResponse> expectedData =
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
                            Accessroads = ["string"],
                            Adainfo = "adainfo",
                            Additionalinfo = "additionalinfo",
                            Cellphoneinfo = "cellphoneinfo",
                            Classifications = ["string"],
                            Firestovepolicy = "firestovepolicy",
                            Internetinfo = "internetinfo",
                            Rvallowed = "rvallowed",
                            Rvinfo = "rvinfo",
                            Rvmaxlength = "rvmaxlength",
                            Trailerallowed = "trailerallowed",
                            Trailermaxlength = "trailermaxlength",
                            Wheelchairaccess = "wheelchairaccess",
                        },
                        Addresses =
                        [
                            new()
                            {
                                City = "city",
                                CountryCode = "US",
                                Line1 = "line1",
                                Line2 = "line2",
                                Line3 = "line3",
                                PostalCode = "postalCode",
                                ProvinceTerritoryCode = "NB",
                                StateCode = "stateCode",
                                Type = Type.Physical,
                            },
                        ],
                        Amenities = new()
                        {
                            Amphitheater = "amphitheater",
                            Ampitheater = "ampitheater",
                            Campstore = "campstore",
                            Cellphonereception = "cellphonereception",
                            Dumpstation = "dumpstation",
                            Firewoodforsale = "firewoodforsale",
                            FoodStorageLockers = "foodStorageLockers",
                            Iceavailableforsale = "iceavailableforsale",
                            Internetconnectivity = "internetconnectivity",
                            Laundry = "laundry",
                            Potablewater = ["string"],
                            Showers = ["string"],
                            Stafforvolunteerhostonsite = "stafforvolunteerhostonsite",
                            Toilets = ["string"],
                            Trashrecyclingcollection = "trashrecyclingcollection",
                        },
                        Campsites = new()
                        {
                            Electricalhookups = "electricalhookups",
                            Group = "group",
                            Horse = "horse",
                            Other = "other",
                            Rvonly = "rvonly",
                            Tentonly = "tentonly",
                            Totalsites = "totalsites",
                            Walkboatto = "walkboatto",
                        },
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
                                    Type = PhoneNumberType.Voice,
                                },
                            ],
                        },
                        Description = "description",
                        Directionsoverview = "directionsoverview",
                        DirectionsUrl = "directionsUrl",
                        Fees = ["string"],
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images = ["string"],
                        LastIndexedDate = "lastIndexedDate",
                        Latitude = "63.4574408",
                        LatLong = "{lat:63.4574408, lng:-150.8612003}",
                        Longitude = "-150.8612003",
                        Multimedia =
                        [
                            new()
                            {
                                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                Title = "The Worthington Farm",
                                Type = "multimedia/videos",
                                Url =
                                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
                            },
                        ],
                        Name = "name",
                        OperatingHours = ["string"],
                        ParkCode = "parkCode",
                        Regulationsoverview = "regulationsoverview",
                        Regulationsurl = "regulationsurl",
                        RelevanceScore = 0,
                        Reservationsdescription = "reservationsdescription",
                        Reservationssitesfirstcome = "reservationssitesfirstcome",
                        Reservationssitesreservable = "reservationssitesreservable",
                        Reservationsurl = "reservationsurl",
                        Weatheroverview = "weatheroverview",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "total",
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
        var model = new CampgroundListPageResponse
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
                                Accessroads = ["string"],
                                Adainfo = "adainfo",
                                Additionalinfo = "additionalinfo",
                                Cellphoneinfo = "cellphoneinfo",
                                Classifications = ["string"],
                                Firestovepolicy = "firestovepolicy",
                                Internetinfo = "internetinfo",
                                Rvallowed = "rvallowed",
                                Rvinfo = "rvinfo",
                                Rvmaxlength = "rvmaxlength",
                                Trailerallowed = "trailerallowed",
                                Trailermaxlength = "trailermaxlength",
                                Wheelchairaccess = "wheelchairaccess",
                            },
                            Addresses =
                            [
                                new()
                                {
                                    City = "city",
                                    CountryCode = "US",
                                    Line1 = "line1",
                                    Line2 = "line2",
                                    Line3 = "line3",
                                    PostalCode = "postalCode",
                                    ProvinceTerritoryCode = "NB",
                                    StateCode = "stateCode",
                                    Type = Type.Physical,
                                },
                            ],
                            Amenities = new()
                            {
                                Amphitheater = "amphitheater",
                                Ampitheater = "ampitheater",
                                Campstore = "campstore",
                                Cellphonereception = "cellphonereception",
                                Dumpstation = "dumpstation",
                                Firewoodforsale = "firewoodforsale",
                                FoodStorageLockers = "foodStorageLockers",
                                Iceavailableforsale = "iceavailableforsale",
                                Internetconnectivity = "internetconnectivity",
                                Laundry = "laundry",
                                Potablewater = ["string"],
                                Showers = ["string"],
                                Stafforvolunteerhostonsite = "stafforvolunteerhostonsite",
                                Toilets = ["string"],
                                Trashrecyclingcollection = "trashrecyclingcollection",
                            },
                            Campsites = new()
                            {
                                Electricalhookups = "electricalhookups",
                                Group = "group",
                                Horse = "horse",
                                Other = "other",
                                Rvonly = "rvonly",
                                Tentonly = "tentonly",
                                Totalsites = "totalsites",
                                Walkboatto = "walkboatto",
                            },
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
                                        Type = PhoneNumberType.Voice,
                                    },
                                ],
                            },
                            Description = "description",
                            Directionsoverview = "directionsoverview",
                            DirectionsUrl = "directionsUrl",
                            Fees = ["string"],
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            LastIndexedDate = "lastIndexedDate",
                            Latitude = "63.4574408",
                            LatLong = "{lat:63.4574408, lng:-150.8612003}",
                            Longitude = "-150.8612003",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
                                },
                            ],
                            Name = "name",
                            OperatingHours = ["string"],
                            ParkCode = "parkCode",
                            Regulationsoverview = "regulationsoverview",
                            Regulationsurl = "regulationsurl",
                            RelevanceScore = 0,
                            Reservationsdescription = "reservationsdescription",
                            Reservationssitesfirstcome = "reservationssitesfirstcome",
                            Reservationssitesreservable = "reservationssitesreservable",
                            Reservationsurl = "reservationsurl",
                            Weatheroverview = "weatheroverview",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "total",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CampgroundListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CampgroundListPageResponse
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
                                Accessroads = ["string"],
                                Adainfo = "adainfo",
                                Additionalinfo = "additionalinfo",
                                Cellphoneinfo = "cellphoneinfo",
                                Classifications = ["string"],
                                Firestovepolicy = "firestovepolicy",
                                Internetinfo = "internetinfo",
                                Rvallowed = "rvallowed",
                                Rvinfo = "rvinfo",
                                Rvmaxlength = "rvmaxlength",
                                Trailerallowed = "trailerallowed",
                                Trailermaxlength = "trailermaxlength",
                                Wheelchairaccess = "wheelchairaccess",
                            },
                            Addresses =
                            [
                                new()
                                {
                                    City = "city",
                                    CountryCode = "US",
                                    Line1 = "line1",
                                    Line2 = "line2",
                                    Line3 = "line3",
                                    PostalCode = "postalCode",
                                    ProvinceTerritoryCode = "NB",
                                    StateCode = "stateCode",
                                    Type = Type.Physical,
                                },
                            ],
                            Amenities = new()
                            {
                                Amphitheater = "amphitheater",
                                Ampitheater = "ampitheater",
                                Campstore = "campstore",
                                Cellphonereception = "cellphonereception",
                                Dumpstation = "dumpstation",
                                Firewoodforsale = "firewoodforsale",
                                FoodStorageLockers = "foodStorageLockers",
                                Iceavailableforsale = "iceavailableforsale",
                                Internetconnectivity = "internetconnectivity",
                                Laundry = "laundry",
                                Potablewater = ["string"],
                                Showers = ["string"],
                                Stafforvolunteerhostonsite = "stafforvolunteerhostonsite",
                                Toilets = ["string"],
                                Trashrecyclingcollection = "trashrecyclingcollection",
                            },
                            Campsites = new()
                            {
                                Electricalhookups = "electricalhookups",
                                Group = "group",
                                Horse = "horse",
                                Other = "other",
                                Rvonly = "rvonly",
                                Tentonly = "tentonly",
                                Totalsites = "totalsites",
                                Walkboatto = "walkboatto",
                            },
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
                                        Type = PhoneNumberType.Voice,
                                    },
                                ],
                            },
                            Description = "description",
                            Directionsoverview = "directionsoverview",
                            DirectionsUrl = "directionsUrl",
                            Fees = ["string"],
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            LastIndexedDate = "lastIndexedDate",
                            Latitude = "63.4574408",
                            LatLong = "{lat:63.4574408, lng:-150.8612003}",
                            Longitude = "-150.8612003",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
                                },
                            ],
                            Name = "name",
                            OperatingHours = ["string"],
                            ParkCode = "parkCode",
                            Regulationsoverview = "regulationsoverview",
                            Regulationsurl = "regulationsurl",
                            RelevanceScore = 0,
                            Reservationsdescription = "reservationsdescription",
                            Reservationssitesfirstcome = "reservationssitesfirstcome",
                            Reservationssitesreservable = "reservationssitesreservable",
                            Reservationsurl = "reservationsurl",
                            Weatheroverview = "weatheroverview",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "total",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CampgroundListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<CampgroundListResponse> expectedData =
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
                            Accessroads = ["string"],
                            Adainfo = "adainfo",
                            Additionalinfo = "additionalinfo",
                            Cellphoneinfo = "cellphoneinfo",
                            Classifications = ["string"],
                            Firestovepolicy = "firestovepolicy",
                            Internetinfo = "internetinfo",
                            Rvallowed = "rvallowed",
                            Rvinfo = "rvinfo",
                            Rvmaxlength = "rvmaxlength",
                            Trailerallowed = "trailerallowed",
                            Trailermaxlength = "trailermaxlength",
                            Wheelchairaccess = "wheelchairaccess",
                        },
                        Addresses =
                        [
                            new()
                            {
                                City = "city",
                                CountryCode = "US",
                                Line1 = "line1",
                                Line2 = "line2",
                                Line3 = "line3",
                                PostalCode = "postalCode",
                                ProvinceTerritoryCode = "NB",
                                StateCode = "stateCode",
                                Type = Type.Physical,
                            },
                        ],
                        Amenities = new()
                        {
                            Amphitheater = "amphitheater",
                            Ampitheater = "ampitheater",
                            Campstore = "campstore",
                            Cellphonereception = "cellphonereception",
                            Dumpstation = "dumpstation",
                            Firewoodforsale = "firewoodforsale",
                            FoodStorageLockers = "foodStorageLockers",
                            Iceavailableforsale = "iceavailableforsale",
                            Internetconnectivity = "internetconnectivity",
                            Laundry = "laundry",
                            Potablewater = ["string"],
                            Showers = ["string"],
                            Stafforvolunteerhostonsite = "stafforvolunteerhostonsite",
                            Toilets = ["string"],
                            Trashrecyclingcollection = "trashrecyclingcollection",
                        },
                        Campsites = new()
                        {
                            Electricalhookups = "electricalhookups",
                            Group = "group",
                            Horse = "horse",
                            Other = "other",
                            Rvonly = "rvonly",
                            Tentonly = "tentonly",
                            Totalsites = "totalsites",
                            Walkboatto = "walkboatto",
                        },
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
                                    Type = PhoneNumberType.Voice,
                                },
                            ],
                        },
                        Description = "description",
                        Directionsoverview = "directionsoverview",
                        DirectionsUrl = "directionsUrl",
                        Fees = ["string"],
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images = ["string"],
                        LastIndexedDate = "lastIndexedDate",
                        Latitude = "63.4574408",
                        LatLong = "{lat:63.4574408, lng:-150.8612003}",
                        Longitude = "-150.8612003",
                        Multimedia =
                        [
                            new()
                            {
                                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                Title = "The Worthington Farm",
                                Type = "multimedia/videos",
                                Url =
                                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
                            },
                        ],
                        Name = "name",
                        OperatingHours = ["string"],
                        ParkCode = "parkCode",
                        Regulationsoverview = "regulationsoverview",
                        Regulationsurl = "regulationsurl",
                        RelevanceScore = 0,
                        Reservationsdescription = "reservationsdescription",
                        Reservationssitesfirstcome = "reservationssitesfirstcome",
                        Reservationssitesreservable = "reservationssitesreservable",
                        Reservationsurl = "reservationsurl",
                        Weatheroverview = "weatheroverview",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "total",
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
        var model = new CampgroundListPageResponse
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
                                Accessroads = ["string"],
                                Adainfo = "adainfo",
                                Additionalinfo = "additionalinfo",
                                Cellphoneinfo = "cellphoneinfo",
                                Classifications = ["string"],
                                Firestovepolicy = "firestovepolicy",
                                Internetinfo = "internetinfo",
                                Rvallowed = "rvallowed",
                                Rvinfo = "rvinfo",
                                Rvmaxlength = "rvmaxlength",
                                Trailerallowed = "trailerallowed",
                                Trailermaxlength = "trailermaxlength",
                                Wheelchairaccess = "wheelchairaccess",
                            },
                            Addresses =
                            [
                                new()
                                {
                                    City = "city",
                                    CountryCode = "US",
                                    Line1 = "line1",
                                    Line2 = "line2",
                                    Line3 = "line3",
                                    PostalCode = "postalCode",
                                    ProvinceTerritoryCode = "NB",
                                    StateCode = "stateCode",
                                    Type = Type.Physical,
                                },
                            ],
                            Amenities = new()
                            {
                                Amphitheater = "amphitheater",
                                Ampitheater = "ampitheater",
                                Campstore = "campstore",
                                Cellphonereception = "cellphonereception",
                                Dumpstation = "dumpstation",
                                Firewoodforsale = "firewoodforsale",
                                FoodStorageLockers = "foodStorageLockers",
                                Iceavailableforsale = "iceavailableforsale",
                                Internetconnectivity = "internetconnectivity",
                                Laundry = "laundry",
                                Potablewater = ["string"],
                                Showers = ["string"],
                                Stafforvolunteerhostonsite = "stafforvolunteerhostonsite",
                                Toilets = ["string"],
                                Trashrecyclingcollection = "trashrecyclingcollection",
                            },
                            Campsites = new()
                            {
                                Electricalhookups = "electricalhookups",
                                Group = "group",
                                Horse = "horse",
                                Other = "other",
                                Rvonly = "rvonly",
                                Tentonly = "tentonly",
                                Totalsites = "totalsites",
                                Walkboatto = "walkboatto",
                            },
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
                                        Type = PhoneNumberType.Voice,
                                    },
                                ],
                            },
                            Description = "description",
                            Directionsoverview = "directionsoverview",
                            DirectionsUrl = "directionsUrl",
                            Fees = ["string"],
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images = ["string"],
                            LastIndexedDate = "lastIndexedDate",
                            Latitude = "63.4574408",
                            LatLong = "{lat:63.4574408, lng:-150.8612003}",
                            Longitude = "-150.8612003",
                            Multimedia =
                            [
                                new()
                                {
                                    ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                                    Title = "The Worthington Farm",
                                    Type = "multimedia/videos",
                                    Url =
                                        "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
                                },
                            ],
                            Name = "name",
                            OperatingHours = ["string"],
                            ParkCode = "parkCode",
                            Regulationsoverview = "regulationsoverview",
                            Regulationsurl = "regulationsurl",
                            RelevanceScore = 0,
                            Reservationsdescription = "reservationsdescription",
                            Reservationssitesfirstcome = "reservationssitesfirstcome",
                            Reservationssitesreservable = "reservationssitesreservable",
                            Reservationsurl = "reservationsurl",
                            Weatheroverview = "weatheroverview",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "total",
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
        var model = new CampgroundListPageResponse { };

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
        var model = new CampgroundListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CampgroundListPageResponse
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
        var model = new CampgroundListPageResponse
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
