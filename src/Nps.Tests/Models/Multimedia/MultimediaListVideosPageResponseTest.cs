using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Multimedia;

namespace Nps.Tests.Models.Multimedia;

public class MultimediaListVideosPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListVideosPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            AslVideoUrl =
                                "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4",
                            AudioDescribedBuiltIn = false,
                            Audiodescription = "audiodescription",
                            AudioDescriptionUrl = "audioDescriptionUrl",
                            CallToAction = "",
                            CallToActionUrl = "",
                            CaptionFiles =
                            [
                                new()
                                {
                                    FileType = "text/vtt",
                                    Language = "english",
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
                                },
                            ],
                            Credit = "Thomas M. Strom",
                            Description = "Find out what homesteading means to this cowboy.",
                            DescriptiveTranscript =
                                "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>",
                            DurationMs = 263000,
                            GeometryPoiID = "geometryPoiId",
                            HasOpenCaptions = false,
                            IsBRoll = false,
                            IsVideoOnly = false,
                            Latitude = 25.4829769134522,
                            Longitude = -80.2179336547852,
                            PermalinkUrl =
                                "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Biscayne National Park",
                                    Name = "Biscayne",
                                    ParkCode = "bisc",
                                    States = "NM,TX",
                                    Url = "https://www.nps.gov/bisc/index.htm",
                                },
                            ],
                            SplashImage = new() { Url = "" },
                            Tags =
                            [
                                "Biscayne",
                                "national",
                                "park",
                                "introduction",
                                "underwater",
                                "Shipwreck",
                                "ocean",
                                "miami",
                                "homestead",
                                "south",
                                "Florida",
                                "fl",
                                "FLA",
                                "dive",
                                "history",
                                "podcast",
                                "video",
                                "astrid",
                                "rybeck",
                                "bnp",
                                "bisc",
                            ],
                            Title = "Cowboy Gives Tour of Family Homestead",
                            Transcript =
                                "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.",
                            Versions =
                            [
                                new()
                                {
                                    AspectRatio = 1.778,
                                    FileSizeKB = 10012,
                                    FileType = "video/mp4",
                                    HeightPixels = 360,
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
                                    WidthPixels = 640,
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "9375",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<MultimediaListVideosResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                        AslVideoUrl =
                            "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4",
                        AudioDescribedBuiltIn = false,
                        Audiodescription = "audiodescription",
                        AudioDescriptionUrl = "audioDescriptionUrl",
                        CallToAction = "",
                        CallToActionUrl = "",
                        CaptionFiles =
                        [
                            new()
                            {
                                FileType = "text/vtt",
                                Language = "english",
                                Url =
                                    "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
                            },
                        ],
                        Credit = "Thomas M. Strom",
                        Description = "Find out what homesteading means to this cowboy.",
                        DescriptiveTranscript =
                            "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>",
                        DurationMs = 263000,
                        GeometryPoiID = "geometryPoiId",
                        HasOpenCaptions = false,
                        IsBRoll = false,
                        IsVideoOnly = false,
                        Latitude = 25.4829769134522,
                        Longitude = -80.2179336547852,
                        PermalinkUrl =
                            "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park",
                                FullName = "Biscayne National Park",
                                Name = "Biscayne",
                                ParkCode = "bisc",
                                States = "NM,TX",
                                Url = "https://www.nps.gov/bisc/index.htm",
                            },
                        ],
                        SplashImage = new() { Url = "" },
                        Tags =
                        [
                            "Biscayne",
                            "national",
                            "park",
                            "introduction",
                            "underwater",
                            "Shipwreck",
                            "ocean",
                            "miami",
                            "homestead",
                            "south",
                            "Florida",
                            "fl",
                            "FLA",
                            "dive",
                            "history",
                            "podcast",
                            "video",
                            "astrid",
                            "rybeck",
                            "bnp",
                            "bisc",
                        ],
                        Title = "Cowboy Gives Tour of Family Homestead",
                        Transcript =
                            "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.",
                        Versions =
                        [
                            new()
                            {
                                AspectRatio = 1.778,
                                FileSizeKB = 10012,
                                FileType = "video/mp4",
                                HeightPixels = 360,
                                Url =
                                    "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
                                WidthPixels = 640,
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "9375",
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
        var model = new MultimediaListVideosPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            AslVideoUrl =
                                "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4",
                            AudioDescribedBuiltIn = false,
                            Audiodescription = "audiodescription",
                            AudioDescriptionUrl = "audioDescriptionUrl",
                            CallToAction = "",
                            CallToActionUrl = "",
                            CaptionFiles =
                            [
                                new()
                                {
                                    FileType = "text/vtt",
                                    Language = "english",
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
                                },
                            ],
                            Credit = "Thomas M. Strom",
                            Description = "Find out what homesteading means to this cowboy.",
                            DescriptiveTranscript =
                                "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>",
                            DurationMs = 263000,
                            GeometryPoiID = "geometryPoiId",
                            HasOpenCaptions = false,
                            IsBRoll = false,
                            IsVideoOnly = false,
                            Latitude = 25.4829769134522,
                            Longitude = -80.2179336547852,
                            PermalinkUrl =
                                "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Biscayne National Park",
                                    Name = "Biscayne",
                                    ParkCode = "bisc",
                                    States = "NM,TX",
                                    Url = "https://www.nps.gov/bisc/index.htm",
                                },
                            ],
                            SplashImage = new() { Url = "" },
                            Tags =
                            [
                                "Biscayne",
                                "national",
                                "park",
                                "introduction",
                                "underwater",
                                "Shipwreck",
                                "ocean",
                                "miami",
                                "homestead",
                                "south",
                                "Florida",
                                "fl",
                                "FLA",
                                "dive",
                                "history",
                                "podcast",
                                "video",
                                "astrid",
                                "rybeck",
                                "bnp",
                                "bisc",
                            ],
                            Title = "Cowboy Gives Tour of Family Homestead",
                            Transcript =
                                "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.",
                            Versions =
                            [
                                new()
                                {
                                    AspectRatio = 1.778,
                                    FileSizeKB = 10012,
                                    FileType = "video/mp4",
                                    HeightPixels = 360,
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
                                    WidthPixels = 640,
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "9375",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListVideosPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            AslVideoUrl =
                                "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4",
                            AudioDescribedBuiltIn = false,
                            Audiodescription = "audiodescription",
                            AudioDescriptionUrl = "audioDescriptionUrl",
                            CallToAction = "",
                            CallToActionUrl = "",
                            CaptionFiles =
                            [
                                new()
                                {
                                    FileType = "text/vtt",
                                    Language = "english",
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
                                },
                            ],
                            Credit = "Thomas M. Strom",
                            Description = "Find out what homesteading means to this cowboy.",
                            DescriptiveTranscript =
                                "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>",
                            DurationMs = 263000,
                            GeometryPoiID = "geometryPoiId",
                            HasOpenCaptions = false,
                            IsBRoll = false,
                            IsVideoOnly = false,
                            Latitude = 25.4829769134522,
                            Longitude = -80.2179336547852,
                            PermalinkUrl =
                                "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Biscayne National Park",
                                    Name = "Biscayne",
                                    ParkCode = "bisc",
                                    States = "NM,TX",
                                    Url = "https://www.nps.gov/bisc/index.htm",
                                },
                            ],
                            SplashImage = new() { Url = "" },
                            Tags =
                            [
                                "Biscayne",
                                "national",
                                "park",
                                "introduction",
                                "underwater",
                                "Shipwreck",
                                "ocean",
                                "miami",
                                "homestead",
                                "south",
                                "Florida",
                                "fl",
                                "FLA",
                                "dive",
                                "history",
                                "podcast",
                                "video",
                                "astrid",
                                "rybeck",
                                "bnp",
                                "bisc",
                            ],
                            Title = "Cowboy Gives Tour of Family Homestead",
                            Transcript =
                                "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.",
                            Versions =
                            [
                                new()
                                {
                                    AspectRatio = 1.778,
                                    FileSizeKB = 10012,
                                    FileType = "video/mp4",
                                    HeightPixels = 360,
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
                                    WidthPixels = 640,
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "9375",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosPageResponse>(element);
        Assert.NotNull(deserialized);

        List<MultimediaListVideosResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                        AslVideoUrl =
                            "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4",
                        AudioDescribedBuiltIn = false,
                        Audiodescription = "audiodescription",
                        AudioDescriptionUrl = "audioDescriptionUrl",
                        CallToAction = "",
                        CallToActionUrl = "",
                        CaptionFiles =
                        [
                            new()
                            {
                                FileType = "text/vtt",
                                Language = "english",
                                Url =
                                    "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
                            },
                        ],
                        Credit = "Thomas M. Strom",
                        Description = "Find out what homesteading means to this cowboy.",
                        DescriptiveTranscript =
                            "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>",
                        DurationMs = 263000,
                        GeometryPoiID = "geometryPoiId",
                        HasOpenCaptions = false,
                        IsBRoll = false,
                        IsVideoOnly = false,
                        Latitude = 25.4829769134522,
                        Longitude = -80.2179336547852,
                        PermalinkUrl =
                            "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park",
                                FullName = "Biscayne National Park",
                                Name = "Biscayne",
                                ParkCode = "bisc",
                                States = "NM,TX",
                                Url = "https://www.nps.gov/bisc/index.htm",
                            },
                        ],
                        SplashImage = new() { Url = "" },
                        Tags =
                        [
                            "Biscayne",
                            "national",
                            "park",
                            "introduction",
                            "underwater",
                            "Shipwreck",
                            "ocean",
                            "miami",
                            "homestead",
                            "south",
                            "Florida",
                            "fl",
                            "FLA",
                            "dive",
                            "history",
                            "podcast",
                            "video",
                            "astrid",
                            "rybeck",
                            "bnp",
                            "bisc",
                        ],
                        Title = "Cowboy Gives Tour of Family Homestead",
                        Transcript =
                            "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.",
                        Versions =
                        [
                            new()
                            {
                                AspectRatio = 1.778,
                                FileSizeKB = 10012,
                                FileType = "video/mp4",
                                HeightPixels = 360,
                                Url =
                                    "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
                                WidthPixels = 640,
                            },
                        ],
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "9375",
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
        var model = new MultimediaListVideosPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            AslVideoUrl =
                                "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4",
                            AudioDescribedBuiltIn = false,
                            Audiodescription = "audiodescription",
                            AudioDescriptionUrl = "audioDescriptionUrl",
                            CallToAction = "",
                            CallToActionUrl = "",
                            CaptionFiles =
                            [
                                new()
                                {
                                    FileType = "text/vtt",
                                    Language = "english",
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
                                },
                            ],
                            Credit = "Thomas M. Strom",
                            Description = "Find out what homesteading means to this cowboy.",
                            DescriptiveTranscript =
                                "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>",
                            DurationMs = 263000,
                            GeometryPoiID = "geometryPoiId",
                            HasOpenCaptions = false,
                            IsBRoll = false,
                            IsVideoOnly = false,
                            Latitude = 25.4829769134522,
                            Longitude = -80.2179336547852,
                            PermalinkUrl =
                                "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758",
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Biscayne National Park",
                                    Name = "Biscayne",
                                    ParkCode = "bisc",
                                    States = "NM,TX",
                                    Url = "https://www.nps.gov/bisc/index.htm",
                                },
                            ],
                            SplashImage = new() { Url = "" },
                            Tags =
                            [
                                "Biscayne",
                                "national",
                                "park",
                                "introduction",
                                "underwater",
                                "Shipwreck",
                                "ocean",
                                "miami",
                                "homestead",
                                "south",
                                "Florida",
                                "fl",
                                "FLA",
                                "dive",
                                "history",
                                "podcast",
                                "video",
                                "astrid",
                                "rybeck",
                                "bnp",
                                "bisc",
                            ],
                            Title = "Cowboy Gives Tour of Family Homestead",
                            Transcript =
                                "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.",
                            Versions =
                            [
                                new()
                                {
                                    AspectRatio = 1.778,
                                    FileSizeKB = 10012,
                                    FileType = "video/mp4",
                                    HeightPixels = 360,
                                    Url =
                                        "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
                                    WidthPixels = 640,
                                },
                            ],
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "9375",
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
        var model = new MultimediaListVideosPageResponse { };

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
        var model = new MultimediaListVideosPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListVideosPageResponse
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
        var model = new MultimediaListVideosPageResponse
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
