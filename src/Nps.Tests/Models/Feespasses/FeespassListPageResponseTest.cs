using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.Feespasses;

namespace Nps.Tests.Models.Feespasses;

public class FeespassListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FeespassListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            Cashless = "Depends on location",
                            ContentOrderOrdinals = ContentOrderOrdinals.EntranceFee,
                            CustomFeeDescription = "Details about custom fees go here.",
                            CustomFeeHeading = "Special Fees May Apply",
                            CustomFeeLinkText = "Custom Fee Link Text",
                            CustomFeeLinkUrl = "https://www.nps.gov/etc/etc",
                            EntranceFeeDescription =
                                "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce",
                            EntrancePassesDescription =
                                "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.",
                            Fees =
                            [
                                new()
                                {
                                    ID = "B0ACE361-8899-4098-A238-18BA39FD67C2",
                                    Cost = "6.00",
                                    Description =
                                        "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.",
                                    EndDate = new()
                                    {
                                        Day = 22,
                                        Holiday = "",
                                        Month = 10,
                                    },
                                    EntranceFeeType = "Timed Entry Reservation - Location",
                                    Exceptions = "",
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription =
                                        "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.",
                                    PurchaseUrl = "",
                                    RecGovPurchaseUrl =
                                        "https://www.recreation.gov/timed-entry/400000",
                                    StartDate = new()
                                    {
                                        Day = 24,
                                        Holiday = "",
                                        Month = 5,
                                    },
                                    TimedEntryLocation =
                                        "Cadillac Summit Road Vehicle Reservations",
                                    TimedEntryShortDescription =
                                        "Required to drive Cadillac Summit Road",
                                },
                            ],
                            FeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                            IsFeeFreePark = true,
                            IsInteragencyPassAccepted = true,
                            IsParkingFeePossible = true,
                            IsParkingOrTransportationFeePossible = false,
                            PaidParkingDescription = "Details about paid parking go here.",
                            PaidParkingHeading = "Paid Parking Available",
                            ParkCode = "acad",
                            ParkingDetailsUrl = "",
                            Passes =
                            [
                                new()
                                {
                                    ID = "F647C604-6000-4454-A9FB-6147436E8A7C",
                                    Category = "Annual Entrance - Park",
                                    Cost = "70.00",
                                    Description =
                                        "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.",
                                    Exceptions = "",
                                    Image =
                                    [
                                        new()
                                        {
                                            AltText = "Test Image",
                                            Caption = "Testing",
                                            Credit = "Test Credit",
                                            Title = "Test Image",
                                            Url =
                                                "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                                        },
                                    ],
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    NpsGovPurchaseUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription = "",
                                    RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
                                },
                            ],
                            RelatedMultiSitePasses =
                            [
                                new()
                                {
                                    Audience = "People with great taste.",
                                    Cost = "100.00",
                                    Description = "All of these parks exist.",
                                    Images =
                                    [
                                        new()
                                        {
                                            AltText =
                                                "The Memorial Building surrounded by fall colors",
                                            Caption =
                                                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
                                            Credit = "NPS Photo",
                                            Title = "The Memorial Building with fall colors",
                                            Url =
                                                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
                                        },
                                    ],
                                    PurchaseLocations =
                                    [
                                        new()
                                        {
                                            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                                            PaymentMethod = "Cash Only",
                                            Title = "Houla Campground",
                                            Type = "campgrounds",
                                        },
                                    ],
                                    RelatedParks =
                                    [
                                        new()
                                        {
                                            Designation = "National Historic Park",
                                            FullName =
                                                "Abraham Lincoln Birthplace National Historical Park",
                                            Name = "Abraham Lincoln Birthplace",
                                            ParkCode = "abli",
                                            States = "KY",
                                            Url = "https://www.nps.gov/abli/index.htm",
                                        },
                                    ],
                                    Title = "Andy's Pass To All The Good Spots",
                                    Type = "Multi-Site Pass",
                                },
                            ],
                            TimedEntryDescription =
                                "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.",
                            TimedEntryHeading = "Timed Entry Reservation",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "469",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<FeespassListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        Cashless = "Depends on location",
                        ContentOrderOrdinals = ContentOrderOrdinals.EntranceFee,
                        CustomFeeDescription = "Details about custom fees go here.",
                        CustomFeeHeading = "Special Fees May Apply",
                        CustomFeeLinkText = "Custom Fee Link Text",
                        CustomFeeLinkUrl = "https://www.nps.gov/etc/etc",
                        EntranceFeeDescription =
                            "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce",
                        EntrancePassesDescription =
                            "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.",
                        Fees =
                        [
                            new()
                            {
                                ID = "B0ACE361-8899-4098-A238-18BA39FD67C2",
                                Cost = "6.00",
                                Description =
                                    "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.",
                                EndDate = new()
                                {
                                    Day = 22,
                                    Holiday = "",
                                    Month = 10,
                                },
                                EntranceFeeType = "Timed Entry Reservation - Location",
                                Exceptions = "",
                                InformationUrl =
                                    "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
                                PayGovPurchaseUrl = "",
                                PaymentDescription =
                                    "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.",
                                PurchaseUrl = "",
                                RecGovPurchaseUrl = "https://www.recreation.gov/timed-entry/400000",
                                StartDate = new()
                                {
                                    Day = 24,
                                    Holiday = "",
                                    Month = 5,
                                },
                                TimedEntryLocation = "Cadillac Summit Road Vehicle Reservations",
                                TimedEntryShortDescription =
                                    "Required to drive Cadillac Summit Road",
                            },
                        ],
                        FeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                        IsFeeFreePark = true,
                        IsInteragencyPassAccepted = true,
                        IsParkingFeePossible = true,
                        IsParkingOrTransportationFeePossible = false,
                        PaidParkingDescription = "Details about paid parking go here.",
                        PaidParkingHeading = "Paid Parking Available",
                        ParkCode = "acad",
                        ParkingDetailsUrl = "",
                        Passes =
                        [
                            new()
                            {
                                ID = "F647C604-6000-4454-A9FB-6147436E8A7C",
                                Category = "Annual Entrance - Park",
                                Cost = "70.00",
                                Description =
                                    "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.",
                                Exceptions = "",
                                Image =
                                [
                                    new()
                                    {
                                        AltText = "Test Image",
                                        Caption = "Testing",
                                        Credit = "Test Credit",
                                        Title = "Test Image",
                                        Url =
                                            "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                                    },
                                ],
                                InformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                NpsGovPurchaseUrl =
                                    "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                PayGovPurchaseUrl = "",
                                PaymentDescription = "",
                                RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
                            },
                        ],
                        RelatedMultiSitePasses =
                        [
                            new()
                            {
                                Audience = "People with great taste.",
                                Cost = "100.00",
                                Description = "All of these parks exist.",
                                Images =
                                [
                                    new()
                                    {
                                        AltText = "The Memorial Building surrounded by fall colors",
                                        Caption =
                                            "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
                                        Credit = "NPS Photo",
                                        Title = "The Memorial Building with fall colors",
                                        Url =
                                            "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
                                    },
                                ],
                                PurchaseLocations =
                                [
                                    new()
                                    {
                                        ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                                        PaymentMethod = "Cash Only",
                                        Title = "Houla Campground",
                                        Type = "campgrounds",
                                    },
                                ],
                                RelatedParks =
                                [
                                    new()
                                    {
                                        Designation = "National Historic Park",
                                        FullName =
                                            "Abraham Lincoln Birthplace National Historical Park",
                                        Name = "Abraham Lincoln Birthplace",
                                        ParkCode = "abli",
                                        States = "KY",
                                        Url = "https://www.nps.gov/abli/index.htm",
                                    },
                                ],
                                Title = "Andy's Pass To All The Good Spots",
                                Type = "Multi-Site Pass",
                            },
                        ],
                        TimedEntryDescription =
                            "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.",
                        TimedEntryHeading = "Timed Entry Reservation",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "469",
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
        var model = new FeespassListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            Cashless = "Depends on location",
                            ContentOrderOrdinals = ContentOrderOrdinals.EntranceFee,
                            CustomFeeDescription = "Details about custom fees go here.",
                            CustomFeeHeading = "Special Fees May Apply",
                            CustomFeeLinkText = "Custom Fee Link Text",
                            CustomFeeLinkUrl = "https://www.nps.gov/etc/etc",
                            EntranceFeeDescription =
                                "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce",
                            EntrancePassesDescription =
                                "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.",
                            Fees =
                            [
                                new()
                                {
                                    ID = "B0ACE361-8899-4098-A238-18BA39FD67C2",
                                    Cost = "6.00",
                                    Description =
                                        "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.",
                                    EndDate = new()
                                    {
                                        Day = 22,
                                        Holiday = "",
                                        Month = 10,
                                    },
                                    EntranceFeeType = "Timed Entry Reservation - Location",
                                    Exceptions = "",
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription =
                                        "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.",
                                    PurchaseUrl = "",
                                    RecGovPurchaseUrl =
                                        "https://www.recreation.gov/timed-entry/400000",
                                    StartDate = new()
                                    {
                                        Day = 24,
                                        Holiday = "",
                                        Month = 5,
                                    },
                                    TimedEntryLocation =
                                        "Cadillac Summit Road Vehicle Reservations",
                                    TimedEntryShortDescription =
                                        "Required to drive Cadillac Summit Road",
                                },
                            ],
                            FeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                            IsFeeFreePark = true,
                            IsInteragencyPassAccepted = true,
                            IsParkingFeePossible = true,
                            IsParkingOrTransportationFeePossible = false,
                            PaidParkingDescription = "Details about paid parking go here.",
                            PaidParkingHeading = "Paid Parking Available",
                            ParkCode = "acad",
                            ParkingDetailsUrl = "",
                            Passes =
                            [
                                new()
                                {
                                    ID = "F647C604-6000-4454-A9FB-6147436E8A7C",
                                    Category = "Annual Entrance - Park",
                                    Cost = "70.00",
                                    Description =
                                        "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.",
                                    Exceptions = "",
                                    Image =
                                    [
                                        new()
                                        {
                                            AltText = "Test Image",
                                            Caption = "Testing",
                                            Credit = "Test Credit",
                                            Title = "Test Image",
                                            Url =
                                                "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                                        },
                                    ],
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    NpsGovPurchaseUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription = "",
                                    RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
                                },
                            ],
                            RelatedMultiSitePasses =
                            [
                                new()
                                {
                                    Audience = "People with great taste.",
                                    Cost = "100.00",
                                    Description = "All of these parks exist.",
                                    Images =
                                    [
                                        new()
                                        {
                                            AltText =
                                                "The Memorial Building surrounded by fall colors",
                                            Caption =
                                                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
                                            Credit = "NPS Photo",
                                            Title = "The Memorial Building with fall colors",
                                            Url =
                                                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
                                        },
                                    ],
                                    PurchaseLocations =
                                    [
                                        new()
                                        {
                                            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                                            PaymentMethod = "Cash Only",
                                            Title = "Houla Campground",
                                            Type = "campgrounds",
                                        },
                                    ],
                                    RelatedParks =
                                    [
                                        new()
                                        {
                                            Designation = "National Historic Park",
                                            FullName =
                                                "Abraham Lincoln Birthplace National Historical Park",
                                            Name = "Abraham Lincoln Birthplace",
                                            ParkCode = "abli",
                                            States = "KY",
                                            Url = "https://www.nps.gov/abli/index.htm",
                                        },
                                    ],
                                    Title = "Andy's Pass To All The Good Spots",
                                    Type = "Multi-Site Pass",
                                },
                            ],
                            TimedEntryDescription =
                                "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.",
                            TimedEntryHeading = "Timed Entry Reservation",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "469",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FeespassListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FeespassListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            Cashless = "Depends on location",
                            ContentOrderOrdinals = ContentOrderOrdinals.EntranceFee,
                            CustomFeeDescription = "Details about custom fees go here.",
                            CustomFeeHeading = "Special Fees May Apply",
                            CustomFeeLinkText = "Custom Fee Link Text",
                            CustomFeeLinkUrl = "https://www.nps.gov/etc/etc",
                            EntranceFeeDescription =
                                "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce",
                            EntrancePassesDescription =
                                "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.",
                            Fees =
                            [
                                new()
                                {
                                    ID = "B0ACE361-8899-4098-A238-18BA39FD67C2",
                                    Cost = "6.00",
                                    Description =
                                        "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.",
                                    EndDate = new()
                                    {
                                        Day = 22,
                                        Holiday = "",
                                        Month = 10,
                                    },
                                    EntranceFeeType = "Timed Entry Reservation - Location",
                                    Exceptions = "",
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription =
                                        "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.",
                                    PurchaseUrl = "",
                                    RecGovPurchaseUrl =
                                        "https://www.recreation.gov/timed-entry/400000",
                                    StartDate = new()
                                    {
                                        Day = 24,
                                        Holiday = "",
                                        Month = 5,
                                    },
                                    TimedEntryLocation =
                                        "Cadillac Summit Road Vehicle Reservations",
                                    TimedEntryShortDescription =
                                        "Required to drive Cadillac Summit Road",
                                },
                            ],
                            FeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                            IsFeeFreePark = true,
                            IsInteragencyPassAccepted = true,
                            IsParkingFeePossible = true,
                            IsParkingOrTransportationFeePossible = false,
                            PaidParkingDescription = "Details about paid parking go here.",
                            PaidParkingHeading = "Paid Parking Available",
                            ParkCode = "acad",
                            ParkingDetailsUrl = "",
                            Passes =
                            [
                                new()
                                {
                                    ID = "F647C604-6000-4454-A9FB-6147436E8A7C",
                                    Category = "Annual Entrance - Park",
                                    Cost = "70.00",
                                    Description =
                                        "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.",
                                    Exceptions = "",
                                    Image =
                                    [
                                        new()
                                        {
                                            AltText = "Test Image",
                                            Caption = "Testing",
                                            Credit = "Test Credit",
                                            Title = "Test Image",
                                            Url =
                                                "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                                        },
                                    ],
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    NpsGovPurchaseUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription = "",
                                    RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
                                },
                            ],
                            RelatedMultiSitePasses =
                            [
                                new()
                                {
                                    Audience = "People with great taste.",
                                    Cost = "100.00",
                                    Description = "All of these parks exist.",
                                    Images =
                                    [
                                        new()
                                        {
                                            AltText =
                                                "The Memorial Building surrounded by fall colors",
                                            Caption =
                                                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
                                            Credit = "NPS Photo",
                                            Title = "The Memorial Building with fall colors",
                                            Url =
                                                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
                                        },
                                    ],
                                    PurchaseLocations =
                                    [
                                        new()
                                        {
                                            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                                            PaymentMethod = "Cash Only",
                                            Title = "Houla Campground",
                                            Type = "campgrounds",
                                        },
                                    ],
                                    RelatedParks =
                                    [
                                        new()
                                        {
                                            Designation = "National Historic Park",
                                            FullName =
                                                "Abraham Lincoln Birthplace National Historical Park",
                                            Name = "Abraham Lincoln Birthplace",
                                            ParkCode = "abli",
                                            States = "KY",
                                            Url = "https://www.nps.gov/abli/index.htm",
                                        },
                                    ],
                                    Title = "Andy's Pass To All The Good Spots",
                                    Type = "Multi-Site Pass",
                                },
                            ],
                            TimedEntryDescription =
                                "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.",
                            TimedEntryHeading = "Timed Entry Reservation",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "469",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FeespassListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<FeespassListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        Cashless = "Depends on location",
                        ContentOrderOrdinals = ContentOrderOrdinals.EntranceFee,
                        CustomFeeDescription = "Details about custom fees go here.",
                        CustomFeeHeading = "Special Fees May Apply",
                        CustomFeeLinkText = "Custom Fee Link Text",
                        CustomFeeLinkUrl = "https://www.nps.gov/etc/etc",
                        EntranceFeeDescription =
                            "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce",
                        EntrancePassesDescription =
                            "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.",
                        Fees =
                        [
                            new()
                            {
                                ID = "B0ACE361-8899-4098-A238-18BA39FD67C2",
                                Cost = "6.00",
                                Description =
                                    "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.",
                                EndDate = new()
                                {
                                    Day = 22,
                                    Holiday = "",
                                    Month = 10,
                                },
                                EntranceFeeType = "Timed Entry Reservation - Location",
                                Exceptions = "",
                                InformationUrl =
                                    "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
                                PayGovPurchaseUrl = "",
                                PaymentDescription =
                                    "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.",
                                PurchaseUrl = "",
                                RecGovPurchaseUrl = "https://www.recreation.gov/timed-entry/400000",
                                StartDate = new()
                                {
                                    Day = 24,
                                    Holiday = "",
                                    Month = 5,
                                },
                                TimedEntryLocation = "Cadillac Summit Road Vehicle Reservations",
                                TimedEntryShortDescription =
                                    "Required to drive Cadillac Summit Road",
                            },
                        ],
                        FeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                        IsFeeFreePark = true,
                        IsInteragencyPassAccepted = true,
                        IsParkingFeePossible = true,
                        IsParkingOrTransportationFeePossible = false,
                        PaidParkingDescription = "Details about paid parking go here.",
                        PaidParkingHeading = "Paid Parking Available",
                        ParkCode = "acad",
                        ParkingDetailsUrl = "",
                        Passes =
                        [
                            new()
                            {
                                ID = "F647C604-6000-4454-A9FB-6147436E8A7C",
                                Category = "Annual Entrance - Park",
                                Cost = "70.00",
                                Description =
                                    "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.",
                                Exceptions = "",
                                Image =
                                [
                                    new()
                                    {
                                        AltText = "Test Image",
                                        Caption = "Testing",
                                        Credit = "Test Credit",
                                        Title = "Test Image",
                                        Url =
                                            "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                                    },
                                ],
                                InformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                NpsGovPurchaseUrl =
                                    "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                PayGovPurchaseUrl = "",
                                PaymentDescription = "",
                                RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
                            },
                        ],
                        RelatedMultiSitePasses =
                        [
                            new()
                            {
                                Audience = "People with great taste.",
                                Cost = "100.00",
                                Description = "All of these parks exist.",
                                Images =
                                [
                                    new()
                                    {
                                        AltText = "The Memorial Building surrounded by fall colors",
                                        Caption =
                                            "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
                                        Credit = "NPS Photo",
                                        Title = "The Memorial Building with fall colors",
                                        Url =
                                            "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
                                    },
                                ],
                                PurchaseLocations =
                                [
                                    new()
                                    {
                                        ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                                        PaymentMethod = "Cash Only",
                                        Title = "Houla Campground",
                                        Type = "campgrounds",
                                    },
                                ],
                                RelatedParks =
                                [
                                    new()
                                    {
                                        Designation = "National Historic Park",
                                        FullName =
                                            "Abraham Lincoln Birthplace National Historical Park",
                                        Name = "Abraham Lincoln Birthplace",
                                        ParkCode = "abli",
                                        States = "KY",
                                        Url = "https://www.nps.gov/abli/index.htm",
                                    },
                                ],
                                Title = "Andy's Pass To All The Good Spots",
                                Type = "Multi-Site Pass",
                            },
                        ],
                        TimedEntryDescription =
                            "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.",
                        TimedEntryHeading = "Timed Entry Reservation",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "469",
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
        var model = new FeespassListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            Cashless = "Depends on location",
                            ContentOrderOrdinals = ContentOrderOrdinals.EntranceFee,
                            CustomFeeDescription = "Details about custom fees go here.",
                            CustomFeeHeading = "Special Fees May Apply",
                            CustomFeeLinkText = "Custom Fee Link Text",
                            CustomFeeLinkUrl = "https://www.nps.gov/etc/etc",
                            EntranceFeeDescription =
                                "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce",
                            EntrancePassesDescription =
                                "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.",
                            Fees =
                            [
                                new()
                                {
                                    ID = "B0ACE361-8899-4098-A238-18BA39FD67C2",
                                    Cost = "6.00",
                                    Description =
                                        "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.",
                                    EndDate = new()
                                    {
                                        Day = 22,
                                        Holiday = "",
                                        Month = 10,
                                    },
                                    EntranceFeeType = "Timed Entry Reservation - Location",
                                    Exceptions = "",
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription =
                                        "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.",
                                    PurchaseUrl = "",
                                    RecGovPurchaseUrl =
                                        "https://www.recreation.gov/timed-entry/400000",
                                    StartDate = new()
                                    {
                                        Day = 24,
                                        Holiday = "",
                                        Month = 5,
                                    },
                                    TimedEntryLocation =
                                        "Cadillac Summit Road Vehicle Reservations",
                                    TimedEntryShortDescription =
                                        "Required to drive Cadillac Summit Road",
                                },
                            ],
                            FeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                            IsFeeFreePark = true,
                            IsInteragencyPassAccepted = true,
                            IsParkingFeePossible = true,
                            IsParkingOrTransportationFeePossible = false,
                            PaidParkingDescription = "Details about paid parking go here.",
                            PaidParkingHeading = "Paid Parking Available",
                            ParkCode = "acad",
                            ParkingDetailsUrl = "",
                            Passes =
                            [
                                new()
                                {
                                    ID = "F647C604-6000-4454-A9FB-6147436E8A7C",
                                    Category = "Annual Entrance - Park",
                                    Cost = "70.00",
                                    Description =
                                        "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.",
                                    Exceptions = "",
                                    Image =
                                    [
                                        new()
                                        {
                                            AltText = "Test Image",
                                            Caption = "Testing",
                                            Credit = "Test Credit",
                                            Title = "Test Image",
                                            Url =
                                                "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                                        },
                                    ],
                                    InformationUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    NpsGovPurchaseUrl =
                                        "https://www.nps.gov/acad/planyourvisit/fees.htm",
                                    PayGovPurchaseUrl = "",
                                    PaymentDescription = "",
                                    RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
                                },
                            ],
                            RelatedMultiSitePasses =
                            [
                                new()
                                {
                                    Audience = "People with great taste.",
                                    Cost = "100.00",
                                    Description = "All of these parks exist.",
                                    Images =
                                    [
                                        new()
                                        {
                                            AltText =
                                                "The Memorial Building surrounded by fall colors",
                                            Caption =
                                                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
                                            Credit = "NPS Photo",
                                            Title = "The Memorial Building with fall colors",
                                            Url =
                                                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
                                        },
                                    ],
                                    PurchaseLocations =
                                    [
                                        new()
                                        {
                                            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                                            PaymentMethod = "Cash Only",
                                            Title = "Houla Campground",
                                            Type = "campgrounds",
                                        },
                                    ],
                                    RelatedParks =
                                    [
                                        new()
                                        {
                                            Designation = "National Historic Park",
                                            FullName =
                                                "Abraham Lincoln Birthplace National Historical Park",
                                            Name = "Abraham Lincoln Birthplace",
                                            ParkCode = "abli",
                                            States = "KY",
                                            Url = "https://www.nps.gov/abli/index.htm",
                                        },
                                    ],
                                    Title = "Andy's Pass To All The Good Spots",
                                    Type = "Multi-Site Pass",
                                },
                            ],
                            TimedEntryDescription =
                                "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.",
                            TimedEntryHeading = "Timed Entry Reservation",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "469",
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
        var model = new FeespassListPageResponse { };

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
        var model = new FeespassListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new FeespassListPageResponse
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
        var model = new FeespassListPageResponse
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
