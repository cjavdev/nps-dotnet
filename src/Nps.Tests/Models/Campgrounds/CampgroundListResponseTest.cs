using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Exceptions;
using Nps.Models.Campgrounds;

namespace Nps.Tests.Models.Campgrounds;

public class CampgroundListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CampgroundListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new CampgroundListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CampgroundListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CampgroundListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CampgroundListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new CampgroundListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CampgroundListResponse { };

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
        var model = new CampgroundListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CampgroundListResponse
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
        var model = new CampgroundListResponse
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
            DataValue =
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
        };

        List<DataData> expectedDataValue =
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
                        new() { Description = "description", EmailAddressValue = "emailAddress" },
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "total";

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
        var model = new Data
        {
            DataValue =
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
        {
            DataValue =
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        List<DataData> expectedDataValue =
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
                        new() { Description = "description", EmailAddressValue = "emailAddress" },
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "total";

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
        var model = new Data
        {
            DataValue =
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

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
        var model = new Data { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
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
        var model = new Data
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
        var model = new DataData
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
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
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
        };

        string expectedID = "id";
        Accessibility expectedAccessibility = new()
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
        };
        List<Address> expectedAddresses =
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
        ];
        DataDataAmenities expectedAmenities = new()
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
        };
        Campsites expectedCampsites = new()
        {
            Electricalhookups = "electricalhookups",
            Group = "group",
            Horse = "horse",
            Other = "other",
            Rvonly = "rvonly",
            Tentonly = "tentonly",
            Totalsites = "totalsites",
            Walkboatto = "walkboatto",
        };
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
                    Type = PhoneNumberType.Voice,
                },
            ],
        };
        string expectedDescription = "description";
        string expectedDirectionsoverview = "directionsoverview";
        string expectedDirectionsUrl = "directionsUrl";
        List<string> expectedFees = ["string"];
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<string> expectedImages = ["string"];
        string expectedLastIndexedDate = "lastIndexedDate";
        string expectedLatitude = "63.4574408";
        string expectedLatLong = "{lat:63.4574408, lng:-150.8612003}";
        string expectedLongitude = "-150.8612003";
        List<DataDataMultimedia> expectedMultimedia =
        [
            new()
            {
                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                Title = "The Worthington Farm",
                Type = "multimedia/videos",
                Url =
                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
            },
        ];
        string expectedName = "name";
        List<string> expectedOperatingHours = ["string"];
        string expectedParkCode = "parkCode";
        string expectedRegulationsoverview = "regulationsoverview";
        string expectedRegulationsurl = "regulationsurl";
        double expectedRelevanceScore = 0;
        string expectedReservationsdescription = "reservationsdescription";
        string expectedReservationssitesfirstcome = "reservationssitesfirstcome";
        string expectedReservationssitesreservable = "reservationssitesreservable";
        string expectedReservationsurl = "reservationsurl";
        string expectedWeatheroverview = "weatheroverview";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccessibility, model.Accessibility);
        Assert.NotNull(model.Addresses);
        Assert.Equal(expectedAddresses.Count, model.Addresses.Count);
        for (int i = 0; i < expectedAddresses.Count; i++)
        {
            Assert.Equal(expectedAddresses[i], model.Addresses[i]);
        }
        Assert.Equal(expectedAmenities, model.Amenities);
        Assert.Equal(expectedCampsites, model.Campsites);
        Assert.Equal(expectedContacts, model.Contacts);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDirectionsoverview, model.Directionsoverview);
        Assert.Equal(expectedDirectionsUrl, model.DirectionsUrl);
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
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
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
        Assert.Equal(expectedRegulationsoverview, model.Regulationsoverview);
        Assert.Equal(expectedRegulationsurl, model.Regulationsurl);
        Assert.Equal(expectedRelevanceScore, model.RelevanceScore);
        Assert.Equal(expectedReservationsdescription, model.Reservationsdescription);
        Assert.Equal(expectedReservationssitesfirstcome, model.Reservationssitesfirstcome);
        Assert.Equal(expectedReservationssitesreservable, model.Reservationssitesreservable);
        Assert.Equal(expectedReservationsurl, model.Reservationsurl);
        Assert.Equal(expectedWeatheroverview, model.Weatheroverview);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataData
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
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataData
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
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        Accessibility expectedAccessibility = new()
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
        };
        List<Address> expectedAddresses =
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
        ];
        DataDataAmenities expectedAmenities = new()
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
        };
        Campsites expectedCampsites = new()
        {
            Electricalhookups = "electricalhookups",
            Group = "group",
            Horse = "horse",
            Other = "other",
            Rvonly = "rvonly",
            Tentonly = "tentonly",
            Totalsites = "totalsites",
            Walkboatto = "walkboatto",
        };
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
                    Type = PhoneNumberType.Voice,
                },
            ],
        };
        string expectedDescription = "description";
        string expectedDirectionsoverview = "directionsoverview";
        string expectedDirectionsUrl = "directionsUrl";
        List<string> expectedFees = ["string"];
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<string> expectedImages = ["string"];
        string expectedLastIndexedDate = "lastIndexedDate";
        string expectedLatitude = "63.4574408";
        string expectedLatLong = "{lat:63.4574408, lng:-150.8612003}";
        string expectedLongitude = "-150.8612003";
        List<DataDataMultimedia> expectedMultimedia =
        [
            new()
            {
                ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
                Title = "The Worthington Farm",
                Type = "multimedia/videos",
                Url =
                    "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
            },
        ];
        string expectedName = "name";
        List<string> expectedOperatingHours = ["string"];
        string expectedParkCode = "parkCode";
        string expectedRegulationsoverview = "regulationsoverview";
        string expectedRegulationsurl = "regulationsurl";
        double expectedRelevanceScore = 0;
        string expectedReservationsdescription = "reservationsdescription";
        string expectedReservationssitesfirstcome = "reservationssitesfirstcome";
        string expectedReservationssitesreservable = "reservationssitesreservable";
        string expectedReservationsurl = "reservationsurl";
        string expectedWeatheroverview = "weatheroverview";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccessibility, deserialized.Accessibility);
        Assert.NotNull(deserialized.Addresses);
        Assert.Equal(expectedAddresses.Count, deserialized.Addresses.Count);
        for (int i = 0; i < expectedAddresses.Count; i++)
        {
            Assert.Equal(expectedAddresses[i], deserialized.Addresses[i]);
        }
        Assert.Equal(expectedAmenities, deserialized.Amenities);
        Assert.Equal(expectedCampsites, deserialized.Campsites);
        Assert.Equal(expectedContacts, deserialized.Contacts);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDirectionsoverview, deserialized.Directionsoverview);
        Assert.Equal(expectedDirectionsUrl, deserialized.DirectionsUrl);
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
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
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
        Assert.Equal(expectedRegulationsoverview, deserialized.Regulationsoverview);
        Assert.Equal(expectedRegulationsurl, deserialized.Regulationsurl);
        Assert.Equal(expectedRelevanceScore, deserialized.RelevanceScore);
        Assert.Equal(expectedReservationsdescription, deserialized.Reservationsdescription);
        Assert.Equal(expectedReservationssitesfirstcome, deserialized.Reservationssitesfirstcome);
        Assert.Equal(expectedReservationssitesreservable, deserialized.Reservationssitesreservable);
        Assert.Equal(expectedReservationsurl, deserialized.Reservationsurl);
        Assert.Equal(expectedWeatheroverview, deserialized.Weatheroverview);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataData
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
                    new() { Description = "description", EmailAddressValue = "emailAddress" },
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Accessibility);
        Assert.False(model.RawData.ContainsKey("accessibility"));
        Assert.Null(model.Addresses);
        Assert.False(model.RawData.ContainsKey("addresses"));
        Assert.Null(model.Amenities);
        Assert.False(model.RawData.ContainsKey("amenities"));
        Assert.Null(model.Campsites);
        Assert.False(model.RawData.ContainsKey("campsites"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Directionsoverview);
        Assert.False(model.RawData.ContainsKey("directionsoverview"));
        Assert.Null(model.DirectionsUrl);
        Assert.False(model.RawData.ContainsKey("directionsUrl"));
        Assert.Null(model.Fees);
        Assert.False(model.RawData.ContainsKey("fees"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
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
        Assert.Null(model.Regulationsoverview);
        Assert.False(model.RawData.ContainsKey("regulationsoverview"));
        Assert.Null(model.Regulationsurl);
        Assert.False(model.RawData.ContainsKey("regulationsurl"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.Reservationsdescription);
        Assert.False(model.RawData.ContainsKey("reservationsdescription"));
        Assert.Null(model.Reservationssitesfirstcome);
        Assert.False(model.RawData.ContainsKey("reservationssitesfirstcome"));
        Assert.Null(model.Reservationssitesreservable);
        Assert.False(model.RawData.ContainsKey("reservationssitesreservable"));
        Assert.Null(model.Reservationsurl);
        Assert.False(model.RawData.ContainsKey("reservationsurl"));
        Assert.Null(model.Weatheroverview);
        Assert.False(model.RawData.ContainsKey("weatheroverview"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Accessibility = null,
            Addresses = null,
            Amenities = null,
            Campsites = null,
            Contacts = null,
            Description = null,
            Directionsoverview = null,
            DirectionsUrl = null,
            Fees = null,
            GeometryPoiID = null,
            Images = null,
            LastIndexedDate = null,
            Latitude = null,
            LatLong = null,
            Longitude = null,
            Multimedia = null,
            Name = null,
            OperatingHours = null,
            ParkCode = null,
            Regulationsoverview = null,
            Regulationsurl = null,
            RelevanceScore = null,
            Reservationsdescription = null,
            Reservationssitesfirstcome = null,
            Reservationssitesreservable = null,
            Reservationsurl = null,
            Weatheroverview = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Accessibility);
        Assert.False(model.RawData.ContainsKey("accessibility"));
        Assert.Null(model.Addresses);
        Assert.False(model.RawData.ContainsKey("addresses"));
        Assert.Null(model.Amenities);
        Assert.False(model.RawData.ContainsKey("amenities"));
        Assert.Null(model.Campsites);
        Assert.False(model.RawData.ContainsKey("campsites"));
        Assert.Null(model.Contacts);
        Assert.False(model.RawData.ContainsKey("contacts"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Directionsoverview);
        Assert.False(model.RawData.ContainsKey("directionsoverview"));
        Assert.Null(model.DirectionsUrl);
        Assert.False(model.RawData.ContainsKey("directionsUrl"));
        Assert.Null(model.Fees);
        Assert.False(model.RawData.ContainsKey("fees"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
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
        Assert.Null(model.Regulationsoverview);
        Assert.False(model.RawData.ContainsKey("regulationsoverview"));
        Assert.Null(model.Regulationsurl);
        Assert.False(model.RawData.ContainsKey("regulationsurl"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.Reservationsdescription);
        Assert.False(model.RawData.ContainsKey("reservationsdescription"));
        Assert.Null(model.Reservationssitesfirstcome);
        Assert.False(model.RawData.ContainsKey("reservationssitesfirstcome"));
        Assert.Null(model.Reservationssitesreservable);
        Assert.False(model.RawData.ContainsKey("reservationssitesreservable"));
        Assert.Null(model.Reservationsurl);
        Assert.False(model.RawData.ContainsKey("reservationsurl"));
        Assert.Null(model.Weatheroverview);
        Assert.False(model.RawData.ContainsKey("weatheroverview"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Accessibility = null,
            Addresses = null,
            Amenities = null,
            Campsites = null,
            Contacts = null,
            Description = null,
            Directionsoverview = null,
            DirectionsUrl = null,
            Fees = null,
            GeometryPoiID = null,
            Images = null,
            LastIndexedDate = null,
            Latitude = null,
            LatLong = null,
            Longitude = null,
            Multimedia = null,
            Name = null,
            OperatingHours = null,
            ParkCode = null,
            Regulationsoverview = null,
            Regulationsurl = null,
            RelevanceScore = null,
            Reservationsdescription = null,
            Reservationssitesfirstcome = null,
            Reservationssitesreservable = null,
            Reservationsurl = null,
            Weatheroverview = null,
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
        };

        List<string> expectedAccessroads = ["string"];
        string expectedAdainfo = "adainfo";
        string expectedAdditionalinfo = "additionalinfo";
        string expectedCellphoneinfo = "cellphoneinfo";
        List<string> expectedClassifications = ["string"];
        string expectedFirestovepolicy = "firestovepolicy";
        string expectedInternetinfo = "internetinfo";
        string expectedRvallowed = "rvallowed";
        string expectedRvinfo = "rvinfo";
        string expectedRvmaxlength = "rvmaxlength";
        string expectedTrailerallowed = "trailerallowed";
        string expectedTrailermaxlength = "trailermaxlength";
        string expectedWheelchairaccess = "wheelchairaccess";

        Assert.NotNull(model.Accessroads);
        Assert.Equal(expectedAccessroads.Count, model.Accessroads.Count);
        for (int i = 0; i < expectedAccessroads.Count; i++)
        {
            Assert.Equal(expectedAccessroads[i], model.Accessroads[i]);
        }
        Assert.Equal(expectedAdainfo, model.Adainfo);
        Assert.Equal(expectedAdditionalinfo, model.Additionalinfo);
        Assert.Equal(expectedCellphoneinfo, model.Cellphoneinfo);
        Assert.NotNull(model.Classifications);
        Assert.Equal(expectedClassifications.Count, model.Classifications.Count);
        for (int i = 0; i < expectedClassifications.Count; i++)
        {
            Assert.Equal(expectedClassifications[i], model.Classifications[i]);
        }
        Assert.Equal(expectedFirestovepolicy, model.Firestovepolicy);
        Assert.Equal(expectedInternetinfo, model.Internetinfo);
        Assert.Equal(expectedRvallowed, model.Rvallowed);
        Assert.Equal(expectedRvinfo, model.Rvinfo);
        Assert.Equal(expectedRvmaxlength, model.Rvmaxlength);
        Assert.Equal(expectedTrailerallowed, model.Trailerallowed);
        Assert.Equal(expectedTrailermaxlength, model.Trailermaxlength);
        Assert.Equal(expectedWheelchairaccess, model.Wheelchairaccess);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Accessibility
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Accessibility>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accessibility
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Accessibility>(element);
        Assert.NotNull(deserialized);

        List<string> expectedAccessroads = ["string"];
        string expectedAdainfo = "adainfo";
        string expectedAdditionalinfo = "additionalinfo";
        string expectedCellphoneinfo = "cellphoneinfo";
        List<string> expectedClassifications = ["string"];
        string expectedFirestovepolicy = "firestovepolicy";
        string expectedInternetinfo = "internetinfo";
        string expectedRvallowed = "rvallowed";
        string expectedRvinfo = "rvinfo";
        string expectedRvmaxlength = "rvmaxlength";
        string expectedTrailerallowed = "trailerallowed";
        string expectedTrailermaxlength = "trailermaxlength";
        string expectedWheelchairaccess = "wheelchairaccess";

        Assert.NotNull(deserialized.Accessroads);
        Assert.Equal(expectedAccessroads.Count, deserialized.Accessroads.Count);
        for (int i = 0; i < expectedAccessroads.Count; i++)
        {
            Assert.Equal(expectedAccessroads[i], deserialized.Accessroads[i]);
        }
        Assert.Equal(expectedAdainfo, deserialized.Adainfo);
        Assert.Equal(expectedAdditionalinfo, deserialized.Additionalinfo);
        Assert.Equal(expectedCellphoneinfo, deserialized.Cellphoneinfo);
        Assert.NotNull(deserialized.Classifications);
        Assert.Equal(expectedClassifications.Count, deserialized.Classifications.Count);
        for (int i = 0; i < expectedClassifications.Count; i++)
        {
            Assert.Equal(expectedClassifications[i], deserialized.Classifications[i]);
        }
        Assert.Equal(expectedFirestovepolicy, deserialized.Firestovepolicy);
        Assert.Equal(expectedInternetinfo, deserialized.Internetinfo);
        Assert.Equal(expectedRvallowed, deserialized.Rvallowed);
        Assert.Equal(expectedRvinfo, deserialized.Rvinfo);
        Assert.Equal(expectedRvmaxlength, deserialized.Rvmaxlength);
        Assert.Equal(expectedTrailerallowed, deserialized.Trailerallowed);
        Assert.Equal(expectedTrailermaxlength, deserialized.Trailermaxlength);
        Assert.Equal(expectedWheelchairaccess, deserialized.Wheelchairaccess);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Accessibility
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Accessibility { };

        Assert.Null(model.Accessroads);
        Assert.False(model.RawData.ContainsKey("accessroads"));
        Assert.Null(model.Adainfo);
        Assert.False(model.RawData.ContainsKey("adainfo"));
        Assert.Null(model.Additionalinfo);
        Assert.False(model.RawData.ContainsKey("additionalinfo"));
        Assert.Null(model.Cellphoneinfo);
        Assert.False(model.RawData.ContainsKey("cellphoneinfo"));
        Assert.Null(model.Classifications);
        Assert.False(model.RawData.ContainsKey("classifications"));
        Assert.Null(model.Firestovepolicy);
        Assert.False(model.RawData.ContainsKey("firestovepolicy"));
        Assert.Null(model.Internetinfo);
        Assert.False(model.RawData.ContainsKey("internetinfo"));
        Assert.Null(model.Rvallowed);
        Assert.False(model.RawData.ContainsKey("rvallowed"));
        Assert.Null(model.Rvinfo);
        Assert.False(model.RawData.ContainsKey("rvinfo"));
        Assert.Null(model.Rvmaxlength);
        Assert.False(model.RawData.ContainsKey("rvmaxlength"));
        Assert.Null(model.Trailerallowed);
        Assert.False(model.RawData.ContainsKey("trailerallowed"));
        Assert.Null(model.Trailermaxlength);
        Assert.False(model.RawData.ContainsKey("trailermaxlength"));
        Assert.Null(model.Wheelchairaccess);
        Assert.False(model.RawData.ContainsKey("wheelchairaccess"));
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
            Accessroads = null,
            Adainfo = null,
            Additionalinfo = null,
            Cellphoneinfo = null,
            Classifications = null,
            Firestovepolicy = null,
            Internetinfo = null,
            Rvallowed = null,
            Rvinfo = null,
            Rvmaxlength = null,
            Trailerallowed = null,
            Trailermaxlength = null,
            Wheelchairaccess = null,
        };

        Assert.Null(model.Accessroads);
        Assert.False(model.RawData.ContainsKey("accessroads"));
        Assert.Null(model.Adainfo);
        Assert.False(model.RawData.ContainsKey("adainfo"));
        Assert.Null(model.Additionalinfo);
        Assert.False(model.RawData.ContainsKey("additionalinfo"));
        Assert.Null(model.Cellphoneinfo);
        Assert.False(model.RawData.ContainsKey("cellphoneinfo"));
        Assert.Null(model.Classifications);
        Assert.False(model.RawData.ContainsKey("classifications"));
        Assert.Null(model.Firestovepolicy);
        Assert.False(model.RawData.ContainsKey("firestovepolicy"));
        Assert.Null(model.Internetinfo);
        Assert.False(model.RawData.ContainsKey("internetinfo"));
        Assert.Null(model.Rvallowed);
        Assert.False(model.RawData.ContainsKey("rvallowed"));
        Assert.Null(model.Rvinfo);
        Assert.False(model.RawData.ContainsKey("rvinfo"));
        Assert.Null(model.Rvmaxlength);
        Assert.False(model.RawData.ContainsKey("rvmaxlength"));
        Assert.Null(model.Trailerallowed);
        Assert.False(model.RawData.ContainsKey("trailerallowed"));
        Assert.Null(model.Trailermaxlength);
        Assert.False(model.RawData.ContainsKey("trailermaxlength"));
        Assert.Null(model.Wheelchairaccess);
        Assert.False(model.RawData.ContainsKey("wheelchairaccess"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Accessibility
        {
            // Null should be interpreted as omitted for these properties
            Accessroads = null,
            Adainfo = null,
            Additionalinfo = null,
            Cellphoneinfo = null,
            Classifications = null,
            Firestovepolicy = null,
            Internetinfo = null,
            Rvallowed = null,
            Rvinfo = null,
            Rvmaxlength = null,
            Trailerallowed = null,
            Trailermaxlength = null,
            Wheelchairaccess = null,
        };

        model.Validate();
    }
}

public class AddressTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Address
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
        };

        string expectedCity = "city";
        string expectedCountryCode = "US";
        string expectedLine1 = "line1";
        string expectedLine2 = "line2";
        string expectedLine3 = "line3";
        string expectedPostalCode = "postalCode";
        string expectedProvinceTerritoryCode = "NB";
        string expectedStateCode = "stateCode";
        ApiEnum<string, Type> expectedType = Type.Physical;

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
        var model = new Address
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Address>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Address
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Address>(element);
        Assert.NotNull(deserialized);

        string expectedCity = "city";
        string expectedCountryCode = "US";
        string expectedLine1 = "line1";
        string expectedLine2 = "line2";
        string expectedLine3 = "line3";
        string expectedPostalCode = "postalCode";
        string expectedProvinceTerritoryCode = "NB";
        string expectedStateCode = "stateCode";
        ApiEnum<string, Type> expectedType = Type.Physical;

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
        var model = new Address
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Address { };

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
        var model = new Address { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Address
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
        var model = new Address
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
    [InlineData(Type.Physical)]
    [InlineData(Type.Mailing)]
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Type.Physical)]
    [InlineData(Type.Mailing)]
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
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

public class DataDataAmenitiesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataDataAmenities
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
        };

        string expectedAmphitheater = "amphitheater";
        string expectedAmpitheater = "ampitheater";
        string expectedCampstore = "campstore";
        string expectedCellphonereception = "cellphonereception";
        string expectedDumpstation = "dumpstation";
        string expectedFirewoodforsale = "firewoodforsale";
        string expectedFoodStorageLockers = "foodStorageLockers";
        string expectedIceavailableforsale = "iceavailableforsale";
        string expectedInternetconnectivity = "internetconnectivity";
        string expectedLaundry = "laundry";
        List<string> expectedPotablewater = ["string"];
        List<string> expectedShowers = ["string"];
        string expectedStafforvolunteerhostonsite = "stafforvolunteerhostonsite";
        List<string> expectedToilets = ["string"];
        string expectedTrashrecyclingcollection = "trashrecyclingcollection";

        Assert.Equal(expectedAmphitheater, model.Amphitheater);
        Assert.Equal(expectedAmpitheater, model.Ampitheater);
        Assert.Equal(expectedCampstore, model.Campstore);
        Assert.Equal(expectedCellphonereception, model.Cellphonereception);
        Assert.Equal(expectedDumpstation, model.Dumpstation);
        Assert.Equal(expectedFirewoodforsale, model.Firewoodforsale);
        Assert.Equal(expectedFoodStorageLockers, model.FoodStorageLockers);
        Assert.Equal(expectedIceavailableforsale, model.Iceavailableforsale);
        Assert.Equal(expectedInternetconnectivity, model.Internetconnectivity);
        Assert.Equal(expectedLaundry, model.Laundry);
        Assert.NotNull(model.Potablewater);
        Assert.Equal(expectedPotablewater.Count, model.Potablewater.Count);
        for (int i = 0; i < expectedPotablewater.Count; i++)
        {
            Assert.Equal(expectedPotablewater[i], model.Potablewater[i]);
        }
        Assert.NotNull(model.Showers);
        Assert.Equal(expectedShowers.Count, model.Showers.Count);
        for (int i = 0; i < expectedShowers.Count; i++)
        {
            Assert.Equal(expectedShowers[i], model.Showers[i]);
        }
        Assert.Equal(expectedStafforvolunteerhostonsite, model.Stafforvolunteerhostonsite);
        Assert.NotNull(model.Toilets);
        Assert.Equal(expectedToilets.Count, model.Toilets.Count);
        for (int i = 0; i < expectedToilets.Count; i++)
        {
            Assert.Equal(expectedToilets[i], model.Toilets[i]);
        }
        Assert.Equal(expectedTrashrecyclingcollection, model.Trashrecyclingcollection);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataDataAmenities
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataDataAmenities>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataDataAmenities
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataDataAmenities>(element);
        Assert.NotNull(deserialized);

        string expectedAmphitheater = "amphitheater";
        string expectedAmpitheater = "ampitheater";
        string expectedCampstore = "campstore";
        string expectedCellphonereception = "cellphonereception";
        string expectedDumpstation = "dumpstation";
        string expectedFirewoodforsale = "firewoodforsale";
        string expectedFoodStorageLockers = "foodStorageLockers";
        string expectedIceavailableforsale = "iceavailableforsale";
        string expectedInternetconnectivity = "internetconnectivity";
        string expectedLaundry = "laundry";
        List<string> expectedPotablewater = ["string"];
        List<string> expectedShowers = ["string"];
        string expectedStafforvolunteerhostonsite = "stafforvolunteerhostonsite";
        List<string> expectedToilets = ["string"];
        string expectedTrashrecyclingcollection = "trashrecyclingcollection";

        Assert.Equal(expectedAmphitheater, deserialized.Amphitheater);
        Assert.Equal(expectedAmpitheater, deserialized.Ampitheater);
        Assert.Equal(expectedCampstore, deserialized.Campstore);
        Assert.Equal(expectedCellphonereception, deserialized.Cellphonereception);
        Assert.Equal(expectedDumpstation, deserialized.Dumpstation);
        Assert.Equal(expectedFirewoodforsale, deserialized.Firewoodforsale);
        Assert.Equal(expectedFoodStorageLockers, deserialized.FoodStorageLockers);
        Assert.Equal(expectedIceavailableforsale, deserialized.Iceavailableforsale);
        Assert.Equal(expectedInternetconnectivity, deserialized.Internetconnectivity);
        Assert.Equal(expectedLaundry, deserialized.Laundry);
        Assert.NotNull(deserialized.Potablewater);
        Assert.Equal(expectedPotablewater.Count, deserialized.Potablewater.Count);
        for (int i = 0; i < expectedPotablewater.Count; i++)
        {
            Assert.Equal(expectedPotablewater[i], deserialized.Potablewater[i]);
        }
        Assert.NotNull(deserialized.Showers);
        Assert.Equal(expectedShowers.Count, deserialized.Showers.Count);
        for (int i = 0; i < expectedShowers.Count; i++)
        {
            Assert.Equal(expectedShowers[i], deserialized.Showers[i]);
        }
        Assert.Equal(expectedStafforvolunteerhostonsite, deserialized.Stafforvolunteerhostonsite);
        Assert.NotNull(deserialized.Toilets);
        Assert.Equal(expectedToilets.Count, deserialized.Toilets.Count);
        for (int i = 0; i < expectedToilets.Count; i++)
        {
            Assert.Equal(expectedToilets[i], deserialized.Toilets[i]);
        }
        Assert.Equal(expectedTrashrecyclingcollection, deserialized.Trashrecyclingcollection);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataDataAmenities
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataDataAmenities { };

        Assert.Null(model.Amphitheater);
        Assert.False(model.RawData.ContainsKey("amphitheater"));
        Assert.Null(model.Ampitheater);
        Assert.False(model.RawData.ContainsKey("ampitheater"));
        Assert.Null(model.Campstore);
        Assert.False(model.RawData.ContainsKey("campstore"));
        Assert.Null(model.Cellphonereception);
        Assert.False(model.RawData.ContainsKey("cellphonereception"));
        Assert.Null(model.Dumpstation);
        Assert.False(model.RawData.ContainsKey("dumpstation"));
        Assert.Null(model.Firewoodforsale);
        Assert.False(model.RawData.ContainsKey("firewoodforsale"));
        Assert.Null(model.FoodStorageLockers);
        Assert.False(model.RawData.ContainsKey("foodStorageLockers"));
        Assert.Null(model.Iceavailableforsale);
        Assert.False(model.RawData.ContainsKey("iceavailableforsale"));
        Assert.Null(model.Internetconnectivity);
        Assert.False(model.RawData.ContainsKey("internetconnectivity"));
        Assert.Null(model.Laundry);
        Assert.False(model.RawData.ContainsKey("laundry"));
        Assert.Null(model.Potablewater);
        Assert.False(model.RawData.ContainsKey("potablewater"));
        Assert.Null(model.Showers);
        Assert.False(model.RawData.ContainsKey("showers"));
        Assert.Null(model.Stafforvolunteerhostonsite);
        Assert.False(model.RawData.ContainsKey("stafforvolunteerhostonsite"));
        Assert.Null(model.Toilets);
        Assert.False(model.RawData.ContainsKey("toilets"));
        Assert.Null(model.Trashrecyclingcollection);
        Assert.False(model.RawData.ContainsKey("trashrecyclingcollection"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataDataAmenities { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataDataAmenities
        {
            // Null should be interpreted as omitted for these properties
            Amphitheater = null,
            Ampitheater = null,
            Campstore = null,
            Cellphonereception = null,
            Dumpstation = null,
            Firewoodforsale = null,
            FoodStorageLockers = null,
            Iceavailableforsale = null,
            Internetconnectivity = null,
            Laundry = null,
            Potablewater = null,
            Showers = null,
            Stafforvolunteerhostonsite = null,
            Toilets = null,
            Trashrecyclingcollection = null,
        };

        Assert.Null(model.Amphitheater);
        Assert.False(model.RawData.ContainsKey("amphitheater"));
        Assert.Null(model.Ampitheater);
        Assert.False(model.RawData.ContainsKey("ampitheater"));
        Assert.Null(model.Campstore);
        Assert.False(model.RawData.ContainsKey("campstore"));
        Assert.Null(model.Cellphonereception);
        Assert.False(model.RawData.ContainsKey("cellphonereception"));
        Assert.Null(model.Dumpstation);
        Assert.False(model.RawData.ContainsKey("dumpstation"));
        Assert.Null(model.Firewoodforsale);
        Assert.False(model.RawData.ContainsKey("firewoodforsale"));
        Assert.Null(model.FoodStorageLockers);
        Assert.False(model.RawData.ContainsKey("foodStorageLockers"));
        Assert.Null(model.Iceavailableforsale);
        Assert.False(model.RawData.ContainsKey("iceavailableforsale"));
        Assert.Null(model.Internetconnectivity);
        Assert.False(model.RawData.ContainsKey("internetconnectivity"));
        Assert.Null(model.Laundry);
        Assert.False(model.RawData.ContainsKey("laundry"));
        Assert.Null(model.Potablewater);
        Assert.False(model.RawData.ContainsKey("potablewater"));
        Assert.Null(model.Showers);
        Assert.False(model.RawData.ContainsKey("showers"));
        Assert.Null(model.Stafforvolunteerhostonsite);
        Assert.False(model.RawData.ContainsKey("stafforvolunteerhostonsite"));
        Assert.Null(model.Toilets);
        Assert.False(model.RawData.ContainsKey("toilets"));
        Assert.Null(model.Trashrecyclingcollection);
        Assert.False(model.RawData.ContainsKey("trashrecyclingcollection"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataDataAmenities
        {
            // Null should be interpreted as omitted for these properties
            Amphitheater = null,
            Ampitheater = null,
            Campstore = null,
            Cellphonereception = null,
            Dumpstation = null,
            Firewoodforsale = null,
            FoodStorageLockers = null,
            Iceavailableforsale = null,
            Internetconnectivity = null,
            Laundry = null,
            Potablewater = null,
            Showers = null,
            Stafforvolunteerhostonsite = null,
            Toilets = null,
            Trashrecyclingcollection = null,
        };

        model.Validate();
    }
}

public class CampsitesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Campsites
        {
            Electricalhookups = "electricalhookups",
            Group = "group",
            Horse = "horse",
            Other = "other",
            Rvonly = "rvonly",
            Tentonly = "tentonly",
            Totalsites = "totalsites",
            Walkboatto = "walkboatto",
        };

        string expectedElectricalhookups = "electricalhookups";
        string expectedGroup = "group";
        string expectedHorse = "horse";
        string expectedOther = "other";
        string expectedRvonly = "rvonly";
        string expectedTentonly = "tentonly";
        string expectedTotalsites = "totalsites";
        string expectedWalkboatto = "walkboatto";

        Assert.Equal(expectedElectricalhookups, model.Electricalhookups);
        Assert.Equal(expectedGroup, model.Group);
        Assert.Equal(expectedHorse, model.Horse);
        Assert.Equal(expectedOther, model.Other);
        Assert.Equal(expectedRvonly, model.Rvonly);
        Assert.Equal(expectedTentonly, model.Tentonly);
        Assert.Equal(expectedTotalsites, model.Totalsites);
        Assert.Equal(expectedWalkboatto, model.Walkboatto);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Campsites
        {
            Electricalhookups = "electricalhookups",
            Group = "group",
            Horse = "horse",
            Other = "other",
            Rvonly = "rvonly",
            Tentonly = "tentonly",
            Totalsites = "totalsites",
            Walkboatto = "walkboatto",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Campsites>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Campsites
        {
            Electricalhookups = "electricalhookups",
            Group = "group",
            Horse = "horse",
            Other = "other",
            Rvonly = "rvonly",
            Tentonly = "tentonly",
            Totalsites = "totalsites",
            Walkboatto = "walkboatto",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Campsites>(element);
        Assert.NotNull(deserialized);

        string expectedElectricalhookups = "electricalhookups";
        string expectedGroup = "group";
        string expectedHorse = "horse";
        string expectedOther = "other";
        string expectedRvonly = "rvonly";
        string expectedTentonly = "tentonly";
        string expectedTotalsites = "totalsites";
        string expectedWalkboatto = "walkboatto";

        Assert.Equal(expectedElectricalhookups, deserialized.Electricalhookups);
        Assert.Equal(expectedGroup, deserialized.Group);
        Assert.Equal(expectedHorse, deserialized.Horse);
        Assert.Equal(expectedOther, deserialized.Other);
        Assert.Equal(expectedRvonly, deserialized.Rvonly);
        Assert.Equal(expectedTentonly, deserialized.Tentonly);
        Assert.Equal(expectedTotalsites, deserialized.Totalsites);
        Assert.Equal(expectedWalkboatto, deserialized.Walkboatto);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Campsites
        {
            Electricalhookups = "electricalhookups",
            Group = "group",
            Horse = "horse",
            Other = "other",
            Rvonly = "rvonly",
            Tentonly = "tentonly",
            Totalsites = "totalsites",
            Walkboatto = "walkboatto",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Campsites { };

        Assert.Null(model.Electricalhookups);
        Assert.False(model.RawData.ContainsKey("electricalhookups"));
        Assert.Null(model.Group);
        Assert.False(model.RawData.ContainsKey("group"));
        Assert.Null(model.Horse);
        Assert.False(model.RawData.ContainsKey("horse"));
        Assert.Null(model.Other);
        Assert.False(model.RawData.ContainsKey("other"));
        Assert.Null(model.Rvonly);
        Assert.False(model.RawData.ContainsKey("rvonly"));
        Assert.Null(model.Tentonly);
        Assert.False(model.RawData.ContainsKey("tentonly"));
        Assert.Null(model.Totalsites);
        Assert.False(model.RawData.ContainsKey("totalsites"));
        Assert.Null(model.Walkboatto);
        Assert.False(model.RawData.ContainsKey("walkboatto"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Campsites { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Campsites
        {
            // Null should be interpreted as omitted for these properties
            Electricalhookups = null,
            Group = null,
            Horse = null,
            Other = null,
            Rvonly = null,
            Tentonly = null,
            Totalsites = null,
            Walkboatto = null,
        };

        Assert.Null(model.Electricalhookups);
        Assert.False(model.RawData.ContainsKey("electricalhookups"));
        Assert.Null(model.Group);
        Assert.False(model.RawData.ContainsKey("group"));
        Assert.Null(model.Horse);
        Assert.False(model.RawData.ContainsKey("horse"));
        Assert.Null(model.Other);
        Assert.False(model.RawData.ContainsKey("other"));
        Assert.Null(model.Rvonly);
        Assert.False(model.RawData.ContainsKey("rvonly"));
        Assert.Null(model.Tentonly);
        Assert.False(model.RawData.ContainsKey("tentonly"));
        Assert.Null(model.Totalsites);
        Assert.False(model.RawData.ContainsKey("totalsites"));
        Assert.Null(model.Walkboatto);
        Assert.False(model.RawData.ContainsKey("walkboatto"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Campsites
        {
            // Null should be interpreted as omitted for these properties
            Electricalhookups = null,
            Group = null,
            Horse = null,
            Other = null,
            Rvonly = null,
            Tentonly = null,
            Totalsites = null,
            Walkboatto = null,
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
                    Type = PhoneNumberType.Voice,
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
                Type = PhoneNumberType.Voice,
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
                    Type = PhoneNumberType.Voice,
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Contacts>(json);

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
                    Type = PhoneNumberType.Voice,
                },
            ],
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Contacts>(element);
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
                Type = PhoneNumberType.Voice,
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
                    Type = PhoneNumberType.Voice,
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<EmailAddress>(json);

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

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<EmailAddress>(element);
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
            Type = PhoneNumberType.Voice,
        };

        string expectedDescription = "description";
        string expectedExtension = "extension";
        string expectedPhoneNumberValue = "phoneNumber";
        ApiEnum<string, PhoneNumberType> expectedType = PhoneNumberType.Voice;

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
            Type = PhoneNumberType.Voice,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PhoneNumber>(json);

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
            Type = PhoneNumberType.Voice,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PhoneNumber>(element);
        Assert.NotNull(deserialized);

        string expectedDescription = "description";
        string expectedExtension = "extension";
        string expectedPhoneNumberValue = "phoneNumber";
        ApiEnum<string, PhoneNumberType> expectedType = PhoneNumberType.Voice;

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
            Type = PhoneNumberType.Voice,
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

public class PhoneNumberTypeTest : TestBase
{
    [Theory]
    [InlineData(PhoneNumberType.Voice)]
    [InlineData(PhoneNumberType.Fax)]
    [InlineData(PhoneNumberType.Tty)]
    public void Validation_Works(PhoneNumberType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PhoneNumberType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PhoneNumberType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PhoneNumberType.Voice)]
    [InlineData(PhoneNumberType.Fax)]
    [InlineData(PhoneNumberType.Tty)]
    public void SerializationRoundtrip_Works(PhoneNumberType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PhoneNumberType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PhoneNumberType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PhoneNumberType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PhoneNumberType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DataDataMultimediaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataDataMultimedia
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
        var model = new DataDataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataDataMultimedia>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataDataMultimedia
        {
            ID = "4FD5B472-D6D9-43AA-9532-2AC5BF920883",
            Title = "The Worthington Farm",
            Type = "multimedia/videos",
            Url =
                "https://www.nps.gov/media/video/view.htm?id=4FD5B472-D6D9-43AA-9532-2AC5BF920883              ",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataDataMultimedia>(element);
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
        var model = new DataDataMultimedia
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
        var model = new DataDataMultimedia { };

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
        var model = new DataDataMultimedia { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataDataMultimedia
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
        var model = new DataDataMultimedia
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
