using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.People;

namespace Nps.Tests.Models.People;

public class PersonListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PersonListResponse
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
        };

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "451";

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
        var model = new PersonListResponse
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
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PersonListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PersonListResponse
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
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PersonListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "451";

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
        var model = new PersonListResponse
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PersonListResponse { };

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
        var model = new PersonListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PersonListResponse
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
        var model = new PersonListResponse
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
        };

        string expectedID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494";
        string expectedBodyText =
            "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>";
        string expectedFirstName = "Pauline";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<Image> expectedImages =
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
        ];
        string expectedLastName = "Fryer";
        string expectedLatitude = "";
        string expectedLatLong = "latLong";
        string expectedListingDescription =
            "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.";
        string expectedLongitude = "longitude";
        string expectedMiddleName = "Cushman";
        List<QuickFact> expectedQuickFacts =
        [
            new()
            {
                ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                Name = "Significance: ",
                Value = "Civil War Spy",
            },
        ];
        List<JsonElement> expectedRelatedOrganizations =
        [
            JsonSerializer.Deserialize<JsonElement>("{}"),
        ];
        List<RelatedPark> expectedRelatedParks =
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
        ];
        string expectedTitle = "Pauline Cushman-Fryer";
        string expectedUrl = "url";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBodyText, model.BodyText);
        Assert.Equal(expectedFirstName, model.FirstName);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedLastName, model.LastName);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLatLong, model.LatLong);
        Assert.Equal(expectedListingDescription, model.ListingDescription);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedMiddleName, model.MiddleName);
        Assert.NotNull(model.QuickFacts);
        Assert.Equal(expectedQuickFacts.Count, model.QuickFacts.Count);
        for (int i = 0; i < expectedQuickFacts.Count; i++)
        {
            Assert.Equal(expectedQuickFacts[i], model.QuickFacts[i]);
        }
        Assert.NotNull(model.RelatedOrganizations);
        Assert.Equal(expectedRelatedOrganizations.Count, model.RelatedOrganizations.Count);
        for (int i = 0; i < expectedRelatedOrganizations.Count; i++)
        {
            Assert.True(
                JsonElement.DeepEquals(
                    expectedRelatedOrganizations[i],
                    model.RelatedOrganizations[i]
                )
            );
        }
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
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
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
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
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "7013F68B-9DAC-4C96-B1C5-0256CC6D1494";
        string expectedBodyText =
            "<p>Though trained as an actress, <strong>Pauline Cushman-Fryer</strong>'s legacy is her service as a spy for the Union during the Civil War. During a stage performance in Louisville, Kentucky, Cushman-Fryer boldly proposed a toast to Jefferson Davis at the behest of Union officers (in the script, the toast was supposed to go to President Lincoln). Impressed by her &quot;loyalty,&quot; Confederate officers took her into their confidence. Months later, a curious Confederate sentry arrested her with information on the whereabouts of the Army of Tennessee and she was sent to Gen. Bragg's headquarters. When her identity as a spy was confirmed, Pauline Cushman-Fryer was sentenced to be hanged.</p>\n\n<p>Before the sentence could be carried out, however, Union forces captured the town of Shelbyville and the Confederates quickly retreated--leaving Cushman-Fryer behind. Following her brush with death, the army awarded Pauline Cushman-Fryer the brevet rank of major for her heroic service as a spy. She died in San Francisco in 1893 and is interred in the <a href=\"https://www.nps.gov/prsf/historyculture/san-francisco-national-cemetery.htm\" id=\"CP___PAGEID=137178,san-francisco-national-cemetery.htm,2253|\">San Francisco National Cemetery</a> in the Presidio.</p>\n\n<p><em>Pauline Cushman-Fryer is buried in the Officers' Section.</em></p>";
        string expectedFirstName = "Pauline";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<Image> expectedImages =
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
        ];
        string expectedLastName = "Fryer";
        string expectedLatitude = "";
        string expectedLatLong = "latLong";
        string expectedListingDescription =
            "Actress and Civil War spy, Pauline Cushman-Fryer narrowly escaped execution for her service to the Union cause. Undercover in Tennessee she performed an illness to escape hanging. She is buried in the Officer's section of the San Francisco National Cemetery at the Presidio.";
        string expectedLongitude = "longitude";
        string expectedMiddleName = "Cushman";
        List<QuickFact> expectedQuickFacts =
        [
            new()
            {
                ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
                Name = "Significance: ",
                Value = "Civil War Spy",
            },
        ];
        List<JsonElement> expectedRelatedOrganizations =
        [
            JsonSerializer.Deserialize<JsonElement>("{}"),
        ];
        List<RelatedPark> expectedRelatedParks =
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
        ];
        string expectedTitle = "Pauline Cushman-Fryer";
        string expectedUrl = "url";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedBodyText, deserialized.BodyText);
        Assert.Equal(expectedFirstName, deserialized.FirstName);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedLastName, deserialized.LastName);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLatLong, deserialized.LatLong);
        Assert.Equal(expectedListingDescription, deserialized.ListingDescription);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedMiddleName, deserialized.MiddleName);
        Assert.NotNull(deserialized.QuickFacts);
        Assert.Equal(expectedQuickFacts.Count, deserialized.QuickFacts.Count);
        for (int i = 0; i < expectedQuickFacts.Count; i++)
        {
            Assert.Equal(expectedQuickFacts[i], deserialized.QuickFacts[i]);
        }
        Assert.NotNull(deserialized.RelatedOrganizations);
        Assert.Equal(expectedRelatedOrganizations.Count, deserialized.RelatedOrganizations.Count);
        for (int i = 0; i < expectedRelatedOrganizations.Count; i++)
        {
            Assert.True(
                JsonElement.DeepEquals(
                    expectedRelatedOrganizations[i],
                    deserialized.RelatedOrganizations[i]
                )
            );
        }
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.BodyText);
        Assert.False(model.RawData.ContainsKey("bodyText"));
        Assert.Null(model.FirstName);
        Assert.False(model.RawData.ContainsKey("firstName"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.LastName);
        Assert.False(model.RawData.ContainsKey("lastName"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.ListingDescription);
        Assert.False(model.RawData.ContainsKey("listingDescription"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.MiddleName);
        Assert.False(model.RawData.ContainsKey("middleName"));
        Assert.Null(model.QuickFacts);
        Assert.False(model.RawData.ContainsKey("quickFacts"));
        Assert.Null(model.RelatedOrganizations);
        Assert.False(model.RawData.ContainsKey("relatedOrganizations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
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
            ID = null,
            BodyText = null,
            FirstName = null,
            GeometryPoiID = null,
            Images = null,
            LastName = null,
            Latitude = null,
            LatLong = null,
            ListingDescription = null,
            Longitude = null,
            MiddleName = null,
            QuickFacts = null,
            RelatedOrganizations = null,
            RelatedParks = null,
            Title = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.BodyText);
        Assert.False(model.RawData.ContainsKey("bodyText"));
        Assert.Null(model.FirstName);
        Assert.False(model.RawData.ContainsKey("firstName"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.LastName);
        Assert.False(model.RawData.ContainsKey("lastName"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.LatLong);
        Assert.False(model.RawData.ContainsKey("latLong"));
        Assert.Null(model.ListingDescription);
        Assert.False(model.RawData.ContainsKey("listingDescription"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.MiddleName);
        Assert.False(model.RawData.ContainsKey("middleName"));
        Assert.Null(model.QuickFacts);
        Assert.False(model.RawData.ContainsKey("quickFacts"));
        Assert.Null(model.RelatedOrganizations);
        Assert.False(model.RawData.ContainsKey("relatedOrganizations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            BodyText = null,
            FirstName = null,
            GeometryPoiID = null,
            Images = null,
            LastName = null,
            Latitude = null,
            LatLong = null,
            ListingDescription = null,
            Longitude = null,
            MiddleName = null,
            QuickFacts = null,
            RelatedOrganizations = null,
            RelatedParks = null,
            Title = null,
            Url = null,
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
            AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
            Caption = "",
            Credit = "Golden Gate National Recreation Area Park Archives",
            Crops = ["string"],
            Title = "",
            Url =
                "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
        };

        string expectedAltText = "Portrait Pauline Cushman Fryer in soldier uniform";
        string expectedCaption = "";
        string expectedCredit = "Golden Gate National Recreation Area Park Archives";
        List<string> expectedCrops = ["string"];
        string expectedTitle = "";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg";

        Assert.Equal(expectedAltText, model.AltText);
        Assert.Equal(expectedCaption, model.Caption);
        Assert.Equal(expectedCredit, model.Credit);
        Assert.NotNull(model.Crops);
        Assert.Equal(expectedCrops.Count, model.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], model.Crops[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Image
        {
            AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
            Caption = "",
            Credit = "Golden Gate National Recreation Area Park Archives",
            Crops = ["string"],
            Title = "",
            Url =
                "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Image>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Image
        {
            AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
            Caption = "",
            Credit = "Golden Gate National Recreation Area Park Archives",
            Crops = ["string"],
            Title = "",
            Url =
                "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Image>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedAltText = "Portrait Pauline Cushman Fryer in soldier uniform";
        string expectedCaption = "";
        string expectedCredit = "Golden Gate National Recreation Area Park Archives";
        List<string> expectedCrops = ["string"];
        string expectedTitle = "";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg";

        Assert.Equal(expectedAltText, deserialized.AltText);
        Assert.Equal(expectedCaption, deserialized.Caption);
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.NotNull(deserialized.Crops);
        Assert.Equal(expectedCrops.Count, deserialized.Crops.Count);
        for (int i = 0; i < expectedCrops.Count; i++)
        {
            Assert.Equal(expectedCrops[i], deserialized.Crops[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Image
        {
            AltText = "Portrait Pauline Cushman Fryer in soldier uniform",
            Caption = "",
            Credit = "Golden Gate National Recreation Area Park Archives",
            Crops = ["string"],
            Title = "",
            Url =
                "https://www.nps.gov/common/uploads/people/nri/20200814/people/34BCEDFA-D585-62B8-086046B6CEF7BACC/34BCEDFA-D585-62B8-086046B6CEF7BACC.jpg",
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
        var model = new Image
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

public class QuickFactTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new QuickFact
        {
            ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
            Name = "Significance: ",
            Value = "Civil War Spy",
        };

        string expectedID = "F7A67C96-173F-4675-B374-7E3D3A1818B2";
        string expectedName = "Significance: ";
        string expectedValue = "Civil War Spy";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedValue, model.Value);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new QuickFact
        {
            ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
            Name = "Significance: ",
            Value = "Civil War Spy",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<QuickFact>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new QuickFact
        {
            ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
            Name = "Significance: ",
            Value = "Civil War Spy",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<QuickFact>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "F7A67C96-173F-4675-B374-7E3D3A1818B2";
        string expectedName = "Significance: ";
        string expectedValue = "Civil War Spy";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedValue, deserialized.Value);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new QuickFact
        {
            ID = "F7A67C96-173F-4675-B374-7E3D3A1818B2",
            Name = "Significance: ",
            Value = "Civil War Spy",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new QuickFact { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new QuickFact { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new QuickFact
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Value = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new QuickFact
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
            Value = null,
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
            Designation = "National Recreation Area",
            FullName = "Golden Gate National Recreation Area",
            Name = "Golden Gate",
            ParkCode = "goga",
            States = ["CA"],
            Url = "https://www.nps.gov/goga/index.htm",
        };

        string expectedDesignation = "National Recreation Area";
        string expectedFullName = "Golden Gate National Recreation Area";
        string expectedName = "Golden Gate";
        string expectedParkCode = "goga";
        List<string> expectedStates = ["CA"];
        string expectedUrl = "https://www.nps.gov/goga/index.htm";

        Assert.Equal(expectedDesignation, model.Designation);
        Assert.Equal(expectedFullName, model.FullName);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedParkCode, model.ParkCode);
        Assert.NotNull(model.States);
        Assert.Equal(expectedStates.Count, model.States.Count);
        for (int i = 0; i < expectedStates.Count; i++)
        {
            Assert.Equal(expectedStates[i], model.States[i]);
        }
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Recreation Area",
            FullName = "Golden Gate National Recreation Area",
            Name = "Golden Gate",
            ParkCode = "goga",
            States = ["CA"],
            Url = "https://www.nps.gov/goga/index.htm",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Recreation Area",
            FullName = "Golden Gate National Recreation Area",
            Name = "Golden Gate",
            ParkCode = "goga",
            States = ["CA"],
            Url = "https://www.nps.gov/goga/index.htm",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Recreation Area";
        string expectedFullName = "Golden Gate National Recreation Area";
        string expectedName = "Golden Gate";
        string expectedParkCode = "goga";
        List<string> expectedStates = ["CA"];
        string expectedUrl = "https://www.nps.gov/goga/index.htm";

        Assert.Equal(expectedDesignation, deserialized.Designation);
        Assert.Equal(expectedFullName, deserialized.FullName);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedParkCode, deserialized.ParkCode);
        Assert.NotNull(deserialized.States);
        Assert.Equal(expectedStates.Count, deserialized.States.Count);
        for (int i = 0; i < expectedStates.Count; i++)
        {
            Assert.Equal(expectedStates[i], deserialized.States[i]);
        }
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RelatedPark
        {
            Designation = "National Recreation Area",
            FullName = "Golden Gate National Recreation Area",
            Name = "Golden Gate",
            ParkCode = "goga",
            States = ["CA"],
            Url = "https://www.nps.gov/goga/index.htm",
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
