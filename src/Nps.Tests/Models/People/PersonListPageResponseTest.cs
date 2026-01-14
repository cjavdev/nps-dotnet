using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.People;

namespace Nps.Tests.Models.People;

public class PersonListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PersonListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494",
                            BodyText =
                                "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>",
                            FirstName = "Pauline",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
                                    Caption = "",
                                    Credit = "Golden Gate National Recreation Area Park Archives",
                                    Crops = ["string"],
                                    Title = "",
                                    Url =
                                        "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
                                },
                            ],
                            LastName = "Fryer",
                            Latitude = "",
                            LatLong = "latLong",
                            ListingDescription =
                                "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.",
                            Longitude = "longitude",
                            MiddleName = "Cushman",
                            QuickFacts =
                            [
                                new()
                                {
                                    ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                                    Name = "Significance: ",
                                    Value = "Civil War Spy",
                                },
                            ],
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Recreation Area",
                                    FullName = "Golden Gate National Recreation Area",
                                    Name = "Golden Gate",
                                    ParkCode = "goga",
                                    States = ["CA"],
                                    Url = "https://www.nps.gov/goga/index.htm",
                                },
                            ],
                            Title = "Pauline Cushman-Fryer",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "451",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<PersonListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494",
                        BodyText =
                            "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>",
                        FirstName = "Pauline",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images =
                        [
                            new()
                            {
                                AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
                                Caption = "",
                                Credit = "Golden Gate National Recreation Area Park Archives",
                                Crops = ["string"],
                                Title = "",
                                Url =
                                    "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
                            },
                        ],
                        LastName = "Fryer",
                        Latitude = "",
                        LatLong = "latLong",
                        ListingDescription =
                            "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.",
                        Longitude = "longitude",
                        MiddleName = "Cushman",
                        QuickFacts =
                        [
                            new()
                            {
                                ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                                Name = "Significance: ",
                                Value = "Civil War Spy",
                            },
                        ],
                        RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Recreation Area",
                                FullName = "Golden Gate National Recreation Area",
                                Name = "Golden Gate",
                                ParkCode = "goga",
                                States = ["CA"],
                                Url = "https://www.nps.gov/goga/index.htm",
                            },
                        ],
                        Title = "Pauline Cushman-Fryer",
                        Url = "url",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "451",
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
        var model = new PersonListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494",
                            BodyText =
                                "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>",
                            FirstName = "Pauline",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
                                    Caption = "",
                                    Credit = "Golden Gate National Recreation Area Park Archives",
                                    Crops = ["string"],
                                    Title = "",
                                    Url =
                                        "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
                                },
                            ],
                            LastName = "Fryer",
                            Latitude = "",
                            LatLong = "latLong",
                            ListingDescription =
                                "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.",
                            Longitude = "longitude",
                            MiddleName = "Cushman",
                            QuickFacts =
                            [
                                new()
                                {
                                    ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                                    Name = "Significance: ",
                                    Value = "Civil War Spy",
                                },
                            ],
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Recreation Area",
                                    FullName = "Golden Gate National Recreation Area",
                                    Name = "Golden Gate",
                                    ParkCode = "goga",
                                    States = ["CA"],
                                    Url = "https://www.nps.gov/goga/index.htm",
                                },
                            ],
                            Title = "Pauline Cushman-Fryer",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "451",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PersonListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PersonListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494",
                            BodyText =
                                "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>",
                            FirstName = "Pauline",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
                                    Caption = "",
                                    Credit = "Golden Gate National Recreation Area Park Archives",
                                    Crops = ["string"],
                                    Title = "",
                                    Url =
                                        "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
                                },
                            ],
                            LastName = "Fryer",
                            Latitude = "",
                            LatLong = "latLong",
                            ListingDescription =
                                "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.",
                            Longitude = "longitude",
                            MiddleName = "Cushman",
                            QuickFacts =
                            [
                                new()
                                {
                                    ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                                    Name = "Significance: ",
                                    Value = "Civil War Spy",
                                },
                            ],
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Recreation Area",
                                    FullName = "Golden Gate National Recreation Area",
                                    Name = "Golden Gate",
                                    ParkCode = "goga",
                                    States = ["CA"],
                                    Url = "https://www.nps.gov/goga/index.htm",
                                },
                            ],
                            Title = "Pauline Cushman-Fryer",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "451",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PersonListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<PersonListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494",
                        BodyText =
                            "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>",
                        FirstName = "Pauline",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images =
                        [
                            new()
                            {
                                AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
                                Caption = "",
                                Credit = "Golden Gate National Recreation Area Park Archives",
                                Crops = ["string"],
                                Title = "",
                                Url =
                                    "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
                            },
                        ],
                        LastName = "Fryer",
                        Latitude = "",
                        LatLong = "latLong",
                        ListingDescription =
                            "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.",
                        Longitude = "longitude",
                        MiddleName = "Cushman",
                        QuickFacts =
                        [
                            new()
                            {
                                ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                                Name = "Significance: ",
                                Value = "Civil War Spy",
                            },
                        ],
                        RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Recreation Area",
                                FullName = "Golden Gate National Recreation Area",
                                Name = "Golden Gate",
                                ParkCode = "goga",
                                States = ["CA"],
                                Url = "https://www.nps.gov/goga/index.htm",
                            },
                        ],
                        Title = "Pauline Cushman-Fryer",
                        Url = "url",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "451",
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
        var model = new PersonListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494",
                            BodyText =
                                "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>",
                            FirstName = "Pauline",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
                                    Caption = "",
                                    Credit = "Golden Gate National Recreation Area Park Archives",
                                    Crops = ["string"],
                                    Title = "",
                                    Url =
                                        "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
                                },
                            ],
                            LastName = "Fryer",
                            Latitude = "",
                            LatLong = "latLong",
                            ListingDescription =
                                "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.",
                            Longitude = "longitude",
                            MiddleName = "Cushman",
                            QuickFacts =
                            [
                                new()
                                {
                                    ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                                    Name = "Significance: ",
                                    Value = "Civil War Spy",
                                },
                            ],
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Recreation Area",
                                    FullName = "Golden Gate National Recreation Area",
                                    Name = "Golden Gate",
                                    ParkCode = "goga",
                                    States = ["CA"],
                                    Url = "https://www.nps.gov/goga/index.htm",
                                },
                            ],
                            Title = "Pauline Cushman-Fryer",
                            Url = "url",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "451",
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
        var model = new PersonListPageResponse { };

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
        var model = new PersonListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PersonListPageResponse
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
        var model = new PersonListPageResponse
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
