using System;
using Nps;

namespace Nps.Tests;

public class TestBase
{
    protected INationalParksApiClient client;

    public TestBase()
    {
        client = new NationalParksApiClient()
        {
            BaseUrl =
                Environment.GetEnvironmentVariable("TEST_API_BASE_URL") ?? "http://localhost:4010",
            ApiKey = "My API Key",
        };
    }
}
