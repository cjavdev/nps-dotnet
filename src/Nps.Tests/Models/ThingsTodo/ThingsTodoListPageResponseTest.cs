using System.Collections.Generic;
using System.Text.Json;
using Nps.Core;
using Nps.Models.ThingsTodo;

namespace Nps.Tests.Models.ThingsTodo;

public class ThingsTodoListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ThingsTodoListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
                            AccessibilityInformation = "accessibilityInformation",
                            Activities =
                            [
                                new()
                                {
                                    ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C",
                                    Name = "Skiing",
                                },
                            ],
                            ActivityDescription = "Easiest",
                            Age = "age",
                            AgeDescription = "ageDescription",
                            ArePetsPermitted = "arePetsPermitted",
                            ArePetsPermittedwithRestrictions = "false",
                            DoFeesApply = "false",
                            Duration = "1-2 hours",
                            DurationDescription =
                                "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.",
                            FeeDescription = "feeDescription",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "The Bannock Trail is a mostly flat through mature forest.",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = 3,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                        },
                                    ],
                                    Title = "title",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                },
                            ],
                            IsReservationRequired = "false",
                            Latitude = "latitude",
                            Location = "location",
                            LocationDescription =
                                "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.",
                            LongDescription =
                                "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>",
                            Longitude = "longitude",
                            PetsDescription =
                                "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n",
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Yellowstone National Park",
                                    Name = "Yellowstone",
                                    ParkCode = "yell",
                                    States = "ID,MT,WY",
                                    Url = "https://www.nps.gov/yell/index.htm",
                                },
                            ],
                            RelevanceScore = 0,
                            ReservationDescription = "reservationDescription",
                            Season = ["winter"],
                            SeasonDescription = "seasonDescription",
                            ShortDescription =
                                "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.",
                            Tags = ["cross country skiing"],
                            TimeOfDay = ["Day"],
                            TimeOfDayDescription = "timeOfDayDescription",
                            Title = "Bannock Ski Trail",
                            Topics =
                            [
                                new()
                                {
                                    ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417",
                                    Name = "Trails",
                                },
                            ],
                            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "638",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        List<ThingsTodoListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
                        AccessibilityInformation = "accessibilityInformation",
                        Activities =
                        [
                            new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" },
                        ],
                        ActivityDescription = "Easiest",
                        Age = "age",
                        AgeDescription = "ageDescription",
                        ArePetsPermitted = "arePetsPermitted",
                        ArePetsPermittedwithRestrictions = "false",
                        DoFeesApply = "false",
                        Duration = "1-2 hours",
                        DurationDescription =
                            "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.",
                        FeeDescription = "feeDescription",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images =
                        [
                            new()
                            {
                                AltText =
                                    "The Bannock Trail is a mostly flat through mature forest.",
                                Caption = "caption",
                                Credit = "credit",
                                Crops =
                                [
                                    new()
                                    {
                                        Aspectratio = 3,
                                        Url =
                                            "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                    },
                                ],
                                Title = "title",
                                Url =
                                    "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                            },
                        ],
                        IsReservationRequired = "false",
                        Latitude = "latitude",
                        Location = "location",
                        LocationDescription =
                            "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.",
                        LongDescription =
                            "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>",
                        Longitude = "longitude",
                        PetsDescription =
                            "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n",
                        RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park",
                                FullName = "Yellowstone National Park",
                                Name = "Yellowstone",
                                ParkCode = "yell",
                                States = "ID,MT,WY",
                                Url = "https://www.nps.gov/yell/index.htm",
                            },
                        ],
                        RelevanceScore = 0,
                        ReservationDescription = "reservationDescription",
                        Season = ["winter"],
                        SeasonDescription = "seasonDescription",
                        ShortDescription =
                            "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.",
                        Tags = ["cross country skiing"],
                        TimeOfDay = ["Day"],
                        TimeOfDayDescription = "timeOfDayDescription",
                        Title = "Bannock Ski Trail",
                        Topics =
                        [
                            new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" },
                        ],
                        Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "638",
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
        var model = new ThingsTodoListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
                            AccessibilityInformation = "accessibilityInformation",
                            Activities =
                            [
                                new()
                                {
                                    ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C",
                                    Name = "Skiing",
                                },
                            ],
                            ActivityDescription = "Easiest",
                            Age = "age",
                            AgeDescription = "ageDescription",
                            ArePetsPermitted = "arePetsPermitted",
                            ArePetsPermittedwithRestrictions = "false",
                            DoFeesApply = "false",
                            Duration = "1-2 hours",
                            DurationDescription =
                                "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.",
                            FeeDescription = "feeDescription",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "The Bannock Trail is a mostly flat through mature forest.",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = 3,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                        },
                                    ],
                                    Title = "title",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                },
                            ],
                            IsReservationRequired = "false",
                            Latitude = "latitude",
                            Location = "location",
                            LocationDescription =
                                "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.",
                            LongDescription =
                                "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>",
                            Longitude = "longitude",
                            PetsDescription =
                                "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n",
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Yellowstone National Park",
                                    Name = "Yellowstone",
                                    ParkCode = "yell",
                                    States = "ID,MT,WY",
                                    Url = "https://www.nps.gov/yell/index.htm",
                                },
                            ],
                            RelevanceScore = 0,
                            ReservationDescription = "reservationDescription",
                            Season = ["winter"],
                            SeasonDescription = "seasonDescription",
                            ShortDescription =
                                "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.",
                            Tags = ["cross country skiing"],
                            TimeOfDay = ["Day"],
                            TimeOfDayDescription = "timeOfDayDescription",
                            Title = "Bannock Ski Trail",
                            Topics =
                            [
                                new()
                                {
                                    ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417",
                                    Name = "Trails",
                                },
                            ],
                            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "638",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ThingsTodoListPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ThingsTodoListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
                            AccessibilityInformation = "accessibilityInformation",
                            Activities =
                            [
                                new()
                                {
                                    ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C",
                                    Name = "Skiing",
                                },
                            ],
                            ActivityDescription = "Easiest",
                            Age = "age",
                            AgeDescription = "ageDescription",
                            ArePetsPermitted = "arePetsPermitted",
                            ArePetsPermittedwithRestrictions = "false",
                            DoFeesApply = "false",
                            Duration = "1-2 hours",
                            DurationDescription =
                                "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.",
                            FeeDescription = "feeDescription",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "The Bannock Trail is a mostly flat through mature forest.",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = 3,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                        },
                                    ],
                                    Title = "title",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                },
                            ],
                            IsReservationRequired = "false",
                            Latitude = "latitude",
                            Location = "location",
                            LocationDescription =
                                "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.",
                            LongDescription =
                                "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>",
                            Longitude = "longitude",
                            PetsDescription =
                                "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n",
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Yellowstone National Park",
                                    Name = "Yellowstone",
                                    ParkCode = "yell",
                                    States = "ID,MT,WY",
                                    Url = "https://www.nps.gov/yell/index.htm",
                                },
                            ],
                            RelevanceScore = 0,
                            ReservationDescription = "reservationDescription",
                            Season = ["winter"],
                            SeasonDescription = "seasonDescription",
                            ShortDescription =
                                "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.",
                            Tags = ["cross country skiing"],
                            TimeOfDay = ["Day"],
                            TimeOfDayDescription = "timeOfDayDescription",
                            Title = "Bannock Ski Trail",
                            Topics =
                            [
                                new()
                                {
                                    ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417",
                                    Name = "Trails",
                                },
                            ],
                            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "638",
                },
            ],
            Limit = 0,
            Start = 0,
            Total = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ThingsTodoListPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<ThingsTodoListResponse> expectedData =
        [
            new()
            {
                Data =
                [
                    new()
                    {
                        ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
                        AccessibilityInformation = "accessibilityInformation",
                        Activities =
                        [
                            new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" },
                        ],
                        ActivityDescription = "Easiest",
                        Age = "age",
                        AgeDescription = "ageDescription",
                        ArePetsPermitted = "arePetsPermitted",
                        ArePetsPermittedwithRestrictions = "false",
                        DoFeesApply = "false",
                        Duration = "1-2 hours",
                        DurationDescription =
                            "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.",
                        FeeDescription = "feeDescription",
                        GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                        Images =
                        [
                            new()
                            {
                                AltText =
                                    "The Bannock Trail is a mostly flat through mature forest.",
                                Caption = "caption",
                                Credit = "credit",
                                Crops =
                                [
                                    new()
                                    {
                                        Aspectratio = 3,
                                        Url =
                                            "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                    },
                                ],
                                Title = "title",
                                Url =
                                    "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                            },
                        ],
                        IsReservationRequired = "false",
                        Latitude = "latitude",
                        Location = "location",
                        LocationDescription =
                            "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.",
                        LongDescription =
                            "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>",
                        Longitude = "longitude",
                        PetsDescription =
                            "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n",
                        RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                        RelatedParks =
                        [
                            new()
                            {
                                Designation = "National Park",
                                FullName = "Yellowstone National Park",
                                Name = "Yellowstone",
                                ParkCode = "yell",
                                States = "ID,MT,WY",
                                Url = "https://www.nps.gov/yell/index.htm",
                            },
                        ],
                        RelevanceScore = 0,
                        ReservationDescription = "reservationDescription",
                        Season = ["winter"],
                        SeasonDescription = "seasonDescription",
                        ShortDescription =
                            "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.",
                        Tags = ["cross country skiing"],
                        TimeOfDay = ["Day"],
                        TimeOfDayDescription = "timeOfDayDescription",
                        Title = "Bannock Ski Trail",
                        Topics =
                        [
                            new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" },
                        ],
                        Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
                    },
                ],
                Limit = "50",
                Start = "0",
                Total = "638",
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
        var model = new ThingsTodoListPageResponse
        {
            Data =
            [
                new()
                {
                    Data =
                    [
                        new()
                        {
                            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
                            AccessibilityInformation = "accessibilityInformation",
                            Activities =
                            [
                                new()
                                {
                                    ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C",
                                    Name = "Skiing",
                                },
                            ],
                            ActivityDescription = "Easiest",
                            Age = "age",
                            AgeDescription = "ageDescription",
                            ArePetsPermitted = "arePetsPermitted",
                            ArePetsPermittedwithRestrictions = "false",
                            DoFeesApply = "false",
                            Duration = "1-2 hours",
                            DurationDescription =
                                "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.",
                            FeeDescription = "feeDescription",
                            GeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937",
                            Images =
                            [
                                new()
                                {
                                    AltText =
                                        "The Bannock Trail is a mostly flat through mature forest.",
                                    Caption = "caption",
                                    Credit = "credit",
                                    Crops =
                                    [
                                        new()
                                        {
                                            Aspectratio = 3,
                                            Url =
                                                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                        },
                                    ],
                                    Title = "title",
                                    Url =
                                        "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
                                },
                            ],
                            IsReservationRequired = "false",
                            Latitude = "latitude",
                            Location = "location",
                            LocationDescription =
                                "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.",
                            LongDescription =
                                "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>",
                            Longitude = "longitude",
                            PetsDescription =
                                "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n",
                            RelatedOrganizations = [JsonSerializer.Deserialize<JsonElement>("{}")],
                            RelatedParks =
                            [
                                new()
                                {
                                    Designation = "National Park",
                                    FullName = "Yellowstone National Park",
                                    Name = "Yellowstone",
                                    ParkCode = "yell",
                                    States = "ID,MT,WY",
                                    Url = "https://www.nps.gov/yell/index.htm",
                                },
                            ],
                            RelevanceScore = 0,
                            ReservationDescription = "reservationDescription",
                            Season = ["winter"],
                            SeasonDescription = "seasonDescription",
                            ShortDescription =
                                "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.",
                            Tags = ["cross country skiing"],
                            TimeOfDay = ["Day"],
                            TimeOfDayDescription = "timeOfDayDescription",
                            Title = "Bannock Ski Trail",
                            Topics =
                            [
                                new()
                                {
                                    ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417",
                                    Name = "Trails",
                                },
                            ],
                            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
                        },
                    ],
                    Limit = "50",
                    Start = "0",
                    Total = "638",
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
        var model = new ThingsTodoListPageResponse { };

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
        var model = new ThingsTodoListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ThingsTodoListPageResponse
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
        var model = new ThingsTodoListPageResponse
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
