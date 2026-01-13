using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Exceptions;
using Nps.Models.Feespasses;

namespace Nps.Tests.Models.Feespasses;

public class FeespassListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FeespassListResponse
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
                            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
        };

        List<Data> expectedData =
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
                        TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                        NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
                                FullName = "Abraham Lincoln Birthplace National Historical Park",
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "469";

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
        var model = new FeespassListResponse
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
                            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<FeespassListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FeespassListResponse
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
                            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<FeespassListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
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
                        TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                        NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
                                FullName = "Abraham Lincoln Birthplace National Historical Park",
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "469";

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
        var model = new FeespassListResponse
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
                            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new FeespassListResponse { };

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
        var model = new FeespassListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new FeespassListResponse
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
        var model = new FeespassListResponse
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
                    TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                    NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
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
        };

        string expectedCashless = "Depends on location";
        ApiEnum<string, ContentOrderOrdinals> expectedContentOrderOrdinals =
            ContentOrderOrdinals.EntranceFee;
        string expectedCustomFeeDescription = "Details about custom fees go here.";
        string expectedCustomFeeHeading = "Special Fees May Apply";
        string expectedCustomFeeLinkText = "Custom Fee Link Text";
        string expectedCustomFeeLinkUrl = "https://www.nps.gov/etc/etc";
        string expectedEntranceFeeDescription =
            "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce";
        string expectedEntrancePassesDescription =
            "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.";
        List<Fee> expectedFees =
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
                InformationUrl = "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
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
                TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
            },
        ];
        string expectedFeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm";
        bool expectedIsFeeFreePark = true;
        bool expectedIsInteragencyPassAccepted = true;
        bool expectedIsParkingFeePossible = true;
        bool expectedIsParkingOrTransportationFeePossible = false;
        string expectedPaidParkingDescription = "Details about paid parking go here.";
        string expectedPaidParkingHeading = "Paid Parking Available";
        string expectedParkCode = "acad";
        string expectedParkingDetailsUrl = "";
        List<Pass> expectedPasses =
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
                NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                PayGovPurchaseUrl = "",
                PaymentDescription = "",
                RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
            },
        ];
        List<RelatedMultiSitePass> expectedRelatedMultiSitePasses =
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
                        FullName = "Abraham Lincoln Birthplace National Historical Park",
                        Name = "Abraham Lincoln Birthplace",
                        ParkCode = "abli",
                        States = "KY",
                        Url = "https://www.nps.gov/abli/index.htm",
                    },
                ],
                Title = "Andy's Pass To All The Good Spots",
                Type = "Multi-Site Pass",
            },
        ];
        string expectedTimedEntryDescription =
            "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.";
        string expectedTimedEntryHeading = "Timed Entry Reservation";

        Assert.Equal(expectedCashless, model.Cashless);
        Assert.Equal(expectedContentOrderOrdinals, model.ContentOrderOrdinals);
        Assert.Equal(expectedCustomFeeDescription, model.CustomFeeDescription);
        Assert.Equal(expectedCustomFeeHeading, model.CustomFeeHeading);
        Assert.Equal(expectedCustomFeeLinkText, model.CustomFeeLinkText);
        Assert.Equal(expectedCustomFeeLinkUrl, model.CustomFeeLinkUrl);
        Assert.Equal(expectedEntranceFeeDescription, model.EntranceFeeDescription);
        Assert.Equal(expectedEntrancePassesDescription, model.EntrancePassesDescription);
        Assert.NotNull(model.Fees);
        Assert.Equal(expectedFees.Count, model.Fees.Count);
        for (int i = 0; i < expectedFees.Count; i++)
        {
            Assert.Equal(expectedFees[i], model.Fees[i]);
        }
        Assert.Equal(expectedFeesAtWorkUrl, model.FeesAtWorkUrl);
        Assert.Equal(expectedIsFeeFreePark, model.IsFeeFreePark);
        Assert.Equal(expectedIsInteragencyPassAccepted, model.IsInteragencyPassAccepted);
        Assert.Equal(expectedIsParkingFeePossible, model.IsParkingFeePossible);
        Assert.Equal(
            expectedIsParkingOrTransportationFeePossible,
            model.IsParkingOrTransportationFeePossible
        );
        Assert.Equal(expectedPaidParkingDescription, model.PaidParkingDescription);
        Assert.Equal(expectedPaidParkingHeading, model.PaidParkingHeading);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedParkingDetailsUrl, model.ParkingDetailsUrl);
        Assert.NotNull(model.Passes);
        Assert.Equal(expectedPasses.Count, model.Passes.Count);
        for (int i = 0; i < expectedPasses.Count; i++)
        {
            Assert.Equal(expectedPasses[i], model.Passes[i]);
        }
        Assert.NotNull(model.RelatedMultiSitePasses);
        Assert.Equal(expectedRelatedMultiSitePasses.Count, model.RelatedMultiSitePasses.Count);
        for (int i = 0; i < expectedRelatedMultiSitePasses.Count; i++)
        {
            Assert.Equal(expectedRelatedMultiSitePasses[i], model.RelatedMultiSitePasses[i]);
        }
        Assert.Equal(expectedTimedEntryDescription, model.TimedEntryDescription);
        Assert.Equal(expectedTimedEntryHeading, model.TimedEntryHeading);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
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
                    TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                    NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
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
                    TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                    NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        string expectedCashless = "Depends on location";
        ApiEnum<string, ContentOrderOrdinals> expectedContentOrderOrdinals =
            ContentOrderOrdinals.EntranceFee;
        string expectedCustomFeeDescription = "Details about custom fees go here.";
        string expectedCustomFeeHeading = "Special Fees May Apply";
        string expectedCustomFeeLinkText = "Custom Fee Link Text";
        string expectedCustomFeeLinkUrl = "https://www.nps.gov/etc/etc";
        string expectedEntranceFeeDescription =
            "A park entrance pass is required year-round at Acadia National Park. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present. A separate vehicle reservation is also required to drive Cadillac Summit Road from mid-May into October. Vehicle reservations are only sold online in advance and are not available for purchase at the park. In addition to NPS locations in visitor centers and campgrounds, entrance passes are also available for purchase in-person at third-party sellers. These locations are not operated by the NPS and do not offer federal lands passes -- * Jordan Pond Gift Shop * Acadia Regional Chamber of Commerce at Thompson Island * Bar Harbor Chamber of Commerce, Cottage Street * Ellsworth Chamber of Commerce * Mount Desert Chamber of Commerce * Southwest Harbor/Tremont Chamber of Commerce";
        string expectedEntrancePassesDescription =
            "A park entrance pass is required year-round. All vehicles must display a pass clearly visible through the windshield. Display federal lands passes, such as annual and military passes, on your dashboard with the signature and expiration date facing up. Passes are non-transferable and passholder must be present.";
        List<Fee> expectedFees =
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
                InformationUrl = "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
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
                TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
            },
        ];
        string expectedFeesAtWorkUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm";
        bool expectedIsFeeFreePark = true;
        bool expectedIsInteragencyPassAccepted = true;
        bool expectedIsParkingFeePossible = true;
        bool expectedIsParkingOrTransportationFeePossible = false;
        string expectedPaidParkingDescription = "Details about paid parking go here.";
        string expectedPaidParkingHeading = "Paid Parking Available";
        string expectedParkCode = "acad";
        string expectedParkingDetailsUrl = "";
        List<Pass> expectedPasses =
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
                NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
                PayGovPurchaseUrl = "",
                PaymentDescription = "",
                RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
            },
        ];
        List<RelatedMultiSitePass> expectedRelatedMultiSitePasses =
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
                        FullName = "Abraham Lincoln Birthplace National Historical Park",
                        Name = "Abraham Lincoln Birthplace",
                        ParkCode = "abli",
                        States = "KY",
                        Url = "https://www.nps.gov/abli/index.htm",
                    },
                ],
                Title = "Andy's Pass To All The Good Spots",
                Type = "Multi-Site Pass",
            },
        ];
        string expectedTimedEntryDescription =
            "A timed entry reservation is required from 7:00 am to 3:00 pm for two areas of the park: (1) Paradise Corridor entering through the Nisqually and Stevens Canyon Entrances, and (2) Sunrise Corridor entering through the White River Entrance. Each corridor requires a separate vehicle reservation. Timed entry reservations are for good a single day, per vehicle, and are required in addition to an entrance fee or park pass.";
        string expectedTimedEntryHeading = "Timed Entry Reservation";

        Assert.Equal(expectedCashless, deserialized.Cashless);
        Assert.Equal(expectedContentOrderOrdinals, deserialized.ContentOrderOrdinals);
        Assert.Equal(expectedCustomFeeDescription, deserialized.CustomFeeDescription);
        Assert.Equal(expectedCustomFeeHeading, deserialized.CustomFeeHeading);
        Assert.Equal(expectedCustomFeeLinkText, deserialized.CustomFeeLinkText);
        Assert.Equal(expectedCustomFeeLinkUrl, deserialized.CustomFeeLinkUrl);
        Assert.Equal(expectedEntranceFeeDescription, deserialized.EntranceFeeDescription);
        Assert.Equal(expectedEntrancePassesDescription, deserialized.EntrancePassesDescription);
        Assert.NotNull(deserialized.Fees);
        Assert.Equal(expectedFees.Count, deserialized.Fees.Count);
        for (int i = 0; i < expectedFees.Count; i++)
        {
            Assert.Equal(expectedFees[i], deserialized.Fees[i]);
        }
        Assert.Equal(expectedFeesAtWorkUrl, deserialized.FeesAtWorkUrl);
        Assert.Equal(expectedIsFeeFreePark, deserialized.IsFeeFreePark);
        Assert.Equal(expectedIsInteragencyPassAccepted, deserialized.IsInteragencyPassAccepted);
        Assert.Equal(expectedIsParkingFeePossible, deserialized.IsParkingFeePossible);
        Assert.Equal(
            expectedIsParkingOrTransportationFeePossible,
            deserialized.IsParkingOrTransportationFeePossible
        );
        Assert.Equal(expectedPaidParkingDescription, deserialized.PaidParkingDescription);
        Assert.Equal(expectedPaidParkingHeading, deserialized.PaidParkingHeading);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedParkingDetailsUrl, deserialized.ParkingDetailsUrl);
        Assert.NotNull(deserialized.Passes);
        Assert.Equal(expectedPasses.Count, deserialized.Passes.Count);
        for (int i = 0; i < expectedPasses.Count; i++)
        {
            Assert.Equal(expectedPasses[i], deserialized.Passes[i]);
        }
        Assert.NotNull(deserialized.RelatedMultiSitePasses);
        Assert.Equal(
            expectedRelatedMultiSitePasses.Count,
            deserialized.RelatedMultiSitePasses.Count
        );
        for (int i = 0; i < expectedRelatedMultiSitePasses.Count; i++)
        {
            Assert.Equal(expectedRelatedMultiSitePasses[i], deserialized.RelatedMultiSitePasses[i]);
        }
        Assert.Equal(expectedTimedEntryDescription, deserialized.TimedEntryDescription);
        Assert.Equal(expectedTimedEntryHeading, deserialized.TimedEntryHeading);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
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
                    TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
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
                    NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
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
                            FullName = "Abraham Lincoln Birthplace National Historical Park",
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.Cashless);
        Assert.False(model.RawData.ContainsKey("cashless"));
        Assert.Null(model.ContentOrderOrdinals);
        Assert.False(model.RawData.ContainsKey("contentOrderOrdinals"));
        Assert.Null(model.CustomFeeDescription);
        Assert.False(model.RawData.ContainsKey("customFeeDescription"));
        Assert.Null(model.CustomFeeHeading);
        Assert.False(model.RawData.ContainsKey("customFeeHeading"));
        Assert.Null(model.CustomFeeLinkText);
        Assert.False(model.RawData.ContainsKey("customFeeLinkText"));
        Assert.Null(model.CustomFeeLinkUrl);
        Assert.False(model.RawData.ContainsKey("customFeeLinkUrl"));
        Assert.Null(model.EntranceFeeDescription);
        Assert.False(model.RawData.ContainsKey("entranceFeeDescription"));
        Assert.Null(model.EntrancePassesDescription);
        Assert.False(model.RawData.ContainsKey("entrancePassesDescription"));
        Assert.Null(model.Fees);
        Assert.False(model.RawData.ContainsKey("fees"));
        Assert.Null(model.FeesAtWorkUrl);
        Assert.False(model.RawData.ContainsKey("feesAtWorkUrl"));
        Assert.Null(model.IsFeeFreePark);
        Assert.False(model.RawData.ContainsKey("isFeeFreePark"));
        Assert.Null(model.IsInteragencyPassAccepted);
        Assert.False(model.RawData.ContainsKey("isInteragencyPassAccepted"));
        Assert.Null(model.IsParkingFeePossible);
        Assert.False(model.RawData.ContainsKey("isParkingFeePossible"));
        Assert.Null(model.IsParkingOrTransportationFeePossible);
        Assert.False(model.RawData.ContainsKey("isParkingOrTransportationFeePossible"));
        Assert.Null(model.PaidParkingDescription);
        Assert.False(model.RawData.ContainsKey("paidParkingDescription"));
        Assert.Null(model.PaidParkingHeading);
        Assert.False(model.RawData.ContainsKey("paidParkingHeading"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.ParkingDetailsUrl);
        Assert.False(model.RawData.ContainsKey("parkingDetailsUrl"));
        Assert.Null(model.Passes);
        Assert.False(model.RawData.ContainsKey("passes"));
        Assert.Null(model.RelatedMultiSitePasses);
        Assert.False(model.RawData.ContainsKey("relatedMultiSitePasses"));
        Assert.Null(model.TimedEntryDescription);
        Assert.False(model.RawData.ContainsKey("timedEntryDescription"));
        Assert.Null(model.TimedEntryHeading);
        Assert.False(model.RawData.ContainsKey("timedEntryHeading"));
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
            Cashless = null,
            ContentOrderOrdinals = null,
            CustomFeeDescription = null,
            CustomFeeHeading = null,
            CustomFeeLinkText = null,
            CustomFeeLinkUrl = null,
            EntranceFeeDescription = null,
            EntrancePassesDescription = null,
            Fees = null,
            FeesAtWorkUrl = null,
            IsFeeFreePark = null,
            IsInteragencyPassAccepted = null,
            IsParkingFeePossible = null,
            IsParkingOrTransportationFeePossible = null,
            PaidParkingDescription = null,
            PaidParkingHeading = null,
            ParkCode = null,
            ParkingDetailsUrl = null,
            Passes = null,
            RelatedMultiSitePasses = null,
            TimedEntryDescription = null,
            TimedEntryHeading = null,
        };

        Assert.Null(model.Cashless);
        Assert.False(model.RawData.ContainsKey("cashless"));
        Assert.Null(model.ContentOrderOrdinals);
        Assert.False(model.RawData.ContainsKey("contentOrderOrdinals"));
        Assert.Null(model.CustomFeeDescription);
        Assert.False(model.RawData.ContainsKey("customFeeDescription"));
        Assert.Null(model.CustomFeeHeading);
        Assert.False(model.RawData.ContainsKey("customFeeHeading"));
        Assert.Null(model.CustomFeeLinkText);
        Assert.False(model.RawData.ContainsKey("customFeeLinkText"));
        Assert.Null(model.CustomFeeLinkUrl);
        Assert.False(model.RawData.ContainsKey("customFeeLinkUrl"));
        Assert.Null(model.EntranceFeeDescription);
        Assert.False(model.RawData.ContainsKey("entranceFeeDescription"));
        Assert.Null(model.EntrancePassesDescription);
        Assert.False(model.RawData.ContainsKey("entrancePassesDescription"));
        Assert.Null(model.Fees);
        Assert.False(model.RawData.ContainsKey("fees"));
        Assert.Null(model.FeesAtWorkUrl);
        Assert.False(model.RawData.ContainsKey("feesAtWorkUrl"));
        Assert.Null(model.IsFeeFreePark);
        Assert.False(model.RawData.ContainsKey("isFeeFreePark"));
        Assert.Null(model.IsInteragencyPassAccepted);
        Assert.False(model.RawData.ContainsKey("isInteragencyPassAccepted"));
        Assert.Null(model.IsParkingFeePossible);
        Assert.False(model.RawData.ContainsKey("isParkingFeePossible"));
        Assert.Null(model.IsParkingOrTransportationFeePossible);
        Assert.False(model.RawData.ContainsKey("isParkingOrTransportationFeePossible"));
        Assert.Null(model.PaidParkingDescription);
        Assert.False(model.RawData.ContainsKey("paidParkingDescription"));
        Assert.Null(model.PaidParkingHeading);
        Assert.False(model.RawData.ContainsKey("paidParkingHeading"));
        Assert.Null(model.ParkCode);
        Assert.False(model.RawData.ContainsKey("parkCode"));
        Assert.Null(model.ParkingDetailsUrl);
        Assert.False(model.RawData.ContainsKey("parkingDetailsUrl"));
        Assert.Null(model.Passes);
        Assert.False(model.RawData.ContainsKey("passes"));
        Assert.Null(model.RelatedMultiSitePasses);
        Assert.False(model.RawData.ContainsKey("relatedMultiSitePasses"));
        Assert.Null(model.TimedEntryDescription);
        Assert.False(model.RawData.ContainsKey("timedEntryDescription"));
        Assert.Null(model.TimedEntryHeading);
        Assert.False(model.RawData.ContainsKey("timedEntryHeading"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            Cashless = null,
            ContentOrderOrdinals = null,
            CustomFeeDescription = null,
            CustomFeeHeading = null,
            CustomFeeLinkText = null,
            CustomFeeLinkUrl = null,
            EntranceFeeDescription = null,
            EntrancePassesDescription = null,
            Fees = null,
            FeesAtWorkUrl = null,
            IsFeeFreePark = null,
            IsInteragencyPassAccepted = null,
            IsParkingFeePossible = null,
            IsParkingOrTransportationFeePossible = null,
            PaidParkingDescription = null,
            PaidParkingHeading = null,
            ParkCode = null,
            ParkingDetailsUrl = null,
            Passes = null,
            RelatedMultiSitePasses = null,
            TimedEntryDescription = null,
            TimedEntryHeading = null,
        };

        model.Validate();
    }
}

public class ContentOrderOrdinalsTest : TestBase
{
    [Theory]
    [InlineData(ContentOrderOrdinals.EntranceFee)]
    [InlineData(ContentOrderOrdinals.TimedEntry)]
    [InlineData(ContentOrderOrdinals.PaidParking)]
    [InlineData(ContentOrderOrdinals.CustomFee)]
    public void Validation_Works(ContentOrderOrdinals rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ContentOrderOrdinals> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ContentOrderOrdinals>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<NpsInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ContentOrderOrdinals.EntranceFee)]
    [InlineData(ContentOrderOrdinals.TimedEntry)]
    [InlineData(ContentOrderOrdinals.PaidParking)]
    [InlineData(ContentOrderOrdinals.CustomFee)]
    public void SerializationRoundtrip_Works(ContentOrderOrdinals rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ContentOrderOrdinals> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ContentOrderOrdinals>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ContentOrderOrdinals>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ContentOrderOrdinals>>(
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
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
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
            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
        };

        string expectedID = "B0ACE361-8899-4098-A238-18BA39FD67C2";
        string expectedCost = "6.00";
        string expectedDescription =
            "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.";
        EndDate expectedEndDate = new()
        {
            Day = 22,
            Holiday = "",
            Month = 10,
        };
        string expectedEntranceFeeType = "Timed Entry Reservation - Location";
        string expectedExceptions = "";
        string expectedInformationUrl =
            "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm";
        string expectedPayGovPurchaseUrl = "";
        string expectedPaymentDescription =
            "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.";
        string expectedPurchaseUrl = "";
        string expectedRecGovPurchaseUrl = "https://www.recreation.gov/timed-entry/400000";
        StartDate expectedStartDate = new()
        {
            Day = 24,
            Holiday = "",
            Month = 5,
        };
        string expectedTimedEntryLocation = "Cadillac Summit Road Vehicle Reservations";
        string expectedTimedEntryShortDescription = "Required to drive Cadillac Summit Road";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCost, model.Cost);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedEndDate, model.EndDate);
        Assert.Equal(expectedEntranceFeeType, model.EntranceFeeType);
        Assert.Equal(expectedExceptions, model.Exceptions);
        Assert.Equal(expectedInformationUrl, model.InformationUrl);
        Assert.Equal(expectedPayGovPurchaseUrl, model.PayGovPurchaseUrl);
        Assert.Equal(expectedPaymentDescription, model.PaymentDescription);
        Assert.Equal(expectedPurchaseUrl, model.PurchaseUrl);
        Assert.Equal(expectedRecGovPurchaseUrl, model.RecGovPurchaseUrl);
        Assert.Equal(expectedStartDate, model.StartDate);
        Assert.Equal(expectedTimedEntryLocation, model.TimedEntryLocation);
        Assert.Equal(expectedTimedEntryShortDescription, model.TimedEntryShortDescription);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Fee
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
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
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
            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Fee>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Fee
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
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
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
            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Fee>(element);
        Assert.NotNull(deserialized);

        string expectedID = "B0ACE361-8899-4098-A238-18BA39FD67C2";
        string expectedCost = "6.00";
        string expectedDescription =
            "Vehicle reservations are not required for any other areas of the park, or for visitors who enter the area by foot, bike, or taxi. Vehicle reservations provide a timed entry, but do not require a departure time until 10 pm, when the road closes to vehicles. Reservations do not permit re-entry. Reservations are per vehicle, not per person. Reservations do not assign a specific parking space. Parking is prohibited outside of designated spaces. Cadillac is not served by the Island Explorer bus system.";
        EndDate expectedEndDate = new()
        {
            Day = 22,
            Holiday = "",
            Month = 10,
        };
        string expectedEntranceFeeType = "Timed Entry Reservation - Location";
        string expectedExceptions = "";
        string expectedInformationUrl =
            "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm";
        string expectedPayGovPurchaseUrl = "";
        string expectedPaymentDescription =
            "Vehicle reservations cost $6. They are only sold online in advance at Recreation.gov. They are not available for purchase at the park. In addition to purchasing a vehicle reservation for Cadillac Summit Road, vehicles must display a park entrance pass through the windshield. Park entrance passes are available at the park or online at Recreation.gov. Print or save a digital copy of the QR Code that comes with the vehicle reservation confirmation email. It will be scanned to verify the reservation.";
        string expectedPurchaseUrl = "";
        string expectedRecGovPurchaseUrl = "https://www.recreation.gov/timed-entry/400000";
        StartDate expectedStartDate = new()
        {
            Day = 24,
            Holiday = "",
            Month = 5,
        };
        string expectedTimedEntryLocation = "Cadillac Summit Road Vehicle Reservations";
        string expectedTimedEntryShortDescription = "Required to drive Cadillac Summit Road";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCost, deserialized.Cost);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedEndDate, deserialized.EndDate);
        Assert.Equal(expectedEntranceFeeType, deserialized.EntranceFeeType);
        Assert.Equal(expectedExceptions, deserialized.Exceptions);
        Assert.Equal(expectedInformationUrl, deserialized.InformationUrl);
        Assert.Equal(expectedPayGovPurchaseUrl, deserialized.PayGovPurchaseUrl);
        Assert.Equal(expectedPaymentDescription, deserialized.PaymentDescription);
        Assert.Equal(expectedPurchaseUrl, deserialized.PurchaseUrl);
        Assert.Equal(expectedRecGovPurchaseUrl, deserialized.RecGovPurchaseUrl);
        Assert.Equal(expectedStartDate, deserialized.StartDate);
        Assert.Equal(expectedTimedEntryLocation, deserialized.TimedEntryLocation);
        Assert.Equal(expectedTimedEntryShortDescription, deserialized.TimedEntryShortDescription);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Fee
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
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/vehicle_reservations.htm",
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
            TimedEntryShortDescription = "Required to drive Cadillac Summit Road",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Fee { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("endDate"));
        Assert.Null(model.EntranceFeeType);
        Assert.False(model.RawData.ContainsKey("entranceFeeType"));
        Assert.Null(model.Exceptions);
        Assert.False(model.RawData.ContainsKey("exceptions"));
        Assert.Null(model.InformationUrl);
        Assert.False(model.RawData.ContainsKey("informationUrl"));
        Assert.Null(model.PayGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("payGovPurchaseUrl"));
        Assert.Null(model.PaymentDescription);
        Assert.False(model.RawData.ContainsKey("paymentDescription"));
        Assert.Null(model.PurchaseUrl);
        Assert.False(model.RawData.ContainsKey("purchaseUrl"));
        Assert.Null(model.RecGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("recGovPurchaseUrl"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("startDate"));
        Assert.Null(model.TimedEntryLocation);
        Assert.False(model.RawData.ContainsKey("timedEntryLocation"));
        Assert.Null(model.TimedEntryShortDescription);
        Assert.False(model.RawData.ContainsKey("timedEntryShortDescription"));
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
            ID = null,
            Cost = null,
            Description = null,
            EndDate = null,
            EntranceFeeType = null,
            Exceptions = null,
            InformationUrl = null,
            PayGovPurchaseUrl = null,
            PaymentDescription = null,
            PurchaseUrl = null,
            RecGovPurchaseUrl = null,
            StartDate = null,
            TimedEntryLocation = null,
            TimedEntryShortDescription = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.EndDate);
        Assert.False(model.RawData.ContainsKey("endDate"));
        Assert.Null(model.EntranceFeeType);
        Assert.False(model.RawData.ContainsKey("entranceFeeType"));
        Assert.Null(model.Exceptions);
        Assert.False(model.RawData.ContainsKey("exceptions"));
        Assert.Null(model.InformationUrl);
        Assert.False(model.RawData.ContainsKey("informationUrl"));
        Assert.Null(model.PayGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("payGovPurchaseUrl"));
        Assert.Null(model.PaymentDescription);
        Assert.False(model.RawData.ContainsKey("paymentDescription"));
        Assert.Null(model.PurchaseUrl);
        Assert.False(model.RawData.ContainsKey("purchaseUrl"));
        Assert.Null(model.RecGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("recGovPurchaseUrl"));
        Assert.Null(model.StartDate);
        Assert.False(model.RawData.ContainsKey("startDate"));
        Assert.Null(model.TimedEntryLocation);
        Assert.False(model.RawData.ContainsKey("timedEntryLocation"));
        Assert.Null(model.TimedEntryShortDescription);
        Assert.False(model.RawData.ContainsKey("timedEntryShortDescription"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Fee
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Cost = null,
            Description = null,
            EndDate = null,
            EntranceFeeType = null,
            Exceptions = null,
            InformationUrl = null,
            PayGovPurchaseUrl = null,
            PaymentDescription = null,
            PurchaseUrl = null,
            RecGovPurchaseUrl = null,
            StartDate = null,
            TimedEntryLocation = null,
            TimedEntryShortDescription = null,
        };

        model.Validate();
    }
}

public class EndDateTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new EndDate
        {
            Day = 22,
            Holiday = "",
            Month = 10,
        };

        long expectedDay = 22;
        string expectedHoliday = "";
        long expectedMonth = 10;

        Assert.Equal(expectedDay, model.Day);
        Assert.Equal(expectedHoliday, model.Holiday);
        Assert.Equal(expectedMonth, model.Month);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new EndDate
        {
            Day = 22,
            Holiday = "",
            Month = 10,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<EndDate>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new EndDate
        {
            Day = 22,
            Holiday = "",
            Month = 10,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<EndDate>(element);
        Assert.NotNull(deserialized);

        long expectedDay = 22;
        string expectedHoliday = "";
        long expectedMonth = 10;

        Assert.Equal(expectedDay, deserialized.Day);
        Assert.Equal(expectedHoliday, deserialized.Holiday);
        Assert.Equal(expectedMonth, deserialized.Month);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new EndDate
        {
            Day = 22,
            Holiday = "",
            Month = 10,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new EndDate { };

        Assert.Null(model.Day);
        Assert.False(model.RawData.ContainsKey("day"));
        Assert.Null(model.Holiday);
        Assert.False(model.RawData.ContainsKey("holiday"));
        Assert.Null(model.Month);
        Assert.False(model.RawData.ContainsKey("month"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new EndDate { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new EndDate
        {
            // Null should be interpreted as omitted for these properties
            Day = null,
            Holiday = null,
            Month = null,
        };

        Assert.Null(model.Day);
        Assert.False(model.RawData.ContainsKey("day"));
        Assert.Null(model.Holiday);
        Assert.False(model.RawData.ContainsKey("holiday"));
        Assert.Null(model.Month);
        Assert.False(model.RawData.ContainsKey("month"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new EndDate
        {
            // Null should be interpreted as omitted for these properties
            Day = null,
            Holiday = null,
            Month = null,
        };

        model.Validate();
    }
}

public class StartDateTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StartDate
        {
            Day = 24,
            Holiday = "",
            Month = 5,
        };

        long expectedDay = 24;
        string expectedHoliday = "";
        long expectedMonth = 5;

        Assert.Equal(expectedDay, model.Day);
        Assert.Equal(expectedHoliday, model.Holiday);
        Assert.Equal(expectedMonth, model.Month);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StartDate
        {
            Day = 24,
            Holiday = "",
            Month = 5,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<StartDate>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StartDate
        {
            Day = 24,
            Holiday = "",
            Month = 5,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<StartDate>(element);
        Assert.NotNull(deserialized);

        long expectedDay = 24;
        string expectedHoliday = "";
        long expectedMonth = 5;

        Assert.Equal(expectedDay, deserialized.Day);
        Assert.Equal(expectedHoliday, deserialized.Holiday);
        Assert.Equal(expectedMonth, deserialized.Month);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StartDate
        {
            Day = 24,
            Holiday = "",
            Month = 5,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new StartDate { };

        Assert.Null(model.Day);
        Assert.False(model.RawData.ContainsKey("day"));
        Assert.Null(model.Holiday);
        Assert.False(model.RawData.ContainsKey("holiday"));
        Assert.Null(model.Month);
        Assert.False(model.RawData.ContainsKey("month"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new StartDate { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new StartDate
        {
            // Null should be interpreted as omitted for these properties
            Day = null,
            Holiday = null,
            Month = null,
        };

        Assert.Null(model.Day);
        Assert.False(model.RawData.ContainsKey("day"));
        Assert.Null(model.Holiday);
        Assert.False(model.RawData.ContainsKey("holiday"));
        Assert.Null(model.Month);
        Assert.False(model.RawData.ContainsKey("month"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new StartDate
        {
            // Null should be interpreted as omitted for these properties
            Day = null,
            Holiday = null,
            Month = null,
        };

        model.Validate();
    }
}

public class PassTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Pass
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
                    Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                },
            ],
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            PayGovPurchaseUrl = "",
            PaymentDescription = "",
            RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
        };

        string expectedID = "F647C604-6000-4454-A9FB-6147436E8A7C";
        string expectedCategory = "Annual Entrance - Park";
        string expectedCost = "70.00";
        string expectedDescription =
            "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.";
        string expectedExceptions = "";
        List<Image> expectedImage =
        [
            new()
            {
                AltText = "Test Image",
                Caption = "Testing",
                Credit = "Test Credit",
                Title = "Test Image",
                Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
            },
        ];
        string expectedInformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm";
        string expectedNpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm";
        string expectedPayGovPurchaseUrl = "";
        string expectedPaymentDescription = "";
        string expectedRecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCategory, model.Category);
        Assert.Equal(expectedCost, model.Cost);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedExceptions, model.Exceptions);
        Assert.NotNull(model.Image);
        Assert.Equal(expectedImage.Count, model.Image.Count);
        for (int i = 0; i < expectedImage.Count; i++)
        {
            Assert.Equal(expectedImage[i], model.Image[i]);
        }
        Assert.Equal(expectedInformationUrl, model.InformationUrl);
        Assert.Equal(expectedNpsGovPurchaseUrl, model.NpsGovPurchaseUrl);
        Assert.Equal(expectedPayGovPurchaseUrl, model.PayGovPurchaseUrl);
        Assert.Equal(expectedPaymentDescription, model.PaymentDescription);
        Assert.Equal(expectedRecGovPurchaseUrl, model.RecGovPurchaseUrl);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Pass
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
                    Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                },
            ],
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            PayGovPurchaseUrl = "",
            PaymentDescription = "",
            RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Pass>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Pass
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
                    Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                },
            ],
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            PayGovPurchaseUrl = "",
            PaymentDescription = "",
            RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Pass>(element);
        Assert.NotNull(deserialized);

        string expectedID = "F647C604-6000-4454-A9FB-6147436E8A7C";
        string expectedCategory = "Annual Entrance - Park";
        string expectedCost = "70.00";
        string expectedDescription =
            "The Acadia Annual Pass is valid only at Acadia and may be purchased online or in person. You do not need an additional entrance pass if you already have a federal lands pass. It is valid for 12 months from purchase month. This pass admits the pass holder and passengers in a non-commercial vehicle. In addition to park visitor centers and campgrounds, the Acadia Annual Pass is available at the Acadia Regional Chamber at Thompson Island, and at Bar Harbor, Ellsworth and Southwest Harbor chambers of commerce.";
        string expectedExceptions = "";
        List<Image> expectedImage =
        [
            new()
            {
                AltText = "Test Image",
                Caption = "Testing",
                Credit = "Test Credit",
                Title = "Test Image",
                Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
            },
        ];
        string expectedInformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm";
        string expectedNpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm";
        string expectedPayGovPurchaseUrl = "";
        string expectedPaymentDescription = "";
        string expectedRecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCategory, deserialized.Category);
        Assert.Equal(expectedCost, deserialized.Cost);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedExceptions, deserialized.Exceptions);
        Assert.NotNull(deserialized.Image);
        Assert.Equal(expectedImage.Count, deserialized.Image.Count);
        for (int i = 0; i < expectedImage.Count; i++)
        {
            Assert.Equal(expectedImage[i], deserialized.Image[i]);
        }
        Assert.Equal(expectedInformationUrl, deserialized.InformationUrl);
        Assert.Equal(expectedNpsGovPurchaseUrl, deserialized.NpsGovPurchaseUrl);
        Assert.Equal(expectedPayGovPurchaseUrl, deserialized.PayGovPurchaseUrl);
        Assert.Equal(expectedPaymentDescription, deserialized.PaymentDescription);
        Assert.Equal(expectedRecGovPurchaseUrl, deserialized.RecGovPurchaseUrl);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Pass
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
                    Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
                },
            ],
            InformationUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            NpsGovPurchaseUrl = "https://www.nps.gov/acad/planyourvisit/fees.htm",
            PayGovPurchaseUrl = "",
            PaymentDescription = "",
            RecGovPurchaseUrl = "https://www.recreation.gov/sitepass/74271",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Pass { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Category);
        Assert.False(model.RawData.ContainsKey("category"));
        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Exceptions);
        Assert.False(model.RawData.ContainsKey("exceptions"));
        Assert.Null(model.Image);
        Assert.False(model.RawData.ContainsKey("image"));
        Assert.Null(model.InformationUrl);
        Assert.False(model.RawData.ContainsKey("informationUrl"));
        Assert.Null(model.NpsGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("npsGovPurchaseUrl"));
        Assert.Null(model.PayGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("payGovPurchaseUrl"));
        Assert.Null(model.PaymentDescription);
        Assert.False(model.RawData.ContainsKey("paymentDescription"));
        Assert.Null(model.RecGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("recGovPurchaseUrl"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Pass { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Pass
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Category = null,
            Cost = null,
            Description = null,
            Exceptions = null,
            Image = null,
            InformationUrl = null,
            NpsGovPurchaseUrl = null,
            PayGovPurchaseUrl = null,
            PaymentDescription = null,
            RecGovPurchaseUrl = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Category);
        Assert.False(model.RawData.ContainsKey("category"));
        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Exceptions);
        Assert.False(model.RawData.ContainsKey("exceptions"));
        Assert.Null(model.Image);
        Assert.False(model.RawData.ContainsKey("image"));
        Assert.Null(model.InformationUrl);
        Assert.False(model.RawData.ContainsKey("informationUrl"));
        Assert.Null(model.NpsGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("npsGovPurchaseUrl"));
        Assert.Null(model.PayGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("payGovPurchaseUrl"));
        Assert.Null(model.PaymentDescription);
        Assert.False(model.RawData.ContainsKey("paymentDescription"));
        Assert.Null(model.RecGovPurchaseUrl);
        Assert.False(model.RawData.ContainsKey("recGovPurchaseUrl"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Pass
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Category = null,
            Cost = null,
            Description = null,
            Exceptions = null,
            Image = null,
            InformationUrl = null,
            NpsGovPurchaseUrl = null,
            PayGovPurchaseUrl = null,
            PaymentDescription = null,
            RecGovPurchaseUrl = null,
        };

        model.Validate();
    }
}

public class ImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Image
        {
            AltText = "Test Image",
            Caption = "Testing",
            Credit = "Test Credit",
            Title = "Test Image",
            Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
        };

        string expectedAltText = "Test Image";
        string expectedCaption = "Testing";
        string expectedCredit = "Test Credit";
        string expectedTitle = "Test Image";
        string expectedUrl =
            "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Image
        {
            AltText = "Test Image",
            Caption = "Testing",
            Credit = "Test Credit",
            Title = "Test Image",
            Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Image
        {
            AltText = "Test Image",
            Caption = "Testing",
            Credit = "Test Credit",
            Title = "Test Image",
            Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "Test Image";
        string expectedCaption = "Testing";
        string expectedCredit = "Test Credit";
        string expectedTitle = "Test Image";
        string expectedUrl =
            "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Image
        {
            AltText = "Test Image",
            Caption = "Testing",
            Credit = "Test Credit",
            Title = "Test Image",
            Url = "/common/uploads/entrance_pass/D6D2EEDD-C4CD-4139-021C101891BD86AB.jpg",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Image { };

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
        var model = new Image { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Image
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
        var model = new Image
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

public class RelatedMultiSitePassTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RelatedMultiSitePass
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
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
            Title = "Andy's Pass To All The Good Spots",
            Type = "Multi-Site Pass",
        };

        string expectedAudience = "People with great taste.";
        string expectedCost = "100.00";
        string expectedDescription = "All of these parks exist.";
        List<RelatedMultiSitePassImage> expectedImages =
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
        ];
        List<PurchaseLocation> expectedPurchaseLocations =
        [
            new()
            {
                ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                PaymentMethod = "Cash Only",
                Title = "Houla Campground",
                Type = "campgrounds",
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National Historic Park",
                FullName = "Abraham Lincoln Birthplace National Historical Park",
                Name = "Abraham Lincoln Birthplace",
                ParkCode = "abli",
                States = "KY",
                Url = "https://www.nps.gov/abli/index.htm",
            },
        ];
        string expectedTitle = "Andy's Pass To All The Good Spots";
        string expectedType = "Multi-Site Pass";

        Assert.Equal(expectedAudience, model.Audience);
        Assert.Equal(expectedCost, model.Cost);
        Assert.Equal(expectedDescription, model.Description);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.NotNull(model.PurchaseLocations);
        Assert.Equal(expectedPurchaseLocations.Count, model.PurchaseLocations.Count);
        for (int i = 0; i < expectedPurchaseLocations.Count; i++)
        {
            Assert.Equal(expectedPurchaseLocations[i], model.PurchaseLocations[i]);
        }
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedMultiSitePass
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
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
            Title = "Andy's Pass To All The Good Spots",
            Type = "Multi-Site Pass",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedMultiSitePass>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedMultiSitePass
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
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
            Title = "Andy's Pass To All The Good Spots",
            Type = "Multi-Site Pass",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedMultiSitePass>(element);
        Assert.NotNull(deserialized);

        string expectedAudience = "People with great taste.";
        string expectedCost = "100.00";
        string expectedDescription = "All of these parks exist.";
        List<RelatedMultiSitePassImage> expectedImages =
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
        ];
        List<PurchaseLocation> expectedPurchaseLocations =
        [
            new()
            {
                ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
                PaymentMethod = "Cash Only",
                Title = "Houla Campground",
                Type = "campgrounds",
            },
        ];
        List<RelatedPark> expectedRelatedParks =
        [
            new()
            {
                Designation = "National Historic Park",
                FullName = "Abraham Lincoln Birthplace National Historical Park",
                Name = "Abraham Lincoln Birthplace",
                ParkCode = "abli",
                States = "KY",
                Url = "https://www.nps.gov/abli/index.htm",
            },
        ];
        string expectedTitle = "Andy's Pass To All The Good Spots";
        string expectedType = "Multi-Site Pass";

        Assert.Equal(expectedAudience, deserialized.Audience);
        Assert.Equal(expectedCost, deserialized.Cost);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.NotNull(deserialized.PurchaseLocations);
        Assert.Equal(expectedPurchaseLocations.Count, deserialized.PurchaseLocations.Count);
        for (int i = 0; i < expectedPurchaseLocations.Count; i++)
        {
            Assert.Equal(expectedPurchaseLocations[i], deserialized.PurchaseLocations[i]);
        }
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedMultiSitePass
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
                    FullName = "Abraham Lincoln Birthplace National Historical Park",
                    Name = "Abraham Lincoln Birthplace",
                    ParkCode = "abli",
                    States = "KY",
                    Url = "https://www.nps.gov/abli/index.htm",
                },
            ],
            Title = "Andy's Pass To All The Good Spots",
            Type = "Multi-Site Pass",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RelatedMultiSitePass { };

        Assert.Null(model.Audience);
        Assert.False(model.RawData.ContainsKey("audience"));
        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.PurchaseLocations);
        Assert.False(model.RawData.ContainsKey("purchaseLocations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new RelatedMultiSitePass { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RelatedMultiSitePass
        {
            // Null should be interpreted as omitted for these properties
            Audience = null,
            Cost = null,
            Description = null,
            Images = null,
            PurchaseLocations = null,
            RelatedParks = null,
            Title = null,
            Type = null,
        };

        Assert.Null(model.Audience);
        Assert.False(model.RawData.ContainsKey("audience"));
        Assert.Null(model.Cost);
        Assert.False(model.RawData.ContainsKey("cost"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.PurchaseLocations);
        Assert.False(model.RawData.ContainsKey("purchaseLocations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RelatedMultiSitePass
        {
            // Null should be interpreted as omitted for these properties
            Audience = null,
            Cost = null,
            Description = null,
            Images = null,
            PurchaseLocations = null,
            RelatedParks = null,
            Title = null,
            Type = null,
        };

        model.Validate();
    }
}

public class RelatedMultiSitePassImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RelatedMultiSitePassImage
        {
            AltText = "The Memorial Building surrounded by fall colors",
            Caption =
                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
            Credit = "NPS Photo",
            Title = "The Memorial Building with fall colors",
            Url =
                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
        };

        string expectedAltText = "The Memorial Building surrounded by fall colors";
        string expectedCaption =
            "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born";
        string expectedCredit = "NPS Photo";
        string expectedTitle = "The Memorial Building with fall colors";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedMultiSitePassImage
        {
            AltText = "The Memorial Building surrounded by fall colors",
            Caption =
                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
            Credit = "NPS Photo",
            Title = "The Memorial Building with fall colors",
            Url =
                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedMultiSitePassImage>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedMultiSitePassImage
        {
            AltText = "The Memorial Building surrounded by fall colors",
            Caption =
                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
            Credit = "NPS Photo",
            Title = "The Memorial Building with fall colors",
            Url =
                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedMultiSitePassImage>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "The Memorial Building surrounded by fall colors";
        string expectedCaption =
            "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born";
        string expectedCredit = "NPS Photo";
        string expectedTitle = "The Memorial Building with fall colors";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedMultiSitePassImage
        {
            AltText = "The Memorial Building surrounded by fall colors",
            Caption =
                "Over 200,000 people a year come to walk up the steps of the Memorial Building to visit the site where Abraham Lincoln was born",
            Credit = "NPS Photo",
            Title = "The Memorial Building with fall colors",
            Url =
                "https://www.nps.gov/common/uploads/structured_data/3C861078-1DD8-B71B-0B774A242EF6A706.jpg",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RelatedMultiSitePassImage { };

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
        var model = new RelatedMultiSitePassImage { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RelatedMultiSitePassImage
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
        var model = new RelatedMultiSitePassImage
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

public class PurchaseLocationTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PurchaseLocation
        {
            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
            PaymentMethod = "Cash Only",
            Title = "Houla Campground",
            Type = "campgrounds",
        };

        string expectedID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86";
        string expectedPaymentMethod = "Cash Only";
        string expectedTitle = "Houla Campground";
        string expectedType = "campgrounds";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedPaymentMethod, model.PaymentMethod);
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PurchaseLocation
        {
            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
            PaymentMethod = "Cash Only",
            Title = "Houla Campground",
            Type = "campgrounds",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PurchaseLocation>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PurchaseLocation
        {
            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
            PaymentMethod = "Cash Only",
            Title = "Houla Campground",
            Type = "campgrounds",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<PurchaseLocation>(element);
        Assert.NotNull(deserialized);

        string expectedID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86";
        string expectedPaymentMethod = "Cash Only";
        string expectedTitle = "Houla Campground";
        string expectedType = "campgrounds";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedPaymentMethod, deserialized.PaymentMethod);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PurchaseLocation
        {
            ID = "EA81BC45-C361-437F-89B8-5C89FB0D0F86",
            PaymentMethod = "Cash Only",
            Title = "Houla Campground",
            Type = "campgrounds",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PurchaseLocation { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.PaymentMethod);
        Assert.False(model.RawData.ContainsKey("paymentMethod"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PurchaseLocation { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PurchaseLocation
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            PaymentMethod = null,
            Title = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.PaymentMethod);
        Assert.False(model.RawData.ContainsKey("paymentMethod"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PurchaseLocation
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            PaymentMethod = null,
            Title = null,
            Type = null,
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
            Designation = "National Historic Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
        };

        string expectedDesignation = "National Historic Park";
        string expectedFullName = "Abraham Lincoln Birthplace National Historical Park";
        string expectedName = "Abraham Lincoln Birthplace";
        string expectedParkCode = "abli";
        string expectedStates = "KY";
        string expectedUrl = "https://www.nps.gov/abli/index.htm";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.Equal(expectedStates, model.States);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Historic Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Historic Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Historic Park";
        string expectedFullName = "Abraham Lincoln Birthplace National Historical Park";
        string expectedName = "Abraham Lincoln Birthplace";
        string expectedParkCode = "abli";
        string expectedStates = "KY";
        string expectedUrl = "https://www.nps.gov/abli/index.htm";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.Equal(expectedStates, deserialized.States);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Historic Park",
            FullName = "Abraham Lincoln Birthplace National Historical Park",
            Name = "Abraham Lincoln Birthplace",
            ParkCode = "abli",
            States = "KY",
            Url = "https://www.nps.gov/abli/index.htm",
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
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
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
        Assert.Null(model.States);
        Assert.False(model.RawData.ContainsKey("states"));
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
            States = null,
            Url = null,
        };

        model.Validate();
    }
}
