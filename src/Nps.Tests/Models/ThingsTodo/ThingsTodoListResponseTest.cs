using System.Collections.Generic;
using System.Text.Json;
using Nps.Models.ThingsTodo;

namespace Nps.Tests.Models.ThingsTodo;

public class ThingsTodoListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ThingsTodoListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
        var model = new ThingsTodoListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ThingsTodoListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ThingsTodoListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ThingsTodoListResponse>(element);
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                DataValue =
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
        var model = new ThingsTodoListResponse
        {
            Data =
            [
                new()
                {
                    DataValue =
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
            Limit = "limit",
            Start = "start",
            Total = "total",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ThingsTodoListResponse { };

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
        var model = new ThingsTodoListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ThingsTodoListResponse
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
        var model = new ThingsTodoListResponse
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
                            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
        };

        List<DataData> expectedDataValue =
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
                        AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
                Topics = [new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" }],
                Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "638";

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
                            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
                            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Data>(element);
        Assert.NotNull(deserialized);

        List<DataData> expectedDataValue =
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
                        AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
                Topics = [new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" }],
                Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
            },
        ];
        string expectedLimit = "50";
        string expectedStart = "0";
        string expectedTotal = "638";

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
                            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
            AccessibilityInformation = "accessibilityInformation",
            Activities = [new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" }],
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
                    AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
            Topics = [new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" }],
            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
        };

        string expectedID = "8B175753-D37B-4DD5-BF96-00383F7BB46C";
        string expectedAccessibilityInformation = "accessibilityInformation";
        List<Activity> expectedActivities =
        [
            new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" },
        ];
        string expectedActivityDescription = "Easiest";
        string expectedAge = "age";
        string expectedAgeDescription = "ageDescription";
        string expectedArePetsPermitted = "arePetsPermitted";
        string expectedArePetsPermittedwithRestrictions = "false";
        string expectedDoFeesApply = "false";
        string expectedDuration = "1-2 hours";
        string expectedDurationDescription =
            "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.";
        string expectedFeeDescription = "feeDescription";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
        ];
        string expectedIsReservationRequired = "false";
        string expectedLatitude = "latitude";
        string expectedLocation = "location";
        string expectedLocationDescription =
            "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.";
        string expectedLongDescription =
            "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>";
        string expectedLongitude = "longitude";
        string expectedPetsDescription =
            "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n";
        List<JsonElement> expectedRelatedOrganizations =
        [
            JsonSerializer.Deserialize<JsonElement>("{}"),
        ];
        List<RelatedPark> expectedRelatedParks =
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
        ];
        double expectedRelevanceScore = 0;
        string expectedReservationDescription = "reservationDescription";
        List<string> expectedSeason = ["winter"];
        string expectedSeasonDescription = "seasonDescription";
        string expectedShortDescription =
            "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.";
        List<string> expectedTags = ["cross country skiing"];
        List<string> expectedTimeOfDay = ["Day"];
        string expectedTimeOfDayDescription = "timeOfDayDescription";
        string expectedTitle = "Bannock Ski Trail";
        List<Topic> expectedTopics =
        [
            new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" },
        ];
        string expectedUrl = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccessibilityInformation, model.AccessibilityInformation);
        Assert.NotNull(model.Activities);
        Assert.Equal(expectedActivities.Count, model.Activities.Count);
        for (int i = 0; i < expectedActivities.Count; i++)
        {
            Assert.Equal(expectedActivities[i], model.Activities[i]);
        }
        Assert.Equal(expectedActivityDescription, model.ActivityDescription);
        Assert.Equal(expectedAge, model.Age);
        Assert.Equal(expectedAgeDescription, model.AgeDescription);
        Assert.Equal(expectedArePetsPermitted, model.ArePetsPermitted);
        Assert.Equal(
            expectedArePetsPermittedwithRestrictions,
            model.ArePetsPermittedwithRestrictions
        );
        Assert.Equal(expectedDoFeesApply, model.DoFeesApply);
        Assert.Equal(expectedDuration, model.Duration);
        Assert.Equal(expectedDurationDescription, model.DurationDescription);
        Assert.Equal(expectedFeeDescription, model.FeeDescription);
        Assert.Equal(expectedGeometryPoiID, model.GeometryPoiID);
        Assert.NotNull(model.Images);
        Assert.Equal(expectedImages.Count, model.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], model.Images[i]);
        }
        Assert.Equal(expectedIsReservationRequired, model.IsReservationRequired);
        Assert.Equal(expectedLatitude, model.Latitude);
        Assert.Equal(expectedLocation, model.Location);
        Assert.Equal(expectedLocationDescription, model.LocationDescription);
        Assert.Equal(expectedLongDescription, model.LongDescription);
        Assert.Equal(expectedLongitude, model.Longitude);
        Assert.Equal(expectedPetsDescription, model.PetsDescription);
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
        Assert.Equal(expectedRelevanceScore, model.RelevanceScore);
        Assert.Equal(expectedReservationDescription, model.ReservationDescription);
        Assert.NotNull(model.Season);
        Assert.Equal(expectedSeason.Count, model.Season.Count);
        for (int i = 0; i < expectedSeason.Count; i++)
        {
            Assert.Equal(expectedSeason[i], model.Season[i]);
        }
        Assert.Equal(expectedSeasonDescription, model.SeasonDescription);
        Assert.Equal(expectedShortDescription, model.ShortDescription);
        Assert.NotNull(model.Tags);
        Assert.Equal(expectedTags.Count, model.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], model.Tags[i]);
        }
        Assert.NotNull(model.TimeOfDay);
        Assert.Equal(expectedTimeOfDay.Count, model.TimeOfDay.Count);
        for (int i = 0; i < expectedTimeOfDay.Count; i++)
        {
            Assert.Equal(expectedTimeOfDay[i], model.TimeOfDay[i]);
        }
        Assert.Equal(expectedTimeOfDayDescription, model.TimeOfDayDescription);
        Assert.Equal(expectedTitle, model.Title);
        Assert.NotNull(model.Topics);
        Assert.Equal(expectedTopics.Count, model.Topics.Count);
        for (int i = 0; i < expectedTopics.Count; i++)
        {
            Assert.Equal(expectedTopics[i], model.Topics[i]);
        }
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataData
        {
            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
            AccessibilityInformation = "accessibilityInformation",
            Activities = [new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" }],
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
                    AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
            Topics = [new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" }],
            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
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
            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
            AccessibilityInformation = "accessibilityInformation",
            Activities = [new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" }],
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
                    AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
            Topics = [new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" }],
            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<DataData>(element);
        Assert.NotNull(deserialized);

        string expectedID = "8B175753-D37B-4DD5-BF96-00383F7BB46C";
        string expectedAccessibilityInformation = "accessibilityInformation";
        List<Activity> expectedActivities =
        [
            new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" },
        ];
        string expectedActivityDescription = "Easiest";
        string expectedAge = "age";
        string expectedAgeDescription = "ageDescription";
        string expectedArePetsPermitted = "arePetsPermitted";
        string expectedArePetsPermittedwithRestrictions = "false";
        string expectedDoFeesApply = "false";
        string expectedDuration = "1-2 hours";
        string expectedDurationDescription =
            "The duration will vary depending on fitness level, snow conditions, and length of time spent along the trail.";
        string expectedFeeDescription = "feeDescription";
        string expectedGeometryPoiID = "8793be28-0d54-493f-8556-877e7ecbe937";
        List<Image> expectedImages =
        [
            new()
            {
                AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
        ];
        string expectedIsReservationRequired = "false";
        string expectedLatitude = "latitude";
        string expectedLocation = "location";
        string expectedLocationDescription =
            "The trail begins at Warm Creek picnic area and ends in Silver Gate, Montana.";
        string expectedLongDescription =
            "<p>The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana. Begin at Warm Creek picnic area, one mile west of the Northeast Entrance. This trail takes its name from the Bannock band of the Shoshone, who used this route to reach the buffalo grounds of the Great Plains. After crossing Soda Butte Creek, the terrain is mostly flat and the trail traverses open meadows and mixed conifer forests. You will reach the North Absaroka Wilderness approximately one mile (1.6 km) from the trailhead. At two miles (3.2 km) you come to Silver Gate, Montana. From here the road bed is used as a snowmobile route and is good skiing to Cooke City, 3 miles (4.8 km) to the east.</p>\\n\\n<p><b>Notes:</b> Bison and elk frequent this trail. Federal regulations require you to stay at least 100 yards (91 m) away from bears and wolves, and at least 25 yards (23 m) away from bison and all other wild animals.</p>\\n\\n<p>Check out the<a href=\\\"/thingstodo/yell-bannock-ski-trail.htm#Details\\\" id=\\\"CP___PAGEID=5744528,yell-bannock-ski-trail.htm#Details,30639|\\\"> ski trail details and accessibility information</a> at the bottom of this page.</p>";
        string expectedLongitude = "longitude";
        string expectedPetsDescription =
            "Qualified service animals are welcome throughout the park and in all park facilities. However, they must be leashed and under your control at all times. This trail requires a backcountry access pass for service animals.<br />\\n<br />\\n<br />\\n";
        List<JsonElement> expectedRelatedOrganizations =
        [
            JsonSerializer.Deserialize<JsonElement>("{}"),
        ];
        List<RelatedPark> expectedRelatedParks =
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
        ];
        double expectedRelevanceScore = 0;
        string expectedReservationDescription = "reservationDescription";
        List<string> expectedSeason = ["winter"];
        string expectedSeasonDescription = "seasonDescription";
        string expectedShortDescription =
            "The Bannock Ski Trail is a 2 mile (3.2 km) easy ski that follows the old road bed that once used to supply the mining town of Cooke City, Montana.";
        List<string> expectedTags = ["cross country skiing"];
        List<string> expectedTimeOfDay = ["Day"];
        string expectedTimeOfDayDescription = "timeOfDayDescription";
        string expectedTitle = "Bannock Ski Trail";
        List<Topic> expectedTopics =
        [
            new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" },
        ];
        string expectedUrl = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccessibilityInformation, deserialized.AccessibilityInformation);
        Assert.NotNull(deserialized.Activities);
        Assert.Equal(expectedActivities.Count, deserialized.Activities.Count);
        for (int i = 0; i < expectedActivities.Count; i++)
        {
            Assert.Equal(expectedActivities[i], deserialized.Activities[i]);
        }
        Assert.Equal(expectedActivityDescription, deserialized.ActivityDescription);
        Assert.Equal(expectedAge, deserialized.Age);
        Assert.Equal(expectedAgeDescription, deserialized.AgeDescription);
        Assert.Equal(expectedArePetsPermitted, deserialized.ArePetsPermitted);
        Assert.Equal(
            expectedArePetsPermittedwithRestrictions,
            deserialized.ArePetsPermittedwithRestrictions
        );
        Assert.Equal(expectedDoFeesApply, deserialized.DoFeesApply);
        Assert.Equal(expectedDuration, deserialized.Duration);
        Assert.Equal(expectedDurationDescription, deserialized.DurationDescription);
        Assert.Equal(expectedFeeDescription, deserialized.FeeDescription);
        Assert.Equal(expectedGeometryPoiID, deserialized.GeometryPoiID);
        Assert.NotNull(deserialized.Images);
        Assert.Equal(expectedImages.Count, deserialized.Images.Count);
        for (int i = 0; i < expectedImages.Count; i++)
        {
            Assert.Equal(expectedImages[i], deserialized.Images[i]);
        }
        Assert.Equal(expectedIsReservationRequired, deserialized.IsReservationRequired);
        Assert.Equal(expectedLatitude, deserialized.Latitude);
        Assert.Equal(expectedLocation, deserialized.Location);
        Assert.Equal(expectedLocationDescription, deserialized.LocationDescription);
        Assert.Equal(expectedLongDescription, deserialized.LongDescription);
        Assert.Equal(expectedLongitude, deserialized.Longitude);
        Assert.Equal(expectedPetsDescription, deserialized.PetsDescription);
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
        Assert.Equal(expectedRelevanceScore, deserialized.RelevanceScore);
        Assert.Equal(expectedReservationDescription, deserialized.ReservationDescription);
        Assert.NotNull(deserialized.Season);
        Assert.Equal(expectedSeason.Count, deserialized.Season.Count);
        for (int i = 0; i < expectedSeason.Count; i++)
        {
            Assert.Equal(expectedSeason[i], deserialized.Season[i]);
        }
        Assert.Equal(expectedSeasonDescription, deserialized.SeasonDescription);
        Assert.Equal(expectedShortDescription, deserialized.ShortDescription);
        Assert.NotNull(deserialized.Tags);
        Assert.Equal(expectedTags.Count, deserialized.Tags.Count);
        for (int i = 0; i < expectedTags.Count; i++)
        {
            Assert.Equal(expectedTags[i], deserialized.Tags[i]);
        }
        Assert.NotNull(deserialized.TimeOfDay);
        Assert.Equal(expectedTimeOfDay.Count, deserialized.TimeOfDay.Count);
        for (int i = 0; i < expectedTimeOfDay.Count; i++)
        {
            Assert.Equal(expectedTimeOfDay[i], deserialized.TimeOfDay[i]);
        }
        Assert.Equal(expectedTimeOfDayDescription, deserialized.TimeOfDayDescription);
        Assert.Equal(expectedTitle, deserialized.Title);
        Assert.NotNull(deserialized.Topics);
        Assert.Equal(expectedTopics.Count, deserialized.Topics.Count);
        for (int i = 0; i < expectedTopics.Count; i++)
        {
            Assert.Equal(expectedTopics[i], deserialized.Topics[i]);
        }
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataData
        {
            ID = "8B175753-D37B-4DD5-BF96-00383F7BB46C",
            AccessibilityInformation = "accessibilityInformation",
            Activities = [new() { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" }],
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
                    AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
            Topics = [new() { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" }],
            Url = "https://www.nps.gov/thingstodo/yell-bannock-ski-trail.htm",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataData { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AccessibilityInformation);
        Assert.False(model.RawData.ContainsKey("accessibilityInformation"));
        Assert.Null(model.Activities);
        Assert.False(model.RawData.ContainsKey("activities"));
        Assert.Null(model.ActivityDescription);
        Assert.False(model.RawData.ContainsKey("activityDescription"));
        Assert.Null(model.Age);
        Assert.False(model.RawData.ContainsKey("age"));
        Assert.Null(model.AgeDescription);
        Assert.False(model.RawData.ContainsKey("ageDescription"));
        Assert.Null(model.ArePetsPermitted);
        Assert.False(model.RawData.ContainsKey("arePetsPermitted"));
        Assert.Null(model.ArePetsPermittedwithRestrictions);
        Assert.False(model.RawData.ContainsKey("arePetsPermittedwithRestrictions"));
        Assert.Null(model.DoFeesApply);
        Assert.False(model.RawData.ContainsKey("doFeesApply"));
        Assert.Null(model.Duration);
        Assert.False(model.RawData.ContainsKey("duration"));
        Assert.Null(model.DurationDescription);
        Assert.False(model.RawData.ContainsKey("durationDescription"));
        Assert.Null(model.FeeDescription);
        Assert.False(model.RawData.ContainsKey("feeDescription"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsReservationRequired);
        Assert.False(model.RawData.ContainsKey("isReservationRequired"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Location);
        Assert.False(model.RawData.ContainsKey("location"));
        Assert.Null(model.LocationDescription);
        Assert.False(model.RawData.ContainsKey("locationDescription"));
        Assert.Null(model.LongDescription);
        Assert.False(model.RawData.ContainsKey("longDescription"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.PetsDescription);
        Assert.False(model.RawData.ContainsKey("petsDescription"));
        Assert.Null(model.RelatedOrganizations);
        Assert.False(model.RawData.ContainsKey("relatedOrganizations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.ReservationDescription);
        Assert.False(model.RawData.ContainsKey("reservationDescription"));
        Assert.Null(model.Season);
        Assert.False(model.RawData.ContainsKey("season"));
        Assert.Null(model.SeasonDescription);
        Assert.False(model.RawData.ContainsKey("seasonDescription"));
        Assert.Null(model.ShortDescription);
        Assert.False(model.RawData.ContainsKey("shortDescription"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.TimeOfDay);
        Assert.False(model.RawData.ContainsKey("timeOfDay"));
        Assert.Null(model.TimeOfDayDescription);
        Assert.False(model.RawData.ContainsKey("timeOfDayDescription"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Topics);
        Assert.False(model.RawData.ContainsKey("topics"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
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
            AccessibilityInformation = null,
            Activities = null,
            ActivityDescription = null,
            Age = null,
            AgeDescription = null,
            ArePetsPermitted = null,
            ArePetsPermittedwithRestrictions = null,
            DoFeesApply = null,
            Duration = null,
            DurationDescription = null,
            FeeDescription = null,
            GeometryPoiID = null,
            Images = null,
            IsReservationRequired = null,
            Latitude = null,
            Location = null,
            LocationDescription = null,
            LongDescription = null,
            Longitude = null,
            PetsDescription = null,
            RelatedOrganizations = null,
            RelatedParks = null,
            RelevanceScore = null,
            ReservationDescription = null,
            Season = null,
            SeasonDescription = null,
            ShortDescription = null,
            Tags = null,
            TimeOfDay = null,
            TimeOfDayDescription = null,
            Title = null,
            Topics = null,
            Url = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.AccessibilityInformation);
        Assert.False(model.RawData.ContainsKey("accessibilityInformation"));
        Assert.Null(model.Activities);
        Assert.False(model.RawData.ContainsKey("activities"));
        Assert.Null(model.ActivityDescription);
        Assert.False(model.RawData.ContainsKey("activityDescription"));
        Assert.Null(model.Age);
        Assert.False(model.RawData.ContainsKey("age"));
        Assert.Null(model.AgeDescription);
        Assert.False(model.RawData.ContainsKey("ageDescription"));
        Assert.Null(model.ArePetsPermitted);
        Assert.False(model.RawData.ContainsKey("arePetsPermitted"));
        Assert.Null(model.ArePetsPermittedwithRestrictions);
        Assert.False(model.RawData.ContainsKey("arePetsPermittedwithRestrictions"));
        Assert.Null(model.DoFeesApply);
        Assert.False(model.RawData.ContainsKey("doFeesApply"));
        Assert.Null(model.Duration);
        Assert.False(model.RawData.ContainsKey("duration"));
        Assert.Null(model.DurationDescription);
        Assert.False(model.RawData.ContainsKey("durationDescription"));
        Assert.Null(model.FeeDescription);
        Assert.False(model.RawData.ContainsKey("feeDescription"));
        Assert.Null(model.GeometryPoiID);
        Assert.False(model.RawData.ContainsKey("geometryPoiId"));
        Assert.Null(model.Images);
        Assert.False(model.RawData.ContainsKey("images"));
        Assert.Null(model.IsReservationRequired);
        Assert.False(model.RawData.ContainsKey("isReservationRequired"));
        Assert.Null(model.Latitude);
        Assert.False(model.RawData.ContainsKey("latitude"));
        Assert.Null(model.Location);
        Assert.False(model.RawData.ContainsKey("location"));
        Assert.Null(model.LocationDescription);
        Assert.False(model.RawData.ContainsKey("locationDescription"));
        Assert.Null(model.LongDescription);
        Assert.False(model.RawData.ContainsKey("longDescription"));
        Assert.Null(model.Longitude);
        Assert.False(model.RawData.ContainsKey("longitude"));
        Assert.Null(model.PetsDescription);
        Assert.False(model.RawData.ContainsKey("petsDescription"));
        Assert.Null(model.RelatedOrganizations);
        Assert.False(model.RawData.ContainsKey("relatedOrganizations"));
        Assert.Null(model.RelatedParks);
        Assert.False(model.RawData.ContainsKey("relatedParks"));
        Assert.Null(model.RelevanceScore);
        Assert.False(model.RawData.ContainsKey("relevanceScore"));
        Assert.Null(model.ReservationDescription);
        Assert.False(model.RawData.ContainsKey("reservationDescription"));
        Assert.Null(model.Season);
        Assert.False(model.RawData.ContainsKey("season"));
        Assert.Null(model.SeasonDescription);
        Assert.False(model.RawData.ContainsKey("seasonDescription"));
        Assert.Null(model.ShortDescription);
        Assert.False(model.RawData.ContainsKey("shortDescription"));
        Assert.Null(model.Tags);
        Assert.False(model.RawData.ContainsKey("tags"));
        Assert.Null(model.TimeOfDay);
        Assert.False(model.RawData.ContainsKey("timeOfDay"));
        Assert.Null(model.TimeOfDayDescription);
        Assert.False(model.RawData.ContainsKey("timeOfDayDescription"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
        Assert.Null(model.Topics);
        Assert.False(model.RawData.ContainsKey("topics"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataData
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            AccessibilityInformation = null,
            Activities = null,
            ActivityDescription = null,
            Age = null,
            AgeDescription = null,
            ArePetsPermitted = null,
            ArePetsPermittedwithRestrictions = null,
            DoFeesApply = null,
            Duration = null,
            DurationDescription = null,
            FeeDescription = null,
            GeometryPoiID = null,
            Images = null,
            IsReservationRequired = null,
            Latitude = null,
            Location = null,
            LocationDescription = null,
            LongDescription = null,
            Longitude = null,
            PetsDescription = null,
            RelatedOrganizations = null,
            RelatedParks = null,
            RelevanceScore = null,
            ReservationDescription = null,
            Season = null,
            SeasonDescription = null,
            ShortDescription = null,
            Tags = null,
            TimeOfDay = null,
            TimeOfDayDescription = null,
            Title = null,
            Topics = null,
            Url = null,
        };

        model.Validate();
    }
}

public class ActivityTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Activity { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" };

        string expectedID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C";
        string expectedName = "Skiing";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Activity { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Activity>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Activity { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Activity>(element);
        Assert.NotNull(deserialized);

        string expectedID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C";
        string expectedName = "Skiing";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Activity { ID = "F9B1D433-6B86-4804-AED7-B50A519A3B7C", Name = "Skiing" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Activity { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Activity { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Activity
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Activity
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
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
            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
        };

        string expectedAltText = "The Bannock Trail is a mostly flat through mature forest.";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        List<Crop> expectedCrops =
        [
            new()
            {
                Aspectratio = 3,
                Url =
                    "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
            },
        ];
        string expectedTitle = "title";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg";

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
            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Image>(element);
        Assert.NotNull(deserialized);

        string expectedAltText = "The Bannock Trail is a mostly flat through mature forest.";
        string expectedCaption = "caption";
        string expectedCredit = "credit";
        List<Crop> expectedCrops =
        [
            new()
            {
                Aspectratio = 3,
                Url =
                    "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
            },
        ];
        string expectedTitle = "title";
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg";

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
            AltText = "The Bannock Trail is a mostly flat through mature forest.",
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

public class CropTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Crop
        {
            Aspectratio = 3,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
        };

        long expectedAspectratio = 3;
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg";

        Assert.Equal(expectedAspectratio, model.Aspectratio);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Crop
        {
            Aspectratio = 3,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Crop>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Crop
        {
            Aspectratio = 3,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Crop>(element);
        Assert.NotNull(deserialized);

        long expectedAspectratio = 3;
        string expectedUrl =
            "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg";

        Assert.Equal(expectedAspectratio, deserialized.Aspectratio);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Crop
        {
            Aspectratio = 3,
            Url =
                "https://www.nps.gov/common/uploads/cropped_image/primary/20970C88-BB81-37F7-5FB606A6D4A87D9B.jpeg",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Crop { };

        Assert.Null(model.Aspectratio);
        Assert.False(model.RawData.ContainsKey("aspectratio"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Crop { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Crop
        {
            // Null should be interpreted as omitted for these properties
            Aspectratio = null,
            Url = null,
        };

        Assert.Null(model.Aspectratio);
        Assert.False(model.RawData.ContainsKey("aspectratio"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Crop
        {
            // Null should be interpreted as omitted for these properties
            Aspectratio = null,
            Url = null,
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
            Designation = "National Park",
            FullName = "Yellowstone National Park",
            Name = "Yellowstone",
            ParkCode = "yell",
            States = "ID,MT,WY",
            Url = "https://www.nps.gov/yell/index.htm",
        };

        string expectedDesignation = "National Park";
        string expectedFullName = "Yellowstone National Park";
        string expectedName = "Yellowstone";
        string expectedParkCode = "yell";
        string expectedStates = "ID,MT,WY";
        string expectedUrl = "https://www.nps.gov/yell/index.htm";

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
            Designation = "National Park",
            FullName = "Yellowstone National Park",
            Name = "Yellowstone",
            ParkCode = "yell",
            States = "ID,MT,WY",
            Url = "https://www.nps.gov/yell/index.htm",
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
            Designation = "National Park",
            FullName = "Yellowstone National Park",
            Name = "Yellowstone",
            ParkCode = "yell",
            States = "ID,MT,WY",
            Url = "https://www.nps.gov/yell/index.htm",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RelatedPark>(element);
        Assert.NotNull(deserialized);

        string expectedDesignation = "National Park";
        string expectedFullName = "Yellowstone National Park";
        string expectedName = "Yellowstone";
        string expectedParkCode = "yell";
        string expectedStates = "ID,MT,WY";
        string expectedUrl = "https://www.nps.gov/yell/index.htm";

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
            Designation = "National Park",
            FullName = "Yellowstone National Park",
            Name = "Yellowstone",
            ParkCode = "yell",
            States = "ID,MT,WY",
            Url = "https://www.nps.gov/yell/index.htm",
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

public class TopicTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Topic { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" };

        string expectedID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417";
        string expectedName = "Trails";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Topic { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Topic>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Topic { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Topic>(element);
        Assert.NotNull(deserialized);

        string expectedID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417";
        string expectedName = "Trails";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Topic { ID = "5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417", Name = "Trails" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Topic { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Topic { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Topic
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Topic
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Name = null,
        };

        model.Validate();
    }
}
