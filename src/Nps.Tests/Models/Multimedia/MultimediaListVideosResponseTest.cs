using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.Multimedia;

namespace Nps.Tests.Models.Multimedia;

public class MultimediaListVideosResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListVideosResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        List<MultimediaListVideosResponseData> expectedData =
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
        var model = new MultimediaListVideosResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListVideosResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosResponse>(element);
        Assert.NotNull(deserialized);

        List<MultimediaListVideosResponseData> expectedData =
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
        var model = new MultimediaListVideosResponse
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponse { };

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
        var model = new MultimediaListVideosResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponse
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
        var model = new MultimediaListVideosResponse
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

public class MultimediaListVideosResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListVideosResponseData
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
        };

        List<MultimediaListVideosResponseDataData> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "9375";

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
        var model = new MultimediaListVideosResponseData
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosResponseData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListVideosResponseData
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosResponseData>(element);
        Assert.NotNull(deserialized);

        List<MultimediaListVideosResponseDataData> expectedData =
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
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "9375";

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
        var model = new MultimediaListVideosResponseData
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseData { };

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
        var model = new MultimediaListVideosResponseData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseData
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
        var model = new MultimediaListVideosResponseData
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

public class MultimediaListVideosResponseDataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListVideosResponseDataData
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
        };

        string expectedID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758";
        string expectedAslVideoUrl =
            "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4";
        bool expectedAudioDescribedBuiltIn = false;
        string expectedAudiodescription = "audiodescription";
        string expectedAudioDescriptionUrl = "audioDescriptionUrl";
        string expectedCallToAction = "";
        string expectedCallToActionUrl = "";
        List<CaptionFile> expectedCaptionFiles =
        [
            new()
            {
                FileType = "text/vtt",
                Language = "english",
                Url =
                    "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
            },
        ];
        string expectedCredit = "Thomas M. Strom";
        string expectedDescription = "Find out what homesteading means to this cowboy.";
        string expectedDescriptiveTranscript =
            "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>";
        double expectedDurationMs = 263000;
        string expectedGeometryPoiID = "geometryPoiId";
        bool expectedHasOpenCaptions = false;
        bool expectedIsBRoll = false;
        bool expectedIsVideoOnly = false;
        double expectedLatitude = 25.4829769134522;
        double expectedLongitude = -80.2179336547852;
        string expectedPermalinkUrl =
            "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758";
        List<MultimediaListVideosResponseDataDataRelatedPark> expectedRelatedParks =
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
        ];
        MultimediaListVideosResponseDataDataSplashImage expectedSplashImage = new() { Url = "" };
        List<string> expectedTags =
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
        ];
        string expectedTitle = "Cowboy Gives Tour of Family Homestead";
        string expectedTranscript =
            "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.";
        List<Version> expectedVersions =
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
        ];

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAslVideoUrl, model.AslVideoUrl);
        Assert.Equal(expectedAudioDescribedBuiltIn, model.AudioDescribedBuiltIn);
        Assert.Equal(expectedAudiodescription, model.Audiodescription);
        Assert.Equal(expectedAudioDescriptionUrl, model.AudioDescriptionUrl);
        Assert.Equal(expectedCallToAction, model.CallToAction);
        Assert.Equal(expectedCallToActionUrl, model.CallToActionUrl);
        Assert.NotNull(model.CaptionFiles);
        Assert.Equal(expectedCaptionFiles.Count, model.CaptionFiles.Count);
        for (int i = 0; i < expectedCaptionFiles.Count; i++)
        {
            Assert.Equal(expectedCaptionFiles[i], model.CaptionFiles[i]);
        }
        Assert.Equal(expectedCredit, model.Credit);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDescriptiveTranscript, model.DescriptiveTranscript);
        Assert.Equal(expectedDurationMs, model.DurationMs);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.Equal(expectedHasOpenCaptions, model.HasOpenCaptions);
        Assert.Equal(expectedIsBRoll, model.IsBRoll);
        Assert.Equal(expectedIsVideoOnly, model.IsVideoOnly);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedPermalinkUrl, model.PermalinkUrl);
        Assert.NotNull(model.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, model.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], model.RelatedParks[i]);
        }
        Assert.Equal(expectedSplashImage, model.SplashImage);
        Assert.NotNull(model.Tags);
        Assert.Equal(expectedTags.Count, model.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], model.Tags[i]);
        }
        Assert.Equal(expectedTitle, model.Title);
        Assert.Equal(expectedTranscript, model.Transcript);
        Assert.NotNull(model.Versions);
        Assert.Equal(expectedVersions.Count, model.Versions.Count);
        for (int i = 0; i < expectedVersions.Count; i++)
        {
            Assert.Equal(expectedVersions[i], model.Versions[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new MultimediaListVideosResponseDataData
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosResponseDataData>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListVideosResponseDataData
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<MultimediaListVideosResponseDataData>(
            element
        );
        Assert.NotNull(deserialized);

        string expectedID = "CA91ADBF-BCE3-4434-B3D6-7691D7347758";
        string expectedAslVideoUrl =
            "https://www.nps.gov/nps-audiovideo/audiovideo/94c690d6-676c-4c74-8b69-8c488f9240af.mp4";
        bool expectedAudioDescribedBuiltIn = false;
        string expectedAudiodescription = "audiodescription";
        string expectedAudioDescriptionUrl = "audioDescriptionUrl";
        string expectedCallToAction = "";
        string expectedCallToActionUrl = "";
        List<CaptionFile> expectedCaptionFiles =
        [
            new()
            {
                FileType = "text/vtt",
                Language = "english",
                Url =
                    "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
            },
        ];
        string expectedCredit = "Thomas M. Strom";
        string expectedDescription = "Find out what homesteading means to this cowboy.";
        string expectedDescriptiveTranscript =
            "<p>Two video clips showing a prairie dog standing alert above and within its burrow in a windy grassland environment.</p>";
        double expectedDurationMs = 263000;
        string expectedGeometryPoiID = "geometryPoiId";
        bool expectedHasOpenCaptions = false;
        bool expectedIsBRoll = false;
        bool expectedIsVideoOnly = false;
        double expectedLatitude = 25.4829769134522;
        double expectedLongitude = -80.2179336547852;
        string expectedPermalinkUrl =
            "https://www.nps.gov/media/video/view.htm?id=CA91ADBF-BCE3-4434-B3D6-7691D7347758";
        List<MultimediaListVideosResponseDataDataRelatedPark> expectedRelatedParks =
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
        ];
        MultimediaListVideosResponseDataDataSplashImage expectedSplashImage = new() { Url = "" };
        List<string> expectedTags =
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
        ];
        string expectedTitle = "Cowboy Gives Tour of Family Homestead";
        string expectedTranscript =
            "Hi! I'm Park Ranger Astrid Rybeck and together we'll explore the six shipwrecks that make up Biscayne National Park's Maritime Heritage Trail. Each ship tells a different story, and contributes to the maritime history that is unique to Biscayne National Park. Ships of all nationalities and all sizes have navigated these waters. Let's talk about Biscayne's natural features which were so vital in shaping the human history of Biscayne National Park. The park has four different ecosystems that all work together: a mangrove shoreline, the crystal clear waters of Biscayne Bay, the northern portion of the Florida Keys, and the northern portion of the shallow Florida coral reef. It is the beauty and the wealth of these natural features that have drawn people to this area for over 10,000 years. From homesteaders to millionaires, to native people and pirates, these natural features have shaped the stories of the people who have called Biscayne home. The outer waters of the park have long been a 'superhighway' for marine trade and commerce. The northward flowing Gulf Stream has, and continues to, carry goods, ideas, and cultures around the tip of Florida to ports all around the world. While many ships made it safely to their destinations, many others did not. A combination of perfectly occurring natural features in the eastern waters of Biscayne National Park was often fatal for sailing ships. Whether headed north or south, sailing captains had to battle easterly winds, shallow reefs, uncharted waters, and strong currents. The waters of Biscayne National Park now safeguard the ghosts of over 400 years of maritime traffic. Park scientists have identified over fifty shipwrecks in the park. But while the identities of some of these have been uncovered, many still hold secrets. From Spanish galleons to English man of wars, from modern cruisers to unknown remnants of events long since forgotten, Biscayne National Park's Maritime Heritage Trail serves to literally submerge visitors into history. Come see how a 19th-century wooden sailing ship left only ballast stones behind as a clue to its identity. Explore \"Lugano,\" which at one time was the largest ship ever to have wrecked upon the shallow reef patches. Divers can enjoy exploring \"Arratoon Apcar,\" a ship that slammed into the reef only a few hundred yards away from horrified men building a lighthouse to warn vessels away from that very spot. Snorkelers will marvel at the ruins of \"Mandalay,\" the most recent wreck on the Trail. The wreck of \"Erl King\" represents a major transition from ships powered by sail to ships powered by steam. History will open up with the remains of \"Alicia,\" one of the last big ships to be salvaged by traditional 'Keys Wreckers',. Each of the shipwrecks on the trail tells a unique story. Most of them lie in about 20 feet of water giving experienced divers and first time snorkelers the opportunity to view these magnificent pieces of history while ensuring that the ship's remains will be around for many years of exploration and enjoyment. Each site has permanent mooring balls installed, so private boaters can discover the wrecks without having to worry about dropping an anchor onto the wrecks or the fragile ecosystems that surround them. You can help protect the stories and the futures of all of these ships by remembering that these six sites, like all of the archeological sites in Biscayne National Park, are part of our shared heritage. Leave the sites as you find them. Please take only pictures and leave only bubbles. Dive into history and discover the stories behind the shipwrecks of Biscayne's Maritime Heritage Trail.";
        List<Version> expectedVersions =
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
        ];

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAslVideoUrl, deserialized.AslVideoUrl);
        Assert.Equal(expectedAudioDescribedBuiltIn, deserialized.AudioDescribedBuiltIn);
        Assert.Equal(expectedAudiodescription, deserialized.Audiodescription);
        Assert.Equal(expectedAudioDescriptionUrl, deserialized.AudioDescriptionUrl);
        Assert.Equal(expectedCallToAction, deserialized.CallToAction);
        Assert.Equal(expectedCallToActionUrl, deserialized.CallToActionUrl);
        Assert.NotNull(deserialized.CaptionFiles);
        Assert.Equal(expectedCaptionFiles.Count, deserialized.CaptionFiles.Count);
        for (int i = 0; i < expectedCaptionFiles.Count; i++)
        {
            Assert.Equal(expectedCaptionFiles[i], deserialized.CaptionFiles[i]);
        }
        Assert.Equal(expectedCredit, deserialized.Credit);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDescriptiveTranscript, deserialized.DescriptiveTranscript);
        Assert.Equal(expectedDurationMs, deserialized.DurationMs);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.Equal(expectedHasOpenCaptions, deserialized.HasOpenCaptions);
        Assert.Equal(expectedIsBRoll, deserialized.IsBRoll);
        Assert.Equal(expectedIsVideoOnly, deserialized.IsVideoOnly);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedPermalinkUrl, deserialized.PermalinkUrl);
        Assert.NotNull(deserialized.RelatedParks);
        Assert.Equal(expectedRelatedParks.Count, deserialized.RelatedParks.Count);
        for (int i = 0; i < expectedRelatedParks.Count; i++)
        {
            Assert.Equal(expectedRelatedParks[i], deserialized.RelatedParks[i]);
        }
        Assert.Equal(expectedSplashImage, deserialized.SplashImage);
        Assert.NotNull(deserialized.Tags);
        Assert.Equal(expectedTags.Count, deserialized.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], deserialized.Tags[i]);
        }
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.Equal(expectedTranscript, deserialized.Transcript);
        Assert.NotNull(deserialized.Versions);
        Assert.Equal(expectedVersions.Count, deserialized.Versions.Count);
        for (int i = 0; i < expectedVersions.Count; i++)
        {
            Assert.Equal(expectedVersions[i], deserialized.Versions[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new MultimediaListVideosResponseDataData
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseDataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AslVideoUrl);
        Assert.False(model.RawData.ContainsKey("aslVideoUrl"));
        Assert.Null(model.AudioDescribedBuiltIn);
        Assert.False(model.RawData.ContainsKey("audioDescribedBuiltIn"));
        Assert.Null(model.Audiodescription);
        Assert.False(model.RawData.ContainsKey("audiodescription"));
        Assert.Null(model.AudioDescriptionUrl);
        Assert.False(model.RawData.ContainsKey("audioDescriptionUrl"));
        Assert.Null(model.CallToAction);
        Assert.False(model.RawData.ContainsKey("callToAction"));
        Assert.Null(model.CallToActionUrl);
        Assert.False(model.RawData.ContainsKey("callToActionURL"));
        Assert.Null(model.CaptionFiles);
        Assert.False(model.RawData.ContainsKey("captionFiles"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DescriptiveTranscript);
        Assert.False(model.RawData.ContainsKey("descriptiveTranscript"));
        Assert.Null(model.DurationMs);
        Assert.False(model.RawData.ContainsKey("durationMs"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.HasOpenCaptions);
        Assert.False(model.RawData.ContainsKey("hasOpenCaptions"));
        Assert.Null(model.IsBRoll);
        Assert.False(model.RawData.ContainsKey("isBRoll"));
        Assert.Null(model.IsVideoOnly);
        Assert.False(model.RawData.ContainsKey("isVideoOnly"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.PermalinkUrl);
        Assert.False(model.RawData.ContainsKey("permalinkUrl"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.SplashImage);
        Assert.False(model.RawData.ContainsKey("splashImage"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Transcript);
        Assert.False(model.RawData.ContainsKey("transcript"));
        Assert.Null(model.Versions);
        Assert.False(model.RawData.ContainsKey("versions"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new MultimediaListVideosResponseDataData { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseDataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            AslVideoUrl = null,
            AudioDescribedBuiltIn = null,
            Audiodescription = null,
            AudioDescriptionUrl = null,
            CallToAction = null,
            CallToActionUrl = null,
            CaptionFiles = null,
            Credit = null,
            Description = null,
            DescriptiveTranscript = null,
            DurationMs = null,
            GeometryPoiID = null,
            HasOpenCaptions = null,
            IsBRoll = null,
            IsVideoOnly = null,
            Latitude = null,
            Longitude = null,
            PermalinkUrl = null,
            RelatedParks = null,
            SplashImage = null,
            Tags = null,
            Title = null,
            Transcript = null,
            Versions = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AslVideoUrl);
        Assert.False(model.RawData.ContainsKey("aslVideoUrl"));
        Assert.Null(model.AudioDescribedBuiltIn);
        Assert.False(model.RawData.ContainsKey("audioDescribedBuiltIn"));
        Assert.Null(model.Audiodescription);
        Assert.False(model.RawData.ContainsKey("audiodescription"));
        Assert.Null(model.AudioDescriptionUrl);
        Assert.False(model.RawData.ContainsKey("audioDescriptionUrl"));
        Assert.Null(model.CallToAction);
        Assert.False(model.RawData.ContainsKey("callToAction"));
        Assert.Null(model.CallToActionUrl);
        Assert.False(model.RawData.ContainsKey("callToActionURL"));
        Assert.Null(model.CaptionFiles);
        Assert.False(model.RawData.ContainsKey("captionFiles"));
        Assert.Null(model.Credit);
        Assert.False(model.RawData.ContainsKey("credit"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.DescriptiveTranscript);
        Assert.False(model.RawData.ContainsKey("descriptiveTranscript"));
        Assert.Null(model.DurationMs);
        Assert.False(model.RawData.ContainsKey("durationMs"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.HasOpenCaptions);
        Assert.False(model.RawData.ContainsKey("hasOpenCaptions"));
        Assert.Null(model.IsBRoll);
        Assert.False(model.RawData.ContainsKey("isBRoll"));
        Assert.Null(model.IsVideoOnly);
        Assert.False(model.RawData.ContainsKey("isVideoOnly"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.PermalinkUrl);
        Assert.False(model.RawData.ContainsKey("permalinkUrl"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.SplashImage);
        Assert.False(model.RawData.ContainsKey("splashImage"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Transcript);
        Assert.False(model.RawData.ContainsKey("transcript"));
        Assert.Null(model.Versions);
        Assert.False(model.RawData.ContainsKey("versions"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new MultimediaListVideosResponseDataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            AslVideoUrl = null,
            AudioDescribedBuiltIn = null,
            Audiodescription = null,
            AudioDescriptionUrl = null,
            CallToAction = null,
            CallToActionUrl = null,
            CaptionFiles = null,
            Credit = null,
            Description = null,
            DescriptiveTranscript = null,
            DurationMs = null,
            GeometryPoiID = null,
            HasOpenCaptions = null,
            IsBRoll = null,
            IsVideoOnly = null,
            Latitude = null,
            Longitude = null,
            PermalinkUrl = null,
            RelatedParks = null,
            SplashImage = null,
            Tags = null,
            Title = null,
            Transcript = null,
            Versions = null,
        };

        model.Validate();
    }
}

public class CaptionFileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CaptionFile
        {
            FileType = "text/vtt",
            Language = "english",
            Url =
                "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
        };

        string expectedFileType = "text/vtt";
        string expectedLanguage = "english";
        string expectedUrl =
            "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt";

        Assert.Equal(expectedFileType, model.FileType);
        Assert.Equal(expectedLanguage, model.Language);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CaptionFile
        {
            FileType = "text/vtt",
            Language = "english",
            Url =
                "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CaptionFile>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CaptionFile
        {
            FileType = "text/vtt",
            Language = "english",
            Url =
                "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CaptionFile>(element);
        Assert.NotNull(deserialized);

        string expectedFileType = "text/vtt";
        string expectedLanguage = "english";
        string expectedUrl =
            "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt";

        Assert.Equal(expectedFileType, deserialized.FileType);
        Assert.Equal(expectedLanguage, deserialized.Language);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CaptionFile
        {
            FileType = "text/vtt",
            Language = "english",
            Url =
                "https://www.nps.gov/nps-audiovideo/closed-caption/5E069AB9-EE15-33B2-27A194C84A61BCBE.vtt",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CaptionFile { };

        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.Language);
        Assert.False(model.RawData.ContainsKey("language"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CaptionFile { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CaptionFile
        {
            // Null should be interpreted as omitted for these properties
            FileType = null,
            Language = null,
            Url = null,
        };

        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.Language);
        Assert.False(model.RawData.ContainsKey("language"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CaptionFile
        {
            // Null should be interpreted as omitted for these properties
            FileType = null,
            Language = null,
            Url = null,
        };

        model.Validate();
    }
}

public class MultimediaListVideosResponseDataDataRelatedParkTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListVideosResponseDataDataRelatedPark
        {
            Designation = "National Park",
            FullName = "Biscayne National Park",
            Name = "Biscayne",
            ParkCode = "bisc",
            States = "NM,TX",
            Url = "https://www.nps.gov/bisc/index.htm",
        };

        string expectedDesignation = "National Park";
        string expectedFullName = "Biscayne National Park";
        string expectedName = "Biscayne";
        string expectedParkCode = "bisc";
        string expectedStates = "NM,TX";
        string expectedUrl = "https://www.nps.gov/bisc/index.htm";

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
        var model = new MultimediaListVideosResponseDataDataRelatedPark
        {
            Designation = "National Park",
            FullName = "Biscayne National Park",
            Name = "Biscayne",
            ParkCode = "bisc",
            States = "NM,TX",
            Url = "https://www.nps.gov/bisc/index.htm",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<MultimediaListVideosResponseDataDataRelatedPark>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListVideosResponseDataDataRelatedPark
        {
            Designation = "National Park",
            FullName = "Biscayne National Park",
            Name = "Biscayne",
            ParkCode = "bisc",
            States = "NM,TX",
            Url = "https://www.nps.gov/bisc/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<MultimediaListVideosResponseDataDataRelatedPark>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park";
        string expectedFullName = "Biscayne National Park";
        string expectedName = "Biscayne";
        string expectedParkCode = "bisc";
        string expectedStates = "NM,TX";
        string expectedUrl = "https://www.nps.gov/bisc/index.htm";

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
        var model = new MultimediaListVideosResponseDataDataRelatedPark
        {
            Designation = "National Park",
            FullName = "Biscayne National Park",
            Name = "Biscayne",
            ParkCode = "bisc",
            States = "NM,TX",
            Url = "https://www.nps.gov/bisc/index.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseDataDataRelatedPark { };

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
        var model = new MultimediaListVideosResponseDataDataRelatedPark { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseDataDataRelatedPark
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
        var model = new MultimediaListVideosResponseDataDataRelatedPark
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

public class MultimediaListVideosResponseDataDataSplashImageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage { Url = "" };

        string expectedUrl = "";

        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage { Url = "" };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<MultimediaListVideosResponseDataDataSplashImage>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage { Url = "" };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<MultimediaListVideosResponseDataDataSplashImage>(element);
        Assert.NotNull(deserialized);

        string expectedUrl = "";

        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage { Url = "" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage { };

        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage
        {
            // Null should be interpreted as omitted for these properties
            Url = null,
        };

        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new MultimediaListVideosResponseDataDataSplashImage
        {
            // Null should be interpreted as omitted for these properties
            Url = null,
        };

        model.Validate();
    }
}

public class VersionTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Version
        {
            AspectRatio = 1.778,
            FileSizeKB = 10012,
            FileType = "video/mp4",
            HeightPixels = 360,
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
            WidthPixels = 640,
        };

        double expectedAspectRatio = 1.778;
        double expectedFileSizeKB = 10012;
        string expectedFileType = "video/mp4";
        double expectedHeightPixels = 360;
        string expectedUrl =
            "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4";
        double expectedWidthPixels = 640;

        Assert.Equal(expectedAspectRatio, model.AspectRatio);
        Assert.Equal(expectedFileSizeKB, model.FileSizeKB);
        Assert.Equal(expectedFileType, model.FileType);
        Assert.Equal(expectedHeightPixels, model.HeightPixels);
        Assert.Equal(expectedUrl, model.Url);
        Assert.Equal(expectedWidthPixels, model.WidthPixels);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Version
        {
            AspectRatio = 1.778,
            FileSizeKB = 10012,
            FileType = "video/mp4",
            HeightPixels = 360,
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
            WidthPixels = 640,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Version>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Version
        {
            AspectRatio = 1.778,
            FileSizeKB = 10012,
            FileType = "video/mp4",
            HeightPixels = 360,
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
            WidthPixels = 640,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Version>(element);
        Assert.NotNull(deserialized);

        double expectedAspectRatio = 1.778;
        double expectedFileSizeKB = 10012;
        string expectedFileType = "video/mp4";
        double expectedHeightPixels = 360;
        string expectedUrl =
            "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4";
        double expectedWidthPixels = 640;

        Assert.Equal(expectedAspectRatio, deserialized.AspectRatio);
        Assert.Equal(expectedFileSizeKB, deserialized.FileSizeKB);
        Assert.Equal(expectedFileType, deserialized.FileType);
        Assert.Equal(expectedHeightPixels, deserialized.HeightPixels);
        Assert.Equal(expectedUrl, deserialized.Url);
        Assert.Equal(expectedWidthPixels, deserialized.WidthPixels);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Version
        {
            AspectRatio = 1.778,
            FileSizeKB = 10012,
            FileType = "video/mp4",
            HeightPixels = 360,
            Url =
                "https://www.nps.gov/nps-audiovideo/audiovideo/f0f43726-f2b5-4492-b11c-9e89a13527d9360p.mp4",
            WidthPixels = 640,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Version { };

        Assert.Null(model.AspectRatio);
        Assert.False(model.RawData.ContainsKey("aspectRatio"));
        Assert.Null(model.FileSizeKB);
        Assert.False(model.RawData.ContainsKey("fileSizeKb"));
        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.HeightPixels);
        Assert.False(model.RawData.ContainsKey("heightPixels"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.WidthPixels);
        Assert.False(model.RawData.ContainsKey("widthPixels"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Version { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Version
        {
            // Null should be interpreted as omitted for these properties
            AspectRatio = null,
            FileSizeKB = null,
            FileType = null,
            HeightPixels = null,
            Url = null,
            WidthPixels = null,
        };

        Assert.Null(model.AspectRatio);
        Assert.False(model.RawData.ContainsKey("aspectRatio"));
        Assert.Null(model.FileSizeKB);
        Assert.False(model.RawData.ContainsKey("fileSizeKb"));
        Assert.Null(model.FileType);
        Assert.False(model.RawData.ContainsKey("fileType"));
        Assert.Null(model.HeightPixels);
        Assert.False(model.RawData.ContainsKey("heightPixels"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.WidthPixels);
        Assert.False(model.RawData.ContainsKey("widthPixels"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Version
        {
            // Null should be interpreted as omitted for these properties
            AspectRatio = null,
            FileSizeKB = null,
            FileType = null,
            HeightPixels = null,
            Url = null,
            WidthPixels = null,
        };

        model.Validate();
    }
}
